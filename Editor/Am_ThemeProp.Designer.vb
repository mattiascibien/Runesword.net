<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmThemeProp
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
	Public WithEvents cmbPartyAvgLevel As System.Windows.Forms.ComboBox
	Public WithEvents cmbPartySize As System.Windows.Forms.ComboBox
	Public WithEvents cmbMapStyle As System.Windows.Forms.ComboBox
	Public WithEvents txtCoverage As System.Windows.Forms.TextBox
	Public WithEvents btnReGen As System.Windows.Forms.Button
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents _lblName_0 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents chkMajorTheme As System.Windows.Forms.CheckBox
	Public WithEvents chkStoryTheme As System.Windows.Forms.CheckBox
	Public WithEvents txtName As System.Windows.Forms.TextBox
	Public WithEvents txtComments As System.Windows.Forms.TextBox
	Public WithEvents _lblName_2 As System.Windows.Forms.Label
	Public WithEvents _Label1_7 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents _fraTheme_0 As System.Windows.Forms.Panel
	Public WithEvents btnLibrary As System.Windows.Forms.Button
	Public WithEvents btnPaste As System.Windows.Forms.Button
	Public WithEvents btnCopy As System.Windows.Forms.Button
	Public WithEvents btnCut As System.Windows.Forms.Button
	Public WithEvents btnInsert As System.Windows.Forms.Button
	Public WithEvents btnEdit As System.Windows.Forms.Button
	Public WithEvents lstThings As System.Windows.Forms.ListBox
	Public WithEvents lblAttached As System.Windows.Forms.Label
	Public WithEvents _fraTheme_1 As System.Windows.Forms.Panel
	Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents btnOk As System.Windows.Forms.Button
	Public WithEvents btnApply As System.Windows.Forms.Button
	Public WithEvents tabThemeProp As AxComctlLib.AxTabStrip
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents fraTheme As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
	Public WithEvents lblName As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmThemeProp))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me._fraTheme_0 = New System.Windows.Forms.Panel
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.cmbPartyAvgLevel = New System.Windows.Forms.ComboBox
		Me.cmbPartySize = New System.Windows.Forms.ComboBox
		Me.cmbMapStyle = New System.Windows.Forms.ComboBox
		Me.txtCoverage = New System.Windows.Forms.TextBox
		Me.btnReGen = New System.Windows.Forms.Button
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me._lblName_0 = New System.Windows.Forms.Label
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.chkMajorTheme = New System.Windows.Forms.CheckBox
		Me.chkStoryTheme = New System.Windows.Forms.CheckBox
		Me.txtName = New System.Windows.Forms.TextBox
		Me.txtComments = New System.Windows.Forms.TextBox
		Me._lblName_2 = New System.Windows.Forms.Label
		Me._Label1_7 = New System.Windows.Forms.Label
		Me._fraTheme_1 = New System.Windows.Forms.Panel
		Me.btnLibrary = New System.Windows.Forms.Button
		Me.btnPaste = New System.Windows.Forms.Button
		Me.btnCopy = New System.Windows.Forms.Button
		Me.btnCut = New System.Windows.Forms.Button
		Me.btnInsert = New System.Windows.Forms.Button
		Me.btnEdit = New System.Windows.Forms.Button
		Me.lstThings = New System.Windows.Forms.ListBox
		Me.lblAttached = New System.Windows.Forms.Label
		Me.btnCancel = New System.Windows.Forms.Button
		Me.btnOk = New System.Windows.Forms.Button
		Me.btnApply = New System.Windows.Forms.Button
		Me.tabThemeProp = New AxComctlLib.AxTabStrip
		Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.fraTheme = New Microsoft.VisualBasic.Compatibility.VB6.PanelArray(components)
		Me.lblName = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me._fraTheme_0.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me._fraTheme_1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tabThemeProp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.fraTheme, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblName, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Theme Properties"
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
		Me.Name = "frmThemeProp"
		Me._fraTheme_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._fraTheme_0.Size = New System.Drawing.Size(377, 201)
		Me._fraTheme_0.Location = New System.Drawing.Point(8, 28)
		Me._fraTheme_0.TabIndex = 10
		Me._fraTheme_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraTheme_0.BackColor = System.Drawing.SystemColors.Control
		Me._fraTheme_0.Enabled = True
		Me._fraTheme_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraTheme_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._fraTheme_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraTheme_0.Visible = True
		Me._fraTheme_0.Name = "_fraTheme_0"
		Me.Frame3.Text = "ReGenerate Theme"
		Me.Frame3.Size = New System.Drawing.Size(121, 193)
		Me.Frame3.Location = New System.Drawing.Point(252, 0)
		Me.Frame3.TabIndex = 18
		Me.Frame3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Me.cmbPartyAvgLevel.Size = New System.Drawing.Size(108, 21)
		Me.cmbPartyAvgLevel.Location = New System.Drawing.Point(8, 136)
		Me.cmbPartyAvgLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbPartyAvgLevel.TabIndex = 27
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
		Me.cmbPartySize.Size = New System.Drawing.Size(108, 21)
		Me.cmbPartySize.Location = New System.Drawing.Point(8, 96)
		Me.cmbPartySize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbPartySize.TabIndex = 25
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
		Me.cmbMapStyle.Size = New System.Drawing.Size(108, 21)
		Me.cmbMapStyle.Location = New System.Drawing.Point(8, 56)
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
		Me.txtCoverage.AutoSize = False
		Me.txtCoverage.Size = New System.Drawing.Size(25, 19)
		Me.txtCoverage.Location = New System.Drawing.Point(80, 20)
		Me.txtCoverage.TabIndex = 20
		Me.txtCoverage.Text = "999"
		Me.txtCoverage.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCoverage.AcceptsReturn = True
		Me.txtCoverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCoverage.BackColor = System.Drawing.SystemColors.Window
		Me.txtCoverage.CausesValidation = True
		Me.txtCoverage.Enabled = True
		Me.txtCoverage.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCoverage.HideSelection = True
		Me.txtCoverage.ReadOnly = False
		Me.txtCoverage.Maxlength = 0
		Me.txtCoverage.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCoverage.MultiLine = False
		Me.txtCoverage.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCoverage.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCoverage.TabStop = True
		Me.txtCoverage.Visible = True
		Me.txtCoverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCoverage.Name = "txtCoverage"
		Me.btnReGen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnReGen.BackColor = System.Drawing.SystemColors.Control
		Me.btnReGen.Text = "ReGen Now"
		Me.btnReGen.Size = New System.Drawing.Size(73, 21)
		Me.btnReGen.Location = New System.Drawing.Point(24, 164)
		Me.btnReGen.TabIndex = 19
		Me.btnReGen.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnReGen.CausesValidation = True
		Me.btnReGen.Enabled = True
		Me.btnReGen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnReGen.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnReGen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnReGen.TabStop = True
		Me.btnReGen.Name = "btnReGen"
		Me.Label3.Text = "Party Avg Level"
		Me.Label3.Size = New System.Drawing.Size(93, 13)
		Me.Label3.Location = New System.Drawing.Point(8, 120)
		Me.Label3.TabIndex = 28
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
		Me.Label2.Text = "Party Size"
		Me.Label2.Size = New System.Drawing.Size(93, 13)
		Me.Label2.Location = New System.Drawing.Point(8, 80)
		Me.Label2.TabIndex = 26
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
		Me.Label7.Text = "Map Style"
		Me.Label7.Size = New System.Drawing.Size(93, 13)
		Me.Label7.Location = New System.Drawing.Point(8, 40)
		Me.Label7.TabIndex = 23
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
		Me._lblName_0.Text = "Encounters"
		Me._lblName_0.Size = New System.Drawing.Size(57, 13)
		Me._lblName_0.Location = New System.Drawing.Point(16, 22)
		Me._lblName_0.TabIndex = 21
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
		Me.Frame1.Text = "Description"
		Me.Frame1.Size = New System.Drawing.Size(241, 193)
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
		Me.chkMajorTheme.Text = "Major Theme?"
		Me.chkMajorTheme.Size = New System.Drawing.Size(91, 13)
		Me.chkMajorTheme.Location = New System.Drawing.Point(145, 18)
		Me.chkMajorTheme.TabIndex = 29
		Me.chkMajorTheme.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkMajorTheme.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkMajorTheme.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkMajorTheme.BackColor = System.Drawing.SystemColors.Control
		Me.chkMajorTheme.CausesValidation = True
		Me.chkMajorTheme.Enabled = True
		Me.chkMajorTheme.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkMajorTheme.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkMajorTheme.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkMajorTheme.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkMajorTheme.TabStop = True
		Me.chkMajorTheme.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkMajorTheme.Visible = True
		Me.chkMajorTheme.Name = "chkMajorTheme"
		Me.chkStoryTheme.Text = "Is a Quest?"
		Me.chkStoryTheme.Size = New System.Drawing.Size(79, 13)
		Me.chkStoryTheme.Location = New System.Drawing.Point(64, 18)
		Me.chkStoryTheme.TabIndex = 22
		Me.chkStoryTheme.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkStoryTheme.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkStoryTheme.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkStoryTheme.BackColor = System.Drawing.SystemColors.Control
		Me.chkStoryTheme.CausesValidation = True
		Me.chkStoryTheme.Enabled = True
		Me.chkStoryTheme.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkStoryTheme.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkStoryTheme.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkStoryTheme.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkStoryTheme.TabStop = True
		Me.chkStoryTheme.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkStoryTheme.Visible = True
		Me.chkStoryTheme.Name = "chkStoryTheme"
		Me.txtName.AutoSize = False
		Me.txtName.Size = New System.Drawing.Size(225, 19)
		Me.txtName.Location = New System.Drawing.Point(8, 36)
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
		Me.txtComments.AutoSize = False
		Me.txtComments.Size = New System.Drawing.Size(225, 105)
		Me.txtComments.Location = New System.Drawing.Point(8, 76)
		Me.txtComments.MultiLine = True
		Me.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtComments.TabIndex = 12
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
		Me._lblName_2.Text = "Name"
		Me._lblName_2.Size = New System.Drawing.Size(41, 13)
		Me._lblName_2.Location = New System.Drawing.Point(8, 20)
		Me._lblName_2.TabIndex = 15
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
		Me._Label1_7.Text = "Comments"
		Me._Label1_7.Size = New System.Drawing.Size(81, 13)
		Me._Label1_7.Location = New System.Drawing.Point(8, 60)
		Me._Label1_7.TabIndex = 14
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
		Me._fraTheme_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._fraTheme_1.Size = New System.Drawing.Size(373, 193)
		Me._fraTheme_1.Location = New System.Drawing.Point(12, 28)
		Me._fraTheme_1.TabIndex = 4
		Me._fraTheme_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraTheme_1.BackColor = System.Drawing.SystemColors.Control
		Me._fraTheme_1.Enabled = True
		Me._fraTheme_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraTheme_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._fraTheme_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraTheme_1.Visible = True
		Me._fraTheme_1.Name = "_fraTheme_1"
		Me.btnLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnLibrary.Text = "Insert from library"
		Me.btnLibrary.Size = New System.Drawing.Size(73, 49)
		Me.btnLibrary.Location = New System.Drawing.Point(296, 40)
		Me.btnLibrary.TabIndex = 30
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
		Me.btnPaste.Location = New System.Drawing.Point(296, 168)
		Me.btnPaste.TabIndex = 17
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
		Me.btnCopy.Location = New System.Drawing.Point(296, 144)
		Me.btnCopy.TabIndex = 16
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
		Me.btnCut.Location = New System.Drawing.Point(296, 120)
		Me.btnCut.TabIndex = 8
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
		Me.btnInsert.Location = New System.Drawing.Point(296, 16)
		Me.btnInsert.TabIndex = 7
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
		Me.btnEdit.Location = New System.Drawing.Point(296, 91)
		Me.btnEdit.TabIndex = 6
		Me.btnEdit.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEdit.CausesValidation = True
		Me.btnEdit.Enabled = True
		Me.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnEdit.TabStop = True
		Me.btnEdit.Name = "btnEdit"
		Me.lstThings.Size = New System.Drawing.Size(289, 163)
		Me.lstThings.Location = New System.Drawing.Point(0, 24)
		Me.lstThings.TabIndex = 5
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
		Me.lblAttached.Text = "Things Attached to Theme"
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
		tabThemeProp.OcxState = CType(resources.GetObject("tabThemeProp.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tabThemeProp.Size = New System.Drawing.Size(385, 229)
		Me.tabThemeProp.Location = New System.Drawing.Point(4, 4)
		Me.tabThemeProp.TabIndex = 3
		Me.tabThemeProp.Name = "tabThemeProp"
		Me.Label1.SetIndex(_Label1_7, CType(7, Short))
		Me.fraTheme.SetIndex(_fraTheme_0, CType(0, Short))
		Me.fraTheme.SetIndex(_fraTheme_1, CType(1, Short))
		Me.lblName.SetIndex(_lblName_0, CType(0, Short))
		Me.lblName.SetIndex(_lblName_2, CType(2, Short))
		CType(Me.lblName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.fraTheme, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tabThemeProp, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(_fraTheme_0)
		Me.Controls.Add(_fraTheme_1)
		Me.Controls.Add(btnCancel)
		Me.Controls.Add(btnOk)
		Me.Controls.Add(btnApply)
		Me.Controls.Add(tabThemeProp)
		Me._fraTheme_0.Controls.Add(Frame3)
		Me._fraTheme_0.Controls.Add(Frame1)
		Me.Frame3.Controls.Add(cmbPartyAvgLevel)
		Me.Frame3.Controls.Add(cmbPartySize)
		Me.Frame3.Controls.Add(cmbMapStyle)
		Me.Frame3.Controls.Add(txtCoverage)
		Me.Frame3.Controls.Add(btnReGen)
		Me.Frame3.Controls.Add(Label3)
		Me.Frame3.Controls.Add(Label2)
		Me.Frame3.Controls.Add(Label7)
		Me.Frame3.Controls.Add(_lblName_0)
		Me.Frame1.Controls.Add(chkMajorTheme)
		Me.Frame1.Controls.Add(chkStoryTheme)
		Me.Frame1.Controls.Add(txtName)
		Me.Frame1.Controls.Add(txtComments)
		Me.Frame1.Controls.Add(_lblName_2)
		Me.Frame1.Controls.Add(_Label1_7)
		Me._fraTheme_1.Controls.Add(btnLibrary)
		Me._fraTheme_1.Controls.Add(btnPaste)
		Me._fraTheme_1.Controls.Add(btnCopy)
		Me._fraTheme_1.Controls.Add(btnCut)
		Me._fraTheme_1.Controls.Add(btnInsert)
		Me._fraTheme_1.Controls.Add(btnEdit)
		Me._fraTheme_1.Controls.Add(lstThings)
		Me._fraTheme_1.Controls.Add(lblAttached)
		Me._fraTheme_0.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me._fraTheme_1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class