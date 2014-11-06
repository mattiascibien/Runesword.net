<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmTriggerProp
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
	Public WithEvents btnLibrary As System.Windows.Forms.Button
	Public WithEvents lstAutoComplete As System.Windows.Forms.ListBox
	Public WithEvents btnEdit As System.Windows.Forms.Button
	Public WithEvents txtStatements As System.Windows.Forms.TextBox
	Public WithEvents lstThings As System.Windows.Forms.ListBox
	Public WithEvents _cmbVar_0 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbContext_3 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbVar_3 As System.Windows.Forms.ComboBox
	Public WithEvents btnUpdate As System.Windows.Forms.Button
	Public WithEvents _cmbOp_1 As System.Windows.Forms.ComboBox
	Public WithEvents cmbStatement As System.Windows.Forms.ComboBox
	Public WithEvents _cmbVar_2 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbContext_2 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbVar_1 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbContext_1 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbOp_0 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbContext_0 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbEach_0 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbEach_1 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbEach_2 As System.Windows.Forms.ComboBox
	Public WithEvents _txtText_0 As System.Windows.Forms.TextBox
	Public WithEvents _txtText_1 As System.Windows.Forms.TextBox
	Public WithEvents btnBrowse As System.Windows.Forms.Button
	Public WithEvents _cmbEach_3 As System.Windows.Forms.ComboBox
	Public WithEvents _txtText_2 As System.Windows.Forms.TextBox
	Public WithEvents chkOption As System.Windows.Forms.CheckBox
	Public WithEvents btnTest As System.Windows.Forms.Button
	Public WithEvents fraStatementEditor As System.Windows.Forms.GroupBox
	Public WithEvents btnPaste As System.Windows.Forms.Button
	Public WithEvents btnCopy As System.Windows.Forms.Button
	Public WithEvents btnCut As System.Windows.Forms.Button
	Public WithEvents btnNew As System.Windows.Forms.Button
	Public WithEvents _chkStyle_15 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStyle_14 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStyle_13 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStyle_12 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStyle_11 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStyle_10 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStyle_9 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStyle_8 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStyle_6 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStyle_5 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStyle_4 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStyle_3 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStyle_2 As System.Windows.Forms.CheckBox
	Public WithEvents fraStyle As System.Windows.Forms.GroupBox
	Public WithEvents _chkStyle_1 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStyle_0 As System.Windows.Forms.CheckBox
	Public WithEvents txtName As System.Windows.Forms.TextBox
	Public WithEvents cmbTriggerType As System.Windows.Forms.ComboBox
	Public WithEvents txtComments As System.Windows.Forms.TextBox
	Public WithEvents cmbLasting As System.Windows.Forms.ComboBox
	Public WithEvents txtSkillPoints As System.Windows.Forms.TextBox
	Public WithEvents txtTurns As System.Windows.Forms.TextBox
	Public WithEvents _Label1_7 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents lblTurns As System.Windows.Forms.Label
	Public WithEvents lblSkillPoints As System.Windows.Forms.Label
	Public WithEvents lblDuration As System.Windows.Forms.Label
	Public WithEvents fraDescription As System.Windows.Forms.GroupBox
	Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents btnOk As System.Windows.Forms.Button
	Public WithEvents btnApply As System.Windows.Forms.Button
	Public WithEvents tabTrigger As AxComctlLib.AxTabStrip
	Public dlgFileOpen As System.Windows.Forms.OpenFileDialog
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents chkStyle As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	Public WithEvents cmbContext As Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray
	Public WithEvents cmbEach As Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray
	Public WithEvents cmbOp As Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray
	Public WithEvents cmbVar As Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray
	Public WithEvents txtText As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTriggerProp))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.btnLibrary = New System.Windows.Forms.Button
		Me.lstAutoComplete = New System.Windows.Forms.ListBox
		Me.btnEdit = New System.Windows.Forms.Button
		Me.txtStatements = New System.Windows.Forms.TextBox
		Me.lstThings = New System.Windows.Forms.ListBox
		Me.fraStatementEditor = New System.Windows.Forms.GroupBox
		Me._cmbVar_0 = New System.Windows.Forms.ComboBox
		Me._cmbContext_3 = New System.Windows.Forms.ComboBox
		Me._cmbVar_3 = New System.Windows.Forms.ComboBox
		Me.btnUpdate = New System.Windows.Forms.Button
		Me._cmbOp_1 = New System.Windows.Forms.ComboBox
		Me.cmbStatement = New System.Windows.Forms.ComboBox
		Me._cmbVar_2 = New System.Windows.Forms.ComboBox
		Me._cmbContext_2 = New System.Windows.Forms.ComboBox
		Me._cmbVar_1 = New System.Windows.Forms.ComboBox
		Me._cmbContext_1 = New System.Windows.Forms.ComboBox
		Me._cmbOp_0 = New System.Windows.Forms.ComboBox
		Me._cmbContext_0 = New System.Windows.Forms.ComboBox
		Me._cmbEach_0 = New System.Windows.Forms.ComboBox
		Me._cmbEach_1 = New System.Windows.Forms.ComboBox
		Me._cmbEach_2 = New System.Windows.Forms.ComboBox
		Me._txtText_0 = New System.Windows.Forms.TextBox
		Me._txtText_1 = New System.Windows.Forms.TextBox
		Me.btnBrowse = New System.Windows.Forms.Button
		Me._cmbEach_3 = New System.Windows.Forms.ComboBox
		Me._txtText_2 = New System.Windows.Forms.TextBox
		Me.chkOption = New System.Windows.Forms.CheckBox
		Me.btnTest = New System.Windows.Forms.Button
		Me.btnPaste = New System.Windows.Forms.Button
		Me.btnCopy = New System.Windows.Forms.Button
		Me.btnCut = New System.Windows.Forms.Button
		Me.btnNew = New System.Windows.Forms.Button
		Me.fraDescription = New System.Windows.Forms.GroupBox
		Me._chkStyle_15 = New System.Windows.Forms.CheckBox
		Me.fraStyle = New System.Windows.Forms.GroupBox
		Me._chkStyle_14 = New System.Windows.Forms.CheckBox
		Me._chkStyle_13 = New System.Windows.Forms.CheckBox
		Me._chkStyle_12 = New System.Windows.Forms.CheckBox
		Me._chkStyle_11 = New System.Windows.Forms.CheckBox
		Me._chkStyle_10 = New System.Windows.Forms.CheckBox
		Me._chkStyle_9 = New System.Windows.Forms.CheckBox
		Me._chkStyle_8 = New System.Windows.Forms.CheckBox
		Me._chkStyle_6 = New System.Windows.Forms.CheckBox
		Me._chkStyle_5 = New System.Windows.Forms.CheckBox
		Me._chkStyle_4 = New System.Windows.Forms.CheckBox
		Me._chkStyle_3 = New System.Windows.Forms.CheckBox
		Me._chkStyle_2 = New System.Windows.Forms.CheckBox
		Me._chkStyle_1 = New System.Windows.Forms.CheckBox
		Me._chkStyle_0 = New System.Windows.Forms.CheckBox
		Me.txtName = New System.Windows.Forms.TextBox
		Me.cmbTriggerType = New System.Windows.Forms.ComboBox
		Me.txtComments = New System.Windows.Forms.TextBox
		Me.cmbLasting = New System.Windows.Forms.ComboBox
		Me.txtSkillPoints = New System.Windows.Forms.TextBox
		Me.txtTurns = New System.Windows.Forms.TextBox
		Me._Label1_7 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me._Label1_0 = New System.Windows.Forms.Label
		Me.lblTurns = New System.Windows.Forms.Label
		Me.lblSkillPoints = New System.Windows.Forms.Label
		Me.lblDuration = New System.Windows.Forms.Label
		Me.btnCancel = New System.Windows.Forms.Button
		Me.btnOk = New System.Windows.Forms.Button
		Me.btnApply = New System.Windows.Forms.Button
		Me.tabTrigger = New AxComctlLib.AxTabStrip
		Me.dlgFileOpen = New System.Windows.Forms.OpenFileDialog
		Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.chkStyle = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(components)
		Me.cmbContext = New Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray(components)
		Me.cmbEach = New Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray(components)
		Me.cmbOp = New Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray(components)
		Me.cmbVar = New Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray(components)
		Me.txtText = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.fraStatementEditor.SuspendLayout()
		Me.fraDescription.SuspendLayout()
		Me.fraStyle.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tabTrigger, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.chkStyle, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmbContext, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmbEach, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmbOp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmbVar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtText, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Trigger Properties"
		Me.ClientSize = New System.Drawing.Size(735, 411)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmTriggerProp"
		Me.btnLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnLibrary.Text = "Insert from library"
		Me.btnLibrary.Size = New System.Drawing.Size(73, 49)
		Me.btnLibrary.Location = New System.Drawing.Point(652, 64)
		Me.btnLibrary.TabIndex = 63
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
		Me.lstAutoComplete.Size = New System.Drawing.Size(137, 124)
		Me.lstAutoComplete.Location = New System.Drawing.Point(488, 224)
		Me.lstAutoComplete.Sorted = True
		Me.lstAutoComplete.TabIndex = 62
		Me.lstAutoComplete.Visible = False
		Me.lstAutoComplete.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstAutoComplete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstAutoComplete.BackColor = System.Drawing.SystemColors.Window
		Me.lstAutoComplete.CausesValidation = True
		Me.lstAutoComplete.Enabled = True
		Me.lstAutoComplete.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstAutoComplete.IntegralHeight = True
		Me.lstAutoComplete.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstAutoComplete.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstAutoComplete.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstAutoComplete.TabStop = True
		Me.lstAutoComplete.MultiColumn = False
		Me.lstAutoComplete.Name = "lstAutoComplete"
		Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnEdit.BackColor = System.Drawing.SystemColors.Control
		Me.btnEdit.Text = "Edit..."
		Me.btnEdit.Size = New System.Drawing.Size(73, 21)
		Me.btnEdit.Location = New System.Drawing.Point(652, 118)
		Me.btnEdit.TabIndex = 48
		Me.btnEdit.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEdit.CausesValidation = True
		Me.btnEdit.Enabled = True
		Me.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnEdit.TabStop = True
		Me.btnEdit.Name = "btnEdit"
		Me.txtStatements.AutoSize = False
		Me.txtStatements.Font = New System.Drawing.Font("Courier New", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStatements.Size = New System.Drawing.Size(305, 329)
		Me.txtStatements.Location = New System.Drawing.Point(340, 40)
		Me.txtStatements.MultiLine = True
		Me.txtStatements.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.txtStatements.WordWrap = False
		Me.txtStatements.TabIndex = 32
		Me.txtStatements.Text = "Text1" & Chr(13) & Chr(10) & "Text2" & Chr(13) & Chr(10) & "Text3" & Chr(13) & Chr(10) & "Text4" & Chr(13) & Chr(10) & "Text5" & Chr(13) & Chr(10) & "Text6" & Chr(13) & Chr(10) & "Text7" & Chr(13) & Chr(10) & "Text8" & Chr(13) & Chr(10) & "Text9" & Chr(13) & Chr(10) & "Text10" & Chr(13) & Chr(10) & "Text11" & Chr(13) & Chr(10) & "Text12" & Chr(13) & Chr(10) & "Text13" & Chr(13) & Chr(10) & "Text14" & Chr(13) & Chr(10) & "Text15" & Chr(13) & Chr(10) & "Text16" & Chr(13) & Chr(10) & "Text17" & Chr(13) & Chr(10) & "Text18" & Chr(13) & Chr(10) & "Text19" & Chr(13) & Chr(10) & "Text20" & Chr(13) & Chr(10) & "Text21" & Chr(13) & Chr(10) & "Text22" & Chr(13) & Chr(10)
		Me.txtStatements.AcceptsReturn = True
		Me.txtStatements.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStatements.BackColor = System.Drawing.SystemColors.Window
		Me.txtStatements.CausesValidation = True
		Me.txtStatements.Enabled = True
		Me.txtStatements.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStatements.HideSelection = True
		Me.txtStatements.ReadOnly = False
		Me.txtStatements.Maxlength = 0
		Me.txtStatements.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStatements.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStatements.TabStop = True
		Me.txtStatements.Visible = True
		Me.txtStatements.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStatements.Name = "txtStatements"
		Me.lstThings.Size = New System.Drawing.Size(305, 332)
		Me.lstThings.Location = New System.Drawing.Point(340, 40)
		Me.lstThings.TabIndex = 47
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
		Me.fraStatementEditor.Text = "Statement Editor"
		Me.fraStatementEditor.Size = New System.Drawing.Size(321, 161)
		Me.fraStatementEditor.Location = New System.Drawing.Point(4, 220)
		Me.fraStatementEditor.TabIndex = 37
		Me.fraStatementEditor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraStatementEditor.BackColor = System.Drawing.SystemColors.Control
		Me.fraStatementEditor.Enabled = True
		Me.fraStatementEditor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraStatementEditor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraStatementEditor.Visible = True
		Me.fraStatementEditor.Padding = New System.Windows.Forms.Padding(0)
		Me.fraStatementEditor.Name = "fraStatementEditor"
		Me._cmbVar_0.Size = New System.Drawing.Size(149, 21)
		Me._cmbVar_0.Location = New System.Drawing.Point(164, 48)
		Me._cmbVar_0.Sorted = True
		Me._cmbVar_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbVar_0.TabIndex = 38
		Me._cmbVar_0.Visible = False
		Me._cmbVar_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbVar_0.BackColor = System.Drawing.SystemColors.Window
		Me._cmbVar_0.CausesValidation = True
		Me._cmbVar_0.Enabled = True
		Me._cmbVar_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbVar_0.IntegralHeight = True
		Me._cmbVar_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbVar_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbVar_0.TabStop = True
		Me._cmbVar_0.Name = "_cmbVar_0"
		Me._cmbContext_3.Size = New System.Drawing.Size(101, 21)
		Me._cmbContext_3.Location = New System.Drawing.Point(60, 132)
		Me._cmbContext_3.Sorted = True
		Me._cmbContext_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbContext_3.TabIndex = 57
		Me._cmbContext_3.Visible = False
		Me._cmbContext_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbContext_3.BackColor = System.Drawing.SystemColors.Window
		Me._cmbContext_3.CausesValidation = True
		Me._cmbContext_3.Enabled = True
		Me._cmbContext_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbContext_3.IntegralHeight = True
		Me._cmbContext_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbContext_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbContext_3.TabStop = True
		Me._cmbContext_3.Name = "_cmbContext_3"
		Me._cmbVar_3.Size = New System.Drawing.Size(149, 21)
		Me._cmbVar_3.Location = New System.Drawing.Point(164, 132)
		Me._cmbVar_3.Sorted = True
		Me._cmbVar_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbVar_3.TabIndex = 56
		Me._cmbVar_3.Visible = False
		Me._cmbVar_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbVar_3.BackColor = System.Drawing.SystemColors.Window
		Me._cmbVar_3.CausesValidation = True
		Me._cmbVar_3.Enabled = True
		Me._cmbVar_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbVar_3.IntegralHeight = True
		Me._cmbVar_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbVar_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbVar_3.TabStop = True
		Me._cmbVar_3.Name = "_cmbVar_3"
		Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnUpdate.BackColor = System.Drawing.SystemColors.Control
		Me.btnUpdate.Text = "Update >>"
		Me.btnUpdate.Size = New System.Drawing.Size(73, 21)
		Me.btnUpdate.Location = New System.Drawing.Point(240, 20)
		Me.btnUpdate.TabIndex = 55
		Me.btnUpdate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnUpdate.CausesValidation = True
		Me.btnUpdate.Enabled = True
		Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnUpdate.TabStop = True
		Me.btnUpdate.Name = "btnUpdate"
		Me._cmbOp_1.Size = New System.Drawing.Size(45, 21)
		Me._cmbOp_1.Location = New System.Drawing.Point(12, 104)
		Me._cmbOp_1.Items.AddRange(New Object(){"Like"})
		Me._cmbOp_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbOp_1.TabIndex = 46
		Me._cmbOp_1.Visible = False
		Me._cmbOp_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbOp_1.BackColor = System.Drawing.SystemColors.Window
		Me._cmbOp_1.CausesValidation = True
		Me._cmbOp_1.Enabled = True
		Me._cmbOp_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbOp_1.IntegralHeight = True
		Me._cmbOp_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbOp_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbOp_1.Sorted = False
		Me._cmbOp_1.TabStop = True
		Me._cmbOp_1.Name = "_cmbOp_1"
		Me.cmbStatement.Size = New System.Drawing.Size(149, 21)
		Me.cmbStatement.Location = New System.Drawing.Point(12, 20)
		Me.cmbStatement.Sorted = True
		Me.cmbStatement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbStatement.TabIndex = 45
		Me.cmbStatement.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbStatement.BackColor = System.Drawing.SystemColors.Window
		Me.cmbStatement.CausesValidation = True
		Me.cmbStatement.Enabled = True
		Me.cmbStatement.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbStatement.IntegralHeight = True
		Me.cmbStatement.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbStatement.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbStatement.TabStop = True
		Me.cmbStatement.Visible = True
		Me.cmbStatement.Name = "cmbStatement"
		Me._cmbVar_2.Size = New System.Drawing.Size(149, 21)
		Me._cmbVar_2.Location = New System.Drawing.Point(164, 104)
		Me._cmbVar_2.Sorted = True
		Me._cmbVar_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbVar_2.TabIndex = 44
		Me._cmbVar_2.Visible = False
		Me._cmbVar_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbVar_2.BackColor = System.Drawing.SystemColors.Window
		Me._cmbVar_2.CausesValidation = True
		Me._cmbVar_2.Enabled = True
		Me._cmbVar_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbVar_2.IntegralHeight = True
		Me._cmbVar_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbVar_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbVar_2.TabStop = True
		Me._cmbVar_2.Name = "_cmbVar_2"
		Me._cmbContext_2.Size = New System.Drawing.Size(101, 21)
		Me._cmbContext_2.Location = New System.Drawing.Point(60, 104)
		Me._cmbContext_2.Sorted = True
		Me._cmbContext_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbContext_2.TabIndex = 43
		Me._cmbContext_2.Visible = False
		Me._cmbContext_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbContext_2.BackColor = System.Drawing.SystemColors.Window
		Me._cmbContext_2.CausesValidation = True
		Me._cmbContext_2.Enabled = True
		Me._cmbContext_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbContext_2.IntegralHeight = True
		Me._cmbContext_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbContext_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbContext_2.TabStop = True
		Me._cmbContext_2.Name = "_cmbContext_2"
		Me._cmbVar_1.Size = New System.Drawing.Size(149, 21)
		Me._cmbVar_1.Location = New System.Drawing.Point(164, 76)
		Me._cmbVar_1.Sorted = True
		Me._cmbVar_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbVar_1.TabIndex = 42
		Me._cmbVar_1.Visible = False
		Me._cmbVar_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbVar_1.BackColor = System.Drawing.SystemColors.Window
		Me._cmbVar_1.CausesValidation = True
		Me._cmbVar_1.Enabled = True
		Me._cmbVar_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbVar_1.IntegralHeight = True
		Me._cmbVar_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbVar_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbVar_1.TabStop = True
		Me._cmbVar_1.Name = "_cmbVar_1"
		Me._cmbContext_1.Size = New System.Drawing.Size(101, 21)
		Me._cmbContext_1.Location = New System.Drawing.Point(60, 76)
		Me._cmbContext_1.Sorted = True
		Me._cmbContext_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbContext_1.TabIndex = 41
		Me._cmbContext_1.Visible = False
		Me._cmbContext_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbContext_1.BackColor = System.Drawing.SystemColors.Window
		Me._cmbContext_1.CausesValidation = True
		Me._cmbContext_1.Enabled = True
		Me._cmbContext_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbContext_1.IntegralHeight = True
		Me._cmbContext_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbContext_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbContext_1.TabStop = True
		Me._cmbContext_1.Name = "_cmbContext_1"
		Me._cmbOp_0.Size = New System.Drawing.Size(45, 21)
		Me._cmbOp_0.Location = New System.Drawing.Point(12, 76)
		Me._cmbOp_0.Items.AddRange(New Object(){"Like"})
		Me._cmbOp_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbOp_0.TabIndex = 40
		Me._cmbOp_0.Visible = False
		Me._cmbOp_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbOp_0.BackColor = System.Drawing.SystemColors.Window
		Me._cmbOp_0.CausesValidation = True
		Me._cmbOp_0.Enabled = True
		Me._cmbOp_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbOp_0.IntegralHeight = True
		Me._cmbOp_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbOp_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbOp_0.Sorted = False
		Me._cmbOp_0.TabStop = True
		Me._cmbOp_0.Name = "_cmbOp_0"
		Me._cmbContext_0.Size = New System.Drawing.Size(101, 21)
		Me._cmbContext_0.Location = New System.Drawing.Point(60, 48)
		Me._cmbContext_0.Sorted = True
		Me._cmbContext_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbContext_0.TabIndex = 39
		Me._cmbContext_0.Visible = False
		Me._cmbContext_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbContext_0.BackColor = System.Drawing.SystemColors.Window
		Me._cmbContext_0.CausesValidation = True
		Me._cmbContext_0.Enabled = True
		Me._cmbContext_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbContext_0.IntegralHeight = True
		Me._cmbContext_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbContext_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbContext_0.TabStop = True
		Me._cmbContext_0.Name = "_cmbContext_0"
		Me._cmbEach_0.Size = New System.Drawing.Size(149, 21)
		Me._cmbEach_0.Location = New System.Drawing.Point(12, 48)
		Me._cmbEach_0.Sorted = True
		Me._cmbEach_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbEach_0.TabIndex = 49
		Me._cmbEach_0.Visible = False
		Me._cmbEach_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbEach_0.BackColor = System.Drawing.SystemColors.Window
		Me._cmbEach_0.CausesValidation = True
		Me._cmbEach_0.Enabled = True
		Me._cmbEach_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbEach_0.IntegralHeight = True
		Me._cmbEach_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbEach_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbEach_0.TabStop = True
		Me._cmbEach_0.Name = "_cmbEach_0"
		Me._cmbEach_1.Size = New System.Drawing.Size(149, 21)
		Me._cmbEach_1.Location = New System.Drawing.Point(12, 76)
		Me._cmbEach_1.Sorted = True
		Me._cmbEach_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbEach_1.TabIndex = 50
		Me._cmbEach_1.Visible = False
		Me._cmbEach_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbEach_1.BackColor = System.Drawing.SystemColors.Window
		Me._cmbEach_1.CausesValidation = True
		Me._cmbEach_1.Enabled = True
		Me._cmbEach_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbEach_1.IntegralHeight = True
		Me._cmbEach_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbEach_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbEach_1.TabStop = True
		Me._cmbEach_1.Name = "_cmbEach_1"
		Me._cmbEach_2.Size = New System.Drawing.Size(149, 21)
		Me._cmbEach_2.Location = New System.Drawing.Point(12, 104)
		Me._cmbEach_2.Sorted = True
		Me._cmbEach_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbEach_2.TabIndex = 51
		Me._cmbEach_2.Visible = False
		Me._cmbEach_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbEach_2.BackColor = System.Drawing.SystemColors.Window
		Me._cmbEach_2.CausesValidation = True
		Me._cmbEach_2.Enabled = True
		Me._cmbEach_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbEach_2.IntegralHeight = True
		Me._cmbEach_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbEach_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbEach_2.TabStop = True
		Me._cmbEach_2.Name = "_cmbEach_2"
		Me._txtText_0.AutoSize = False
		Me._txtText_0.Size = New System.Drawing.Size(149, 21)
		Me._txtText_0.Location = New System.Drawing.Point(12, 48)
		Me._txtText_0.TabIndex = 52
		Me._txtText_0.Text = "Text1"
		Me._txtText_0.Visible = False
		Me._txtText_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtText_0.AcceptsReturn = True
		Me._txtText_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtText_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtText_0.CausesValidation = True
		Me._txtText_0.Enabled = True
		Me._txtText_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtText_0.HideSelection = True
		Me._txtText_0.ReadOnly = False
		Me._txtText_0.Maxlength = 0
		Me._txtText_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtText_0.MultiLine = False
		Me._txtText_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtText_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtText_0.TabStop = True
		Me._txtText_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtText_0.Name = "_txtText_0"
		Me._txtText_1.AutoSize = False
		Me._txtText_1.Size = New System.Drawing.Size(301, 49)
		Me._txtText_1.Location = New System.Drawing.Point(12, 76)
		Me._txtText_1.MultiLine = True
		Me._txtText_1.TabIndex = 53
		Me._txtText_1.Text = "Text1"
		Me._txtText_1.Visible = False
		Me._txtText_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtText_1.AcceptsReturn = True
		Me._txtText_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtText_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtText_1.CausesValidation = True
		Me._txtText_1.Enabled = True
		Me._txtText_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtText_1.HideSelection = True
		Me._txtText_1.ReadOnly = False
		Me._txtText_1.Maxlength = 0
		Me._txtText_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtText_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtText_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtText_1.TabStop = True
		Me._txtText_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtText_1.Name = "_txtText_1"
		Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnBrowse.BackColor = System.Drawing.SystemColors.Control
		Me.btnBrowse.Text = "Browse..."
		Me.btnBrowse.Size = New System.Drawing.Size(73, 21)
		Me.btnBrowse.Location = New System.Drawing.Point(164, 48)
		Me.btnBrowse.TabIndex = 54
		Me.btnBrowse.Visible = False
		Me.btnBrowse.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBrowse.CausesValidation = True
		Me.btnBrowse.Enabled = True
		Me.btnBrowse.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnBrowse.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnBrowse.TabStop = True
		Me.btnBrowse.Name = "btnBrowse"
		Me._cmbEach_3.Size = New System.Drawing.Size(149, 21)
		Me._cmbEach_3.Location = New System.Drawing.Point(12, 132)
		Me._cmbEach_3.Sorted = True
		Me._cmbEach_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbEach_3.TabIndex = 58
		Me._cmbEach_3.Visible = False
		Me._cmbEach_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbEach_3.BackColor = System.Drawing.SystemColors.Window
		Me._cmbEach_3.CausesValidation = True
		Me._cmbEach_3.Enabled = True
		Me._cmbEach_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbEach_3.IntegralHeight = True
		Me._cmbEach_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbEach_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbEach_3.TabStop = True
		Me._cmbEach_3.Name = "_cmbEach_3"
		Me._txtText_2.AutoSize = False
		Me._txtText_2.Size = New System.Drawing.Size(253, 21)
		Me._txtText_2.Location = New System.Drawing.Point(60, 76)
		Me._txtText_2.TabIndex = 59
		Me._txtText_2.Text = "Text1"
		Me._txtText_2.Visible = False
		Me._txtText_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtText_2.AcceptsReturn = True
		Me._txtText_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtText_2.BackColor = System.Drawing.SystemColors.Window
		Me._txtText_2.CausesValidation = True
		Me._txtText_2.Enabled = True
		Me._txtText_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtText_2.HideSelection = True
		Me._txtText_2.ReadOnly = False
		Me._txtText_2.Maxlength = 0
		Me._txtText_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtText_2.MultiLine = False
		Me._txtText_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtText_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtText_2.TabStop = True
		Me._txtText_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtText_2.Name = "_txtText_2"
		Me.chkOption.Text = "Option"
		Me.chkOption.Size = New System.Drawing.Size(149, 21)
		Me.chkOption.Location = New System.Drawing.Point(164, 132)
		Me.chkOption.TabIndex = 60
		Me.chkOption.Visible = False
		Me.chkOption.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkOption.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkOption.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkOption.BackColor = System.Drawing.SystemColors.Control
		Me.chkOption.CausesValidation = True
		Me.chkOption.Enabled = True
		Me.chkOption.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkOption.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkOption.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkOption.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkOption.TabStop = True
		Me.chkOption.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkOption.Name = "chkOption"
		Me.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnTest.BackColor = System.Drawing.SystemColors.Control
		Me.btnTest.Text = "Test"
		Me.btnTest.Size = New System.Drawing.Size(73, 21)
		Me.btnTest.Location = New System.Drawing.Point(240, 48)
		Me.btnTest.TabIndex = 61
		Me.btnTest.Visible = False
		Me.btnTest.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTest.CausesValidation = True
		Me.btnTest.Enabled = True
		Me.btnTest.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTest.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTest.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTest.TabStop = True
		Me.btnTest.Name = "btnTest"
		Me.btnPaste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnPaste.BackColor = System.Drawing.SystemColors.Control
		Me.btnPaste.Text = "Paste"
		Me.btnPaste.Size = New System.Drawing.Size(73, 21)
		Me.btnPaste.Location = New System.Drawing.Point(652, 200)
		Me.btnPaste.TabIndex = 36
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
		Me.btnCopy.Location = New System.Drawing.Point(652, 176)
		Me.btnCopy.TabIndex = 35
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
		Me.btnCut.Location = New System.Drawing.Point(652, 152)
		Me.btnCut.TabIndex = 34
		Me.btnCut.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCut.CausesValidation = True
		Me.btnCut.Enabled = True
		Me.btnCut.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCut.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCut.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCut.TabStop = True
		Me.btnCut.Name = "btnCut"
		Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnNew.BackColor = System.Drawing.SystemColors.Control
		Me.btnNew.Text = "New..."
		Me.btnNew.Size = New System.Drawing.Size(73, 21)
		Me.btnNew.Location = New System.Drawing.Point(652, 40)
		Me.btnNew.TabIndex = 33
		Me.btnNew.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnNew.CausesValidation = True
		Me.btnNew.Enabled = True
		Me.btnNew.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnNew.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnNew.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnNew.TabStop = True
		Me.btnNew.Name = "btnNew"
		Me.fraDescription.Text = "Description"
		Me.fraDescription.Size = New System.Drawing.Size(321, 213)
		Me.fraDescription.Location = New System.Drawing.Point(4, 4)
		Me.fraDescription.TabIndex = 4
		Me.fraDescription.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraDescription.BackColor = System.Drawing.SystemColors.Control
		Me.fraDescription.Enabled = True
		Me.fraDescription.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraDescription.Visible = True
		Me.fraDescription.Padding = New System.Windows.Forms.Padding(0)
		Me.fraDescription.Name = "fraDescription"
		Me._chkStyle_15.Text = "Dead too?"
		Me._chkStyle_15.Size = New System.Drawing.Size(77, 13)
		Me._chkStyle_15.Location = New System.Drawing.Point(88, 99)
		Me._chkStyle_15.TabIndex = 64
		Me._chkStyle_15.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStyle_15.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStyle_15.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStyle_15.BackColor = System.Drawing.SystemColors.Control
		Me._chkStyle_15.CausesValidation = True
		Me._chkStyle_15.Enabled = True
		Me._chkStyle_15.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStyle_15.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStyle_15.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStyle_15.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStyle_15.TabStop = True
		Me._chkStyle_15.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStyle_15.Visible = True
		Me._chkStyle_15.Name = "_chkStyle_15"
		Me.fraStyle.Text = "Class"
		Me.fraStyle.Size = New System.Drawing.Size(141, 144)
		Me.fraStyle.Location = New System.Drawing.Point(172, 60)
		Me.fraStyle.TabIndex = 19
		Me.fraStyle.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraStyle.BackColor = System.Drawing.SystemColors.Control
		Me.fraStyle.Enabled = True
		Me.fraStyle.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraStyle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraStyle.Visible = True
		Me.fraStyle.Padding = New System.Windows.Forms.Padding(0)
		Me.fraStyle.Name = "fraStyle"
		Me._chkStyle_14.Text = "Dreamer"
		Me._chkStyle_14.Size = New System.Drawing.Size(60, 13)
		Me._chkStyle_14.Location = New System.Drawing.Point(71, 121)
		Me._chkStyle_14.TabIndex = 31
		Me._chkStyle_14.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStyle_14.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStyle_14.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStyle_14.BackColor = System.Drawing.SystemColors.Control
		Me._chkStyle_14.CausesValidation = True
		Me._chkStyle_14.Enabled = True
		Me._chkStyle_14.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStyle_14.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStyle_14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStyle_14.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStyle_14.TabStop = True
		Me._chkStyle_14.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStyle_14.Visible = True
		Me._chkStyle_14.Name = "_chkStyle_14"
		Me._chkStyle_13.Text = "Lust"
		Me._chkStyle_13.Size = New System.Drawing.Size(57, 13)
		Me._chkStyle_13.Location = New System.Drawing.Point(71, 101)
		Me._chkStyle_13.TabIndex = 30
		Me._chkStyle_13.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStyle_13.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStyle_13.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStyle_13.BackColor = System.Drawing.SystemColors.Control
		Me._chkStyle_13.CausesValidation = True
		Me._chkStyle_13.Enabled = True
		Me._chkStyle_13.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStyle_13.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStyle_13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStyle_13.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStyle_13.TabStop = True
		Me._chkStyle_13.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStyle_13.Visible = True
		Me._chkStyle_13.Name = "_chkStyle_13"
		Me._chkStyle_12.Text = "Greed"
		Me._chkStyle_12.Size = New System.Drawing.Size(57, 13)
		Me._chkStyle_12.Location = New System.Drawing.Point(71, 81)
		Me._chkStyle_12.TabIndex = 29
		Me._chkStyle_12.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStyle_12.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStyle_12.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStyle_12.BackColor = System.Drawing.SystemColors.Control
		Me._chkStyle_12.CausesValidation = True
		Me._chkStyle_12.Enabled = True
		Me._chkStyle_12.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStyle_12.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStyle_12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStyle_12.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStyle_12.TabStop = True
		Me._chkStyle_12.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStyle_12.Visible = True
		Me._chkStyle_12.Name = "_chkStyle_12"
		Me._chkStyle_11.Text = "Pride"
		Me._chkStyle_11.Size = New System.Drawing.Size(49, 13)
		Me._chkStyle_11.Location = New System.Drawing.Point(72, 20)
		Me._chkStyle_11.TabIndex = 28
		Me._chkStyle_11.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStyle_11.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStyle_11.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStyle_11.BackColor = System.Drawing.SystemColors.Control
		Me._chkStyle_11.CausesValidation = True
		Me._chkStyle_11.Enabled = True
		Me._chkStyle_11.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStyle_11.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStyle_11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStyle_11.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStyle_11.TabStop = True
		Me._chkStyle_11.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStyle_11.Visible = True
		Me._chkStyle_11.Name = "_chkStyle_11"
		Me._chkStyle_10.Text = "Wrath"
		Me._chkStyle_10.Size = New System.Drawing.Size(57, 13)
		Me._chkStyle_10.Location = New System.Drawing.Point(72, 60)
		Me._chkStyle_10.TabIndex = 27
		Me._chkStyle_10.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStyle_10.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStyle_10.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStyle_10.BackColor = System.Drawing.SystemColors.Control
		Me._chkStyle_10.CausesValidation = True
		Me._chkStyle_10.Enabled = True
		Me._chkStyle_10.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStyle_10.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStyle_10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStyle_10.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStyle_10.TabStop = True
		Me._chkStyle_10.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStyle_10.Visible = True
		Me._chkStyle_10.Name = "_chkStyle_10"
		Me._chkStyle_9.Text = "Revelry"
		Me._chkStyle_9.Size = New System.Drawing.Size(57, 13)
		Me._chkStyle_9.Location = New System.Drawing.Point(72, 40)
		Me._chkStyle_9.TabIndex = 26
		Me._chkStyle_9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStyle_9.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStyle_9.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStyle_9.BackColor = System.Drawing.SystemColors.Control
		Me._chkStyle_9.CausesValidation = True
		Me._chkStyle_9.Enabled = True
		Me._chkStyle_9.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStyle_9.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStyle_9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStyle_9.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStyle_9.TabStop = True
		Me._chkStyle_9.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStyle_9.Visible = True
		Me._chkStyle_9.Name = "_chkStyle_9"
		Me._chkStyle_8.Text = "Lunacy"
		Me._chkStyle_8.Size = New System.Drawing.Size(57, 13)
		Me._chkStyle_8.Location = New System.Drawing.Point(8, 120)
		Me._chkStyle_8.TabIndex = 25
		Me._chkStyle_8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStyle_8.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStyle_8.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStyle_8.BackColor = System.Drawing.SystemColors.Control
		Me._chkStyle_8.CausesValidation = True
		Me._chkStyle_8.Enabled = True
		Me._chkStyle_8.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStyle_8.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStyle_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStyle_8.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStyle_8.TabStop = True
		Me._chkStyle_8.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStyle_8.Visible = True
		Me._chkStyle_8.Name = "_chkStyle_8"
		Me._chkStyle_6.Text = "Magic"
		Me._chkStyle_6.Size = New System.Drawing.Size(57, 13)
		Me._chkStyle_6.Location = New System.Drawing.Point(8, 100)
		Me._chkStyle_6.TabIndex = 24
		Me._chkStyle_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStyle_6.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStyle_6.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStyle_6.BackColor = System.Drawing.SystemColors.Control
		Me._chkStyle_6.CausesValidation = True
		Me._chkStyle_6.Enabled = True
		Me._chkStyle_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStyle_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStyle_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStyle_6.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStyle_6.TabStop = True
		Me._chkStyle_6.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStyle_6.Visible = True
		Me._chkStyle_6.Name = "_chkStyle_6"
		Me._chkStyle_5.Text = "Fear"
		Me._chkStyle_5.Size = New System.Drawing.Size(57, 13)
		Me._chkStyle_5.Location = New System.Drawing.Point(8, 80)
		Me._chkStyle_5.TabIndex = 23
		Me._chkStyle_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStyle_5.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStyle_5.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStyle_5.BackColor = System.Drawing.SystemColors.Control
		Me._chkStyle_5.CausesValidation = True
		Me._chkStyle_5.Enabled = True
		Me._chkStyle_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStyle_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStyle_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStyle_5.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStyle_5.TabStop = True
		Me._chkStyle_5.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStyle_5.Visible = True
		Me._chkStyle_5.Name = "_chkStyle_5"
		Me._chkStyle_4.Text = "Evil"
		Me._chkStyle_4.Size = New System.Drawing.Size(57, 13)
		Me._chkStyle_4.Location = New System.Drawing.Point(7, 60)
		Me._chkStyle_4.TabIndex = 22
		Me._chkStyle_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStyle_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStyle_4.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStyle_4.BackColor = System.Drawing.SystemColors.Control
		Me._chkStyle_4.CausesValidation = True
		Me._chkStyle_4.Enabled = True
		Me._chkStyle_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStyle_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStyle_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStyle_4.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStyle_4.TabStop = True
		Me._chkStyle_4.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStyle_4.Visible = True
		Me._chkStyle_4.Name = "_chkStyle_4"
		Me._chkStyle_3.Text = "Poison"
		Me._chkStyle_3.Size = New System.Drawing.Size(57, 13)
		Me._chkStyle_3.Location = New System.Drawing.Point(7, 40)
		Me._chkStyle_3.TabIndex = 21
		Me._chkStyle_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStyle_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStyle_3.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStyle_3.BackColor = System.Drawing.SystemColors.Control
		Me._chkStyle_3.CausesValidation = True
		Me._chkStyle_3.Enabled = True
		Me._chkStyle_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStyle_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStyle_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStyle_3.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStyle_3.TabStop = True
		Me._chkStyle_3.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStyle_3.Visible = True
		Me._chkStyle_3.Name = "_chkStyle_3"
		Me._chkStyle_2.Text = "Curse"
		Me._chkStyle_2.Size = New System.Drawing.Size(57, 13)
		Me._chkStyle_2.Location = New System.Drawing.Point(7, 20)
		Me._chkStyle_2.TabIndex = 20
		Me._chkStyle_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStyle_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStyle_2.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStyle_2.BackColor = System.Drawing.SystemColors.Control
		Me._chkStyle_2.CausesValidation = True
		Me._chkStyle_2.Enabled = True
		Me._chkStyle_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStyle_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStyle_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStyle_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStyle_2.TabStop = True
		Me._chkStyle_2.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStyle_2.Visible = True
		Me._chkStyle_2.Name = "_chkStyle_2"
		Me._chkStyle_1.Text = "Is a Trap?"
		Me._chkStyle_1.Size = New System.Drawing.Size(69, 13)
		Me._chkStyle_1.Location = New System.Drawing.Point(88, 60)
		Me._chkStyle_1.TabIndex = 12
		Me._chkStyle_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStyle_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStyle_1.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStyle_1.BackColor = System.Drawing.SystemColors.Control
		Me._chkStyle_1.CausesValidation = True
		Me._chkStyle_1.Enabled = True
		Me._chkStyle_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStyle_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStyle_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStyle_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStyle_1.TabStop = True
		Me._chkStyle_1.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStyle_1.Visible = True
		Me._chkStyle_1.Name = "_chkStyle_1"
		Me._chkStyle_0.Text = "Is a Skill?"
		Me._chkStyle_0.Size = New System.Drawing.Size(67, 13)
		Me._chkStyle_0.Location = New System.Drawing.Point(88, 16)
		Me._chkStyle_0.TabIndex = 11
		Me._chkStyle_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStyle_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStyle_0.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStyle_0.BackColor = System.Drawing.SystemColors.Control
		Me._chkStyle_0.CausesValidation = True
		Me._chkStyle_0.Enabled = True
		Me._chkStyle_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStyle_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStyle_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStyle_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStyle_0.TabStop = True
		Me._chkStyle_0.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStyle_0.Visible = True
		Me._chkStyle_0.Name = "_chkStyle_0"
		Me.txtName.AutoSize = False
		Me.txtName.Size = New System.Drawing.Size(157, 19)
		Me.txtName.Location = New System.Drawing.Point(8, 76)
		Me.txtName.MultiLine = True
		Me.txtName.TabIndex = 10
		Me.txtName.Text = "Text2"
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
		Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtName.TabStop = True
		Me.txtName.Visible = True
		Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtName.Name = "txtName"
		Me.cmbTriggerType.Size = New System.Drawing.Size(157, 21)
		Me.cmbTriggerType.Location = New System.Drawing.Point(8, 32)
		Me.cmbTriggerType.Sorted = True
		Me.cmbTriggerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbTriggerType.TabIndex = 9
		Me.cmbTriggerType.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbTriggerType.BackColor = System.Drawing.SystemColors.Window
		Me.cmbTriggerType.CausesValidation = True
		Me.cmbTriggerType.Enabled = True
		Me.cmbTriggerType.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbTriggerType.IntegralHeight = True
		Me.cmbTriggerType.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbTriggerType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbTriggerType.TabStop = True
		Me.cmbTriggerType.Visible = True
		Me.cmbTriggerType.Name = "cmbTriggerType"
		Me.txtComments.AutoSize = False
		Me.txtComments.Size = New System.Drawing.Size(157, 85)
		Me.txtComments.Location = New System.Drawing.Point(8, 116)
		Me.txtComments.MultiLine = True
		Me.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtComments.TabIndex = 8
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
		Me.cmbLasting.Size = New System.Drawing.Size(77, 21)
		Me.cmbLasting.Location = New System.Drawing.Point(172, 32)
		Me.cmbLasting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbLasting.TabIndex = 7
		Me.cmbLasting.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbLasting.BackColor = System.Drawing.SystemColors.Window
		Me.cmbLasting.CausesValidation = True
		Me.cmbLasting.Enabled = True
		Me.cmbLasting.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbLasting.IntegralHeight = True
		Me.cmbLasting.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbLasting.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbLasting.Sorted = False
		Me.cmbLasting.TabStop = True
		Me.cmbLasting.Visible = True
		Me.cmbLasting.Name = "cmbLasting"
		Me.txtSkillPoints.AutoSize = False
		Me.txtSkillPoints.Size = New System.Drawing.Size(37, 19)
		Me.txtSkillPoints.Location = New System.Drawing.Point(212, 33)
		Me.txtSkillPoints.Maxlength = 5
		Me.txtSkillPoints.TabIndex = 6
		Me.txtSkillPoints.Text = "99999"
		Me.txtSkillPoints.Visible = False
		Me.txtSkillPoints.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSkillPoints.AcceptsReturn = True
		Me.txtSkillPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSkillPoints.BackColor = System.Drawing.SystemColors.Window
		Me.txtSkillPoints.CausesValidation = True
		Me.txtSkillPoints.Enabled = True
		Me.txtSkillPoints.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSkillPoints.HideSelection = True
		Me.txtSkillPoints.ReadOnly = False
		Me.txtSkillPoints.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSkillPoints.MultiLine = False
		Me.txtSkillPoints.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSkillPoints.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSkillPoints.TabStop = True
		Me.txtSkillPoints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSkillPoints.Name = "txtSkillPoints"
		Me.txtTurns.AutoSize = False
		Me.txtTurns.Enabled = False
		Me.txtTurns.Size = New System.Drawing.Size(25, 19)
		Me.txtTurns.Location = New System.Drawing.Point(253, 33)
		Me.txtTurns.Maxlength = 3
		Me.txtTurns.TabIndex = 5
		Me.txtTurns.Text = "255"
		Me.txtTurns.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTurns.AcceptsReturn = True
		Me.txtTurns.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTurns.BackColor = System.Drawing.SystemColors.Window
		Me.txtTurns.CausesValidation = True
		Me.txtTurns.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTurns.HideSelection = True
		Me.txtTurns.ReadOnly = False
		Me.txtTurns.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTurns.MultiLine = False
		Me.txtTurns.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTurns.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTurns.TabStop = True
		Me.txtTurns.Visible = True
		Me.txtTurns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTurns.Name = "txtTurns"
		Me._Label1_7.Text = "Name"
		Me._Label1_7.Size = New System.Drawing.Size(81, 13)
		Me._Label1_7.Location = New System.Drawing.Point(8, 60)
		Me._Label1_7.TabIndex = 18
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
		Me.Label2.Text = "Event Timing"
		Me.Label2.Size = New System.Drawing.Size(89, 13)
		Me.Label2.Location = New System.Drawing.Point(8, 16)
		Me.Label2.TabIndex = 17
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
		Me._Label1_0.Text = "Comments"
		Me._Label1_0.Size = New System.Drawing.Size(81, 13)
		Me._Label1_0.Location = New System.Drawing.Point(8, 100)
		Me._Label1_0.TabIndex = 16
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
		Me.lblTurns.Text = "Turns"
		Me.lblTurns.Enabled = False
		Me.lblTurns.Size = New System.Drawing.Size(29, 13)
		Me.lblTurns.Location = New System.Drawing.Point(284, 36)
		Me.lblTurns.TabIndex = 15
		Me.lblTurns.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTurns.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTurns.BackColor = System.Drawing.SystemColors.Control
		Me.lblTurns.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTurns.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTurns.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTurns.UseMnemonic = True
		Me.lblTurns.Visible = True
		Me.lblTurns.AutoSize = False
		Me.lblTurns.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTurns.Name = "lblTurns"
		Me.lblSkillPoints.Text = "SkillPts"
		Me.lblSkillPoints.Size = New System.Drawing.Size(37, 13)
		Me.lblSkillPoints.Location = New System.Drawing.Point(172, 36)
		Me.lblSkillPoints.TabIndex = 14
		Me.lblSkillPoints.Visible = False
		Me.lblSkillPoints.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSkillPoints.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSkillPoints.BackColor = System.Drawing.SystemColors.Control
		Me.lblSkillPoints.Enabled = True
		Me.lblSkillPoints.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSkillPoints.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSkillPoints.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSkillPoints.UseMnemonic = True
		Me.lblSkillPoints.AutoSize = False
		Me.lblSkillPoints.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSkillPoints.Name = "lblSkillPoints"
		Me.lblDuration.Text = "Duration"
		Me.lblDuration.Size = New System.Drawing.Size(81, 13)
		Me.lblDuration.Location = New System.Drawing.Point(172, 16)
		Me.lblDuration.TabIndex = 13
		Me.lblDuration.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDuration.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDuration.BackColor = System.Drawing.SystemColors.Control
		Me.lblDuration.Enabled = True
		Me.lblDuration.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDuration.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDuration.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDuration.UseMnemonic = True
		Me.lblDuration.Visible = True
		Me.lblDuration.AutoSize = False
		Me.lblDuration.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDuration.Name = "lblDuration"
		Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
		Me.CancelButton = Me.btnCancel
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.Size = New System.Drawing.Size(73, 21)
		Me.btnCancel.Location = New System.Drawing.Point(580, 388)
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
		Me.btnOk.Location = New System.Drawing.Point(500, 388)
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
		Me.btnApply.Location = New System.Drawing.Point(660, 388)
		Me.btnApply.TabIndex = 1
		Me.btnApply.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnApply.CausesValidation = True
		Me.btnApply.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnApply.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnApply.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnApply.TabStop = True
		Me.btnApply.Name = "btnApply"
		tabTrigger.OcxState = CType(resources.GetObject("tabTrigger.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tabTrigger.Size = New System.Drawing.Size(401, 373)
		Me.tabTrigger.Location = New System.Drawing.Point(332, 8)
		Me.tabTrigger.TabIndex = 0
		Me.tabTrigger.Name = "tabTrigger"
		Me.Label1.SetIndex(_Label1_7, CType(7, Short))
		Me.Label1.SetIndex(_Label1_0, CType(0, Short))
		Me.chkStyle.SetIndex(_chkStyle_15, CType(15, Short))
		Me.chkStyle.SetIndex(_chkStyle_14, CType(14, Short))
		Me.chkStyle.SetIndex(_chkStyle_13, CType(13, Short))
		Me.chkStyle.SetIndex(_chkStyle_12, CType(12, Short))
		Me.chkStyle.SetIndex(_chkStyle_11, CType(11, Short))
		Me.chkStyle.SetIndex(_chkStyle_10, CType(10, Short))
		Me.chkStyle.SetIndex(_chkStyle_9, CType(9, Short))
		Me.chkStyle.SetIndex(_chkStyle_8, CType(8, Short))
		Me.chkStyle.SetIndex(_chkStyle_6, CType(6, Short))
		Me.chkStyle.SetIndex(_chkStyle_5, CType(5, Short))
		Me.chkStyle.SetIndex(_chkStyle_4, CType(4, Short))
		Me.chkStyle.SetIndex(_chkStyle_3, CType(3, Short))
		Me.chkStyle.SetIndex(_chkStyle_2, CType(2, Short))
		Me.chkStyle.SetIndex(_chkStyle_1, CType(1, Short))
		Me.chkStyle.SetIndex(_chkStyle_0, CType(0, Short))
		Me.cmbContext.SetIndex(_cmbContext_3, CType(3, Short))
		Me.cmbContext.SetIndex(_cmbContext_2, CType(2, Short))
		Me.cmbContext.SetIndex(_cmbContext_1, CType(1, Short))
		Me.cmbContext.SetIndex(_cmbContext_0, CType(0, Short))
		Me.cmbEach.SetIndex(_cmbEach_0, CType(0, Short))
		Me.cmbEach.SetIndex(_cmbEach_1, CType(1, Short))
		Me.cmbEach.SetIndex(_cmbEach_2, CType(2, Short))
		Me.cmbEach.SetIndex(_cmbEach_3, CType(3, Short))
		Me.cmbOp.SetIndex(_cmbOp_1, CType(1, Short))
		Me.cmbOp.SetIndex(_cmbOp_0, CType(0, Short))
		Me.cmbVar.SetIndex(_cmbVar_0, CType(0, Short))
		Me.cmbVar.SetIndex(_cmbVar_3, CType(3, Short))
		Me.cmbVar.SetIndex(_cmbVar_2, CType(2, Short))
		Me.cmbVar.SetIndex(_cmbVar_1, CType(1, Short))
		Me.txtText.SetIndex(_txtText_0, CType(0, Short))
		Me.txtText.SetIndex(_txtText_1, CType(1, Short))
		Me.txtText.SetIndex(_txtText_2, CType(2, Short))
		CType(Me.txtText, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmbVar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmbOp, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmbEach, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmbContext, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chkStyle, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tabTrigger, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(btnLibrary)
		Me.Controls.Add(lstAutoComplete)
		Me.Controls.Add(btnEdit)
		Me.Controls.Add(txtStatements)
		Me.Controls.Add(lstThings)
		Me.Controls.Add(fraStatementEditor)
		Me.Controls.Add(btnPaste)
		Me.Controls.Add(btnCopy)
		Me.Controls.Add(btnCut)
		Me.Controls.Add(btnNew)
		Me.Controls.Add(fraDescription)
		Me.Controls.Add(btnCancel)
		Me.Controls.Add(btnOk)
		Me.Controls.Add(btnApply)
		Me.Controls.Add(tabTrigger)
		Me.fraStatementEditor.Controls.Add(_cmbVar_0)
		Me.fraStatementEditor.Controls.Add(_cmbContext_3)
		Me.fraStatementEditor.Controls.Add(_cmbVar_3)
		Me.fraStatementEditor.Controls.Add(btnUpdate)
		Me.fraStatementEditor.Controls.Add(_cmbOp_1)
		Me.fraStatementEditor.Controls.Add(cmbStatement)
		Me.fraStatementEditor.Controls.Add(_cmbVar_2)
		Me.fraStatementEditor.Controls.Add(_cmbContext_2)
		Me.fraStatementEditor.Controls.Add(_cmbVar_1)
		Me.fraStatementEditor.Controls.Add(_cmbContext_1)
		Me.fraStatementEditor.Controls.Add(_cmbOp_0)
		Me.fraStatementEditor.Controls.Add(_cmbContext_0)
		Me.fraStatementEditor.Controls.Add(_cmbEach_0)
		Me.fraStatementEditor.Controls.Add(_cmbEach_1)
		Me.fraStatementEditor.Controls.Add(_cmbEach_2)
		Me.fraStatementEditor.Controls.Add(_txtText_0)
		Me.fraStatementEditor.Controls.Add(_txtText_1)
		Me.fraStatementEditor.Controls.Add(btnBrowse)
		Me.fraStatementEditor.Controls.Add(_cmbEach_3)
		Me.fraStatementEditor.Controls.Add(_txtText_2)
		Me.fraStatementEditor.Controls.Add(chkOption)
		Me.fraStatementEditor.Controls.Add(btnTest)
		Me.fraDescription.Controls.Add(_chkStyle_15)
		Me.fraDescription.Controls.Add(fraStyle)
		Me.fraDescription.Controls.Add(_chkStyle_1)
		Me.fraDescription.Controls.Add(_chkStyle_0)
		Me.fraDescription.Controls.Add(txtName)
		Me.fraDescription.Controls.Add(cmbTriggerType)
		Me.fraDescription.Controls.Add(txtComments)
		Me.fraDescription.Controls.Add(cmbLasting)
		Me.fraDescription.Controls.Add(txtSkillPoints)
		Me.fraDescription.Controls.Add(txtTurns)
		Me.fraDescription.Controls.Add(_Label1_7)
		Me.fraDescription.Controls.Add(Label2)
		Me.fraDescription.Controls.Add(_Label1_0)
		Me.fraDescription.Controls.Add(lblTurns)
		Me.fraDescription.Controls.Add(lblSkillPoints)
		Me.fraDescription.Controls.Add(lblDuration)
		Me.fraStyle.Controls.Add(_chkStyle_14)
		Me.fraStyle.Controls.Add(_chkStyle_13)
		Me.fraStyle.Controls.Add(_chkStyle_12)
		Me.fraStyle.Controls.Add(_chkStyle_11)
		Me.fraStyle.Controls.Add(_chkStyle_10)
		Me.fraStyle.Controls.Add(_chkStyle_9)
		Me.fraStyle.Controls.Add(_chkStyle_8)
		Me.fraStyle.Controls.Add(_chkStyle_6)
		Me.fraStyle.Controls.Add(_chkStyle_5)
		Me.fraStyle.Controls.Add(_chkStyle_4)
		Me.fraStyle.Controls.Add(_chkStyle_3)
		Me.fraStyle.Controls.Add(_chkStyle_2)
		Me.fraStatementEditor.ResumeLayout(False)
		Me.fraDescription.ResumeLayout(False)
		Me.fraStyle.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class