Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frmMap
	Inherits System.Windows.Forms.Form
	
	Dim TreeViewX As AxComctlLib.AxTreeView
	Public MapX As Map
	Dim TileTop() As Tile
	Dim TileMiddle() As Tile
	Dim TileBottom() As Tile
	Dim blnClearTile As Boolean '[Titi] added for 2.4.8
	Dim Xcloned, Ycloned As Short '[Titi] added for 2.4.8 (copy three layers simultaneously)
	Dim XOutline, YOutline As Short
	Public MAJ As Short '[Titi] added for 2.4.8 (find tile)
	Dim blnFromCenterMap As Boolean '[Titi] added for 2.4.8 (set scrollbars when centering map)
	Dim bLeftRightScroll As Short ' [Titi 2.5.1] enable left/right scrolling
	Public TileNow As Tile '[Titi 2.4.9] made public
	Dim EncounterX As New Encounter
	Dim ItemX As Item
	
	' Stacks for Undo/Redo
	Dim TopTile() As Short
	Dim MiddleTile() As Short
	Dim BottomTile() As Short
	Dim EncPointer() As Short
	Dim UndoVisible() As Short
	Dim UndoTop, UndoBottom As Short
	Dim RedoTop As Short
	
	Dim XClick, YClick As Short
	'UPGRADE_NOTE: OnLoad was upgraded to OnLoad_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Dim OnLoad_Renamed As Short
	Dim PicSize As Double
	'UPGRADE_NOTE: TileList was upgraded to TileList_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Dim TileList_Renamed() As TileList
	Dim MouseButton As Short
	'UPGRADE_NOTE: MouseDown was upgraded to MouseDown_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Dim MouseDown_Renamed As Short
	
	' For painting the map
	Dim MapScale As Double
	Dim TileWidth As Short
	Dim TileHeight As Short
	Dim PaintTool As Short
	Public PaintLevel As Short
	Dim LastTool As Short
	Dim LastLevel As Short
	Const bdToolPaint As Short = 0
	Const bdToolFill As Short = 1
	Const bdToolErase As Short = 2
	Const bdToolZoomIn As Short = 3
	Const bdToolDropper As Short = 4
	Const bdToolHand As Short = 5 ' [Titi 2.4.8] selects all three tiles
	Const bdToolZoomOut As Short = 6
	Const bdToolEyeOpen As Short = 7
	Const bdToolEyeClosed As Short = 8
	Const bdToolClone As Short = 9 ' [Titi 2.4.8] pastes all three tiles
	
	Const bdLevelTop As Short = 0
	Const bdLevelMiddle As Short = 1
	Const bdLevelBottom As Short = 2
	Const bdLevelEncounter As Short = 3
	
	Const bdDrawBottom As Short = 1
	Const bdDrawMiddle As Short = 2
	Const bdDrawTop As Short = 3
	Const bdEraseAll As Short = 4
	
	' For drawing the map
	Const bdMapBottom As Short = 0
	Const bdMapMiddle As Short = 1
	Const bdMapItems As Short = 2
	Const bdMapMonsters As Short = 3
	Const bdMapParty As Short = 4
	Const bdMapDoors As Short = 5
	Const bdMapTop As Short = 6
	Const bdMapDim As Short = 7
	Const bdMapEnc As Short = 8
	Const bdSideLeft As Short = 1
	Const bdSideTop As Short = 2
	Const bdSideRight As Short = 4
	Const bdSideFirstBottom As Short = 8
	Const bdSideSecondBottom As Short = 16
	Const bdTileEncYellow As Short = -5
	Const bdTileFlatGray As Short = -4
	Const bdTileDarkGray As Short = -3
	Const bdTileGray As Short = -2
	Const bdTileBlack As Short = -1
	Const bdTileHighlightTop As Short = -6
	Const bdTileHighlightBottom As Short = -7
	Const bdTileHighlightMiddle As Short = -8
	
	Public Sub CenterMap(ByRef XMap As Short, ByRef YMap As Short)
		Dim oErr As Object
		On Error GoTo ErrorHandler
		blnFromCenterMap = True
		MapX.Left_Renamed = XMap + 2
		MapX.Top = YMap - Int(System.Math.Sqrt((picMap.ClientRectangle.Width ^ 2) + (picMap.ClientRectangle.Height ^ 2)) / 108) + 1
		' [Titi 2.4.8] set the scrollbars to the correct values after the map is centered
		hsbMap.Value = Greatest(Int((MapX.Left_Renamed + MapX.Top + 3) / 2), 0)
		vsbMap.Value = Greatest(Int((MapX.Top - MapX.Left_Renamed + 1 + MapX.Width) / 2), 0)
		blnFromCenterMap = False
		Exit Sub
