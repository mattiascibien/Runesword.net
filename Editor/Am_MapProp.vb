Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmMapProp
	Inherits System.Windows.Forms.Form
	Dim TreeViewX As AxComctlLib.AxTreeView
	Dim MapX As Map
	Dim Dirty As Short
	' [Titi 2.4.9a] add a flag to prevent display of warning messages when the form loads
	Dim blnNoChange As Boolean
	' Height and Width of Picture in Tile Units (96x72)
	Dim PicHeight, PicWidth As Short
	
	Const bdGeneral As Short = 1
	Const bdEncounters As Short = 2
	Const bdTileSets As Short = 3
	Const bdTiles As Short = 4
	Const bdEntryPoints As Short = 5
	Const bdReGen As Short = 6
	Const bdThemes As Short = 7
	Const bdCreatures As Short = 8
	
	Private Sub InitGame()
		' ReGen Map Style
		cmbDefaultStyle.Items.Add(New VB6.ListBoxItem("Tetris Spin", 0))
		cmbDefaultStyle.Items.Add(New VB6.ListBoxItem("Cavern Sprawl", 1))
		cmbDefaultStyle.Items.Add(New VB6.ListBoxItem("Bubble Tubes", 2))
		cmbDefaultStyle.Items.Add(New VB6.ListBoxItem("Rectangles", 3))
		cmbDefaultStyle.Items.Add(New VB6.ListBoxItem("Huge Cavern", 4))
		cmbDefaultStyle.Items.Add(New VB6.ListBoxItem("<None>", 5))
		' Map Style
		cmbMapStyle.Items.Add(New VB6.ListBoxItem("Town", 0))
		cmbMapStyle.Items.Add(New VB6.ListBoxItem("Wilderness", 1))
		cmbMapStyle.Items.Add(New VB6.ListBoxItem("Building", 2))
		cmbMapStyle.Items.Add(New VB6.ListBoxItem("Dungeon", 3))
		' Party Size
		cmbPartySize.Items.Add(New VB6.ListBoxItem("Solo", 0))
		cmbPartySize.Items.Add(New VB6.ListBoxItem("1-3", 1))
		cmbPartySize.Items.Add(New VB6.ListBoxItem("4-6", 2))
		cmbPartySize.Items.Add(New VB6.ListBoxItem("7-9", 3))
		' Party Avg Level
		cmbPartyAvgLevel.Items.Add(New VB6.ListBoxItem("1-3", 0))
		cmbPartyAvgLevel.Items.Add(New VB6.ListBoxItem("4-6", 1))
		cmbPartyAvgLevel.Items.Add(New VB6.ListBoxItem("7-10", 2))
		cmbPartyAvgLevel.Items.Add(New VB6.ListBoxItem("10+", 3))
		' Flag to prevent warning messages upon loading
		blnNoChange = True
		' [Titi 2.4.9b] change the names of the runes as per the world settings
		Dim i As Short
		Dim sText, sRune As String
		' if the world doesn't use the Eternia runes system, let's as well deactivate it
		If WorldNow.Runes Then
			For i = 0 To 19
				lblRune(i).Visible = False
				txtRune(i).Visible = False
			Next 
			optIsNoRunes(0).Visible = False
			optIsNoRunes(1).Visible = False
			Frame2.Text = "No Runes in this world"
		Else
			' update the names as per the list
			sText = VB.Right(strRunesList, Len(strRunesList) - 5) & "," ' get rid of "List="
			For i = 0 To intNbRunes - 1
				sRune = VB.Left(sText, InStr(sText, ",") - 1)
				sText = VB.Right(sText, Len(sText) - Len(VB.Left(sText, InStr(sText, ",") - 1)) - 1)
				lblRune(i).Text = sRune
			Next 
			' now, hide the unnecessary labels
			For i = intNbRunes To 19
				lblRune(i).Visible = False
				txtRune(i).Visible = False
			Next 
		End If
	End Sub
	
	Private Sub SetDirty(ByRef Flag As Short)
		btnApply.Enabled = Flag
		Dirty = Flag
		If Dirty = True Then
			frmMDI.Dirty = True
		End If
	End Sub
	
	Private Sub SetPictureFile()
		'UPGRADE_WARNING: Arrays in structure bmTiles may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmTiles As BITMAPINFO
		Dim hMemTiles, TransparentRGB As Integer
		On Error Resume Next
		'    dlgFile.FileName = gAppPath & "\Data\Graphics\Tiles\*.bmp"
		dlgFileOpen.FileName = gDataPath & "\Graphics\Tiles\*.bmp"
		dlgFileOpen.Title = "Choose Picture"
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		dlgFile.CancelError = True
		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		dlgFileOpen.Filter = "Bitmaps (*.bmp)|*.bmp|All Files (*.*)|*.*"
		dlgFileOpen.FilterIndex = 1
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFile.Flags was upgraded to dlgFileOpen.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		dlgFileOpen.CheckFileExists = True
		dlgFileOpen.CheckPathExists = True
		'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFile.Flags was upgraded to dlgFileOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		dlgFileOpen.ShowReadOnly = False
		dlgFileOpen.RestoreDirectory = False
		dlgFileOpen.ShowDialog()
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		If Err.Number = DialogResult.Cancel Then
			Exit Sub
		End If
		' Depending on file chosen, get other files
		'UPGRADE_WARNING: CommonDialog property dlgFile.FileTitle was upgraded to dlgFile.FileName which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		txtPictureFile.Text = dlgFileOpen.FileName
		frmMDI.ShowMsg("Loading TileSet " & txtPictureFile.Text & "...")
		' Load TileSet bitmap
		ReadBitmapFile(txtPictureFile.Text, bmTiles, hMemTiles, TransparentRGB)
		' Set Height and Width defaults
		PicHeight = Int(bmTiles.bmiHeader.biHeight / 72)
		PicWidth = Int(bmTiles.bmiHeader.biWidth / 96)
	End Sub
	
	Private Sub GenerateMap()
		Dim c, Found As Short
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		If UpdateMap Then
			' [Titi 2.4.9b] RT9 when regenerating a map (except for Tetris Spin style) when it was on screen
			' So, if MapX.Graphic is open, close it.
			For c = 0 To My.Application.OpenForms.Count - 1
				If My.Application.OpenForms.Item(c).Tag = Me.Tag & "Graphic" Then
					If My.Application.OpenForms.Item(c).WindowState <> 1 Then
						'UPGRADE_ISSUE: Unload Forms() was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="875EBAD7-D704-4539-9969-BC7DBDAA62A2"'
						Unload(My.Application.OpenForms(c))
						Found = True
					End If
					Exit For
				End If
			Next c
			modDungeonMaker.MakeMap(MapX, True)
			ShowMap((frmProject.tvwProject), MapX)
			frmMDI.OpenArea(Area)
			' If MapX.Graphic was open, repaint it.
			' [Titi 2.4.9b] fixed RT9 when regenerating an already open map
			'        For c = 0 To Forms.Count - 1
			'            If Forms(c).Tag = Me.Tag & "Graphic" Then
			'                If Forms(c).WindowState <> 1 Then
			'                    Forms(c).ShowMap TreeViewX, MapX
			'                    Forms(c).DrawMap
			'                End If
			'                Exit For
			'            End If
			'        Next c
			If Found Then
				frmMDI.EditProperties(Me.Tag & "Graphic")
				For c = 0 To My.Application.OpenForms.Count - 1
					If My.Application.OpenForms.Item(c).Tag = Me.Tag Then
						'UPGRADE_WARNING: Form method Forms.ZOrder has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
						My.Application.OpenForms.Item(c).BringToFront()
						Exit For
					End If
				Next c
			End If
			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		End If
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Function UpdateMap() As Short
		Dim Tome_Renamed As Object
		Dim c As Short
		Dim TileX As Tile
		Dim FileName As String
		' Validate the Picture File
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FullPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileName = Dir(Tome.FullPath & "\" & txtPictureFile.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FullPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If FileName = "" Or Tome.FullPath = "" Then
			'        FileName = Dir(gAppPath & "\data\graphics\tiles\" & txtPictureFile.Text)
			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FileName = Dir(gDataPath & "\graphics\tiles\" & txtPictureFile.Text)
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FullPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FileName = Dir(Tome.FullPath & "\" & txtPictureFile.Text)
		End If
		If FileName = "" Then
			frmMDI.ShowMsg("Invalid Picture File Name " & txtPictureFile.Text)
			UpdateMap = False
			Exit Function
		End If
		' Update other properties
		MapX.Name = txtName.Text
		MapX.Width = Greatest(Val(txtWidth.Text) - 1, 0)
		MapX.Height = Greatest(Val(txtHeight.Text) - 1, 0)
		MapX.PictureFile = txtPictureFile.Text
		MapX.Comments = txtComments.Text
		MapX.MapStyle = VB6.GetItemData(cmbMapStyle, cmbMapStyle.SelectedIndex)
		MapX.PartySize = VB6.GetItemData(cmbPartySize, cmbPartySize.SelectedIndex)
		MapX.PartyAvgLevel = VB6.GetItemData(cmbPartyAvgLevel, cmbPartyAvgLevel.SelectedIndex)
		For c = 0 To 19
			MapX.Runes(c) = CShort(txtRune(c).Text)
		Next c
		MapX.DefaultStyle = cmbDefaultStyle.SelectedIndex
		MapX.IsNoTiles = chkIsNoTiles.CheckState * CShort(True)
		If optIsNoRunes(0).Checked = True Then
			MapX.IsNoRunes = False
		Else
			MapX.IsNoRunes = True
		End If
		MapX.CanCamp = chkCanCamp.CheckState * CShort(True) ' [Titi 2.5.1] flag for camping
		MapX.GenerateUponEntry = chkReGen.CheckState * CShort(True)
		MapX.GenerateAppend = chkReGenAppend.CheckState * CShort(True)
		MapX.DefaultWidth = Greatest(Val(txtDefaultWidth.Text) - 1, 0)
		MapX.DefaultHeight = Greatest(Val(txtDefaultHeight.Text) - 1, 0)
		MapX.DefaultEncounters = Greatest(Val(txtDefaultEncounters.Text), 1)
		' [Titi 2.5.1] display wandering monsters options
		blnNoChange = True
		MapX.Hazard = CShort(Val(lblChancesWandering.Text))
		cmbFrequency.SelectedIndex = 0
		MapX.Interval = CShort(Val(lblBetweenRests.Text))
		cmbInterval.SelectedIndex = 0
		For c = 0 To cmbFrequency.Items.Count
			If VB6.GetItemString(cmbFrequency, c) = lblChancesWandering.Text & "%" Then
				cmbFrequency.SelectedIndex = c
				Exit For
			End If
		Next 
		For c = 0 To cmbInterval.Items.Count
			If VB6.GetItemString(cmbInterval, c) = lblBetweenRests.Text & " turns" Then
				cmbInterval.SelectedIndex = c
				Exit For
			End If
		Next 
		'    MapX.WanderingMonsters = ""
		'    For c = 0 To cmbWandering.ListCount - 1
		'        MapX.WanderingMonsters = IIf(MapX.WanderingMonsters = "", "", MapX.WanderingMonsters & ",") & cmbWandering.List(c)
		'    Next
		blnNoChange = False
		' If Auto-Generating a list of tiles, do that now.
		If chkAutoGenTiles.CheckState = 1 Then
			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
			frmProject.LoadMapPic(MapX, 1)
			' Delete old tiles
			For	Each TileX In MapX.Tiles
				MapX.RemoveTile("L" & TileX.Index)
			Next TileX
			For c = 0 To (VB6.PixelsToTwipsY(frmProject.picMap(MapX.Pic).Height) / 72) / 2 * (VB6.PixelsToTwipsX(frmProject.picMap(MapX.Pic).Width) / 96) / 2
				TileX = MapX.AddTile
				TileX.Pic = c
			Next c
			chkAutoGenTiles.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
		' [Titi 2.4.9a] update drawing
		For c = 0 To My.Application.OpenForms.Count - 1
			If My.Application.OpenForms.Item(c).Tag = frmProject.tvwProject.SelectedItem.Tag & "Graphic" Then
				'UPGRADE_ISSUE: Unload Forms() was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="875EBAD7-D704-4539-9969-BC7DBDAA62A2"'
				Unload(My.Application.OpenForms(c))
				frmMDI.EditProperties(TreeViewX.SelectedItem.Tag & "Graphic")
				Exit For
			End If
		Next 
		frmMDI.OpenArea(Area)
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		' Update name in project list
		TreeViewX.Nodes(Me.Tag).Text = MapX.Name
		SetDirty(False)
		UpdateMap = True
	End Function
	
	Public Sub ShowMap(ByRef InTree As AxComctlLib.AxTreeView, ByRef InMap As Map)
		Dim c As Short
		Dim CreatureX As Creature
		Dim OldDirt, tmpDirty As Short
		Dim ObjectX As Object
		OldDirt = frmMDI.Dirty
		TreeViewX = InTree
		MapX = InMap
		Me.Text = "Map [" & MapX.Name & "]"
		txtName.Text = MapX.Name
		txtWidth.Text = VB6.Format(MapX.Width + 1)
		txtHeight.Text = VB6.Format(MapX.Height + 1)
		txtPictureFile.Text = MapX.PictureFile
		cmbPartySize.SelectedIndex = MapX.PartySize
		cmbPartyAvgLevel.SelectedIndex = MapX.PartyAvgLevel
		cmbMapStyle.SelectedIndex = MapX.MapStyle
		txtComments.Text = MapX.Comments
		For c = 0 To 19
			txtRune(c).Text = VB6.Format(MapX.Runes(c))
		Next c
		cmbDefaultStyle.SelectedIndex = 0
		For c = 0 To cmbDefaultStyle.Items.Count - 1
			If VB6.GetItemData(cmbDefaultStyle, c) = MapX.DefaultStyle Then
				cmbDefaultStyle.SelectedIndex = c
				Exit For
			End If
		Next c
		' [Titi 2.5.1] added a flag to tell if camping is possible. If set to true, it will overwrite the same flag in encounters
		chkCanCamp.CheckState = MapX.CanCamp * CShort(True)
		' [Titi 2.5.1] display wandering monsters options
		blnNoChange = True
		lblChancesWandering.Text = CStr(MapX.Hazard)
		cmbFrequency.SelectedIndex = 0
		lblBetweenRests.Text = CStr(MapX.Interval)
		cmbInterval.SelectedIndex = 0
		For c = 0 To cmbFrequency.Items.Count
			If VB6.GetItemString(cmbFrequency, c) = lblChancesWandering.Text & "%" Then
				cmbFrequency.SelectedIndex = c
				Exit For
			End If
		Next 
		For c = 0 To cmbInterval.Items.Count
			If VB6.GetItemString(cmbInterval, c) = lblBetweenRests.Text & " turns" Then
				cmbInterval.SelectedIndex = c
				Exit For
			End If
		Next 
		cmbWandering.Items.Clear()
		'    sText = MapX.WanderingMonsters & ","
		'    While InStr(sText, ",") > 1
		'        cmbWandering.AddItem Left$(sText, InStr(sText, ",") - 1)
		'        sText = Mid$(sText, InStr(sText, ",") + 1)
		'    Wend
		For	Each CreatureX In MapX.Creatures
			cmbWandering.Items.Add(CreatureX.Name)
		Next CreatureX
		If cmbWandering.Items.Count = 0 Then
			cmbWandering.Items.Add("None")
		End If
		cmbWandering.SelectedIndex = 0
		blnNoChange = False
		chkIsNoTiles.CheckState = MapX.IsNoTiles * CShort(True)
		chkReGen.CheckState = MapX.GenerateUponEntry * CShort(True)
		chkReGenAppend.CheckState = MapX.GenerateAppend * CShort(True)
		txtDefaultWidth.Text = VB6.Format(MapX.DefaultWidth + 1)
		txtDefaultHeight.Text = VB6.Format(MapX.DefaultHeight + 1)
		txtDefaultEncounters.Text = VB6.Format(MapX.DefaultEncounters)
		If MapX.IsNoRunes = False Then
			optIsNoRunes(0).Checked = True
		Else
			optIsNoRunes(1).Checked = True
		End If
		For c = 0 To 19
			txtRune(c).Enabled = optIsNoRunes(0).Checked
			lblRune(c).Enabled = optIsNoRunes(0).Checked
		Next c
		chkAutoGenTiles.CheckState = System.Windows.Forms.CheckState.Unchecked
		SetDirty(False)
		frmMDI.Dirty = OldDirt
		Dirty = tmpDirty ' [Titi 2.4.9a] when loading, the form will not set Dirty
		btnApply.Enabled = Dirty
	End Sub
	
	Public Sub ListThemes()
		Dim c As Short
		If tabMapProp.SelectedItem.Tag = bdThemes Then
			lblAttached.Text = "Themes Attached to Map"
			lstThings.Items.Clear()
			For c = 1 To MapX.Themes.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object MapX.Themes(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object MapX.Themes(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstThings.Items.Add(New VB6.ListBoxItem(MapX.Themes.Item(c).Name, MapX.Themes.Item(c).Index))
			Next c
		End If
	End Sub
	
	Public Sub ListCreatures()
		Dim c As Short
		If tabMapProp.SelectedItem.Tag = bdCreatures Then
			lblAttached.Text = "Wandering Monsters Attached to Map"
			lstThings.Items.Clear()
			For c = 1 To MapX.Creatures.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object MapX.Creatures(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object MapX.Creatures(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstThings.Items.Add(New VB6.ListBoxItem(MapX.Creatures.Item(c).Name, MapX.Creatures.Item(c).Index))
			Next c
		End If
	End Sub
	
	Public Sub ListTiles()
		Dim c As Short
		If tabMapProp.SelectedItem.Tag = bdTiles Then
			lblAttached.Text = "Tiles Attached to Map"
			lstThings.Items.Clear()
			For c = 1 To MapX.Tiles.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object MapX.Tiles(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstThings.Items.Add(New VB6.ListBoxItem("Tile #" & MapX.Tiles.Item(c).Index, MapX.Tiles.Item(c).Index))
			Next c
		End If
	End Sub
	
	Public Sub ListEncounters()
		Dim c As Short
		If tabMapProp.SelectedItem.Tag = bdEncounters Then
			lblAttached.Text = "Encounters Attached to Theme"
			lstThings.Items.Clear()
			For c = 1 To MapX.Encounters.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object MapX.Encounters(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object MapX.Encounters(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstThings.Items.Add(New VB6.ListBoxItem(MapX.Encounters.Item(c).Name, MapX.Encounters.Item(c).Index))
			Next c
		End If
	End Sub
	
	Public Sub ListTileSets()
		Dim c As Short
		If tabMapProp.SelectedItem.Tag = bdTileSets Then
			'        lblAttached.Caption = "TileSets Attached to Map"
			' [Titi 2.6.0] Tileset is kinda confusing --> changed to combat wallpaper
			lblAttached.Text = "Combat Wallpapers Attached to Map"
			lstThings.Items.Clear()
			For c = 1 To MapX.TileSets.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object MapX.TileSets(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object MapX.TileSets(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstThings.Items.Add(New VB6.ListBoxItem(MapX.TileSets.Item(c).Name, MapX.TileSets.Item(c).Index))
			Next c
		End If
	End Sub
	
	Private Sub EditThing()
		If lstThings.SelectedIndex > -1 Then
			Select Case tabMapProp.SelectedItem.Tag
				Case bdEncounters
					frmMDI.EditProperties(Me.Tag & "EncountersE" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdTileSets
					frmMDI.EditProperties(Me.Tag & "TileSetsW" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdTiles
					frmMDI.EditProperties(Me.Tag & "TilesL" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdThemes
					frmMDI.EditProperties(Me.Tag & "ThemesR" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdCreatures
					frmMDI.EditProperties(Me.Tag & "CreaturesX" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
		End If
	End Sub
	
	Private Sub InsertThing()
		Select Case tabMapProp.SelectedItem.Tag
			Case bdEncounters
				frmMDI.EditAdd(Me.Tag & "Encounters", bdEditEncounter)
			Case bdTileSets
				frmMDI.EditAdd(Me.Tag & "TileSets", bdEditTileSet)
			Case bdTiles
				frmMDI.EditAdd(Me.Tag & "Tiles", bdEditTile)
			Case bdThemes
				frmMDI.EditAdd(Me.Tag & "Themes", bdEditTheme)
			Case bdCreatures
				frmMDI.EditAdd(Me.Tag & "Creatures", bdEditCreature)
		End Select
	End Sub
	
	Private Sub CutThing()
		If lstThings.SelectedIndex > -1 Then
			Select Case tabMapProp.SelectedItem.Tag
				Case bdEncounters
					frmMDI.EditCut(Me.Tag & "EncountersE" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdTileSets
					frmMDI.EditCut(Me.Tag & "TileSetsW" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdTiles
					frmMDI.EditCut(Me.Tag & "TilesL" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdThemes
					frmMDI.EditCut(Me.Tag & "ThemesR" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdCreatures
					frmMDI.EditCut(Me.Tag & "CreaturesX" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
		End If
	End Sub
	
	Private Sub CopyThing()
		If lstThings.SelectedIndex > -1 Then
			Select Case tabMapProp.SelectedItem.Tag
				Case bdEncounters
					frmMDI.EditCopy(Me.Tag & "EncountersE" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdTileSets
					frmMDI.EditCopy(Me.Tag & "TileSetsW" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdTiles
					frmMDI.EditCopy(Me.Tag & "TilesL" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdThemes
					frmMDI.EditCopy(Me.Tag & "ThemesR" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdEntryPoints
					frmMDI.EditCopy(Me.Tag & "EntryPointsP" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
		End If
	End Sub
	
	Private Sub PasteThing()
		Select Case tabMapProp.SelectedItem.Tag
			Case bdEncounters
				If frmMDI.BufferType = bdEditEncounter Then
					frmMDI.EditPaste(Me.Tag & "Encounters")
				End If
			Case bdTileSets
				If frmMDI.BufferType = bdEditTileSet Then
					frmMDI.EditPaste(Me.Tag & "TileSets")
				End If
			Case bdTiles
				If frmMDI.BufferType = bdEditTile Then
					frmMDI.EditPaste(Me.Tag & "Tiles")
				End If
			Case bdThemes
				If frmMDI.BufferType = bdEditTheme Then
					frmMDI.EditPaste(Me.Tag & "Themes")
				End If
			Case bdCreatures
				If frmMDI.BufferType = bdEditCreature Then
					frmMDI.EditPaste(Me.Tag & "Creatures")
				End If
		End Select
	End Sub
	
	
	Private Sub btnApply_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnApply.Click
		If UpdateMap Then
			ShowMap(TreeViewX, MapX)
		End If
	End Sub
	
	Private Sub btnBrowse_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnBrowse.Click
		SetPictureFile()
	End Sub
	
	Private Sub btnCopy_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCopy.Click
		CopyThing()
	End Sub
	
	Private Sub btnCut_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCut.Click
		CutThing()
	End Sub
	
	Private Sub btnEdit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnEdit.Click
		EditThing()
	End Sub
	
	Private Sub btnInsert_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnInsert.Click
		InsertThing()
	End Sub
	
	Private Sub btnOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOk.Click
		If UpdateMap Then
			' [Titi 2.6.3] cancelling an updated map only means we won't keep the changes since the last ones so we update the tag
			If VB.Right("   " & Me.Tag, 3) = "NEW" Then Me.Tag = VB.Left(Me.Tag, Len(Me.Tag) - 3)
			Me.Close()
		End If
	End Sub
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		' [Titi 2.6.3] cancelling a new map means we won't keep it
		If VB.Right("   " & Me.Tag, 3) = "NEW" Then frmMDI.EditCut(VB.Left(Me.Tag, Len(Me.Tag) - 3))
		Me.Close()
	End Sub
	
	Private Sub btnPaste_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnPaste.Click
		PasteThing()
	End Sub
	
	Private Sub btnReGen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnReGen.Click
		GenerateMap()
	End Sub
	
	'UPGRADE_WARNING: Event chkAutoGenTiles.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkAutoGenTiles_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkAutoGenTiles.CheckStateChanged
		Dim c As Short
		If chkAutoGenTiles.CheckState = 1 And blnNoChange = False Then c = MsgBox("This will erase " & Me.Text & "." & Chr(13) & "Are you sure?", MsgBoxStyle.YesNo, "Warning!")
		If c = MsgBoxResult.No Then
			chkAutoGenTiles.CheckState = System.Windows.Forms.CheckState.Unchecked
		Else
			SetDirty(True)
		End If
	End Sub
	
	'UPGRADE_WARNING: Event chkCanCamp.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkCanCamp_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkCanCamp.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkIsNoTiles.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkIsNoTiles_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkIsNoTiles.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkReGen.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkReGen_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkReGen.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkReGenAppend.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkReGenAppend_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkReGenAppend.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbDefaultStyle.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbDefaultStyle_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbDefaultStyle.SelectedIndexChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbFrequency.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbFrequency_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbFrequency.SelectedIndexChanged
		If blnNoChange = False Then
			MapX.Hazard = CShort(Val(VB6.GetItemString(cmbFrequency, cmbFrequency.SelectedIndex)))
			SetDirty(True)
		End If
		lblChancesWandering.Text = CStr(MapX.Hazard)
	End Sub
	
	'UPGRADE_WARNING: Event cmbInterval.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbInterval_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbInterval.SelectedIndexChanged
		If blnNoChange = False Then
			MapX.Interval = CShort(Val(VB6.GetItemString(cmbInterval, cmbInterval.SelectedIndex)))
			SetDirty(True)
		End If
		lblBetweenRests.Text = CStr(MapX.Interval)
	End Sub
	
	'UPGRADE_WARNING: Event cmbMapStyle.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbMapStyle_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbMapStyle.SelectedIndexChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbPartyAvgLevel.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbPartyAvgLevel_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbPartyAvgLevel.SelectedIndexChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbPartySize.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbPartySize_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbPartySize.SelectedIndexChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbWandering.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbWandering_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbWandering.SelectedIndexChanged
		On Error Resume Next
		Dim CreatureX As Creature
		If blnNoChange = False Then
			frmMDI.EditLoad(Me.Tag & "Creatures", bdEditCreature)
			If VB6.GetItemString(cmbWandering, 0) = "None" Then cmbWandering.Items.RemoveAt(0)
			'        MapX.WanderingMonsters = IIf(MapX.WanderingMonsters = "", "", MapX.WanderingMonsters & ",") & frmMDI.dlgFile.FileTitle
			'UPGRADE_WARNING: CommonDialog property frmMDI.dlgFile.FileTitle was upgraded to frmMDI.dlgFile.FileName which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			'UPGRADE_NOTE: Variable frmMDI.dlgFile was renamed frmMDI.dlgFileOpen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="94ADAC4D-C65D-414F-A061-8FDC6B83C5EC"'
			cmbWandering.Items.Add((New System.IO.DirectoryInfo(frmMDI.dlgFileOpen.FileName)).Name)
			cmbWandering.SelectedIndex = VB6.GetItemString(cmbWandering, cmbWandering.Items.Count)
			SetDirty(True)
		End If
	End Sub
	
	Private Sub cmbWandering_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles cmbWandering.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		If KeyCode = System.Windows.Forms.Keys.Escape And Shift = VB6.ShiftConstants.ShiftMask Then
			cmbWandering.Items.Clear()
		End If
	End Sub
	
	Private Sub btnLibrary_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnLibrary.Click
		If btnLibrary.Visible = True Then
			Select Case Mid(btnLibrary.Text, 8, 4)
				Case "them"
					frmMDI.EditLoad(Me.Tag & "Themes", bdEditTheme)
				Case "enco"
					frmMDI.EditLoad(Me.Tag & "Encounters", bdEditEncounter)
			End Select
		End If
	End Sub
	
	'UPGRADE_WARNING: Form event frmMapProp.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmMapProp_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		' [Titi 2.6.0] Make sure we're still working with the relevant treeview and objectlist
		If VB.Left(Me.Tag, 4) = "Tome" Then
			frmMDI.TreeViewX = frmProject.tvwTome.GetOcx
			frmMDI.ObjectListX = frmProject.TomeList
		Else
			frmMDI.TreeViewX = frmProject.tvwProject.GetOcx
			frmMDI.ObjectListX = frmProject.AreaList
		End If
	End Sub
	
	Private Sub frmMapProp_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		If TypeOf Me.ActiveControl Is System.Windows.Forms.TextBox Then
			CtrlKey(Me.ActiveControl, KeyCode, Shift)
		End If
	End Sub
	
	Private Sub frmMapProp_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		InitGame()
		' [Titi 2.5.1] camping options
		Dim c As Short
		cmbInterval.Items.Clear()
		cmbInterval.Items.Add("No interval")
		For c = 10 To 200 Step 10
			cmbInterval.Items.Add(c & " turns")
		Next 
		cmbFrequency.Items.Clear()
		cmbFrequency.Items.Add("No monsters")
		'    For c = 5 To 50 Step 5
		'        cmbFrequency.AddItem c & "%"
		'    Next
		cmbFrequency.Items.Add("1%")
		cmbFrequency.Items.Add("5%")
		cmbFrequency.Items.Add("10%")
		cmbFrequency.Items.Add("20%")
		cmbFrequency.Items.Add("25%")
		cmbFrequency.Items.Add("33%")
		cmbFrequency.Items.Add("50%")
		cmbFrequency.Items.Add("67%")
		cmbFrequency.Items.Add("75%")
		cmbFrequency.Items.Add("100%")
		cmbWandering.Items.Clear()
		cmbWandering.Items.Add("None")
		cmbWandering.SelectedIndex = 0
		blnNoChange = True
	End Sub
	
	Private Sub frmMapProp_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Dim c As Short
		' [Titi 2.4.9a]
		If Dirty Then
			c = MsgBox("Changes will be lost! Save first?", MsgBoxStyle.YesNo, "Changes not saved!")
			If c = MsgBoxResult.Yes Then
				' [Titi 2.6.3] update the tag before closing
				If VB.Right("   " & Me.Tag, 3) = "NEW" Then Me.Tag = VB.Left(Me.Tag, Len(Me.Tag) - 3)
				btnOk_Click(btnOk, New System.EventArgs())
			Else
				' [Titi 2.6.3] closing a new map means we won't keep it
				If VB.Right("   " & Me.Tag, 3) = "NEW" Then
					frmMDI.EditCut(VB.Left(Me.Tag, Len(Me.Tag) - 3))
				End If
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event lstThings.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstThings_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstThings.SelectedIndexChanged
		Select Case tabMapProp.SelectedItem.Tag
			Case bdEncounters
				TreeViewX.Nodes(Me.Tag & "EncountersE" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
			Case bdTileSets
				TreeViewX.Nodes(Me.Tag & "TileSetsW" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
			Case bdTiles
				TreeViewX.Nodes(Me.Tag & "TilesL" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
			Case bdThemes
				TreeViewX.Nodes(Me.Tag & "ThemesR" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
			Case bdCreatures
				TreeViewX.Nodes(Me.Tag & "CreaturesX" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
		End Select
	End Sub
	
	Private Sub lstThings_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstThings.DoubleClick
		EditThing()
	End Sub
	
	'UPGRADE_WARNING: Event optIsNoRunes.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optIsNoRunes_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optIsNoRunes.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = optIsNoRunes.GetIndex(eventSender)
			Dim c As Short
			For c = 0 To 19
				txtRune(c).Enabled = optIsNoRunes(0).Checked
				lblRune(c).Enabled = optIsNoRunes(0).Checked
			Next c
			SetDirty(True)
		End If
	End Sub
	
	Private Sub tabMapProp_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabMapProp.ClickEvent
		Select Case tabMapProp.SelectedItem.Tag
			Case bdGeneral
				fraMap(0).BringToFront()
			Case bdEncounters
				fraMap(1).BringToFront()
				btnLibrary.Text = "Insert encounter from library"
				btnLibrary.Visible = True
				ListEncounters()
			Case bdTileSets
				fraMap(1).BringToFront()
				btnLibrary.Visible = False
				ListTileSets()
			Case bdTiles
				fraMap(1).BringToFront()
				btnLibrary.Visible = False
				ListTiles()
			Case bdThemes
				fraMap(1).BringToFront()
				btnLibrary.Text = "Insert theme from library"
				btnLibrary.Visible = True
				ListThemes()
			Case bdReGen
				fraMap(2).BringToFront()
		End Select
	End Sub
	
	'UPGRADE_WARNING: Event txtComments.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtComments_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtComments.TextChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtDefaultEncounters.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtDefaultEncounters_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDefaultEncounters.TextChanged
		Limit(Me.ActiveControl, 0, bdInt)
		SetDirty(True)
	End Sub
	
	Private Sub txtDefaultEncounters_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDefaultEncounters.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdInt)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtDefaultHeight.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtDefaultHeight_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDefaultHeight.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	Private Sub txtDefaultHeight_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDefaultHeight.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtDefaultWidth.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtDefaultWidth_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDefaultWidth.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	Private Sub txtDefaultWidth_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDefaultWidth.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtHeight.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtHeight_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHeight.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	Private Sub txtHeight_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHeight.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtName.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtName_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtName.TextChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtPictureFile.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtPictureFile_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPictureFile.TextChanged
		SetDirty(True)
		If blnNoChange Then chkAutoGenTiles.CheckState = System.Windows.Forms.CheckState.Checked
		blnNoChange = False
	End Sub
	
	'UPGRADE_WARNING: Event txtRune.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtRune_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRune.TextChanged
		Dim Index As Short = txtRune.GetIndex(eventSender)
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	Private Sub txtRune_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtRune.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = txtRune.GetIndex(eventSender)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtWidth.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtWidth_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWidth.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	Private Sub txtWidth_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtWidth.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
End Class