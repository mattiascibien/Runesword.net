<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMonsExplorer
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
	Public WithEvents btnInsert As System.Windows.Forms.Button
	Public WithEvents drvList As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
	Public WithEvents _txtStats_0 As System.Windows.Forms.TextBox
	Public WithEvents _txtStats_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtStats_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtStats_3 As System.Windows.Forms.TextBox
	Public WithEvents _txtStats_4 As System.Windows.Forms.TextBox
	Public WithEvents _txtStats_5 As System.Windows.Forms.TextBox
	Public WithEvents _lblStats_0 As System.Windows.Forms.Label
	Public WithEvents _lblStats_1 As System.Windows.Forms.Label
	Public WithEvents _lblStats_2 As System.Windows.Forms.Label
	Public WithEvents _lblStats_3 As System.Windows.Forms.Label
	Public WithEvents _lblStats_4 As System.Windows.Forms.Label
	Public WithEvents _lblStats_5 As System.Windows.Forms.Label
	Public WithEvents fraStats As System.Windows.Forms.GroupBox
	Public WithEvents _chkFamily_0 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_1 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_2 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_3 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_4 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_5 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_6 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_7 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_8 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_9 As System.Windows.Forms.CheckBox
	Public WithEvents fraFamily As System.Windows.Forms.GroupBox
	Public WithEvents _txtVices_0 As System.Windows.Forms.TextBox
	Public WithEvents _txtVices_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtVices_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtVices_3 As System.Windows.Forms.TextBox
	Public WithEvents _txtVices_4 As System.Windows.Forms.TextBox
	Public WithEvents _txtVices_5 As System.Windows.Forms.TextBox
	Public WithEvents _lblVices_0 As System.Windows.Forms.Label
	Public WithEvents _lblVices_1 As System.Windows.Forms.Label
	Public WithEvents _lblVices_2 As System.Windows.Forms.Label
	Public WithEvents _lblVices_3 As System.Windows.Forms.Label
	Public WithEvents _lblVices_4 As System.Windows.Forms.Label
	Public WithEvents _lblVices_5 As System.Windows.Forms.Label
	Public WithEvents fraVices As System.Windows.Forms.GroupBox
	Public WithEvents lstTriggers As System.Windows.Forms.ListBox
	Public WithEvents txtTriggComm As System.Windows.Forms.TextBox
	Public WithEvents lblTriggComm As System.Windows.Forms.Label
	Public WithEvents fraTriggers As System.Windows.Forms.GroupBox
	Public WithEvents lstConvos As System.Windows.Forms.ListBox
	Public WithEvents fraConvo As System.Windows.Forms.GroupBox
	Public WithEvents _txtSoundFile_0 As System.Windows.Forms.TextBox
	Public WithEvents _txtSoundFile_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtSoundFile_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtSoundFile_3 As System.Windows.Forms.TextBox
	Public WithEvents _cmdPlaySound_0 As System.Windows.Forms.Button
	Public WithEvents _cmdPlaySound_1 As System.Windows.Forms.Button
	Public WithEvents _cmdPlaySound_2 As System.Windows.Forms.Button
	Public WithEvents _cmdPlaySound_3 As System.Windows.Forms.Button
	Public WithEvents _lblSoundEvent_0 As System.Windows.Forms.Label
	Public WithEvents _lblSoundEvent_1 As System.Windows.Forms.Label
	Public WithEvents _lblSoundEvent_2 As System.Windows.Forms.Label
	Public WithEvents _lblSoundEvent_3 As System.Windows.Forms.Label
	Public WithEvents fraSounds As System.Windows.Forms.GroupBox
	Public WithEvents txtName As System.Windows.Forms.TextBox
	Public WithEvents txtRace As System.Windows.Forms.TextBox
	Public WithEvents txtSize As System.Windows.Forms.TextBox
	Public WithEvents chkIsMale As System.Windows.Forms.CheckBox
	Public WithEvents txtSkillPoints As System.Windows.Forms.TextBox
	Public WithEvents txtExperiencePoints As System.Windows.Forms.TextBox
	Public WithEvents txtLevel As System.Windows.Forms.TextBox
	Public WithEvents shpFace As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents picCreature As System.Windows.Forms.Panel
	Public WithEvents txtCombat As System.Windows.Forms.TextBox
	Public WithEvents txtComments As System.Windows.Forms.TextBox
	Public WithEvents chkIsInanimate As System.Windows.Forms.CheckBox
	Public WithEvents chkRequiredInTome As System.Windows.Forms.CheckBox
	Public WithEvents chkFriend As System.Windows.Forms.CheckBox
	Public WithEvents chkGuard As System.Windows.Forms.CheckBox
	Public WithEvents chkAgressive As System.Windows.Forms.CheckBox
	Public WithEvents chkDMControlled As System.Windows.Forms.CheckBox
	Public WithEvents fraGenProps As System.Windows.Forms.GroupBox
	Public WithEvents _lblBonusPerc_7 As System.Windows.Forms.Label
	Public WithEvents _lblBonusPerc_6 As System.Windows.Forms.Label
	Public WithEvents _lblBonusPerc_5 As System.Windows.Forms.Label
	Public WithEvents _lblBonusPerc_4 As System.Windows.Forms.Label
	Public WithEvents _lblBonusPerc_3 As System.Windows.Forms.Label
	Public WithEvents _lblBonusPerc_2 As System.Windows.Forms.Label
	Public WithEvents _lblBonusPerc_1 As System.Windows.Forms.Label
	Public WithEvents _lblBonusPerc_0 As System.Windows.Forms.Label
	Public WithEvents _lblResBonus_7 As System.Windows.Forms.Label
	Public WithEvents _lblResBonus_6 As System.Windows.Forms.Label
	Public WithEvents _lblResBonus_5 As System.Windows.Forms.Label
	Public WithEvents _lblResBonus_4 As System.Windows.Forms.Label
	Public WithEvents _lblResBonus_3 As System.Windows.Forms.Label
	Public WithEvents _lblResBonus_2 As System.Windows.Forms.Label
	Public WithEvents _lblResBonus_1 As System.Windows.Forms.Label
	Public WithEvents _lblResBonus_0 As System.Windows.Forms.Label
	Public WithEvents fraResistBonus As System.Windows.Forms.GroupBox
	Public WithEvents _lblBody_0 As System.Windows.Forms.Label
	Public WithEvents _lblReHeader_0 As System.Windows.Forms.Label
	Public WithEvents _lblReHeader_1 As System.Windows.Forms.Label
	Public WithEvents _lblReHeader_2 As System.Windows.Forms.Label
	Public WithEvents _lblReHeader_3 As System.Windows.Forms.Label
	Public WithEvents _lblPlace_0 As System.Windows.Forms.Label
	Public WithEvents _lblPlace_1 As System.Windows.Forms.Label
	Public WithEvents _lblPlace_2 As System.Windows.Forms.Label
	Public WithEvents _lblPlace_3 As System.Windows.Forms.Label
	Public WithEvents _lblPlace_4 As System.Windows.Forms.Label
	Public WithEvents _lblPlace_5 As System.Windows.Forms.Label
	Public WithEvents _lblPlace_6 As System.Windows.Forms.Label
	Public WithEvents _lblPlace_7 As System.Windows.Forms.Label
	Public WithEvents _lblBody_1 As System.Windows.Forms.Label
	Public WithEvents _lblBody_2 As System.Windows.Forms.Label
	Public WithEvents _lblBody_3 As System.Windows.Forms.Label
	Public WithEvents _lblBody_4 As System.Windows.Forms.Label
	Public WithEvents _lblBody_5 As System.Windows.Forms.Label
	Public WithEvents _lblBody_6 As System.Windows.Forms.Label
	Public WithEvents _lblBody_7 As System.Windows.Forms.Label
	Public WithEvents _lblResPerc_0 As System.Windows.Forms.Label
	Public WithEvents _lblResPerc_1 As System.Windows.Forms.Label
	Public WithEvents _lblResPerc_2 As System.Windows.Forms.Label
	Public WithEvents _lblResPerc_3 As System.Windows.Forms.Label
	Public WithEvents _lblResPerc_4 As System.Windows.Forms.Label
	Public WithEvents _lblResPerc_5 As System.Windows.Forms.Label
	Public WithEvents _lblResPerc_6 As System.Windows.Forms.Label
	Public WithEvents _lblResPerc_7 As System.Windows.Forms.Label
	Public WithEvents _lblCovered_0 As System.Windows.Forms.Label
	Public WithEvents _lblCovered_1 As System.Windows.Forms.Label
	Public WithEvents _lblCovered_2 As System.Windows.Forms.Label
	Public WithEvents _lblCovered_3 As System.Windows.Forms.Label
	Public WithEvents _lblCovered_4 As System.Windows.Forms.Label
	Public WithEvents _lblCovered_5 As System.Windows.Forms.Label
	Public WithEvents _lblCovered_6 As System.Windows.Forms.Label
	Public WithEvents _lblCovered_7 As System.Windows.Forms.Label
	Public WithEvents FraArmor As System.Windows.Forms.GroupBox
	Public WithEvents lstItems As System.Windows.Forms.ListBox
	Public WithEvents txtItemComments As System.Windows.Forms.TextBox
	Public WithEvents lblItemComments As System.Windows.Forms.Label
	Public WithEvents fraItems As System.Windows.Forms.GroupBox
	Public WithEvents lblSize As System.Windows.Forms.Label
	Public WithEvents _lblRace_0 As System.Windows.Forms.Label
	Public WithEvents _lblName_0 As System.Windows.Forms.Label
	Public WithEvents lblCombat As System.Windows.Forms.Label
	Public WithEvents _Label1_9 As System.Windows.Forms.Label
	Public WithEvents _Label1_4 As System.Windows.Forms.Label
	Public WithEvents _Label1_17 As System.Windows.Forms.Label
	Public WithEvents imgBook As System.Windows.Forms.PictureBox
	Public WithEvents fraFullView As System.Windows.Forms.Panel
	Public WithEvents picMons As System.Windows.Forms.PictureBox
	Public WithEvents picMask As System.Windows.Forms.PictureBox
	Public WithEvents dlstDirectory As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
	Public WithEvents txtDataPath As System.Windows.Forms.TextBox
	Public WithEvents flsFileList As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents txtInfo As System.Windows.Forms.TextBox
	Public WithEvents Shape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents picCreatureCompact As System.Windows.Forms.Panel
	Public WithEvents fraCompactView As System.Windows.Forms.Panel
	Public WithEvents lblDrive As System.Windows.Forms.Label
	Public WithEvents lblDirectory As System.Windows.Forms.Label
	Public WithEvents lblFiles As System.Windows.Forms.Label
	Public WithEvents lblPath As System.Windows.Forms.Label
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents chkFamily As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	Public WithEvents cmdPlaySound As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents lblBody As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblBonusPerc As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblCovered As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblName As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblPlace As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblRace As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblReHeader As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblResBonus As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblResPerc As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblSoundEvent As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblStats As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblVices As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents txtSoundFile As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtStats As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtVices As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMonsExplorer))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.btnInsert = New System.Windows.Forms.Button
		Me.drvList = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
		Me.fraFullView = New System.Windows.Forms.Panel
		Me.fraStats = New System.Windows.Forms.GroupBox
		Me._txtStats_0 = New System.Windows.Forms.TextBox
		Me._txtStats_1 = New System.Windows.Forms.TextBox
		Me._txtStats_2 = New System.Windows.Forms.TextBox
		Me._txtStats_3 = New System.Windows.Forms.TextBox
		Me._txtStats_4 = New System.Windows.Forms.TextBox
		Me._txtStats_5 = New System.Windows.Forms.TextBox
		Me._lblStats_0 = New System.Windows.Forms.Label
		Me._lblStats_1 = New System.Windows.Forms.Label
		Me._lblStats_2 = New System.Windows.Forms.Label
		Me._lblStats_3 = New System.Windows.Forms.Label
		Me._lblStats_4 = New System.Windows.Forms.Label
		Me._lblStats_5 = New System.Windows.Forms.Label
		Me.fraFamily = New System.Windows.Forms.GroupBox
		Me._chkFamily_0 = New System.Windows.Forms.CheckBox
		Me._chkFamily_1 = New System.Windows.Forms.CheckBox
		Me._chkFamily_2 = New System.Windows.Forms.CheckBox
		Me._chkFamily_3 = New System.Windows.Forms.CheckBox
		Me._chkFamily_4 = New System.Windows.Forms.CheckBox
		Me._chkFamily_5 = New System.Windows.Forms.CheckBox
		Me._chkFamily_6 = New System.Windows.Forms.CheckBox
		Me._chkFamily_7 = New System.Windows.Forms.CheckBox
		Me._chkFamily_8 = New System.Windows.Forms.CheckBox
		Me._chkFamily_9 = New System.Windows.Forms.CheckBox
		Me.fraVices = New System.Windows.Forms.GroupBox
		Me._txtVices_0 = New System.Windows.Forms.TextBox
		Me._txtVices_1 = New System.Windows.Forms.TextBox
		Me._txtVices_2 = New System.Windows.Forms.TextBox
		Me._txtVices_3 = New System.Windows.Forms.TextBox
		Me._txtVices_4 = New System.Windows.Forms.TextBox
		Me._txtVices_5 = New System.Windows.Forms.TextBox
		Me._lblVices_0 = New System.Windows.Forms.Label
		Me._lblVices_1 = New System.Windows.Forms.Label
		Me._lblVices_2 = New System.Windows.Forms.Label
		Me._lblVices_3 = New System.Windows.Forms.Label
		Me._lblVices_4 = New System.Windows.Forms.Label
		Me._lblVices_5 = New System.Windows.Forms.Label
		Me.fraTriggers = New System.Windows.Forms.GroupBox
		Me.lstTriggers = New System.Windows.Forms.ListBox
		Me.txtTriggComm = New System.Windows.Forms.TextBox
		Me.lblTriggComm = New System.Windows.Forms.Label
		Me.fraConvo = New System.Windows.Forms.GroupBox
		Me.lstConvos = New System.Windows.Forms.ListBox
		Me.fraSounds = New System.Windows.Forms.GroupBox
		Me._txtSoundFile_0 = New System.Windows.Forms.TextBox
		Me._txtSoundFile_1 = New System.Windows.Forms.TextBox
		Me._txtSoundFile_2 = New System.Windows.Forms.TextBox
		Me._txtSoundFile_3 = New System.Windows.Forms.TextBox
		Me._cmdPlaySound_0 = New System.Windows.Forms.Button
		Me._cmdPlaySound_1 = New System.Windows.Forms.Button
		Me._cmdPlaySound_2 = New System.Windows.Forms.Button
		Me._cmdPlaySound_3 = New System.Windows.Forms.Button
		Me._lblSoundEvent_0 = New System.Windows.Forms.Label
		Me._lblSoundEvent_1 = New System.Windows.Forms.Label
		Me._lblSoundEvent_2 = New System.Windows.Forms.Label
		Me._lblSoundEvent_3 = New System.Windows.Forms.Label
		Me.txtName = New System.Windows.Forms.TextBox
		Me.txtRace = New System.Windows.Forms.TextBox
		Me.txtSize = New System.Windows.Forms.TextBox
		Me.chkIsMale = New System.Windows.Forms.CheckBox
		Me.txtSkillPoints = New System.Windows.Forms.TextBox
		Me.txtExperiencePoints = New System.Windows.Forms.TextBox
		Me.txtLevel = New System.Windows.Forms.TextBox
		Me.picCreature = New System.Windows.Forms.Panel
		Me.shpFace = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.txtCombat = New System.Windows.Forms.TextBox
		Me.txtComments = New System.Windows.Forms.TextBox
		Me.fraGenProps = New System.Windows.Forms.GroupBox
		Me.chkIsInanimate = New System.Windows.Forms.CheckBox
		Me.chkRequiredInTome = New System.Windows.Forms.CheckBox
		Me.chkFriend = New System.Windows.Forms.CheckBox
		Me.chkGuard = New System.Windows.Forms.CheckBox
		Me.chkAgressive = New System.Windows.Forms.CheckBox
		Me.chkDMControlled = New System.Windows.Forms.CheckBox
		Me.fraResistBonus = New System.Windows.Forms.GroupBox
		Me._lblBonusPerc_7 = New System.Windows.Forms.Label
		Me._lblBonusPerc_6 = New System.Windows.Forms.Label
		Me._lblBonusPerc_5 = New System.Windows.Forms.Label
		Me._lblBonusPerc_4 = New System.Windows.Forms.Label
		Me._lblBonusPerc_3 = New System.Windows.Forms.Label
		Me._lblBonusPerc_2 = New System.Windows.Forms.Label
		Me._lblBonusPerc_1 = New System.Windows.Forms.Label
		Me._lblBonusPerc_0 = New System.Windows.Forms.Label
		Me._lblResBonus_7 = New System.Windows.Forms.Label
		Me._lblResBonus_6 = New System.Windows.Forms.Label
		Me._lblResBonus_5 = New System.Windows.Forms.Label
		Me._lblResBonus_4 = New System.Windows.Forms.Label
		Me._lblResBonus_3 = New System.Windows.Forms.Label
		Me._lblResBonus_2 = New System.Windows.Forms.Label
		Me._lblResBonus_1 = New System.Windows.Forms.Label
		Me._lblResBonus_0 = New System.Windows.Forms.Label
		Me.FraArmor = New System.Windows.Forms.GroupBox
		Me._lblBody_0 = New System.Windows.Forms.Label
		Me._lblReHeader_0 = New System.Windows.Forms.Label
		Me._lblReHeader_1 = New System.Windows.Forms.Label
		Me._lblReHeader_2 = New System.Windows.Forms.Label
		Me._lblReHeader_3 = New System.Windows.Forms.Label
		Me._lblPlace_0 = New System.Windows.Forms.Label
		Me._lblPlace_1 = New System.Windows.Forms.Label
		Me._lblPlace_2 = New System.Windows.Forms.Label
		Me._lblPlace_3 = New System.Windows.Forms.Label
		Me._lblPlace_4 = New System.Windows.Forms.Label
		Me._lblPlace_5 = New System.Windows.Forms.Label
		Me._lblPlace_6 = New System.Windows.Forms.Label
		Me._lblPlace_7 = New System.Windows.Forms.Label
		Me._lblBody_1 = New System.Windows.Forms.Label
		Me._lblBody_2 = New System.Windows.Forms.Label
		Me._lblBody_3 = New System.Windows.Forms.Label
		Me._lblBody_4 = New System.Windows.Forms.Label
		Me._lblBody_5 = New System.Windows.Forms.Label
		Me._lblBody_6 = New System.Windows.Forms.Label
		Me._lblBody_7 = New System.Windows.Forms.Label
		Me._lblResPerc_0 = New System.Windows.Forms.Label
		Me._lblResPerc_1 = New System.Windows.Forms.Label
		Me._lblResPerc_2 = New System.Windows.Forms.Label
		Me._lblResPerc_3 = New System.Windows.Forms.Label
		Me._lblResPerc_4 = New System.Windows.Forms.Label
		Me._lblResPerc_5 = New System.Windows.Forms.Label
		Me._lblResPerc_6 = New System.Windows.Forms.Label
		Me._lblResPerc_7 = New System.Windows.Forms.Label
		Me._lblCovered_0 = New System.Windows.Forms.Label
		Me._lblCovered_1 = New System.Windows.Forms.Label
		Me._lblCovered_2 = New System.Windows.Forms.Label
		Me._lblCovered_3 = New System.Windows.Forms.Label
		Me._lblCovered_4 = New System.Windows.Forms.Label
		Me._lblCovered_5 = New System.Windows.Forms.Label
		Me._lblCovered_6 = New System.Windows.Forms.Label
		Me._lblCovered_7 = New System.Windows.Forms.Label
		Me.fraItems = New System.Windows.Forms.GroupBox
		Me.lstItems = New System.Windows.Forms.ListBox
		Me.txtItemComments = New System.Windows.Forms.TextBox
		Me.lblItemComments = New System.Windows.Forms.Label
		Me.lblSize = New System.Windows.Forms.Label
		Me._lblRace_0 = New System.Windows.Forms.Label
		Me._lblName_0 = New System.Windows.Forms.Label
		Me.lblCombat = New System.Windows.Forms.Label
		Me._Label1_9 = New System.Windows.Forms.Label
		Me._Label1_4 = New System.Windows.Forms.Label
		Me._Label1_17 = New System.Windows.Forms.Label
		Me.imgBook = New System.Windows.Forms.PictureBox
		Me.picMons = New System.Windows.Forms.PictureBox
		Me.picMask = New System.Windows.Forms.PictureBox
		Me.dlstDirectory = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox
		Me.txtDataPath = New System.Windows.Forms.TextBox
		Me.flsFileList = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
		Me.cmdClose = New System.Windows.Forms.Button
		Me.fraCompactView = New System.Windows.Forms.Panel
		Me.txtInfo = New System.Windows.Forms.TextBox
		Me.picCreatureCompact = New System.Windows.Forms.Panel
		Me.Shape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.lblDrive = New System.Windows.Forms.Label
		Me.lblDirectory = New System.Windows.Forms.Label
		Me.lblFiles = New System.Windows.Forms.Label
		Me.lblPath = New System.Windows.Forms.Label
		Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.chkFamily = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(components)
		Me.cmdPlaySound = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.lblBody = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblBonusPerc = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblCovered = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblName = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblPlace = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblRace = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblReHeader = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblResBonus = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblResPerc = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblSoundEvent = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblStats = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblVices = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.txtSoundFile = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtStats = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtVices = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.fraFullView.SuspendLayout()
		Me.fraStats.SuspendLayout()
		Me.fraFamily.SuspendLayout()
		Me.fraVices.SuspendLayout()
		Me.fraTriggers.SuspendLayout()
		Me.fraConvo.SuspendLayout()
		Me.fraSounds.SuspendLayout()
		Me.picCreature.SuspendLayout()
		Me.fraGenProps.SuspendLayout()
		Me.fraResistBonus.SuspendLayout()
		Me.FraArmor.SuspendLayout()
		Me.fraItems.SuspendLayout()
		Me.fraCompactView.SuspendLayout()
		Me.picCreatureCompact.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.chkFamily, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdPlaySound, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblBody, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblBonusPerc, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblCovered, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblPlace, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblRace, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblReHeader, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblResBonus, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblResPerc, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblSoundEvent, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblStats, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblVices, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtSoundFile, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtStats, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtVices, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Creature Explorer"
		Me.ClientSize = New System.Drawing.Size(1159, 609)
		Me.Location = New System.Drawing.Point(6, 29)
		Me.MaximizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmMonsExplorer"
		Me.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnInsert.Text = "Insert into Tome"
		Me.btnInsert.Size = New System.Drawing.Size(81, 33)
		Me.btnInsert.Location = New System.Drawing.Point(544, 56)
		Me.btnInsert.TabIndex = 153
		Me.btnInsert.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnInsert.BackColor = System.Drawing.SystemColors.Control
		Me.btnInsert.CausesValidation = True
		Me.btnInsert.Enabled = True
		Me.btnInsert.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnInsert.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnInsert.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnInsert.TabStop = True
		Me.btnInsert.Name = "btnInsert"
		Me.drvList.Size = New System.Drawing.Size(145, 21)
		Me.drvList.Location = New System.Drawing.Point(8, 56)
		Me.drvList.TabIndex = 152
		Me.drvList.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.drvList.BackColor = System.Drawing.SystemColors.Window
		Me.drvList.CausesValidation = True
		Me.drvList.Enabled = True
		Me.drvList.ForeColor = System.Drawing.SystemColors.WindowText
		Me.drvList.Cursor = System.Windows.Forms.Cursors.Default
		Me.drvList.TabStop = True
		Me.drvList.Visible = True
		Me.drvList.Name = "drvList"
		Me.fraFullView.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.fraFullView.Text = "Frame1"
		Me.fraFullView.Size = New System.Drawing.Size(1009, 585)
		Me.fraFullView.Location = New System.Drawing.Point(160, 40)
		Me.fraFullView.TabIndex = 12
		Me.fraFullView.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraFullView.BackColor = System.Drawing.SystemColors.Control
		Me.fraFullView.Enabled = True
		Me.fraFullView.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraFullView.Cursor = System.Windows.Forms.Cursors.Default
		Me.fraFullView.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraFullView.Visible = True
		Me.fraFullView.Name = "fraFullView"
		Me.fraStats.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.fraStats.Text = "Statistics"
		Me.fraStats.Size = New System.Drawing.Size(113, 185)
		Me.fraStats.Location = New System.Drawing.Point(360, 264)
		Me.fraStats.TabIndex = 131
		Me.fraStats.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraStats.Enabled = True
		Me.fraStats.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraStats.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraStats.Visible = True
		Me.fraStats.Padding = New System.Windows.Forms.Padding(0)
		Me.fraStats.Name = "fraStats"
		Me._txtStats_0.AutoSize = False
		Me._txtStats_0.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtStats_0.Size = New System.Drawing.Size(33, 19)
		Me._txtStats_0.Location = New System.Drawing.Point(64, 16)
		Me._txtStats_0.ReadOnly = True
		Me._txtStats_0.TabIndex = 137
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
		Me._txtStats_1.AutoSize = False
		Me._txtStats_1.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtStats_1.Size = New System.Drawing.Size(33, 19)
		Me._txtStats_1.Location = New System.Drawing.Point(64, 48)
		Me._txtStats_1.ReadOnly = True
		Me._txtStats_1.TabIndex = 136
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
		Me._txtStats_2.AutoSize = False
		Me._txtStats_2.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtStats_2.Size = New System.Drawing.Size(33, 19)
		Me._txtStats_2.Location = New System.Drawing.Point(64, 72)
		Me._txtStats_2.ReadOnly = True
		Me._txtStats_2.TabIndex = 135
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
		Me._txtStats_3.AutoSize = False
		Me._txtStats_3.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtStats_3.Size = New System.Drawing.Size(33, 19)
		Me._txtStats_3.Location = New System.Drawing.Point(64, 96)
		Me._txtStats_3.ReadOnly = True
		Me._txtStats_3.TabIndex = 134
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
		Me._txtStats_4.AutoSize = False
		Me._txtStats_4.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtStats_4.Size = New System.Drawing.Size(33, 19)
		Me._txtStats_4.Location = New System.Drawing.Point(64, 128)
		Me._txtStats_4.ReadOnly = True
		Me._txtStats_4.TabIndex = 133
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
		Me._txtStats_5.AutoSize = False
		Me._txtStats_5.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtStats_5.Size = New System.Drawing.Size(33, 19)
		Me._txtStats_5.Location = New System.Drawing.Point(64, 152)
		Me._txtStats_5.ReadOnly = True
		Me._txtStats_5.TabIndex = 132
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
		Me._lblStats_0.BackColor = System.Drawing.Color.Transparent
		Me._lblStats_0.Text = "Max Health"
		Me._lblStats_0.Size = New System.Drawing.Size(57, 17)
		Me._lblStats_0.Location = New System.Drawing.Point(8, 17)
		Me._lblStats_0.TabIndex = 143
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
		Me._lblStats_1.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblStats_1.Text = "Intelligence"
		Me._lblStats_1.Size = New System.Drawing.Size(57, 17)
		Me._lblStats_1.Location = New System.Drawing.Point(8, 49)
		Me._lblStats_1.TabIndex = 142
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
		Me._lblStats_2.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblStats_2.Text = "Strength"
		Me._lblStats_2.Size = New System.Drawing.Size(57, 17)
		Me._lblStats_2.Location = New System.Drawing.Point(8, 73)
		Me._lblStats_2.TabIndex = 141
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
		Me._lblStats_3.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblStats_3.Text = "Agility"
		Me._lblStats_3.Size = New System.Drawing.Size(57, 17)
		Me._lblStats_3.Location = New System.Drawing.Point(8, 97)
		Me._lblStats_3.TabIndex = 140
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
		Me._lblStats_4.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblStats_4.Text = "Move Cost"
		Me._lblStats_4.Size = New System.Drawing.Size(57, 17)
		Me._lblStats_4.Location = New System.Drawing.Point(8, 129)
		Me._lblStats_4.TabIndex = 139
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
		Me._lblStats_5.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblStats_5.Text = "Action Points"
		Me._lblStats_5.Size = New System.Drawing.Size(57, 25)
		Me._lblStats_5.Location = New System.Drawing.Point(8, 149)
		Me._lblStats_5.TabIndex = 138
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
		Me.fraFamily.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.fraFamily.Text = "Family"
		Me.fraFamily.Size = New System.Drawing.Size(81, 185)
		Me.fraFamily.Location = New System.Drawing.Point(376, 64)
		Me.fraFamily.TabIndex = 120
		Me.fraFamily.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraFamily.Enabled = True
		Me.fraFamily.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraFamily.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraFamily.Visible = True
		Me.fraFamily.Padding = New System.Windows.Forms.Padding(0)
		Me.fraFamily.Name = "fraFamily"
		Me._chkFamily_0.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_0.Text = "Sentient"
		Me._chkFamily_0.Size = New System.Drawing.Size(65, 17)
		Me._chkFamily_0.Location = New System.Drawing.Point(8, 16)
		Me._chkFamily_0.TabIndex = 130
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
		Me._chkFamily_1.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_1.Text = "Reptile"
		Me._chkFamily_1.Size = New System.Drawing.Size(65, 17)
		Me._chkFamily_1.Location = New System.Drawing.Point(8, 32)
		Me._chkFamily_1.TabIndex = 129
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
		Me._chkFamily_2.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_2.Text = "Insect"
		Me._chkFamily_2.Size = New System.Drawing.Size(65, 17)
		Me._chkFamily_2.Location = New System.Drawing.Point(8, 48)
		Me._chkFamily_2.TabIndex = 128
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
		Me._chkFamily_3.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_3.Text = "Blob"
		Me._chkFamily_3.Size = New System.Drawing.Size(65, 17)
		Me._chkFamily_3.Location = New System.Drawing.Point(8, 64)
		Me._chkFamily_3.TabIndex = 127
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
		Me._chkFamily_4.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_4.Text = "Undead"
		Me._chkFamily_4.Size = New System.Drawing.Size(65, 17)
		Me._chkFamily_4.Location = New System.Drawing.Point(8, 128)
		Me._chkFamily_4.TabIndex = 126
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
		Me._chkFamily_5.Text = "Bird"
		Me._chkFamily_5.Size = New System.Drawing.Size(65, 17)
		Me._chkFamily_5.Location = New System.Drawing.Point(8, 112)
		Me._chkFamily_5.TabIndex = 125
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
		Me._chkFamily_6.Text = "Plant"
		Me._chkFamily_6.Size = New System.Drawing.Size(65, 17)
		Me._chkFamily_6.Location = New System.Drawing.Point(8, 96)
		Me._chkFamily_6.TabIndex = 124
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
		Me._chkFamily_7.Text = "Animal"
		Me._chkFamily_7.Size = New System.Drawing.Size(65, 17)
		Me._chkFamily_7.Location = New System.Drawing.Point(8, 80)
		Me._chkFamily_7.TabIndex = 123
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
		Me._chkFamily_8.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._chkFamily_8.Text = "Magical"
		Me._chkFamily_8.Size = New System.Drawing.Size(65, 17)
		Me._chkFamily_8.Location = New System.Drawing.Point(8, 160)
		Me._chkFamily_8.TabIndex = 122
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
		Me._chkFamily_9.Text = "Aquatic"
		Me._chkFamily_9.Size = New System.Drawing.Size(65, 17)
		Me._chkFamily_9.Location = New System.Drawing.Point(8, 144)
		Me._chkFamily_9.TabIndex = 121
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
		Me.fraVices.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.fraVices.Text = "Vices"
		Me.fraVices.Size = New System.Drawing.Size(97, 185)
		Me.fraVices.Location = New System.Drawing.Point(824, 368)
		Me.fraVices.TabIndex = 107
		Me.fraVices.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraVices.Enabled = True
		Me.fraVices.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraVices.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraVices.Visible = True
		Me.fraVices.Padding = New System.Windows.Forms.Padding(0)
		Me.fraVices.Name = "fraVices"
		Me._txtVices_0.AutoSize = False
		Me._txtVices_0.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtVices_0.Size = New System.Drawing.Size(33, 19)
		Me._txtVices_0.Location = New System.Drawing.Point(48, 23)
		Me._txtVices_0.ReadOnly = True
		Me._txtVices_0.TabIndex = 113
		Me._txtVices_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtVices_0.AcceptsReturn = True
		Me._txtVices_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtVices_0.CausesValidation = True
		Me._txtVices_0.Enabled = True
		Me._txtVices_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtVices_0.HideSelection = True
		Me._txtVices_0.Maxlength = 0
		Me._txtVices_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtVices_0.MultiLine = False
		Me._txtVices_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtVices_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtVices_0.TabStop = True
		Me._txtVices_0.Visible = True
		Me._txtVices_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtVices_0.Name = "_txtVices_0"
		Me._txtVices_1.AutoSize = False
		Me._txtVices_1.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtVices_1.Size = New System.Drawing.Size(33, 19)
		Me._txtVices_1.Location = New System.Drawing.Point(48, 48)
		Me._txtVices_1.ReadOnly = True
		Me._txtVices_1.TabIndex = 112
		Me._txtVices_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtVices_1.AcceptsReturn = True
		Me._txtVices_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtVices_1.CausesValidation = True
		Me._txtVices_1.Enabled = True
		Me._txtVices_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtVices_1.HideSelection = True
		Me._txtVices_1.Maxlength = 0
		Me._txtVices_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtVices_1.MultiLine = False
		Me._txtVices_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtVices_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtVices_1.TabStop = True
		Me._txtVices_1.Visible = True
		Me._txtVices_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtVices_1.Name = "_txtVices_1"
		Me._txtVices_2.AutoSize = False
		Me._txtVices_2.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtVices_2.Size = New System.Drawing.Size(33, 19)
		Me._txtVices_2.Location = New System.Drawing.Point(48, 72)
		Me._txtVices_2.ReadOnly = True
		Me._txtVices_2.TabIndex = 111
		Me._txtVices_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtVices_2.AcceptsReturn = True
		Me._txtVices_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtVices_2.CausesValidation = True
		Me._txtVices_2.Enabled = True
		Me._txtVices_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtVices_2.HideSelection = True
		Me._txtVices_2.Maxlength = 0
		Me._txtVices_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtVices_2.MultiLine = False
		Me._txtVices_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtVices_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtVices_2.TabStop = True
		Me._txtVices_2.Visible = True
		Me._txtVices_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtVices_2.Name = "_txtVices_2"
		Me._txtVices_3.AutoSize = False
		Me._txtVices_3.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtVices_3.Size = New System.Drawing.Size(33, 19)
		Me._txtVices_3.Location = New System.Drawing.Point(48, 96)
		Me._txtVices_3.ReadOnly = True
		Me._txtVices_3.TabIndex = 110
		Me._txtVices_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtVices_3.AcceptsReturn = True
		Me._txtVices_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtVices_3.CausesValidation = True
		Me._txtVices_3.Enabled = True
		Me._txtVices_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtVices_3.HideSelection = True
		Me._txtVices_3.Maxlength = 0
		Me._txtVices_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtVices_3.MultiLine = False
		Me._txtVices_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtVices_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtVices_3.TabStop = True
		Me._txtVices_3.Visible = True
		Me._txtVices_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtVices_3.Name = "_txtVices_3"
		Me._txtVices_4.AutoSize = False
		Me._txtVices_4.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtVices_4.Size = New System.Drawing.Size(33, 19)
		Me._txtVices_4.Location = New System.Drawing.Point(48, 120)
		Me._txtVices_4.ReadOnly = True
		Me._txtVices_4.TabIndex = 109
		Me._txtVices_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtVices_4.AcceptsReturn = True
		Me._txtVices_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtVices_4.CausesValidation = True
		Me._txtVices_4.Enabled = True
		Me._txtVices_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtVices_4.HideSelection = True
		Me._txtVices_4.Maxlength = 0
		Me._txtVices_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtVices_4.MultiLine = False
		Me._txtVices_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtVices_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtVices_4.TabStop = True
		Me._txtVices_4.Visible = True
		Me._txtVices_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtVices_4.Name = "_txtVices_4"
		Me._txtVices_5.AutoSize = False
		Me._txtVices_5.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtVices_5.Size = New System.Drawing.Size(33, 19)
		Me._txtVices_5.Location = New System.Drawing.Point(48, 144)
		Me._txtVices_5.ReadOnly = True
		Me._txtVices_5.TabIndex = 108
		Me._txtVices_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtVices_5.AcceptsReturn = True
		Me._txtVices_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtVices_5.CausesValidation = True
		Me._txtVices_5.Enabled = True
		Me._txtVices_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtVices_5.HideSelection = True
		Me._txtVices_5.Maxlength = 0
		Me._txtVices_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtVices_5.MultiLine = False
		Me._txtVices_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtVices_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtVices_5.TabStop = True
		Me._txtVices_5.Visible = True
		Me._txtVices_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtVices_5.Name = "_txtVices_5"
		Me._lblVices_0.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblVices_0.Text = "Lunacy"
		Me._lblVices_0.Size = New System.Drawing.Size(41, 17)
		Me._lblVices_0.Location = New System.Drawing.Point(8, 24)
		Me._lblVices_0.TabIndex = 119
		Me._lblVices_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblVices_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblVices_0.Enabled = True
		Me._lblVices_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblVices_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblVices_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblVices_0.UseMnemonic = True
		Me._lblVices_0.Visible = True
		Me._lblVices_0.AutoSize = False
		Me._lblVices_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblVices_0.Name = "_lblVices_0"
		Me._lblVices_1.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblVices_1.Text = "Revelry"
		Me._lblVices_1.Size = New System.Drawing.Size(41, 17)
		Me._lblVices_1.Location = New System.Drawing.Point(8, 49)
		Me._lblVices_1.TabIndex = 118
		Me._lblVices_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblVices_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblVices_1.Enabled = True
		Me._lblVices_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblVices_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblVices_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblVices_1.UseMnemonic = True
		Me._lblVices_1.Visible = True
		Me._lblVices_1.AutoSize = False
		Me._lblVices_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblVices_1.Name = "_lblVices_1"
		Me._lblVices_2.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblVices_2.Text = "Wrath"
		Me._lblVices_2.Size = New System.Drawing.Size(41, 17)
		Me._lblVices_2.Location = New System.Drawing.Point(8, 73)
		Me._lblVices_2.TabIndex = 117
		Me._lblVices_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblVices_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblVices_2.Enabled = True
		Me._lblVices_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblVices_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblVices_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblVices_2.UseMnemonic = True
		Me._lblVices_2.Visible = True
		Me._lblVices_2.AutoSize = False
		Me._lblVices_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblVices_2.Name = "_lblVices_2"
		Me._lblVices_3.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblVices_3.Text = "Pride"
		Me._lblVices_3.Size = New System.Drawing.Size(41, 17)
		Me._lblVices_3.Location = New System.Drawing.Point(8, 97)
		Me._lblVices_3.TabIndex = 116
		Me._lblVices_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblVices_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblVices_3.Enabled = True
		Me._lblVices_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblVices_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblVices_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblVices_3.UseMnemonic = True
		Me._lblVices_3.Visible = True
		Me._lblVices_3.AutoSize = False
		Me._lblVices_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblVices_3.Name = "_lblVices_3"
		Me._lblVices_4.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblVices_4.Text = "Greed"
		Me._lblVices_4.Size = New System.Drawing.Size(41, 17)
		Me._lblVices_4.Location = New System.Drawing.Point(8, 121)
		Me._lblVices_4.TabIndex = 115
		Me._lblVices_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblVices_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblVices_4.Enabled = True
		Me._lblVices_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblVices_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblVices_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblVices_4.UseMnemonic = True
		Me._lblVices_4.Visible = True
		Me._lblVices_4.AutoSize = False
		Me._lblVices_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblVices_4.Name = "_lblVices_4"
		Me._lblVices_5.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblVices_5.Text = "Lust"
		Me._lblVices_5.Size = New System.Drawing.Size(41, 17)
		Me._lblVices_5.Location = New System.Drawing.Point(8, 145)
		Me._lblVices_5.TabIndex = 114
		Me._lblVices_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblVices_5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblVices_5.Enabled = True
		Me._lblVices_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblVices_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblVices_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblVices_5.UseMnemonic = True
		Me._lblVices_5.Visible = True
		Me._lblVices_5.AutoSize = False
		Me._lblVices_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblVices_5.Name = "_lblVices_5"
		Me.fraTriggers.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.fraTriggers.Text = "Triggers"
		Me.fraTriggers.Size = New System.Drawing.Size(201, 209)
		Me.fraTriggers.Location = New System.Drawing.Point(504, 8)
		Me.fraTriggers.TabIndex = 103
		Me.fraTriggers.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraTriggers.Enabled = True
		Me.fraTriggers.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraTriggers.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraTriggers.Visible = True
		Me.fraTriggers.Padding = New System.Windows.Forms.Padding(0)
		Me.fraTriggers.Name = "fraTriggers"
		Me.lstTriggers.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.lstTriggers.Size = New System.Drawing.Size(185, 72)
		Me.lstTriggers.Location = New System.Drawing.Point(8, 16)
		Me.lstTriggers.TabIndex = 105
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
		Me.txtTriggComm.AutoSize = False
		Me.txtTriggComm.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.txtTriggComm.Size = New System.Drawing.Size(185, 97)
		Me.txtTriggComm.Location = New System.Drawing.Point(8, 104)
		Me.txtTriggComm.ReadOnly = True
		Me.txtTriggComm.MultiLine = True
		Me.txtTriggComm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtTriggComm.TabIndex = 104
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
		Me.lblTriggComm.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.lblTriggComm.Text = "Trigger Comments :"
		Me.lblTriggComm.Size = New System.Drawing.Size(121, 17)
		Me.lblTriggComm.Location = New System.Drawing.Point(8, 88)
		Me.lblTriggComm.TabIndex = 106
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
		Me.fraConvo.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.fraConvo.Text = "Conversations"
		Me.fraConvo.Size = New System.Drawing.Size(265, 145)
		Me.fraConvo.Location = New System.Drawing.Point(504, 224)
		Me.fraConvo.TabIndex = 101
		Me.fraConvo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraConvo.Enabled = True
		Me.fraConvo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraConvo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraConvo.Visible = True
		Me.fraConvo.Padding = New System.Windows.Forms.Padding(0)
		Me.fraConvo.Name = "fraConvo"
		Me.lstConvos.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.lstConvos.Size = New System.Drawing.Size(249, 124)
		Me.lstConvos.Location = New System.Drawing.Point(8, 16)
		Me.lstConvos.TabIndex = 102
		Me.lstConvos.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstConvos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstConvos.CausesValidation = True
		Me.lstConvos.Enabled = True
		Me.lstConvos.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstConvos.IntegralHeight = True
		Me.lstConvos.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstConvos.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstConvos.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstConvos.Sorted = False
		Me.lstConvos.TabStop = True
		Me.lstConvos.Visible = True
		Me.lstConvos.MultiColumn = False
		Me.lstConvos.Name = "lstConvos"
		Me.fraSounds.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.fraSounds.Text = "Sounds"
		Me.fraSounds.Size = New System.Drawing.Size(305, 177)
		Me.fraSounds.Location = New System.Drawing.Point(504, 376)
		Me.fraSounds.TabIndex = 88
		Me.fraSounds.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraSounds.Enabled = True
		Me.fraSounds.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraSounds.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraSounds.Visible = True
		Me.fraSounds.Padding = New System.Windows.Forms.Padding(0)
		Me.fraSounds.Name = "fraSounds"
		Me._txtSoundFile_0.AutoSize = False
		Me._txtSoundFile_0.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtSoundFile_0.Size = New System.Drawing.Size(233, 19)
		Me._txtSoundFile_0.Location = New System.Drawing.Point(8, 32)
		Me._txtSoundFile_0.ReadOnly = True
		Me._txtSoundFile_0.TabIndex = 96
		Me._txtSoundFile_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtSoundFile_0.AcceptsReturn = True
		Me._txtSoundFile_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtSoundFile_0.CausesValidation = True
		Me._txtSoundFile_0.Enabled = True
		Me._txtSoundFile_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtSoundFile_0.HideSelection = True
		Me._txtSoundFile_0.Maxlength = 0
		Me._txtSoundFile_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtSoundFile_0.MultiLine = False
		Me._txtSoundFile_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtSoundFile_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtSoundFile_0.TabStop = True
		Me._txtSoundFile_0.Visible = True
		Me._txtSoundFile_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtSoundFile_0.Name = "_txtSoundFile_0"
		Me._txtSoundFile_1.AutoSize = False
		Me._txtSoundFile_1.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtSoundFile_1.Size = New System.Drawing.Size(233, 19)
		Me._txtSoundFile_1.Location = New System.Drawing.Point(8, 72)
		Me._txtSoundFile_1.ReadOnly = True
		Me._txtSoundFile_1.TabIndex = 95
		Me._txtSoundFile_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtSoundFile_1.AcceptsReturn = True
		Me._txtSoundFile_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtSoundFile_1.CausesValidation = True
		Me._txtSoundFile_1.Enabled = True
		Me._txtSoundFile_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtSoundFile_1.HideSelection = True
		Me._txtSoundFile_1.Maxlength = 0
		Me._txtSoundFile_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtSoundFile_1.MultiLine = False
		Me._txtSoundFile_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtSoundFile_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtSoundFile_1.TabStop = True
		Me._txtSoundFile_1.Visible = True
		Me._txtSoundFile_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtSoundFile_1.Name = "_txtSoundFile_1"
		Me._txtSoundFile_2.AutoSize = False
		Me._txtSoundFile_2.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtSoundFile_2.Size = New System.Drawing.Size(233, 19)
		Me._txtSoundFile_2.Location = New System.Drawing.Point(8, 112)
		Me._txtSoundFile_2.ReadOnly = True
		Me._txtSoundFile_2.TabIndex = 94
		Me._txtSoundFile_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtSoundFile_2.AcceptsReturn = True
		Me._txtSoundFile_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtSoundFile_2.CausesValidation = True
		Me._txtSoundFile_2.Enabled = True
		Me._txtSoundFile_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtSoundFile_2.HideSelection = True
		Me._txtSoundFile_2.Maxlength = 0
		Me._txtSoundFile_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtSoundFile_2.MultiLine = False
		Me._txtSoundFile_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtSoundFile_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtSoundFile_2.TabStop = True
		Me._txtSoundFile_2.Visible = True
		Me._txtSoundFile_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtSoundFile_2.Name = "_txtSoundFile_2"
		Me._txtSoundFile_3.AutoSize = False
		Me._txtSoundFile_3.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._txtSoundFile_3.Size = New System.Drawing.Size(233, 19)
		Me._txtSoundFile_3.Location = New System.Drawing.Point(8, 152)
		Me._txtSoundFile_3.ReadOnly = True
		Me._txtSoundFile_3.TabIndex = 93
		Me._txtSoundFile_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtSoundFile_3.AcceptsReturn = True
		Me._txtSoundFile_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtSoundFile_3.CausesValidation = True
		Me._txtSoundFile_3.Enabled = True
		Me._txtSoundFile_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtSoundFile_3.HideSelection = True
		Me._txtSoundFile_3.Maxlength = 0
		Me._txtSoundFile_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtSoundFile_3.MultiLine = False
		Me._txtSoundFile_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtSoundFile_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtSoundFile_3.TabStop = True
		Me._txtSoundFile_3.Visible = True
		Me._txtSoundFile_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtSoundFile_3.Name = "_txtSoundFile_3"
		Me._cmdPlaySound_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdPlaySound_0.Text = "Play"
		Me._cmdPlaySound_0.Size = New System.Drawing.Size(49, 17)
		Me._cmdPlaySound_0.Location = New System.Drawing.Point(248, 32)
		Me._cmdPlaySound_0.TabIndex = 92
		Me._cmdPlaySound_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdPlaySound_0.BackColor = System.Drawing.SystemColors.Control
		Me._cmdPlaySound_0.CausesValidation = True
		Me._cmdPlaySound_0.Enabled = True
		Me._cmdPlaySound_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdPlaySound_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdPlaySound_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdPlaySound_0.TabStop = True
		Me._cmdPlaySound_0.Name = "_cmdPlaySound_0"
		Me._cmdPlaySound_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdPlaySound_1.Text = "Play"
		Me._cmdPlaySound_1.Size = New System.Drawing.Size(49, 17)
		Me._cmdPlaySound_1.Location = New System.Drawing.Point(248, 72)
		Me._cmdPlaySound_1.TabIndex = 91
		Me._cmdPlaySound_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdPlaySound_1.BackColor = System.Drawing.SystemColors.Control
		Me._cmdPlaySound_1.CausesValidation = True
		Me._cmdPlaySound_1.Enabled = True
		Me._cmdPlaySound_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdPlaySound_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdPlaySound_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdPlaySound_1.TabStop = True
		Me._cmdPlaySound_1.Name = "_cmdPlaySound_1"
		Me._cmdPlaySound_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdPlaySound_2.Text = "Play"
		Me._cmdPlaySound_2.Size = New System.Drawing.Size(49, 17)
		Me._cmdPlaySound_2.Location = New System.Drawing.Point(248, 112)
		Me._cmdPlaySound_2.TabIndex = 90
		Me._cmdPlaySound_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdPlaySound_2.BackColor = System.Drawing.SystemColors.Control
		Me._cmdPlaySound_2.CausesValidation = True
		Me._cmdPlaySound_2.Enabled = True
		Me._cmdPlaySound_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdPlaySound_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdPlaySound_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdPlaySound_2.TabStop = True
		Me._cmdPlaySound_2.Name = "_cmdPlaySound_2"
		Me._cmdPlaySound_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdPlaySound_3.Text = "Play"
		Me._cmdPlaySound_3.Size = New System.Drawing.Size(49, 17)
		Me._cmdPlaySound_3.Location = New System.Drawing.Point(248, 152)
		Me._cmdPlaySound_3.TabIndex = 89
		Me._cmdPlaySound_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdPlaySound_3.BackColor = System.Drawing.SystemColors.Control
		Me._cmdPlaySound_3.CausesValidation = True
		Me._cmdPlaySound_3.Enabled = True
		Me._cmdPlaySound_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdPlaySound_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdPlaySound_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdPlaySound_3.TabStop = True
		Me._cmdPlaySound_3.Name = "_cmdPlaySound_3"
		Me._lblSoundEvent_0.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblSoundEvent_0.Text = "When Move in Combat :"
		Me._lblSoundEvent_0.Size = New System.Drawing.Size(137, 17)
		Me._lblSoundEvent_0.Location = New System.Drawing.Point(8, 17)
		Me._lblSoundEvent_0.TabIndex = 100
		Me._lblSoundEvent_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblSoundEvent_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblSoundEvent_0.Enabled = True
		Me._lblSoundEvent_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblSoundEvent_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblSoundEvent_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblSoundEvent_0.UseMnemonic = True
		Me._lblSoundEvent_0.Visible = True
		Me._lblSoundEvent_0.AutoSize = False
		Me._lblSoundEvent_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblSoundEvent_0.Name = "_lblSoundEvent_0"
		Me._lblSoundEvent_1.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblSoundEvent_1.Text = "When Attack in Combat :"
		Me._lblSoundEvent_1.Size = New System.Drawing.Size(137, 17)
		Me._lblSoundEvent_1.Location = New System.Drawing.Point(8, 56)
		Me._lblSoundEvent_1.TabIndex = 99
		Me._lblSoundEvent_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblSoundEvent_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblSoundEvent_1.Enabled = True
		Me._lblSoundEvent_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblSoundEvent_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblSoundEvent_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblSoundEvent_1.UseMnemonic = True
		Me._lblSoundEvent_1.Visible = True
		Me._lblSoundEvent_1.AutoSize = False
		Me._lblSoundEvent_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblSoundEvent_1.Name = "_lblSoundEvent_1"
		Me._lblSoundEvent_2.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblSoundEvent_2.Text = "Hit and Damaged by Attack :"
		Me._lblSoundEvent_2.Size = New System.Drawing.Size(137, 17)
		Me._lblSoundEvent_2.Location = New System.Drawing.Point(8, 96)
		Me._lblSoundEvent_2.TabIndex = 98
		Me._lblSoundEvent_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblSoundEvent_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblSoundEvent_2.Enabled = True
		Me._lblSoundEvent_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblSoundEvent_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblSoundEvent_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblSoundEvent_2.UseMnemonic = True
		Me._lblSoundEvent_2.Visible = True
		Me._lblSoundEvent_2.AutoSize = False
		Me._lblSoundEvent_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblSoundEvent_2.Name = "_lblSoundEvent_2"
		Me._lblSoundEvent_3.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblSoundEvent_3.Text = "When Creature Dies :"
		Me._lblSoundEvent_3.Size = New System.Drawing.Size(137, 17)
		Me._lblSoundEvent_3.Location = New System.Drawing.Point(8, 136)
		Me._lblSoundEvent_3.TabIndex = 97
		Me._lblSoundEvent_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblSoundEvent_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblSoundEvent_3.Enabled = True
		Me._lblSoundEvent_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblSoundEvent_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblSoundEvent_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblSoundEvent_3.UseMnemonic = True
		Me._lblSoundEvent_3.Visible = True
		Me._lblSoundEvent_3.AutoSize = False
		Me._lblSoundEvent_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblSoundEvent_3.Name = "_lblSoundEvent_3"
		Me.txtName.AutoSize = False
		Me.txtName.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.txtName.Size = New System.Drawing.Size(297, 19)
		Me.txtName.Location = New System.Drawing.Point(72, 13)
		Me.txtName.ReadOnly = True
		Me.txtName.TabIndex = 87
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
		Me.txtRace.AutoSize = False
		Me.txtRace.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.txtRace.Size = New System.Drawing.Size(297, 19)
		Me.txtRace.Location = New System.Drawing.Point(72, 40)
		Me.txtRace.ReadOnly = True
		Me.txtRace.TabIndex = 86
		Me.txtRace.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRace.AcceptsReturn = True
		Me.txtRace.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtRace.CausesValidation = True
		Me.txtRace.Enabled = True
		Me.txtRace.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtRace.HideSelection = True
		Me.txtRace.Maxlength = 0
		Me.txtRace.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtRace.MultiLine = False
		Me.txtRace.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtRace.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtRace.TabStop = True
		Me.txtRace.Visible = True
		Me.txtRace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtRace.Name = "txtRace"
		Me.txtSize.AutoSize = False
		Me.txtSize.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.txtSize.Size = New System.Drawing.Size(177, 17)
		Me.txtSize.Location = New System.Drawing.Point(72, 64)
		Me.txtSize.ReadOnly = True
		Me.txtSize.TabIndex = 85
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
		Me.chkIsMale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.chkIsMale.BackColor = System.Drawing.SystemColors.Window
		Me.chkIsMale.Text = "Male?"
		Me.chkIsMale.ForeColor = System.Drawing.SystemColors.WindowText
		Me.chkIsMale.Size = New System.Drawing.Size(49, 13)
		Me.chkIsMale.Location = New System.Drawing.Point(168, 216)
		Me.chkIsMale.TabIndex = 84
		Me.chkIsMale.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkIsMale.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkIsMale.CausesValidation = True
		Me.chkIsMale.Enabled = True
		Me.chkIsMale.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkIsMale.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkIsMale.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkIsMale.TabStop = True
		Me.chkIsMale.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkIsMale.Visible = True
		Me.chkIsMale.Name = "chkIsMale"
		Me.txtSkillPoints.AutoSize = False
		Me.txtSkillPoints.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.txtSkillPoints.Size = New System.Drawing.Size(49, 19)
		Me.txtSkillPoints.Location = New System.Drawing.Point(72, 240)
		Me.txtSkillPoints.ReadOnly = True
		Me.txtSkillPoints.Maxlength = 3
		Me.txtSkillPoints.TabIndex = 83
		Me.txtSkillPoints.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSkillPoints.AcceptsReturn = True
		Me.txtSkillPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSkillPoints.CausesValidation = True
		Me.txtSkillPoints.Enabled = True
		Me.txtSkillPoints.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSkillPoints.HideSelection = True
		Me.txtSkillPoints.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSkillPoints.MultiLine = False
		Me.txtSkillPoints.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSkillPoints.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSkillPoints.TabStop = True
		Me.txtSkillPoints.Visible = True
		Me.txtSkillPoints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSkillPoints.Name = "txtSkillPoints"
		Me.txtExperiencePoints.AutoSize = False
		Me.txtExperiencePoints.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.txtExperiencePoints.Size = New System.Drawing.Size(49, 19)
		Me.txtExperiencePoints.Location = New System.Drawing.Point(165, 240)
		Me.txtExperiencePoints.ReadOnly = True
		Me.txtExperiencePoints.Maxlength = 7
		Me.txtExperiencePoints.TabIndex = 82
		Me.txtExperiencePoints.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtExperiencePoints.AcceptsReturn = True
		Me.txtExperiencePoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtExperiencePoints.CausesValidation = True
		Me.txtExperiencePoints.Enabled = True
		Me.txtExperiencePoints.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtExperiencePoints.HideSelection = True
		Me.txtExperiencePoints.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtExperiencePoints.MultiLine = False
		Me.txtExperiencePoints.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtExperiencePoints.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtExperiencePoints.TabStop = True
		Me.txtExperiencePoints.Visible = True
		Me.txtExperiencePoints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtExperiencePoints.Name = "txtExperiencePoints"
		Me.txtLevel.AutoSize = False
		Me.txtLevel.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.txtLevel.Size = New System.Drawing.Size(49, 19)
		Me.txtLevel.Location = New System.Drawing.Point(72, 216)
		Me.txtLevel.ReadOnly = True
		Me.txtLevel.Maxlength = 3
		Me.txtLevel.TabIndex = 81
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
		Me.picCreature.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.picCreature.Enabled = False
		Me.picCreature.Size = New System.Drawing.Size(109, 137)
		Me.picCreature.Location = New System.Drawing.Point(256, 64)
		Me.picCreature.TabIndex = 80
		Me.picCreature.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picCreature.Dock = System.Windows.Forms.DockStyle.None
		Me.picCreature.CausesValidation = True
		Me.picCreature.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picCreature.Cursor = System.Windows.Forms.Cursors.Default
		Me.picCreature.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picCreature.TabStop = True
		Me.picCreature.Visible = True
		Me.picCreature.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picCreature.Name = "picCreature"
		Me.shpFace.BorderColor = System.Drawing.Color.Yellow
		Me.shpFace.BorderWidth = 2
		Me.shpFace.Size = New System.Drawing.Size(26, 32)
		Me.shpFace.Location = New System.Drawing.Point(32, 24)
		Me.shpFace.Visible = False
		Me.shpFace.BackColor = System.Drawing.SystemColors.Window
		Me.shpFace.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.shpFace.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.shpFace.FillColor = System.Drawing.Color.Black
		Me.shpFace.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.shpFace.Name = "shpFace"
		Me.txtCombat.AutoSize = False
		Me.txtCombat.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.txtCombat.Size = New System.Drawing.Size(113, 19)
		Me.txtCombat.Location = New System.Drawing.Point(232, 240)
		Me.txtCombat.ReadOnly = True
		Me.txtCombat.TabIndex = 79
		Me.txtCombat.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCombat.AcceptsReturn = True
		Me.txtCombat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCombat.CausesValidation = True
		Me.txtCombat.Enabled = True
		Me.txtCombat.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCombat.HideSelection = True
		Me.txtCombat.Maxlength = 0
		Me.txtCombat.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCombat.MultiLine = False
		Me.txtCombat.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCombat.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCombat.TabStop = True
		Me.txtCombat.Visible = True
		Me.txtCombat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCombat.Name = "txtCombat"
		Me.txtComments.AutoSize = False
		Me.txtComments.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.txtComments.Size = New System.Drawing.Size(193, 113)
		Me.txtComments.Location = New System.Drawing.Point(56, 88)
		Me.txtComments.ReadOnly = True
		Me.txtComments.MultiLine = True
		Me.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtComments.TabIndex = 78
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
		Me.fraGenProps.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.fraGenProps.Text = "General Properties"
		Me.fraGenProps.Size = New System.Drawing.Size(137, 145)
		Me.fraGenProps.Location = New System.Drawing.Point(784, 224)
		Me.fraGenProps.TabIndex = 71
		Me.fraGenProps.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraGenProps.Enabled = True
		Me.fraGenProps.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraGenProps.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraGenProps.Visible = True
		Me.fraGenProps.Padding = New System.Windows.Forms.Padding(0)
		Me.fraGenProps.Name = "fraGenProps"
		Me.chkIsInanimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.chkIsInanimate.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.chkIsInanimate.Text = "Inanimate?"
		Me.chkIsInanimate.ForeColor = System.Drawing.SystemColors.WindowText
		Me.chkIsInanimate.Size = New System.Drawing.Size(83, 13)
		Me.chkIsInanimate.Location = New System.Drawing.Point(8, 16)
		Me.chkIsInanimate.TabIndex = 77
		Me.chkIsInanimate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkIsInanimate.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkIsInanimate.CausesValidation = True
		Me.chkIsInanimate.Enabled = True
		Me.chkIsInanimate.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkIsInanimate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkIsInanimate.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkIsInanimate.TabStop = True
		Me.chkIsInanimate.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkIsInanimate.Visible = True
		Me.chkIsInanimate.Name = "chkIsInanimate"
		Me.chkRequiredInTome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.chkRequiredInTome.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.chkRequiredInTome.Text = "Locked in Tome?"
		Me.chkRequiredInTome.ForeColor = System.Drawing.SystemColors.WindowText
		Me.chkRequiredInTome.Size = New System.Drawing.Size(103, 13)
		Me.chkRequiredInTome.Location = New System.Drawing.Point(8, 97)
		Me.chkRequiredInTome.TabIndex = 76
		Me.chkRequiredInTome.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkRequiredInTome.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkRequiredInTome.CausesValidation = True
		Me.chkRequiredInTome.Enabled = True
		Me.chkRequiredInTome.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkRequiredInTome.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkRequiredInTome.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkRequiredInTome.TabStop = True
		Me.chkRequiredInTome.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkRequiredInTome.Visible = True
		Me.chkRequiredInTome.Name = "chkRequiredInTome"
		Me.chkFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.chkFriend.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.chkFriend.Text = "Friendly?"
		Me.chkFriend.ForeColor = System.Drawing.SystemColors.WindowText
		Me.chkFriend.Size = New System.Drawing.Size(63, 13)
		Me.chkFriend.Location = New System.Drawing.Point(8, 49)
		Me.chkFriend.TabIndex = 75
		Me.chkFriend.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkFriend.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkFriend.CausesValidation = True
		Me.chkFriend.Enabled = True
		Me.chkFriend.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkFriend.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkFriend.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkFriend.TabStop = True
		Me.chkFriend.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkFriend.Visible = True
		Me.chkFriend.Name = "chkFriend"
		Me.chkGuard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.chkGuard.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.chkGuard.Text = "Prevent Search?"
		Me.chkGuard.ForeColor = System.Drawing.SystemColors.WindowText
		Me.chkGuard.Size = New System.Drawing.Size(115, 13)
		Me.chkGuard.Location = New System.Drawing.Point(8, 81)
		Me.chkGuard.TabIndex = 74
		Me.chkGuard.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkGuard.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkGuard.CausesValidation = True
		Me.chkGuard.Enabled = True
		Me.chkGuard.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkGuard.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkGuard.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkGuard.TabStop = True
		Me.chkGuard.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkGuard.Visible = True
		Me.chkGuard.Name = "chkGuard"
		Me.chkAgressive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.chkAgressive.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.chkAgressive.Text = "Can't Ignore?"
		Me.chkAgressive.ForeColor = System.Drawing.SystemColors.WindowText
		Me.chkAgressive.Size = New System.Drawing.Size(83, 13)
		Me.chkAgressive.Location = New System.Drawing.Point(8, 33)
		Me.chkAgressive.TabIndex = 73
		Me.chkAgressive.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkAgressive.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkAgressive.CausesValidation = True
		Me.chkAgressive.Enabled = True
		Me.chkAgressive.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkAgressive.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkAgressive.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkAgressive.TabStop = True
		Me.chkAgressive.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkAgressive.Visible = True
		Me.chkAgressive.Name = "chkAgressive"
		Me.chkDMControlled.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.chkDMControlled.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.chkDMControlled.Text = "Computer Controlled?"
		Me.chkDMControlled.ForeColor = System.Drawing.SystemColors.WindowText
		Me.chkDMControlled.Size = New System.Drawing.Size(121, 13)
		Me.chkDMControlled.Location = New System.Drawing.Point(8, 64)
		Me.chkDMControlled.TabIndex = 72
		Me.chkDMControlled.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkDMControlled.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkDMControlled.CausesValidation = True
		Me.chkDMControlled.Enabled = True
		Me.chkDMControlled.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkDMControlled.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkDMControlled.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkDMControlled.TabStop = True
		Me.chkDMControlled.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkDMControlled.Visible = True
		Me.chkDMControlled.Name = "chkDMControlled"
		Me.fraResistBonus.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.fraResistBonus.Text = "Resistance Bonuses"
		Me.fraResistBonus.Size = New System.Drawing.Size(433, 81)
		Me.fraResistBonus.Location = New System.Drawing.Point(40, 456)
		Me.fraResistBonus.TabIndex = 54
		Me.fraResistBonus.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraResistBonus.Enabled = True
		Me.fraResistBonus.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraResistBonus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraResistBonus.Visible = True
		Me.fraResistBonus.Padding = New System.Windows.Forms.Padding(0)
		Me.fraResistBonus.Name = "fraResistBonus"
		Me._lblBonusPerc_7.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblBonusPerc_7.Size = New System.Drawing.Size(81, 17)
		Me._lblBonusPerc_7.Location = New System.Drawing.Point(296, 40)
		Me._lblBonusPerc_7.TabIndex = 70
		Me._lblBonusPerc_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblBonusPerc_7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblBonusPerc_7.Enabled = True
		Me._lblBonusPerc_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblBonusPerc_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblBonusPerc_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblBonusPerc_7.UseMnemonic = True
		Me._lblBonusPerc_7.Visible = True
		Me._lblBonusPerc_7.AutoSize = False
		Me._lblBonusPerc_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblBonusPerc_7.Name = "_lblBonusPerc_7"
		Me._lblBonusPerc_6.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblBonusPerc_6.Size = New System.Drawing.Size(81, 17)
		Me._lblBonusPerc_6.Location = New System.Drawing.Point(296, 24)
		Me._lblBonusPerc_6.TabIndex = 69
		Me._lblBonusPerc_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblBonusPerc_6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblBonusPerc_6.Enabled = True
		Me._lblBonusPerc_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblBonusPerc_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblBonusPerc_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblBonusPerc_6.UseMnemonic = True
		Me._lblBonusPerc_6.Visible = True
		Me._lblBonusPerc_6.AutoSize = False
		Me._lblBonusPerc_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblBonusPerc_6.Name = "_lblBonusPerc_6"
		Me._lblBonusPerc_5.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblBonusPerc_5.Size = New System.Drawing.Size(81, 17)
		Me._lblBonusPerc_5.Location = New System.Drawing.Point(176, 56)
		Me._lblBonusPerc_5.TabIndex = 68
		Me._lblBonusPerc_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblBonusPerc_5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblBonusPerc_5.Enabled = True
		Me._lblBonusPerc_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblBonusPerc_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblBonusPerc_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblBonusPerc_5.UseMnemonic = True
		Me._lblBonusPerc_5.Visible = True
		Me._lblBonusPerc_5.AutoSize = False
		Me._lblBonusPerc_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblBonusPerc_5.Name = "_lblBonusPerc_5"
		Me._lblBonusPerc_4.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblBonusPerc_4.Size = New System.Drawing.Size(81, 17)
		Me._lblBonusPerc_4.Location = New System.Drawing.Point(176, 40)
		Me._lblBonusPerc_4.TabIndex = 67
		Me._lblBonusPerc_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblBonusPerc_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblBonusPerc_4.Enabled = True
		Me._lblBonusPerc_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblBonusPerc_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblBonusPerc_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblBonusPerc_4.UseMnemonic = True
		Me._lblBonusPerc_4.Visible = True
		Me._lblBonusPerc_4.AutoSize = False
		Me._lblBonusPerc_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblBonusPerc_4.Name = "_lblBonusPerc_4"
		Me._lblBonusPerc_3.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblBonusPerc_3.Size = New System.Drawing.Size(81, 17)
		Me._lblBonusPerc_3.Location = New System.Drawing.Point(176, 24)
		Me._lblBonusPerc_3.TabIndex = 66
		Me._lblBonusPerc_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblBonusPerc_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblBonusPerc_3.Enabled = True
		Me._lblBonusPerc_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblBonusPerc_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblBonusPerc_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblBonusPerc_3.UseMnemonic = True
		Me._lblBonusPerc_3.Visible = True
		Me._lblBonusPerc_3.AutoSize = False
		Me._lblBonusPerc_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblBonusPerc_3.Name = "_lblBonusPerc_3"
		Me._lblBonusPerc_2.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblBonusPerc_2.Size = New System.Drawing.Size(81, 17)
		Me._lblBonusPerc_2.Location = New System.Drawing.Point(56, 56)
		Me._lblBonusPerc_2.TabIndex = 65
		Me._lblBonusPerc_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblBonusPerc_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblBonusPerc_2.Enabled = True
		Me._lblBonusPerc_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblBonusPerc_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblBonusPerc_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblBonusPerc_2.UseMnemonic = True
		Me._lblBonusPerc_2.Visible = True
		Me._lblBonusPerc_2.AutoSize = False
		Me._lblBonusPerc_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblBonusPerc_2.Name = "_lblBonusPerc_2"
		Me._lblBonusPerc_1.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblBonusPerc_1.Size = New System.Drawing.Size(81, 17)
		Me._lblBonusPerc_1.Location = New System.Drawing.Point(56, 40)
		Me._lblBonusPerc_1.TabIndex = 64
		Me._lblBonusPerc_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblBonusPerc_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblBonusPerc_1.Enabled = True
		Me._lblBonusPerc_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblBonusPerc_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblBonusPerc_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblBonusPerc_1.UseMnemonic = True
		Me._lblBonusPerc_1.Visible = True
		Me._lblBonusPerc_1.AutoSize = False
		Me._lblBonusPerc_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblBonusPerc_1.Name = "_lblBonusPerc_1"
		Me._lblBonusPerc_0.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblBonusPerc_0.Size = New System.Drawing.Size(81, 17)
		Me._lblBonusPerc_0.Location = New System.Drawing.Point(56, 24)
		Me._lblBonusPerc_0.TabIndex = 63
		Me._lblBonusPerc_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblBonusPerc_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblBonusPerc_0.Enabled = True
		Me._lblBonusPerc_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblBonusPerc_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblBonusPerc_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblBonusPerc_0.UseMnemonic = True
		Me._lblBonusPerc_0.Visible = True
		Me._lblBonusPerc_0.AutoSize = False
		Me._lblBonusPerc_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblBonusPerc_0.Name = "_lblBonusPerc_0"
		Me._lblResBonus_7.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblResBonus_7.Text = "Mind : "
		Me._lblResBonus_7.Size = New System.Drawing.Size(33, 17)
		Me._lblResBonus_7.Location = New System.Drawing.Point(256, 40)
		Me._lblResBonus_7.TabIndex = 62
		Me._lblResBonus_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblResBonus_7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblResBonus_7.Enabled = True
		Me._lblResBonus_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblResBonus_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblResBonus_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblResBonus_7.UseMnemonic = True
		Me._lblResBonus_7.Visible = True
		Me._lblResBonus_7.AutoSize = False
		Me._lblResBonus_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblResBonus_7.Name = "_lblResBonus_7"
		Me._lblResBonus_6.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblResBonus_6.Text = "Magic : "
		Me._lblResBonus_6.Size = New System.Drawing.Size(41, 17)
		Me._lblResBonus_6.Location = New System.Drawing.Point(256, 24)
		Me._lblResBonus_6.TabIndex = 61
		Me._lblResBonus_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblResBonus_6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblResBonus_6.Enabled = True
		Me._lblResBonus_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblResBonus_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblResBonus_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblResBonus_6.UseMnemonic = True
		Me._lblResBonus_6.Visible = True
		Me._lblResBonus_6.AutoSize = False
		Me._lblResBonus_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblResBonus_6.Name = "_lblResBonus_6"
		Me._lblResBonus_5.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblResBonus_5.Text = "Good : "
		Me._lblResBonus_5.Size = New System.Drawing.Size(33, 17)
		Me._lblResBonus_5.Location = New System.Drawing.Point(144, 56)
		Me._lblResBonus_5.TabIndex = 60
		Me._lblResBonus_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblResBonus_5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblResBonus_5.Enabled = True
		Me._lblResBonus_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblResBonus_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblResBonus_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblResBonus_5.UseMnemonic = True
		Me._lblResBonus_5.Visible = True
		Me._lblResBonus_5.AutoSize = False
		Me._lblResBonus_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblResBonus_5.Name = "_lblResBonus_5"
		Me._lblResBonus_4.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblResBonus_4.Text = "Evil : "
		Me._lblResBonus_4.Size = New System.Drawing.Size(33, 17)
		Me._lblResBonus_4.Location = New System.Drawing.Point(144, 40)
		Me._lblResBonus_4.TabIndex = 59
		Me._lblResBonus_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblResBonus_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblResBonus_4.Enabled = True
		Me._lblResBonus_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblResBonus_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblResBonus_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblResBonus_4.UseMnemonic = True
		Me._lblResBonus_4.Visible = True
		Me._lblResBonus_4.AutoSize = False
		Me._lblResBonus_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblResBonus_4.Name = "_lblResBonus_4"
		Me._lblResBonus_3.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblResBonus_3.Text = "Fire : "
		Me._lblResBonus_3.Size = New System.Drawing.Size(33, 17)
		Me._lblResBonus_3.Location = New System.Drawing.Point(144, 24)
		Me._lblResBonus_3.TabIndex = 58
		Me._lblResBonus_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblResBonus_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblResBonus_3.Enabled = True
		Me._lblResBonus_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblResBonus_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblResBonus_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblResBonus_3.UseMnemonic = True
		Me._lblResBonus_3.Visible = True
		Me._lblResBonus_3.AutoSize = False
		Me._lblResBonus_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblResBonus_3.Name = "_lblResBonus_3"
		Me._lblResBonus_2.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblResBonus_2.Text = "Cold : "
		Me._lblResBonus_2.Size = New System.Drawing.Size(33, 17)
		Me._lblResBonus_2.Location = New System.Drawing.Point(16, 56)
		Me._lblResBonus_2.TabIndex = 57
		Me._lblResBonus_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblResBonus_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblResBonus_2.Enabled = True
		Me._lblResBonus_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblResBonus_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblResBonus_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblResBonus_2.UseMnemonic = True
		Me._lblResBonus_2.Visible = True
		Me._lblResBonus_2.AutoSize = False
		Me._lblResBonus_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblResBonus_2.Name = "_lblResBonus_2"
		Me._lblResBonus_1.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblResBonus_1.Text = "Blunt : "
		Me._lblResBonus_1.Size = New System.Drawing.Size(33, 17)
		Me._lblResBonus_1.Location = New System.Drawing.Point(16, 40)
		Me._lblResBonus_1.TabIndex = 56
		Me._lblResBonus_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblResBonus_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblResBonus_1.Enabled = True
		Me._lblResBonus_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblResBonus_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblResBonus_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblResBonus_1.UseMnemonic = True
		Me._lblResBonus_1.Visible = True
		Me._lblResBonus_1.AutoSize = False
		Me._lblResBonus_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblResBonus_1.Name = "_lblResBonus_1"
		Me._lblResBonus_0.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblResBonus_0.Text = "Sharp : "
		Me._lblResBonus_0.Size = New System.Drawing.Size(41, 17)
		Me._lblResBonus_0.Location = New System.Drawing.Point(16, 24)
		Me._lblResBonus_0.TabIndex = 55
		Me._lblResBonus_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblResBonus_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblResBonus_0.Enabled = True
		Me._lblResBonus_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblResBonus_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblResBonus_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblResBonus_0.UseMnemonic = True
		Me._lblResBonus_0.Visible = True
		Me._lblResBonus_0.AutoSize = False
		Me._lblResBonus_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblResBonus_0.Name = "_lblResBonus_0"
		Me.FraArmor.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.FraArmor.Text = "Armor"
		Me.FraArmor.Size = New System.Drawing.Size(313, 185)
		Me.FraArmor.Location = New System.Drawing.Point(40, 264)
		Me.FraArmor.TabIndex = 17
		Me.FraArmor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FraArmor.Enabled = True
		Me.FraArmor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FraArmor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FraArmor.Visible = True
		Me.FraArmor.Padding = New System.Windows.Forms.Padding(0)
		Me.FraArmor.Name = "FraArmor"
		Me._lblBody_0.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblBody_0.Text = "Body 1"
		Me._lblBody_0.Size = New System.Drawing.Size(49, 17)
		Me._lblBody_0.Location = New System.Drawing.Point(56, 32)
		Me._lblBody_0.TabIndex = 53
		Me._lblBody_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblBody_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblBody_0.Enabled = True
		Me._lblBody_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblBody_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblBody_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblBody_0.UseMnemonic = True
		Me._lblBody_0.Visible = True
		Me._lblBody_0.AutoSize = False
		Me._lblBody_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblBody_0.Name = "_lblBody_0"
		Me._lblReHeader_0.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblReHeader_0.Text = "Position"
		Me._lblReHeader_0.Size = New System.Drawing.Size(41, 17)
		Me._lblReHeader_0.Location = New System.Drawing.Point(8, 16)
		Me._lblReHeader_0.TabIndex = 52
		Me._lblReHeader_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblReHeader_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblReHeader_0.Enabled = True
		Me._lblReHeader_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblReHeader_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblReHeader_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblReHeader_0.UseMnemonic = True
		Me._lblReHeader_0.Visible = True
		Me._lblReHeader_0.AutoSize = False
		Me._lblReHeader_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblReHeader_0.Name = "_lblReHeader_0"
		Me._lblReHeader_1.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblReHeader_1.Text = "Body Type"
		Me._lblReHeader_1.Size = New System.Drawing.Size(57, 17)
		Me._lblReHeader_1.Location = New System.Drawing.Point(56, 16)
		Me._lblReHeader_1.TabIndex = 51
		Me._lblReHeader_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblReHeader_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblReHeader_1.Enabled = True
		Me._lblReHeader_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblReHeader_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblReHeader_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblReHeader_1.UseMnemonic = True
		Me._lblReHeader_1.Visible = True
		Me._lblReHeader_1.AutoSize = False
		Me._lblReHeader_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblReHeader_1.Name = "_lblReHeader_1"
		Me._lblReHeader_2.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblReHeader_2.Text = "Resistance"
		Me._lblReHeader_2.Size = New System.Drawing.Size(57, 17)
		Me._lblReHeader_2.Location = New System.Drawing.Point(120, 16)
		Me._lblReHeader_2.TabIndex = 50
		Me._lblReHeader_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblReHeader_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblReHeader_2.Enabled = True
		Me._lblReHeader_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblReHeader_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblReHeader_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblReHeader_2.UseMnemonic = True
		Me._lblReHeader_2.Visible = True
		Me._lblReHeader_2.AutoSize = False
		Me._lblReHeader_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblReHeader_2.Name = "_lblReHeader_2"
		Me._lblReHeader_3.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblReHeader_3.Text = "Covered By"
		Me._lblReHeader_3.Size = New System.Drawing.Size(57, 17)
		Me._lblReHeader_3.Location = New System.Drawing.Point(192, 16)
		Me._lblReHeader_3.TabIndex = 49
		Me._lblReHeader_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblReHeader_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblReHeader_3.Enabled = True
		Me._lblReHeader_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblReHeader_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblReHeader_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblReHeader_3.UseMnemonic = True
		Me._lblReHeader_3.Visible = True
		Me._lblReHeader_3.AutoSize = False
		Me._lblReHeader_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblReHeader_3.Name = "_lblReHeader_3"
		Me._lblPlace_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblPlace_0.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblPlace_0.Text = "1"
		Me._lblPlace_0.Size = New System.Drawing.Size(41, 17)
		Me._lblPlace_0.Location = New System.Drawing.Point(8, 32)
		Me._lblPlace_0.TabIndex = 48
		Me._lblPlace_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblPlace_0.Enabled = True
		Me._lblPlace_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblPlace_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblPlace_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblPlace_0.UseMnemonic = True
		Me._lblPlace_0.Visible = True
		Me._lblPlace_0.AutoSize = False
		Me._lblPlace_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblPlace_0.Name = "_lblPlace_0"
		Me._lblPlace_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblPlace_1.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblPlace_1.Text = "2"
		Me._lblPlace_1.Size = New System.Drawing.Size(41, 17)
		Me._lblPlace_1.Location = New System.Drawing.Point(8, 48)
		Me._lblPlace_1.TabIndex = 47
		Me._lblPlace_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblPlace_1.Enabled = True
		Me._lblPlace_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblPlace_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblPlace_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblPlace_1.UseMnemonic = True
		Me._lblPlace_1.Visible = True
		Me._lblPlace_1.AutoSize = False
		Me._lblPlace_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblPlace_1.Name = "_lblPlace_1"
		Me._lblPlace_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblPlace_2.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblPlace_2.Text = "3"
		Me._lblPlace_2.Size = New System.Drawing.Size(41, 17)
		Me._lblPlace_2.Location = New System.Drawing.Point(8, 64)
		Me._lblPlace_2.TabIndex = 46
		Me._lblPlace_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblPlace_2.Enabled = True
		Me._lblPlace_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblPlace_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblPlace_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblPlace_2.UseMnemonic = True
		Me._lblPlace_2.Visible = True
		Me._lblPlace_2.AutoSize = False
		Me._lblPlace_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblPlace_2.Name = "_lblPlace_2"
		Me._lblPlace_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblPlace_3.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblPlace_3.Text = "4"
		Me._lblPlace_3.Size = New System.Drawing.Size(41, 17)
		Me._lblPlace_3.Location = New System.Drawing.Point(8, 80)
		Me._lblPlace_3.TabIndex = 45
		Me._lblPlace_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblPlace_3.Enabled = True
		Me._lblPlace_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblPlace_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblPlace_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblPlace_3.UseMnemonic = True
		Me._lblPlace_3.Visible = True
		Me._lblPlace_3.AutoSize = False
		Me._lblPlace_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblPlace_3.Name = "_lblPlace_3"
		Me._lblPlace_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblPlace_4.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblPlace_4.Text = "5"
		Me._lblPlace_4.Size = New System.Drawing.Size(41, 17)
		Me._lblPlace_4.Location = New System.Drawing.Point(8, 96)
		Me._lblPlace_4.TabIndex = 44
		Me._lblPlace_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblPlace_4.Enabled = True
		Me._lblPlace_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblPlace_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblPlace_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblPlace_4.UseMnemonic = True
		Me._lblPlace_4.Visible = True
		Me._lblPlace_4.AutoSize = False
		Me._lblPlace_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblPlace_4.Name = "_lblPlace_4"
		Me._lblPlace_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblPlace_5.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblPlace_5.Text = "6"
		Me._lblPlace_5.Size = New System.Drawing.Size(41, 17)
		Me._lblPlace_5.Location = New System.Drawing.Point(8, 112)
		Me._lblPlace_5.TabIndex = 43
		Me._lblPlace_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblPlace_5.Enabled = True
		Me._lblPlace_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblPlace_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblPlace_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblPlace_5.UseMnemonic = True
		Me._lblPlace_5.Visible = True
		Me._lblPlace_5.AutoSize = False
		Me._lblPlace_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblPlace_5.Name = "_lblPlace_5"
		Me._lblPlace_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblPlace_6.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblPlace_6.Text = "7"
		Me._lblPlace_6.Size = New System.Drawing.Size(41, 17)
		Me._lblPlace_6.Location = New System.Drawing.Point(8, 128)
		Me._lblPlace_6.TabIndex = 42
		Me._lblPlace_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblPlace_6.Enabled = True
		Me._lblPlace_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblPlace_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblPlace_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblPlace_6.UseMnemonic = True
		Me._lblPlace_6.Visible = True
		Me._lblPlace_6.AutoSize = False
		Me._lblPlace_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblPlace_6.Name = "_lblPlace_6"
		Me._lblPlace_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblPlace_7.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblPlace_7.Text = "8"
		Me._lblPlace_7.Size = New System.Drawing.Size(41, 17)
		Me._lblPlace_7.Location = New System.Drawing.Point(8, 144)
		Me._lblPlace_7.TabIndex = 41
		Me._lblPlace_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblPlace_7.Enabled = True
		Me._lblPlace_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblPlace_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblPlace_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblPlace_7.UseMnemonic = True
		Me._lblPlace_7.Visible = True
		Me._lblPlace_7.AutoSize = False
		Me._lblPlace_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblPlace_7.Name = "_lblPlace_7"
		Me._lblBody_1.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblBody_1.Text = "Body 2"
		Me._lblBody_1.Size = New System.Drawing.Size(49, 17)
		Me._lblBody_1.Location = New System.Drawing.Point(56, 48)
		Me._lblBody_1.TabIndex = 40
		Me._lblBody_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblBody_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblBody_1.Enabled = True
		Me._lblBody_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblBody_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblBody_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblBody_1.UseMnemonic = True
		Me._lblBody_1.Visible = True
		Me._lblBody_1.AutoSize = False
		Me._lblBody_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblBody_1.Name = "_lblBody_1"
		Me._lblBody_2.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblBody_2.Text = "Body 3"
		Me._lblBody_2.Size = New System.Drawing.Size(49, 17)
		Me._lblBody_2.Location = New System.Drawing.Point(56, 64)
		Me._lblBody_2.TabIndex = 39
		Me._lblBody_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblBody_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblBody_2.Enabled = True
		Me._lblBody_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblBody_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblBody_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblBody_2.UseMnemonic = True
		Me._lblBody_2.Visible = True
		Me._lblBody_2.AutoSize = False
		Me._lblBody_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblBody_2.Name = "_lblBody_2"
		Me._lblBody_3.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblBody_3.Text = "Body 4"
		Me._lblBody_3.Size = New System.Drawing.Size(49, 17)
		Me._lblBody_3.Location = New System.Drawing.Point(56, 80)
		Me._lblBody_3.TabIndex = 38
		Me._lblBody_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblBody_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblBody_3.Enabled = True
		Me._lblBody_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblBody_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblBody_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblBody_3.UseMnemonic = True
		Me._lblBody_3.Visible = True
		Me._lblBody_3.AutoSize = False
		Me._lblBody_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblBody_3.Name = "_lblBody_3"
		Me._lblBody_4.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblBody_4.Text = "Body 5"
		Me._lblBody_4.Size = New System.Drawing.Size(49, 17)
		Me._lblBody_4.Location = New System.Drawing.Point(56, 96)
		Me._lblBody_4.TabIndex = 37
		Me._lblBody_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblBody_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblBody_4.Enabled = True
		Me._lblBody_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblBody_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblBody_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblBody_4.UseMnemonic = True
		Me._lblBody_4.Visible = True
		Me._lblBody_4.AutoSize = False
		Me._lblBody_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblBody_4.Name = "_lblBody_4"
		Me._lblBody_5.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblBody_5.Text = "Body 6"
		Me._lblBody_5.Size = New System.Drawing.Size(49, 17)
		Me._lblBody_5.Location = New System.Drawing.Point(56, 112)
		Me._lblBody_5.TabIndex = 36
		Me._lblBody_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblBody_5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblBody_5.Enabled = True
		Me._lblBody_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblBody_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblBody_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblBody_5.UseMnemonic = True
		Me._lblBody_5.Visible = True
		Me._lblBody_5.AutoSize = False
		Me._lblBody_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblBody_5.Name = "_lblBody_5"
		Me._lblBody_6.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblBody_6.Text = "Body 7"
		Me._lblBody_6.Size = New System.Drawing.Size(49, 17)
		Me._lblBody_6.Location = New System.Drawing.Point(56, 128)
		Me._lblBody_6.TabIndex = 35
		Me._lblBody_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblBody_6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblBody_6.Enabled = True
		Me._lblBody_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblBody_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblBody_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblBody_6.UseMnemonic = True
		Me._lblBody_6.Visible = True
		Me._lblBody_6.AutoSize = False
		Me._lblBody_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblBody_6.Name = "_lblBody_6"
		Me._lblBody_7.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblBody_7.Text = "Body 8"
		Me._lblBody_7.Size = New System.Drawing.Size(49, 17)
		Me._lblBody_7.Location = New System.Drawing.Point(56, 144)
		Me._lblBody_7.TabIndex = 34
		Me._lblBody_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblBody_7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblBody_7.Enabled = True
		Me._lblBody_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblBody_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblBody_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblBody_7.UseMnemonic = True
		Me._lblBody_7.Visible = True
		Me._lblBody_7.AutoSize = False
		Me._lblBody_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblBody_7.Name = "_lblBody_7"
		Me._lblResPerc_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblResPerc_0.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblResPerc_0.Text = "0%"
		Me._lblResPerc_0.Size = New System.Drawing.Size(57, 17)
		Me._lblResPerc_0.Location = New System.Drawing.Point(120, 32)
		Me._lblResPerc_0.TabIndex = 33
		Me._lblResPerc_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblResPerc_0.Enabled = True
		Me._lblResPerc_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblResPerc_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblResPerc_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblResPerc_0.UseMnemonic = True
		Me._lblResPerc_0.Visible = True
		Me._lblResPerc_0.AutoSize = False
		Me._lblResPerc_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblResPerc_0.Name = "_lblResPerc_0"
		Me._lblResPerc_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblResPerc_1.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblResPerc_1.Text = "0%"
		Me._lblResPerc_1.Size = New System.Drawing.Size(57, 17)
		Me._lblResPerc_1.Location = New System.Drawing.Point(120, 48)
		Me._lblResPerc_1.TabIndex = 32
		Me._lblResPerc_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblResPerc_1.Enabled = True
		Me._lblResPerc_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblResPerc_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblResPerc_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblResPerc_1.UseMnemonic = True
		Me._lblResPerc_1.Visible = True
		Me._lblResPerc_1.AutoSize = False
		Me._lblResPerc_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblResPerc_1.Name = "_lblResPerc_1"
		Me._lblResPerc_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblResPerc_2.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblResPerc_2.Text = "0%"
		Me._lblResPerc_2.Size = New System.Drawing.Size(57, 17)
		Me._lblResPerc_2.Location = New System.Drawing.Point(120, 64)
		Me._lblResPerc_2.TabIndex = 31
		Me._lblResPerc_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblResPerc_2.Enabled = True
		Me._lblResPerc_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblResPerc_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblResPerc_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblResPerc_2.UseMnemonic = True
		Me._lblResPerc_2.Visible = True
		Me._lblResPerc_2.AutoSize = False
		Me._lblResPerc_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblResPerc_2.Name = "_lblResPerc_2"
		Me._lblResPerc_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblResPerc_3.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblResPerc_3.Text = "0%"
		Me._lblResPerc_3.Size = New System.Drawing.Size(57, 17)
		Me._lblResPerc_3.Location = New System.Drawing.Point(120, 80)
		Me._lblResPerc_3.TabIndex = 30
		Me._lblResPerc_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblResPerc_3.Enabled = True
		Me._lblResPerc_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblResPerc_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblResPerc_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblResPerc_3.UseMnemonic = True
		Me._lblResPerc_3.Visible = True
		Me._lblResPerc_3.AutoSize = False
		Me._lblResPerc_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblResPerc_3.Name = "_lblResPerc_3"
		Me._lblResPerc_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblResPerc_4.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblResPerc_4.Text = "0%"
		Me._lblResPerc_4.Size = New System.Drawing.Size(57, 17)
		Me._lblResPerc_4.Location = New System.Drawing.Point(120, 96)
		Me._lblResPerc_4.TabIndex = 29
		Me._lblResPerc_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblResPerc_4.Enabled = True
		Me._lblResPerc_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblResPerc_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblResPerc_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblResPerc_4.UseMnemonic = True
		Me._lblResPerc_4.Visible = True
		Me._lblResPerc_4.AutoSize = False
		Me._lblResPerc_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblResPerc_4.Name = "_lblResPerc_4"
		Me._lblResPerc_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblResPerc_5.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblResPerc_5.Text = "0%"
		Me._lblResPerc_5.Size = New System.Drawing.Size(57, 17)
		Me._lblResPerc_5.Location = New System.Drawing.Point(120, 112)
		Me._lblResPerc_5.TabIndex = 28
		Me._lblResPerc_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblResPerc_5.Enabled = True
		Me._lblResPerc_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblResPerc_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblResPerc_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblResPerc_5.UseMnemonic = True
		Me._lblResPerc_5.Visible = True
		Me._lblResPerc_5.AutoSize = False
		Me._lblResPerc_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblResPerc_5.Name = "_lblResPerc_5"
		Me._lblResPerc_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblResPerc_6.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblResPerc_6.Text = "0%"
		Me._lblResPerc_6.Size = New System.Drawing.Size(57, 17)
		Me._lblResPerc_6.Location = New System.Drawing.Point(120, 128)
		Me._lblResPerc_6.TabIndex = 27
		Me._lblResPerc_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblResPerc_6.Enabled = True
		Me._lblResPerc_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblResPerc_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblResPerc_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblResPerc_6.UseMnemonic = True
		Me._lblResPerc_6.Visible = True
		Me._lblResPerc_6.AutoSize = False
		Me._lblResPerc_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblResPerc_6.Name = "_lblResPerc_6"
		Me._lblResPerc_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblResPerc_7.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblResPerc_7.Text = "0%"
		Me._lblResPerc_7.Size = New System.Drawing.Size(57, 17)
		Me._lblResPerc_7.Location = New System.Drawing.Point(120, 144)
		Me._lblResPerc_7.TabIndex = 26
		Me._lblResPerc_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblResPerc_7.Enabled = True
		Me._lblResPerc_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblResPerc_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblResPerc_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblResPerc_7.UseMnemonic = True
		Me._lblResPerc_7.Visible = True
		Me._lblResPerc_7.AutoSize = False
		Me._lblResPerc_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblResPerc_7.Name = "_lblResPerc_7"
		Me._lblCovered_0.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblCovered_0.Text = "Body Armor"
		Me._lblCovered_0.Size = New System.Drawing.Size(57, 17)
		Me._lblCovered_0.Location = New System.Drawing.Point(192, 32)
		Me._lblCovered_0.TabIndex = 25
		Me._lblCovered_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblCovered_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblCovered_0.Enabled = True
		Me._lblCovered_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblCovered_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblCovered_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblCovered_0.UseMnemonic = True
		Me._lblCovered_0.Visible = True
		Me._lblCovered_0.AutoSize = False
		Me._lblCovered_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblCovered_0.Name = "_lblCovered_0"
		Me._lblCovered_1.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblCovered_1.Text = "Body Armor"
		Me._lblCovered_1.Size = New System.Drawing.Size(57, 17)
		Me._lblCovered_1.Location = New System.Drawing.Point(192, 48)
		Me._lblCovered_1.TabIndex = 24
		Me._lblCovered_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblCovered_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblCovered_1.Enabled = True
		Me._lblCovered_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblCovered_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblCovered_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblCovered_1.UseMnemonic = True
		Me._lblCovered_1.Visible = True
		Me._lblCovered_1.AutoSize = False
		Me._lblCovered_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblCovered_1.Name = "_lblCovered_1"
		Me._lblCovered_2.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblCovered_2.Text = "Body Armor"
		Me._lblCovered_2.Size = New System.Drawing.Size(57, 17)
		Me._lblCovered_2.Location = New System.Drawing.Point(192, 64)
		Me._lblCovered_2.TabIndex = 23
		Me._lblCovered_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblCovered_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblCovered_2.Enabled = True
		Me._lblCovered_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblCovered_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblCovered_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblCovered_2.UseMnemonic = True
		Me._lblCovered_2.Visible = True
		Me._lblCovered_2.AutoSize = False
		Me._lblCovered_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblCovered_2.Name = "_lblCovered_2"
		Me._lblCovered_3.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblCovered_3.Text = "Body Armor"
		Me._lblCovered_3.Size = New System.Drawing.Size(57, 17)
		Me._lblCovered_3.Location = New System.Drawing.Point(192, 80)
		Me._lblCovered_3.TabIndex = 22
		Me._lblCovered_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblCovered_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblCovered_3.Enabled = True
		Me._lblCovered_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblCovered_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblCovered_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblCovered_3.UseMnemonic = True
		Me._lblCovered_3.Visible = True
		Me._lblCovered_3.AutoSize = False
		Me._lblCovered_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblCovered_3.Name = "_lblCovered_3"
		Me._lblCovered_4.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblCovered_4.Text = "Shield"
		Me._lblCovered_4.Size = New System.Drawing.Size(57, 17)
		Me._lblCovered_4.Location = New System.Drawing.Point(192, 96)
		Me._lblCovered_4.TabIndex = 21
		Me._lblCovered_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblCovered_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblCovered_4.Enabled = True
		Me._lblCovered_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblCovered_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblCovered_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblCovered_4.UseMnemonic = True
		Me._lblCovered_4.Visible = True
		Me._lblCovered_4.AutoSize = False
		Me._lblCovered_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblCovered_4.Name = "_lblCovered_4"
		Me._lblCovered_5.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblCovered_5.Text = "Shield"
		Me._lblCovered_5.Size = New System.Drawing.Size(57, 17)
		Me._lblCovered_5.Location = New System.Drawing.Point(192, 112)
		Me._lblCovered_5.TabIndex = 20
		Me._lblCovered_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblCovered_5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblCovered_5.Enabled = True
		Me._lblCovered_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblCovered_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblCovered_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblCovered_5.UseMnemonic = True
		Me._lblCovered_5.Visible = True
		Me._lblCovered_5.AutoSize = False
		Me._lblCovered_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblCovered_5.Name = "_lblCovered_5"
		Me._lblCovered_6.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblCovered_6.Text = "Helm"
		Me._lblCovered_6.Size = New System.Drawing.Size(57, 17)
		Me._lblCovered_6.Location = New System.Drawing.Point(192, 128)
		Me._lblCovered_6.TabIndex = 19
		Me._lblCovered_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblCovered_6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblCovered_6.Enabled = True
		Me._lblCovered_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblCovered_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblCovered_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblCovered_6.UseMnemonic = True
		Me._lblCovered_6.Visible = True
		Me._lblCovered_6.AutoSize = False
		Me._lblCovered_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblCovered_6.Name = "_lblCovered_6"
		Me._lblCovered_7.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me._lblCovered_7.Text = "None"
		Me._lblCovered_7.Size = New System.Drawing.Size(57, 17)
		Me._lblCovered_7.Location = New System.Drawing.Point(192, 144)
		Me._lblCovered_7.TabIndex = 18
		Me._lblCovered_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblCovered_7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblCovered_7.Enabled = True
		Me._lblCovered_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblCovered_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblCovered_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblCovered_7.UseMnemonic = True
		Me._lblCovered_7.Visible = True
		Me._lblCovered_7.AutoSize = False
		Me._lblCovered_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblCovered_7.Name = "_lblCovered_7"
		Me.fraItems.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.fraItems.Text = "Items"
		Me.fraItems.Size = New System.Drawing.Size(201, 209)
		Me.fraItems.Location = New System.Drawing.Point(712, 8)
		Me.fraItems.TabIndex = 13
		Me.fraItems.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraItems.Enabled = True
		Me.fraItems.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraItems.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraItems.Visible = True
		Me.fraItems.Padding = New System.Windows.Forms.Padding(0)
		Me.fraItems.Name = "fraItems"
		Me.lstItems.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.lstItems.Size = New System.Drawing.Size(185, 72)
		Me.lstItems.Location = New System.Drawing.Point(8, 16)
		Me.lstItems.TabIndex = 15
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
		Me.txtItemComments.AutoSize = False
		Me.txtItemComments.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.txtItemComments.Size = New System.Drawing.Size(185, 97)
		Me.txtItemComments.Location = New System.Drawing.Point(8, 104)
		Me.txtItemComments.ReadOnly = True
		Me.txtItemComments.Maxlength = 10000
		Me.txtItemComments.MultiLine = True
		Me.txtItemComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtItemComments.TabIndex = 14
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
		Me.lblItemComments.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.lblItemComments.Text = "Item Comments"
		Me.lblItemComments.Size = New System.Drawing.Size(145, 17)
		Me.lblItemComments.Location = New System.Drawing.Point(8, 88)
		Me.lblItemComments.TabIndex = 16
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
		Me.lblSize.Text = "Size : "
		Me.lblSize.Size = New System.Drawing.Size(33, 17)
		Me.lblSize.Location = New System.Drawing.Point(32, 64)
		Me.lblSize.TabIndex = 148
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
		Me._lblRace_0.Text = "Race :"
		Me._lblRace_0.Size = New System.Drawing.Size(41, 13)
		Me._lblRace_0.Location = New System.Drawing.Point(32, 40)
		Me._lblRace_0.TabIndex = 149
		Me._lblRace_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblRace_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblRace_0.BackColor = System.Drawing.Color.Transparent
		Me._lblRace_0.Enabled = True
		Me._lblRace_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblRace_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblRace_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblRace_0.UseMnemonic = True
		Me._lblRace_0.Visible = True
		Me._lblRace_0.AutoSize = False
		Me._lblRace_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblRace_0.Name = "_lblRace_0"
		Me._lblName_0.BackColor = System.Drawing.Color.Transparent
		Me._lblName_0.Text = "Name :"
		Me._lblName_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lblName_0.Size = New System.Drawing.Size(41, 13)
		Me._lblName_0.Location = New System.Drawing.Point(32, 16)
		Me._lblName_0.TabIndex = 150
		Me._lblName_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblName_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblName_0.Enabled = True
		Me._lblName_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblName_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblName_0.UseMnemonic = True
		Me._lblName_0.Visible = True
		Me._lblName_0.AutoSize = False
		Me._lblName_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblName_0.Name = "_lblName_0"
		Me.lblCombat.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.lblCombat.Text = "Combat Rank :"
		Me.lblCombat.Size = New System.Drawing.Size(105, 17)
		Me.lblCombat.Location = New System.Drawing.Point(232, 224)
		Me.lblCombat.TabIndex = 144
		Me.lblCombat.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCombat.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCombat.Enabled = True
		Me.lblCombat.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCombat.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCombat.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCombat.UseMnemonic = True
		Me.lblCombat.Visible = True
		Me.lblCombat.AutoSize = False
		Me.lblCombat.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCombat.Name = "lblCombat"
		Me._Label1_9.BackColor = System.Drawing.Color.Transparent
		Me._Label1_9.Text = "ExpLvl"
		Me._Label1_9.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_9.Size = New System.Drawing.Size(37, 13)
		Me._Label1_9.Location = New System.Drawing.Point(33, 219)
		Me._Label1_9.TabIndex = 145
		Me._Label1_9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_9.Enabled = True
		Me._Label1_9.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_9.UseMnemonic = True
		Me._Label1_9.Visible = True
		Me._Label1_9.AutoSize = False
		Me._Label1_9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_9.Name = "_Label1_9"
		Me._Label1_4.BackColor = System.Drawing.Color.Transparent
		Me._Label1_4.Text = "SkillPts"
		Me._Label1_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_4.Size = New System.Drawing.Size(37, 13)
		Me._Label1_4.Location = New System.Drawing.Point(33, 243)
		Me._Label1_4.TabIndex = 147
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
		Me._Label1_17.BackColor = System.Drawing.Color.Transparent
		Me._Label1_17.Text = "ExpPts"
		Me._Label1_17.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_17.Size = New System.Drawing.Size(37, 13)
		Me._Label1_17.Location = New System.Drawing.Point(129, 243)
		Me._Label1_17.TabIndex = 146
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
		Me.imgBook.Size = New System.Drawing.Size(987, 564)
		Me.imgBook.Location = New System.Drawing.Point(0, 0)
		Me.imgBook.Image = CType(resources.GetObject("imgBook.Image"), System.Drawing.Image)
		Me.imgBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.imgBook.Enabled = True
		Me.imgBook.Cursor = System.Windows.Forms.Cursors.Default
		Me.imgBook.Visible = True
		Me.imgBook.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.imgBook.Name = "imgBook"
		Me.picMons.BackColor = System.Drawing.SystemColors.Window
		Me.picMons.ForeColor = System.Drawing.SystemColors.WindowText
		Me.picMons.Size = New System.Drawing.Size(81, 81)
		Me.picMons.Location = New System.Drawing.Point(8, 776)
		Me.picMons.TabIndex = 8
		Me.picMons.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picMons.Dock = System.Windows.Forms.DockStyle.None
		Me.picMons.CausesValidation = True
		Me.picMons.Enabled = True
		Me.picMons.Cursor = System.Windows.Forms.Cursors.Default
		Me.picMons.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picMons.TabStop = True
		Me.picMons.Visible = True
		Me.picMons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picMons.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.picMons.Name = "picMons"
		Me.picMask.BackColor = System.Drawing.SystemColors.Window
		Me.picMask.ForeColor = System.Drawing.SystemColors.WindowText
		Me.picMask.Size = New System.Drawing.Size(89, 81)
		Me.picMask.Location = New System.Drawing.Point(8, 688)
		Me.picMask.TabIndex = 7
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
		Me.dlstDirectory.Size = New System.Drawing.Size(145, 141)
		Me.dlstDirectory.Location = New System.Drawing.Point(8, 96)
		Me.dlstDirectory.TabIndex = 5
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
		Me.txtDataPath.AutoSize = False
		Me.txtDataPath.Size = New System.Drawing.Size(369, 19)
		Me.txtDataPath.Location = New System.Drawing.Point(72, 8)
		Me.txtDataPath.ReadOnly = True
		Me.txtDataPath.TabIndex = 3
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
		Me.flsFileList.Size = New System.Drawing.Size(145, 344)
		Me.flsFileList.Location = New System.Drawing.Point(8, 256)
		Me.flsFileList.Pattern = "*.rsc"
		Me.flsFileList.TabIndex = 1
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
		Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdClose.Text = "Close"
		Me.cmdClose.Size = New System.Drawing.Size(97, 25)
		Me.cmdClose.Location = New System.Drawing.Point(456, 8)
		Me.cmdClose.TabIndex = 0
		Me.cmdClose.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.CausesValidation = True
		Me.cmdClose.Enabled = True
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.TabStop = True
		Me.cmdClose.Name = "cmdClose"
		Me.fraCompactView.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.fraCompactView.Size = New System.Drawing.Size(401, 313)
		Me.fraCompactView.Location = New System.Drawing.Point(160, 40)
		Me.fraCompactView.TabIndex = 9
		Me.fraCompactView.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraCompactView.BackColor = System.Drawing.SystemColors.Control
		Me.fraCompactView.Enabled = True
		Me.fraCompactView.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraCompactView.Cursor = System.Windows.Forms.Cursors.Default
		Me.fraCompactView.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraCompactView.Visible = True
		Me.fraCompactView.Name = "fraCompactView"
		Me.txtInfo.AutoSize = False
		Me.txtInfo.Size = New System.Drawing.Size(265, 297)
		Me.txtInfo.Location = New System.Drawing.Point(128, 16)
		Me.txtInfo.ReadOnly = True
		Me.txtInfo.MultiLine = True
		Me.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.txtInfo.WordWrap = False
		Me.txtInfo.TabIndex = 11
		Me.txtInfo.Text = "Click a creature file name to display its info." & Chr(13) & Chr(10)
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
		Me.picCreatureCompact.BackColor = System.Drawing.Color.FromARGB(253, 254, 226)
		Me.picCreatureCompact.Enabled = False
		Me.picCreatureCompact.Size = New System.Drawing.Size(109, 137)
		Me.picCreatureCompact.Location = New System.Drawing.Point(8, 16)
		Me.picCreatureCompact.TabIndex = 10
		Me.picCreatureCompact.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picCreatureCompact.Dock = System.Windows.Forms.DockStyle.None
		Me.picCreatureCompact.CausesValidation = True
		Me.picCreatureCompact.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picCreatureCompact.Cursor = System.Windows.Forms.Cursors.Default
		Me.picCreatureCompact.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picCreatureCompact.TabStop = True
		Me.picCreatureCompact.Visible = True
		Me.picCreatureCompact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picCreatureCompact.Name = "picCreatureCompact"
		Me.Shape1.BorderColor = System.Drawing.Color.Yellow
		Me.Shape1.BorderWidth = 2
		Me.Shape1.Size = New System.Drawing.Size(26, 32)
		Me.Shape1.Location = New System.Drawing.Point(32, 24)
		Me.Shape1.Visible = False
		Me.Shape1.BackColor = System.Drawing.SystemColors.Window
		Me.Shape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shape1.FillColor = System.Drawing.Color.Black
		Me.Shape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape1.Name = "Shape1"
		Me.lblDrive.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblDrive.Text = "Drive"
		Me.lblDrive.Size = New System.Drawing.Size(145, 17)
		Me.lblDrive.Location = New System.Drawing.Point(8, 40)
		Me.lblDrive.TabIndex = 151
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
		Me.lblDirectory.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblDirectory.Text = "Directory"
		Me.lblDirectory.Size = New System.Drawing.Size(145, 17)
		Me.lblDirectory.Location = New System.Drawing.Point(8, 80)
		Me.lblDirectory.TabIndex = 6
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
		Me.lblFiles.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblFiles.Text = "Creature Files"
		Me.lblFiles.Size = New System.Drawing.Size(145, 17)
		Me.lblFiles.Location = New System.Drawing.Point(8, 240)
		Me.lblFiles.TabIndex = 4
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
		Me.lblPath.Text = "DataPath : "
		Me.lblPath.Size = New System.Drawing.Size(65, 25)
		Me.lblPath.Location = New System.Drawing.Point(8, 8)
		Me.lblPath.TabIndex = 2
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
		Me.Label1.SetIndex(_Label1_9, CType(9, Short))
		Me.Label1.SetIndex(_Label1_4, CType(4, Short))
		Me.Label1.SetIndex(_Label1_17, CType(17, Short))
		Me.chkFamily.SetIndex(_chkFamily_0, CType(0, Short))
		Me.chkFamily.SetIndex(_chkFamily_1, CType(1, Short))
		Me.chkFamily.SetIndex(_chkFamily_2, CType(2, Short))
		Me.chkFamily.SetIndex(_chkFamily_3, CType(3, Short))
		Me.chkFamily.SetIndex(_chkFamily_4, CType(4, Short))
		Me.chkFamily.SetIndex(_chkFamily_5, CType(5, Short))
		Me.chkFamily.SetIndex(_chkFamily_6, CType(6, Short))
		Me.chkFamily.SetIndex(_chkFamily_7, CType(7, Short))
		Me.chkFamily.SetIndex(_chkFamily_8, CType(8, Short))
		Me.chkFamily.SetIndex(_chkFamily_9, CType(9, Short))
		Me.cmdPlaySound.SetIndex(_cmdPlaySound_0, CType(0, Short))
		Me.cmdPlaySound.SetIndex(_cmdPlaySound_1, CType(1, Short))
		Me.cmdPlaySound.SetIndex(_cmdPlaySound_2, CType(2, Short))
		Me.cmdPlaySound.SetIndex(_cmdPlaySound_3, CType(3, Short))
		Me.lblBody.SetIndex(_lblBody_0, CType(0, Short))
		Me.lblBody.SetIndex(_lblBody_1, CType(1, Short))
		Me.lblBody.SetIndex(_lblBody_2, CType(2, Short))
		Me.lblBody.SetIndex(_lblBody_3, CType(3, Short))
		Me.lblBody.SetIndex(_lblBody_4, CType(4, Short))
		Me.lblBody.SetIndex(_lblBody_5, CType(5, Short))
		Me.lblBody.SetIndex(_lblBody_6, CType(6, Short))
		Me.lblBody.SetIndex(_lblBody_7, CType(7, Short))
		Me.lblBonusPerc.SetIndex(_lblBonusPerc_7, CType(7, Short))
		Me.lblBonusPerc.SetIndex(_lblBonusPerc_6, CType(6, Short))
		Me.lblBonusPerc.SetIndex(_lblBonusPerc_5, CType(5, Short))
		Me.lblBonusPerc.SetIndex(_lblBonusPerc_4, CType(4, Short))
		Me.lblBonusPerc.SetIndex(_lblBonusPerc_3, CType(3, Short))
		Me.lblBonusPerc.SetIndex(_lblBonusPerc_2, CType(2, Short))
		Me.lblBonusPerc.SetIndex(_lblBonusPerc_1, CType(1, Short))
		Me.lblBonusPerc.SetIndex(_lblBonusPerc_0, CType(0, Short))
		Me.lblCovered.SetIndex(_lblCovered_0, CType(0, Short))
		Me.lblCovered.SetIndex(_lblCovered_1, CType(1, Short))
		Me.lblCovered.SetIndex(_lblCovered_2, CType(2, Short))
		Me.lblCovered.SetIndex(_lblCovered_3, CType(3, Short))
		Me.lblCovered.SetIndex(_lblCovered_4, CType(4, Short))
		Me.lblCovered.SetIndex(_lblCovered_5, CType(5, Short))
		Me.lblCovered.SetIndex(_lblCovered_6, CType(6, Short))
		Me.lblCovered.SetIndex(_lblCovered_7, CType(7, Short))
		Me.lblName.SetIndex(_lblName_0, CType(0, Short))
		Me.lblPlace.SetIndex(_lblPlace_0, CType(0, Short))
		Me.lblPlace.SetIndex(_lblPlace_1, CType(1, Short))
		Me.lblPlace.SetIndex(_lblPlace_2, CType(2, Short))
		Me.lblPlace.SetIndex(_lblPlace_3, CType(3, Short))
		Me.lblPlace.SetIndex(_lblPlace_4, CType(4, Short))
		Me.lblPlace.SetIndex(_lblPlace_5, CType(5, Short))
		Me.lblPlace.SetIndex(_lblPlace_6, CType(6, Short))
		Me.lblPlace.SetIndex(_lblPlace_7, CType(7, Short))
		Me.lblRace.SetIndex(_lblRace_0, CType(0, Short))
		Me.lblReHeader.SetIndex(_lblReHeader_0, CType(0, Short))
		Me.lblReHeader.SetIndex(_lblReHeader_1, CType(1, Short))
		Me.lblReHeader.SetIndex(_lblReHeader_2, CType(2, Short))
		Me.lblReHeader.SetIndex(_lblReHeader_3, CType(3, Short))
		Me.lblResBonus.SetIndex(_lblResBonus_7, CType(7, Short))
		Me.lblResBonus.SetIndex(_lblResBonus_6, CType(6, Short))
		Me.lblResBonus.SetIndex(_lblResBonus_5, CType(5, Short))
		Me.lblResBonus.SetIndex(_lblResBonus_4, CType(4, Short))
		Me.lblResBonus.SetIndex(_lblResBonus_3, CType(3, Short))
		Me.lblResBonus.SetIndex(_lblResBonus_2, CType(2, Short))
		Me.lblResBonus.SetIndex(_lblResBonus_1, CType(1, Short))
		Me.lblResBonus.SetIndex(_lblResBonus_0, CType(0, Short))
		Me.lblResPerc.SetIndex(_lblResPerc_0, CType(0, Short))
		Me.lblResPerc.SetIndex(_lblResPerc_1, CType(1, Short))
		Me.lblResPerc.SetIndex(_lblResPerc_2, CType(2, Short))
		Me.lblResPerc.SetIndex(_lblResPerc_3, CType(3, Short))
		Me.lblResPerc.SetIndex(_lblResPerc_4, CType(4, Short))
		Me.lblResPerc.SetIndex(_lblResPerc_5, CType(5, Short))
		Me.lblResPerc.SetIndex(_lblResPerc_6, CType(6, Short))
		Me.lblResPerc.SetIndex(_lblResPerc_7, CType(7, Short))
		Me.lblSoundEvent.SetIndex(_lblSoundEvent_0, CType(0, Short))
		Me.lblSoundEvent.SetIndex(_lblSoundEvent_1, CType(1, Short))
		Me.lblSoundEvent.SetIndex(_lblSoundEvent_2, CType(2, Short))
		Me.lblSoundEvent.SetIndex(_lblSoundEvent_3, CType(3, Short))
		Me.lblStats.SetIndex(_lblStats_0, CType(0, Short))
		Me.lblStats.SetIndex(_lblStats_1, CType(1, Short))
		Me.lblStats.SetIndex(_lblStats_2, CType(2, Short))
		Me.lblStats.SetIndex(_lblStats_3, CType(3, Short))
		Me.lblStats.SetIndex(_lblStats_4, CType(4, Short))
		Me.lblStats.SetIndex(_lblStats_5, CType(5, Short))
		Me.lblVices.SetIndex(_lblVices_0, CType(0, Short))
		Me.lblVices.SetIndex(_lblVices_1, CType(1, Short))
		Me.lblVices.SetIndex(_lblVices_2, CType(2, Short))
		Me.lblVices.SetIndex(_lblVices_3, CType(3, Short))
		Me.lblVices.SetIndex(_lblVices_4, CType(4, Short))
		Me.lblVices.SetIndex(_lblVices_5, CType(5, Short))
		Me.txtSoundFile.SetIndex(_txtSoundFile_0, CType(0, Short))
		Me.txtSoundFile.SetIndex(_txtSoundFile_1, CType(1, Short))
		Me.txtSoundFile.SetIndex(_txtSoundFile_2, CType(2, Short))
		Me.txtSoundFile.SetIndex(_txtSoundFile_3, CType(3, Short))
		Me.txtStats.SetIndex(_txtStats_0, CType(0, Short))
		Me.txtStats.SetIndex(_txtStats_1, CType(1, Short))
		Me.txtStats.SetIndex(_txtStats_2, CType(2, Short))
		Me.txtStats.SetIndex(_txtStats_3, CType(3, Short))
		Me.txtStats.SetIndex(_txtStats_4, CType(4, Short))
		Me.txtStats.SetIndex(_txtStats_5, CType(5, Short))
		Me.txtVices.SetIndex(_txtVices_0, CType(0, Short))
		Me.txtVices.SetIndex(_txtVices_1, CType(1, Short))
		Me.txtVices.SetIndex(_txtVices_2, CType(2, Short))
		Me.txtVices.SetIndex(_txtVices_3, CType(3, Short))
		Me.txtVices.SetIndex(_txtVices_4, CType(4, Short))
		Me.txtVices.SetIndex(_txtVices_5, CType(5, Short))
		CType(Me.txtVices, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtStats, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtSoundFile, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblVices, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblStats, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblSoundEvent, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblResPerc, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblResBonus, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblReHeader, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblRace, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblPlace, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblCovered, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblBonusPerc, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblBody, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdPlaySound, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chkFamily, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(btnInsert)
		Me.Controls.Add(drvList)
		Me.Controls.Add(fraFullView)
		Me.Controls.Add(picMons)
		Me.Controls.Add(picMask)
		Me.Controls.Add(dlstDirectory)
		Me.Controls.Add(txtDataPath)
		Me.Controls.Add(flsFileList)
		Me.Controls.Add(cmdClose)
		Me.Controls.Add(fraCompactView)
		Me.Controls.Add(lblDrive)
		Me.Controls.Add(lblDirectory)
		Me.Controls.Add(lblFiles)
		Me.Controls.Add(lblPath)
		Me.fraFullView.Controls.Add(fraStats)
		Me.fraFullView.Controls.Add(fraFamily)
		Me.fraFullView.Controls.Add(fraVices)
		Me.fraFullView.Controls.Add(fraTriggers)
		Me.fraFullView.Controls.Add(fraConvo)
		Me.fraFullView.Controls.Add(fraSounds)
		Me.fraFullView.Controls.Add(txtName)
		Me.fraFullView.Controls.Add(txtRace)
		Me.fraFullView.Controls.Add(txtSize)
		Me.fraFullView.Controls.Add(chkIsMale)
		Me.fraFullView.Controls.Add(txtSkillPoints)
		Me.fraFullView.Controls.Add(txtExperiencePoints)
		Me.fraFullView.Controls.Add(txtLevel)
		Me.fraFullView.Controls.Add(picCreature)
		Me.fraFullView.Controls.Add(txtCombat)
		Me.fraFullView.Controls.Add(txtComments)
		Me.fraFullView.Controls.Add(fraGenProps)
		Me.fraFullView.Controls.Add(fraResistBonus)
		Me.fraFullView.Controls.Add(FraArmor)
		Me.fraFullView.Controls.Add(fraItems)
		Me.fraFullView.Controls.Add(lblSize)
		Me.fraFullView.Controls.Add(_lblRace_0)
		Me.fraFullView.Controls.Add(_lblName_0)
		Me.fraFullView.Controls.Add(lblCombat)
		Me.fraFullView.Controls.Add(_Label1_9)
		Me.fraFullView.Controls.Add(_Label1_4)
		Me.fraFullView.Controls.Add(_Label1_17)
		Me.fraFullView.Controls.Add(imgBook)
		Me.fraStats.Controls.Add(_txtStats_0)
		Me.fraStats.Controls.Add(_txtStats_1)
		Me.fraStats.Controls.Add(_txtStats_2)
		Me.fraStats.Controls.Add(_txtStats_3)
		Me.fraStats.Controls.Add(_txtStats_4)
		Me.fraStats.Controls.Add(_txtStats_5)
		Me.fraStats.Controls.Add(_lblStats_0)
		Me.fraStats.Controls.Add(_lblStats_1)
		Me.fraStats.Controls.Add(_lblStats_2)
		Me.fraStats.Controls.Add(_lblStats_3)
		Me.fraStats.Controls.Add(_lblStats_4)
		Me.fraStats.Controls.Add(_lblStats_5)
		Me.fraFamily.Controls.Add(_chkFamily_0)
		Me.fraFamily.Controls.Add(_chkFamily_1)
		Me.fraFamily.Controls.Add(_chkFamily_2)
		Me.fraFamily.Controls.Add(_chkFamily_3)
		Me.fraFamily.Controls.Add(_chkFamily_4)
		Me.fraFamily.Controls.Add(_chkFamily_5)
		Me.fraFamily.Controls.Add(_chkFamily_6)
		Me.fraFamily.Controls.Add(_chkFamily_7)
		Me.fraFamily.Controls.Add(_chkFamily_8)
		Me.fraFamily.Controls.Add(_chkFamily_9)
		Me.fraVices.Controls.Add(_txtVices_0)
		Me.fraVices.Controls.Add(_txtVices_1)
		Me.fraVices.Controls.Add(_txtVices_2)
		Me.fraVices.Controls.Add(_txtVices_3)
		Me.fraVices.Controls.Add(_txtVices_4)
		Me.fraVices.Controls.Add(_txtVices_5)
		Me.fraVices.Controls.Add(_lblVices_0)
		Me.fraVices.Controls.Add(_lblVices_1)
		Me.fraVices.Controls.Add(_lblVices_2)
		Me.fraVices.Controls.Add(_lblVices_3)
		Me.fraVices.Controls.Add(_lblVices_4)
		Me.fraVices.Controls.Add(_lblVices_5)
		Me.fraTriggers.Controls.Add(lstTriggers)
		Me.fraTriggers.Controls.Add(txtTriggComm)
		Me.fraTriggers.Controls.Add(lblTriggComm)
		Me.fraConvo.Controls.Add(lstConvos)
		Me.fraSounds.Controls.Add(_txtSoundFile_0)
		Me.fraSounds.Controls.Add(_txtSoundFile_1)
		Me.fraSounds.Controls.Add(_txtSoundFile_2)
		Me.fraSounds.Controls.Add(_txtSoundFile_3)
		Me.fraSounds.Controls.Add(_cmdPlaySound_0)
		Me.fraSounds.Controls.Add(_cmdPlaySound_1)
		Me.fraSounds.Controls.Add(_cmdPlaySound_2)
		Me.fraSounds.Controls.Add(_cmdPlaySound_3)
		Me.fraSounds.Controls.Add(_lblSoundEvent_0)
		Me.fraSounds.Controls.Add(_lblSoundEvent_1)
		Me.fraSounds.Controls.Add(_lblSoundEvent_2)
		Me.fraSounds.Controls.Add(_lblSoundEvent_3)
		Me.ShapeContainer1.Shapes.Add(shpFace)
		Me.picCreature.Controls.Add(ShapeContainer1)
		Me.fraGenProps.Controls.Add(chkIsInanimate)
		Me.fraGenProps.Controls.Add(chkRequiredInTome)
		Me.fraGenProps.Controls.Add(chkFriend)
		Me.fraGenProps.Controls.Add(chkGuard)
		Me.fraGenProps.Controls.Add(chkAgressive)
		Me.fraGenProps.Controls.Add(chkDMControlled)
		Me.fraResistBonus.Controls.Add(_lblBonusPerc_7)
		Me.fraResistBonus.Controls.Add(_lblBonusPerc_6)
		Me.fraResistBonus.Controls.Add(_lblBonusPerc_5)
		Me.fraResistBonus.Controls.Add(_lblBonusPerc_4)
		Me.fraResistBonus.Controls.Add(_lblBonusPerc_3)
		Me.fraResistBonus.Controls.Add(_lblBonusPerc_2)
		Me.fraResistBonus.Controls.Add(_lblBonusPerc_1)
		Me.fraResistBonus.Controls.Add(_lblBonusPerc_0)
		Me.fraResistBonus.Controls.Add(_lblResBonus_7)
		Me.fraResistBonus.Controls.Add(_lblResBonus_6)
		Me.fraResistBonus.Controls.Add(_lblResBonus_5)
		Me.fraResistBonus.Controls.Add(_lblResBonus_4)
		Me.fraResistBonus.Controls.Add(_lblResBonus_3)
		Me.fraResistBonus.Controls.Add(_lblResBonus_2)
		Me.fraResistBonus.Controls.Add(_lblResBonus_1)
		Me.fraResistBonus.Controls.Add(_lblResBonus_0)
		Me.FraArmor.Controls.Add(_lblBody_0)
		Me.FraArmor.Controls.Add(_lblReHeader_0)
		Me.FraArmor.Controls.Add(_lblReHeader_1)
		Me.FraArmor.Controls.Add(_lblReHeader_2)
		Me.FraArmor.Controls.Add(_lblReHeader_3)
		Me.FraArmor.Controls.Add(_lblPlace_0)
		Me.FraArmor.Controls.Add(_lblPlace_1)
		Me.FraArmor.Controls.Add(_lblPlace_2)
		Me.FraArmor.Controls.Add(_lblPlace_3)
		Me.FraArmor.Controls.Add(_lblPlace_4)
		Me.FraArmor.Controls.Add(_lblPlace_5)
		Me.FraArmor.Controls.Add(_lblPlace_6)
		Me.FraArmor.Controls.Add(_lblPlace_7)
		Me.FraArmor.Controls.Add(_lblBody_1)
		Me.FraArmor.Controls.Add(_lblBody_2)
		Me.FraArmor.Controls.Add(_lblBody_3)
		Me.FraArmor.Controls.Add(_lblBody_4)
		Me.FraArmor.Controls.Add(_lblBody_5)
		Me.FraArmor.Controls.Add(_lblBody_6)
		Me.FraArmor.Controls.Add(_lblBody_7)
		Me.FraArmor.Controls.Add(_lblResPerc_0)
		Me.FraArmor.Controls.Add(_lblResPerc_1)
		Me.FraArmor.Controls.Add(_lblResPerc_2)
		Me.FraArmor.Controls.Add(_lblResPerc_3)
		Me.FraArmor.Controls.Add(_lblResPerc_4)
		Me.FraArmor.Controls.Add(_lblResPerc_5)
		Me.FraArmor.Controls.Add(_lblResPerc_6)
		Me.FraArmor.Controls.Add(_lblResPerc_7)
		Me.FraArmor.Controls.Add(_lblCovered_0)
		Me.FraArmor.Controls.Add(_lblCovered_1)
		Me.FraArmor.Controls.Add(_lblCovered_2)
		Me.FraArmor.Controls.Add(_lblCovered_3)
		Me.FraArmor.Controls.Add(_lblCovered_4)
		Me.FraArmor.Controls.Add(_lblCovered_5)
		Me.FraArmor.Controls.Add(_lblCovered_6)
		Me.FraArmor.Controls.Add(_lblCovered_7)
		Me.fraItems.Controls.Add(lstItems)
		Me.fraItems.Controls.Add(txtItemComments)
		Me.fraItems.Controls.Add(lblItemComments)
		Me.fraCompactView.Controls.Add(txtInfo)
		Me.fraCompactView.Controls.Add(picCreatureCompact)
		Me.ShapeContainer2.Shapes.Add(Shape1)
		Me.picCreatureCompact.Controls.Add(ShapeContainer2)
		Me.fraFullView.ResumeLayout(False)
		Me.fraStats.ResumeLayout(False)
		Me.fraFamily.ResumeLayout(False)
		Me.fraVices.ResumeLayout(False)
		Me.fraTriggers.ResumeLayout(False)
		Me.fraConvo.ResumeLayout(False)
		Me.fraSounds.ResumeLayout(False)
		Me.picCreature.ResumeLayout(False)
		Me.fraGenProps.ResumeLayout(False)
		Me.fraResistBonus.ResumeLayout(False)
		Me.FraArmor.ResumeLayout(False)
		Me.fraItems.ResumeLayout(False)
		Me.fraCompactView.ResumeLayout(False)
		Me.picCreatureCompact.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class