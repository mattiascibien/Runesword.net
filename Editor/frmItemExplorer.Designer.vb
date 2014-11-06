<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmItemExplorer
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
	Public WithEvents txtValue As System.Windows.Forms.TextBox
	Public WithEvents btnInsert As System.Windows.Forms.Button
	Public WithEvents picMask As System.Windows.Forms.PictureBox
	Public WithEvents picItem As System.Windows.Forms.PictureBox
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents flsFileList As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
	Public WithEvents txtDataPath As System.Windows.Forms.TextBox
	Public WithEvents dlstDirectory As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
	Public WithEvents txtItemComments As System.Windows.Forms.TextBox
	Public WithEvents lstItems As System.Windows.Forms.ListBox
	Public WithEvents lblItemComments As System.Windows.Forms.Label
	Public WithEvents fraItems As System.Windows.Forms.GroupBox
	Public WithEvents lstArmor As System.Windows.Forms.ListBox
	Public WithEvents fraArmor As System.Windows.Forms.GroupBox
	Public WithEvents txtCapacity As System.Windows.Forms.TextBox
	Public WithEvents txtContainerBulk As System.Windows.Forms.TextBox
	Public WithEvents txtContainerWeight As System.Windows.Forms.TextBox
	Public WithEvents txtBulk As System.Windows.Forms.TextBox
	Public WithEvents txtWeight As System.Windows.Forms.TextBox
	Public WithEvents chkContainer As System.Windows.Forms.CheckBox
	Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents lblBulk As System.Windows.Forms.Label
	Public WithEvents _lblWeight_4 As System.Windows.Forms.Label
	Public WithEvents lblContainerType As System.Windows.Forms.Label
	Public WithEvents lblSoft As System.Windows.Forms.Label
	Public WithEvents fraEncumbrance As System.Windows.Forms.GroupBox
	Public WithEvents txtComments As System.Windows.Forms.TextBox
	Public WithEvents picCreature As System.Windows.Forms.PictureBox
	Public WithEvents txtLevel As System.Windows.Forms.TextBox
	Public WithEvents chkCanCombine As System.Windows.Forms.CheckBox
	Public WithEvents txtSize As System.Windows.Forms.TextBox
	Public WithEvents txtCount As System.Windows.Forms.TextBox
	Public WithEvents txtName As System.Windows.Forms.TextBox
	Public WithEvents lstFood As System.Windows.Forms.ListBox
	Public WithEvents fraFood As System.Windows.Forms.GroupBox
	Public WithEvents txtTriggComm As System.Windows.Forms.TextBox
	Public WithEvents lstTriggers As System.Windows.Forms.ListBox
	Public WithEvents lblTriggComm As System.Windows.Forms.Label
	Public WithEvents fraTriggers As System.Windows.Forms.GroupBox
	Public WithEvents chk2hands As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_18 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_17 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_16 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_15 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_14 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_13 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_12 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_11 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_10 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_8 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_9 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_4 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_5 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_6 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_7 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_3 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_2 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_1 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_0 As System.Windows.Forms.CheckBox
	Public WithEvents fraFamily As System.Windows.Forms.GroupBox
	Public WithEvents _txtStats_7 As System.Windows.Forms.TextBox
	Public WithEvents _txtStats_6 As System.Windows.Forms.TextBox
	Public WithEvents _txtStats_5 As System.Windows.Forms.TextBox
	Public WithEvents _txtStats_4 As System.Windows.Forms.TextBox
	Public WithEvents _txtStats_3 As System.Windows.Forms.TextBox
	Public WithEvents _txtStats_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtStats_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtStats_0 As System.Windows.Forms.TextBox
	Public WithEvents _lblStats_7 As System.Windows.Forms.Label
	Public WithEvents _lblStats_6 As System.Windows.Forms.Label
	Public WithEvents _lblStats_5 As System.Windows.Forms.Label
	Public WithEvents _lblStats_4 As System.Windows.Forms.Label
	Public WithEvents _lblStats_3 As System.Windows.Forms.Label
	Public WithEvents _lblStats_2 As System.Windows.Forms.Label
	Public WithEvents _lblStats_1 As System.Windows.Forms.Label
	Public WithEvents _lblStats_0 As System.Windows.Forms.Label
	Public WithEvents fraStats As System.Windows.Forms.GroupBox
	Public WithEvents lblValue As System.Windows.Forms.Label
	Public WithEvents lblSize As System.Windows.Forms.Label
	Public WithEvents lblCount As System.Windows.Forms.Label
	Public WithEvents lblLevel As System.Windows.Forms.Label
	Public WithEvents lblName As System.Windows.Forms.Label
	Public WithEvents imgBook As System.Windows.Forms.PictureBox
	Public WithEvents fraFullView As System.Windows.Forms.Panel
	Public WithEvents drvList As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
	Public WithEvents picCreatureCompact As System.Windows.Forms.PictureBox
	Public WithEvents txtInfo As System.Windows.Forms.TextBox
	Public WithEvents fraCompactView As System.Windows.Forms.Panel
	Public WithEvents lblPath As System.Windows.Forms.Label
	Public WithEvents lblFiles As System.Windows.Forms.Label
	Public WithEvents lblDirectory As System.Windows.Forms.Label
	Public WithEvents lblDrive As System.Windows.Forms.Label
	Public WithEvents chkFamily As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	Public WithEvents lblStats As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblWeight As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents txtStats As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmItemExplorer))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.txtValue = New System.Windows.Forms.TextBox
		Me.btnInsert = New System.Windows.Forms.Button
		Me.picMask = New System.Windows.Forms.PictureBox
		Me.picItem = New System.Windows.Forms.PictureBox
		Me.cmdClose = New System.Windows.Forms.Button
		Me.flsFileList = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
		Me.txtDataPath = New System.Windows.Forms.TextBox
		Me.dlstDirectory = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox
		Me.fraFullView = New System.Windows.Forms.Panel
		Me.fraItems = New System.Windows.Forms.GroupBox
		Me.txtItemComments = New System.Windows.Forms.TextBox
		Me.lstItems = New System.Windows.Forms.ListBox
		Me.lblItemComments = New System.Windows.Forms.Label
		Me.fraArmor = New System.Windows.Forms.GroupBox
		Me.lstArmor = New System.Windows.Forms.ListBox
		Me.fraEncumbrance = New System.Windows.Forms.GroupBox
		Me.txtCapacity = New System.Windows.Forms.TextBox
		Me.txtContainerBulk = New System.Windows.Forms.TextBox
		Me.txtContainerWeight = New System.Windows.Forms.TextBox
		Me.txtBulk = New System.Windows.Forms.TextBox
		Me.txtWeight = New System.Windows.Forms.TextBox
		Me.chkContainer = New System.Windows.Forms.CheckBox
		Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.lblBulk = New System.Windows.Forms.Label
		Me._lblWeight_4 = New System.Windows.Forms.Label
		Me.lblContainerType = New System.Windows.Forms.Label
		Me.lblSoft = New System.Windows.Forms.Label
		Me.txtComments = New System.Windows.Forms.TextBox
		Me.picCreature = New System.Windows.Forms.PictureBox
		Me.txtLevel = New System.Windows.Forms.TextBox
		Me.chkCanCombine = New System.Windows.Forms.CheckBox
		Me.txtSize = New System.Windows.Forms.TextBox
		Me.txtCount = New System.Windows.Forms.TextBox
		Me.txtName = New System.Windows.Forms.TextBox
		Me.fraFood = New System.Windows.Forms.GroupBox
		Me.lstFood = New System.Windows.Forms.ListBox
		Me.fraTriggers = New System.Windows.Forms.GroupBox
		Me.txtTriggComm = New System.Windows.Forms.TextBox
		Me.lstTriggers = New System.Windows.Forms.ListBox
		Me.lblTriggComm = New System.Windows.Forms.Label
		Me.fraFamily = New System.Windows.Forms.GroupBox
		Me.chk2hands = New System.Windows.Forms.CheckBox
		Me._chkFamily_18 = New System.Windows.Forms.CheckBox
		Me._chkFamily_17 = New System.Windows.Forms.CheckBox
		Me._chkFamily_16 = New System.Windows.Forms.CheckBox
		Me._chkFamily_15 = New System.Windows.Forms.CheckBox
		Me._chkFamily_14 = New System.Windows.Forms.CheckBox
		Me._chkFamily_13 = New System.Windows.Forms.CheckBox
		Me._chkFamily_12 = New System.Windows.Forms.CheckBox
		Me._chkFamily_11 = New System.Windows.Forms.CheckBox
		Me._chkFamily_10 = New System.Windows.Forms.CheckBox
		Me._chkFamily_8 = New System.Windows.Forms.CheckBox
		Me._chkFamily_9 = New System.Windows.Forms.CheckBox
		Me._chkFamily_4 = New System.Windows.Forms.CheckBox
		Me._chkFamily_5 = New System.Windows.Forms.CheckBox
		Me._chkFamily_6 = New System.Windows.Forms.CheckBox
		Me._chkFamily_7 = New System.Windows.Forms.CheckBox
		Me._chkFamily_3 = New System.Windows.Forms.CheckBox
		Me._chkFamily_2 = New System.Windows.Forms.CheckBox
		Me._chkFamily_1 = New System.Windows.Forms.CheckBox
		Me._chkFamily_0 = New System.Windows.Forms.CheckBox
		Me.fraStats = New System.Windows.Forms.GroupBox
		Me._txtStats_7 = New System.Windows.Forms.TextBox
		Me._txtStats_6 = New System.Windows.Forms.TextBox
		Me._txtStats_5 = New System.Windows.Forms.TextBox
		Me._txtStats_4 = New System.Windows.Forms.TextBox
		Me._txtStats_3 = New System.Windows.Forms.TextBox
		Me._txtStats_2 = New System.Windows.Forms.TextBox
		Me._txtStats_1 = New System.Windows.Forms.TextBox
		Me._txtStats_0 = New System.Windows.Forms.TextBox
		Me._lblStats_7 = New System.Windows.Forms.Label
		Me._lblStats_6 = New System.Windows.Forms.Label
		Me._lblStats_5 = New System.Windows.Forms.Label
		Me._lblStats_4 = New System.Windows.Forms.Label
		Me._lblStats_3 = New System.Windows.Forms.Label
		Me._lblStats_2 = New System.Windows.Forms.Label
		Me._lblStats_1 = New System.Windows.Forms.Label
		Me._lblStats_0 = New System.Windows.Forms.Label
		Me.lblValue = New System.Windows.Forms.Label
		Me.lblSize = New System.Windows.Forms.Label
		Me.lblCount = New System.Windows.Forms.Label
		Me.lblLevel = New System.Windows.Forms.Label
		Me.lblName = New System.Windows.Forms.Label
		Me.imgBook = New System.Windows.Forms.PictureBox
		Me.drvList = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
		Me.fraCompactView = New System.Windows.Forms.Panel
		Me.picCreatureCompact = New System.Windows.Forms.PictureBox
		Me.txtInfo = New System.Windows.Forms.TextBox
		Me.lblPath = New System.Windows.Forms.Label
		Me.lblFiles = New System.Windows.Forms.Label
		Me.lblDirectory = New System.Windows.Forms.Label
		Me.lblDrive = New System.Windows.Forms.Label
		Me.chkFamily = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(components)
		Me.lblStats = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblWeight = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.txtStats = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.fraFullView.SuspendLayout()
		Me.fraItems.SuspendLayout()
		Me.fraArmor.SuspendLayout()
		Me.fraEncumbrance.SuspendLayout()
		Me.fraFood.SuspendLayout()
		Me.fraTriggers.SuspendLayout()
		Me.fraFamily.SuspendLayout()
		Me.fraStats.SuspendLayout()
		Me.fraCompactView.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.chkFamily, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblStats, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblWeight, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtStats, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Item Explorer"
		Me.ClientSize = New System.Drawing.Size(1159, 609)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.MaximizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
		Me.MinimizeBox = False
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmItemExplorer"
		Me.txtValue.AutoSize = False
		Me.txtValue.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.txtValue.Size = New System.Drawing.Size(49, 19)
		Me.txtValue.Location = New System.Drawing.Point(224, 272)
		Me.txtValue.ReadOnly = True
		Me.txtValue.Maxlength = 3
		Me.txtValue.TabIndex = 66
		Me.txtValue.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtValue.AcceptsReturn = True
		Me.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtValue.CausesValidation = True
		Me.txtValue.Enabled = True
		Me.txtValue.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtValue.HideSelection = True
		Me.txtValue.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtValue.MultiLine = False
		Me.txtValue.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtValue.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtValue.TabStop = True
		Me.txtValue.Visible = True
		Me.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtValue.Name = "txtValue"
		Me.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnInsert.Text = "Insert into Tome"
		Me.btnInsert.Size = New System.Drawing.Size(81, 33)
		Me.btnInsert.Location = New System.Drawing.Point(536, 48)
		Me.btnInsert.TabIndex = 61
		Me.btnInsert.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnInsert.BackColor = System.Drawing.SystemColors.Control
		Me.btnInsert.CausesValidation = True
		Me.btnInsert.Enabled = True
		Me.btnInsert.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnInsert.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnInsert.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnInsert.TabStop = True
		Me.btnInsert.Name = "btnInsert"
		Me.picMask.BackColor = System.Drawing.SystemColors.Window
		Me.picMask.ForeColor = System.Drawing.SystemColors.WindowText
		Me.picMask.Size = New System.Drawing.Size(89, 81)
		Me.picMask.Location = New System.Drawing.Point(8, 672)
		Me.picMask.TabIndex = 60
		Me.picMask.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picMask.Dock = System.Windows.Forms.DockStyle.None
		Me.picMask.CausesValidation = True
		Me.picMask.Enabled = True
		Me.picMask.Cursor = System.Windows.Forms.Cursors.Default
		Me.picMask.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picMask.TabStop = True
		Me.picMask.Visible = True
		Me.picMask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picMask.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.picMask.Name = "picMask"
		Me.picItem.BackColor = System.Drawing.SystemColors.Window
		Me.picItem.ForeColor = System.Drawing.SystemColors.WindowText
		Me.picItem.Size = New System.Drawing.Size(81, 81)
		Me.picItem.Location = New System.Drawing.Point(128, 672)
		Me.picItem.TabIndex = 59
		Me.picItem.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picItem.Dock = System.Windows.Forms.DockStyle.None
		Me.picItem.CausesValidation = True
		Me.picItem.Enabled = True
		Me.picItem.Cursor = System.Windows.Forms.Cursors.Default
		Me.picItem.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picItem.TabStop = True
		Me.picItem.Visible = True
		Me.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picItem.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.picItem.Name = "picItem"
		Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdClose.Text = "Close"
		Me.cmdClose.Size = New System.Drawing.Size(97, 25)
		Me.cmdClose.Location = New System.Drawing.Point(448, 8)
		Me.cmdClose.TabIndex = 54
		Me.cmdClose.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.CausesValidation = True
		Me.cmdClose.Enabled = True
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.TabStop = True
		Me.cmdClose.Name = "cmdClose"
		Me.flsFileList.Size = New System.Drawing.Size(145, 344)
		Me.flsFileList.Location = New System.Drawing.Point(8, 248)
		Me.flsFileList.Pattern = "*.rsi"
		Me.flsFileList.TabIndex = 53
		Me.flsFileList.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.flsFileList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.flsFileList.Archive = True
		Me.flsFileList.BackColor = System.Drawing.SystemColors.Window
		Me.flsFileList.CausesValidation = True
		Me.flsFileList.Enabled = True
		Me.flsFileList.ForeColor = System.Drawing.SystemColors.WindowText
		Me.flsFileList.Hidden = False
		Me.flsFileList.Cursor = System.Windows.Forms.Cursors.Default
		Me.flsFileList.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.flsFileList.Normal = True
		Me.flsFileList.ReadOnly = True
		Me.flsFileList.System = False
		Me.flsFileList.TabStop = True
		Me.flsFileList.TopIndex = 0
		Me.flsFileList.Visible = True
		Me.flsFileList.Name = "flsFileList"
		Me.txtDataPath.AutoSize = False
		Me.txtDataPath.Size = New System.Drawing.Size(369, 19)
		Me.txtDataPath.Location = New System.Drawing.Point(64, 8)
		Me.txtDataPath.ReadOnly = True
		Me.txtDataPath.TabIndex = 52
		Me.txtDataPath.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDataPath.AcceptsReturn = True
		Me.txtDataPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDataPath.BackColor = System.Drawing.SystemColors.Window
		Me.txtDataPath.CausesValidation = True
		Me.txtDataPath.Enabled = True
		Me.txtDataPath.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDataPath.HideSelection = True
		Me.txtDataPath.Maxlength = 0
		Me.txtDataPath.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDataPath.MultiLine = False
		Me.txtDataPath.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDataPath.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDataPath.TabStop = True
		Me.txtDataPath.Visible = True
		Me.txtDataPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDataPath.Name = "txtDataPath"
		Me.dlstDirectory.Size = New System.Drawing.Size(145, 141)
		Me.dlstDirectory.Location = New System.Drawing.Point(8, 88)
		Me.dlstDirectory.TabIndex = 51
		Me.dlstDirectory.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dlstDirectory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.dlstDirectory.BackColor = System.Drawing.SystemColors.Window
		Me.dlstDirectory.CausesValidation = True
		Me.dlstDirectory.Enabled = True
		Me.dlstDirectory.ForeColor = System.Drawing.SystemColors.WindowText
		Me.dlstDirectory.Cursor = System.Windows.Forms.Cursors.Default
		Me.dlstDirectory.TabStop = True
		Me.dlstDirectory.Visible = True
		Me.dlstDirectory.Name = "dlstDirectory"
		Me.fraFullView.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.fraFullView.Text = "Frame1"
		Me.fraFullView.Size = New System.Drawing.Size(1009, 585)
		Me.fraFullView.Location = New System.Drawing.Point(152, 32)
		Me.fraFullView.TabIndex = 1
		Me.fraFullView.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraFullView.BackColor = System.Drawing.SystemColors.Control
		Me.fraFullView.Enabled = True
		Me.fraFullView.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraFullView.Cursor = System.Windows.Forms.Cursors.Default
		Me.fraFullView.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraFullView.Visible = True
		Me.fraFullView.Name = "fraFullView"
		Me.fraItems.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.fraItems.Text = "Items"
		Me.fraItems.Size = New System.Drawing.Size(201, 209)
		Me.fraItems.Location = New System.Drawing.Point(712, 8)
		Me.fraItems.TabIndex = 43
		Me.fraItems.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraItems.Enabled = True
		Me.fraItems.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraItems.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraItems.Visible = True
		Me.fraItems.Padding = New System.Windows.Forms.Padding(0)
		Me.fraItems.Name = "fraItems"
		Me.txtItemComments.AutoSize = False
		Me.txtItemComments.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.txtItemComments.Size = New System.Drawing.Size(185, 97)
		Me.txtItemComments.Location = New System.Drawing.Point(8, 104)
		Me.txtItemComments.ReadOnly = True
		Me.txtItemComments.Maxlength = 10000
		Me.txtItemComments.MultiLine = True
		Me.txtItemComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtItemComments.TabIndex = 45
		Me.txtItemComments.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtItemComments.AcceptsReturn = True
		Me.txtItemComments.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtItemComments.CausesValidation = True
		Me.txtItemComments.Enabled = True
		Me.txtItemComments.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtItemComments.HideSelection = True
		Me.txtItemComments.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtItemComments.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtItemComments.TabStop = True
		Me.txtItemComments.Visible = True
		Me.txtItemComments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtItemComments.Name = "txtItemComments"
		Me.lstItems.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.lstItems.Size = New System.Drawing.Size(185, 72)
		Me.lstItems.Location = New System.Drawing.Point(8, 16)
		Me.lstItems.TabIndex = 44
		Me.lstItems.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstItems.CausesValidation = True
		Me.lstItems.Enabled = True
		Me.lstItems.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstItems.IntegralHeight = True
		Me.lstItems.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstItems.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstItems.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstItems.Sorted = False
		Me.lstItems.TabStop = True
		Me.lstItems.Visible = True
		Me.lstItems.MultiColumn = False
		Me.lstItems.Name = "lstItems"
		Me.lblItemComments.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.lblItemComments.Text = "Item Comments"
		Me.lblItemComments.Size = New System.Drawing.Size(145, 17)
		Me.lblItemComments.Location = New System.Drawing.Point(8, 88)
		Me.lblItemComments.TabIndex = 46
		Me.lblItemComments.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItemComments.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItemComments.Enabled = True
		Me.lblItemComments.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItemComments.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItemComments.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItemComments.UseMnemonic = True
		Me.lblItemComments.Visible = True
		Me.lblItemComments.AutoSize = False
		Me.lblItemComments.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItemComments.Name = "lblItemComments"
		Me.fraArmor.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.fraArmor.Text = "Armor details"
		Me.fraArmor.Size = New System.Drawing.Size(393, 185)
		Me.fraArmor.Location = New System.Drawing.Point(504, 368)
		Me.fraArmor.TabIndex = 42
		Me.fraArmor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraArmor.Enabled = True
		Me.fraArmor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraArmor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraArmor.Visible = True
		Me.fraArmor.Padding = New System.Windows.Forms.Padding(0)
		Me.fraArmor.Name = "fraArmor"
		Me.lstArmor.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.lstArmor.Size = New System.Drawing.Size(377, 163)
		Me.lstArmor.Location = New System.Drawing.Point(8, 16)
		Me.lstArmor.TabIndex = 86
		Me.lstArmor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstArmor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstArmor.CausesValidation = True
		Me.lstArmor.Enabled = True
		Me.lstArmor.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstArmor.IntegralHeight = True
		Me.lstArmor.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstArmor.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstArmor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstArmor.Sorted = False
		Me.lstArmor.TabStop = True
		Me.lstArmor.Visible = True
		Me.lstArmor.MultiColumn = False
		Me.lstArmor.Name = "lstArmor"
		Me.fraEncumbrance.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.fraEncumbrance.Text = "Encumbrance"
		Me.fraEncumbrance.Size = New System.Drawing.Size(433, 97)
		Me.fraEncumbrance.Location = New System.Drawing.Point(40, 448)
		Me.fraEncumbrance.TabIndex = 39
		Me.fraEncumbrance.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraEncumbrance.Enabled = True
		Me.fraEncumbrance.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraEncumbrance.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraEncumbrance.Visible = True
		Me.fraEncumbrance.Padding = New System.Windows.Forms.Padding(0)
		Me.fraEncumbrance.Name = "fraEncumbrance"
		Me.txtCapacity.AutoSize = False
		Me.txtCapacity.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.txtCapacity.Size = New System.Drawing.Size(113, 19)
		Me.txtCapacity.Location = New System.Drawing.Point(216, 72)
		Me.txtCapacity.ReadOnly = True
		Me.txtCapacity.TabIndex = 76
		Me.txtCapacity.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCapacity.AcceptsReturn = True
		Me.txtCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCapacity.CausesValidation = True
		Me.txtCapacity.Enabled = True
		Me.txtCapacity.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCapacity.HideSelection = True
		Me.txtCapacity.Maxlength = 0
		Me.txtCapacity.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCapacity.MultiLine = False
		Me.txtCapacity.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCapacity.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCapacity.TabStop = True
		Me.txtCapacity.Visible = True
		Me.txtCapacity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCapacity.Name = "txtCapacity"
		Me.txtContainerBulk.AutoSize = False
		Me.txtContainerBulk.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.txtContainerBulk.Size = New System.Drawing.Size(113, 19)
		Me.txtContainerBulk.Location = New System.Drawing.Point(216, 48)
		Me.txtContainerBulk.ReadOnly = True
		Me.txtContainerBulk.TabIndex = 75
		Me.txtContainerBulk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtContainerBulk.AcceptsReturn = True
		Me.txtContainerBulk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtContainerBulk.CausesValidation = True
		Me.txtContainerBulk.Enabled = True
		Me.txtContainerBulk.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtContainerBulk.HideSelection = True
		Me.txtContainerBulk.Maxlength = 0
		Me.txtContainerBulk.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtContainerBulk.MultiLine = False
		Me.txtContainerBulk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtContainerBulk.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtContainerBulk.TabStop = True
		Me.txtContainerBulk.Visible = True
		Me.txtContainerBulk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtContainerBulk.Name = "txtContainerBulk"
		Me.txtContainerWeight.AutoSize = False
		Me.txtContainerWeight.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.txtContainerWeight.Size = New System.Drawing.Size(113, 19)
		Me.txtContainerWeight.Location = New System.Drawing.Point(216, 24)
		Me.txtContainerWeight.ReadOnly = True
		Me.txtContainerWeight.TabIndex = 74
		Me.txtContainerWeight.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtContainerWeight.AcceptsReturn = True
		Me.txtContainerWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtContainerWeight.CausesValidation = True
		Me.txtContainerWeight.Enabled = True
		Me.txtContainerWeight.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtContainerWeight.HideSelection = True
		Me.txtContainerWeight.Maxlength = 0
		Me.txtContainerWeight.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtContainerWeight.MultiLine = False
		Me.txtContainerWeight.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtContainerWeight.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtContainerWeight.TabStop = True
		Me.txtContainerWeight.Visible = True
		Me.txtContainerWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtContainerWeight.Name = "txtContainerWeight"
		Me.txtBulk.AutoSize = False
		Me.txtBulk.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.txtBulk.Size = New System.Drawing.Size(49, 19)
		Me.txtBulk.Location = New System.Drawing.Point(48, 48)
		Me.txtBulk.ReadOnly = True
		Me.txtBulk.Maxlength = 7
		Me.txtBulk.TabIndex = 73
		Me.txtBulk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtBulk.AcceptsReturn = True
		Me.txtBulk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtBulk.CausesValidation = True
		Me.txtBulk.Enabled = True
		Me.txtBulk.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtBulk.HideSelection = True
		Me.txtBulk.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtBulk.MultiLine = False
		Me.txtBulk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtBulk.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtBulk.TabStop = True
		Me.txtBulk.Visible = True
		Me.txtBulk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtBulk.Name = "txtBulk"
		Me.txtWeight.AutoSize = False
		Me.txtWeight.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.txtWeight.Size = New System.Drawing.Size(49, 19)
		Me.txtWeight.Location = New System.Drawing.Point(48, 24)
		Me.txtWeight.ReadOnly = True
		Me.txtWeight.Maxlength = 3
		Me.txtWeight.TabIndex = 71
		Me.txtWeight.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtWeight.AcceptsReturn = True
		Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtWeight.CausesValidation = True
		Me.txtWeight.Enabled = True
		Me.txtWeight.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtWeight.HideSelection = True
		Me.txtWeight.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtWeight.MultiLine = False
		Me.txtWeight.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtWeight.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtWeight.TabStop = True
		Me.txtWeight.Visible = True
		Me.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtWeight.Name = "txtWeight"
		Me.chkContainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.chkContainer.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.chkContainer.Text = "Container?"
		Me.chkContainer.ForeColor = System.Drawing.SystemColors.WindowText
		Me.chkContainer.Size = New System.Drawing.Size(97, 13)
		Me.chkContainer.Location = New System.Drawing.Point(216, 8)
		Me.chkContainer.TabIndex = 69
		Me.chkContainer.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkContainer.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkContainer.CausesValidation = True
		Me.chkContainer.Enabled = True
		Me.chkContainer.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkContainer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkContainer.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkContainer.TabStop = True
		Me.chkContainer.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkContainer.Visible = True
		Me.chkContainer.Name = "chkContainer"
		Me.Line1.BorderColor = System.Drawing.Color.FromARGB(192, 192, 192)
		Me.Line1.X1 = 208
		Me.Line1.X2 = 208
		Me.Line1.Y1 = -5
		Me.Line1.Y2 = 83
		Me.Line1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line1.BorderWidth = 1
		Me.Line1.Visible = True
		Me.Line1.Name = "Line1"
		Me.lblBulk.BackColor = System.Drawing.Color.Transparent
		Me.lblBulk.Text = "Bulk:"
		Me.lblBulk.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lblBulk.Size = New System.Drawing.Size(37, 13)
		Me.lblBulk.Location = New System.Drawing.Point(8, 48)
		Me.lblBulk.TabIndex = 72
		Me.lblBulk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBulk.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblBulk.Enabled = True
		Me.lblBulk.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblBulk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblBulk.UseMnemonic = True
		Me.lblBulk.Visible = True
		Me.lblBulk.AutoSize = False
		Me.lblBulk.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblBulk.Name = "lblBulk"
		Me._lblWeight_4.BackColor = System.Drawing.Color.Transparent
		Me._lblWeight_4.Text = "Weight:"
		Me._lblWeight_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lblWeight_4.Size = New System.Drawing.Size(37, 13)
		Me._lblWeight_4.Location = New System.Drawing.Point(8, 24)
		Me._lblWeight_4.TabIndex = 70
		Me._lblWeight_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblWeight_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblWeight_4.Enabled = True
		Me._lblWeight_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblWeight_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblWeight_4.UseMnemonic = True
		Me._lblWeight_4.Visible = True
		Me._lblWeight_4.AutoSize = False
		Me._lblWeight_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblWeight_4.Name = "_lblWeight_4"
		Me.lblContainerType.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblContainerType.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.lblContainerType.Text = "Type of container"
		Me.lblContainerType.Size = New System.Drawing.Size(49, 33)
		Me.lblContainerType.Location = New System.Drawing.Point(360, 24)
		Me.lblContainerType.TabIndex = 41
		Me.lblContainerType.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblContainerType.Enabled = True
		Me.lblContainerType.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblContainerType.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblContainerType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblContainerType.UseMnemonic = True
		Me.lblContainerType.Visible = True
		Me.lblContainerType.AutoSize = False
		Me.lblContainerType.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblContainerType.Name = "lblContainerType"
		Me.lblSoft.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblSoft.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.lblSoft.Size = New System.Drawing.Size(81, 17)
		Me.lblSoft.Location = New System.Drawing.Point(344, 56)
		Me.lblSoft.TabIndex = 40
		Me.lblSoft.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSoft.Enabled = True
		Me.lblSoft.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSoft.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSoft.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSoft.UseMnemonic = True
		Me.lblSoft.Visible = True
		Me.lblSoft.AutoSize = False
		Me.lblSoft.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSoft.Name = "lblSoft"
		Me.txtComments.AutoSize = False
		Me.txtComments.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.txtComments.Size = New System.Drawing.Size(193, 113)
		Me.txtComments.Location = New System.Drawing.Point(56, 88)
		Me.txtComments.ReadOnly = True
		Me.txtComments.MultiLine = True
		Me.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtComments.TabIndex = 38
		Me.txtComments.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtComments.AcceptsReturn = True
		Me.txtComments.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtComments.CausesValidation = True
		Me.txtComments.Enabled = True
		Me.txtComments.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtComments.HideSelection = True
		Me.txtComments.Maxlength = 0
		Me.txtComments.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtComments.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtComments.TabStop = True
		Me.txtComments.Visible = True
		Me.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtComments.Name = "txtComments"
		Me.picCreature.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.picCreature.Enabled = False
		Me.picCreature.Size = New System.Drawing.Size(109, 137)
		Me.picCreature.Location = New System.Drawing.Point(252, 64)
		Me.picCreature.TabIndex = 37
		Me.picCreature.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picCreature.Dock = System.Windows.Forms.DockStyle.None
		Me.picCreature.CausesValidation = True
		Me.picCreature.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picCreature.Cursor = System.Windows.Forms.Cursors.Default
		Me.picCreature.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picCreature.TabStop = True
		Me.picCreature.Visible = True
		Me.picCreature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picCreature.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picCreature.Name = "picCreature"
		Me.txtLevel.AutoSize = False
		Me.txtLevel.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.txtLevel.Size = New System.Drawing.Size(49, 19)
		Me.txtLevel.Location = New System.Drawing.Point(72, 216)
		Me.txtLevel.ReadOnly = True
		Me.txtLevel.Maxlength = 3
		Me.txtLevel.TabIndex = 36
		Me.txtLevel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLevel.AcceptsReturn = True
		Me.txtLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtLevel.CausesValidation = True
		Me.txtLevel.Enabled = True
		Me.txtLevel.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLevel.HideSelection = True
		Me.txtLevel.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLevel.MultiLine = False
		Me.txtLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLevel.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtLevel.TabStop = True
		Me.txtLevel.Visible = True
		Me.txtLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtLevel.Name = "txtLevel"
		Me.chkCanCombine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.chkCanCombine.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.chkCanCombine.Text = "Can combine?"
		Me.chkCanCombine.ForeColor = System.Drawing.SystemColors.WindowText
		Me.chkCanCombine.Size = New System.Drawing.Size(97, 13)
		Me.chkCanCombine.Location = New System.Drawing.Point(160, 43)
		Me.chkCanCombine.TabIndex = 35
		Me.chkCanCombine.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkCanCombine.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkCanCombine.CausesValidation = True
		Me.chkCanCombine.Enabled = True
		Me.chkCanCombine.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkCanCombine.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkCanCombine.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkCanCombine.TabStop = True
		Me.chkCanCombine.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkCanCombine.Visible = True
		Me.chkCanCombine.Name = "chkCanCombine"
		Me.txtSize.AutoSize = False
		Me.txtSize.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.txtSize.Size = New System.Drawing.Size(177, 17)
		Me.txtSize.Location = New System.Drawing.Point(72, 64)
		Me.txtSize.ReadOnly = True
		Me.txtSize.TabIndex = 34
		Me.txtSize.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSize.AcceptsReturn = True
		Me.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSize.CausesValidation = True
		Me.txtSize.Enabled = True
		Me.txtSize.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSize.HideSelection = True
		Me.txtSize.Maxlength = 0
		Me.txtSize.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSize.MultiLine = False
		Me.txtSize.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSize.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSize.TabStop = True
		Me.txtSize.Visible = True
		Me.txtSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSize.Name = "txtSize"
		Me.txtCount.AutoSize = False
		Me.txtCount.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.txtCount.Size = New System.Drawing.Size(57, 19)
		Me.txtCount.Location = New System.Drawing.Point(72, 40)
		Me.txtCount.ReadOnly = True
		Me.txtCount.TabIndex = 33
		Me.txtCount.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCount.AcceptsReturn = True
		Me.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCount.CausesValidation = True
		Me.txtCount.Enabled = True
		Me.txtCount.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCount.HideSelection = True
		Me.txtCount.Maxlength = 0
		Me.txtCount.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCount.MultiLine = False
		Me.txtCount.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCount.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCount.TabStop = True
		Me.txtCount.Visible = True
		Me.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCount.Name = "txtCount"
		Me.txtName.AutoSize = False
		Me.txtName.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.txtName.Size = New System.Drawing.Size(297, 19)
		Me.txtName.Location = New System.Drawing.Point(72, 13)
		Me.txtName.ReadOnly = True
		Me.txtName.TabIndex = 32
		Me.txtName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtName.AcceptsReturn = True
		Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtName.CausesValidation = True
		Me.txtName.Enabled = True
		Me.txtName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtName.HideSelection = True
		Me.txtName.Maxlength = 0
		Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtName.MultiLine = False
		Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtName.TabStop = True
		Me.txtName.Visible = True
		Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtName.Name = "txtName"
		Me.fraFood.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.fraFood.Text = "Food details"
		Me.fraFood.Size = New System.Drawing.Size(393, 145)
		Me.fraFood.Location = New System.Drawing.Point(504, 224)
		Me.fraFood.TabIndex = 30
		Me.fraFood.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraFood.Enabled = True
		Me.fraFood.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraFood.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraFood.Visible = True
		Me.fraFood.Padding = New System.Windows.Forms.Padding(0)
		Me.fraFood.Name = "fraFood"
		Me.lstFood.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.lstFood.Size = New System.Drawing.Size(377, 124)
		Me.lstFood.Location = New System.Drawing.Point(8, 16)
		Me.lstFood.TabIndex = 31
		Me.lstFood.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstFood.CausesValidation = True
		Me.lstFood.Enabled = True
		Me.lstFood.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstFood.IntegralHeight = True
		Me.lstFood.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstFood.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstFood.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstFood.Sorted = False
		Me.lstFood.TabStop = True
		Me.lstFood.Visible = True
		Me.lstFood.MultiColumn = False
		Me.lstFood.Name = "lstFood"
		Me.fraTriggers.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.fraTriggers.Text = "Triggers"
		Me.fraTriggers.Size = New System.Drawing.Size(201, 209)
		Me.fraTriggers.Location = New System.Drawing.Point(504, 8)
		Me.fraTriggers.TabIndex = 26
		Me.fraTriggers.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraTriggers.Enabled = True
		Me.fraTriggers.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraTriggers.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraTriggers.Visible = True
		Me.fraTriggers.Padding = New System.Windows.Forms.Padding(0)
		Me.fraTriggers.Name = "fraTriggers"
		Me.txtTriggComm.AutoSize = False
		Me.txtTriggComm.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.txtTriggComm.Size = New System.Drawing.Size(185, 97)
		Me.txtTriggComm.Location = New System.Drawing.Point(8, 104)
		Me.txtTriggComm.ReadOnly = True
		Me.txtTriggComm.MultiLine = True
		Me.txtTriggComm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtTriggComm.TabIndex = 28
		Me.txtTriggComm.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTriggComm.AcceptsReturn = True
		Me.txtTriggComm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTriggComm.CausesValidation = True
		Me.txtTriggComm.Enabled = True
		Me.txtTriggComm.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTriggComm.HideSelection = True
		Me.txtTriggComm.Maxlength = 0
		Me.txtTriggComm.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTriggComm.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTriggComm.TabStop = True
		Me.txtTriggComm.Visible = True
		Me.txtTriggComm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTriggComm.Name = "txtTriggComm"
		Me.lstTriggers.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.lstTriggers.Size = New System.Drawing.Size(185, 72)
		Me.lstTriggers.Location = New System.Drawing.Point(8, 16)
		Me.lstTriggers.TabIndex = 27
		Me.lstTriggers.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstTriggers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstTriggers.CausesValidation = True
		Me.lstTriggers.Enabled = True
		Me.lstTriggers.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstTriggers.IntegralHeight = True
		Me.lstTriggers.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstTriggers.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstTriggers.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstTriggers.Sorted = False
		Me.lstTriggers.TabStop = True
		Me.lstTriggers.Visible = True
		Me.lstTriggers.MultiColumn = False
		Me.lstTriggers.Name = "lstTriggers"
		Me.lblTriggComm.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.lblTriggComm.Text = "Trigger Comments :"
		Me.lblTriggComm.Size = New System.Drawing.Size(121, 17)
		Me.lblTriggComm.Location = New System.Drawing.Point(8, 88)
		Me.lblTriggComm.TabIndex = 29
		Me.lblTriggComm.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTriggComm.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTriggComm.Enabled = True
		Me.lblTriggComm.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTriggComm.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTriggComm.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTriggComm.UseMnemonic = True
		Me.lblTriggComm.Visible = True
		Me.lblTriggComm.AutoSize = False
		Me.lblTriggComm.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTriggComm.Name = "lblTriggComm"
		Me.fraFamily.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.fraFamily.Text = "Family"
		Me.fraFamily.Size = New System.Drawing.Size(297, 183)
		Me.fraFamily.Location = New System.Drawing.Point(40, 264)
		Me.fraFamily.TabIndex = 15
		Me.fraFamily.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraFamily.Enabled = True
		Me.fraFamily.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraFamily.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraFamily.Visible = True
		Me.fraFamily.Padding = New System.Windows.Forms.Padding(0)
		Me.fraFamily.Name = "fraFamily"
		Me.chk2hands.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.chk2hands.Text = "Two-handed?"
		Me.chk2hands.Size = New System.Drawing.Size(97, 17)
		Me.chk2hands.Location = New System.Drawing.Point(8, 160)
		Me.chk2hands.TabIndex = 87
		Me.chk2hands.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chk2hands.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chk2hands.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chk2hands.CausesValidation = True
		Me.chk2hands.Enabled = True
		Me.chk2hands.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chk2hands.Cursor = System.Windows.Forms.Cursors.Default
		Me.chk2hands.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chk2hands.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chk2hands.TabStop = True
		Me.chk2hands.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chk2hands.Visible = True
		Me.chk2hands.Name = "chk2hands"
		Me._chkFamily_18.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_18.Text = "Worthless currency"
		Me._chkFamily_18.Size = New System.Drawing.Size(129, 17)
		Me._chkFamily_18.Location = New System.Drawing.Point(144, 160)
		Me._chkFamily_18.TabIndex = 85
		Me._chkFamily_18.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_18.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_18.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_18.CausesValidation = True
		Me._chkFamily_18.Enabled = True
		Me._chkFamily_18.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFamily_18.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFamily_18.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFamily_18.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFamily_18.TabStop = True
		Me._chkFamily_18.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFamily_18.Visible = True
		Me._chkFamily_18.Name = "_chkFamily_18"
		Me._chkFamily_17.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_17.Text = "Durable"
		Me._chkFamily_17.Size = New System.Drawing.Size(105, 17)
		Me._chkFamily_17.Location = New System.Drawing.Point(144, 144)
		Me._chkFamily_17.TabIndex = 84
		Me._chkFamily_17.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_17.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_17.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_17.CausesValidation = True
		Me._chkFamily_17.Enabled = True
		Me._chkFamily_17.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFamily_17.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFamily_17.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFamily_17.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFamily_17.TabStop = True
		Me._chkFamily_17.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFamily_17.Visible = True
		Me._chkFamily_17.Name = "_chkFamily_17"
		Me._chkFamily_16.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_16.Text = "Jammed shut"
		Me._chkFamily_16.Size = New System.Drawing.Size(105, 17)
		Me._chkFamily_16.Location = New System.Drawing.Point(144, 128)
		Me._chkFamily_16.TabIndex = 83
		Me._chkFamily_16.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_16.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_16.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_16.CausesValidation = True
		Me._chkFamily_16.Enabled = True
		Me._chkFamily_16.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFamily_16.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFamily_16.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFamily_16.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFamily_16.TabStop = True
		Me._chkFamily_16.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFamily_16.Visible = True
		Me._chkFamily_16.Name = "_chkFamily_16"
		Me._chkFamily_15.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_15.Text = "Locked"
		Me._chkFamily_15.Size = New System.Drawing.Size(105, 17)
		Me._chkFamily_15.Location = New System.Drawing.Point(144, 112)
		Me._chkFamily_15.TabIndex = 82
		Me._chkFamily_15.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_15.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_15.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_15.CausesValidation = True
		Me._chkFamily_15.Enabled = True
		Me._chkFamily_15.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFamily_15.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFamily_15.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFamily_15.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFamily_15.TabStop = True
		Me._chkFamily_15.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFamily_15.Visible = True
		Me._chkFamily_15.Name = "_chkFamily_15"
		Me._chkFamily_14.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_14.Text = "Fragile"
		Me._chkFamily_14.Size = New System.Drawing.Size(105, 17)
		Me._chkFamily_14.Location = New System.Drawing.Point(144, 96)
		Me._chkFamily_14.TabIndex = 81
		Me._chkFamily_14.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_14.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_14.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_14.CausesValidation = True
		Me._chkFamily_14.Enabled = True
		Me._chkFamily_14.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFamily_14.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFamily_14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFamily_14.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFamily_14.TabStop = True
		Me._chkFamily_14.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFamily_14.Visible = True
		Me._chkFamily_14.Name = "_chkFamily_14"
		Me._chkFamily_13.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_13.Text = "Random junk"
		Me._chkFamily_13.Size = New System.Drawing.Size(105, 17)
		Me._chkFamily_13.Location = New System.Drawing.Point(144, 80)
		Me._chkFamily_13.TabIndex = 80
		Me._chkFamily_13.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_13.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_13.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_13.CausesValidation = True
		Me._chkFamily_13.Enabled = True
		Me._chkFamily_13.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFamily_13.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFamily_13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFamily_13.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFamily_13.TabStop = True
		Me._chkFamily_13.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFamily_13.Visible = True
		Me._chkFamily_13.Name = "_chkFamily_13"
		Me._chkFamily_12.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_12.Text = "Random treasure"
		Me._chkFamily_12.Size = New System.Drawing.Size(105, 17)
		Me._chkFamily_12.Location = New System.Drawing.Point(144, 64)
		Me._chkFamily_12.TabIndex = 79
		Me._chkFamily_12.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_12.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_12.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_12.CausesValidation = True
		Me._chkFamily_12.Enabled = True
		Me._chkFamily_12.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFamily_12.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFamily_12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFamily_12.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFamily_12.TabStop = True
		Me._chkFamily_12.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFamily_12.Visible = True
		Me._chkFamily_12.Name = "_chkFamily_12"
		Me._chkFamily_11.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_11.Text = "Random gems"
		Me._chkFamily_11.Size = New System.Drawing.Size(105, 17)
		Me._chkFamily_11.Location = New System.Drawing.Point(144, 48)
		Me._chkFamily_11.TabIndex = 78
		Me._chkFamily_11.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_11.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_11.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_11.CausesValidation = True
		Me._chkFamily_11.Enabled = True
		Me._chkFamily_11.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFamily_11.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFamily_11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFamily_11.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFamily_11.TabStop = True
		Me._chkFamily_11.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFamily_11.Visible = True
		Me._chkFamily_11.Name = "_chkFamily_11"
		Me._chkFamily_10.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_10.Text = "Random armor"
		Me._chkFamily_10.Size = New System.Drawing.Size(105, 17)
		Me._chkFamily_10.Location = New System.Drawing.Point(144, 32)
		Me._chkFamily_10.TabIndex = 77
		Me._chkFamily_10.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_10.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_10.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_10.CausesValidation = True
		Me._chkFamily_10.Enabled = True
		Me._chkFamily_10.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFamily_10.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFamily_10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFamily_10.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFamily_10.TabStop = True
		Me._chkFamily_10.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFamily_10.Visible = True
		Me._chkFamily_10.Name = "_chkFamily_10"
		Me._chkFamily_8.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_8.Text = "Weapon (thrown)"
		Me._chkFamily_8.Size = New System.Drawing.Size(105, 17)
		Me._chkFamily_8.Location = New System.Drawing.Point(8, 144)
		Me._chkFamily_8.TabIndex = 25
		Me._chkFamily_8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_8.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_8.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_8.CausesValidation = True
		Me._chkFamily_8.Enabled = True
		Me._chkFamily_8.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFamily_8.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFamily_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFamily_8.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFamily_8.TabStop = True
		Me._chkFamily_8.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFamily_8.Visible = True
		Me._chkFamily_8.Name = "_chkFamily_8"
		Me._chkFamily_9.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_9.Text = "Random weapon"
		Me._chkFamily_9.Size = New System.Drawing.Size(105, 17)
		Me._chkFamily_9.Location = New System.Drawing.Point(144, 16)
		Me._chkFamily_9.TabIndex = 24
		Me._chkFamily_9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_9.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_9.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_9.CausesValidation = True
		Me._chkFamily_9.Enabled = True
		Me._chkFamily_9.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFamily_9.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFamily_9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFamily_9.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFamily_9.TabStop = True
		Me._chkFamily_9.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFamily_9.Visible = True
		Me._chkFamily_9.Name = "_chkFamily_9"
		Me._chkFamily_4.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_4.Text = "Armor"
		Me._chkFamily_4.Size = New System.Drawing.Size(65, 17)
		Me._chkFamily_4.Location = New System.Drawing.Point(8, 80)
		Me._chkFamily_4.TabIndex = 23
		Me._chkFamily_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_4.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_4.CausesValidation = True
		Me._chkFamily_4.Enabled = True
		Me._chkFamily_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFamily_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFamily_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFamily_4.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFamily_4.TabStop = True
		Me._chkFamily_4.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFamily_4.Visible = True
		Me._chkFamily_4.Name = "_chkFamily_4"
		Me._chkFamily_5.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_5.Text = "Weapon (melee)"
		Me._chkFamily_5.Size = New System.Drawing.Size(105, 17)
		Me._chkFamily_5.Location = New System.Drawing.Point(8, 96)
		Me._chkFamily_5.TabIndex = 22
		Me._chkFamily_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_5.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_5.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_5.CausesValidation = True
		Me._chkFamily_5.Enabled = True
		Me._chkFamily_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFamily_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFamily_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFamily_5.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFamily_5.TabStop = True
		Me._chkFamily_5.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFamily_5.Visible = True
		Me._chkFamily_5.Name = "_chkFamily_5"
		Me._chkFamily_6.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_6.Text = "Weapon (ammo)"
		Me._chkFamily_6.Size = New System.Drawing.Size(105, 17)
		Me._chkFamily_6.Location = New System.Drawing.Point(8, 112)
		Me._chkFamily_6.TabIndex = 21
		Me._chkFamily_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_6.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_6.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_6.CausesValidation = True
		Me._chkFamily_6.Enabled = True
		Me._chkFamily_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFamily_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFamily_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFamily_6.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFamily_6.TabStop = True
		Me._chkFamily_6.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFamily_6.Visible = True
		Me._chkFamily_6.Name = "_chkFamily_6"
		Me._chkFamily_7.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_7.Text = "Weapon (ranged)"
		Me._chkFamily_7.Size = New System.Drawing.Size(105, 17)
		Me._chkFamily_7.Location = New System.Drawing.Point(8, 128)
		Me._chkFamily_7.TabIndex = 20
		Me._chkFamily_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_7.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_7.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_7.CausesValidation = True
		Me._chkFamily_7.Enabled = True
		Me._chkFamily_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFamily_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFamily_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFamily_7.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFamily_7.TabStop = True
		Me._chkFamily_7.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFamily_7.Visible = True
		Me._chkFamily_7.Name = "_chkFamily_7"
		Me._chkFamily_3.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_3.Text = "Food"
		Me._chkFamily_3.Size = New System.Drawing.Size(65, 17)
		Me._chkFamily_3.Location = New System.Drawing.Point(8, 64)
		Me._chkFamily_3.TabIndex = 19
		Me._chkFamily_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_3.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_3.CausesValidation = True
		Me._chkFamily_3.Enabled = True
		Me._chkFamily_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFamily_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFamily_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFamily_3.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFamily_3.TabStop = True
		Me._chkFamily_3.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFamily_3.Visible = True
		Me._chkFamily_3.Name = "_chkFamily_3"
		Me._chkFamily_2.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_2.Text = "Money"
		Me._chkFamily_2.Size = New System.Drawing.Size(65, 17)
		Me._chkFamily_2.Location = New System.Drawing.Point(8, 48)
		Me._chkFamily_2.TabIndex = 18
		Me._chkFamily_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_2.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_2.CausesValidation = True
		Me._chkFamily_2.Enabled = True
		Me._chkFamily_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFamily_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFamily_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFamily_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFamily_2.TabStop = True
		Me._chkFamily_2.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFamily_2.Visible = True
		Me._chkFamily_2.Name = "_chkFamily_2"
		Me._chkFamily_1.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_1.Text = "Key"
		Me._chkFamily_1.Size = New System.Drawing.Size(65, 17)
		Me._chkFamily_1.Location = New System.Drawing.Point(8, 32)
		Me._chkFamily_1.TabIndex = 17
		Me._chkFamily_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_1.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_1.CausesValidation = True
		Me._chkFamily_1.Enabled = True
		Me._chkFamily_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFamily_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFamily_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFamily_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFamily_1.TabStop = True
		Me._chkFamily_1.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFamily_1.Visible = True
		Me._chkFamily_1.Name = "_chkFamily_1"
		Me._chkFamily_0.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_0.Text = "None"
		Me._chkFamily_0.Size = New System.Drawing.Size(65, 17)
		Me._chkFamily_0.Location = New System.Drawing.Point(8, 16)
		Me._chkFamily_0.TabIndex = 16
		Me._chkFamily_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_0.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_0.CausesValidation = True
		Me._chkFamily_0.Enabled = True
		Me._chkFamily_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFamily_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFamily_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFamily_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFamily_0.TabStop = True
		Me._chkFamily_0.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFamily_0.Visible = True
		Me._chkFamily_0.Name = "_chkFamily_0"
		Me.fraStats.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.fraStats.Text = "Statistics"
		Me.fraStats.Size = New System.Drawing.Size(129, 209)
		Me.fraStats.Location = New System.Drawing.Point(344, 240)
		Me.fraStats.TabIndex = 2
		Me.fraStats.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraStats.Enabled = True
		Me.fraStats.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraStats.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraStats.Visible = True
		Me.fraStats.Padding = New System.Windows.Forms.Padding(0)
		Me.fraStats.Name = "fraStats"
		Me._txtStats_7.AutoSize = False
		Me._txtStats_7.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtStats_7.Size = New System.Drawing.Size(49, 19)
		Me._txtStats_7.Location = New System.Drawing.Point(72, 112)
		Me._txtStats_7.ReadOnly = True
		Me._txtStats_7.TabIndex = 89
		Me._txtStats_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtStats_7.AcceptsReturn = True
		Me._txtStats_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtStats_7.CausesValidation = True
		Me._txtStats_7.Enabled = True
		Me._txtStats_7.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtStats_7.HideSelection = True
		Me._txtStats_7.Maxlength = 0
		Me._txtStats_7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtStats_7.MultiLine = False
		Me._txtStats_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtStats_7.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtStats_7.TabStop = True
		Me._txtStats_7.Visible = True
		Me._txtStats_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtStats_7.Name = "_txtStats_7"
		Me._txtStats_6.AutoSize = False
		Me._txtStats_6.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtStats_6.Size = New System.Drawing.Size(49, 19)
		Me._txtStats_6.Location = New System.Drawing.Point(72, 184)
		Me._txtStats_6.ReadOnly = True
		Me._txtStats_6.TabIndex = 68
		Me._txtStats_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtStats_6.AcceptsReturn = True
		Me._txtStats_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtStats_6.CausesValidation = True
		Me._txtStats_6.Enabled = True
		Me._txtStats_6.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtStats_6.HideSelection = True
		Me._txtStats_6.Maxlength = 0
		Me._txtStats_6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtStats_6.MultiLine = False
		Me._txtStats_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtStats_6.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtStats_6.TabStop = True
		Me._txtStats_6.Visible = True
		Me._txtStats_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtStats_6.Name = "_txtStats_6"
		Me._txtStats_5.AutoSize = False
		Me._txtStats_5.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtStats_5.Size = New System.Drawing.Size(49, 19)
		Me._txtStats_5.Location = New System.Drawing.Point(72, 160)
		Me._txtStats_5.ReadOnly = True
		Me._txtStats_5.TabIndex = 8
		Me._txtStats_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtStats_5.AcceptsReturn = True
		Me._txtStats_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtStats_5.CausesValidation = True
		Me._txtStats_5.Enabled = True
		Me._txtStats_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtStats_5.HideSelection = True
		Me._txtStats_5.Maxlength = 0
		Me._txtStats_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtStats_5.MultiLine = False
		Me._txtStats_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtStats_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtStats_5.TabStop = True
		Me._txtStats_5.Visible = True
		Me._txtStats_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtStats_5.Name = "_txtStats_5"
		Me._txtStats_4.AutoSize = False
		Me._txtStats_4.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtStats_4.Size = New System.Drawing.Size(49, 19)
		Me._txtStats_4.Location = New System.Drawing.Point(72, 136)
		Me._txtStats_4.ReadOnly = True
		Me._txtStats_4.TabIndex = 7
		Me._txtStats_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtStats_4.AcceptsReturn = True
		Me._txtStats_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtStats_4.CausesValidation = True
		Me._txtStats_4.Enabled = True
		Me._txtStats_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtStats_4.HideSelection = True
		Me._txtStats_4.Maxlength = 0
		Me._txtStats_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtStats_4.MultiLine = False
		Me._txtStats_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtStats_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtStats_4.TabStop = True
		Me._txtStats_4.Visible = True
		Me._txtStats_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtStats_4.Name = "_txtStats_4"
		Me._txtStats_3.AutoSize = False
		Me._txtStats_3.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtStats_3.Size = New System.Drawing.Size(49, 19)
		Me._txtStats_3.Location = New System.Drawing.Point(72, 88)
		Me._txtStats_3.ReadOnly = True
		Me._txtStats_3.TabIndex = 6
		Me._txtStats_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtStats_3.AcceptsReturn = True
		Me._txtStats_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtStats_3.CausesValidation = True
		Me._txtStats_3.Enabled = True
		Me._txtStats_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtStats_3.HideSelection = True
		Me._txtStats_3.Maxlength = 0
		Me._txtStats_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtStats_3.MultiLine = False
		Me._txtStats_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtStats_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtStats_3.TabStop = True
		Me._txtStats_3.Visible = True
		Me._txtStats_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtStats_3.Name = "_txtStats_3"
		Me._txtStats_2.AutoSize = False
		Me._txtStats_2.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtStats_2.Size = New System.Drawing.Size(49, 19)
		Me._txtStats_2.Location = New System.Drawing.Point(72, 64)
		Me._txtStats_2.ReadOnly = True
		Me._txtStats_2.TabIndex = 5
		Me._txtStats_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtStats_2.AcceptsReturn = True
		Me._txtStats_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtStats_2.CausesValidation = True
		Me._txtStats_2.Enabled = True
		Me._txtStats_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtStats_2.HideSelection = True
		Me._txtStats_2.Maxlength = 0
		Me._txtStats_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtStats_2.MultiLine = False
		Me._txtStats_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtStats_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtStats_2.TabStop = True
		Me._txtStats_2.Visible = True
		Me._txtStats_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtStats_2.Name = "_txtStats_2"
		Me._txtStats_1.AutoSize = False
		Me._txtStats_1.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtStats_1.Size = New System.Drawing.Size(49, 19)
		Me._txtStats_1.Location = New System.Drawing.Point(72, 40)
		Me._txtStats_1.ReadOnly = True
		Me._txtStats_1.TabIndex = 4
		Me._txtStats_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtStats_1.AcceptsReturn = True
		Me._txtStats_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtStats_1.CausesValidation = True
		Me._txtStats_1.Enabled = True
		Me._txtStats_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtStats_1.HideSelection = True
		Me._txtStats_1.Maxlength = 0
		Me._txtStats_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtStats_1.MultiLine = False
		Me._txtStats_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtStats_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtStats_1.TabStop = True
		Me._txtStats_1.Visible = True
		Me._txtStats_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtStats_1.Name = "_txtStats_1"
		Me._txtStats_0.AutoSize = False
		Me._txtStats_0.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtStats_0.Size = New System.Drawing.Size(49, 19)
		Me._txtStats_0.Location = New System.Drawing.Point(72, 16)
		Me._txtStats_0.ReadOnly = True
		Me._txtStats_0.TabIndex = 3
		Me._txtStats_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtStats_0.AcceptsReturn = True
		Me._txtStats_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtStats_0.CausesValidation = True
		Me._txtStats_0.Enabled = True
		Me._txtStats_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtStats_0.HideSelection = True
		Me._txtStats_0.Maxlength = 0
		Me._txtStats_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtStats_0.MultiLine = False
		Me._txtStats_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtStats_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtStats_0.TabStop = True
		Me._txtStats_0.Visible = True
		Me._txtStats_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtStats_0.Name = "_txtStats_0"
		Me._lblStats_7.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblStats_7.Text = "Dmg bonus"
		Me._lblStats_7.Size = New System.Drawing.Size(73, 17)
		Me._lblStats_7.Location = New System.Drawing.Point(8, 112)
		Me._lblStats_7.TabIndex = 88
		Me._lblStats_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblStats_7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblStats_7.Enabled = True
		Me._lblStats_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblStats_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblStats_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblStats_7.UseMnemonic = True
		Me._lblStats_7.Visible = True
		Me._lblStats_7.AutoSize = False
		Me._lblStats_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblStats_7.Name = "_lblStats_7"
		Me._lblStats_6.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblStats_6.Text = "Ammo type"
		Me._lblStats_6.Size = New System.Drawing.Size(73, 17)
		Me._lblStats_6.Location = New System.Drawing.Point(8, 184)
		Me._lblStats_6.TabIndex = 67
		Me._lblStats_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblStats_6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblStats_6.Enabled = True
		Me._lblStats_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblStats_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblStats_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblStats_6.UseMnemonic = True
		Me._lblStats_6.Visible = True
		Me._lblStats_6.AutoSize = False
		Me._lblStats_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblStats_6.Name = "_lblStats_6"
		Me._lblStats_5.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblStats_5.Text = "Range"
		Me._lblStats_5.Size = New System.Drawing.Size(73, 17)
		Me._lblStats_5.Location = New System.Drawing.Point(8, 160)
		Me._lblStats_5.TabIndex = 14
		Me._lblStats_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblStats_5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblStats_5.Enabled = True
		Me._lblStats_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblStats_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblStats_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblStats_5.UseMnemonic = True
		Me._lblStats_5.Visible = True
		Me._lblStats_5.AutoSize = False
		Me._lblStats_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblStats_5.Name = "_lblStats_5"
		Me._lblStats_4.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblStats_4.Text = "Damage type"
		Me._lblStats_4.Size = New System.Drawing.Size(73, 17)
		Me._lblStats_4.Location = New System.Drawing.Point(8, 136)
		Me._lblStats_4.TabIndex = 13
		Me._lblStats_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblStats_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblStats_4.Enabled = True
		Me._lblStats_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblStats_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblStats_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblStats_4.UseMnemonic = True
		Me._lblStats_4.Visible = True
		Me._lblStats_4.AutoSize = False
		Me._lblStats_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblStats_4.Name = "_lblStats_4"
		Me._lblStats_3.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblStats_3.Text = "Damage"
		Me._lblStats_3.Size = New System.Drawing.Size(73, 17)
		Me._lblStats_3.Location = New System.Drawing.Point(8, 88)
		Me._lblStats_3.TabIndex = 12
		Me._lblStats_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblStats_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblStats_3.Enabled = True
		Me._lblStats_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblStats_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblStats_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblStats_3.UseMnemonic = True
		Me._lblStats_3.Visible = True
		Me._lblStats_3.AutoSize = False
		Me._lblStats_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblStats_3.Name = "_lblStats_3"
		Me._lblStats_2.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblStats_2.Text = "Defense"
		Me._lblStats_2.Size = New System.Drawing.Size(57, 17)
		Me._lblStats_2.Location = New System.Drawing.Point(8, 64)
		Me._lblStats_2.TabIndex = 11
		Me._lblStats_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblStats_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblStats_2.Enabled = True
		Me._lblStats_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblStats_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblStats_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblStats_2.UseMnemonic = True
		Me._lblStats_2.Visible = True
		Me._lblStats_2.AutoSize = False
		Me._lblStats_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblStats_2.Name = "_lblStats_2"
		Me._lblStats_1.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblStats_1.Text = "Attack bonus"
		Me._lblStats_1.Size = New System.Drawing.Size(73, 17)
		Me._lblStats_1.Location = New System.Drawing.Point(8, 40)
		Me._lblStats_1.TabIndex = 10
		Me._lblStats_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblStats_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblStats_1.Enabled = True
		Me._lblStats_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblStats_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblStats_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblStats_1.UseMnemonic = True
		Me._lblStats_1.Visible = True
		Me._lblStats_1.AutoSize = False
		Me._lblStats_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblStats_1.Name = "_lblStats_1"
		Me._lblStats_0.BackColor = System.Drawing.Color.Transparent
		Me._lblStats_0.Text = "Action Points"
		Me._lblStats_0.Size = New System.Drawing.Size(73, 17)
		Me._lblStats_0.Location = New System.Drawing.Point(8, 17)
		Me._lblStats_0.TabIndex = 9
		Me._lblStats_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblStats_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblStats_0.Enabled = True
		Me._lblStats_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblStats_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblStats_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblStats_0.UseMnemonic = True
		Me._lblStats_0.Visible = True
		Me._lblStats_0.AutoSize = False
		Me._lblStats_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblStats_0.Name = "_lblStats_0"
		Me.lblValue.BackColor = System.Drawing.Color.Transparent
		Me.lblValue.Text = "Value:"
		Me.lblValue.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lblValue.Size = New System.Drawing.Size(37, 13)
		Me.lblValue.Location = New System.Drawing.Point(40, 246)
		Me.lblValue.TabIndex = 65
		Me.lblValue.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblValue.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblValue.Enabled = True
		Me.lblValue.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblValue.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblValue.UseMnemonic = True
		Me.lblValue.Visible = True
		Me.lblValue.AutoSize = False
		Me.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblValue.Name = "lblValue"
		Me.lblSize.Text = "Size : "
		Me.lblSize.Size = New System.Drawing.Size(33, 17)
		Me.lblSize.Location = New System.Drawing.Point(40, 66)
		Me.lblSize.TabIndex = 47
		Me.lblSize.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSize.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSize.BackColor = System.Drawing.Color.Transparent
		Me.lblSize.Enabled = True
		Me.lblSize.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSize.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSize.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSize.UseMnemonic = True
		Me.lblSize.Visible = True
		Me.lblSize.AutoSize = False
		Me.lblSize.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSize.Name = "lblSize"
		Me.lblCount.Text = "Count:"
		Me.lblCount.Size = New System.Drawing.Size(41, 17)
		Me.lblCount.Location = New System.Drawing.Point(40, 43)
		Me.lblCount.TabIndex = 64
		Me.lblCount.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCount.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCount.BackColor = System.Drawing.Color.Transparent
		Me.lblCount.Enabled = True
		Me.lblCount.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCount.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCount.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCount.UseMnemonic = True
		Me.lblCount.Visible = True
		Me.lblCount.AutoSize = False
		Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCount.Name = "lblCount"
		Me.lblLevel.Text = "Level:"
		Me.lblLevel.Size = New System.Drawing.Size(33, 17)
		Me.lblLevel.Location = New System.Drawing.Point(40, 219)
		Me.lblLevel.TabIndex = 63
		Me.lblLevel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLevel.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblLevel.BackColor = System.Drawing.Color.Transparent
		Me.lblLevel.Enabled = True
		Me.lblLevel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLevel.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLevel.UseMnemonic = True
		Me.lblLevel.Visible = True
		Me.lblLevel.AutoSize = False
		Me.lblLevel.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblLevel.Name = "lblLevel"
		Me.lblName.Text = "Name:"
		Me.lblName.Size = New System.Drawing.Size(41, 17)
		Me.lblName.Location = New System.Drawing.Point(40, 16)
		Me.lblName.TabIndex = 62
		Me.lblName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblName.BackColor = System.Drawing.Color.Transparent
		Me.lblName.Enabled = True
		Me.lblName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblName.UseMnemonic = True
		Me.lblName.Visible = True
		Me.lblName.AutoSize = False
		Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblName.Name = "lblName"
		Me.imgBook.Size = New System.Drawing.Size(987, 564)
		Me.imgBook.Location = New System.Drawing.Point(1, 1)
		Me.imgBook.Image = CType(resources.GetObject("imgBook.Image"), System.Drawing.Image)
		Me.imgBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.imgBook.Enabled = True
		Me.imgBook.Cursor = System.Windows.Forms.Cursors.Default
		Me.imgBook.Visible = True
		Me.imgBook.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.imgBook.Name = "imgBook"
		Me.drvList.Size = New System.Drawing.Size(145, 21)
		Me.drvList.Location = New System.Drawing.Point(8, 48)
		Me.drvList.TabIndex = 0
		Me.drvList.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.drvList.BackColor = System.Drawing.SystemColors.Window
		Me.drvList.CausesValidation = True
		Me.drvList.Enabled = True
		Me.drvList.ForeColor = System.Drawing.SystemColors.WindowText
		Me.drvList.Cursor = System.Windows.Forms.Cursors.Default
		Me.drvList.TabStop = True
		Me.drvList.Visible = True
		Me.drvList.Name = "drvList"
		Me.fraCompactView.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.fraCompactView.Size = New System.Drawing.Size(401, 313)
		Me.fraCompactView.Location = New System.Drawing.Point(152, 32)
		Me.fraCompactView.TabIndex = 48
		Me.fraCompactView.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraCompactView.BackColor = System.Drawing.SystemColors.Control
		Me.fraCompactView.Enabled = True
		Me.fraCompactView.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraCompactView.Cursor = System.Windows.Forms.Cursors.Default
		Me.fraCompactView.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraCompactView.Visible = True
		Me.fraCompactView.Name = "fraCompactView"
		Me.picCreatureCompact.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.picCreatureCompact.Enabled = False
		Me.picCreatureCompact.Size = New System.Drawing.Size(109, 137)
		Me.picCreatureCompact.Location = New System.Drawing.Point(8, 16)
		Me.picCreatureCompact.TabIndex = 50
		Me.picCreatureCompact.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picCreatureCompact.Dock = System.Windows.Forms.DockStyle.None
		Me.picCreatureCompact.CausesValidation = True
		Me.picCreatureCompact.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picCreatureCompact.Cursor = System.Windows.Forms.Cursors.Default
		Me.picCreatureCompact.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picCreatureCompact.TabStop = True
		Me.picCreatureCompact.Visible = True
		Me.picCreatureCompact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picCreatureCompact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picCreatureCompact.Name = "picCreatureCompact"
		Me.txtInfo.AutoSize = False
		Me.txtInfo.Size = New System.Drawing.Size(265, 297)
		Me.txtInfo.Location = New System.Drawing.Point(128, 16)
		Me.txtInfo.ReadOnly = True
		Me.txtInfo.MultiLine = True
		Me.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.txtInfo.WordWrap = False
		Me.txtInfo.TabIndex = 49
		Me.txtInfo.Text = "Click an item file name to display its info" & Chr(13) & Chr(10)
		Me.txtInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtInfo.AcceptsReturn = True
		Me.txtInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtInfo.BackColor = System.Drawing.SystemColors.Window
		Me.txtInfo.CausesValidation = True
		Me.txtInfo.Enabled = True
		Me.txtInfo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtInfo.HideSelection = True
		Me.txtInfo.Maxlength = 0
		Me.txtInfo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtInfo.TabStop = True
		Me.txtInfo.Visible = True
		Me.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtInfo.Name = "txtInfo"
		Me.lblPath.Text = "DataPath : "
		Me.lblPath.Size = New System.Drawing.Size(65, 25)
		Me.lblPath.Location = New System.Drawing.Point(8, 8)
		Me.lblPath.TabIndex = 58
		Me.lblPath.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPath.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPath.BackColor = System.Drawing.SystemColors.Control
		Me.lblPath.Enabled = True
		Me.lblPath.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPath.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPath.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPath.UseMnemonic = True
		Me.lblPath.Visible = True
		Me.lblPath.AutoSize = False
		Me.lblPath.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPath.Name = "lblPath"
		Me.lblFiles.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblFiles.Text = "ItemFiles"
		Me.lblFiles.Size = New System.Drawing.Size(145, 17)
		Me.lblFiles.Location = New System.Drawing.Point(8, 232)
		Me.lblFiles.TabIndex = 57
		Me.lblFiles.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFiles.BackColor = System.Drawing.SystemColors.Control
		Me.lblFiles.Enabled = True
		Me.lblFiles.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblFiles.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblFiles.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblFiles.UseMnemonic = True
		Me.lblFiles.Visible = True
		Me.lblFiles.AutoSize = False
		Me.lblFiles.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblFiles.Name = "lblFiles"
		Me.lblDirectory.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblDirectory.Text = "Directory"
		Me.lblDirectory.Size = New System.Drawing.Size(145, 17)
		Me.lblDirectory.Location = New System.Drawing.Point(8, 72)
		Me.lblDirectory.TabIndex = 56
		Me.lblDirectory.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDirectory.BackColor = System.Drawing.SystemColors.Control
		Me.lblDirectory.Enabled = True
		Me.lblDirectory.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDirectory.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDirectory.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDirectory.UseMnemonic = True
		Me.lblDirectory.Visible = True
		Me.lblDirectory.AutoSize = False
		Me.lblDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDirectory.Name = "lblDirectory"
		Me.lblDrive.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblDrive.Text = "Drive"
		Me.lblDrive.Size = New System.Drawing.Size(145, 17)
		Me.lblDrive.Location = New System.Drawing.Point(8, 32)
		Me.lblDrive.TabIndex = 55
		Me.lblDrive.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDrive.BackColor = System.Drawing.SystemColors.Control
		Me.lblDrive.Enabled = True
		Me.lblDrive.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDrive.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDrive.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDrive.UseMnemonic = True
		Me.lblDrive.Visible = True
		Me.lblDrive.AutoSize = False
		Me.lblDrive.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDrive.Name = "lblDrive"
		Me.chkFamily.SetIndex(_chkFamily_18, CType(18, Short))
		Me.chkFamily.SetIndex(_chkFamily_17, CType(17, Short))
		Me.chkFamily.SetIndex(_chkFamily_16, CType(16, Short))
		Me.chkFamily.SetIndex(_chkFamily_15, CType(15, Short))
		Me.chkFamily.SetIndex(_chkFamily_14, CType(14, Short))
		Me.chkFamily.SetIndex(_chkFamily_13, CType(13, Short))
		Me.chkFamily.SetIndex(_chkFamily_12, CType(12, Short))
		Me.chkFamily.SetIndex(_chkFamily_11, CType(11, Short))
		Me.chkFamily.SetIndex(_chkFamily_10, CType(10, Short))
		Me.chkFamily.SetIndex(_chkFamily_8, CType(8, Short))
		Me.chkFamily.SetIndex(_chkFamily_9, CType(9, Short))
		Me.chkFamily.SetIndex(_chkFamily_4, CType(4, Short))
		Me.chkFamily.SetIndex(_chkFamily_5, CType(5, Short))
		Me.chkFamily.SetIndex(_chkFamily_6, CType(6, Short))
		Me.chkFamily.SetIndex(_chkFamily_7, CType(7, Short))
		Me.chkFamily.SetIndex(_chkFamily_3, CType(3, Short))
		Me.chkFamily.SetIndex(_chkFamily_2, CType(2, Short))
		Me.chkFamily.SetIndex(_chkFamily_1, CType(1, Short))
		Me.chkFamily.SetIndex(_chkFamily_0, CType(0, Short))
		Me.lblStats.SetIndex(_lblStats_7, CType(7, Short))
		Me.lblStats.SetIndex(_lblStats_6, CType(6, Short))
		Me.lblStats.SetIndex(_lblStats_5, CType(5, Short))
		Me.lblStats.SetIndex(_lblStats_4, CType(4, Short))
		Me.lblStats.SetIndex(_lblStats_3, CType(3, Short))
		Me.lblStats.SetIndex(_lblStats_2, CType(2, Short))
		Me.lblStats.SetIndex(_lblStats_1, CType(1, Short))
		Me.lblStats.SetIndex(_lblStats_0, CType(0, Short))
		Me.lblWeight.SetIndex(_lblWeight_4, CType(4, Short))
		Me.txtStats.SetIndex(_txtStats_7, CType(7, Short))
		Me.txtStats.SetIndex(_txtStats_6, CType(6, Short))
		Me.txtStats.SetIndex(_txtStats_5, CType(5, Short))
		Me.txtStats.SetIndex(_txtStats_4, CType(4, Short))
		Me.txtStats.SetIndex(_txtStats_3, CType(3, Short))
		Me.txtStats.SetIndex(_txtStats_2, CType(2, Short))
		Me.txtStats.SetIndex(_txtStats_1, CType(1, Short))
		Me.txtStats.SetIndex(_txtStats_0, CType(0, Short))
		CType(Me.txtStats, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblWeight, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblStats, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chkFamily, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(txtValue)
		Me.Controls.Add(btnInsert)
		Me.Controls.Add(picMask)
		Me.Controls.Add(picItem)
		Me.Controls.Add(cmdClose)
		Me.Controls.Add(flsFileList)
		Me.Controls.Add(txtDataPath)
		Me.Controls.Add(dlstDirectory)
		Me.Controls.Add(fraFullView)
		Me.Controls.Add(drvList)
		Me.Controls.Add(fraCompactView)
		Me.Controls.Add(lblPath)
		Me.Controls.Add(lblFiles)
		Me.Controls.Add(lblDirectory)
		Me.Controls.Add(lblDrive)
		Me.fraFullView.Controls.Add(fraItems)
		Me.fraFullView.Controls.Add(fraArmor)
		Me.fraFullView.Controls.Add(fraEncumbrance)
		Me.fraFullView.Controls.Add(txtComments)
		Me.fraFullView.Controls.Add(picCreature)
		Me.fraFullView.Controls.Add(txtLevel)
		Me.fraFullView.Controls.Add(chkCanCombine)
		Me.fraFullView.Controls.Add(txtSize)
		Me.fraFullView.Controls.Add(txtCount)
		Me.fraFullView.Controls.Add(txtName)
		Me.fraFullView.Controls.Add(fraFood)
		Me.fraFullView.Controls.Add(fraTriggers)
		Me.fraFullView.Controls.Add(fraFamily)
		Me.fraFullView.Controls.Add(fraStats)
		Me.fraFullView.Controls.Add(lblValue)
		Me.fraFullView.Controls.Add(lblSize)
		Me.fraFullView.Controls.Add(lblCount)
		Me.fraFullView.Controls.Add(lblLevel)
		Me.fraFullView.Controls.Add(lblName)
		Me.fraFullView.Controls.Add(imgBook)
		Me.fraItems.Controls.Add(txtItemComments)
		Me.fraItems.Controls.Add(lstItems)
		Me.fraItems.Controls.Add(lblItemComments)
		Me.fraArmor.Controls.Add(lstArmor)
		Me.fraEncumbrance.Controls.Add(txtCapacity)
		Me.fraEncumbrance.Controls.Add(txtContainerBulk)
		Me.fraEncumbrance.Controls.Add(txtContainerWeight)
		Me.fraEncumbrance.Controls.Add(txtBulk)
		Me.fraEncumbrance.Controls.Add(txtWeight)
		Me.fraEncumbrance.Controls.Add(chkContainer)
		Me.ShapeContainer1.Shapes.Add(Line1)
		Me.fraEncumbrance.Controls.Add(lblBulk)
		Me.fraEncumbrance.Controls.Add(_lblWeight_4)
		Me.fraEncumbrance.Controls.Add(lblContainerType)
		Me.fraEncumbrance.Controls.Add(lblSoft)
		Me.fraEncumbrance.Controls.Add(ShapeContainer1)
		Me.fraFood.Controls.Add(lstFood)
		Me.fraTriggers.Controls.Add(txtTriggComm)
		Me.fraTriggers.Controls.Add(lstTriggers)
		Me.fraTriggers.Controls.Add(lblTriggComm)
		Me.fraFamily.Controls.Add(chk2hands)
		Me.fraFamily.Controls.Add(_chkFamily_18)
		Me.fraFamily.Controls.Add(_chkFamily_17)
		Me.fraFamily.Controls.Add(_chkFamily_16)
		Me.fraFamily.Controls.Add(_chkFamily_15)
		Me.fraFamily.Controls.Add(_chkFamily_14)
		Me.fraFamily.Controls.Add(_chkFamily_13)
		Me.fraFamily.Controls.Add(_chkFamily_12)
		Me.fraFamily.Controls.Add(_chkFamily_11)
		Me.fraFamily.Controls.Add(_chkFamily_10)
		Me.fraFamily.Controls.Add(_chkFamily_8)
		Me.fraFamily.Controls.Add(_chkFamily_9)
		Me.fraFamily.Controls.Add(_chkFamily_4)
		Me.fraFamily.Controls.Add(_chkFamily_5)
		Me.fraFamily.Controls.Add(_chkFamily_6)
		Me.fraFamily.Controls.Add(_chkFamily_7)
		Me.fraFamily.Controls.Add(_chkFamily_3)
		Me.fraFamily.Controls.Add(_chkFamily_2)
		Me.fraFamily.Controls.Add(_chkFamily_1)
		Me.fraFamily.Controls.Add(_chkFamily_0)
		Me.fraStats.Controls.Add(_txtStats_7)
		Me.fraStats.Controls.Add(_txtStats_6)
		Me.fraStats.Controls.Add(_txtStats_5)
		Me.fraStats.Controls.Add(_txtStats_4)
		Me.fraStats.Controls.Add(_txtStats_3)
		Me.fraStats.Controls.Add(_txtStats_2)
		Me.fraStats.Controls.Add(_txtStats_1)
		Me.fraStats.Controls.Add(_txtStats_0)
		Me.fraStats.Controls.Add(_lblStats_7)
		Me.fraStats.Controls.Add(_lblStats_6)
		Me.fraStats.Controls.Add(_lblStats_5)
		Me.fraStats.Controls.Add(_lblStats_4)
		Me.fraStats.Controls.Add(_lblStats_3)
		Me.fraStats.Controls.Add(_lblStats_2)
		Me.fraStats.Controls.Add(_lblStats_1)
		Me.fraStats.Controls.Add(_lblStats_0)
		Me.fraCompactView.Controls.Add(picCreatureCompact)
		Me.fraCompactView.Controls.Add(txtInfo)
		Me.fraFullView.ResumeLayout(False)
		Me.fraItems.ResumeLayout(False)
		Me.fraArmor.ResumeLayout(False)
		Me.fraEncumbrance.ResumeLayout(False)
		Me.fraFood.ResumeLayout(False)
		Me.fraTriggers.ResumeLayout(False)
		Me.fraFamily.ResumeLayout(False)
		Me.fraStats.ResumeLayout(False)
		Me.fraCompactView.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class