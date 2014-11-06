Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmTopic
	Inherits System.Windows.Forms.Form
	Dim TreeViewX As AxComctlLib.AxTreeView
	Dim CreatureX As Creature
	Dim ConvoX As Conversation
	Dim TopicX As Topic
	Dim Dirty As Short
	Dim intAction As Short
	
	Const bdGeneral As Short = 1
	Const bdFactoids As Short = 2
	Const bdTriggers As Short = 3
	
	Const bdActionDoNothing As Short = 0
	Const bdActionSetConvo As Short = 1
	Const bdActionRemove As Short = 2
	Const bdActionAdd As Short = 3
	Const bdActionReplace As Short = 4
	Const bdActionClose As Short = 5
	
	Private Sub SetActionRef(ByRef InAction As Short)
		Dim c As Short
		cmbActionRef.Items.Clear()
		cmbActionRef.Enabled = False
		Select Case InAction
			Case bdActionDoNothing
			Case bdActionSetConvo
				For c = 1 To CreatureX.Conversations.Count()
					'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Conversations(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Conversations(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cmbActionRef.Items.Add(New VB6.ListBoxItem(CreatureX.Conversations.Item(c).Name, CreatureX.Conversations.Item(c).Index))
				Next c
				If cmbActionRef.Items.Count > 0 Then
					cmbActionRef.SelectedIndex = 0
					cmbActionRef.Enabled = True
				End If
			Case bdActionRemove
			Case bdActionAdd
				For c = 1 To ConvoX.Topics.Count()
					'UPGRADE_WARNING: Couldn't resolve default property of object ConvoX.Topics().Say. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cmbActionRef.Items.Add(ConvoX.Topics.Item(c).Say)
					'UPGRADE_WARNING: Couldn't resolve default property of object ConvoX.Topics().Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_ISSUE: ComboBox property cmbActionRef.NewIndex was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
					VB6.SetItemData(cmbActionRef, cmbActionRef.NewIndex, ConvoX.Topics.Item(c).Index)
				Next c
			Case bdActionReplace
				For c = 1 To ConvoX.Topics.Count()
					'UPGRADE_WARNING: Couldn't resolve default property of object ConvoX.Topics().Say. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cmbActionRef.Items.Add(ConvoX.Topics.Item(c).Say)
					'UPGRADE_WARNING: Couldn't resolve default property of object ConvoX.Topics().Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_ISSUE: ComboBox property cmbActionRef.NewIndex was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
					VB6.SetItemData(cmbActionRef, cmbActionRef.NewIndex, ConvoX.Topics.Item(c).Index)
				Next c
			Case bdActionClose
		End Select
		If cmbActionRef.Items.Count > 0 Then
			cmbActionRef.SelectedIndex = 0
			cmbActionRef.Enabled = True
		End If
	End Sub
	
	Private Sub InitGame()
		cmbAction.Items.Add(New VB6.ListBoxItem("Do Nothing", bdActionDoNothing))
		cmbAction.Items.Add(New VB6.ListBoxItem("Set CurrentConvo", bdActionSetConvo))
		cmbAction.Items.Add(New VB6.ListBoxItem("Remove this Topic", bdActionRemove))
		cmbAction.Items.Add(New VB6.ListBoxItem("Add a Topic", bdActionAdd))
		cmbAction.Items.Add(New VB6.ListBoxItem("Replace this Topic", bdActionReplace))
		cmbAction.Items.Add(New VB6.ListBoxItem("Close Conversation", bdActionClose))
	End Sub
	
	Private Sub EditThing()
		If lstThings.SelectedIndex > -1 Then
			Select Case tabTopicProp.SelectedItem.Tag
				Case bdFactoids
					frmMDI.EditProperties(Me.Tag & "F" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdTriggers
					frmMDI.EditProperties(Me.Tag & "T" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
		End If
	End Sub
	
	Private Sub CutThing()
		If lstThings.SelectedIndex > -1 Then
			Select Case tabTopicProp.SelectedItem.Tag
				Case bdFactoids
					frmMDI.EditCut(Me.Tag & "F" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdTriggers
					frmMDI.EditCut(Me.Tag & "T" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
		End If
	End Sub
	
	Private Sub CopyThing()
		If lstThings.SelectedIndex > -1 Then
			Select Case tabTopicProp.SelectedItem.Tag
				Case bdFactoids
					frmMDI.EditCopy(Me.Tag & "F" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdTriggers
					frmMDI.EditCopy(Me.Tag & "T" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
			btnPaste.Enabled = True
		End If
	End Sub
	
	Private Sub PasteThing()
		Select Case tabTopicProp.SelectedItem.Tag
			Case bdFactoids
				If frmMDI.BufferType = bdEditFactoid Then
					frmMDI.EditPaste(Me.Tag)
				End If
			Case bdTriggers
				If frmMDI.BufferType = bdEditTrigger Then
					frmMDI.EditPaste(Me.Tag)
				End If
		End Select
	End Sub
	
	Private Sub InsertThing()
		Select Case tabTopicProp.SelectedItem.Tag
			Case bdFactoids
				frmMDI.EditAdd(Me.Tag, bdEditFactoid)
			Case bdTriggers
				frmMDI.EditAdd(Me.Tag, bdEditTrigger)
		End Select
	End Sub
	
	Private Sub btnApply_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnApply.Click
		UpdateTopic()
	End Sub
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		' [Titi 2.6.3] cancelling a new topic means we won't keep it
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
		' [Titi 2.6.3] cancelling a validated topic only means we won't keep the changes since the last ones so we update the tag
		If VB.Right("   " & Me.Tag, 3) = "NEW" Then Me.Tag = VB.Left(Me.Tag, Len(Me.Tag) - 3)
		UpdateTopic()
		Me.Close()
	End Sub
	
	
	Private Sub btnPaste_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnPaste.Click
		PasteThing()
	End Sub
	
	'UPGRADE_WARNING: Event chkDefault.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkDefault_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkDefault.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbAction.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbAction_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbAction.SelectedIndexChanged
		If cmbAction.SelectedIndex > -1 Then
			SetActionRef(VB6.GetItemData(cmbAction, cmbAction.SelectedIndex))
			SetDirty(True)
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmbActionRef.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	'UPGRADE_WARNING: ComboBox event cmbActionRef.Change was upgraded to cmbActionRef.TextChanged which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
	Private Sub cmbActionRef_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbActionRef.TextChanged ' [Titi 2.4.9] will never be run, wrong combobox type!
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbActionRef.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbActionRef_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbActionRef.SelectedIndexChanged
		If intAction <> cmbActionRef.SelectedIndex Then
			cmbActionRef_TextChanged(cmbActionRef, New System.EventArgs()) ' hehe, could as well be SetDirty True
			intAction = cmbActionRef.SelectedIndex
		End If
	End Sub
	
	Private Sub btnLibrary_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnLibrary.Click
		If btnLibrary.Visible = True Then
			frmMDI.EditLoad(Me.Tag, bdEditTrigger)
		End If
	End Sub
	
	'UPGRADE_WARNING: Form event frmTopic.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmTopic_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		' [Titi 2.6.0] Make sure we're still working with the relevant treeview and objectlist
		If VB.Left(Me.Tag, 4) = "Tome" Then
			frmMDI.TreeViewX = frmProject.tvwTome.GetOcx
			frmMDI.ObjectListX = frmProject.TomeList
		Else
			frmMDI.TreeViewX = frmProject.tvwProject.GetOcx
			frmMDI.ObjectListX = frmProject.AreaList
		End If
	End Sub
	
	Private Sub frmTopic_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Dim CtrlKey As Object
		If TypeOf Me.ActiveControl Is System.Windows.Forms.TextBox Then
			CtrlKey(Me.ActiveControl, KeyCode, Shift)
		End If
	End Sub
	
	Private Sub frmTopic_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		InitGame()
	End Sub
	
	Private Sub frmTopic_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Dim c As Short
		' [Titi 2.4.9a]
		If Dirty Then
			c = MsgBox("Changes will be lost! Save first?", MsgBoxStyle.YesNo, "Changes not saved!")
			If c = MsgBoxResult.Yes Then
				' [Titi 2.6.3] update the tag before closing
				If VB.Right("   " & Me.Tag, 3) = "NEW" Then Me.Tag = VB.Left(Me.Tag, Len(Me.Tag) - 3)
				btnOk_Click(btnOk, New System.EventArgs())
			Else
				' [Titi 2.6.3] closing a new topic means we won't keep it
				If VB.Right("   " & Me.Tag, 3) = "NEW" Then
					frmMDI.EditCut(VB.Left(Me.Tag, Len(Me.Tag) - 3))
				End If
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event lstThings.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstThings_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstThings.SelectedIndexChanged
		Select Case tabTopicProp.SelectedItem.Tag
			Case bdTriggers
				TreeViewX.Nodes(Me.Tag & "T" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
			Case bdFactoids
				TreeViewX.Nodes(Me.Tag & "F" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
		End Select
	End Sub
	
	Private Sub lstThings_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstThings.DoubleClick
		EditThing()
	End Sub
	
	Private Sub tabTopicProp_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabTopicProp.ClickEvent
		Select Case tabTopicProp.SelectedItem.Tag
			Case bdGeneral
				fraTopic(0).BringToFront()
			Case bdFactoids
				fraTopic(1).BringToFront()
				btnLibrary.Enabled = False
				ListFactoids()
			Case bdTriggers
				fraTopic(1).BringToFront()
				btnLibrary.Enabled = True
				ListTriggers()
		End Select
	End Sub
	
	Public Sub ListTriggers()
		Dim c As Short
		If tabTopicProp.SelectedItem.Tag = bdTriggers Then
			lblAttached.Text = "Triggers Attached to Topic:"
			lstThings.Items.Clear()
			For c = 1 To TopicX.Triggers.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object TopicX.Triggers(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object TopicX.Triggers(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object TopicX.Triggers().TriggerType. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstThings.Items.Add(New VB6.ListBoxItem(TriggerName(TopicX.Triggers.Item(c).TriggerType) & " " & TopicX.Triggers.Item(c).Name, TopicX.Triggers.Item(c).Index))
			Next c
		End If
	End Sub
	
	Public Sub ListFactoids()
		Dim c As Short
		lblAttached.Text = "Factoids Required for Topic:"
		lstThings.Items.Clear()
		For c = 1 To TopicX.Factoids.Count()
			'UPGRADE_WARNING: Couldn't resolve default property of object TopicX.Factoids(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object TopicX.Factoids(c).Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lstThings.Items.Add(New VB6.ListBoxItem(TopicX.Factoids.Item(c).Text, TopicX.Factoids.Item(c).Index))
		Next c
	End Sub
	
	Public Sub ShowTopic(ByRef InTree As AxComctlLib.AxTreeView, ByRef InMons As Creature, ByRef InConvo As Conversation, ByRef InTopic As Topic)
		Dim c As Short
		Dim OldDirt, tmpDirty As Short
		OldDirt = frmMDI.Dirty
		tmpDirty = Dirty '[Titi 2.4.9a]
		TreeViewX = InTree
		CreatureX = InMons
		ConvoX = InConvo
		TopicX = InTopic
		Me.Text = "Topic [" & TopicX.Say & "]"
		txtSay.Text = TopicX.Say
		chkDefault.CheckState = TopicX.Default_Renamed * CShort(True)
		txtReply.Text = TopicX.Reply
		cmbAction.SelectedIndex = TopicX.Action
		Select Case VB6.GetItemData(cmbAction, cmbAction.SelectedIndex)
			Case bdActionAdd, bdActionReplace, bdActionSetConvo
				For c = 1 To cmbActionRef.Items.Count
					If VB6.GetItemData(cmbActionRef, c - 1) = TopicX.ActionRef Then
						cmbActionRef.SelectedIndex = c - 1
						intAction = cmbActionRef.SelectedIndex
						Exit For
					End If
				Next c
		End Select
		ListTriggers()
		SetDirty(False)
		frmMDI.Dirty = OldDirt
		Dirty = tmpDirty ' [Titi 2.4.9a] when loading, the form will not set Dirty
		btnApply.Enabled = Dirty
	End Sub
	
	Private Sub UpdateTopic()
		TopicX.Say = txtSay.Text
		TopicX.Default_Renamed = chkDefault.CheckState * CShort(True)
		TopicX.Reply = txtReply.Text
		TopicX.Action = VB6.GetItemData(cmbAction, cmbAction.SelectedIndex)
		If cmbActionRef.SelectedIndex > -1 Then
			TopicX.ActionRef = VB6.GetItemData(cmbActionRef, cmbActionRef.SelectedIndex)
		End If
		' Update ProjectList
		TreeViewX.Nodes(Me.Tag).Text = TopicX.Say
		SetDirty(False)
	End Sub
	
	Private Sub SetDirty(ByRef Flag As Short)
		btnApply.Enabled = Flag
		Dirty = Flag
		If Dirty = True Then
			frmMDI.Dirty = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtReply.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtReply_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtReply.TextChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtSay.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtSay_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSay.TextChanged
		SetDirty(True)
	End Sub
End Class