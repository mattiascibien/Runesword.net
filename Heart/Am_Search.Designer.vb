<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSearch
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
	Public WithEvents cmbSearchDirection As System.Windows.Forms.ComboBox
	Public WithEvents btnReplaceAll As System.Windows.Forms.Button
	Public WithEvents cmbReplaceWith As System.Windows.Forms.ComboBox
	Public WithEvents btnReplace As System.Windows.Forms.Button
	Public WithEvents _chkSearch_2 As System.Windows.Forms.CheckBox
	Public WithEvents _chkSearch_1 As System.Windows.Forms.CheckBox
	Public WithEvents _chkSearch_0 As System.Windows.Forms.CheckBox
	Public WithEvents _optSearch_4 As System.Windows.Forms.RadioButton
	Public WithEvents _optSearch_3 As System.Windows.Forms.RadioButton
	Public WithEvents _optSearch_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optSearch_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optSearch_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents btnFindNext As System.Windows.Forms.Button
	Public WithEvents txtFindWhat As System.Windows.Forms.TextBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents chkSearch As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	Public WithEvents optSearch As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSearch))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmbSearchDirection = New System.Windows.Forms.ComboBox
		Me.btnReplaceAll = New System.Windows.Forms.Button
		Me.cmbReplaceWith = New System.Windows.Forms.ComboBox
		Me.btnReplace = New System.Windows.Forms.Button
		Me._chkSearch_2 = New System.Windows.Forms.CheckBox
		Me._chkSearch_1 = New System.Windows.Forms.CheckBox
		Me._chkSearch_0 = New System.Windows.Forms.CheckBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me._optSearch_4 = New System.Windows.Forms.RadioButton
		Me._optSearch_3 = New System.Windows.Forms.RadioButton
		Me._optSearch_2 = New System.Windows.Forms.RadioButton
		Me._optSearch_1 = New System.Windows.Forms.RadioButton
		Me._optSearch_0 = New System.Windows.Forms.RadioButton
		Me.btnCancel = New System.Windows.Forms.Button
		Me.btnFindNext = New System.Windows.Forms.Button
		Me.txtFindWhat = New System.Windows.Forms.TextBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.chkSearch = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(components)
		Me.optSearch = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.chkSearch, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optSearch, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Search"
		Me.ClientSize = New System.Drawing.Size(372, 185)
		Me.Location = New System.Drawing.Point(3, 24)
		Me.Icon = CType(resources.GetObject("frmSearch.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmSearch"
		Me.cmbSearchDirection.Size = New System.Drawing.Size(77, 21)
		Me.cmbSearchDirection.Location = New System.Drawing.Point(196, 68)
		Me.cmbSearchDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbSearchDirection.TabIndex = 16
		Me.cmbSearchDirection.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbSearchDirection.BackColor = System.Drawing.SystemColors.Window
		Me.cmbSearchDirection.CausesValidation = True
		Me.cmbSearchDirection.Enabled = True
		Me.cmbSearchDirection.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbSearchDirection.IntegralHeight = True
		Me.cmbSearchDirection.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbSearchDirection.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbSearchDirection.Sorted = False
		Me.cmbSearchDirection.TabStop = True
		Me.cmbSearchDirection.Visible = True
		Me.cmbSearchDirection.Name = "cmbSearchDirection"
		Me.btnReplaceAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnReplaceAll.BackColor = System.Drawing.SystemColors.Control
		Me.CancelButton = Me.btnReplaceAll
		Me.btnReplaceAll.Text = "Replace All"
		Me.btnReplaceAll.Enabled = False
		Me.btnReplaceAll.Size = New System.Drawing.Size(73, 21)
		Me.btnReplaceAll.Location = New System.Drawing.Point(288, 108)
		Me.btnReplaceAll.TabIndex = 15
		Me.btnReplaceAll.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnReplaceAll.CausesValidation = True
		Me.btnReplaceAll.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnReplaceAll.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnReplaceAll.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnReplaceAll.TabStop = True
		Me.btnReplaceAll.Name = "btnReplaceAll"
		Me.cmbReplaceWith.Enabled = False
		Me.cmbReplaceWith.Size = New System.Drawing.Size(193, 21)
		Me.cmbReplaceWith.Location = New System.Drawing.Point(80, 36)
		Me.cmbReplaceWith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbReplaceWith.TabIndex = 14
		Me.cmbReplaceWith.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbReplaceWith.BackColor = System.Drawing.SystemColors.Window
		Me.cmbReplaceWith.CausesValidation = True
		Me.cmbReplaceWith.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbReplaceWith.IntegralHeight = True
		Me.cmbReplaceWith.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbReplaceWith.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbReplaceWith.Sorted = False
		Me.cmbReplaceWith.TabStop = True
		Me.cmbReplaceWith.Visible = True
		Me.cmbReplaceWith.Name = "cmbReplaceWith"
		Me.btnReplace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnReplace.BackColor = System.Drawing.SystemColors.Control
		Me.btnReplace.Text = "Replace"
		Me.btnReplace.Enabled = False
		Me.btnReplace.Size = New System.Drawing.Size(73, 21)
		Me.btnReplace.Location = New System.Drawing.Point(288, 80)
		Me.btnReplace.TabIndex = 12
		Me.btnReplace.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnReplace.CausesValidation = True
		Me.btnReplace.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnReplace.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnReplace.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnReplace.TabStop = True
		Me.btnReplace.Name = "btnReplace"
		Me._chkSearch_2.Text = "Use Pattern Matching"
		Me._chkSearch_2.Size = New System.Drawing.Size(137, 17)
		Me._chkSearch_2.Location = New System.Drawing.Point(140, 140)
		Me._chkSearch_2.TabIndex = 11
		Me._chkSearch_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkSearch_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkSearch_2.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkSearch_2.BackColor = System.Drawing.SystemColors.Control
		Me._chkSearch_2.CausesValidation = True
		Me._chkSearch_2.Enabled = True
		Me._chkSearch_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkSearch_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkSearch_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkSearch_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkSearch_2.TabStop = True
		Me._chkSearch_2.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkSearch_2.Visible = True
		Me._chkSearch_2.Name = "_chkSearch_2"
		Me._chkSearch_1.Text = "Match Case"
		Me._chkSearch_1.Size = New System.Drawing.Size(137, 17)
		Me._chkSearch_1.Location = New System.Drawing.Point(140, 120)
		Me._chkSearch_1.TabIndex = 10
		Me._chkSearch_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkSearch_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkSearch_1.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkSearch_1.BackColor = System.Drawing.SystemColors.Control
		Me._chkSearch_1.CausesValidation = True
		Me._chkSearch_1.Enabled = True
		Me._chkSearch_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkSearch_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkSearch_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkSearch_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkSearch_1.TabStop = True
		Me._chkSearch_1.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkSearch_1.Visible = True
		Me._chkSearch_1.Name = "_chkSearch_1"
		Me._chkSearch_0.Text = "Find Whole Word Only"
		Me._chkSearch_0.Size = New System.Drawing.Size(137, 17)
		Me._chkSearch_0.Location = New System.Drawing.Point(140, 100)
		Me._chkSearch_0.TabIndex = 9
		Me._chkSearch_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkSearch_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkSearch_0.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkSearch_0.BackColor = System.Drawing.SystemColors.Control
		Me._chkSearch_0.CausesValidation = True
		Me._chkSearch_0.Enabled = True
		Me._chkSearch_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkSearch_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkSearch_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkSearch_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkSearch_0.TabStop = True
		Me._chkSearch_0.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkSearch_0.Visible = True
		Me._chkSearch_0.Name = "_chkSearch_0"
		Me.Frame1.Text = "Search"
		Me.Frame1.Size = New System.Drawing.Size(121, 121)
		Me.Frame1.Location = New System.Drawing.Point(8, 60)
		Me.Frame1.TabIndex = 4
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me._optSearch_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSearch_4.Text = "Data files"
		Me._optSearch_4.Size = New System.Drawing.Size(73, 17)
		Me._optSearch_4.Location = New System.Drawing.Point(16, 100)
		Me._optSearch_4.TabIndex = 18
		Me._optSearch_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optSearch_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSearch_4.BackColor = System.Drawing.SystemColors.Control
		Me._optSearch_4.CausesValidation = True
		Me._optSearch_4.Enabled = True
		Me._optSearch_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optSearch_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._optSearch_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optSearch_4.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optSearch_4.TabStop = True
		Me._optSearch_4.Checked = False
		Me._optSearch_4.Visible = True
		Me._optSearch_4.Name = "_optSearch_4"
		Me._optSearch_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSearch_3.Text = "Triggers"
		Me._optSearch_3.Size = New System.Drawing.Size(73, 17)
		Me._optSearch_3.Location = New System.Drawing.Point(16, 80)
		Me._optSearch_3.TabIndex = 8
		Me._optSearch_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optSearch_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSearch_3.BackColor = System.Drawing.SystemColors.Control
		Me._optSearch_3.CausesValidation = True
		Me._optSearch_3.Enabled = True
		Me._optSearch_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optSearch_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._optSearch_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optSearch_3.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optSearch_3.TabStop = True
		Me._optSearch_3.Checked = False
		Me._optSearch_3.Visible = True
		Me._optSearch_3.Name = "_optSearch_3"
		Me._optSearch_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSearch_2.Text = "Items"
		Me._optSearch_2.Size = New System.Drawing.Size(81, 17)
		Me._optSearch_2.Location = New System.Drawing.Point(16, 60)
		Me._optSearch_2.TabIndex = 7
		Me._optSearch_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optSearch_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSearch_2.BackColor = System.Drawing.SystemColors.Control
		Me._optSearch_2.CausesValidation = True
		Me._optSearch_2.Enabled = True
		Me._optSearch_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optSearch_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._optSearch_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optSearch_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optSearch_2.TabStop = True
		Me._optSearch_2.Checked = False
		Me._optSearch_2.Visible = True
		Me._optSearch_2.Name = "_optSearch_2"
		Me._optSearch_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSearch_1.Text = "Creatures"
		Me._optSearch_1.Size = New System.Drawing.Size(81, 17)
		Me._optSearch_1.Location = New System.Drawing.Point(16, 40)
		Me._optSearch_1.TabIndex = 6
		Me._optSearch_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optSearch_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSearch_1.BackColor = System.Drawing.SystemColors.Control
		Me._optSearch_1.CausesValidation = True
		Me._optSearch_1.Enabled = True
		Me._optSearch_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optSearch_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optSearch_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optSearch_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optSearch_1.TabStop = True
		Me._optSearch_1.Checked = False
		Me._optSearch_1.Visible = True
		Me._optSearch_1.Name = "_optSearch_1"
		Me._optSearch_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSearch_0.Text = "Encounters"
		Me._optSearch_0.Size = New System.Drawing.Size(85, 17)
		Me._optSearch_0.Location = New System.Drawing.Point(16, 20)
		Me._optSearch_0.TabIndex = 5
		Me._optSearch_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optSearch_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSearch_0.BackColor = System.Drawing.SystemColors.Control
		Me._optSearch_0.CausesValidation = True
		Me._optSearch_0.Enabled = True
		Me._optSearch_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optSearch_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optSearch_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optSearch_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optSearch_0.TabStop = True
		Me._optSearch_0.Checked = False
		Me._optSearch_0.Visible = True
		Me._optSearch_0.Name = "_optSearch_0"
		Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.Size = New System.Drawing.Size(73, 21)
		Me.btnCancel.Location = New System.Drawing.Point(288, 40)
		Me.btnCancel.TabIndex = 3
		Me.btnCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancel.CausesValidation = True
		Me.btnCancel.Enabled = True
		Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCancel.TabStop = True
		Me.btnCancel.Name = "btnCancel"
		Me.btnFindNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnFindNext.BackColor = System.Drawing.SystemColors.Control
		Me.btnFindNext.Text = "Find Next"
		Me.btnFindNext.Size = New System.Drawing.Size(73, 21)
		Me.btnFindNext.Location = New System.Drawing.Point(288, 12)
		Me.btnFindNext.TabIndex = 2
		Me.btnFindNext.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnFindNext.CausesValidation = True
		Me.btnFindNext.Enabled = True
		Me.btnFindNext.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnFindNext.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnFindNext.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnFindNext.TabStop = True
		Me.btnFindNext.Name = "btnFindNext"
		Me.txtFindWhat.AutoSize = False
		Me.txtFindWhat.Size = New System.Drawing.Size(193, 19)
		Me.txtFindWhat.Location = New System.Drawing.Point(80, 12)
		Me.txtFindWhat.TabIndex = 0
		Me.txtFindWhat.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFindWhat.AcceptsReturn = True
		Me.txtFindWhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtFindWhat.BackColor = System.Drawing.SystemColors.Window
		Me.txtFindWhat.CausesValidation = True
		Me.txtFindWhat.Enabled = True
		Me.txtFindWhat.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtFindWhat.HideSelection = True
		Me.txtFindWhat.ReadOnly = False
		Me.txtFindWhat.Maxlength = 0
		Me.txtFindWhat.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtFindWhat.MultiLine = False
		Me.txtFindWhat.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtFindWhat.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtFindWhat.TabStop = True
		Me.txtFindWhat.Visible = True
		Me.txtFindWhat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtFindWhat.Name = "txtFindWhat"
		Me.Label3.Text = "Direction"
		Me.Label3.Size = New System.Drawing.Size(53, 17)
		Me.Label3.Location = New System.Drawing.Point(140, 72)
		Me.Label3.TabIndex = 17
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
		Me.Label2.Text = "Replace With"
		Me.Label2.Size = New System.Drawing.Size(73, 17)
		Me.Label2.Location = New System.Drawing.Point(8, 40)
		Me.Label2.TabIndex = 13
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
		Me.Label1.Text = "Find What"
		Me.Label1.Size = New System.Drawing.Size(65, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 16)
		Me.Label1.TabIndex = 1
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
		Me.chkSearch.SetIndex(_chkSearch_2, CType(2, Short))
		Me.chkSearch.SetIndex(_chkSearch_1, CType(1, Short))
		Me.chkSearch.SetIndex(_chkSearch_0, CType(0, Short))
		Me.optSearch.SetIndex(_optSearch_4, CType(4, Short))
		Me.optSearch.SetIndex(_optSearch_3, CType(3, Short))
		Me.optSearch.SetIndex(_optSearch_2, CType(2, Short))
		Me.optSearch.SetIndex(_optSearch_1, CType(1, Short))
		Me.optSearch.SetIndex(_optSearch_0, CType(0, Short))
		CType(Me.optSearch, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chkSearch, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(cmbSearchDirection)
		Me.Controls.Add(btnReplaceAll)
		Me.Controls.Add(cmbReplaceWith)
		Me.Controls.Add(btnReplace)
		Me.Controls.Add(_chkSearch_2)
		Me.Controls.Add(_chkSearch_1)
		Me.Controls.Add(_chkSearch_0)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(btnCancel)
		Me.Controls.Add(btnFindNext)
		Me.Controls.Add(txtFindWhat)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Frame1.Controls.Add(_optSearch_4)
		Me.Frame1.Controls.Add(_optSearch_3)
		Me.Frame1.Controls.Add(_optSearch_2)
		Me.Frame1.Controls.Add(_optSearch_1)
		Me.Frame1.Controls.Add(_optSearch_0)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class