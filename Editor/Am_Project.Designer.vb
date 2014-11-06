<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmProject
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
		Me.MDIParent = rsCreator.frmMDI
		rsCreator.frmMDI.Show
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
	Public WithEvents tmrScroll As System.Windows.Forms.Timer
	Public WithEvents tmrExpandNode As System.Windows.Forms.Timer
	Public WithEvents picOutline As System.Windows.Forms.PictureBox
	Public WithEvents picSign As System.Windows.Forms.PictureBox
	Public WithEvents _picMap_0 As System.Windows.Forms.PictureBox
	Public WithEvents _picCMap_0 As System.Windows.Forms.PictureBox
	Public WithEvents picBlack As System.Windows.Forms.PictureBox
	Public WithEvents picItem As System.Windows.Forms.PictureBox
	Public WithEvents tvwProject As AxComctlLib.AxTreeView
	Public WithEvents tvwTome As AxComctlLib.AxTreeView
	Public WithEvents lblProjectTome As System.Windows.Forms.Label
	Public WithEvents lblProjectArea As System.Windows.Forms.Label
	Public WithEvents imgProject As AxComctlLib.AxImageList
	Public WithEvents picCMap As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
	Public WithEvents picMap As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProject))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tmrScroll = New System.Windows.Forms.Timer(components)
		Me.tmrExpandNode = New System.Windows.Forms.Timer(components)
		Me.picOutline = New System.Windows.Forms.PictureBox
		Me.picSign = New System.Windows.Forms.PictureBox
		Me._picMap_0 = New System.Windows.Forms.PictureBox
		Me._picCMap_0 = New System.Windows.Forms.PictureBox
		Me.picBlack = New System.Windows.Forms.PictureBox
		Me.picItem = New System.Windows.Forms.PictureBox
		Me.tvwProject = New AxComctlLib.AxTreeView
		Me.tvwTome = New AxComctlLib.AxTreeView
		Me.lblProjectTome = New System.Windows.Forms.Label
		Me.lblProjectArea = New System.Windows.Forms.Label
		Me.imgProject = New AxComctlLib.AxImageList
		Me.picCMap = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(components)
		Me.picMap = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(components)
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tvwProject, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tvwTome, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgProject, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picCMap, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picMap, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ControlBox = False
		Me.ClientSize = New System.Drawing.Size(499, 344)
		Me.Location = New System.Drawing.Point(4, 3)
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
		Me.MinimizeBox = False
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.Enabled = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmProject"
		Me.tmrScroll.Interval = 100
		Me.tmrScroll.Enabled = True
		Me.tmrExpandNode.Interval = 600
		Me.tmrExpandNode.Enabled = True
		Me.picOutline.BackColor = System.Drawing.SystemColors.Window
		Me.picOutline.ForeColor = System.Drawing.SystemColors.WindowText
		Me.picOutline.Size = New System.Drawing.Size(56, 56)
		Me.picOutline.Location = New System.Drawing.Point(336, 108)
		Me.picOutline.TabIndex = 9
		Me.picOutline.Visible = False
		Me.picOutline.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picOutline.Dock = System.Windows.Forms.DockStyle.None
		Me.picOutline.CausesValidation = True
		Me.picOutline.Enabled = True
		Me.picOutline.Cursor = System.Windows.Forms.Cursors.Default
		Me.picOutline.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picOutline.TabStop = True
		Me.picOutline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.picOutline.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.picOutline.Name = "picOutline"
		Me.picSign.BackColor = System.Drawing.Color.Black
		Me.picSign.ForeColor = System.Drawing.SystemColors.WindowText
		Me.picSign.Size = New System.Drawing.Size(32, 32)
		Me.picSign.Location = New System.Drawing.Point(362, 72)
		Me.picSign.Image = CType(resources.GetObject("picSign.Image"), System.Drawing.Image)
		Me.picSign.TabIndex = 8
		Me.picSign.Visible = False
		Me.picSign.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picSign.Dock = System.Windows.Forms.DockStyle.None
		Me.picSign.CausesValidation = True
		Me.picSign.Enabled = True
		Me.picSign.Cursor = System.Windows.Forms.Cursors.Default
		Me.picSign.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picSign.TabStop = True
		Me.picSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.picSign.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.picSign.Name = "picSign"
		Me._picMap_0.BackColor = System.Drawing.Color.Black
		Me._picMap_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._picMap_0.Size = New System.Drawing.Size(48, 44)
		Me._picMap_0.Location = New System.Drawing.Point(272, 8)
		Me._picMap_0.TabIndex = 3
		Me._picMap_0.Visible = False
		Me._picMap_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picMap_0.Dock = System.Windows.Forms.DockStyle.None
		Me._picMap_0.CausesValidation = True
		Me._picMap_0.Enabled = True
		Me._picMap_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._picMap_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picMap_0.TabStop = True
		Me._picMap_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me._picMap_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._picMap_0.Name = "_picMap_0"
		Me._picCMap_0.BackColor = System.Drawing.Color.FromARGB(192, 0, 0)
		Me._picCMap_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._picCMap_0.Size = New System.Drawing.Size(44, 44)
		Me._picCMap_0.Location = New System.Drawing.Point(386, 8)
		Me._picCMap_0.TabIndex = 2
		Me._picCMap_0.Visible = False
		Me._picCMap_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picCMap_0.Dock = System.Windows.Forms.DockStyle.None
		Me._picCMap_0.CausesValidation = True
		Me._picCMap_0.Enabled = True
		Me._picCMap_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._picCMap_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picCMap_0.TabStop = True
		Me._picCMap_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me._picCMap_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._picCMap_0.Name = "_picCMap_0"
		Me.picBlack.BackColor = System.Drawing.SystemColors.Window
		Me.picBlack.ForeColor = System.Drawing.SystemColors.WindowText
		Me.picBlack.Size = New System.Drawing.Size(56, 56)
		Me.picBlack.Location = New System.Drawing.Point(268, 108)
		Me.picBlack.TabIndex = 4
		Me.picBlack.Visible = False
		Me.picBlack.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picBlack.Dock = System.Windows.Forms.DockStyle.None
		Me.picBlack.CausesValidation = True
		Me.picBlack.Enabled = True
		Me.picBlack.Cursor = System.Windows.Forms.Cursors.Default
		Me.picBlack.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picBlack.TabStop = True
		Me.picBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.picBlack.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.picBlack.Name = "picBlack"
		Me.picItem.BackColor = System.Drawing.Color.FromARGB(192, 0, 0)
		Me.picItem.ForeColor = System.Drawing.SystemColors.WindowText
		Me.picItem.Size = New System.Drawing.Size(48, 44)
		Me.picItem.Location = New System.Drawing.Point(328, 8)
		Me.picItem.TabIndex = 1
		Me.picItem.Visible = False
		Me.picItem.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picItem.Dock = System.Windows.Forms.DockStyle.None
		Me.picItem.CausesValidation = True
		Me.picItem.Enabled = True
		Me.picItem.Cursor = System.Windows.Forms.Cursors.Default
		Me.picItem.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picItem.TabStop = True
		Me.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.picItem.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.picItem.Name = "picItem"
		tvwProject.OcxState = CType(resources.GetObject("tvwProject.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tvwProject.Size = New System.Drawing.Size(258, 138)
		Me.tvwProject.Location = New System.Drawing.Point(3, 192)
		Me.tvwProject.TabIndex = 0
		Me.tvwProject.Name = "tvwProject"
		tvwTome.OcxState = CType(resources.GetObject("tvwTome.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tvwTome.Size = New System.Drawing.Size(258, 126)
		Me.tvwTome.Location = New System.Drawing.Point(3, 36)
		Me.tvwTome.TabIndex = 5
		Me.tvwTome.Name = "tvwTome"
		Me.lblProjectTome.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblProjectTome.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.lblProjectTome.Text = "Label1"
		Me.lblProjectTome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.lblProjectTome.Size = New System.Drawing.Size(257, 17)
		Me.lblProjectTome.Location = New System.Drawing.Point(0, 0)
		Me.lblProjectTome.TabIndex = 7
		Me.lblProjectTome.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProjectTome.Enabled = True
		Me.lblProjectTome.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblProjectTome.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblProjectTome.UseMnemonic = True
		Me.lblProjectTome.Visible = True
		Me.lblProjectTome.AutoSize = False
		Me.lblProjectTome.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblProjectTome.Name = "lblProjectTome"
		Me.lblProjectArea.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblProjectArea.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.lblProjectArea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.lblProjectArea.Size = New System.Drawing.Size(257, 17)
		Me.lblProjectArea.Location = New System.Drawing.Point(4, 168)
		Me.lblProjectArea.TabIndex = 6
		Me.lblProjectArea.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProjectArea.Enabled = True
		Me.lblProjectArea.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblProjectArea.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblProjectArea.UseMnemonic = True
		Me.lblProjectArea.Visible = True
		Me.lblProjectArea.AutoSize = False
		Me.lblProjectArea.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblProjectArea.Name = "lblProjectArea"
		imgProject.OcxState = CType(resources.GetObject("imgProject.OcxState"), System.Windows.Forms.AxHost.State)
		Me.imgProject.Location = New System.Drawing.Point(276, 60)
		Me.imgProject.Name = "imgProject"
		Me.picCMap.SetIndex(_picCMap_0, CType(0, Short))
		Me.picMap.SetIndex(_picMap_0, CType(0, Short))
		CType(Me.picMap, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picCMap, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgProject, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tvwTome, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tvwProject, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(picOutline)
		Me.Controls.Add(picSign)
		Me.Controls.Add(_picMap_0)
		Me.Controls.Add(_picCMap_0)
		Me.Controls.Add(picBlack)
		Me.Controls.Add(picItem)
		Me.Controls.Add(tvwProject)
		Me.Controls.Add(tvwTome)
		Me.Controls.Add(lblProjectTome)
		Me.Controls.Add(lblProjectArea)
		Me.Controls.Add(imgProject)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class