Option Strict Off
Option Explicit On
Friend Class frmErrorDialog
	Inherits System.Windows.Forms.Form
	
	
	Private Sub OKButton_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles OKButton.Click
		'frmErrorDialog.Visible = False
		Me.Close()
		'Set frmErrorDialog = Nothing
	End Sub
End Class