Option Strict Off
Option Explicit On
Friend Class frmSearch
	Inherits System.Windows.Forms.Form
	Dim ObjectType As Short
	Public OriginNode As Short
	
	Private Sub InitGame()
		optSearch(0).Checked = True
		chkSearch(2).CheckState = System.Windows.Forms.CheckState.Checked
		' Add Direction Options
		cmbSearchDirection.Items.Add("All")
		cmbSearchDirection.Items.Add("Down")
		cmbSearchDirection.Items.Add("Up")
		cmbSearchDirection.SelectedIndex = 0
	End Sub
	
	Public Sub ReplaceList()
		Dim c As Short
		cmbReplaceWith.Items.Clear()
		For c = 1 To frmMDI.CopyBufferSet.Count()
			'UPGRADE_WARNING: Couldn't resolve default property of object frmMDI.CopyBufferTags(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If frmMDI.ParseTag(frmMDI.CopyBufferTags.Item(c)) = ObjectType Then
				'UPGRADE_WARNING: Couldn't resolve default property of object frmMDI.CopyBufferSet(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				cmbReplaceWith.Items.Add(New VB6.ListBoxItem(frmMDI.CopyBufferSet.Item(c).Name, c))
			End If
		Next c
		cmbReplaceWith.Enabled = (cmbReplaceWith.Items.Count > 0)
		btnReplace.Enabled = (cmbReplaceWith.Items.Count > 0)
		btnReplaceAll.Enabled = (cmbReplaceWith.Items.Count > 0)
		If cmbReplaceWith.Enabled = True Then
			cmbReplaceWith.SelectedIndex = 0
		End If
		'UPGRADE_WARNING: Form method frmSearch.ZOrder has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		Me.BringToFront() ' [Titi 2.6.0] display the form on top of the other windows
	End Sub
	
	Public Function FindNext(ByRef Silent As Short) As Short
		FindNext = frmMDI.FindNext((txtFindWhat.Text), ObjectType, (cmbSearchDirection.SelectedIndex), chkSearch(0).CheckState = 1, chkSearch(1).CheckState = 1, chkSearch(2).CheckState = 1, Silent)
	End Function
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		Me.Close()
	End Sub
	
	Private Sub btnFindNext_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnFindNext.Click
		FindNext(False)
	End Sub
	
	Private Sub btnReplace_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnReplace.Click
		If cmbReplaceWith.SelectedIndex > -1 Then
			frmMDI.FindReplace(VB6.GetItemData(cmbReplaceWith, cmbReplaceWith.SelectedIndex), True)
			FindNext(False)
		End If
	End Sub
	
	Private Sub btnReplaceAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnReplaceAll.Click
		Dim Found As Short
		If cmbReplaceWith.SelectedIndex > -1 Then
			frmMDI.FindReplace(VB6.GetItemData(cmbReplaceWith, cmbReplaceWith.SelectedIndex), False, True)
			' [Titi 2.4.8] save starting to position to avoid endless loop
			OriginNode = frmMDI.TreeViewX.SelectedItem.Index
			Do Until FindNext(True) = False
				' [Titi 2.4.9] count how many occurrences
				Found = Found + 1
				frmMDI.FindReplace(VB6.GetItemData(cmbReplaceWith, cmbReplaceWith.SelectedIndex), False, True)
			Loop 
			' [Titi 2.5.1] reopen the node we were at before
			If frmMDI.TreeViewX.Name = "tvwProject" Then
				frmMDI.OpenArea(Area)
			End If
			frmMDI.TreeViewX.SelectedItem = frmMDI.TreeViewX.Nodes.Item(OriginNode)
		End If
		OriginNode = 0
		MsgBox(Found & " item" & IIf(Found > 1, "s replaced.", " replaced."))
	End Sub
	
	Private Sub frmSearch_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		InitGame()
	End Sub
	
	'UPGRADE_WARNING: Event optSearch.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optSearch_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optSearch.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = optSearch.GetIndex(eventSender)
			Dim c As Short
			For c = 0 To 4
				If optSearch(c).Checked = True Then
					Select Case c
						Case 0 ' Encounters
							ObjectType = bdEditEncounter
						Case 1 ' Creatures
							ObjectType = bdEditCreature
						Case 2 ' Items
							ObjectType = bdEditItem
						Case 3 ' Triggers
							ObjectType = bdEditTrigger
						Case 4 ' Data files [Titi] 2.4.6
							ObjectType = bdEditData
					End Select
					Exit For
				End If
			Next c
			ReplaceList()
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtFindWhat.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtFindWhat_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFindWhat.TextChanged
		frmMDI.LastNode = 0
	End Sub
End Class