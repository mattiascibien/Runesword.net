<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmEncProp
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
	Public WithEvents chkCanCamp As System.Windows.Forms.CheckBox
	Public WithEvents chkIsActive As System.Windows.Forms.CheckBox
	Public WithEvents chkIsDark As System.Windows.Forms.CheckBox
	Public WithEvents chkCanTalk As System.Windows.Forms.CheckBox
	Public WithEvents chkEntered As System.Windows.Forms.CheckBox
	Public WithEvents chkHint As System.Windows.Forms.CheckBox
	Public WithEvents txtSecondEntry As System.Windows.Forms.TextBox
	Public WithEvents txtName As System.Windows.Forms.TextBox
	Public WithEvents txtFirstEntry As System.Windows.Forms.TextBox
	Public WithEvents _Label1_4 As System.Windows.Forms.Label
	Public WithEvents _lblName_1 As System.Windows.Forms.Label
	Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents _fraEncounter_0 As System.Windows.Forms.Panel
	Public WithEvents btnLibrary As System.Windows.Forms.Button
	Public WithEvents btnPaste As System.Windows.Forms.Button
	Public WithEvents btnCopy As System.Windows.Forms.Button
	Public WithEvents btnCut As System.Windows.Forms.Button
	Public WithEvents btnInsert As System.Windows.Forms.Button
	Public WithEvents btnEdit As System.Windows.Forms.Button
	Public WithEvents lstThings As System.Windows.Forms.ListBox
	Public WithEvents lblAttached As System.Windows.Forms.Label
	Public WithEvents _fraEncounter_1 As System.Windows.Forms.Panel
	Public WithEvents _optCombatSettings_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optCombatSettings_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optCombatSettings_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame6 As System.Windows.Forms.GroupBox
	Public WithEvents btnBrowse As System.Windows.Forms.Button
	Public WithEvents picCombatWallpaper As System.Windows.Forms.PictureBox
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents chkCanFlee As System.Windows.Forms.CheckBox
	Public WithEvents chkCanFight As System.Windows.Forms.CheckBox
	Public WithEvents txtChanceToFlee As System.Windows.Forms.TextBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents _fraEncounter_3 As System.Windows.Forms.Panel
	Public WithEvents _chkReGenFlag_4 As System.Windows.Forms.CheckBox
	Public WithEvents _chkReGenFlag_2 As System.Windows.Forms.CheckBox
	Public WithEvents _chkReGenFlag_3 As System.Windows.Forms.CheckBox
	Public WithEvents _chkReGenFlag_1 As System.Windows.Forms.CheckBox
	Public WithEvents _chkReGenFlag_0 As System.Windows.Forms.CheckBox
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents btnReGen As System.Windows.Forms.Button
	Public WithEvents chkReGen As System.Windows.Forms.CheckBox
	Public WithEvents cmbParentTheme As System.Windows.Forms.ComboBox
	Public WithEvents cmbClassification As System.Windows.Forms.ComboBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents _fraEncounter_2 As System.Windows.Forms.Panel
	Public WithEvents picGridBlocks As System.Windows.Forms.PictureBox
	Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents btnOk As System.Windows.Forms.Button
	Public WithEvents btnApply As System.Windows.Forms.Button
	Public WithEvents tabEncProp As AxComctlLib.AxTabStrip
	Public dlgFileOpen As System.Windows.Forms.OpenFileDialog
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents chkReGenFlag As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	Public WithEvents fraEncounter As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
	Public WithEvents lblName As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents optCombatSettings As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEncProp))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me._fraEncounter_0 = New System.Windows.Forms.Panel
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.chkCanCamp = New System.Windows.Forms.CheckBox
		Me.chkIsActive = New System.Windows.Forms.CheckBox
		Me.chkIsDark = New System.Windows.Forms.CheckBox
		Me.chkCanTalk = New System.Windows.Forms.CheckBox
		Me.chkEntered = New System.Windows.Forms.CheckBox
		Me.chkHint = New System.Windows.Forms.CheckBox
		Me.txtSecondEntry = New System.Windows.Forms.TextBox
		Me.txtName = New System.Windows.Forms.TextBox
		Me.txtFirstEntry = New System.Windows.Forms.TextBox
		Me._Label1_4 = New System.Windows.Forms.Label
		Me._lblName_1 = New System.Windows.Forms.Label
		Me._Label1_0 = New System.Windows.Forms.Label
		Me._fraEncounter_1 = New System.Windows.Forms.Panel
		Me.btnLibrary = New System.Windows.Forms.Button
		Me.btnPaste = New System.Windows.Forms.Button
		Me.btnCopy = New System.Windows.Forms.Button
		Me.btnCut = New System.Windows.Forms.Button
		Me.btnInsert = New System.Windows.Forms.Button
		Me.btnEdit = New System.Windows.Forms.Button
		Me.lstThings = New System.Windows.Forms.ListBox
		Me.lblAttached = New System.Windows.Forms.Label
		Me._fraEncounter_3 = New System.Windows.Forms.Panel
		Me.Frame6 = New System.Windows.Forms.GroupBox
		Me._optCombatSettings_2 = New System.Windows.Forms.RadioButton
		Me._optCombatSettings_1 = New System.Windows.Forms.RadioButton
		Me._optCombatSettings_0 = New System.Windows.Forms.RadioButton
		Me.Frame5 = New System.Windows.Forms.GroupBox
		Me.btnBrowse = New System.Windows.Forms.Button
		Me.picCombatWallpaper = New System.Windows.Forms.PictureBox
		Me.Frame4 = New System.Windows.Forms.GroupBox
		Me.chkCanFlee = New System.Windows.Forms.CheckBox
		Me.chkCanFight = New System.Windows.Forms.CheckBox
		Me.txtChanceToFlee = New System.Windows.Forms.TextBox
		Me.Label3 = New System.Windows.Forms.Label
		Me._fraEncounter_2 = New System.Windows.Forms.Panel
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me._chkReGenFlag_4 = New System.Windows.Forms.CheckBox
		Me._chkReGenFlag_2 = New System.Windows.Forms.CheckBox
		Me._chkReGenFlag_3 = New System.Windows.Forms.CheckBox
		Me._chkReGenFlag_1 = New System.Windows.Forms.CheckBox
		Me._chkReGenFlag_0 = New System.Windows.Forms.CheckBox
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.btnReGen = New System.Windows.Forms.Button
		Me.chkReGen = New System.Windows.Forms.CheckBox
		Me.cmbParentTheme = New System.Windows.Forms.ComboBox
		Me.cmbClassification = New System.Windows.Forms.ComboBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.picGridBlocks = New System.Windows.Forms.PictureBox
		Me.btnCancel = New System.Windows.Forms.Button
		Me.btnOk = New System.Windows.Forms.Button
		Me.btnApply = New System.Windows.Forms.Button
		Me.tabEncProp = New AxComctlLib.AxTabStrip
		Me.dlgFileOpen = New System.Windows.Forms.OpenFileDialog
		Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.chkReGenFlag = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(components)
		Me.fraEncounter = New Microsoft.VisualBasic.Compatibility.VB6.PanelArray(components)
		Me.lblName = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.optCombatSettings = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me._fraEncounter_0.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me._fraEncounter_1.SuspendLayout()
		Me._fraEncounter_3.SuspendLayout()
		Me.Frame6.SuspendLayout()
		Me.Frame5.SuspendLayout()
		Me.Frame4.SuspendLayout()
		Me._fraEncounter_2.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tabEncProp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.chkReGenFlag, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.fraEncounter, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optCombatSettings, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Encounter Properties"
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
		Me.Name = "frmEncProp"
		Me._fraEncounter_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._fraEncounter_0.Size = New System.Drawing.Size(377, 201)
		Me._fraEncounter_0.Location = New System.Drawing.Point(8, 28)
		Me._fraEncounter_0.TabIndex = 3
		Me._fraEncounter_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraEncounter_0.BackColor = System.Drawing.SystemColors.Control
		Me._fraEncounter_0.Enabled = True
		Me._fraEncounter_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraEncounter_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._fraEncounter_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraEncounter_0.Visible = True
		Me._fraEncounter_0.Name = "_fraEncounter_0"
		Me.Frame1.Text = "Description"
		Me.Frame1.Size = New System.Drawing.Size(365, 201)
		Me.Frame1.Location = New System.Drawing.Point(4, 0)
		Me.Frame1.TabIndex = 11
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.chkCanCamp.Text = "Can Camp?"
		Me.chkCanCamp.Size = New System.Drawing.Size(77, 17)
		Me.chkCanCamp.Location = New System.Drawing.Point(8, 13)
		Me.chkCanCamp.TabIndex = 53
		Me.chkCanCamp.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkCanCamp.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkCanCamp.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkCanCamp.BackColor = System.Drawing.SystemColors.Control
		Me.chkCanCamp.CausesValidation = True
		Me.chkCanCamp.Enabled = True
		Me.chkCanCamp.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkCanCamp.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkCanCamp.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkCanCamp.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkCanCamp.TabStop = True
		Me.chkCanCamp.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkCanCamp.Visible = True
		Me.chkCanCamp.Name = "chkCanCamp"
		Me.chkIsActive.Text = "Is Active?"
		Me.chkIsActive.Size = New System.Drawing.Size(69, 13)
		Me.chkIsActive.Location = New System.Drawing.Point(96, 13)
		Me.chkIsActive.TabIndex = 52
		Me.chkIsActive.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkIsActive.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkIsActive.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkIsActive.BackColor = System.Drawing.SystemColors.Control
		Me.chkIsActive.CausesValidation = True
		Me.chkIsActive.Enabled = True
		Me.chkIsActive.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkIsActive.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkIsActive.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkIsActive.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkIsActive.TabStop = True
		Me.chkIsActive.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkIsActive.Visible = True
		Me.chkIsActive.Name = "chkIsActive"
		Me.chkIsDark.Text = "Is Dark?"
		Me.chkIsDark.Enabled = False
		Me.chkIsDark.Size = New System.Drawing.Size(61, 13)
		Me.chkIsDark.Location = New System.Drawing.Point(184, 13)
		Me.chkIsDark.TabIndex = 37
		Me.chkIsDark.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkIsDark.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkIsDark.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkIsDark.BackColor = System.Drawing.SystemColors.Control
		Me.chkIsDark.CausesValidation = True
		Me.chkIsDark.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkIsDark.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkIsDark.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkIsDark.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkIsDark.TabStop = True
		Me.chkIsDark.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkIsDark.Visible = True
		Me.chkIsDark.Name = "chkIsDark"
		Me.chkCanTalk.Text = "Can Talk?"
		Me.chkCanTalk.Size = New System.Drawing.Size(69, 13)
		Me.chkCanTalk.Location = New System.Drawing.Point(264, 13)
		Me.chkCanTalk.TabIndex = 22
		Me.chkCanTalk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkCanTalk.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkCanTalk.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkCanTalk.BackColor = System.Drawing.SystemColors.Control
		Me.chkCanTalk.CausesValidation = True
		Me.chkCanTalk.Enabled = True
		Me.chkCanTalk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkCanTalk.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkCanTalk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkCanTalk.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkCanTalk.TabStop = True
		Me.chkCanTalk.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkCanTalk.Visible = True
		Me.chkCanTalk.Name = "chkCanTalk"
		Me.chkEntered.Text = "Have entered?"
		Me.chkEntered.Size = New System.Drawing.Size(93, 13)
		Me.chkEntered.Location = New System.Drawing.Point(260, 136)
		Me.chkEntered.TabIndex = 21
		Me.chkEntered.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkEntered.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkEntered.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkEntered.BackColor = System.Drawing.SystemColors.Control
		Me.chkEntered.CausesValidation = True
		Me.chkEntered.Enabled = True
		Me.chkEntered.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkEntered.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkEntered.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkEntered.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkEntered.TabStop = True
		Me.chkEntered.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkEntered.Visible = True
		Me.chkEntered.Name = "chkEntered"
		Me.chkHint.Text = "Display Name?"
		Me.chkHint.Size = New System.Drawing.Size(93, 13)
		Me.chkHint.Location = New System.Drawing.Point(264, 32)
		Me.chkHint.TabIndex = 18
		Me.chkHint.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkHint.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkHint.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkHint.BackColor = System.Drawing.SystemColors.Control
		Me.chkHint.CausesValidation = True
		Me.chkHint.Enabled = True
		Me.chkHint.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkHint.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkHint.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkHint.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkHint.TabStop = True
		Me.chkHint.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkHint.Visible = True
		Me.chkHint.Name = "chkHint"
		Me.txtSecondEntry.AutoSize = False
		Me.txtSecondEntry.Size = New System.Drawing.Size(345, 45)
		Me.txtSecondEntry.Location = New System.Drawing.Point(8, 152)
		Me.txtSecondEntry.MultiLine = True
		Me.txtSecondEntry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtSecondEntry.TabIndex = 16
		Me.txtSecondEntry.Text = "Text2"
		Me.txtSecondEntry.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSecondEntry.AcceptsReturn = True
		Me.txtSecondEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSecondEntry.BackColor = System.Drawing.SystemColors.Window
		Me.txtSecondEntry.CausesValidation = True
		Me.txtSecondEntry.Enabled = True
		Me.txtSecondEntry.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSecondEntry.HideSelection = True
		Me.txtSecondEntry.ReadOnly = False
		Me.txtSecondEntry.Maxlength = 0
		Me.txtSecondEntry.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSecondEntry.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSecondEntry.TabStop = True
		Me.txtSecondEntry.Visible = True
		Me.txtSecondEntry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSecondEntry.Name = "txtSecondEntry"
		Me.txtName.AutoSize = False
		Me.txtName.Size = New System.Drawing.Size(345, 19)
		Me.txtName.Location = New System.Drawing.Point(8, 48)
		Me.txtName.TabIndex = 13
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
		Me.txtFirstEntry.AutoSize = False
		Me.txtFirstEntry.Size = New System.Drawing.Size(345, 45)
		Me.txtFirstEntry.Location = New System.Drawing.Point(8, 88)
		Me.txtFirstEntry.MultiLine = True
		Me.txtFirstEntry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtFirstEntry.TabIndex = 12
		Me.txtFirstEntry.Text = "Text2"
		Me.txtFirstEntry.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFirstEntry.AcceptsReturn = True
		Me.txtFirstEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtFirstEntry.BackColor = System.Drawing.SystemColors.Window
		Me.txtFirstEntry.CausesValidation = True
		Me.txtFirstEntry.Enabled = True
		Me.txtFirstEntry.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtFirstEntry.HideSelection = True
		Me.txtFirstEntry.ReadOnly = False
		Me.txtFirstEntry.Maxlength = 0
		Me.txtFirstEntry.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtFirstEntry.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtFirstEntry.TabStop = True
		Me.txtFirstEntry.Visible = True
		Me.txtFirstEntry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtFirstEntry.Name = "txtFirstEntry"
		Me._Label1_4.Text = "Additional Entries"
		Me._Label1_4.Size = New System.Drawing.Size(93, 13)
		Me._Label1_4.Location = New System.Drawing.Point(8, 136)
		Me._Label1_4.TabIndex = 17
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
		Me._lblName_1.Text = "Name:"
		Me._lblName_1.Size = New System.Drawing.Size(41, 13)
		Me._lblName_1.Location = New System.Drawing.Point(8, 32)
		Me._lblName_1.TabIndex = 15
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
		Me._Label1_0.Text = "Upon First Entry"
		Me._Label1_0.Size = New System.Drawing.Size(105, 13)
		Me._Label1_0.Location = New System.Drawing.Point(8, 72)
		Me._Label1_0.TabIndex = 14
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
		Me._fraEncounter_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._fraEncounter_1.Size = New System.Drawing.Size(373, 193)
		Me._fraEncounter_1.Location = New System.Drawing.Point(12, 28)
		Me._fraEncounter_1.TabIndex = 5
		Me._fraEncounter_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraEncounter_1.BackColor = System.Drawing.SystemColors.Control
		Me._fraEncounter_1.Enabled = True
		Me._fraEncounter_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraEncounter_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._fraEncounter_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraEncounter_1.Visible = True
		Me._fraEncounter_1.Name = "_fraEncounter_1"
		Me.btnLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnLibrary.Text = "Insert from library"
		Me.btnLibrary.Size = New System.Drawing.Size(73, 49)
		Me.btnLibrary.Location = New System.Drawing.Point(292, 40)
		Me.btnLibrary.TabIndex = 54
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
		Me.btnPaste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnPaste.BackColor = System.Drawing.SystemColors.Control
		Me.btnPaste.Text = "Paste"
		Me.btnPaste.Size = New System.Drawing.Size(73, 21)
		Me.btnPaste.Location = New System.Drawing.Point(292, 168)
		Me.btnPaste.TabIndex = 20
		Me.btnPaste.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPaste.CausesValidation = True
		Me.btnPaste.Enabled = True
		Me.btnPaste.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnPaste.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnPaste.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnPaste.TabStop = True
		Me.btnPaste.Name = "btnPaste"
		Me.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnCopy.BackColor = System.Drawing.SystemColors.Control
		Me.btnCopy.Text = "Copy"
		Me.btnCopy.Size = New System.Drawing.Size(73, 21)
		Me.btnCopy.Location = New System.Drawing.Point(292, 144)
		Me.btnCopy.TabIndex = 19
		Me.btnCopy.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCopy.CausesValidation = True
		Me.btnCopy.Enabled = True
		Me.btnCopy.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCopy.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCopy.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCopy.TabStop = True
		Me.btnCopy.Name = "btnCopy"
		Me.btnCut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnCut.BackColor = System.Drawing.SystemColors.Control
		Me.btnCut.Text = "Cut"
		Me.btnCut.Size = New System.Drawing.Size(73, 21)
		Me.btnCut.Location = New System.Drawing.Point(292, 120)
		Me.btnCut.TabIndex = 10
		Me.btnCut.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCut.CausesValidation = True
		Me.btnCut.Enabled = True
		Me.btnCut.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCut.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCut.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCut.TabStop = True
		Me.btnCut.Name = "btnCut"
		Me.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnInsert.BackColor = System.Drawing.SystemColors.Control
		Me.btnInsert.Text = "New"
		Me.btnInsert.Size = New System.Drawing.Size(73, 21)
		Me.btnInsert.Location = New System.Drawing.Point(292, 16)
		Me.btnInsert.TabIndex = 9
		Me.btnInsert.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnInsert.CausesValidation = True
		Me.btnInsert.Enabled = True
		Me.btnInsert.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnInsert.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnInsert.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnInsert.TabStop = True
		Me.btnInsert.Name = "btnInsert"
		Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnEdit.BackColor = System.Drawing.SystemColors.Control
		Me.btnEdit.Text = "Edit..."
		Me.btnEdit.Size = New System.Drawing.Size(73, 21)
		Me.btnEdit.Location = New System.Drawing.Point(292, 92)
		Me.btnEdit.TabIndex = 8
		Me.btnEdit.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEdit.CausesValidation = True
		Me.btnEdit.Enabled = True
		Me.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnEdit.TabStop = True
		Me.btnEdit.Name = "btnEdit"
		Me.lstThings.Size = New System.Drawing.Size(285, 163)
		Me.lstThings.Location = New System.Drawing.Point(0, 24)
		Me.lstThings.TabIndex = 6
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
		Me.lblAttached.Text = "Events Attached to Encounter"
		Me.lblAttached.Size = New System.Drawing.Size(289, 13)
		Me.lblAttached.Location = New System.Drawing.Point(0, 4)
		Me.lblAttached.TabIndex = 7
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
		Me._fraEncounter_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._fraEncounter_3.Size = New System.Drawing.Size(373, 197)
		Me._fraEncounter_3.Location = New System.Drawing.Point(8, 28)
		Me._fraEncounter_3.TabIndex = 38
		Me._fraEncounter_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraEncounter_3.BackColor = System.Drawing.SystemColors.Control
		Me._fraEncounter_3.Enabled = True
		Me._fraEncounter_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraEncounter_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._fraEncounter_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraEncounter_3.Visible = True
		Me._fraEncounter_3.Name = "_fraEncounter_3"
		Me.Frame6.Text = "Background Settings"
		Me.Frame6.Size = New System.Drawing.Size(133, 101)
		Me.Frame6.Location = New System.Drawing.Point(4, 92)
		Me.Frame6.TabIndex = 47
		Me.Frame6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame6.BackColor = System.Drawing.SystemColors.Control
		Me.Frame6.Enabled = True
		Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame6.Visible = True
		Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame6.Name = "Frame6"
		Me._optCombatSettings_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCombatSettings_2.Text = "Set Creatures"
		Me._optCombatSettings_2.Size = New System.Drawing.Size(97, 13)
		Me._optCombatSettings_2.Location = New System.Drawing.Point(16, 68)
		Me._optCombatSettings_2.TabIndex = 50
		Me._optCombatSettings_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optCombatSettings_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCombatSettings_2.BackColor = System.Drawing.SystemColors.Control
		Me._optCombatSettings_2.CausesValidation = True
		Me._optCombatSettings_2.Enabled = True
		Me._optCombatSettings_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optCombatSettings_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._optCombatSettings_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optCombatSettings_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optCombatSettings_2.TabStop = True
		Me._optCombatSettings_2.Checked = False
		Me._optCombatSettings_2.Visible = True
		Me._optCombatSettings_2.Name = "_optCombatSettings_2"
		Me._optCombatSettings_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCombatSettings_1.Text = "Set  Party"
		Me._optCombatSettings_1.Size = New System.Drawing.Size(97, 13)
		Me._optCombatSettings_1.Location = New System.Drawing.Point(16, 48)
		Me._optCombatSettings_1.TabIndex = 49
		Me._optCombatSettings_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optCombatSettings_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCombatSettings_1.BackColor = System.Drawing.SystemColors.Control
		Me._optCombatSettings_1.CausesValidation = True
		Me._optCombatSettings_1.Enabled = True
		Me._optCombatSettings_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optCombatSettings_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optCombatSettings_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optCombatSettings_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optCombatSettings_1.TabStop = True
		Me._optCombatSettings_1.Checked = False
		Me._optCombatSettings_1.Visible = True
		Me._optCombatSettings_1.Name = "_optCombatSettings_1"
		Me._optCombatSettings_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCombatSettings_0.Text = "Set Blocked"
		Me._optCombatSettings_0.Size = New System.Drawing.Size(97, 13)
		Me._optCombatSettings_0.Location = New System.Drawing.Point(16, 28)
		Me._optCombatSettings_0.TabIndex = 48
		Me._optCombatSettings_0.Checked = True
		Me._optCombatSettings_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optCombatSettings_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCombatSettings_0.BackColor = System.Drawing.SystemColors.Control
		Me._optCombatSettings_0.CausesValidation = True
		Me._optCombatSettings_0.Enabled = True
		Me._optCombatSettings_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optCombatSettings_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optCombatSettings_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optCombatSettings_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optCombatSettings_0.TabStop = True
		Me._optCombatSettings_0.Visible = True
		Me._optCombatSettings_0.Name = "_optCombatSettings_0"
		Me.Frame5.Text = "Background"
		Me.Frame5.Size = New System.Drawing.Size(225, 193)
		Me.Frame5.Location = New System.Drawing.Point(144, 0)
		Me.Frame5.TabIndex = 44
		Me.Frame5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame5.BackColor = System.Drawing.SystemColors.Control
		Me.Frame5.Enabled = True
		Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame5.Visible = True
		Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame5.Name = "Frame5"
		Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnBrowse.BackColor = System.Drawing.SystemColors.Control
		Me.btnBrowse.Text = "Browse..."
		Me.btnBrowse.Size = New System.Drawing.Size(73, 21)
		Me.btnBrowse.Location = New System.Drawing.Point(76, 164)
		Me.btnBrowse.TabIndex = 46
		Me.btnBrowse.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBrowse.CausesValidation = True
		Me.btnBrowse.Enabled = True
		Me.btnBrowse.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnBrowse.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnBrowse.TabStop = True
		Me.btnBrowse.Name = "btnBrowse"
		Me.picCombatWallpaper.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.picCombatWallpaper.Size = New System.Drawing.Size(209, 129)
		Me.picCombatWallpaper.Location = New System.Drawing.Point(8, 24)
		Me.picCombatWallpaper.TabIndex = 45
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
		Me.Frame4.Text = "Combat Settings"
		Me.Frame4.Size = New System.Drawing.Size(133, 89)
		Me.Frame4.Location = New System.Drawing.Point(4, 0)
		Me.Frame4.TabIndex = 39
		Me.Frame4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame4.BackColor = System.Drawing.SystemColors.Control
		Me.Frame4.Enabled = True
		Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame4.Visible = True
		Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame4.Name = "Frame4"
		Me.chkCanFlee.Text = "Can Flee?"
		Me.chkCanFlee.Size = New System.Drawing.Size(69, 13)
		Me.chkCanFlee.Location = New System.Drawing.Point(32, 40)
		Me.chkCanFlee.TabIndex = 42
		Me.chkCanFlee.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkCanFlee.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkCanFlee.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkCanFlee.BackColor = System.Drawing.SystemColors.Control
		Me.chkCanFlee.CausesValidation = True
		Me.chkCanFlee.Enabled = True
		Me.chkCanFlee.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkCanFlee.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkCanFlee.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkCanFlee.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkCanFlee.TabStop = True
		Me.chkCanFlee.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkCanFlee.Visible = True
		Me.chkCanFlee.Name = "chkCanFlee"
		Me.chkCanFight.Text = "Can Fight?"
		Me.chkCanFight.Size = New System.Drawing.Size(73, 13)
		Me.chkCanFight.Location = New System.Drawing.Point(32, 20)
		Me.chkCanFight.TabIndex = 41
		Me.chkCanFight.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkCanFight.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkCanFight.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkCanFight.BackColor = System.Drawing.SystemColors.Control
		Me.chkCanFight.CausesValidation = True
		Me.chkCanFight.Enabled = True
		Me.chkCanFight.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkCanFight.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkCanFight.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkCanFight.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkCanFight.TabStop = True
		Me.chkCanFight.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkCanFight.Visible = True
		Me.chkCanFight.Name = "chkCanFight"
		Me.txtChanceToFlee.AutoSize = False
		Me.txtChanceToFlee.Size = New System.Drawing.Size(25, 19)
		Me.txtChanceToFlee.Location = New System.Drawing.Point(92, 60)
		Me.txtChanceToFlee.TabIndex = 40
		Me.txtChanceToFlee.Text = "100"
		Me.txtChanceToFlee.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtChanceToFlee.AcceptsReturn = True
		Me.txtChanceToFlee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtChanceToFlee.BackColor = System.Drawing.SystemColors.Window
		Me.txtChanceToFlee.CausesValidation = True
		Me.txtChanceToFlee.Enabled = True
		Me.txtChanceToFlee.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtChanceToFlee.HideSelection = True
		Me.txtChanceToFlee.ReadOnly = False
		Me.txtChanceToFlee.Maxlength = 0
		Me.txtChanceToFlee.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtChanceToFlee.MultiLine = False
		Me.txtChanceToFlee.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtChanceToFlee.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtChanceToFlee.TabStop = True
		Me.txtChanceToFlee.Visible = True
		Me.txtChanceToFlee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtChanceToFlee.Name = "txtChanceToFlee"
		Me.Label3.Text = "Chance to Flee"
		Me.Label3.Size = New System.Drawing.Size(77, 13)
		Me.Label3.Location = New System.Drawing.Point(12, 64)
		Me.Label3.TabIndex = 43
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
		Me._fraEncounter_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._fraEncounter_2.Size = New System.Drawing.Size(377, 201)
		Me._fraEncounter_2.Location = New System.Drawing.Point(8, 28)
		Me._fraEncounter_2.TabIndex = 23
		Me._fraEncounter_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraEncounter_2.BackColor = System.Drawing.SystemColors.Control
		Me._fraEncounter_2.Enabled = True
		Me._fraEncounter_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraEncounter_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._fraEncounter_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraEncounter_2.Visible = True
		Me._fraEncounter_2.Name = "_fraEncounter_2"
		Me.Frame2.Text = "Options:"
		Me.Frame2.Size = New System.Drawing.Size(173, 193)
		Me.Frame2.Location = New System.Drawing.Point(196, 0)
		Me.Frame2.TabIndex = 31
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me._chkReGenFlag_4.Text = "Tiles Locked?"
		Me._chkReGenFlag_4.Size = New System.Drawing.Size(105, 17)
		Me._chkReGenFlag_4.Location = New System.Drawing.Point(28, 152)
		Me._chkReGenFlag_4.TabIndex = 36
		Me._chkReGenFlag_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkReGenFlag_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkReGenFlag_4.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkReGenFlag_4.BackColor = System.Drawing.SystemColors.Control
		Me._chkReGenFlag_4.CausesValidation = True
		Me._chkReGenFlag_4.Enabled = True
		Me._chkReGenFlag_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkReGenFlag_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkReGenFlag_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkReGenFlag_4.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkReGenFlag_4.TabStop = True
		Me._chkReGenFlag_4.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkReGenFlag_4.Visible = True
		Me._chkReGenFlag_4.Name = "_chkReGenFlag_4"
		Me._chkReGenFlag_2.Text = "ReGen Triggers?"
		Me._chkReGenFlag_2.Size = New System.Drawing.Size(137, 17)
		Me._chkReGenFlag_2.Location = New System.Drawing.Point(28, 88)
		Me._chkReGenFlag_2.TabIndex = 35
		Me._chkReGenFlag_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkReGenFlag_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkReGenFlag_2.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkReGenFlag_2.BackColor = System.Drawing.SystemColors.Control
		Me._chkReGenFlag_2.CausesValidation = True
		Me._chkReGenFlag_2.Enabled = True
		Me._chkReGenFlag_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkReGenFlag_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkReGenFlag_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkReGenFlag_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkReGenFlag_2.TabStop = True
		Me._chkReGenFlag_2.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkReGenFlag_2.Visible = True
		Me._chkReGenFlag_2.Name = "_chkReGenFlag_2"
		Me._chkReGenFlag_3.Text = "ReGen Description?"
		Me._chkReGenFlag_3.Size = New System.Drawing.Size(129, 17)
		Me._chkReGenFlag_3.Location = New System.Drawing.Point(28, 120)
		Me._chkReGenFlag_3.TabIndex = 34
		Me._chkReGenFlag_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkReGenFlag_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkReGenFlag_3.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkReGenFlag_3.BackColor = System.Drawing.SystemColors.Control
		Me._chkReGenFlag_3.CausesValidation = True
		Me._chkReGenFlag_3.Enabled = True
		Me._chkReGenFlag_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkReGenFlag_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkReGenFlag_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkReGenFlag_3.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkReGenFlag_3.TabStop = True
		Me._chkReGenFlag_3.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkReGenFlag_3.Visible = True
		Me._chkReGenFlag_3.Name = "_chkReGenFlag_3"
		Me._chkReGenFlag_1.Text = "ReGen Items?"
		Me._chkReGenFlag_1.Size = New System.Drawing.Size(137, 17)
		Me._chkReGenFlag_1.Location = New System.Drawing.Point(28, 60)
		Me._chkReGenFlag_1.TabIndex = 33
		Me._chkReGenFlag_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkReGenFlag_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkReGenFlag_1.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkReGenFlag_1.BackColor = System.Drawing.SystemColors.Control
		Me._chkReGenFlag_1.CausesValidation = True
		Me._chkReGenFlag_1.Enabled = True
		Me._chkReGenFlag_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkReGenFlag_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkReGenFlag_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkReGenFlag_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkReGenFlag_1.TabStop = True
		Me._chkReGenFlag_1.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkReGenFlag_1.Visible = True
		Me._chkReGenFlag_1.Name = "_chkReGenFlag_1"
		Me._chkReGenFlag_0.Text = "ReGen Creatures?"
		Me._chkReGenFlag_0.Size = New System.Drawing.Size(141, 17)
		Me._chkReGenFlag_0.Location = New System.Drawing.Point(28, 32)
		Me._chkReGenFlag_0.TabIndex = 32
		Me._chkReGenFlag_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkReGenFlag_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkReGenFlag_0.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkReGenFlag_0.BackColor = System.Drawing.SystemColors.Control
		Me._chkReGenFlag_0.CausesValidation = True
		Me._chkReGenFlag_0.Enabled = True
		Me._chkReGenFlag_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkReGenFlag_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkReGenFlag_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkReGenFlag_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkReGenFlag_0.TabStop = True
		Me._chkReGenFlag_0.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkReGenFlag_0.Visible = True
		Me._chkReGenFlag_0.Name = "_chkReGenFlag_0"
		Me.Frame3.Text = "ReGenerate Encounter"
		Me.Frame3.Size = New System.Drawing.Size(181, 193)
		Me.Frame3.Location = New System.Drawing.Point(4, 0)
		Me.Frame3.TabIndex = 24
		Me.Frame3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Me.btnReGen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnReGen.BackColor = System.Drawing.SystemColors.Control
		Me.btnReGen.Text = "ReGen Now"
		Me.btnReGen.Size = New System.Drawing.Size(73, 21)
		Me.btnReGen.Location = New System.Drawing.Point(48, 148)
		Me.btnReGen.TabIndex = 28
		Me.btnReGen.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnReGen.CausesValidation = True
		Me.btnReGen.Enabled = True
		Me.btnReGen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnReGen.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnReGen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnReGen.TabStop = True
		Me.btnReGen.Name = "btnReGen"
		Me.chkReGen.Text = "ReGenerate upon first entry?"
		Me.chkReGen.Size = New System.Drawing.Size(161, 17)
		Me.chkReGen.Location = New System.Drawing.Point(12, 124)
		Me.chkReGen.TabIndex = 27
		Me.chkReGen.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkReGen.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkReGen.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkReGen.BackColor = System.Drawing.SystemColors.Control
		Me.chkReGen.CausesValidation = True
		Me.chkReGen.Enabled = True
		Me.chkReGen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkReGen.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkReGen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkReGen.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkReGen.TabStop = True
		Me.chkReGen.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkReGen.Visible = True
		Me.chkReGen.Name = "chkReGen"
		Me.cmbParentTheme.Size = New System.Drawing.Size(157, 21)
		Me.cmbParentTheme.Location = New System.Drawing.Point(12, 88)
		Me.cmbParentTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbParentTheme.TabIndex = 26
		Me.cmbParentTheme.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbParentTheme.BackColor = System.Drawing.SystemColors.Window
		Me.cmbParentTheme.CausesValidation = True
		Me.cmbParentTheme.Enabled = True
		Me.cmbParentTheme.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbParentTheme.IntegralHeight = True
		Me.cmbParentTheme.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbParentTheme.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbParentTheme.Sorted = False
		Me.cmbParentTheme.TabStop = True
		Me.cmbParentTheme.Visible = True
		Me.cmbParentTheme.Name = "cmbParentTheme"
		Me.cmbClassification.Size = New System.Drawing.Size(157, 21)
		Me.cmbClassification.Location = New System.Drawing.Point(12, 40)
		Me.cmbClassification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbClassification.TabIndex = 25
		Me.cmbClassification.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbClassification.BackColor = System.Drawing.SystemColors.Window
		Me.cmbClassification.CausesValidation = True
		Me.cmbClassification.Enabled = True
		Me.cmbClassification.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbClassification.IntegralHeight = True
		Me.cmbClassification.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbClassification.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbClassification.Sorted = False
		Me.cmbClassification.TabStop = True
		Me.cmbClassification.Visible = True
		Me.cmbClassification.Name = "cmbClassification"
		Me.Label2.Text = "Parent Theme:"
		Me.Label2.Size = New System.Drawing.Size(105, 13)
		Me.Label2.Location = New System.Drawing.Point(12, 72)
		Me.Label2.TabIndex = 30
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
		Me.Label7.Text = "Classification"
		Me.Label7.Size = New System.Drawing.Size(105, 13)
		Me.Label7.Location = New System.Drawing.Point(12, 24)
		Me.Label7.TabIndex = 29
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
		Me.picGridBlocks.BackColor = System.Drawing.Color.Cyan
		Me.picGridBlocks.ForeColor = System.Drawing.SystemColors.WindowText
		Me.picGridBlocks.Size = New System.Drawing.Size(16, 32)
		Me.picGridBlocks.Location = New System.Drawing.Point(40, 236)
		Me.picGridBlocks.Image = CType(resources.GetObject("picGridBlocks.Image"), System.Drawing.Image)
		Me.picGridBlocks.TabIndex = 51
		Me.picGridBlocks.Visible = False
		Me.picGridBlocks.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picGridBlocks.Dock = System.Windows.Forms.DockStyle.None
		Me.picGridBlocks.CausesValidation = True
		Me.picGridBlocks.Enabled = True
		Me.picGridBlocks.Cursor = System.Windows.Forms.Cursors.Default
		Me.picGridBlocks.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picGridBlocks.TabStop = True
		Me.picGridBlocks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.picGridBlocks.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.picGridBlocks.Name = "picGridBlocks"
		Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.Size = New System.Drawing.Size(73, 21)
		Me.btnCancel.Location = New System.Drawing.Point(236, 240)
		Me.btnCancel.TabIndex = 2
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
		Me.btnOk.TabIndex = 1
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
		Me.btnApply.TabIndex = 0
		Me.btnApply.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnApply.CausesValidation = True
		Me.btnApply.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnApply.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnApply.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnApply.TabStop = True
		Me.btnApply.Name = "btnApply"
		tabEncProp.OcxState = CType(resources.GetObject("tabEncProp.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tabEncProp.Size = New System.Drawing.Size(385, 229)
		Me.tabEncProp.Location = New System.Drawing.Point(4, 4)
		Me.tabEncProp.TabIndex = 4
		Me.tabEncProp.Name = "tabEncProp"
		Me.Label1.SetIndex(_Label1_4, CType(4, Short))
		Me.Label1.SetIndex(_Label1_0, CType(0, Short))
		Me.chkReGenFlag.SetIndex(_chkReGenFlag_4, CType(4, Short))
		Me.chkReGenFlag.SetIndex(_chkReGenFlag_2, CType(2, Short))
		Me.chkReGenFlag.SetIndex(_chkReGenFlag_3, CType(3, Short))
		Me.chkReGenFlag.SetIndex(_chkReGenFlag_1, CType(1, Short))
		Me.chkReGenFlag.SetIndex(_chkReGenFlag_0, CType(0, Short))
		Me.fraEncounter.SetIndex(_fraEncounter_0, CType(0, Short))
		Me.fraEncounter.SetIndex(_fraEncounter_1, CType(1, Short))
		Me.fraEncounter.SetIndex(_fraEncounter_3, CType(3, Short))
		Me.fraEncounter.SetIndex(_fraEncounter_2, CType(2, Short))
		Me.lblName.SetIndex(_lblName_1, CType(1, Short))
		Me.optCombatSettings.SetIndex(_optCombatSettings_2, CType(2, Short))
		Me.optCombatSettings.SetIndex(_optCombatSettings_1, CType(1, Short))
		Me.optCombatSettings.SetIndex(_optCombatSettings_0, CType(0, Short))
		CType(Me.optCombatSettings, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.fraEncounter, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chkReGenFlag, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tabEncProp, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(_fraEncounter_0)
		Me.Controls.Add(_fraEncounter_1)
		Me.Controls.Add(_fraEncounter_3)
		Me.Controls.Add(_fraEncounter_2)
		Me.Controls.Add(picGridBlocks)
		Me.Controls.Add(btnCancel)
		Me.Controls.Add(btnOk)
		Me.Controls.Add(btnApply)
		Me.Controls.Add(tabEncProp)
		Me._fraEncounter_0.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(chkCanCamp)
		Me.Frame1.Controls.Add(chkIsActive)
		Me.Frame1.Controls.Add(chkIsDark)
		Me.Frame1.Controls.Add(chkCanTalk)
		Me.Frame1.Controls.Add(chkEntered)
		Me.Frame1.Controls.Add(chkHint)
		Me.Frame1.Controls.Add(txtSecondEntry)
		Me.Frame1.Controls.Add(txtName)
		Me.Frame1.Controls.Add(txtFirstEntry)
		Me.Frame1.Controls.Add(_Label1_4)
		Me.Frame1.Controls.Add(_lblName_1)
		Me.Frame1.Controls.Add(_Label1_0)
		Me._fraEncounter_1.Controls.Add(btnLibrary)
		Me._fraEncounter_1.Controls.Add(btnPaste)
		Me._fraEncounter_1.Controls.Add(btnCopy)
		Me._fraEncounter_1.Controls.Add(btnCut)
		Me._fraEncounter_1.Controls.Add(btnInsert)
		Me._fraEncounter_1.Controls.Add(btnEdit)
		Me._fraEncounter_1.Controls.Add(lstThings)
		Me._fraEncounter_1.Controls.Add(lblAttached)
		Me._fraEncounter_3.Controls.Add(Frame6)
		Me._fraEncounter_3.Controls.Add(Frame5)
		Me._fraEncounter_3.Controls.Add(Frame4)
		Me.Frame6.Controls.Add(_optCombatSettings_2)
		Me.Frame6.Controls.Add(_optCombatSettings_1)
		Me.Frame6.Controls.Add(_optCombatSettings_0)
		Me.Frame5.Controls.Add(btnBrowse)
		Me.Frame5.Controls.Add(picCombatWallpaper)
		Me.Frame4.Controls.Add(chkCanFlee)
		Me.Frame4.Controls.Add(chkCanFight)
		Me.Frame4.Controls.Add(txtChanceToFlee)
		Me.Frame4.Controls.Add(Label3)
		Me._fraEncounter_2.Controls.Add(Frame2)
		Me._fraEncounter_2.Controls.Add(Frame3)
		Me.Frame2.Controls.Add(_chkReGenFlag_4)
		Me.Frame2.Controls.Add(_chkReGenFlag_2)
		Me.Frame2.Controls.Add(_chkReGenFlag_3)
		Me.Frame2.Controls.Add(_chkReGenFlag_1)
		Me.Frame2.Controls.Add(_chkReGenFlag_0)
		Me.Frame3.Controls.Add(btnReGen)
		Me.Frame3.Controls.Add(chkReGen)
		Me.Frame3.Controls.Add(cmbParentTheme)
		Me.Frame3.Controls.Add(cmbClassification)
		Me.Frame3.Controls.Add(Label2)
		Me.Frame3.Controls.Add(Label7)
		Me._fraEncounter_0.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me._fraEncounter_1.ResumeLayout(False)
		Me._fraEncounter_3.ResumeLayout(False)
		Me.Frame6.ResumeLayout(False)
		Me.Frame5.ResumeLayout(False)
		Me.Frame4.ResumeLayout(False)
		Me._fraEncounter_2.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class