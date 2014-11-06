<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmTileSetProp
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
	Public dlgFileOpen As System.Windows.Forms.OpenFileDialog
	Public WithEvents picCombatWallpaper As System.Windows.Forms.PictureBox
	Public WithEvents btnBrowse As System.Windows.Forms.Button
	Public WithEvents txtCombatPic As System.Windows.Forms.TextBox
	Public WithEvents txtName As System.Windows.Forms.TextBox
	Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents _Label1_8 As System.Windows.Forms.Label
	Public WithEvents fraTileSetProp As System.Windows.Forms.GroupBox
	Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents btnOk As System.Windows.Forms.Button
	Public WithEvents btnApply As System.Windows.Forms.Button
	Public WithEvents tabTileSetProp As AxComctlLib.AxTabStrip
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTileSetProp))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.dlgFileOpen = New System.Windows.Forms.OpenFileDialog
		Me.fraTileSetProp = New System.Windows.Forms.GroupBox
		Me.picCombatWallpaper = New System.Windows.Forms.PictureBox
		Me.btnBrowse = New System.Windows.Forms.Button
		Me.txtCombatPic = New System.Windows.Forms.TextBox
		Me.txtName = New System.Windows.Forms.TextBox
		Me._Label1_0 = New System.Windows.Forms.Label
		Me._Label1_8 = New System.Windows.Forms.Label
		Me.btnCancel = New System.Windows.Forms.Button
		Me.btnOk = New System.Windows.Forms.Button
		Me.btnApply = New System.Windows.Forms.Button
		Me.tabTileSetProp = New AxComctlLib.AxTabStrip
		Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.fraTileSetProp.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tabTileSetProp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Combat Wallpaper Properties"
		Me.ClientSize = New System.Drawing.Size(392, 267)
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
		Me.Name = "frmTileSetProp"
		Me.fraTileSetProp.Text = "Attributes"
		Me.fraTileSetProp.Size = New System.Drawing.Size(369, 193)
		Me.fraTileSetProp.Location = New System.Drawing.Point(12, 28)
		Me.fraTileSetProp.TabIndex = 4
		Me.fraTileSetProp.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraTileSetProp.BackColor = System.Drawing.SystemColors.Control
		Me.fraTileSetProp.Enabled = True
		Me.fraTileSetProp.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraTileSetProp.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraTileSetProp.Visible = True
		Me.fraTileSetProp.Padding = New System.Windows.Forms.Padding(0)
		Me.fraTileSetProp.Name = "fraTileSetProp"
		Me.picCombatWallpaper.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.picCombatWallpaper.Size = New System.Drawing.Size(165, 125)
		Me.picCombatWallpaper.Location = New System.Drawing.Point(100, 60)
		Me.picCombatWallpaper.TabIndex = 10
		Me.picCombatWallpaper.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picCombatWallpaper.Dock = System.Windows.Forms.DockStyle.None
		Me.picCombatWallpaper.CausesValidation = True
		Me.picCombatWallpaper.Enabled = True
		Me.picCombatWallpaper.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picCombatWallpaper.Cursor = System.Windows.Forms.Cursors.Default
		Me.picCombatWallpaper.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picCombatWallpaper.TabStop = True
		Me.picCombatWallpaper.Visible = True
		Me.picCombatWallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picCombatWallpaper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picCombatWallpaper.Name = "picCombatWallpaper"
		Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnBrowse.BackColor = System.Drawing.SystemColors.Control
		Me.btnBrowse.Text = "Browse..."
		Me.btnBrowse.Size = New System.Drawing.Size(73, 21)
		Me.btnBrowse.Location = New System.Drawing.Point(288, 31)
		Me.btnBrowse.TabIndex = 7
		Me.btnBrowse.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBrowse.CausesValidation = True
		Me.btnBrowse.Enabled = True
		Me.btnBrowse.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnBrowse.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnBrowse.TabStop = True
		Me.btnBrowse.Name = "btnBrowse"
		Me.txtCombatPic.AutoSize = False
		Me.txtCombatPic.Size = New System.Drawing.Size(113, 19)
		Me.txtCombatPic.Location = New System.Drawing.Point(168, 32)
		Me.txtCombatPic.TabIndex = 6
		Me.txtCombatPic.Text = "Text1"
		Me.txtCombatPic.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCombatPic.AcceptsReturn = True
		Me.txtCombatPic.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCombatPic.BackColor = System.Drawing.SystemColors.Window
		Me.txtCombatPic.CausesValidation = True
		Me.txtCombatPic.Enabled = True
		Me.txtCombatPic.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCombatPic.HideSelection = True
		Me.txtCombatPic.ReadOnly = False
		Me.txtCombatPic.Maxlength = 0
		Me.txtCombatPic.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCombatPic.MultiLine = False
		Me.txtCombatPic.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCombatPic.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCombatPic.TabStop = True
		Me.txtCombatPic.Visible = True
		Me.txtCombatPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCombatPic.Name = "txtCombatPic"
		Me.txtName.AutoSize = False
		Me.txtName.Size = New System.Drawing.Size(149, 19)
		Me.txtName.Location = New System.Drawing.Point(12, 32)
		Me.txtName.TabIndex = 5
		Me.txtName.Text = "123456789012345678901234567890"
		Me.txtName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtName.AcceptsReturn = True
		Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtName.BackColor = System.Drawing.SystemColors.Window
		Me.txtName.CausesValidation = True
		Me.txtName.Enabled = True
		Me.txtName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtName.HideSelection = True
		Me.txtName.ReadOnly = False
		Me.txtName.Maxlength = 0
		Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtName.MultiLine = False
		Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtName.TabStop = True
		Me.txtName.Visible = True
		Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtName.Name = "txtName"
		Me._Label1_0.Text = "Name"
		Me._Label1_0.Size = New System.Drawing.Size(37, 13)
		Me._Label1_0.Location = New System.Drawing.Point(12, 16)
		Me._Label1_0.TabIndex = 9
		Me._Label1_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
		Me._Label1_0.Enabled = True
		Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_0.UseMnemonic = True
		Me._Label1_0.Visible = True
		Me._Label1_0.AutoSize = False
		Me._Label1_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_0.Name = "_Label1_0"
		Me._Label1_8.Text = "Combat Wallpaper"
		Me._Label1_8.Size = New System.Drawing.Size(101, 13)
		Me._Label1_8.Location = New System.Drawing.Point(168, 16)
		Me._Label1_8.TabIndex = 8
		Me._Label1_8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_8.BackColor = System.Drawing.SystemColors.Control
		Me._Label1_8.Enabled = True
		Me._Label1_8.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label1_8.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_8.UseMnemonic = True
		Me._Label1_8.Visible = True
		Me._Label1_8.AutoSize = False
		Me._Label1_8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_8.Name = "_Label1_8"
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
		tabTileSetProp.OcxState = CType(resources.GetObject("tabTileSetProp.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tabTileSetProp.Size = New System.Drawing.Size(385, 229)
		Me.tabTileSetProp.Location = New System.Drawing.Point(4, 4)
		Me.tabTileSetProp.TabIndex = 0
		Me.tabTileSetProp.Name = "tabTileSetProp"
		Me.Label1.SetIndex(_Label1_0, CType(0, Short))
		Me.Label1.SetIndex(_Label1_8, CType(8, Short))
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tabTileSetProp, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(fraTileSetProp)
		Me.Controls.Add(btnCancel)
		Me.Controls.Add(btnOk)
		Me.Controls.Add(btnApply)
		Me.Controls.Add(tabTileSetProp)
		Me.fraTileSetProp.Controls.Add(picCombatWallpaper)
		Me.fraTileSetProp.Controls.Add(btnBrowse)
		Me.fraTileSetProp.Controls.Add(txtCombatPic)
		Me.fraTileSetProp.Controls.Add(txtName)
		Me.fraTileSetProp.Controls.Add(_Label1_0)
		Me.fraTileSetProp.Controls.Add(_Label1_8)
		Me.fraTileSetProp.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class