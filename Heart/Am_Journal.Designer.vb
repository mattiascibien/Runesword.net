<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmJournal
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
		'This form is an MDI child.
		'This code simulates the VB6 
		' functionality of automatically
		' loading and showing an MDI
		' child's parent.
		Me.MDIParent = prjHeart.frmMDI
		prjHeart.frmMDI.Show
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents btnOk As System.Windows.Forms.Button
	Public WithEvents btnApply As System.Windows.Forms.Button
	Public WithEvents txtText As System.Windows.Forms.TextBox
	Public WithEvents tabItemProp As AxComctlLib.AxTabStrip
	Public WithEvents _fraItemProp_0 As System.Windows.Forms.Panel
	Public WithEvents fraItemProp As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmJournal))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.btnCancel = New System.Windows.Forms.Button
		Me.btnOk = New System.Windows.Forms.Button
		Me.btnApply = New System.Windows.Forms.Button
		Me.txtText = New System.Windows.Forms.TextBox
		Me.tabItemProp = New AxComctlLib.AxTabStrip
		Me._fraItemProp_0 = New System.Windows.Forms.Panel
		Me.fraItemProp = New Microsoft.VisualBasic.Compatibility.VB6.PanelArray(components)
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tabItemProp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.fraItemProp, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Journal Properties"
		Me.ClientSize = New System.Drawing.Size(395, 267)
		Me.Location = New System.Drawing.Point(3, 25)
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
		Me.MinimizeBox = False
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmJournal"
		Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.Size = New System.Drawing.Size(73, 21)
		Me.btnCancel.Location = New System.Drawing.Point(236, 240)
		Me.btnCancel.TabIndex = 3
		Me.btnCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancel.CausesValidation = True
		Me.btnCancel.Enabled = True
		Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCancel.TabStop = True
		Me.btnCancel.Name = "btnCancel"
		Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnOk.BackColor = System.Drawing.SystemColors.Control
		Me.btnOk.Text = "OK"
		Me.btnOk.Size = New System.Drawing.Size(73, 21)
		Me.btnOk.Location = New System.Drawing.Point(156, 240)
		Me.btnOk.TabIndex = 2
		Me.btnOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnOk.CausesValidation = True
		Me.btnOk.Enabled = True
		Me.btnOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnOk.TabStop = True
		Me.btnOk.Name = "btnOk"
		Me.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnApply.BackColor = System.Drawing.SystemColors.Control
		Me.btnApply.Text = "Apply"
		Me.btnApply.Enabled = False
		Me.btnApply.Size = New System.Drawing.Size(73, 21)
		Me.btnApply.Location = New System.Drawing.Point(316, 240)
		Me.btnApply.TabIndex = 1
		Me.btnApply.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnApply.CausesValidation = True
		Me.btnApply.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnApply.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnApply.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnApply.TabStop = True
		Me.btnApply.Name = "btnApply"
		Me.txtText.AutoSize = False
		Me.txtText.Size = New System.Drawing.Size(367, 186)
		Me.txtText.Location = New System.Drawing.Point(12, 36)
		Me.txtText.MultiLine = True
		Me.txtText.TabIndex = 0
		Me.txtText.Text = "Day of the Dagger: We were lost and unable to find our way back to the far distant past that I once knew. It could not be worse in my estimate. The thieves are vicisous and numerous --- far too many for me to dispose of singlehandedly. I only hope for some reinforcements soon else all is lost. This would be bad not only for me" & Chr(13) & Chr(10)
		Me.txtText.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtText.AcceptsReturn = True
		Me.txtText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtText.BackColor = System.Drawing.SystemColors.Window
		Me.txtText.CausesValidation = True
		Me.txtText.Enabled = True
		Me.txtText.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtText.HideSelection = True
		Me.txtText.ReadOnly = False
		Me.txtText.Maxlength = 0
		Me.txtText.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtText.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtText.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtText.TabStop = True
		Me.txtText.Visible = True
		Me.txtText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtText.Name = "txtText"
		tabItemProp.OcxState = CType(resources.GetObject("tabItemProp.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tabItemProp.Size = New System.Drawing.Size(385, 229)
		Me.tabItemProp.Location = New System.Drawing.Point(4, 4)
		Me.tabItemProp.TabIndex = 5
		Me.tabItemProp.Name = "tabItemProp"
		Me._fraItemProp_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._fraItemProp_0.Size = New System.Drawing.Size(377, 197)
		Me._fraItemProp_0.Location = New System.Drawing.Point(8, 28)
		Me._fraItemProp_0.TabIndex = 4
		Me._fraItemProp_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraItemProp_0.BackColor = System.Drawing.SystemColors.Control
		Me._fraItemProp_0.Enabled = True
		Me._fraItemProp_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraItemProp_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._fraItemProp_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraItemProp_0.Visible = True
		Me._fraItemProp_0.Name = "_fraItemProp_0"
		Me.fraItemProp.SetIndex(_fraItemProp_0, CType(0, Short))
		CType(Me.fraItemProp, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tabItemProp, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(btnCancel)
		Me.Controls.Add(btnOk)
		Me.Controls.Add(btnApply)
		Me.Controls.Add(txtText)
		Me.Controls.Add(tabItemProp)
		Me.Controls.Add(_fraItemProp_0)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class