ErrorHandler: 
		' [Titi 2.4.9]
		If Err.Number = 380 Then ' cannot update the scroll values.
			Resume Next
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object oErr.logError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			oErr.logError("CenterMap (#" & Err.Number & ")")
		End If
	End Sub
	
	Private Sub AddUndo()
		Dim X, Y As Short
		Static UndoCycle As Short
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		UndoTop = LoopNumber(0, 15, UndoTop, 1)
		RedoTop = UndoTop
		If UndoTop = 0 Then
			UndoBottom = 0
			UndoCycle = True
		ElseIf UndoCycle = True Then 
			UndoBottom = LoopNumber(0, 15, UndoTop, 1)
		End If
		For X = 0 To MapX.Width : For Y = 0 To MapX.Height
				TopTile(UndoTop, X, Y) = MapX.TopTile(X, Y)
				MiddleTile(UndoTop, X, Y) = MapX.MiddleTile(X, Y)
				BottomTile(UndoTop, X, Y) = MapX.BottomTile(X, Y)
				EncPointer(UndoTop, X, Y) = MapX.EncPointer(X, Y)
				UndoVisible(UndoTop, X, Y) = MapX.Visible(X, Y)
			Next Y : Next X
		btnRedo.Enabled = False
		btnUndo.Enabled = True
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub ApplyUndo()
		Dim X, Y As Short
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		UndoTop = LoopNumber(0, 15, UndoTop, -1)
		For X = 0 To MapX.Width : For Y = 0 To MapX.Height
				MapX.TopTile(X, Y) = TopTile(UndoTop, X, Y)
				MapX.MiddleTile(X, Y) = MiddleTile(UndoTop, X, Y)
				MapX.BottomTile(X, Y) = BottomTile(UndoTop, X, Y)
				MapX.EncPointer(X, Y) = EncPointer(UndoTop, X, Y)
				MapX.Visible(X, Y) = UndoVisible(UndoTop, X, Y)
			Next Y : Next X
		btnRedo.Enabled = True
		If UndoTop = UndoBottom Then
			btnUndo.Enabled = False
		End If
		DrawMap()
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub ApplyRedo()
		Dim X, Y As Short
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		UndoTop = LoopNumber(0, 15, UndoTop, 1)
		For X = 0 To MapX.Width : For Y = 0 To MapX.Height
				MapX.TopTile(X, Y) = TopTile(UndoTop, X, Y)
				MapX.MiddleTile(X, Y) = MiddleTile(UndoTop, X, Y)
				MapX.BottomTile(X, Y) = BottomTile(UndoTop, X, Y)
				MapX.EncPointer(X, Y) = EncPointer(UndoTop, X, Y)
				MapX.Visible(X, Y) = UndoVisible(UndoTop, X, Y)
			Next Y : Next X
		If UndoTop = RedoTop Then
			btnRedo.Enabled = False
		End If
		btnUndo.Enabled = True
		DrawMap()
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
	End Sub
	
	Public Sub SetTileList()
		Dim c, i As Short
		Dim TileX As Tile
		'UPGRADE_NOTE: Height was upgraded to Height_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Height_Renamed As Short
		' Populate array of tiles which map TileSet selected
		c = -1
		For	Each TileX In MapX.Tiles
			If TileX.TileSet = VB6.GetItemData(cmbTileSet, cmbTileSet.SelectedIndex) Or VB6.GetItemData(cmbTileSet, cmbTileSet.SelectedIndex) = 0 Then
				c = c + 1
			End If
		Next TileX
		If c < 0 Then
			vsbTiles.Maximum = (0 + vsbTiles.LargeChange - 1)
			vsbTiles.Enabled = False
			picTiles.Enabled = False
			'UPGRADE_ISSUE: PictureBox method picTiles.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picTiles.Cls()
		Else
			vsbTiles.Maximum = (c + vsbTiles.LargeChange - 1)
			vsbTiles.Enabled = True
			picTiles.Enabled = True
			'UPGRADE_NOTE: TileList was upgraded to TileList_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			ReDim TileList_Renamed(c)
			ReDim Preserve TileTop(MapX.Width, MapX.Height)
			ReDim Preserve TileMiddle(MapX.Width, MapX.Height)
			ReDim Preserve TileBottom(MapX.Width, MapX.Height)
			frmProject.LoadMapPic(MapX, 1)
			'        Height = (frmProject.picMap(MapX.Pic).Height / 72) / 2
			Height_Renamed = (VB6.PixelsToTwipsY(frmProject.picMap(MapX.Pic).Height) / 72) / 3
			c = 0
			For	Each TileX In MapX.Tiles
				If TileX.TileSet = VB6.GetItemData(cmbTileSet, cmbTileSet.SelectedIndex) Or VB6.GetItemData(cmbTileSet, cmbTileSet.SelectedIndex) = 0 Then
					TileList_Renamed(c).TileX = TileX
					TileList_Renamed(c).X = 96 * Int(TileX.Pic / Height_Renamed)
					TileList_Renamed(c).Y = 72 * (TileX.Pic Mod Height_Renamed)
					c = c + 1
				End If
			Next TileX
			YClick = 0
			ListTiles()
		End If
	End Sub
	
	Private Sub FloodFill(ByRef AtX As Short, ByRef AtY As Short)
		Dim p(MapX.Width, MapX.Height) As Short
		Dim px(CDbl(MapX.Width) * CDbl(MapX.Height)) As Short
		Dim py(CDbl(MapX.Width) * CDbl(MapX.Height)) As Short
		Dim StackIndex As Integer
		Dim OldMiddle, OldTop, OldBottom As Short
		Dim X, c, dx, dy, i, Y As Short
		' Capture matching Tile
		OldTop = MapX.TopTile(AtX, AtY)
		OldMiddle = MapX.MiddleTile(AtX, AtY)
		OldBottom = MapX.BottomTile(AtX, AtY)
		' Starting at AtX, AtY, find the flood area
		StackIndex = 0
		px(StackIndex) = AtX : py(StackIndex) = AtY
		Do 
			X = px(StackIndex) : Y = py(StackIndex)
			If ((MapX.TopTile(X, Y) = OldTop And PaintLevel = bdLevelTop And MapX.TopTile(X, Y) <> TileNow.Index) Or (MapX.MiddleTile(X, Y) = OldMiddle And PaintLevel = bdLevelMiddle And MapX.MiddleTile(X, Y) <> TileNow.Index) Or (MapX.BottomTile(X, Y) = OldBottom And PaintLevel = bdLevelBottom And MapX.BottomTile(X, Y) <> TileNow.Index)) Then
				Select Case PaintLevel
					Case bdLevelTop
						MapX.TopTile(X, Y) = TileNow.Index
						MapX.TopFlip(X, Y) = TileNow.Flip
					Case bdLevelMiddle
						MapX.MiddleTile(X, Y) = TileNow.Index
						MapX.MiddleFlip(X, Y) = TileNow.Flip
					Case bdLevelBottom
						MapX.BottomTile(X, Y) = TileNow.Index
						MapX.BottomFlip(X, Y) = TileNow.Flip
				End Select
				MapX.Hidden(X, Y) = True
				' Mark as filled
				p(X, Y) = 1
				' Que all other directions
				For c = 0 To 3
					Select Case c
						Case 0
							dx = 0 : dy = -1
						Case 1
							dx = 1 : dy = 0
						Case 2
							dx = 0 : dy = 1
						Case 3
							dx = -1 : dy = 0
					End Select
					If IsBetween(X + dx, 0, MapX.Width) And IsBetween(Y + dy, 0, MapX.Height) Then
						If p(X + dx, Y + dy) < 1 Then
							px(StackIndex) = X + dx
							py(StackIndex) = Y + dy
							StackIndex = StackIndex + 1
						End If
					End If
				Next c
			End If
			StackIndex = StackIndex - 1
		Loop Until StackIndex < 0
	End Sub
	
	Private Sub EditEncounter(ByRef AtX As Short, ByRef AtY As Short, Optional ByRef Shift As Short = 0)
		Dim X, XMap, YMap, Y As Short
		Dim EntryPointX As EntryPoint
		Dim Found As Boolean
		Dim EncounterX As Encounter
		SetMapCursor(AtX, AtY, (MapX.Left_Renamed), (MapX.Top), X, Y, XMap, YMap)
		' If cursor is outside map boundaries, then exit
		If XMap < 0 Or XMap > MapX.Width Or YMap < 0 Or YMap > MapX.Height Then
			Exit Sub
		End If
		' Check if Encounter exists when click
		If MapX.EncPointer(XMap, YMap) > 0 Then
			TreeViewX.SelectedItem = TreeViewX.Nodes("M" & MapX.Index & "EncountersE" & MapX.EncPointer(XMap, YMap))
			frmMDI.SetupMenu((frmProject.AreaList), TreeViewX, "M" & MapX.Index & "EncountersE" & MapX.EncPointer(XMap, YMap))
			'UPGRADE_ISSUE: MDIForm method frmMDI.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			frmMDI.PopupMenu(frmMDI.mnuEdit)
			Found = True
		Else ' [Titi 2.6.0] check if EntryPoint exists
			For	Each EntryPointX In MapX.EntryPoints
				If EntryPointX.MapX = XMap And EntryPointX.MapY = YMap Then
					TreeViewX.SelectedItem = TreeViewX.Nodes("M" & MapX.Index & "EntryPointsP" & EntryPointX.Index)
					frmMDI.SetupMenu((frmProject.AreaList), TreeViewX, "M" & MapX.Index & "EntryPointsP" & EntryPointX.Index)
					'UPGRADE_ISSUE: MDIForm method frmMDI.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					frmMDI.PopupMenu(frmMDI.mnuEdit)
					Found = True
					Exit For
				End If
			Next EntryPointX
		End If
		If Not Found Then
			' [Titi 2.6.0] if nothing, right-click will create a new entrypoint (encounter if Shift-Right-Click)
			If Shift = 1 Then
				' new encounter
				TreeViewX.SelectedItem = TreeViewX.Nodes("M" & MapX.Index & "Encounters")
				frmMDI.EditAdd(TreeViewX.SelectedItem.Tag, bdEditEncounter)
				'UPGRADE_WARNING: Couldn't resolve default property of object MapX.Encounters.Item().Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				EncounterX = frmMDI.ObjectListX.Item(TreeViewX.SelectedItem.Tag & "E" & MapX.Encounters.Item(MapX.Encounters.Count()).Index)
				MapX.EncPointer(XMap, YMap) = EncounterX.Index
				frmMDI.ActiveMDIChild.Close()
				'UPGRADE_WARNING: Couldn't resolve default property of object MapX.Encounters.Item().Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object frmMDI.ObjectListX().Copy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				frmMDI.ObjectListX.Item(TreeViewX.SelectedItem.Tag & "E" & MapX.Encounters.Item(MapX.Encounters.Count()).Index).Copy(EncounterX)
				'UPGRADE_WARNING: Couldn't resolve default property of object MapX.Encounters.Item().Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				frmMDI.EditProperties(TreeViewX.SelectedItem.Tag & "E" & MapX.Encounters.Item(MapX.Encounters.Count()).Index)
			Else
				TreeViewX.SelectedItem = TreeViewX.Nodes("M" & MapX.Index & "EntryPoints")
				frmMDI.EditAdd(TreeViewX.SelectedItem.Tag, bdEditEntryPoint)
				'UPGRADE_WARNING: Couldn't resolve default property of object MapX.EntryPoints.Item().Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				EntryPointX = frmMDI.ObjectListX.Item(TreeViewX.SelectedItem.Tag & "P" & MapX.EntryPoints.Item(MapX.EntryPoints.Count()).Index)
				EntryPointX.MapX = XMap
				EntryPointX.MapY = YMap
				frmMDI.ActiveMDIChild.Close()
				'UPGRADE_WARNING: Couldn't resolve default property of object MapX.EntryPoints.Item().Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object frmMDI.ObjectListX().Copy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				frmMDI.ObjectListX.Item(TreeViewX.SelectedItem.Tag & "P" & MapX.EntryPoints.Item(MapX.EntryPoints.Count()).Index).Copy(EntryPointX)
				'UPGRADE_WARNING: Couldn't resolve default property of object MapX.EntryPoints.Item().Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				frmMDI.EditProperties(TreeViewX.SelectedItem.Tag & "P" & MapX.EntryPoints.Item(MapX.EntryPoints.Count()).Index)
			End If
		End If
	End Sub
	
	Private Sub PaintTile(ByRef AtX As Short, ByRef AtY As Short)
		'UPGRADE_NOTE: Size was upgraded to Size_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim YMap, XMap, Size_Renamed As Short
		Dim YY, c, X, Y, XX, Found As Short
		SetMapCursor(AtX, AtY, (MapX.Left_Renamed), (MapX.Top), X, Y, XMap, YMap)
		' If cursor is outside map boundaries, then exit
		If XMap < 0 Or XMap > MapX.Width Or YMap < 0 Or YMap > MapX.Height Then
			Exit Sub
		End If
		' If no tiles in palette, then exit
		If vsbTiles.Enabled = False Then
			Exit Sub
		End If
		' If Tool is flood fill, dropper, zoomin, zoomout, then here
		Select Case PaintTool
			Case bdToolFill
				If PaintLevel <> bdLevelEncounter Then
					'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
					System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
					FloodFill(XMap, YMap)
					DrawMap()
					'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
					System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
					Exit Sub
				End If
			Case bdToolDropper
				If PaintLevel <> bdLevelEncounter Then
					Select Case PaintLevel
						Case bdLevelTop
							c = MapX.TopTile(XMap, YMap)
						Case bdLevelMiddle
							c = MapX.MiddleTile(XMap, YMap)
						Case bdLevelBottom
							c = MapX.BottomTile(XMap, YMap)
					End Select
					' Find Tile in TileList
					For XX = 0 To UBound(TileList_Renamed)
						If TileList_Renamed(XX).TileX.Index = c Then
							vsbTiles.Value = XX
							YClick = 0
							SetSelectBox()
							Exit For
						End If
					Next XX
					Exit Sub
				End If
			Case bdToolHand ' copies the three layers
				Xcloned = XMap
				Ycloned = YMap
				Size_Renamed = 0
				If optBrushSize(2).Checked = True Then
					Size_Renamed = 2
				ElseIf optBrushSize(1).Checked = True Then 
					Size_Renamed = 1
				End If
				For XX = Greatest(XMap - Size_Renamed, 0) To Least(XMap + Size_Renamed, (MapX.Width))
					For YY = Greatest(YMap - Size_Renamed, 0) To Least(YMap + Size_Renamed, (MapX.Height))
						If PaintLevel <> bdLevelEncounter Then
							optTool(9).Enabled = True
							If MapX.TopTile(XX, YY) <> 0 Then
								TileTop(XX, YY) = New Tile
								TileTop(XX, YY).Index = MapX.TopTile(XX, YY)
								TileTop(XX, YY).Flip = MapX.TopFlip(XX, YY)
							End If
							If MapX.MiddleTile(XX, YY) <> 0 Then
								TileMiddle(XX, YY) = New Tile
								TileMiddle(XX, YY).Index = MapX.MiddleTile(XX, YY)
								TileMiddle(XX, YY).Flip = MapX.MiddleFlip(XX, YY)
							End If
							If MapX.BottomTile(XX, YY) <> 0 Then
								TileBottom(XX, YY) = New Tile
								TileBottom(XX, YY).Index = MapX.BottomTile(XX, YY)
								TileBottom(XX, YY).Flip = MapX.BottomFlip(XX, YY)
							End If
						End If
					Next YY
				Next XX
				Exit Sub
			Case bdToolZoomIn
				'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
				If MapScale = 0.125 Then
					MapScale = 0.25
				Else
					MapScale = MapScale + 0.25
				End If
				If MapScale > 1 Then
					MapScale = 1
				End If
				SetMapScale(MapScale)
				frmProject.LoadMapPic(MapX, MapScale)
				CenterMap(XMap, YMap)
				DrawMap()
				ListTiles()
				'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
				Exit Sub
			Case bdToolZoomOut
				'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
				MapScale = MapScale - 0.25
				If MapScale < 0.25 Then
					MapScale = 0.125
				End If
				SetMapScale(MapScale)
				frmProject.LoadMapPic(MapX, MapScale)
				CenterMap(XMap, YMap)
				DrawMap()
				ListTiles()
				'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
				Exit Sub
		End Select
		' If you get this far, you are painting on the map
		frmMDI.Dirty = True
		' Set Brush Size
		Size_Renamed = 0
		If optBrushSize(2).Checked = True Then
			Size_Renamed = 2
		ElseIf optBrushSize(1).Checked = True Then 
			Size_Renamed = 1
		End If
		' Paint Tile
		For XX = Greatest(XMap - Size_Renamed, 0) To Least(XMap + Size_Renamed, (MapX.Width)) : For YY = Greatest(YMap - Size_Renamed, 0) To Least(YMap + Size_Renamed, (MapX.Height))
				If PaintLevel = bdLevelEncounter Then
					Select Case PaintTool
						Case bdToolPaint
							MapX.EncPointer(XX, YY) = EncounterX.Index
							For c = 0 To lstEncCreatures.Items.Count - 1
								If lstEncCreatures.GetItemChecked(c) = True Then
									'UPGRADE_WARNING: Couldn't resolve default property of object EncounterX.Creatures().MapX. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
									EncounterX.Creatures.Item("X" & VB6.GetItemData(lstEncCreatures, c)).MapX = XX
									'UPGRADE_WARNING: Couldn't resolve default property of object EncounterX.Creatures().MapY. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
									EncounterX.Creatures.Item("X" & VB6.GetItemData(lstEncCreatures, c)).MapY = YY
									'UPGRADE_WARNING: Couldn't resolve default property of object EncounterX.Creatures(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
									PositionCreatureSpot(EncounterX, EncounterX.Creatures.Item("X" & VB6.GetItemData(lstEncCreatures, c)))
								End If
							Next c
							For c = 0 To lstEncItems.Items.Count - 1
								If lstEncItems.GetItemChecked(c) = True Then
									'UPGRADE_WARNING: Couldn't resolve default property of object EncounterX.Items().MapX. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
									EncounterX.Items.Item("I" & VB6.GetItemData(lstEncItems, c)).MapX = XX
									'UPGRADE_WARNING: Couldn't resolve default property of object EncounterX.Items().MapY. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
									EncounterX.Items.Item("I" & VB6.GetItemData(lstEncItems, c)).MapY = YY
									'UPGRADE_WARNING: Couldn't resolve default property of object EncounterX.Items(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
									PositionItemSpot(EncounterX, EncounterX.Items.Item("I" & VB6.GetItemData(lstEncItems, c)))
								End If
							Next c
						Case bdToolErase
							MapX.EncPointer(XX, YY) = 0
					End Select
				Else
					MapX.Hidden(XX, YY) = True
					Select Case PaintTool
						Case bdToolPaint
							Select Case PaintLevel
								Case bdLevelTop
									MapX.TopTile(XX, YY) = TileNow.Index
									MapX.TopFlip(XX, YY) = TileNow.Flip
								Case bdLevelMiddle
									MapX.MiddleTile(XX, YY) = TileNow.Index
									MapX.MiddleFlip(XX, YY) = TileNow.Flip
								Case bdLevelBottom
									MapX.BottomTile(XX, YY) = TileNow.Index
									MapX.BottomFlip(XX, YY) = TileNow.Flip
							End Select
						Case bdToolFill
						Case bdToolDropper
						Case bdToolClone
							' [Titi 2.4.8]
							If PaintLevel <> bdLevelEncounter Then
								If (XX + Xcloned - XMap >= 0 And XX + Xcloned - XMap <= MapX.Width) And (YY + Ycloned - YMap >= 0 And YY + Ycloned - YMap <= MapX.Height) Then
									If Not (TileTop(XX + Xcloned - XMap, YY + Ycloned - YMap) Is Nothing) Then
										MapX.TopTile(XX, YY) = TileTop(XX + Xcloned - XMap, YY + Ycloned - YMap).Index
										MapX.TopFlip(XX, YY) = TileTop(XX + Xcloned - XMap, YY + Ycloned - YMap).Flip
									End If
									If Not (TileMiddle(XX + Xcloned - XMap, YY + Ycloned - YMap) Is Nothing) Then
										MapX.MiddleTile(XX, YY) = TileMiddle(XX + Xcloned - XMap, YY + Ycloned - YMap).Index
										MapX.MiddleFlip(XX, YY) = TileMiddle(XX + Xcloned - XMap, YY + Ycloned - YMap).Flip
									End If
									If Not (TileBottom(XX + Xcloned - XMap, YY + Ycloned - YMap) Is Nothing) Then
										MapX.BottomTile(XX, YY) = TileBottom(XX + Xcloned - XMap, YY + Ycloned - YMap).Index
										MapX.BottomFlip(XX, YY) = TileBottom(XX + Xcloned - XMap, YY + Ycloned - YMap).Flip
									End If
									If blnClearTile Then
										'UPGRADE_NOTE: Object TileTop() may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
										TileTop(XX + Xcloned - XMap, YY + Ycloned - YMap) = Nothing
										'UPGRADE_NOTE: Object TileMiddle() may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
										TileMiddle(XX + Xcloned - XMap, YY + Ycloned - YMap) = Nothing
										'UPGRADE_NOTE: Object TileBottom() may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
										TileBottom(XX + Xcloned - XMap, YY + Ycloned - YMap) = Nothing
										optTool(9).Checked = False
										optTool(9).Enabled = False
									End If
								End If
							End If
						Case bdToolErase
							If chkTileShow(0).CheckState = 1 Then
								MapX.TopTile(XX, YY) = 0
								MapX.TopFlip(XX, YY) = 0
							End If
							If chkTileShow(1).CheckState = 1 Then
								MapX.MiddleTile(XX, YY) = 0
								MapX.MiddleFlip(XX, YY) = 0
							End If
							If chkTileShow(2).CheckState = 1 Then
								MapX.BottomTile(XX, YY) = 0
								MapX.BottomFlip(XX, YY) = 0
							End If
						Case bdToolEyeOpen
							MapX.Hidden(XX, YY) = False
						Case bdToolEyeClosed
							MapX.Hidden(XX, YY) = True
					End Select
				End If
			Next YY : Next XX
		DrawMapRegion(Y - (TileHeight / 3) * (Size_Renamed + 3), X - 96 * Size_Renamed, Y + (TileHeight / 3) * (Size_Renamed * 3 + 2), X + 96 * (Size_Renamed + 1))
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
	End Sub
	
	Public Sub FindTile(Optional ByRef EntryPointX As EntryPoint = Nothing)
		Dim X, Y As Short
		Dim sMsg As String
		Dim AtX, AtY, c As Short
		If Not EntryPointX Is Nothing Then
			TileNow.Index = MapX.BottomTile(EntryPointX.MapX, EntryPointX.MapY)
			AtY = EntryPointX.MapY + 1 + MapX.Left_Renamed - MapX.Top - EntryPointX.MapX
			AtX = EntryPointX.MapX + Int(AtY / 2) - MapX.Left_Renamed
			DrawTile(AtX, AtY, 0)
			XClick = EntryPointX.MapX
			YClick = EntryPointX.MapY
			PlotCursor()
			Exit Sub
		End If
		DrawMap()
		sMsg = "Found " & TileNow.Name
		For c = 0 To UBound(TileList_Renamed)
			If TileNow.Index = TileList_Renamed(c).TileX.Index Then Exit For
		Next 
		YOutline = TileList_Renamed(c).Y
		For X = 0 To MapX.Width
			For Y = 0 To MapX.Height
				' convert map coordinates into values valid for DrawTile()
				' AtX is a Pixel / (TileWidth / 2), AtY is Pixel / (TileHeight / 3)
				AtY = Y + 1 + MapX.Left_Renamed - MapX.Top - X
				AtX = X + Int(AtY / 2) - MapX.Left_Renamed
				If MapX.TopTile(X, Y) = TileNow.Index Then
					sMsg = sMsg & vbLf & "At (" & X & "," & Y & ") on top layer"
					MAJ = bdTileHighlightTop
					If MapX.TopFlip(X, Y) = True Then
						XOutline = System.Math.Abs(frmProject.picOutline.Width - 96 * (TileList_Renamed(c).X / 96) - 96)
					Else
						XOutline = TileList_Renamed(c).X
					End If
					YOutline = TileList_Renamed(c).Y
					DrawTile(AtX, AtY, 0)
				End If
				If MapX.MiddleTile(X, Y) = TileNow.Index Then
					sMsg = sMsg & vbLf & "At (" & X & "," & Y & ") on middle layer"
					MAJ = bdTileHighlightMiddle
					If MapX.MiddleFlip(X, Y) = True Then
						XOutline = System.Math.Abs(frmProject.picOutline.Width - 96 * (TileList_Renamed(c).X / 96) - 96)
					Else
						XOutline = TileList_Renamed(c).X
					End If
					YOutline = TileList_Renamed(c).Y
					DrawTile(AtX, AtY, 0)
				End If
				If MapX.BottomTile(X, Y) = TileNow.Index Then
					sMsg = sMsg & vbLf & "At (" & X & "," & Y & ") on bottom layer"
					MAJ = bdTileHighlightBottom
					If MapX.BottomFlip(X, Y) = True Then
						XOutline = System.Math.Abs(frmProject.picOutline.Width - 96 * (TileList_Renamed(c).X / 96) - 96)
					Else
						XOutline = TileList_Renamed(c).X
					End If
					YOutline = TileList_Renamed(c).Y
					DrawTile(AtX, AtY, 0)
				End If
			Next 
		Next 
		' [Titi 2.6.0] RT 480 if tileset too large
		'UPGRADE_ISSUE: PictureBox property picMap.AutoRedraw was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If picMap.AutoRedraw = False Then
			MsgBox("The tileset (" & MapX.PictureFile & ") is too large and the action cannot be completed." & vbCrLf & "Green outlines will not be displayed...")
			'UPGRADE_ISSUE: PictureBox property picMap.AutoRedraw was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picMap.AutoRedraw = True
		End If
		picMap.Refresh()
		' [Titi 2.5.1] Changed the message if no tiles found
		If sMsg = "Found " & TileNow.Name Then sMsg = TileNow.Name & " not used in this map."
		MsgBox(sMsg)
		MAJ = 0
	End Sub
	
	Private Sub SetPaintMode()
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		' Repaint screen if needed
		If LastLevel = bdLevelEncounter And PaintLevel <> bdLevelEncounter Then
			'        Screen.MousePointer = 11
			picTiles.Visible = True
			vsbTiles.Visible = True
			cmbTileSet.BringToFront()
			lstEncCreatures.Visible = False
			lstEncItems.Visible = False
			DrawMap()
			'        Screen.MousePointer = 0
		ElseIf PaintLevel = bdLevelEncounter And LastLevel <> bdLevelEncounter Then 
			'        Screen.MousePointer = 11
			picTiles.Visible = False
			vsbTiles.Visible = False
			cmbEncounters.BringToFront()
			ListEncounters()
			lstEncCreatures.Visible = True
			lstEncItems.Visible = True
			DrawMap()
			'        Screen.MousePointer = 0
		ElseIf ((LastTool <> bdToolEyeClosed And LastTool <> bdToolEyeOpen) And (PaintTool = bdToolEyeClosed Or PaintTool = bdToolEyeOpen)) Or ((LastTool = bdToolEyeClosed Or LastTool = bdToolEyeOpen) And (PaintTool <> bdToolEyeClosed And PaintTool <> bdToolEyeOpen)) Then 
			'        Screen.MousePointer = 11
			DrawMap()
			'        Screen.MousePointer = 0
		End If
		LastTool = PaintTool
		LastLevel = PaintLevel
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
	End Sub
	
	Public Sub SetSelectBox() ' [Titi 2.4.9] made it public
		Dim c As Short
		If XClick > shpSelect.Width And PaintTool <> bdToolDropper Then Exit Sub '[Titi 2.4.9a] don't reset the box if the click is outside of the tiles list! [Titi 2.4.9b] however select active tile if EyeDropper is on
		' Set select box
		If vsbTiles.Value + Int(YClick / 72) > (vsbTiles.Maximum - vsbTiles.LargeChange + 1) Then
			c = ((vsbTiles.Maximum - vsbTiles.LargeChange + 1) - vsbTiles.Value) * 72 + 1
			TileNow = TileList_Renamed((c - 1) / 72).TileX
		Else
			c = Int(YClick / 72) * 72 + 1
			TileNow = TileList_Renamed(vsbTiles.Value + Int(YClick / 72)).TileX
		End If
		shpSelect.Top = c
	End Sub
	
	Public Sub ListTiles()
		Dim rc, c, i As Short
		'UPGRADE_NOTE: Height was upgraded to Height_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Height_Renamed, X As Short
		' If no tiles to list, then exit
		If (vsbTiles.Maximum - vsbTiles.LargeChange + 1) = 0 Then
			Exit Sub
		End If
		'UPGRADE_ISSUE: PictureBox method picTiles.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picTiles.Cls()
		' List Tiles in current TileSet()
		i = 0
		frmProject.LoadMapPic(MapX, 1)
		For c = vsbTiles.Value To Least(vsbTiles.Value + (picTiles.Height / 72), ((vsbTiles.Maximum - vsbTiles.LargeChange + 1)))
			'        Height = (frmProject.picMap(MapX.Pic).Height / 2)
			' [Titi 2.4.8] added another set of tiles, for green outline
			Height_Renamed = (VB6.PixelsToTwipsY(frmProject.picMap(MapX.Pic).Height) / 3)
			If TileList_Renamed(c).TileX.Flip = True Then
				X = System.Math.Abs((VB6.PixelsToTwipsX(frmProject.picMap(MapX.Pic).Width) - 96 * (TileList_Renamed(c).X / 96) - 96) * TileList_Renamed(c).TileX.Flip)
			Else
				X = TileList_Renamed(c).X
			End If
			'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			'UPGRADE_ISSUE: PictureBox property picTiles.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			rc = BitBlt(picTiles.hdc, 3, 72 * i, 96, 72, frmProject.picMap(MapX.Pic).hdc, X, Height_Renamed + TileList_Renamed(c).Y, SRCAND)
			'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			'UPGRADE_ISSUE: PictureBox property picTiles.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			rc = BitBlt(picTiles.hdc, 3, 72 * i, 96, 72, frmProject.picMap(MapX.Pic).hdc, X, TileList_Renamed(c).Y, SRCPAINT)
			i = i + 1
		Next c
		picTiles.Refresh()
		SetSelectBox()
	End Sub
	
	Public Sub ListEncounters()
		Dim EncounterX As Encounter
		' [Titi 2.4.9b] except if chosen directly from the dropdown list!
		If MAJ = False Then
			cmbEncounters.Items.Clear()
			For	Each EncounterX In MapX.Encounters
				cmbEncounters.Items.Add(New VB6.ListBoxItem(EncounterX.Name, EncounterX.Index))
			Next EncounterX
			If cmbEncounters.Items.Count > 0 And cmbEncounters.SelectedIndex < 0 Then
				cmbEncounters.SelectedIndex = 0
			End If
		End If
		MAJ = False
	End Sub
	
	Private Sub ListEncThings(ByRef InEncounter As Encounter)
		Dim c As Short
		Dim CreatureX As Creature
		Dim ItemZ As Item
		' Set new encounter
		EncounterX = InEncounter
		' List Creatures and Load Pictures
		lstEncCreatures.Items.Clear()
		For	Each CreatureX In EncounterX.Creatures
			lstEncCreatures.Items.Add(New VB6.ListBoxItem(CreatureX.Name, CreatureX.Index))
			frmProject.LoadCreaturePic(CreatureX)
		Next CreatureX
		lstEncItems.Items.Clear()
		For	Each ItemZ In EncounterX.Items
			lstEncItems.Items.Add(New VB6.ListBoxItem(ItemZ.Name, ItemZ.Index))
			frmProject.LoadItemPic(ItemZ)
		Next ItemZ
	End Sub
	
	Public Sub ShowMap(ByRef InTree As AxComctlLib.AxTreeView, ByRef InMap As Map)
		Dim oErr As Object
		On Error GoTo ErrorHandler
		Dim c As Short
		Dim TileSetX As TileSet
		Dim X, Y As Short
		Dim OldDirt As Short
		OldDirt = frmMDI.Dirty
		TreeViewX = InTree
		MapX = InMap
		' Load Map bitmap
		Me.Text = "Map [" & MapX.Name & "]"
		frmProject.LoadMapPic(MapX, 1)
		' Resize scroll bars (which will draw the map)
		hsbMap.Maximum = (Greatest(Int((MapX.Width + MapX.Height - 4) / 2), 0) + hsbMap.LargeChange - 1)
		vsbMap.Maximum = (Greatest(Int((MapX.Width + MapX.Height - 14) / 2), 0) + vsbMap.LargeChange - 1)
		hsbMap.Value = (hsbMap.Maximum - hsbMap.LargeChange + 1) / 2
		vsbMap.Value = (vsbMap.Maximum - vsbMap.LargeChange + 1) / 2
		' Populate the TileSet list
		cmbTileSet.Items.Add(New VB6.ListBoxItem("<All>", 0))
		For	Each TileSetX In MapX.TileSets
			cmbTileSet.Items.Add(New VB6.ListBoxItem(TileSetX.Name, TileSetX.Index))
		Next TileSetX
		cmbTileSet.SelectedIndex = 0
		cmbTileSet.BringToFront()
		' Set up the Undo Stack
		ReDim TopTile(15, MapX.Width, MapX.Height)
		ReDim MiddleTile(15, MapX.Width, MapX.Height)
		ReDim BottomTile(15, MapX.Width, MapX.Height)
		ReDim EncPointer(15, MapX.Width, MapX.Height)
		ReDim UndoVisible(15, MapX.Width, MapX.Height)
		UndoTop = 0 : UndoBottom = 0
		' Show the form
		Me.Top = 0
		Me.Left = 0
		Me.Height = frmMDI.ClientRectangle.Height
		Me.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmMDI.ClientRectangle.Width) - VB6.PixelsToTwipsX(frmProject.Width))
		' Prime the Undo pump
		For X = 0 To MapX.Width : For Y = 0 To MapX.Height
				TopTile(0, X, Y) = MapX.TopTile(X, Y)
				MiddleTile(0, X, Y) = MapX.MiddleTile(X, Y)
				BottomTile(0, X, Y) = MapX.BottomTile(X, Y)
				EncPointer(0, X, Y) = MapX.EncPointer(X, Y)
				UndoVisible(0, X, Y) = MapX.Visible(X, Y)
			Next Y : Next X
		Me.Show()
		frmMDI.Dirty = OldDirt
		Exit Sub
