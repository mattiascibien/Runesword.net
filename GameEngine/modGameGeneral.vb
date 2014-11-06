Option Strict Off
Option Explicit On
Module modGameGeneral
	
	' [Titi 2.4.9b] added to handle the Alt-Tab and Ctrl-Esc key combinations
	Private Const WH_KEYBOARD_LL As Short = 13 'enables monitoring of keyboard input events about to be posted in a thread input queue
	Private Const HC_ACTION As Short = 0 'wParam and lParam parameters contain information about a keyboard message
	Private Const LLKHF_EXTENDED As Integer = &H1 'test the extended-key flag
	Private Const LLKHF_INJECTED As Integer = &H10 'test the event-injected flag
	Private Const LLKHF_ALTDOWN As Integer = &H20 'test the context code
	Private Const LLKHF_UP As Integer = &H80 'test the transition-state flag
	Private Const VK_TAB As Integer = &H9 'virtual key constants
	Private Const VK_CONTROL As Integer = &H11
	Private Const VK_ESCAPE As Integer = &H1B
	Private Structure KBDLLHOOKSTRUCT
		Dim vkCode As Integer 'a virtual-key code in the range 1 to 254
		Dim scanCode As Integer 'hardware scan code for the key
		Dim flags As Integer 'specifies the extended-key flag, event-injected flag, context code, and transition-state flag
		Dim time As Integer 'time stamp for this message
		Dim dwExtraInfo As Integer 'extra info associated with the message
	End Structure
	
	Private Declare Function SetWindowsHookEx Lib "user32"  Alias "SetWindowsHookExA"(ByVal idHook As Integer, ByVal lpfn As Integer, ByVal hmod As Integer, ByVal dwThreadId As Integer) As Integer
	Private Declare Function UnhookWindowsHookEx Lib "user32" (ByVal hHook As Integer) As Integer
	Private Declare Function CallNextHookEx Lib "user32" (ByVal hHook As Integer, ByVal nCode As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
	Private Declare Sub CopyMemory Lib "kernel32"  Alias "RtlMoveMemory"(ByRef pDest As Any, ByRef pSource As Any, ByVal cb As Integer)
	Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
	Private m_hDllKbdHook As Integer 'private variable holding the handle to the hook procedure
	
	' [Titi 2.4.9b] System tray icon
	Public OldWindowProc As Integer
	Public TheForm As System.Windows.Forms.Form
	Public TheMenu As System.Windows.Forms.ToolStripMenuItem
	Declare Function CallWindowProc Lib "user32"  Alias "CallWindowProcA"(ByVal lpPrevWndFunc As Integer, ByVal hWnd As Integer, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
	Declare Function SetWindowLong Lib "user32"  Alias "SetWindowLongA"(ByVal hWnd As Integer, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
	'UPGRADE_WARNING: Structure NOTIFYICONDATA may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Declare Function Shell_NotifyIcon Lib "shell32.dll"  Alias "Shell_NotifyIconA"(ByVal dwMessage As Integer, ByRef lpData As NOTIFYICONDATA) As Integer
	Public Const WM_USER As Integer = &H400
	Public Const WM_LBUTTONUP As Integer = &H202
	Public Const WM_MBUTTONUP As Integer = &H208
	Public Const WM_RBUTTONUP As Integer = &H205
	Public Const TRAY_CALLBACK As Decimal = (WM_USER + 1001)
	Public Const GWL_WNDPROC As Short = (-4)
	Public Const GWL_USERDATA As Short = (-21)
	Public Const NIF_ICON As Integer = &H2
	Public Const NIF_TIP As Integer = &H4
	Public Const NIM_ADD As Integer = &H0
	Public Const NIF_MESSAGE As Integer = &H1
	Public Const NIM_MODIFY As Integer = &H1
	Public Const NIM_DELETE As Integer = &H2
	Public Structure NOTIFYICONDATA
		Dim cbSize As Integer
		Dim hWnd As Integer
		Dim uID As Integer
		Dim uFlags As Integer
		Dim uCallbackMessage As Integer
		Dim hIcon As Integer
		'UPGRADE_WARNING: Fixed-length string size must fit in the buffer. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="3C1E4426-0B80-443E-B943-0627CD55D48B"'
		<VBFixedString(64),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray,SizeConst:=64)> Public szTip() As Char
	End Structure
	Private TheData As NOTIFYICONDATA
	Private Declare Function SetForegroundWindow Lib "user32" (ByVal hWnd As Integer) As Integer
	Private Declare Function PostMessage Lib "user32"  Alias "PostMessageA"(ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
	Private Const WM_NULL As Integer = &H0
	'[Titi 2.4.9b] all the above added for the system tray icon
	
	' Nasty Nasty variable be vawie vawie carefull with this one
	Public Frozen As Short
	
	' Reference to current Tome
	'Public Tome As New Tome
	' Reference to current Plot
	'Public Area As New Area
	' Reference to current Map in Plot
	Public Map As New Map
	
	' Reference to current Encounter in Map
	Public EncounterNow As New Encounter
	' Always points to the current Creature taking a turn
	Public CreatureWithTurn As New Creature
	' Points to Creature Selling objects
	Public CreatureSelling As Creature
	' Below are all used by Triggers ONLY
	Public CreatureNow As New Creature
	Public CreatureTarget As New Creature
	Public ItemNow As New Item
	Public ItemTarget As New Item
	
	' Creatures now in Menu
	Public MenuParty(4) As Creature
	Public MenuPartyIndex As Short
	' Stack of Text for DialogBrief
	Public DialogBriefSet As New Collection
	
	' Font related variables
	Public aX(3, 89) As Short
	Public aY(3, 89) As Short
	Public aW(3, 89) As Short
	Public Const bdFontSmallWhite As Short = 0
	Public Const bdFontNoxiousWhite As Short = 1
	Public Const bdFontNoxiousGold As Short = 2
	Public Const bdFontNoxiousGrey As Short = 3
	Public Const bdFontNoxiousBlack As Short = 4
	Public Const bdFontElixirWhite As Short = 5
	Public Const bdFontElixirGold As Short = 6
	Public Const bdFontElixirGrey As Short = 7
	Public Const bdFontElixirBlack As Short = 8
	Public Const bdFontLargeWhite As Short = 9
	
	' Variables to store Create Character information
	Public TomeList As Collection
	Public TomeRoster As Collection
	Public TomeRosterSelect As Short
	Public TomeMenu As Short
	Public TomeAction As Short
	Public TomeIndex As Short
	Public TomeRosterTop As Short
	Public TomeRosterDragX, TomeRosterDrag, TomeRosterDragY As Short
	Public TomeListTop As Short
	Public Worlds As Collection
	' Public WorldNow As World
	' moved to modBD for compatibility with world settings creation
	Public KingdomNow As Kingdom
	Public KingdomIndex As Short
	' Public KingdomNames(11) As String
	' moved to modBD for compatibility with world settings creation
	Public CreateNameNew As String
	Public CreateSkillsIndex As Short
	Public CreateNameIndex As Short
	Public CreatePictureIndex As Short
	Public CreatePCReturn As Short
	Public TomeSavePos As Short
	Public TomeSavePathName As String
	Public CombatAction1, CombatAction2 As Short
	
	Public Const bdTomeNew As Short = 0
	Public Const bdTomeGather As Short = 1
	Public Const bdCreatePCKingdom As Short = 2
	Public Const bdCreatePCPicture As Short = 3
	Public Const bdCreatePCSkills As Short = 4
	Public Const bdCreatePCName As Short = 5
	Public Const bdTomeSaves As Short = 6
	Public Const bdTomeOptions As Short = 7
	Public Const bdTomeSaveAs As Short = 8
	Public Const bdMenuSkill As Short = 9
	' [Titi 2.6.0] sub-menus added
	Public Const bdTomePackage As Short = 10
	Public Const bdTomeMenu As Short = 11
	Public Const bdWorldMenu As Short = 12
	Public Const bdCharacterMenu As Short = 13
	
	' Game Options
	'Public Const bdOptionsCount As Integer = 13
	Public Const bdOptionsCount As Short = 17
	Public GlobalInterfaceList As Collection
	Public GlobalInterfaceIndex As Short
	Public GlobalDiceList As Collection
	Public GlobalDiceIndex As Short
	' [Titi 2.4.9] ASCII code of shortcuts
	Public bdKey(25) As Short
	' [Titi 2.4.9] Automatic centering of the map on the party?
	Public GlobalAutoCenter As Short
	
	' Constants for Misc Interface Pieces
	Public Const bdIntWidth As Short = 90
	Public Const bdIntHeight As Short = 16
	
	' Variables for Tome Wizard
	Public TomeWizardParty As Short
	Public TomeWizardLevel As Short
	Public TomeWizardStory As Short
	Public TomeWizardSize As Short
	Public UberWizMaps As UberWizard
	Public BuildMessage As String
	
	' Scratch variables
	Public Darker As Short
	Public DarkDir As Short
	
	' Scroll Box Variables
	Public ScrollThumbY As Short
	Public ScrollTop As Short
	Public ScrollSelect As Short
	Public ScrollList As Collection
	Public ScrollList2 As Collection
	Public ScrollList3 As Collection ' [Titi 2.5.1] added for skills filtering purposes
	Public JournalThumbY As Short
	Public JournalTop As Short
	Public JournalList As Collection
	
	' Sorcery variables
	Public GlobalSaveStyle As Short
	
	' Create Character variables
	Public Const bdCPCShowStats As Short = 0
	Public Const bdCPCShowSkills As Short = 1
	Public Const bdCPCShowNoName As Short = 2
	Public Const bdFaceDM As Short = 198
	Public Const bdFaceBlank As Short = 132
	Public Const bdFaceScroll As Short = 264
	Public Const bdFaceSelect As Short = 330
	Public Const bdFaceNoTraps As Short = 462 ' [Titi 2.6.0] No traps picture
	'Public Const bdFaceMin As Integer = 462
	Public Const bdFaceMin As Short = 528
	
	' Inventory variables
	Public InvX(128) As Short
	Public InvY(128) As Short
	Public InvZ(128) As Short
	Public InvC(80) As Short
	Public InvDragMode As Short
	Public InvDragItem As New Item
	Public InvDragPos As Short
	Public InvDragIndex As Short
	Public InvContainer As Item
	Public InvNowShow As Short
	Public InvTopIndex As Short
	Public InvTooMany As Short
	
	Public Const bdInvItems As Short = 0
	Public Const bdInvStatus As Short = 1
	Public Const bdInvObjects As Short = 0
	Public Const bdInvWear As Short = 1
	Public Const bdInvContainer As Short = 2
	Public Const bdInvEncounter As Short = 3
	Public Const bdInvParty As Short = 4
	
	'Public Const bdDlgNoReply As Integer = 0
	'Public Const bdDlgWithReply As Integer = 1
	'Public Const bdDlgItemList As Integer = 2
	'Public Const bdDlgWithDice As Integer = 3
	'Public Const bdDlgReplyText As Integer = 4
	'Public Const bdDlgItem As Integer = 6
	'Public Const bdDlgSave As Integer = 7
	'Public Const bdDlgCreatureList As Integer = 8
	'Public Const bdDlgDebug As Integer = 9
	'Public Const bdDlgCredits As Integer = 10
	Public Enum DLGTYPE
		bdDlgNoReply = 0
		bdDlgWithReply = 1
		bdDlgItemList = 2
		bdDlgWithDice = 3
		bdDlgReplyText = 4
		bdDlgExamItem = 5 ' [Titi 2.4.9b] need more space to display information about an item when it is examined
		bdDlgItem = 6
		bdDlgSave = 7
		bdDlgCreatureList = 8
		bdDlgDebug = 9
		bdDlgCredits = 10
	End Enum
	
	Public Const bdSellStyleInv As Short = 0
	Public Const bdSellStyleEnc As Short = 1
	
	Public Function OpName(ByVal Index As Short) As String
		Select Case Index
			Case 0 ' =
				OpName = "EqualTo"
			Case 1 ' +
				OpName = "Plus"
			Case 2 ' -
				OpName = "Minus"
			Case 3 ' *
				OpName = "X"
			Case 4 ' /
				OpName = "DividedBy"
			Case 5 ' >
				OpName = "GreaterThan"
			Case 6 ' <
				OpName = "LessThan"
			Case 7 ' >=
				OpName = "GreaterOrEqual"
			Case 8 ' <=
				OpName = "LessOrEqual"
			Case 9 ' Or
				OpName = "Or"
			Case 10 ' And
				OpName = "And"
			Case 11 ' Xor
				OpName = "XOr"
			Case 12 ' Like
				OpName = "Like"
		End Select
	End Function
	
	Public Sub OptionsLoad(ByRef Refresh As Short)
		' Revised for 2-4-6 by Count0 to handle no options file present and outdated options file present cases
		Dim GlobalFlags, FromFile, c As Short
		Dim Cnt As Integer
		'Dim FromFile As Integer, GlobalFlags As Integer, Cnt As Integer, c As Integer
		Dim sPath As String
		Dim sVersion As String
		On Error GoTo Err_Handler
		'    If Not oFileSys.CheckExists(gAppPath & "\Data", Folder) Then
		If Not oFileSys.CheckExists(gDataPath, clsInOut.IOActionType.Folder) Then
			Err.Raise(1000, "Engine.OptionsLoad", "No Data Folder found.")
		End If
		'    sPath = gAppPath & "\data\stock\"
		sPath = gDataPath & "\stock\"
		If Not oFileSys.CheckExists(sPath & "options.dat", clsInOut.IOActionType.File, False) Then OptionsFileDefault() : Exit Sub
		' check for options file version for this build
		sVersion = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Revision
		FromFile = FreeFile
		' Now we open it for real and read from it.
		FileOpen(FromFile, sPath & "options.dat", OpenMode.Binary)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, Cnt)
		If Cnt > 1 Then
			GlobalLicNumber1 = ""
			For c = 1 To Cnt
				GlobalLicNumber1 = GlobalLicNumber1 & " "
			Next c
			GlobalMusicRandom = 1 ' default to ON
		Else
			GlobalMusicRandom = Cnt
		End If
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, GlobalLicNumber1)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, GlobalMusicState)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, GlobalRightClick)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, GlobalGameSpeed)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, GlobalDiceRolling)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, GlobalWAVState)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, GlobalDebugMode)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, GlobalOverSwing)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, GlobalFlags)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, Cnt)
		GlobalLicNumber2 = ""
		For c = 1 To Cnt
			GlobalLicNumber2 = GlobalLicNumber2 & " "
		Next c
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, GlobalLicNumber2)
		' Read GlobalInterfaceName
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, Cnt)
		GlobalInterfaceName = ""
		For c = 1 To Cnt
			GlobalInterfaceName = GlobalInterfaceName & " "
		Next c
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, GlobalInterfaceName)
		' Read GlobalDiceName
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, Cnt)
		GlobalDiceName = ""
		For c = 1 To Cnt
			GlobalDiceName = GlobalDiceName & " "
		Next c
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, GlobalDiceName)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, Cnt)
		GlobalLicNumber3 = ""
		For c = 1 To Cnt + 1 ' last character will be GlobalCredits status
			GlobalLicNumber3 = GlobalLicNumber3 & " "
		Next c
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, GlobalLicNumber3)
		GlobalCredits = Right(GlobalLicNumber3, 1) ' now retrieve GlobalCredits value
		GlobalLicNumber3 = Left(GlobalLicNumber3, Cnt) ' and set GlobalLicNumber3 to its correct value
		' [Titi 2.4.9] keyboard shortcuts
		For c = 1 To 25
			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FileGet(FromFile, bdKey(c))
		Next 
		FileClose(FromFile)
		' Decompose GlobalMouseClick and GlobalAutoEndTurn
		GlobalMouseClick = System.Math.Abs(CInt((GlobalFlags And &H1) > 0))
		GlobalAutoEndTurn = System.Math.Abs(CInt((GlobalFlags And &H2) > 0))
		GlobalFastMove = System.Math.Abs(CInt((GlobalFlags And &H4) > 0))
		GlobalAutoCenter = System.Math.Abs(CInt((GlobalFlags And &H8) > 0)) ' [Titi 2.4.9]
		' Double check GlobalInterfaceName
		'    If Not oFileSys.CheckExists(gAppPath & "\Data\Interface\" & GlobalInterfaceName, Folder) Then GlobalInterfaceName = "WoodWeave"
		If Not oFileSys.CheckExists(gDataPath & "\Interface\" & GlobalInterfaceName, clsInOut.IOActionType.Folder) Then GlobalInterfaceName = "WoodWeave"
		' Double check GlobalDiceName
		'    If Not oFileSys.CheckExists(gAppPath & "\Data\Interface\Dice\" & GlobalDiceName, File) Then GlobalDiceName = "Bone White.bmp"
		If Not oFileSys.CheckExists(gDataPath & "\Interface\Dice\" & GlobalDiceName, clsInOut.IOActionType.File) Then GlobalDiceName = "Bone White.bmp"
Exit_Sub: 
		Exit Sub
Err_Handler: 
		oErr.logError("You may not have the required data files installed.  Check for a Data folder.", CErrorHandler.ErrorLevel.ERR_CRITICAL)
		'Stop
		Resume Exit_Sub
	End Sub
	
	Private Sub OptionsFileDefault()
		' for 2-4-6 revision, by Count0
		' set what would be in contents of options file when not available
		Call oErr.LogText("setting game default game options since no options to load")
		GlobalWAVState = 1
		GlobalGameSpeed = 12
		GlobalMusicState = 1
		GlobalDebugMode = 0
		GlobalRightClick = 1
		GlobalDiceRolling = 1
		GlobalOverSwing = 1
		GlobalMouseClick = 1
		GlobalAutoEndTurn = 0
		GlobalFastMove = 0
		GlobalAutoCenter = 0 ' [Titi 2.4.9]
		' the following are already set by gameInit()
		' GlobalScreenX
		' GlobalScreenY
		' GlobalScreenColor
		GlobalInterfaceName = "WoodWeave"
		GlobalDiceName = "Bone White.bmp"
		GlobalLicNumber1 = "0000"
		' GlobalLicNumber2
		' GlobalLicNumber3
		GlobalCredits = "0"
		GlobalMusicRandom = 1
		InitKeyboardShortCuts()
	End Sub
	
	Public Sub OptionsSave()
		' Requires revision
		Dim ToFile, GlobalFlags As Short
		Dim c As Short
		' Compose GlobalFlags
		If GlobalMouseClick = 1 Then
			GlobalFlags = GlobalFlags Or &H1
		End If
		If GlobalAutoEndTurn = 1 Then
			GlobalFlags = GlobalFlags Or &H2
		End If
		If GlobalFastMove = 1 Then
			GlobalFlags = GlobalFlags Or &H4
		End If
		'    If GlobalAutoCenter = 1 Then ' [Titi 2.4.9]
		If GlobalAutoCenter And 1 = 1 Then ' [Titi 2.6.0]
			GlobalFlags = GlobalFlags Or &H8
		End If
		' Save options file
		ToFile = FreeFile
		'    Open gAppPath & "\data\stock\options.dat" For Binary As ToFile
		FileOpen(ToFile, gDataPath & "\stock\options.dat", OpenMode.Binary)
		'Put ToFile, , Len(GlobalLicNumber1)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, CInt(GlobalMusicRandom))
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, "") 'GlobalLicNumber1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, GlobalMusicState)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, GlobalRightClick)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, GlobalGameSpeed)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, GlobalDiceRolling)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, GlobalWAVState)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, GlobalDebugMode)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, GlobalOverSwing)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, GlobalFlags)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, Len(GlobalLicNumber2))
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, GlobalLicNumber2)
		' Write GlobalInterfaceName
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, Len(GlobalInterfaceName))
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, GlobalInterfaceName)
		' Write GlobalDiceName
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, Len(GlobalDiceName))
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, GlobalDiceName)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, Len(GlobalLicNumber3))
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, GlobalLicNumber3)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, GlobalCredits)
		' [Titi 2.4.9] keyboard shortcuts
		For c = 1 To 25
			'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FilePut(ToFile, bdKey(c))
		Next 
		FileClose(ToFile)
	End Sub
	
	Public Sub InitKeyboardShortCuts()
		' [Titi 2.4.9] init keyboard shortcuts
		' 200 means CTRL, 100 means SHIFT
		bdKey(1) = 200 + System.Windows.Forms.Keys.D ' Debug
		bdKey(2) = 200 + System.Windows.Forms.Keys.Q ' Quit
		bdKey(3) = 200 + System.Windows.Forms.Keys.X ' Exit
		bdKey(4) = 200 + System.Windows.Forms.Keys.Z ' Speed
		bdKey(5) = 200 + System.Windows.Forms.Keys.L ' Load
		bdKey(6) = 200 + System.Windows.Forms.Keys.S ' Save
		bdKey(7) = 200 + System.Windows.Forms.Keys.M ' Music
		bdKey(8) = 200 + System.Windows.Forms.Keys.W ' Sound
		bdKey(9) = 100 + System.Windows.Forms.Keys.Left ' Scroll map left
		bdKey(10) = 100 + System.Windows.Forms.Keys.Right ' Scroll map right
		bdKey(11) = 100 + System.Windows.Forms.Keys.Up ' Scroll map up
		bdKey(12) = 100 + System.Windows.Forms.Keys.Down ' Scroll map down
		bdKey(13) = System.Windows.Forms.Keys.Left ' Move party left
		bdKey(14) = System.Windows.Forms.Keys.Right ' Move party right
		bdKey(15) = System.Windows.Forms.Keys.Up ' Move party up
		bdKey(16) = System.Windows.Forms.Keys.Down ' Move party down
		bdKey(17) = System.Windows.Forms.Keys.J ' Journals and Quests
		bdKey(18) = System.Windows.Forms.Keys.L ' Listen
		bdKey(19) = System.Windows.Forms.Keys.T ' Talk
		bdKey(20) = System.Windows.Forms.Keys.K ' Skills
		bdKey(21) = System.Windows.Forms.Keys.Z ' Status
		bdKey(22) = System.Windows.Forms.Keys.S ' Search
		bdKey(23) = System.Windows.Forms.Keys.O ' Open
		bdKey(24) = System.Windows.Forms.Keys.I ' Inventory
		bdKey(25) = System.Windows.Forms.Keys.E ' Equip
	End Sub
	
	Public Function NotTwice(ByRef intKey As Short, ByRef code As Short) As Boolean
		Dim i As Short
		NotTwice = True
		For i = 1 To 25
			If bdKey(i) = code And intKey <> i Then
				DialogSetUp(DLGTYPE.bdDlgNoReply)
				DialogShow("", "Shortcut already used!")
				DialogHide()
				NotTwice = False
			End If
		Next 
	End Function
	
	' [Titi 2.4.9b] Added for the system tray icon
	Public Function NewWindowProc(ByVal hWnd As Integer, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
		' The replacement window proc.
		Const WM_NCDESTROY As Integer = &H82
		Const WM_SYSCOMMAND As Integer = &H112
		Const SC_MAXIMIZE As Integer = &HF030
		Const SC_MINIMIZE As Integer = &HF020
		Const SC_RESTORE As Integer = &HF120
		' If we're being destroyed, remove the tray icon and restore the original WindowProc.
		If msg = WM_NCDESTROY Then
			RemoveFromTray()
		ElseIf msg = TRAY_CALLBACK Then 
			' The user clicked on the tray icon.
			' Look for click events.
			If lParam = WM_LBUTTONUP Then
				' On left click, show the form.
				TheForm.Show()
				'UPGRADE_ISSUE: Control LastState could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
				If TheForm.WindowState = System.Windows.Forms.FormWindowState.Minimized Then TheForm.WindowState = TheForm.LastState
				TheForm.Activate()
				Exit Function
			End If
			If lParam = WM_RBUTTONUP Then
				' On right click, show the menu.
				SetForegroundWindow(TheForm.Handle.ToInt32)
				'UPGRADE_ISSUE: Form method TheForm.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				TheForm.PopupMenu(TheMenu)
				If Not (TheForm Is Nothing) Then
					PostMessage(TheForm.Handle.ToInt32, WM_NULL, 0, 0)
				End If
				Exit Function
			End If
		End If
		If msg = WM_SYSCOMMAND Then
			If wParam = SC_MINIMIZE Then
				TheForm.Hide()
				'UPGRADE_ISSUE: Control SetTrayMenuItems could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
				TheForm.SetTrayMenuItems(System.Windows.Forms.FormWindowState.Minimized)
				Exit Function
			ElseIf wParam = SC_RESTORE Then 
				If Not TheForm.Visible Then
					TheForm.Show()
					'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
					'UPGRADE_ISSUE: Control SetTrayMenuItems could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					TheForm.SetTrayMenuItems(vbNormal)
					Exit Function
				End If
			End If
		End If
		' Send other messages to the original window proc.
		NewWindowProc = CallWindowProc(OldWindowProc, hWnd, msg, wParam, lParam)
	End Function
	
	Public Sub AddToTray(ByRef frm As System.Windows.Forms.Form, ByRef mnu As System.Windows.Forms.ToolStripMenuItem)
		' Add the form's icon to the tray.
		' Save the form and menu for later use.
		TheForm = frm
		TheMenu = mnu
		' Install the new WindowProc.
		'UPGRADE_WARNING: Add a delegate for AddressOf NewWindowProc Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="E9E157F7-EF0C-4016-87B7-7D7FBBC6EE08"'
		OldWindowProc = SetWindowLong(frm.Handle.ToInt32, GWL_WNDPROC, AddressOf NewWindowProc)
		' Install the form's icon in the tray.
		With TheData
			.uID = 0
			.hWnd = frm.Handle.ToInt32
			.cbSize = Len(TheData)
			'UPGRADE_ISSUE: Picture property Icon.Handle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			.hIcon = frm.Icon.Handle
			.uFlags = NIF_ICON
			.uCallbackMessage = TRAY_CALLBACK
			.uFlags = .uFlags Or NIF_MESSAGE
			.cbSize = Len(TheData)
		End With
		Shell_NotifyIcon(NIM_ADD, TheData)
	End Sub
	
	Public Sub RemoveFromTray()
		' Remove the icon from the tray.
		With TheData
			.uFlags = 0
		End With
		Shell_NotifyIcon(NIM_DELETE, TheData)
		' Restore the original window proc.
		SetWindowLong(TheForm.Handle.ToInt32, GWL_WNDPROC, OldWindowProc)
		' Clean up.
		'UPGRADE_NOTE: Object TheForm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		TheForm = Nothing
	End Sub
	
	Public Sub SetTrayTip(ByRef tip As String)
		' Set a new tray tip.
		With TheData
			.szTip = tip & vbNullChar
			.uFlags = NIF_TIP
		End With
		Shell_NotifyIcon(NIM_MODIFY, TheData)
	End Sub
	
	' [Titi 2.4.9b] added to handle the Alt-Tab and Ctrl-Esc key combinations
	Public Sub HookKeyboard(ByRef blnEnd As Boolean)
		' [Titi 2.6.0] feature not available for Win 9x
		If Mid(modRegistry.VBWinVer, 9, 1) = "9" Or Mid(modRegistry.VBWinVer, 9, 1) = "M" Then Exit Sub
		'set and obtain the handle to the keyboard hook
		'UPGRADE_WARNING: Add a delegate for AddressOf LowLevelKeyboardProc Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="E9E157F7-EF0C-4016-87B7-7D7FBBC6EE08"'
		m_hDllKbdHook = SetWindowsHookEx(WH_KEYBOARD_LL, AddressOf LowLevelKeyboardProc, VB6.GetHInstance.ToInt32, 0)
		If m_hDllKbdHook <> 0 Then
			'  It's hooked! Show a messagebox to temporarily suspend the app here (the LowLevelKeyboardProc will continue to process messages), and follow the messagebox, for this demo, with the unhook call. See the text above for specific information.
			'MsgBox "Ctrl+Esc, Alt+Tab and Alt+Esc are blocked. " & "Click OK to quit and re-enable the keys.", vbOKOnly Or vbInformation, "Keyboard Hook Active"
			'Placement for this demo only. Move to the unload event of the main form when used in an application.
			If blnEnd Then Call UnhookWindowsHookEx(m_hDllKbdHook)
		Else
			MsgBox("Failed to install low-level keyboard hook - " & Err.LastDllError)
		End If
	End Sub
	
	Public Function LowLevelKeyboardProc(ByVal nCode As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
		'Application-defined callback function used with the SetWindowsHookEx function.
		'The system calls this function every time a new keyboard input event is about to be posted into a thread input queue.
		'The keyboard input can come from the local keyboard driver or from calls to the keybd_event function. If the input comes from a call to keybd_event, the input was "injected".
		Static kbdllhs As KBDLLHOOKSTRUCT
		'If nCode is less than zero, the hook procedure must return the value returned by CallNextHookEx.
		'If nCode is greater than or equal to zero, and the hook procedure did not process the message, it is highly recommended that you call CallNextHookEx and return the value it returns; otherwise, other applications that have installed WH_KEYBOARD_LL hooks will not receive hook notifications and may behave incorrectly as a result.
		'If the hook procedure processed the message, it may return a nonzero value to prevent the system from passing the message to the rest of the hook chain or the target window procedure.
		If nCode = HC_ACTION Then
			'nCode specifies a code the hook procedure uses to determine how to process the message. HC_ACTION is the only valid code.
			'On receipt of the HC_ACTION code, wParam and lParam contain information about a keyboard message, and lParam holds the pointer to a KBDLLHOOKSTRUCT structure.
			'UPGRADE_WARNING: Couldn't resolve default property of object kbdllhs. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Call CopyMemory(kbdllhs, lParam, Len(kbdllhs))
			'Ctrl+Esc --------------
			If (kbdllhs.vkCode = VK_ESCAPE) And CBool(GetAsyncKeyState(VK_CONTROL) And &H8000) Then
				Call frmMain.mnuTrayMinimize_Click(Nothing, New System.EventArgs())
				LowLevelKeyboardProc = 1
				Exit Function
			End If 'kbdllhs.vkCode = VK_ESCAPE
			'Alt+Tab --------------
			If (kbdllhs.vkCode = VK_TAB) And CBool(kbdllhs.flags And LLKHF_ALTDOWN) Then
				Call frmMain.mnuTrayMinimize_Click(Nothing, New System.EventArgs())
				LowLevelKeyboardProc = 1
				Exit Function
			End If 'kbdllhs.vkCode = VK_TAB
			'Alt+Esc --------------
			If (kbdllhs.vkCode = VK_ESCAPE) And CBool(kbdllhs.flags And LLKHF_ALTDOWN) Then
				Call frmMain.mnuTrayMinimize_Click(Nothing, New System.EventArgs())
				LowLevelKeyboardProc = 1
				Exit Function
			End If 'kbdllhs.vkCode = VK_ESCAPE
		End If 'nCode = HC_ACTION
		LowLevelKeyboardProc = CallNextHookEx(m_hDllKbdHook, nCode, wParam, lParam)
	End Function
End Module