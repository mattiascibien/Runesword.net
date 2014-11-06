<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmTileProp
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
	Public WithEvents txtName As System.Windows.Forms.TextBox
	Public WithEvents _lblSee_2 As System.Windows.Forms.Label
	Public WithEvents _lblSee_3 As System.Windows.Forms.Label
	Public WithEvents _shpSee_3 As Microsoft.VisualBasic.PowerPacks.OvalShape
	Public WithEvents _shpSee_0 As Microsoft.VisualBasic.PowerPacks.OvalShape
	Public WithEvents _shpSee_2 As Microsoft.VisualBasic.PowerPacks.OvalShape
	Public WithEvents _shpSee_1 As Microsoft.VisualBasic.PowerPacks.OvalShape
	Public WithEvents _lnSide_1 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents _lnSide_3 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents _lnSide_2 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents _lnSide_0 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents _lblBlocked_2 As System.Windows.Forms.Label
	Public WithEvents _lblBlocked_3 As System.Windows.Forms.Label
	Public WithEvents _lblSee_0 As System.Windows.Forms.Label
	Public WithEvents _lblSee_1 As System.Windows.Forms.Label
	Public WithEvents _lblBlocked_1 As System.Windows.Forms.Label
	Public WithEvents _lblBlocked_0 As System.Windows.Forms.Label
	Public WithEvents _picTiles_0 As System.Windows.Forms.Panel
	Public WithEvents cmbTileSet As System.Windows.Forms.ComboBox
	Public WithEvents vsbTilePic As System.Windows.Forms.VScrollBar
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents cmbSwapTile As System.Windows.Forms.ComboBox
	Public WithEvents _picTiles_1 As System.Windows.Forms.Panel
	Public WithEvents txtChance As System.Windows.Forms.TextBox
	Public WithEvents _chkKey_3 As System.Windows.Forms.CheckBox
	Public WithEvents _chkKey_4 As System.Windows.Forms.CheckBox
	Public WithEvents _chkKey_5 As System.Windows.Forms.CheckBox
	Public WithEvents _chkKey_6 As System.Windows.Forms.CheckBox
	Public WithEvents _chkKey_7 As System.Windows.Forms.CheckBox
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmbMovementCost As System.Windows.Forms.ComboBox
	Public WithEvents cmbTerrainType As System.Windows.Forms.ComboBox
	Public WithEvents cmbStyle As System.Windows.Forms.ComboBox
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents _lblName_1 As System.Windows.Forms.Label
	Public WithEvents _fraTileProp_0 As System.Windows.Forms.Panel
	Public WithEvents btnApply As System.Windows.Forms.Button
	Public WithEvents btnOk As System.Windows.Forms.Button
	Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents tabTileProp As AxComctlLib.AxTabStrip
	Public WithEvents chkKey As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	Public WithEvents fraTileProp As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
	Public WithEvents lblBlocked As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblName As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblSee As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lnSide As LineShapeArray
	Public WithEvents picTiles As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
	Public WithEvents shpSee As OvalShapeArray
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTileProp))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me._fraTileProp_0 = New System.Windows.Forms.Panel
		Me.txtName = New System.Windows.Forms.TextBox
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me._picTiles_0 = New System.Windows.Forms.Panel
		Me._lblSee_2 = New System.Windows.Forms.Label
		Me._lblSee_3 = New System.Windows.Forms.Label
		Me._shpSee_3 = New Microsoft.VisualBasic.PowerPacks.OvalShape
		Me._shpSee_0 = New Microsoft.VisualBasic.PowerPacks.OvalShape
		Me._shpSee_2 = New Microsoft.VisualBasic.PowerPacks.OvalShape
		Me._shpSee_1 = New Microsoft.VisualBasic.PowerPacks.OvalShape
		Me._lnSide_1 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me._lnSide_3 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me._lnSide_2 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me._lnSide_0 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me._lblBlocked_2 = New System.Windows.Forms.Label
		Me._lblBlocked_3 = New System.Windows.Forms.Label
		Me._lblSee_0 = New System.Windows.Forms.Label
		Me._lblSee_1 = New System.Windows.Forms.Label
		Me._lblBlocked_1 = New System.Windows.Forms.Label
		Me._lblBlocked_0 = New System.Windows.Forms.Label
		Me.cmbTileSet = New System.Windows.Forms.ComboBox
		Me.vsbTilePic = New System.Windows.Forms.VScrollBar
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.cmbSwapTile = New System.Windows.Forms.ComboBox
		Me._picTiles_1 = New System.Windows.Forms.Panel
		Me.txtChance = New System.Windows.Forms.TextBox
		Me._chkKey_3 = New System.Windows.Forms.CheckBox
		Me._chkKey_4 = New System.Windows.Forms.CheckBox
		Me._chkKey_5 = New System.Windows.Forms.CheckBox
		Me._chkKey_6 = New System.Windows.Forms.CheckBox
		Me._chkKey_7 = New System.Windows.Forms.CheckBox
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.cmbMovementCost = New System.Windows.Forms.ComboBox
		Me.cmbTerrainType = New System.Windows.Forms.ComboBox
		Me.cmbStyle = New System.Windows.Forms.ComboBox
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me._lblName_1 = New System.Windows.Forms.Label
		Me.btnApply = New System.Windows.Forms.Button
		Me.btnOk = New System.Windows.Forms.Button
		Me.btnCancel = New System.Windows.Forms.Button
		Me.tabTileProp = New AxComctlLib.AxTabStrip
		Me.chkKey = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(components)
		Me.fraTileProp = New Microsoft.VisualBasic.Compatibility.VB6.PanelArray(components)
		Me.lblBlocked = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblName = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblSee = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lnSide = New LineShapeArray(components)
		Me.picTiles = New Microsoft.VisualBasic.Compatibility.VB6.PanelArray(components)
		Me.shpSee = New OvalShapeArray(components)
		Me._fraTileProp_0.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me._picTiles_0.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tabTileProp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.chkKey, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.fraTileProp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblBlocked, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblSee, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lnSide, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picTiles, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.shpSee, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Tile Properties"
		Me.ClientSize = New System.Drawing.Size(402, 294)
		Me.Location = New System.Drawing.Point(188, 267)
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
		Me.Name = "frmTileProp"
		Me._fraTileProp_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._fraTileProp_0.Text = "Frame5"
		Me._fraTileProp_0.Size = New System.Drawing.Size(385, 225)
		Me._fraTileProp_0.Location = New System.Drawing.Point(8, 28)
		Me._fraTileProp_0.TabIndex = 4
		Me._fraTileProp_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraTileProp_0.BackColor = System.Drawing.SystemColors.Control
		Me._fraTileProp_0.Enabled = True
		Me._fraTileProp_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraTileProp_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._fraTileProp_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraTileProp_0.Visible = True
		Me._fraTileProp_0.Name = "_fraTileProp_0"
		Me.txtName.AutoSize = False
		Me.txtName.Size = New System.Drawing.Size(373, 19)
		Me.txtName.Location = New System.Drawing.Point(8, 20)
		Me.txtName.TabIndex = 33
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
		Me.Frame3.Text = "Description"
		Me.Frame3.Size = New System.Drawing.Size(129, 177)
		Me.Frame3.Location = New System.Drawing.Point(4, 44)
		Me.Frame3.TabIndex = 18
		Me.Frame3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Me._picTiles_0.Size = New System.Drawing.Size(100, 83)
		Me._picTiles_0.Location = New System.Drawing.Point(8, 84)
		Me._picTiles_0.TabIndex = 21
		Me._picTiles_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picTiles_0.Dock = System.Windows.Forms.DockStyle.None
		Me._picTiles_0.BackColor = System.Drawing.SystemColors.Control
		Me._picTiles_0.CausesValidation = True
		Me._picTiles_0.Enabled = True
		Me._picTiles_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picTiles_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._picTiles_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picTiles_0.TabStop = True
		Me._picTiles_0.Visible = True
		Me._picTiles_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._picTiles_0.Name = "_picTiles_0"
		Me._lblSee_2.BackColor = System.Drawing.Color.Transparent
		Me._lblSee_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lblSee_2.Size = New System.Drawing.Size(13, 13)
		Me._lblSee_2.Location = New System.Drawing.Point(10, 62)
		Me._lblSee_2.TabIndex = 23
		Me._lblSee_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblSee_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblSee_2.Enabled = True
		Me._lblSee_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblSee_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblSee_2.UseMnemonic = True
		Me._lblSee_2.Visible = True
		Me._lblSee_2.AutoSize = False
		Me._lblSee_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblSee_2.Name = "_lblSee_2"
		Me._lblSee_3.BackColor = System.Drawing.Color.Transparent
		Me._lblSee_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lblSee_3.Size = New System.Drawing.Size(13, 13)
		Me._lblSee_3.Location = New System.Drawing.Point(74, 62)
		Me._lblSee_3.TabIndex = 22
		Me._lblSee_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblSee_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblSee_3.Enabled = True
		Me._lblSee_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblSee_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblSee_3.UseMnemonic = True
		Me._lblSee_3.Visible = True
		Me._lblSee_3.AutoSize = False
		Me._lblSee_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblSee_3.Name = "_lblSee_3"
		Me._shpSee_3.FillColor = System.Drawing.Color.Blue
		Me._shpSee_3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
		Me._shpSee_3.Size = New System.Drawing.Size(9, 9)
		Me._shpSee_3.Location = New System.Drawing.Point(76, 64)
		Me._shpSee_3.BackColor = System.Drawing.SystemColors.Window
		Me._shpSee_3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me._shpSee_3.BorderColor = System.Drawing.SystemColors.WindowText
		Me._shpSee_3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me._shpSee_3.BorderWidth = 1
		Me._shpSee_3.Visible = True
		Me._shpSee_3.Name = "_shpSee_3"
		Me._shpSee_3.Bounds = New Rectangle(76, 64, 9, 9)
		Me._shpSee_0.FillColor = System.Drawing.Color.Blue
		Me._shpSee_0.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
		Me._shpSee_0.Size = New System.Drawing.Size(9, 9)
		Me._shpSee_0.Location = New System.Drawing.Point(12, 24)
		Me._shpSee_0.BackColor = System.Drawing.SystemColors.Window
		Me._shpSee_0.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me._shpSee_0.BorderColor = System.Drawing.SystemColors.WindowText
		Me._shpSee_0.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me._shpSee_0.BorderWidth = 1
		Me._shpSee_0.Visible = True
		Me._shpSee_0.Name = "_shpSee_0"
		Me._shpSee_0.Bounds = New Rectangle(12, 24, 9, 9)
		Me._shpSee_2.FillColor = System.Drawing.Color.Blue
		Me._shpSee_2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
		Me._shpSee_2.Size = New System.Drawing.Size(9, 9)
		Me._shpSee_2.Location = New System.Drawing.Point(12, 64)
		Me._shpSee_2.BackColor = System.Drawing.SystemColors.Window
		Me._shpSee_2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me._shpSee_2.BorderColor = System.Drawing.SystemColors.WindowText
		Me._shpSee_2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me._shpSee_2.BorderWidth = 1
		Me._shpSee_2.Visible = True
		Me._shpSee_2.Name = "_shpSee_2"
		Me._shpSee_2.Bounds = New Rectangle(12, 64, 9, 9)
		Me._shpSee_1.FillColor = System.Drawing.Color.Blue
		Me._shpSee_1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
		Me._shpSee_1.Size = New System.Drawing.Size(9, 9)
		Me._shpSee_1.Location = New System.Drawing.Point(76, 24)
		Me._shpSee_1.BackColor = System.Drawing.SystemColors.Window
		Me._shpSee_1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me._shpSee_1.BorderColor = System.Drawing.SystemColors.WindowText
		Me._shpSee_1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me._shpSee_1.BorderWidth = 1
		Me._shpSee_1.Visible = True
		Me._shpSee_1.Name = "_shpSee_1"
		Me._shpSee_1.Bounds = New Rectangle(76, 24, 9, 9)
		Me._lnSide_1.BorderColor = System.Drawing.Color.Yellow
		Me._lnSide_1.BorderWidth = 2
		Me._lnSide_1.X1 = 4
		Me._lnSide_1.X2 = 7
		Me._lnSide_1.Y1 = 2
		Me._lnSide_1.Y2 = 4
		Me._lnSide_1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me._lnSide_1.Visible = True
		Me._lnSide_1.Name = "_lnSide_1"
		Me._lnSide_3.BorderColor = System.Drawing.Color.Yellow
		Me._lnSide_3.BorderWidth = 2
		Me._lnSide_3.X1 = 4
		Me._lnSide_3.X2 = 7
		Me._lnSide_3.Y1 = 5
		Me._lnSide_3.Y2 = 4
		Me._lnSide_3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me._lnSide_3.Visible = True
		Me._lnSide_3.Name = "_lnSide_3"
		Me._lnSide_2.BorderColor = System.Drawing.Color.Yellow
		Me._lnSide_2.BorderWidth = 2
		Me._lnSide_2.X1 = 0
		Me._lnSide_2.X2 = 4
		Me._lnSide_2.Y1 = 4
		Me._lnSide_2.Y2 = 5
		Me._lnSide_2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me._lnSide_2.Visible = True
		Me._lnSide_2.Name = "_lnSide_2"
		Me._lnSide_0.BorderColor = System.Drawing.Color.Yellow
		Me._lnSide_0.BorderWidth = 2
		Me._lnSide_0.X1 = 0
		Me._lnSide_0.X2 = 4
		Me._lnSide_0.Y1 = 4
		Me._lnSide_0.Y2 = 2
		Me._lnSide_0.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me._lnSide_0.Visible = True
		Me._lnSide_0.Name = "_lnSide_0"
		Me._lblBlocked_2.BackColor = System.Drawing.Color.Transparent
		Me._lblBlocked_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lblBlocked_2.Size = New System.Drawing.Size(45, 25)
		Me._lblBlocked_2.Location = New System.Drawing.Point(2, 50)
		Me._lblBlocked_2.TabIndex = 27
		Me._lblBlocked_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblBlocked_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblBlocked_2.Enabled = True
		Me._lblBlocked_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblBlocked_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblBlocked_2.UseMnemonic = True
		Me._lblBlocked_2.Visible = True
		Me._lblBlocked_2.AutoSize = False
		Me._lblBlocked_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblBlocked_2.Name = "_lblBlocked_2"
		Me._lblBlocked_3.BackColor = System.Drawing.Color.Transparent
		Me._lblBlocked_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lblBlocked_3.Size = New System.Drawing.Size(45, 25)
		Me._lblBlocked_3.Location = New System.Drawing.Point(50, 50)
		Me._lblBlocked_3.TabIndex = 26
		Me._lblBlocked_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblBlocked_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblBlocked_3.Enabled = True
		Me._lblBlocked_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblBlocked_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblBlocked_3.UseMnemonic = True
		Me._lblBlocked_3.Visible = True
		Me._lblBlocked_3.AutoSize = False
		Me._lblBlocked_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblBlocked_3.Name = "_lblBlocked_3"
		Me._lblSee_0.BackColor = System.Drawing.Color.Transparent
		Me._lblSee_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lblSee_0.Size = New System.Drawing.Size(13, 13)
		Me._lblSee_0.Location = New System.Drawing.Point(10, 22)
		Me._lblSee_0.TabIndex = 25
		Me._lblSee_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblSee_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblSee_0.Enabled = True
		Me._lblSee_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblSee_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblSee_0.UseMnemonic = True
		Me._lblSee_0.Visible = True
		Me._lblSee_0.AutoSize = False
		Me._lblSee_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblSee_0.Name = "_lblSee_0"
		Me._lblSee_1.BackColor = System.Drawing.Color.Transparent
		Me._lblSee_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lblSee_1.Size = New System.Drawing.Size(13, 13)
		Me._lblSee_1.Location = New System.Drawing.Point(74, 22)
		Me._lblSee_1.TabIndex = 24
		Me._lblSee_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblSee_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblSee_1.Enabled = True
		Me._lblSee_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblSee_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblSee_1.UseMnemonic = True
		Me._lblSee_1.Visible = True
		Me._lblSee_1.AutoSize = False
		Me._lblSee_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblSee_1.Name = "_lblSee_1"
		Me._lblBlocked_1.BackColor = System.Drawing.Color.Transparent
		Me._lblBlocked_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lblBlocked_1.Size = New System.Drawing.Size(45, 25)
		Me._lblBlocked_1.Location = New System.Drawing.Point(50, 22)
		Me._lblBlocked_1.TabIndex = 28
		Me._lblBlocked_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblBlocked_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblBlocked_1.Enabled = True
		Me._lblBlocked_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblBlocked_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblBlocked_1.UseMnemonic = True
		Me._lblBlocked_1.Visible = True
		Me._lblBlocked_1.AutoSize = False
		Me._lblBlocked_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblBlocked_1.Name = "_lblBlocked_1"
		Me._lblBlocked_0.BackColor = System.Drawing.Color.Transparent
		Me._lblBlocked_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lblBlocked_0.Size = New System.Drawing.Size(45, 25)
		Me._lblBlocked_0.Location = New System.Drawing.Point(2, 22)
		Me._lblBlocked_0.TabIndex = 29
		Me._lblBlocked_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblBlocked_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblBlocked_0.Enabled = True
		Me._lblBlocked_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblBlocked_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblBlocked_0.UseMnemonic = True
		Me._lblBlocked_0.Visible = True
		Me._lblBlocked_0.AutoSize = False
		Me._lblBlocked_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblBlocked_0.Name = "_lblBlocked_0"
		Me.cmbTileSet.Size = New System.Drawing.Size(115, 21)
		Me.cmbTileSet.Location = New System.Drawing.Point(8, 32)
		Me.cmbTileSet.Sorted = True
		Me.cmbTileSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbTileSet.TabIndex = 20
		Me.cmbTileSet.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbTileSet.BackColor = System.Drawing.SystemColors.Window
		Me.cmbTileSet.CausesValidation = True
		Me.cmbTileSet.Enabled = True
		Me.cmbTileSet.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbTileSet.IntegralHeight = True
		Me.cmbTileSet.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbTileSet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbTileSet.TabStop = True
		Me.cmbTileSet.Visible = True
		Me.cmbTileSet.Name = "cmbTileSet"
		Me.vsbTilePic.Size = New System.Drawing.Size(13, 83)
		Me.vsbTilePic.Location = New System.Drawing.Point(108, 84)
		Me.vsbTilePic.TabIndex = 19
		Me.vsbTilePic.CausesValidation = True
		Me.vsbTilePic.Enabled = True
		Me.vsbTilePic.LargeChange = 1
		Me.vsbTilePic.Maximum = 32767
		Me.vsbTilePic.Minimum = 0
		Me.vsbTilePic.Cursor = System.Windows.Forms.Cursors.Default
		Me.vsbTilePic.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.vsbTilePic.SmallChange = 1
		Me.vsbTilePic.TabStop = True
		Me.vsbTilePic.Value = 0
		Me.vsbTilePic.Visible = True
		Me.vsbTilePic.Name = "vsbTilePic"
		Me.Label2.Text = "Blocked and Visible"
		Me.Label2.Size = New System.Drawing.Size(97, 13)
		Me.Label2.Location = New System.Drawing.Point(8, 68)
		Me.Label2.TabIndex = 31
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.Text = "Uses Wallpaper"
		Me.Label1.Size = New System.Drawing.Size(97, 13)
		Me.Label1.Location = New System.Drawing.Point(8, 16)
		Me.Label1.TabIndex = 30
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Frame1.Text = "Door Tile"
		Me.Frame1.Size = New System.Drawing.Size(117, 177)
		Me.Frame1.Location = New System.Drawing.Point(140, 44)
		Me.Frame1.TabIndex = 8
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.cmbSwapTile.Size = New System.Drawing.Size(100, 21)
		Me.cmbSwapTile.Location = New System.Drawing.Point(8, 60)
		Me.cmbSwapTile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbSwapTile.TabIndex = 32
		Me.cmbSwapTile.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbSwapTile.BackColor = System.Drawing.SystemColors.Window
		Me.cmbSwapTile.CausesValidation = True
		Me.cmbSwapTile.Enabled = True
		Me.cmbSwapTile.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbSwapTile.IntegralHeight = True
		Me.cmbSwapTile.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbSwapTile.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbSwapTile.Sorted = False
		Me.cmbSwapTile.TabStop = True
		Me.cmbSwapTile.Visible = True
		Me.cmbSwapTile.Name = "cmbSwapTile"
		Me._picTiles_1.Size = New System.Drawing.Size(100, 83)
		Me._picTiles_1.Location = New System.Drawing.Point(8, 84)
		Me._picTiles_1.TabIndex = 15
		Me._picTiles_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picTiles_1.Dock = System.Windows.Forms.DockStyle.None
		Me._picTiles_1.BackColor = System.Drawing.SystemColors.Control
		Me._picTiles_1.CausesValidation = True
		Me._picTiles_1.Enabled = True
		Me._picTiles_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picTiles_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._picTiles_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picTiles_1.TabStop = True
		Me._picTiles_1.Visible = True
		Me._picTiles_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._picTiles_1.Name = "_picTiles_1"
		Me.txtChance.AutoSize = False
		Me.txtChance.Size = New System.Drawing.Size(25, 19)
		Me.txtChance.Location = New System.Drawing.Point(12, 32)
		Me.txtChance.TabIndex = 14
		Me.txtChance.Text = "0"
		Me.txtChance.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtChance.AcceptsReturn = True
		Me.txtChance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtChance.BackColor = System.Drawing.SystemColors.Window
		Me.txtChance.CausesValidation = True
		Me.txtChance.Enabled = True
		Me.txtChance.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtChance.HideSelection = True
		Me.txtChance.ReadOnly = False
		Me.txtChance.Maxlength = 0
		Me.txtChance.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtChance.MultiLine = False
		Me.txtChance.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtChance.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtChance.TabStop = True
		Me.txtChance.Visible = True
		Me.txtChance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtChance.Name = "txtChance"
		Me._chkKey_3.Size = New System.Drawing.Size(13, 13)
		Me._chkKey_3.Location = New System.Drawing.Point(48, 36)
		Me._chkKey_3.TabIndex = 13
		Me._chkKey_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkKey_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkKey_3.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkKey_3.BackColor = System.Drawing.SystemColors.Control
		Me._chkKey_3.Text = ""
		Me._chkKey_3.CausesValidation = True
		Me._chkKey_3.Enabled = True
		Me._chkKey_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkKey_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkKey_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkKey_3.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkKey_3.TabStop = True
		Me._chkKey_3.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkKey_3.Visible = True
		Me._chkKey_3.Name = "_chkKey_3"
		Me._chkKey_4.Size = New System.Drawing.Size(13, 13)
		Me._chkKey_4.Location = New System.Drawing.Point(60, 36)
		Me._chkKey_4.TabIndex = 12
		Me._chkKey_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkKey_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkKey_4.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkKey_4.BackColor = System.Drawing.SystemColors.Control
		Me._chkKey_4.Text = ""
		Me._chkKey_4.CausesValidation = True
		Me._chkKey_4.Enabled = True
		Me._chkKey_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkKey_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkKey_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkKey_4.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkKey_4.TabStop = True
		Me._chkKey_4.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkKey_4.Visible = True
		Me._chkKey_4.Name = "_chkKey_4"
		Me._chkKey_5.Size = New System.Drawing.Size(13, 13)
		Me._chkKey_5.Location = New System.Drawing.Point(72, 36)
		Me._chkKey_5.TabIndex = 11
		Me._chkKey_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkKey_5.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkKey_5.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkKey_5.BackColor = System.Drawing.SystemColors.Control
		Me._chkKey_5.Text = ""
		Me._chkKey_5.CausesValidation = True
		Me._chkKey_5.Enabled = True
		Me._chkKey_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkKey_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkKey_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkKey_5.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkKey_5.TabStop = True
		Me._chkKey_5.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkKey_5.Visible = True
		Me._chkKey_5.Name = "_chkKey_5"
		Me._chkKey_6.Size = New System.Drawing.Size(13, 13)
		Me._chkKey_6.Location = New System.Drawing.Point(84, 36)
		Me._chkKey_6.TabIndex = 10
		Me._chkKey_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkKey_6.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkKey_6.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkKey_6.BackColor = System.Drawing.SystemColors.Control
		Me._chkKey_6.Text = ""
		Me._chkKey_6.CausesValidation = True
		Me._chkKey_6.Enabled = True
		Me._chkKey_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkKey_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkKey_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkKey_6.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkKey_6.TabStop = True
		Me._chkKey_6.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkKey_6.Visible = True
		Me._chkKey_6.Name = "_chkKey_6"
		Me._chkKey_7.Size = New System.Drawing.Size(13, 13)
		Me._chkKey_7.Location = New System.Drawing.Point(96, 36)
		Me._chkKey_7.TabIndex = 9
		Me._chkKey_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkKey_7.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkKey_7.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkKey_7.BackColor = System.Drawing.SystemColors.Control
		Me._chkKey_7.Text = ""
		Me._chkKey_7.CausesValidation = True
		Me._chkKey_7.Enabled = True
		Me._chkKey_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkKey_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkKey_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkKey_7.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkKey_7.TabStop = True
		Me._chkKey_7.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkKey_7.Visible = True
		Me._chkKey_7.Name = "_chkKey_7"
		Me.Label5.Text = "% ToOpen"
		Me.Label5.Size = New System.Drawing.Size(53, 13)
		Me.Label5.Location = New System.Drawing.Point(4, 16)
		Me.Label5.TabIndex = 17
		Me.Label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label6.Text = "Key Mask"
		Me.Label6.Size = New System.Drawing.Size(53, 13)
		Me.Label6.Location = New System.Drawing.Point(60, 16)
		Me.Label6.TabIndex = 16
		Me.Label6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Frame2.Text = "Attributes"
		Me.Frame2.Size = New System.Drawing.Size(117, 177)
		Me.Frame2.Location = New System.Drawing.Point(264, 44)
		Me.Frame2.TabIndex = 5
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.cmbMovementCost.Size = New System.Drawing.Size(100, 21)
		Me.cmbMovementCost.Location = New System.Drawing.Point(8, 132)
		Me.cmbMovementCost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbMovementCost.TabIndex = 38
		Me.cmbMovementCost.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbMovementCost.BackColor = System.Drawing.SystemColors.Window
		Me.cmbMovementCost.CausesValidation = True
		Me.cmbMovementCost.Enabled = True
		Me.cmbMovementCost.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbMovementCost.IntegralHeight = True
		Me.cmbMovementCost.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbMovementCost.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbMovementCost.Sorted = False
		Me.cmbMovementCost.TabStop = True
		Me.cmbMovementCost.Visible = True
		Me.cmbMovementCost.Name = "cmbMovementCost"
		Me.cmbTerrainType.Size = New System.Drawing.Size(100, 21)
		Me.cmbTerrainType.Location = New System.Drawing.Point(8, 80)
		Me.cmbTerrainType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbTerrainType.TabIndex = 35
		Me.cmbTerrainType.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbTerrainType.BackColor = System.Drawing.SystemColors.Window
		Me.cmbTerrainType.CausesValidation = True
		Me.cmbTerrainType.Enabled = True
		Me.cmbTerrainType.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbTerrainType.IntegralHeight = True
		Me.cmbTerrainType.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbTerrainType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbTerrainType.Sorted = False
		Me.cmbTerrainType.TabStop = True
		Me.cmbTerrainType.Visible = True
		Me.cmbTerrainType.Name = "cmbTerrainType"
		Me.cmbStyle.Size = New System.Drawing.Size(100, 21)
		Me.cmbStyle.Location = New System.Drawing.Point(8, 32)
		Me.cmbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbStyle.TabIndex = 6
		Me.cmbStyle.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbStyle.BackColor = System.Drawing.SystemColors.Window
		Me.cmbStyle.CausesValidation = True
		Me.cmbStyle.Enabled = True
		Me.cmbStyle.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbStyle.IntegralHeight = True
		Me.cmbStyle.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbStyle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbStyle.Sorted = False
		Me.cmbStyle.TabStop = True
		Me.cmbStyle.Visible = True
		Me.cmbStyle.Name = "cmbStyle"
		Me.Label7.Text = "Movement Cost"
		Me.Label7.Size = New System.Drawing.Size(97, 13)
		Me.Label7.Location = New System.Drawing.Point(8, 116)
		Me.Label7.TabIndex = 37
		Me.Label7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.Label4.Text = "Terrain Type"
		Me.Label4.Size = New System.Drawing.Size(97, 13)
		Me.Label4.Location = New System.Drawing.Point(8, 64)
		Me.Label4.TabIndex = 36
		Me.Label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label3.Text = "Style"
		Me.Label3.Size = New System.Drawing.Size(97, 13)
		Me.Label3.Location = New System.Drawing.Point(8, 16)
		Me.Label3.TabIndex = 7
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me._lblName_1.Text = "Name"
		Me._lblName_1.Size = New System.Drawing.Size(41, 13)
		Me._lblName_1.Location = New System.Drawing.Point(8, 4)
		Me._lblName_1.TabIndex = 34
		Me._lblName_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblName_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblName_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblName_1.Enabled = True
		Me._lblName_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblName_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblName_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblName_1.UseMnemonic = True
		Me._lblName_1.Visible = True
		Me._lblName_1.AutoSize = False
		Me._lblName_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblName_1.Name = "_lblName_1"
		Me.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnApply.BackColor = System.Drawing.SystemColors.Control
		Me.btnApply.Text = "Apply"
		Me.btnApply.Enabled = False
		Me.btnApply.Size = New System.Drawing.Size(73, 21)
		Me.btnApply.Location = New System.Drawing.Point(324, 268)
		Me.btnApply.TabIndex = 2
		Me.btnApply.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnApply.CausesValidation = True
		Me.btnApply.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnApply.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnApply.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnApply.TabStop = True
		Me.btnApply.Name = "btnApply"
		Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnOk.BackColor = System.Drawing.SystemColors.Control
		Me.btnOk.Text = "OK"
		Me.btnOk.Size = New System.Drawing.Size(73, 21)
		Me.btnOk.Location = New System.Drawing.Point(164, 268)
		Me.btnOk.TabIndex = 1
		Me.btnOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnOk.CausesValidation = True
		Me.btnOk.Enabled = True
		Me.btnOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnOk.TabStop = True
		Me.btnOk.Name = "btnOk"
		Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.Size = New System.Drawing.Size(73, 21)
		Me.btnCancel.Location = New System.Drawing.Point(244, 268)
		Me.btnCancel.TabIndex = 0
		Me.btnCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancel.CausesValidation = True
		Me.btnCancel.Enabled = True
		Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCancel.TabStop = True
		Me.btnCancel.Name = "btnCancel"
		tabTileProp.OcxState = CType(resources.GetObject("tabTileProp.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tabTileProp.Size = New System.Drawing.Size(393, 257)
		Me.tabTileProp.Location = New System.Drawing.Point(4, 4)
		Me.tabTileProp.TabIndex = 3
		Me.tabTileProp.Name = "tabTileProp"
		Me.chkKey.SetIndex(_chkKey_3, CType(3, Short))
		Me.chkKey.SetIndex(_chkKey_4, CType(4, Short))
		Me.chkKey.SetIndex(_chkKey_5, CType(5, Short))
		Me.chkKey.SetIndex(_chkKey_6, CType(6, Short))
		Me.chkKey.SetIndex(_chkKey_7, CType(7, Short))
		Me.fraTileProp.SetIndex(_fraTileProp_0, CType(0, Short))
		Me.lblBlocked.SetIndex(_lblBlocked_2, CType(2, Short))
		Me.lblBlocked.SetIndex(_lblBlocked_3, CType(3, Short))
		Me.lblBlocked.SetIndex(_lblBlocked_1, CType(1, Short))
		Me.lblBlocked.SetIndex(_lblBlocked_0, CType(0, Short))
		Me.lblName.SetIndex(_lblName_1, CType(1, Short))
		Me.lblSee.SetIndex(_lblSee_2, CType(2, Short))
		Me.lblSee.SetIndex(_lblSee_3, CType(3, Short))
		Me.lblSee.SetIndex(_lblSee_0, CType(0, Short))
		Me.lblSee.SetIndex(_lblSee_1, CType(1, Short))
		Me.lnSide.SetIndex(_lnSide_1, CType(1, Short))
		Me.lnSide.SetIndex(_lnSide_3, CType(3, Short))
		Me.lnSide.SetIndex(_lnSide_2, CType(2, Short))
		Me.lnSide.SetIndex(_lnSide_0, CType(0, Short))
		Me.picTiles.SetIndex(_picTiles_0, CType(0, Short))
		Me.picTiles.SetIndex(_picTiles_1, CType(1, Short))
		Me.shpSee.SetIndex(_shpSee_3, CType(3, Short))
		Me.shpSee.SetIndex(_shpSee_0, CType(0, Short))
		Me.shpSee.SetIndex(_shpSee_2, CType(2, Short))
		Me.shpSee.SetIndex(_shpSee_1, CType(1, Short))
		CType(Me.shpSee, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picTiles, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lnSide, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblSee, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblBlocked, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.fraTileProp, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chkKey, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tabTileProp, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(_fraTileProp_0)
		Me.Controls.Add(btnApply)
		Me.Controls.Add(btnOk)
		Me.Controls.Add(btnCancel)
		Me.Controls.Add(tabTileProp)
		Me._fraTileProp_0.Controls.Add(txtName)
		Me._fraTileProp_0.Controls.Add(Frame3)
		Me._fraTileProp_0.Controls.Add(Frame1)
		Me._fraTileProp_0.Controls.Add(Frame2)
		Me._fraTileProp_0.Controls.Add(_lblName_1)
		Me.Frame3.Controls.Add(_picTiles_0)
		Me.Frame3.Controls.Add(cmbTileSet)
		Me.Frame3.Controls.Add(vsbTilePic)
		Me.Frame3.Controls.Add(Label2)
		Me.Frame3.Controls.Add(Label1)
		Me._picTiles_0.Controls.Add(_lblSee_2)
		Me._picTiles_0.Controls.Add(_lblSee_3)
		Me.ShapeContainer1.Shapes.Add(_shpSee_3)
		Me.ShapeContainer1.Shapes.Add(_shpSee_0)
		Me.ShapeContainer1.Shapes.Add(_shpSee_2)
		Me.ShapeContainer1.Shapes.Add(_shpSee_1)
		Me.ShapeContainer1.Shapes.Add(_lnSide_1)
		Me.ShapeContainer1.Shapes.Add(_lnSide_3)
		Me.ShapeContainer1.Shapes.Add(_lnSide_2)
		Me.ShapeContainer1.Shapes.Add(_lnSide_0)
		Me._picTiles_0.Controls.Add(_lblBlocked_2)
		Me._picTiles_0.Controls.Add(_lblBlocked_3)
		Me._picTiles_0.Controls.Add(_lblSee_0)
		Me._picTiles_0.Controls.Add(_lblSee_1)
		Me._picTiles_0.Controls.Add(_lblBlocked_1)
		Me._picTiles_0.Controls.Add(_lblBlocked_0)
		Me._picTiles_0.Controls.Add(ShapeContainer1)
		Me.Frame1.Controls.Add(cmbSwapTile)
		Me.Frame1.Controls.Add(_picTiles_1)
		Me.Frame1.Controls.Add(txtChance)
		Me.Frame1.Controls.Add(_chkKey_3)
		Me.Frame1.Controls.Add(_chkKey_4)
		Me.Frame1.Controls.Add(_chkKey_5)
		Me.Frame1.Controls.Add(_chkKey_6)
		Me.Frame1.Controls.Add(_chkKey_7)
		Me.Frame1.Controls.Add(Label5)
		Me.Frame1.Controls.Add(Label6)
		Me.Frame2.Controls.Add(cmbMovementCost)
		Me.Frame2.Controls.Add(cmbTerrainType)
		Me.Frame2.Controls.Add(cmbStyle)
		Me.Frame2.Controls.Add(Label7)
		Me.Frame2.Controls.Add(Label4)
		Me.Frame2.Controls.Add(Label3)
		Me._fraTileProp_0.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me._picTiles_0.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class