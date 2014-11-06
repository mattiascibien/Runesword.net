Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmEntryPoint
	Inherits System.Windows.Forms.Form
	Dim TileX As Tile
	Dim Dirty As Short
	Dim TomeX As Tome
	Dim MapX As Map
	Dim EntryPointX As EntryPoint
	
	Private Sub InitGame()
		cmbStyle.Items.Add(New VB6.ListBoxItem("Exit", 0))
		cmbStyle.Items.Add(New VB6.ListBoxItem("Exit Up", 1))
		cmbStyle.Items.Add(New VB6.ListBoxItem("Exit Down", 2))
		cmbMapStyle.Items.Add(New VB6.ListBoxItem("To Town", 0))
		cmbMapStyle.Items.Add(New VB6.ListBoxItem("To Wilderness", 1))
		cmbMapStyle.Items.Add(New VB6.ListBoxItem("To Building", 2))
		cmbMapStyle.Items.Add(New VB6.ListBoxItem("To Dungeon", 3))
	End Sub
	
	Public Sub ShowEntryPoint(ByRef InTome As Tome, ByRef InMap As Map, ByRef InEntryPoint As EntryPoint)
		Dim i, c, Found As Short
		Dim MapZ As Map
		Dim EntryPointZ As EntryPoint
		Dim AreaX As Area
		Dim OldDirt, tmpDirty As Short
		tmpDirty = Dirty '[Titi 2.4.9a]
		OldDirt = frmMDI.Dirty
		TomeX = InTome
		MapX = InMap
		EntryPointX = InEntryPoint
		Me.Text = "EntryPoint [" & EntryPointX.Name & "]"
		txtName.Text = EntryPointX.Name
		txtDescription.Text = EntryPointX.Description
		For c = 0 To 2
			If VB6.GetItemData(cmbStyle, c) = EntryPointX.Style Then
				cmbStyle.SelectedIndex = EntryPointX.Style
			End If
		Next c
		If cmbStyle.SelectedIndex < 0 Then
			cmbStyle.SelectedIndex = 0
		End If
		For c = 0 To 3
			If VB6.GetItemData(cmbMapStyle, c) = EntryPointX.MapStyle Then
				cmbMapStyle.SelectedIndex = EntryPointX.MapStyle
			End If
		Next c
		If cmbMapStyle.SelectedIndex < 0 Then
			cmbMapStyle.SelectedIndex = 0
		End If
		txtMapX.Text = VB6.Format(EntryPointX.MapX)
		txtMapY.Text = VB6.Format(EntryPointX.MapY)
		chkIsNoExitSign.CheckState = EntryPointX.IsNoExitSign * CShort(True)
		' Populate the Area list box
		cmbAreas.Items.Clear()
		cmbAreas.Items.Add(New VB6.ListBoxItem("[Main Menu]", 0))
		cmbAreas.Items.Add(New VB6.ListBoxItem("[Random]", -1))
		For	Each AreaX In Tome.Areas
			cmbAreas.Items.Add(New VB6.ListBoxItem(AreaX.Name, AreaX.Index))
		Next AreaX
		' Find matching Area
		cmbAreas.SelectedIndex = 0
		For c = 0 To cmbAreas.Items.Count - 1
			If EntryPointX.AreaIndex = VB6.GetItemData(cmbAreas, c) Then
				cmbAreas.SelectedIndex = c
				If VB6.GetItemData(cmbAreas, c) < 1 Then
					cmbMaps.Enabled = False
					cmbEntryPoints.Enabled = False
				Else
					cmbAreas_SelectedIndexChanged(cmbAreas, New System.EventArgs())
				End If
				Exit For
			End If
		Next c
		SetDirty(False)
		frmMDI.Dirty = OldDirt
		Dirty = tmpDirty ' [Titi 2.4.9a] when loading, the form will not set Dirty
		btnApply.Enabled = Dirty
	End Sub
	
	Private Sub ConfirmedUpdateEntryPoint()
		EntryPointX.Name = txtName.Text
		EntryPointX.Description = txtDescription.Text
		EntryPointX.Style = VB6.GetItemData(cmbStyle, cmbStyle.SelectedIndex)
		EntryPointX.MapStyle = VB6.GetItemData(cmbMapStyle, cmbMapStyle.SelectedIndex)
		EntryPointX.MapX = Val(txtMapX.Text)
		EntryPointX.MapY = Val(txtMapY.Text)
		EntryPointX.IsNoExitSign = chkIsNoExitSign.CheckState * CShort(True)
		If cmbAreas.SelectedIndex > -1 Then
			EntryPointX.AreaIndex = VB6.GetItemData(cmbAreas, cmbAreas.SelectedIndex)
		End If
		If cmbMaps.SelectedIndex > -1 Then
			EntryPointX.MapIndex = VB6.GetItemData(cmbMaps, cmbMaps.SelectedIndex)
		End If
		If cmbEntryPoints.SelectedIndex > -1 Then
			EntryPointX.EntryIndex = VB6.GetItemData(cmbEntryPoints, cmbEntryPoints.SelectedIndex)
		End If
		' Update name in project list
		frmProject.tvwProject.Nodes(Me.Tag).Text = EntryPointX.Name & " (" & EntryPointX.MapX & "," & EntryPointX.MapY & ")"
		SetDirty(False)
	End Sub
	
	Private Sub UpdateEntryPoint()
		Dim EntryPointZ As EntryPoint
		EntryPointZ = New EntryPoint
		EntryPointZ.Name = txtName.Text
		EntryPointZ.Description = txtDescription.Text
		EntryPointZ.Style = VB6.GetItemData(cmbStyle, cmbStyle.SelectedIndex)
		EntryPointZ.MapStyle = VB6.GetItemData(cmbMapStyle, cmbMapStyle.SelectedIndex)
		EntryPointZ.MapX = Val(txtMapX.Text)
		EntryPointZ.MapY = Val(txtMapY.Text)
		EntryPointZ.IsNoExitSign = chkIsNoExitSign.CheckState * CShort(True)
		If cmbAreas.SelectedIndex > -1 Then
			EntryPointZ.AreaIndex = VB6.GetItemData(cmbAreas, cmbAreas.SelectedIndex)
		End If
		If cmbMaps.SelectedIndex > -1 Then
			EntryPointZ.MapIndex = VB6.GetItemData(cmbMaps, cmbMaps.SelectedIndex)
		End If
		If cmbEntryPoints.SelectedIndex > -1 Then
			EntryPointZ.EntryIndex = VB6.GetItemData(cmbEntryPoints, cmbEntryPoints.SelectedIndex)
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object CheckValidity(EntryPointZ, True). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If CheckValidity(EntryPointZ, True) Then
			ConfirmedUpdateEntryPoint()
		End If
	End Sub
	
	Private Function CheckValidity(ByRef EntryPointX As EntryPoint, Optional ByRef blnShowMsg As Boolean = False) As Object
		' [Titi 2.4.8] checks if the origin and destination are valid entrypoints
		Dim blnValid As Boolean
		Dim i As Short
		Dim EntryPointZ As EntryPoint
		Dim MapZ As Map
		' [Titi 2.4.9b] first, check if the coordinates are within the boundaries
		If EntryPointX.MapX <= MapX.Width And EntryPointX.MapY <= MapX.Height Then
			' now, is the entrypoint on a valid tile?
			If MapX.BottomTile(EntryPointX.MapX, EntryPointX.MapY) <> 0 Then
				' check if this tile allows movement
				For i = 0 To 3
					If MapX.Blocked(EntryPointX.MapX, EntryPointX.MapY, i) = False Then
						blnValid = True
					End If
				Next i
			End If
		End If
		If blnValid = False Then
			If blnShowMsg Then MsgBox("Check the origin entrypoint!", MsgBoxStyle.OKOnly, "Invalid entrypoint!")
		Else
			blnValid = False
			'OK, now let's see what happens on the other side of the entrypoint
			If EntryPointX.AreaIndex <= 0 Then 'Or cmbEntryPoints.ListIndex = -1 Then
				' entrypoint goes to main menu or is random
				blnValid = True
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Areas(A & cmbAreas.ItemData(cmbAreas.ListIndex)).Plot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each MapZ In TomeX.Areas.Item("A" & VB6.GetItemData(cmbAreas, cmbAreas.SelectedIndex)).Plot.Maps
					If EntryPointX.MapIndex = MapZ.Index Then
						'                    For Each EntryPointZ In MapZ.EntryPoints
						'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Areas().Plot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						For	Each EntryPointZ In TomeX.Areas.Item("A" & VB6.GetItemData(cmbAreas, cmbAreas.SelectedIndex)).Plot.Maps("M" & VB6.GetItemData(cmbMaps, cmbMaps.SelectedIndex)).EntryPoints
							If EntryPointX.EntryIndex = EntryPointZ.Index Then
								' [Titi 2.4.9b] case of maps inserted from the library: what if the entrypoints were wrong initially?
								If EntryPointZ.MapX <= MapZ.Width And EntryPointZ.MapY <= MapZ.Height Then
									If MapZ.BottomTile(EntryPointZ.MapX, EntryPointZ.MapY) <> 0 Then
										For i = 0 To 3
											If MapZ.Blocked(EntryPointZ.MapX, EntryPointZ.MapY, i) = False Then
												blnValid = True
											End If
										Next i
									End If
								End If
							End If
						Next EntryPointZ
					End If
				Next MapZ
			End If
			If Not blnValid Then
				If blnShowMsg Then MsgBox("Check the destination entrypoint!", MsgBoxStyle.OKOnly, "Invalid entrypoint!")
			End If
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object CheckValidity. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CheckValidity = blnValid
	End Function
	
	Private Sub SetDirty(ByRef Flag As Short)
		btnApply.Enabled = Flag
		Dirty = Flag
		If Dirty = True Then
			frmMDI.Dirty = True
		End If
	End Sub
	
	Private Sub btnApply_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnApply.Click
		UpdateEntryPoint()
		ShowEntryPoint(TomeX, MapX, EntryPointX)
	End Sub
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		' [Titi 2.6.3] cancelling a new entry point means we won't keep it
		If VB.Right("   " & Me.Tag, 3) = "NEW" Then frmMDI.EditCut(VB.Left(Me.Tag, Len(Me.Tag) - 3))
		Me.Close()
	End Sub
	
	Private Sub btnOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOk.Click
		UpdateEntryPoint()
		' [Titi 2.4.8] added EntryPoint verification
		'UPGRADE_WARNING: Couldn't resolve default property of object CheckValidity(EntryPointX, True). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If CheckValidity(EntryPointX, True) Then
			' [Titi 2.6.3] cancelling an updated entry point only means we won't keep the changes since the last ones so we update the tag
			If VB.Right("   " & Me.Tag, 3) = "NEW" Then Me.Tag = VB.Left(Me.Tag, Len(Me.Tag) - 3)
			Me.Close()
		End If
	End Sub
	
	'UPGRADE_WARNING: Event chkIsNoExitSign.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkIsNoExitSign_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkIsNoExitSign.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbAreas.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbAreas_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbAreas.SelectedIndexChanged
		Dim i, c, Found As Short
		Dim MapZ As Map
		If cmbAreas.SelectedIndex > -1 Then
			If VB6.GetItemData(cmbAreas, cmbAreas.SelectedIndex) < 1 Then
				cmbMaps.Enabled = False
				cmbMaps.SelectedIndex = -1
				cmbEntryPoints.Enabled = False
				cmbEntryPoints.SelectedIndex = -1
			Else
				cmbMaps.Enabled = True
				cmbEntryPoints.Enabled = True
				cmbMaps.Items.Clear()
				'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Areas(A & cmbAreas.ItemData(cmbAreas.ListIndex)).Plot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each MapZ In TomeX.Areas.Item("A" & VB6.GetItemData(cmbAreas, cmbAreas.SelectedIndex)).Plot.Maps
					cmbMaps.Items.Add(New VB6.ListBoxItem(MapZ.Name, MapZ.Index))
					If EntryPointX.MapIndex = MapZ.Index Then
						'UPGRADE_ISSUE: ComboBox property cmbMaps.NewIndex was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
						cmbMaps.SelectedIndex = cmbMaps.NewIndex
					End If
				Next MapZ
				cmbMaps_SelectedIndexChanged(cmbMaps, New System.EventArgs())
			End If
			SetDirty(True)
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmbEntryPoints.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbEntryPoints_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbEntryPoints.SelectedIndexChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbMaps.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbMaps_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbMaps.SelectedIndexChanged
		Dim c, oldArea As Short
		Dim EntryPointZ As EntryPoint
		Dim MapZ As Map
		' [Titi 2.4.9] get current area index
		c = Len(frmProject.lblProjectArea.Text)
		While Val(Mid(frmProject.lblProjectArea.Text, c)) > 0
			c = c - 1
		End While
		oldArea = Val(VB.Right(frmProject.lblProjectArea.Text, Len(frmProject.lblProjectArea.Text) - c))
		If cmbMaps.SelectedIndex > -1 Then
			cmbEntryPoints.Items.Clear()
			'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Areas().Plot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			For	Each EntryPointZ In TomeX.Areas.Item("A" & VB6.GetItemData(cmbAreas, cmbAreas.SelectedIndex)).Plot.Maps("M" & VB6.GetItemData(cmbMaps, cmbMaps.SelectedIndex)).EntryPoints
				cmbEntryPoints.Items.Add(New VB6.ListBoxItem(EntryPointZ.Name, EntryPointZ.Index))
				If EntryPointX.EntryIndex = EntryPointZ.Index Then
					'UPGRADE_ISSUE: ComboBox property cmbEntryPoints.NewIndex was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
					cmbEntryPoints.SelectedIndex = cmbEntryPoints.NewIndex
				End If
			Next EntryPointZ
			SetDirty(True)
		Else
			' [Titi 2.4.9] refresh the entrypoints list
			If VB6.GetItemData(cmbAreas, cmbAreas.SelectedIndex) < 1 Then
				cmbMaps.Enabled = False
				cmbMaps.SelectedIndex = -1
				cmbEntryPoints.Enabled = False
				cmbEntryPoints.SelectedIndex = -1
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Areas(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				frmMDI.OpenArea(TomeX.Areas.Item("A" & VB6.GetItemData(cmbAreas, cmbAreas.SelectedIndex)))
				cmbMaps.Enabled = True
				cmbEntryPoints.Enabled = True
				cmbMaps.Items.Clear()
				'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Areas(A & cmbAreas.ItemData(cmbAreas.ListIndex)).Plot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each MapZ In TomeX.Areas.Item("A" & VB6.GetItemData(cmbAreas, cmbAreas.SelectedIndex)).Plot.Maps
					cmbMaps.Items.Add(New VB6.ListBoxItem(MapZ.Name, MapZ.Index))
					If EntryPointX.MapIndex = MapZ.Index Then
						'UPGRADE_ISSUE: ComboBox property cmbMaps.NewIndex was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
						cmbMaps.SelectedIndex = cmbMaps.NewIndex
					End If
				Next MapZ
				' go back to the current area
				'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Areas(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				frmMDI.OpenArea(TomeX.Areas.Item("A" & oldArea))
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmbMapStyle.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbMapStyle_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbMapStyle.SelectedIndexChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbStyle.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbStyle_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbStyle.SelectedIndexChanged
		SetDirty(True)
	End Sub
	
	Private Sub frmEntryPoint_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		If TypeOf Me.ActiveControl Is System.Windows.Forms.TextBox Then
			CtrlKey(Me.ActiveControl, KeyCode, Shift)
		End If
	End Sub
	
	Private Sub frmEntryPoint_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		InitGame()
	End Sub
	
	Private Sub frmEntryPoint_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Dim c As Short
		' [Titi 2.4.9a]
		If Dirty Then
			c = MsgBox("Changes will be lost! Save first?", MsgBoxStyle.YesNo, "Changes not saved!")
			If c = MsgBoxResult.Yes Then
				' [Titi 2.6.3] update the tag before closing
				If VB.Right("   " & Me.Tag, 3) = "NEW" Then Me.Tag = VB.Left(Me.Tag, Len(Me.Tag) - 3)
				btnOk_Click(btnOk, New System.EventArgs())
			Else
				' [Titi 2.6.3] closing a new entry point means we won't keep it
				If VB.Right("   " & Me.Tag, 3) = "NEW" Then
					frmMDI.EditCut(VB.Left(Me.Tag, Len(Me.Tag) - 3))
				End If
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtDescription.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtDescription_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDescription.TextChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtMapX.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtMapX_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMapX.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		If Val(txtMapX.Text) > MapX.Width Then
			txtMapX.Text = VB6.Format(MapX.Width)
		End If
		SetDirty(True)
	End Sub
	
	Private Sub txtMapX_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMapX.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtMapY.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtMapY_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMapY.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		If Val(txtMapY.Text) > MapX.Height Then
			txtMapX.Text = VB6.Format(MapX.Height)
		End If
		SetDirty(True)
	End Sub
	
	Private Sub txtMapY_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMapY.KeyPress
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
End Class