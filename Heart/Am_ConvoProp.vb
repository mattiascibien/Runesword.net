Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmConvoProp
	Inherits System.Windows.Forms.Form
	Dim TreeViewX As AxComctlLib.AxTreeView
	Dim CreatureX As Creature
	Dim ConversationX As Conversation
	Dim Dirty As Short
	
	Const bdGeneral As Short = 1
	Const bdTopics As Short = 2
	
	Public Sub ListTopics()
		Dim c As Short
		If tabConvoProp.SelectedItem.Tag = bdTopics Then
			lstThings.Items.Clear()
			For c = 1 To ConversationX.Topics.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object ConversationX.Topics(c).Default. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If ConversationX.Topics.Item(c).Default = True Then
					'UPGRADE_WARNING: Couldn't resolve default property of object ConversationX.Topics().Say. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					lstThings.Items.Add("<Default> " & ConversationX.Topics.Item(c).Say)
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object ConversationX.Topics().Say. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					lstThings.Items.Add(ConversationX.Topics.Item(c).Say)
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object ConversationX.Topics().Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: ListBox property lstThings.NewIndex was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
				VB6.SetItemData(lstThings, lstThings.NewIndex, ConversationX.Topics.Item(c).Index)
			Next c
		End If
	End Sub
	
	Private Sub CutThing()
		If lstThings.SelectedIndex > -1 Then
			Select Case tabConvoProp.SelectedItem.Tag
				Case bdTopics
					frmMDI.EditCut(Me.Tag & "Q" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
		End If
	End Sub
	
	Private Sub EditThing()
		If lstThings.SelectedIndex > -1 Then
			Select Case tabConvoProp.SelectedItem.Tag
				Case bdTopics
					frmMDI.EditProperties(Me.Tag & "Q" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
		End If
	End Sub
	
	Private Sub InsertThing()
		Select Case tabConvoProp.SelectedItem.Tag
			Case bdTopics
				frmMDI.EditAdd(Me.Tag, bdEditTopic)
		End Select
	End Sub
	
	Private Sub CopyThing()
		Select Case tabConvoProp.SelectedItem.Tag
			Case bdTopics
				frmMDI.EditCopy(Me.Tag & "Q" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
		End Select
	End Sub
	
	Private Sub PasteThing()
		Select Case tabConvoProp.SelectedItem.Tag
			Case bdTopics
				If frmMDI.BufferType = bdEditTopic Then
					frmMDI.EditPaste(Me.Tag)
				End If
		End Select
	End Sub
	
	Private Sub SetDirty(ByRef Flag As Short)
		btnApply.Enabled = Flag
		Dirty = Flag
		If Dirty = True Then
			frmMDI.Dirty = True
		End If
	End Sub
	
	Private Sub UpdateConvo()
		ConversationX.Name = txtName.Text
		If chkDefault.CheckState > 0 Then
			CreatureX.CurrentConvo = ConversationX.Index
		End If
		ConversationX.FirstTalk = txtFirstTalk.Text
		ConversationX.HaveTalked = chkHaveTalked.CheckState * CShort(True)
		ConversationX.SecondTalk = txtSecondTalk.Text
		TreeViewX.Nodes(Me.Tag).Text = ConversationX.Name
		SetDirty(False)
	End Sub
	
	Public Sub ShowConvo(ByRef InTree As AxComctlLib.AxTreeView, ByRef InCreature As Creature, ByRef InConvo As Conversation)
		Dim OldDirt, tmpDirty As Short
		tmpDirty = Dirty '[Titi 2.4.9a]
		OldDirt = frmMDI.Dirty
		TreeViewX = InTree
		CreatureX = InCreature
		ConversationX = InConvo
		Me.Text = "Conversation [" & ConversationX.Name & "]"
		txtName.Text = ConversationX.Name
		chkDefault.CheckState = CShort(CreatureX.CurrentConvo = ConversationX.Index) * CShort(True)
		txtFirstTalk.Text = ConversationX.FirstTalk
		chkHaveTalked.CheckState = ConversationX.HaveTalked * CShort(True)
		txtSecondTalk.Text = ConversationX.SecondTalk
		SetDirty(False)
		frmMDI.Dirty = OldDirt
		Dirty = tmpDirty ' [Titi 2.4.9a] when loading, the form will not set Dirty
		btnApply.Enabled = Dirty
	End Sub
	
	Private Sub btnApply_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnApply.Click
		UpdateConvo()
	End Sub
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		' [Titi 2.6.3] cancelling a new convo means we won't keep it
		If VB.Right("   " & Me.Tag, 3) = "NEW" Then frmMDI.EditCut(VB.Left(Me.Tag, Len(Me.Tag) - 3))
		Me.Close()
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
		' [Titi 2.4.9b] check if there's a way to end the convo when the creature can't be ignored
		Dim TopicX As Topic
		Dim Found As Boolean
		Dim ConvoX As Conversation
		If CreatureX.Agressive = True Then
			For	Each ConvoX In CreatureX.Conversations
				For	Each TopicX In ConvoX.Topics
					If TopicX.Action = 5 Then
						Found = True
						Exit For
					End If
				Next TopicX
			Next ConvoX
			If Not Found Then MsgBox("You should include a 'Close Convo' topic...", MsgBoxStyle.Exclamation, "Never ending conversation!")
		End If
		' [Titi 2.6.3] cancelling a validated convo only means we won't keep the changes since the last ones so we update the tag
		If VB.Right("   " & Me.Tag, 3) = "NEW" Then Me.Tag = VB.Left(Me.Tag, Len(Me.Tag) - 3)
		UpdateConvo()
		Me.Close()
	End Sub
	
	Private Sub btnPaste_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnPaste.Click
		PasteThing()
	End Sub
	
	'UPGRADE_WARNING: Event chkDefault.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkDefault_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkDefault.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkHaveTalked.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkHaveTalked_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkHaveTalked.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Form event frmConvoProp.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmConvoProp_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		' [Titi 2.6.0] Make sure we're still working with the relevant treeview and objectlist
		If VB.Left(Me.Tag, 4) = "Tome" Then
			frmMDI.TreeViewX = frmProject.tvwTome.GetOcx
			frmMDI.ObjectListX = frmProject.TomeList
		Else
			frmMDI.TreeViewX = frmProject.tvwProject.GetOcx
			frmMDI.ObjectListX = frmProject.AreaList
		End If
	End Sub
	
	Private Sub frmConvoProp_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Dim CtrlKey As Object
		If TypeOf Me.ActiveControl Is System.Windows.Forms.TextBox Then
			CtrlKey(Me.ActiveControl, KeyCode, Shift)
		End If
	End Sub
	
	Private Sub frmConvoProp_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Dim c As Short
		' [Titi 2.4.9a]
		If Dirty Then
			c = MsgBox("Changes will be lost! Save first?", MsgBoxStyle.YesNo, "Changes not saved!")
			If c = MsgBoxResult.Yes Then
				' [Titi 2.6.3] update the tag before closing
				If VB.Right("   " & Me.Tag, 3) = "NEW" Then Me.Tag = VB.Left(Me.Tag, Len(Me.Tag) - 3)
				btnOk_Click(btnOk, New System.EventArgs())
			Else
				' [Titi 2.6.3] closing a new convo means we won't keep it
				If VB.Right("   " & Me.Tag, 3) = "NEW" Then
					frmMDI.EditCut(VB.Left(Me.Tag, Len(Me.Tag) - 3))
				End If
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event lstThings.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstThings_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstThings.SelectedIndexChanged
		Select Case tabConvoProp.SelectedItem.Tag
			Case bdTopics
				TreeViewX.Nodes(Me.Tag & "Q" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
		End Select
	End Sub
	
	Private Sub lstThings_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstThings.DoubleClick
		EditThing()
	End Sub
	
	Private Sub tabConvoProp_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabConvoProp.ClickEvent
		Select Case tabConvoProp.SelectedItem.Tag
			Case bdGeneral
				fraConvoProp(0).BringToFront()
			Case bdTopics
				fraConvoProp(1).BringToFront()
				ListTopics()
		End Select
	End Sub
	
	'UPGRADE_WARNING: Event txtFirstTalk.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtFirstTalk_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFirstTalk.TextChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtName.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtName_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtName.TextChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtSecondTalk.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtSecondTalk_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSecondTalk.TextChanged
		SetDirty(True)
	End Sub
End Class