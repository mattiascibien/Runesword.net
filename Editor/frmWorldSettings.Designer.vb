<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmWorldSettings
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
	Public WithEvents mnuAdd As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuPictureAdd As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuPictureChange As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuPictureRemove As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuPicture As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuAddRemove As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuWorldPackage As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuQuit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	Public WithEvents cmbInterface As System.Windows.Forms.ComboBox
	Public WithEvents chkRandHP As System.Windows.Forms.CheckBox
	Public WithEvents txtHPperLevel As System.Windows.Forms.TextBox
	Public WithEvents txtSkillPtsPerLevel As System.Windows.Forms.TextBox
	Public WithEvents picMoney As System.Windows.Forms.PictureBox
	Public WithEvents _txtMoney_0 As System.Windows.Forms.TextBox
	Public WithEvents txtNumberKingdoms As System.Windows.Forms.TextBox
	Public WithEvents txtWorldName As System.Windows.Forms.TextBox
	Public WithEvents _txtMoney_1 As System.Windows.Forms.TextBox
	Public WithEvents picWorldMap As System.Windows.Forms.PictureBox
	Public WithEvents lblInterface As System.Windows.Forms.Label
	Public WithEvents lblRandomHP As System.Windows.Forms.Label
	Public WithEvents lblHPperLevel As System.Windows.Forms.Label
	Public WithEvents lblSkillPts As System.Windows.Forms.Label
	Public WithEvents lblMoney As System.Windows.Forms.Label
	Public WithEvents lblCount As System.Windows.Forms.Label
	Public WithEvents lblWorldName As System.Windows.Forms.Label
	Public WithEvents _fraKingdom_1 As System.Windows.Forms.GroupBox
	Public WithEvents chkMagicPerLevel As System.Windows.Forms.CheckBox
	Public WithEvents txtMagicPerLevel As System.Windows.Forms.TextBox
	Public WithEvents _chkStats_11 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStats_10 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStats_9 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStats_8 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStats_7 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStats_6 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStats_0 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStats_5 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStats_4 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStats_3 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStats_2 As System.Windows.Forms.CheckBox
	Public WithEvents _chkStats_1 As System.Windows.Forms.CheckBox
	Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents fraStats As System.Windows.Forms.GroupBox
	Public WithEvents chkRunes As System.Windows.Forms.CheckBox
	Public WithEvents txtCoef As System.Windows.Forms.TextBox
	Public WithEvents cmbMagicBasis As System.Windows.Forms.ComboBox
	Public WithEvents txtMagicName As System.Windows.Forms.TextBox
	Public WithEvents lblFormulaBasis As System.Windows.Forms.Label
	Public WithEvents lblMagicFormula As System.Windows.Forms.Label
	Public WithEvents lblMagicBasis As System.Windows.Forms.Label
	Public WithEvents lblMagicName As System.Windows.Forms.Label
	Public WithEvents fraMagic As System.Windows.Forms.GroupBox
	Public WithEvents lblRandMagicPerLvl As System.Windows.Forms.Label
	Public WithEvents lblMagicPerLevel As System.Windows.Forms.Label
	Public WithEvents _fraKingdom_3 As System.Windows.Forms.GroupBox
	Public WithEvents txtIntroMusic As System.Windows.Forms.TextBox
	Public WithEvents txtMusicFolder As System.Windows.Forms.TextBox
	Public WithEvents _picWorldDesc_0 As System.Windows.Forms.PictureBox
	Public WithEvents _picWorldDesc_1 As System.Windows.Forms.PictureBox
	Public WithEvents txtWorldDesc As System.Windows.Forms.TextBox
	Public WithEvents lblIntroMusic As System.Windows.Forms.Label
	Public WithEvents lblMusicFolder As System.Windows.Forms.Label
	Public WithEvents _lblWorldDesc_0 As System.Windows.Forms.Label
	Public WithEvents _lblWorldDesc_1 As System.Windows.Forms.Label
	Public WithEvents _fraKingdom_2 As System.Windows.Forms.GroupBox
	Public WithEvents _optGender_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optGender_0 As System.Windows.Forms.RadioButton
	Public WithEvents btnQuit As System.Windows.Forms.Button
	Public WithEvents btnSave As System.Windows.Forms.Button
	Public WithEvents _txtPictureName_0 As System.Windows.Forms.TextBox
	Public WithEvents _shpFace_5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents _picInhabitant_5 As System.Windows.Forms.Panel
	Public WithEvents _shpFace_4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents _picInhabitant_4 As System.Windows.Forms.Panel
	Public WithEvents _shpFace_3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents _picInhabitant_3 As System.Windows.Forms.Panel
	Public WithEvents _shpFace_2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents _picInhabitant_2 As System.Windows.Forms.Panel
	Public WithEvents _shpFace_1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents _picInhabitant_1 As System.Windows.Forms.Panel
	Public WithEvents _shpFace_0 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents _picInhabitant_0 As System.Windows.Forms.Panel
	Public WithEvents txtKingdomSet As System.Windows.Forms.TextBox
	Public WithEvents _txtPictureName_5 As System.Windows.Forms.TextBox
	Public WithEvents _txtPictureName_4 As System.Windows.Forms.TextBox
	Public WithEvents _txtPictureName_3 As System.Windows.Forms.TextBox
	Public WithEvents _txtPictureName_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtPictureName_1 As System.Windows.Forms.TextBox
	Public WithEvents btnLeftRoster As System.Windows.Forms.Button
	Public WithEvents btnRightRoster As System.Windows.Forms.Button
	Public WithEvents txtKingdomTemplate As System.Windows.Forms.TextBox
	Public WithEvents VScroll1 As System.Windows.Forms.VScrollBar
	Public WithEvents btnZoomOut As System.Windows.Forms.Button
	Public WithEvents HScroll1 As System.Windows.Forms.HScrollBar
	Public WithEvents shpBorder As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents picKingdom As System.Windows.Forms.Panel
	Public WithEvents lblKingdomSet As System.Windows.Forms.Label
	Public WithEvents lblKingdomName As System.Windows.Forms.Label
	Public WithEvents _fraKingdom_0 As System.Windows.Forms.GroupBox
	Public WithEvents _txtPicDescName_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtPicDescName_0 As System.Windows.Forms.TextBox
	Public WithEvents picMask As System.Windows.Forms.PictureBox
	Public WithEvents picMons As System.Windows.Forms.PictureBox
	Public WithEvents txtWorldMap As System.Windows.Forms.TextBox
	Public WithEvents txtKingdomLocation As System.Windows.Forms.TextBox
	Public WithEvents txtKingdomPictures As System.Windows.Forms.TextBox
	Public WithEvents tmpShape As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents picTmp As System.Windows.Forms.Panel
	Public WithEvents TabStrip1 As AxComctlLib.AxTabStrip
	Public WithEvents lblPicDesc As System.Windows.Forms.Label
	Public WithEvents lblWorldMap As System.Windows.Forms.Label
	Public WithEvents lblKingdomLocation As System.Windows.Forms.Label
	Public WithEvents lblKingdomPictures As System.Windows.Forms.Label
	Public WithEvents chkStats As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	Public WithEvents fraKingdom As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
	Public WithEvents lblWorldDesc As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents optGender As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents picInhabitant As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
	Public WithEvents picWorldDesc As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
	Public WithEvents txtMoney As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtPicDescName As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtPictureName As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents shpFace As OvalShapeArray
	Public WithEvents ShapeContainer8 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	Public WithEvents ShapeContainer7 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	Public WithEvents ShapeContainer6 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	Public WithEvents ShapeContainer5 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	Public WithEvents ShapeContainer4 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	Public WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	Public WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmWorldSettings))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer8 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.ShapeContainer7 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.ShapeContainer6 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.ShapeContainer5 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.MainMenu1 = New System.Windows.Forms.MenuStrip
		Me.mnuAddRemove = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuAdd = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuPicture = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuPictureAdd = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuPictureChange = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuPictureRemove = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuWorldPackage = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuQuit = New System.Windows.Forms.ToolStripMenuItem
		Me._fraKingdom_1 = New System.Windows.Forms.GroupBox
		Me.cmbInterface = New System.Windows.Forms.ComboBox
		Me.chkRandHP = New System.Windows.Forms.CheckBox
		Me.txtHPperLevel = New System.Windows.Forms.TextBox
		Me.txtSkillPtsPerLevel = New System.Windows.Forms.TextBox
		Me.picMoney = New System.Windows.Forms.PictureBox
		Me._txtMoney_0 = New System.Windows.Forms.TextBox
		Me.txtNumberKingdoms = New System.Windows.Forms.TextBox
		Me.txtWorldName = New System.Windows.Forms.TextBox
		Me._txtMoney_1 = New System.Windows.Forms.TextBox
		Me.picWorldMap = New System.Windows.Forms.PictureBox
		Me.lblInterface = New System.Windows.Forms.Label
		Me.lblRandomHP = New System.Windows.Forms.Label
		Me.lblHPperLevel = New System.Windows.Forms.Label
		Me.lblSkillPts = New System.Windows.Forms.Label
		Me.lblMoney = New System.Windows.Forms.Label
		Me.lblCount = New System.Windows.Forms.Label
		Me.lblWorldName = New System.Windows.Forms.Label
		Me._fraKingdom_3 = New System.Windows.Forms.GroupBox
		Me.chkMagicPerLevel = New System.Windows.Forms.CheckBox
		Me.txtMagicPerLevel = New System.Windows.Forms.TextBox
		Me.fraStats = New System.Windows.Forms.GroupBox
		Me._chkStats_11 = New System.Windows.Forms.CheckBox
		Me._chkStats_10 = New System.Windows.Forms.CheckBox
		Me._chkStats_9 = New System.Windows.Forms.CheckBox
		Me._chkStats_8 = New System.Windows.Forms.CheckBox
		Me._chkStats_7 = New System.Windows.Forms.CheckBox
		Me._chkStats_6 = New System.Windows.Forms.CheckBox
		Me._chkStats_0 = New System.Windows.Forms.CheckBox
		Me._chkStats_5 = New System.Windows.Forms.CheckBox
		Me._chkStats_4 = New System.Windows.Forms.CheckBox
		Me._chkStats_3 = New System.Windows.Forms.CheckBox
		Me._chkStats_2 = New System.Windows.Forms.CheckBox
		Me._chkStats_1 = New System.Windows.Forms.CheckBox
		Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.fraMagic = New System.Windows.Forms.GroupBox
		Me.chkRunes = New System.Windows.Forms.CheckBox
		Me.txtCoef = New System.Windows.Forms.TextBox
		Me.cmbMagicBasis = New System.Windows.Forms.ComboBox
		Me.txtMagicName = New System.Windows.Forms.TextBox
		Me.lblFormulaBasis = New System.Windows.Forms.Label
		Me.lblMagicFormula = New System.Windows.Forms.Label
		Me.lblMagicBasis = New System.Windows.Forms.Label
		Me.lblMagicName = New System.Windows.Forms.Label
		Me.lblRandMagicPerLvl = New System.Windows.Forms.Label
		Me.lblMagicPerLevel = New System.Windows.Forms.Label
		Me._fraKingdom_2 = New System.Windows.Forms.GroupBox
		Me.txtIntroMusic = New System.Windows.Forms.TextBox
		Me.txtMusicFolder = New System.Windows.Forms.TextBox
		Me._picWorldDesc_0 = New System.Windows.Forms.PictureBox
		Me._picWorldDesc_1 = New System.Windows.Forms.PictureBox
		Me.txtWorldDesc = New System.Windows.Forms.TextBox
		Me.lblIntroMusic = New System.Windows.Forms.Label
		Me.lblMusicFolder = New System.Windows.Forms.Label
		Me._lblWorldDesc_0 = New System.Windows.Forms.Label
		Me._lblWorldDesc_1 = New System.Windows.Forms.Label
		Me._fraKingdom_0 = New System.Windows.Forms.GroupBox
		Me._optGender_1 = New System.Windows.Forms.RadioButton
		Me._optGender_0 = New System.Windows.Forms.RadioButton
		Me.btnQuit = New System.Windows.Forms.Button
		Me.btnSave = New System.Windows.Forms.Button
		Me._txtPictureName_0 = New System.Windows.Forms.TextBox
		Me._picInhabitant_5 = New System.Windows.Forms.Panel
		Me._shpFace_5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me._picInhabitant_4 = New System.Windows.Forms.Panel
		Me._shpFace_4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me._picInhabitant_3 = New System.Windows.Forms.Panel
		Me._shpFace_3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me._picInhabitant_2 = New System.Windows.Forms.Panel
		Me._shpFace_2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me._picInhabitant_1 = New System.Windows.Forms.Panel
		Me._shpFace_1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me._picInhabitant_0 = New System.Windows.Forms.Panel
		Me._shpFace_0 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.txtKingdomSet = New System.Windows.Forms.TextBox
		Me._txtPictureName_5 = New System.Windows.Forms.TextBox
		Me._txtPictureName_4 = New System.Windows.Forms.TextBox
		Me._txtPictureName_3 = New System.Windows.Forms.TextBox
		Me._txtPictureName_2 = New System.Windows.Forms.TextBox
		Me._txtPictureName_1 = New System.Windows.Forms.TextBox
		Me.btnLeftRoster = New System.Windows.Forms.Button
		Me.btnRightRoster = New System.Windows.Forms.Button
		Me.txtKingdomTemplate = New System.Windows.Forms.TextBox
		Me.picKingdom = New System.Windows.Forms.Panel
		Me.VScroll1 = New System.Windows.Forms.VScrollBar
		Me.btnZoomOut = New System.Windows.Forms.Button
		Me.HScroll1 = New System.Windows.Forms.HScrollBar
		Me.shpBorder = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.lblKingdomSet = New System.Windows.Forms.Label
		Me.lblKingdomName = New System.Windows.Forms.Label
		Me._txtPicDescName_1 = New System.Windows.Forms.TextBox
		Me._txtPicDescName_0 = New System.Windows.Forms.TextBox
		Me.picMask = New System.Windows.Forms.PictureBox
		Me.picMons = New System.Windows.Forms.PictureBox
		Me.txtWorldMap = New System.Windows.Forms.TextBox
		Me.txtKingdomLocation = New System.Windows.Forms.TextBox
		Me.txtKingdomPictures = New System.Windows.Forms.TextBox
		Me.picTmp = New System.Windows.Forms.Panel
		Me.tmpShape = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.TabStrip1 = New AxComctlLib.AxTabStrip
		Me.lblPicDesc = New System.Windows.Forms.Label
		Me.lblWorldMap = New System.Windows.Forms.Label
		Me.lblKingdomLocation = New System.Windows.Forms.Label
		Me.lblKingdomPictures = New System.Windows.Forms.Label
		Me.chkStats = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(components)
		Me.fraKingdom = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(components)
		Me.lblWorldDesc = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.optGender = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.picInhabitant = New Microsoft.VisualBasic.Compatibility.VB6.PanelArray(components)
		Me.picWorldDesc = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(components)
		Me.txtMoney = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtPicDescName = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtPictureName = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.shpFace = New OvalShapeArray(components)
		Me.MainMenu1.SuspendLayout()
		Me._fraKingdom_1.SuspendLayout()
		Me._fraKingdom_3.SuspendLayout()
		Me.fraStats.SuspendLayout()
		Me.fraMagic.SuspendLayout()
		Me._fraKingdom_2.SuspendLayout()
		Me._fraKingdom_0.SuspendLayout()
		Me._picInhabitant_5.SuspendLayout()
		Me._picInhabitant_4.SuspendLayout()
		Me._picInhabitant_3.SuspendLayout()
		Me._picInhabitant_2.SuspendLayout()
		Me._picInhabitant_1.SuspendLayout()
		Me._picInhabitant_0.SuspendLayout()
		Me.picKingdom.SuspendLayout()
		Me.picTmp.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.TabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.chkStats, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.fraKingdom, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblWorldDesc, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optGender, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picInhabitant, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picWorldDesc, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtMoney, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPicDescName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPictureName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.shpFace, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "World Settings"
		Me.ClientSize = New System.Drawing.Size(357, 452)
		Me.Location = New System.Drawing.Point(108, 92)
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
		Me.Name = "frmWorldSettings"
		Me.mnuAddRemove.Name = "mnuAddRemove"
		Me.mnuAddRemove.Text = "Kingdom"
		Me.mnuAddRemove.Checked = False
		Me.mnuAddRemove.Enabled = True
		Me.mnuAddRemove.Visible = True
		Me.mnuAdd.Name = "mnuAdd"
		Me.mnuAdd.Text = "Add Kingdom"
		Me.mnuAdd.Checked = False
		Me.mnuAdd.Enabled = True
		Me.mnuAdd.Visible = True
		Me.mnuDelete.Name = "mnuDelete"
		Me.mnuDelete.Text = "Remove Kingdom"
		Me.mnuDelete.Checked = False
		Me.mnuDelete.Enabled = True
		Me.mnuDelete.Visible = True
		Me.mnuPicture.Name = "mnuPicture"
		Me.mnuPicture.Text = "Pictures"
		Me.mnuPicture.Checked = False
		Me.mnuPicture.Enabled = True
		Me.mnuPicture.Visible = True
		Me.mnuPictureAdd.Name = "mnuPictureAdd"
		Me.mnuPictureAdd.Text = "Add character picture"
		Me.mnuPictureAdd.Checked = False
		Me.mnuPictureAdd.Enabled = True
		Me.mnuPictureAdd.Visible = True
		Me.mnuPictureChange.Name = "mnuPictureChange"
		Me.mnuPictureChange.Text = "Change character picture"
		Me.mnuPictureChange.Checked = False
		Me.mnuPictureChange.Enabled = True
		Me.mnuPictureChange.Visible = True
		Me.mnuPictureRemove.Name = "mnuPictureRemove"
		Me.mnuPictureRemove.Text = "Remove character picture"
		Me.mnuPictureRemove.Checked = False
		Me.mnuPictureRemove.Enabled = True
		Me.mnuPictureRemove.Visible = True
		Me.mnuSave.Name = "mnuSave"
		Me.mnuSave.Text = "Save"
		Me.mnuSave.Checked = False
		Me.mnuSave.Enabled = True
		Me.mnuSave.Visible = True
		Me.mnuWorldPackage.Name = "mnuWorldPackage"
		Me.mnuWorldPackage.Text = "Create Package"
		Me.mnuWorldPackage.Checked = False
		Me.mnuWorldPackage.Enabled = True
		Me.mnuWorldPackage.Visible = True
		Me.mnuQuit.Name = "mnuQuit"
		Me.mnuQuit.Text = "Quit"
		Me.mnuQuit.Checked = False
		Me.mnuQuit.Enabled = True
		Me.mnuQuit.Visible = True
		Me._fraKingdom_1.Size = New System.Drawing.Size(329, 353)
		Me._fraKingdom_1.Location = New System.Drawing.Point(16, 93)
		Me._fraKingdom_1.TabIndex = 34
		Me._fraKingdom_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraKingdom_1.BackColor = System.Drawing.SystemColors.Control
		Me._fraKingdom_1.Enabled = True
		Me._fraKingdom_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraKingdom_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraKingdom_1.Visible = True
		Me._fraKingdom_1.Padding = New System.Windows.Forms.Padding(0)
		Me._fraKingdom_1.Name = "_fraKingdom_1"
		Me.cmbInterface.Size = New System.Drawing.Size(137, 21)
		Me.cmbInterface.Location = New System.Drawing.Point(96, 56)
		Me.cmbInterface.Sorted = True
		Me.cmbInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbInterface.TabIndex = 89
		Me.cmbInterface.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbInterface.BackColor = System.Drawing.SystemColors.Window
		Me.cmbInterface.CausesValidation = True
		Me.cmbInterface.Enabled = True
		Me.cmbInterface.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbInterface.IntegralHeight = True
		Me.cmbInterface.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbInterface.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbInterface.TabStop = True
		Me.cmbInterface.Visible = True
		Me.cmbInterface.Name = "cmbInterface"
		Me.chkRandHP.Size = New System.Drawing.Size(17, 17)
		Me.chkRandHP.Location = New System.Drawing.Point(304, 120)
		Me.chkRandHP.TabIndex = 48
		Me.chkRandHP.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkRandHP.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkRandHP.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkRandHP.BackColor = System.Drawing.SystemColors.Control
		Me.chkRandHP.Text = ""
		Me.chkRandHP.CausesValidation = True
		Me.chkRandHP.Enabled = True
		Me.chkRandHP.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkRandHP.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkRandHP.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkRandHP.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkRandHP.TabStop = True
		Me.chkRandHP.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkRandHP.Visible = True
		Me.chkRandHP.Name = "chkRandHP"
		Me.txtHPperLevel.AutoSize = False
		Me.txtHPperLevel.Size = New System.Drawing.Size(25, 19)
		Me.txtHPperLevel.Location = New System.Drawing.Point(72, 118)
		Me.txtHPperLevel.TabIndex = 49
		Me.txtHPperLevel.Text = "10"
		Me.txtHPperLevel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHPperLevel.AcceptsReturn = True
		Me.txtHPperLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtHPperLevel.BackColor = System.Drawing.SystemColors.Window
		Me.txtHPperLevel.CausesValidation = True
		Me.txtHPperLevel.Enabled = True
		Me.txtHPperLevel.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtHPperLevel.HideSelection = True
		Me.txtHPperLevel.ReadOnly = False
		Me.txtHPperLevel.Maxlength = 0
		Me.txtHPperLevel.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtHPperLevel.MultiLine = False
		Me.txtHPperLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtHPperLevel.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtHPperLevel.TabStop = True
		Me.txtHPperLevel.Visible = True
		Me.txtHPperLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtHPperLevel.Name = "txtHPperLevel"
		Me.txtSkillPtsPerLevel.AutoSize = False
		Me.txtSkillPtsPerLevel.Size = New System.Drawing.Size(25, 19)
		Me.txtSkillPtsPerLevel.Location = New System.Drawing.Point(208, 118)
		Me.txtSkillPtsPerLevel.TabIndex = 50
		Me.txtSkillPtsPerLevel.Text = "10"
		Me.txtSkillPtsPerLevel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSkillPtsPerLevel.AcceptsReturn = True
		Me.txtSkillPtsPerLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSkillPtsPerLevel.BackColor = System.Drawing.SystemColors.Window
		Me.txtSkillPtsPerLevel.CausesValidation = True
		Me.txtSkillPtsPerLevel.Enabled = True
		Me.txtSkillPtsPerLevel.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSkillPtsPerLevel.HideSelection = True
		Me.txtSkillPtsPerLevel.ReadOnly = False
		Me.txtSkillPtsPerLevel.Maxlength = 0
		Me.txtSkillPtsPerLevel.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSkillPtsPerLevel.MultiLine = False
		Me.txtSkillPtsPerLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSkillPtsPerLevel.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSkillPtsPerLevel.TabStop = True
		Me.txtSkillPtsPerLevel.Visible = True
		Me.txtSkillPtsPerLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSkillPtsPerLevel.Name = "txtSkillPtsPerLevel"
		Me.picMoney.Size = New System.Drawing.Size(88, 81)
		Me.picMoney.Location = New System.Drawing.Point(238, 32)
		Me.picMoney.TabIndex = 43
		Me.picMoney.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picMoney.Dock = System.Windows.Forms.DockStyle.None
		Me.picMoney.BackColor = System.Drawing.SystemColors.Control
		Me.picMoney.CausesValidation = True
		Me.picMoney.Enabled = True
		Me.picMoney.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picMoney.Cursor = System.Windows.Forms.Cursors.Default
		Me.picMoney.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picMoney.TabStop = True
		Me.picMoney.Visible = True
		Me.picMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picMoney.Name = "picMoney"
		Me._txtMoney_0.AutoSize = False
		Me._txtMoney_0.Size = New System.Drawing.Size(137, 19)
		Me._txtMoney_0.Location = New System.Drawing.Point(96, 32)
		Me._txtMoney_0.TabIndex = 42
		Me._txtMoney_0.Text = "Gold piece"
		Me._txtMoney_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtMoney_0.AcceptsReturn = True
		Me._txtMoney_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtMoney_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtMoney_0.CausesValidation = True
		Me._txtMoney_0.Enabled = True
		Me._txtMoney_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtMoney_0.HideSelection = True
		Me._txtMoney_0.ReadOnly = False
		Me._txtMoney_0.Maxlength = 0
		Me._txtMoney_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtMoney_0.MultiLine = False
		Me._txtMoney_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtMoney_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtMoney_0.TabStop = True
		Me._txtMoney_0.Visible = True
		Me._txtMoney_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtMoney_0.Name = "_txtMoney_0"
		Me.txtNumberKingdoms.AutoSize = False
		Me.txtNumberKingdoms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtNumberKingdoms.Size = New System.Drawing.Size(33, 19)
		Me.txtNumberKingdoms.Location = New System.Drawing.Point(288, 8)
		Me.txtNumberKingdoms.ReadOnly = True
		Me.txtNumberKingdoms.TabIndex = 36
		Me.txtNumberKingdoms.Text = "1"
		Me.txtNumberKingdoms.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNumberKingdoms.AcceptsReturn = True
		Me.txtNumberKingdoms.BackColor = System.Drawing.SystemColors.Window
		Me.txtNumberKingdoms.CausesValidation = True
		Me.txtNumberKingdoms.Enabled = True
		Me.txtNumberKingdoms.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNumberKingdoms.HideSelection = True
		Me.txtNumberKingdoms.Maxlength = 0
		Me.txtNumberKingdoms.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNumberKingdoms.MultiLine = False
		Me.txtNumberKingdoms.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNumberKingdoms.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNumberKingdoms.TabStop = True
		Me.txtNumberKingdoms.Visible = True
		Me.txtNumberKingdoms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtNumberKingdoms.Name = "txtNumberKingdoms"
		Me.txtWorldName.AutoSize = False
		Me.txtWorldName.Size = New System.Drawing.Size(137, 19)
		Me.txtWorldName.Location = New System.Drawing.Point(96, 8)
		Me.txtWorldName.TabIndex = 35
		Me.txtWorldName.Text = "Not defined."
		Me.txtWorldName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtWorldName.AcceptsReturn = True
		Me.txtWorldName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtWorldName.BackColor = System.Drawing.SystemColors.Window
		Me.txtWorldName.CausesValidation = True
		Me.txtWorldName.Enabled = True
		Me.txtWorldName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtWorldName.HideSelection = True
		Me.txtWorldName.ReadOnly = False
		Me.txtWorldName.Maxlength = 0
		Me.txtWorldName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtWorldName.MultiLine = False
		Me.txtWorldName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtWorldName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtWorldName.TabStop = True
		Me.txtWorldName.Visible = True
		Me.txtWorldName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtWorldName.Name = "txtWorldName"
		Me._txtMoney_1.AutoSize = False
		Me._txtMoney_1.Size = New System.Drawing.Size(137, 19)
		Me._txtMoney_1.Location = New System.Drawing.Point(96, 32)
		Me._txtMoney_1.TabIndex = 44
		Me._txtMoney_1.Text = "Gold piece"
		Me._txtMoney_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtMoney_1.AcceptsReturn = True
		Me._txtMoney_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtMoney_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtMoney_1.CausesValidation = True
		Me._txtMoney_1.Enabled = True
		Me._txtMoney_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtMoney_1.HideSelection = True
		Me._txtMoney_1.ReadOnly = False
		Me._txtMoney_1.Maxlength = 0
		Me._txtMoney_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtMoney_1.MultiLine = False
		Me._txtMoney_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtMoney_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtMoney_1.TabStop = True
		Me._txtMoney_1.Visible = True
		Me._txtMoney_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtMoney_1.Name = "_txtMoney_1"
		Me.picWorldMap.Size = New System.Drawing.Size(321, 212)
		Me.picWorldMap.Location = New System.Drawing.Point(4, 138)
		Me.picWorldMap.TabIndex = 37
		Me.picWorldMap.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picWorldMap.Dock = System.Windows.Forms.DockStyle.None
		Me.picWorldMap.BackColor = System.Drawing.SystemColors.Control
		Me.picWorldMap.CausesValidation = True
		Me.picWorldMap.Enabled = True
		Me.picWorldMap.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picWorldMap.Cursor = System.Windows.Forms.Cursors.Default
		Me.picWorldMap.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picWorldMap.TabStop = True
		Me.picWorldMap.Visible = True
		Me.picWorldMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picWorldMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picWorldMap.Name = "picWorldMap"
		Me.lblInterface.Text = "Preferred interface"
		Me.lblInterface.Size = New System.Drawing.Size(89, 17)
		Me.lblInterface.Location = New System.Drawing.Point(6, 59)
		Me.lblInterface.TabIndex = 90
		Me.lblInterface.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblInterface.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblInterface.BackColor = System.Drawing.SystemColors.Control
		Me.lblInterface.Enabled = True
		Me.lblInterface.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblInterface.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblInterface.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblInterface.UseMnemonic = True
		Me.lblInterface.Visible = True
		Me.lblInterface.AutoSize = False
		Me.lblInterface.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblInterface.Name = "lblInterface"
		Me.lblRandomHP.Text = "(randomize?)"
		Me.lblRandomHP.Size = New System.Drawing.Size(65, 17)
		Me.lblRandomHP.Location = New System.Drawing.Point(240, 120)
		Me.lblRandomHP.TabIndex = 51
		Me.lblRandomHP.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRandomHP.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblRandomHP.BackColor = System.Drawing.SystemColors.Control
		Me.lblRandomHP.Enabled = True
		Me.lblRandomHP.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblRandomHP.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblRandomHP.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblRandomHP.UseMnemonic = True
		Me.lblRandomHP.Visible = True
		Me.lblRandomHP.AutoSize = False
		Me.lblRandomHP.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblRandomHP.Name = "lblRandomHP"
		Me.lblHPperLevel.Text = "HP per level"
		Me.lblHPperLevel.Size = New System.Drawing.Size(65, 17)
		Me.lblHPperLevel.Location = New System.Drawing.Point(8, 120)
		Me.lblHPperLevel.TabIndex = 52
		Me.lblHPperLevel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHPperLevel.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblHPperLevel.BackColor = System.Drawing.SystemColors.Control
		Me.lblHPperLevel.Enabled = True
		Me.lblHPperLevel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblHPperLevel.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblHPperLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblHPperLevel.UseMnemonic = True
		Me.lblHPperLevel.Visible = True
		Me.lblHPperLevel.AutoSize = False
		Me.lblHPperLevel.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblHPperLevel.Name = "lblHPperLevel"
		Me.lblSkillPts.Text = "Skill pts per level"
		Me.lblSkillPts.Size = New System.Drawing.Size(89, 17)
		Me.lblSkillPts.Location = New System.Drawing.Point(112, 120)
		Me.lblSkillPts.TabIndex = 53
		Me.lblSkillPts.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSkillPts.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSkillPts.BackColor = System.Drawing.SystemColors.Control
		Me.lblSkillPts.Enabled = True
		Me.lblSkillPts.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSkillPts.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSkillPts.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSkillPts.UseMnemonic = True
		Me.lblSkillPts.Visible = True
		Me.lblSkillPts.AutoSize = False
		Me.lblSkillPts.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSkillPts.Name = "lblSkillPts"
		Me.lblMoney.Text = "Currency"
		Me.lblMoney.Size = New System.Drawing.Size(89, 17)
		Me.lblMoney.Location = New System.Drawing.Point(6, 32)
		Me.lblMoney.TabIndex = 41
		Me.lblMoney.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMoney.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMoney.BackColor = System.Drawing.SystemColors.Control
		Me.lblMoney.Enabled = True
		Me.lblMoney.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMoney.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMoney.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMoney.UseMnemonic = True
		Me.lblMoney.Visible = True
		Me.lblMoney.AutoSize = False
		Me.lblMoney.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMoney.Name = "lblMoney"
		Me.lblCount.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblCount.Text = "Kingdoms"
		Me.lblCount.Size = New System.Drawing.Size(49, 17)
		Me.lblCount.Location = New System.Drawing.Point(240, 8)
		Me.lblCount.TabIndex = 39
		Me.lblCount.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCount.BackColor = System.Drawing.SystemColors.Control
		Me.lblCount.Enabled = True
		Me.lblCount.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCount.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCount.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCount.UseMnemonic = True
		Me.lblCount.Visible = True
		Me.lblCount.AutoSize = False
		Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCount.Name = "lblCount"
		Me.lblWorldName.Text = "Name of the world"
		Me.lblWorldName.Size = New System.Drawing.Size(105, 17)
		Me.lblWorldName.Location = New System.Drawing.Point(6, 10)
		Me.lblWorldName.TabIndex = 38
		Me.lblWorldName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWorldName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWorldName.BackColor = System.Drawing.SystemColors.Control
		Me.lblWorldName.Enabled = True
		Me.lblWorldName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWorldName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWorldName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWorldName.UseMnemonic = True
		Me.lblWorldName.Visible = True
		Me.lblWorldName.AutoSize = False
		Me.lblWorldName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWorldName.Name = "lblWorldName"
		Me._fraKingdom_3.Size = New System.Drawing.Size(329, 353)
		Me._fraKingdom_3.Location = New System.Drawing.Point(16, 93)
		Me._fraKingdom_3.TabIndex = 60
		Me._fraKingdom_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraKingdom_3.BackColor = System.Drawing.SystemColors.Control
		Me._fraKingdom_3.Enabled = True
		Me._fraKingdom_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraKingdom_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraKingdom_3.Visible = True
		Me._fraKingdom_3.Padding = New System.Windows.Forms.Padding(0)
		Me._fraKingdom_3.Name = "_fraKingdom_3"
		Me.chkMagicPerLevel.Size = New System.Drawing.Size(17, 17)
		Me.chkMagicPerLevel.Location = New System.Drawing.Point(200, 160)
		Me.chkMagicPerLevel.TabIndex = 79
		Me.chkMagicPerLevel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkMagicPerLevel.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkMagicPerLevel.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkMagicPerLevel.BackColor = System.Drawing.SystemColors.Control
		Me.chkMagicPerLevel.Text = ""
		Me.chkMagicPerLevel.CausesValidation = True
		Me.chkMagicPerLevel.Enabled = True
		Me.chkMagicPerLevel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkMagicPerLevel.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkMagicPerLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkMagicPerLevel.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkMagicPerLevel.TabStop = True
		Me.chkMagicPerLevel.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkMagicPerLevel.Visible = True
		Me.chkMagicPerLevel.Name = "chkMagicPerLevel"
		Me.txtMagicPerLevel.AutoSize = False
		Me.txtMagicPerLevel.Size = New System.Drawing.Size(33, 19)
		Me.txtMagicPerLevel.Location = New System.Drawing.Point(160, 160)
		Me.txtMagicPerLevel.TabIndex = 78
		Me.txtMagicPerLevel.Text = "10"
		Me.txtMagicPerLevel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMagicPerLevel.AcceptsReturn = True
		Me.txtMagicPerLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMagicPerLevel.BackColor = System.Drawing.SystemColors.Window
		Me.txtMagicPerLevel.CausesValidation = True
		Me.txtMagicPerLevel.Enabled = True
		Me.txtMagicPerLevel.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMagicPerLevel.HideSelection = True
		Me.txtMagicPerLevel.ReadOnly = False
		Me.txtMagicPerLevel.Maxlength = 0
		Me.txtMagicPerLevel.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMagicPerLevel.MultiLine = False
		Me.txtMagicPerLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMagicPerLevel.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMagicPerLevel.TabStop = True
		Me.txtMagicPerLevel.Visible = True
		Me.txtMagicPerLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMagicPerLevel.Name = "txtMagicPerLevel"
		Me.fraStats.Text = "Statistics"
		Me.fraStats.Size = New System.Drawing.Size(313, 161)
		Me.fraStats.Location = New System.Drawing.Point(8, 184)
		Me.fraStats.TabIndex = 70
		Me.fraStats.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraStats.BackColor = System.Drawing.SystemColors.Control
		Me.fraStats.Enabled = True
		Me.fraStats.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraStats.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraStats.Visible = True
		Me.fraStats.Padding = New System.Windows.Forms.Padding(0)
		Me.fraStats.Name = "fraStats"
		Me._chkStats_11.Text = "Not used in Eternia"
		Me._chkStats_11.Size = New System.Drawing.Size(145, 17)
		Me._chkStats_11.Location = New System.Drawing.Point(166, 136)
		Me._chkStats_11.TabIndex = 86
		Me._chkStats_11.Visible = False
		Me._chkStats_11.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStats_11.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStats_11.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStats_11.BackColor = System.Drawing.SystemColors.Control
		Me._chkStats_11.CausesValidation = True
		Me._chkStats_11.Enabled = True
		Me._chkStats_11.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStats_11.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStats_11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStats_11.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStats_11.TabStop = True
		Me._chkStats_11.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStats_11.Name = "_chkStats_11"
		Me._chkStats_10.Text = "Not used in Eternia"
		Me._chkStats_10.Size = New System.Drawing.Size(145, 17)
		Me._chkStats_10.Location = New System.Drawing.Point(166, 112)
		Me._chkStats_10.TabIndex = 85
		Me._chkStats_10.Visible = False
		Me._chkStats_10.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStats_10.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStats_10.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStats_10.BackColor = System.Drawing.SystemColors.Control
		Me._chkStats_10.CausesValidation = True
		Me._chkStats_10.Enabled = True
		Me._chkStats_10.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStats_10.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStats_10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStats_10.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStats_10.TabStop = True
		Me._chkStats_10.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStats_10.Name = "_chkStats_10"
		Me._chkStats_9.Text = "Not used in Eternia"
		Me._chkStats_9.Size = New System.Drawing.Size(145, 17)
		Me._chkStats_9.Location = New System.Drawing.Point(166, 88)
		Me._chkStats_9.TabIndex = 84
		Me._chkStats_9.Visible = False
		Me._chkStats_9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStats_9.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStats_9.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStats_9.BackColor = System.Drawing.SystemColors.Control
		Me._chkStats_9.CausesValidation = True
		Me._chkStats_9.Enabled = True
		Me._chkStats_9.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStats_9.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStats_9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStats_9.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStats_9.TabStop = True
		Me._chkStats_9.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStats_9.Name = "_chkStats_9"
		Me._chkStats_8.Text = "Not used in Eternia"
		Me._chkStats_8.Size = New System.Drawing.Size(145, 17)
		Me._chkStats_8.Location = New System.Drawing.Point(166, 64)
		Me._chkStats_8.TabIndex = 83
		Me._chkStats_8.Visible = False
		Me._chkStats_8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStats_8.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStats_8.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStats_8.BackColor = System.Drawing.SystemColors.Control
		Me._chkStats_8.CausesValidation = True
		Me._chkStats_8.Enabled = True
		Me._chkStats_8.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStats_8.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStats_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStats_8.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStats_8.TabStop = True
		Me._chkStats_8.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStats_8.Name = "_chkStats_8"
		Me._chkStats_7.Text = "Not used in Eternia"
		Me._chkStats_7.Size = New System.Drawing.Size(145, 17)
		Me._chkStats_7.Location = New System.Drawing.Point(166, 40)
		Me._chkStats_7.TabIndex = 82
		Me._chkStats_7.Visible = False
		Me._chkStats_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStats_7.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStats_7.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStats_7.BackColor = System.Drawing.SystemColors.Control
		Me._chkStats_7.CausesValidation = True
		Me._chkStats_7.Enabled = True
		Me._chkStats_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStats_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStats_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStats_7.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStats_7.TabStop = True
		Me._chkStats_7.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStats_7.Name = "_chkStats_7"
		Me._chkStats_6.Text = "Not used in Eternia"
		Me._chkStats_6.Size = New System.Drawing.Size(145, 17)
		Me._chkStats_6.Location = New System.Drawing.Point(166, 16)
		Me._chkStats_6.TabIndex = 81
		Me._chkStats_6.Visible = False
		Me._chkStats_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStats_6.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStats_6.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStats_6.BackColor = System.Drawing.SystemColors.Control
		Me._chkStats_6.CausesValidation = True
		Me._chkStats_6.Enabled = True
		Me._chkStats_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStats_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStats_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStats_6.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStats_6.TabStop = True
		Me._chkStats_6.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStats_6.Name = "_chkStats_6"
		Me._chkStats_0.Text = "Strength"
		Me._chkStats_0.Size = New System.Drawing.Size(145, 17)
		Me._chkStats_0.Location = New System.Drawing.Point(8, 16)
		Me._chkStats_0.TabIndex = 76
		Me._chkStats_0.CheckState = System.Windows.Forms.CheckState.Checked
		Me._chkStats_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStats_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStats_0.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStats_0.BackColor = System.Drawing.SystemColors.Control
		Me._chkStats_0.CausesValidation = True
		Me._chkStats_0.Enabled = True
		Me._chkStats_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStats_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStats_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStats_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStats_0.TabStop = True
		Me._chkStats_0.Visible = True
		Me._chkStats_0.Name = "_chkStats_0"
		Me._chkStats_5.Text = "Not used in Eternia"
		Me._chkStats_5.Size = New System.Drawing.Size(145, 17)
		Me._chkStats_5.Location = New System.Drawing.Point(8, 136)
		Me._chkStats_5.TabIndex = 75
		Me._chkStats_5.Visible = False
		Me._chkStats_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStats_5.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStats_5.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStats_5.BackColor = System.Drawing.SystemColors.Control
		Me._chkStats_5.CausesValidation = True
		Me._chkStats_5.Enabled = True
		Me._chkStats_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStats_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStats_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStats_5.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStats_5.TabStop = True
		Me._chkStats_5.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStats_5.Name = "_chkStats_5"
		Me._chkStats_4.Text = "Not used in Eternia"
		Me._chkStats_4.Size = New System.Drawing.Size(145, 17)
		Me._chkStats_4.Location = New System.Drawing.Point(8, 112)
		Me._chkStats_4.TabIndex = 74
		Me._chkStats_4.Visible = False
		Me._chkStats_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStats_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStats_4.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStats_4.BackColor = System.Drawing.SystemColors.Control
		Me._chkStats_4.CausesValidation = True
		Me._chkStats_4.Enabled = True
		Me._chkStats_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStats_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStats_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStats_4.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStats_4.TabStop = True
		Me._chkStats_4.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStats_4.Name = "_chkStats_4"
		Me._chkStats_3.Text = "Not used in Eternia"
		Me._chkStats_3.Size = New System.Drawing.Size(145, 17)
		Me._chkStats_3.Location = New System.Drawing.Point(8, 88)
		Me._chkStats_3.TabIndex = 73
		Me._chkStats_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStats_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStats_3.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStats_3.BackColor = System.Drawing.SystemColors.Control
		Me._chkStats_3.CausesValidation = True
		Me._chkStats_3.Enabled = True
		Me._chkStats_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStats_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStats_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStats_3.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStats_3.TabStop = True
		Me._chkStats_3.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkStats_3.Visible = True
		Me._chkStats_3.Name = "_chkStats_3"
		Me._chkStats_2.Text = "Will"
		Me._chkStats_2.Size = New System.Drawing.Size(145, 17)
		Me._chkStats_2.Location = New System.Drawing.Point(8, 64)
		Me._chkStats_2.TabIndex = 72
		Me._chkStats_2.CheckState = System.Windows.Forms.CheckState.Checked
		Me._chkStats_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStats_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStats_2.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStats_2.BackColor = System.Drawing.SystemColors.Control
		Me._chkStats_2.CausesValidation = True
		Me._chkStats_2.Enabled = True
		Me._chkStats_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStats_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStats_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStats_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStats_2.TabStop = True
		Me._chkStats_2.Visible = True
		Me._chkStats_2.Name = "_chkStats_2"
		Me._chkStats_1.Text = "Agility"
		Me._chkStats_1.Size = New System.Drawing.Size(145, 17)
		Me._chkStats_1.Location = New System.Drawing.Point(8, 40)
		Me._chkStats_1.TabIndex = 71
		Me._chkStats_1.CheckState = System.Windows.Forms.CheckState.Checked
		Me._chkStats_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkStats_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkStats_1.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkStats_1.BackColor = System.Drawing.SystemColors.Control
		Me._chkStats_1.CausesValidation = True
		Me._chkStats_1.Enabled = True
		Me._chkStats_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkStats_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkStats_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkStats_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkStats_1.TabStop = True
		Me._chkStats_1.Visible = True
		Me._chkStats_1.Name = "_chkStats_1"
		Me.Line1.BorderColor = System.Drawing.SystemColors.GrayText
		Me.Line1.X1 = 157
		Me.Line1.X2 = 157
		Me.Line1.Y1 = -5
		Me.Line1.Y2 = 147
		Me.Line1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line1.BorderWidth = 1
		Me.Line1.Visible = True
		Me.Line1.Name = "Line1"
		Me.fraMagic.Text = "Magic"
		Me.fraMagic.Size = New System.Drawing.Size(313, 145)
		Me.fraMagic.Location = New System.Drawing.Point(8, 8)
		Me.fraMagic.TabIndex = 61
		Me.fraMagic.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraMagic.BackColor = System.Drawing.SystemColors.Control
		Me.fraMagic.Enabled = True
		Me.fraMagic.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraMagic.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraMagic.Visible = True
		Me.fraMagic.Padding = New System.Windows.Forms.Padding(0)
		Me.fraMagic.Name = "fraMagic"
		Me.chkRunes.Text = "Magic does not use the Eternia system of runes."
		Me.chkRunes.Size = New System.Drawing.Size(297, 17)
		Me.chkRunes.Location = New System.Drawing.Point(8, 120)
		Me.chkRunes.TabIndex = 69
		Me.chkRunes.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkRunes.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkRunes.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkRunes.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkRunes.BackColor = System.Drawing.SystemColors.Control
		Me.chkRunes.CausesValidation = True
		Me.chkRunes.Enabled = True
		Me.chkRunes.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkRunes.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkRunes.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkRunes.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkRunes.TabStop = True
		Me.chkRunes.Visible = True
		Me.chkRunes.Name = "chkRunes"
		Me.txtCoef.AutoSize = False
		Me.txtCoef.Size = New System.Drawing.Size(33, 19)
		Me.txtCoef.Location = New System.Drawing.Point(200, 72)
		Me.txtCoef.TabIndex = 67
		Me.txtCoef.Text = "4"
		Me.txtCoef.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCoef.AcceptsReturn = True
		Me.txtCoef.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCoef.BackColor = System.Drawing.SystemColors.Window
		Me.txtCoef.CausesValidation = True
		Me.txtCoef.Enabled = True
		Me.txtCoef.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCoef.HideSelection = True
		Me.txtCoef.ReadOnly = False
		Me.txtCoef.Maxlength = 0
		Me.txtCoef.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCoef.MultiLine = False
		Me.txtCoef.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCoef.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCoef.TabStop = True
		Me.txtCoef.Visible = True
		Me.txtCoef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCoef.Name = "txtCoef"
		Me.cmbMagicBasis.Size = New System.Drawing.Size(129, 21)
		Me.cmbMagicBasis.Location = New System.Drawing.Point(176, 46)
		Me.cmbMagicBasis.TabIndex = 65
		Me.cmbMagicBasis.Text = "Will"
		Me.cmbMagicBasis.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbMagicBasis.BackColor = System.Drawing.SystemColors.Window
		Me.cmbMagicBasis.CausesValidation = True
		Me.cmbMagicBasis.Enabled = True
		Me.cmbMagicBasis.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbMagicBasis.IntegralHeight = True
		Me.cmbMagicBasis.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbMagicBasis.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbMagicBasis.Sorted = False
		Me.cmbMagicBasis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cmbMagicBasis.TabStop = True
		Me.cmbMagicBasis.Visible = True
		Me.cmbMagicBasis.Name = "cmbMagicBasis"
		Me.txtMagicName.AutoSize = False
		Me.txtMagicName.Size = New System.Drawing.Size(129, 19)
		Me.txtMagicName.Location = New System.Drawing.Point(176, 22)
		Me.txtMagicName.TabIndex = 63
		Me.txtMagicName.Text = "Eternium"
		Me.txtMagicName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMagicName.AcceptsReturn = True
		Me.txtMagicName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMagicName.BackColor = System.Drawing.SystemColors.Window
		Me.txtMagicName.CausesValidation = True
		Me.txtMagicName.Enabled = True
		Me.txtMagicName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMagicName.HideSelection = True
		Me.txtMagicName.ReadOnly = False
		Me.txtMagicName.Maxlength = 0
		Me.txtMagicName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMagicName.MultiLine = False
		Me.txtMagicName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMagicName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMagicName.TabStop = True
		Me.txtMagicName.Visible = True
		Me.txtMagicName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMagicName.Name = "txtMagicName"
		Me.lblFormulaBasis.Text = "x Will"
		Me.lblFormulaBasis.Size = New System.Drawing.Size(65, 17)
		Me.lblFormulaBasis.Location = New System.Drawing.Point(240, 75)
		Me.lblFormulaBasis.TabIndex = 68
		Me.lblFormulaBasis.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFormulaBasis.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblFormulaBasis.BackColor = System.Drawing.SystemColors.Control
		Me.lblFormulaBasis.Enabled = True
		Me.lblFormulaBasis.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblFormulaBasis.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblFormulaBasis.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblFormulaBasis.UseMnemonic = True
		Me.lblFormulaBasis.Visible = True
		Me.lblFormulaBasis.AutoSize = False
		Me.lblFormulaBasis.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblFormulaBasis.Name = "lblFormulaBasis"
		Me.lblMagicFormula.Text = "according to the formula: Eternium ="
		Me.lblMagicFormula.Size = New System.Drawing.Size(193, 17)
		Me.lblMagicFormula.Location = New System.Drawing.Point(8, 74)
		Me.lblMagicFormula.TabIndex = 66
		Me.lblMagicFormula.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMagicFormula.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMagicFormula.BackColor = System.Drawing.SystemColors.Control
		Me.lblMagicFormula.Enabled = True
		Me.lblMagicFormula.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMagicFormula.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMagicFormula.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMagicFormula.UseMnemonic = True
		Me.lblMagicFormula.Visible = True
		Me.lblMagicFormula.AutoSize = False
		Me.lblMagicFormula.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMagicFormula.Name = "lblMagicFormula"
		Me.lblMagicBasis.Text = "Magic capabilities are based on"
		Me.lblMagicBasis.Size = New System.Drawing.Size(161, 17)
		Me.lblMagicBasis.Location = New System.Drawing.Point(8, 48)
		Me.lblMagicBasis.TabIndex = 64
		Me.lblMagicBasis.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMagicBasis.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMagicBasis.BackColor = System.Drawing.SystemColors.Control
		Me.lblMagicBasis.Enabled = True
		Me.lblMagicBasis.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMagicBasis.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMagicBasis.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMagicBasis.UseMnemonic = True
		Me.lblMagicBasis.Visible = True
		Me.lblMagicBasis.AutoSize = False
		Me.lblMagicBasis.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMagicBasis.Name = "lblMagicBasis"
		Me.lblMagicName.Text = "Magic will drain the attribute"
		Me.lblMagicName.Size = New System.Drawing.Size(145, 17)
		Me.lblMagicName.Location = New System.Drawing.Point(8, 24)
		Me.lblMagicName.TabIndex = 62
		Me.lblMagicName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMagicName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMagicName.BackColor = System.Drawing.SystemColors.Control
		Me.lblMagicName.Enabled = True
		Me.lblMagicName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMagicName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMagicName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMagicName.UseMnemonic = True
		Me.lblMagicName.Visible = True
		Me.lblMagicName.AutoSize = False
		Me.lblMagicName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMagicName.Name = "lblMagicName"
		Me.lblRandMagicPerLvl.Text = "Randomize Magic per Level"
		Me.lblRandMagicPerLvl.Size = New System.Drawing.Size(97, 27)
		Me.lblRandMagicPerLvl.Location = New System.Drawing.Point(216, 156)
		Me.lblRandMagicPerLvl.TabIndex = 80
		Me.lblRandMagicPerLvl.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRandMagicPerLvl.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblRandMagicPerLvl.BackColor = System.Drawing.SystemColors.Control
		Me.lblRandMagicPerLvl.Enabled = True
		Me.lblRandMagicPerLvl.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblRandMagicPerLvl.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblRandMagicPerLvl.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblRandMagicPerLvl.UseMnemonic = True
		Me.lblRandMagicPerLvl.Visible = True
		Me.lblRandMagicPerLvl.AutoSize = False
		Me.lblRandMagicPerLvl.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblRandMagicPerLvl.Name = "lblRandMagicPerLvl"
		Me.lblMagicPerLevel.Text = "Magic Points gained per level"
		Me.lblMagicPerLevel.Size = New System.Drawing.Size(145, 17)
		Me.lblMagicPerLevel.Location = New System.Drawing.Point(8, 160)
		Me.lblMagicPerLevel.TabIndex = 77
		Me.lblMagicPerLevel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMagicPerLevel.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMagicPerLevel.BackColor = System.Drawing.SystemColors.Control
		Me.lblMagicPerLevel.Enabled = True
		Me.lblMagicPerLevel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMagicPerLevel.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMagicPerLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMagicPerLevel.UseMnemonic = True
		Me.lblMagicPerLevel.Visible = True
		Me.lblMagicPerLevel.AutoSize = False
		Me.lblMagicPerLevel.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMagicPerLevel.Name = "lblMagicPerLevel"
		Me._fraKingdom_2.Size = New System.Drawing.Size(329, 353)
		Me._fraKingdom_2.Location = New System.Drawing.Point(16, 93)
		Me._fraKingdom_2.TabIndex = 54
		Me._fraKingdom_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraKingdom_2.BackColor = System.Drawing.SystemColors.Control
		Me._fraKingdom_2.Enabled = True
		Me._fraKingdom_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraKingdom_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraKingdom_2.Visible = True
		Me._fraKingdom_2.Padding = New System.Windows.Forms.Padding(0)
		Me._fraKingdom_2.Name = "_fraKingdom_2"
		Me.txtIntroMusic.AutoSize = False
		Me.txtIntroMusic.Size = New System.Drawing.Size(241, 19)
		Me.txtIntroMusic.Location = New System.Drawing.Point(80, 32)
		Me.txtIntroMusic.TabIndex = 94
		Me.txtIntroMusic.Text = "Not defined."
		Me.txtIntroMusic.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtIntroMusic.AcceptsReturn = True
		Me.txtIntroMusic.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtIntroMusic.BackColor = System.Drawing.SystemColors.Window
		Me.txtIntroMusic.CausesValidation = True
		Me.txtIntroMusic.Enabled = True
		Me.txtIntroMusic.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtIntroMusic.HideSelection = True
		Me.txtIntroMusic.ReadOnly = False
		Me.txtIntroMusic.Maxlength = 0
		Me.txtIntroMusic.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtIntroMusic.MultiLine = False
		Me.txtIntroMusic.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtIntroMusic.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtIntroMusic.TabStop = True
		Me.txtIntroMusic.Visible = True
		Me.txtIntroMusic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtIntroMusic.Name = "txtIntroMusic"
		Me.txtMusicFolder.AutoSize = False
		Me.txtMusicFolder.Size = New System.Drawing.Size(241, 19)
		Me.txtMusicFolder.Location = New System.Drawing.Point(80, 10)
		Me.txtMusicFolder.TabIndex = 92
		Me.txtMusicFolder.Text = "Not defined."
		Me.txtMusicFolder.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMusicFolder.AcceptsReturn = True
		Me.txtMusicFolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMusicFolder.BackColor = System.Drawing.SystemColors.Window
		Me.txtMusicFolder.CausesValidation = True
		Me.txtMusicFolder.Enabled = True
		Me.txtMusicFolder.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMusicFolder.HideSelection = True
		Me.txtMusicFolder.ReadOnly = False
		Me.txtMusicFolder.Maxlength = 0
		Me.txtMusicFolder.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMusicFolder.MultiLine = False
		Me.txtMusicFolder.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMusicFolder.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMusicFolder.TabStop = True
		Me.txtMusicFolder.Visible = True
		Me.txtMusicFolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMusicFolder.Name = "txtMusicFolder"
		Me._picWorldDesc_0.Size = New System.Drawing.Size(145, 142)
		Me._picWorldDesc_0.Location = New System.Drawing.Point(8, 208)
		Me._picWorldDesc_0.TabIndex = 57
		Me._picWorldDesc_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picWorldDesc_0.Dock = System.Windows.Forms.DockStyle.None
		Me._picWorldDesc_0.BackColor = System.Drawing.SystemColors.Control
		Me._picWorldDesc_0.CausesValidation = True
		Me._picWorldDesc_0.Enabled = True
		Me._picWorldDesc_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picWorldDesc_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._picWorldDesc_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picWorldDesc_0.TabStop = True
		Me._picWorldDesc_0.Visible = True
		Me._picWorldDesc_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._picWorldDesc_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._picWorldDesc_0.Name = "_picWorldDesc_0"
		Me._picWorldDesc_1.Size = New System.Drawing.Size(145, 142)
		Me._picWorldDesc_1.Location = New System.Drawing.Point(176, 208)
		Me._picWorldDesc_1.TabIndex = 56
		Me._picWorldDesc_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picWorldDesc_1.Dock = System.Windows.Forms.DockStyle.None
		Me._picWorldDesc_1.BackColor = System.Drawing.SystemColors.Control
		Me._picWorldDesc_1.CausesValidation = True
		Me._picWorldDesc_1.Enabled = True
		Me._picWorldDesc_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picWorldDesc_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._picWorldDesc_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picWorldDesc_1.TabStop = True
		Me._picWorldDesc_1.Visible = True
		Me._picWorldDesc_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._picWorldDesc_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._picWorldDesc_1.Name = "_picWorldDesc_1"
		Me.txtWorldDesc.AutoSize = False
		Me.txtWorldDesc.Size = New System.Drawing.Size(313, 121)
		Me.txtWorldDesc.Location = New System.Drawing.Point(8, 72)
		Me.txtWorldDesc.MultiLine = True
		Me.txtWorldDesc.TabIndex = 55
		Me.txtWorldDesc.Text = "No description available." & Chr(13) & Chr(10)
		Me.txtWorldDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtWorldDesc.AcceptsReturn = True
		Me.txtWorldDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtWorldDesc.BackColor = System.Drawing.SystemColors.Window
		Me.txtWorldDesc.CausesValidation = True
		Me.txtWorldDesc.Enabled = True
		Me.txtWorldDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtWorldDesc.HideSelection = True
		Me.txtWorldDesc.ReadOnly = False
		Me.txtWorldDesc.Maxlength = 0
		Me.txtWorldDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtWorldDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtWorldDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtWorldDesc.TabStop = True
		Me.txtWorldDesc.Visible = True
		Me.txtWorldDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtWorldDesc.Name = "txtWorldDesc"
		Me.lblIntroMusic.Text = "Intro Music"
		Me.lblIntroMusic.Size = New System.Drawing.Size(65, 17)
		Me.lblIntroMusic.Location = New System.Drawing.Point(8, 35)
		Me.lblIntroMusic.TabIndex = 93
		Me.lblIntroMusic.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblIntroMusic.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblIntroMusic.BackColor = System.Drawing.SystemColors.Control
		Me.lblIntroMusic.Enabled = True
		Me.lblIntroMusic.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblIntroMusic.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblIntroMusic.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblIntroMusic.UseMnemonic = True
		Me.lblIntroMusic.Visible = True
		Me.lblIntroMusic.AutoSize = False
		Me.lblIntroMusic.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblIntroMusic.Name = "lblIntroMusic"
		Me.lblMusicFolder.Text = "Music Folder"
		Me.lblMusicFolder.Size = New System.Drawing.Size(65, 17)
		Me.lblMusicFolder.Location = New System.Drawing.Point(8, 12)
		Me.lblMusicFolder.TabIndex = 91
		Me.lblMusicFolder.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMusicFolder.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMusicFolder.BackColor = System.Drawing.SystemColors.Control
		Me.lblMusicFolder.Enabled = True
		Me.lblMusicFolder.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMusicFolder.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMusicFolder.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMusicFolder.UseMnemonic = True
		Me.lblMusicFolder.Visible = True
		Me.lblMusicFolder.AutoSize = False
		Me.lblMusicFolder.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMusicFolder.Name = "lblMusicFolder"
		Me._lblWorldDesc_0.Text = "Briefly describe the world."
		Me._lblWorldDesc_0.Size = New System.Drawing.Size(153, 17)
		Me._lblWorldDesc_0.Location = New System.Drawing.Point(8, 56)
		Me._lblWorldDesc_0.TabIndex = 59
		Me._lblWorldDesc_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblWorldDesc_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblWorldDesc_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblWorldDesc_0.Enabled = True
		Me._lblWorldDesc_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblWorldDesc_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblWorldDesc_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblWorldDesc_0.UseMnemonic = True
		Me._lblWorldDesc_0.Visible = True
		Me._lblWorldDesc_0.AutoSize = False
		Me._lblWorldDesc_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblWorldDesc_0.Name = "_lblWorldDesc_0"
		Me._lblWorldDesc_1.Text = "Pictures representative of the world."
		Me._lblWorldDesc_1.Size = New System.Drawing.Size(313, 17)
		Me._lblWorldDesc_1.Location = New System.Drawing.Point(8, 192)
		Me._lblWorldDesc_1.TabIndex = 58
		Me._lblWorldDesc_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblWorldDesc_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblWorldDesc_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblWorldDesc_1.Enabled = True
		Me._lblWorldDesc_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblWorldDesc_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblWorldDesc_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblWorldDesc_1.UseMnemonic = True
		Me._lblWorldDesc_1.Visible = True
		Me._lblWorldDesc_1.AutoSize = False
		Me._lblWorldDesc_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblWorldDesc_1.Name = "_lblWorldDesc_1"
		Me._fraKingdom_0.Size = New System.Drawing.Size(329, 353)
		Me._fraKingdom_0.Location = New System.Drawing.Point(16, 93)
		Me._fraKingdom_0.TabIndex = 1
		Me._fraKingdom_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraKingdom_0.BackColor = System.Drawing.SystemColors.Control
		Me._fraKingdom_0.Enabled = True
		Me._fraKingdom_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraKingdom_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraKingdom_0.Visible = True
		Me._fraKingdom_0.Padding = New System.Windows.Forms.Padding(0)
		Me._fraKingdom_0.Name = "_fraKingdom_0"
		Me._optGender_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optGender_1.Text = "Female"
		Me._optGender_1.Size = New System.Drawing.Size(65, 13)
		Me._optGender_1.Location = New System.Drawing.Point(168, 220)
		Me._optGender_1.TabIndex = 88
		Me._optGender_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optGender_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optGender_1.BackColor = System.Drawing.SystemColors.Control
		Me._optGender_1.CausesValidation = True
		Me._optGender_1.Enabled = True
		Me._optGender_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optGender_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optGender_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optGender_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optGender_1.TabStop = True
		Me._optGender_1.Checked = False
		Me._optGender_1.Visible = True
		Me._optGender_1.Name = "_optGender_1"
		Me._optGender_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optGender_0.Text = "Male"
		Me._optGender_0.Size = New System.Drawing.Size(65, 13)
		Me._optGender_0.Location = New System.Drawing.Point(16, 220)
		Me._optGender_0.TabIndex = 87
		Me._optGender_0.Checked = True
		Me._optGender_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optGender_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optGender_0.BackColor = System.Drawing.SystemColors.Control
		Me._optGender_0.CausesValidation = True
		Me._optGender_0.Enabled = True
		Me._optGender_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optGender_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optGender_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optGender_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optGender_0.TabStop = True
		Me._optGender_0.Visible = True
		Me._optGender_0.Name = "_optGender_0"
		Me.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnQuit.Text = "Exit"
		Me.btnQuit.Size = New System.Drawing.Size(81, 30)
		Me.btnQuit.Location = New System.Drawing.Point(192, 318)
		Me.btnQuit.TabIndex = 33
		Me.btnQuit.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnQuit.BackColor = System.Drawing.SystemColors.Control
		Me.btnQuit.CausesValidation = True
		Me.btnQuit.Enabled = True
		Me.btnQuit.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnQuit.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnQuit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnQuit.TabStop = True
		Me.btnQuit.Name = "btnQuit"
		Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnSave.Text = "Save"
		Me.btnSave.Size = New System.Drawing.Size(81, 30)
		Me.btnSave.Location = New System.Drawing.Point(64, 318)
		Me.btnSave.TabIndex = 32
		Me.btnSave.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSave.BackColor = System.Drawing.SystemColors.Control
		Me.btnSave.CausesValidation = True
		Me.btnSave.Enabled = True
		Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSave.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSave.TabStop = True
		Me.btnSave.Name = "btnSave"
		Me._txtPictureName_0.AutoSize = False
		Me._txtPictureName_0.Enabled = False
		Me._txtPictureName_0.Size = New System.Drawing.Size(49, 19)
		Me._txtPictureName_0.Location = New System.Drawing.Point(12, 294)
		Me._txtPictureName_0.TabIndex = 29
		Me._txtPictureName_0.Text = "Nobody"
		Me._txtPictureName_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtPictureName_0.AcceptsReturn = True
		Me._txtPictureName_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtPictureName_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtPictureName_0.CausesValidation = True
		Me._txtPictureName_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtPictureName_0.HideSelection = True
		Me._txtPictureName_0.ReadOnly = False
		Me._txtPictureName_0.Maxlength = 0
		Me._txtPictureName_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtPictureName_0.MultiLine = False
		Me._txtPictureName_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtPictureName_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtPictureName_0.TabStop = True
		Me._txtPictureName_0.Visible = True
		Me._txtPictureName_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtPictureName_0.Name = "_txtPictureName_0"
		Me._picInhabitant_5.Size = New System.Drawing.Size(49, 57)
		Me._picInhabitant_5.Location = New System.Drawing.Point(274, 235)
		Me._picInhabitant_5.TabIndex = 24
		Me._picInhabitant_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picInhabitant_5.Dock = System.Windows.Forms.DockStyle.None
		Me._picInhabitant_5.BackColor = System.Drawing.SystemColors.Control
		Me._picInhabitant_5.CausesValidation = True
		Me._picInhabitant_5.Enabled = True
		Me._picInhabitant_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picInhabitant_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._picInhabitant_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picInhabitant_5.TabStop = True
		Me._picInhabitant_5.Visible = True
		Me._picInhabitant_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._picInhabitant_5.Name = "_picInhabitant_5"
		Me._shpFace_5.BorderColor = System.Drawing.Color.Yellow
		Me._shpFace_5.BorderWidth = 2
		Me._shpFace_5.Size = New System.Drawing.Size(17, 16)
		Me._shpFace_5.Location = New System.Drawing.Point(16, 8)
		Me._shpFace_5.BackColor = System.Drawing.SystemColors.Window
		Me._shpFace_5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me._shpFace_5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me._shpFace_5.FillColor = System.Drawing.Color.Black
		Me._shpFace_5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me._shpFace_5.Visible = True
		Me._shpFace_5.Name = "_shpFace_5"
		Me._picInhabitant_4.Size = New System.Drawing.Size(49, 57)
		Me._picInhabitant_4.Location = New System.Drawing.Point(222, 235)
		Me._picInhabitant_4.TabIndex = 23
		Me._picInhabitant_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picInhabitant_4.Dock = System.Windows.Forms.DockStyle.None
		Me._picInhabitant_4.BackColor = System.Drawing.SystemColors.Control
		Me._picInhabitant_4.CausesValidation = True
		Me._picInhabitant_4.Enabled = True
		Me._picInhabitant_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picInhabitant_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._picInhabitant_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picInhabitant_4.TabStop = True
		Me._picInhabitant_4.Visible = True
		Me._picInhabitant_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._picInhabitant_4.Name = "_picInhabitant_4"
		Me._shpFace_4.BorderColor = System.Drawing.Color.Yellow
		Me._shpFace_4.BorderWidth = 2
		Me._shpFace_4.Size = New System.Drawing.Size(17, 16)
		Me._shpFace_4.Location = New System.Drawing.Point(16, 8)
		Me._shpFace_4.BackColor = System.Drawing.SystemColors.Window
		Me._shpFace_4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me._shpFace_4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me._shpFace_4.FillColor = System.Drawing.Color.Black
		Me._shpFace_4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me._shpFace_4.Visible = True
		Me._shpFace_4.Name = "_shpFace_4"
		Me._picInhabitant_3.Size = New System.Drawing.Size(49, 57)
		Me._picInhabitant_3.Location = New System.Drawing.Point(169, 235)
		Me._picInhabitant_3.TabIndex = 22
		Me._picInhabitant_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picInhabitant_3.Dock = System.Windows.Forms.DockStyle.None
		Me._picInhabitant_3.BackColor = System.Drawing.SystemColors.Control
		Me._picInhabitant_3.CausesValidation = True
		Me._picInhabitant_3.Enabled = True
		Me._picInhabitant_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picInhabitant_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._picInhabitant_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picInhabitant_3.TabStop = True
		Me._picInhabitant_3.Visible = True
		Me._picInhabitant_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._picInhabitant_3.Name = "_picInhabitant_3"
		Me._shpFace_3.BorderColor = System.Drawing.Color.Yellow
		Me._shpFace_3.BorderWidth = 2
		Me._shpFace_3.Size = New System.Drawing.Size(17, 16)
		Me._shpFace_3.Location = New System.Drawing.Point(16, 8)
		Me._shpFace_3.BackColor = System.Drawing.SystemColors.Window
		Me._shpFace_3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me._shpFace_3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me._shpFace_3.FillColor = System.Drawing.Color.Black
		Me._shpFace_3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me._shpFace_3.Visible = True
		Me._shpFace_3.Name = "_shpFace_3"
		Me._picInhabitant_2.Size = New System.Drawing.Size(49, 57)
		Me._picInhabitant_2.Location = New System.Drawing.Point(118, 235)
		Me._picInhabitant_2.TabIndex = 21
		Me._picInhabitant_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picInhabitant_2.Dock = System.Windows.Forms.DockStyle.None
		Me._picInhabitant_2.BackColor = System.Drawing.SystemColors.Control
		Me._picInhabitant_2.CausesValidation = True
		Me._picInhabitant_2.Enabled = True
		Me._picInhabitant_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picInhabitant_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._picInhabitant_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picInhabitant_2.TabStop = True
		Me._picInhabitant_2.Visible = True
		Me._picInhabitant_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._picInhabitant_2.Name = "_picInhabitant_2"
		Me._shpFace_2.BorderColor = System.Drawing.Color.Yellow
		Me._shpFace_2.BorderWidth = 2
		Me._shpFace_2.Size = New System.Drawing.Size(17, 16)
		Me._shpFace_2.Location = New System.Drawing.Point(16, 8)
		Me._shpFace_2.BackColor = System.Drawing.SystemColors.Window
		Me._shpFace_2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me._shpFace_2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me._shpFace_2.FillColor = System.Drawing.Color.Black
		Me._shpFace_2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me._shpFace_2.Visible = True
		Me._shpFace_2.Name = "_shpFace_2"
		Me._picInhabitant_1.Size = New System.Drawing.Size(49, 57)
		Me._picInhabitant_1.Location = New System.Drawing.Point(66, 235)
		Me._picInhabitant_1.TabIndex = 20
		Me._picInhabitant_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picInhabitant_1.Dock = System.Windows.Forms.DockStyle.None
		Me._picInhabitant_1.BackColor = System.Drawing.SystemColors.Control
		Me._picInhabitant_1.CausesValidation = True
		Me._picInhabitant_1.Enabled = True
		Me._picInhabitant_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picInhabitant_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._picInhabitant_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picInhabitant_1.TabStop = True
		Me._picInhabitant_1.Visible = True
		Me._picInhabitant_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._picInhabitant_1.Name = "_picInhabitant_1"
		Me._shpFace_1.BorderColor = System.Drawing.Color.Yellow
		Me._shpFace_1.BorderWidth = 2
		Me._shpFace_1.Size = New System.Drawing.Size(17, 16)
		Me._shpFace_1.Location = New System.Drawing.Point(16, 8)
		Me._shpFace_1.BackColor = System.Drawing.SystemColors.Window
		Me._shpFace_1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me._shpFace_1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me._shpFace_1.FillColor = System.Drawing.Color.Black
		Me._shpFace_1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me._shpFace_1.Visible = True
		Me._shpFace_1.Name = "_shpFace_1"
		Me._picInhabitant_0.Size = New System.Drawing.Size(49, 57)
		Me._picInhabitant_0.Location = New System.Drawing.Point(12, 235)
		Me._picInhabitant_0.TabIndex = 19
		Me._picInhabitant_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picInhabitant_0.Dock = System.Windows.Forms.DockStyle.None
		Me._picInhabitant_0.BackColor = System.Drawing.SystemColors.Control
		Me._picInhabitant_0.CausesValidation = True
		Me._picInhabitant_0.Enabled = True
		Me._picInhabitant_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picInhabitant_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._picInhabitant_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picInhabitant_0.TabStop = True
		Me._picInhabitant_0.Visible = True
		Me._picInhabitant_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._picInhabitant_0.Name = "_picInhabitant_0"
		Me._shpFace_0.BorderColor = System.Drawing.Color.Yellow
		Me._shpFace_0.BorderWidth = 2
		Me._shpFace_0.Size = New System.Drawing.Size(17, 16)
		Me._shpFace_0.Location = New System.Drawing.Point(16, 8)
		Me._shpFace_0.BackColor = System.Drawing.SystemColors.Window
		Me._shpFace_0.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me._shpFace_0.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me._shpFace_0.FillColor = System.Drawing.Color.Black
		Me._shpFace_0.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me._shpFace_0.Visible = True
		Me._shpFace_0.Name = "_shpFace_0"
		Me.txtKingdomSet.AutoSize = False
		Me.txtKingdomSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtKingdomSet.Size = New System.Drawing.Size(33, 19)
		Me.txtKingdomSet.Location = New System.Drawing.Point(288, 8)
		Me.txtKingdomSet.TabIndex = 15
		Me.txtKingdomSet.Text = "0"
		Me.txtKingdomSet.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtKingdomSet.AcceptsReturn = True
		Me.txtKingdomSet.BackColor = System.Drawing.SystemColors.Window
		Me.txtKingdomSet.CausesValidation = True
		Me.txtKingdomSet.Enabled = True
		Me.txtKingdomSet.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtKingdomSet.HideSelection = True
		Me.txtKingdomSet.ReadOnly = False
		Me.txtKingdomSet.Maxlength = 0
		Me.txtKingdomSet.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtKingdomSet.MultiLine = False
		Me.txtKingdomSet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtKingdomSet.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtKingdomSet.TabStop = True
		Me.txtKingdomSet.Visible = True
		Me.txtKingdomSet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtKingdomSet.Name = "txtKingdomSet"
		Me._txtPictureName_5.AutoSize = False
		Me._txtPictureName_5.Enabled = False
		Me._txtPictureName_5.Size = New System.Drawing.Size(49, 20)
		Me._txtPictureName_5.Location = New System.Drawing.Point(274, 294)
		Me._txtPictureName_5.TabIndex = 14
		Me._txtPictureName_5.Text = "Nobody"
		Me._txtPictureName_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtPictureName_5.AcceptsReturn = True
		Me._txtPictureName_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtPictureName_5.BackColor = System.Drawing.SystemColors.Window
		Me._txtPictureName_5.CausesValidation = True
		Me._txtPictureName_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtPictureName_5.HideSelection = True
		Me._txtPictureName_5.ReadOnly = False
		Me._txtPictureName_5.Maxlength = 0
		Me._txtPictureName_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtPictureName_5.MultiLine = False
		Me._txtPictureName_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtPictureName_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtPictureName_5.TabStop = True
		Me._txtPictureName_5.Visible = True
		Me._txtPictureName_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtPictureName_5.Name = "_txtPictureName_5"
		Me._txtPictureName_4.AutoSize = False
		Me._txtPictureName_4.Enabled = False
		Me._txtPictureName_4.Size = New System.Drawing.Size(49, 20)
		Me._txtPictureName_4.Location = New System.Drawing.Point(222, 294)
		Me._txtPictureName_4.TabIndex = 9
		Me._txtPictureName_4.Text = "Nobody"
		Me._txtPictureName_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtPictureName_4.AcceptsReturn = True
		Me._txtPictureName_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtPictureName_4.BackColor = System.Drawing.SystemColors.Window
		Me._txtPictureName_4.CausesValidation = True
		Me._txtPictureName_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtPictureName_4.HideSelection = True
		Me._txtPictureName_4.ReadOnly = False
		Me._txtPictureName_4.Maxlength = 0
		Me._txtPictureName_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtPictureName_4.MultiLine = False
		Me._txtPictureName_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtPictureName_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtPictureName_4.TabStop = True
		Me._txtPictureName_4.Visible = True
		Me._txtPictureName_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtPictureName_4.Name = "_txtPictureName_4"
		Me._txtPictureName_3.AutoSize = False
		Me._txtPictureName_3.Enabled = False
		Me._txtPictureName_3.Size = New System.Drawing.Size(49, 20)
		Me._txtPictureName_3.Location = New System.Drawing.Point(170, 294)
		Me._txtPictureName_3.TabIndex = 8
		Me._txtPictureName_3.Text = "Nobody"
		Me._txtPictureName_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtPictureName_3.AcceptsReturn = True
		Me._txtPictureName_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtPictureName_3.BackColor = System.Drawing.SystemColors.Window
		Me._txtPictureName_3.CausesValidation = True
		Me._txtPictureName_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtPictureName_3.HideSelection = True
		Me._txtPictureName_3.ReadOnly = False
		Me._txtPictureName_3.Maxlength = 0
		Me._txtPictureName_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtPictureName_3.MultiLine = False
		Me._txtPictureName_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtPictureName_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtPictureName_3.TabStop = True
		Me._txtPictureName_3.Visible = True
		Me._txtPictureName_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtPictureName_3.Name = "_txtPictureName_3"
		Me._txtPictureName_2.AutoSize = False
		Me._txtPictureName_2.Enabled = False
		Me._txtPictureName_2.Size = New System.Drawing.Size(49, 20)
		Me._txtPictureName_2.Location = New System.Drawing.Point(118, 294)
		Me._txtPictureName_2.TabIndex = 7
		Me._txtPictureName_2.Text = "Nobody"
		Me._txtPictureName_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtPictureName_2.AcceptsReturn = True
		Me._txtPictureName_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtPictureName_2.BackColor = System.Drawing.SystemColors.Window
		Me._txtPictureName_2.CausesValidation = True
		Me._txtPictureName_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtPictureName_2.HideSelection = True
		Me._txtPictureName_2.ReadOnly = False
		Me._txtPictureName_2.Maxlength = 0
		Me._txtPictureName_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtPictureName_2.MultiLine = False
		Me._txtPictureName_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtPictureName_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtPictureName_2.TabStop = True
		Me._txtPictureName_2.Visible = True
		Me._txtPictureName_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtPictureName_2.Name = "_txtPictureName_2"
		Me._txtPictureName_1.AutoSize = False
		Me._txtPictureName_1.Enabled = False
		Me._txtPictureName_1.Size = New System.Drawing.Size(49, 19)
		Me._txtPictureName_1.Location = New System.Drawing.Point(66, 294)
		Me._txtPictureName_1.TabIndex = 6
		Me._txtPictureName_1.Text = "Nobody"
		Me._txtPictureName_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtPictureName_1.AcceptsReturn = True
		Me._txtPictureName_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtPictureName_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtPictureName_1.CausesValidation = True
		Me._txtPictureName_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtPictureName_1.HideSelection = True
		Me._txtPictureName_1.ReadOnly = False
		Me._txtPictureName_1.Maxlength = 0
		Me._txtPictureName_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtPictureName_1.MultiLine = False
		Me._txtPictureName_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtPictureName_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtPictureName_1.TabStop = True
		Me._txtPictureName_1.Visible = True
		Me._txtPictureName_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtPictureName_1.Name = "_txtPictureName_1"
		Me.btnLeftRoster.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnLeftRoster.Size = New System.Drawing.Size(25, 33)
		Me.btnLeftRoster.Location = New System.Drawing.Point(12, 315)
		Me.btnLeftRoster.Image = CType(resources.GetObject("btnLeftRoster.Image"), System.Drawing.Image)
		Me.btnLeftRoster.TabIndex = 5
		Me.btnLeftRoster.Visible = False
		Me.btnLeftRoster.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLeftRoster.BackColor = System.Drawing.SystemColors.Control
		Me.btnLeftRoster.CausesValidation = True
		Me.btnLeftRoster.Enabled = True
		Me.btnLeftRoster.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLeftRoster.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnLeftRoster.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnLeftRoster.TabStop = True
		Me.btnLeftRoster.Name = "btnLeftRoster"
		Me.btnRightRoster.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnRightRoster.Size = New System.Drawing.Size(25, 33)
		Me.btnRightRoster.Location = New System.Drawing.Point(296, 315)
		Me.btnRightRoster.Image = CType(resources.GetObject("btnRightRoster.Image"), System.Drawing.Image)
		Me.btnRightRoster.TabIndex = 4
		Me.btnRightRoster.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnRightRoster.BackColor = System.Drawing.SystemColors.Control
		Me.btnRightRoster.CausesValidation = True
		Me.btnRightRoster.Enabled = True
		Me.btnRightRoster.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnRightRoster.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnRightRoster.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnRightRoster.TabStop = True
		Me.btnRightRoster.Name = "btnRightRoster"
		Me.txtKingdomTemplate.AutoSize = False
		Me.txtKingdomTemplate.Size = New System.Drawing.Size(105, 19)
		Me.txtKingdomTemplate.Location = New System.Drawing.Point(120, 8)
		Me.txtKingdomTemplate.TabIndex = 2
		Me.txtKingdomTemplate.Text = "Nobody"
		Me.txtKingdomTemplate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtKingdomTemplate.AcceptsReturn = True
		Me.txtKingdomTemplate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtKingdomTemplate.BackColor = System.Drawing.SystemColors.Window
		Me.txtKingdomTemplate.CausesValidation = True
		Me.txtKingdomTemplate.Enabled = True
		Me.txtKingdomTemplate.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtKingdomTemplate.HideSelection = True
		Me.txtKingdomTemplate.ReadOnly = False
		Me.txtKingdomTemplate.Maxlength = 0
		Me.txtKingdomTemplate.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtKingdomTemplate.MultiLine = False
		Me.txtKingdomTemplate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtKingdomTemplate.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtKingdomTemplate.TabStop = True
		Me.txtKingdomTemplate.Visible = True
		Me.txtKingdomTemplate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtKingdomTemplate.Name = "txtKingdomTemplate"
		Me.picKingdom.Size = New System.Drawing.Size(313, 185)
		Me.picKingdom.Location = New System.Drawing.Point(8, 32)
		Me.picKingdom.TabIndex = 18
		Me.picKingdom.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picKingdom.Dock = System.Windows.Forms.DockStyle.None
		Me.picKingdom.BackColor = System.Drawing.SystemColors.Control
		Me.picKingdom.CausesValidation = True
		Me.picKingdom.Enabled = True
		Me.picKingdom.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picKingdom.Cursor = System.Windows.Forms.Cursors.Default
		Me.picKingdom.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picKingdom.TabStop = True
		Me.picKingdom.Visible = True
		Me.picKingdom.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.picKingdom.Name = "picKingdom"
		Me.VScroll1.Size = New System.Drawing.Size(17, 161)
		Me.VScroll1.Location = New System.Drawing.Point(296, 0)
		Me.VScroll1.TabIndex = 27
		Me.VScroll1.CausesValidation = True
		Me.VScroll1.Enabled = True
		Me.VScroll1.LargeChange = 1
		Me.VScroll1.Maximum = 32767
		Me.VScroll1.Minimum = 0
		Me.VScroll1.Cursor = System.Windows.Forms.Cursors.Default
		Me.VScroll1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.VScroll1.SmallChange = 1
		Me.VScroll1.TabStop = True
		Me.VScroll1.Value = 0
		Me.VScroll1.Visible = True
		Me.VScroll1.Name = "VScroll1"
		Me.btnZoomOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnZoomOut.Text = "+"
		Me.btnZoomOut.Font = New System.Drawing.Font("Arial", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnZoomOut.Size = New System.Drawing.Size(25, 29)
		Me.btnZoomOut.Location = New System.Drawing.Point(288, 160)
		Me.btnZoomOut.TabIndex = 40
		Me.btnZoomOut.BackColor = System.Drawing.SystemColors.Control
		Me.btnZoomOut.CausesValidation = True
		Me.btnZoomOut.Enabled = True
		Me.btnZoomOut.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnZoomOut.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnZoomOut.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnZoomOut.TabStop = True
		Me.btnZoomOut.Name = "btnZoomOut"
		Me.HScroll1.Size = New System.Drawing.Size(289, 17)
		Me.HScroll1.Location = New System.Drawing.Point(0, 168)
		Me.HScroll1.TabIndex = 28
		Me.HScroll1.CausesValidation = True
		Me.HScroll1.Enabled = True
		Me.HScroll1.LargeChange = 1
		Me.HScroll1.Maximum = 32767
		Me.HScroll1.Minimum = 0
		Me.HScroll1.Cursor = System.Windows.Forms.Cursors.Default
		Me.HScroll1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HScroll1.SmallChange = 1
		Me.HScroll1.TabStop = True
		Me.HScroll1.Value = 0
		Me.HScroll1.Visible = True
		Me.HScroll1.Name = "HScroll1"
		Me.shpBorder.BorderColor = System.Drawing.Color.Yellow
		Me.shpBorder.BorderWidth = 2
		Me.shpBorder.Size = New System.Drawing.Size(97, 80)
		Me.shpBorder.Location = New System.Drawing.Point(0, 0)
		Me.shpBorder.BackColor = System.Drawing.SystemColors.Window
		Me.shpBorder.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.shpBorder.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.shpBorder.FillColor = System.Drawing.Color.Black
		Me.shpBorder.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.shpBorder.Visible = True
		Me.shpBorder.Name = "shpBorder"
		Me.lblKingdomSet.Text = "Names Set"
		Me.lblKingdomSet.Size = New System.Drawing.Size(57, 17)
		Me.lblKingdomSet.Location = New System.Drawing.Point(232, 10)
		Me.lblKingdomSet.TabIndex = 31
		Me.lblKingdomSet.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblKingdomSet.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblKingdomSet.BackColor = System.Drawing.SystemColors.Control
		Me.lblKingdomSet.Enabled = True
		Me.lblKingdomSet.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblKingdomSet.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblKingdomSet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblKingdomSet.UseMnemonic = True
		Me.lblKingdomSet.Visible = True
		Me.lblKingdomSet.AutoSize = False
		Me.lblKingdomSet.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblKingdomSet.Name = "lblKingdomSet"
		Me.lblKingdomName.Text = "Name of the kingdom"
		Me.lblKingdomName.Size = New System.Drawing.Size(105, 17)
		Me.lblKingdomName.Location = New System.Drawing.Point(8, 10)
		Me.lblKingdomName.TabIndex = 30
		Me.lblKingdomName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblKingdomName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblKingdomName.BackColor = System.Drawing.SystemColors.Control
		Me.lblKingdomName.Enabled = True
		Me.lblKingdomName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblKingdomName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblKingdomName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblKingdomName.UseMnemonic = True
		Me.lblKingdomName.Visible = True
		Me.lblKingdomName.AutoSize = False
		Me.lblKingdomName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblKingdomName.Name = "lblKingdomName"
		Me._txtPicDescName_1.AutoSize = False
		Me._txtPicDescName_1.Size = New System.Drawing.Size(193, 25)
		Me._txtPicDescName_1.Location = New System.Drawing.Point(576, 672)
		Me._txtPicDescName_1.TabIndex = 46
		Me._txtPicDescName_1.Text = "BlankMap.bmp"
		Me._txtPicDescName_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtPicDescName_1.AcceptsReturn = True
		Me._txtPicDescName_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtPicDescName_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtPicDescName_1.CausesValidation = True
		Me._txtPicDescName_1.Enabled = True
		Me._txtPicDescName_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtPicDescName_1.HideSelection = True
		Me._txtPicDescName_1.ReadOnly = False
		Me._txtPicDescName_1.Maxlength = 0
		Me._txtPicDescName_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtPicDescName_1.MultiLine = False
		Me._txtPicDescName_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtPicDescName_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtPicDescName_1.TabStop = True
		Me._txtPicDescName_1.Visible = True
		Me._txtPicDescName_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtPicDescName_1.Name = "_txtPicDescName_1"
		Me._txtPicDescName_0.AutoSize = False
		Me._txtPicDescName_0.Size = New System.Drawing.Size(193, 25)
		Me._txtPicDescName_0.Location = New System.Drawing.Point(576, 640)
		Me._txtPicDescName_0.TabIndex = 45
		Me._txtPicDescName_0.Text = "BlankMap.bmp"
		Me._txtPicDescName_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtPicDescName_0.AcceptsReturn = True
		Me._txtPicDescName_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtPicDescName_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtPicDescName_0.CausesValidation = True
		Me._txtPicDescName_0.Enabled = True
		Me._txtPicDescName_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtPicDescName_0.HideSelection = True
		Me._txtPicDescName_0.ReadOnly = False
		Me._txtPicDescName_0.Maxlength = 0
		Me._txtPicDescName_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtPicDescName_0.MultiLine = False
		Me._txtPicDescName_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtPicDescName_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtPicDescName_0.TabStop = True
		Me._txtPicDescName_0.Visible = True
		Me._txtPicDescName_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtPicDescName_0.Name = "_txtPicDescName_0"
		Me.picMask.BackColor = System.Drawing.SystemColors.Window
		Me.picMask.ForeColor = System.Drawing.SystemColors.WindowText
		Me.picMask.Size = New System.Drawing.Size(65, 84)
		Me.picMask.Location = New System.Drawing.Point(784, 576)
		Me.picMask.TabIndex = 26
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
		Me.picMons.BackColor = System.Drawing.SystemColors.Window
		Me.picMons.ForeColor = System.Drawing.SystemColors.WindowText
		Me.picMons.Size = New System.Drawing.Size(65, 81)
		Me.picMons.Location = New System.Drawing.Point(864, 576)
		Me.picMons.TabIndex = 25
		Me.picMons.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picMons.Dock = System.Windows.Forms.DockStyle.None
		Me.picMons.CausesValidation = True
		Me.picMons.Enabled = True
		Me.picMons.Cursor = System.Windows.Forms.Cursors.Default
		Me.picMons.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picMons.TabStop = True
		Me.picMons.Visible = True
		Me.picMons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.picMons.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.picMons.Name = "picMons"
		Me.txtWorldMap.AutoSize = False
		Me.txtWorldMap.Size = New System.Drawing.Size(193, 25)
		Me.txtWorldMap.Location = New System.Drawing.Point(576, 608)
		Me.txtWorldMap.TabIndex = 17
		Me.txtWorldMap.Text = "BlankMap.bmp"
		Me.txtWorldMap.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtWorldMap.AcceptsReturn = True
		Me.txtWorldMap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtWorldMap.BackColor = System.Drawing.SystemColors.Window
		Me.txtWorldMap.CausesValidation = True
		Me.txtWorldMap.Enabled = True
		Me.txtWorldMap.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtWorldMap.HideSelection = True
		Me.txtWorldMap.ReadOnly = False
		Me.txtWorldMap.Maxlength = 0
		Me.txtWorldMap.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtWorldMap.MultiLine = False
		Me.txtWorldMap.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtWorldMap.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtWorldMap.TabStop = True
		Me.txtWorldMap.Visible = True
		Me.txtWorldMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtWorldMap.Name = "txtWorldMap"
		Me.txtKingdomLocation.AutoSize = False
		Me.txtKingdomLocation.Size = New System.Drawing.Size(193, 25)
		Me.txtKingdomLocation.Location = New System.Drawing.Point(576, 576)
		Me.txtKingdomLocation.TabIndex = 13
		Me.txtKingdomLocation.Text = "Text1"
		Me.txtKingdomLocation.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtKingdomLocation.AcceptsReturn = True
		Me.txtKingdomLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtKingdomLocation.BackColor = System.Drawing.SystemColors.Window
		Me.txtKingdomLocation.CausesValidation = True
		Me.txtKingdomLocation.Enabled = True
		Me.txtKingdomLocation.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtKingdomLocation.HideSelection = True
		Me.txtKingdomLocation.ReadOnly = False
		Me.txtKingdomLocation.Maxlength = 0
		Me.txtKingdomLocation.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtKingdomLocation.MultiLine = False
		Me.txtKingdomLocation.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtKingdomLocation.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtKingdomLocation.TabStop = True
		Me.txtKingdomLocation.Visible = True
		Me.txtKingdomLocation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtKingdomLocation.Name = "txtKingdomLocation"
		Me.txtKingdomPictures.AutoSize = False
		Me.txtKingdomPictures.Size = New System.Drawing.Size(505, 27)
		Me.txtKingdomPictures.Location = New System.Drawing.Point(576, 544)
		Me.txtKingdomPictures.TabIndex = 11
		Me.txtKingdomPictures.Text = "Text2"
		Me.txtKingdomPictures.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtKingdomPictures.AcceptsReturn = True
		Me.txtKingdomPictures.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtKingdomPictures.BackColor = System.Drawing.SystemColors.Window
		Me.txtKingdomPictures.CausesValidation = True
		Me.txtKingdomPictures.Enabled = True
		Me.txtKingdomPictures.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtKingdomPictures.HideSelection = True
		Me.txtKingdomPictures.ReadOnly = False
		Me.txtKingdomPictures.Maxlength = 0
		Me.txtKingdomPictures.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtKingdomPictures.MultiLine = False
		Me.txtKingdomPictures.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtKingdomPictures.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtKingdomPictures.TabStop = True
		Me.txtKingdomPictures.Visible = True
		Me.txtKingdomPictures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtKingdomPictures.Name = "txtKingdomPictures"
		Me.picTmp.Size = New System.Drawing.Size(617, 497)
		Me.picTmp.Location = New System.Drawing.Point(472, 40)
		Me.picTmp.TabIndex = 3
		Me.picTmp.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picTmp.Dock = System.Windows.Forms.DockStyle.None
		Me.picTmp.BackColor = System.Drawing.SystemColors.Control
		Me.picTmp.CausesValidation = True
		Me.picTmp.Enabled = True
		Me.picTmp.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picTmp.Cursor = System.Windows.Forms.Cursors.Default
		Me.picTmp.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picTmp.TabStop = True
		Me.picTmp.Visible = True
		Me.picTmp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picTmp.Name = "picTmp"
		Me.tmpShape.BorderColor = System.Drawing.Color.Red
		Me.tmpShape.BorderWidth = 2
		Me.tmpShape.Size = New System.Drawing.Size(185, 113)
		Me.tmpShape.Location = New System.Drawing.Point(32, 32)
		Me.tmpShape.BackColor = System.Drawing.SystemColors.Window
		Me.tmpShape.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.tmpShape.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.tmpShape.FillColor = System.Drawing.Color.Black
		Me.tmpShape.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.tmpShape.Visible = True
		Me.tmpShape.Name = "tmpShape"
		TabStrip1.OcxState = CType(resources.GetObject("TabStrip1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TabStrip1.Size = New System.Drawing.Size(345, 422)
		Me.TabStrip1.Location = New System.Drawing.Point(8, 28)
		Me.TabStrip1.TabIndex = 0
		Me.TabStrip1.Name = "TabStrip1"
		Me.lblPicDesc.Text = "Names of pictures to describe the world"
		Me.lblPicDesc.Size = New System.Drawing.Size(97, 57)
		Me.lblPicDesc.Location = New System.Drawing.Point(472, 640)
		Me.lblPicDesc.TabIndex = 47
		Me.lblPicDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPicDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPicDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblPicDesc.Enabled = True
		Me.lblPicDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPicDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPicDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPicDesc.UseMnemonic = True
		Me.lblPicDesc.Visible = True
		Me.lblPicDesc.AutoSize = False
		Me.lblPicDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPicDesc.Name = "lblPicDesc"
		Me.lblWorldMap.Text = "World map name"
		Me.lblWorldMap.Size = New System.Drawing.Size(105, 17)
		Me.lblWorldMap.Location = New System.Drawing.Point(472, 608)
		Me.lblWorldMap.TabIndex = 16
		Me.lblWorldMap.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWorldMap.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWorldMap.BackColor = System.Drawing.SystemColors.Control
		Me.lblWorldMap.Enabled = True
		Me.lblWorldMap.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWorldMap.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWorldMap.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWorldMap.UseMnemonic = True
		Me.lblWorldMap.Visible = True
		Me.lblWorldMap.AutoSize = False
		Me.lblWorldMap.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWorldMap.Name = "lblWorldMap"
		Me.lblKingdomLocation.Text = "Kingdom coordinates"
		Me.lblKingdomLocation.Size = New System.Drawing.Size(105, 17)
		Me.lblKingdomLocation.Location = New System.Drawing.Point(472, 576)
		Me.lblKingdomLocation.TabIndex = 12
		Me.lblKingdomLocation.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblKingdomLocation.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblKingdomLocation.BackColor = System.Drawing.SystemColors.Control
		Me.lblKingdomLocation.Enabled = True
		Me.lblKingdomLocation.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblKingdomLocation.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblKingdomLocation.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblKingdomLocation.UseMnemonic = True
		Me.lblKingdomLocation.Visible = True
		Me.lblKingdomLocation.AutoSize = False
		Me.lblKingdomLocation.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblKingdomLocation.Name = "lblKingdomLocation"
		Me.lblKingdomPictures.Text = "Inhabitants pictures"
		Me.lblKingdomPictures.Size = New System.Drawing.Size(97, 17)
		Me.lblKingdomPictures.Location = New System.Drawing.Point(472, 544)
		Me.lblKingdomPictures.TabIndex = 10
		Me.lblKingdomPictures.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblKingdomPictures.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblKingdomPictures.BackColor = System.Drawing.SystemColors.Control
		Me.lblKingdomPictures.Enabled = True
		Me.lblKingdomPictures.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblKingdomPictures.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblKingdomPictures.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblKingdomPictures.UseMnemonic = True
		Me.lblKingdomPictures.Visible = True
		Me.lblKingdomPictures.AutoSize = False
		Me.lblKingdomPictures.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblKingdomPictures.Name = "lblKingdomPictures"
		Me.chkStats.SetIndex(_chkStats_11, CType(11, Short))
		Me.chkStats.SetIndex(_chkStats_10, CType(10, Short))
		Me.chkStats.SetIndex(_chkStats_9, CType(9, Short))
		Me.chkStats.SetIndex(_chkStats_8, CType(8, Short))
		Me.chkStats.SetIndex(_chkStats_7, CType(7, Short))
		Me.chkStats.SetIndex(_chkStats_6, CType(6, Short))
		Me.chkStats.SetIndex(_chkStats_0, CType(0, Short))
		Me.chkStats.SetIndex(_chkStats_5, CType(5, Short))
		Me.chkStats.SetIndex(_chkStats_4, CType(4, Short))
		Me.chkStats.SetIndex(_chkStats_3, CType(3, Short))
		Me.chkStats.SetIndex(_chkStats_2, CType(2, Short))
		Me.chkStats.SetIndex(_chkStats_1, CType(1, Short))
		Me.fraKingdom.SetIndex(_fraKingdom_1, CType(1, Short))
		Me.fraKingdom.SetIndex(_fraKingdom_3, CType(3, Short))
		Me.fraKingdom.SetIndex(_fraKingdom_2, CType(2, Short))
		Me.fraKingdom.SetIndex(_fraKingdom_0, CType(0, Short))
		Me.lblWorldDesc.SetIndex(_lblWorldDesc_0, CType(0, Short))
		Me.lblWorldDesc.SetIndex(_lblWorldDesc_1, CType(1, Short))
		Me.optGender.SetIndex(_optGender_1, CType(1, Short))
		Me.optGender.SetIndex(_optGender_0, CType(0, Short))
		Me.picInhabitant.SetIndex(_picInhabitant_5, CType(5, Short))
		Me.picInhabitant.SetIndex(_picInhabitant_4, CType(4, Short))
		Me.picInhabitant.SetIndex(_picInhabitant_3, CType(3, Short))
		Me.picInhabitant.SetIndex(_picInhabitant_2, CType(2, Short))
		Me.picInhabitant.SetIndex(_picInhabitant_1, CType(1, Short))
		Me.picInhabitant.SetIndex(_picInhabitant_0, CType(0, Short))
		Me.picWorldDesc.SetIndex(_picWorldDesc_0, CType(0, Short))
		Me.picWorldDesc.SetIndex(_picWorldDesc_1, CType(1, Short))
		Me.txtMoney.SetIndex(_txtMoney_0, CType(0, Short))
		Me.txtMoney.SetIndex(_txtMoney_1, CType(1, Short))
		Me.txtPicDescName.SetIndex(_txtPicDescName_1, CType(1, Short))
		Me.txtPicDescName.SetIndex(_txtPicDescName_0, CType(0, Short))
		Me.txtPictureName.SetIndex(_txtPictureName_0, CType(0, Short))
		Me.txtPictureName.SetIndex(_txtPictureName_5, CType(5, Short))
		Me.txtPictureName.SetIndex(_txtPictureName_4, CType(4, Short))
		Me.txtPictureName.SetIndex(_txtPictureName_3, CType(3, Short))
		Me.txtPictureName.SetIndex(_txtPictureName_2, CType(2, Short))
		Me.txtPictureName.SetIndex(_txtPictureName_1, CType(1, Short))
		Me.shpFace.SetIndex(_shpFace_5, CType(5, Short))
		Me.shpFace.SetIndex(_shpFace_4, CType(4, Short))
		Me.shpFace.SetIndex(_shpFace_3, CType(3, Short))
		Me.shpFace.SetIndex(_shpFace_2, CType(2, Short))
		Me.shpFace.SetIndex(_shpFace_1, CType(1, Short))
		Me.shpFace.SetIndex(_shpFace_0, CType(0, Short))
		CType(Me.shpFace, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPictureName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPicDescName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtMoney, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picWorldDesc, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picInhabitant, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.optGender, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblWorldDesc, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.fraKingdom, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chkStats, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(_fraKingdom_1)
		Me.Controls.Add(_fraKingdom_3)
		Me.Controls.Add(_fraKingdom_2)
		Me.Controls.Add(_fraKingdom_0)
		Me.Controls.Add(_txtPicDescName_1)
		Me.Controls.Add(_txtPicDescName_0)
		Me.Controls.Add(picMask)
		Me.Controls.Add(picMons)
		Me.Controls.Add(txtWorldMap)
		Me.Controls.Add(txtKingdomLocation)
		Me.Controls.Add(txtKingdomPictures)
		Me.Controls.Add(picTmp)
		Me.Controls.Add(TabStrip1)
		Me.Controls.Add(lblPicDesc)
		Me.Controls.Add(lblWorldMap)
		Me.Controls.Add(lblKingdomLocation)
		Me.Controls.Add(lblKingdomPictures)
		Me._fraKingdom_1.Controls.Add(cmbInterface)
		Me._fraKingdom_1.Controls.Add(chkRandHP)
		Me._fraKingdom_1.Controls.Add(txtHPperLevel)
		Me._fraKingdom_1.Controls.Add(txtSkillPtsPerLevel)
		Me._fraKingdom_1.Controls.Add(picMoney)
		Me._fraKingdom_1.Controls.Add(_txtMoney_0)
		Me._fraKingdom_1.Controls.Add(txtNumberKingdoms)
		Me._fraKingdom_1.Controls.Add(txtWorldName)
		Me._fraKingdom_1.Controls.Add(_txtMoney_1)
		Me._fraKingdom_1.Controls.Add(picWorldMap)
		Me._fraKingdom_1.Controls.Add(lblInterface)
		Me._fraKingdom_1.Controls.Add(lblRandomHP)
		Me._fraKingdom_1.Controls.Add(lblHPperLevel)
		Me._fraKingdom_1.Controls.Add(lblSkillPts)
		Me._fraKingdom_1.Controls.Add(lblMoney)
		Me._fraKingdom_1.Controls.Add(lblCount)
		Me._fraKingdom_1.Controls.Add(lblWorldName)
		Me._fraKingdom_3.Controls.Add(chkMagicPerLevel)
		Me._fraKingdom_3.Controls.Add(txtMagicPerLevel)
		Me._fraKingdom_3.Controls.Add(fraStats)
		Me._fraKingdom_3.Controls.Add(fraMagic)
		Me._fraKingdom_3.Controls.Add(lblRandMagicPerLvl)
		Me._fraKingdom_3.Controls.Add(lblMagicPerLevel)
		Me.fraStats.Controls.Add(_chkStats_11)
		Me.fraStats.Controls.Add(_chkStats_10)
		Me.fraStats.Controls.Add(_chkStats_9)
		Me.fraStats.Controls.Add(_chkStats_8)
		Me.fraStats.Controls.Add(_chkStats_7)
		Me.fraStats.Controls.Add(_chkStats_6)
		Me.fraStats.Controls.Add(_chkStats_0)
		Me.fraStats.Controls.Add(_chkStats_5)
		Me.fraStats.Controls.Add(_chkStats_4)
		Me.fraStats.Controls.Add(_chkStats_3)
		Me.fraStats.Controls.Add(_chkStats_2)
		Me.fraStats.Controls.Add(_chkStats_1)
		Me.ShapeContainer1.Shapes.Add(Line1)
		Me.fraStats.Controls.Add(ShapeContainer1)
		Me.fraMagic.Controls.Add(chkRunes)
		Me.fraMagic.Controls.Add(txtCoef)
		Me.fraMagic.Controls.Add(cmbMagicBasis)
		Me.fraMagic.Controls.Add(txtMagicName)
		Me.fraMagic.Controls.Add(lblFormulaBasis)
		Me.fraMagic.Controls.Add(lblMagicFormula)
		Me.fraMagic.Controls.Add(lblMagicBasis)
		Me.fraMagic.Controls.Add(lblMagicName)
		Me._fraKingdom_2.Controls.Add(txtIntroMusic)
		Me._fraKingdom_2.Controls.Add(txtMusicFolder)
		Me._fraKingdom_2.Controls.Add(_picWorldDesc_0)
		Me._fraKingdom_2.Controls.Add(_picWorldDesc_1)
		Me._fraKingdom_2.Controls.Add(txtWorldDesc)
		Me._fraKingdom_2.Controls.Add(lblIntroMusic)
		Me._fraKingdom_2.Controls.Add(lblMusicFolder)
		Me._fraKingdom_2.Controls.Add(_lblWorldDesc_0)
		Me._fraKingdom_2.Controls.Add(_lblWorldDesc_1)
		Me._fraKingdom_0.Controls.Add(_optGender_1)
		Me._fraKingdom_0.Controls.Add(_optGender_0)
		Me._fraKingdom_0.Controls.Add(btnQuit)
		Me._fraKingdom_0.Controls.Add(btnSave)
		Me._fraKingdom_0.Controls.Add(_txtPictureName_0)
		Me._fraKingdom_0.Controls.Add(_picInhabitant_5)
		Me._fraKingdom_0.Controls.Add(_picInhabitant_4)
		Me._fraKingdom_0.Controls.Add(_picInhabitant_3)
		Me._fraKingdom_0.Controls.Add(_picInhabitant_2)
		Me._fraKingdom_0.Controls.Add(_picInhabitant_1)
		Me._fraKingdom_0.Controls.Add(_picInhabitant_0)
		Me._fraKingdom_0.Controls.Add(txtKingdomSet)
		Me._fraKingdom_0.Controls.Add(_txtPictureName_5)
		Me._fraKingdom_0.Controls.Add(_txtPictureName_4)
		Me._fraKingdom_0.Controls.Add(_txtPictureName_3)
		Me._fraKingdom_0.Controls.Add(_txtPictureName_2)
		Me._fraKingdom_0.Controls.Add(_txtPictureName_1)
		Me._fraKingdom_0.Controls.Add(btnLeftRoster)
		Me._fraKingdom_0.Controls.Add(btnRightRoster)
		Me._fraKingdom_0.Controls.Add(txtKingdomTemplate)
		Me._fraKingdom_0.Controls.Add(picKingdom)
		Me._fraKingdom_0.Controls.Add(lblKingdomSet)
		Me._fraKingdom_0.Controls.Add(lblKingdomName)
		Me.ShapeContainer1.Shapes.Add(_shpFace_5)
		Me.ShapeContainer2.Shapes.Add(_shpFace_4)
		Me._picInhabitant_4.Controls.Add(ShapeContainer2)
		Me.ShapeContainer3.Shapes.Add(_shpFace_3)
		Me._picInhabitant_3.Controls.Add(ShapeContainer3)
		Me.ShapeContainer4.Shapes.Add(_shpFace_2)
		Me._picInhabitant_2.Controls.Add(ShapeContainer4)
		Me.ShapeContainer5.Shapes.Add(_shpFace_1)
		Me._picInhabitant_1.Controls.Add(ShapeContainer5)
		Me.ShapeContainer6.Shapes.Add(_shpFace_0)
		Me._picInhabitant_0.Controls.Add(ShapeContainer6)
		Me.picKingdom.Controls.Add(VScroll1)
		Me.picKingdom.Controls.Add(btnZoomOut)
		Me.picKingdom.Controls.Add(HScroll1)
		Me.ShapeContainer7.Shapes.Add(shpBorder)
		Me.picKingdom.Controls.Add(ShapeContainer7)
		Me.ShapeContainer8.Shapes.Add(tmpShape)
		Me.picTmp.Controls.Add(ShapeContainer8)
		MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuAddRemove, Me.mnuSave, Me.mnuWorldPackage, Me.mnuQuit})
		mnuAddRemove.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuAdd, Me.mnuDelete, Me.mnuPicture})
		mnuPicture.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuPictureAdd, Me.mnuPictureChange, Me.mnuPictureRemove})
		Me.Controls.Add(MainMenu1)
		Me.MainMenu1.ResumeLayout(False)
		Me._fraKingdom_1.ResumeLayout(False)
		Me._fraKingdom_3.ResumeLayout(False)
		Me.fraStats.ResumeLayout(False)
		Me.fraMagic.ResumeLayout(False)
		Me._fraKingdom_2.ResumeLayout(False)
		Me._fraKingdom_0.ResumeLayout(False)
		Me._picInhabitant_5.ResumeLayout(False)
		Me._picInhabitant_4.ResumeLayout(False)
		Me._picInhabitant_3.ResumeLayout(False)
		Me._picInhabitant_2.ResumeLayout(False)
		Me._picInhabitant_1.ResumeLayout(False)
		Me._picInhabitant_0.ResumeLayout(False)
		Me.picKingdom.ResumeLayout(False)
		Me.picTmp.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class