ErrorHandler: 
		If Err.Number <> 364 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object oErr.logError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			oErr.logError("frmMap.ShowMap encounter error #" & Err.Number & " (" & Err.Description & ")")
		End If
	End Sub
	
	Public Sub DrawMap()
		DrawMapRegion(0, 0, picMap.ClientRectangle.Height, picMap.ClientRectangle.Width)
	End Sub
	
	'UPGRADE_NOTE: Right was upgraded to Right_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	'UPGRADE_NOTE: Bottom was upgraded to Bottom_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	'UPGRADE_NOTE: Left was upgraded to Left_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	'UPGRADE_NOTE: Top was upgraded to Top_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub DrawMapRegion(ByRef Top_Renamed As Short, ByRef Left_Renamed As Short, ByRef Bottom_Renamed As Short, ByRef Right_Renamed As Short)
		' Based on bounding coordinates in Pixels, draw the correct number
		' of tiles the correct way. Only draw the overlaps necessary
		' (only on the outer most region of the rectangle).
		' Draw Bottom Layer of entire region, Items, Creatures, Party
		' then Middle, Top.
		Dim Side, X, Y, i As Short
		Dim rc As Short
		'UPGRADE_NOTE: my was upgraded to my_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim XMap, mx, my_Renamed, YMap As Short
		Dim sx, sy As Short
		Dim FromY, ToY As Short
		Dim FromX, ToX As Short
		Dim EncounterX As Encounter
		Dim CreatureX As Creature
		Dim ItemX As Item
		SetMapCursor(Left_Renamed, Top_Renamed, MapX.Left_Renamed, MapX.Top, FromX, FromY, XMap, YMap)
		SetMapCursor(Right_Renamed, Bottom_Renamed, MapX.Left_Renamed, MapX.Top, ToX, ToY, XMap, YMap)
		FromX = Int(FromX / TileWidth) : FromY = Int(FromY / (TileHeight / 3)) + (XMap + YMap) Mod 2
		ToX = Int(ToX / TileWidth) + 1 : ToY = Int(ToY / (TileHeight / 3))
		' Ensure correct Map size is loaded
		frmProject.LoadMapPic(MapX, MapScale)
		' Draw Top of Region
		Y = FromY
		For X = FromX To ToX - 1
			Side = bdSideTop
			If X = FromX Then
				Side = Side Or bdSideLeft
			End If
			If X = ToX Then
				Side = Side Or bdSideRight
			End If
			DrawTile(X, Y, Side)
		Next X
		' Draw Middle of Region
		For Y = FromY + 1 To ToY
			For X = FromX To ToX - (Y Mod 2)
				Side = 0
				If X = FromX And (Y Mod 2) = 0 Then
					Side = Side Or bdSideLeft
				End If
				If X = ToX And (Y Mod 2) = 0 Then
					Side = Side Or bdSideRight
				End If
				DrawTile(X, Y, Side)
			Next X
		Next Y
		' Draw Bottom of Region
		For Y = ToY + 1 To ToY + 2
			For X = FromX To ToX - (Y Mod 2)
				If Y = ToY + 1 Then
					Side = bdSideFirstBottom
				Else
					Side = bdSideSecondBottom
				End If
				If X = FromX And (Y Mod 2) = 0 Then
					Side = Side Or bdSideLeft
				End If
				If X = ToX And (Y Mod 2) = 0 Then
					Side = Side Or bdSideRight
				End If
				DrawTile(X, Y, Side)
			Next X
		Next Y
		picMap.Refresh()
	End Sub
	
	Private Sub SizeAndDrawMap()
		' [Titi 2.4.8] if map is being centered, don't mess with scrollbars!
		If blnFromCenterMap = False Then
			MapX.Left_Renamed = Int((MapX.Width) / 2) + hsbMap.Value - vsbMap.Value - 1
			MapX.Top = -Int((MapX.Width) / 2) + hsbMap.Value + vsbMap.Value - 2
		End If
		DrawMap()
	End Sub
	
	Private Sub LayerTile(ByRef Layer As Short, ByRef XMap As Short, ByRef YMap As Short, ByRef AtX As Short, ByRef AtY As Short, ByRef AtWidth As Short, ByRef AtHeight As Short, ByRef AtOffX As Short, ByRef AtOffY As Short, ByRef Gray As Short)
		Dim c, Flip As Short
		Select Case Layer
			Case bdMapBottom
				c = MapX.BottomTile(XMap, YMap)
				If c > 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object MapX.Tiles().Pic. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					c = MapX.Tiles.Item("L" & c).Pic
				Else
					c = -1
				End If
				Flip = MapX.BottomFlip(XMap, YMap)
				PlotTile(c, AtX, AtY, AtWidth, AtHeight, AtOffX, AtOffY, Flip, Gray)
			Case bdMapMiddle
				c = MapX.MiddleTile(XMap, YMap)
				If c > 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object MapX.Tiles().Pic. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					c = MapX.Tiles.Item("L" & c).Pic
					Flip = MapX.MiddleFlip(XMap, YMap)
					PlotTile(c, AtX, AtY, AtWidth, AtHeight, AtOffX, AtOffY, Flip, Gray)
				End If
			Case bdMapTop
				c = MapX.TopTile(XMap, YMap)
				If c > 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object MapX.Tiles().Pic. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					c = MapX.Tiles.Item("L" & c).Pic
					Flip = MapX.TopFlip(XMap, YMap)
					PlotTile(c, AtX, AtY, AtWidth, AtHeight, AtOffX, AtOffY, Flip, Gray)
				End If
			Case bdMapEnc
				PlotTile(bdTileEncYellow, AtX, AtY, AtWidth, AtHeight, AtOffX, AtOffY, Flip, Gray)
			Case bdMapDim
				PlotTile(bdTileDarkGray, AtX, AtY, AtWidth, AtHeight, AtOffX, AtOffY, Flip, Gray)
		End Select
	End Sub
	
	Public Sub DrawTile(ByRef AtX As Short, ByRef AtY As Short, ByRef Side As Short)
		' AtX is a Pixel / (TileWidth / 2), AtY is Pixel / (TileHeight / 3)
		'UPGRADE_NOTE: my was upgraded to my_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim mx, c, my_Renamed As Short
		Dim X, Y As Short
		Dim rc As Integer
		Dim OffX, OffY As Short
		'UPGRADE_NOTE: Height was upgraded to Height_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		'UPGRADE_NOTE: Width was upgraded to Width_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Width_Renamed, Height_Renamed As Short
		Dim XMap, YMap As Short
		' Convert AtX and AtY to Map Coordinates
		XMap = MapX.Left_Renamed + AtX - Int(AtY / 2)
		YMap = MapX.Top + AtX + Int((AtY + 1) / 2) - 1
		X = (AtX * 2 - 1 + (AtY Mod 2)) * (TileWidth / 2)
		Y = (AtY - 2) * (TileHeight / 3)
		' The calc above is spot on. I've double checked it.
		OffX = 0 : OffY = 0
		Height_Renamed = TileHeight : Width_Renamed = TileWidth
		' Set Offsets and Width/Height
		If (Side And bdSideTop) > 0 Then
			OffY = (TileHeight / 3) * 2 : Height_Renamed = (TileHeight / 3)
		End If
		If (Side And bdSideLeft) > 0 Then
			OffX = (TileWidth / 2) : Width_Renamed = (TileWidth / 2)
		End If
		If (Side And bdSideFirstBottom) > 0 Then
			Height_Renamed = (TileHeight / 3) * 2
		End If
		If (Side And bdSideSecondBottom) > 0 Then
			Height_Renamed = (TileHeight / 3)
		End If
		If (Side And bdSideRight) > 0 Then
			Width_Renamed = (TileWidth / 2)
		End If
		' LayerTile: XMap, YMap, x, y, width, height, offx, offy
		' Plot blank tile if out of bounds
		If XMap < 0 Or YMap < 0 Or XMap > MapX.Width Or YMap > MapX.Height Then
			PlotTile(bdTileFlatGray, X + OffX, Y + OffY, Width_Renamed, Height_Renamed, OffX, OffY, 0, 0)
		Else
			If MAJ < 0 Then ' highlight tiles
				PlotTile(MAJ, X + OffX, Y + OffY, Width_Renamed, Height_Renamed, OffX, OffY, 0, 0)
				'            LayerTile MAJ, XMap, YMap, X + OffX, Y + OffY, Width, Height, OffX, OffY, 0
				Exit Sub
			End If
			If chkTileShow(2).CheckState = 0 Or MapX.BottomTile(XMap, YMap) = 0 Then
				PlotTile(-1, X + OffX, Y + OffY, Width_Renamed, Height_Renamed, OffX, OffY, 0, 0)
			Else
				LayerTile(bdMapBottom, XMap, YMap, X + OffX, Y + OffY, Width_Renamed, Height_Renamed, OffX, OffY, 0)
			End If
			If (frmMDI.OptionShowEncounters = True And MapX.EncPointer(XMap, YMap) > 0) Or (PaintLevel = bdLevelEncounter And MapX.EncPointer(XMap, YMap) = EncounterX.Index And EncounterX.Index > 0) Then
				LayerTile(bdMapEnc, XMap, YMap, X + OffX, Y + OffY, Width_Renamed, Height_Renamed, OffX, OffY, 0)
			End If
			If chkTileShow(1).CheckState = 1 Then
				LayerTile(bdMapMiddle, XMap, YMap, X + OffX, Y + OffY, Width_Renamed, Height_Renamed, OffX, OffY, 0)
			End If
			If chkTileShow(0).CheckState = 1 Then
				LayerTile(bdMapTop, XMap, YMap, X + OffX, Y + OffY, Width_Renamed, Height_Renamed, OffX, OffY, 0)
			End If
			' Only draw map objects if scale is 100%
			If MapScale = 1 Then
				DrawTileObjects(XMap, YMap)
			End If
			' If drawing Hidden tiles, then show gray layer
			If (PaintTool = bdToolEyeClosed Or PaintTool = bdToolEyeOpen) And MapX.Hidden(XMap, YMap) = True Then
				LayerTile(bdMapDim, XMap, YMap, X + OffX, Y + OffY, Width_Renamed, Height_Renamed, OffX, OffY, 0)
			End If
			'        LayerTile bdMapDim, XMap, YMap, X + OffX, Y + OffY, Width, Height, OffX, OffY, 0
		End If
	End Sub
	
	Private Sub DrawTileObjects(ByRef XMap As Short, ByRef YMap As Short)
		Dim EncounterX As Encounter
		Dim CreatureX As Creature
		Dim ItemX As Item
		Dim cy, cx, n As Short
		Dim rc As Integer
		' Draw Encounter
		If MapX.EncPointer(XMap, YMap) > 0 Then
			EncounterX = MapX.Encounters.Item("E" & MapX.EncPointer(XMap, YMap))
			' Encounter Items
			For	Each ItemX In EncounterX.Items
				If ItemX.MapX = 0 And ItemX.MapY = 0 Then
					PositionItem(MapX, EncounterX, ItemX)
				End If
				If ItemX.MapX = XMap And ItemX.MapY = YMap And Len(ItemX.PictureFile) > 0 Then
					frmProject.LoadItemPic(ItemX)
					cx = ((YMap - MapX.Top) + (XMap - MapX.Left_Renamed)) * 48 + ItemX.TileSpotX
					cy = ((YMap - MapX.Top) - (XMap - MapX.Left_Renamed)) * 24 - 24 + ItemX.TileSpotY - 24
					'UPGRADE_ISSUE: PictureBox property picItem.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					rc = BitBlt(picMap.hdc, cx, cy, frmProject.GetItemPicWidth((ItemX.Pic)) / 3, frmProject.GetItemPicHeight((ItemX.Pic)) / 3, frmProject.picItem.hdc, 32 * ItemX.Pic - 32, 32, SRCAND)
					'UPGRADE_ISSUE: PictureBox property picItem.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					rc = BitBlt(picMap.hdc, cx, cy, frmProject.GetItemPicWidth((ItemX.Pic)) / 3, frmProject.GetItemPicHeight((ItemX.Pic)) / 3, frmProject.picItem.hdc, 32 * ItemX.Pic - 32, 0, SRCPAINT)
				End If
			Next ItemX
			' Encounter Creatures
			For	Each CreatureX In EncounterX.Creatures
				If CreatureX.MapX = XMap And CreatureX.MapY = YMap Then
					If CreatureX.Pic = 0 Then
						frmProject.LoadCreaturePic(CreatureX)
					End If
					If CreatureX.HPNow > 0 Then
						n = CreatureX.Pic
						cx = ((YMap - MapX.Top) + (XMap - MapX.Left_Renamed)) * (TileWidth / 2) + CreatureX.TileSpotX
						cy = ((YMap - MapX.Top) - (XMap - MapX.Left_Renamed)) * (TileHeight / 3) - (TileHeight / 3) + CreatureX.TileSpotY - (VB6.PixelsToTwipsY(frmProject.picCMap(n).Height) / 2)
						'UPGRADE_ISSUE: PictureBox property picCMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
						'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
						rc = BitBlt(picMap.hdc, cx, cy, VB6.PixelsToTwipsX(frmProject.picCMap(n).Width), VB6.PixelsToTwipsY(frmProject.picCMap(n).Height) / 2, frmProject.picCMap(n).hdc, 0, VB6.PixelsToTwipsY(frmProject.picCMap(n).Height) / 2, SRCAND)
						'UPGRADE_ISSUE: PictureBox property picCMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
						'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
						rc = BitBlt(picMap.hdc, cx, cy, VB6.PixelsToTwipsX(frmProject.picCMap(n).Width), VB6.PixelsToTwipsY(frmProject.picCMap(n).Height) / 2, frmProject.picCMap(n).hdc, 0, 0, SRCPAINT)
					End If
				End If
			Next CreatureX
		End If
	End Sub
	
	Private Sub InitGame()
		Dim c As Short
		Dim CreatureX As Creature
		' Set default PaintMode
		OnLoad_Renamed = True
		' Load default Bones picture
		' Load bones picture for Creature
		CreatureX = New Creature
		CreatureX.PictureFile = "bones.bmp"
		frmProject.LoadCreaturePic(CreatureX)
		' Set up paint modes
		chkTileShow(0).CheckState = System.Windows.Forms.CheckState.Checked
		chkTileShow(1).CheckState = System.Windows.Forms.CheckState.Checked
		chkTileShow(2).CheckState = System.Windows.Forms.CheckState.Checked
		optTileLayer(2).Checked = 1
		optBrushSize(0).Checked = 1
		optTool(0).Checked = 1
		PaintTool = bdToolPaint
		PaintLevel = bdLevelBottom
		SetPaintMode()
		' Set common scale
		PicSize = VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) / (800 * VB6.TwipsPerPixelX) * 0.87 * 0.4
		' Set up Default Map Scale
		MapScale = 0.25
		TileWidth = 96 * MapScale
		TileHeight = 72 * MapScale
		SetMapScale(1)
		OnLoad_Renamed = False
	End Sub
	
	Private Sub SetMapCursor(ByVal ScreenX As Short, ByVal ScreenY As Short, ByRef MapLeft As Short, ByRef MapTop As Short, ByRef ToScreenX As Short, ByRef ToScreenY As Short, ByRef ToMapX As Short, ByRef ToMapY As Short)
		' Converts any ScreenX, ScreenY to true blue MapX and MapY
		Dim TileY24, TileY8, TileY48 As Short
		Dim TileX24, TileX48 As Short
		TileY8 = TileHeight / 9 : TileY24 = TileY8 * 3 : TileY48 = TileY8 * 6
		TileX24 = TileWidth / 4 : TileX48 = TileX24 * 2
		If Int(ScreenY / (TileY8 * 2)) Mod 3 = 1 Or (Int(ScreenY / TileY8) Mod 3 = 1 And Int((ScreenX - TileX24) / TileX48) Mod 2 = 0) Then
			ToMapX = MapLeft + Int(ScreenX / TileWidth) - Int(ScreenY / TileY48)
			ToMapY = MapTop + Int(ScreenX / TileWidth) + Int(ScreenY / TileY48)
			ToScreenX = Int(ScreenX / TileWidth) * TileWidth
			ToScreenY = Int(ScreenY / TileY48) * TileY48
		Else
			ToMapX = MapLeft + Int((ScreenX - TileX48) / TileWidth) - Int((ScreenY - TileY24) / TileY48)
			ToMapY = MapTop + Int((ScreenX + TileX48) / TileWidth) + Int((ScreenY - TileY24) / TileY48)
			ToScreenX = Int((ScreenX - TileX48) / TileWidth) * TileWidth + TileX48
			ToScreenY = Int((ScreenY - TileY24) / TileY48) * TileY48 + TileY24
		End If
	End Sub
	
	Private Sub SetMapScale(ByRef ToSize As Double)
		MapScale = ToSize
		TileWidth = 96 * MapScale
		TileHeight = 72 * MapScale
	End Sub
	
	Private Sub PlotCursor()
		Dim c As Short
		Dim XMap, YMap As Short
		Dim X, Y As Short
		SetMapCursor(XClick, YClick, (MapX.Left_Renamed), (MapX.Top), X, Y, XMap, YMap)
		If PointIn(XMap, YMap, 0, 0, (MapX.Width), (MapX.Height)) Then
			' Draw lines
			lnCursor(0).X1 = VB6.TwipsToPixelsX(X) : lnCursor(0).X2 = VB6.TwipsToPixelsX(X + (TileWidth / 2))
			lnCursor(0).Y1 = VB6.TwipsToPixelsY(Y + (TileHeight / 3)) : lnCursor(0).Y2 = VB6.TwipsToPixelsY(Y)
			lnCursor(1).X1 = VB6.TwipsToPixelsX(X + (TileWidth / 2)) : lnCursor(1).X2 = VB6.TwipsToPixelsX(X + TileWidth)
			lnCursor(1).Y1 = VB6.TwipsToPixelsY(Y) : lnCursor(1).Y2 = VB6.TwipsToPixelsY(Y + (TileHeight / 3))
			lnCursor(2).X1 = VB6.TwipsToPixelsX(X + TileWidth) : lnCursor(2).X2 = VB6.TwipsToPixelsX(X + (TileWidth / 2))
			lnCursor(2).Y1 = VB6.TwipsToPixelsY(Y + (TileHeight / 3)) : lnCursor(2).Y2 = VB6.TwipsToPixelsY(Y + (TileHeight / 3) * 2)
			lnCursor(3).X1 = VB6.TwipsToPixelsX(X + (TileWidth / 2)) : lnCursor(3).X2 = VB6.TwipsToPixelsX(X)
			lnCursor(3).Y1 = VB6.TwipsToPixelsY(Y + (TileHeight / 3) * 2) : lnCursor(3).Y2 = VB6.TwipsToPixelsY(Y + (TileHeight / 3))
			' Check if pointing to an encounter. If so, show it in hint box
			' Show MapX and MapY
			If MapX.EncPointer(XMap, YMap) < 1 Then
				frmMDI.ShowMsg("X: " & VB6.Format(XMap, "000") & "   Y: " & VB6.Format(YMap, "000"))
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object MapX.Encounters(E & MapX.EncPointer(XMap, YMap)).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				frmMDI.ShowMsg("X: " & VB6.Format(XMap, "000") & "   Y: " & VB6.Format(YMap, "000") & "   Encounter: " & MapX.Encounters.Item("E" & MapX.EncPointer(XMap, YMap)).Name)
			End If
		End If
	End Sub
	
	Private Sub PlotTile(ByRef TileToPlot As Short, ByRef X As Short, ByRef Y As Short, ByRef XWidth As Short, ByRef YWidth As Short, ByRef XSrcOff As Short, ByRef YSrcOff As Short, ByRef XFlip As Short, ByRef Gray As Short)
		Dim oErr As Object
		On Error GoTo ErrorHandler
		Dim rc As Short
		Dim MaxHeight, MaxWidth As Short
		Dim TileX, TileY As Short
		' Draw tile
		If TileToPlot < 0 Then
			Select Case TileToPlot
				Case bdTileBlack ' Pure Black
					'UPGRADE_ISSUE: PictureBox property picBlack.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					rc = BitBlt(picMap.hdc, X, Y, XWidth, YWidth, frmProject.picBlack.hdc, XSrcOff, TileHeight + YSrcOff, SRCAND)
					'UPGRADE_ISSUE: PictureBox property picBlack.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					rc = BitBlt(picMap.hdc, X, Y, XWidth, YWidth, frmProject.picBlack.hdc, XSrcOff, YSrcOff, SRCPAINT)
				Case bdTileGray ' Light Dim
					'UPGRADE_ISSUE: PictureBox property picBlack.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					rc = BitBlt(picMap.hdc, X, Y, XWidth, YWidth, frmProject.picBlack.hdc, TileWidth + XSrcOff, YSrcOff, SRCAND)
					'UPGRADE_ISSUE: PictureBox property picBlack.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					rc = BitBlt(picMap.hdc, X, Y, XWidth, YWidth, frmProject.picBlack.hdc, XSrcOff, YSrcOff, SRCPAINT)
				Case bdTileDarkGray ' Dark Dim
					'UPGRADE_ISSUE: PictureBox property picBlack.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					rc = BitBlt(picMap.hdc, X, Y, XWidth, YWidth, frmProject.picBlack.hdc, TileWidth + XSrcOff, TileHeight + YSrcOff, SRCAND)
					'UPGRADE_ISSUE: PictureBox property picBlack.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					rc = BitBlt(picMap.hdc, X, Y, XWidth, YWidth, frmProject.picBlack.hdc, XSrcOff, YSrcOff, SRCPAINT)
				Case bdTileFlatGray ' Solid Gray
					'UPGRADE_ISSUE: PictureBox property picBlack.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					rc = BitBlt(picMap.hdc, X, Y, XWidth, YWidth, frmProject.picBlack.hdc, XSrcOff, TileHeight + YSrcOff, SRCAND)
					'UPGRADE_ISSUE: PictureBox property picBlack.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					rc = BitBlt(picMap.hdc, X, Y, XWidth, YWidth, frmProject.picBlack.hdc, (TileWidth * 2) + XSrcOff, YSrcOff, SRCPAINT)
				Case bdTileEncYellow ' Map Yellow
					'UPGRADE_ISSUE: PictureBox property picBlack.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					rc = BitBlt(picMap.hdc, X, Y, XWidth, YWidth, frmProject.picBlack.hdc, TileWidth + XSrcOff, YSrcOff, SRCAND)
					'UPGRADE_ISSUE: PictureBox property picBlack.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					rc = BitBlt(picMap.hdc, X, Y, XWidth, YWidth, frmProject.picBlack.hdc, (TileWidth * 2) + XSrcOff, TileHeight + YSrcOff, SRCPAINT)
					'            ' [Titi 2.4.8] show where tile is found
				Case bdTileHighlightTop ' Green outline
					'UPGRADE_ISSUE: PictureBox property picOutline.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					rc = BitBlt(picMap.hdc, X, Y, XWidth, YWidth, frmProject.picOutline.hdc, XOutline, VB6.PixelsToTwipsY(Height) + YOutline, SRCAND)
					'UPGRADE_ISSUE: PictureBox property picOutline.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					rc = BitBlt(picMap.hdc, X, Y, XWidth, YWidth, frmProject.picOutline.hdc, XOutline, YOutline, SRCPAINT)
				Case bdTileHighlightMiddle ' Green outline
					'UPGRADE_ISSUE: PictureBox property picOutline.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					rc = BitBlt(picMap.hdc, X, Y, XWidth, YWidth, frmProject.picOutline.hdc, XOutline, VB6.PixelsToTwipsY(Height) + YOutline, SRCAND)
					'UPGRADE_ISSUE: PictureBox property picOutline.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					rc = BitBlt(picMap.hdc, X, Y, XWidth, YWidth, frmProject.picOutline.hdc, XOutline, YOutline, SRCPAINT)
				Case bdTileHighlightBottom ' Green outline
					'UPGRADE_ISSUE: PictureBox property picOutline.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					rc = BitBlt(picMap.hdc, X, Y, XWidth, YWidth, frmProject.picOutline.hdc, XOutline, VB6.PixelsToTwipsY(Height) + YOutline, SRCAND)
					'UPGRADE_ISSUE: PictureBox property picOutline.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					rc = BitBlt(picMap.hdc, X, Y, XWidth, YWidth, frmProject.picOutline.hdc, XOutline, YOutline, SRCPAINT)
			End Select
		Else
			' Set height, width and location of tile in bmp
			'        MaxHeight = (frmProject.picMap(MapX.Pic).Height / (TileHeight * 2))
			' [Titi 2.4.8] added another set of tiles, for green outline
			MaxHeight = (VB6.PixelsToTwipsY(frmProject.picMap(MapX.Pic).Height) / (TileHeight * 3))
			MaxWidth = (VB6.PixelsToTwipsX(frmProject.picMap(MapX.Pic).Width) / (TileWidth * 2))
			TileX = TileWidth * Int(TileToPlot / MaxHeight)
			TileY = TileHeight * (TileToPlot Mod MaxHeight)
			If XFlip = True Then
				TileX = VB6.PixelsToTwipsX(frmProject.picMap(MapX.Pic).Width) - TileWidth * (TileX / TileWidth) - TileWidth
			End If
			'        rc = BitBlt(picMap.hdc, X, Y, XWidth, YWidth, frmProject.picMap(MapX.Pic).hdc, _
			''            TileX + XSrcOff, TileY + YSrcOff + (frmProject.picMap(MapX.Pic).Height / 2), SRCAND)
			' [Titi 2.4.8] added another set of tiles, for green outline
			'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			rc = BitBlt(picMap.hdc, X, Y, XWidth, YWidth, frmProject.picMap(MapX.Pic).hdc, TileX + XSrcOff, TileY + YSrcOff + (VB6.PixelsToTwipsY(frmProject.picMap(MapX.Pic).Height) / 3), SRCAND)
			'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			rc = BitBlt(picMap.hdc, X, Y, XWidth, YWidth, frmProject.picMap(MapX.Pic).hdc, TileX + XSrcOff, TileY + YSrcOff, SRCPAINT)
		End If
		Exit Sub
		' [Titi 2.6.0] RT 480 when the tileset is too big
