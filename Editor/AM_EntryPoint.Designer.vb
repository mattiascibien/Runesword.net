<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmEntryPoint
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
	Public WithEvents txtMapY As System.Windows.Forms.TextBox
	Public WithEvents txtMapX As System.Windows.Forms.TextBox
	Public WithEvents _Label1_2 As System.Windows.Forms.Label
	Public WithEvents _Label1_1 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents cmbAreas As System.Windows.Forms.ComboBox
	Public WithEvents cmbMaps As System.Windows.Forms.ComboBox
	Public WithEvents cmbEntryPoints As System.Windows.Forms.ComboBox
	Public WithEvents _lblName_0 As System.Windows.Forms.Label
	Public WithEvents _lblName_2 As System.Windows.Forms.Label
	Public WithEvents _lblName_3 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents chkIsNoExitSign As System.Windows.Forms.CheckBox
	Public WithEvents cmbMapStyle As System.Windows.Forms.ComboBox
	Public WithEvents txtDescription As System.Windows.Forms.TextBox
	Public WithEvents cmbStyle As System.Windows.Forms.ComboBox
	Public WithEvents txtName As System.Windows.Forms.TextBox
	Public WithEvents _Label1_21 As System.Windows.Forms.Label
	Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents _lblName_1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents _fraItemProp_0 As System.Windows.Forms.Panel
	Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents btnOk As System.Windows.Forms.Button
	Public WithEvents btnApply As System.Windows.Forms.Button
	Public WithEvents tabItemProp As AxComctlLib.AxTabStrip
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents fraItemProp As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
	Public WithEvents lblName As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEntryPoint))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me._fraItemProp_0 = New System.Windows.Forms.Panel
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.txtMapY = New System.Windows.Forms.TextBox
		Me.txtMapX = New System.Windows.Forms.TextBox
		Me._Label1_2 = New System.Windows.Forms.Label
		Me._Label1_1 = New System.Windows.Forms.Label
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.cmbAreas = New System.Windows.Forms.ComboBox
		Me.cmbMaps = New System.Windows.Forms.ComboBox
		Me.cmbEntryPoints = New System.Windows.Forms.ComboBox
		Me._lblName_0 = New System.Windows.Forms.Label
		Me._lblName_2 = New System.Windows.Forms.Label
		Me._lblName_3 = New System.Windows.Forms.Label
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.chkIsNoExitSign = New System.Windows.Forms.CheckBox
		Me.cmbMapStyle = New System.Windows.Forms.ComboBox
		Me.txtDescription = New System.Windows.Forms.TextBox
		Me.cmbStyle = New System.Windows.Forms.ComboBox
		Me.txtName = New System.Windows.Forms.TextBox
		Me._Label1_21 = New System.Windows.Forms.Label
		Me._Label1_0 = New System.Windows.Forms.Label
		Me._lblName_1 = New System.Windows.Forms.Label
		Me.btnCancel = New System.Windows.Forms.Button
		Me.btnOk = New System.Windows.Forms.Button
		Me.btnApply = New System.Windows.Forms.Button
		Me.tabItemProp = New AxComctlLib.AxTabStrip
		Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.fraItemProp = New Microsoft.VisualBasic.Compatibility.VB6.PanelArray(components)
		Me.lblName = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me._fraItemProp_0.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tabItemProp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.fraItemProp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblName, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Entry Point Properties"
		Me.ClientSize = New System.Drawing.Size(395, 267)
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
		Me.Name = "frmEntryPoint"
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
		Me.Frame3.Text = "Location on Map"
		Me.Frame3.Size = New System.Drawing.Size(129, 49)
		Me.Frame3.Location = New System.Drawing.Point(244, 0)
		Me.Frame3.TabIndex = 19
		Me.Frame3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Me.txtMapY.AutoSize = False
		Me.txtMapY.Size = New System.Drawing.Size(25, 19)
		Me.txtMapY.Location = New System.Drawing.Point(96, 20)
		Me.txtMapY.Maxlength = 5
		Me.txtMapY.TabIndex = 23
		Me.txtMapY.Text = "999"
		Me.txtMapY.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMapY.AcceptsReturn = True
		Me.txtMapY.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMapY.BackColor = System.Drawing.SystemColors.Window
		Me.txtMapY.CausesValidation = True
		Me.txtMapY.Enabled = True
		Me.txtMapY.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMapY.HideSelection = True
		Me.txtMapY.ReadOnly = False
		Me.txtMapY.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMapY.MultiLine = False
		Me.txtMapY.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMapY.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMapY.TabStop = True
		Me.txtMapY.Visible = True
		Me.txtMapY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMapY.Name = "txtMapY"
		Me.txtMapX.AutoSize = False
		Me.txtMapX.Size = New System.Drawing.Size(25, 19)
		Me.txtMapX.Location = New System.Drawing.Point(36, 20)
		Me.txtMapX.Maxlength = 5
		Me.txtMapX.TabIndex = 22
		Me.txtMapX.Text = "999"
		Me.txtMapX.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMapX.AcceptsReturn = True
		Me.txtMapX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMapX.BackColor = System.Drawing.SystemColors.Window
		Me.txtMapX.CausesValidation = True
		Me.txtMapX.Enabled = True
		Me.txtMapX.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMapX.HideSelection = True
		Me.txtMapX.ReadOnly = False
		Me.txtMapX.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMapX.MultiLine = False
		Me.txtMapX.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMapX.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMapX.TabStop = True
		Me.txtMapX.Visible = True
		Me.txtMapX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMapX.Name = "txtMapX"
		Me._Label1_2.Text = "At X:"
		Me._Label1_2.Size = New System.Drawing.Size(25, 13)
		Me._Label1_2.Location = New System.Drawing.Point(8, 24)
		Me._Label1_2.TabIndex = 21
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
		Me._Label1_1.Text = "At Y:"
		Me._Label1_1.Size = New System.Drawing.Size(25, 13)
		Me._Label1_1.Location = New System.Drawing.Point(68, 24)
		Me._Label1_1.TabIndex = 20
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
		Me.Frame2.Text = "Links To"
		Me.Frame2.Size = New System.Drawing.Size(129, 141)
		Me.Frame2.Location = New System.Drawing.Point(244, 52)
		Me.Frame2.TabIndex = 10
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
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
		Me.cmbMaps.Size = New System.Drawing.Size(113, 21)
		Me.cmbMaps.Location = New System.Drawing.Point(8, 72)
		Me.cmbMaps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbMaps.TabIndex = 14
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
		Me.cmbEntryPoints.Size = New System.Drawing.Size(113, 21)
		Me.cmbEntryPoints.Location = New System.Drawing.Point(8, 112)
		Me.cmbEntryPoints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbEntryPoints.TabIndex = 13
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
		Me._lblName_2.Text = "Map in Area"
		Me._lblName_2.Size = New System.Drawing.Size(113, 13)
		Me._lblName_2.Location = New System.Drawing.Point(8, 56)
		Me._lblName_2.TabIndex = 17
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
		Me._lblName_3.Text = "EntryPoint on Map"
		Me._lblName_3.Size = New System.Drawing.Size(113, 13)
		Me._lblName_3.Location = New System.Drawing.Point(8, 96)
		Me._lblName_3.TabIndex = 16
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
		Me.Frame1.Text = "Description"
		Me.Frame1.Size = New System.Drawing.Size(233, 193)
		Me.Frame1.Location = New System.Drawing.Point(4, 0)
		Me.Frame1.TabIndex = 5
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.chkIsNoExitSign.Text = "Hide Exit Sign?"
		Me.chkIsNoExitSign.Size = New System.Drawing.Size(93, 13)
		Me.chkIsNoExitSign.Location = New System.Drawing.Point(128, 16)
		Me.chkIsNoExitSign.TabIndex = 25
		Me.chkIsNoExitSign.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkIsNoExitSign.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkIsNoExitSign.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkIsNoExitSign.BackColor = System.Drawing.SystemColors.Control
		Me.chkIsNoExitSign.CausesValidation = True
		Me.chkIsNoExitSign.Enabled = True
		Me.chkIsNoExitSign.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkIsNoExitSign.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkIsNoExitSign.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkIsNoExitSign.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkIsNoExitSign.TabStop = True
		Me.chkIsNoExitSign.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkIsNoExitSign.Visible = True
		Me.chkIsNoExitSign.Name = "chkIsNoExitSign"
		Me.cmbMapStyle.Size = New System.Drawing.Size(108, 21)
		Me.cmbMapStyle.Location = New System.Drawing.Point(117, 164)
		Me.cmbMapStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbMapStyle.TabIndex = 24
		Me.cmbMapStyle.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbMapStyle.BackColor = System.Drawing.SystemColors.Window
		Me.cmbMapStyle.CausesValidation = True
		Me.cmbMapStyle.Enabled = True
		Me.cmbMapStyle.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbMapStyle.IntegralHeight = True
		Me.cmbMapStyle.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbMapStyle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbMapStyle.Sorted = False
		Me.cmbMapStyle.TabStop = True
		Me.cmbMapStyle.Visible = True
		Me.cmbMapStyle.Name = "cmbMapStyle"
		Me.txtDescription.AutoSize = False
		Me.txtDescription.Size = New System.Drawing.Size(217, 77)
		Me.txtDescription.Location = New System.Drawing.Point(8, 68)
		Me.txtDescription.MultiLine = True
		Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtDescription.TabIndex = 11
		Me.txtDescription.Text = "Text2"
		Me.txtDescription.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDescription.AcceptsReturn = True
		Me.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDescription.BackColor = System.Drawing.SystemColors.Window
		Me.txtDescription.CausesValidation = True
		Me.txtDescription.Enabled = True
		Me.txtDescription.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDescription.HideSelection = True
		Me.txtDescription.ReadOnly = False
		Me.txtDescription.Maxlength = 0
		Me.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDescription.TabStop = True
		Me.txtDescription.Visible = True
		Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDescription.Name = "txtDescription"
		Me.cmbStyle.Size = New System.Drawing.Size(103, 21)
		Me.cmbStyle.Location = New System.Drawing.Point(8, 164)
		Me.cmbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbStyle.TabIndex = 8
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
		Me.txtName.AutoSize = False
		Me.txtName.Size = New System.Drawing.Size(215, 19)
		Me.txtName.Location = New System.Drawing.Point(8, 32)
		Me.txtName.TabIndex = 6
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
		Me._Label1_21.Text = "Description when enter/exit"
		Me._Label1_21.Size = New System.Drawing.Size(209, 13)
		Me._Label1_21.Location = New System.Drawing.Point(8, 52)
		Me._Label1_21.TabIndex = 12
		Me._Label1_21.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_21.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_21.BackColor = System.Drawing.SystemColors.Control
		Me._Label1_21.Enabled = True
		Me._Label1_21.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label1_21.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_21.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_21.UseMnemonic = True
		Me._Label1_21.Visible = True
		Me._Label1_21.AutoSize = False
		Me._Label1_21.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_21.Name = "_Label1_21"
		Me._Label1_0.BackColor = System.Drawing.Color.Transparent
		Me._Label1_0.Text = "Style"
		Me._Label1_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_0.Size = New System.Drawing.Size(45, 13)
		Me._Label1_0.Location = New System.Drawing.Point(8, 148)
		Me._Label1_0.TabIndex = 9
		Me._Label1_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_0.Enabled = True
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
		Me._lblName_1.TabIndex = 7
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
		tabItemProp.OcxState = CType(resources.GetObject("tabItemProp.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tabItemProp.Size = New System.Drawing.Size(385, 229)
		Me.tabItemProp.Location = New System.Drawing.Point(4, 4)
		Me.tabItemProp.TabIndex = 0
		Me.tabItemProp.Name = "tabItemProp"
		Me.Label1.SetIndex(_Label1_2, CType(2, Short))
		Me.Label1.SetIndex(_Label1_1, CType(1, Short))
		Me.Label1.SetIndex(_Label1_21, CType(21, Short))
		Me.Label1.SetIndex(_Label1_0, CType(0, Short))
		Me.fraItemProp.SetIndex(_fraItemProp_0, CType(0, Short))
		Me.lblName.SetIndex(_lblName_0, CType(0, Short))
		Me.lblName.SetIndex(_lblName_2, CType(2, Short))
		Me.lblName.SetIndex(_lblName_3, CType(3, Short))
		Me.lblName.SetIndex(_lblName_1, CType(1, Short))
		CType(Me.lblName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.fraItemProp, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tabItemProp, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(_fraItemProp_0)
		Me.Controls.Add(btnCancel)
		Me.Controls.Add(btnOk)
		Me.Controls.Add(btnApply)
		Me.Controls.Add(tabItemProp)
		Me._fraItemProp_0.Controls.Add(Frame3)
		Me._fraItemProp_0.Controls.Add(Frame2)
		Me._fraItemProp_0.Controls.Add(Frame1)
		Me.Frame3.Controls.Add(txtMapY)
		Me.Frame3.Controls.Add(txtMapX)
		Me.Frame3.Controls.Add(_Label1_2)
		Me.Frame3.Controls.Add(_Label1_1)
		Me.Frame2.Controls.Add(cmbAreas)
		Me.Frame2.Controls.Add(cmbMaps)
		Me.Frame2.Controls.Add(cmbEntryPoints)
		Me.Frame2.Controls.Add(_lblName_0)
		Me.Frame2.Controls.Add(_lblName_2)
		Me.Frame2.Controls.Add(_lblName_3)
		Me.Frame1.Controls.Add(chkIsNoExitSign)
		Me.Frame1.Controls.Add(cmbMapStyle)
		Me.Frame1.Controls.Add(txtDescription)
		Me.Frame1.Controls.Add(cmbStyle)
		Me.Frame1.Controls.Add(txtName)
		Me.Frame1.Controls.Add(_Label1_21)
		Me.Frame1.Controls.Add(_Label1_0)
		Me.Frame1.Controls.Add(_lblName_1)
		Me._fraItemProp_0.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class