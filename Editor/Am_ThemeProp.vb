Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmThemeProp
	Inherits System.Windows.Forms.Form
	Dim TreeViewX As AxComctlLib.AxTreeView
	Dim MapX As Map
	Dim ThemeX As Theme
	Dim Dirty As Short
	
	Const bdGeneral As Short = 1
	Const bdEncounters As Short = 2
	Const bdCreatures As Short = 3
	Const bdItems As Short = 4
	Const bdTriggers As Short = 5
	Const bdFactoids As Short = 6
	
	Private Sub InitGame()
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
	End Sub
	
	Private Sub SetDirty(ByRef Flag As Short)
		btnApply.Enabled = Flag
		Dirty = Flag
		If Dirty = True Then
			frmMDI.Dirty = True
		End If
	End Sub
	
	Private Sub InsertThing()
		Select Case tabThemeProp.SelectedItem.Tag
			Case bdEncounters
				frmMDI.EditAdd(Me.Tag, bdEditEncounter)
			Case bdCreatures
				frmMDI.EditAdd(Me.Tag, bdEditCreature)
			Case bdItems
				frmMDI.EditAdd(Me.Tag, bdEditItem)
			Case bdTriggers
				frmMDI.EditAdd(Me.Tag, bdEditTrigger)
			Case bdFactoids
				frmMDI.EditAdd(Me.Tag, bdEditFactoid)
		End Select
	End Sub
	
	Private Sub CutThing()
		If lstThings.SelectedIndex > -1 Then
			Select Case tabThemeProp.SelectedItem.Tag
				Case bdEncounters
					frmMDI.EditCut(Me.Tag & "E" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdCreatures
					frmMDI.EditCut(Me.Tag & "X" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdItems
					frmMDI.EditCut(Me.Tag & "I" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdTriggers
					frmMDI.EditCut(Me.Tag & "T" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdFactoids
					frmMDI.EditCut(Me.Tag & "F" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
		End If
	End Sub
	
	Private Sub CopyThing()
		If lstThings.SelectedIndex > -1 Then
			Select Case tabThemeProp.SelectedItem.Tag
				Case bdEncounters
					frmMDI.EditCopy(Me.Tag & "E" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdCreatures
					frmMDI.EditCopy(Me.Tag & "X" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdItems
					frmMDI.EditCopy(Me.Tag & "I" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdTriggers
					frmMDI.EditCopy(Me.Tag & "T" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdFactoids
					frmMDI.EditCopy(Me.Tag & "F" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
		End If
	End Sub
	
	Private Sub PasteThing()
		Select Case tabThemeProp.SelectedItem.Tag
			Case bdEncounters
				If frmMDI.BufferType = bdEditEncounter Then
					frmMDI.EditPaste(Me.Tag)
				End If
			Case bdCreatures
				If frmMDI.BufferType = bdEditCreature Then
					frmMDI.EditPaste(Me.Tag)
				End If
			Case bdItems
				If frmMDI.BufferType = bdEditItem Then
					frmMDI.EditPaste(Me.Tag)
				End If
			Case bdTriggers
				If frmMDI.BufferType = bdEditTrigger Then
					frmMDI.EditPaste(Me.Tag)
				End If
			Case bdFactoids
				If frmMDI.BufferType = bdEditFactoid Then
					frmMDI.EditPaste(Me.Tag)
				End If
		End Select
	End Sub
	
	Private Sub EditThing()
		If lstThings.SelectedIndex > -1 Then
			Select Case tabThemeProp.SelectedItem.Tag
				Case bdEncounters
					frmMDI.EditProperties(Me.Tag & "E" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdCreatures
					frmMDI.EditProperties(Me.Tag & "X" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdItems
					frmMDI.EditProperties(Me.Tag & "I" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdTriggers
					frmMDI.EditProperties(Me.Tag & "T" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdFactoids
					frmMDI.EditProperties(Me.Tag & "F" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
		End If
	End Sub
	
	Public Sub ListEncounters()
		Dim c As Short
		If tabThemeProp.SelectedItem.Tag = bdEncounters Then
			lblAttached.Text = "Encounters Attached to Theme"
			lstThings.Items.Clear()
			For c = 1 To ThemeX.Encounters.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object ThemeX.Encounters(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ThemeX.Encounters(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstThings.Items.Add(New VB6.ListBoxItem(ThemeX.Encounters.Item(c).Name, ThemeX.Encounters.Item(c).Index))
			Next c
		End If
	End Sub
	
	Public Sub ListCreatures()
		Dim c As Short
		If tabThemeProp.SelectedItem.Tag = bdCreatures Then
			lblAttached.Text = "Creatures Attached to Theme"
			lstThings.Items.Clear()
			For c = 1 To ThemeX.Creatures.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object ThemeX.Creatures(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ThemeX.Creatures(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstThings.Items.Add(New VB6.ListBoxItem(ThemeX.Creatures.Item(c).Name, ThemeX.Creatures.Item(c).Index))
			Next c
		End If
	End Sub
	
	Public Sub ListItems()
		Dim c As Short
		If tabThemeProp.SelectedItem.Tag = bdItems Then
			lblAttached.Text = "Items Attached to Theme"
			lstThings.Items.Clear()
			For c = 1 To ThemeX.Items.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object ThemeX.Items(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ThemeX.Items(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstThings.Items.Add(New VB6.ListBoxItem(ThemeX.Items.Item(c).Name, ThemeX.Items.Item(c).Index))
			Next c
		End If
	End Sub
	
	Public Sub ListTriggers()
		Dim c As Short
		If tabThemeProp.SelectedItem.Tag = bdTriggers Then
			lblAttached.Text = "Triggers Attached to Theme"
			lstThings.Items.Clear()
			For c = 1 To ThemeX.Triggers.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object ThemeX.Triggers(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ThemeX.Triggers(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstThings.Items.Add(New VB6.ListBoxItem(ThemeX.Triggers.Item(c).Name, ThemeX.Triggers.Item(c).Index))
			Next c
		End If
	End Sub
	
	Public Sub ListFactoids()
		Dim c As Short
		If tabThemeProp.SelectedItem.Tag = bdFactoids Then
			lblAttached.Text = "Descriptions Attached to Theme"
			lstThings.Items.Clear()
			For c = 1 To ThemeX.Factoids.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object ThemeX.Factoids(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ThemeX.Factoids(c).Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstThings.Items.Add(New VB6.ListBoxItem(ThemeX.Factoids.Item(c).Text, ThemeX.Factoids.Item(c).Index))
			Next c
		End If
	End Sub
	
	Private Sub UpdateTheme()
		ThemeX.Name = txtName.Text
		ThemeX.Comments = txtComments.Text
		ThemeX.Coverage = Val(txtCoverage.Text)
		ThemeX.IsQuest = chkStoryTheme.CheckState * CShort(True)
		ThemeX.IsMajorTheme = chkMajorTheme.CheckState * CShort(True)
		ThemeX.MapStyle = VB6.GetItemData(cmbMapStyle, cmbMapStyle.SelectedIndex)
		ThemeX.PartySize = VB6.GetItemData(cmbPartySize, cmbPartySize.SelectedIndex)
		ThemeX.PartyAvgLevel = VB6.GetItemData(cmbPartyAvgLevel, cmbPartyAvgLevel.SelectedIndex)
		TreeViewX.Nodes(Me.Tag).Text = ThemeX.Name
		SetDirty(False)
	End Sub
	
	Public Sub ShowTheme(ByRef InTree As AxComctlLib.AxTreeView, ByRef InMap As Map, ByRef InTheme As Theme)
		Dim OldDirt, tmpDirty As Short
		tmpDirty = Dirty '[Titi 2.4.9a]
		OldDirt = frmMDI.Dirty
		TreeViewX = InTree
		MapX = InMap
		ThemeX = InTheme
		Me.Text = "Theme [" & ThemeX.Name & "]"
		txtName.Text = ThemeX.Name
		txtComments.Text = ThemeX.Comments
		txtCoverage.Text = CStr(ThemeX.Coverage)
		chkStoryTheme.CheckState = ThemeX.IsQuest * CShort(True)
		chkMajorTheme.CheckState = ThemeX.IsMajorTheme * CShort(True)
		cmbMapStyle.SelectedIndex = ThemeX.MapStyle
		cmbPartySize.SelectedIndex = ThemeX.PartySize
		cmbPartyAvgLevel.SelectedIndex = ThemeX.PartyAvgLevel
		frmMDI.Dirty = OldDirt
		Dirty = tmpDirty ' [Titi 2.4.9a] when loading, the form will not set Dirty
		btnApply.Enabled = Dirty
	End Sub
	
	Private Sub btnApply_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnApply.Click
		UpdateTheme()
		ShowTheme(TreeViewX, MapX, ThemeX)
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
		' [Titi 2.6.3] cancelling a validated theme only means we won't keep the changes since the last ones so we update the tag
		If VB.Right("   " & Me.Tag, 3) = "NEW" Then Me.Tag = VB.Left(Me.Tag, Len(Me.Tag) - 3)
		UpdateTheme()
		Me.Close()
	End Sub
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		' [Titi 2.6.3] cancelling a new theme means we won't keep it
		If VB.Right("   " & Me.Tag, 3) = "NEW" Then frmMDI.EditCut(VB.Left(Me.Tag, Len(Me.Tag) - 3))
		Me.Close()
	End Sub
	
	Private Sub btnPaste_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnPaste.Click
		PasteThing()
	End Sub
	
	Private Sub btnReGen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnReGen.Click
		Dim EncounterX As Encounter
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		UpdateTheme()
		' ReGen Encounters for this Theme
		modDungeonMaker.ThemeMap(MapX, ThemeX)
		frmMDI.OpenArea(Area)
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		MsgBox(ThemeX.Name & " is finished!", MsgBoxStyle.OKOnly, "RuneSword Theme Generator")
		SetDirty(True) ' [Titi 2.5.1]
	End Sub
	
	'UPGRADE_WARNING: Event chkMajorTheme.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkMajorTheme_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkMajorTheme.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkStoryTheme.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkStoryTheme_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkStoryTheme.CheckStateChanged
		SetDirty(True)
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
	
	Private Sub btnLibrary_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnLibrary.Click
		If btnLibrary.Visible = True Then
			Select Case Mid(btnLibrary.Text, 8, 4)
				Case "item"
					frmMDI.EditLoad(Me.Tag, bdEditItem)
				Case "crea"
					frmMDI.EditLoad(Me.Tag, bdEditCreature)
				Case "trig"
					frmMDI.EditLoad(Me.Tag, bdEditTrigger)
				Case "enco"
					frmMDI.EditLoad(Me.Tag, bdEditEncounter)
			End Select
		End If
	End Sub
	
	'UPGRADE_WARNING: Form event frmThemeProp.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmThemeProp_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		' [Titi 2.6.0] Make sure we're still working with the relevant treeview and objectlist
		If VB.Left(Me.Tag, 4) = "Tome" Then
			frmMDI.TreeViewX = frmProject.tvwTome.GetOcx
			frmMDI.ObjectListX = frmProject.TomeList
		Else
			frmMDI.TreeViewX = frmProject.tvwProject.GetOcx
			frmMDI.ObjectListX = frmProject.AreaList
		End If
	End Sub
	
	Private Sub frmThemeProp_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		If TypeOf Me.ActiveControl Is System.Windows.Forms.TextBox Then
			CtrlKey(Me.ActiveControl, KeyCode, Shift)
		End If
	End Sub
	
	Private Sub frmThemeProp_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		InitGame()
	End Sub
	
	Private Sub frmThemeProp_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Dim c As Short
		' [Titi 2.4.9a]
		If Dirty Then
			c = MsgBox("Changes will be lost! Save first?", MsgBoxStyle.YesNo, "Changes not saved!")
			If c = MsgBoxResult.Yes Then
				' [Titi 2.6.3] update the tag before closing
				If VB.Right("   " & Me.Tag, 3) = "NEW" Then Me.Tag = VB.Left(Me.Tag, Len(Me.Tag) - 3)
				btnOk_Click(btnOk, New System.EventArgs())
			Else
				' [Titi 2.6.3] closing a new theme means we won't keep it
				If VB.Right("   " & Me.Tag, 3) = "NEW" Then
					frmMDI.EditCut(VB.Left(Me.Tag, Len(Me.Tag) - 3))
				End If
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event lstThings.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstThings_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstThings.SelectedIndexChanged
		Select Case tabThemeProp.SelectedItem.Tag
			Case bdEncounters
				TreeViewX.Nodes(Me.Tag & "E" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
			Case bdCreatures
				TreeViewX.Nodes(Me.Tag & "X" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
			Case bdItems
				TreeViewX.Nodes(Me.Tag & "I" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
			Case bdTriggers
				TreeViewX.Nodes(Me.Tag & "T" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
			Case bdFactoids
				TreeViewX.Nodes(Me.Tag & "F" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
		End Select
	End Sub
	
	Private Sub lstThings_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstThings.DoubleClick
		EditThing()
	End Sub
	
	Private Sub tabThemeProp_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabThemeProp.ClickEvent
		Select Case tabThemeProp.SelectedItem.Tag
			Case bdGeneral
				fraTheme(0).BringToFront()
			Case bdEncounters
				fraTheme(1).BringToFront()
				btnLibrary.Text = "Insert encounter from library"
				btnLibrary.Visible = True
				ListEncounters()
			Case bdCreatures
				fraTheme(1).BringToFront()
				btnLibrary.Text = "Insert creature from library"
				btnLibrary.Visible = True
				ListCreatures()
			Case bdItems
				fraTheme(1).BringToFront()
				btnLibrary.Text = "Insert item from library"
				btnLibrary.Visible = True
				ListItems()
			Case bdTriggers
				fraTheme(1).BringToFront()
				btnLibrary.Text = "Insert trigger from library"
				btnLibrary.Visible = True
				ListTriggers()
			Case bdFactoids
				fraTheme(1).BringToFront()
				btnLibrary.Visible = False
				ListFactoids()
		End Select
	End Sub
	
	'UPGRADE_WARNING: Event txtComments.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtComments_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtComments.TextChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtCoverage.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtCoverage_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCoverage.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	Private Sub txtCoverage_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCoverage.KeyPress
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