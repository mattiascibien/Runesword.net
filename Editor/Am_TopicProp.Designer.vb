<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmTopic
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
	Public WithEvents chkDefault As System.Windows.Forms.CheckBox
	Public WithEvents txtSay As System.Windows.Forms.TextBox
	Public WithEvents cmbActionRef As System.Windows.Forms.ComboBox
	Public WithEvents cmbAction As System.Windows.Forms.ComboBox
	Public WithEvents txtReply As System.Windows.Forms.TextBox
	Public WithEvents _Label1_2 As System.Windows.Forms.Label
	Public WithEvents _Label1_1 As System.Windows.Forms.Label
	Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents _fraTopic_0 As System.Windows.Forms.Panel
	Public WithEvents btnLibrary As System.Windows.Forms.Button
	Public WithEvents btnPaste As System.Windows.Forms.Button
	Public WithEvents btnCopy As System.Windows.Forms.Button
	Public WithEvents btnCut As System.Windows.Forms.Button
	Public WithEvents btnInsert As System.Windows.Forms.Button
	Public WithEvents btnEdit As System.Windows.Forms.Button
	Public WithEvents lstThings As System.Windows.Forms.ListBox
	Public WithEvents lblAttached As System.Windows.Forms.Label
	Public WithEvents _fraTopic_1 As System.Windows.Forms.Panel
	Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents btnOk As System.Windows.Forms.Button
	Public WithEvents btnApply As System.Windows.Forms.Button
	Public WithEvents tabTopicProp As AxComctlLib.AxTabStrip
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents fraTopic As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTopic))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me._fraTopic_0 = New System.Windows.Forms.Panel
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.chkDefault = New System.Windows.Forms.CheckBox
		Me.txtSay = New System.Windows.Forms.TextBox
		Me.cmbActionRef = New System.Windows.Forms.ComboBox
		Me.cmbAction = New System.Windows.Forms.ComboBox
		Me.txtReply = New System.Windows.Forms.TextBox
		Me._Label1_2 = New System.Windows.Forms.Label
		Me._Label1_1 = New System.Windows.Forms.Label
		Me._Label1_0 = New System.Windows.Forms.Label
		Me._fraTopic_1 = New System.Windows.Forms.Panel
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
		Me.tabTopicProp = New AxComctlLib.AxTabStrip
		Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.fraTopic = New Microsoft.VisualBasic.Compatibility.VB6.PanelArray(components)
		Me._fraTopic_0.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me._fraTopic_1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tabTopicProp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.fraTopic, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Topic Properties"
		Me.ClientSize = New System.Drawing.Size(393, 267)
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
		Me.Name = "frmTopic"
		Me._fraTopic_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._fraTopic_0.Size = New System.Drawing.Size(377, 201)
		Me._fraTopic_0.Location = New System.Drawing.Point(8, 28)
		Me._fraTopic_0.TabIndex = 4
		Me._fraTopic_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraTopic_0.BackColor = System.Drawing.SystemColors.Control
		Me._fraTopic_0.Enabled = True
		Me._fraTopic_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraTopic_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._fraTopic_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraTopic_0.Visible = True
		Me._fraTopic_0.Name = "_fraTopic_0"
		Me.Frame1.Text = "Details"
		Me.Frame1.Size = New System.Drawing.Size(369, 193)
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
		Me.chkDefault.Text = "Lists by default?"
		Me.chkDefault.Size = New System.Drawing.Size(97, 13)
		Me.chkDefault.Location = New System.Drawing.Point(268, 16)
		Me.chkDefault.TabIndex = 21
		Me.chkDefault.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkDefault.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkDefault.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkDefault.BackColor = System.Drawing.SystemColors.Control
		Me.chkDefault.CausesValidation = True
		Me.chkDefault.Enabled = True
		Me.chkDefault.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkDefault.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkDefault.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkDefault.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkDefault.TabStop = True
		Me.chkDefault.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkDefault.Visible = True
		Me.chkDefault.Name = "chkDefault"
		Me.txtSay.AutoSize = False
		Me.txtSay.Size = New System.Drawing.Size(353, 21)
		Me.txtSay.Location = New System.Drawing.Point(8, 32)
		Me.txtSay.TabIndex = 19
		Me.txtSay.Text = "Text2"
		Me.txtSay.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSay.AcceptsReturn = True
		Me.txtSay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSay.BackColor = System.Drawing.SystemColors.Window
		Me.txtSay.CausesValidation = True
		Me.txtSay.Enabled = True
		Me.txtSay.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSay.HideSelection = True
		Me.txtSay.ReadOnly = False
		Me.txtSay.Maxlength = 0
		Me.txtSay.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSay.MultiLine = False
		Me.txtSay.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSay.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSay.TabStop = True
		Me.txtSay.Visible = True
		Me.txtSay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSay.Name = "txtSay"
		Me.cmbActionRef.Size = New System.Drawing.Size(221, 21)
		Me.cmbActionRef.Location = New System.Drawing.Point(140, 160)
		Me.cmbActionRef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbActionRef.TabIndex = 18
		Me.cmbActionRef.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbActionRef.BackColor = System.Drawing.SystemColors.Window
		Me.cmbActionRef.CausesValidation = True
		Me.cmbActionRef.Enabled = True
		Me.cmbActionRef.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbActionRef.IntegralHeight = True
		Me.cmbActionRef.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbActionRef.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbActionRef.Sorted = False
		Me.cmbActionRef.TabStop = True
		Me.cmbActionRef.Visible = True
		Me.cmbActionRef.Name = "cmbActionRef"
		Me.cmbAction.Size = New System.Drawing.Size(125, 21)
		Me.cmbAction.Location = New System.Drawing.Point(8, 160)
		Me.cmbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbAction.TabIndex = 16
		Me.cmbAction.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbAction.BackColor = System.Drawing.SystemColors.Window
		Me.cmbAction.CausesValidation = True
		Me.cmbAction.Enabled = True
		Me.cmbAction.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbAction.IntegralHeight = True
		Me.cmbAction.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbAction.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbAction.Sorted = False
		Me.cmbAction.TabStop = True
		Me.cmbAction.Visible = True
		Me.cmbAction.Name = "cmbAction"
		Me.txtReply.AutoSize = False
		Me.txtReply.Size = New System.Drawing.Size(353, 69)
		Me.txtReply.Location = New System.Drawing.Point(8, 72)
		Me.txtReply.MultiLine = True
		Me.txtReply.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtReply.TabIndex = 6
		Me.txtReply.Text = "Text2"
		Me.txtReply.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtReply.AcceptsReturn = True
		Me.txtReply.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtReply.BackColor = System.Drawing.SystemColors.Window
		Me.txtReply.CausesValidation = True
		Me.txtReply.Enabled = True
		Me.txtReply.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtReply.HideSelection = True
		Me.txtReply.ReadOnly = False
		Me.txtReply.Maxlength = 0
		Me.txtReply.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtReply.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtReply.TabStop = True
		Me.txtReply.Visible = True
		Me.txtReply.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtReply.Name = "txtReply"
		Me._Label1_2.Text = "PC says"
		Me._Label1_2.Size = New System.Drawing.Size(81, 13)
		Me._Label1_2.Location = New System.Drawing.Point(8, 16)
		Me._Label1_2.TabIndex = 20
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
		Me._Label1_1.Text = "Action"
		Me._Label1_1.Size = New System.Drawing.Size(105, 13)
		Me._Label1_1.Location = New System.Drawing.Point(8, 144)
		Me._Label1_1.TabIndex = 17
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
		Me._Label1_0.Text = "NPC Replies"
		Me._Label1_0.Size = New System.Drawing.Size(81, 13)
		Me._Label1_0.Location = New System.Drawing.Point(8, 56)
		Me._Label1_0.TabIndex = 7
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
		Me._fraTopic_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._fraTopic_1.Size = New System.Drawing.Size(377, 197)
		Me._fraTopic_1.Location = New System.Drawing.Point(8, 28)
		Me._fraTopic_1.TabIndex = 8
		Me._fraTopic_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraTopic_1.BackColor = System.Drawing.SystemColors.Control
		Me._fraTopic_1.Enabled = True
		Me._fraTopic_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraTopic_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._fraTopic_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraTopic_1.Visible = True
		Me._fraTopic_1.Name = "_fraTopic_1"
		Me.btnLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnLibrary.Text = "Insert trigger from library"
		Me.btnLibrary.Size = New System.Drawing.Size(73, 49)
		Me.btnLibrary.Location = New System.Drawing.Point(300, 40)
		Me.btnLibrary.TabIndex = 22
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
		Me.btnPaste.Location = New System.Drawing.Point(300, 168)
		Me.btnPaste.TabIndex = 15
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
		Me.btnCopy.Location = New System.Drawing.Point(300, 144)
		Me.btnCopy.TabIndex = 14
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
		Me.btnCut.Location = New System.Drawing.Point(300, 120)
		Me.btnCut.TabIndex = 12
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
		Me.btnInsert.Location = New System.Drawing.Point(300, 16)
		Me.btnInsert.TabIndex = 11
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
		Me.btnEdit.Location = New System.Drawing.Point(300, 91)
		Me.btnEdit.TabIndex = 10
		Me.btnEdit.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEdit.CausesValidation = True
		Me.btnEdit.Enabled = True
		Me.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnEdit.TabStop = True
		Me.btnEdit.Name = "btnEdit"
		Me.lstThings.Size = New System.Drawing.Size(289, 163)
		Me.lstThings.Location = New System.Drawing.Point(4, 24)
		Me.lstThings.TabIndex = 9
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
		Me.lblAttached.Text = "Triggers Attached to Topic"
		Me.lblAttached.Size = New System.Drawing.Size(289, 13)
		Me.lblAttached.Location = New System.Drawing.Point(4, 4)
		Me.lblAttached.TabIndex = 13
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
		tabTopicProp.OcxState = CType(resources.GetObject("tabTopicProp.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tabTopicProp.Size = New System.Drawing.Size(385, 229)
		Me.tabTopicProp.Location = New System.Drawing.Point(4, 4)
		Me.tabTopicProp.TabIndex = 0
		Me.tabTopicProp.Name = "tabTopicProp"
		Me.Label1.SetIndex(_Label1_2, CType(2, Short))
		Me.Label1.SetIndex(_Label1_1, CType(1, Short))
		Me.Label1.SetIndex(_Label1_0, CType(0, Short))
		Me.fraTopic.SetIndex(_fraTopic_0, CType(0, Short))
		Me.fraTopic.SetIndex(_fraTopic_1, CType(1, Short))
		CType(Me.fraTopic, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tabTopicProp, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(_fraTopic_0)
		Me.Controls.Add(_fraTopic_1)
		Me.Controls.Add(btnCancel)
		Me.Controls.Add(btnOk)
		Me.Controls.Add(btnApply)
		Me.Controls.Add(tabTopicProp)
		Me._fraTopic_0.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(chkDefault)
		Me.Frame1.Controls.Add(txtSay)
		Me.Frame1.Controls.Add(cmbActionRef)
		Me.Frame1.Controls.Add(cmbAction)
		Me.Frame1.Controls.Add(txtReply)
		Me.Frame1.Controls.Add(_Label1_2)
		Me.Frame1.Controls.Add(_Label1_1)
		Me.Frame1.Controls.Add(_Label1_0)
		Me._fraTopic_1.Controls.Add(btnLibrary)
		Me._fraTopic_1.Controls.Add(btnPaste)
		Me._fraTopic_1.Controls.Add(btnCopy)
		Me._fraTopic_1.Controls.Add(btnCut)
		Me._fraTopic_1.Controls.Add(btnInsert)
		Me._fraTopic_1.Controls.Add(btnEdit)
		Me._fraTopic_1.Controls.Add(lstThings)
		Me._fraTopic_1.Controls.Add(lblAttached)
		Me._fraTopic_0.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me._fraTopic_1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class