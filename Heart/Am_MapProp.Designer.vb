<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMapProp
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
	Public WithEvents _optIsNoRunes_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optIsNoRunes_0 As System.Windows.Forms.RadioButton
	Public WithEvents chkIsNoTiles As System.Windows.Forms.CheckBox
	Public WithEvents chkAutoGenTiles As System.Windows.Forms.CheckBox
	Public WithEvents btnBrowse As System.Windows.Forms.Button
	Public WithEvents txtPictureFile As System.Windows.Forms.TextBox
	Public WithEvents _Label1_2 As System.Windows.Forms.Label
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents _txtRune_19 As System.Windows.Forms.TextBox
	Public WithEvents _txtRune_18 As System.Windows.Forms.TextBox
	Public WithEvents _txtRune_17 As System.Windows.Forms.TextBox
	Public WithEvents _txtRune_16 As System.Windows.Forms.TextBox
	Public WithEvents _txtRune_15 As System.Windows.Forms.TextBox
	Public WithEvents _txtRune_14 As System.Windows.Forms.TextBox
	Public WithEvents _txtRune_13 As System.Windows.Forms.TextBox
	Public WithEvents _txtRune_12 As System.Windows.Forms.TextBox
	Public WithEvents _txtRune_11 As System.Windows.Forms.TextBox
	Public WithEvents _txtRune_10 As System.Windows.Forms.TextBox
	Public WithEvents _txtRune_9 As System.Windows.Forms.TextBox
	Public WithEvents _txtRune_8 As System.Windows.Forms.TextBox
	Public WithEvents _txtRune_7 As System.Windows.Forms.TextBox
	Public WithEvents _txtRune_6 As System.Windows.Forms.TextBox
	Public WithEvents _txtRune_5 As System.Windows.Forms.TextBox
	Public WithEvents _txtRune_4 As System.Windows.Forms.TextBox
	Public WithEvents _txtRune_3 As System.Windows.Forms.TextBox
	Public WithEvents _txtRune_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtRune_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtRune_0 As System.Windows.Forms.TextBox
	Public WithEvents _lblRune_19 As System.Windows.Forms.Label
	Public WithEvents _lblRune_18 As System.Windows.Forms.Label
	Public WithEvents _lblRune_17 As System.Windows.Forms.Label
	Public WithEvents _lblRune_16 As System.Windows.Forms.Label
	Public WithEvents _lblRune_15 As System.Windows.Forms.Label
	Public WithEvents _lblRune_14 As System.Windows.Forms.Label
	Public WithEvents _lblRune_13 As System.Windows.Forms.Label
	Public WithEvents _lblRune_12 As System.Windows.Forms.Label
	Public WithEvents _lblRune_11 As System.Windows.Forms.Label
	Public WithEvents _lblRune_10 As System.Windows.Forms.Label
	Public WithEvents _lblRune_9 As System.Windows.Forms.Label
	Public WithEvents _lblRune_8 As System.Windows.Forms.Label
	Public WithEvents _lblRune_7 As System.Windows.Forms.Label
	Public WithEvents _lblRune_6 As System.Windows.Forms.Label
	Public WithEvents _lblRune_5 As System.Windows.Forms.Label
	Public WithEvents _lblRune_4 As System.Windows.Forms.Label
	Public WithEvents _lblRune_3 As System.Windows.Forms.Label
	Public WithEvents _lblRune_2 As System.Windows.Forms.Label
	Public WithEvents _lblRune_1 As System.Windows.Forms.Label
	Public WithEvents _lblRune_0 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents chkCanCamp As System.Windows.Forms.CheckBox
	Public WithEvents cmbMapStyle As System.Windows.Forms.ComboBox
	Public WithEvents txtWidth As System.Windows.Forms.TextBox
	Public WithEvents txtHeight As System.Windows.Forms.TextBox
	Public WithEvents txtComments As System.Windows.Forms.TextBox
	Public WithEvents txtName As System.Windows.Forms.TextBox
	Public WithEvents _Label1_3 As System.Windows.Forms.Label
	Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents _Label1_1 As System.Windows.Forms.Label
	Public WithEvents _Label1_7 As System.Windows.Forms.Label
	Public WithEvents _lblName_2 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents _fraMap_0 As System.Windows.Forms.Panel
	Public WithEvents btnLibrary As System.Windows.Forms.Button
	Public WithEvents btnPaste As System.Windows.Forms.Button
	Public WithEvents btnCopy As System.Windows.Forms.Button
	Public WithEvents lstThings As System.Windows.Forms.ListBox
	Public WithEvents btnEdit As System.Windows.Forms.Button
	Public WithEvents btnInsert As System.Windows.Forms.Button
	Public WithEvents btnCut As System.Windows.Forms.Button
	Public WithEvents lblAttached As System.Windows.Forms.Label
	Public WithEvents _fraMap_1 As System.Windows.Forms.Panel
	Public WithEvents txtWandering As System.Windows.Forms.TextBox
	Public dlgFileOpen As System.Windows.Forms.OpenFileDialog
	Public WithEvents btnApply As System.Windows.Forms.Button
	Public WithEvents btnOk As System.Windows.Forms.Button
	Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents tabMapProp As AxComctlLib.AxTabStrip
	Public WithEvents cmbInterval As System.Windows.Forms.ComboBox
	Public WithEvents cmbFrequency As System.Windows.Forms.ComboBox
	Public WithEvents cmbWandering As System.Windows.Forms.ComboBox
	Public WithEvents lblInterval As System.Windows.Forms.Label
	Public WithEvents lblHazard As System.Windows.Forms.Label
	Public WithEvents lblMonsters As System.Windows.Forms.Label
	Public WithEvents fraHazard As System.Windows.Forms.GroupBox
	Public WithEvents chkReGenAppend As System.Windows.Forms.CheckBox
	Public WithEvents txtDefaultEncounters As System.Windows.Forms.TextBox
	Public WithEvents txtDefaultHeight As System.Windows.Forms.TextBox
	Public WithEvents txtDefaultWidth As System.Windows.Forms.TextBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents cmbPartySize As System.Windows.Forms.ComboBox
	Public WithEvents cmbPartyAvgLevel As System.Windows.Forms.ComboBox
	Public WithEvents cmbDefaultStyle As System.Windows.Forms.ComboBox
	Public WithEvents chkReGen As System.Windows.Forms.CheckBox
	Public WithEvents btnReGen As System.Windows.Forms.Button
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents _fraMap_2 As System.Windows.Forms.Panel
	Public WithEvents lblChancesWandering As System.Windows.Forms.Label
	Public WithEvents lblBetweenRests As System.Windows.Forms.Label
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents fraMap As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
	Public WithEvents lblName As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblRune As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents optIsNoRunes As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents txtRune As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMapProp))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me._fraMap_0 = New System.Windows.Forms.Panel
		Me._optIsNoRunes_1 = New System.Windows.Forms.RadioButton
		Me._optIsNoRunes_0 = New System.Windows.Forms.RadioButton
		Me.Frame5 = New System.Windows.Forms.GroupBox
		Me.chkIsNoTiles = New System.Windows.Forms.CheckBox
		Me.chkAutoGenTiles = New System.Windows.Forms.CheckBox
		Me.btnBrowse = New System.Windows.Forms.Button
		Me.txtPictureFile = New System.Windows.Forms.TextBox
		Me._Label1_2 = New System.Windows.Forms.Label
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me._txtRune_19 = New System.Windows.Forms.TextBox
		Me._txtRune_18 = New System.Windows.Forms.TextBox
		Me._txtRune_17 = New System.Windows.Forms.TextBox
		Me._txtRune_16 = New System.Windows.Forms.TextBox
		Me._txtRune_15 = New System.Windows.Forms.TextBox
		Me._txtRune_14 = New System.Windows.Forms.TextBox
		Me._txtRune_13 = New System.Windows.Forms.TextBox
		Me._txtRune_12 = New System.Windows.Forms.TextBox
		Me._txtRune_11 = New System.Windows.Forms.TextBox
		Me._txtRune_10 = New System.Windows.Forms.TextBox
		Me._txtRune_9 = New System.Windows.Forms.TextBox
		Me._txtRune_8 = New System.Windows.Forms.TextBox
		Me._txtRune_7 = New System.Windows.Forms.TextBox
		Me._txtRune_6 = New System.Windows.Forms.TextBox
		Me._txtRune_5 = New System.Windows.Forms.TextBox
		Me._txtRune_4 = New System.Windows.Forms.TextBox
		Me._txtRune_3 = New System.Windows.Forms.TextBox
		Me._txtRune_2 = New System.Windows.Forms.TextBox
		Me._txtRune_1 = New System.Windows.Forms.TextBox
		Me._txtRune_0 = New System.Windows.Forms.TextBox
		Me._lblRune_19 = New System.Windows.Forms.Label
		Me._lblRune_18 = New System.Windows.Forms.Label
		Me._lblRune_17 = New System.Windows.Forms.Label
		Me._lblRune_16 = New System.Windows.Forms.Label
		Me._lblRune_15 = New System.Windows.Forms.Label
		Me._lblRune_14 = New System.Windows.Forms.Label
		Me._lblRune_13 = New System.Windows.Forms.Label
		Me._lblRune_12 = New System.Windows.Forms.Label
		Me._lblRune_11 = New System.Windows.Forms.Label
		Me._lblRune_10 = New System.Windows.Forms.Label
		Me._lblRune_9 = New System.Windows.Forms.Label
		Me._lblRune_8 = New System.Windows.Forms.Label
		Me._lblRune_7 = New System.Windows.Forms.Label
		Me._lblRune_6 = New System.Windows.Forms.Label
		Me._lblRune_5 = New System.Windows.Forms.Label
		Me._lblRune_4 = New System.Windows.Forms.Label
		Me._lblRune_3 = New System.Windows.Forms.Label
		Me._lblRune_2 = New System.Windows.Forms.Label
		Me._lblRune_1 = New System.Windows.Forms.Label
		Me._lblRune_0 = New System.Windows.Forms.Label
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.chkCanCamp = New System.Windows.Forms.CheckBox
		Me.cmbMapStyle = New System.Windows.Forms.ComboBox
		Me.txtWidth = New System.Windows.Forms.TextBox
		Me.txtHeight = New System.Windows.Forms.TextBox
		Me.txtComments = New System.Windows.Forms.TextBox
		Me.txtName = New System.Windows.Forms.TextBox
		Me._Label1_3 = New System.Windows.Forms.Label
		Me._Label1_0 = New System.Windows.Forms.Label
		Me._Label1_1 = New System.Windows.Forms.Label
		Me._Label1_7 = New System.Windows.Forms.Label
		Me._lblName_2 = New System.Windows.Forms.Label
		Me._fraMap_1 = New System.Windows.Forms.Panel
		Me.btnLibrary = New System.Windows.Forms.Button
		Me.btnPaste = New System.Windows.Forms.Button
		Me.btnCopy = New System.Windows.Forms.Button
		Me.lstThings = New System.Windows.Forms.ListBox
		Me.btnEdit = New System.Windows.Forms.Button
		Me.btnInsert = New System.Windows.Forms.Button
		Me.btnCut = New System.Windows.Forms.Button
		Me.lblAttached = New System.Windows.Forms.Label
		Me.txtWandering = New System.Windows.Forms.TextBox
		Me.dlgFileOpen = New System.Windows.Forms.OpenFileDialog
		Me.btnApply = New System.Windows.Forms.Button
		Me.btnOk = New System.Windows.Forms.Button
		Me.btnCancel = New System.Windows.Forms.Button
		Me.tabMapProp = New AxComctlLib.AxTabStrip
		Me._fraMap_2 = New System.Windows.Forms.Panel
		Me.fraHazard = New System.Windows.Forms.GroupBox
		Me.cmbInterval = New System.Windows.Forms.ComboBox
		Me.cmbFrequency = New System.Windows.Forms.ComboBox
		Me.cmbWandering = New System.Windows.Forms.ComboBox
		Me.lblInterval = New System.Windows.Forms.Label
		Me.lblHazard = New System.Windows.Forms.Label
		Me.lblMonsters = New System.Windows.Forms.Label
		Me.Frame4 = New System.Windows.Forms.GroupBox
		Me.chkReGenAppend = New System.Windows.Forms.CheckBox
		Me.txtDefaultEncounters = New System.Windows.Forms.TextBox
		Me.txtDefaultHeight = New System.Windows.Forms.TextBox
		Me.txtDefaultWidth = New System.Windows.Forms.TextBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.cmbPartySize = New System.Windows.Forms.ComboBox
		Me.cmbPartyAvgLevel = New System.Windows.Forms.ComboBox
		Me.cmbDefaultStyle = New System.Windows.Forms.ComboBox
		Me.chkReGen = New System.Windows.Forms.CheckBox
		Me.btnReGen = New System.Windows.Forms.Button
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.lblChancesWandering = New System.Windows.Forms.Label
		Me.lblBetweenRests = New System.Windows.Forms.Label
		Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.fraMap = New Microsoft.VisualBasic.Compatibility.VB6.PanelArray(components)
		Me.lblName = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblRune = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.optIsNoRunes = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.txtRune = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me._fraMap_0.SuspendLayout()
		Me.Frame5.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me._fraMap_1.SuspendLayout()
		Me._fraMap_2.SuspendLayout()
		Me.fraHazard.SuspendLayout()
		Me.Frame4.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tabMapProp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.fraMap, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblRune, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optIsNoRunes, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtRune, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Map Properties"
		Me.ClientSize = New System.Drawing.Size(404, 296)
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
		Me.Name = "frmMapProp"
		Me._fraMap_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._fraMap_0.Size = New System.Drawing.Size(389, 229)
		Me._fraMap_0.Location = New System.Drawing.Point(8, 28)
		Me._fraMap_0.TabIndex = 4
		Me._fraMap_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraMap_0.BackColor = System.Drawing.SystemColors.Control
		Me._fraMap_0.Enabled = True
		Me._fraMap_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraMap_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._fraMap_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraMap_0.Visible = True
		Me._fraMap_0.Name = "_fraMap_0"
		Me._optIsNoRunes_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optIsNoRunes_1.Text = "Off"
		Me._optIsNoRunes_1.Size = New System.Drawing.Size(37, 13)
		Me._optIsNoRunes_1.Location = New System.Drawing.Point(328, 0)
		Me._optIsNoRunes_1.TabIndex = 90
		Me._optIsNoRunes_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optIsNoRunes_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optIsNoRunes_1.BackColor = System.Drawing.SystemColors.Control
		Me._optIsNoRunes_1.CausesValidation = True
		Me._optIsNoRunes_1.Enabled = True
		Me._optIsNoRunes_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optIsNoRunes_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optIsNoRunes_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optIsNoRunes_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optIsNoRunes_1.TabStop = True
		Me._optIsNoRunes_1.Checked = False
		Me._optIsNoRunes_1.Visible = True
		Me._optIsNoRunes_1.Name = "_optIsNoRunes_1"
		Me._optIsNoRunes_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optIsNoRunes_0.Text = "On"
		Me._optIsNoRunes_0.Size = New System.Drawing.Size(37, 13)
		Me._optIsNoRunes_0.Location = New System.Drawing.Point(284, 0)
		Me._optIsNoRunes_0.TabIndex = 89
		Me._optIsNoRunes_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optIsNoRunes_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optIsNoRunes_0.BackColor = System.Drawing.SystemColors.Control
		Me._optIsNoRunes_0.CausesValidation = True
		Me._optIsNoRunes_0.Enabled = True
		Me._optIsNoRunes_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optIsNoRunes_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optIsNoRunes_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optIsNoRunes_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optIsNoRunes_0.TabStop = True
		Me._optIsNoRunes_0.Checked = False
		Me._optIsNoRunes_0.Visible = True
		Me._optIsNoRunes_0.Name = "_optIsNoRunes_0"
		Me.Frame5.Text = "Tiles"
		Me.Frame5.Size = New System.Drawing.Size(213, 61)
		Me.Frame5.Location = New System.Drawing.Point(4, 164)
		Me.Frame5.TabIndex = 76
		Me.Frame5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame5.BackColor = System.Drawing.SystemColors.Control
		Me.Frame5.Enabled = True
		Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame5.Visible = True
		Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame5.Name = "Frame5"
		Me.chkIsNoTiles.Text = "No Tiles?"
		Me.chkIsNoTiles.Enabled = False
		Me.chkIsNoTiles.Size = New System.Drawing.Size(68, 13)
		Me.chkIsNoTiles.Location = New System.Drawing.Point(62, 12)
		Me.chkIsNoTiles.TabIndex = 88
		Me.chkIsNoTiles.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkIsNoTiles.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkIsNoTiles.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkIsNoTiles.BackColor = System.Drawing.SystemColors.Control
		Me.chkIsNoTiles.CausesValidation = True
		Me.chkIsNoTiles.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkIsNoTiles.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkIsNoTiles.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkIsNoTiles.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkIsNoTiles.TabStop = True
		Me.chkIsNoTiles.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkIsNoTiles.Visible = True
		Me.chkIsNoTiles.Name = "chkIsNoTiles"
		Me.chkAutoGenTiles.Text = "Make Tiles?"
		Me.chkAutoGenTiles.Size = New System.Drawing.Size(79, 13)
		Me.chkAutoGenTiles.Location = New System.Drawing.Point(130, 12)
		Me.chkAutoGenTiles.TabIndex = 80
		Me.chkAutoGenTiles.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkAutoGenTiles.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkAutoGenTiles.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkAutoGenTiles.BackColor = System.Drawing.SystemColors.Control
		Me.chkAutoGenTiles.CausesValidation = True
		Me.chkAutoGenTiles.Enabled = True
		Me.chkAutoGenTiles.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkAutoGenTiles.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkAutoGenTiles.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkAutoGenTiles.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkAutoGenTiles.TabStop = True
		Me.chkAutoGenTiles.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkAutoGenTiles.Visible = True
		Me.chkAutoGenTiles.Name = "chkAutoGenTiles"
		Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnBrowse.BackColor = System.Drawing.SystemColors.Control
		Me.btnBrowse.Text = "Browse..."
		Me.btnBrowse.Size = New System.Drawing.Size(73, 21)
		Me.btnBrowse.Location = New System.Drawing.Point(132, 32)
		Me.btnBrowse.TabIndex = 78
		Me.btnBrowse.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBrowse.CausesValidation = True
		Me.btnBrowse.Enabled = True
		Me.btnBrowse.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnBrowse.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnBrowse.TabStop = True
		Me.btnBrowse.Name = "btnBrowse"
		Me.txtPictureFile.AutoSize = False
		Me.txtPictureFile.Size = New System.Drawing.Size(117, 19)
		Me.txtPictureFile.Location = New System.Drawing.Point(8, 32)
		Me.txtPictureFile.TabIndex = 77
		Me.txtPictureFile.Text = "Text1"
		Me.txtPictureFile.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPictureFile.AcceptsReturn = True
		Me.txtPictureFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPictureFile.BackColor = System.Drawing.SystemColors.Window
		Me.txtPictureFile.CausesValidation = True
		Me.txtPictureFile.Enabled = True
		Me.txtPictureFile.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPictureFile.HideSelection = True
		Me.txtPictureFile.ReadOnly = False
		Me.txtPictureFile.Maxlength = 0
		Me.txtPictureFile.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPictureFile.MultiLine = False
		Me.txtPictureFile.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPictureFile.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPictureFile.TabStop = True
		Me.txtPictureFile.Visible = True
		Me.txtPictureFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPictureFile.Name = "txtPictureFile"
		Me._Label1_2.Text = "FileName"
		Me._Label1_2.Size = New System.Drawing.Size(51, 13)
		Me._Label1_2.Location = New System.Drawing.Point(8, 16)
		Me._Label1_2.TabIndex = 79
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
		Me.Frame2.Text = "Runes"
		Me.Frame2.Size = New System.Drawing.Size(161, 225)
		Me.Frame2.Location = New System.Drawing.Point(224, 0)
		Me.Frame2.TabIndex = 35
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me._txtRune_19.AutoSize = False
		Me._txtRune_19.Size = New System.Drawing.Size(25, 19)
		Me._txtRune_19.Location = New System.Drawing.Point(128, 200)
		Me._txtRune_19.TabIndex = 74
		Me._txtRune_19.Text = "999"
		Me._txtRune_19.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRune_19.AcceptsReturn = True
		Me._txtRune_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRune_19.BackColor = System.Drawing.SystemColors.Window
		Me._txtRune_19.CausesValidation = True
		Me._txtRune_19.Enabled = True
		Me._txtRune_19.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRune_19.HideSelection = True
		Me._txtRune_19.ReadOnly = False
		Me._txtRune_19.Maxlength = 0
		Me._txtRune_19.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRune_19.MultiLine = False
		Me._txtRune_19.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRune_19.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRune_19.TabStop = True
		Me._txtRune_19.Visible = True
		Me._txtRune_19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRune_19.Name = "_txtRune_19"
		Me._txtRune_18.AutoSize = False
		Me._txtRune_18.Size = New System.Drawing.Size(25, 19)
		Me._txtRune_18.Location = New System.Drawing.Point(128, 180)
		Me._txtRune_18.TabIndex = 72
		Me._txtRune_18.Text = "999"
		Me._txtRune_18.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRune_18.AcceptsReturn = True
		Me._txtRune_18.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRune_18.BackColor = System.Drawing.SystemColors.Window
		Me._txtRune_18.CausesValidation = True
		Me._txtRune_18.Enabled = True
		Me._txtRune_18.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRune_18.HideSelection = True
		Me._txtRune_18.ReadOnly = False
		Me._txtRune_18.Maxlength = 0
		Me._txtRune_18.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRune_18.MultiLine = False
		Me._txtRune_18.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRune_18.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRune_18.TabStop = True
		Me._txtRune_18.Visible = True
		Me._txtRune_18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRune_18.Name = "_txtRune_18"
		Me._txtRune_17.AutoSize = False
		Me._txtRune_17.Size = New System.Drawing.Size(25, 19)
		Me._txtRune_17.Location = New System.Drawing.Point(128, 160)
		Me._txtRune_17.TabIndex = 70
		Me._txtRune_17.Text = "999"
		Me._txtRune_17.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRune_17.AcceptsReturn = True
		Me._txtRune_17.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRune_17.BackColor = System.Drawing.SystemColors.Window
		Me._txtRune_17.CausesValidation = True
		Me._txtRune_17.Enabled = True
		Me._txtRune_17.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRune_17.HideSelection = True
		Me._txtRune_17.ReadOnly = False
		Me._txtRune_17.Maxlength = 0
		Me._txtRune_17.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRune_17.MultiLine = False
		Me._txtRune_17.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRune_17.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRune_17.TabStop = True
		Me._txtRune_17.Visible = True
		Me._txtRune_17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRune_17.Name = "_txtRune_17"
		Me._txtRune_16.AutoSize = False
		Me._txtRune_16.Size = New System.Drawing.Size(25, 19)
		Me._txtRune_16.Location = New System.Drawing.Point(128, 140)
		Me._txtRune_16.TabIndex = 68
		Me._txtRune_16.Text = "999"
		Me._txtRune_16.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRune_16.AcceptsReturn = True
		Me._txtRune_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRune_16.BackColor = System.Drawing.SystemColors.Window
		Me._txtRune_16.CausesValidation = True
		Me._txtRune_16.Enabled = True
		Me._txtRune_16.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRune_16.HideSelection = True
		Me._txtRune_16.ReadOnly = False
		Me._txtRune_16.Maxlength = 0
		Me._txtRune_16.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRune_16.MultiLine = False
		Me._txtRune_16.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRune_16.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRune_16.TabStop = True
		Me._txtRune_16.Visible = True
		Me._txtRune_16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRune_16.Name = "_txtRune_16"
		Me._txtRune_15.AutoSize = False
		Me._txtRune_15.Size = New System.Drawing.Size(25, 19)
		Me._txtRune_15.Location = New System.Drawing.Point(128, 120)
		Me._txtRune_15.TabIndex = 66
		Me._txtRune_15.Text = "999"
		Me._txtRune_15.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRune_15.AcceptsReturn = True
		Me._txtRune_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRune_15.BackColor = System.Drawing.SystemColors.Window
		Me._txtRune_15.CausesValidation = True
		Me._txtRune_15.Enabled = True
		Me._txtRune_15.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRune_15.HideSelection = True
		Me._txtRune_15.ReadOnly = False
		Me._txtRune_15.Maxlength = 0
		Me._txtRune_15.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRune_15.MultiLine = False
		Me._txtRune_15.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRune_15.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRune_15.TabStop = True
		Me._txtRune_15.Visible = True
		Me._txtRune_15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRune_15.Name = "_txtRune_15"
		Me._txtRune_14.AutoSize = False
		Me._txtRune_14.Size = New System.Drawing.Size(25, 19)
		Me._txtRune_14.Location = New System.Drawing.Point(128, 100)
		Me._txtRune_14.TabIndex = 64
		Me._txtRune_14.Text = "999"
		Me._txtRune_14.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRune_14.AcceptsReturn = True
		Me._txtRune_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRune_14.BackColor = System.Drawing.SystemColors.Window
		Me._txtRune_14.CausesValidation = True
		Me._txtRune_14.Enabled = True
		Me._txtRune_14.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRune_14.HideSelection = True
		Me._txtRune_14.ReadOnly = False
		Me._txtRune_14.Maxlength = 0
		Me._txtRune_14.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRune_14.MultiLine = False
		Me._txtRune_14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRune_14.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRune_14.TabStop = True
		Me._txtRune_14.Visible = True
		Me._txtRune_14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRune_14.Name = "_txtRune_14"
		Me._txtRune_13.AutoSize = False
		Me._txtRune_13.Size = New System.Drawing.Size(25, 19)
		Me._txtRune_13.Location = New System.Drawing.Point(128, 80)
		Me._txtRune_13.TabIndex = 62
		Me._txtRune_13.Text = "999"
		Me._txtRune_13.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRune_13.AcceptsReturn = True
		Me._txtRune_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRune_13.BackColor = System.Drawing.SystemColors.Window
		Me._txtRune_13.CausesValidation = True
		Me._txtRune_13.Enabled = True
		Me._txtRune_13.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRune_13.HideSelection = True
		Me._txtRune_13.ReadOnly = False
		Me._txtRune_13.Maxlength = 0
		Me._txtRune_13.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRune_13.MultiLine = False
		Me._txtRune_13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRune_13.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRune_13.TabStop = True
		Me._txtRune_13.Visible = True
		Me._txtRune_13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRune_13.Name = "_txtRune_13"
		Me._txtRune_12.AutoSize = False
		Me._txtRune_12.Size = New System.Drawing.Size(25, 19)
		Me._txtRune_12.Location = New System.Drawing.Point(128, 60)
		Me._txtRune_12.TabIndex = 60
		Me._txtRune_12.Text = "999"
		Me._txtRune_12.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRune_12.AcceptsReturn = True
		Me._txtRune_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRune_12.BackColor = System.Drawing.SystemColors.Window
		Me._txtRune_12.CausesValidation = True
		Me._txtRune_12.Enabled = True
		Me._txtRune_12.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRune_12.HideSelection = True
		Me._txtRune_12.ReadOnly = False
		Me._txtRune_12.Maxlength = 0
		Me._txtRune_12.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRune_12.MultiLine = False
		Me._txtRune_12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRune_12.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRune_12.TabStop = True
		Me._txtRune_12.Visible = True
		Me._txtRune_12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRune_12.Name = "_txtRune_12"
		Me._txtRune_11.AutoSize = False
		Me._txtRune_11.Size = New System.Drawing.Size(25, 19)
		Me._txtRune_11.Location = New System.Drawing.Point(128, 40)
		Me._txtRune_11.TabIndex = 58
		Me._txtRune_11.Text = "999"
		Me._txtRune_11.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRune_11.AcceptsReturn = True
		Me._txtRune_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRune_11.BackColor = System.Drawing.SystemColors.Window
		Me._txtRune_11.CausesValidation = True
		Me._txtRune_11.Enabled = True
		Me._txtRune_11.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRune_11.HideSelection = True
		Me._txtRune_11.ReadOnly = False
		Me._txtRune_11.Maxlength = 0
		Me._txtRune_11.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRune_11.MultiLine = False
		Me._txtRune_11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRune_11.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRune_11.TabStop = True
		Me._txtRune_11.Visible = True
		Me._txtRune_11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRune_11.Name = "_txtRune_11"
		Me._txtRune_10.AutoSize = False
		Me._txtRune_10.Size = New System.Drawing.Size(25, 19)
		Me._txtRune_10.Location = New System.Drawing.Point(128, 20)
		Me._txtRune_10.TabIndex = 56
		Me._txtRune_10.Text = "999"
		Me._txtRune_10.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRune_10.AcceptsReturn = True
		Me._txtRune_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRune_10.BackColor = System.Drawing.SystemColors.Window
		Me._txtRune_10.CausesValidation = True
		Me._txtRune_10.Enabled = True
		Me._txtRune_10.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRune_10.HideSelection = True
		Me._txtRune_10.ReadOnly = False
		Me._txtRune_10.Maxlength = 0
		Me._txtRune_10.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRune_10.MultiLine = False
		Me._txtRune_10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRune_10.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRune_10.TabStop = True
		Me._txtRune_10.Visible = True
		Me._txtRune_10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRune_10.Name = "_txtRune_10"
		Me._txtRune_9.AutoSize = False
		Me._txtRune_9.Size = New System.Drawing.Size(25, 19)
		Me._txtRune_9.Location = New System.Drawing.Point(48, 200)
		Me._txtRune_9.TabIndex = 54
		Me._txtRune_9.Text = "999"
		Me._txtRune_9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRune_9.AcceptsReturn = True
		Me._txtRune_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRune_9.BackColor = System.Drawing.SystemColors.Window
		Me._txtRune_9.CausesValidation = True
		Me._txtRune_9.Enabled = True
		Me._txtRune_9.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRune_9.HideSelection = True
		Me._txtRune_9.ReadOnly = False
		Me._txtRune_9.Maxlength = 0
		Me._txtRune_9.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRune_9.MultiLine = False
		Me._txtRune_9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRune_9.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRune_9.TabStop = True
		Me._txtRune_9.Visible = True
		Me._txtRune_9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRune_9.Name = "_txtRune_9"
		Me._txtRune_8.AutoSize = False
		Me._txtRune_8.Size = New System.Drawing.Size(25, 19)
		Me._txtRune_8.Location = New System.Drawing.Point(48, 180)
		Me._txtRune_8.TabIndex = 52
		Me._txtRune_8.Text = "999"
		Me._txtRune_8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRune_8.AcceptsReturn = True
		Me._txtRune_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRune_8.BackColor = System.Drawing.SystemColors.Window
		Me._txtRune_8.CausesValidation = True
		Me._txtRune_8.Enabled = True
		Me._txtRune_8.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRune_8.HideSelection = True
		Me._txtRune_8.ReadOnly = False
		Me._txtRune_8.Maxlength = 0
		Me._txtRune_8.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRune_8.MultiLine = False
		Me._txtRune_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRune_8.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRune_8.TabStop = True
		Me._txtRune_8.Visible = True
		Me._txtRune_8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRune_8.Name = "_txtRune_8"
		Me._txtRune_7.AutoSize = False
		Me._txtRune_7.Size = New System.Drawing.Size(25, 19)
		Me._txtRune_7.Location = New System.Drawing.Point(48, 160)
		Me._txtRune_7.TabIndex = 50
		Me._txtRune_7.Text = "999"
		Me._txtRune_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRune_7.AcceptsReturn = True
		Me._txtRune_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRune_7.BackColor = System.Drawing.SystemColors.Window
		Me._txtRune_7.CausesValidation = True
		Me._txtRune_7.Enabled = True
		Me._txtRune_7.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRune_7.HideSelection = True
		Me._txtRune_7.ReadOnly = False
		Me._txtRune_7.Maxlength = 0
		Me._txtRune_7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRune_7.MultiLine = False
		Me._txtRune_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRune_7.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRune_7.TabStop = True
		Me._txtRune_7.Visible = True
		Me._txtRune_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRune_7.Name = "_txtRune_7"
		Me._txtRune_6.AutoSize = False
		Me._txtRune_6.Size = New System.Drawing.Size(25, 19)
		Me._txtRune_6.Location = New System.Drawing.Point(48, 140)
		Me._txtRune_6.TabIndex = 48
		Me._txtRune_6.Text = "999"
		Me._txtRune_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRune_6.AcceptsReturn = True
		Me._txtRune_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRune_6.BackColor = System.Drawing.SystemColors.Window
		Me._txtRune_6.CausesValidation = True
		Me._txtRune_6.Enabled = True
		Me._txtRune_6.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRune_6.HideSelection = True
		Me._txtRune_6.ReadOnly = False
		Me._txtRune_6.Maxlength = 0
		Me._txtRune_6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRune_6.MultiLine = False
		Me._txtRune_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRune_6.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRune_6.TabStop = True
		Me._txtRune_6.Visible = True
		Me._txtRune_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRune_6.Name = "_txtRune_6"
		Me._txtRune_5.AutoSize = False
		Me._txtRune_5.Size = New System.Drawing.Size(25, 19)
		Me._txtRune_5.Location = New System.Drawing.Point(48, 120)
		Me._txtRune_5.TabIndex = 46
		Me._txtRune_5.Text = "999"
		Me._txtRune_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRune_5.AcceptsReturn = True
		Me._txtRune_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRune_5.BackColor = System.Drawing.SystemColors.Window
		Me._txtRune_5.CausesValidation = True
		Me._txtRune_5.Enabled = True
		Me._txtRune_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRune_5.HideSelection = True
		Me._txtRune_5.ReadOnly = False
		Me._txtRune_5.Maxlength = 0
		Me._txtRune_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRune_5.MultiLine = False
		Me._txtRune_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRune_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRune_5.TabStop = True
		Me._txtRune_5.Visible = True
		Me._txtRune_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRune_5.Name = "_txtRune_5"
		Me._txtRune_4.AutoSize = False
		Me._txtRune_4.Size = New System.Drawing.Size(25, 19)
		Me._txtRune_4.Location = New System.Drawing.Point(48, 100)
		Me._txtRune_4.TabIndex = 44
		Me._txtRune_4.Text = "999"
		Me._txtRune_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRune_4.AcceptsReturn = True
		Me._txtRune_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRune_4.BackColor = System.Drawing.SystemColors.Window
		Me._txtRune_4.CausesValidation = True
		Me._txtRune_4.Enabled = True
		Me._txtRune_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRune_4.HideSelection = True
		Me._txtRune_4.ReadOnly = False
		Me._txtRune_4.Maxlength = 0
		Me._txtRune_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRune_4.MultiLine = False
		Me._txtRune_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRune_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRune_4.TabStop = True
		Me._txtRune_4.Visible = True
		Me._txtRune_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRune_4.Name = "_txtRune_4"
		Me._txtRune_3.AutoSize = False
		Me._txtRune_3.Size = New System.Drawing.Size(25, 19)
		Me._txtRune_3.Location = New System.Drawing.Point(48, 80)
		Me._txtRune_3.TabIndex = 42
		Me._txtRune_3.Text = "999"
		Me._txtRune_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRune_3.AcceptsReturn = True
		Me._txtRune_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRune_3.BackColor = System.Drawing.SystemColors.Window
		Me._txtRune_3.CausesValidation = True
		Me._txtRune_3.Enabled = True
		Me._txtRune_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRune_3.HideSelection = True
		Me._txtRune_3.ReadOnly = False
		Me._txtRune_3.Maxlength = 0
		Me._txtRune_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRune_3.MultiLine = False
		Me._txtRune_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRune_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRune_3.TabStop = True
		Me._txtRune_3.Visible = True
		Me._txtRune_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRune_3.Name = "_txtRune_3"
		Me._txtRune_2.AutoSize = False
		Me._txtRune_2.Size = New System.Drawing.Size(25, 19)
		Me._txtRune_2.Location = New System.Drawing.Point(48, 60)
		Me._txtRune_2.TabIndex = 40
		Me._txtRune_2.Text = "999"
		Me._txtRune_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRune_2.AcceptsReturn = True
		Me._txtRune_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRune_2.BackColor = System.Drawing.SystemColors.Window
		Me._txtRune_2.CausesValidation = True
		Me._txtRune_2.Enabled = True
		Me._txtRune_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRune_2.HideSelection = True
		Me._txtRune_2.ReadOnly = False
		Me._txtRune_2.Maxlength = 0
		Me._txtRune_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRune_2.MultiLine = False
		Me._txtRune_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRune_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRune_2.TabStop = True
		Me._txtRune_2.Visible = True
		Me._txtRune_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRune_2.Name = "_txtRune_2"
		Me._txtRune_1.AutoSize = False
		Me._txtRune_1.Size = New System.Drawing.Size(25, 19)
		Me._txtRune_1.Location = New System.Drawing.Point(48, 40)
		Me._txtRune_1.TabIndex = 38
		Me._txtRune_1.Text = "999"
		Me._txtRune_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRune_1.AcceptsReturn = True
		Me._txtRune_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRune_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtRune_1.CausesValidation = True
		Me._txtRune_1.Enabled = True
		Me._txtRune_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRune_1.HideSelection = True
		Me._txtRune_1.ReadOnly = False
		Me._txtRune_1.Maxlength = 0
		Me._txtRune_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRune_1.MultiLine = False
		Me._txtRune_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRune_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRune_1.TabStop = True
		Me._txtRune_1.Visible = True
		Me._txtRune_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRune_1.Name = "_txtRune_1"
		Me._txtRune_0.AutoSize = False
		Me._txtRune_0.Size = New System.Drawing.Size(25, 19)
		Me._txtRune_0.Location = New System.Drawing.Point(48, 20)
		Me._txtRune_0.Maxlength = 3
		Me._txtRune_0.TabIndex = 36
		Me._txtRune_0.Text = "999"
		Me._txtRune_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRune_0.AcceptsReturn = True
		Me._txtRune_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRune_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtRune_0.CausesValidation = True
		Me._txtRune_0.Enabled = True
		Me._txtRune_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRune_0.HideSelection = True
		Me._txtRune_0.ReadOnly = False
		Me._txtRune_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRune_0.MultiLine = False
		Me._txtRune_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRune_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRune_0.TabStop = True
		Me._txtRune_0.Visible = True
		Me._txtRune_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRune_0.Name = "_txtRune_0"
		Me._lblRune_19.Text = "Eternium"
		Me._lblRune_19.Size = New System.Drawing.Size(45, 13)
		Me._lblRune_19.Location = New System.Drawing.Point(80, 204)
		Me._lblRune_19.TabIndex = 75
		Me._lblRune_19.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblRune_19.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblRune_19.BackColor = System.Drawing.SystemColors.Control
		Me._lblRune_19.Enabled = True
		Me._lblRune_19.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblRune_19.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblRune_19.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblRune_19.UseMnemonic = True
		Me._lblRune_19.Visible = True
		Me._lblRune_19.AutoSize = False
		Me._lblRune_19.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblRune_19.Name = "_lblRune_19"
		Me._lblRune_18.Text = "Dreams"
		Me._lblRune_18.Size = New System.Drawing.Size(45, 13)
		Me._lblRune_18.Location = New System.Drawing.Point(80, 184)
		Me._lblRune_18.TabIndex = 73
		Me._lblRune_18.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblRune_18.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblRune_18.BackColor = System.Drawing.SystemColors.Control
		Me._lblRune_18.Enabled = True
		Me._lblRune_18.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblRune_18.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblRune_18.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblRune_18.UseMnemonic = True
		Me._lblRune_18.Visible = True
		Me._lblRune_18.AutoSize = False
		Me._lblRune_18.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblRune_18.Name = "_lblRune_18"
		Me._lblRune_17.Text = "Abyss"
		Me._lblRune_17.Size = New System.Drawing.Size(45, 13)
		Me._lblRune_17.Location = New System.Drawing.Point(80, 164)
		Me._lblRune_17.TabIndex = 71
		Me._lblRune_17.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblRune_17.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblRune_17.BackColor = System.Drawing.SystemColors.Control
		Me._lblRune_17.Enabled = True
		Me._lblRune_17.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblRune_17.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblRune_17.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblRune_17.UseMnemonic = True
		Me._lblRune_17.Visible = True
		Me._lblRune_17.AutoSize = False
		Me._lblRune_17.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblRune_17.Name = "_lblRune_17"
		Me._lblRune_16.Text = "Twilight"
		Me._lblRune_16.Size = New System.Drawing.Size(45, 13)
		Me._lblRune_16.Location = New System.Drawing.Point(80, 144)
		Me._lblRune_16.TabIndex = 69
		Me._lblRune_16.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblRune_16.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblRune_16.BackColor = System.Drawing.SystemColors.Control
		Me._lblRune_16.Enabled = True
		Me._lblRune_16.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblRune_16.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblRune_16.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblRune_16.UseMnemonic = True
		Me._lblRune_16.Visible = True
		Me._lblRune_16.AutoSize = False
		Me._lblRune_16.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblRune_16.Name = "_lblRune_16"
		Me._lblRune_15.Text = "Animal"
		Me._lblRune_15.Size = New System.Drawing.Size(45, 13)
		Me._lblRune_15.Location = New System.Drawing.Point(80, 124)
		Me._lblRune_15.TabIndex = 67
		Me._lblRune_15.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblRune_15.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblRune_15.BackColor = System.Drawing.SystemColors.Control
		Me._lblRune_15.Enabled = True
		Me._lblRune_15.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblRune_15.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblRune_15.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblRune_15.UseMnemonic = True
		Me._lblRune_15.Visible = True
		Me._lblRune_15.AutoSize = False
		Me._lblRune_15.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblRune_15.Name = "_lblRune_15"
		Me._lblRune_14.Text = "Fish"
		Me._lblRune_14.Size = New System.Drawing.Size(45, 13)
		Me._lblRune_14.Location = New System.Drawing.Point(80, 104)
		Me._lblRune_14.TabIndex = 65
		Me._lblRune_14.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblRune_14.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblRune_14.BackColor = System.Drawing.SystemColors.Control
		Me._lblRune_14.Enabled = True
		Me._lblRune_14.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblRune_14.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblRune_14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblRune_14.UseMnemonic = True
		Me._lblRune_14.Visible = True
		Me._lblRune_14.AutoSize = False
		Me._lblRune_14.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblRune_14.Name = "_lblRune_14"
		Me._lblRune_13.Text = "Man"
		Me._lblRune_13.Size = New System.Drawing.Size(45, 13)
		Me._lblRune_13.Location = New System.Drawing.Point(80, 84)
		Me._lblRune_13.TabIndex = 63
		Me._lblRune_13.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblRune_13.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblRune_13.BackColor = System.Drawing.SystemColors.Control
		Me._lblRune_13.Enabled = True
		Me._lblRune_13.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblRune_13.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblRune_13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblRune_13.UseMnemonic = True
		Me._lblRune_13.Visible = True
		Me._lblRune_13.AutoSize = False
		Me._lblRune_13.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblRune_13.Name = "_lblRune_13"
		Me._lblRune_12.Text = "Insect"
		Me._lblRune_12.Size = New System.Drawing.Size(45, 13)
		Me._lblRune_12.Location = New System.Drawing.Point(80, 64)
		Me._lblRune_12.TabIndex = 61
		Me._lblRune_12.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblRune_12.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblRune_12.BackColor = System.Drawing.SystemColors.Control
		Me._lblRune_12.Enabled = True
		Me._lblRune_12.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblRune_12.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblRune_12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblRune_12.UseMnemonic = True
		Me._lblRune_12.Visible = True
		Me._lblRune_12.AutoSize = False
		Me._lblRune_12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblRune_12.Name = "_lblRune_12"
		Me._lblRune_11.Text = "Space"
		Me._lblRune_11.Size = New System.Drawing.Size(45, 13)
		Me._lblRune_11.Location = New System.Drawing.Point(80, 44)
		Me._lblRune_11.TabIndex = 59
		Me._lblRune_11.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblRune_11.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblRune_11.BackColor = System.Drawing.SystemColors.Control
		Me._lblRune_11.Enabled = True
		Me._lblRune_11.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblRune_11.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblRune_11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblRune_11.UseMnemonic = True
		Me._lblRune_11.Visible = True
		Me._lblRune_11.AutoSize = False
		Me._lblRune_11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblRune_11.Name = "_lblRune_11"
		Me._lblRune_10.Text = "Suns"
		Me._lblRune_10.Size = New System.Drawing.Size(45, 13)
		Me._lblRune_10.Location = New System.Drawing.Point(80, 24)
		Me._lblRune_10.TabIndex = 57
		Me._lblRune_10.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblRune_10.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblRune_10.BackColor = System.Drawing.SystemColors.Control
		Me._lblRune_10.Enabled = True
		Me._lblRune_10.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblRune_10.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblRune_10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblRune_10.UseMnemonic = True
		Me._lblRune_10.Visible = True
		Me._lblRune_10.AutoSize = False
		Me._lblRune_10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblRune_10.Name = "_lblRune_10"
		Me._lblRune_9.Text = "Moons"
		Me._lblRune_9.Size = New System.Drawing.Size(45, 13)
		Me._lblRune_9.Location = New System.Drawing.Point(8, 204)
		Me._lblRune_9.TabIndex = 55
		Me._lblRune_9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblRune_9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblRune_9.BackColor = System.Drawing.SystemColors.Control
		Me._lblRune_9.Enabled = True
		Me._lblRune_9.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblRune_9.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblRune_9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblRune_9.UseMnemonic = True
		Me._lblRune_9.Visible = True
		Me._lblRune_9.AutoSize = False
		Me._lblRune_9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblRune_9.Name = "_lblRune_9"
		Me._lblRune_8.Text = "Time"
		Me._lblRune_8.Size = New System.Drawing.Size(45, 13)
		Me._lblRune_8.Location = New System.Drawing.Point(8, 184)
		Me._lblRune_8.TabIndex = 53
		Me._lblRune_8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblRune_8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblRune_8.BackColor = System.Drawing.SystemColors.Control
		Me._lblRune_8.Enabled = True
		Me._lblRune_8.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblRune_8.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblRune_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblRune_8.UseMnemonic = True
		Me._lblRune_8.Visible = True
		Me._lblRune_8.AutoSize = False
		Me._lblRune_8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblRune_8.Name = "_lblRune_8"
		Me._lblRune_7.Text = "Air"
		Me._lblRune_7.Size = New System.Drawing.Size(45, 13)
		Me._lblRune_7.Location = New System.Drawing.Point(8, 164)
		Me._lblRune_7.TabIndex = 51
		Me._lblRune_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblRune_7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblRune_7.BackColor = System.Drawing.SystemColors.Control
		Me._lblRune_7.Enabled = True
		Me._lblRune_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblRune_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblRune_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblRune_7.UseMnemonic = True
		Me._lblRune_7.Visible = True
		Me._lblRune_7.AutoSize = False
		Me._lblRune_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblRune_7.Name = "_lblRune_7"
		Me._lblRune_6.Text = "Water"
		Me._lblRune_6.Size = New System.Drawing.Size(45, 13)
		Me._lblRune_6.Location = New System.Drawing.Point(8, 144)
		Me._lblRune_6.TabIndex = 49
		Me._lblRune_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblRune_6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblRune_6.BackColor = System.Drawing.SystemColors.Control
		Me._lblRune_6.Enabled = True
		Me._lblRune_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblRune_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblRune_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblRune_6.UseMnemonic = True
		Me._lblRune_6.Visible = True
		Me._lblRune_6.AutoSize = False
		Me._lblRune_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblRune_6.Name = "_lblRune_6"
		Me._lblRune_5.Text = "Earth"
		Me._lblRune_5.Size = New System.Drawing.Size(45, 13)
		Me._lblRune_5.Location = New System.Drawing.Point(8, 124)
		Me._lblRune_5.TabIndex = 47
		Me._lblRune_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblRune_5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblRune_5.BackColor = System.Drawing.SystemColors.Control
		Me._lblRune_5.Enabled = True
		Me._lblRune_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblRune_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblRune_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblRune_5.UseMnemonic = True
		Me._lblRune_5.Visible = True
		Me._lblRune_5.AutoSize = False
		Me._lblRune_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblRune_5.Name = "_lblRune_5"
		Me._lblRune_4.Text = "Fire"
		Me._lblRune_4.Size = New System.Drawing.Size(45, 13)
		Me._lblRune_4.Location = New System.Drawing.Point(8, 104)
		Me._lblRune_4.TabIndex = 45
		Me._lblRune_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblRune_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblRune_4.BackColor = System.Drawing.SystemColors.Control
		Me._lblRune_4.Enabled = True
		Me._lblRune_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblRune_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblRune_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblRune_4.UseMnemonic = True
		Me._lblRune_4.Visible = True
		Me._lblRune_4.AutoSize = False
		Me._lblRune_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblRune_4.Name = "_lblRune_4"
		Me._lblRune_3.Text = "Nectar"
		Me._lblRune_3.Size = New System.Drawing.Size(45, 13)
		Me._lblRune_3.Location = New System.Drawing.Point(8, 84)
		Me._lblRune_3.TabIndex = 43
		Me._lblRune_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblRune_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblRune_3.BackColor = System.Drawing.SystemColors.Control
		Me._lblRune_3.Enabled = True
		Me._lblRune_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblRune_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblRune_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblRune_3.UseMnemonic = True
		Me._lblRune_3.Visible = True
		Me._lblRune_3.AutoSize = False
		Me._lblRune_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblRune_3.Name = "_lblRune_3"
		Me._lblRune_2.Text = "Oil"
		Me._lblRune_2.Size = New System.Drawing.Size(45, 13)
		Me._lblRune_2.Location = New System.Drawing.Point(8, 64)
		Me._lblRune_2.TabIndex = 41
		Me._lblRune_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblRune_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblRune_2.BackColor = System.Drawing.SystemColors.Control
		Me._lblRune_2.Enabled = True
		Me._lblRune_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblRune_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblRune_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblRune_2.UseMnemonic = True
		Me._lblRune_2.Visible = True
		Me._lblRune_2.AutoSize = False
		Me._lblRune_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblRune_2.Name = "_lblRune_2"
		Me._lblRune_1.Text = "Bile"
		Me._lblRune_1.Size = New System.Drawing.Size(45, 13)
		Me._lblRune_1.Location = New System.Drawing.Point(8, 44)
		Me._lblRune_1.TabIndex = 39
		Me._lblRune_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblRune_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblRune_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblRune_1.Enabled = True
		Me._lblRune_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblRune_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblRune_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblRune_1.UseMnemonic = True
		Me._lblRune_1.Visible = True
		Me._lblRune_1.AutoSize = False
		Me._lblRune_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblRune_1.Name = "_lblRune_1"
		Me._lblRune_0.Text = "Blood"
		Me._lblRune_0.Size = New System.Drawing.Size(45, 13)
		Me._lblRune_0.Location = New System.Drawing.Point(8, 24)
		Me._lblRune_0.TabIndex = 37
		Me._lblRune_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblRune_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblRune_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblRune_0.Enabled = True
		Me._lblRune_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblRune_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblRune_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblRune_0.UseMnemonic = True
		Me._lblRune_0.Visible = True
		Me._lblRune_0.AutoSize = False
		Me._lblRune_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblRune_0.Name = "_lblRune_0"
		Me.Frame1.Text = "Description"
		Me.Frame1.Size = New System.Drawing.Size(213, 161)
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
		Me.chkCanCamp.Text = "Can Camp?"
		Me.chkCanCamp.Size = New System.Drawing.Size(81, 13)
		Me.chkCanCamp.Location = New System.Drawing.Point(124, 54)
		Me.chkCanCamp.TabIndex = 91
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
		Me.cmbMapStyle.Size = New System.Drawing.Size(108, 21)
		Me.cmbMapStyle.Location = New System.Drawing.Point(72, 132)
		Me.cmbMapStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbMapStyle.TabIndex = 81
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
		Me.txtWidth.AutoSize = False
		Me.txtWidth.Size = New System.Drawing.Size(25, 19)
		Me.txtWidth.Location = New System.Drawing.Point(144, 32)
		Me.txtWidth.TabIndex = 32
		Me.txtWidth.Text = "999"
		Me.txtWidth.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtWidth.AcceptsReturn = True
		Me.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtWidth.BackColor = System.Drawing.SystemColors.Window
		Me.txtWidth.CausesValidation = True
		Me.txtWidth.Enabled = True
		Me.txtWidth.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtWidth.HideSelection = True
		Me.txtWidth.ReadOnly = False
		Me.txtWidth.Maxlength = 0
		Me.txtWidth.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtWidth.MultiLine = False
		Me.txtWidth.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtWidth.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtWidth.TabStop = True
		Me.txtWidth.Visible = True
		Me.txtWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtWidth.Name = "txtWidth"
		Me.txtHeight.AutoSize = False
		Me.txtHeight.Size = New System.Drawing.Size(25, 19)
		Me.txtHeight.Location = New System.Drawing.Point(180, 32)
		Me.txtHeight.TabIndex = 31
		Me.txtHeight.Text = "999"
		Me.txtHeight.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHeight.AcceptsReturn = True
		Me.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtHeight.BackColor = System.Drawing.SystemColors.Window
		Me.txtHeight.CausesValidation = True
		Me.txtHeight.Enabled = True
		Me.txtHeight.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtHeight.HideSelection = True
		Me.txtHeight.ReadOnly = False
		Me.txtHeight.Maxlength = 0
		Me.txtHeight.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtHeight.MultiLine = False
		Me.txtHeight.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtHeight.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtHeight.TabStop = True
		Me.txtHeight.Visible = True
		Me.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtHeight.Name = "txtHeight"
		Me.txtComments.AutoSize = False
		Me.txtComments.Size = New System.Drawing.Size(197, 58)
		Me.txtComments.Location = New System.Drawing.Point(8, 69)
		Me.txtComments.MultiLine = True
		Me.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtComments.TabIndex = 9
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
		Me.txtName.Size = New System.Drawing.Size(129, 19)
		Me.txtName.Location = New System.Drawing.Point(8, 32)
		Me.txtName.TabIndex = 8
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
		Me._Label1_3.Text = "Map Style"
		Me._Label1_3.Size = New System.Drawing.Size(53, 13)
		Me._Label1_3.Location = New System.Drawing.Point(16, 136)
		Me._Label1_3.TabIndex = 82
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
		Me._Label1_0.Text = "Width"
		Me._Label1_0.Size = New System.Drawing.Size(37, 13)
		Me._Label1_0.Location = New System.Drawing.Point(136, 16)
		Me._Label1_0.TabIndex = 34
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
		Me._Label1_1.Text = "Height"
		Me._Label1_1.Size = New System.Drawing.Size(37, 13)
		Me._Label1_1.Location = New System.Drawing.Point(172, 16)
		Me._Label1_1.TabIndex = 33
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
		Me._Label1_7.Text = "Comments"
		Me._Label1_7.Size = New System.Drawing.Size(81, 13)
		Me._Label1_7.Location = New System.Drawing.Point(8, 54)
		Me._Label1_7.TabIndex = 7
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
		Me._lblName_2.Text = "Name"
		Me._lblName_2.Size = New System.Drawing.Size(41, 13)
		Me._lblName_2.Location = New System.Drawing.Point(8, 16)
		Me._lblName_2.TabIndex = 6
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
		Me._fraMap_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._fraMap_1.Size = New System.Drawing.Size(385, 229)
		Me._fraMap_1.Location = New System.Drawing.Point(12, 28)
		Me._fraMap_1.TabIndex = 10
		Me._fraMap_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraMap_1.BackColor = System.Drawing.SystemColors.Control
		Me._fraMap_1.Enabled = True
		Me._fraMap_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraMap_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._fraMap_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraMap_1.Visible = True
		Me._fraMap_1.Name = "_fraMap_1"
		Me.btnLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnLibrary.Text = "Insert from library"
		Me.btnLibrary.Size = New System.Drawing.Size(73, 49)
		Me.btnLibrary.Location = New System.Drawing.Point(308, 48)
		Me.btnLibrary.TabIndex = 102
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
		Me.btnPaste.Location = New System.Drawing.Point(308, 200)
		Me.btnPaste.TabIndex = 30
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
		Me.btnCopy.Location = New System.Drawing.Point(308, 176)
		Me.btnCopy.TabIndex = 29
		Me.btnCopy.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCopy.CausesValidation = True
		Me.btnCopy.Enabled = True
		Me.btnCopy.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCopy.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCopy.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCopy.TabStop = True
		Me.btnCopy.Name = "btnCopy"
		Me.lstThings.Size = New System.Drawing.Size(301, 202)
		Me.lstThings.Location = New System.Drawing.Point(0, 24)
		Me.lstThings.TabIndex = 14
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
		Me.btnEdit.Location = New System.Drawing.Point(308, 100)
		Me.btnEdit.TabIndex = 13
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
		Me.btnInsert.Location = New System.Drawing.Point(308, 24)
		Me.btnInsert.TabIndex = 12
		Me.btnInsert.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnInsert.CausesValidation = True
		Me.btnInsert.Enabled = True
		Me.btnInsert.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnInsert.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnInsert.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnInsert.TabStop = True
		Me.btnInsert.Name = "btnInsert"
		Me.btnCut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnCut.BackColor = System.Drawing.SystemColors.Control
		Me.btnCut.Text = "Cut"
		Me.btnCut.Size = New System.Drawing.Size(73, 21)
		Me.btnCut.Location = New System.Drawing.Point(308, 152)
		Me.btnCut.TabIndex = 11
		Me.btnCut.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCut.CausesValidation = True
		Me.btnCut.Enabled = True
		Me.btnCut.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCut.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCut.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCut.TabStop = True
		Me.btnCut.Name = "btnCut"
		Me.lblAttached.Text = "Themes Attached to Map"
		Me.lblAttached.Size = New System.Drawing.Size(289, 13)
		Me.lblAttached.Location = New System.Drawing.Point(0, 4)
		Me.lblAttached.TabIndex = 15
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
		Me.txtWandering.AutoSize = False
		Me.txtWandering.Size = New System.Drawing.Size(33, 19)
		Me.txtWandering.Location = New System.Drawing.Point(128, 272)
		Me.txtWandering.TabIndex = 101
		Me.txtWandering.Text = "None"
		Me.txtWandering.Visible = False
		Me.txtWandering.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtWandering.AcceptsReturn = True
		Me.txtWandering.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtWandering.BackColor = System.Drawing.SystemColors.Window
		Me.txtWandering.CausesValidation = True
		Me.txtWandering.Enabled = True
		Me.txtWandering.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtWandering.HideSelection = True
		Me.txtWandering.ReadOnly = False
		Me.txtWandering.Maxlength = 0
		Me.txtWandering.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtWandering.MultiLine = False
		Me.txtWandering.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtWandering.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtWandering.TabStop = True
		Me.txtWandering.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtWandering.Name = "txtWandering"
		Me.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnApply.BackColor = System.Drawing.SystemColors.Control
		Me.btnApply.Text = "Apply"
		Me.btnApply.Enabled = False
		Me.btnApply.Size = New System.Drawing.Size(73, 21)
		Me.btnApply.Location = New System.Drawing.Point(327, 272)
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
		Me.btnOk.Location = New System.Drawing.Point(167, 272)
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
		Me.btnCancel.Location = New System.Drawing.Point(247, 272)
		Me.btnCancel.TabIndex = 0
		Me.btnCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancel.CausesValidation = True
		Me.btnCancel.Enabled = True
		Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCancel.TabStop = True
		Me.btnCancel.Name = "btnCancel"
		tabMapProp.OcxState = CType(resources.GetObject("tabMapProp.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tabMapProp.Size = New System.Drawing.Size(397, 261)
		Me.tabMapProp.Location = New System.Drawing.Point(4, 4)
		Me.tabMapProp.TabIndex = 3
		Me.tabMapProp.Name = "tabMapProp"
		Me._fraMap_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._fraMap_2.Size = New System.Drawing.Size(389, 229)
		Me._fraMap_2.Location = New System.Drawing.Point(8, 28)
		Me._fraMap_2.TabIndex = 16
		Me._fraMap_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraMap_2.BackColor = System.Drawing.SystemColors.Control
		Me._fraMap_2.Enabled = True
		Me._fraMap_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraMap_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._fraMap_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraMap_2.Visible = True
		Me._fraMap_2.Name = "_fraMap_2"
		Me.fraHazard.Text = "Wandering Monsters"
		Me.fraHazard.Size = New System.Drawing.Size(205, 119)
		Me.fraHazard.Location = New System.Drawing.Point(184, 107)
		Me.fraHazard.TabIndex = 92
		Me.fraHazard.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraHazard.BackColor = System.Drawing.SystemColors.Control
		Me.fraHazard.Enabled = True
		Me.fraHazard.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraHazard.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraHazard.Visible = True
		Me.fraHazard.Padding = New System.Windows.Forms.Padding(0)
		Me.fraHazard.Name = "fraHazard"
		Me.cmbInterval.Size = New System.Drawing.Size(85, 21)
		Me.cmbInterval.Location = New System.Drawing.Point(117, 20)
		Me.cmbInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbInterval.TabIndex = 96
		Me.cmbInterval.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbInterval.BackColor = System.Drawing.SystemColors.Window
		Me.cmbInterval.CausesValidation = True
		Me.cmbInterval.Enabled = True
		Me.cmbInterval.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbInterval.IntegralHeight = True
		Me.cmbInterval.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbInterval.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbInterval.Sorted = False
		Me.cmbInterval.TabStop = True
		Me.cmbInterval.Visible = True
		Me.cmbInterval.Name = "cmbInterval"
		Me.cmbFrequency.Size = New System.Drawing.Size(85, 21)
		Me.cmbFrequency.Location = New System.Drawing.Point(117, 50)
		Me.cmbFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbFrequency.TabIndex = 95
		Me.cmbFrequency.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbFrequency.BackColor = System.Drawing.SystemColors.Window
		Me.cmbFrequency.CausesValidation = True
		Me.cmbFrequency.Enabled = True
		Me.cmbFrequency.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbFrequency.IntegralHeight = True
		Me.cmbFrequency.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbFrequency.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbFrequency.Sorted = False
		Me.cmbFrequency.TabStop = True
		Me.cmbFrequency.Visible = True
		Me.cmbFrequency.Name = "cmbFrequency"
		Me.cmbWandering.Size = New System.Drawing.Size(153, 21)
		Me.cmbWandering.Location = New System.Drawing.Point(48, 94)
		Me.cmbWandering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbWandering.TabIndex = 93
		Me.cmbWandering.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbWandering.BackColor = System.Drawing.SystemColors.Window
		Me.cmbWandering.CausesValidation = True
		Me.cmbWandering.Enabled = True
		Me.cmbWandering.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbWandering.IntegralHeight = True
		Me.cmbWandering.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbWandering.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbWandering.Sorted = False
		Me.cmbWandering.TabStop = True
		Me.cmbWandering.Visible = True
		Me.cmbWandering.Name = "cmbWandering"
		Me.lblInterval.Text = "Interval between rest periods"
		Me.lblInterval.Size = New System.Drawing.Size(89, 25)
		Me.lblInterval.Location = New System.Drawing.Point(4, 16)
		Me.lblInterval.TabIndex = 98
		Me.lblInterval.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblInterval.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblInterval.BackColor = System.Drawing.SystemColors.Control
		Me.lblInterval.Enabled = True
		Me.lblInterval.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblInterval.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblInterval.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblInterval.UseMnemonic = True
		Me.lblInterval.Visible = True
		Me.lblInterval.AutoSize = False
		Me.lblInterval.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblInterval.Name = "lblInterval"
		Me.lblHazard.Text = "Chances of wandering monsters appearances"
		Me.lblHazard.Size = New System.Drawing.Size(113, 25)
		Me.lblHazard.Location = New System.Drawing.Point(4, 46)
		Me.lblHazard.TabIndex = 97
		Me.lblHazard.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHazard.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblHazard.BackColor = System.Drawing.SystemColors.Control
		Me.lblHazard.Enabled = True
		Me.lblHazard.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblHazard.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblHazard.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblHazard.UseMnemonic = True
		Me.lblHazard.Visible = True
		Me.lblHazard.AutoSize = False
		Me.lblHazard.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblHazard.Name = "lblHazard"
		Me.lblMonsters.Text = "Choice of wandering monsters"
		Me.lblMonsters.Size = New System.Drawing.Size(161, 17)
		Me.lblMonsters.Location = New System.Drawing.Point(4, 80)
		Me.lblMonsters.TabIndex = 94
		Me.lblMonsters.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMonsters.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMonsters.BackColor = System.Drawing.SystemColors.Control
		Me.lblMonsters.Enabled = True
		Me.lblMonsters.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMonsters.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMonsters.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMonsters.UseMnemonic = True
		Me.lblMonsters.Visible = True
		Me.lblMonsters.AutoSize = False
		Me.lblMonsters.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMonsters.Name = "lblMonsters"
		Me.Frame4.Text = "Settings"
		Me.Frame4.Size = New System.Drawing.Size(205, 107)
		Me.Frame4.Location = New System.Drawing.Point(184, 0)
		Me.Frame4.TabIndex = 20
		Me.Frame4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame4.BackColor = System.Drawing.SystemColors.Control
		Me.Frame4.Enabled = True
		Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame4.Visible = True
		Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame4.Name = "Frame4"
		Me.chkReGenAppend.Text = "Append to Existing Map?"
		Me.chkReGenAppend.Size = New System.Drawing.Size(141, 17)
		Me.chkReGenAppend.Location = New System.Drawing.Point(20, 16)
		Me.chkReGenAppend.TabIndex = 87
		Me.chkReGenAppend.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkReGenAppend.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkReGenAppend.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkReGenAppend.BackColor = System.Drawing.SystemColors.Control
		Me.chkReGenAppend.CausesValidation = True
		Me.chkReGenAppend.Enabled = True
		Me.chkReGenAppend.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkReGenAppend.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkReGenAppend.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkReGenAppend.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkReGenAppend.TabStop = True
		Me.chkReGenAppend.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkReGenAppend.Visible = True
		Me.chkReGenAppend.Name = "chkReGenAppend"
		Me.txtDefaultEncounters.AutoSize = False
		Me.txtDefaultEncounters.Size = New System.Drawing.Size(41, 19)
		Me.txtDefaultEncounters.Location = New System.Drawing.Point(104, 84)
		Me.txtDefaultEncounters.TabIndex = 25
		Me.txtDefaultEncounters.Text = "Text1"
		Me.txtDefaultEncounters.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDefaultEncounters.AcceptsReturn = True
		Me.txtDefaultEncounters.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDefaultEncounters.BackColor = System.Drawing.SystemColors.Window
		Me.txtDefaultEncounters.CausesValidation = True
		Me.txtDefaultEncounters.Enabled = True
		Me.txtDefaultEncounters.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDefaultEncounters.HideSelection = True
		Me.txtDefaultEncounters.ReadOnly = False
		Me.txtDefaultEncounters.Maxlength = 0
		Me.txtDefaultEncounters.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDefaultEncounters.MultiLine = False
		Me.txtDefaultEncounters.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDefaultEncounters.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDefaultEncounters.TabStop = True
		Me.txtDefaultEncounters.Visible = True
		Me.txtDefaultEncounters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDefaultEncounters.Name = "txtDefaultEncounters"
		Me.txtDefaultHeight.AutoSize = False
		Me.txtDefaultHeight.Size = New System.Drawing.Size(41, 19)
		Me.txtDefaultHeight.Location = New System.Drawing.Point(104, 60)
		Me.txtDefaultHeight.TabIndex = 24
		Me.txtDefaultHeight.Text = "Text1"
		Me.txtDefaultHeight.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDefaultHeight.AcceptsReturn = True
		Me.txtDefaultHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDefaultHeight.BackColor = System.Drawing.SystemColors.Window
		Me.txtDefaultHeight.CausesValidation = True
		Me.txtDefaultHeight.Enabled = True
		Me.txtDefaultHeight.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDefaultHeight.HideSelection = True
		Me.txtDefaultHeight.ReadOnly = False
		Me.txtDefaultHeight.Maxlength = 0
		Me.txtDefaultHeight.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDefaultHeight.MultiLine = False
		Me.txtDefaultHeight.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDefaultHeight.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDefaultHeight.TabStop = True
		Me.txtDefaultHeight.Visible = True
		Me.txtDefaultHeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDefaultHeight.Name = "txtDefaultHeight"
		Me.txtDefaultWidth.AutoSize = False
		Me.txtDefaultWidth.Size = New System.Drawing.Size(41, 19)
		Me.txtDefaultWidth.Location = New System.Drawing.Point(104, 36)
		Me.txtDefaultWidth.TabIndex = 22
		Me.txtDefaultWidth.Text = "Text1"
		Me.txtDefaultWidth.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDefaultWidth.AcceptsReturn = True
		Me.txtDefaultWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDefaultWidth.BackColor = System.Drawing.SystemColors.Window
		Me.txtDefaultWidth.CausesValidation = True
		Me.txtDefaultWidth.Enabled = True
		Me.txtDefaultWidth.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDefaultWidth.HideSelection = True
		Me.txtDefaultWidth.ReadOnly = False
		Me.txtDefaultWidth.Maxlength = 0
		Me.txtDefaultWidth.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDefaultWidth.MultiLine = False
		Me.txtDefaultWidth.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDefaultWidth.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDefaultWidth.TabStop = True
		Me.txtDefaultWidth.Visible = True
		Me.txtDefaultWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDefaultWidth.Name = "txtDefaultWidth"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.Label3.Text = "Total Encounters"
		Me.Label3.Size = New System.Drawing.Size(81, 13)
		Me.Label3.Location = New System.Drawing.Point(16, 88)
		Me.Label3.TabIndex = 26
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.Label6.Text = "Approx. Height"
		Me.Label6.Size = New System.Drawing.Size(77, 13)
		Me.Label6.Location = New System.Drawing.Point(20, 64)
		Me.Label6.TabIndex = 23
		Me.Label6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.Label5.Text = "Approx. Width"
		Me.Label5.Size = New System.Drawing.Size(77, 13)
		Me.Label5.Location = New System.Drawing.Point(16, 40)
		Me.Label5.TabIndex = 21
		Me.Label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.Frame3.Text = "ReGenerate Map"
		Me.Frame3.Size = New System.Drawing.Size(177, 225)
		Me.Frame3.Location = New System.Drawing.Point(4, 0)
		Me.Frame3.TabIndex = 17
		Me.Frame3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Me.cmbPartySize.Size = New System.Drawing.Size(108, 21)
		Me.cmbPartySize.Location = New System.Drawing.Point(40, 36)
		Me.cmbPartySize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbPartySize.TabIndex = 84
		Me.cmbPartySize.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbPartySize.BackColor = System.Drawing.SystemColors.Window
		Me.cmbPartySize.CausesValidation = True
		Me.cmbPartySize.Enabled = True
		Me.cmbPartySize.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbPartySize.IntegralHeight = True
		Me.cmbPartySize.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbPartySize.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbPartySize.Sorted = False
		Me.cmbPartySize.TabStop = True
		Me.cmbPartySize.Visible = True
		Me.cmbPartySize.Name = "cmbPartySize"
		Me.cmbPartyAvgLevel.Size = New System.Drawing.Size(108, 21)
		Me.cmbPartyAvgLevel.Location = New System.Drawing.Point(40, 76)
		Me.cmbPartyAvgLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbPartyAvgLevel.TabIndex = 83
		Me.cmbPartyAvgLevel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbPartyAvgLevel.BackColor = System.Drawing.SystemColors.Window
		Me.cmbPartyAvgLevel.CausesValidation = True
		Me.cmbPartyAvgLevel.Enabled = True
		Me.cmbPartyAvgLevel.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbPartyAvgLevel.IntegralHeight = True
		Me.cmbPartyAvgLevel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbPartyAvgLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbPartyAvgLevel.Sorted = False
		Me.cmbPartyAvgLevel.TabStop = True
		Me.cmbPartyAvgLevel.Visible = True
		Me.cmbPartyAvgLevel.Name = "cmbPartyAvgLevel"
		Me.cmbDefaultStyle.Size = New System.Drawing.Size(105, 21)
		Me.cmbDefaultStyle.Location = New System.Drawing.Point(40, 124)
		Me.cmbDefaultStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbDefaultStyle.TabIndex = 27
		Me.cmbDefaultStyle.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbDefaultStyle.BackColor = System.Drawing.SystemColors.Window
		Me.cmbDefaultStyle.CausesValidation = True
		Me.cmbDefaultStyle.Enabled = True
		Me.cmbDefaultStyle.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbDefaultStyle.IntegralHeight = True
		Me.cmbDefaultStyle.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbDefaultStyle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbDefaultStyle.Sorted = False
		Me.cmbDefaultStyle.TabStop = True
		Me.cmbDefaultStyle.Visible = True
		Me.cmbDefaultStyle.Name = "cmbDefaultStyle"
		Me.chkReGen.Text = "ReGenerate upon first entry?"
		Me.chkReGen.Size = New System.Drawing.Size(165, 17)
		Me.chkReGen.Location = New System.Drawing.Point(8, 160)
		Me.chkReGen.TabIndex = 19
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
		Me.btnReGen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnReGen.BackColor = System.Drawing.SystemColors.Control
		Me.btnReGen.Text = "ReGen Now"
		Me.btnReGen.Size = New System.Drawing.Size(73, 21)
		Me.btnReGen.Location = New System.Drawing.Point(48, 192)
		Me.btnReGen.TabIndex = 18
		Me.btnReGen.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnReGen.CausesValidation = True
		Me.btnReGen.Enabled = True
		Me.btnReGen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnReGen.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnReGen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnReGen.TabStop = True
		Me.btnReGen.Name = "btnReGen"
		Me.Label7.Text = "Party Size"
		Me.Label7.Size = New System.Drawing.Size(93, 13)
		Me.Label7.Location = New System.Drawing.Point(40, 20)
		Me.Label7.TabIndex = 86
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
		Me.Label4.Text = "Party Avg Level"
		Me.Label4.Size = New System.Drawing.Size(93, 13)
		Me.Label4.Location = New System.Drawing.Point(40, 60)
		Me.Label4.TabIndex = 85
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
		Me.Label2.Text = "Generate Style"
		Me.Label2.Size = New System.Drawing.Size(105, 13)
		Me.Label2.Location = New System.Drawing.Point(40, 108)
		Me.Label2.TabIndex = 28
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
		Me.lblChancesWandering.Text = "None"
		Me.lblChancesWandering.Size = New System.Drawing.Size(57, 17)
		Me.lblChancesWandering.Location = New System.Drawing.Point(88, 272)
		Me.lblChancesWandering.TabIndex = 100
		Me.lblChancesWandering.Visible = False
		Me.lblChancesWandering.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblChancesWandering.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblChancesWandering.BackColor = System.Drawing.SystemColors.Control
		Me.lblChancesWandering.Enabled = True
		Me.lblChancesWandering.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblChancesWandering.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblChancesWandering.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblChancesWandering.UseMnemonic = True
		Me.lblChancesWandering.AutoSize = False
		Me.lblChancesWandering.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblChancesWandering.Name = "lblChancesWandering"
		Me.lblBetweenRests.Text = "None"
		Me.lblBetweenRests.Size = New System.Drawing.Size(41, 17)
		Me.lblBetweenRests.Location = New System.Drawing.Point(40, 272)
		Me.lblBetweenRests.TabIndex = 99
		Me.lblBetweenRests.Visible = False
		Me.lblBetweenRests.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBetweenRests.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblBetweenRests.BackColor = System.Drawing.SystemColors.Control
		Me.lblBetweenRests.Enabled = True
		Me.lblBetweenRests.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblBetweenRests.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblBetweenRests.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblBetweenRests.UseMnemonic = True
		Me.lblBetweenRests.AutoSize = False
		Me.lblBetweenRests.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblBetweenRests.Name = "lblBetweenRests"
		Me.Label1.SetIndex(_Label1_2, CType(2, Short))
		Me.Label1.SetIndex(_Label1_3, CType(3, Short))
		Me.Label1.SetIndex(_Label1_0, CType(0, Short))
		Me.Label1.SetIndex(_Label1_1, CType(1, Short))
		Me.Label1.SetIndex(_Label1_7, CType(7, Short))
		Me.fraMap.SetIndex(_fraMap_0, CType(0, Short))
		Me.fraMap.SetIndex(_fraMap_1, CType(1, Short))
		Me.fraMap.SetIndex(_fraMap_2, CType(2, Short))
		Me.lblName.SetIndex(_lblName_2, CType(2, Short))
		Me.lblRune.SetIndex(_lblRune_19, CType(19, Short))
		Me.lblRune.SetIndex(_lblRune_18, CType(18, Short))
		Me.lblRune.SetIndex(_lblRune_17, CType(17, Short))
		Me.lblRune.SetIndex(_lblRune_16, CType(16, Short))
		Me.lblRune.SetIndex(_lblRune_15, CType(15, Short))
		Me.lblRune.SetIndex(_lblRune_14, CType(14, Short))
		Me.lblRune.SetIndex(_lblRune_13, CType(13, Short))
		Me.lblRune.SetIndex(_lblRune_12, CType(12, Short))
		Me.lblRune.SetIndex(_lblRune_11, CType(11, Short))
		Me.lblRune.SetIndex(_lblRune_10, CType(10, Short))
		Me.lblRune.SetIndex(_lblRune_9, CType(9, Short))
		Me.lblRune.SetIndex(_lblRune_8, CType(8, Short))
		Me.lblRune.SetIndex(_lblRune_7, CType(7, Short))
		Me.lblRune.SetIndex(_lblRune_6, CType(6, Short))
		Me.lblRune.SetIndex(_lblRune_5, CType(5, Short))
		Me.lblRune.SetIndex(_lblRune_4, CType(4, Short))
		Me.lblRune.SetIndex(_lblRune_3, CType(3, Short))
		Me.lblRune.SetIndex(_lblRune_2, CType(2, Short))
		Me.lblRune.SetIndex(_lblRune_1, CType(1, Short))
		Me.lblRune.SetIndex(_lblRune_0, CType(0, Short))
		Me.optIsNoRunes.SetIndex(_optIsNoRunes_1, CType(1, Short))
		Me.optIsNoRunes.SetIndex(_optIsNoRunes_0, CType(0, Short))
		Me.txtRune.SetIndex(_txtRune_19, CType(19, Short))
		Me.txtRune.SetIndex(_txtRune_18, CType(18, Short))
		Me.txtRune.SetIndex(_txtRune_17, CType(17, Short))
		Me.txtRune.SetIndex(_txtRune_16, CType(16, Short))
		Me.txtRune.SetIndex(_txtRune_15, CType(15, Short))
		Me.txtRune.SetIndex(_txtRune_14, CType(14, Short))
		Me.txtRune.SetIndex(_txtRune_13, CType(13, Short))
		Me.txtRune.SetIndex(_txtRune_12, CType(12, Short))
		Me.txtRune.SetIndex(_txtRune_11, CType(11, Short))
		Me.txtRune.SetIndex(_txtRune_10, CType(10, Short))
		Me.txtRune.SetIndex(_txtRune_9, CType(9, Short))
		Me.txtRune.SetIndex(_txtRune_8, CType(8, Short))
		Me.txtRune.SetIndex(_txtRune_7, CType(7, Short))
		Me.txtRune.SetIndex(_txtRune_6, CType(6, Short))
		Me.txtRune.SetIndex(_txtRune_5, CType(5, Short))
		Me.txtRune.SetIndex(_txtRune_4, CType(4, Short))
		Me.txtRune.SetIndex(_txtRune_3, CType(3, Short))
		Me.txtRune.SetIndex(_txtRune_2, CType(2, Short))
		Me.txtRune.SetIndex(_txtRune_1, CType(1, Short))
		Me.txtRune.SetIndex(_txtRune_0, CType(0, Short))
		CType(Me.txtRune, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.optIsNoRunes, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblRune, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.fraMap, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tabMapProp, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(_fraMap_0)
		Me.Controls.Add(_fraMap_1)
		Me.Controls.Add(txtWandering)
		Me.Controls.Add(btnApply)
		Me.Controls.Add(btnOk)
		Me.Controls.Add(btnCancel)
		Me.Controls.Add(tabMapProp)
		Me.Controls.Add(_fraMap_2)
		Me.Controls.Add(lblChancesWandering)
		Me.Controls.Add(lblBetweenRests)
		Me._fraMap_0.Controls.Add(_optIsNoRunes_1)
		Me._fraMap_0.Controls.Add(_optIsNoRunes_0)
		Me._fraMap_0.Controls.Add(Frame5)
		Me._fraMap_0.Controls.Add(Frame2)
		Me._fraMap_0.Controls.Add(Frame1)
		Me.Frame5.Controls.Add(chkIsNoTiles)
		Me.Frame5.Controls.Add(chkAutoGenTiles)
		Me.Frame5.Controls.Add(btnBrowse)
		Me.Frame5.Controls.Add(txtPictureFile)
		Me.Frame5.Controls.Add(_Label1_2)
		Me.Frame2.Controls.Add(_txtRune_19)
		Me.Frame2.Controls.Add(_txtRune_18)
		Me.Frame2.Controls.Add(_txtRune_17)
		Me.Frame2.Controls.Add(_txtRune_16)
		Me.Frame2.Controls.Add(_txtRune_15)
		Me.Frame2.Controls.Add(_txtRune_14)
		Me.Frame2.Controls.Add(_txtRune_13)
		Me.Frame2.Controls.Add(_txtRune_12)
		Me.Frame2.Controls.Add(_txtRune_11)
		Me.Frame2.Controls.Add(_txtRune_10)
		Me.Frame2.Controls.Add(_txtRune_9)
		Me.Frame2.Controls.Add(_txtRune_8)
		Me.Frame2.Controls.Add(_txtRune_7)
		Me.Frame2.Controls.Add(_txtRune_6)
		Me.Frame2.Controls.Add(_txtRune_5)
		Me.Frame2.Controls.Add(_txtRune_4)
		Me.Frame2.Controls.Add(_txtRune_3)
		Me.Frame2.Controls.Add(_txtRune_2)
		Me.Frame2.Controls.Add(_txtRune_1)
		Me.Frame2.Controls.Add(_txtRune_0)
		Me.Frame2.Controls.Add(_lblRune_19)
		Me.Frame2.Controls.Add(_lblRune_18)
		Me.Frame2.Controls.Add(_lblRune_17)
		Me.Frame2.Controls.Add(_lblRune_16)
		Me.Frame2.Controls.Add(_lblRune_15)
		Me.Frame2.Controls.Add(_lblRune_14)
		Me.Frame2.Controls.Add(_lblRune_13)
		Me.Frame2.Controls.Add(_lblRune_12)
		Me.Frame2.Controls.Add(_lblRune_11)
		Me.Frame2.Controls.Add(_lblRune_10)
		Me.Frame2.Controls.Add(_lblRune_9)
		Me.Frame2.Controls.Add(_lblRune_8)
		Me.Frame2.Controls.Add(_lblRune_7)
		Me.Frame2.Controls.Add(_lblRune_6)
		Me.Frame2.Controls.Add(_lblRune_5)
		Me.Frame2.Controls.Add(_lblRune_4)
		Me.Frame2.Controls.Add(_lblRune_3)
		Me.Frame2.Controls.Add(_lblRune_2)
		Me.Frame2.Controls.Add(_lblRune_1)
		Me.Frame2.Controls.Add(_lblRune_0)
		Me.Frame1.Controls.Add(chkCanCamp)
		Me.Frame1.Controls.Add(cmbMapStyle)
		Me.Frame1.Controls.Add(txtWidth)
		Me.Frame1.Controls.Add(txtHeight)
		Me.Frame1.Controls.Add(txtComments)
		Me.Frame1.Controls.Add(txtName)
		Me.Frame1.Controls.Add(_Label1_3)
		Me.Frame1.Controls.Add(_Label1_0)
		Me.Frame1.Controls.Add(_Label1_1)
		Me.Frame1.Controls.Add(_Label1_7)
		Me.Frame1.Controls.Add(_lblName_2)
		Me._fraMap_1.Controls.Add(btnLibrary)
		Me._fraMap_1.Controls.Add(btnPaste)
		Me._fraMap_1.Controls.Add(btnCopy)
		Me._fraMap_1.Controls.Add(lstThings)
		Me._fraMap_1.Controls.Add(btnEdit)
		Me._fraMap_1.Controls.Add(btnInsert)
		Me._fraMap_1.Controls.Add(btnCut)
		Me._fraMap_1.Controls.Add(lblAttached)
		Me._fraMap_2.Controls.Add(fraHazard)
		Me._fraMap_2.Controls.Add(Frame4)
		Me._fraMap_2.Controls.Add(Frame3)
		Me.fraHazard.Controls.Add(cmbInterval)
		Me.fraHazard.Controls.Add(cmbFrequency)
		Me.fraHazard.Controls.Add(cmbWandering)
		Me.fraHazard.Controls.Add(lblInterval)
		Me.fraHazard.Controls.Add(lblHazard)
		Me.fraHazard.Controls.Add(lblMonsters)
		Me.Frame4.Controls.Add(chkReGenAppend)
		Me.Frame4.Controls.Add(txtDefaultEncounters)
		Me.Frame4.Controls.Add(txtDefaultHeight)
		Me.Frame4.Controls.Add(txtDefaultWidth)
		Me.Frame4.Controls.Add(Label3)
		Me.Frame4.Controls.Add(Label6)
		Me.Frame4.Controls.Add(Label5)
		Me.Frame3.Controls.Add(cmbPartySize)
		Me.Frame3.Controls.Add(cmbPartyAvgLevel)
		Me.Frame3.Controls.Add(cmbDefaultStyle)
		Me.Frame3.Controls.Add(chkReGen)
		Me.Frame3.Controls.Add(btnReGen)
		Me.Frame3.Controls.Add(Label7)
		Me.Frame3.Controls.Add(Label4)
		Me.Frame3.Controls.Add(Label2)
		Me._fraMap_0.ResumeLayout(False)
		Me.Frame5.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me._fraMap_1.ResumeLayout(False)
		Me._fraMap_2.ResumeLayout(False)
		Me.fraHazard.ResumeLayout(False)
		Me.Frame4.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class