<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMonsProp
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
	Public WithEvents chkIsMale As System.Windows.Forms.CheckBox
	Public WithEvents chkIsInanimate As System.Windows.Forms.CheckBox
	Public WithEvents txtSkillPoints As System.Windows.Forms.TextBox
	Public WithEvents txtExperiencePoints As System.Windows.Forms.TextBox
	Public WithEvents txtLevel As System.Windows.Forms.TextBox
	Public WithEvents chkRequiredInTome As System.Windows.Forms.CheckBox
	Public WithEvents chkFriend As System.Windows.Forms.CheckBox
	Public WithEvents chkOnAdventure As System.Windows.Forms.CheckBox
	Public WithEvents txtRace As System.Windows.Forms.TextBox
	Public WithEvents chkGuard As System.Windows.Forms.CheckBox
	Public WithEvents chkAgressive As System.Windows.Forms.CheckBox
	Public WithEvents chkDMControlled As System.Windows.Forms.CheckBox
	Public WithEvents txtName As System.Windows.Forms.TextBox
	Public WithEvents txtComments As System.Windows.Forms.TextBox
	Public WithEvents _Label1_4 As System.Windows.Forms.Label
	Public WithEvents _Label1_17 As System.Windows.Forms.Label
	Public WithEvents _Label1_9 As System.Windows.Forms.Label
	Public WithEvents _lblRace_0 As System.Windows.Forms.Label
	Public WithEvents _lblName_1 As System.Windows.Forms.Label
	Public WithEvents _Label1_21 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents btnPortrait As System.Windows.Forms.Button
	Public WithEvents shpFace As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents picCreature As System.Windows.Forms.Panel
	Public WithEvents btnBrowseRight As System.Windows.Forms.Button
	Public WithEvents btnBrowseLeft As System.Windows.Forms.Button
	Public WithEvents btnBrowse As System.Windows.Forms.Button
	Public WithEvents fraMonsPic As System.Windows.Forms.GroupBox
	Public WithEvents _fraMonsProp_0 As System.Windows.Forms.Panel
	Public WithEvents btnDead As System.Windows.Forms.Button
	Public WithEvents picDead As System.Windows.Forms.PictureBox
	Public WithEvents chkWAV As System.Windows.Forms.CheckBox
	Public WithEvents btnPlayWAV As System.Windows.Forms.Button
	Public WithEvents btnBrowseWAV As System.Windows.Forms.Button
	Public WithEvents cmbWAV As System.Windows.Forms.ComboBox
	Public WithEvents Frame7 As System.Windows.Forms.GroupBox
	Public WithEvents lstWAV As System.Windows.Forms.ListBox
	Public WithEvents lblDead As System.Windows.Forms.Label
	Public WithEvents _lblWAV_0 As System.Windows.Forms.Label
	Public WithEvents _fraMonsProp_4 As System.Windows.Forms.Panel
	Public WithEvents btnLibrary As System.Windows.Forms.Button
	Public WithEvents btnPaste As System.Windows.Forms.Button
	Public WithEvents btnCopy As System.Windows.Forms.Button
	Public WithEvents lstThings As System.Windows.Forms.ListBox
	Public WithEvents btnEdit As System.Windows.Forms.Button
	Public WithEvents btnInsert As System.Windows.Forms.Button
	Public WithEvents btnCut As System.Windows.Forms.Button
	Public WithEvents lblAttached As System.Windows.Forms.Label
	Public WithEvents _fraMonsProp_3 As System.Windows.Forms.Panel
	Public WithEvents _cmbResistance_7 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbResistance_6 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbResistance_5 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbResistance_4 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbResistance_3 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbResistance_2 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbResistance_1 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbResistance_0 As System.Windows.Forms.ComboBox
	Public WithEvents _lblWeakness_7 As System.Windows.Forms.Label
	Public WithEvents _lblWeakness_6 As System.Windows.Forms.Label
	Public WithEvents _lblWeakness_5 As System.Windows.Forms.Label
	Public WithEvents _lblWeakness_4 As System.Windows.Forms.Label
	Public WithEvents _lblWeakness_3 As System.Windows.Forms.Label
	Public WithEvents _lblWeakness_2 As System.Windows.Forms.Label
	Public WithEvents _lblWeakness_1 As System.Windows.Forms.Label
	Public WithEvents _lblWeakness_0 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents cmbBodyType As System.Windows.Forms.ComboBox
	Public WithEvents _cmbArmor_7 As System.Windows.Forms.ComboBox
	Public WithEvents _txtAR_7 As System.Windows.Forms.TextBox
	Public WithEvents _cmbArmor_6 As System.Windows.Forms.ComboBox
	Public WithEvents _txtAR_6 As System.Windows.Forms.TextBox
	Public WithEvents _cmbArmor_5 As System.Windows.Forms.ComboBox
	Public WithEvents _txtAR_5 As System.Windows.Forms.TextBox
	Public WithEvents _cmbArmor_4 As System.Windows.Forms.ComboBox
	Public WithEvents _txtAR_4 As System.Windows.Forms.TextBox
	Public WithEvents _cmbArmor_3 As System.Windows.Forms.ComboBox
	Public WithEvents _txtAR_3 As System.Windows.Forms.TextBox
	Public WithEvents _cmbArmor_2 As System.Windows.Forms.ComboBox
	Public WithEvents _txtAR_2 As System.Windows.Forms.TextBox
	Public WithEvents _cmbArmor_1 As System.Windows.Forms.ComboBox
	Public WithEvents _txtAR_1 As System.Windows.Forms.TextBox
	Public WithEvents _cmbArmor_0 As System.Windows.Forms.ComboBox
	Public WithEvents _txtAR_0 As System.Windows.Forms.TextBox
	Public WithEvents _lblArmor_26 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_25 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_24 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_23 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_22 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_21 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_20 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_19 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_18 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_17 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_16 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_15 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_14 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_13 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_12 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_11 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_10 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_9 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_8 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_7 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_6 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_5 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_4 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_3 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_2 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_0 As System.Windows.Forms.Label
	Public WithEvents _lblArmor_1 As System.Windows.Forms.Label
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents _fraMonsProp_2 As System.Windows.Forms.Panel
	Public WithEvents txtHome As System.Windows.Forms.TextBox
	Public WithEvents cmbCombatRank As System.Windows.Forms.ComboBox
	Public WithEvents txtGreed As System.Windows.Forms.TextBox
	Public WithEvents txtLust As System.Windows.Forms.TextBox
	Public WithEvents txtLunacy As System.Windows.Forms.TextBox
	Public WithEvents txtPride As System.Windows.Forms.TextBox
	Public WithEvents txtWrath As System.Windows.Forms.TextBox
	Public WithEvents txtRevelry As System.Windows.Forms.TextBox
	Public WithEvents _Label1_16 As System.Windows.Forms.Label
	Public WithEvents _Label1_14 As System.Windows.Forms.Label
	Public WithEvents _Label1_13 As System.Windows.Forms.Label
	Public WithEvents _Label1_12 As System.Windows.Forms.Label
	Public WithEvents _Label1_11 As System.Windows.Forms.Label
	Public WithEvents _Label1_10 As System.Windows.Forms.Label
	Public WithEvents Frame9 As System.Windows.Forms.GroupBox
	Public WithEvents _chkFamily_9 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_7 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_8 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_6 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_3 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_2 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_1 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_0 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_5 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFamily_4 As System.Windows.Forms.CheckBox
	Public WithEvents Frame6 As System.Windows.Forms.GroupBox
	Public WithEvents _OptSize_4 As System.Windows.Forms.RadioButton
	Public WithEvents _OptSize_3 As System.Windows.Forms.RadioButton
	Public WithEvents _OptSize_2 As System.Windows.Forms.RadioButton
	Public WithEvents _OptSize_1 As System.Windows.Forms.RadioButton
	Public WithEvents _OptSize_0 As System.Windows.Forms.RadioButton
	Public WithEvents fraSize As System.Windows.Forms.GroupBox
	Public WithEvents txtEterniumMax As System.Windows.Forms.TextBox
	Public WithEvents txtActionPts As System.Windows.Forms.TextBox
	Public WithEvents txtMovement As System.Windows.Forms.TextBox
	Public WithEvents txtWill As System.Windows.Forms.TextBox
	Public WithEvents txtAgility As System.Windows.Forms.TextBox
	Public WithEvents txtStrength As System.Windows.Forms.TextBox
	Public WithEvents txtEternium As System.Windows.Forms.TextBox
	Public WithEvents txtHPNow As System.Windows.Forms.TextBox
	Public WithEvents txtHPMax As System.Windows.Forms.TextBox
	Public WithEvents _Label1_15 As System.Windows.Forms.Label
	Public WithEvents _Label1_8 As System.Windows.Forms.Label
	Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents _Label1_7 As System.Windows.Forms.Label
	Public WithEvents _Label1_6 As System.Windows.Forms.Label
	Public WithEvents _Label1_5 As System.Windows.Forms.Label
	Public WithEvents _Label1_3 As System.Windows.Forms.Label
	Public WithEvents _Label1_1 As System.Windows.Forms.Label
	Public WithEvents _Label1_2 As System.Windows.Forms.Label
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents lblHome As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents _fraMonsProp_1 As System.Windows.Forms.Panel
	Public WithEvents btnXP_Value As System.Windows.Forms.Button
	Public WithEvents picMask As System.Windows.Forms.PictureBox
	Public WithEvents picMons As System.Windows.Forms.PictureBox
	Public dlgFileOpen As System.Windows.Forms.OpenFileDialog
	Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents btnOk As System.Windows.Forms.Button
	Public WithEvents btnApply As System.Windows.Forms.Button
	Public WithEvents tabMonsProp As AxComctlLib.AxTabStrip
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents OptSize As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents chkFamily As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	Public WithEvents cmbArmor As Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray
	Public WithEvents cmbResistance As Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray
	Public WithEvents fraMonsProp As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
	Public WithEvents lblArmor As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblName As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblRace As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblWAV As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblWeakness As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents txtAR As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMonsProp))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me._fraMonsProp_0 = New System.Windows.Forms.Panel
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.chkIsMale = New System.Windows.Forms.CheckBox
		Me.chkIsInanimate = New System.Windows.Forms.CheckBox
		Me.txtSkillPoints = New System.Windows.Forms.TextBox
		Me.txtExperiencePoints = New System.Windows.Forms.TextBox
		Me.txtLevel = New System.Windows.Forms.TextBox
		Me.chkRequiredInTome = New System.Windows.Forms.CheckBox
		Me.chkFriend = New System.Windows.Forms.CheckBox
		Me.chkOnAdventure = New System.Windows.Forms.CheckBox
		Me.txtRace = New System.Windows.Forms.TextBox
		Me.chkGuard = New System.Windows.Forms.CheckBox
		Me.chkAgressive = New System.Windows.Forms.CheckBox
		Me.chkDMControlled = New System.Windows.Forms.CheckBox
		Me.txtName = New System.Windows.Forms.TextBox
		Me.txtComments = New System.Windows.Forms.TextBox
		Me._Label1_4 = New System.Windows.Forms.Label
		Me._Label1_17 = New System.Windows.Forms.Label
		Me._Label1_9 = New System.Windows.Forms.Label
		Me._lblRace_0 = New System.Windows.Forms.Label
		Me._lblName_1 = New System.Windows.Forms.Label
		Me._Label1_21 = New System.Windows.Forms.Label
		Me.fraMonsPic = New System.Windows.Forms.GroupBox
		Me.btnPortrait = New System.Windows.Forms.Button
		Me.picCreature = New System.Windows.Forms.Panel
		Me.shpFace = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.btnBrowseRight = New System.Windows.Forms.Button
		Me.btnBrowseLeft = New System.Windows.Forms.Button
		Me.btnBrowse = New System.Windows.Forms.Button
		Me._fraMonsProp_4 = New System.Windows.Forms.Panel
		Me.btnDead = New System.Windows.Forms.Button
		Me.picDead = New System.Windows.Forms.PictureBox
		Me.Frame7 = New System.Windows.Forms.GroupBox
		Me.chkWAV = New System.Windows.Forms.CheckBox
		Me.btnPlayWAV = New System.Windows.Forms.Button
		Me.btnBrowseWAV = New System.Windows.Forms.Button
		Me.cmbWAV = New System.Windows.Forms.ComboBox
		Me.lstWAV = New System.Windows.Forms.ListBox
		Me.lblDead = New System.Windows.Forms.Label
		Me._lblWAV_0 = New System.Windows.Forms.Label
		Me._fraMonsProp_3 = New System.Windows.Forms.Panel
		Me.btnLibrary = New System.Windows.Forms.Button
		Me.btnPaste = New System.Windows.Forms.Button
		Me.btnCopy = New System.Windows.Forms.Button
		Me.lstThings = New System.Windows.Forms.ListBox
		Me.btnEdit = New System.Windows.Forms.Button
		Me.btnInsert = New System.Windows.Forms.Button
		Me.btnCut = New System.Windows.Forms.Button
		Me.lblAttached = New System.Windows.Forms.Label
		Me._fraMonsProp_2 = New System.Windows.Forms.Panel
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me._cmbResistance_7 = New System.Windows.Forms.ComboBox
		Me._cmbResistance_6 = New System.Windows.Forms.ComboBox
		Me._cmbResistance_5 = New System.Windows.Forms.ComboBox
		Me._cmbResistance_4 = New System.Windows.Forms.ComboBox
		Me._cmbResistance_3 = New System.Windows.Forms.ComboBox
		Me._cmbResistance_2 = New System.Windows.Forms.ComboBox
		Me._cmbResistance_1 = New System.Windows.Forms.ComboBox
		Me._cmbResistance_0 = New System.Windows.Forms.ComboBox
		Me._lblWeakness_7 = New System.Windows.Forms.Label
		Me._lblWeakness_6 = New System.Windows.Forms.Label
		Me._lblWeakness_5 = New System.Windows.Forms.Label
		Me._lblWeakness_4 = New System.Windows.Forms.Label
		Me._lblWeakness_3 = New System.Windows.Forms.Label
		Me._lblWeakness_2 = New System.Windows.Forms.Label
		Me._lblWeakness_1 = New System.Windows.Forms.Label
		Me._lblWeakness_0 = New System.Windows.Forms.Label
		Me.Frame4 = New System.Windows.Forms.GroupBox
		Me.cmbBodyType = New System.Windows.Forms.ComboBox
		Me._cmbArmor_7 = New System.Windows.Forms.ComboBox
		Me._txtAR_7 = New System.Windows.Forms.TextBox
		Me._cmbArmor_6 = New System.Windows.Forms.ComboBox
		Me._txtAR_6 = New System.Windows.Forms.TextBox
		Me._cmbArmor_5 = New System.Windows.Forms.ComboBox
		Me._txtAR_5 = New System.Windows.Forms.TextBox
		Me._cmbArmor_4 = New System.Windows.Forms.ComboBox
		Me._txtAR_4 = New System.Windows.Forms.TextBox
		Me._cmbArmor_3 = New System.Windows.Forms.ComboBox
		Me._txtAR_3 = New System.Windows.Forms.TextBox
		Me._cmbArmor_2 = New System.Windows.Forms.ComboBox
		Me._txtAR_2 = New System.Windows.Forms.TextBox
		Me._cmbArmor_1 = New System.Windows.Forms.ComboBox
		Me._txtAR_1 = New System.Windows.Forms.TextBox
		Me._cmbArmor_0 = New System.Windows.Forms.ComboBox
		Me._txtAR_0 = New System.Windows.Forms.TextBox
		Me._lblArmor_26 = New System.Windows.Forms.Label
		Me._lblArmor_25 = New System.Windows.Forms.Label
		Me._lblArmor_24 = New System.Windows.Forms.Label
		Me._lblArmor_23 = New System.Windows.Forms.Label
		Me._lblArmor_22 = New System.Windows.Forms.Label
		Me._lblArmor_21 = New System.Windows.Forms.Label
		Me._lblArmor_20 = New System.Windows.Forms.Label
		Me._lblArmor_19 = New System.Windows.Forms.Label
		Me._lblArmor_18 = New System.Windows.Forms.Label
		Me._lblArmor_17 = New System.Windows.Forms.Label
		Me._lblArmor_16 = New System.Windows.Forms.Label
		Me._lblArmor_15 = New System.Windows.Forms.Label
		Me._lblArmor_14 = New System.Windows.Forms.Label
		Me._lblArmor_13 = New System.Windows.Forms.Label
		Me._lblArmor_12 = New System.Windows.Forms.Label
		Me._lblArmor_11 = New System.Windows.Forms.Label
		Me._lblArmor_10 = New System.Windows.Forms.Label
		Me._lblArmor_9 = New System.Windows.Forms.Label
		Me._lblArmor_8 = New System.Windows.Forms.Label
		Me._lblArmor_7 = New System.Windows.Forms.Label
		Me._lblArmor_6 = New System.Windows.Forms.Label
		Me._lblArmor_5 = New System.Windows.Forms.Label
		Me._lblArmor_4 = New System.Windows.Forms.Label
		Me._lblArmor_3 = New System.Windows.Forms.Label
		Me._lblArmor_2 = New System.Windows.Forms.Label
		Me._lblArmor_0 = New System.Windows.Forms.Label
		Me._lblArmor_1 = New System.Windows.Forms.Label
		Me._fraMonsProp_1 = New System.Windows.Forms.Panel
		Me.txtHome = New System.Windows.Forms.TextBox
		Me.cmbCombatRank = New System.Windows.Forms.ComboBox
		Me.Frame9 = New System.Windows.Forms.GroupBox
		Me.txtGreed = New System.Windows.Forms.TextBox
		Me.txtLust = New System.Windows.Forms.TextBox
		Me.txtLunacy = New System.Windows.Forms.TextBox
		Me.txtPride = New System.Windows.Forms.TextBox
		Me.txtWrath = New System.Windows.Forms.TextBox
		Me.txtRevelry = New System.Windows.Forms.TextBox
		Me._Label1_16 = New System.Windows.Forms.Label
		Me._Label1_14 = New System.Windows.Forms.Label
		Me._Label1_13 = New System.Windows.Forms.Label
		Me._Label1_12 = New System.Windows.Forms.Label
		Me._Label1_11 = New System.Windows.Forms.Label
		Me._Label1_10 = New System.Windows.Forms.Label
		Me.Frame6 = New System.Windows.Forms.GroupBox
		Me._chkFamily_9 = New System.Windows.Forms.CheckBox
		Me._chkFamily_7 = New System.Windows.Forms.CheckBox
		Me._chkFamily_8 = New System.Windows.Forms.CheckBox
		Me._chkFamily_6 = New System.Windows.Forms.CheckBox
		Me._chkFamily_3 = New System.Windows.Forms.CheckBox
		Me._chkFamily_2 = New System.Windows.Forms.CheckBox
		Me._chkFamily_1 = New System.Windows.Forms.CheckBox
		Me._chkFamily_0 = New System.Windows.Forms.CheckBox
		Me._chkFamily_5 = New System.Windows.Forms.CheckBox
		Me._chkFamily_4 = New System.Windows.Forms.CheckBox
		Me.fraSize = New System.Windows.Forms.GroupBox
		Me._OptSize_4 = New System.Windows.Forms.RadioButton
		Me._OptSize_3 = New System.Windows.Forms.RadioButton
		Me._OptSize_2 = New System.Windows.Forms.RadioButton
		Me._OptSize_1 = New System.Windows.Forms.RadioButton
		Me._OptSize_0 = New System.Windows.Forms.RadioButton
		Me.Frame5 = New System.Windows.Forms.GroupBox
		Me.txtEterniumMax = New System.Windows.Forms.TextBox
		Me.txtActionPts = New System.Windows.Forms.TextBox
		Me.txtMovement = New System.Windows.Forms.TextBox
		Me.txtWill = New System.Windows.Forms.TextBox
		Me.txtAgility = New System.Windows.Forms.TextBox
		Me.txtStrength = New System.Windows.Forms.TextBox
		Me.txtEternium = New System.Windows.Forms.TextBox
		Me.txtHPNow = New System.Windows.Forms.TextBox
		Me.txtHPMax = New System.Windows.Forms.TextBox
		Me._Label1_15 = New System.Windows.Forms.Label
		Me._Label1_8 = New System.Windows.Forms.Label
		Me._Label1_0 = New System.Windows.Forms.Label
		Me._Label1_7 = New System.Windows.Forms.Label
		Me._Label1_6 = New System.Windows.Forms.Label
		Me._Label1_5 = New System.Windows.Forms.Label
		Me._Label1_3 = New System.Windows.Forms.Label
		Me._Label1_1 = New System.Windows.Forms.Label
		Me._Label1_2 = New System.Windows.Forms.Label
		Me.lblHome = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.btnXP_Value = New System.Windows.Forms.Button
		Me.picMask = New System.Windows.Forms.PictureBox
		Me.picMons = New System.Windows.Forms.PictureBox
		Me.dlgFileOpen = New System.Windows.Forms.OpenFileDialog
		Me.btnCancel = New System.Windows.Forms.Button
		Me.btnOk = New System.Windows.Forms.Button
		Me.btnApply = New System.Windows.Forms.Button
		Me.tabMonsProp = New AxComctlLib.AxTabStrip
		Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.OptSize = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.chkFamily = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(components)
		Me.cmbArmor = New Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray(components)
		Me.cmbResistance = New Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray(components)
		Me.fraMonsProp = New Microsoft.VisualBasic.Compatibility.VB6.PanelArray(components)
		Me.lblArmor = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblName = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblRace = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblWAV = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblWeakness = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.txtAR = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me._fraMonsProp_0.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.fraMonsPic.SuspendLayout()
		Me.picCreature.SuspendLayout()
		Me._fraMonsProp_4.SuspendLayout()
		Me.Frame7.SuspendLayout()
		Me._fraMonsProp_3.SuspendLayout()
		Me._fraMonsProp_2.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.Frame4.SuspendLayout()
		Me._fraMonsProp_1.SuspendLayout()
		Me.Frame9.SuspendLayout()
		Me.Frame6.SuspendLayout()
		Me.fraSize.SuspendLayout()
		Me.Frame5.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tabMonsProp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.OptSize, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.chkFamily, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmbArmor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmbResistance, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.fraMonsProp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblArmor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblRace, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblWAV, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblWeakness, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtAR, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Creature Properties"
		Me.ClientSize = New System.Drawing.Size(392, 283)
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
		Me.Name = "frmMonsProp"
		Me._fraMonsProp_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._fraMonsProp_0.Size = New System.Drawing.Size(377, 215)
		Me._fraMonsProp_0.Location = New System.Drawing.Point(8, 28)
		Me._fraMonsProp_0.TabIndex = 4
		Me._fraMonsProp_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraMonsProp_0.BackColor = System.Drawing.SystemColors.Control
		Me._fraMonsProp_0.Enabled = True
		Me._fraMonsProp_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraMonsProp_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._fraMonsProp_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraMonsProp_0.Visible = True
		Me._fraMonsProp_0.Name = "_fraMonsProp_0"
		Me.Frame1.Text = "Description"
		Me.Frame1.Size = New System.Drawing.Size(233, 211)
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
		Me.chkIsMale.Text = "Male?"
		Me.chkIsMale.Size = New System.Drawing.Size(49, 13)
		Me.chkIsMale.Location = New System.Drawing.Point(180, 18)
		Me.chkIsMale.TabIndex = 155
		Me.chkIsMale.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkIsMale.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkIsMale.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkIsMale.BackColor = System.Drawing.SystemColors.Control
		Me.chkIsMale.CausesValidation = True
		Me.chkIsMale.Enabled = True
		Me.chkIsMale.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkIsMale.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkIsMale.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkIsMale.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkIsMale.TabStop = True
		Me.chkIsMale.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkIsMale.Visible = True
		Me.chkIsMale.Name = "chkIsMale"
		Me.chkIsInanimate.Text = "Inanimate?"
		Me.chkIsInanimate.Size = New System.Drawing.Size(83, 13)
		Me.chkIsInanimate.Location = New System.Drawing.Point(8, 156)
		Me.chkIsInanimate.TabIndex = 149
		Me.chkIsInanimate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkIsInanimate.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkIsInanimate.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkIsInanimate.BackColor = System.Drawing.SystemColors.Control
		Me.chkIsInanimate.CausesValidation = True
		Me.chkIsInanimate.Enabled = True
		Me.chkIsInanimate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkIsInanimate.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkIsInanimate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkIsInanimate.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkIsInanimate.TabStop = True
		Me.chkIsInanimate.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkIsInanimate.Visible = True
		Me.chkIsInanimate.Name = "chkIsInanimate"
		Me.txtSkillPoints.AutoSize = False
		Me.txtSkillPoints.Size = New System.Drawing.Size(25, 19)
		Me.txtSkillPoints.Location = New System.Drawing.Point(200, 61)
		Me.txtSkillPoints.Maxlength = 3
		Me.txtSkillPoints.TabIndex = 78
		Me.txtSkillPoints.Text = "999"
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
		Me.txtSkillPoints.Visible = True
		Me.txtSkillPoints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSkillPoints.Name = "txtSkillPoints"
		Me.txtExperiencePoints.AutoSize = False
		Me.txtExperiencePoints.Size = New System.Drawing.Size(49, 19)
		Me.txtExperiencePoints.Location = New System.Drawing.Point(109, 61)
		Me.txtExperiencePoints.Maxlength = 7
		Me.txtExperiencePoints.TabIndex = 76
		Me.txtExperiencePoints.Text = "99999"
		Me.txtExperiencePoints.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtExperiencePoints.AcceptsReturn = True
		Me.txtExperiencePoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtExperiencePoints.BackColor = System.Drawing.SystemColors.Window
		Me.txtExperiencePoints.CausesValidation = True
		Me.txtExperiencePoints.Enabled = True
		Me.txtExperiencePoints.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtExperiencePoints.HideSelection = True
		Me.txtExperiencePoints.ReadOnly = False
		Me.txtExperiencePoints.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtExperiencePoints.MultiLine = False
		Me.txtExperiencePoints.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtExperiencePoints.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtExperiencePoints.TabStop = True
		Me.txtExperiencePoints.Visible = True
		Me.txtExperiencePoints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtExperiencePoints.Name = "txtExperiencePoints"
		Me.txtLevel.AutoSize = False
		Me.txtLevel.Size = New System.Drawing.Size(25, 19)
		Me.txtLevel.Location = New System.Drawing.Point(45, 61)
		Me.txtLevel.Maxlength = 3
		Me.txtLevel.TabIndex = 74
		Me.txtLevel.Text = "255"
		Me.txtLevel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLevel.AcceptsReturn = True
		Me.txtLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtLevel.BackColor = System.Drawing.SystemColors.Window
		Me.txtLevel.CausesValidation = True
		Me.txtLevel.Enabled = True
		Me.txtLevel.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLevel.HideSelection = True
		Me.txtLevel.ReadOnly = False
		Me.txtLevel.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLevel.MultiLine = False
		Me.txtLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLevel.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtLevel.TabStop = True
		Me.txtLevel.Visible = True
		Me.txtLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtLevel.Name = "txtLevel"
		Me.chkRequiredInTome.Text = "Locked in Tome?"
		Me.chkRequiredInTome.Size = New System.Drawing.Size(103, 13)
		Me.chkRequiredInTome.Location = New System.Drawing.Point(104, 189)
		Me.chkRequiredInTome.TabIndex = 73
		Me.chkRequiredInTome.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkRequiredInTome.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkRequiredInTome.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkRequiredInTome.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkRequiredInTome.BackColor = System.Drawing.SystemColors.Control
		Me.chkRequiredInTome.CausesValidation = True
		Me.chkRequiredInTome.Enabled = True
		Me.chkRequiredInTome.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkRequiredInTome.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkRequiredInTome.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkRequiredInTome.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkRequiredInTome.TabStop = True
		Me.chkRequiredInTome.Visible = True
		Me.chkRequiredInTome.Name = "chkRequiredInTome"
		Me.chkFriend.Text = "Friendly?"
		Me.chkFriend.Size = New System.Drawing.Size(63, 13)
		Me.chkFriend.Location = New System.Drawing.Point(8, 189)
		Me.chkFriend.TabIndex = 72
		Me.chkFriend.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkFriend.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkFriend.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkFriend.BackColor = System.Drawing.SystemColors.Control
		Me.chkFriend.CausesValidation = True
		Me.chkFriend.Enabled = True
		Me.chkFriend.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkFriend.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkFriend.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkFriend.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkFriend.TabStop = True
		Me.chkFriend.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkFriend.Visible = True
		Me.chkFriend.Name = "chkFriend"
		Me.chkOnAdventure.Text = "Not in Roster?"
		Me.chkOnAdventure.Size = New System.Drawing.Size(89, 13)
		Me.chkOnAdventure.Location = New System.Drawing.Point(52, 18)
		Me.chkOnAdventure.TabIndex = 71
		Me.chkOnAdventure.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkOnAdventure.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkOnAdventure.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkOnAdventure.BackColor = System.Drawing.SystemColors.Control
		Me.chkOnAdventure.CausesValidation = True
		Me.chkOnAdventure.Enabled = True
		Me.chkOnAdventure.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkOnAdventure.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkOnAdventure.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkOnAdventure.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkOnAdventure.TabStop = True
		Me.chkOnAdventure.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkOnAdventure.Visible = True
		Me.chkOnAdventure.Name = "chkOnAdventure"
		Me.txtRace.AutoSize = False
		Me.txtRace.Size = New System.Drawing.Size(81, 19)
		Me.txtRace.Location = New System.Drawing.Point(144, 34)
		Me.txtRace.TabIndex = 58
		Me.txtRace.Text = "123456789012345678901234567890"
		Me.txtRace.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRace.AcceptsReturn = True
		Me.txtRace.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtRace.BackColor = System.Drawing.SystemColors.Window
		Me.txtRace.CausesValidation = True
		Me.txtRace.Enabled = True
		Me.txtRace.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtRace.HideSelection = True
		Me.txtRace.ReadOnly = False
		Me.txtRace.Maxlength = 0
		Me.txtRace.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtRace.MultiLine = False
		Me.txtRace.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtRace.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtRace.TabStop = True
		Me.txtRace.Visible = True
		Me.txtRace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtRace.Name = "txtRace"
		Me.chkGuard.Text = "Prevent Search?"
		Me.chkGuard.Size = New System.Drawing.Size(115, 13)
		Me.chkGuard.Location = New System.Drawing.Point(104, 173)
		Me.chkGuard.TabIndex = 57
		Me.chkGuard.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkGuard.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkGuard.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkGuard.BackColor = System.Drawing.SystemColors.Control
		Me.chkGuard.CausesValidation = True
		Me.chkGuard.Enabled = True
		Me.chkGuard.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkGuard.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkGuard.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkGuard.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkGuard.TabStop = True
		Me.chkGuard.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkGuard.Visible = True
		Me.chkGuard.Name = "chkGuard"
		Me.chkAgressive.Text = "Can't Ignore?"
		Me.chkAgressive.Size = New System.Drawing.Size(83, 13)
		Me.chkAgressive.Location = New System.Drawing.Point(8, 173)
		Me.chkAgressive.TabIndex = 56
		Me.chkAgressive.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkAgressive.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkAgressive.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkAgressive.BackColor = System.Drawing.SystemColors.Control
		Me.chkAgressive.CausesValidation = True
		Me.chkAgressive.Enabled = True
		Me.chkAgressive.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkAgressive.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkAgressive.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkAgressive.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkAgressive.TabStop = True
		Me.chkAgressive.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkAgressive.Visible = True
		Me.chkAgressive.Name = "chkAgressive"
		Me.chkDMControlled.Text = "Computer Controlled?"
		Me.chkDMControlled.Size = New System.Drawing.Size(121, 13)
		Me.chkDMControlled.Location = New System.Drawing.Point(104, 156)
		Me.chkDMControlled.TabIndex = 53
		Me.chkDMControlled.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkDMControlled.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkDMControlled.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkDMControlled.BackColor = System.Drawing.SystemColors.Control
		Me.chkDMControlled.CausesValidation = True
		Me.chkDMControlled.Enabled = True
		Me.chkDMControlled.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkDMControlled.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkDMControlled.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkDMControlled.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkDMControlled.TabStop = True
		Me.chkDMControlled.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkDMControlled.Visible = True
		Me.chkDMControlled.Name = "chkDMControlled"
		Me.txtName.AutoSize = False
		Me.txtName.Size = New System.Drawing.Size(129, 19)
		Me.txtName.Location = New System.Drawing.Point(8, 34)
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
		Me.txtComments.AutoSize = False
		Me.txtComments.Size = New System.Drawing.Size(217, 47)
		Me.txtComments.Location = New System.Drawing.Point(8, 102)
		Me.txtComments.MultiLine = True
		Me.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtComments.TabIndex = 6
		Me.txtComments.Text = "Here is some" & Chr(13) & Chr(10) & "test" & Chr(13) & Chr(10) & "about this creature" & Chr(13) & Chr(10) & "so tell me" & Chr(13) & Chr(10)
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
		Me._Label1_4.BackColor = System.Drawing.Color.Transparent
		Me._Label1_4.Text = "SkillPts"
		Me._Label1_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_4.Size = New System.Drawing.Size(37, 13)
		Me._Label1_4.Location = New System.Drawing.Point(161, 64)
		Me._Label1_4.TabIndex = 79
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
		Me._Label1_17.Location = New System.Drawing.Point(73, 64)
		Me._Label1_17.TabIndex = 77
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
		Me._Label1_9.BackColor = System.Drawing.Color.Transparent
		Me._Label1_9.Text = "ExpLvl"
		Me._Label1_9.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_9.Size = New System.Drawing.Size(37, 13)
		Me._Label1_9.Location = New System.Drawing.Point(9, 64)
		Me._Label1_9.TabIndex = 75
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
		Me._lblRace_0.Text = "Race"
		Me._lblRace_0.Size = New System.Drawing.Size(41, 13)
		Me._lblRace_0.Location = New System.Drawing.Point(144, 18)
		Me._lblRace_0.TabIndex = 59
		Me._lblRace_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblRace_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblRace_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblRace_0.Enabled = True
		Me._lblRace_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblRace_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblRace_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblRace_0.UseMnemonic = True
		Me._lblRace_0.Visible = True
		Me._lblRace_0.AutoSize = False
		Me._lblRace_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblRace_0.Name = "_lblRace_0"
		Me._lblName_1.Text = "Name"
		Me._lblName_1.Size = New System.Drawing.Size(41, 13)
		Me._lblName_1.Location = New System.Drawing.Point(9, 18)
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
		Me._Label1_21.Text = "Comments"
		Me._Label1_21.Size = New System.Drawing.Size(81, 13)
		Me._Label1_21.Location = New System.Drawing.Point(8, 86)
		Me._Label1_21.TabIndex = 8
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
		Me.fraMonsPic.Text = "Picture"
		Me.fraMonsPic.Size = New System.Drawing.Size(129, 211)
		Me.fraMonsPic.Location = New System.Drawing.Point(244, 0)
		Me.fraMonsPic.TabIndex = 38
		Me.fraMonsPic.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraMonsPic.BackColor = System.Drawing.SystemColors.Control
		Me.fraMonsPic.Enabled = True
		Me.fraMonsPic.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraMonsPic.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraMonsPic.Visible = True
		Me.fraMonsPic.Padding = New System.Windows.Forms.Padding(0)
		Me.fraMonsPic.Name = "fraMonsPic"
		Me.btnPortrait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnPortrait.BackColor = System.Drawing.SystemColors.Control
		Me.btnPortrait.Text = "Portrait"
		Me.btnPortrait.Size = New System.Drawing.Size(109, 21)
		Me.btnPortrait.Location = New System.Drawing.Point(11, 19)
		Me.btnPortrait.TabIndex = 156
		Me.btnPortrait.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPortrait.CausesValidation = True
		Me.btnPortrait.Enabled = True
		Me.btnPortrait.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnPortrait.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnPortrait.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnPortrait.TabStop = True
		Me.btnPortrait.Name = "btnPortrait"
		Me.picCreature.BackColor = System.Drawing.Color.FromARGB(128, 128, 128)
		Me.picCreature.Size = New System.Drawing.Size(109, 137)
		Me.picCreature.Location = New System.Drawing.Point(11, 42)
		Me.picCreature.TabIndex = 39
		Me.picCreature.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picCreature.Dock = System.Windows.Forms.DockStyle.None
		Me.picCreature.CausesValidation = True
		Me.picCreature.Enabled = True
		Me.picCreature.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picCreature.Cursor = System.Windows.Forms.Cursors.Default
		Me.picCreature.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picCreature.TabStop = True
		Me.picCreature.Visible = True
		Me.picCreature.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picCreature.Name = "picCreature"
		Me.shpFace.BorderColor = System.Drawing.Color.Yellow
		Me.shpFace.BorderWidth = 2
		Me.shpFace.Size = New System.Drawing.Size(25, 32)
		Me.shpFace.Location = New System.Drawing.Point(32, 24)
		Me.shpFace.BackColor = System.Drawing.SystemColors.Window
		Me.shpFace.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.shpFace.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.shpFace.FillColor = System.Drawing.Color.Black
		Me.shpFace.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.shpFace.Visible = True
		Me.shpFace.Name = "shpFace"
		Me.btnBrowseRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnBrowseRight.Text = ">"
		Me.btnBrowseRight.Size = New System.Drawing.Size(19, 21)
		Me.btnBrowseRight.Location = New System.Drawing.Point(102, 183)
		Me.btnBrowseRight.TabIndex = 154
		Me.btnBrowseRight.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBrowseRight.BackColor = System.Drawing.SystemColors.Control
		Me.btnBrowseRight.CausesValidation = True
		Me.btnBrowseRight.Enabled = True
		Me.btnBrowseRight.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnBrowseRight.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnBrowseRight.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnBrowseRight.TabStop = True
		Me.btnBrowseRight.Name = "btnBrowseRight"
		Me.btnBrowseLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnBrowseLeft.Text = "<"
		Me.btnBrowseLeft.Size = New System.Drawing.Size(19, 21)
		Me.btnBrowseLeft.Location = New System.Drawing.Point(8, 183)
		Me.btnBrowseLeft.TabIndex = 153
		Me.btnBrowseLeft.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBrowseLeft.BackColor = System.Drawing.SystemColors.Control
		Me.btnBrowseLeft.CausesValidation = True
		Me.btnBrowseLeft.Enabled = True
		Me.btnBrowseLeft.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnBrowseLeft.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnBrowseLeft.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnBrowseLeft.TabStop = True
		Me.btnBrowseLeft.Name = "btnBrowseLeft"
		Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnBrowse.BackColor = System.Drawing.SystemColors.Control
		Me.btnBrowse.Text = "Browse..."
		Me.btnBrowse.Size = New System.Drawing.Size(73, 21)
		Me.btnBrowse.Location = New System.Drawing.Point(28, 184)
		Me.btnBrowse.TabIndex = 152
		Me.btnBrowse.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBrowse.CausesValidation = True
		Me.btnBrowse.Enabled = True
		Me.btnBrowse.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnBrowse.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnBrowse.TabStop = True
		Me.btnBrowse.Name = "btnBrowse"
		Me._fraMonsProp_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._fraMonsProp_4.Size = New System.Drawing.Size(373, 215)
		Me._fraMonsProp_4.Location = New System.Drawing.Point(8, 28)
		Me._fraMonsProp_4.TabIndex = 63
		Me._fraMonsProp_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraMonsProp_4.BackColor = System.Drawing.SystemColors.Control
		Me._fraMonsProp_4.Enabled = True
		Me._fraMonsProp_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraMonsProp_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._fraMonsProp_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraMonsProp_4.Visible = True
		Me._fraMonsProp_4.Name = "_fraMonsProp_4"
		Me.btnDead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnDead.Text = "Change picture when dead"
		Me.btnDead.Size = New System.Drawing.Size(73, 41)
		Me.btnDead.Location = New System.Drawing.Point(298, 152)
		Me.btnDead.TabIndex = 171
		Me.btnDead.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDead.BackColor = System.Drawing.SystemColors.Control
		Me.btnDead.CausesValidation = True
		Me.btnDead.Enabled = True
		Me.btnDead.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnDead.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnDead.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnDead.TabStop = True
		Me.btnDead.Name = "btnDead"
		Me.picDead.Size = New System.Drawing.Size(81, 89)
		Me.picDead.Location = New System.Drawing.Point(290, 56)
		Me.picDead.TabIndex = 169
		Me.picDead.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picDead.Dock = System.Windows.Forms.DockStyle.None
		Me.picDead.BackColor = System.Drawing.SystemColors.Control
		Me.picDead.CausesValidation = True
		Me.picDead.Enabled = True
		Me.picDead.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picDead.Cursor = System.Windows.Forms.Cursors.Default
		Me.picDead.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picDead.TabStop = True
		Me.picDead.Visible = True
		Me.picDead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picDead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picDead.Name = "picDead"
		Me.Frame7.Text = "Sounds"
		Me.Frame7.Size = New System.Drawing.Size(285, 81)
		Me.Frame7.Location = New System.Drawing.Point(4, 112)
		Me.Frame7.TabIndex = 66
		Me.Frame7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame7.BackColor = System.Drawing.SystemColors.Control
		Me.Frame7.Enabled = True
		Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame7.Visible = True
		Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame7.Name = "Frame7"
		Me.chkWAV.Text = "One Time Only?"
		Me.chkWAV.Size = New System.Drawing.Size(101, 13)
		Me.chkWAV.Location = New System.Drawing.Point(176, 52)
		Me.chkWAV.TabIndex = 70
		Me.chkWAV.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkWAV.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkWAV.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkWAV.BackColor = System.Drawing.SystemColors.Control
		Me.chkWAV.CausesValidation = True
		Me.chkWAV.Enabled = True
		Me.chkWAV.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkWAV.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkWAV.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkWAV.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkWAV.TabStop = True
		Me.chkWAV.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkWAV.Visible = True
		Me.chkWAV.Name = "chkWAV"
		Me.btnPlayWAV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnPlayWAV.BackColor = System.Drawing.SystemColors.Control
		Me.btnPlayWAV.Text = "Play"
		Me.btnPlayWAV.Size = New System.Drawing.Size(73, 21)
		Me.btnPlayWAV.Location = New System.Drawing.Point(92, 48)
		Me.btnPlayWAV.TabIndex = 69
		Me.btnPlayWAV.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPlayWAV.CausesValidation = True
		Me.btnPlayWAV.Enabled = True
		Me.btnPlayWAV.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnPlayWAV.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnPlayWAV.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnPlayWAV.TabStop = True
		Me.btnPlayWAV.Name = "btnPlayWAV"
		Me.btnBrowseWAV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnBrowseWAV.BackColor = System.Drawing.SystemColors.Control
		Me.btnBrowseWAV.Text = "Browse..."
		Me.btnBrowseWAV.Size = New System.Drawing.Size(73, 21)
		Me.btnBrowseWAV.Location = New System.Drawing.Point(8, 48)
		Me.btnBrowseWAV.TabIndex = 68
		Me.btnBrowseWAV.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBrowseWAV.CausesValidation = True
		Me.btnBrowseWAV.Enabled = True
		Me.btnBrowseWAV.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnBrowseWAV.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnBrowseWAV.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnBrowseWAV.TabStop = True
		Me.btnBrowseWAV.Name = "btnBrowseWAV"
		Me.cmbWAV.Size = New System.Drawing.Size(269, 21)
		Me.cmbWAV.Location = New System.Drawing.Point(8, 16)
		Me.cmbWAV.TabIndex = 67
		Me.cmbWAV.Text = "Combo1"
		Me.cmbWAV.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbWAV.BackColor = System.Drawing.SystemColors.Window
		Me.cmbWAV.CausesValidation = True
		Me.cmbWAV.Enabled = True
		Me.cmbWAV.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbWAV.IntegralHeight = True
		Me.cmbWAV.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbWAV.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbWAV.Sorted = False
		Me.cmbWAV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cmbWAV.TabStop = True
		Me.cmbWAV.Visible = True
		Me.cmbWAV.Name = "cmbWAV"
		Me.lstWAV.Size = New System.Drawing.Size(285, 85)
		Me.lstWAV.Location = New System.Drawing.Point(4, 24)
		Me.lstWAV.Items.AddRange(New Object(){"When Move in Combat", "When Attack in Combat", "When Hit by an Attack and Damaged", "When Die"})
		Me.lstWAV.TabIndex = 65
		Me.lstWAV.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstWAV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstWAV.BackColor = System.Drawing.SystemColors.Window
		Me.lstWAV.CausesValidation = True
		Me.lstWAV.Enabled = True
		Me.lstWAV.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstWAV.IntegralHeight = True
		Me.lstWAV.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstWAV.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstWAV.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstWAV.Sorted = False
		Me.lstWAV.TabStop = True
		Me.lstWAV.Visible = True
		Me.lstWAV.MultiColumn = False
		Me.lstWAV.Name = "lstWAV"
		Me.lblDead.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblDead.Text = "Picture when dead"
		Me.lblDead.Size = New System.Drawing.Size(73, 33)
		Me.lblDead.Location = New System.Drawing.Point(296, 24)
		Me.lblDead.TabIndex = 170
		Me.lblDead.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDead.BackColor = System.Drawing.SystemColors.Control
		Me.lblDead.Enabled = True
		Me.lblDead.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDead.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDead.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDead.UseMnemonic = True
		Me.lblDead.Visible = True
		Me.lblDead.AutoSize = False
		Me.lblDead.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDead.Name = "lblDead"
		Me._lblWAV_0.Text = "Events"
		Me._lblWAV_0.Size = New System.Drawing.Size(41, 13)
		Me._lblWAV_0.Location = New System.Drawing.Point(4, 4)
		Me._lblWAV_0.TabIndex = 64
		Me._lblWAV_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblWAV_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblWAV_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblWAV_0.Enabled = True
		Me._lblWAV_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblWAV_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblWAV_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblWAV_0.UseMnemonic = True
		Me._lblWAV_0.Visible = True
		Me._lblWAV_0.AutoSize = False
		Me._lblWAV_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblWAV_0.Name = "_lblWAV_0"
		Me._fraMonsProp_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._fraMonsProp_3.Size = New System.Drawing.Size(373, 215)
		Me._fraMonsProp_3.Location = New System.Drawing.Point(8, 28)
		Me._fraMonsProp_3.TabIndex = 27
		Me._fraMonsProp_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraMonsProp_3.BackColor = System.Drawing.SystemColors.Control
		Me._fraMonsProp_3.Enabled = True
		Me._fraMonsProp_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraMonsProp_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._fraMonsProp_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraMonsProp_3.Visible = True
		Me._fraMonsProp_3.Name = "_fraMonsProp_3"
		Me.btnLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnLibrary.Text = "Insert from library"
		Me.btnLibrary.Size = New System.Drawing.Size(73, 49)
		Me.btnLibrary.Location = New System.Drawing.Point(296, 48)
		Me.btnLibrary.TabIndex = 168
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
		Me.btnPaste.Location = New System.Drawing.Point(296, 184)
		Me.btnPaste.TabIndex = 55
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
		Me.btnCopy.Location = New System.Drawing.Point(296, 160)
		Me.btnCopy.TabIndex = 54
		Me.btnCopy.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCopy.CausesValidation = True
		Me.btnCopy.Enabled = True
		Me.btnCopy.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCopy.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCopy.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCopy.TabStop = True
		Me.btnCopy.Name = "btnCopy"
		Me.lstThings.Size = New System.Drawing.Size(289, 189)
		Me.lstThings.Location = New System.Drawing.Point(4, 24)
		Me.lstThings.TabIndex = 31
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
		Me.btnEdit.Location = New System.Drawing.Point(296, 99)
		Me.btnEdit.TabIndex = 30
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
		Me.btnInsert.TabIndex = 29
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
		Me.btnCut.Location = New System.Drawing.Point(296, 136)
		Me.btnCut.TabIndex = 28
		Me.btnCut.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCut.CausesValidation = True
		Me.btnCut.Enabled = True
		Me.btnCut.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCut.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCut.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCut.TabStop = True
		Me.btnCut.Name = "btnCut"
		Me.lblAttached.Text = "Events Attached to Creature"
		Me.lblAttached.Size = New System.Drawing.Size(289, 13)
		Me.lblAttached.Location = New System.Drawing.Point(4, 4)
		Me.lblAttached.TabIndex = 32
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
		Me._fraMonsProp_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._fraMonsProp_2.Text = "Frame3"
		Me._fraMonsProp_2.Size = New System.Drawing.Size(377, 217)
		Me._fraMonsProp_2.Location = New System.Drawing.Point(8, 28)
		Me._fraMonsProp_2.TabIndex = 10
		Me._fraMonsProp_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraMonsProp_2.BackColor = System.Drawing.SystemColors.Control
		Me._fraMonsProp_2.Enabled = True
		Me._fraMonsProp_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraMonsProp_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._fraMonsProp_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraMonsProp_2.Visible = True
		Me._fraMonsProp_2.Name = "_fraMonsProp_2"
		Me.Frame3.Text = "Resistance Bonus"
		Me.Frame3.Size = New System.Drawing.Size(153, 215)
		Me.Frame3.Location = New System.Drawing.Point(222, 0)
		Me.Frame3.TabIndex = 124
		Me.Frame3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Me._cmbResistance_7.Size = New System.Drawing.Size(101, 21)
		Me._cmbResistance_7.Location = New System.Drawing.Point(44, 178)
		Me._cmbResistance_7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbResistance_7.TabIndex = 132
		Me._cmbResistance_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbResistance_7.BackColor = System.Drawing.SystemColors.Window
		Me._cmbResistance_7.CausesValidation = True
		Me._cmbResistance_7.Enabled = True
		Me._cmbResistance_7.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbResistance_7.IntegralHeight = True
		Me._cmbResistance_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbResistance_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbResistance_7.Sorted = False
		Me._cmbResistance_7.TabStop = True
		Me._cmbResistance_7.Visible = True
		Me._cmbResistance_7.Name = "_cmbResistance_7"
		Me._cmbResistance_6.Size = New System.Drawing.Size(101, 21)
		Me._cmbResistance_6.Location = New System.Drawing.Point(44, 156)
		Me._cmbResistance_6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbResistance_6.TabIndex = 131
		Me._cmbResistance_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbResistance_6.BackColor = System.Drawing.SystemColors.Window
		Me._cmbResistance_6.CausesValidation = True
		Me._cmbResistance_6.Enabled = True
		Me._cmbResistance_6.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbResistance_6.IntegralHeight = True
		Me._cmbResistance_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbResistance_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbResistance_6.Sorted = False
		Me._cmbResistance_6.TabStop = True
		Me._cmbResistance_6.Visible = True
		Me._cmbResistance_6.Name = "_cmbResistance_6"
		Me._cmbResistance_5.Size = New System.Drawing.Size(101, 21)
		Me._cmbResistance_5.Location = New System.Drawing.Point(44, 134)
		Me._cmbResistance_5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbResistance_5.TabIndex = 130
		Me._cmbResistance_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbResistance_5.BackColor = System.Drawing.SystemColors.Window
		Me._cmbResistance_5.CausesValidation = True
		Me._cmbResistance_5.Enabled = True
		Me._cmbResistance_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbResistance_5.IntegralHeight = True
		Me._cmbResistance_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbResistance_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbResistance_5.Sorted = False
		Me._cmbResistance_5.TabStop = True
		Me._cmbResistance_5.Visible = True
		Me._cmbResistance_5.Name = "_cmbResistance_5"
		Me._cmbResistance_4.Size = New System.Drawing.Size(101, 21)
		Me._cmbResistance_4.Location = New System.Drawing.Point(44, 112)
		Me._cmbResistance_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbResistance_4.TabIndex = 129
		Me._cmbResistance_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbResistance_4.BackColor = System.Drawing.SystemColors.Window
		Me._cmbResistance_4.CausesValidation = True
		Me._cmbResistance_4.Enabled = True
		Me._cmbResistance_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbResistance_4.IntegralHeight = True
		Me._cmbResistance_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbResistance_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbResistance_4.Sorted = False
		Me._cmbResistance_4.TabStop = True
		Me._cmbResistance_4.Visible = True
		Me._cmbResistance_4.Name = "_cmbResistance_4"
		Me._cmbResistance_3.Size = New System.Drawing.Size(101, 21)
		Me._cmbResistance_3.Location = New System.Drawing.Point(44, 90)
		Me._cmbResistance_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbResistance_3.TabIndex = 128
		Me._cmbResistance_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbResistance_3.BackColor = System.Drawing.SystemColors.Window
		Me._cmbResistance_3.CausesValidation = True
		Me._cmbResistance_3.Enabled = True
		Me._cmbResistance_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbResistance_3.IntegralHeight = True
		Me._cmbResistance_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbResistance_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbResistance_3.Sorted = False
		Me._cmbResistance_3.TabStop = True
		Me._cmbResistance_3.Visible = True
		Me._cmbResistance_3.Name = "_cmbResistance_3"
		Me._cmbResistance_2.Size = New System.Drawing.Size(101, 21)
		Me._cmbResistance_2.Location = New System.Drawing.Point(44, 68)
		Me._cmbResistance_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbResistance_2.TabIndex = 127
		Me._cmbResistance_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbResistance_2.BackColor = System.Drawing.SystemColors.Window
		Me._cmbResistance_2.CausesValidation = True
		Me._cmbResistance_2.Enabled = True
		Me._cmbResistance_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbResistance_2.IntegralHeight = True
		Me._cmbResistance_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbResistance_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbResistance_2.Sorted = False
		Me._cmbResistance_2.TabStop = True
		Me._cmbResistance_2.Visible = True
		Me._cmbResistance_2.Name = "_cmbResistance_2"
		Me._cmbResistance_1.Size = New System.Drawing.Size(101, 21)
		Me._cmbResistance_1.Location = New System.Drawing.Point(44, 46)
		Me._cmbResistance_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbResistance_1.TabIndex = 126
		Me._cmbResistance_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbResistance_1.BackColor = System.Drawing.SystemColors.Window
		Me._cmbResistance_1.CausesValidation = True
		Me._cmbResistance_1.Enabled = True
		Me._cmbResistance_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbResistance_1.IntegralHeight = True
		Me._cmbResistance_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbResistance_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbResistance_1.Sorted = False
		Me._cmbResistance_1.TabStop = True
		Me._cmbResistance_1.Visible = True
		Me._cmbResistance_1.Name = "_cmbResistance_1"
		Me._cmbResistance_0.Size = New System.Drawing.Size(101, 21)
		Me._cmbResistance_0.Location = New System.Drawing.Point(44, 24)
		Me._cmbResistance_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbResistance_0.TabIndex = 125
		Me._cmbResistance_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbResistance_0.BackColor = System.Drawing.SystemColors.Window
		Me._cmbResistance_0.CausesValidation = True
		Me._cmbResistance_0.Enabled = True
		Me._cmbResistance_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbResistance_0.IntegralHeight = True
		Me._cmbResistance_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbResistance_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbResistance_0.Sorted = False
		Me._cmbResistance_0.TabStop = True
		Me._cmbResistance_0.Visible = True
		Me._cmbResistance_0.Name = "_cmbResistance_0"
		Me._lblWeakness_7.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me._lblWeakness_7.Text = "Sharp"
		Me._lblWeakness_7.Size = New System.Drawing.Size(29, 13)
		Me._lblWeakness_7.Location = New System.Drawing.Point(10, 30)
		Me._lblWeakness_7.TabIndex = 140
		Me._lblWeakness_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblWeakness_7.BackColor = System.Drawing.SystemColors.Control
		Me._lblWeakness_7.Enabled = True
		Me._lblWeakness_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblWeakness_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblWeakness_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblWeakness_7.UseMnemonic = True
		Me._lblWeakness_7.Visible = True
		Me._lblWeakness_7.AutoSize = False
		Me._lblWeakness_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblWeakness_7.Name = "_lblWeakness_7"
		Me._lblWeakness_6.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me._lblWeakness_6.Text = "Blunt"
		Me._lblWeakness_6.Size = New System.Drawing.Size(29, 17)
		Me._lblWeakness_6.Location = New System.Drawing.Point(10, 50)
		Me._lblWeakness_6.TabIndex = 139
		Me._lblWeakness_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblWeakness_6.BackColor = System.Drawing.SystemColors.Control
		Me._lblWeakness_6.Enabled = True
		Me._lblWeakness_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblWeakness_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblWeakness_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblWeakness_6.UseMnemonic = True
		Me._lblWeakness_6.Visible = True
		Me._lblWeakness_6.AutoSize = False
		Me._lblWeakness_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblWeakness_6.Name = "_lblWeakness_6"
		Me._lblWeakness_5.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me._lblWeakness_5.Text = "Mind"
		Me._lblWeakness_5.Size = New System.Drawing.Size(29, 17)
		Me._lblWeakness_5.Location = New System.Drawing.Point(10, 182)
		Me._lblWeakness_5.TabIndex = 138
		Me._lblWeakness_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblWeakness_5.BackColor = System.Drawing.SystemColors.Control
		Me._lblWeakness_5.Enabled = True
		Me._lblWeakness_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblWeakness_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblWeakness_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblWeakness_5.UseMnemonic = True
		Me._lblWeakness_5.Visible = True
		Me._lblWeakness_5.AutoSize = False
		Me._lblWeakness_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblWeakness_5.Name = "_lblWeakness_5"
		Me._lblWeakness_4.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me._lblWeakness_4.Text = "Magic"
		Me._lblWeakness_4.Size = New System.Drawing.Size(37, 17)
		Me._lblWeakness_4.Location = New System.Drawing.Point(5, 160)
		Me._lblWeakness_4.TabIndex = 137
		Me._lblWeakness_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblWeakness_4.BackColor = System.Drawing.SystemColors.Control
		Me._lblWeakness_4.Enabled = True
		Me._lblWeakness_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblWeakness_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblWeakness_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblWeakness_4.UseMnemonic = True
		Me._lblWeakness_4.Visible = True
		Me._lblWeakness_4.AutoSize = False
		Me._lblWeakness_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblWeakness_4.Name = "_lblWeakness_4"
		Me._lblWeakness_3.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me._lblWeakness_3.Text = "Good"
		Me._lblWeakness_3.Size = New System.Drawing.Size(29, 17)
		Me._lblWeakness_3.Location = New System.Drawing.Point(10, 138)
		Me._lblWeakness_3.TabIndex = 136
		Me._lblWeakness_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblWeakness_3.BackColor = System.Drawing.SystemColors.Control
		Me._lblWeakness_3.Enabled = True
		Me._lblWeakness_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblWeakness_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblWeakness_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblWeakness_3.UseMnemonic = True
		Me._lblWeakness_3.Visible = True
		Me._lblWeakness_3.AutoSize = False
		Me._lblWeakness_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblWeakness_3.Name = "_lblWeakness_3"
		Me._lblWeakness_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me._lblWeakness_2.Text = "Evil"
		Me._lblWeakness_2.Size = New System.Drawing.Size(29, 17)
		Me._lblWeakness_2.Location = New System.Drawing.Point(10, 116)
		Me._lblWeakness_2.TabIndex = 135
		Me._lblWeakness_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblWeakness_2.BackColor = System.Drawing.SystemColors.Control
		Me._lblWeakness_2.Enabled = True
		Me._lblWeakness_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblWeakness_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblWeakness_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblWeakness_2.UseMnemonic = True
		Me._lblWeakness_2.Visible = True
		Me._lblWeakness_2.AutoSize = False
		Me._lblWeakness_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblWeakness_2.Name = "_lblWeakness_2"
		Me._lblWeakness_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me._lblWeakness_1.Text = "Fire"
		Me._lblWeakness_1.Size = New System.Drawing.Size(29, 17)
		Me._lblWeakness_1.Location = New System.Drawing.Point(10, 94)
		Me._lblWeakness_1.TabIndex = 134
		Me._lblWeakness_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblWeakness_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblWeakness_1.Enabled = True
		Me._lblWeakness_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblWeakness_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblWeakness_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblWeakness_1.UseMnemonic = True
		Me._lblWeakness_1.Visible = True
		Me._lblWeakness_1.AutoSize = False
		Me._lblWeakness_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblWeakness_1.Name = "_lblWeakness_1"
		Me._lblWeakness_0.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me._lblWeakness_0.Text = "Cold"
		Me._lblWeakness_0.Size = New System.Drawing.Size(29, 17)
		Me._lblWeakness_0.Location = New System.Drawing.Point(10, 72)
		Me._lblWeakness_0.TabIndex = 133
		Me._lblWeakness_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblWeakness_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblWeakness_0.Enabled = True
		Me._lblWeakness_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblWeakness_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblWeakness_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblWeakness_0.UseMnemonic = True
		Me._lblWeakness_0.Visible = True
		Me._lblWeakness_0.AutoSize = False
		Me._lblWeakness_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblWeakness_0.Name = "_lblWeakness_0"
		Me.Frame4.Text = "Armor"
		Me.Frame4.Size = New System.Drawing.Size(214, 215)
		Me.Frame4.Location = New System.Drawing.Point(4, 0)
		Me.Frame4.TabIndex = 11
		Me.Frame4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame4.BackColor = System.Drawing.SystemColors.Control
		Me.Frame4.Enabled = True
		Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame4.Visible = True
		Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame4.Name = "Frame4"
		Me.cmbBodyType.Size = New System.Drawing.Size(73, 21)
		Me.cmbBodyType.Location = New System.Drawing.Point(19, 16)
		Me.cmbBodyType.TabIndex = 167
		Me.cmbBodyType.Text = "Body Type"
		Me.cmbBodyType.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbBodyType.BackColor = System.Drawing.SystemColors.Window
		Me.cmbBodyType.CausesValidation = True
		Me.cmbBodyType.Enabled = True
		Me.cmbBodyType.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbBodyType.IntegralHeight = True
		Me.cmbBodyType.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbBodyType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbBodyType.Sorted = False
		Me.cmbBodyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cmbBodyType.TabStop = True
		Me.cmbBodyType.Visible = True
		Me.cmbBodyType.Name = "cmbBodyType"
		Me._cmbArmor_7.Size = New System.Drawing.Size(73, 21)
		Me._cmbArmor_7.Location = New System.Drawing.Point(19, 189)
		Me._cmbArmor_7.Sorted = True
		Me._cmbArmor_7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbArmor_7.TabIndex = 114
		Me._cmbArmor_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbArmor_7.BackColor = System.Drawing.SystemColors.Window
		Me._cmbArmor_7.CausesValidation = True
		Me._cmbArmor_7.Enabled = True
		Me._cmbArmor_7.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbArmor_7.IntegralHeight = True
		Me._cmbArmor_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbArmor_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbArmor_7.TabStop = True
		Me._cmbArmor_7.Visible = True
		Me._cmbArmor_7.Name = "_cmbArmor_7"
		Me._txtAR_7.AutoSize = False
		Me._txtAR_7.Size = New System.Drawing.Size(25, 19)
		Me._txtAR_7.Location = New System.Drawing.Point(104, 190)
		Me._txtAR_7.Maxlength = 3
		Me._txtAR_7.TabIndex = 113
		Me._txtAR_7.Text = "999"
		Me._txtAR_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtAR_7.AcceptsReturn = True
		Me._txtAR_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtAR_7.BackColor = System.Drawing.SystemColors.Window
		Me._txtAR_7.CausesValidation = True
		Me._txtAR_7.Enabled = True
		Me._txtAR_7.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtAR_7.HideSelection = True
		Me._txtAR_7.ReadOnly = False
		Me._txtAR_7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtAR_7.MultiLine = False
		Me._txtAR_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtAR_7.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtAR_7.TabStop = True
		Me._txtAR_7.Visible = True
		Me._txtAR_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtAR_7.Name = "_txtAR_7"
		Me._cmbArmor_6.Size = New System.Drawing.Size(73, 21)
		Me._cmbArmor_6.Location = New System.Drawing.Point(19, 167)
		Me._cmbArmor_6.Sorted = True
		Me._cmbArmor_6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbArmor_6.TabIndex = 111
		Me._cmbArmor_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbArmor_6.BackColor = System.Drawing.SystemColors.Window
		Me._cmbArmor_6.CausesValidation = True
		Me._cmbArmor_6.Enabled = True
		Me._cmbArmor_6.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbArmor_6.IntegralHeight = True
		Me._cmbArmor_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbArmor_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbArmor_6.TabStop = True
		Me._cmbArmor_6.Visible = True
		Me._cmbArmor_6.Name = "_cmbArmor_6"
		Me._txtAR_6.AutoSize = False
		Me._txtAR_6.Size = New System.Drawing.Size(25, 19)
		Me._txtAR_6.Location = New System.Drawing.Point(104, 168)
		Me._txtAR_6.Maxlength = 3
		Me._txtAR_6.TabIndex = 110
		Me._txtAR_6.Text = "999"
		Me._txtAR_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtAR_6.AcceptsReturn = True
		Me._txtAR_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtAR_6.BackColor = System.Drawing.SystemColors.Window
		Me._txtAR_6.CausesValidation = True
		Me._txtAR_6.Enabled = True
		Me._txtAR_6.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtAR_6.HideSelection = True
		Me._txtAR_6.ReadOnly = False
		Me._txtAR_6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtAR_6.MultiLine = False
		Me._txtAR_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtAR_6.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtAR_6.TabStop = True
		Me._txtAR_6.Visible = True
		Me._txtAR_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtAR_6.Name = "_txtAR_6"
		Me._cmbArmor_5.Size = New System.Drawing.Size(73, 21)
		Me._cmbArmor_5.Location = New System.Drawing.Point(19, 145)
		Me._cmbArmor_5.Sorted = True
		Me._cmbArmor_5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbArmor_5.TabIndex = 108
		Me._cmbArmor_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbArmor_5.BackColor = System.Drawing.SystemColors.Window
		Me._cmbArmor_5.CausesValidation = True
		Me._cmbArmor_5.Enabled = True
		Me._cmbArmor_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbArmor_5.IntegralHeight = True
		Me._cmbArmor_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbArmor_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbArmor_5.TabStop = True
		Me._cmbArmor_5.Visible = True
		Me._cmbArmor_5.Name = "_cmbArmor_5"
		Me._txtAR_5.AutoSize = False
		Me._txtAR_5.Size = New System.Drawing.Size(25, 19)
		Me._txtAR_5.Location = New System.Drawing.Point(104, 146)
		Me._txtAR_5.Maxlength = 3
		Me._txtAR_5.TabIndex = 107
		Me._txtAR_5.Text = "999"
		Me._txtAR_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtAR_5.AcceptsReturn = True
		Me._txtAR_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtAR_5.BackColor = System.Drawing.SystemColors.Window
		Me._txtAR_5.CausesValidation = True
		Me._txtAR_5.Enabled = True
		Me._txtAR_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtAR_5.HideSelection = True
		Me._txtAR_5.ReadOnly = False
		Me._txtAR_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtAR_5.MultiLine = False
		Me._txtAR_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtAR_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtAR_5.TabStop = True
		Me._txtAR_5.Visible = True
		Me._txtAR_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtAR_5.Name = "_txtAR_5"
		Me._cmbArmor_4.Size = New System.Drawing.Size(73, 21)
		Me._cmbArmor_4.Location = New System.Drawing.Point(19, 123)
		Me._cmbArmor_4.Sorted = True
		Me._cmbArmor_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbArmor_4.TabIndex = 105
		Me._cmbArmor_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbArmor_4.BackColor = System.Drawing.SystemColors.Window
		Me._cmbArmor_4.CausesValidation = True
		Me._cmbArmor_4.Enabled = True
		Me._cmbArmor_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbArmor_4.IntegralHeight = True
		Me._cmbArmor_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbArmor_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbArmor_4.TabStop = True
		Me._cmbArmor_4.Visible = True
		Me._cmbArmor_4.Name = "_cmbArmor_4"
		Me._txtAR_4.AutoSize = False
		Me._txtAR_4.Size = New System.Drawing.Size(25, 19)
		Me._txtAR_4.Location = New System.Drawing.Point(104, 125)
		Me._txtAR_4.Maxlength = 3
		Me._txtAR_4.TabIndex = 104
		Me._txtAR_4.Text = "999"
		Me._txtAR_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtAR_4.AcceptsReturn = True
		Me._txtAR_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtAR_4.BackColor = System.Drawing.SystemColors.Window
		Me._txtAR_4.CausesValidation = True
		Me._txtAR_4.Enabled = True
		Me._txtAR_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtAR_4.HideSelection = True
		Me._txtAR_4.ReadOnly = False
		Me._txtAR_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtAR_4.MultiLine = False
		Me._txtAR_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtAR_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtAR_4.TabStop = True
		Me._txtAR_4.Visible = True
		Me._txtAR_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtAR_4.Name = "_txtAR_4"
		Me._cmbArmor_3.Size = New System.Drawing.Size(73, 21)
		Me._cmbArmor_3.Location = New System.Drawing.Point(19, 101)
		Me._cmbArmor_3.Sorted = True
		Me._cmbArmor_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbArmor_3.TabIndex = 102
		Me._cmbArmor_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbArmor_3.BackColor = System.Drawing.SystemColors.Window
		Me._cmbArmor_3.CausesValidation = True
		Me._cmbArmor_3.Enabled = True
		Me._cmbArmor_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbArmor_3.IntegralHeight = True
		Me._cmbArmor_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbArmor_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbArmor_3.TabStop = True
		Me._cmbArmor_3.Visible = True
		Me._cmbArmor_3.Name = "_cmbArmor_3"
		Me._txtAR_3.AutoSize = False
		Me._txtAR_3.Size = New System.Drawing.Size(25, 19)
		Me._txtAR_3.Location = New System.Drawing.Point(104, 103)
		Me._txtAR_3.Maxlength = 3
		Me._txtAR_3.TabIndex = 101
		Me._txtAR_3.Text = "999"
		Me._txtAR_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtAR_3.AcceptsReturn = True
		Me._txtAR_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtAR_3.BackColor = System.Drawing.SystemColors.Window
		Me._txtAR_3.CausesValidation = True
		Me._txtAR_3.Enabled = True
		Me._txtAR_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtAR_3.HideSelection = True
		Me._txtAR_3.ReadOnly = False
		Me._txtAR_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtAR_3.MultiLine = False
		Me._txtAR_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtAR_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtAR_3.TabStop = True
		Me._txtAR_3.Visible = True
		Me._txtAR_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtAR_3.Name = "_txtAR_3"
		Me._cmbArmor_2.Size = New System.Drawing.Size(73, 21)
		Me._cmbArmor_2.Location = New System.Drawing.Point(19, 79)
		Me._cmbArmor_2.Sorted = True
		Me._cmbArmor_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbArmor_2.TabIndex = 99
		Me._cmbArmor_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbArmor_2.BackColor = System.Drawing.SystemColors.Window
		Me._cmbArmor_2.CausesValidation = True
		Me._cmbArmor_2.Enabled = True
		Me._cmbArmor_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbArmor_2.IntegralHeight = True
		Me._cmbArmor_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbArmor_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbArmor_2.TabStop = True
		Me._cmbArmor_2.Visible = True
		Me._cmbArmor_2.Name = "_cmbArmor_2"
		Me._txtAR_2.AutoSize = False
		Me._txtAR_2.Size = New System.Drawing.Size(25, 19)
		Me._txtAR_2.Location = New System.Drawing.Point(104, 81)
		Me._txtAR_2.Maxlength = 3
		Me._txtAR_2.TabIndex = 98
		Me._txtAR_2.Text = "999"
		Me._txtAR_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtAR_2.AcceptsReturn = True
		Me._txtAR_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtAR_2.BackColor = System.Drawing.SystemColors.Window
		Me._txtAR_2.CausesValidation = True
		Me._txtAR_2.Enabled = True
		Me._txtAR_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtAR_2.HideSelection = True
		Me._txtAR_2.ReadOnly = False
		Me._txtAR_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtAR_2.MultiLine = False
		Me._txtAR_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtAR_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtAR_2.TabStop = True
		Me._txtAR_2.Visible = True
		Me._txtAR_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtAR_2.Name = "_txtAR_2"
		Me._cmbArmor_1.Size = New System.Drawing.Size(73, 21)
		Me._cmbArmor_1.Location = New System.Drawing.Point(19, 58)
		Me._cmbArmor_1.Sorted = True
		Me._cmbArmor_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbArmor_1.TabIndex = 96
		Me._cmbArmor_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbArmor_1.BackColor = System.Drawing.SystemColors.Window
		Me._cmbArmor_1.CausesValidation = True
		Me._cmbArmor_1.Enabled = True
		Me._cmbArmor_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbArmor_1.IntegralHeight = True
		Me._cmbArmor_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbArmor_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbArmor_1.TabStop = True
		Me._cmbArmor_1.Visible = True
		Me._cmbArmor_1.Name = "_cmbArmor_1"
		Me._txtAR_1.AutoSize = False
		Me._txtAR_1.Size = New System.Drawing.Size(25, 19)
		Me._txtAR_1.Location = New System.Drawing.Point(104, 60)
		Me._txtAR_1.Maxlength = 3
		Me._txtAR_1.TabIndex = 95
		Me._txtAR_1.Text = "999"
		Me._txtAR_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtAR_1.AcceptsReturn = True
		Me._txtAR_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtAR_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtAR_1.CausesValidation = True
		Me._txtAR_1.Enabled = True
		Me._txtAR_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtAR_1.HideSelection = True
		Me._txtAR_1.ReadOnly = False
		Me._txtAR_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtAR_1.MultiLine = False
		Me._txtAR_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtAR_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtAR_1.TabStop = True
		Me._txtAR_1.Visible = True
		Me._txtAR_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtAR_1.Name = "_txtAR_1"
		Me._cmbArmor_0.Size = New System.Drawing.Size(73, 21)
		Me._cmbArmor_0.Location = New System.Drawing.Point(19, 37)
		Me._cmbArmor_0.Sorted = True
		Me._cmbArmor_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me._cmbArmor_0.TabIndex = 90
		Me._cmbArmor_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmbArmor_0.BackColor = System.Drawing.SystemColors.Window
		Me._cmbArmor_0.CausesValidation = True
		Me._cmbArmor_0.Enabled = True
		Me._cmbArmor_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cmbArmor_0.IntegralHeight = True
		Me._cmbArmor_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmbArmor_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmbArmor_0.TabStop = True
		Me._cmbArmor_0.Visible = True
		Me._cmbArmor_0.Name = "_cmbArmor_0"
		Me._txtAR_0.AutoSize = False
		Me._txtAR_0.Size = New System.Drawing.Size(25, 19)
		Me._txtAR_0.Location = New System.Drawing.Point(104, 38)
		Me._txtAR_0.Maxlength = 3
		Me._txtAR_0.TabIndex = 12
		Me._txtAR_0.Text = "999"
		Me._txtAR_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtAR_0.AcceptsReturn = True
		Me._txtAR_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtAR_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtAR_0.CausesValidation = True
		Me._txtAR_0.Enabled = True
		Me._txtAR_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtAR_0.HideSelection = True
		Me._txtAR_0.ReadOnly = False
		Me._txtAR_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtAR_0.MultiLine = False
		Me._txtAR_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtAR_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtAR_0.TabStop = True
		Me._txtAR_0.Visible = True
		Me._txtAR_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtAR_0.Name = "_txtAR_0"
		Me._lblArmor_26.Text = "%"
		Me._lblArmor_26.Size = New System.Drawing.Size(9, 13)
		Me._lblArmor_26.Location = New System.Drawing.Point(130, 196)
		Me._lblArmor_26.TabIndex = 148
		Me._lblArmor_26.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_26.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblArmor_26.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_26.Enabled = True
		Me._lblArmor_26.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_26.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_26.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_26.UseMnemonic = True
		Me._lblArmor_26.Visible = True
		Me._lblArmor_26.AutoSize = False
		Me._lblArmor_26.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_26.Name = "_lblArmor_26"
		Me._lblArmor_25.Text = "%"
		Me._lblArmor_25.Size = New System.Drawing.Size(9, 13)
		Me._lblArmor_25.Location = New System.Drawing.Point(130, 172)
		Me._lblArmor_25.TabIndex = 147
		Me._lblArmor_25.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_25.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblArmor_25.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_25.Enabled = True
		Me._lblArmor_25.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_25.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_25.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_25.UseMnemonic = True
		Me._lblArmor_25.Visible = True
		Me._lblArmor_25.AutoSize = False
		Me._lblArmor_25.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_25.Name = "_lblArmor_25"
		Me._lblArmor_24.Text = "%"
		Me._lblArmor_24.Size = New System.Drawing.Size(9, 13)
		Me._lblArmor_24.Location = New System.Drawing.Point(130, 150)
		Me._lblArmor_24.TabIndex = 146
		Me._lblArmor_24.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_24.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblArmor_24.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_24.Enabled = True
		Me._lblArmor_24.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_24.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_24.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_24.UseMnemonic = True
		Me._lblArmor_24.Visible = True
		Me._lblArmor_24.AutoSize = False
		Me._lblArmor_24.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_24.Name = "_lblArmor_24"
		Me._lblArmor_23.Text = "%"
		Me._lblArmor_23.Size = New System.Drawing.Size(9, 13)
		Me._lblArmor_23.Location = New System.Drawing.Point(130, 130)
		Me._lblArmor_23.TabIndex = 145
		Me._lblArmor_23.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_23.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblArmor_23.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_23.Enabled = True
		Me._lblArmor_23.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_23.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_23.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_23.UseMnemonic = True
		Me._lblArmor_23.Visible = True
		Me._lblArmor_23.AutoSize = False
		Me._lblArmor_23.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_23.Name = "_lblArmor_23"
		Me._lblArmor_22.Text = "%"
		Me._lblArmor_22.Size = New System.Drawing.Size(9, 13)
		Me._lblArmor_22.Location = New System.Drawing.Point(130, 108)
		Me._lblArmor_22.TabIndex = 144
		Me._lblArmor_22.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_22.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblArmor_22.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_22.Enabled = True
		Me._lblArmor_22.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_22.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_22.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_22.UseMnemonic = True
		Me._lblArmor_22.Visible = True
		Me._lblArmor_22.AutoSize = False
		Me._lblArmor_22.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_22.Name = "_lblArmor_22"
		Me._lblArmor_21.Text = "%"
		Me._lblArmor_21.Size = New System.Drawing.Size(9, 13)
		Me._lblArmor_21.Location = New System.Drawing.Point(130, 84)
		Me._lblArmor_21.TabIndex = 143
		Me._lblArmor_21.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_21.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblArmor_21.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_21.Enabled = True
		Me._lblArmor_21.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_21.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_21.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_21.UseMnemonic = True
		Me._lblArmor_21.Visible = True
		Me._lblArmor_21.AutoSize = False
		Me._lblArmor_21.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_21.Name = "_lblArmor_21"
		Me._lblArmor_20.Text = "%"
		Me._lblArmor_20.Size = New System.Drawing.Size(9, 13)
		Me._lblArmor_20.Location = New System.Drawing.Point(130, 64)
		Me._lblArmor_20.TabIndex = 142
		Me._lblArmor_20.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_20.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblArmor_20.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_20.Enabled = True
		Me._lblArmor_20.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_20.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_20.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_20.UseMnemonic = True
		Me._lblArmor_20.Visible = True
		Me._lblArmor_20.AutoSize = False
		Me._lblArmor_20.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_20.Name = "_lblArmor_20"
		Me._lblArmor_19.Text = "%"
		Me._lblArmor_19.Size = New System.Drawing.Size(9, 13)
		Me._lblArmor_19.Location = New System.Drawing.Point(130, 42)
		Me._lblArmor_19.TabIndex = 141
		Me._lblArmor_19.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_19.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblArmor_19.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_19.Enabled = True
		Me._lblArmor_19.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_19.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_19.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_19.UseMnemonic = True
		Me._lblArmor_19.Visible = True
		Me._lblArmor_19.AutoSize = False
		Me._lblArmor_19.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_19.Name = "_lblArmor_19"
		Me._lblArmor_18.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblArmor_18.Text = "8"
		Me._lblArmor_18.Size = New System.Drawing.Size(14, 13)
		Me._lblArmor_18.Location = New System.Drawing.Point(4, 193)
		Me._lblArmor_18.TabIndex = 123
		Me._lblArmor_18.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_18.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_18.Enabled = True
		Me._lblArmor_18.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_18.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_18.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_18.UseMnemonic = True
		Me._lblArmor_18.Visible = True
		Me._lblArmor_18.AutoSize = False
		Me._lblArmor_18.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_18.Name = "_lblArmor_18"
		Me._lblArmor_17.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblArmor_17.Text = "7"
		Me._lblArmor_17.Size = New System.Drawing.Size(14, 13)
		Me._lblArmor_17.Location = New System.Drawing.Point(4, 171)
		Me._lblArmor_17.TabIndex = 122
		Me._lblArmor_17.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_17.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_17.Enabled = True
		Me._lblArmor_17.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_17.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_17.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_17.UseMnemonic = True
		Me._lblArmor_17.Visible = True
		Me._lblArmor_17.AutoSize = False
		Me._lblArmor_17.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_17.Name = "_lblArmor_17"
		Me._lblArmor_16.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblArmor_16.Text = "6"
		Me._lblArmor_16.Size = New System.Drawing.Size(14, 13)
		Me._lblArmor_16.Location = New System.Drawing.Point(4, 149)
		Me._lblArmor_16.TabIndex = 121
		Me._lblArmor_16.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_16.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_16.Enabled = True
		Me._lblArmor_16.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_16.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_16.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_16.UseMnemonic = True
		Me._lblArmor_16.Visible = True
		Me._lblArmor_16.AutoSize = False
		Me._lblArmor_16.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_16.Name = "_lblArmor_16"
		Me._lblArmor_15.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblArmor_15.Text = "5"
		Me._lblArmor_15.Size = New System.Drawing.Size(14, 13)
		Me._lblArmor_15.Location = New System.Drawing.Point(4, 127)
		Me._lblArmor_15.TabIndex = 120
		Me._lblArmor_15.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_15.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_15.Enabled = True
		Me._lblArmor_15.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_15.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_15.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_15.UseMnemonic = True
		Me._lblArmor_15.Visible = True
		Me._lblArmor_15.AutoSize = False
		Me._lblArmor_15.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_15.Name = "_lblArmor_15"
		Me._lblArmor_14.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblArmor_14.Text = "4"
		Me._lblArmor_14.Size = New System.Drawing.Size(14, 13)
		Me._lblArmor_14.Location = New System.Drawing.Point(4, 105)
		Me._lblArmor_14.TabIndex = 119
		Me._lblArmor_14.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_14.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_14.Enabled = True
		Me._lblArmor_14.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_14.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_14.UseMnemonic = True
		Me._lblArmor_14.Visible = True
		Me._lblArmor_14.AutoSize = False
		Me._lblArmor_14.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_14.Name = "_lblArmor_14"
		Me._lblArmor_13.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblArmor_13.Text = "3"
		Me._lblArmor_13.Size = New System.Drawing.Size(14, 13)
		Me._lblArmor_13.Location = New System.Drawing.Point(4, 83)
		Me._lblArmor_13.TabIndex = 118
		Me._lblArmor_13.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_13.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_13.Enabled = True
		Me._lblArmor_13.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_13.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_13.UseMnemonic = True
		Me._lblArmor_13.Visible = True
		Me._lblArmor_13.AutoSize = False
		Me._lblArmor_13.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_13.Name = "_lblArmor_13"
		Me._lblArmor_12.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblArmor_12.Text = "2"
		Me._lblArmor_12.Size = New System.Drawing.Size(14, 13)
		Me._lblArmor_12.Location = New System.Drawing.Point(4, 62)
		Me._lblArmor_12.TabIndex = 117
		Me._lblArmor_12.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_12.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_12.Enabled = True
		Me._lblArmor_12.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_12.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_12.UseMnemonic = True
		Me._lblArmor_12.Visible = True
		Me._lblArmor_12.AutoSize = False
		Me._lblArmor_12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_12.Name = "_lblArmor_12"
		Me._lblArmor_11.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblArmor_11.Text = "1"
		Me._lblArmor_11.Size = New System.Drawing.Size(14, 13)
		Me._lblArmor_11.Location = New System.Drawing.Point(4, 41)
		Me._lblArmor_11.TabIndex = 116
		Me._lblArmor_11.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_11.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_11.Enabled = True
		Me._lblArmor_11.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_11.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_11.UseMnemonic = True
		Me._lblArmor_11.Visible = True
		Me._lblArmor_11.AutoSize = False
		Me._lblArmor_11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_11.Name = "_lblArmor_11"
		Me._lblArmor_10.Text = "<None>"
		Me._lblArmor_10.Size = New System.Drawing.Size(57, 13)
		Me._lblArmor_10.Location = New System.Drawing.Point(149, 193)
		Me._lblArmor_10.TabIndex = 115
		Me._lblArmor_10.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_10.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblArmor_10.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_10.Enabled = True
		Me._lblArmor_10.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_10.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_10.UseMnemonic = True
		Me._lblArmor_10.Visible = True
		Me._lblArmor_10.AutoSize = False
		Me._lblArmor_10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_10.Name = "_lblArmor_10"
		Me._lblArmor_9.Text = "Helm"
		Me._lblArmor_9.Size = New System.Drawing.Size(57, 13)
		Me._lblArmor_9.Location = New System.Drawing.Point(149, 171)
		Me._lblArmor_9.TabIndex = 112
		Me._lblArmor_9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblArmor_9.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_9.Enabled = True
		Me._lblArmor_9.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_9.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_9.UseMnemonic = True
		Me._lblArmor_9.Visible = True
		Me._lblArmor_9.AutoSize = False
		Me._lblArmor_9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_9.Name = "_lblArmor_9"
		Me._lblArmor_8.Text = "Shield"
		Me._lblArmor_8.Size = New System.Drawing.Size(57, 13)
		Me._lblArmor_8.Location = New System.Drawing.Point(149, 149)
		Me._lblArmor_8.TabIndex = 109
		Me._lblArmor_8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblArmor_8.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_8.Enabled = True
		Me._lblArmor_8.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_8.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_8.UseMnemonic = True
		Me._lblArmor_8.Visible = True
		Me._lblArmor_8.AutoSize = False
		Me._lblArmor_8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_8.Name = "_lblArmor_8"
		Me._lblArmor_7.Text = "Shield"
		Me._lblArmor_7.Size = New System.Drawing.Size(57, 13)
		Me._lblArmor_7.Location = New System.Drawing.Point(149, 127)
		Me._lblArmor_7.TabIndex = 106
		Me._lblArmor_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblArmor_7.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_7.Enabled = True
		Me._lblArmor_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_7.UseMnemonic = True
		Me._lblArmor_7.Visible = True
		Me._lblArmor_7.AutoSize = False
		Me._lblArmor_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_7.Name = "_lblArmor_7"
		Me._lblArmor_6.Text = "Body Armor"
		Me._lblArmor_6.Size = New System.Drawing.Size(57, 13)
		Me._lblArmor_6.Location = New System.Drawing.Point(149, 105)
		Me._lblArmor_6.TabIndex = 103
		Me._lblArmor_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblArmor_6.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_6.Enabled = True
		Me._lblArmor_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_6.UseMnemonic = True
		Me._lblArmor_6.Visible = True
		Me._lblArmor_6.AutoSize = False
		Me._lblArmor_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_6.Name = "_lblArmor_6"
		Me._lblArmor_5.Text = "Body Armor"
		Me._lblArmor_5.Size = New System.Drawing.Size(57, 13)
		Me._lblArmor_5.Location = New System.Drawing.Point(149, 83)
		Me._lblArmor_5.TabIndex = 100
		Me._lblArmor_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblArmor_5.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_5.Enabled = True
		Me._lblArmor_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_5.UseMnemonic = True
		Me._lblArmor_5.Visible = True
		Me._lblArmor_5.AutoSize = False
		Me._lblArmor_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_5.Name = "_lblArmor_5"
		Me._lblArmor_4.Text = "Body Armor"
		Me._lblArmor_4.Size = New System.Drawing.Size(57, 13)
		Me._lblArmor_4.Location = New System.Drawing.Point(149, 62)
		Me._lblArmor_4.TabIndex = 97
		Me._lblArmor_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblArmor_4.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_4.Enabled = True
		Me._lblArmor_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_4.UseMnemonic = True
		Me._lblArmor_4.Visible = True
		Me._lblArmor_4.AutoSize = False
		Me._lblArmor_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_4.Name = "_lblArmor_4"
		Me._lblArmor_3.Text = "Body Armor"
		Me._lblArmor_3.Size = New System.Drawing.Size(57, 13)
		Me._lblArmor_3.Location = New System.Drawing.Point(149, 41)
		Me._lblArmor_3.TabIndex = 94
		Me._lblArmor_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblArmor_3.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_3.Enabled = True
		Me._lblArmor_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_3.UseMnemonic = True
		Me._lblArmor_3.Visible = True
		Me._lblArmor_3.AutoSize = False
		Me._lblArmor_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_3.Name = "_lblArmor_3"
		Me._lblArmor_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblArmor_2.Text = "Covered By"
		Me._lblArmor_2.Size = New System.Drawing.Size(60, 13)
		Me._lblArmor_2.Location = New System.Drawing.Point(151, 14)
		Me._lblArmor_2.TabIndex = 93
		Me._lblArmor_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_2.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_2.Enabled = True
		Me._lblArmor_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_2.UseMnemonic = True
		Me._lblArmor_2.Visible = True
		Me._lblArmor_2.AutoSize = False
		Me._lblArmor_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_2.Name = "_lblArmor_2"
		Me._lblArmor_0.Text = "Body Type"
		Me._lblArmor_0.Size = New System.Drawing.Size(59, 13)
		Me._lblArmor_0.Location = New System.Drawing.Point(19, 14)
		Me._lblArmor_0.TabIndex = 92
		Me._lblArmor_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblArmor_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_0.Enabled = True
		Me._lblArmor_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_0.UseMnemonic = True
		Me._lblArmor_0.Visible = True
		Me._lblArmor_0.AutoSize = False
		Me._lblArmor_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_0.Name = "_lblArmor_0"
		Me._lblArmor_1.Text = "Resistance"
		Me._lblArmor_1.Size = New System.Drawing.Size(53, 13)
		Me._lblArmor_1.Location = New System.Drawing.Point(93, 14)
		Me._lblArmor_1.TabIndex = 91
		Me._lblArmor_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblArmor_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblArmor_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblArmor_1.Enabled = True
		Me._lblArmor_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblArmor_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblArmor_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblArmor_1.UseMnemonic = True
		Me._lblArmor_1.Visible = True
		Me._lblArmor_1.AutoSize = False
		Me._lblArmor_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblArmor_1.Name = "_lblArmor_1"
		Me._fraMonsProp_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._fraMonsProp_1.Text = "Frame5"
		Me._fraMonsProp_1.Size = New System.Drawing.Size(377, 217)
		Me._fraMonsProp_1.Location = New System.Drawing.Point(8, 28)
		Me._fraMonsProp_1.TabIndex = 13
		Me._fraMonsProp_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraMonsProp_1.BackColor = System.Drawing.SystemColors.Control
		Me._fraMonsProp_1.Enabled = True
		Me._fraMonsProp_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraMonsProp_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._fraMonsProp_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraMonsProp_1.Visible = True
		Me._fraMonsProp_1.Name = "_fraMonsProp_1"
		Me.txtHome.AutoSize = False
		Me.txtHome.Size = New System.Drawing.Size(169, 19)
		Me.txtHome.Location = New System.Drawing.Point(76, 196)
		Me.txtHome.TabIndex = 164
		Me.txtHome.Text = "Home"
		Me.txtHome.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHome.AcceptsReturn = True
		Me.txtHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtHome.BackColor = System.Drawing.SystemColors.Window
		Me.txtHome.CausesValidation = True
		Me.txtHome.Enabled = True
		Me.txtHome.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtHome.HideSelection = True
		Me.txtHome.ReadOnly = False
		Me.txtHome.Maxlength = 0
		Me.txtHome.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtHome.MultiLine = False
		Me.txtHome.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtHome.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtHome.TabStop = True
		Me.txtHome.Visible = True
		Me.txtHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtHome.Name = "txtHome"
		Me.cmbCombatRank.Size = New System.Drawing.Size(117, 21)
		Me.cmbCombatRank.Location = New System.Drawing.Point(256, 180)
		Me.cmbCombatRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbCombatRank.TabIndex = 150
		Me.cmbCombatRank.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbCombatRank.BackColor = System.Drawing.SystemColors.Window
		Me.cmbCombatRank.CausesValidation = True
		Me.cmbCombatRank.Enabled = True
		Me.cmbCombatRank.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbCombatRank.IntegralHeight = True
		Me.cmbCombatRank.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbCombatRank.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbCombatRank.Sorted = False
		Me.cmbCombatRank.TabStop = True
		Me.cmbCombatRank.Visible = True
		Me.cmbCombatRank.Name = "cmbCombatRank"
		Me.Frame9.Text = "Vices"
		Me.Frame9.Size = New System.Drawing.Size(119, 97)
		Me.Frame9.Location = New System.Drawing.Point(254, 64)
		Me.Frame9.TabIndex = 40
		Me.Frame9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame9.BackColor = System.Drawing.SystemColors.Control
		Me.Frame9.Enabled = True
		Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame9.Visible = True
		Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame9.Name = "Frame9"
		Me.txtGreed.AutoSize = False
		Me.txtGreed.Size = New System.Drawing.Size(25, 19)
		Me.txtGreed.Location = New System.Drawing.Point(47, 69)
		Me.txtGreed.Maxlength = 3
		Me.txtGreed.TabIndex = 46
		Me.txtGreed.Text = "255"
		Me.txtGreed.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGreed.AcceptsReturn = True
		Me.txtGreed.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtGreed.BackColor = System.Drawing.SystemColors.Window
		Me.txtGreed.CausesValidation = True
		Me.txtGreed.Enabled = True
		Me.txtGreed.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtGreed.HideSelection = True
		Me.txtGreed.ReadOnly = False
		Me.txtGreed.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtGreed.MultiLine = False
		Me.txtGreed.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtGreed.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtGreed.TabStop = True
		Me.txtGreed.Visible = True
		Me.txtGreed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtGreed.Name = "txtGreed"
		Me.txtLust.AutoSize = False
		Me.txtLust.Size = New System.Drawing.Size(25, 19)
		Me.txtLust.Location = New System.Drawing.Point(83, 69)
		Me.txtLust.Maxlength = 3
		Me.txtLust.TabIndex = 45
		Me.txtLust.Text = "255"
		Me.txtLust.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLust.AcceptsReturn = True
		Me.txtLust.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtLust.BackColor = System.Drawing.SystemColors.Window
		Me.txtLust.CausesValidation = True
		Me.txtLust.Enabled = True
		Me.txtLust.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLust.HideSelection = True
		Me.txtLust.ReadOnly = False
		Me.txtLust.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLust.MultiLine = False
		Me.txtLust.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLust.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtLust.TabStop = True
		Me.txtLust.Visible = True
		Me.txtLust.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtLust.Name = "txtLust"
		Me.txtLunacy.AutoSize = False
		Me.txtLunacy.Size = New System.Drawing.Size(25, 19)
		Me.txtLunacy.Location = New System.Drawing.Point(11, 29)
		Me.txtLunacy.Maxlength = 3
		Me.txtLunacy.TabIndex = 44
		Me.txtLunacy.Text = "255"
		Me.txtLunacy.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLunacy.AcceptsReturn = True
		Me.txtLunacy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtLunacy.BackColor = System.Drawing.SystemColors.Window
		Me.txtLunacy.CausesValidation = True
		Me.txtLunacy.Enabled = True
		Me.txtLunacy.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLunacy.HideSelection = True
		Me.txtLunacy.ReadOnly = False
		Me.txtLunacy.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLunacy.MultiLine = False
		Me.txtLunacy.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLunacy.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtLunacy.TabStop = True
		Me.txtLunacy.Visible = True
		Me.txtLunacy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtLunacy.Name = "txtLunacy"
		Me.txtPride.AutoSize = False
		Me.txtPride.Size = New System.Drawing.Size(25, 19)
		Me.txtPride.Location = New System.Drawing.Point(11, 69)
		Me.txtPride.Maxlength = 3
		Me.txtPride.TabIndex = 43
		Me.txtPride.Text = "255"
		Me.txtPride.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPride.AcceptsReturn = True
		Me.txtPride.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPride.BackColor = System.Drawing.SystemColors.Window
		Me.txtPride.CausesValidation = True
		Me.txtPride.Enabled = True
		Me.txtPride.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPride.HideSelection = True
		Me.txtPride.ReadOnly = False
		Me.txtPride.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPride.MultiLine = False
		Me.txtPride.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPride.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPride.TabStop = True
		Me.txtPride.Visible = True
		Me.txtPride.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPride.Name = "txtPride"
		Me.txtWrath.AutoSize = False
		Me.txtWrath.Size = New System.Drawing.Size(25, 19)
		Me.txtWrath.Location = New System.Drawing.Point(83, 29)
		Me.txtWrath.Maxlength = 3
		Me.txtWrath.TabIndex = 42
		Me.txtWrath.Text = "255"
		Me.txtWrath.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtWrath.AcceptsReturn = True
		Me.txtWrath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtWrath.BackColor = System.Drawing.SystemColors.Window
		Me.txtWrath.CausesValidation = True
		Me.txtWrath.Enabled = True
		Me.txtWrath.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtWrath.HideSelection = True
		Me.txtWrath.ReadOnly = False
		Me.txtWrath.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtWrath.MultiLine = False
		Me.txtWrath.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtWrath.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtWrath.TabStop = True
		Me.txtWrath.Visible = True
		Me.txtWrath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtWrath.Name = "txtWrath"
		Me.txtRevelry.AutoSize = False
		Me.txtRevelry.Size = New System.Drawing.Size(25, 19)
		Me.txtRevelry.Location = New System.Drawing.Point(46, 29)
		Me.txtRevelry.Maxlength = 3
		Me.txtRevelry.TabIndex = 41
		Me.txtRevelry.Text = "255"
		Me.txtRevelry.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRevelry.AcceptsReturn = True
		Me.txtRevelry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtRevelry.BackColor = System.Drawing.SystemColors.Window
		Me.txtRevelry.CausesValidation = True
		Me.txtRevelry.Enabled = True
		Me.txtRevelry.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtRevelry.HideSelection = True
		Me.txtRevelry.ReadOnly = False
		Me.txtRevelry.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtRevelry.MultiLine = False
		Me.txtRevelry.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtRevelry.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtRevelry.TabStop = True
		Me.txtRevelry.Visible = True
		Me.txtRevelry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtRevelry.Name = "txtRevelry"
		Me._Label1_16.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._Label1_16.BackColor = System.Drawing.Color.Transparent
		Me._Label1_16.Text = "Greed"
		Me._Label1_16.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_16.Size = New System.Drawing.Size(33, 13)
		Me._Label1_16.Location = New System.Drawing.Point(43, 53)
		Me._Label1_16.TabIndex = 52
		Me._Label1_16.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_16.Enabled = True
		Me._Label1_16.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_16.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_16.UseMnemonic = True
		Me._Label1_16.Visible = True
		Me._Label1_16.AutoSize = False
		Me._Label1_16.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_16.Name = "_Label1_16"
		Me._Label1_14.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._Label1_14.BackColor = System.Drawing.Color.Transparent
		Me._Label1_14.Text = "Lust"
		Me._Label1_14.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_14.Size = New System.Drawing.Size(33, 13)
		Me._Label1_14.Location = New System.Drawing.Point(79, 53)
		Me._Label1_14.TabIndex = 51
		Me._Label1_14.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_14.Enabled = True
		Me._Label1_14.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_14.UseMnemonic = True
		Me._Label1_14.Visible = True
		Me._Label1_14.AutoSize = False
		Me._Label1_14.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_14.Name = "_Label1_14"
		Me._Label1_13.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._Label1_13.BackColor = System.Drawing.Color.Transparent
		Me._Label1_13.Text = "Luncy"
		Me._Label1_13.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_13.Size = New System.Drawing.Size(33, 13)
		Me._Label1_13.Location = New System.Drawing.Point(7, 13)
		Me._Label1_13.TabIndex = 50
		Me._Label1_13.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_13.Enabled = True
		Me._Label1_13.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_13.UseMnemonic = True
		Me._Label1_13.Visible = True
		Me._Label1_13.AutoSize = False
		Me._Label1_13.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_13.Name = "_Label1_13"
		Me._Label1_12.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._Label1_12.BackColor = System.Drawing.Color.Transparent
		Me._Label1_12.Text = "Pride"
		Me._Label1_12.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_12.Size = New System.Drawing.Size(33, 13)
		Me._Label1_12.Location = New System.Drawing.Point(7, 53)
		Me._Label1_12.TabIndex = 49
		Me._Label1_12.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_12.Enabled = True
		Me._Label1_12.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_12.UseMnemonic = True
		Me._Label1_12.Visible = True
		Me._Label1_12.AutoSize = False
		Me._Label1_12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_12.Name = "_Label1_12"
		Me._Label1_11.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._Label1_11.BackColor = System.Drawing.Color.Transparent
		Me._Label1_11.Text = "Wrath"
		Me._Label1_11.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_11.Size = New System.Drawing.Size(33, 13)
		Me._Label1_11.Location = New System.Drawing.Point(79, 13)
		Me._Label1_11.TabIndex = 48
		Me._Label1_11.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_11.Enabled = True
		Me._Label1_11.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_11.UseMnemonic = True
		Me._Label1_11.Visible = True
		Me._Label1_11.AutoSize = False
		Me._Label1_11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_11.Name = "_Label1_11"
		Me._Label1_10.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._Label1_10.BackColor = System.Drawing.Color.Transparent
		Me._Label1_10.Text = "Revlry"
		Me._Label1_10.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_10.Size = New System.Drawing.Size(33, 13)
		Me._Label1_10.Location = New System.Drawing.Point(43, 13)
		Me._Label1_10.TabIndex = 47
		Me._Label1_10.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_10.Enabled = True
		Me._Label1_10.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_10.UseMnemonic = True
		Me._Label1_10.Visible = True
		Me._Label1_10.AutoSize = False
		Me._Label1_10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_10.Name = "_Label1_10"
		Me.Frame6.Text = "Family"
		Me.Frame6.Size = New System.Drawing.Size(153, 129)
		Me.Frame6.Location = New System.Drawing.Point(4, 64)
		Me.Frame6.TabIndex = 16
		Me.Frame6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame6.BackColor = System.Drawing.SystemColors.Control
		Me.Frame6.Enabled = True
		Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame6.Visible = True
		Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame6.Name = "Frame6"
		Me._chkFamily_9.Text = "Magical"
		Me._chkFamily_9.Size = New System.Drawing.Size(61, 13)
		Me._chkFamily_9.Location = New System.Drawing.Point(80, 104)
		Me._chkFamily_9.TabIndex = 26
		Me._chkFamily_9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_9.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_9.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_9.BackColor = System.Drawing.SystemColors.Control
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
		Me._chkFamily_7.Text = "Undead"
		Me._chkFamily_7.Size = New System.Drawing.Size(61, 13)
		Me._chkFamily_7.Location = New System.Drawing.Point(80, 64)
		Me._chkFamily_7.TabIndex = 25
		Me._chkFamily_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_7.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_7.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_7.BackColor = System.Drawing.SystemColors.Control
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
		Me._chkFamily_8.Text = "Aquatic"
		Me._chkFamily_8.Size = New System.Drawing.Size(61, 13)
		Me._chkFamily_8.Location = New System.Drawing.Point(80, 84)
		Me._chkFamily_8.TabIndex = 24
		Me._chkFamily_8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_8.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_8.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_8.BackColor = System.Drawing.SystemColors.Control
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
		Me._chkFamily_6.Text = "Bird"
		Me._chkFamily_6.Size = New System.Drawing.Size(53, 13)
		Me._chkFamily_6.Location = New System.Drawing.Point(80, 44)
		Me._chkFamily_6.TabIndex = 23
		Me._chkFamily_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_6.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_6.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_6.BackColor = System.Drawing.SystemColors.Control
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
		Me._chkFamily_3.Text = "Blob"
		Me._chkFamily_3.Size = New System.Drawing.Size(45, 13)
		Me._chkFamily_3.Location = New System.Drawing.Point(12, 84)
		Me._chkFamily_3.TabIndex = 22
		Me._chkFamily_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_3.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_3.BackColor = System.Drawing.SystemColors.Control
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
		Me._chkFamily_2.Text = "Insect"
		Me._chkFamily_2.Size = New System.Drawing.Size(69, 13)
		Me._chkFamily_2.Location = New System.Drawing.Point(12, 64)
		Me._chkFamily_2.TabIndex = 21
		Me._chkFamily_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_2.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_2.BackColor = System.Drawing.SystemColors.Control
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
		Me._chkFamily_1.Text = "Reptile"
		Me._chkFamily_1.Size = New System.Drawing.Size(69, 13)
		Me._chkFamily_1.Location = New System.Drawing.Point(12, 44)
		Me._chkFamily_1.TabIndex = 20
		Me._chkFamily_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_1.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_1.BackColor = System.Drawing.SystemColors.Control
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
		Me._chkFamily_0.Text = "Sentient"
		Me._chkFamily_0.Size = New System.Drawing.Size(65, 13)
		Me._chkFamily_0.Location = New System.Drawing.Point(12, 24)
		Me._chkFamily_0.TabIndex = 19
		Me._chkFamily_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_0.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_0.BackColor = System.Drawing.SystemColors.Control
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
		Me._chkFamily_5.Text = "Plant"
		Me._chkFamily_5.Size = New System.Drawing.Size(53, 13)
		Me._chkFamily_5.Location = New System.Drawing.Point(80, 24)
		Me._chkFamily_5.TabIndex = 18
		Me._chkFamily_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_5.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_5.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_5.BackColor = System.Drawing.SystemColors.Control
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
		Me._chkFamily_4.Text = "Animal"
		Me._chkFamily_4.Size = New System.Drawing.Size(53, 13)
		Me._chkFamily_4.Location = New System.Drawing.Point(12, 104)
		Me._chkFamily_4.TabIndex = 17
		Me._chkFamily_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFamily_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFamily_4.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkFamily_4.BackColor = System.Drawing.SystemColors.Control
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
		Me.fraSize.Text = "Size"
		Me.fraSize.Size = New System.Drawing.Size(83, 129)
		Me.fraSize.Location = New System.Drawing.Point(164, 64)
		Me.fraSize.TabIndex = 15
		Me.fraSize.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraSize.BackColor = System.Drawing.SystemColors.Control
		Me.fraSize.Enabled = True
		Me.fraSize.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraSize.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraSize.Visible = True
		Me.fraSize.Padding = New System.Windows.Forms.Padding(0)
		Me.fraSize.Name = "fraSize"
		Me._OptSize_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptSize_4.Text = "Huge"
		Me._OptSize_4.Size = New System.Drawing.Size(73, 17)
		Me._OptSize_4.Location = New System.Drawing.Point(8, 104)
		Me._OptSize_4.TabIndex = 162
		Me._OptSize_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._OptSize_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptSize_4.BackColor = System.Drawing.SystemColors.Control
		Me._OptSize_4.CausesValidation = True
		Me._OptSize_4.Enabled = True
		Me._OptSize_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._OptSize_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._OptSize_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._OptSize_4.Appearance = System.Windows.Forms.Appearance.Normal
		Me._OptSize_4.TabStop = True
		Me._OptSize_4.Checked = False
		Me._OptSize_4.Visible = True
		Me._OptSize_4.Name = "_OptSize_4"
		Me._OptSize_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptSize_3.Text = "Large"
		Me._OptSize_3.Size = New System.Drawing.Size(73, 17)
		Me._OptSize_3.Location = New System.Drawing.Point(8, 84)
		Me._OptSize_3.TabIndex = 161
		Me._OptSize_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._OptSize_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptSize_3.BackColor = System.Drawing.SystemColors.Control
		Me._OptSize_3.CausesValidation = True
		Me._OptSize_3.Enabled = True
		Me._OptSize_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._OptSize_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._OptSize_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._OptSize_3.Appearance = System.Windows.Forms.Appearance.Normal
		Me._OptSize_3.TabStop = True
		Me._OptSize_3.Checked = False
		Me._OptSize_3.Visible = True
		Me._OptSize_3.Name = "_OptSize_3"
		Me._OptSize_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptSize_2.Text = "Normal"
		Me._OptSize_2.Size = New System.Drawing.Size(73, 17)
		Me._OptSize_2.Location = New System.Drawing.Point(8, 64)
		Me._OptSize_2.TabIndex = 160
		Me._OptSize_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._OptSize_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptSize_2.BackColor = System.Drawing.SystemColors.Control
		Me._OptSize_2.CausesValidation = True
		Me._OptSize_2.Enabled = True
		Me._OptSize_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._OptSize_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._OptSize_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._OptSize_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._OptSize_2.TabStop = True
		Me._OptSize_2.Checked = False
		Me._OptSize_2.Visible = True
		Me._OptSize_2.Name = "_OptSize_2"
		Me._OptSize_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptSize_1.Text = "Small"
		Me._OptSize_1.Size = New System.Drawing.Size(73, 17)
		Me._OptSize_1.Location = New System.Drawing.Point(8, 44)
		Me._OptSize_1.TabIndex = 159
		Me._OptSize_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._OptSize_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptSize_1.BackColor = System.Drawing.SystemColors.Control
		Me._OptSize_1.CausesValidation = True
		Me._OptSize_1.Enabled = True
		Me._OptSize_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._OptSize_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._OptSize_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._OptSize_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._OptSize_1.TabStop = True
		Me._OptSize_1.Checked = False
		Me._OptSize_1.Visible = True
		Me._OptSize_1.Name = "_OptSize_1"
		Me._OptSize_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptSize_0.Text = "Tiny"
		Me._OptSize_0.Size = New System.Drawing.Size(73, 17)
		Me._OptSize_0.Location = New System.Drawing.Point(8, 24)
		Me._OptSize_0.TabIndex = 158
		Me._OptSize_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._OptSize_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptSize_0.BackColor = System.Drawing.SystemColors.Control
		Me._OptSize_0.CausesValidation = True
		Me._OptSize_0.Enabled = True
		Me._OptSize_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._OptSize_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._OptSize_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._OptSize_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._OptSize_0.TabStop = True
		Me._OptSize_0.Checked = False
		Me._OptSize_0.Visible = True
		Me._OptSize_0.Name = "_OptSize_0"
		Me.Frame5.Text = "General"
		Me.Frame5.Size = New System.Drawing.Size(370, 61)
		Me.Frame5.Location = New System.Drawing.Point(4, 0)
		Me.Frame5.TabIndex = 14
		Me.Frame5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame5.BackColor = System.Drawing.SystemColors.Control
		Me.Frame5.Enabled = True
		Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame5.Visible = True
		Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame5.Name = "Frame5"
		Me.txtEterniumMax.AutoSize = False
		Me.txtEterniumMax.Enabled = False
		Me.txtEterniumMax.Size = New System.Drawing.Size(25, 19)
		Me.txtEterniumMax.Location = New System.Drawing.Point(111, 32)
		Me.txtEterniumMax.Maxlength = 3
		Me.txtEterniumMax.TabIndex = 165
		Me.txtEterniumMax.Text = "999"
		Me.txtEterniumMax.Visible = False
		Me.txtEterniumMax.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtEterniumMax.AcceptsReturn = True
		Me.txtEterniumMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtEterniumMax.BackColor = System.Drawing.SystemColors.Window
		Me.txtEterniumMax.CausesValidation = True
		Me.txtEterniumMax.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtEterniumMax.HideSelection = True
		Me.txtEterniumMax.ReadOnly = False
		Me.txtEterniumMax.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtEterniumMax.MultiLine = False
		Me.txtEterniumMax.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtEterniumMax.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtEterniumMax.TabStop = True
		Me.txtEterniumMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtEterniumMax.Name = "txtEterniumMax"
		Me.txtActionPts.AutoSize = False
		Me.txtActionPts.Enabled = False
		Me.txtActionPts.Size = New System.Drawing.Size(25, 19)
		Me.txtActionPts.Location = New System.Drawing.Point(321, 32)
		Me.txtActionPts.Maxlength = 3
		Me.txtActionPts.TabIndex = 88
		Me.txtActionPts.Text = "255"
		Me.txtActionPts.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtActionPts.AcceptsReturn = True
		Me.txtActionPts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtActionPts.BackColor = System.Drawing.SystemColors.Window
		Me.txtActionPts.CausesValidation = True
		Me.txtActionPts.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtActionPts.HideSelection = True
		Me.txtActionPts.ReadOnly = False
		Me.txtActionPts.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtActionPts.MultiLine = False
		Me.txtActionPts.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtActionPts.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtActionPts.TabStop = True
		Me.txtActionPts.Visible = True
		Me.txtActionPts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtActionPts.Name = "txtActionPts"
		Me.txtMovement.AutoSize = False
		Me.txtMovement.Enabled = False
		Me.txtMovement.Size = New System.Drawing.Size(25, 19)
		Me.txtMovement.Location = New System.Drawing.Point(266, 32)
		Me.txtMovement.Maxlength = 3
		Me.txtMovement.TabIndex = 86
		Me.txtMovement.Text = "255"
		Me.txtMovement.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMovement.AcceptsReturn = True
		Me.txtMovement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMovement.BackColor = System.Drawing.SystemColors.Window
		Me.txtMovement.CausesValidation = True
		Me.txtMovement.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMovement.HideSelection = True
		Me.txtMovement.ReadOnly = False
		Me.txtMovement.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMovement.MultiLine = False
		Me.txtMovement.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMovement.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMovement.TabStop = True
		Me.txtMovement.Visible = True
		Me.txtMovement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMovement.Name = "txtMovement"
		Me.txtWill.AutoSize = False
		Me.txtWill.Size = New System.Drawing.Size(25, 19)
		Me.txtWill.Location = New System.Drawing.Point(220, 32)
		Me.txtWill.Maxlength = 3
		Me.txtWill.TabIndex = 82
		Me.txtWill.Text = "255"
		Me.txtWill.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtWill.AcceptsReturn = True
		Me.txtWill.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtWill.BackColor = System.Drawing.SystemColors.Window
		Me.txtWill.CausesValidation = True
		Me.txtWill.Enabled = True
		Me.txtWill.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtWill.HideSelection = True
		Me.txtWill.ReadOnly = False
		Me.txtWill.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtWill.MultiLine = False
		Me.txtWill.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtWill.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtWill.TabStop = True
		Me.txtWill.Visible = True
		Me.txtWill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtWill.Name = "txtWill"
		Me.txtAgility.AutoSize = False
		Me.txtAgility.Size = New System.Drawing.Size(25, 19)
		Me.txtAgility.Location = New System.Drawing.Point(186, 32)
		Me.txtAgility.Maxlength = 3
		Me.txtAgility.TabIndex = 81
		Me.txtAgility.Text = "255"
		Me.txtAgility.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAgility.AcceptsReturn = True
		Me.txtAgility.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtAgility.BackColor = System.Drawing.SystemColors.Window
		Me.txtAgility.CausesValidation = True
		Me.txtAgility.Enabled = True
		Me.txtAgility.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtAgility.HideSelection = True
		Me.txtAgility.ReadOnly = False
		Me.txtAgility.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtAgility.MultiLine = False
		Me.txtAgility.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtAgility.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtAgility.TabStop = True
		Me.txtAgility.Visible = True
		Me.txtAgility.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtAgility.Name = "txtAgility"
		Me.txtStrength.AutoSize = False
		Me.txtStrength.Size = New System.Drawing.Size(25, 19)
		Me.txtStrength.Location = New System.Drawing.Point(151, 32)
		Me.txtStrength.Maxlength = 3
		Me.txtStrength.TabIndex = 80
		Me.txtStrength.Text = "255"
		Me.txtStrength.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStrength.AcceptsReturn = True
		Me.txtStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStrength.BackColor = System.Drawing.SystemColors.Window
		Me.txtStrength.CausesValidation = True
		Me.txtStrength.Enabled = True
		Me.txtStrength.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStrength.HideSelection = True
		Me.txtStrength.ReadOnly = False
		Me.txtStrength.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStrength.MultiLine = False
		Me.txtStrength.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStrength.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStrength.TabStop = True
		Me.txtStrength.Visible = True
		Me.txtStrength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStrength.Name = "txtStrength"
		Me.txtEternium.AutoSize = False
		Me.txtEternium.Size = New System.Drawing.Size(25, 19)
		Me.txtEternium.Location = New System.Drawing.Point(80, 32)
		Me.txtEternium.Maxlength = 3
		Me.txtEternium.TabIndex = 60
		Me.txtEternium.Text = "999"
		Me.txtEternium.Visible = False
		Me.txtEternium.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtEternium.AcceptsReturn = True
		Me.txtEternium.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtEternium.BackColor = System.Drawing.SystemColors.Window
		Me.txtEternium.CausesValidation = True
		Me.txtEternium.Enabled = True
		Me.txtEternium.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtEternium.HideSelection = True
		Me.txtEternium.ReadOnly = False
		Me.txtEternium.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtEternium.MultiLine = False
		Me.txtEternium.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtEternium.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtEternium.TabStop = True
		Me.txtEternium.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtEternium.Name = "txtEternium"
		Me.txtHPNow.AutoSize = False
		Me.txtHPNow.Size = New System.Drawing.Size(25, 19)
		Me.txtHPNow.Location = New System.Drawing.Point(10, 32)
		Me.txtHPNow.Maxlength = 3
		Me.txtHPNow.TabIndex = 36
		Me.txtHPNow.Text = "255"
		Me.txtHPNow.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHPNow.AcceptsReturn = True
		Me.txtHPNow.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtHPNow.BackColor = System.Drawing.SystemColors.Window
		Me.txtHPNow.CausesValidation = True
		Me.txtHPNow.Enabled = True
		Me.txtHPNow.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtHPNow.HideSelection = True
		Me.txtHPNow.ReadOnly = False
		Me.txtHPNow.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtHPNow.MultiLine = False
		Me.txtHPNow.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtHPNow.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtHPNow.TabStop = True
		Me.txtHPNow.Visible = True
		Me.txtHPNow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtHPNow.Name = "txtHPNow"
		Me.txtHPMax.AutoSize = False
		Me.txtHPMax.Size = New System.Drawing.Size(25, 19)
		Me.txtHPMax.Location = New System.Drawing.Point(43, 32)
		Me.txtHPMax.Maxlength = 3
		Me.txtHPMax.TabIndex = 35
		Me.txtHPMax.Text = "255"
		Me.txtHPMax.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHPMax.AcceptsReturn = True
		Me.txtHPMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtHPMax.BackColor = System.Drawing.SystemColors.Window
		Me.txtHPMax.CausesValidation = True
		Me.txtHPMax.Enabled = True
		Me.txtHPMax.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtHPMax.HideSelection = True
		Me.txtHPMax.ReadOnly = False
		Me.txtHPMax.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtHPMax.MultiLine = False
		Me.txtHPMax.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtHPMax.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtHPMax.TabStop = True
		Me.txtHPMax.Visible = True
		Me.txtHPMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtHPMax.Name = "txtHPMax"
		Me._Label1_15.BackColor = System.Drawing.Color.Transparent
		Me._Label1_15.Text = "/"
		Me._Label1_15.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_15.Size = New System.Drawing.Size(5, 13)
		Me._Label1_15.Location = New System.Drawing.Point(104, 36)
		Me._Label1_15.TabIndex = 166
		Me._Label1_15.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_15.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_15.Enabled = True
		Me._Label1_15.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_15.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_15.UseMnemonic = True
		Me._Label1_15.Visible = True
		Me._Label1_15.AutoSize = False
		Me._Label1_15.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_15.Name = "_Label1_15"
		Me._Label1_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._Label1_8.BackColor = System.Drawing.Color.Transparent
		Me._Label1_8.Text = "Action Pts"
		Me._Label1_8.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_8.Size = New System.Drawing.Size(65, 13)
		Me._Label1_8.Location = New System.Drawing.Point(303, 16)
		Me._Label1_8.TabIndex = 89
		Me._Label1_8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_8.Enabled = True
		Me._Label1_8.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_8.UseMnemonic = True
		Me._Label1_8.Visible = True
		Me._Label1_8.AutoSize = False
		Me._Label1_8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_8.Name = "_Label1_8"
		Me._Label1_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._Label1_0.BackColor = System.Drawing.Color.Transparent
		Me._Label1_0.Text = "MoveCost"
		Me._Label1_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_0.Size = New System.Drawing.Size(49, 13)
		Me._Label1_0.Location = New System.Drawing.Point(253, 16)
		Me._Label1_0.TabIndex = 87
		Me._Label1_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_0.Enabled = True
		Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_0.UseMnemonic = True
		Me._Label1_0.Visible = True
		Me._Label1_0.AutoSize = False
		Me._Label1_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_0.Name = "_Label1_0"
		Me._Label1_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._Label1_7.BackColor = System.Drawing.Color.Transparent
		Me._Label1_7.Text = "Intel"
		Me._Label1_7.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_7.Size = New System.Drawing.Size(29, 13)
		Me._Label1_7.Location = New System.Drawing.Point(219, 16)
		Me._Label1_7.TabIndex = 85
		Me._Label1_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_7.Enabled = True
		Me._Label1_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_7.UseMnemonic = True
		Me._Label1_7.Visible = True
		Me._Label1_7.AutoSize = False
		Me._Label1_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_7.Name = "_Label1_7"
		Me._Label1_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._Label1_6.BackColor = System.Drawing.Color.Transparent
		Me._Label1_6.Text = "Agility"
		Me._Label1_6.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_6.Size = New System.Drawing.Size(33, 13)
		Me._Label1_6.Location = New System.Drawing.Point(183, 16)
		Me._Label1_6.TabIndex = 84
		Me._Label1_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_6.Enabled = True
		Me._Label1_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_6.UseMnemonic = True
		Me._Label1_6.Visible = True
		Me._Label1_6.AutoSize = False
		Me._Label1_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_6.Name = "_Label1_6"
		Me._Label1_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._Label1_5.BackColor = System.Drawing.Color.Transparent
		Me._Label1_5.Text = "Strgth"
		Me._Label1_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_5.Size = New System.Drawing.Size(33, 13)
		Me._Label1_5.Location = New System.Drawing.Point(147, 16)
		Me._Label1_5.TabIndex = 83
		Me._Label1_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_5.Enabled = True
		Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_5.UseMnemonic = True
		Me._Label1_5.Visible = True
		Me._Label1_5.AutoSize = False
		Me._Label1_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_5.Name = "_Label1_5"
		Me._Label1_3.BackColor = System.Drawing.Color.Transparent
		Me._Label1_3.Text = "/"
		Me._Label1_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_3.Size = New System.Drawing.Size(5, 13)
		Me._Label1_3.Location = New System.Drawing.Point(36, 36)
		Me._Label1_3.TabIndex = 62
		Me._Label1_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_3.Enabled = True
		Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_3.UseMnemonic = True
		Me._Label1_3.Visible = True
		Me._Label1_3.AutoSize = False
		Me._Label1_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_3.Name = "_Label1_3"
		Me._Label1_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._Label1_1.BackColor = System.Drawing.Color.Transparent
		Me._Label1_1.Text = "Eternium"
		Me._Label1_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_1.Size = New System.Drawing.Size(69, 13)
		Me._Label1_1.Location = New System.Drawing.Point(72, 16)
		Me._Label1_1.TabIndex = 61
		Me._Label1_1.Visible = False
		Me._Label1_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_1.Enabled = True
		Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_1.UseMnemonic = True
		Me._Label1_1.AutoSize = False
		Me._Label1_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_1.Name = "_Label1_1"
		Me._Label1_2.BackColor = System.Drawing.Color.Transparent
		Me._Label1_2.Text = "Health"
		Me._Label1_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Label1_2.Size = New System.Drawing.Size(35, 13)
		Me._Label1_2.Location = New System.Drawing.Point(22, 16)
		Me._Label1_2.TabIndex = 37
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
		Me.lblHome.Text = "Home tome"
		Me.lblHome.Size = New System.Drawing.Size(65, 25)
		Me.lblHome.Location = New System.Drawing.Point(8, 198)
		Me.lblHome.TabIndex = 163
		Me.lblHome.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHome.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblHome.BackColor = System.Drawing.SystemColors.Control
		Me.lblHome.Enabled = True
		Me.lblHome.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblHome.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblHome.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblHome.UseMnemonic = True
		Me.lblHome.Visible = True
		Me.lblHome.AutoSize = False
		Me.lblHome.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblHome.Name = "lblHome"
		Me.Label2.Text = "Combat Rank"
		Me.Label2.Size = New System.Drawing.Size(109, 13)
		Me.Label2.Location = New System.Drawing.Point(256, 164)
		Me.Label2.TabIndex = 151
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
		Me.btnXP_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnXP_Value.BackColor = System.Drawing.SystemColors.Control
		Me.btnXP_Value.Text = "XP value"
		Me.btnXP_Value.Enabled = False
		Me.btnXP_Value.Size = New System.Drawing.Size(73, 21)
		Me.btnXP_Value.Location = New System.Drawing.Point(72, 256)
		Me.btnXP_Value.TabIndex = 157
		Me.btnXP_Value.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnXP_Value.CausesValidation = True
		Me.btnXP_Value.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnXP_Value.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnXP_Value.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnXP_Value.TabStop = True
		Me.btnXP_Value.Name = "btnXP_Value"
		Me.picMask.BackColor = System.Drawing.SystemColors.Window
		Me.picMask.ForeColor = System.Drawing.SystemColors.WindowText
		Me.picMask.Size = New System.Drawing.Size(89, 81)
		Me.picMask.Location = New System.Drawing.Point(92, 294)
		Me.picMask.TabIndex = 34
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
		Me.picMons.Size = New System.Drawing.Size(81, 81)
		Me.picMons.Location = New System.Drawing.Point(4, 294)
		Me.picMons.TabIndex = 33
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
		Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.Size = New System.Drawing.Size(73, 21)
		Me.btnCancel.Location = New System.Drawing.Point(236, 256)
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
		Me.btnOk.Location = New System.Drawing.Point(156, 256)
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
		Me.btnApply.Location = New System.Drawing.Point(316, 256)
		Me.btnApply.TabIndex = 0
		Me.btnApply.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnApply.CausesValidation = True
		Me.btnApply.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnApply.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnApply.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnApply.TabStop = True
		Me.btnApply.Name = "btnApply"
		tabMonsProp.OcxState = CType(resources.GetObject("tabMonsProp.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tabMonsProp.Size = New System.Drawing.Size(385, 245)
		Me.tabMonsProp.Location = New System.Drawing.Point(4, 4)
		Me.tabMonsProp.TabIndex = 3
		Me.tabMonsProp.Name = "tabMonsProp"
		Me.Label1.SetIndex(_Label1_4, CType(4, Short))
		Me.Label1.SetIndex(_Label1_17, CType(17, Short))
		Me.Label1.SetIndex(_Label1_9, CType(9, Short))
		Me.Label1.SetIndex(_Label1_21, CType(21, Short))
		Me.Label1.SetIndex(_Label1_16, CType(16, Short))
		Me.Label1.SetIndex(_Label1_14, CType(14, Short))
		Me.Label1.SetIndex(_Label1_13, CType(13, Short))
		Me.Label1.SetIndex(_Label1_12, CType(12, Short))
		Me.Label1.SetIndex(_Label1_11, CType(11, Short))
		Me.Label1.SetIndex(_Label1_10, CType(10, Short))
		Me.Label1.SetIndex(_Label1_15, CType(15, Short))
		Me.Label1.SetIndex(_Label1_8, CType(8, Short))
		Me.Label1.SetIndex(_Label1_0, CType(0, Short))
		Me.Label1.SetIndex(_Label1_7, CType(7, Short))
		Me.Label1.SetIndex(_Label1_6, CType(6, Short))
		Me.Label1.SetIndex(_Label1_5, CType(5, Short))
		Me.Label1.SetIndex(_Label1_3, CType(3, Short))
		Me.Label1.SetIndex(_Label1_1, CType(1, Short))
		Me.Label1.SetIndex(_Label1_2, CType(2, Short))
		Me.OptSize.SetIndex(_OptSize_4, CType(4, Short))
		Me.OptSize.SetIndex(_OptSize_3, CType(3, Short))
		Me.OptSize.SetIndex(_OptSize_2, CType(2, Short))
		Me.OptSize.SetIndex(_OptSize_1, CType(1, Short))
		Me.OptSize.SetIndex(_OptSize_0, CType(0, Short))
		Me.chkFamily.SetIndex(_chkFamily_9, CType(9, Short))
		Me.chkFamily.SetIndex(_chkFamily_7, CType(7, Short))
		Me.chkFamily.SetIndex(_chkFamily_8, CType(8, Short))
		Me.chkFamily.SetIndex(_chkFamily_6, CType(6, Short))
		Me.chkFamily.SetIndex(_chkFamily_3, CType(3, Short))
		Me.chkFamily.SetIndex(_chkFamily_2, CType(2, Short))
		Me.chkFamily.SetIndex(_chkFamily_1, CType(1, Short))
		Me.chkFamily.SetIndex(_chkFamily_0, CType(0, Short))
		Me.chkFamily.SetIndex(_chkFamily_5, CType(5, Short))
		Me.chkFamily.SetIndex(_chkFamily_4, CType(4, Short))
		Me.cmbArmor.SetIndex(_cmbArmor_7, CType(7, Short))
		Me.cmbArmor.SetIndex(_cmbArmor_6, CType(6, Short))
		Me.cmbArmor.SetIndex(_cmbArmor_5, CType(5, Short))
		Me.cmbArmor.SetIndex(_cmbArmor_4, CType(4, Short))
		Me.cmbArmor.SetIndex(_cmbArmor_3, CType(3, Short))
		Me.cmbArmor.SetIndex(_cmbArmor_2, CType(2, Short))
		Me.cmbArmor.SetIndex(_cmbArmor_1, CType(1, Short))
		Me.cmbArmor.SetIndex(_cmbArmor_0, CType(0, Short))
		Me.cmbResistance.SetIndex(_cmbResistance_7, CType(7, Short))
		Me.cmbResistance.SetIndex(_cmbResistance_6, CType(6, Short))
		Me.cmbResistance.SetIndex(_cmbResistance_5, CType(5, Short))
		Me.cmbResistance.SetIndex(_cmbResistance_4, CType(4, Short))
		Me.cmbResistance.SetIndex(_cmbResistance_3, CType(3, Short))
		Me.cmbResistance.SetIndex(_cmbResistance_2, CType(2, Short))
		Me.cmbResistance.SetIndex(_cmbResistance_1, CType(1, Short))
		Me.cmbResistance.SetIndex(_cmbResistance_0, CType(0, Short))
		Me.fraMonsProp.SetIndex(_fraMonsProp_0, CType(0, Short))
		Me.fraMonsProp.SetIndex(_fraMonsProp_4, CType(4, Short))
		Me.fraMonsProp.SetIndex(_fraMonsProp_3, CType(3, Short))
		Me.fraMonsProp.SetIndex(_fraMonsProp_2, CType(2, Short))
		Me.fraMonsProp.SetIndex(_fraMonsProp_1, CType(1, Short))
		Me.lblArmor.SetIndex(_lblArmor_26, CType(26, Short))
		Me.lblArmor.SetIndex(_lblArmor_25, CType(25, Short))
		Me.lblArmor.SetIndex(_lblArmor_24, CType(24, Short))
		Me.lblArmor.SetIndex(_lblArmor_23, CType(23, Short))
		Me.lblArmor.SetIndex(_lblArmor_22, CType(22, Short))
		Me.lblArmor.SetIndex(_lblArmor_21, CType(21, Short))
		Me.lblArmor.SetIndex(_lblArmor_20, CType(20, Short))
		Me.lblArmor.SetIndex(_lblArmor_19, CType(19, Short))
		Me.lblArmor.SetIndex(_lblArmor_18, CType(18, Short))
		Me.lblArmor.SetIndex(_lblArmor_17, CType(17, Short))
		Me.lblArmor.SetIndex(_lblArmor_16, CType(16, Short))
		Me.lblArmor.SetIndex(_lblArmor_15, CType(15, Short))
		Me.lblArmor.SetIndex(_lblArmor_14, CType(14, Short))
		Me.lblArmor.SetIndex(_lblArmor_13, CType(13, Short))
		Me.lblArmor.SetIndex(_lblArmor_12, CType(12, Short))
		Me.lblArmor.SetIndex(_lblArmor_11, CType(11, Short))
		Me.lblArmor.SetIndex(_lblArmor_10, CType(10, Short))
		Me.lblArmor.SetIndex(_lblArmor_9, CType(9, Short))
		Me.lblArmor.SetIndex(_lblArmor_8, CType(8, Short))
		Me.lblArmor.SetIndex(_lblArmor_7, CType(7, Short))
		Me.lblArmor.SetIndex(_lblArmor_6, CType(6, Short))
		Me.lblArmor.SetIndex(_lblArmor_5, CType(5, Short))
		Me.lblArmor.SetIndex(_lblArmor_4, CType(4, Short))
		Me.lblArmor.SetIndex(_lblArmor_3, CType(3, Short))
		Me.lblArmor.SetIndex(_lblArmor_2, CType(2, Short))
		Me.lblArmor.SetIndex(_lblArmor_0, CType(0, Short))
		Me.lblArmor.SetIndex(_lblArmor_1, CType(1, Short))
		Me.lblName.SetIndex(_lblName_1, CType(1, Short))
		Me.lblRace.SetIndex(_lblRace_0, CType(0, Short))
		Me.lblWAV.SetIndex(_lblWAV_0, CType(0, Short))
		Me.lblWeakness.SetIndex(_lblWeakness_7, CType(7, Short))
		Me.lblWeakness.SetIndex(_lblWeakness_6, CType(6, Short))
		Me.lblWeakness.SetIndex(_lblWeakness_5, CType(5, Short))
		Me.lblWeakness.SetIndex(_lblWeakness_4, CType(4, Short))
		Me.lblWeakness.SetIndex(_lblWeakness_3, CType(3, Short))
		Me.lblWeakness.SetIndex(_lblWeakness_2, CType(2, Short))
		Me.lblWeakness.SetIndex(_lblWeakness_1, CType(1, Short))
		Me.lblWeakness.SetIndex(_lblWeakness_0, CType(0, Short))
		Me.txtAR.SetIndex(_txtAR_7, CType(7, Short))
		Me.txtAR.SetIndex(_txtAR_6, CType(6, Short))
		Me.txtAR.SetIndex(_txtAR_5, CType(5, Short))
		Me.txtAR.SetIndex(_txtAR_4, CType(4, Short))
		Me.txtAR.SetIndex(_txtAR_3, CType(3, Short))
		Me.txtAR.SetIndex(_txtAR_2, CType(2, Short))
		Me.txtAR.SetIndex(_txtAR_1, CType(1, Short))
		Me.txtAR.SetIndex(_txtAR_0, CType(0, Short))
		CType(Me.txtAR, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblWeakness, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblWAV, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblRace, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblArmor, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.fraMonsProp, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmbResistance, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmbArmor, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chkFamily, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.OptSize, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tabMonsProp, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(_fraMonsProp_0)
		Me.Controls.Add(_fraMonsProp_4)
		Me.Controls.Add(_fraMonsProp_3)
		Me.Controls.Add(_fraMonsProp_2)
		Me.Controls.Add(_fraMonsProp_1)
		Me.Controls.Add(btnXP_Value)
		Me.Controls.Add(picMask)
		Me.Controls.Add(picMons)
		Me.Controls.Add(btnCancel)
		Me.Controls.Add(btnOk)
		Me.Controls.Add(btnApply)
		Me.Controls.Add(tabMonsProp)
		Me._fraMonsProp_0.Controls.Add(Frame1)
		Me._fraMonsProp_0.Controls.Add(fraMonsPic)
		Me.Frame1.Controls.Add(chkIsMale)
		Me.Frame1.Controls.Add(chkIsInanimate)
		Me.Frame1.Controls.Add(txtSkillPoints)
		Me.Frame1.Controls.Add(txtExperiencePoints)
		Me.Frame1.Controls.Add(txtLevel)
		Me.Frame1.Controls.Add(chkRequiredInTome)
		Me.Frame1.Controls.Add(chkFriend)
		Me.Frame1.Controls.Add(chkOnAdventure)
		Me.Frame1.Controls.Add(txtRace)
		Me.Frame1.Controls.Add(chkGuard)
		Me.Frame1.Controls.Add(chkAgressive)
		Me.Frame1.Controls.Add(chkDMControlled)
		Me.Frame1.Controls.Add(txtName)
		Me.Frame1.Controls.Add(txtComments)
		Me.Frame1.Controls.Add(_Label1_4)
		Me.Frame1.Controls.Add(_Label1_17)
		Me.Frame1.Controls.Add(_Label1_9)
		Me.Frame1.Controls.Add(_lblRace_0)
		Me.Frame1.Controls.Add(_lblName_1)
		Me.Frame1.Controls.Add(_Label1_21)
		Me.fraMonsPic.Controls.Add(btnPortrait)
		Me.fraMonsPic.Controls.Add(picCreature)
		Me.fraMonsPic.Controls.Add(btnBrowseRight)
		Me.fraMonsPic.Controls.Add(btnBrowseLeft)
		Me.fraMonsPic.Controls.Add(btnBrowse)
		Me.ShapeContainer1.Shapes.Add(shpFace)
		Me.picCreature.Controls.Add(ShapeContainer1)
		Me._fraMonsProp_4.Controls.Add(btnDead)
		Me._fraMonsProp_4.Controls.Add(picDead)
		Me._fraMonsProp_4.Controls.Add(Frame7)
		Me._fraMonsProp_4.Controls.Add(lstWAV)
		Me._fraMonsProp_4.Controls.Add(lblDead)
		Me._fraMonsProp_4.Controls.Add(_lblWAV_0)
		Me.Frame7.Controls.Add(chkWAV)
		Me.Frame7.Controls.Add(btnPlayWAV)
		Me.Frame7.Controls.Add(btnBrowseWAV)
		Me.Frame7.Controls.Add(cmbWAV)
		Me._fraMonsProp_3.Controls.Add(btnLibrary)
		Me._fraMonsProp_3.Controls.Add(btnPaste)
		Me._fraMonsProp_3.Controls.Add(btnCopy)
		Me._fraMonsProp_3.Controls.Add(lstThings)
		Me._fraMonsProp_3.Controls.Add(btnEdit)
		Me._fraMonsProp_3.Controls.Add(btnInsert)
		Me._fraMonsProp_3.Controls.Add(btnCut)
		Me._fraMonsProp_3.Controls.Add(lblAttached)
		Me._fraMonsProp_2.Controls.Add(Frame3)
		Me._fraMonsProp_2.Controls.Add(Frame4)
		Me.Frame3.Controls.Add(_cmbResistance_7)
		Me.Frame3.Controls.Add(_cmbResistance_6)
		Me.Frame3.Controls.Add(_cmbResistance_5)
		Me.Frame3.Controls.Add(_cmbResistance_4)
		Me.Frame3.Controls.Add(_cmbResistance_3)
		Me.Frame3.Controls.Add(_cmbResistance_2)
		Me.Frame3.Controls.Add(_cmbResistance_1)
		Me.Frame3.Controls.Add(_cmbResistance_0)
		Me.Frame3.Controls.Add(_lblWeakness_7)
		Me.Frame3.Controls.Add(_lblWeakness_6)
		Me.Frame3.Controls.Add(_lblWeakness_5)
		Me.Frame3.Controls.Add(_lblWeakness_4)
		Me.Frame3.Controls.Add(_lblWeakness_3)
		Me.Frame3.Controls.Add(_lblWeakness_2)
		Me.Frame3.Controls.Add(_lblWeakness_1)
		Me.Frame3.Controls.Add(_lblWeakness_0)
		Me.Frame4.Controls.Add(cmbBodyType)
		Me.Frame4.Controls.Add(_cmbArmor_7)
		Me.Frame4.Controls.Add(_txtAR_7)
		Me.Frame4.Controls.Add(_cmbArmor_6)
		Me.Frame4.Controls.Add(_txtAR_6)
		Me.Frame4.Controls.Add(_cmbArmor_5)
		Me.Frame4.Controls.Add(_txtAR_5)
		Me.Frame4.Controls.Add(_cmbArmor_4)
		Me.Frame4.Controls.Add(_txtAR_4)
		Me.Frame4.Controls.Add(_cmbArmor_3)
		Me.Frame4.Controls.Add(_txtAR_3)
		Me.Frame4.Controls.Add(_cmbArmor_2)
		Me.Frame4.Controls.Add(_txtAR_2)
		Me.Frame4.Controls.Add(_cmbArmor_1)
		Me.Frame4.Controls.Add(_txtAR_1)
		Me.Frame4.Controls.Add(_cmbArmor_0)
		Me.Frame4.Controls.Add(_txtAR_0)
		Me.Frame4.Controls.Add(_lblArmor_26)
		Me.Frame4.Controls.Add(_lblArmor_25)
		Me.Frame4.Controls.Add(_lblArmor_24)
		Me.Frame4.Controls.Add(_lblArmor_23)
		Me.Frame4.Controls.Add(_lblArmor_22)
		Me.Frame4.Controls.Add(_lblArmor_21)
		Me.Frame4.Controls.Add(_lblArmor_20)
		Me.Frame4.Controls.Add(_lblArmor_19)
		Me.Frame4.Controls.Add(_lblArmor_18)
		Me.Frame4.Controls.Add(_lblArmor_17)
		Me.Frame4.Controls.Add(_lblArmor_16)
		Me.Frame4.Controls.Add(_lblArmor_15)
		Me.Frame4.Controls.Add(_lblArmor_14)
		Me.Frame4.Controls.Add(_lblArmor_13)
		Me.Frame4.Controls.Add(_lblArmor_12)
		Me.Frame4.Controls.Add(_lblArmor_11)
		Me.Frame4.Controls.Add(_lblArmor_10)
		Me.Frame4.Controls.Add(_lblArmor_9)
		Me.Frame4.Controls.Add(_lblArmor_8)
		Me.Frame4.Controls.Add(_lblArmor_7)
		Me.Frame4.Controls.Add(_lblArmor_6)
		Me.Frame4.Controls.Add(_lblArmor_5)
		Me.Frame4.Controls.Add(_lblArmor_4)
		Me.Frame4.Controls.Add(_lblArmor_3)
		Me.Frame4.Controls.Add(_lblArmor_2)
		Me.Frame4.Controls.Add(_lblArmor_0)
		Me.Frame4.Controls.Add(_lblArmor_1)
		Me._fraMonsProp_1.Controls.Add(txtHome)
		Me._fraMonsProp_1.Controls.Add(cmbCombatRank)
		Me._fraMonsProp_1.Controls.Add(Frame9)
		Me._fraMonsProp_1.Controls.Add(Frame6)
		Me._fraMonsProp_1.Controls.Add(fraSize)
		Me._fraMonsProp_1.Controls.Add(Frame5)
		Me._fraMonsProp_1.Controls.Add(lblHome)
		Me._fraMonsProp_1.Controls.Add(Label2)
		Me.Frame9.Controls.Add(txtGreed)
		Me.Frame9.Controls.Add(txtLust)
		Me.Frame9.Controls.Add(txtLunacy)
		Me.Frame9.Controls.Add(txtPride)
		Me.Frame9.Controls.Add(txtWrath)
		Me.Frame9.Controls.Add(txtRevelry)
		Me.Frame9.Controls.Add(_Label1_16)
		Me.Frame9.Controls.Add(_Label1_14)
		Me.Frame9.Controls.Add(_Label1_13)
		Me.Frame9.Controls.Add(_Label1_12)
		Me.Frame9.Controls.Add(_Label1_11)
		Me.Frame9.Controls.Add(_Label1_10)
		Me.Frame6.Controls.Add(_chkFamily_9)
		Me.Frame6.Controls.Add(_chkFamily_7)
		Me.Frame6.Controls.Add(_chkFamily_8)
		Me.Frame6.Controls.Add(_chkFamily_6)
		Me.Frame6.Controls.Add(_chkFamily_3)
		Me.Frame6.Controls.Add(_chkFamily_2)
		Me.Frame6.Controls.Add(_chkFamily_1)
		Me.Frame6.Controls.Add(_chkFamily_0)
		Me.Frame6.Controls.Add(_chkFamily_5)
		Me.Frame6.Controls.Add(_chkFamily_4)
		Me.fraSize.Controls.Add(_OptSize_4)
		Me.fraSize.Controls.Add(_OptSize_3)
		Me.fraSize.Controls.Add(_OptSize_2)
		Me.fraSize.Controls.Add(_OptSize_1)
		Me.fraSize.Controls.Add(_OptSize_0)
		Me.Frame5.Controls.Add(txtEterniumMax)
		Me.Frame5.Controls.Add(txtActionPts)
		Me.Frame5.Controls.Add(txtMovement)
		Me.Frame5.Controls.Add(txtWill)
		Me.Frame5.Controls.Add(txtAgility)
		Me.Frame5.Controls.Add(txtStrength)
		Me.Frame5.Controls.Add(txtEternium)
		Me.Frame5.Controls.Add(txtHPNow)
		Me.Frame5.Controls.Add(txtHPMax)
		Me.Frame5.Controls.Add(_Label1_15)
		Me.Frame5.Controls.Add(_Label1_8)
		Me.Frame5.Controls.Add(_Label1_0)
		Me.Frame5.Controls.Add(_Label1_7)
		Me.Frame5.Controls.Add(_Label1_6)
		Me.Frame5.Controls.Add(_Label1_5)
		Me.Frame5.Controls.Add(_Label1_3)
		Me.Frame5.Controls.Add(_Label1_1)
		Me.Frame5.Controls.Add(_Label1_2)
		Me._fraMonsProp_0.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.fraMonsPic.ResumeLayout(False)
		Me.picCreature.ResumeLayout(False)
		Me._fraMonsProp_4.ResumeLayout(False)
		Me.Frame7.ResumeLayout(False)
		Me._fraMonsProp_3.ResumeLayout(False)
		Me._fraMonsProp_2.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.Frame4.ResumeLayout(False)
		Me._fraMonsProp_1.ResumeLayout(False)
		Me.Frame9.ResumeLayout(False)
		Me.Frame6.ResumeLayout(False)
		Me.fraSize.ResumeLayout(False)
		Me.Frame5.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class