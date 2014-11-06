<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmTome
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
	Public WithEvents txtAtY As System.Windows.Forms.TextBox
	Public WithEvents txtAtX As System.Windows.Forms.TextBox
	Public WithEvents _Label1_1 As System.Windows.Forms.Label
	Public WithEvents _Label1_2 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents chkIsPersistent As System.Windows.Forms.CheckBox
	Public WithEvents txtPartyAvgLevel As System.Windows.Forms.TextBox
	Public WithEvents txtPartySize As System.Windows.Forms.TextBox
	Public WithEvents txtYear As System.Windows.Forms.TextBox
	Public WithEvents txtMoon As System.Windows.Forms.TextBox
	Public WithEvents txtCycle As System.Windows.Forms.TextBox
	Public WithEvents txtTurn As System.Windows.Forms.TextBox
	Public WithEvents chkOnAdventure As System.Windows.Forms.CheckBox
	Public WithEvents txtComments As System.Windows.Forms.TextBox
	Public WithEvents txtName As System.Windows.Forms.TextBox
	Public WithEvents _Label1_7 As System.Windows.Forms.Label
	Public WithEvents _Label1_8 As System.Windows.Forms.Label
	Public WithEvents _Label1_6 As System.Windows.Forms.Label
	Public WithEvents _Label1_5 As System.Windows.Forms.Label
	Public WithEvents _Label1_4 As System.Windows.Forms.Label
	Public WithEvents _Label1_3 As System.Windows.Forms.Label
	Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents _lblName_1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmbEntryPoints As System.Windows.Forms.ComboBox
	Public WithEvents cmbMaps As System.Windows.Forms.ComboBox
	Public WithEvents cmbAreas As System.Windows.Forms.ComboBox
	Public WithEvents _lblName_3 As System.Windows.Forms.Label
	Public WithEvents _lblName_2 As System.Windows.Forms.Label
	Public WithEvents _lblName_0 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents _fraTome_0 As System.Windows.Forms.Panel
	Public WithEvents btnLibrary As System.Windows.Forms.Button
	Public WithEvents btnCut As System.Windows.Forms.Button
	Public WithEvents btnPaste As System.Windows.Forms.Button
	Public WithEvents btnCopy As System.Windows.Forms.Button
	Public WithEvents lstThings As System.Windows.Forms.ListBox
	Public WithEvents btnEdit As System.Windows.Forms.Button
	Public WithEvents btnInsert As System.Windows.Forms.Button
	Public WithEvents btnDelete As System.Windows.Forms.Button
	Public WithEvents lblAttached As System.Windows.Forms.Label
	Public WithEvents _fraTome_1 As System.Windows.Forms.Panel
	Public WithEvents btnApply As System.Windows.Forms.Button
	Public WithEvents btnOk As System.Windows.Forms.Button
	Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents tabTomeProp As AxComctlLib.AxTabStrip
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents fraTome As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
	Public WithEvents lblName As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTome))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me._fraTome_0 = New System.Windows.Forms.Panel
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.txtAtY = New System.Windows.Forms.TextBox
		Me.txtAtX = New System.Windows.Forms.TextBox
		Me._Label1_1 = New System.Windows.Forms.Label
		Me._Label1_2 = New System.Windows.Forms.Label
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.chkIsPersistent = New System.Windows.Forms.CheckBox
		Me.txtPartyAvgLevel = New System.Windows.Forms.TextBox
		Me.txtPartySize = New System.Windows.Forms.TextBox
		Me.txtYear = New System.Windows.Forms.TextBox
		Me.txtMoon = New System.Windows.Forms.TextBox
		Me.txtCycle = New System.Windows.Forms.TextBox
		Me.txtTurn = New System.Windows.Forms.TextBox
		Me.chkOnAdventure = New System.Windows.Forms.CheckBox
		Me.txtComments = New System.Windows.Forms.TextBox
		Me.txtName = New System.Windows.Forms.TextBox
		Me._Label1_7 = New System.Windows.Forms.Label
		Me._Label1_8 = New System.Windows.Forms.Label
		Me._Label1_6 = New System.Windows.Forms.Label
		Me._Label1_5 = New System.Windows.Forms.Label
		Me._Label1_4 = New System.Windows.Forms.Label
		Me._Label1_3 = New System.Windows.Forms.Label
		Me._Label1_0 = New System.Windows.Forms.Label
		Me._lblName_1 = New System.Windows.Forms.Label
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.cmbEntryPoints = New System.Windows.Forms.ComboBox
		Me.cmbMaps = New System.Windows.Forms.ComboBox
		Me.cmbAreas = New System.Windows.Forms.ComboBox
		Me._lblName_3 = New System.Windows.Forms.Label
		Me._lblName_2 = New System.Windows.Forms.Label
		Me._lblName_0 = New System.Windows.Forms.Label
		Me._fraTome_1 = New System.Windows.Forms.Panel
		Me.btnLibrary = New System.Windows.Forms.Button
		Me.btnCut = New System.Windows.Forms.Button
		Me.btnPaste = New System.Windows.Forms.Button
		Me.btnCopy = New System.Windows.Forms.Button
		Me.lstThings = New System.Windows.Forms.ListBox
		Me.btnEdit = New System.Windows.Forms.Button
		Me.btnInsert = New System.Windows.Forms.Button
		Me.btnDelete = New System.Windows.Forms.Button
		Me.lblAttached = New System.Windows.Forms.Label
		Me.btnApply = New System.Windows.Forms.Button
		Me.btnOk = New System.Windows.Forms.Button
		Me.btnCancel = New System.Windows.Forms.Button
		Me.tabTomeProp = New AxComctlLib.AxTabStrip
		Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.fraTome = New Microsoft.VisualBasic.Compatibility.VB6.PanelArray(components)
		Me.lblName = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me._fraTome_0.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me._fraTome_1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tabTomeProp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.fraTome, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblName, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Tome Properties"
		Me.ClientSize = New System.Drawing.Size(392, 264)
		Me.Location = New System.Drawing.Point(3, 24)
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
		Me.Name = "frmTome"
		Me._fraTome_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._fraTome_0.Size = New System.Drawing.Size(377, 201)
		Me._fraTome_0.Location = New System.Drawing.Point(8, 28)
		Me._fraTome_0.TabIndex = 13
		Me._fraTome_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraTome_0.BackColor = System.Drawing.SystemColors.Control
		Me._fraTome_0.Enabled = True
		Me._fraTome_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraTome_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._fraTome_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraTome_0.Visible = True
		Me._fraTome_0.Name = "_fraTome_0"
		Me.Frame3.Text = "Current Location"
		Me.Frame3.Size = New System.Drawing.Size(129, 49)
		Me.Frame3.Location = New System.Drawing.Point(244, 144)
		Me.Frame3.TabIndex = 39
		Me.Frame3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Me.txtAtY.AutoSize = False
		Me.txtAtY.Size = New System.Drawing.Size(25, 19)
		Me.txtAtY.Location = New System.Drawing.Point(96, 20)
		Me.txtAtY.TabIndex = 41
		Me.txtAtY.Text = "999"
		Me.txtAtY.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAtY.AcceptsReturn = True
		Me.txtAtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtAtY.BackColor = System.Drawing.SystemColors.Window
		Me.txtAtY.CausesValidation = True
		Me.txtAtY.Enabled = True
		Me.txtAtY.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtAtY.HideSelection = True
		Me.txtAtY.ReadOnly = False
		Me.txtAtY.Maxlength = 0
		Me.txtAtY.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtAtY.MultiLine = False
		Me.txtAtY.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtAtY.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtAtY.TabStop = True
		Me.txtAtY.Visible = True
		Me.txtAtY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtAtY.Name = "txtAtY"
		Me.txtAtX.AutoSize = False
		Me.txtAtX.Size = New System.Drawing.Size(25, 19)
		Me.txtAtX.Location = New System.Drawing.Point(36, 20)
		Me.txtAtX.TabIndex = 40
		Me.txtAtX.Text = "999"
		Me.txtAtX.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAtX.AcceptsReturn = True
		Me.txtAtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtAtX.BackColor = System.Drawing.SystemColors.Window
		Me.txtAtX.CausesValidation = True
		Me.txtAtX.Enabled = True
		Me.txtAtX.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtAtX.HideSelection = True
		Me.txtAtX.ReadOnly = False
		Me.txtAtX.Maxlength = 0
		Me.txtAtX.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtAtX.MultiLine = False
		Me.txtAtX.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtAtX.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtAtX.TabStop = True
		Me.txtAtX.Visible = True
		Me.txtAtX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtAtX.Name = "txtAtX"
		Me._Label1_1.Text = "At Y"
		Me._Label1_1.Size = New System.Drawing.Size(25, 13)
		Me._Label1_1.Location = New System.Drawing.Point(68, 24)
		Me._Label1_1.TabIndex = 43
		Me._Label1_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
		Me._Label1_1.Enabled = True
		Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_1.UseMnemonic = True
		Me._Label1_1.Visible = True
		Me._Label1_1.AutoSize = False
		Me._Label1_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_1.Name = "_Label1_1"
		Me._Label1_2.Text = "At X"
		Me._Label1_2.Size = New System.Drawing.Size(25, 13)
		Me._Label1_2.Location = New System.Drawing.Point(8, 24)
		Me._Label1_2.TabIndex = 42
		Me._Label1_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
		Me._Label1_2.Enabled = True
		Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_2.UseMnemonic = True
		Me._Label1_2.Visible = True
		Me._Label1_2.AutoSize = False
		Me._Label1_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_2.Name = "_Label1_2"
		Me.Frame1.Text = "Description"
		Me.Frame1.Size = New System.Drawing.Size(233, 193)
		Me.Frame1.Location = New System.Drawing.Point(4, 0)
		Me.Frame1.TabIndex = 21
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.chkIsPersistent.Text = "IsPersistent"
		Me.chkIsPersistent.Size = New System.Drawing.Size(81, 13)
		Me.chkIsPersistent.Location = New System.Drawing.Point(56, 16)
		Me.chkIsPersistent.TabIndex = 45
		Me.chkIsPersistent.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkIsPersistent.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkIsPersistent.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkIsPersistent.BackColor = System.Drawing.SystemColors.Control
		Me.chkIsPersistent.CausesValidation = True
		Me.chkIsPersistent.Enabled = True
		Me.chkIsPersistent.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkIsPersistent.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkIsPersistent.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkIsPersistent.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkIsPersistent.TabStop = True
		Me.chkIsPersistent.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkIsPersistent.Visible = True
		Me.chkIsPersistent.Name = "chkIsPersistent"
		Me.txtPartyAvgLevel.AutoSize = False
		Me.txtPartyAvgLevel.Size = New System.Drawing.Size(25, 19)
		Me.txtPartyAvgLevel.Location = New System.Drawing.Point(44, 168)
		Me.txtPartyAvgLevel.TabIndex = 30
		Me.txtPartyAvgLevel.Text = "999"
		Me.txtPartyAvgLevel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPartyAvgLevel.AcceptsReturn = True
		Me.txtPartyAvgLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPartyAvgLevel.BackColor = System.Drawing.SystemColors.Window
		Me.txtPartyAvgLevel.CausesValidation = True
		Me.txtPartyAvgLevel.Enabled = True
		Me.txtPartyAvgLevel.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPartyAvgLevel.HideSelection = True
		Me.txtPartyAvgLevel.ReadOnly = False
		Me.txtPartyAvgLevel.Maxlength = 0
		Me.txtPartyAvgLevel.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPartyAvgLevel.MultiLine = False
		Me.txtPartyAvgLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPartyAvgLevel.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPartyAvgLevel.TabStop = True
		Me.txtPartyAvgLevel.Visible = True
		Me.txtPartyAvgLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPartyAvgLevel.Name = "txtPartyAvgLevel"
		Me.txtPartySize.AutoSize = False
		Me.txtPartySize.Size = New System.Drawing.Size(25, 19)
		Me.txtPartySize.Location = New System.Drawing.Point(8, 168)
		Me.txtPartySize.TabIndex = 29
		Me.txtPartySize.Text = "999"
		Me.txtPartySize.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPartySize.AcceptsReturn = True
		Me.txtPartySize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPartySize.BackColor = System.Drawing.SystemColors.Window
		Me.txtPartySize.CausesValidation = True
		Me.txtPartySize.Enabled = True
		Me.txtPartySize.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPartySize.HideSelection = True
		Me.txtPartySize.ReadOnly = False
		Me.txtPartySize.Maxlength = 0
		Me.txtPartySize.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPartySize.MultiLine = False
		Me.txtPartySize.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPartySize.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPartySize.TabStop = True
		Me.txtPartySize.Visible = True
		Me.txtPartySize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPartySize.Name = "txtPartySize"
		Me.txtYear.AutoSize = False
		Me.txtYear.Size = New System.Drawing.Size(37, 19)
		Me.txtYear.Location = New System.Drawing.Point(188, 168)
		Me.txtYear.Maxlength = 5
		Me.txtYear.TabIndex = 28
		Me.txtYear.Text = "99999"
		Me.txtYear.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtYear.AcceptsReturn = True
		Me.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtYear.BackColor = System.Drawing.SystemColors.Window
		Me.txtYear.CausesValidation = True
		Me.txtYear.Enabled = True
		Me.txtYear.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtYear.HideSelection = True
		Me.txtYear.ReadOnly = False
		Me.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtYear.MultiLine = False
		Me.txtYear.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtYear.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtYear.TabStop = True
		Me.txtYear.Visible = True
		Me.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtYear.Name = "txtYear"
		Me.txtMoon.AutoSize = False
		Me.txtMoon.Size = New System.Drawing.Size(25, 19)
		Me.txtMoon.Location = New System.Drawing.Point(152, 168)
		Me.txtMoon.TabIndex = 27
		Me.txtMoon.Text = "999"
		Me.txtMoon.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMoon.AcceptsReturn = True
		Me.txtMoon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMoon.BackColor = System.Drawing.SystemColors.Window
		Me.txtMoon.CausesValidation = True
		Me.txtMoon.Enabled = True
		Me.txtMoon.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMoon.HideSelection = True
		Me.txtMoon.ReadOnly = False
		Me.txtMoon.Maxlength = 0
		Me.txtMoon.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMoon.MultiLine = False
		Me.txtMoon.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMoon.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMoon.TabStop = True
		Me.txtMoon.Visible = True
		Me.txtMoon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMoon.Name = "txtMoon"
		Me.txtCycle.AutoSize = False
		Me.txtCycle.Size = New System.Drawing.Size(25, 19)
		Me.txtCycle.Location = New System.Drawing.Point(116, 168)
		Me.txtCycle.TabIndex = 26
		Me.txtCycle.Text = "999"
		Me.txtCycle.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCycle.AcceptsReturn = True
		Me.txtCycle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCycle.BackColor = System.Drawing.SystemColors.Window
		Me.txtCycle.CausesValidation = True
		Me.txtCycle.Enabled = True
		Me.txtCycle.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCycle.HideSelection = True
		Me.txtCycle.ReadOnly = False
		Me.txtCycle.Maxlength = 0
		Me.txtCycle.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCycle.MultiLine = False
		Me.txtCycle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCycle.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCycle.TabStop = True
		Me.txtCycle.Visible = True
		Me.txtCycle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCycle.Name = "txtCycle"
		Me.txtTurn.AutoSize = False
		Me.txtTurn.Size = New System.Drawing.Size(25, 19)
		Me.txtTurn.Location = New System.Drawing.Point(80, 168)
		Me.txtTurn.TabIndex = 25
		Me.txtTurn.Text = "999"
		Me.txtTurn.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTurn.AcceptsReturn = True
		Me.txtTurn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTurn.BackColor = System.Drawing.SystemColors.Window
		Me.txtTurn.CausesValidation = True
		Me.txtTurn.Enabled = True
		Me.txtTurn.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTurn.HideSelection = True
		Me.txtTurn.ReadOnly = False
		Me.txtTurn.Maxlength = 0
		Me.txtTurn.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTurn.MultiLine = False
		Me.txtTurn.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTurn.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTurn.TabStop = True
		Me.txtTurn.Visible = True
		Me.txtTurn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTurn.Name = "txtTurn"
		Me.chkOnAdventure.Text = "On Adventure"
		Me.chkOnAdventure.Size = New System.Drawing.Size(89, 13)
		Me.chkOnAdventure.Location = New System.Drawing.Point(136, 16)
		Me.chkOnAdventure.TabIndex = 24
		Me.chkOnAdventure.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkOnAdventure.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkOnAdventure.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkOnAdventure.BackColor = System.Drawing.SystemColors.Control
		Me.chkOnAdventure.CausesValidation = True
		Me.chkOnAdventure.Enabled = True
		Me.chkOnAdventure.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkOnAdventure.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkOnAdventure.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkOnAdventure.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkOnAdventure.TabStop = True
		Me.chkOnAdventure.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkOnAdventure.Visible = True
		Me.chkOnAdventure.Name = "chkOnAdventure"
		Me.txtComments.AutoSize = False
		Me.txtComments.Size = New System.Drawing.Size(217, 77)
		Me.txtComments.Location = New System.Drawing.Point(8, 72)
		Me.txtComments.MultiLine = True
		Me.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtComments.TabIndex = 23
		Me.txtComments.Text = "Text2"
		Me.txtComments.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtComments.AcceptsReturn = True
		Me.txtComments.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtComments.BackColor = System.Drawing.SystemColors.Window
		Me.txtComments.CausesValidation = True
		Me.txtComments.Enabled = True
		Me.txtComments.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtComments.HideSelection = True
		Me.txtComments.ReadOnly = False
		Me.txtComments.Maxlength = 0
		Me.txtComments.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtComments.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtComments.TabStop = True
		Me.txtComments.Visible = True
		Me.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtComments.Name = "txtComments"
		Me.txtName.AutoSize = False
		Me.txtName.Size = New System.Drawing.Size(217, 19)
		Me.txtName.Location = New System.Drawing.Point(8, 32)
		Me.txtName.TabIndex = 22
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
		Me._Label1_7.Text = "AvgLvl"
		Me._Label1_7.Size = New System.Drawing.Size(39, 13)
		Me._Label1_7.Location = New System.Drawing.Point(40, 152)
		Me._Label1_7.TabIndex = 38
		Me._Label1_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_7.BackColor = System.Drawing.SystemColors.Control
		Me._Label1_7.Enabled = True
		Me._Label1_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label1_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_7.UseMnemonic = True
		Me._Label1_7.Visible = True
		Me._Label1_7.AutoSize = False
		Me._Label1_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_7.Name = "_Label1_7"
		Me._Label1_8.Text = "Party"
		Me._Label1_8.Size = New System.Drawing.Size(29, 13)
		Me._Label1_8.Location = New System.Drawing.Point(8, 152)
		Me._Label1_8.TabIndex = 37
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
		Me._Label1_6.Text = "Year"
		Me._Label1_6.Size = New System.Drawing.Size(29, 13)
		Me._Label1_6.Location = New System.Drawing.Point(188, 152)
		Me._Label1_6.TabIndex = 36
		Me._Label1_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_6.BackColor = System.Drawing.SystemColors.Control
		Me._Label1_6.Enabled = True
		Me._Label1_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label1_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_6.UseMnemonic = True
		Me._Label1_6.Visible = True
		Me._Label1_6.AutoSize = False
		Me._Label1_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_6.Name = "_Label1_6"
		Me._Label1_5.Text = "Moon"
		Me._Label1_5.Size = New System.Drawing.Size(29, 13)
		Me._Label1_5.Location = New System.Drawing.Point(152, 152)
		Me._Label1_5.TabIndex = 35
		Me._Label1_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_5.BackColor = System.Drawing.SystemColors.Control
		Me._Label1_5.Enabled = True
		Me._Label1_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_5.UseMnemonic = True
		Me._Label1_5.Visible = True
		Me._Label1_5.AutoSize = False
		Me._Label1_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_5.Name = "_Label1_5"
		Me._Label1_4.Text = "Day"
		Me._Label1_4.Size = New System.Drawing.Size(29, 13)
		Me._Label1_4.Location = New System.Drawing.Point(116, 152)
		Me._Label1_4.TabIndex = 34
		Me._Label1_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_4.BackColor = System.Drawing.SystemColors.Control
		Me._Label1_4.Enabled = True
		Me._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_4.UseMnemonic = True
		Me._Label1_4.Visible = True
		Me._Label1_4.AutoSize = False
		Me._Label1_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_4.Name = "_Label1_4"
		Me._Label1_3.Text = "Turn"
		Me._Label1_3.Size = New System.Drawing.Size(25, 13)
		Me._Label1_3.Location = New System.Drawing.Point(80, 152)
		Me._Label1_3.TabIndex = 33
		Me._Label1_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_3.BackColor = System.Drawing.SystemColors.Control
		Me._Label1_3.Enabled = True
		Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_3.UseMnemonic = True
		Me._Label1_3.Visible = True
		Me._Label1_3.AutoSize = False
		Me._Label1_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_3.Name = "_Label1_3"
		Me._Label1_0.Text = "Comments"
		Me._Label1_0.Size = New System.Drawing.Size(81, 13)
		Me._Label1_0.Location = New System.Drawing.Point(8, 56)
		Me._Label1_0.TabIndex = 32
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
		Me._lblName_1.Text = "Name"
		Me._lblName_1.Size = New System.Drawing.Size(41, 13)
		Me._lblName_1.Location = New System.Drawing.Point(8, 16)
		Me._lblName_1.TabIndex = 31
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
		Me.Frame2.Text = "Starting Location"
		Me.Frame2.Size = New System.Drawing.Size(129, 141)
		Me.Frame2.Location = New System.Drawing.Point(244, 0)
		Me.Frame2.TabIndex = 14
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.cmbEntryPoints.Size = New System.Drawing.Size(113, 21)
		Me.cmbEntryPoints.Location = New System.Drawing.Point(8, 112)
		Me.cmbEntryPoints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbEntryPoints.TabIndex = 17
		Me.cmbEntryPoints.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbEntryPoints.BackColor = System.Drawing.SystemColors.Window
		Me.cmbEntryPoints.CausesValidation = True
		Me.cmbEntryPoints.Enabled = True
		Me.cmbEntryPoints.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbEntryPoints.IntegralHeight = True
		Me.cmbEntryPoints.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbEntryPoints.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbEntryPoints.Sorted = False
		Me.cmbEntryPoints.TabStop = True
		Me.cmbEntryPoints.Visible = True
		Me.cmbEntryPoints.Name = "cmbEntryPoints"
		Me.cmbMaps.Size = New System.Drawing.Size(113, 21)
		Me.cmbMaps.Location = New System.Drawing.Point(8, 72)
		Me.cmbMaps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbMaps.TabIndex = 16
		Me.cmbMaps.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbMaps.BackColor = System.Drawing.SystemColors.Window
		Me.cmbMaps.CausesValidation = True
		Me.cmbMaps.Enabled = True
		Me.cmbMaps.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbMaps.IntegralHeight = True
		Me.cmbMaps.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbMaps.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbMaps.Sorted = False
		Me.cmbMaps.TabStop = True
		Me.cmbMaps.Visible = True
		Me.cmbMaps.Name = "cmbMaps"
		Me.cmbAreas.Size = New System.Drawing.Size(113, 21)
		Me.cmbAreas.Location = New System.Drawing.Point(8, 32)
		Me.cmbAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbAreas.TabIndex = 15
		Me.cmbAreas.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbAreas.BackColor = System.Drawing.SystemColors.Window
		Me.cmbAreas.CausesValidation = True
		Me.cmbAreas.Enabled = True
		Me.cmbAreas.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbAreas.IntegralHeight = True
		Me.cmbAreas.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbAreas.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbAreas.Sorted = False
		Me.cmbAreas.TabStop = True
		Me.cmbAreas.Visible = True
		Me.cmbAreas.Name = "cmbAreas"
		Me._lblName_3.Text = "EntryPoint on Map"
		Me._lblName_3.Size = New System.Drawing.Size(113, 13)
		Me._lblName_3.Location = New System.Drawing.Point(8, 96)
		Me._lblName_3.TabIndex = 20
		Me._lblName_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblName_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblName_3.BackColor = System.Drawing.SystemColors.Control
		Me._lblName_3.Enabled = True
		Me._lblName_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblName_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblName_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblName_3.UseMnemonic = True
		Me._lblName_3.Visible = True
		Me._lblName_3.AutoSize = False
		Me._lblName_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblName_3.Name = "_lblName_3"
		Me._lblName_2.Text = "Map in Area"
		Me._lblName_2.Size = New System.Drawing.Size(113, 13)
		Me._lblName_2.Location = New System.Drawing.Point(8, 56)
		Me._lblName_2.TabIndex = 19
		Me._lblName_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblName_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblName_2.BackColor = System.Drawing.SystemColors.Control
		Me._lblName_2.Enabled = True
		Me._lblName_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblName_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblName_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblName_2.UseMnemonic = True
		Me._lblName_2.Visible = True
		Me._lblName_2.AutoSize = False
		Me._lblName_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblName_2.Name = "_lblName_2"
		Me._lblName_0.Text = "Area"
		Me._lblName_0.Size = New System.Drawing.Size(41, 13)
		Me._lblName_0.Location = New System.Drawing.Point(8, 16)
		Me._lblName_0.TabIndex = 18
		Me._lblName_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblName_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblName_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblName_0.Enabled = True
		Me._lblName_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblName_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblName_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblName_0.UseMnemonic = True
		Me._lblName_0.Visible = True
		Me._lblName_0.AutoSize = False
		Me._lblName_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblName_0.Name = "_lblName_0"
		Me._fraTome_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._fraTome_1.Size = New System.Drawing.Size(373, 193)
		Me._fraTome_1.Location = New System.Drawing.Point(12, 28)
		Me._fraTome_1.TabIndex = 4
		Me._fraTome_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraTome_1.BackColor = System.Drawing.SystemColors.Control
		Me._fraTome_1.Enabled = True
		Me._fraTome_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraTome_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._fraTome_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraTome_1.Visible = True
		Me._fraTome_1.Name = "_fraTome_1"
		Me.btnLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnLibrary.Text = "Insert from library"
		Me.btnLibrary.Size = New System.Drawing.Size(73, 49)
		Me.btnLibrary.Location = New System.Drawing.Point(296, 40)
		Me.btnLibrary.TabIndex = 44
		Me.btnLibrary.Visible = False
		Me.btnLibrary.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLibrary.BackColor = System.Drawing.SystemColors.Control
		Me.btnLibrary.CausesValidation = True
		Me.btnLibrary.Enabled = True
		Me.btnLibrary.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLibrary.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnLibrary.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnLibrary.TabStop = True
		Me.btnLibrary.Name = "btnLibrary"
		Me.btnCut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnCut.Text = "Cut"
		Me.btnCut.Size = New System.Drawing.Size(73, 21)
		Me.btnCut.Location = New System.Drawing.Point(296, 120)
		Me.btnCut.TabIndex = 12
		Me.btnCut.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCut.BackColor = System.Drawing.SystemColors.Control
		Me.btnCut.CausesValidation = True
		Me.btnCut.Enabled = True
		Me.btnCut.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCut.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCut.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCut.TabStop = True
		Me.btnCut.Name = "btnCut"
		Me.btnPaste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnPaste.BackColor = System.Drawing.SystemColors.Control
		Me.btnPaste.Text = "Paste"
		Me.btnPaste.Enabled = False
		Me.btnPaste.Size = New System.Drawing.Size(73, 21)
		Me.btnPaste.Location = New System.Drawing.Point(296, 168)
		Me.btnPaste.TabIndex = 11
		Me.btnPaste.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPaste.CausesValidation = True
		Me.btnPaste.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnPaste.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnPaste.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnPaste.TabStop = True
		Me.btnPaste.Name = "btnPaste"
		Me.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnCopy.BackColor = System.Drawing.SystemColors.Control
		Me.btnCopy.Text = "Copy"
		Me.btnCopy.Enabled = False
		Me.btnCopy.Size = New System.Drawing.Size(73, 21)
		Me.btnCopy.Location = New System.Drawing.Point(296, 144)
		Me.btnCopy.TabIndex = 10
		Me.btnCopy.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCopy.CausesValidation = True
		Me.btnCopy.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCopy.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCopy.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCopy.TabStop = True
		Me.btnCopy.Name = "btnCopy"
		Me.lstThings.Size = New System.Drawing.Size(289, 163)
		Me.lstThings.Location = New System.Drawing.Point(0, 24)
		Me.lstThings.TabIndex = 8
		Me.lstThings.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstThings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstThings.BackColor = System.Drawing.SystemColors.Window
		Me.lstThings.CausesValidation = True
		Me.lstThings.Enabled = True
		Me.lstThings.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstThings.IntegralHeight = True
		Me.lstThings.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstThings.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstThings.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstThings.Sorted = False
		Me.lstThings.TabStop = True
		Me.lstThings.Visible = True
		Me.lstThings.MultiColumn = False
		Me.lstThings.Name = "lstThings"
		Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnEdit.BackColor = System.Drawing.SystemColors.Control
		Me.btnEdit.Text = "Edit..."
		Me.btnEdit.Size = New System.Drawing.Size(73, 21)
		Me.btnEdit.Location = New System.Drawing.Point(296, 91)
		Me.btnEdit.TabIndex = 7
		Me.btnEdit.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEdit.CausesValidation = True
		Me.btnEdit.Enabled = True
		Me.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnEdit.TabStop = True
		Me.btnEdit.Name = "btnEdit"
		Me.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnInsert.BackColor = System.Drawing.SystemColors.Control
		Me.btnInsert.Text = "New"
		Me.btnInsert.Size = New System.Drawing.Size(73, 21)
		Me.btnInsert.Location = New System.Drawing.Point(296, 16)
		Me.btnInsert.TabIndex = 6
		Me.btnInsert.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnInsert.CausesValidation = True
		Me.btnInsert.Enabled = True
		Me.btnInsert.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnInsert.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnInsert.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnInsert.TabStop = True
		Me.btnInsert.Name = "btnInsert"
		Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.Size = New System.Drawing.Size(73, 21)
		Me.btnDelete.Location = New System.Drawing.Point(296, 52)
		Me.btnDelete.TabIndex = 5
		Me.btnDelete.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDelete.CausesValidation = True
		Me.btnDelete.Enabled = True
		Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnDelete.TabStop = True
		Me.btnDelete.Name = "btnDelete"
		Me.lblAttached.Text = "StartUp Triggers for Tome"
		Me.lblAttached.Size = New System.Drawing.Size(289, 13)
		Me.lblAttached.Location = New System.Drawing.Point(0, 4)
		Me.lblAttached.TabIndex = 9
		Me.lblAttached.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAttached.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAttached.BackColor = System.Drawing.SystemColors.Control
		Me.lblAttached.Enabled = True
		Me.lblAttached.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAttached.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAttached.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAttached.UseMnemonic = True
		Me.lblAttached.Visible = True
		Me.lblAttached.AutoSize = False
		Me.lblAttached.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAttached.Name = "lblAttached"
		Me.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnApply.BackColor = System.Drawing.SystemColors.Control
		Me.btnApply.Text = "Apply"
		Me.btnApply.Enabled = False
		Me.btnApply.Size = New System.Drawing.Size(73, 21)
		Me.btnApply.Location = New System.Drawing.Point(316, 240)
		Me.btnApply.TabIndex = 3
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
		Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.Size = New System.Drawing.Size(73, 21)
		Me.btnCancel.Location = New System.Drawing.Point(236, 240)
		Me.btnCancel.TabIndex = 1
		Me.btnCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancel.CausesValidation = True
		Me.btnCancel.Enabled = True
		Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCancel.TabStop = True
		Me.btnCancel.Name = "btnCancel"
		tabTomeProp.OcxState = CType(resources.GetObject("tabTomeProp.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tabTomeProp.Size = New System.Drawing.Size(385, 229)
		Me.tabTomeProp.Location = New System.Drawing.Point(4, 4)
		Me.tabTomeProp.TabIndex = 0
		Me.tabTomeProp.Name = "tabTomeProp"
		Me.Label1.SetIndex(_Label1_1, CType(1, Short))
		Me.Label1.SetIndex(_Label1_2, CType(2, Short))
		Me.Label1.SetIndex(_Label1_7, CType(7, Short))
		Me.Label1.SetIndex(_Label1_8, CType(8, Short))
		Me.Label1.SetIndex(_Label1_6, CType(6, Short))
		Me.Label1.SetIndex(_Label1_5, CType(5, Short))
		Me.Label1.SetIndex(_Label1_4, CType(4, Short))
		Me.Label1.SetIndex(_Label1_3, CType(3, Short))
		Me.Label1.SetIndex(_Label1_0, CType(0, Short))
		Me.fraTome.SetIndex(_fraTome_0, CType(0, Short))
		Me.fraTome.SetIndex(_fraTome_1, CType(1, Short))
		Me.lblName.SetIndex(_lblName_1, CType(1, Short))
		Me.lblName.SetIndex(_lblName_3, CType(3, Short))
		Me.lblName.SetIndex(_lblName_2, CType(2, Short))
		Me.lblName.SetIndex(_lblName_0, CType(0, Short))
		CType(Me.lblName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.fraTome, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tabTomeProp, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(_fraTome_0)
		Me.Controls.Add(_fraTome_1)
		Me.Controls.Add(btnApply)
		Me.Controls.Add(btnOk)
		Me.Controls.Add(btnCancel)
		Me.Controls.Add(tabTomeProp)
		Me._fraTome_0.Controls.Add(Frame3)
		Me._fraTome_0.Controls.Add(Frame1)
		Me._fraTome_0.Controls.Add(Frame2)
		Me.Frame3.Controls.Add(txtAtY)
		Me.Frame3.Controls.Add(txtAtX)
		Me.Frame3.Controls.Add(_Label1_1)
		Me.Frame3.Controls.Add(_Label1_2)
		Me.Frame1.Controls.Add(chkIsPersistent)
		Me.Frame1.Controls.Add(txtPartyAvgLevel)
		Me.Frame1.Controls.Add(txtPartySize)
		Me.Frame1.Controls.Add(txtYear)
		Me.Frame1.Controls.Add(txtMoon)
		Me.Frame1.Controls.Add(txtCycle)
		Me.Frame1.Controls.Add(txtTurn)
		Me.Frame1.Controls.Add(chkOnAdventure)
		Me.Frame1.Controls.Add(txtComments)
		Me.Frame1.Controls.Add(txtName)
		Me.Frame1.Controls.Add(_Label1_7)
		Me.Frame1.Controls.Add(_Label1_8)
		Me.Frame1.Controls.Add(_Label1_6)
		Me.Frame1.Controls.Add(_Label1_5)
		Me.Frame1.Controls.Add(_Label1_4)
		Me.Frame1.Controls.Add(_Label1_3)
		Me.Frame1.Controls.Add(_Label1_0)
		Me.Frame1.Controls.Add(_lblName_1)
		Me.Frame2.Controls.Add(cmbEntryPoints)
		Me.Frame2.Controls.Add(cmbMaps)
		Me.Frame2.Controls.Add(cmbAreas)
		Me.Frame2.Controls.Add(_lblName_3)
		Me.Frame2.Controls.Add(_lblName_2)
		Me.Frame2.Controls.Add(_lblName_0)
		Me._fraTome_1.Controls.Add(btnLibrary)
		Me._fraTome_1.Controls.Add(btnCut)
		Me._fraTome_1.Controls.Add(btnPaste)
		Me._fraTome_1.Controls.Add(btnCopy)
		Me._fraTome_1.Controls.Add(lstThings)
		Me._fraTome_1.Controls.Add(btnEdit)
		Me._fraTome_1.Controls.Add(btnInsert)
		Me._fraTome_1.Controls.Add(btnDelete)
		Me._fraTome_1.Controls.Add(lblAttached)
		Me._fraTome_0.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me._fraTome_1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class