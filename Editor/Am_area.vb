Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frmTileProp
	Inherits System.Windows.Forms.Form
	Dim TreeViewX As AxComctlLib.AxTreeView
	Dim TileX As Tile
	Dim Dirty As Short
	Dim MapX As Map
	Dim blnChanceChanged As Boolean
	Const bdGeneral As Short = 1
	Const bdTriggers As Short = 2
	
	Private Sub InitGame()
		Dim c As Short
		blnChanceChanged = False
		' Load relative style constants
		c = 0
		Do Until modBD.SetUpTileStyle(c) = ""
			cmbStyle.Items.Add(New VB6.ListBoxItem(modBD.SetUpTileStyle(c), c))
			c = c + 1
		Loop 
		' Load Terrain Types
		c = 0
		Do Until modBD.SetUpTileTerrain(c) = ""
			cmbTerrainType.Items.Add(New VB6.ListBoxItem(modBD.SetUpTileTerrain(c), c))
			c = c + 1
		Loop 
		' Load Movement Cost
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("1/10 Turn", 0))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("2/10 Turn", 1))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("3/10 Turn", 2))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("4/10 Turn", 3))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("1/2 Turn", 4))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("6/10 Turn", 5))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("7/10 Turn", 6))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("8/10 Turn", 7))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("9/10 Turn", 8))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("1 Turn", 9))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("2 Turns", 10))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("3 Turns", 11))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("4 Turns", 12))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("5 Turns", 13))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("10 Turns", 14))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("20 Turns", 15))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("30 Turns", 16))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("40 Turns", 17))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("50 Turns", 18))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("1/2 Day", 19))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("1 Day", 20))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("2 Days", 21))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("3 Days", 22))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("4 Days", 23))
		cmbMovementCost.Items.Add(New VB6.ListBoxItem("5 Days", 24))
	End Sub
	
	Public Sub ShowTile(ByRef InTree As AxComctlLib.AxTreeView, ByRef InMap As Map, ByRef InTile As Tile)
		Dim c As Short
		Dim TileSetX As TileSet
		Dim TileZ As Tile
		Dim OldDirt As Short
		OldDirt = frmMDI.Dirty
		TreeViewX = InTree
		TileX = InTile
		MapX = InMap
		' Show General
		Me.Text = "Tile [" & TileX.Name & "]"
		txtName.Text = TileX.Name
		cmbTileSet.Items.Add(New VB6.ListBoxItem("<None>", 0))
		cmbTileSet.SelectedIndex = 0
		For	Each TileSetX In MapX.TileSets
			cmbTileSet.Items.Add(New VB6.ListBoxItem(TileSetX.Name, TileSetX.Index))
			If TileX.TileSet = TileSetX.Index Then
				'UPGRADE_ISSUE: ComboBox property cmbTileSet.NewIndex was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
				cmbTileSet.SelectedIndex = cmbTileSet.NewIndex
			End If
		Next TileSetX
		For c = 0 To 3
			shpSee(c).FillStyle = 1 + TileX.See(c)
			lnSide(c).Visible = TileX.Blocked(c)
		Next c
		' Show SwapTile
		txtChance.Text = CStr(TileX.Chance)
		For c = 3 To 7
			chkKey(c).CheckState = TileX.KeyBit(c) * CShort(True)
		Next c
		cmbSwapTile.Items.Add(New VB6.ListBoxItem("<None>", 0))
		cmbSwapTile.SelectedIndex = 0
		For	Each TileZ In MapX.Tiles
			If TileX.Index <> TileZ.Index Then
				cmbSwapTile.Items.Add(New VB6.ListBoxItem(TileZ.Name, TileZ.Index))
				If TileX.SwapTile = TileZ.Index Then
					'UPGRADE_ISSUE: ComboBox property cmbSwapTile.NewIndex was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
					cmbSwapTile.SelectedIndex = cmbSwapTile.NewIndex
				End If
			End If
		Next TileZ
		' Show Magic Paint
		cmbStyle.SelectedIndex = 0
		For c = 0 To cmbStyle.Items.Count - 1
			If TileX.Style = VB6.GetItemData(cmbStyle, c) Then
				cmbStyle.SelectedIndex = c
			End If
		Next c
		' Show Terrain Type
		cmbTerrainType.SelectedIndex = 0
		For c = 0 To cmbTerrainType.Items.Count - 1
			If TileX.TerrainType = VB6.GetItemData(cmbTerrainType, c) Then
				cmbTerrainType.SelectedIndex = c
			End If
		Next c
		' Show Movement Cost
		cmbMovementCost.SelectedIndex = 0
		For c = 0 To cmbMovementCost.Items.Count - 1
			If TileX.MovementCost = VB6.GetItemData(cmbMovementCost, c) Then
				cmbMovementCost.SelectedIndex = c
			End If
		Next c
		' List Tile Pictures
		frmProject.LoadMapPic(MapX, 1)
		vsbTilePic.Maximum = ((VB6.PixelsToTwipsY(frmProject.picMap(MapX.Pic).Height) / 72) / 2 * (VB6.PixelsToTwipsX(frmProject.picMap(MapX.Pic).Width) / 96) / 2 + vsbTilePic.LargeChange - 1)
		' [Titi 2.4.8] added another set of tiles for the green outline, so height should be divided by 3 instead of 2
		'    vsbTilePic.Max = (frmProject.picMap(MapX.Pic).Height / 72) / 3 * (frmProject.picMap(MapX.Pic).Width / 96) / 2
		vsbTilePic.Value = TileX.Pic
		ShowTilePic(0, (vsbTilePic.Value))
		SetDirty(False)
		frmMDI.Dirty = OldDirt
	End Sub
	
	Private Sub ShowTilePic(ByRef Index As Short, ByRef PicToShow As Short)
		Dim MaxHeight, rc, MaxWidth As Short
		Dim X, Y As Short
		'    MaxHeight = (frmProject.picMap(MapX.Pic).Height / 72) / 2
		' [Titi 2.4.8] added another set of tiles for the green outline, so height should be divided by 3 instead of 2
		MaxHeight = (VB6.PixelsToTwipsY(frmProject.picMap(MapX.Pic).Height) / 72) / 3
		MaxWidth = (VB6.PixelsToTwipsX(frmProject.picMap(MapX.Pic).Width) / 96) / 2
		X = 96 * Int(PicToShow / MaxHeight)
		Y = 72 * (PicToShow Mod MaxHeight)
		'UPGRADE_ISSUE: PictureBox method picTiles.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picTiles(Index).Cls()
		' [Titi 2.4.8] added another set of tiles for the green outline, so height should be divided by 3 instead of 2
		'    rc = BitBlt(picTiles(Index).hdc, 0, 0, 96, 72, _
		''        frmProject.picMap(MapX.Pic).hdc, X, (frmProject.picMap(MapX.Pic).Height) / 2 + Y, SRCAND)
		'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: PictureBox property picTiles.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = BitBlt(picTiles(Index).hdc, 0, 0, 96, 72, frmProject.picMap(MapX.Pic).hdc, X, (VB6.PixelsToTwipsY(frmProject.picMap(MapX.Pic).Height)) / 3 + Y, SRCAND)
		'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: PictureBox property picTiles.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = BitBlt(picTiles(Index).hdc, 0, 0, 96, 72, frmProject.picMap(MapX.Pic).hdc, X, Y, SRCPAINT)
		picTiles(Index).Refresh()
	End Sub
	
	Private Sub UpdateTile()
		Dim c As Short
		' General
		TileX.Name = txtName.Text
		TileX.TileSet = VB6.GetItemData(cmbTileSet, cmbTileSet.SelectedIndex)
		TileX.Pic = vsbTilePic.Value
		For c = 0 To 3
			TileX.See(c) = shpSee(c).FillStyle - 1
			TileX.Blocked(c) = lnSide(c).Visible
		Next c
		' SwapTile
		'    TileX.Chance = Val(txtChance.Text) '[Titi 2.4.9] moved AFTER the style definition: by default, doors have 100% chance to open!
		For c = 3 To 7
			TileX.KeyBit(c) = chkKey(c).CheckState * CShort(True)
		Next c
		TileX.SwapTile = VB6.GetItemData(cmbSwapTile, cmbSwapTile.SelectedIndex)
		' Magic Paint
		TileX.Style = VB6.GetItemData(cmbStyle, cmbStyle.SelectedIndex)
		'[Titi 2.4.9] by default, doors have 100% chance to open! Update if this value has been modified AFTER the style change.
		If blnChanceChanged Then TileX.Chance = Val(txtChance.Text)
		' Terrain Type
		TileX.TerrainType = VB6.GetItemData(cmbTerrainType, cmbTerrainType.SelectedIndex)
		' Movement Cost
		TileX.MovementCost = VB6.GetItemData(cmbMovementCost, cmbMovementCost.SelectedIndex)
		' Update Project
		TreeViewX.Nodes(Me.Tag).Text = TileX.Name
		ShowTile(TreeViewX, MapX, TileX)
		blnChanceChanged = False
		SetDirty(False)
		' [Titi 2.5.1]
		For c = 0 To My.Application.OpenForms.Count - 1
			If VB.Right(My.Application.OpenForms.Item(c).Tag, 7) = "Graphic" Then
				If VB.Left(My.Application.OpenForms.Item(c).Tag, Len(My.Application.OpenForms.Item(c).Tag) - 7) = TreeViewX.SelectedItem.Parent.Tag Then
					'UPGRADE_ISSUE: Control SetTileList could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					My.Application.OpenForms.Item(c).SetTileList()
					'UPGRADE_ISSUE: Control ListTiles could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					My.Application.OpenForms.Item(c).ListTiles()
					Exit For
				End If
			End If
		Next c
	End Sub
	
	Private Sub SetDirty(ByRef Flag As Short)
		btnApply.Enabled = Flag
		Dirty = Flag
		If Dirty = True Then
			frmMDI.Dirty = True
		End If
	End Sub
	
	Private Sub btnApply_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnApply.Click
		UpdateTile()
		ShowTile(TreeViewX, MapX, TileX)
	End Sub
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		Me.Close()
	End Sub
	
	Private Sub btnOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOk.Click
		If Dirty Then UpdateTile()
		Me.Close()
	End Sub
	
	'UPGRADE_WARNING: Event chkKey.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkKey_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkKey.CheckStateChanged
		Dim Index As Short = chkKey.GetIndex(eventSender)
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbMovementCost.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbMovementCost_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbMovementCost.SelectedIndexChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbStyle.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbStyle_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbStyle.SelectedIndexChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbSwapTile.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbSwapTile_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbSwapTile.SelectedIndexChanged
		If cmbSwapTile.SelectedIndex > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object MapX.Tiles().Pic. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ShowTilePic(1, MapX.Tiles.Item("L" & VB6.GetItemData(cmbSwapTile, cmbSwapTile.SelectedIndex)).Pic)
		Else
			'UPGRADE_ISSUE: PictureBox method picTiles.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picTiles(1).Cls()
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmbTerrainType.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbTerrainType_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbTerrainType.SelectedIndexChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbTileSet.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbTileSet_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbTileSet.SelectedIndexChanged
		SetDirty(True)
	End Sub
	
	Private Sub frmTileProp_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		If TypeOf Me.ActiveControl Is System.Windows.Forms.TextBox Then
			CtrlKey(Me.ActiveControl, KeyCode, Shift)
		End If
	End Sub
	
	Private Sub frmTileProp_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		InitGame()
	End Sub
	
	Private Sub lblBlocked_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lblBlocked.Click
		Dim Index As Short = lblBlocked.GetIndex(eventSender)
		lnSide(Index).Visible = Not lnSide(Index).Visible
		SetDirty(True)
	End Sub
	
	Private Sub lblSee_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lblSee.Click
		Dim Index As Short = lblSee.GetIndex(eventSender)
		shpSee(Index).FillStyle = System.Math.Abs(shpSee(Index).FillStyle - 1)
		SetDirty(True)
	End Sub
	
	Private Sub tabTileProp_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabTileProp.ClickEvent
		Select Case tabTileProp.SelectedItem.Tag
			Case bdGeneral
				fraTileProp(0).BringToFront()
		End Select
	End Sub
	
	'UPGRADE_WARNING: Event txtChance.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtChance_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtChance.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		blnChanceChanged = True
		SetDirty(True)
	End Sub
	
	Private Sub txtChance_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtChance.KeyPress
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
	
	'UPGRADE_NOTE: vsbTilePic.Change was changed from an event to a procedure. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
	'UPGRADE_WARNING: VScrollBar event vsbTilePic.Change has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub vsbTilePic_Change(ByVal newScrollValue As Integer)
		ShowTilePic(0, (newScrollValue))
		SetDirty(True)
	End Sub
	Private Sub vsbTilePic_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles vsbTilePic.Scroll
		Select Case eventArgs.type
			Case System.Windows.Forms.ScrollEventType.EndScroll
				vsbTilePic_Change(eventArgs.newValue)
		End Select
	End Sub
End Class