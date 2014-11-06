<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAbout
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
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
	Public WithEvents picIcon As System.Windows.Forms.PictureBox
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents cmdSysInfo As System.Windows.Forms.Button
	Public WithEvents _Line1_1 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents lblDescription As System.Windows.Forms.Label
	Public WithEvents lblTitle As System.Windows.Forms.Label
	Public WithEvents _Line1_0 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents lblBuild As System.Windows.Forms.Label
	Public WithEvents lblDisclaimer As System.Windows.Forms.Label
	Public WithEvents Line1 As LineShapeArray
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAbout))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.picIcon = New System.Windows.Forms.PictureBox
		Me.cmdOK = New System.Windows.Forms.Button
		Me.cmdSysInfo = New System.Windows.Forms.Button
		Me._Line1_1 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.lblDescription = New System.Windows.Forms.Label
		Me.lblTitle = New System.Windows.Forms.Label
		Me._Line1_0 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.lblBuild = New System.Windows.Forms.Label
		Me.lblDisclaimer = New System.Windows.Forms.Label
		Me.Line1 = New LineShapeArray(components)
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.Line1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "About RuneSword: Construction Set"
		Me.ClientSize = New System.Drawing.Size(382, 237)
		Me.Location = New System.Drawing.Point(156, 129)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmAbout"
		Me.picIcon.Size = New System.Drawing.Size(56, 146)
		Me.picIcon.Location = New System.Drawing.Point(8, 8)
		Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
		Me.picIcon.TabIndex = 6
		Me.picIcon.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picIcon.Dock = System.Windows.Forms.DockStyle.None
		Me.picIcon.BackColor = System.Drawing.SystemColors.Control
		Me.picIcon.CausesValidation = True
		Me.picIcon.Enabled = True
		Me.picIcon.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picIcon.Cursor = System.Windows.Forms.Cursors.Default
		Me.picIcon.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picIcon.TabStop = True
		Me.picIcon.Visible = True
		Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picIcon.Name = "picIcon"
		Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CancelButton = Me.cmdOK
		Me.cmdOK.Text = "OK"
		Me.AcceptButton = Me.cmdOK
		Me.cmdOK.Size = New System.Drawing.Size(84, 23)
		Me.cmdOK.Location = New System.Drawing.Point(283, 175)
		Me.cmdOK.TabIndex = 0
		Me.cmdOK.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOK.CausesValidation = True
		Me.cmdOK.Enabled = True
		Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOK.TabStop = True
		Me.cmdOK.Name = "cmdOK"
		Me.cmdSysInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSysInfo.Text = "&System Info..."
		Me.cmdSysInfo.Size = New System.Drawing.Size(83, 23)
		Me.cmdSysInfo.Location = New System.Drawing.Point(284, 205)
		Me.cmdSysInfo.TabIndex = 1
		Me.cmdSysInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSysInfo.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSysInfo.CausesValidation = True
		Me.cmdSysInfo.Enabled = True
		Me.cmdSysInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSysInfo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSysInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSysInfo.TabStop = True
		Me.cmdSysInfo.Name = "cmdSysInfo"
		Me._Line1_1.BorderColor = System.Drawing.Color.FromARGB(128, 128, 128)
		Me._Line1_1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me._Line1_1.X1 = 1
		Me._Line1_1.X2 = 26
		Me._Line1_1.Y1 = 11
		Me._Line1_1.Y2 = 11
		Me._Line1_1.BorderWidth = 1
		Me._Line1_1.Visible = True
		Me._Line1_1.Name = "_Line1_1"
		Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblDescription.Text = "License# 0000-0000-0000"
		Me.lblDescription.ForeColor = System.Drawing.Color.Black
		Me.lblDescription.Size = New System.Drawing.Size(259, 115)
		Me.lblDescription.Location = New System.Drawing.Point(70, 40)
		Me.lblDescription.TabIndex = 2
		Me.lblDescription.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDescription.BackColor = System.Drawing.SystemColors.Control
		Me.lblDescription.Enabled = True
		Me.lblDescription.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDescription.UseMnemonic = True
		Me.lblDescription.Visible = True
		Me.lblDescription.AutoSize = False
		Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDescription.Name = "lblDescription"
		Me.lblTitle.Text = "RuneSword: Construction Set"
		Me.lblTitle.ForeColor = System.Drawing.Color.Black
		Me.lblTitle.Size = New System.Drawing.Size(259, 11)
		Me.lblTitle.Location = New System.Drawing.Point(70, 8)
		Me.lblTitle.TabIndex = 4
		Me.lblTitle.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTitle.BackColor = System.Drawing.SystemColors.Control
		Me.lblTitle.Enabled = True
		Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTitle.UseMnemonic = True
		Me.lblTitle.Visible = True
		Me.lblTitle.AutoSize = False
		Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTitle.Name = "lblTitle"
		Me._Line1_0.BorderColor = System.Drawing.Color.White
		Me._Line1_0.BorderWidth = 2
		Me._Line1_0.X1 = 1
		Me._Line1_0.X2 = 26
		Me._Line1_0.Y1 = 11
		Me._Line1_0.Y2 = 11
		Me._Line1_0.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me._Line1_0.Visible = True
		Me._Line1_0.Name = "_Line1_0"
		Me.lblBuild.Text = "Build"
		Me.lblBuild.Size = New System.Drawing.Size(259, 11)
		Me.lblBuild.Location = New System.Drawing.Point(70, 20)
		Me.lblBuild.TabIndex = 5
		Me.lblBuild.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBuild.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblBuild.BackColor = System.Drawing.SystemColors.Control
		Me.lblBuild.Enabled = True
		Me.lblBuild.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblBuild.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblBuild.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblBuild.UseMnemonic = True
		Me.lblBuild.Visible = True
		Me.lblBuild.AutoSize = False
		Me.lblBuild.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblBuild.Name = "lblBuild"
		Me.lblDisclaimer.Text = "Copyright (c) 2001 CrossCut Games, Inc. http://www.runesword.com http://www.shrapnelgames.com"
		Me.lblDisclaimer.ForeColor = System.Drawing.Color.Black
		Me.lblDisclaimer.Size = New System.Drawing.Size(199, 46)
		Me.lblDisclaimer.Location = New System.Drawing.Point(17, 175)
		Me.lblDisclaimer.TabIndex = 3
		Me.lblDisclaimer.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDisclaimer.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDisclaimer.BackColor = System.Drawing.SystemColors.Control
		Me.lblDisclaimer.Enabled = True
		Me.lblDisclaimer.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDisclaimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDisclaimer.UseMnemonic = True
		Me.lblDisclaimer.Visible = True
		Me.lblDisclaimer.AutoSize = False
		Me.lblDisclaimer.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDisclaimer.Name = "lblDisclaimer"
		Me.Controls.Add(picIcon)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(cmdSysInfo)
		Me.ShapeContainer1.Shapes.Add(_Line1_1)
		Me.Controls.Add(lblDescription)
		Me.Controls.Add(lblTitle)
		Me.ShapeContainer1.Shapes.Add(_Line1_0)
		Me.Controls.Add(lblBuild)
		Me.Controls.Add(lblDisclaimer)
		Me.Controls.Add(ShapeContainer1)
		Me.Line1.SetIndex(_Line1_1, CType(1, Short))
		Me.Line1.SetIndex(_Line1_0, CType(0, Short))
		CType(Me.Line1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class