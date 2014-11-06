Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmFactoid
	Inherits System.Windows.Forms.Form
	
	Dim Dirty As Short
	Dim TreeViewX As AxComctlLib.AxTreeView
	Dim FactoidX As Factoid
	
	Private Sub InitGame()
		
	End Sub
	
	Public Sub ShowFactoid(ByRef InTree As AxComctlLib.AxTreeView, ByRef InFactoid As Factoid)
		Dim OldDirt, tmpDirty As Short
		tmpDirty = Dirty '[Titi 2.4.9a]
		OldDirt = frmMDI.Dirty
		TreeViewX = InTree
		FactoidX = InFactoid
		txtText.Text = FactoidX.Text
		SetDirty(False)
		frmMDI.Dirty = OldDirt
		Dirty = tmpDirty ' [Titi 2.4.9a] when loading, the form will not set Dirty
		btnApply.Enabled = Dirty
	End Sub
	
	Private Sub UpdateFactoid()
		FactoidX.Text = txtText.Text
		' Update name in project list
		TreeViewX.Nodes(Me.Tag).Text = FactoidX.Text
		SetDirty(False)
	End Sub
	
	Private Sub SetDirty(ByRef Flag As Short)
		btnApply.Enabled = Flag
		Dirty = Flag
		If Dirty = True Then
			frmMDI.Dirty = True
		End If
	End Sub
	
	Private Sub btnApply_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnApply.Click
		UpdateFactoid()
	End Sub
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		' [Titi 2.6.3] cancelling a new factoid means we won't keep it
		If VB.Right("   " & Me.Tag, 3) = "NEW" Then frmMDI.EditCut(VB.Left(Me.Tag, Len(Me.Tag) - 3))
		Me.Close()
	End Sub
	
	Private Sub btnOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOk.Click
		' [Titi 2.6.3] cancelling a validated factoid only means we won't keep the changes since the last ones so we update the tag
		If VB.Right("   " & Me.Tag, 3) = "NEW" Then Me.Tag = VB.Left(Me.Tag, Len(Me.Tag) - 3)
		UpdateFactoid()
		Me.Close()
	End Sub
	
	Private Sub frmFactoid_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		If TypeOf Me.ActiveControl Is System.Windows.Forms.TextBox Then
			CtrlKey(Me.ActiveControl, KeyCode, Shift)
		End If
	End Sub
	
	Private Sub frmFactoid_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		InitGame()
	End Sub
	
	Private Sub frmFactoid_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Dim c As Short
		' [Titi 2.4.9a]
		If Dirty Then
			c = MsgBox("Changes will be lost! Save first?", MsgBoxStyle.YesNo, "Changes not saved!")
			If c = MsgBoxResult.Yes Then
				' [Titi 2.6.3] update the tag before closing
				If VB.Right("   " & Me.Tag, 3) = "NEW" Then Me.Tag = VB.Left(Me.Tag, Len(Me.Tag) - 3)
				btnOk_Click(btnOk, New System.EventArgs())
			Else
				' [Titi 2.6.3] closing a new factoid means we won't keep it
				If VB.Right("   " & Me.Tag, 3) = "NEW" Then
					frmMDI.EditCut(VB.Left(Me.Tag, Len(Me.Tag) - 3))
				End If
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtText.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtText_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtText.TextChanged
		SetDirty(True)
	End Sub
End Class