ErrorHandler: 
		If Err.Number = 480 Then
			' MsgBox "The tileset (" & MapX.PictureFile & ") is too large and the action cannot be completed." & vbCrLf & "Aborted..."
			'UPGRADE_ISSUE: PictureBox property picMap.AutoRedraw was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picMap.AutoRedraw = False
			Exit Sub
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object oErr.logError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			oErr.logError(Err.Description & " in PlotTile while working with " & MapX.Name & " (" & MapX.PictureFile & ")")
		End If
	End Sub
	
	Private Sub PlotCreature(ByRef X As Short, ByRef Y As Short, ByRef CreatureX As Creature)
		Dim rc As Short
		Y = Y - VB6.PixelsToTwipsY(frmProject.picCMap(CreatureX.Pic).Height) / 3
		Select Case CreatureX.TileSpot
			Case 0
				X = X + 8 : Y = Y + 52
			Case 1
				X = X + 32 : Y = Y + 52
			Case 2
				X = X + 56 : Y = Y + 52
			Case 3
				X = X + 32 : Y = Y + 64
			Case 4
				X = X + 32 : Y = Y + 40
		End Select
		'UPGRADE_ISSUE: PictureBox property picCMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = BitBlt(picMap.hdc, X, Y, VB6.PixelsToTwipsX(frmProject.picCMap(CreatureX.Pic).Width), VB6.PixelsToTwipsY(frmProject.picCMap(CreatureX.Pic).Height) / 2, frmProject.picCMap(CreatureX.Pic).hdc, 0, VB6.PixelsToTwipsY(frmProject.picCMap(CreatureX.Pic).Height) / 2, SRCAND)
		'UPGRADE_ISSUE: PictureBox property picCMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = BitBlt(picMap.hdc, X, Y, VB6.PixelsToTwipsX(frmProject.picCMap(CreatureX.Pic).Width), VB6.PixelsToTwipsY(frmProject.picCMap(CreatureX.Pic).Height) / 2, frmProject.picCMap(CreatureX.Pic).hdc, 0, 0, SRCPAINT)
	End Sub
	
	Private Sub ResizeForm()
		' If now an icon, do nothing else here
		If OnLoad_Renamed Or Me.ClientRectangle.Height < 1 Then
			Exit Sub
		End If
		' Adjust picTile
		picTiles.Height = Me.ClientRectangle.Height - picTiles.Top
		vsbTiles.Height = picTiles.Height - 4
		ListTiles()
		' Adjust size of list boxes for Encounters
		lstEncCreatures.Height = (Me.ClientRectangle.Height - lblEncCreatures.Top) / 2
		lblEncItems.Top = lstEncCreatures.Top + lstEncCreatures.Height
		lstEncItems.Top = lblEncItems.Top + lblEncItems.Height
		lstEncItems.Height = Me.ClientRectangle.Height - lblEncItems.Top - lblEncItems.Height + hsbMap.Height
		' Adjust horizontal scroll bar
		hsbMap.Top = Me.ClientRectangle.Height - hsbMap.Height
		hsbMap.Width = IIf(Me.ClientRectangle.Width - picBox.Left - vsbTiles.Width < 0, 0, Me.ClientRectangle.Width - picBox.Left - vsbTiles.Width)
		' Adjust verticle scroll bar
		vsbMap.Left = Me.ClientRectangle.Width - vsbMap.Width
		vsbMap.Height = hsbMap.Top - vsbMap.Top
		' Adjust map button
		btnMap.Top = vsbMap.Top + vsbMap.Height
		btnMap.Left = vsbMap.Left
		' Adjust size of picture box
		picBox.Width = IIf(Me.ClientRectangle.Width - picBox.Left - vsbTiles.Width < 0, 0, Me.ClientRectangle.Width - picBox.Left - vsbTiles.Width)
		picBox.Height = Me.ClientRectangle.Height - hsbMap.Height
		picMap.Width = picBox.Width + (TileWidth / 2)
		picMap.Height = picBox.Height + (TileHeight / 3)
		' Set all controls visible
		vsbMap.Visible = True
		hsbMap.Visible = True
		btnMap.Visible = True
		DrawMap()
	End Sub
	
	Private Sub btnRedo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnRedo.Click
		ApplyRedo()
	End Sub
	
	Private Sub btnUndo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnUndo.Click
		ApplyUndo()
	End Sub
	
	'UPGRADE_WARNING: Event chkTileShow.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkTileShow_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkTileShow.CheckStateChanged
		Dim Index As Short = chkTileShow.GetIndex(eventSender)
		If chkTileShow(Index).CheckState = 0 Then
			optTileLayer(Index).Checked = 0
		End If
		If OnLoad_Renamed = False Then
			DrawMap()
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmbEncounters.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbEncounters_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbEncounters.SelectedIndexChanged
		Dim k, i As Short
		If cmbEncounters.SelectedIndex > -1 Then
			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
			' [Titi 2.4.9a] default to active encounter
			If frmMDI.bNotFromEncList Then
				' [Titi 2.4.9b] except if chosen directly from the drop list!
				For k = 0 To cmbEncounters.Items.Count
					If VB6.GetItemString(cmbEncounters, k) = frmProject.ActiveEnc.Name Then
						cmbEncounters.SelectedIndex = k
					End If
				Next 
			End If
			frmMDI.bNotFromEncList = False
			'UPGRADE_WARNING: Couldn't resolve default property of object MapX.Encounters(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ListEncThings(MapX.Encounters.Item("E" & VB6.GetItemData(cmbEncounters, cmbEncounters.SelectedIndex)))
			' [Titi 2.4.9] center map on the active encounter
			For k = 0 To MapX.Width
				For i = 0 To MapX.Height
					'UPGRADE_WARNING: Couldn't resolve default property of object MapX.Encounters(E & cmbEncounters.ItemData(cmbEncounters.ListIndex)).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If MapX.EncPointer(k, i) = MapX.Encounters.Item("E" & VB6.GetItemData(cmbEncounters, cmbEncounters.SelectedIndex)).Index Then
						CenterMap(k, i)
						DrawMap()
						'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
						System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
						Exit Sub
					End If
				Next i
			Next k
			DrawMap()
			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmbTileSet.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbTileSet_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbTileSet.SelectedIndexChanged
		If cmbTileSet.SelectedIndex > -1 Then
			SetTileList()
		End If
	End Sub
	
	'UPGRADE_WARNING: Form event frmMap.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmMap_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		tmrLeftRightScroll.Enabled = True
	End Sub
	
	'UPGRADE_WARNING: Form event frmMap.Deactivate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmMap_Deactivate(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Deactivate
		tmrLeftRightScroll.Enabled = False
	End Sub
	
	Private Sub frmMap_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Dim CtrlKey As Object
		If TypeOf Me.ActiveControl Is System.Windows.Forms.TextBox Then
			CtrlKey(Me.ActiveControl, KeyCode, Shift)
		End If
	End Sub
	
	Private Sub frmMap_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Dim ShiftDown, AltDown As Object
		Dim CtrlDown As Short
		'UPGRADE_WARNING: Couldn't resolve default property of object ShiftDown. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ShiftDown = (Shift And VB6.ShiftConstants.ShiftMask) > 0
		'UPGRADE_WARNING: Couldn't resolve default property of object AltDown. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		AltDown = (Shift And VB6.ShiftConstants.AltMask) > 0
		CtrlDown = (Shift And VB6.ShiftConstants.CtrlMask) > 0
		' Undo CTRL-Z
		If KeyCode = System.Windows.Forms.Keys.Z And CtrlDown And btnUndo.Enabled = True Then
			ApplyUndo()
		End If
		' Redo CTRL-Y
		If KeyCode = System.Windows.Forms.Keys.Y And CtrlDown And btnRedo.Enabled = True Then
			ApplyRedo()
		End If
	End Sub
	
	Private Sub frmMap_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		' [Titi 2.6.0] What if the tileset is not found?
		frmProject.LoadMapPic(MapX, 1)
		If VB6.PixelsToTwipsY(frmProject.picMap(MapX.Pic).Height) <= 1 And MAJ <> 260 Then ' MAJ used to prevent the warning from being displayed several times
			MAJ = 260
			MsgBox("Are you sure " & MapX.PictureFile & " is present in" & vbCrLf & gDataPath & "\Graphics\Tilesets?", MsgBoxStyle.Critical, "Unable to display the map!")
			Me.Close()
		ElseIf MAJ = 260 Then 
			Me.Close()
		Else
			InitGame()
			MAJ = 0
		End If
	End Sub
	
	'UPGRADE_WARNING: Event frmMap.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmMap_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		ResizeForm()
	End Sub
	
	'UPGRADE_NOTE: hsbMap.Change was changed from an event to a procedure. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
	'UPGRADE_WARNING: HScrollBar event hsbMap.Change has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub hsbMap_Change(ByVal newScrollValue As Integer)
		SizeAndDrawMap()
	End Sub
	
	'UPGRADE_NOTE: hsbMap.Scroll was changed from an event to a procedure. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
	Private Sub hsbMap_Scroll_Renamed(ByVal newScrollValue As Integer)
		SizeAndDrawMap()
	End Sub
	
	'UPGRADE_WARNING: Event optTileLayer.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optTileLayer_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optTileLayer.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = optTileLayer.GetIndex(eventSender)
			Dim k As Short
			If optTileLayer(Index).Checked = True And Index < 3 Then
				chkTileShow(Index).CheckState = System.Windows.Forms.CheckState.Checked
			End If
			PaintLevel = Index
			SetPaintMode()
			'    ' [Titi 2.4.9] default to active encounter  <-- [Titi 2.4.9a] moved at cmbEncounters_Click to avoid going to the first encounter in the list before going to the active one
			'    If Index = 3 Then
			'        For k = 0 To cmbEncounters.ListCount
			'            If cmbEncounters.List(k) = frmProject.ActiveEnc.Name Then
			'                cmbEncounters.ListIndex = k
			'            End If
			'        Next k
			'    End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optTool.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optTool_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optTool.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = optTool.GetIndex(eventSender)
			PaintTool = Index
			SetPaintMode()
			If Index <> 9 Then blnClearTile = True
		End If
	End Sub
	
	'UPGRADE_ISSUE: OptionButton event optTool.DblClick was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub optTool_DblClick(ByRef Index As Short)
		optTool_CheckedChanged(optTool.Item(Index), New System.EventArgs())
		If Index = 5 Then blnClearTile = False
	End Sub
	
	Private Sub picMap_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles picMap.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = eventArgs.X
		Dim Y As Single = eventArgs.Y
		Dim w, h As Short
		MouseButton = Button
		XClick = CShort(X)
		YClick = CShort(Y)
		If MouseButton = VB6.MouseButtonConstants.LeftButton Then
			MouseDown_Renamed = True
			If (PaintTool = bdToolEyeOpen Or PaintTool = bdToolEyeClosed) And Shift = 2 Then
				'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
				For w = 0 To MapX.Width : For h = 0 To MapX.Height
						MapX.Hidden(w, h) = (PaintTool = bdToolEyeClosed)
					Next h : Next w
				DrawMap()
				'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
			ElseIf PaintTool = bdToolErase And Shift = 2 Then 
				'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
				For w = 0 To MapX.Width : For h = 0 To MapX.Height
						MapX.TopTile(w, h) = 0
						MapX.TopFlip(w, h) = 0
						MapX.MiddleTile(w, h) = 0
						MapX.MiddleFlip(w, h) = 0
						MapX.BottomTile(w, h) = 0
						MapX.BottomFlip(w, h) = 0
						MapX.Hidden(w, h) = False
					Next h : Next w
				DrawMap()
				'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
			Else
				PaintTile(XClick, YClick)
			End If
		Else
			EditEncounter(XClick, YClick, (Shift And 1))
		End If
	End Sub
	
	Private Sub picMap_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles picMap.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = eventArgs.X
		Dim Y As Single = eventArgs.Y
		XClick = CShort(X)
		YClick = CShort(Y)
		If Button = VB6.MouseButtonConstants.LeftButton And (PaintTool = bdToolPaint Or PaintTool = bdToolErase Or PaintTool = bdToolEyeOpen Or PaintTool = bdToolEyeClosed) Then
			bLeftRightScroll = 0 ' stop horizontal scrolling
			PaintTile(XClick, YClick)
		Else
			' [Titi 2.5.1] Left/Right scrolling added
			If X > picMap.Left + 20 And X < picMap.Left + 40 Then
				bLeftRightScroll = -1
			ElseIf X > picBox.Width - 40 And X < picBox.Width - 20 Then 
				bLeftRightScroll = 1
			Else
				bLeftRightScroll = 0
			End If
		End If
		PlotCursor()
	End Sub
	
	Private Sub picMap_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles picMap.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = eventArgs.X
		Dim Y As Single = eventArgs.Y
		MouseDown_Renamed = False
		' [Titi 2.4.9] if right-click, no action done!
		If Button <> VB6.MouseButtonConstants.RightButton Then AddUndo()
	End Sub
	
	Private Sub picTiles_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles picTiles.Click
		Dim TileX As Tile
		SetSelectBox()
		If MouseButton = VB6.MouseButtonConstants.RightButton Then
			TreeViewX.SelectedItem = TreeViewX.Nodes("M" & MapX.Index & "TilesL" & TileNow.Index)
			frmMDI.SetupMenu((frmProject.AreaList), TreeViewX, "M" & MapX.Index & "TilesL" & TileNow.Index)
			'UPGRADE_ISSUE: MDIForm method frmMDI.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			frmMDI.PopupMenu(frmMDI.mnuEdit)
		End If
		If MAJ = VB6.ShiftConstants.ShiftMask Then FindTile() ' [Titi 2.4.8]
	End Sub
	
	Private Sub picTiles_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles picTiles.DoubleClick
		SetSelectBox()
		TileNow.Flip = (TileNow.Flip = False)
		ListTiles()
	End Sub
	
	Private Sub picTiles_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles picTiles.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = eventArgs.X
		Dim Y As Single = eventArgs.Y
		XClick = X
		YClick = Y
		MouseButton = Button
		MAJ = Shift
	End Sub
	
	Private Sub tmrLeftRightScroll_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmrLeftRightScroll.Tick
		Dim Delta As Object
		Dim MouseWheelSupport As Object
		Dim EnumThreadProc As Object
		' [Titi 2.5.1] added mouse wheel support
		EnumThreadProc(picMap.Handle.ToInt32, YClick * &H10000 + XClick)
		'UPGRADE_WARNING: Couldn't resolve default property of object Delta. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Delta <> 0 Then
			MouseWheelSupport(picMap.Handle.ToInt32, CSng(XClick), CSng(YClick), vsbMap)
			'UPGRADE_WARNING: Couldn't resolve default property of object Delta. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Delta = 0
		End If
		' horizontal scroll
		If bLeftRightScroll = -1 Then
			hsbMap.Value = hsbMap.Value - IIf(hsbMap.Value > hsbMap.Minimum, 1, 0)
		ElseIf bLeftRightScroll = 1 Then 
			hsbMap.Value = hsbMap.Value + IIf(hsbMap.Value < (hsbMap.Maximum - hsbMap.LargeChange + 1), 1, 0)
		End If
		picMap.Refresh()
	End Sub
	
	'UPGRADE_NOTE: vsbMap.Change was changed from an event to a procedure. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
	'UPGRADE_WARNING: VScrollBar event vsbMap.Change has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub vsbMap_Change(ByVal newScrollValue As Integer)
		SizeAndDrawMap()
	End Sub
	
	'UPGRADE_NOTE: vsbMap.Scroll was changed from an event to a procedure. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
	Private Sub vsbMap_Scroll_Renamed(ByVal newScrollValue As Integer)
		SizeAndDrawMap()
	End Sub
	
	'UPGRADE_NOTE: vsbTiles.Change was changed from an event to a procedure. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
	'UPGRADE_WARNING: VScrollBar event vsbTiles.Change has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub vsbTiles_Change(ByVal newScrollValue As Integer)
		ListTiles()
		SetSelectBox()
	End Sub
	
	'UPGRADE_NOTE: vsbTiles.Scroll was changed from an event to a procedure. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
	Private Sub vsbTiles_Scroll_Renamed(ByVal newScrollValue As Integer)
		ListTiles()
		SetSelectBox()
	End Sub
	Private Sub hsbMap_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles hsbMap.Scroll
		Select Case eventArgs.type
			Case System.Windows.Forms.ScrollEventType.ThumbTrack
				hsbMap_Scroll_Renamed(eventArgs.newValue)
			Case System.Windows.Forms.ScrollEventType.EndScroll
				hsbMap_Change(eventArgs.newValue)
		End Select
	End Sub
	Private Sub vsbMap_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles vsbMap.Scroll
		Select Case eventArgs.type
			Case System.Windows.Forms.ScrollEventType.ThumbTrack
				vsbMap_Scroll_Renamed(eventArgs.newValue)
			Case System.Windows.Forms.ScrollEventType.EndScroll
				vsbMap_Change(eventArgs.newValue)
		End Select
	End Sub
	Private Sub vsbTiles_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles vsbTiles.Scroll
		Select Case eventArgs.type
			Case System.Windows.Forms.ScrollEventType.ThumbTrack
				vsbTiles_Scroll_Renamed(eventArgs.newValue)
			Case System.Windows.Forms.ScrollEventType.EndScroll
				vsbTiles_Change(eventArgs.newValue)
		End Select
	End Sub
End Class