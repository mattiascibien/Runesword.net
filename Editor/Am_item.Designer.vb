<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmItem
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
	Public WithEvents chkSoftCapacity As System.Windows.Forms.CheckBox
	Public WithEvents picItem As System.Windows.Forms.PictureBox
	Public WithEvents txtBulk As System.Windows.Forms.TextBox
	Public WithEvents txtCapacity As System.Windows.Forms.TextBox
	Public WithEvents txtWeight As System.Windows.Forms.TextBox
	Public WithEvents txtCount As System.Windows.Forms.TextBox
	Public WithEvents txtValue As System.Windows.Forms.TextBox
	Public WithEvents btnBrowse As System.Windows.Forms.Button
	Public WithEvents btnBrowseLeft As System.Windows.Forms.Button
	Public WithEvents btnBrowseRight As System.Windows.Forms.Button
	Public WithEvents _Label1_5 As System.Windows.Forms.Label
	Public WithEvents _Label1_6 As System.Windows.Forms.Label
	Public WithEvents _Label1_4 As System.Windows.Forms.Label
	Public WithEvents _Label1_7 As System.Windows.Forms.Label
	Public WithEvents _Label1_17 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents chkCombine As System.Windows.Forms.CheckBox
	Public WithEvents chkDescription As System.Windows.Forms.CheckBox
	Public WithEvents txtComments As System.Windows.Forms.TextBox
	Public WithEvents txtName As System.Windows.Forms.TextBox
	Public WithEvents _Label1_21 As System.Windows.Forms.Label
	Public WithEvents _lblName_1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents _fraItemProp_0 As System.Windows.Forms.Panel
	Public WithEvents btnLibrary As System.Windows.Forms.Button
	Public WithEvents btnPaste As System.Windows.Forms.Button
	Public WithEvents btnCopy As System.Windows.Forms.Button
	Public WithEvents lstThings As System.Windows.Forms.ListBox
	Public WithEvents btnEdit As System.Windows.Forms.Button
	Public WithEvents btnInsert As System.Windows.Forms.Button
	Public WithEvents btnCut As System.Windows.Forms.Button
	Public WithEvents lblAttached As System.Windows.Forms.Label
	Public WithEvents _fraItemProp_2 As System.Windows.Forms.Panel
	Public WithEvents txtRequiredLevel As System.Windows.Forms.TextBox
	Public WithEvents chkExamined As System.Windows.Forms.CheckBox
	Public WithEvents chkAllowOtherSize As System.Windows.Forms.CheckBox
	Public WithEvents _optSize_0 As System.Windows.Forms.RadioButton
	Public WithEvents _optSize_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optSize_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optSize_3 As System.Windows.Forms.RadioButton
	Public WithEvents _optSize_4 As System.Windows.Forms.RadioButton
	Public WithEvents fraSize As System.Windows.Forms.GroupBox
	Public WithEvents chkIsEquipped As System.Windows.Forms.CheckBox
	Public WithEvents cmbAmmo As System.Windows.Forms.ComboBox
	Public WithEvents txtDamageBonus As System.Windows.Forms.TextBox
	Public WithEvents cmbDamage As System.Windows.Forms.ComboBox
	Public WithEvents cmbDamageType As System.Windows.Forms.ComboBox
	Public WithEvents cmbFoodType As System.Windows.Forms.ComboBox
	Public WithEvents lblAmmo As System.Windows.Forms.Label
	Public WithEvents lblDamageBonus As System.Windows.Forms.Label
	Public WithEvents lblDamageType As System.Windows.Forms.Label
	Public WithEvents lblDamage As System.Windows.Forms.Label
	Public WithEvents _fraItem_1 As System.Windows.Forms.GroupBox
	Public WithEvents txtDefense As System.Windows.Forms.TextBox
	Public WithEvents txtAttackBonus As System.Windows.Forms.TextBox
	Public WithEvents txtActionPoints As System.Windows.Forms.TextBox
	Public WithEvents cmbRange As System.Windows.Forms.ComboBox
	Public WithEvents chkTwoHanded As System.Windows.Forms.CheckBox
	Public WithEvents txtArmor As System.Windows.Forms.TextBox
	Public WithEvents lblDefense As System.Windows.Forms.Label
	Public WithEvents lblAttackBonus As System.Windows.Forms.Label
	Public WithEvents lblActionPoints As System.Windows.Forms.Label
	Public WithEvents lblRange As System.Windows.Forms.Label
	Public WithEvents lblResistance As System.Windows.Forms.Label
	Public WithEvents _fraItem_0 As System.Windows.Forms.GroupBox
	Public WithEvents btnReGen As System.Windows.Forms.Button
	Public WithEvents _chkKey_3 As System.Windows.Forms.CheckBox
	Public WithEvents _chkKey_4 As System.Windows.Forms.CheckBox
	Public WithEvents _chkKey_5 As System.Windows.Forms.CheckBox
	Public WithEvents _chkKey_6 As System.Windows.Forms.CheckBox
	Public WithEvents _chkKey_7 As System.Windows.Forms.CheckBox
	Public WithEvents cmbFamily As System.Windows.Forms.ComboBox
	Public WithEvents cmbWearType As System.Windows.Forms.ComboBox
	Public WithEvents cmbResistanceType As System.Windows.Forms.ComboBox
	Public WithEvents cmbResistanceBonus As System.Windows.Forms.ComboBox
	Public WithEvents _Label1_1 As System.Windows.Forms.Label
	Public WithEvents _Label1_2 As System.Windows.Forms.Label
	Public WithEvents _Label1_12 As System.Windows.Forms.Label
	Public WithEvents _fraItem_2 As System.Windows.Forms.GroupBox
	Public WithEvents lblRequiredLevel As System.Windows.Forms.Label
	Public WithEvents lblKey As System.Windows.Forms.Label
	Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents _fraItemProp_1 As System.Windows.Forms.Panel
	Public WithEvents btnApply As System.Windows.Forms.Button
	Public WithEvents btnOk As System.Windows.Forms.Button
	Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents tabItemProp As AxComctlLib.AxTabStrip
	Public dlgFileOpen As System.Windows.Forms.OpenFileDialog
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents chkKey As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	Public WithEvents fraItem As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
	Public WithEvents fraItemProp As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
	Public WithEvents lblName As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents optSize As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmItem))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me._fraItemProp_0 = New System.Windows.Forms.Panel
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.chkSoftCapacity = New System.Windows.Forms.CheckBox
		Me.picItem = New System.Windows.Forms.PictureBox
		Me.txtBulk = New System.Windows.Forms.TextBox
		Me.txtCapacity = New System.Windows.Forms.TextBox
		Me.txtWeight = New System.Windows.Forms.TextBox
		Me.txtCount = New System.Windows.Forms.TextBox
		Me.txtValue = New System.Windows.Forms.TextBox
		Me.btnBrowse = New System.Windows.Forms.Button
		Me.btnBrowseLeft = New System.Windows.Forms.Button
		Me.btnBrowseRight = New System.Windows.Forms.Button
		Me._Label1_5 = New System.Windows.Forms.Label
		Me._Label1_6 = New System.Windows.Forms.Label
		Me._Label1_4 = New System.Windows.Forms.Label
		Me._Label1_7 = New System.Windows.Forms.Label
		Me._Label1_17 = New System.Windows.Forms.Label
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.chkCombine = New System.Windows.Forms.CheckBox
		Me.chkDescription = New System.Windows.Forms.CheckBox
		Me.txtComments = New System.Windows.Forms.TextBox
		Me.txtName = New System.Windows.Forms.TextBox
		Me._Label1_21 = New System.Windows.Forms.Label
		Me._lblName_1 = New System.Windows.Forms.Label
		Me._fraItemProp_2 = New System.Windows.Forms.Panel
		Me.btnLibrary = New System.Windows.Forms.Button
		Me.btnPaste = New System.Windows.Forms.Button
		Me.btnCopy = New System.Windows.Forms.Button
		Me.lstThings = New System.Windows.Forms.ListBox
		Me.btnEdit = New System.Windows.Forms.Button
		Me.btnInsert = New System.Windows.Forms.Button
		Me.btnCut = New System.Windows.Forms.Button
		Me.lblAttached = New System.Windows.Forms.Label
		Me._fraItemProp_1 = New System.Windows.Forms.Panel
		Me.txtRequiredLevel = New System.Windows.Forms.TextBox
		Me.chkExamined = New System.Windows.Forms.CheckBox
		Me.fraSize = New System.Windows.Forms.GroupBox
		Me.chkAllowOtherSize = New System.Windows.Forms.CheckBox
		Me._optSize_0 = New System.Windows.Forms.RadioButton
		Me._optSize_1 = New System.Windows.Forms.RadioButton
		Me._optSize_2 = New System.Windows.Forms.RadioButton
		Me._optSize_3 = New System.Windows.Forms.RadioButton
		Me._optSize_4 = New System.Windows.Forms.RadioButton
		Me.chkIsEquipped = New System.Windows.Forms.CheckBox
		Me._fraItem_1 = New System.Windows.Forms.GroupBox
		Me.cmbAmmo = New System.Windows.Forms.ComboBox
		Me.txtDamageBonus = New System.Windows.Forms.TextBox
		Me.cmbDamage = New System.Windows.Forms.ComboBox
		Me.cmbDamageType = New System.Windows.Forms.ComboBox
		Me.cmbFoodType = New System.Windows.Forms.ComboBox
		Me.lblAmmo = New System.Windows.Forms.Label
		Me.lblDamageBonus = New System.Windows.Forms.Label
		Me.lblDamageType = New System.Windows.Forms.Label
		Me.lblDamage = New System.Windows.Forms.Label
		Me._fraItem_0 = New System.Windows.Forms.GroupBox
		Me.txtDefense = New System.Windows.Forms.TextBox
		Me.txtAttackBonus = New System.Windows.Forms.TextBox
		Me.txtActionPoints = New System.Windows.Forms.TextBox
		Me.cmbRange = New System.Windows.Forms.ComboBox
		Me.chkTwoHanded = New System.Windows.Forms.CheckBox
		Me.txtArmor = New System.Windows.Forms.TextBox
		Me.lblDefense = New System.Windows.Forms.Label
		Me.lblAttackBonus = New System.Windows.Forms.Label
		Me.lblActionPoints = New System.Windows.Forms.Label
		Me.lblRange = New System.Windows.Forms.Label
		Me.lblResistance = New System.Windows.Forms.Label
		Me.btnReGen = New System.Windows.Forms.Button
		Me._chkKey_3 = New System.Windows.Forms.CheckBox
		Me._chkKey_4 = New System.Windows.Forms.CheckBox
		Me._chkKey_5 = New System.Windows.Forms.CheckBox
		Me._chkKey_6 = New System.Windows.Forms.CheckBox
		Me._chkKey_7 = New System.Windows.Forms.CheckBox
		Me.cmbFamily = New System.Windows.Forms.ComboBox
		Me._fraItem_2 = New System.Windows.Forms.GroupBox
		Me.cmbWearType = New System.Windows.Forms.ComboBox
		Me.cmbResistanceType = New System.Windows.Forms.ComboBox
		Me.cmbResistanceBonus = New System.Windows.Forms.ComboBox
		Me._Label1_1 = New System.Windows.Forms.Label
		Me._Label1_2 = New System.Windows.Forms.Label
		Me._Label1_12 = New System.Windows.Forms.Label
		Me.lblRequiredLevel = New System.Windows.Forms.Label
		Me.lblKey = New System.Windows.Forms.Label
		Me._Label1_0 = New System.Windows.Forms.Label
		Me.btnApply = New System.Windows.Forms.Button
		Me.btnOk = New System.Windows.Forms.Button
		Me.btnCancel = New System.Windows.Forms.Button
		Me.tabItemProp = New AxComctlLib.AxTabStrip
		Me.dlgFileOpen = New System.Windows.Forms.OpenFileDialog
		Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.chkKey = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(components)
		Me.fraItem = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(components)
		Me.fraItemProp = New Microsoft.VisualBasic.Compatibility.VB6.PanelArray(components)
		Me.lblName = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.optSize = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me._fraItemProp_0.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me._fraItemProp_2.SuspendLayout()
		Me._fraItemProp_1.SuspendLayout()
		Me.fraSize.SuspendLayout()
		Me._fraItem_1.SuspendLayout()
		Me._fraItem_0.SuspendLayout()
		Me._fraItem_2.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tabItemProp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.chkKey, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.fraItem, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.fraItemProp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optSize, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Item Properties"
		Me.ClientSize = New System.Drawing.Size(416, 267)
		Me.Location = New System.Drawing.Point(217, 199)
		Me.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Icon = CType(resources.GetObject("frmItem.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmItem"
		Me._fraItemProp_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._fraItemProp_0.Size = New System.Drawing.Size(397, 197)
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
		Me.Frame2.Text = "Attributes"
		Me.Frame2.Size = New System.Drawing.Size(141, 193)
		Me.Frame2.Location = New System.Drawing.Point(252, 0)
		Me.Frame2.TabIndex = 59
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.chkSoftCapacity.Text = "Soft"
		Me.chkSoftCapacity.Size = New System.Drawing.Size(41, 13)
		Me.chkSoftCapacity.Location = New System.Drawing.Point(8, 140)
		Me.chkSoftCapacity.TabIndex = 74
		Me.chkSoftCapacity.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkSoftCapacity.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkSoftCapacity.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkSoftCapacity.BackColor = System.Drawing.SystemColors.Control
		Me.chkSoftCapacity.CausesValidation = True
		Me.chkSoftCapacity.Enabled = True
		Me.chkSoftCapacity.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkSoftCapacity.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkSoftCapacity.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkSoftCapacity.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkSoftCapacity.TabStop = True
		Me.chkSoftCapacity.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkSoftCapacity.Visible = True
		Me.chkSoftCapacity.Name = "chkSoftCapacity"
		Me.picItem.BackColor = System.Drawing.Color.FromARGB(128, 128, 128)
		Me.picItem.Size = New System.Drawing.Size(68, 100)
		Me.picItem.Location = New System.Drawing.Point(59, 59)
		Me.picItem.TabIndex = 73
		Me.picItem.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picItem.Dock = System.Windows.Forms.DockStyle.None
		Me.picItem.CausesValidation = True
		Me.picItem.Enabled = True
		Me.picItem.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picItem.Cursor = System.Windows.Forms.Cursors.Default
		Me.picItem.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picItem.TabStop = True
		Me.picItem.Visible = True
		Me.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picItem.Name = "picItem"
		Me.txtBulk.AutoSize = False
		Me.txtBulk.Size = New System.Drawing.Size(37, 19)
		Me.txtBulk.Location = New System.Drawing.Point(8, 112)
		Me.txtBulk.Maxlength = 5
		Me.txtBulk.TabIndex = 67
		Me.txtBulk.Text = "99999"
		Me.txtBulk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtBulk.AcceptsReturn = True
		Me.txtBulk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtBulk.BackColor = System.Drawing.SystemColors.Window
		Me.txtBulk.CausesValidation = True
		Me.txtBulk.Enabled = True
		Me.txtBulk.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtBulk.HideSelection = True
		Me.txtBulk.ReadOnly = False
		Me.txtBulk.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtBulk.MultiLine = False
		Me.txtBulk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtBulk.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtBulk.TabStop = True
		Me.txtBulk.Visible = True
		Me.txtBulk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtBulk.Name = "txtBulk"
		Me.txtCapacity.AutoSize = False
		Me.txtCapacity.Size = New System.Drawing.Size(37, 19)
		Me.txtCapacity.Location = New System.Drawing.Point(96, 32)
		Me.txtCapacity.Maxlength = 5
		Me.txtCapacity.TabIndex = 66
		Me.txtCapacity.Text = "99999"
		Me.txtCapacity.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCapacity.AcceptsReturn = True
		Me.txtCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCapacity.BackColor = System.Drawing.SystemColors.Window
		Me.txtCapacity.CausesValidation = True
		Me.txtCapacity.Enabled = True
		Me.txtCapacity.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCapacity.HideSelection = True
		Me.txtCapacity.ReadOnly = False
		Me.txtCapacity.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCapacity.MultiLine = False
		Me.txtCapacity.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCapacity.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCapacity.TabStop = True
		Me.txtCapacity.Visible = True
		Me.txtCapacity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCapacity.Name = "txtCapacity"
		Me.txtWeight.AutoSize = False
		Me.txtWeight.Size = New System.Drawing.Size(37, 19)
		Me.txtWeight.Location = New System.Drawing.Point(8, 72)
		Me.txtWeight.Maxlength = 5
		Me.txtWeight.TabIndex = 65
		Me.txtWeight.Text = "99999"
		Me.txtWeight.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtWeight.AcceptsReturn = True
		Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtWeight.BackColor = System.Drawing.SystemColors.Window
		Me.txtWeight.CausesValidation = True
		Me.txtWeight.Enabled = True
		Me.txtWeight.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtWeight.HideSelection = True
		Me.txtWeight.ReadOnly = False
		Me.txtWeight.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtWeight.MultiLine = False
		Me.txtWeight.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtWeight.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtWeight.TabStop = True
		Me.txtWeight.Visible = True
		Me.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtWeight.Name = "txtWeight"
		Me.txtCount.AutoSize = False
		Me.txtCount.Size = New System.Drawing.Size(37, 19)
		Me.txtCount.Location = New System.Drawing.Point(52, 32)
		Me.txtCount.Maxlength = 5
		Me.txtCount.TabIndex = 64
		Me.txtCount.Text = "99999"
		Me.txtCount.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCount.AcceptsReturn = True
		Me.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCount.BackColor = System.Drawing.SystemColors.Window
		Me.txtCount.CausesValidation = True
		Me.txtCount.Enabled = True
		Me.txtCount.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCount.HideSelection = True
		Me.txtCount.ReadOnly = False
		Me.txtCount.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCount.MultiLine = False
		Me.txtCount.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCount.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCount.TabStop = True
		Me.txtCount.Visible = True
		Me.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCount.Name = "txtCount"
		Me.txtValue.AutoSize = False
		Me.txtValue.Size = New System.Drawing.Size(37, 19)
		Me.txtValue.Location = New System.Drawing.Point(9, 32)
		Me.txtValue.Maxlength = 5
		Me.txtValue.TabIndex = 63
		Me.txtValue.Text = "99999"
		Me.txtValue.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtValue.AcceptsReturn = True
		Me.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtValue.BackColor = System.Drawing.SystemColors.Window
		Me.txtValue.CausesValidation = True
		Me.txtValue.Enabled = True
		Me.txtValue.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtValue.HideSelection = True
		Me.txtValue.ReadOnly = False
		Me.txtValue.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtValue.MultiLine = False
		Me.txtValue.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtValue.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtValue.TabStop = True
		Me.txtValue.Visible = True
		Me.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtValue.Name = "txtValue"
		Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnBrowse.BackColor = System.Drawing.SystemColors.Control
		Me.btnBrowse.Text = "Browse..."
		Me.btnBrowse.Size = New System.Drawing.Size(73, 21)
		Me.btnBrowse.Location = New System.Drawing.Point(35, 164)
		Me.btnBrowse.TabIndex = 62
		Me.btnBrowse.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBrowse.CausesValidation = True
		Me.btnBrowse.Enabled = True
		Me.btnBrowse.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnBrowse.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnBrowse.TabStop = True
		Me.btnBrowse.Name = "btnBrowse"
		Me.btnBrowseLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnBrowseLeft.Text = "<"
		Me.btnBrowseLeft.Size = New System.Drawing.Size(19, 21)
		Me.btnBrowseLeft.Location = New System.Drawing.Point(15, 164)
		Me.btnBrowseLeft.TabIndex = 61
		Me.btnBrowseLeft.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBrowseLeft.BackColor = System.Drawing.SystemColors.Control
		Me.btnBrowseLeft.CausesValidation = True
		Me.btnBrowseLeft.Enabled = True
		Me.btnBrowseLeft.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnBrowseLeft.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnBrowseLeft.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnBrowseLeft.TabStop = True
		Me.btnBrowseLeft.Name = "btnBrowseLeft"
		Me.btnBrowseRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnBrowseRight.Text = ">"
		Me.btnBrowseRight.Size = New System.Drawing.Size(19, 21)
		Me.btnBrowseRight.Location = New System.Drawing.Point(109, 164)
		Me.btnBrowseRight.TabIndex = 60
		Me.btnBrowseRight.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBrowseRight.BackColor = System.Drawing.SystemColors.Control
		Me.btnBrowseRight.CausesValidation = True
		Me.btnBrowseRight.Enabled = True
		Me.btnBrowseRight.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnBrowseRight.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnBrowseRight.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnBrowseRight.TabStop = True
		Me.btnBrowseRight.Name = "btnBrowseRight"
		Me._Label1_5.BackColor = System.Drawing.Color.Transparent
		Me._Label1_5.Text = "Bulk"
		Me._Label1_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_5.Size = New System.Drawing.Size(45, 13)
		Me._Label1_5.Location = New System.Drawing.Point(8, 96)
		Me._Label1_5.TabIndex = 72
		Me._Label1_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_5.Enabled = True
		Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_5.UseMnemonic = True
		Me._Label1_5.Visible = True
		Me._Label1_5.AutoSize = False
		Me._Label1_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_5.Name = "_Label1_5"
		Me._Label1_6.BackColor = System.Drawing.Color.Transparent
		Me._Label1_6.Text = "Capacity"
		Me._Label1_6.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_6.Size = New System.Drawing.Size(45, 13)
		Me._Label1_6.Location = New System.Drawing.Point(92, 16)
		Me._Label1_6.TabIndex = 71
		Me._Label1_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_6.Enabled = True
		Me._Label1_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_6.UseMnemonic = True
		Me._Label1_6.Visible = True
		Me._Label1_6.AutoSize = False
		Me._Label1_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_6.Name = "_Label1_6"
		Me._Label1_4.BackColor = System.Drawing.Color.Transparent
		Me._Label1_4.Text = "Weight"
		Me._Label1_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_4.Size = New System.Drawing.Size(45, 13)
		Me._Label1_4.Location = New System.Drawing.Point(8, 56)
		Me._Label1_4.TabIndex = 70
		Me._Label1_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_4.Enabled = True
		Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_4.UseMnemonic = True
		Me._Label1_4.Visible = True
		Me._Label1_4.AutoSize = False
		Me._Label1_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_4.Name = "_Label1_4"
		Me._Label1_7.BackColor = System.Drawing.Color.Transparent
		Me._Label1_7.Text = "Count"
		Me._Label1_7.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_7.Size = New System.Drawing.Size(41, 13)
		Me._Label1_7.Location = New System.Drawing.Point(52, 16)
		Me._Label1_7.TabIndex = 69
		Me._Label1_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_7.Enabled = True
		Me._Label1_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_7.UseMnemonic = True
		Me._Label1_7.Visible = True
		Me._Label1_7.AutoSize = False
		Me._Label1_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_7.Name = "_Label1_7"
		Me._Label1_17.BackColor = System.Drawing.Color.Transparent
		Me._Label1_17.Text = "Value"
		Me._Label1_17.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_17.Size = New System.Drawing.Size(37, 13)
		Me._Label1_17.Location = New System.Drawing.Point(9, 16)
		Me._Label1_17.TabIndex = 68
		Me._Label1_17.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_17.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_17.Enabled = True
		Me._Label1_17.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_17.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_17.UseMnemonic = True
		Me._Label1_17.Visible = True
		Me._Label1_17.AutoSize = False
		Me._Label1_17.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_17.Name = "_Label1_17"
		Me.Frame1.Text = "Description"
		Me.Frame1.Size = New System.Drawing.Size(241, 193)
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
		Me.chkCombine.Text = "Can combine"
		Me.chkCombine.Size = New System.Drawing.Size(93, 13)
		Me.chkCombine.Location = New System.Drawing.Point(124, 16)
		Me.chkCombine.TabIndex = 18
		Me.chkCombine.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkCombine.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkCombine.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkCombine.BackColor = System.Drawing.SystemColors.Control
		Me.chkCombine.CausesValidation = True
		Me.chkCombine.Enabled = True
		Me.chkCombine.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkCombine.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkCombine.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkCombine.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkCombine.TabStop = True
		Me.chkCombine.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkCombine.Visible = True
		Me.chkCombine.Name = "chkCombine"
		Me.chkDescription.Text = "Use as Description"
		Me.chkDescription.Size = New System.Drawing.Size(109, 13)
		Me.chkDescription.Location = New System.Drawing.Point(124, 56)
		Me.chkDescription.TabIndex = 8
		Me.chkDescription.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkDescription.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkDescription.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkDescription.BackColor = System.Drawing.SystemColors.Control
		Me.chkDescription.CausesValidation = True
		Me.chkDescription.Enabled = True
		Me.chkDescription.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkDescription.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkDescription.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkDescription.TabStop = True
		Me.chkDescription.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkDescription.Visible = True
		Me.chkDescription.Name = "chkDescription"
		Me.txtComments.AutoSize = False
		Me.txtComments.Size = New System.Drawing.Size(225, 113)
		Me.txtComments.Location = New System.Drawing.Point(8, 72)
		Me.txtComments.MultiLine = True
		Me.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtComments.TabIndex = 7
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
		Me.txtName.Size = New System.Drawing.Size(227, 19)
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
		Me._Label1_21.Text = "Comments"
		Me._Label1_21.Size = New System.Drawing.Size(81, 13)
		Me._Label1_21.Location = New System.Drawing.Point(8, 56)
		Me._Label1_21.TabIndex = 10
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
		Me._lblName_1.Text = "Name"
		Me._lblName_1.Size = New System.Drawing.Size(41, 13)
		Me._lblName_1.Location = New System.Drawing.Point(8, 16)
		Me._lblName_1.TabIndex = 9
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
		Me._fraItemProp_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._fraItemProp_2.Size = New System.Drawing.Size(397, 197)
		Me._fraItemProp_2.Location = New System.Drawing.Point(8, 28)
		Me._fraItemProp_2.TabIndex = 12
		Me._fraItemProp_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraItemProp_2.BackColor = System.Drawing.SystemColors.Control
		Me._fraItemProp_2.Enabled = True
		Me._fraItemProp_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraItemProp_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._fraItemProp_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraItemProp_2.Visible = True
		Me._fraItemProp_2.Name = "_fraItemProp_2"
		Me.btnLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnLibrary.Text = "Insert trigger from library"
		Me.btnLibrary.Size = New System.Drawing.Size(73, 49)
		Me.btnLibrary.Location = New System.Drawing.Point(320, 40)
		Me.btnLibrary.TabIndex = 86
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
		Me.btnPaste.Location = New System.Drawing.Point(320, 168)
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
		Me.btnCopy.Location = New System.Drawing.Point(320, 144)
		Me.btnCopy.TabIndex = 19
		Me.btnCopy.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCopy.CausesValidation = True
		Me.btnCopy.Enabled = True
		Me.btnCopy.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCopy.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCopy.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCopy.TabStop = True
		Me.btnCopy.Name = "btnCopy"
		Me.lstThings.Size = New System.Drawing.Size(309, 163)
		Me.lstThings.Location = New System.Drawing.Point(4, 24)
		Me.lstThings.TabIndex = 16
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
		Me.btnEdit.Location = New System.Drawing.Point(320, 92)
		Me.btnEdit.TabIndex = 15
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
		Me.btnInsert.Location = New System.Drawing.Point(320, 16)
		Me.btnInsert.TabIndex = 14
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
		Me.btnCut.Location = New System.Drawing.Point(320, 120)
		Me.btnCut.TabIndex = 13
		Me.btnCut.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCut.CausesValidation = True
		Me.btnCut.Enabled = True
		Me.btnCut.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCut.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCut.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCut.TabStop = True
		Me.btnCut.Name = "btnCut"
		Me.lblAttached.Text = "Triggers Attached to Item"
		Me.lblAttached.Size = New System.Drawing.Size(289, 13)
		Me.lblAttached.Location = New System.Drawing.Point(4, 4)
		Me.lblAttached.TabIndex = 17
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
		Me._fraItemProp_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._fraItemProp_1.Size = New System.Drawing.Size(397, 197)
		Me._fraItemProp_1.Location = New System.Drawing.Point(8, 28)
		Me._fraItemProp_1.TabIndex = 11
		Me._fraItemProp_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraItemProp_1.BackColor = System.Drawing.SystemColors.Control
		Me._fraItemProp_1.Enabled = True
		Me._fraItemProp_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraItemProp_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._fraItemProp_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraItemProp_1.Visible = True
		Me._fraItemProp_1.Name = "_fraItemProp_1"
		Me.txtRequiredLevel.AutoSize = False
		Me.txtRequiredLevel.Size = New System.Drawing.Size(25, 19)
		Me.txtRequiredLevel.Location = New System.Drawing.Point(216, 4)
		Me.txtRequiredLevel.TabIndex = 84
		Me.txtRequiredLevel.Text = "1"
		Me.txtRequiredLevel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRequiredLevel.AcceptsReturn = True
		Me.txtRequiredLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtRequiredLevel.BackColor = System.Drawing.SystemColors.Window
		Me.txtRequiredLevel.CausesValidation = True
		Me.txtRequiredLevel.Enabled = True
		Me.txtRequiredLevel.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtRequiredLevel.HideSelection = True
		Me.txtRequiredLevel.ReadOnly = False
		Me.txtRequiredLevel.Maxlength = 0
		Me.txtRequiredLevel.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtRequiredLevel.MultiLine = False
		Me.txtRequiredLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtRequiredLevel.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtRequiredLevel.TabStop = True
		Me.txtRequiredLevel.Visible = True
		Me.txtRequiredLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtRequiredLevel.Name = "txtRequiredLevel"
		Me.chkExamined.Text = "Known?"
		Me.chkExamined.Size = New System.Drawing.Size(65, 17)
		Me.chkExamined.Location = New System.Drawing.Point(336, 8)
		Me.chkExamined.TabIndex = 82
		Me.chkExamined.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkExamined.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkExamined.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkExamined.BackColor = System.Drawing.SystemColors.Control
		Me.chkExamined.CausesValidation = True
		Me.chkExamined.Enabled = True
		Me.chkExamined.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkExamined.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkExamined.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkExamined.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkExamined.TabStop = True
		Me.chkExamined.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkExamined.Visible = True
		Me.chkExamined.Name = "chkExamined"
		Me.fraSize.Text = "Size"
		Me.fraSize.Size = New System.Drawing.Size(99, 161)
		Me.fraSize.Location = New System.Drawing.Point(296, 32)
		Me.fraSize.TabIndex = 75
		Me.fraSize.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraSize.BackColor = System.Drawing.SystemColors.Control
		Me.fraSize.Enabled = True
		Me.fraSize.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraSize.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraSize.Visible = True
		Me.fraSize.Padding = New System.Windows.Forms.Padding(0)
		Me.fraSize.Name = "fraSize"
		Me.chkAllowOtherSize.Text = "Any size can use"
		Me.chkAllowOtherSize.Size = New System.Drawing.Size(81, 25)
		Me.chkAllowOtherSize.Location = New System.Drawing.Point(8, 128)
		Me.chkAllowOtherSize.TabIndex = 81
		Me.chkAllowOtherSize.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkAllowOtherSize.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkAllowOtherSize.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkAllowOtherSize.BackColor = System.Drawing.SystemColors.Control
		Me.chkAllowOtherSize.CausesValidation = True
		Me.chkAllowOtherSize.Enabled = True
		Me.chkAllowOtherSize.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkAllowOtherSize.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkAllowOtherSize.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkAllowOtherSize.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkAllowOtherSize.TabStop = True
		Me.chkAllowOtherSize.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkAllowOtherSize.Visible = True
		Me.chkAllowOtherSize.Name = "chkAllowOtherSize"
		Me._optSize_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSize_0.Text = "Tiny"
		Me._optSize_0.Size = New System.Drawing.Size(73, 17)
		Me._optSize_0.Location = New System.Drawing.Point(8, 16)
		Me._optSize_0.TabIndex = 80
		Me._optSize_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optSize_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSize_0.BackColor = System.Drawing.SystemColors.Control
		Me._optSize_0.CausesValidation = True
		Me._optSize_0.Enabled = True
		Me._optSize_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optSize_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optSize_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optSize_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optSize_0.TabStop = True
		Me._optSize_0.Checked = False
		Me._optSize_0.Visible = True
		Me._optSize_0.Name = "_optSize_0"
		Me._optSize_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSize_1.Text = "Small"
		Me._optSize_1.Size = New System.Drawing.Size(73, 17)
		Me._optSize_1.Location = New System.Drawing.Point(8, 34)
		Me._optSize_1.TabIndex = 79
		Me._optSize_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optSize_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSize_1.BackColor = System.Drawing.SystemColors.Control
		Me._optSize_1.CausesValidation = True
		Me._optSize_1.Enabled = True
		Me._optSize_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optSize_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optSize_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optSize_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optSize_1.TabStop = True
		Me._optSize_1.Checked = False
		Me._optSize_1.Visible = True
		Me._optSize_1.Name = "_optSize_1"
		Me._optSize_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSize_2.Text = "Medium"
		Me._optSize_2.Size = New System.Drawing.Size(73, 17)
		Me._optSize_2.Location = New System.Drawing.Point(8, 54)
		Me._optSize_2.TabIndex = 78
		Me._optSize_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optSize_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSize_2.BackColor = System.Drawing.SystemColors.Control
		Me._optSize_2.CausesValidation = True
		Me._optSize_2.Enabled = True
		Me._optSize_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optSize_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._optSize_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optSize_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optSize_2.TabStop = True
		Me._optSize_2.Checked = False
		Me._optSize_2.Visible = True
		Me._optSize_2.Name = "_optSize_2"
		Me._optSize_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSize_3.Text = "Large"
		Me._optSize_3.Size = New System.Drawing.Size(73, 17)
		Me._optSize_3.Location = New System.Drawing.Point(8, 74)
		Me._optSize_3.TabIndex = 77
		Me._optSize_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optSize_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSize_3.BackColor = System.Drawing.SystemColors.Control
		Me._optSize_3.CausesValidation = True
		Me._optSize_3.Enabled = True
		Me._optSize_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optSize_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._optSize_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optSize_3.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optSize_3.TabStop = True
		Me._optSize_3.Checked = False
		Me._optSize_3.Visible = True
		Me._optSize_3.Name = "_optSize_3"
		Me._optSize_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSize_4.Text = "Huge"
		Me._optSize_4.Size = New System.Drawing.Size(73, 17)
		Me._optSize_4.Location = New System.Drawing.Point(8, 94)
		Me._optSize_4.TabIndex = 76
		Me._optSize_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optSize_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSize_4.BackColor = System.Drawing.SystemColors.Control
		Me._optSize_4.CausesValidation = True
		Me._optSize_4.Enabled = True
		Me._optSize_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optSize_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._optSize_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optSize_4.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optSize_4.TabStop = True
		Me._optSize_4.Checked = False
		Me._optSize_4.Visible = True
		Me._optSize_4.Name = "_optSize_4"
		Me.chkIsEquipped.Text = "Equipped?"
		Me.chkIsEquipped.Size = New System.Drawing.Size(85, 13)
		Me.chkIsEquipped.Location = New System.Drawing.Point(256, 8)
		Me.chkIsEquipped.TabIndex = 58
		Me.chkIsEquipped.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkIsEquipped.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkIsEquipped.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkIsEquipped.BackColor = System.Drawing.SystemColors.Control
		Me.chkIsEquipped.CausesValidation = True
		Me.chkIsEquipped.Enabled = True
		Me.chkIsEquipped.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkIsEquipped.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkIsEquipped.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkIsEquipped.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkIsEquipped.TabStop = True
		Me.chkIsEquipped.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkIsEquipped.Visible = True
		Me.chkIsEquipped.Name = "chkIsEquipped"
		Me._fraItem_1.Text = "Damage"
		Me._fraItem_1.Size = New System.Drawing.Size(133, 161)
		Me._fraItem_1.Location = New System.Drawing.Point(160, 32)
		Me._fraItem_1.TabIndex = 40
		Me._fraItem_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraItem_1.BackColor = System.Drawing.SystemColors.Control
		Me._fraItem_1.Enabled = True
		Me._fraItem_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraItem_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraItem_1.Visible = True
		Me._fraItem_1.Padding = New System.Windows.Forms.Padding(0)
		Me._fraItem_1.Name = "_fraItem_1"
		Me.cmbAmmo.Size = New System.Drawing.Size(116, 21)
		Me.cmbAmmo.Location = New System.Drawing.Point(8, 128)
		Me.cmbAmmo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbAmmo.TabIndex = 47
		Me.cmbAmmo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbAmmo.BackColor = System.Drawing.SystemColors.Window
		Me.cmbAmmo.CausesValidation = True
		Me.cmbAmmo.Enabled = True
		Me.cmbAmmo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbAmmo.IntegralHeight = True
		Me.cmbAmmo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbAmmo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbAmmo.Sorted = False
		Me.cmbAmmo.TabStop = True
		Me.cmbAmmo.Visible = True
		Me.cmbAmmo.Name = "cmbAmmo"
		Me.txtDamageBonus.AutoSize = False
		Me.txtDamageBonus.Size = New System.Drawing.Size(25, 19)
		Me.txtDamageBonus.Location = New System.Drawing.Point(100, 88)
		Me.txtDamageBonus.TabIndex = 43
		Me.txtDamageBonus.Text = "999"
		Me.txtDamageBonus.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDamageBonus.AcceptsReturn = True
		Me.txtDamageBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDamageBonus.BackColor = System.Drawing.SystemColors.Window
		Me.txtDamageBonus.CausesValidation = True
		Me.txtDamageBonus.Enabled = True
		Me.txtDamageBonus.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDamageBonus.HideSelection = True
		Me.txtDamageBonus.ReadOnly = False
		Me.txtDamageBonus.Maxlength = 0
		Me.txtDamageBonus.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDamageBonus.MultiLine = False
		Me.txtDamageBonus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDamageBonus.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDamageBonus.TabStop = True
		Me.txtDamageBonus.Visible = True
		Me.txtDamageBonus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDamageBonus.Name = "txtDamageBonus"
		Me.cmbDamage.Size = New System.Drawing.Size(65, 21)
		Me.cmbDamage.Location = New System.Drawing.Point(60, 60)
		Me.cmbDamage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbDamage.TabIndex = 42
		Me.cmbDamage.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbDamage.BackColor = System.Drawing.SystemColors.Window
		Me.cmbDamage.CausesValidation = True
		Me.cmbDamage.Enabled = True
		Me.cmbDamage.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbDamage.IntegralHeight = True
		Me.cmbDamage.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbDamage.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbDamage.Sorted = False
		Me.cmbDamage.TabStop = True
		Me.cmbDamage.Visible = True
		Me.cmbDamage.Name = "cmbDamage"
		Me.cmbDamageType.Size = New System.Drawing.Size(116, 21)
		Me.cmbDamageType.Location = New System.Drawing.Point(8, 32)
		Me.cmbDamageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbDamageType.TabIndex = 41
		Me.cmbDamageType.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbDamageType.BackColor = System.Drawing.SystemColors.Window
		Me.cmbDamageType.CausesValidation = True
		Me.cmbDamageType.Enabled = True
		Me.cmbDamageType.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbDamageType.IntegralHeight = True
		Me.cmbDamageType.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbDamageType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbDamageType.Sorted = False
		Me.cmbDamageType.TabStop = True
		Me.cmbDamageType.Visible = True
		Me.cmbDamageType.Name = "cmbDamageType"
		Me.cmbFoodType.Size = New System.Drawing.Size(116, 21)
		Me.cmbFoodType.Location = New System.Drawing.Point(8, 32)
		Me.cmbFoodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbFoodType.TabIndex = 85
		Me.cmbFoodType.Visible = False
		Me.cmbFoodType.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbFoodType.BackColor = System.Drawing.SystemColors.Window
		Me.cmbFoodType.CausesValidation = True
		Me.cmbFoodType.Enabled = True
		Me.cmbFoodType.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbFoodType.IntegralHeight = True
		Me.cmbFoodType.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbFoodType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbFoodType.Sorted = False
		Me.cmbFoodType.TabStop = True
		Me.cmbFoodType.Name = "cmbFoodType"
		Me.lblAmmo.BackColor = System.Drawing.Color.Transparent
		Me.lblAmmo.Text = "Ammo Type"
		Me.lblAmmo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lblAmmo.Size = New System.Drawing.Size(113, 13)
		Me.lblAmmo.Location = New System.Drawing.Point(8, 112)
		Me.lblAmmo.TabIndex = 48
		Me.lblAmmo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAmmo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAmmo.Enabled = True
		Me.lblAmmo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAmmo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAmmo.UseMnemonic = True
		Me.lblAmmo.Visible = True
		Me.lblAmmo.AutoSize = False
		Me.lblAmmo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAmmo.Name = "lblAmmo"
		Me.lblDamageBonus.BackColor = System.Drawing.Color.Transparent
		Me.lblDamageBonus.Text = "Damage Bonus"
		Me.lblDamageBonus.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lblDamageBonus.Size = New System.Drawing.Size(83, 13)
		Me.lblDamageBonus.Location = New System.Drawing.Point(8, 92)
		Me.lblDamageBonus.TabIndex = 46
		Me.lblDamageBonus.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDamageBonus.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDamageBonus.Enabled = True
		Me.lblDamageBonus.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDamageBonus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDamageBonus.UseMnemonic = True
		Me.lblDamageBonus.Visible = True
		Me.lblDamageBonus.AutoSize = False
		Me.lblDamageBonus.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDamageBonus.Name = "lblDamageBonus"
		Me.lblDamageType.BackColor = System.Drawing.Color.Transparent
		Me.lblDamageType.Text = "Damage Type"
		Me.lblDamageType.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lblDamageType.Size = New System.Drawing.Size(113, 13)
		Me.lblDamageType.Location = New System.Drawing.Point(8, 16)
		Me.lblDamageType.TabIndex = 45
		Me.lblDamageType.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDamageType.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDamageType.Enabled = True
		Me.lblDamageType.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDamageType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDamageType.UseMnemonic = True
		Me.lblDamageType.Visible = True
		Me.lblDamageType.AutoSize = False
		Me.lblDamageType.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDamageType.Name = "lblDamageType"
		Me.lblDamage.BackColor = System.Drawing.Color.Transparent
		Me.lblDamage.Text = "Damage"
		Me.lblDamage.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lblDamage.Size = New System.Drawing.Size(43, 13)
		Me.lblDamage.Location = New System.Drawing.Point(8, 63)
		Me.lblDamage.TabIndex = 44
		Me.lblDamage.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDamage.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDamage.Enabled = True
		Me.lblDamage.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDamage.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDamage.UseMnemonic = True
		Me.lblDamage.Visible = True
		Me.lblDamage.AutoSize = False
		Me.lblDamage.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDamage.Name = "lblDamage"
		Me._fraItem_0.Text = "Attack"
		Me._fraItem_0.Size = New System.Drawing.Size(141, 161)
		Me._fraItem_0.Location = New System.Drawing.Point(8, 32)
		Me._fraItem_0.TabIndex = 30
		Me._fraItem_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraItem_0.BackColor = System.Drawing.SystemColors.Control
		Me._fraItem_0.Enabled = True
		Me._fraItem_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraItem_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraItem_0.Visible = True
		Me._fraItem_0.Padding = New System.Windows.Forms.Padding(0)
		Me._fraItem_0.Name = "_fraItem_0"
		Me.txtDefense.AutoSize = False
		Me.txtDefense.Size = New System.Drawing.Size(25, 19)
		Me.txtDefense.Location = New System.Drawing.Point(104, 64)
		Me.txtDefense.Maxlength = 3
		Me.txtDefense.TabIndex = 35
		Me.txtDefense.Text = "999"
		Me.txtDefense.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDefense.AcceptsReturn = True
		Me.txtDefense.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDefense.BackColor = System.Drawing.SystemColors.Window
		Me.txtDefense.CausesValidation = True
		Me.txtDefense.Enabled = True
		Me.txtDefense.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDefense.HideSelection = True
		Me.txtDefense.ReadOnly = False
		Me.txtDefense.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDefense.MultiLine = False
		Me.txtDefense.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDefense.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDefense.TabStop = True
		Me.txtDefense.Visible = True
		Me.txtDefense.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDefense.Name = "txtDefense"
		Me.txtAttackBonus.AutoSize = False
		Me.txtAttackBonus.Size = New System.Drawing.Size(25, 19)
		Me.txtAttackBonus.Location = New System.Drawing.Point(104, 40)
		Me.txtAttackBonus.TabIndex = 34
		Me.txtAttackBonus.Text = "999"
		Me.txtAttackBonus.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAttackBonus.AcceptsReturn = True
		Me.txtAttackBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtAttackBonus.BackColor = System.Drawing.SystemColors.Window
		Me.txtAttackBonus.CausesValidation = True
		Me.txtAttackBonus.Enabled = True
		Me.txtAttackBonus.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtAttackBonus.HideSelection = True
		Me.txtAttackBonus.ReadOnly = False
		Me.txtAttackBonus.Maxlength = 0
		Me.txtAttackBonus.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtAttackBonus.MultiLine = False
		Me.txtAttackBonus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtAttackBonus.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtAttackBonus.TabStop = True
		Me.txtAttackBonus.Visible = True
		Me.txtAttackBonus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtAttackBonus.Name = "txtAttackBonus"
		Me.txtActionPoints.AutoSize = False
		Me.txtActionPoints.Size = New System.Drawing.Size(25, 19)
		Me.txtActionPoints.Location = New System.Drawing.Point(104, 16)
		Me.txtActionPoints.Maxlength = 3
		Me.txtActionPoints.TabIndex = 33
		Me.txtActionPoints.Text = "999"
		Me.txtActionPoints.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtActionPoints.AcceptsReturn = True
		Me.txtActionPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtActionPoints.BackColor = System.Drawing.SystemColors.Window
		Me.txtActionPoints.CausesValidation = True
		Me.txtActionPoints.Enabled = True
		Me.txtActionPoints.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtActionPoints.HideSelection = True
		Me.txtActionPoints.ReadOnly = False
		Me.txtActionPoints.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtActionPoints.MultiLine = False
		Me.txtActionPoints.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtActionPoints.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtActionPoints.TabStop = True
		Me.txtActionPoints.Visible = True
		Me.txtActionPoints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtActionPoints.Name = "txtActionPoints"
		Me.cmbRange.Size = New System.Drawing.Size(116, 21)
		Me.cmbRange.Location = New System.Drawing.Point(12, 104)
		Me.cmbRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbRange.TabIndex = 32
		Me.cmbRange.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbRange.BackColor = System.Drawing.SystemColors.Window
		Me.cmbRange.CausesValidation = True
		Me.cmbRange.Enabled = True
		Me.cmbRange.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbRange.IntegralHeight = True
		Me.cmbRange.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbRange.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbRange.Sorted = False
		Me.cmbRange.TabStop = True
		Me.cmbRange.Visible = True
		Me.cmbRange.Name = "cmbRange"
		Me.chkTwoHanded.Text = "Requires two hands?"
		Me.chkTwoHanded.Size = New System.Drawing.Size(121, 13)
		Me.chkTwoHanded.Location = New System.Drawing.Point(12, 136)
		Me.chkTwoHanded.TabIndex = 31
		Me.chkTwoHanded.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkTwoHanded.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkTwoHanded.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkTwoHanded.BackColor = System.Drawing.SystemColors.Control
		Me.chkTwoHanded.CausesValidation = True
		Me.chkTwoHanded.Enabled = True
		Me.chkTwoHanded.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkTwoHanded.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkTwoHanded.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkTwoHanded.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkTwoHanded.TabStop = True
		Me.chkTwoHanded.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkTwoHanded.Visible = True
		Me.chkTwoHanded.Name = "chkTwoHanded"
		Me.txtArmor.AutoSize = False
		Me.txtArmor.Size = New System.Drawing.Size(25, 19)
		Me.txtArmor.Location = New System.Drawing.Point(104, 40)
		Me.txtArmor.Maxlength = 3
		Me.txtArmor.TabIndex = 49
		Me.txtArmor.Text = "999"
		Me.txtArmor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtArmor.AcceptsReturn = True
		Me.txtArmor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtArmor.BackColor = System.Drawing.SystemColors.Window
		Me.txtArmor.CausesValidation = True
		Me.txtArmor.Enabled = True
		Me.txtArmor.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtArmor.HideSelection = True
		Me.txtArmor.ReadOnly = False
		Me.txtArmor.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtArmor.MultiLine = False
		Me.txtArmor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtArmor.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtArmor.TabStop = True
		Me.txtArmor.Visible = True
		Me.txtArmor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtArmor.Name = "txtArmor"
		Me.lblDefense.BackColor = System.Drawing.Color.Transparent
		Me.lblDefense.Text = "Defense Bonus"
		Me.lblDefense.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lblDefense.Size = New System.Drawing.Size(85, 13)
		Me.lblDefense.Location = New System.Drawing.Point(12, 68)
		Me.lblDefense.TabIndex = 39
		Me.lblDefense.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDefense.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDefense.Enabled = True
		Me.lblDefense.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDefense.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDefense.UseMnemonic = True
		Me.lblDefense.Visible = True
		Me.lblDefense.AutoSize = False
		Me.lblDefense.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDefense.Name = "lblDefense"
		Me.lblAttackBonus.BackColor = System.Drawing.Color.Transparent
		Me.lblAttackBonus.Text = "Attack Bonus"
		Me.lblAttackBonus.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lblAttackBonus.Size = New System.Drawing.Size(81, 13)
		Me.lblAttackBonus.Location = New System.Drawing.Point(12, 44)
		Me.lblAttackBonus.TabIndex = 38
		Me.lblAttackBonus.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAttackBonus.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAttackBonus.Enabled = True
		Me.lblAttackBonus.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAttackBonus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAttackBonus.UseMnemonic = True
		Me.lblAttackBonus.Visible = True
		Me.lblAttackBonus.AutoSize = False
		Me.lblAttackBonus.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAttackBonus.Name = "lblAttackBonus"
		Me.lblActionPoints.BackColor = System.Drawing.Color.Transparent
		Me.lblActionPoints.Text = "Action Points"
		Me.lblActionPoints.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lblActionPoints.Size = New System.Drawing.Size(71, 13)
		Me.lblActionPoints.Location = New System.Drawing.Point(12, 20)
		Me.lblActionPoints.TabIndex = 37
		Me.lblActionPoints.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblActionPoints.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblActionPoints.Enabled = True
		Me.lblActionPoints.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblActionPoints.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblActionPoints.UseMnemonic = True
		Me.lblActionPoints.Visible = True
		Me.lblActionPoints.AutoSize = False
		Me.lblActionPoints.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblActionPoints.Name = "lblActionPoints"
		Me.lblRange.BackColor = System.Drawing.Color.Transparent
		Me.lblRange.Text = "Range"
		Me.lblRange.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lblRange.Size = New System.Drawing.Size(113, 13)
		Me.lblRange.Location = New System.Drawing.Point(12, 88)
		Me.lblRange.TabIndex = 36
		Me.lblRange.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRange.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblRange.Enabled = True
		Me.lblRange.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblRange.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblRange.UseMnemonic = True
		Me.lblRange.Visible = True
		Me.lblRange.AutoSize = False
		Me.lblRange.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblRange.Name = "lblRange"
		Me.lblResistance.BackColor = System.Drawing.Color.Transparent
		Me.lblResistance.Text = "Resistance %"
		Me.lblResistance.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lblResistance.Size = New System.Drawing.Size(81, 13)
		Me.lblResistance.Location = New System.Drawing.Point(12, 44)
		Me.lblResistance.TabIndex = 57
		Me.lblResistance.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblResistance.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblResistance.Enabled = True
		Me.lblResistance.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblResistance.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblResistance.UseMnemonic = True
		Me.lblResistance.Visible = True
		Me.lblResistance.AutoSize = False
		Me.lblResistance.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblResistance.Name = "lblResistance"
		Me.btnReGen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnReGen.BackColor = System.Drawing.SystemColors.Control
		Me.btnReGen.Text = "ReGen Now"
		Me.btnReGen.Size = New System.Drawing.Size(73, 21)
		Me.btnReGen.Location = New System.Drawing.Point(166, 4)
		Me.btnReGen.TabIndex = 21
		Me.btnReGen.Visible = False
		Me.btnReGen.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnReGen.CausesValidation = True
		Me.btnReGen.Enabled = True
		Me.btnReGen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnReGen.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnReGen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnReGen.TabStop = True
		Me.btnReGen.Name = "btnReGen"
		Me._chkKey_3.Size = New System.Drawing.Size(13, 13)
		Me._chkKey_3.Location = New System.Drawing.Point(188, 8)
		Me._chkKey_3.TabIndex = 28
		Me._chkKey_3.Visible = False
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
		Me._chkKey_3.Name = "_chkKey_3"
		Me._chkKey_4.Size = New System.Drawing.Size(13, 13)
		Me._chkKey_4.Location = New System.Drawing.Point(200, 8)
		Me._chkKey_4.TabIndex = 27
		Me._chkKey_4.Visible = False
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
		Me._chkKey_4.Name = "_chkKey_4"
		Me._chkKey_5.Size = New System.Drawing.Size(13, 13)
		Me._chkKey_5.Location = New System.Drawing.Point(212, 8)
		Me._chkKey_5.TabIndex = 26
		Me._chkKey_5.Visible = False
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
		Me._chkKey_5.Name = "_chkKey_5"
		Me._chkKey_6.Size = New System.Drawing.Size(13, 13)
		Me._chkKey_6.Location = New System.Drawing.Point(224, 8)
		Me._chkKey_6.TabIndex = 25
		Me._chkKey_6.Visible = False
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
		Me._chkKey_6.Name = "_chkKey_6"
		Me._chkKey_7.Size = New System.Drawing.Size(13, 13)
		Me._chkKey_7.Location = New System.Drawing.Point(236, 8)
		Me._chkKey_7.TabIndex = 24
		Me._chkKey_7.Visible = False
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
		Me._chkKey_7.Name = "_chkKey_7"
		Me.cmbFamily.Size = New System.Drawing.Size(112, 21)
		Me.cmbFamily.Location = New System.Drawing.Point(44, 4)
		Me.cmbFamily.Sorted = True
		Me.cmbFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbFamily.TabIndex = 22
		Me.cmbFamily.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbFamily.BackColor = System.Drawing.SystemColors.Window
		Me.cmbFamily.CausesValidation = True
		Me.cmbFamily.Enabled = True
		Me.cmbFamily.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbFamily.IntegralHeight = True
		Me.cmbFamily.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbFamily.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbFamily.TabStop = True
		Me.cmbFamily.Visible = True
		Me.cmbFamily.Name = "cmbFamily"
		Me._fraItem_2.Text = "Armor"
		Me._fraItem_2.Size = New System.Drawing.Size(133, 161)
		Me._fraItem_2.Location = New System.Drawing.Point(160, 32)
		Me._fraItem_2.TabIndex = 50
		Me._fraItem_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraItem_2.BackColor = System.Drawing.SystemColors.Control
		Me._fraItem_2.Enabled = True
		Me._fraItem_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraItem_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraItem_2.Visible = True
		Me._fraItem_2.Padding = New System.Windows.Forms.Padding(0)
		Me._fraItem_2.Name = "_fraItem_2"
		Me.cmbWearType.Size = New System.Drawing.Size(116, 21)
		Me.cmbWearType.Location = New System.Drawing.Point(8, 32)
		Me.cmbWearType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbWearType.TabIndex = 53
		Me.cmbWearType.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbWearType.BackColor = System.Drawing.SystemColors.Window
		Me.cmbWearType.CausesValidation = True
		Me.cmbWearType.Enabled = True
		Me.cmbWearType.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbWearType.IntegralHeight = True
		Me.cmbWearType.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbWearType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbWearType.Sorted = False
		Me.cmbWearType.TabStop = True
		Me.cmbWearType.Visible = True
		Me.cmbWearType.Name = "cmbWearType"
		Me.cmbResistanceType.Size = New System.Drawing.Size(116, 21)
		Me.cmbResistanceType.Location = New System.Drawing.Point(8, 80)
		Me.cmbResistanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbResistanceType.TabIndex = 52
		Me.cmbResistanceType.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbResistanceType.BackColor = System.Drawing.SystemColors.Window
		Me.cmbResistanceType.CausesValidation = True
		Me.cmbResistanceType.Enabled = True
		Me.cmbResistanceType.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbResistanceType.IntegralHeight = True
		Me.cmbResistanceType.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbResistanceType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbResistanceType.Sorted = False
		Me.cmbResistanceType.TabStop = True
		Me.cmbResistanceType.Visible = True
		Me.cmbResistanceType.Name = "cmbResistanceType"
		Me.cmbResistanceBonus.Size = New System.Drawing.Size(116, 21)
		Me.cmbResistanceBonus.Location = New System.Drawing.Point(8, 128)
		Me.cmbResistanceBonus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbResistanceBonus.TabIndex = 51
		Me.cmbResistanceBonus.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbResistanceBonus.BackColor = System.Drawing.SystemColors.Window
		Me.cmbResistanceBonus.CausesValidation = True
		Me.cmbResistanceBonus.Enabled = True
		Me.cmbResistanceBonus.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbResistanceBonus.IntegralHeight = True
		Me.cmbResistanceBonus.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbResistanceBonus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbResistanceBonus.Sorted = False
		Me.cmbResistanceBonus.TabStop = True
		Me.cmbResistanceBonus.Visible = True
		Me.cmbResistanceBonus.Name = "cmbResistanceBonus"
		Me._Label1_1.BackColor = System.Drawing.Color.Transparent
		Me._Label1_1.Text = "Armor Type"
		Me._Label1_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_1.Size = New System.Drawing.Size(113, 13)
		Me._Label1_1.Location = New System.Drawing.Point(8, 16)
		Me._Label1_1.TabIndex = 56
		Me._Label1_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_1.Enabled = True
		Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_1.UseMnemonic = True
		Me._Label1_1.Visible = True
		Me._Label1_1.AutoSize = False
		Me._Label1_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_1.Name = "_Label1_1"
		Me._Label1_2.BackColor = System.Drawing.Color.Transparent
		Me._Label1_2.Text = "Resistance Bonus Type"
		Me._Label1_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_2.Size = New System.Drawing.Size(113, 13)
		Me._Label1_2.Location = New System.Drawing.Point(8, 64)
		Me._Label1_2.TabIndex = 55
		Me._Label1_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_2.Enabled = True
		Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_2.UseMnemonic = True
		Me._Label1_2.Visible = True
		Me._Label1_2.AutoSize = False
		Me._Label1_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_2.Name = "_Label1_2"
		Me._Label1_12.BackColor = System.Drawing.Color.Transparent
		Me._Label1_12.Text = "Resistance Bonus"
		Me._Label1_12.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_12.Size = New System.Drawing.Size(113, 13)
		Me._Label1_12.Location = New System.Drawing.Point(8, 112)
		Me._Label1_12.TabIndex = 54
		Me._Label1_12.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_12.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_12.Enabled = True
		Me._Label1_12.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_12.UseMnemonic = True
		Me._Label1_12.Visible = True
		Me._Label1_12.AutoSize = False
		Me._Label1_12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_12.Name = "_Label1_12"
		Me.lblRequiredLevel.Text = "Level"
		Me.lblRequiredLevel.Size = New System.Drawing.Size(49, 17)
		Me.lblRequiredLevel.Location = New System.Drawing.Point(164, 8)
		Me.lblRequiredLevel.TabIndex = 83
		Me.lblRequiredLevel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRequiredLevel.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblRequiredLevel.BackColor = System.Drawing.SystemColors.Control
		Me.lblRequiredLevel.Enabled = True
		Me.lblRequiredLevel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblRequiredLevel.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblRequiredLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblRequiredLevel.UseMnemonic = True
		Me.lblRequiredLevel.Visible = True
		Me.lblRequiredLevel.AutoSize = False
		Me.lblRequiredLevel.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblRequiredLevel.Name = "lblRequiredLevel"
		Me.lblKey.Text = "Key"
		Me.lblKey.Size = New System.Drawing.Size(21, 13)
		Me.lblKey.Location = New System.Drawing.Point(164, 8)
		Me.lblKey.TabIndex = 29
		Me.lblKey.Visible = False
		Me.lblKey.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblKey.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblKey.BackColor = System.Drawing.SystemColors.Control
		Me.lblKey.Enabled = True
		Me.lblKey.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblKey.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblKey.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblKey.UseMnemonic = True
		Me.lblKey.AutoSize = False
		Me.lblKey.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblKey.Name = "lblKey"
		Me._Label1_0.BackColor = System.Drawing.Color.Transparent
		Me._Label1_0.Text = "Family"
		Me._Label1_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_0.Size = New System.Drawing.Size(41, 13)
		Me._Label1_0.Location = New System.Drawing.Point(8, 8)
		Me._Label1_0.TabIndex = 23
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
		Me.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnApply.BackColor = System.Drawing.SystemColors.Control
		Me.btnApply.Text = "Apply"
		Me.btnApply.Enabled = False
		Me.btnApply.Size = New System.Drawing.Size(73, 21)
		Me.btnApply.Location = New System.Drawing.Point(336, 240)
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
		Me.btnOk.Location = New System.Drawing.Point(176, 240)
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
		Me.btnCancel.Location = New System.Drawing.Point(256, 240)
		Me.btnCancel.TabIndex = 0
		Me.btnCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancel.CausesValidation = True
		Me.btnCancel.Enabled = True
		Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCancel.TabStop = True
		Me.btnCancel.Name = "btnCancel"
		tabItemProp.OcxState = CType(resources.GetObject("tabItemProp.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tabItemProp.Size = New System.Drawing.Size(405, 229)
		Me.tabItemProp.Location = New System.Drawing.Point(4, 4)
		Me.tabItemProp.TabIndex = 3
		Me.tabItemProp.Name = "tabItemProp"
		Me.Label1.SetIndex(_Label1_5, CType(5, Short))
		Me.Label1.SetIndex(_Label1_6, CType(6, Short))
		Me.Label1.SetIndex(_Label1_4, CType(4, Short))
		Me.Label1.SetIndex(_Label1_7, CType(7, Short))
		Me.Label1.SetIndex(_Label1_17, CType(17, Short))
		Me.Label1.SetIndex(_Label1_21, CType(21, Short))
		Me.Label1.SetIndex(_Label1_1, CType(1, Short))
		Me.Label1.SetIndex(_Label1_2, CType(2, Short))
		Me.Label1.SetIndex(_Label1_12, CType(12, Short))
		Me.Label1.SetIndex(_Label1_0, CType(0, Short))
		Me.chkKey.SetIndex(_chkKey_3, CType(3, Short))
		Me.chkKey.SetIndex(_chkKey_4, CType(4, Short))
		Me.chkKey.SetIndex(_chkKey_5, CType(5, Short))
		Me.chkKey.SetIndex(_chkKey_6, CType(6, Short))
		Me.chkKey.SetIndex(_chkKey_7, CType(7, Short))
		Me.fraItem.SetIndex(_fraItem_1, CType(1, Short))
		Me.fraItem.SetIndex(_fraItem_0, CType(0, Short))
		Me.fraItem.SetIndex(_fraItem_2, CType(2, Short))
		Me.fraItemProp.SetIndex(_fraItemProp_0, CType(0, Short))
		Me.fraItemProp.SetIndex(_fraItemProp_2, CType(2, Short))
		Me.fraItemProp.SetIndex(_fraItemProp_1, CType(1, Short))
		Me.lblName.SetIndex(_lblName_1, CType(1, Short))
		Me.optSize.SetIndex(_optSize_0, CType(0, Short))
		Me.optSize.SetIndex(_optSize_1, CType(1, Short))
		Me.optSize.SetIndex(_optSize_2, CType(2, Short))
		Me.optSize.SetIndex(_optSize_3, CType(3, Short))
		Me.optSize.SetIndex(_optSize_4, CType(4, Short))
		CType(Me.optSize, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.fraItemProp, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.fraItem, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chkKey, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tabItemProp, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(_fraItemProp_0)
		Me.Controls.Add(_fraItemProp_2)
		Me.Controls.Add(_fraItemProp_1)
		Me.Controls.Add(btnApply)
		Me.Controls.Add(btnOk)
		Me.Controls.Add(btnCancel)
		Me.Controls.Add(tabItemProp)
		Me._fraItemProp_0.Controls.Add(Frame2)
		Me._fraItemProp_0.Controls.Add(Frame1)
		Me.Frame2.Controls.Add(chkSoftCapacity)
		Me.Frame2.Controls.Add(picItem)
		Me.Frame2.Controls.Add(txtBulk)
		Me.Frame2.Controls.Add(txtCapacity)
		Me.Frame2.Controls.Add(txtWeight)
		Me.Frame2.Controls.Add(txtCount)
		Me.Frame2.Controls.Add(txtValue)
		Me.Frame2.Controls.Add(btnBrowse)
		Me.Frame2.Controls.Add(btnBrowseLeft)
		Me.Frame2.Controls.Add(btnBrowseRight)
		Me.Frame2.Controls.Add(_Label1_5)
		Me.Frame2.Controls.Add(_Label1_6)
		Me.Frame2.Controls.Add(_Label1_4)
		Me.Frame2.Controls.Add(_Label1_7)
		Me.Frame2.Controls.Add(_Label1_17)
		Me.Frame1.Controls.Add(chkCombine)
		Me.Frame1.Controls.Add(chkDescription)
		Me.Frame1.Controls.Add(txtComments)
		Me.Frame1.Controls.Add(txtName)
		Me.Frame1.Controls.Add(_Label1_21)
		Me.Frame1.Controls.Add(_lblName_1)
		Me._fraItemProp_2.Controls.Add(btnLibrary)
		Me._fraItemProp_2.Controls.Add(btnPaste)
		Me._fraItemProp_2.Controls.Add(btnCopy)
		Me._fraItemProp_2.Controls.Add(lstThings)
		Me._fraItemProp_2.Controls.Add(btnEdit)
		Me._fraItemProp_2.Controls.Add(btnInsert)
		Me._fraItemProp_2.Controls.Add(btnCut)
		Me._fraItemProp_2.Controls.Add(lblAttached)
		Me._fraItemProp_1.Controls.Add(txtRequiredLevel)
		Me._fraItemProp_1.Controls.Add(chkExamined)
		Me._fraItemProp_1.Controls.Add(fraSize)
		Me._fraItemProp_1.Controls.Add(chkIsEquipped)
		Me._fraItemProp_1.Controls.Add(_fraItem_1)
		Me._fraItemProp_1.Controls.Add(_fraItem_0)
		Me._fraItemProp_1.Controls.Add(btnReGen)
		Me._fraItemProp_1.Controls.Add(_chkKey_3)
		Me._fraItemProp_1.Controls.Add(_chkKey_4)
		Me._fraItemProp_1.Controls.Add(_chkKey_5)
		Me._fraItemProp_1.Controls.Add(_chkKey_6)
		Me._fraItemProp_1.Controls.Add(_chkKey_7)
		Me._fraItemProp_1.Controls.Add(cmbFamily)
		Me._fraItemProp_1.Controls.Add(_fraItem_2)
		Me._fraItemProp_1.Controls.Add(lblRequiredLevel)
		Me._fraItemProp_1.Controls.Add(lblKey)
		Me._fraItemProp_1.Controls.Add(_Label1_0)
		Me.fraSize.Controls.Add(chkAllowOtherSize)
		Me.fraSize.Controls.Add(_optSize_0)
		Me.fraSize.Controls.Add(_optSize_1)
		Me.fraSize.Controls.Add(_optSize_2)
		Me.fraSize.Controls.Add(_optSize_3)
		Me.fraSize.Controls.Add(_optSize_4)
		Me._fraItem_1.Controls.Add(cmbAmmo)
		Me._fraItem_1.Controls.Add(txtDamageBonus)
		Me._fraItem_1.Controls.Add(cmbDamage)
		Me._fraItem_1.Controls.Add(cmbDamageType)
		Me._fraItem_1.Controls.Add(cmbFoodType)
		Me._fraItem_1.Controls.Add(lblAmmo)
		Me._fraItem_1.Controls.Add(lblDamageBonus)
		Me._fraItem_1.Controls.Add(lblDamageType)
		Me._fraItem_1.Controls.Add(lblDamage)
		Me._fraItem_0.Controls.Add(txtDefense)
		Me._fraItem_0.Controls.Add(txtAttackBonus)
		Me._fraItem_0.Controls.Add(txtActionPoints)
		Me._fraItem_0.Controls.Add(cmbRange)
		Me._fraItem_0.Controls.Add(chkTwoHanded)
		Me._fraItem_0.Controls.Add(txtArmor)
		Me._fraItem_0.Controls.Add(lblDefense)
		Me._fraItem_0.Controls.Add(lblAttackBonus)
		Me._fraItem_0.Controls.Add(lblActionPoints)
		Me._fraItem_0.Controls.Add(lblRange)
		Me._fraItem_0.Controls.Add(lblResistance)
		Me._fraItem_2.Controls.Add(cmbWearType)
		Me._fraItem_2.Controls.Add(cmbResistanceType)
		Me._fraItem_2.Controls.Add(cmbResistanceBonus)
		Me._fraItem_2.Controls.Add(_Label1_1)
		Me._fraItem_2.Controls.Add(_Label1_2)
		Me._fraItem_2.Controls.Add(_Label1_12)
		Me._fraItemProp_0.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me._fraItemProp_2.ResumeLayout(False)
		Me._fraItemProp_1.ResumeLayout(False)
		Me.fraSize.ResumeLayout(False)
		Me._fraItem_1.ResumeLayout(False)
		Me._fraItem_0.ResumeLayout(False)
		Me._fraItem_2.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class