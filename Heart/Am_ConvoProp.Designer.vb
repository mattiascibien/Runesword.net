<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmConvoProp
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
	Public WithEvents chkDefault As System.Windows.Forms.CheckBox
	Public WithEvents txtFirstTalk As System.Windows.Forms.TextBox
	Public WithEvents txtName As System.Windows.Forms.TextBox
	Public WithEvents txtSecondTalk As System.Windows.Forms.TextBox
	Public WithEvents chkHaveTalked As System.Windows.Forms.CheckBox
	Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents _lblName_1 As System.Windows.Forms.Label
	Public WithEvents _Label1_4 As System.Windows.Forms.Label
	Public WithEvents _fraConvoProp_0 As System.Windows.Forms.GroupBox
	Public WithEvents lstThings As System.Windows.Forms.ListBox
	Public WithEvents btnEdit As System.Windows.Forms.Button
	Public WithEvents btnInsert As System.Windows.Forms.Button
	Public WithEvents btnCut As System.Windows.Forms.Button
	Public WithEvents btnCopy As System.Windows.Forms.Button
	Public WithEvents btnPaste As System.Windows.Forms.Button
	Public WithEvents lblAttached As System.Windows.Forms.Label
	Public WithEvents _fraConvoProp_1 As System.Windows.Forms.GroupBox
	Public WithEvents btnApply As System.Windows.Forms.Button
	Public WithEvents btnOk As System.Windows.Forms.Button
	Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents tabConvoProp As AxComctlLib.AxTabStrip
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents fraConvoProp As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
	Public WithEvents lblName As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmConvoProp))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me._fraConvoProp_0 = New System.Windows.Forms.GroupBox
		Me.chkDefault = New System.Windows.Forms.CheckBox
		Me.txtFirstTalk = New System.Windows.Forms.TextBox
		Me.txtName = New System.Windows.Forms.TextBox
		Me.txtSecondTalk = New System.Windows.Forms.TextBox
		Me.chkHaveTalked = New System.Windows.Forms.CheckBox
		Me._Label1_0 = New System.Windows.Forms.Label
		Me._lblName_1 = New System.Windows.Forms.Label
		Me._Label1_4 = New System.Windows.Forms.Label
		Me._fraConvoProp_1 = New System.Windows.Forms.GroupBox
		Me.lstThings = New System.Windows.Forms.ListBox
		Me.btnEdit = New System.Windows.Forms.Button
		Me.btnInsert = New System.Windows.Forms.Button
		Me.btnCut = New System.Windows.Forms.Button
		Me.btnCopy = New System.Windows.Forms.Button
		Me.btnPaste = New System.Windows.Forms.Button
		Me.lblAttached = New System.Windows.Forms.Label
		Me.btnApply = New System.Windows.Forms.Button
		Me.btnOk = New System.Windows.Forms.Button
		Me.btnCancel = New System.Windows.Forms.Button
		Me.tabConvoProp = New AxComctlLib.AxTabStrip
		Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.fraConvoProp = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(components)
		Me.lblName = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me._fraConvoProp_0.SuspendLayout()
		Me._fraConvoProp_1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tabConvoProp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.fraConvoProp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblName, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Conversation Properties"
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
		Me.Name = "frmConvoProp"
		Me._fraConvoProp_0.Text = "Description"
		Me._fraConvoProp_0.Size = New System.Drawing.Size(369, 193)
		Me._fraConvoProp_0.Location = New System.Drawing.Point(12, 28)
		Me._fraConvoProp_0.TabIndex = 4
		Me._fraConvoProp_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraConvoProp_0.BackColor = System.Drawing.SystemColors.Control
		Me._fraConvoProp_0.Enabled = True
		Me._fraConvoProp_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraConvoProp_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraConvoProp_0.Visible = True
		Me._fraConvoProp_0.Padding = New System.Windows.Forms.Padding(0)
		Me._fraConvoProp_0.Name = "_fraConvoProp_0"
		Me.chkDefault.Text = "Current Default Convo?"
		Me.chkDefault.Size = New System.Drawing.Size(137, 13)
		Me.chkDefault.Location = New System.Drawing.Point(216, 16)
		Me.chkDefault.TabIndex = 20
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
		Me.txtFirstTalk.AutoSize = False
		Me.txtFirstTalk.Size = New System.Drawing.Size(345, 45)
		Me.txtFirstTalk.Location = New System.Drawing.Point(8, 72)
		Me.txtFirstTalk.MultiLine = True
		Me.txtFirstTalk.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtFirstTalk.TabIndex = 8
		Me.txtFirstTalk.Text = "Text2"
		Me.txtFirstTalk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFirstTalk.AcceptsReturn = True
		Me.txtFirstTalk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtFirstTalk.BackColor = System.Drawing.SystemColors.Window
		Me.txtFirstTalk.CausesValidation = True
		Me.txtFirstTalk.Enabled = True
		Me.txtFirstTalk.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtFirstTalk.HideSelection = True
		Me.txtFirstTalk.ReadOnly = False
		Me.txtFirstTalk.Maxlength = 0
		Me.txtFirstTalk.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtFirstTalk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtFirstTalk.TabStop = True
		Me.txtFirstTalk.Visible = True
		Me.txtFirstTalk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtFirstTalk.Name = "txtFirstTalk"
		Me.txtName.AutoSize = False
		Me.txtName.Size = New System.Drawing.Size(345, 19)
		Me.txtName.Location = New System.Drawing.Point(8, 32)
		Me.txtName.TabIndex = 7
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
		Me.txtSecondTalk.AutoSize = False
		Me.txtSecondTalk.Size = New System.Drawing.Size(345, 45)
		Me.txtSecondTalk.Location = New System.Drawing.Point(8, 140)
		Me.txtSecondTalk.MultiLine = True
		Me.txtSecondTalk.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtSecondTalk.TabIndex = 6
		Me.txtSecondTalk.Text = "Text2"
		Me.txtSecondTalk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSecondTalk.AcceptsReturn = True
		Me.txtSecondTalk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSecondTalk.BackColor = System.Drawing.SystemColors.Window
		Me.txtSecondTalk.CausesValidation = True
		Me.txtSecondTalk.Enabled = True
		Me.txtSecondTalk.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSecondTalk.HideSelection = True
		Me.txtSecondTalk.ReadOnly = False
		Me.txtSecondTalk.Maxlength = 0
		Me.txtSecondTalk.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSecondTalk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSecondTalk.TabStop = True
		Me.txtSecondTalk.Visible = True
		Me.txtSecondTalk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSecondTalk.Name = "txtSecondTalk"
		Me.chkHaveTalked.Text = "Have Approached?"
		Me.chkHaveTalked.Size = New System.Drawing.Size(133, 13)
		Me.chkHaveTalked.Location = New System.Drawing.Point(216, 56)
		Me.chkHaveTalked.TabIndex = 5
		Me.chkHaveTalked.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkHaveTalked.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkHaveTalked.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkHaveTalked.BackColor = System.Drawing.SystemColors.Control
		Me.chkHaveTalked.CausesValidation = True
		Me.chkHaveTalked.Enabled = True
		Me.chkHaveTalked.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkHaveTalked.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkHaveTalked.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkHaveTalked.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkHaveTalked.TabStop = True
		Me.chkHaveTalked.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkHaveTalked.Visible = True
		Me.chkHaveTalked.Name = "chkHaveTalked"
		Me._Label1_0.Text = "Says when first approach to Talk"
		Me._Label1_0.Size = New System.Drawing.Size(173, 13)
		Me._Label1_0.Location = New System.Drawing.Point(8, 56)
		Me._Label1_0.TabIndex = 11
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
		Me._lblName_1.TabIndex = 10
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
		Me._Label1_4.Text = "Says for each approach after the first"
		Me._Label1_4.Size = New System.Drawing.Size(201, 13)
		Me._Label1_4.Location = New System.Drawing.Point(8, 121)
		Me._Label1_4.TabIndex = 9
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
		Me._fraConvoProp_1.Size = New System.Drawing.Size(373, 193)
		Me._fraConvoProp_1.Location = New System.Drawing.Point(12, 28)
		Me._fraConvoProp_1.TabIndex = 12
		Me._fraConvoProp_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraConvoProp_1.BackColor = System.Drawing.SystemColors.Control
		Me._fraConvoProp_1.Enabled = True
		Me._fraConvoProp_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraConvoProp_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraConvoProp_1.Visible = True
		Me._fraConvoProp_1.Padding = New System.Windows.Forms.Padding(0)
		Me._fraConvoProp_1.Name = "_fraConvoProp_1"
		Me.lstThings.Size = New System.Drawing.Size(289, 163)
		Me.lstThings.Location = New System.Drawing.Point(0, 24)
		Me.lstThings.TabIndex = 18
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
		Me.btnEdit.Location = New System.Drawing.Point(296, 160)
		Me.btnEdit.TabIndex = 17
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
		Me.btnInsert.Location = New System.Drawing.Point(296, 24)
		Me.btnInsert.TabIndex = 16
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
		Me.btnCut.Location = New System.Drawing.Point(296, 64)
		Me.btnCut.TabIndex = 15
		Me.btnCut.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCut.CausesValidation = True
		Me.btnCut.Enabled = True
		Me.btnCut.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCut.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCut.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCut.TabStop = True
		Me.btnCut.Name = "btnCut"
		Me.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnCopy.BackColor = System.Drawing.SystemColors.Control
		Me.btnCopy.Text = "Copy"
		Me.btnCopy.Size = New System.Drawing.Size(73, 21)
		Me.btnCopy.Location = New System.Drawing.Point(296, 92)
		Me.btnCopy.TabIndex = 14
		Me.btnCopy.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCopy.CausesValidation = True
		Me.btnCopy.Enabled = True
		Me.btnCopy.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCopy.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCopy.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCopy.TabStop = True
		Me.btnCopy.Name = "btnCopy"
		Me.btnPaste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnPaste.BackColor = System.Drawing.SystemColors.Control
		Me.btnPaste.Text = "Paste"
		Me.btnPaste.Size = New System.Drawing.Size(73, 21)
		Me.btnPaste.Location = New System.Drawing.Point(296, 120)
		Me.btnPaste.TabIndex = 13
		Me.btnPaste.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPaste.CausesValidation = True
		Me.btnPaste.Enabled = True
		Me.btnPaste.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnPaste.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnPaste.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnPaste.TabStop = True
		Me.btnPaste.Name = "btnPaste"
		Me.lblAttached.Text = "Topics for this Conversation"
		Me.lblAttached.Size = New System.Drawing.Size(289, 13)
		Me.lblAttached.Location = New System.Drawing.Point(0, 4)
		Me.lblAttached.TabIndex = 19
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
		tabConvoProp.OcxState = CType(resources.GetObject("tabConvoProp.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tabConvoProp.Size = New System.Drawing.Size(385, 229)
		Me.tabConvoProp.Location = New System.Drawing.Point(4, 4)
		Me.tabConvoProp.TabIndex = 0
		Me.tabConvoProp.Name = "tabConvoProp"
		Me.Label1.SetIndex(_Label1_0, CType(0, Short))
		Me.Label1.SetIndex(_Label1_4, CType(4, Short))
		Me.fraConvoProp.SetIndex(_fraConvoProp_0, CType(0, Short))
		Me.fraConvoProp.SetIndex(_fraConvoProp_1, CType(1, Short))
		Me.lblName.SetIndex(_lblName_1, CType(1, Short))
		CType(Me.lblName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.fraConvoProp, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tabConvoProp, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(_fraConvoProp_0)
		Me.Controls.Add(_fraConvoProp_1)
		Me.Controls.Add(btnApply)
		Me.Controls.Add(btnOk)
		Me.Controls.Add(btnCancel)
		Me.Controls.Add(tabConvoProp)
		Me._fraConvoProp_0.Controls.Add(chkDefault)
		Me._fraConvoProp_0.Controls.Add(txtFirstTalk)
		Me._fraConvoProp_0.Controls.Add(txtName)
		Me._fraConvoProp_0.Controls.Add(txtSecondTalk)
		Me._fraConvoProp_0.Controls.Add(chkHaveTalked)
		Me._fraConvoProp_0.Controls.Add(_Label1_0)
		Me._fraConvoProp_0.Controls.Add(_lblName_1)
		Me._fraConvoProp_0.Controls.Add(_Label1_4)
		Me._fraConvoProp_1.Controls.Add(lstThings)
		Me._fraConvoProp_1.Controls.Add(btnEdit)
		Me._fraConvoProp_1.Controls.Add(btnInsert)
		Me._fraConvoProp_1.Controls.Add(btnCut)
		Me._fraConvoProp_1.Controls.Add(btnCopy)
		Me._fraConvoProp_1.Controls.Add(btnPaste)
		Me._fraConvoProp_1.Controls.Add(lblAttached)
		Me._fraConvoProp_0.ResumeLayout(False)
		Me._fraConvoProp_1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class