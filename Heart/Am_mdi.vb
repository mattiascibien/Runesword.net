Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmMDI
	Inherits System.Windows.Forms.Form
	
	'Help declarations
	Dim hWnds As Integer
	Dim hwndHelp As Integer
	Dim ContextID As Integer
	'Help end
	
	Public TreeViewX As AxComctlLib.AxTreeView
	Public ObjectListX As Collection
	
	Public CopyBuffer As Object
	Public BufferType As Byte
	Public CopyBufferSet As New Collection
	Public CopyBufferTags As New Collection
	Const bdCopyBufferLimit As Short = 8
	
	Public LastNode, HoldNode As Short
	Public bNotFromEncList As Boolean ' [Titi 2.4.9b] flag to avoid going to the first encounter in the list before going to the active one
	Public Dirty As Short
	
	'Public Tome As Tome
	'Public Area As Area
	
	Public OptionShowEncounters As Short
	Dim intIndex As Short
	Public strRequiredDataFilesTxtFile As String
	Public blnAutoComplete As Boolean
	Public intSearchLine As Integer
	Public intPosInSearchLine As Short
	
	Private Structure STARTUPINFO
		Dim cb As Integer
		Dim lpReserved As String
		Dim lpDesktop As String
		Dim lpTitle As String
		Dim dwX As Integer
		Dim dwY As Integer
		Dim dwXSize As Integer
		Dim dwYSize As Integer
		Dim dwXCountChars As Integer
		Dim dwYCountChars As Integer
		Dim dwFillAttribute As Integer
		Dim dwFlags As Integer
		Dim wShowWindow As Short
		Dim cbReserved2 As Short
		Dim lpReserved2 As Integer
		Dim hStdInput As Integer
		Dim hStdOutput As Integer
		Dim hStdError As Integer
	End Structure
	
	Private Structure PROCESS_INFORMATION
		Dim hProcess As Integer
		Dim hThread As Integer
		Dim dwProcessID As Integer
		Dim dwThreadId As Integer
	End Structure
	
	Private Declare Function WaitForSingleObject Lib "kernel32" (ByVal hHandle As Integer, ByVal dwMilliseconds As Integer) As Integer
	
	'UPGRADE_WARNING: Structure PROCESS_INFORMATION may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	'UPGRADE_WARNING: Structure STARTUPINFO may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function CreateProcessA Lib "kernel32" (ByVal lpApplicationName As String, ByVal lpCommandLine As String, ByVal lpProcessAttributes As Integer, ByVal lpThreadAttributes As Integer, ByVal bInheritHandles As Integer, ByVal dwCreationFlags As Integer, ByVal lpEnvironment As Integer, ByVal lpCurrentDirectory As String, ByRef lpStartupInfo As STARTUPINFO, ByRef lpProcessInformation As PROCESS_INFORMATION) As Integer
	
	Private Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Integer) As Integer
	
	Private Declare Function GetExitCodeProcess Lib "kernel32" (ByVal hProcess As Integer, ByRef lpExitCode As Integer) As Integer
	
	Private Const NORMAL_PRIORITY_CLASS As Integer = &H20
	Private Const INFINITE As Short = -1
	
	Private Declare Function SetCursorPos Lib "user32" (ByVal X As Integer, ByVal Y As Integer) As Integer
	
	'UPGRADE_NOTE: Tag was upgraded to Tag_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Function ParseTag(ByRef Tag_Renamed As String) As Short
		Dim c As Short
		If VB.Right(Tag_Renamed, 7) = "Graphic" Then
			ParseTag = bdEditMapGraphic
		ElseIf VB.Right(Tag_Renamed, 10) = "Encounters" Then 
			ParseTag = bdEditMapEncounters
		ElseIf VB.Right(Tag_Renamed, 6) = "Themes" Then 
			ParseTag = bdEditMapThemes
		ElseIf VB.Right(Tag_Renamed, 8) = "TileSets" Then 
			ParseTag = bdEditMapTileSets
		ElseIf VB.Right(Tag_Renamed, 5) = "Tiles" Then 
			ParseTag = bdEditMapTiles
		ElseIf VB.Right(Tag_Renamed, 11) = "EntryPoints" Then 
			ParseTag = bdEditMapEntryPoints
		ElseIf VB.Right(Tag_Renamed, 5) = "Party" Then 
			ParseTag = bdEditTomeParty
		ElseIf VB.Right(Tag_Renamed, 8) = "Journals" Then 
			ParseTag = bdEditTomeJournals
		ElseIf VB.Right(Tag_Renamed, 8) = "Factoids" Then 
			ParseTag = bdEditTomeFactoids
		ElseIf VB.Right(Tag_Renamed, 8) = "Triggers" Then 
			ParseTag = bdEditTomeTriggers
		ElseIf VB.Right(Tag_Renamed, 5) = "Areas" Then 
			ParseTag = bdEditTomeAreas
		ElseIf Tag_Renamed = "Tome" Then 
			ParseTag = bdEditTome
		ElseIf VB.Right(Tag_Renamed, 9) = "Creatures" Then 
			ParseTag = bdEditMapCreatures
		Else
			For c = 1 To Len(Tag_Renamed)
				If IsNumeric(VB.Right(Tag_Renamed, c)) = False Then
					Select Case VB.Left(VB.Right(Tag_Renamed, c), 1)
						Case "M"
							ParseTag = bdEditMap
						Case "E"
							ParseTag = bdEditEncounter
						Case "T"
							ParseTag = bdEditTrigger
						Case "X"
							ParseTag = bdEditCreature
						Case "I"
							ParseTag = bdEditItem
						Case "C"
							ParseTag = bdEditConvo
						Case "Q"
							ParseTag = bdEditTopic
						Case "R"
							ParseTag = bdEditTheme
						Case "P"
							ParseTag = bdEditEntryPoint
						Case "L"
							ParseTag = bdEditTile
						Case "W"
							ParseTag = bdEditTileSet
						Case "F"
							ParseTag = bdEditFactoid
						Case "A"
							ParseTag = bdEditArea
						Case "J"
							ParseTag = bdEditJournal
					End Select
					Exit For
				End If
			Next c
		End If
	End Function
	
	'UPGRADE_NOTE: Tag was upgraded to Tag_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub EditCopy(ByRef Tag_Renamed As String)
		Dim frmWorldSettings As Object
		Dim ObjectX As Object
		' [Titi 2.4.9b] to make sure the archetype will always match the kingdom's race
		'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Visible. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If frmWorldSettings.Visible = True And ParseTag(Tag_Renamed) = bdEditCreature Then
			MsgBox("This action is not possible while a world is being created.", MsgBoxStyle.Exclamation, "Cannot cut/copy/insert a creature now.")
			Exit Sub
		End If
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		ObjectX = ObjectListX.Item(Tag_Renamed)
		BufferType = ParseTag(Tag_Renamed)
		Select Case BufferType
			Case bdEditMap
				CopyBuffer = New Map
			Case bdEditEncounter
				CopyBuffer = New Encounter
			Case bdEditCreature, bdEditMapCreatures
				CopyBuffer = New Creature
			Case bdEditItem
				CopyBuffer = New Item
			Case bdEditTrigger
				CopyBuffer = New Trigger
			Case bdEditConvo
				CopyBuffer = New Conversation
			Case bdEditTopic
				CopyBuffer = New Topic
			Case bdEditTheme
				CopyBuffer = New Theme
			Case bdEditEntryPoint
				CopyBuffer = New EntryPoint
			Case bdEditTile
				CopyBuffer = New Tile
			Case bdEditTileSet
				CopyBuffer = New TileSet
			Case bdEditFactoid
				CopyBuffer = New Factoid
			Case bdEditArea
				CopyBuffer = New Area
			Case bdEditJournal
				CopyBuffer = New Journal
			Case Else
				'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
				Exit Sub
		End Select
		'UPGRADE_WARNING: Couldn't resolve default property of object CopyBuffer.Copy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CopyBuffer.Copy(ObjectX)
		' Add CopyBuffer to CopyBufferSet
		CopyBufferSet.Add(CopyBuffer)
		CopyBufferTags.Add(Tag_Renamed)
		If CopyBufferSet.Count() > bdCopyBufferLimit Then
			CopyBufferSet.Remove(1)
			CopyBufferTags.Remove(1)
		End If
		If frmSearch.Visible = True Then
			frmSearch.ReplaceList()
		End If
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
	End Sub
	
	'UPGRADE_NOTE: Tag was upgraded to Tag_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub EditCut(ByRef Tag_Renamed As String)
		Dim frmWorldSettings As Object
		' [Titi 2.4.9b] to make sure the archetype will always match the kingdom's race
		'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Visible. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If frmWorldSettings.Visible = True And ParseTag(Tag_Renamed) = bdEditCreature Then
			MsgBox("This action is not possible while a world is being created.", MsgBoxStyle.Exclamation, "Cannot cut/copy/insert a creature now.")
		Else
			EditCopy(Tag_Renamed)
			EditDelete(Tag_Renamed)
		End If
	End Sub
	
	'UPGRADE_NOTE: Area was upgraded to Area_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	'UPGRADE_NOTE: Tag was upgraded to Tag_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub EditPaste(ByRef Tag_Renamed As String)
		Dim Area_Renamed As Object
		Dim ObjectX, ObjectPaste As Object
		Dim FormX As System.Windows.Forms.Form
		Dim i, c, Found As Short
		' [Titi 2.4.8] added a number for copy/paste
		Dim strCopyNumber, strPasteName As String
		Dim blnSameName As Boolean
		Dim EncounterX As Encounter
		Dim MapX As Map
		Dim TriggerX As Trigger
		Dim ItemX As Item
		Dim CreatureX As Creature
		Dim ConvoX As Conversation
		Dim TopicX As Topic
		Dim TileX As Tile
		Dim ThemeX As Theme
		Dim EntryPointX As EntryPoint
		Dim TileSetX As TileSet
		Dim JournalX As Journal
		Dim FactoidX As Factoid
		Dim AreaX As Area
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		' Show in Open Form (if there is one)
		Select Case ParseTag(Tag_Renamed)
			Case bdEditMapEncounters, bdEditMapCreatures
				i = 10
			Case bdEditMapTiles
				i = 5
			Case bdEditMapTileSets
				i = 8
			Case bdEditMapThemes
				i = 6
			Case Else
				i = 0
		End Select
		Found = False
		For c = 0 To My.Application.OpenForms.Count - 1
			If My.Application.OpenForms.Item(c).Tag = VB.Left(Tag_Renamed, Len(Tag_Renamed) - i) Then
				FormX = My.Application.OpenForms.Item(c)
				Found = True
				Exit For
			End If
		Next c
		ObjectX = ObjectListX.Item(Tag_Renamed)
		Select Case BufferType
			Case bdEditMap
				'UPGRADE_WARNING: Couldn't resolve default property of object Area.Plot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste = Area.Plot.AddMap
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Copy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Copy(CopyBuffer)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strPasteName = ObjectPaste.Name
				c = 0
				blnSameName = True
				While blnSameName
					blnSameName = False
					'UPGRADE_WARNING: Couldn't resolve default property of object Area.Plot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For	Each MapX In Area.Plot.Maps
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If MapX.Name = strPasteName And MapX.Index <> ObjectPaste.Index Then
							c = c + 1
							strCopyNumber = Str(c)
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							strPasteName = ObjectPaste.Name & strCopyNumber
							blnSameName = True
						End If
					Next MapX
				End While
				If strCopyNumber = "0" Then strCopyNumber = ""
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Name = ObjectPaste.Name & strCopyNumber
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowMap(ObjectListX, TreeViewX, ObjectPaste)
			Case bdEditEncounter
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddEncounter. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste = ObjectX.AddEncounter
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Copy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Copy(CopyBuffer)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strPasteName = ObjectPaste.Name
				c = 0
				blnSameName = True
				While blnSameName
					blnSameName = False
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Encounters. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For	Each EncounterX In ObjectX.Encounters
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If EncounterX.Name = strPasteName And EncounterX.Index <> ObjectPaste.Index Then
							c = c + 1
							strCopyNumber = Str(c)
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							strPasteName = ObjectPaste.Name & strCopyNumber
							blnSameName = True
						End If
					Next EncounterX
				End While
				If strCopyNumber = "0" Then strCopyNumber = ""
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Name = ObjectPaste.Name & strCopyNumber
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowEncounter(ObjectListX, TreeViewX, Tag_Renamed, ObjectPaste)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListEncounters could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListEncounters()
				End If
			Case bdEditCreature, bdEditMapCreatures
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddCreature. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste = ObjectX.AddCreature
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Copy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Copy(CopyBuffer)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strPasteName = ObjectPaste.Name
				c = 0
				blnSameName = True
				While blnSameName
					blnSameName = False
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Creatures. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For	Each CreatureX In ObjectX.Creatures
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If CreatureX.Name = strPasteName And CreatureX.Index <> ObjectPaste.Index Then
							c = c + 1
							strCopyNumber = Str(c)
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							strPasteName = ObjectPaste.Name & strCopyNumber
							blnSameName = True
						End If
					Next CreatureX
				End While
				If strCopyNumber = "0" Then strCopyNumber = ""
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Name = ObjectPaste.Name & strCopyNumber
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowCreature(ObjectListX, TreeViewX, Tag_Renamed, ObjectPaste)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListCreatures could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListCreatures()
				End If
				If ParseTag(Tag_Renamed) = bdEditEncounter Then
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					PositionCreature(ObjectListX, TreeViewX, Tag_Renamed, ObjectPaste)
				End If
			Case bdEditItem
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddItem. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste = ObjectX.AddItem
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Copy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Copy(CopyBuffer)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strPasteName = ObjectPaste.Name
				c = 0
				blnSameName = True
				While blnSameName
					blnSameName = False
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Items. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For	Each ItemX In ObjectX.Items
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If ItemX.Name = strPasteName And ItemX.Index <> ObjectPaste.Index Then
							c = c + 1
							strCopyNumber = Str(c)
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							strPasteName = ObjectPaste.Name & strCopyNumber
							blnSameName = True
						End If
					Next ItemX
				End While
				If strCopyNumber = "0" Then strCopyNumber = ""
				' copied item name already includes total count and final 's' if needed
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Val(VB.Left(ObjectPaste.Name, InStr(ObjectPaste.Name, Chr(32)))) > 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					ObjectPaste.Name = Mid(ObjectPaste.Name, InStr(ObjectPaste.Name, Chr(32)), Len(ObjectPaste.Name) - InStr(ObjectPaste.Name, Chr(32))) & strCopyNumber
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					ObjectPaste.Name = ObjectPaste.Name & strCopyNumber
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowItem(ObjectListX, TreeViewX, Tag_Renamed, ObjectPaste)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListItems could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListItems()
				End If
				If ParseTag(Tag_Renamed) = bdEditEncounter Then
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					PositionItem(ObjectListX, TreeViewX, Tag_Renamed, ObjectPaste)
				End If
			Case bdEditTrigger
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddTrigger. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste = ObjectX.AddTrigger
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Copy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Copy(CopyBuffer)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strPasteName = ObjectPaste.Name
				c = 0
				blnSameName = True
				While blnSameName
					blnSameName = False
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Triggers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For	Each TriggerX In ObjectX.Triggers
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If TriggerX.Name = strPasteName And TriggerX.Index <> ObjectPaste.Index Then
							c = c + 1
							strCopyNumber = Str(c)
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							strPasteName = ObjectPaste.Name & strCopyNumber
							blnSameName = True
						End If
					Next TriggerX
				End While
				If strCopyNumber = "0" Then strCopyNumber = ""
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Name = ObjectPaste.Name & strCopyNumber
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowTrigger(ObjectListX, TreeViewX, Tag_Renamed, ObjectPaste)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListTriggers could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListTriggers()
				End If
			Case bdEditConvo
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddConversation. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste = ObjectX.AddConversation
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Copy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Copy(CopyBuffer)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strPasteName = ObjectPaste.Name
				c = 0
				blnSameName = True
				While blnSameName
					blnSameName = False
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Conversations. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For	Each ConvoX In ObjectX.Conversations
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If ConvoX.Name = strPasteName And ConvoX.Index <> ObjectPaste.Index Then
							c = c + 1
							strCopyNumber = Str(c)
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							strPasteName = ObjectPaste.Name & strCopyNumber
							blnSameName = True
						End If
					Next ConvoX
				End While
				If strCopyNumber = "0" Then strCopyNumber = ""
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Name = ObjectPaste.Name & strCopyNumber
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowConversation(ObjectListX, TreeViewX, Tag_Renamed, ObjectPaste)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListConvos could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListConvos()
				End If
			Case bdEditTopic
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddTopic. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste = ObjectX.AddTopic
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Copy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Copy(CopyBuffer)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Say. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strPasteName = ObjectPaste.Say
				c = 0
				blnSameName = True
				While blnSameName
					blnSameName = False
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Topics. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For	Each TopicX In ObjectX.Topics
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If TopicX.Say Like strPasteName And TopicX.Index <> ObjectPaste.Index Then
							c = c + 1
							strCopyNumber = Str(c)
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Say. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							strPasteName = ObjectPaste.Say & strCopyNumber
							blnSameName = True
						End If
					Next TopicX
				End While
				If strCopyNumber = "0" Then strCopyNumber = ""
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Say. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Say = ObjectPaste.Say & strCopyNumber
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowTopic(ObjectListX, TreeViewX, Tag_Renamed, ObjectPaste)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListTopics could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListTopics()
				End If
			Case bdEditTheme
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddTheme. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste = ObjectX.AddTheme
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Copy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Copy(CopyBuffer)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strPasteName = ObjectPaste.Name
				c = 0
				blnSameName = True
				While blnSameName
					blnSameName = False
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Themes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For	Each ThemeX In ObjectX.Themes
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If ThemeX.Name = strPasteName And ThemeX.Index <> ObjectPaste.Index Then
							c = c + 1
							strCopyNumber = Str(c)
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							strPasteName = ObjectPaste.Name & strCopyNumber
							blnSameName = True
						End If
					Next ThemeX
				End While
				If strCopyNumber = "0" Then strCopyNumber = ""
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Name = ObjectPaste.Name & strCopyNumber
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowTheme(ObjectListX, TreeViewX, Tag_Renamed, ObjectPaste)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListThemes could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListThemes()
				End If
			Case bdEditEntryPoint
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddEntryPoint. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste = ObjectX.AddEntryPoint
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Copy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Copy(CopyBuffer)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strPasteName = ObjectPaste.Name
				c = 0
				blnSameName = True
				While blnSameName
					blnSameName = False
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.EntryPoints. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For	Each EntryPointX In ObjectX.EntryPoints
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If EntryPointX.Name = strPasteName And EntryPointX.Index <> ObjectPaste.Index Then
							c = c + 1
							strCopyNumber = Str(c)
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							strPasteName = ObjectPaste.Name & strCopyNumber
							blnSameName = True
						End If
					Next EntryPointX
				End While
				If strCopyNumber = "0" Then strCopyNumber = ""
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Name = ObjectPaste.Name & strCopyNumber
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowEntryPoint(ObjectListX, TreeViewX, Tag_Renamed, ObjectPaste)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListEntryPoints could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListEntryPoints()
				End If
			Case bdEditTile
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddTile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste = ObjectX.AddTile
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Copy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Copy(CopyBuffer)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strPasteName = ObjectPaste.Name
				c = 0
				blnSameName = True
				While blnSameName
					blnSameName = False
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Tiles. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For	Each TileX In ObjectX.Tiles
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If TileX.Name = strPasteName And TileX.Index <> ObjectPaste.Index Then
							c = c + 1
							strCopyNumber = Str(c)
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							strPasteName = ObjectPaste.Name & strCopyNumber
							blnSameName = True
						End If
					Next TileX
				End While
				If strCopyNumber = "0" Then strCopyNumber = ""
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Name = ObjectPaste.Name & strCopyNumber
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowTile(ObjectListX, TreeViewX, Tag_Renamed, ObjectPaste)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListTiles could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListTiles()
				End If
				' Find Map Graphic too (if open)
				Found = False
				For c = 0 To My.Application.OpenForms.Count - 1
					If VB.Right(My.Application.OpenForms.Item(c).Tag, 7) = "Graphic" Then
						If VB.Left(My.Application.OpenForms.Item(c).Tag, Len(My.Application.OpenForms.Item(c).Tag) - 7) = VB.Left(Tag_Renamed, Len(Tag_Renamed) - 5) Then
							'UPGRADE_ISSUE: Control SetTileList could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
							My.Application.OpenForms.Item(c).SetTileList()
							Exit For
						End If
					End If
				Next c
			Case bdEditTileSet
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddTileSet. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste = ObjectX.AddTileSet
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Copy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Copy(CopyBuffer)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strPasteName = ObjectPaste.Name
				c = 0
				blnSameName = True
				While blnSameName
					blnSameName = False
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.TileSets. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For	Each TileSetX In ObjectX.TileSets
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If TileSetX.Name = strPasteName And TileSetX.Index <> ObjectPaste.Index Then
							c = c + 1
							strCopyNumber = Str(c)
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							strPasteName = ObjectPaste.Name & strCopyNumber
							blnSameName = True
						End If
					Next TileSetX
				End While
				If strCopyNumber = "0" Then strCopyNumber = ""
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Name = ObjectPaste.Name & strCopyNumber
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowTileSet(ObjectListX, TreeViewX, Tag_Renamed, ObjectPaste)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListTileSets could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListTileSets()
				End If
			Case bdEditJournal
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddJournal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste = ObjectX.AddJournal
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Copy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Copy(CopyBuffer)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strPasteName = ObjectPaste.Text
				c = 0
				blnSameName = True
				While blnSameName
					blnSameName = False
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Journals. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For	Each JournalX In ObjectX.Journals
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If JournalX.Text Like strPasteName And JournalX.Index <> ObjectPaste.Index Then
							c = c + 1
							strCopyNumber = Str(c)
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							strPasteName = ObjectPaste.Text & strCopyNumber
							blnSameName = True
						End If
					Next JournalX
				End While
				If strCopyNumber = "0" Then strCopyNumber = ""
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Text = ObjectPaste.Text & strCopyNumber
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowJournal(ObjectListX, TreeViewX, Tag_Renamed, ObjectPaste)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListJournals could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListJournals()
				End If
			Case bdEditFactoid
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddFactoid. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste = ObjectX.AddFactoid
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Copy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Copy(CopyBuffer)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strPasteName = ObjectPaste.Text
				c = 0
				blnSameName = True
				While blnSameName
					blnSameName = False
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Factoids. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For	Each FactoidX In ObjectX.Factoids
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If FactoidX.Text Like strPasteName And FactoidX.Index <> ObjectPaste.Index Then
							c = c + 1
							strCopyNumber = Str(c)
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							strPasteName = ObjectPaste.Text & strCopyNumber
							blnSameName = True
						End If
					Next FactoidX
				End While
				If strCopyNumber = "0" Then strCopyNumber = ""
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Text = ObjectPaste.Text & strCopyNumber
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowFactoid(ObjectListX, TreeViewX, Tag_Renamed, ObjectPaste)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListFactoids could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListFactoids()
				End If
			Case bdEditArea
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddArea. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste = ObjectX.AddArea
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Copy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Copy(CopyBuffer)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strPasteName = ObjectPaste.Name
				c = 0
				blnSameName = True
				While blnSameName
					blnSameName = False
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Areas. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For	Each AreaX In ObjectX.Areas
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If AreaX.Name = strPasteName And AreaX.Index <> ObjectPaste.Index Then
							c = c + 1
							strCopyNumber = Trim(Str(c))
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							strPasteName = VB.Left(ObjectPaste.Name, 4) & strCopyNumber
							blnSameName = True
						End If
					Next AreaX
				End While
				If strCopyNumber = "0" Then strCopyNumber = ""
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectPaste.Name = VB.Left(ObjectPaste.Name, 4 + CShort(strCopyNumber = "")) & strCopyNumber
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectPaste. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowArea(ObjectListX, TreeViewX, Tag_Renamed, ObjectPaste)
		End Select
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		Dirty = True
	End Sub
	
	'UPGRADE_NOTE: Tag was upgraded to Tag_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub PositionCreature(ByRef ToList As Collection, ByRef ToTree As AxComctlLib.AxTreeView, ByRef Tag_Renamed As String, ByRef CreatureX As Creature)
		Dim MapX As Map
		Dim EncounterX As Encounter
		Dim CreatureZ As Creature
		Dim Found, X, Y, c As Short
		Dim Spots(4) As Short
		EncounterX = ToList.Item(ToTree.Nodes(Tag_Renamed).Tag)
		If InStr(Tag_Renamed, "Theme") > 0 Then
			MapX = ToList.Item(ToTree.Nodes(Tag_Renamed).Parent.Parent.Tag)
		Else
			MapX = ToList.Item(ToTree.Nodes(Tag_Renamed).Parent.Tag)
		End If
		modDungeonMaker.PositionCreature(MapX, EncounterX, CreatureX)
	End Sub
	
	'UPGRADE_NOTE: Tag was upgraded to Tag_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub PositionItem(ByRef ToList As Collection, ByRef ToTree As AxComctlLib.AxTreeView, ByRef Tag_Renamed As String, ByRef ItemX As Item)
		Dim MapX As Map
		Dim EncounterX As Encounter
		Dim ItemZ As Item
		Dim Found, X, Y, c As Short
		Dim Spots(4) As Short
		EncounterX = ObjectListX.Item(ToTree.Nodes(Tag_Renamed).Tag)
		If InStr(Tag_Renamed, "Theme") > 0 Then
			MapX = ToList.Item(ToTree.Nodes(Tag_Renamed).Parent.Parent.Tag)
		Else
			MapX = ToList.Item(ToTree.Nodes(Tag_Renamed).Parent.Tag)
		End If
		modDungeonMaker.PositionItem(MapX, EncounterX, ItemX)
	End Sub
	
	'UPGRADE_NOTE: Area was upgraded to Area_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	'UPGRADE_NOTE: Tag was upgraded to Tag_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub EditLoad(ByRef Tag_Renamed As String, ByRef AddType As Short)
		Dim Area_Renamed As Object
		Dim frmWorldSettings As Object
		Dim ObjectX, ObjectEdit As Object
		Dim i As Short
		Dim Found, c, Index As Short
		Dim FormX As System.Windows.Forms.Form
		Dim FileName As String
		' Get file from disk
		On Error Resume Next
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		dlgFile.CancelError = True
		Select Case AddType
			Case bdEditMap
				dlgFileOpen.Title = "Insert from Map Library"
				dlgFileSave.Title = "Insert from Map Library"
				'            dlgFile.FileName = gAppPath & "\Library\*.rsm"
				dlgFileOpen.FileName = gLibPath & "\*.rsm"
				dlgFileSave.FileName = gLibPath & "\*.rsm"
				'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				dlgFileOpen.Filter = "Map Files (*.rsm)|*.rsm|All Files (*.*)|*.*"
				dlgFileSave.Filter = "Map Files (*.rsm)|*.rsm|All Files (*.*)|*.*"
			Case bdEditEncounter
				dlgFileOpen.Title = "Insert from Encounter Library"
				dlgFileSave.Title = "Insert from Encounter Library"
				'            dlgFile.FileName = gAppPath & "\Library\*.rse"
				dlgFileOpen.FileName = gLibPath & "\*.rse"
				dlgFileSave.FileName = gLibPath & "\*.rse"
				'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				dlgFileOpen.Filter = "Encounter Files (*.rse)|*.rse|All Files (*.*)|*.*"
				dlgFileSave.Filter = "Encounter Files (*.rse)|*.rse|All Files (*.*)|*.*"
			Case bdEditCreature, bdEditMapCreatures
				' [Titi 2.4.9b] to make sure the archetype will always match the kingdom's race
				'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Visible. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If frmWorldSettings.Visible = True Then
					MsgBox("This action is not possible while a world is being created.", MsgBoxStyle.Exclamation, "Cannot cut/copy/insert any creature now.")
					Exit Sub
				End If
				dlgFileOpen.Title = "Insert from Creature Library"
				dlgFileSave.Title = "Insert from Creature Library"
				'            dlgFile.FileName = gAppPath & "\Library\*.rsc"
				dlgFileOpen.FileName = gLibPath & "\*.rsc"
				dlgFileSave.FileName = gLibPath & "\*.rsc"
				'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				dlgFileOpen.Filter = "Creature Files (*.rsc)|*.rsc|All Files (*.*)|*.*"
				dlgFileSave.Filter = "Creature Files (*.rsc)|*.rsc|All Files (*.*)|*.*"
			Case bdEditItem
				dlgFileOpen.Title = "Insert from Item Library"
				dlgFileSave.Title = "Insert from Item Library"
				'            dlgFile.FileName = gAppPath & "\Library\*.rsi"
				dlgFileOpen.FileName = gLibPath & "\*.rsi"
				dlgFileSave.FileName = gLibPath & "\*.rsi"
				'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				dlgFileOpen.Filter = "Item Files (*.rsi)|*.rsi|All Files (*.*)|*.*"
				dlgFileSave.Filter = "Item Files (*.rsi)|*.rsi|All Files (*.*)|*.*"
			Case bdEditTrigger
				dlgFileOpen.Title = "Insert from Trigger Library"
				dlgFileSave.Title = "Insert from Trigger Library"
				'            dlgFile.FileName = gAppPath & "\Library\*.rst"
				dlgFileOpen.FileName = gLibPath & "\*.rst"
				dlgFileSave.FileName = gLibPath & "\*.rst"
				'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				dlgFileOpen.Filter = "Trigger Files (*.rst)|*.rst|All Files (*.*)|*.*"
				dlgFileSave.Filter = "Trigger Files (*.rst)|*.rst|All Files (*.*)|*.*"
			Case bdEditConvo
				dlgFileOpen.Title = "Insert from Conversation Library"
				dlgFileSave.Title = "Insert from Conversation Library"
				'            dlgFile.FileName = gAppPath & "\Library\*.rsq"
				dlgFileOpen.FileName = gLibPath & "\*.rsq"
				dlgFileSave.FileName = gLibPath & "\*.rsq"
				'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				dlgFileOpen.Filter = "Conversation Files (*.rsq)|*.rsq|All Files (*.*)|*.*"
				dlgFileSave.Filter = "Conversation Files (*.rsq)|*.rsq|All Files (*.*)|*.*"
			Case bdEditTheme
				dlgFileOpen.Title = "Insert from Theme Library"
				dlgFileSave.Title = "Insert from Theme Library"
				'            dlgFile.FileName = gAppPath & "\Library\*.rsr"
				dlgFileOpen.FileName = gLibPath & "\*.rsr"
				dlgFileSave.FileName = gLibPath & "\*.rsr"
				'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				dlgFileOpen.Filter = "Theme Files (*.rsr)|*.rsr|All Files (*.*)|*.*"
				dlgFileSave.Filter = "Theme Files (*.rsr)|*.rsr|All Files (*.*)|*.*"
			Case bdEditArea
				dlgFileOpen.Title = "Insert from Area Library"
				dlgFileSave.Title = "Insert from Area Library"
				'            dlgFile.FileName = gAppPath & "\Library\*.rsa"
				dlgFileOpen.FileName = gLibPath & "\*.rsa"
				dlgFileSave.FileName = gLibPath & "\*.rsa"
				'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				dlgFileOpen.Filter = "Area Files (*.rsa)|*.rsa|All Files (*.*)|*.*"
				dlgFileSave.Filter = "Area Files (*.rsa)|*.rsa|All Files (*.*)|*.*"
		End Select
		dlgFileOpen.FilterIndex = 1
		dlgFileSave.FilterIndex = 1
		'UPGRADE_WARNING: Untranslated statement in EditLoad. Please check source code.
		dlgFileOpen.ShowDialog()
		dlgFileSave.FileName = dlgFileOpen.FileName
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		If Err.Number = DialogResult.Cancel Then
			Exit Sub
		End If
		' Show in Open Form (if there is one)
		Select Case ParseTag(Tag_Renamed)
			Case bdEditMapEncounters
				i = 10
			Case bdEditMapTiles
				i = 5
			Case bdEditMapTileSets
				i = 8
			Case bdEditMapThemes
				i = 6
			Case bdEditTomeParty
				i = 5
			Case bdEditTomeJournals
				i = 8
			Case bdEditTomeTriggers
				i = 8
			Case bdEditTomeAreas
				i = 5
			Case bdEditMapCreatures
				i = 9
			Case Else
				i = 0
		End Select
		Found = False
		For c = 0 To My.Application.OpenForms.Count - 1
			If My.Application.OpenForms.Item(c).Tag = VB.Left(Tag_Renamed, Len(Tag_Renamed) - i) Then
				FormX = My.Application.OpenForms.Item(c)
				Found = True
				Exit For
			End If
		Next c
		' Open file to read from
		FileName = dlgFileOpen.FileName
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		c = FreeFile
		FileOpen(c, FileName, OpenMode.Binary)
		' Add object
		ObjectX = ObjectListX.Item(Tag_Renamed)
		Select Case AddType
			Case bdEditMap
				'UPGRADE_WARNING: Couldn't resolve default property of object Area.Plot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = Area.Plot.AddMap
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Index = ObjectEdit.Index
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.ReadFromFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.ReadFromFile(c)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.Index = Index
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowMap(ObjectListX, TreeViewX, ObjectEdit)
			Case bdEditEncounter
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddEncounter. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = ObjectX.AddEncounter
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Index = ObjectEdit.Index
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.ReadFromFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.ReadFromFile(c)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.Index = Index
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowEncounter(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListEncounters could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListEncounters()
				End If
			Case bdEditCreature
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddCreature. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = ObjectX.AddCreature
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Index = ObjectEdit.Index
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.ReadFromFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.ReadFromFile(c)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.Index = Index
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowCreature(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListCreatures could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListCreatures()
				End If
				If ParseTag(Tag_Renamed) = bdEditEncounter Then
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					PositionCreature(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				End If
			Case bdEditItem
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddItem. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = ObjectX.AddItem
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Index = ObjectEdit.Index
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.ReadFromFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.ReadFromFile(c)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.Index = Index
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowItem(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListItems could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListItems()
				End If
				If ParseTag(Tag_Renamed) = bdEditEncounter Then
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					PositionItem(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				End If
			Case bdEditTrigger
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddTrigger. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = ObjectX.AddTrigger
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Index = ObjectEdit.Index
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.ReadFromFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.ReadFromFile(c)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.Index = Index
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowTrigger(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListTriggers could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListTriggers()
				End If
			Case bdEditConvo
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddConversation. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = ObjectX.AddConversation
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Index = ObjectEdit.Index
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.ReadFromFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.ReadFromFile(c)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.Index = Index
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowConversation(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListConvos could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListConvos()
				End If
			Case bdEditTheme
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddTheme. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = ObjectX.AddTheme
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Index = ObjectEdit.Index
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.ReadFromFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.ReadFromFile(c)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.Index = Index
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowTheme(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListThemes could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListThemes()
				End If
			Case bdEditMapCreatures
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddCreature. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = ObjectX.AddCreature
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Index = ObjectEdit.Index
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.ReadFromFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.ReadFromFile(c)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.Index = Index
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowCreature(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListCreatures could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListCreatures()
				End If
			Case bdEditArea
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddArea. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = ObjectX.AddArea
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.FileName = FileName
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Index = ObjectEdit.Index
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowArea(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Plot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.Plot = New Plot
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Plot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.Plot.ReadFromFile(c)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.IsLoaded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.IsLoaded = True
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				OpenArea(ObjectEdit)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListAreas could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListAreas()
				End If
		End Select
		' Close file
		FileClose(c)
		' [Titi 2.4.9b] insert from library in the tome part didn't set the flag
		Dirty = True
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		Exit Sub
ErrorHandler: 
		Resume Next
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	'UPGRADE_NOTE: Area was upgraded to Area_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	'UPGRADE_NOTE: Text was upgraded to Text_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Function FindNext(ByRef Text_Renamed As String, ByRef ObjectType As Short, ByRef Direction As Short, ByRef WholeWord As Short, ByRef MatchCase As Short, ByRef PatternMatch As Short, ByRef Silent As Short) As Short
		Dim Area_Renamed As Object
		Dim Tome_Renamed As Object
		Dim c, Found As Short
		Dim NodeX As ComctlLib.Node
		Dim strExt As String
		Dim ObjectX As Object
		Dim TriggerX As Trigger
		Dim StmtX As Statement
		Dim OriginNode As Short ' [Titi] 2-4-6
		If ObjectType = bdEditData Then
			' [Titi] 2.4.6 - we're looking for a filename, not a creature, encounter or trigger
			If Len(Text_Renamed) <= 3 Then
				' not enough characters proposed to check the filetype
				strExt = "all"
			Else
				strExt = Mid(Text_Renamed, Len(Text_Renamed) - 3, 1)
				If strExt = "." Then ' filetype is known
					strExt = VB.Right(Text_Renamed, 3)
					Text_Renamed = VB.Left(Text_Renamed, Len(Text_Renamed) - 4)
				Else
					strExt = "all"
				End If
			End If
		End If
		' Configure Matching Text
		If WholeWord = True Then
			Text_Renamed = " " & Text_Renamed & " "
		End If
		If PatternMatch = True Then
			Text_Renamed = "*" & Text_Renamed & "*"
		End If
		' Move off the current Node based on direction searching
		Found = False
		If LastNode = 0 Then LastNode = 1 ' initialize search
		OriginNode = LastNode ' save starting position [Titi 2.4.6]
		If TreeViewX.Nodes.Count < LastNode Then OriginNode = TreeViewX.Nodes.Count ' if the user switched areas in the meantime, make sure LastNode can be reached [Titi 2.4.9b]
		If frmSearch.OriginNode <> 0 Then OriginNode = frmSearch.OriginNode ' case Replace all: let OriginNode be the node to paste
		Select Case Direction
			Case 0 ' All
				LastNode = LoopNumber(1, TreeViewX.Nodes.Count, LastNode, 1)
				'            Found = (LastNode = TreeViewX.Nodes.Count)
				Found = (LastNode = OriginNode) '<-- now, we stop the search when we're back at where we started [Titi 2.4.6]
			Case 1 ' Down
				LastNode = LastNode + 1
				Found = (LastNode > TreeViewX.Nodes.Count)
			Case 2 ' Up
				LastNode = LastNode - 1
				Found = (LastNode < 1)
		End Select
		If Found = True Then
			If Not Silent Then
				MsgBox("The specified region has been searched.", MsgBoxStyle.OKOnly Or MsgBoxStyle.Exclamation, "Find")
				HoldNode = LastNode
			End If
			FindNext = False
			Exit Function
		End If
		' Search
		Found = False
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		LastNode = Greatest(Least(TreeViewX.Nodes.Count, LastNode), 1)
		' [Titi 2.4.8] improvement: show where the file is found
		intSearchLine = 0 ' line number in the trigger
		intPosInSearchLine = 0 ' position in line where the text is found
		Do 
			' [Titi 2.4.9b] More user-friendly: we display where the search is taking place.
			' frmSearch.Caption = "Searching "  & LastNode & " of " & TreeViewX.Nodes.Count
			'UPGRADE_WARNING: Couldn't resolve default property of object Area.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmSearch.Text = "Searching " & IIf(HoldNode = -1 And TreeViewX.Tag = "", Tome.Name, Area.Name) & " (" & LastNode & " of " & TreeViewX.Nodes.Count & ")"
			frmSearch.Refresh()
			NodeX = TreeViewX.Nodes(LastNode)
			' If valid then see if name matches
			If ObjectType = bdEditData Then
				' [Titi] 2.4.6 - we're looking for a filename, not a creature, encounter or trigger
				' which means it's not the name of the node we're interested in, but what's inside it.
				ObjectX = ObjectListX.Item(NodeX.Tag)
				Found = SearchInsideNode(NodeX, ObjectX, strExt, ObjectType, UCase(Text_Renamed))
				If Found = True Then Exit Do
			ElseIf ParseTag((NodeX.Tag)) = ObjectType Then 
				If NodeX.Text Like Text_Renamed Or (MatchCase = False And UCase(NodeX.Text) Like UCase(Text_Renamed)) Then
					Found = True
					Exit Do
				End If
			End If
			' Next Object
			Select Case Direction
				Case 0 ' All
					LastNode = LoopNumber(1, TreeViewX.Nodes.Count, LastNode, 1)
					'                If LastNode = TreeViewX.Nodes.Count Then
					If LastNode = OriginNode Then ' loop circled [Titi 2.4.6]
						Exit Do
					End If
				Case 1 ' Down
					LastNode = LastNode + 1
					If LastNode > TreeViewX.Nodes.Count Then
						Exit Do
					End If
				Case 2 ' Up
					LastNode = LastNode - 1
					If LastNode < 1 Then
						Exit Do
					End If
			End Select
		Loop 
		' If Found then show Properties
		If Found = True Then
			' Close last found
			If TreeViewX.Tag <> "" And Not Silent Then
				For c = 0 To My.Application.OpenForms.Count - 1
					If My.Application.OpenForms.Item(c).Tag = TreeViewX.Tag Then
						'UPGRADE_ISSUE: Unload Forms() was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="875EBAD7-D704-4539-9969-BC7DBDAA62A2"'
						Unload(My.Application.OpenForms(c))
						Exit For
					End If
				Next c
			End If
			TreeViewX.SelectedItem = TreeViewX.Nodes(NodeX.Tag)
			TreeViewX.Tag = NodeX.Tag
			If Not Silent Then
				If ParseTag((NodeX.Tag)) = bdEditMapEncounters Then ' [Titi 2.6.1] the combat wallpapers were not displayed
					EditProperties(NodeX.Child.Tag, VB6.PixelsToTwipsX(frmSearch.Left), VB6.PixelsToTwipsY(frmSearch.Top) + VB6.PixelsToTwipsY(frmSearch.Height))
					For c = 0 To My.Application.OpenForms.Count - 1
						If My.Application.OpenForms.Item(c).Tag = NodeX.Child.Tag Then
							'UPGRADE_ISSUE: Control tabEncProp could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
							My.Application.OpenForms.Item(c).tabEncProp.Tabs(2).Selected = True
							Exit For
						End If
					Next c
				Else
					EditProperties((NodeX.Tag), VB6.PixelsToTwipsX(frmSearch.Left), VB6.PixelsToTwipsY(frmSearch.Top) + VB6.PixelsToTwipsY(frmSearch.Height))
				End If
				' now, highlight the text
				If intSearchLine <> 0 Then
					' if not found in a trigger, the line number will be 0!
					TriggerX = ObjectListX.Item(NodeX.Tag)
					' find the corresponding form
					For c = 0 To My.Application.OpenForms.Count - 1
						If My.Application.OpenForms.Item(c).Tag = NodeX.Tag Then
							'UPGRADE_WARNING: Form method Forms.ZOrder has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
							My.Application.OpenForms.Item(c).BringToFront()
							Exit For
						End If
					Next c
					' now, highlight the text
					For	Each StmtX In TriggerX.Statements
						intSearchLine = intSearchLine - 1
						If intSearchLine = 0 Then Exit For
					Next StmtX
					'UPGRADE_ISSUE: Control txtStatements could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					intSearchLine = InStr(My.Application.OpenForms.Item(c).txtStatements, StmtX.Text)
					'UPGRADE_ISSUE: Control FindStatement could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					My.Application.OpenForms.Item(c).FindStatement(True, True, intSearchLine - 1)
				End If
			End If
			FindNext = True
		Else
			If Not Silent Then
				MsgBox("The specified region has been searched. No more matches found.", MsgBoxStyle.OKOnly Or MsgBoxStyle.Exclamation, "Find")
			End If
			FindNext = False
		End If
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
	End Function
	
	'UPGRADE_NOTE: Refresh was upgraded to Refresh_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub FindReplace(ByRef Index As Short, ByRef Refresh_Renamed As Short, Optional ByRef blnUpdate As Boolean = False)
		Dim ObjectX, ParentX As Object
		Dim CreatureX As Creature
		Dim ItemX As Item
		Dim TriggerX As Trigger
		Dim ConversationX As Conversation
		'UPGRADE_NOTE: Tag was upgraded to Tag_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim c As Short
		Dim Tag_Renamed As String
		' Find open form for Search (if there is an open object and a selected replace)
		If TreeViewX.Tag <> "" And Index > 0 Then
			Dirty = True
			' [Titi 2.6.0] fix for RT 13 (happened when searching creatures to access items)
			'UPGRADE_WARNING: Couldn't resolve default property of object TreeViewX.SelectedItem.Tag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tag_Renamed = TreeViewX.SelectedItem.Tag
			'Tag = TreeViewX.Tag
			ObjectX = ObjectListX.Item(Tag_Renamed)
			Select Case ParseTag(Tag_Renamed)
				Case bdEditEncounter
					' Remove child objects from the tree
					If Refresh_Renamed = True Then
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Creatures. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						For	Each CreatureX In ObjectX.Creatures
							EditDelete(Tag_Renamed & "X" & CreatureX.Index, True)
						Next CreatureX
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Items. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						For	Each ItemX In ObjectX.Items
							EditDelete(Tag_Renamed & "I" & ItemX.Index, True)
						Next ItemX
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Triggers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						For	Each TriggerX In ObjectX.Triggers
							EditDelete(Tag_Renamed & "T" & TriggerX.Index, True)
						Next TriggerX
					End If
					' Copy from Buffer and redisplay
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Copy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					ObjectX.Copy(CopyBufferSet.Item(Index))
					If Refresh_Renamed = True Then
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						TreeViewX.Nodes(Tag_Renamed).Text = ObjectX.Name
						' Restore child objects to the tree
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Creatures. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						For	Each CreatureX In ObjectX.Creatures
							ShowCreature(ObjectListX, TreeViewX, Tag_Renamed, CreatureX)
						Next CreatureX
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Items. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						For	Each ItemX In ObjectX.Items
							ShowItem(ObjectListX, TreeViewX, Tag_Renamed, ItemX)
						Next ItemX
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Triggers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						For	Each TriggerX In ObjectX.Triggers
							ShowTrigger(ObjectListX, TreeViewX, Tag_Renamed, TriggerX)
						Next TriggerX
					ElseIf blnUpdate = True Then  ' [Titi 2.5.1] At least, update the name of the node to tell the user that the replacement is done!
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						TreeViewX.Nodes(Tag_Renamed).Text = ObjectX.Name
					End If
				Case bdEditCreature
					' Remove child objects from the tree
					If Refresh_Renamed = True Then
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Items. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						For	Each ItemX In ObjectX.Items
							EditDelete(Tag_Renamed & "I" & ItemX.Index, True)
						Next ItemX
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Triggers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						For	Each TriggerX In ObjectX.Triggers
							EditDelete(Tag_Renamed & "T" & TriggerX.Index, True)
						Next TriggerX
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Conversations. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						For	Each ConversationX In ObjectX.Conversations
							EditDelete(Tag_Renamed & "C" & ConversationX.Index, True)
						Next ConversationX
					End If
					' Copy from Buffer and redisplay
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Copy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					ObjectX.Copy(CopyBufferSet.Item(Index))
					If Refresh_Renamed = True Then
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						TreeViewX.Nodes(Tag_Renamed).Text = ObjectX.Name
						' Restore child objects to the tree
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Triggers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						For	Each TriggerX In ObjectX.Triggers
							ShowTrigger(ObjectListX, TreeViewX, Tag_Renamed, TriggerX)
						Next TriggerX
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Items. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						For	Each ItemX In ObjectX.Items
							ShowItem(ObjectListX, TreeViewX, Tag_Renamed, ItemX)
						Next ItemX
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Conversations. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						For	Each ConversationX In ObjectX.Conversations
							ShowConversation(ObjectListX, TreeViewX, Tag_Renamed, ConversationX)
						Next ConversationX
					ElseIf blnUpdate = True Then  ' [Titi 2.5.1] At least, update the name of the node to tell the user that the replacement is done!
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						TreeViewX.Nodes(Tag_Renamed).Text = ObjectX.Name
					End If
				Case bdEditItem
					' Remove child objects from the tree
					If Refresh_Renamed = True Then
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Items. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						For	Each ItemX In ObjectX.Items
							EditDelete(Tag_Renamed & "I" & ItemX.Index, True)
						Next ItemX
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Triggers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						For	Each TriggerX In ObjectX.Triggers
							EditDelete(Tag_Renamed & "T" & TriggerX.Index, True)
						Next TriggerX
					End If
					' Copy from Buffer and redisplay
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Copy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					ObjectX.Copy(CopyBufferSet.Item(Index))
					If Refresh_Renamed = True Then
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						TreeViewX.Nodes(Tag_Renamed).Text = ObjectX.Name
						' Restore child objects to the tree
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Triggers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						For	Each TriggerX In ObjectX.Triggers
							ShowTrigger(ObjectListX, TreeViewX, Tag_Renamed, TriggerX)
						Next TriggerX
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Items. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						For	Each ItemX In ObjectX.Items
							ShowItem(ObjectListX, TreeViewX, Tag_Renamed, ItemX)
						Next ItemX
					ElseIf blnUpdate = True Then  ' [Titi 2.5.1] At least, update the name of the node to tell the user that the replacement is done!
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						TreeViewX.Nodes(Tag_Renamed).Text = ObjectX.Name
					End If
				Case bdEditTrigger
					' Remove child objects from the tree
					If Refresh_Renamed = True Then
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Creatures. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						For	Each CreatureX In ObjectX.Creatures
							EditDelete(Tag_Renamed & "X" & CreatureX.Index, True)
						Next CreatureX
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Items. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						For	Each ItemX In ObjectX.Items
							EditDelete(Tag_Renamed & "I" & ItemX.Index, True)
						Next ItemX
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Triggers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						For	Each TriggerX In ObjectX.Triggers
							EditDelete(Tag_Renamed & "T" & TriggerX.Index, True)
						Next TriggerX
					End If
					' Copy from Buffer and redisplay
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Copy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					ObjectX.Copy(CopyBufferSet.Item(Index))
					If Refresh_Renamed = True Then
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.TriggerType. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						TreeViewX.Nodes(Tag_Renamed).Text = TriggerName(ObjectX.TriggerType) & " " & ObjectX.Name
						' Restore child objects to the tree
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Creatures. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						For	Each CreatureX In ObjectX.Creatures
							ShowCreature(ObjectListX, TreeViewX, Tag_Renamed, CreatureX)
						Next CreatureX
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Items. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						For	Each ItemX In ObjectX.Items
							ShowItem(ObjectListX, TreeViewX, Tag_Renamed, ItemX)
						Next ItemX
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Triggers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						For	Each TriggerX In ObjectX.Triggers
							ShowTrigger(ObjectListX, TreeViewX, Tag_Renamed, TriggerX)
						Next TriggerX
					ElseIf blnUpdate = True Then  ' [Titi 2.5.1] At least, update the name of the node to tell the user that the replacement is done!
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.TriggerType. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						TreeViewX.Nodes(Tag_Renamed).Text = TriggerName(ObjectX.TriggerType) & " " & ObjectX.Name
					End If
			End Select
			' Redisplay in the open form
			For c = 0 To My.Application.OpenForms.Count - 1
				If My.Application.OpenForms.Item(c).Tag = Tag_Renamed Then
					Select Case ParseTag(Tag_Renamed)
						Case bdEditEncounter
							If InStr(Tag_Renamed, "Themes") > 0 Then
								ParentX = ObjectListX.Item(TreeViewX.Nodes(Tag_Renamed).Parent.Parent.Tag)
							Else
								ParentX = ObjectListX.Item(TreeViewX.Nodes(Tag_Renamed).Parent.Tag)
							End If
							'UPGRADE_ISSUE: Control ShowEncounter could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
							My.Application.OpenForms.Item(c).ShowEncounter(TreeViewX, ParentX, ObjectX)
						Case bdEditCreature
							'UPGRADE_ISSUE: Control ShowMons could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
							My.Application.OpenForms.Item(c).ShowMons(TreeViewX, ObjectX)
						Case bdEditItem
							'UPGRADE_ISSUE: Control ShowItem could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
							My.Application.OpenForms.Item(c).ShowItem(TreeViewX, ObjectX)
						Case bdEditTrigger
							Select Case ParseTag(TreeViewX.Nodes(Tag_Renamed).Parent.Tag)
								Case bdEditEncounter
									'UPGRADE_ISSUE: Control ShowTrigger could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
									My.Application.OpenForms.Item(c).ShowTrigger(TreeViewX, ObjectX, bdTrigEncounter)
								Case bdEditItem
									'UPGRADE_ISSUE: Control ShowTrigger could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
									My.Application.OpenForms.Item(c).ShowTrigger(TreeViewX, ObjectX, bdTrigItem)
								Case bdEditCreature
									'UPGRADE_ISSUE: Control ShowTrigger could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
									My.Application.OpenForms.Item(c).ShowTrigger(TreeViewX, ObjectX, bdTrigCreature)
								Case bdEditTomeTriggers
									'UPGRADE_ISSUE: Control ShowTrigger could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
									My.Application.OpenForms.Item(c).ShowTrigger(TreeViewX, ObjectX, bdTrigTome)
								Case bdEditTopic
									'UPGRADE_ISSUE: Control ShowTrigger could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
									My.Application.OpenForms.Item(c).ShowTrigger(TreeViewX, ObjectX, bdTrigTopic)
								Case bdEditTrigger
									'UPGRADE_ISSUE: Control ShowTrigger could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
									My.Application.OpenForms.Item(c).ShowTrigger(TreeViewX, ObjectX, bdTrigTrig)
								Case bdEditTile
									'UPGRADE_ISSUE: Control ShowTrigger could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
									My.Application.OpenForms.Item(c).ShowTrigger(TreeViewX, ObjectX, bdTrigTile)
							End Select
					End Select
					Exit For
				End If
			Next c
		End If
	End Sub
	
	'UPGRADE_NOTE: Area was upgraded to Area_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	'UPGRADE_NOTE: Tag was upgraded to Tag_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub EditAdd(ByRef Tag_Renamed As String, ByRef AddType As Short, Optional ByRef blnNew As Boolean = False)
		Dim Area_Renamed As Object
		Dim frmWorldSettings As Object
		' [Titi 2.4.9b] to make sure the archetype will always match the kingdom's race
		'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Visible. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If frmWorldSettings.Visible = True And ParseTag(Tag_Renamed) = bdEditTomeParty Then
			MsgBox("This action is not possible while a world is being created.", MsgBoxStyle.Exclamation, "Cannot cut/copy/insert a creature now.")
			Exit Sub
		End If
		Dim ObjectX, ObjectEdit As Object
		Dim i As Short
		Dim c, Found As Short
		Dim FormX As System.Windows.Forms.Form
		ObjectX = ObjectListX.Item(Tag_Renamed)
		' Show in Open Form (if there is one)
		Select Case ParseTag(Tag_Renamed)
			Case bdEditMapEncounters, bdEditMapCreatures
				i = 10
			Case bdEditMapTiles, bdEditTile
				i = 5
			Case bdEditMapTileSets
				i = 8
			Case bdEditMapThemes
				i = 6
			Case bdEditTomeParty
				i = 5
			Case bdEditTomeJournals
				i = 8
			Case bdEditTomeTriggers
				i = 8
			Case bdEditTomeAreas
				i = 5
			Case Else
				i = 0
		End Select
		Found = False
		For c = 0 To My.Application.OpenForms.Count - 1
			If My.Application.OpenForms.Item(c).Tag = VB.Left(Tag_Renamed, Len(Tag_Renamed) - i) Then
				FormX = My.Application.OpenForms.Item(c)
				Found = True
				Exit For
			End If
		Next c
		' Add object
		Select Case AddType
			Case bdEditMap
				'UPGRADE_WARNING: Couldn't resolve default property of object Area.Plot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = Area.Plot.AddMap
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowMap(ObjectListX, TreeViewX, ObjectEdit)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Tag_Renamed = "M" & ObjectEdit.Index
			Case bdEditEncounter
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddEncounter. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = ObjectX.AddEncounter
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowEncounter(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListEncounters could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListEncounters()
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Tag_Renamed = Tag_Renamed & "E" & ObjectEdit.Index
			Case bdEditCreature, bdEditMapCreatures
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddCreature. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = ObjectX.AddCreature
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowCreature(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListCreatures could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListCreatures()
				End If
				If ParseTag(Tag_Renamed) = bdEditEncounter Then
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					PositionCreature(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Tag_Renamed = Tag_Renamed & "X" & ObjectEdit.Index
			Case bdEditItem
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddItem. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = ObjectX.AddItem
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowItem(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListItems could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListItems()
				End If
				If ParseTag(Tag_Renamed) = bdEditEncounter Then
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					PositionItem(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Tag_Renamed = Tag_Renamed & "I" & ObjectEdit.Index
			Case bdEditTrigger
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddTrigger. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = ObjectX.AddTrigger
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowTrigger(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListTriggers could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListTriggers()
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Tag_Renamed = Tag_Renamed & "T" & ObjectEdit.Index
			Case bdEditConvo
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddConversation. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = ObjectX.AddConversation
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowConversation(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListConvos could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListConvos()
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Tag_Renamed = Tag_Renamed & "C" & ObjectEdit.Index
			Case bdEditTopic
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddTopic. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = ObjectX.AddTopic
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowTopic(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListTopics could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListTopics()
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Tag_Renamed = Tag_Renamed & "Q" & ObjectEdit.Index
			Case bdEditTheme
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddTheme. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = ObjectX.AddTheme
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowTheme(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListThemes could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListThemes()
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Tag_Renamed = Tag_Renamed & "R" & ObjectEdit.Index
			Case bdEditTile
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddTile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = ObjectX.AddTile
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowTile(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListTiles could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListTiles()
				End If
				' Find Map Graphic too (if open)
				Found = False
				For c = 0 To My.Application.OpenForms.Count - 1
					If VB.Right(My.Application.OpenForms.Item(c).Tag, 7) = "Graphic" Then
						If VB.Left(My.Application.OpenForms.Item(c).Tag, Len(My.Application.OpenForms.Item(c).Tag) - 7) = VB.Left(Tag_Renamed, Len(Tag_Renamed) - 5) Then
							'UPGRADE_ISSUE: Control SetTileList could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
							My.Application.OpenForms.Item(c).SetTileList()
							'UPGRADE_ISSUE: Control ListTiles could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
							My.Application.OpenForms.Item(c).ListTiles()
							Exit For
						End If
					End If
				Next c
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Tag_Renamed = Tag_Renamed & "L" & ObjectEdit.Index
			Case bdEditEntryPoint
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddEntryPoint. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = ObjectX.AddEntryPoint
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowEntryPoint(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListEntryPoints could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListEntryPoints()
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Tag_Renamed = Tag_Renamed & "P" & ObjectEdit.Index
			Case bdEditTileSet
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddTileSet. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = ObjectX.AddTileSet
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowTileSet(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListTileSets could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListTileSets()
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Tag_Renamed = Tag_Renamed & "W" & ObjectEdit.Index
			Case bdEditFactoid
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddFactoid. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = ObjectX.AddFactoid
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowFactoid(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListFactoids could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListFactoids()
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Tag_Renamed = Tag_Renamed & "F" & ObjectEdit.Index
			Case bdEditJournal
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddJournal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = ObjectX.AddJournal
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowJournal(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListJournals could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListJournals()
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Tag_Renamed = Tag_Renamed & "J" & ObjectEdit.Index
			Case bdEditArea
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddArea. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = ObjectX.AddArea
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Plot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.Plot = New Plot
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Plot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.Plot.AddMap()
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ShowArea(ObjectListX, TreeViewX, Tag_Renamed, ObjectEdit)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Plot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.Plot.Maps(1).AddEntryPoint()
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				OpenArea(ObjectEdit)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListAreas could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListAreas()
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Tag_Renamed = Tag_Renamed & "A" & ObjectEdit.Index
				Exit Sub
		End Select
		EditProperties(Tag_Renamed, blnNew)
		Dirty = True
	End Sub
	
	'UPGRADE_NOTE: Tag was upgraded to Tag_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub EditSave(ByRef Tag_Renamed As String, ByRef SaveType As Short)
		Dim oErr As Object
		Dim ObjectX, ObjectEdit As Object
		Dim i As Short
		Dim c, Found As Short
		Dim FormX As System.Windows.Forms.Form
		Dim rc As Integer
		Dim FileName As String
		On Error GoTo ErrorHandler
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		dlgFile.CancelError = True
		Select Case SaveType
			Case bdEditMap
				dlgFileOpen.Title = "Save to Map Library"
				dlgFileSave.Title = "Save to Map Library"
				'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				dlgFileOpen.Filter = "Map Files (*.rsm)|*.rsm|All Files (*.*)|*.*"
				dlgFileSave.Filter = "Map Files (*.rsm)|*.rsm|All Files (*.*)|*.*"
				FileName = ".rsm"
			Case bdEditEncounter
				dlgFileOpen.Title = "Save to Encounter Library"
				dlgFileSave.Title = "Save to Encounter Library"
				'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				dlgFileOpen.Filter = "Encounter Files (*.rse)|*.rse|All Files (*.*)|*.*"
				dlgFileSave.Filter = "Encounter Files (*.rse)|*.rse|All Files (*.*)|*.*"
				FileName = ".rse"
			Case bdEditCreature, bdEditMapCreatures
				dlgFileOpen.Title = "Save to Creature Library"
				dlgFileSave.Title = "Save to Creature Library"
				'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				dlgFileOpen.Filter = "Creature Files (*.rsc)|*.rsc|All Files (*.*)|*.*"
				dlgFileSave.Filter = "Creature Files (*.rsc)|*.rsc|All Files (*.*)|*.*"
				FileName = ".rsc"
			Case bdEditItem
				dlgFileOpen.Title = "Save to Item Library"
				dlgFileSave.Title = "Save to Item Library"
				'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				dlgFileOpen.Filter = "Item Files (*.rsi)|*.rsi|All Files (*.*)|*.*"
				dlgFileSave.Filter = "Item Files (*.rsi)|*.rsi|All Files (*.*)|*.*"
				FileName = ".rsi"
			Case bdEditTrigger
				dlgFileOpen.Title = "Save to Trigger Library"
				dlgFileSave.Title = "Save to Trigger Library"
				'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				dlgFileOpen.Filter = "Trigger Files (*.rst)|*.rst|All Files (*.*)|*.*"
				dlgFileSave.Filter = "Trigger Files (*.rst)|*.rst|All Files (*.*)|*.*"
				FileName = ".rst"
			Case bdEditConvo
				dlgFileOpen.Title = "Save to Conversation Library"
				dlgFileSave.Title = "Save to Conversation Library"
				'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				dlgFileOpen.Filter = "Conversation Files (*.rsq)|*.rsq|All Files (*.*)|*.*"
				dlgFileSave.Filter = "Conversation Files (*.rsq)|*.rsq|All Files (*.*)|*.*"
				FileName = ".rsq"
			Case bdEditTheme
				dlgFileOpen.Title = "Save to Theme Library"
				dlgFileSave.Title = "Save to Theme Library"
				'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				dlgFileOpen.Filter = "Theme Files (*.rsr)|*.rsr|All Files (*.*)|*.*"
				dlgFileSave.Filter = "Theme Files (*.rsr)|*.rsr|All Files (*.*)|*.*"
				FileName = ".rsr"
			Case bdEditArea
				dlgFileOpen.Title = "Save to Area Library"
				dlgFileSave.Title = "Save to Area Library"
				'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				dlgFileOpen.Filter = "Area Files (*.rsa)|*.rsa|All Files (*.*)|*.*"
				dlgFileSave.Filter = "Area Files (*.rsa)|*.rsa|All Files (*.*)|*.*"
				FileName = ".rsa"
		End Select
		dlgFileOpen.FilterIndex = 1
		dlgFileSave.FilterIndex = 1
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFile.Flags was upgraded to dlgFileOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		dlgFileOpen.ShowReadOnly = False
		dlgFileOpen.RestoreDirectory = False
		dlgFileSave.RestoreDirectory = False
		'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFile.Flags was upgraded to dlgFileSave.OverwritePrompt which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		dlgFileSave.OverwritePrompt = True
		ObjectX = ObjectListX.Item(Tag_Renamed)
		'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		dlgFileOpen.FileName = ObjectX.Name & FileName
		dlgFileSave.FileName = ObjectX.Name & FileName
		' [Titi 2.4.9] check if name is valid
		While CheckName((dlgFileOpen.FileName)) > 0
			dlgFileOpen.FileName = InputBox("Make sure the file name does not contain ?/<>*|\:" & Chr(34), "Invalid character found!", dlgFileOpen.FileName)
			dlgFileSave.FileName = InputBox("Make sure the file name does not contain ?/<>*|\:" & Chr(34), "Invalid character found!", dlgFileOpen.FileName)
		End While
		If dlgFileOpen.FileName = "" Then
			'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			MsgBox("Action cancelled. The " & VB.Left(dlgFileOpen.Filter, InStr(dlgFileOpen.Filter, Chr(32))) & " has NOT been SAVED.",  , "Save failed!")
			Exit Sub
		End If
		dlgFileSave.ShowDialog()
		dlgFileOpen.FileName = dlgFileSave.FileName
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		If Err.Number = DialogResult.Cancel Then
			Exit Sub
		End If
		' Set cursor to hourglass
		FileName = dlgFileOpen.FileName
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		' [Titi 2.4.9b] the SaveToFile method of the areas only saves their properties, not the maps
		If SaveType = bdEditArea Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SaveArea(ObjectX, FileName) ' but SaveArea does, so let's use it!
		Else
			c = FreeFile
			Kill(FileName)
			FileOpen(c, FileName, OpenMode.Binary)
			'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.SaveToFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ObjectX.SaveToFile(c)
			FileClose(c)
		End If
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		Exit Sub
ErrorHandler: 
		If Err.Number <> 53 Then ' [Titi 2.4.9b] We don't want the error to be logged if it comes from Kill trying to delete an inexisting file!
			'UPGRADE_WARNING: Couldn't resolve default property of object oErr.logError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			oErr.logError("EditSave: cannot " & dlgFileOpen.Title & " (error #" & Err.Number & ": " & Err.Description & ")")
		End If
		Resume Next
	End Sub
	
	Public Function CheckName(ByRef strName As String) As Short
		Dim i As Short
		Dim c As Object
		Dim NotAllowed As New Collection
		NotAllowed.Add(Chr(34))
		NotAllowed.Add("?")
		NotAllowed.Add("*")
		NotAllowed.Add(":")
		NotAllowed.Add("|")
		NotAllowed.Add("<")
		NotAllowed.Add(">")
		NotAllowed.Add("/")
		NotAllowed.Add("\")
		For i = 1 To Len(strName)
			For	Each c In NotAllowed
				'UPGRADE_WARNING: Couldn't resolve default property of object c. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If c = Mid(strName, i, 1) Then
					CheckName = i
					Exit Function
				End If
			Next c
		Next i
		CheckName = 0
	End Function
	
	'UPGRADE_NOTE: Area was upgraded to Area_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	'UPGRADE_NOTE: Tag was upgraded to Tag_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub EditDelete(ByRef Tag_Renamed As String, Optional ByRef bConfirmation As Boolean = False)
		Dim Tome_Renamed As Object
		Dim frmWorldSettings As Object
		Dim Area_Renamed As Object
		Dim c, i As Short
		Dim ObjectDelete As Object
		Dim ObjectX As Object
		Dim FormX As System.Windows.Forms.Form
		Dim Found As Short
		Dim EncounterX As Encounter
		Dim FactoidX As Factoid
		Dim CreatureX As Creature
		Dim TriggerX As Trigger
		Dim ItemX As Item
		Dim ConversationX As Conversation
		Dim TopicX As Topic
		Dim ParentTag As String
		Dim TileX As Tile
		Dim TileSetX As TileSet
		Dim ThemeX As Theme
		Dim EntryPointX As EntryPoint
		Dim AreaX As Area
		Dim JournalX As Journal
		'-- Confirmation
		If bConfirmation Then
			If MsgBox("Are you sure you want to remove this item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Remove Item") = MsgBoxResult.No Then Exit Sub
		End If
		' Delete object
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		If ParseTag(Tag_Renamed) = bdEditMap Then
			ParentTag = ""
			ObjectX = Area
		ElseIf ParseTag(Tag_Renamed) = bdEditTome Then 
			ParentTag = ""
			ObjectX = Tome
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object TreeViewX.Nodes().Parent.Tag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ParentTag = TreeViewX.Nodes(Tag_Renamed).Parent.Tag
			ObjectX = ObjectListX.Item(TreeViewX.Nodes(Tag_Renamed).Parent.Tag)
		End If
		' Show in Open Form (if there is one)
		Select Case ParseTag(ParentTag)
			Case bdEditMapEncounters
				i = 10
			Case bdEditMapTiles
				i = 5
			Case bdEditMapTileSets
				i = 8
			Case bdEditMapThemes
				i = 6
			Case bdEditMapEntryPoints
				i = 11
			Case bdEditTomeParty
				i = 5
			Case bdEditTomeJournals
				i = 7
			Case bdEditTomeTriggers
				i = 8
			Case bdEditMapCreatures
				i = 10
			Case Else
				i = 0
		End Select
		Found = False
		For c = 0 To My.Application.OpenForms.Count - 1
			If My.Application.OpenForms.Item(c).Tag = VB.Left(ParentTag, Len(ParentTag) - i) Then
				FormX = My.Application.OpenForms.Item(c)
				Found = True
				Exit For
			End If
		Next c
		' Set object to delete
		ObjectDelete = ObjectListX.Item(Tag_Renamed)
		' Delete the object
		Select Case ParseTag(Tag_Renamed)
			Case bdEditTome
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Creatures. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each CreatureX In ObjectDelete.Creatures
					EditDelete(Tag_Renamed & "PartyX" & CreatureX.Index)
				Next CreatureX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Factoids. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each FactoidX In ObjectDelete.Factoids
					EditDelete(Tag_Renamed & "FactoidsF" & FactoidX.Index)
				Next FactoidX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Journals. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each JournalX In ObjectDelete.Journals
					EditDelete(Tag_Renamed & "JournalsJ" & JournalX.Index)
				Next JournalX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Triggers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each TriggerX In ObjectDelete.Triggers
					EditDelete(Tag_Renamed & "TriggersT" & TriggerX.Index)
				Next TriggerX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Areas. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each AreaX In ObjectDelete.Areas
					'               EditDelete Tag & "AreasT" & AreaX.Index ' <-- Key for areas begin with A ???
					EditDelete(Tag_Renamed & "AreasA" & AreaX.Index)
				Next AreaX
				ObjectListX.Remove(Tag_Renamed & "Party")
				ObjectListX.Remove(Tag_Renamed & "Journal")
				ObjectListX.Remove(Tag_Renamed & "Triggers")
			Case bdEditMap
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Tiles. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each TileX In ObjectDelete.Tiles
					EditDelete(Tag_Renamed & "TilesL" & TileX.Index)
				Next TileX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.TileSets. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each TileSetX In ObjectDelete.TileSets
					EditDelete(Tag_Renamed & "TileSetsW" & TileSetX.Index)
				Next TileSetX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.EntryPoints. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each EntryPointX In ObjectDelete.EntryPoints
					EditDelete(Tag_Renamed & "EntryPointsP" & EntryPointX.Index)
				Next EntryPointX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Creatures. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each CreatureX In ObjectDelete.Creatures
					EditDelete(Tag_Renamed & "CreaturesX" & CreatureX.Index)
				Next CreatureX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Themes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each ThemeX In ObjectDelete.Themes
					EditDelete(Tag_Renamed & "ThemesR" & ThemeX.Index)
				Next ThemeX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Encounters. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each EncounterX In ObjectDelete.Encounters
					EditDelete(Tag_Renamed & "EncountersE" & EncounterX.Index)
				Next EncounterX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Area.Plot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Area.Plot.RemoveMap("M" & ObjectDelete.Index)
				' Loop through open forms and close if open
				c = 0
				Do While c < My.Application.OpenForms.Count
					If My.Application.OpenForms.Item(c).Tag = Tag_Renamed & "Graphic" Then
						'UPGRADE_ISSUE: Unload Forms() was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="875EBAD7-D704-4539-9969-BC7DBDAA62A2"'
						Unload(My.Application.OpenForms(c))
						c = c - 1
					End If
					c = c + 1
				Loop 
				ObjectListX.Remove(Tag_Renamed & "Graphic")
				ObjectListX.Remove(Tag_Renamed & "Tiles")
				ObjectListX.Remove(Tag_Renamed & "TileSets")
				ObjectListX.Remove(Tag_Renamed & "EntryPoints")
				ObjectListX.Remove(Tag_Renamed & "Themes")
				ObjectListX.Remove(Tag_Renamed & "Encounters")
				ObjectListX.Remove(Tag_Renamed & "Creatures")
			Case bdEditDoor
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Triggers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each TriggerX In ObjectDelete.Triggers
					EditDelete(Tag_Renamed & "T" & TriggerX.Index)
				Next TriggerX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.RemoveDoor. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectX.RemoveDoor("D" & ObjectDelete.Index)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListDoors could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListDoors()
				End If
			Case bdEditEncounter
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Creatures. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each CreatureX In ObjectDelete.Creatures
					EditDelete(Tag_Renamed & "X" & CreatureX.Index)
				Next CreatureX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Items. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each ItemX In ObjectDelete.Items
					EditDelete(Tag_Renamed & "I" & ItemX.Index)
				Next ItemX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Triggers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each TriggerX In ObjectDelete.Triggers
					EditDelete(Tag_Renamed & "T" & TriggerX.Index)
				Next TriggerX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.RemoveEncounter. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectX.RemoveEncounter("E" & ObjectDelete.Index)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListEncounters could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListEncounters()
				End If
			Case bdEditCreature, bdEditMapCreatures
				' [Titi 2.4.9b] deleting a creature while working on a tome means removing the kingdom as well
				'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Visible. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.mnuDelete_Click. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If frmWorldSettings.Visible And HoldNode = -1 Then frmWorldSettings.mnuDelete_Click()
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Items. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each ItemX In ObjectDelete.Items
					EditDelete(Tag_Renamed & "I" & ItemX.Index)
				Next ItemX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Triggers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each TriggerX In ObjectDelete.Triggers
					EditDelete(Tag_Renamed & "T" & TriggerX.Index)
				Next TriggerX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Conversations. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each ConversationX In ObjectDelete.Conversations
					EditDelete(Tag_Renamed & "C" & ConversationX.Index)
				Next ConversationX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.RemoveCreature. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectX.RemoveCreature("X" & ObjectDelete.Index)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListCreatures could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListCreatures()
				End If
			Case bdEditItem
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Items. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each ItemX In ObjectDelete.Items
					EditDelete(Tag_Renamed & "I" & ItemX.Index)
				Next ItemX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Triggers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each TriggerX In ObjectDelete.Triggers
					EditDelete(Tag_Renamed & "T" & TriggerX.Index)
				Next TriggerX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.RemoveItem. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectX.RemoveItem("I" & ObjectDelete.Index)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListItems could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListItems()
				End If
			Case bdEditTrigger
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Items. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each ItemX In ObjectDelete.Items
					EditDelete(Tag_Renamed & "I" & ItemX.Index)
				Next ItemX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Triggers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each TriggerX In ObjectDelete.Triggers
					EditDelete(Tag_Renamed & "T" & TriggerX.Index)
				Next TriggerX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Creatures. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each CreatureX In ObjectDelete.Creatures
					EditDelete(Tag_Renamed & "X" & CreatureX.Index)
				Next CreatureX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.RemoveTrigger. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectX.RemoveTrigger("T" & ObjectDelete.Index)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListTriggers could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListTriggers()
				End If
			Case bdEditConvo
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Topics. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each TopicX In ObjectDelete.Topics
					EditDelete(Tag_Renamed & "Q" & TopicX.Index)
				Next TopicX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.RemoveConversation. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectX.RemoveConversation("C" & ObjectDelete.Index)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListConvos could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListConvos()
				End If
			Case bdEditTopic
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Triggers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each TriggerX In ObjectDelete.Triggers
					EditDelete(Tag_Renamed & "T" & TriggerX.Index)
				Next TriggerX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Factoids. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each FactoidX In ObjectDelete.Factoids
					EditDelete(Tag_Renamed & "F" & FactoidX.Index)
				Next FactoidX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.RemoveTopic. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectX.RemoveTopic("Q" & ObjectDelete.Index)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListTopics could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListTopics()
				End If
			Case bdEditTheme
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Encounters. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each EncounterX In ObjectDelete.Encounters
					EditDelete(Tag_Renamed & "E" & EncounterX.Index)
				Next EncounterX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Creatures. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each CreatureX In ObjectDelete.Creatures
					EditDelete(Tag_Renamed & "X" & CreatureX.Index)
				Next CreatureX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Items. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each ItemX In ObjectDelete.Items
					EditDelete(Tag_Renamed & "I" & ItemX.Index)
				Next ItemX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Triggers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each TriggerX In ObjectDelete.Triggers
					EditDelete(Tag_Renamed & "T" & TriggerX.Index)
				Next TriggerX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Factoids. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For	Each FactoidX In ObjectDelete.Factoids
					EditDelete(Tag_Renamed & "F" & FactoidX.Index)
				Next FactoidX
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.RemoveTheme. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectX.RemoveTheme("R" & ObjectDelete.Index)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListThemes could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListThemes()
				End If
			Case bdEditEntryPoint
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.RemoveEntryPoint. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectX.RemoveEntryPoint("P" & ObjectDelete.Index)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListEntryPoints could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListEntryPoints()
				End If
			Case bdEditTile
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.RemoveTile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectX.RemoveTile("L" & ObjectDelete.Index)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListTiles could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListTiles()
				End If
				' Find Map Graphic too (if open)
				Found = False
				For c = 0 To My.Application.OpenForms.Count - 1
					If VB.Right(My.Application.OpenForms.Item(c).Tag, 7) = "Graphic" Then
						If VB.Left(My.Application.OpenForms.Item(c).Tag, Len(My.Application.OpenForms.Item(c).Tag) - 7) = VB.Left(ParentTag, Len(ParentTag) - 5) Then
							'UPGRADE_ISSUE: Control SetTileList could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
							My.Application.OpenForms.Item(c).SetTileList()
							Exit For
						End If
					End If
				Next c
			Case bdEditTileSet
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.RemoveTileSet. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectX.RemoveTileSet("W" & ObjectDelete.Index)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListTileSets could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListTileSets()
				End If
			Case bdEditFactoid
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.RemoveFactoid. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectX.RemoveFactoid("F" & ObjectDelete.Index)
				If Found = True Then
					'UPGRADE_ISSUE: Control ListFactoids could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					FormX.ListFactoids()
				End If
			Case bdEditArea
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.RemoveArea. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectX.RemoveArea("A" & ObjectDelete.Index)
			Case bdEditJournal
				' [Titi 2.4.8]
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectDelete.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.RemoveJournal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectX.RemoveJournal("J" & ObjectDelete.Index)
			Case Else
				'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
				Exit Sub
		End Select
		' Loop through open forms and close if open
		c = 0
		Do While c < My.Application.OpenForms.Count
			If My.Application.OpenForms.Item(c).Tag = Tag_Renamed Then
				'UPGRADE_ISSUE: Unload Forms() was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="875EBAD7-D704-4539-9969-BC7DBDAA62A2"'
				Unload(My.Application.OpenForms(c))
				c = c - 1
			End If
			c = c + 1
		Loop 
		' Remove from the tree list
		TreeViewX.Nodes.Remove(Tag_Renamed)
		ObjectListX.Remove(Tag_Renamed)
		' If no Areas left, then add one back
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Areas. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Tome.Areas.Count < 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.AddArea. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ObjectX = Tome.AddArea
			'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ShowArea(ObjectListX, TreeViewX, "TomeAreas", ObjectX)
			'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Plot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ObjectX.Plot.AddMap()
			'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Plot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ObjectX.Plot.Maps(1).AddEntryPoint()
			'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			OpenArea(ObjectX)
		End If
		' If no maps left in Area, add one back
		'UPGRADE_WARNING: Couldn't resolve default property of object Area.Plot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Area.Plot.Maps.Count < 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Areas. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.Areas(1).Plot.AddMap()
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Areas. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.Areas(1).Plot.Maps(1).AddEntryPoint()
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Areas. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			OpenArea(Tome.Areas(1))
		End If
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		Dirty = True
	End Sub
	
	'UPGRADE_NOTE: Tag was upgraded to Tag_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub EditProperties(ByRef Tag_Renamed As String, Optional ByRef AtX As Object = Nothing, Optional ByRef AtY As Object = Nothing)
		Dim c, Found As Short
		Dim ParentX As Object
		Dim GrandParentX As Object
		Dim ObjectX As Object
		Dim NewForm As System.Windows.Forms.Form
		On Error GoTo ErrorHandler
		' Check to see if a Form is already open for this Object
		Found = False
		For c = 0 To My.Application.OpenForms.Count - 1
			If My.Application.OpenForms.Item(c).Tag = Tag_Renamed Then
				'UPGRADE_WARNING: Form method Forms.ZOrder has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
				My.Application.OpenForms.Item(c).BringToFront()
				Found = True
				Exit For
			End If
		Next c
		ObjectX = ObjectListX.Item(Tag_Renamed)
		If Found = False Then
			' Pop to correct editor based on type of object
			Select Case ParseTag(Tag_Renamed)
				Case bdEditMap
					NewForm = New frmMapProp
					'UPGRADE_ISSUE: Control ShowMap could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					NewForm.ShowMap(TreeViewX, ObjectX)
				Case bdEditMapGraphic
					NewForm = New frmMap
					'UPGRADE_ISSUE: Control ShowMap could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					NewForm.ShowMap(TreeViewX, ObjectX)
				Case bdEditEncounter
					NewForm = New frmEncProp
					If InStr(Tag_Renamed, "Themes") > 0 Then
						ParentX = ObjectListX.Item(TreeViewX.Nodes(Tag_Renamed).Parent.Parent.Tag)
					Else
						ParentX = ObjectListX.Item(TreeViewX.Nodes(Tag_Renamed).Parent.Tag)
					End If
					'UPGRADE_ISSUE: Control ShowEncounter could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					NewForm.ShowEncounter(TreeViewX, ParentX, ObjectX)
				Case bdEditTileSet
					NewForm = New frmTileSetProp
					'UPGRADE_ISSUE: Control ShowTileSet could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					NewForm.ShowTileSet(TreeViewX, ObjectX)
				Case bdEditEntryPoint
					NewForm = New frmEntryPoint
					'UPGRADE_ISSUE: Control ShowEntryPoint could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					NewForm.ShowEntryPoint(Tome, ObjectListX.Item(TreeViewX.Nodes(Tag_Renamed).Parent.Parent.Tag), ObjectX)
				Case bdEditTile
					NewForm = New frmTileProp
					ParentX = ObjectListX.Item(TreeViewX.Nodes(Tag_Renamed).Parent.Tag)
					'UPGRADE_ISSUE: Control ShowTile could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					NewForm.ShowTile(TreeViewX, ParentX, ObjectX)
				Case bdEditItem
					NewForm = New frmItem
					'UPGRADE_ISSUE: Control ShowItem could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					NewForm.ShowItem(TreeViewX, ObjectX)
				Case bdEditCreature, bdEditMapCreatures
					NewForm = New frmMonsProp
					' [Titi 2.5.1]
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.BodyType. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					BodyType = Int(ObjectX.BodyType(2) / 11)
					frmMonsProp.CreatureX = ObjectX
					'UPGRADE_ISSUE: Control ShowMons could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					NewForm.ShowMons(TreeViewX, ObjectX)
				Case bdEditTrigger
					' Find any open Trigger Property Sheets and Close them (max open is two)
					Found = 0
					For c = 0 To My.Application.OpenForms.Count - 1
						If ParseTag(My.Application.OpenForms.Item(c).Tag) = bdEditTrigger Then
							Found = Found + 1
						End If
					Next c
					c = 0
					If Found > 2 Then
						Do Until c > My.Application.OpenForms.Count Or Found < 3
							If ParseTag(My.Application.OpenForms.Item(c).Tag) = bdEditTrigger Then
								'UPGRADE_ISSUE: Unload Forms() was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="875EBAD7-D704-4539-9969-BC7DBDAA62A2"'
								Unload(My.Application.OpenForms(c))
								Found = Found - 1
							Else
								c = c + 1
							End If
						Loop 
					End If
					' Open a new sheet for editing
					NewForm = New frmTriggerProp
					Select Case ParseTag(TreeViewX.Nodes(Tag_Renamed).Parent.Tag)
						Case bdEditEncounter
							'UPGRADE_ISSUE: Control ShowTrigger could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
							NewForm.ShowTrigger(TreeViewX, ObjectX, bdTrigEncounter)
						Case bdEditItem
							'UPGRADE_ISSUE: Control ShowTrigger could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
							NewForm.ShowTrigger(TreeViewX, ObjectX, bdTrigItem)
						Case bdEditCreature
							'UPGRADE_ISSUE: Control ShowTrigger could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
							NewForm.ShowTrigger(TreeViewX, ObjectX, bdTrigCreature)
						Case bdEditTomeTriggers
							'UPGRADE_ISSUE: Control ShowTrigger could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
							NewForm.ShowTrigger(TreeViewX, ObjectX, bdTrigTome)
						Case bdEditTopic
							'UPGRADE_ISSUE: Control ShowTrigger could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
							NewForm.ShowTrigger(TreeViewX, ObjectX, bdTrigTopic)
						Case bdEditTrigger
							'UPGRADE_ISSUE: Control ShowTrigger could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
							NewForm.ShowTrigger(TreeViewX, ObjectX, bdTrigTrig)
						Case bdEditTile
							'UPGRADE_ISSUE: Control ShowTrigger could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
							NewForm.ShowTrigger(TreeViewX, ObjectX, bdTrigTile)
						Case bdEditEncounter
							'UPGRADE_ISSUE: Control ShowTrigger could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
							NewForm.ShowTrigger(TreeViewX, ObjectX, bdTrigEncounter)
						Case bdEditTheme
							'UPGRADE_ISSUE: Control ShowTrigger could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
							NewForm.ShowTrigger(TreeViewX, ObjectX, bdTrigTheme)
					End Select
					NewForm.Left = 0
				Case bdEditConvo
					NewForm = New frmConvoProp
					ParentX = ObjectListX.Item(TreeViewX.Nodes(Tag_Renamed).Parent.Tag)
					'UPGRADE_ISSUE: Control ShowConvo could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					NewForm.ShowConvo(TreeViewX, ParentX, ObjectX)
				Case bdEditTopic
					NewForm = New frmTopic
					ParentX = ObjectListX.Item(TreeViewX.Nodes(Tag_Renamed).Parent.Tag)
					GrandParentX = ObjectListX.Item(TreeViewX.Nodes(Tag_Renamed).Parent.Parent.Tag)
					'UPGRADE_ISSUE: Control ShowTopic could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					NewForm.ShowTopic(TreeViewX, GrandParentX, ParentX, ObjectX)
				Case bdEditTheme
					NewForm = New frmThemeProp
					ParentX = ObjectListX.Item(TreeViewX.Nodes(Tag_Renamed).Parent.Tag)
					'UPGRADE_ISSUE: Control ShowTheme could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					NewForm.ShowTheme(TreeViewX, ParentX, ObjectX)
				Case bdEditTome
					NewForm = New frmTome
					'UPGRADE_ISSUE: Control ShowTome could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					NewForm.ShowTome(TreeViewX, ObjectX)
				Case bdEditArea
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					OpenArea(ObjectX)
					Exit Sub
				Case bdEditFactoid
					NewForm = New frmFactoid
					'UPGRADE_ISSUE: Control ShowFactoid could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					NewForm.ShowFactoid(TreeViewX, ObjectX)
				Case bdEditJournal
					NewForm = New frmJournal
					'UPGRADE_ISSUE: Control ShowJournal could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					NewForm.ShowJournal(TreeViewX, ObjectX)
				Case Else
					Exit Sub
			End Select
			' [Titi 2.6.3] added a flag to know if we're working on a new object (in which case cancel means delete)
			'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
			If Not IsNothing(AtX) And IsNothing(AtY) Then Tag_Renamed = Tag_Renamed & "NEW"
			NewForm.Tag = Tag_Renamed
			'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
			If Not IsNothing(AtX) And Not IsNothing(AtY) Then
				'UPGRADE_WARNING: Couldn't resolve default property of object AtX. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				NewForm.Left = VB6.TwipsToPixelsX(AtX)
				'UPGRADE_WARNING: Couldn't resolve default property of object AtY. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				NewForm.Top = VB6.TwipsToPixelsY(AtY)
			End If
			NewForm.Show()
			'UPGRADE_NOTE: Object NewForm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			NewForm = Nothing
		End If
ErrorHandler: 
		Exit Sub
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	'UPGRADE_NOTE: Tag was upgraded to Tag_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub SetupMenu(ByRef ToList As Collection, ByRef ToTree As AxComctlLib.AxTreeView, ByRef Tag_Renamed As String)
		Dim Tome_Renamed As Object
		Dim c As Short
		ObjectListX = ToList
		TreeViewX = ToTree.GetOcx
		mnuEditLine1.Visible = True
		mnuEditLine2.Visible = False
		mnuEditLine3.Visible = False
		mnuEditLine5.Visible = False
		For c = 0 To 4
			mnuEditNewObj(c).Visible = False
			mnuEditLoadObj(c).Visible = False
		Next c
		mnuEditLine4.Visible = False
		mnuEditSave.Visible = False
		mnuEditGoto.Enabled = False
		mnuEditMove.Enabled = False
		Select Case ParseTag(Tag_Renamed)
			Case bdEditTome
				mnuEditProperties.Text = "Tome Properties..."
				mnuEditProperties.Visible = True
				mnuEditLine1.Visible = False
				mnuEditCut.Visible = False
				mnuEditCopy.Visible = False
				mnuEditPaste.Visible = False
				mnuEditRemove.Visible = False
			Case bdEditTomeParty
				mnuEditPaste.Visible = True
				mnuEditProperties.Visible = False
				mnuEditLine1.Visible = False
				mnuEditCut.Visible = False
				mnuEditCopy.Visible = False
				Select Case BufferType
					Case bdEditCreature
						mnuEditPaste.Text = "Paste Creature"
						mnuEditPaste.Enabled = True
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditLine2.Visible = True
				mnuEditRemove.Visible = False
				mnuEditNewObj(0).Text = "New Creature"
				mnuEditNewObj(0).Visible = True
				mnuEditLine3.Visible = True
				mnuEditLoadObj(0).Text = "Insert Creature from Library..."
				mnuEditLoadObj(0).Visible = True
			Case bdEditTomeFactoids
				mnuEditPaste.Visible = True
				mnuEditProperties.Visible = False
				mnuEditLine1.Visible = False
				mnuEditCut.Visible = False
				mnuEditCopy.Visible = False
				Select Case BufferType
					Case bdEditFactoid
						mnuEditPaste.Text = "Paste Factoid"
						mnuEditPaste.Enabled = True
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditLine2.Visible = True
				mnuEditRemove.Visible = False
				mnuEditNewObj(0).Text = "New Factoid"
				mnuEditNewObj(0).Visible = True
			Case bdEditTomeJournals
				mnuEditPaste.Visible = True
				mnuEditProperties.Visible = False
				mnuEditLine1.Visible = False
				mnuEditCut.Visible = False
				mnuEditCopy.Visible = False
				Select Case BufferType
					Case bdEditJournal
						mnuEditPaste.Text = "Paste Journal Entry"
						mnuEditPaste.Enabled = True
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditLine2.Visible = True
				mnuEditRemove.Visible = False
				mnuEditNewObj(0).Text = "New Journal Entry"
				mnuEditNewObj(0).Visible = True
			Case bdEditTomeTriggers
				mnuEditPaste.Visible = True
				mnuEditProperties.Visible = False
				mnuEditLine1.Visible = False
				mnuEditCut.Visible = False
				mnuEditCopy.Visible = False
				Select Case BufferType
					Case bdEditTrigger
						mnuEditPaste.Text = "Paste Trigger"
						mnuEditPaste.Enabled = True
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditLine2.Visible = True
				mnuEditRemove.Visible = False
				mnuEditNewObj(0).Text = "New Trigger"
				mnuEditNewObj(0).Visible = True
				mnuEditLine3.Visible = True
				mnuEditLoadObj(0).Text = "Insert Trigger from Library..."
				mnuEditLoadObj(0).Visible = True
			Case bdEditTomeAreas
				mnuEditPaste.Visible = True
				mnuEditProperties.Visible = False
				mnuEditLine1.Visible = False
				mnuEditCut.Visible = False
				mnuEditCopy.Visible = False
				Select Case BufferType
					Case bdEditArea
						mnuEditPaste.Text = "Paste Area"
						mnuEditPaste.Enabled = True
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditLine2.Visible = True
				mnuEditRemove.Visible = False
				mnuEditNewObj(0).Text = "New Area"
				mnuEditNewObj(0).Visible = True
				mnuEditLine3.Visible = True
				mnuEditLoadObj(0).Text = "Insert Area from Library..."
				mnuEditLoadObj(0).Visible = True
				mnuEditLine4.Visible = False
				mnuEditSave.Visible = False
			Case bdEditArea
				mnuEditProperties.Text = "Edit Area"
				mnuEditProperties.Visible = True
				mnuEditLine1.Visible = True
				mnuEditCut.Visible = True
				mnuEditCopy.Visible = True
				mnuEditPaste.Visible = False
				Select Case BufferType
					Case bdEditArea
						mnuEditPaste.Text = "Paste Area"
						mnuEditPaste.Enabled = True
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditLine2.Visible = False
				mnuEditRemove.Visible = True
				mnuEditLine5.Visible = False
				mnuEditNewObj(0).Visible = False
				mnuEditLine3.Visible = False
				mnuEditLoadObj(0).Visible = False
				mnuEditLine4.Visible = True
				mnuEditSave.Text = "Save Area to Library..."
				mnuEditSave.Visible = True
			Case bdEditMap
				mnuEditProperties.Text = "Map Properties..."
				mnuEditProperties.Visible = True
				mnuEditLine1.Visible = True
				mnuEditCut.Visible = True
				mnuEditCopy.Visible = True
				mnuEditPaste.Visible = True
				mnuEditMove.Visible = True
				mnuEditMove.Enabled = True
				'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Areas. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For c = 1 To -Greatest(-9, -Tome.Areas.Count)
					mnuEditMovetoArea(c).Enabled = True
					mnuEditMovetoArea(c).Visible = True
					'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Areas. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					mnuEditMovetoArea(c).Text = Tome.Areas.Item(c).Name
				Next 
				Select Case BufferType
					Case bdEditMap
						mnuEditPaste.Text = "Paste Map"
						mnuEditPaste.Enabled = True
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditLine2.Visible = True
				mnuEditRemove.Visible = True
				mnuEditLine5.Visible = True
				mnuEditNewObj(0).Text = "New Map"
				mnuEditNewObj(0).Visible = True
				mnuEditLine3.Visible = True
				mnuEditLoadObj(0).Text = "Insert Map from Library..."
				mnuEditLoadObj(0).Visible = True
				mnuEditLine4.Visible = True
				mnuEditSave.Text = "Save Map to Library..."
				mnuEditSave.Visible = True
			Case bdEditMapTileSets
				mnuEditPaste.Visible = True
				mnuEditProperties.Visible = False
				mnuEditLine1.Visible = False
				mnuEditCut.Visible = False
				mnuEditCopy.Visible = False
				Select Case BufferType
					Case bdEditTileSet
						mnuEditPaste.Text = "Paste TileSet"
						mnuEditPaste.Enabled = True
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditLine2.Visible = True
				mnuEditNewObj(0).Text = "New TileSet"
				mnuEditNewObj(0).Visible = True
			Case bdEditMapTiles
				mnuEditPaste.Visible = True
				mnuEditProperties.Visible = False
				mnuEditLine1.Visible = False
				mnuEditCut.Visible = False
				mnuEditCopy.Visible = False
				Select Case BufferType
					Case bdEditTile
						mnuEditPaste.Text = "Paste Tile"
						mnuEditPaste.Enabled = True
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditLine2.Visible = True
				mnuEditRemove.Visible = False
				mnuEditNewObj(0).Text = "New Tile"
				mnuEditNewObj(0).Visible = True
			Case bdEditMapEntryPoints
				mnuEditPaste.Visible = True
				mnuEditProperties.Visible = False
				mnuEditLine1.Visible = False
				mnuEditCut.Visible = False
				mnuEditCopy.Visible = False
				Select Case BufferType
					Case bdEditEntryPoint
						mnuEditPaste.Text = "Paste EntryPoint"
						mnuEditPaste.Enabled = True
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditLine2.Visible = True
				mnuEditRemove.Visible = False
				mnuEditNewObj(0).Text = "New EntryPoint"
				mnuEditNewObj(0).Visible = True
			Case bdEditTileSet
				mnuEditProperties.Text = "TileSet Properties..."
				mnuEditProperties.Visible = True
				mnuEditLine1.Visible = True
				mnuEditCut.Visible = True
				mnuEditCopy.Visible = True
				mnuEditPaste.Visible = False
				mnuEditRemove.Visible = True
				mnuEditLine5.Visible = True
			Case bdEditTile
				mnuEditProperties.Text = "Tile Properties..."
				mnuEditProperties.Visible = True
				mnuEditLine1.Visible = True
				mnuEditCut.Visible = True
				mnuEditCopy.Visible = True
				mnuEditPaste.Visible = True
				Select Case BufferType
					Case bdEditTrigger
						mnuEditPaste.Text = "Paste Trigger"
						mnuEditPaste.Enabled = True
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditRemove.Visible = True
				mnuEditLine5.Visible = True
			Case bdEditEntryPoint
				mnuEditProperties.Text = "EntryPoint Properties..."
				mnuEditProperties.Visible = True
				mnuEditLine1.Visible = True
				mnuEditCut.Visible = True
				mnuEditCopy.Visible = True
				mnuEditPaste.Visible = True
				mnuEditGoto.Enabled = True
				Select Case BufferType
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditRemove.Visible = True
				mnuEditLine5.Visible = True
			Case bdEditMapThemes
				mnuEditPaste.Visible = True
				mnuEditProperties.Visible = False
				mnuEditLine1.Visible = False
				mnuEditCut.Visible = False
				mnuEditCopy.Visible = False
				Select Case BufferType
					Case bdEditTheme
						mnuEditPaste.Text = "Paste Theme"
						mnuEditPaste.Enabled = True
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditLine2.Visible = True
				mnuEditRemove.Visible = False
				mnuEditNewObj(0).Text = "New Theme"
				mnuEditNewObj(0).Visible = True
				mnuEditLine3.Visible = True
				mnuEditLoadObj(0).Text = "Insert Theme from Library..."
				mnuEditLoadObj(0).Visible = True
			Case bdEditMapCreatures
				mnuEditPaste.Visible = True
				mnuEditProperties.Visible = False
				mnuEditLine1.Visible = False
				mnuEditCut.Visible = False
				mnuEditCopy.Visible = False
				Select Case BufferType
					Case bdEditCreature
						mnuEditPaste.Text = "Paste Creature"
						mnuEditPaste.Enabled = True
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditLine2.Visible = True
				mnuEditRemove.Visible = False
				mnuEditNewObj(0).Text = "New Creature"
				mnuEditNewObj(0).Visible = True
				mnuEditLine3.Visible = True
				mnuEditLoadObj(0).Text = "Insert Creature from Library..."
				mnuEditLoadObj(0).Visible = True
			Case bdEditMapEncounters
				mnuEditPaste.Visible = True
				mnuEditProperties.Visible = False
				mnuEditLine1.Visible = False
				mnuEditCut.Visible = False
				mnuEditCopy.Visible = False
				Select Case BufferType
					Case bdEditEncounter
						mnuEditPaste.Text = "Paste Encounter"
						mnuEditPaste.Enabled = True
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditLine2.Visible = True
				mnuEditRemove.Visible = False
				mnuEditNewObj(0).Text = "New Encounter"
				mnuEditNewObj(0).Visible = True
				mnuEditLine3.Visible = True
				mnuEditLoadObj(0).Text = "Insert Encounter from Library..."
				mnuEditLoadObj(0).Visible = True
			Case bdEditMapGraphic
				mnuEditProperties.Text = "Edit Graphic"
				mnuEditProperties.Visible = True
				mnuEditLine1.Visible = False
				mnuEditCut.Visible = False
				mnuEditPaste.Visible = False
				mnuEditCopy.Visible = False
				mnuEditRemove.Visible = False
			Case bdEditEncounter
				mnuEditProperties.Text = "Encounter Properties..."
				mnuEditProperties.Visible = True
				mnuEditLine1.Visible = True
				mnuEditCut.Visible = True
				mnuEditCopy.Visible = True
				mnuEditPaste.Visible = True
				Select Case BufferType
					Case bdEditTrigger
						mnuEditPaste.Text = "Paste Trigger"
						mnuEditPaste.Enabled = True
					Case bdEditCreature
						mnuEditPaste.Text = "Paste Creature"
						mnuEditPaste.Enabled = True
					Case bdEditItem
						mnuEditPaste.Text = "Paste Item"
						mnuEditPaste.Enabled = True
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditLine2.Visible = True
				mnuEditRemove.Visible = True
				mnuEditLine5.Visible = True
				mnuEditNewObj(0).Text = "New Creature"
				mnuEditNewObj(0).Visible = True
				mnuEditNewObj(1).Text = "New Item"
				mnuEditNewObj(1).Visible = True
				mnuEditNewObj(2).Text = "New Trigger"
				mnuEditNewObj(2).Visible = True
				mnuEditLine3.Visible = True
				mnuEditLoadObj(0).Text = "Insert Creature from Library..."
				mnuEditLoadObj(0).Visible = True
				mnuEditLoadObj(1).Text = "Insert Item from Library..."
				mnuEditLoadObj(1).Visible = True
				mnuEditLoadObj(2).Text = "Insert Trigger from Library..."
				mnuEditLoadObj(2).Visible = True
				mnuEditLine4.Visible = True
				mnuEditSave.Text = "Save Encounter to Library..."
				mnuEditSave.Visible = True
			Case bdEditCreature
				mnuEditProperties.Text = "Creature Properties..."
				mnuEditProperties.Visible = True
				mnuEditLine1.Visible = True
				mnuEditCut.Visible = True
				mnuEditCopy.Visible = True
				mnuEditPaste.Visible = True
				Select Case BufferType
					Case bdEditTrigger
						mnuEditPaste.Text = "Paste Trigger"
						mnuEditPaste.Enabled = True
					Case bdEditItem
						mnuEditPaste.Text = "Paste Item"
						mnuEditPaste.Enabled = True
					Case bdEditConvo
						mnuEditPaste.Text = "Paste Conversation"
						mnuEditPaste.Enabled = True
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditLine2.Visible = True
				mnuEditRemove.Visible = True
				mnuEditLine5.Visible = True
				mnuEditNewObj(0).Text = "New Item"
				mnuEditNewObj(0).Visible = True
				mnuEditNewObj(1).Text = "New Trigger"
				mnuEditNewObj(1).Visible = True
				mnuEditNewObj(2).Text = "New Conversation"
				mnuEditNewObj(2).Visible = True
				mnuEditLine3.Visible = True
				mnuEditLoadObj(0).Text = "Insert Item from Library..."
				mnuEditLoadObj(0).Visible = True
				mnuEditLoadObj(1).Text = "Insert Trigger from Library..."
				mnuEditLoadObj(1).Visible = True
				mnuEditLoadObj(2).Text = "Insert Conversation from Library..."
				mnuEditLoadObj(2).Visible = True
				mnuEditLine4.Visible = True
				mnuEditSave.Text = "Save Creature to Library..."
				mnuEditSave.Visible = True
			Case bdEditItem
				mnuEditProperties.Text = "Item Properties..."
				mnuEditProperties.Visible = True
				mnuEditLine1.Visible = True
				mnuEditCut.Visible = True
				mnuEditCopy.Visible = True
				mnuEditPaste.Visible = True
				Select Case BufferType
					Case bdEditTrigger
						mnuEditPaste.Text = "Paste Trigger"
						mnuEditPaste.Enabled = True
					Case bdEditItem
						mnuEditPaste.Text = "Paste Item"
						mnuEditPaste.Enabled = True
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditLine2.Visible = True
				mnuEditRemove.Visible = True
				mnuEditLine5.Visible = True
				mnuEditNewObj(0).Text = "New Item"
				mnuEditNewObj(0).Visible = True
				mnuEditNewObj(1).Text = "New Trigger"
				mnuEditNewObj(1).Visible = True
				mnuEditLine3.Visible = True
				mnuEditLoadObj(0).Text = "Insert Item from Library..."
				mnuEditLoadObj(0).Visible = True
				mnuEditLoadObj(1).Text = "Insert Trigger from Library..."
				mnuEditLoadObj(1).Visible = True
				mnuEditLine4.Visible = True
				mnuEditSave.Text = "Save Item to Library..."
				mnuEditSave.Visible = True
			Case bdEditTrigger
				mnuEditProperties.Text = "Trigger Properties..."
				mnuEditProperties.Visible = True
				mnuEditLine1.Visible = True
				mnuEditCut.Visible = True
				mnuEditCopy.Visible = True
				mnuEditPaste.Visible = True
				Select Case BufferType
					Case bdEditItem
						mnuEditPaste.Text = "Paste Item"
						mnuEditPaste.Enabled = True
					Case bdEditCreature
						mnuEditPaste.Text = "Paste Creature"
						mnuEditPaste.Enabled = True
					Case bdEditTrigger
						mnuEditPaste.Text = "Paste Trigger"
						mnuEditPaste.Enabled = True
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditLine2.Visible = True
				mnuEditRemove.Visible = True
				mnuEditLine5.Visible = True
				mnuEditNewObj(0).Text = "New Item"
				mnuEditNewObj(0).Visible = True
				mnuEditNewObj(1).Text = "New Creature"
				mnuEditNewObj(1).Visible = True
				mnuEditNewObj(2).Text = "New Trigger"
				mnuEditNewObj(2).Visible = True
				mnuEditLine3.Visible = True
				mnuEditLoadObj(0).Text = "Insert Item from Library..."
				mnuEditLoadObj(0).Visible = True
				mnuEditLoadObj(1).Text = "Insert Creature from Library..."
				mnuEditLoadObj(1).Visible = True
				mnuEditLoadObj(2).Text = "Insert Trigger from Library..."
				mnuEditLoadObj(2).Visible = True
				mnuEditLine4.Visible = True
				mnuEditSave.Text = "Save Trigger to Library..."
				mnuEditSave.Visible = True
			Case bdEditTheme
				mnuEditProperties.Text = "Theme Properties..."
				mnuEditProperties.Visible = True
				mnuEditLine1.Visible = True
				mnuEditCut.Visible = True
				mnuEditCopy.Visible = True
				mnuEditPaste.Visible = True
				Select Case BufferType
					Case bdEditFactoid
						mnuEditPaste.Text = "Paste Description"
						mnuEditPaste.Enabled = True
					Case bdEditTrigger
						mnuEditPaste.Text = "Paste Trigger"
						mnuEditPaste.Enabled = True
					Case bdEditCreature
						mnuEditPaste.Text = "Paste Creature"
						mnuEditPaste.Enabled = True
					Case bdEditItem
						mnuEditPaste.Text = "Paste Item"
						mnuEditPaste.Enabled = True
					Case bdEditEncounter
						mnuEditPaste.Text = "Paste Encounter"
						mnuEditPaste.Enabled = True
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditLine2.Visible = True
				mnuEditRemove.Visible = True
				mnuEditLine5.Visible = True
				mnuEditNewObj(0).Text = "New Creature"
				mnuEditNewObj(0).Visible = True
				mnuEditNewObj(1).Text = "New Item"
				mnuEditNewObj(1).Visible = True
				mnuEditNewObj(2).Text = "New Trigger"
				mnuEditNewObj(2).Visible = True
				mnuEditNewObj(3).Text = "New Encounter"
				mnuEditNewObj(3).Visible = True
				mnuEditNewObj(4).Text = "New Description"
				mnuEditNewObj(4).Visible = True
				mnuEditLine3.Visible = True
				mnuEditLoadObj(0).Text = "Insert Creature from Library..."
				mnuEditLoadObj(0).Visible = True
				mnuEditLoadObj(1).Text = "Insert Item from Library..."
				mnuEditLoadObj(1).Visible = True
				mnuEditLoadObj(2).Text = "Insert Trigger from Library..."
				mnuEditLoadObj(2).Visible = True
				mnuEditLoadObj(3).Text = "Insert Encounter from Library..."
				mnuEditLoadObj(3).Visible = True
				mnuEditLine4.Visible = True
				mnuEditSave.Text = "Save Theme to Library..."
				mnuEditSave.Visible = True
			Case bdEditConvo
				mnuEditProperties.Text = "Conversation Properties..."
				mnuEditProperties.Visible = True
				mnuEditLine1.Visible = True
				mnuEditCut.Visible = True
				mnuEditCopy.Visible = True
				mnuEditPaste.Visible = True
				Select Case BufferType
					Case bdEditTopic
						mnuEditPaste.Text = "Paste Topic"
						mnuEditPaste.Enabled = True
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditLine2.Visible = True
				mnuEditRemove.Visible = True
				mnuEditLine5.Visible = True
				mnuEditNewObj(0).Text = "New Topic"
				mnuEditNewObj(0).Visible = True
				mnuEditLine4.Visible = True
				mnuEditSave.Text = "Save Conversation to Library..."
				mnuEditSave.Visible = True
			Case bdEditTopic
				mnuEditProperties.Text = "Topic Properties..."
				mnuEditProperties.Visible = True
				mnuEditLine1.Visible = True
				mnuEditCut.Visible = True
				mnuEditCopy.Visible = True
				mnuEditPaste.Visible = True
				Select Case BufferType
					Case bdEditTrigger
						mnuEditPaste.Text = "Paste Trigger"
						mnuEditPaste.Enabled = True
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditLine2.Visible = True
				mnuEditRemove.Visible = True
				mnuEditLine5.Visible = True
				mnuEditNewObj(0).Text = "New Trigger"
				mnuEditNewObj(0).Visible = True
				mnuEditLine3.Visible = True
				mnuEditLoadObj(0).Text = "Insert Trigger from Library..."
				mnuEditLoadObj(0).Visible = True
				mnuEditSave.Visible = False
			Case bdEditFactoid
				mnuEditProperties.Text = "Factoid Properties..."
				mnuEditProperties.Visible = True
				mnuEditLine1.Visible = True
				mnuEditCut.Visible = True
				mnuEditCopy.Visible = True
				mnuEditPaste.Visible = True
				Select Case BufferType
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditLine2.Visible = False
				mnuEditRemove.Visible = True
				mnuEditLine5.Visible = True
				mnuEditLine3.Visible = False
				mnuEditSave.Visible = False
			Case bdEditJournal
				mnuEditProperties.Text = "Journal Entry Properties..."
				mnuEditProperties.Visible = True
				mnuEditLine1.Visible = True
				mnuEditCut.Visible = True
				mnuEditCopy.Visible = True
				mnuEditPaste.Visible = True
				Select Case BufferType
					Case Else
						mnuEditPaste.Text = "Paste"
						mnuEditPaste.Enabled = False
				End Select
				mnuEditLine2.Visible = False
				mnuEditRemove.Visible = True
				mnuEditLine5.Visible = True
				mnuEditLine3.Visible = False
				mnuEditSave.Visible = False
		End Select
		' Setup Button Toolbar
		tlbMenu.Buttons("Cut").Enabled = (mnuEditCut.Enabled And mnuEditCut.Visible)
		tlbMenu.Buttons("Copy").Enabled = (mnuEditCopy.Enabled And mnuEditCopy.Visible)
		tlbMenu.Buttons("Paste").Enabled = (mnuEditPaste.Enabled And mnuEditPaste.Visible)
	End Sub
	
	Private Sub ResizeForm()
		frmProject.Top = 0
		frmProject.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.ClientRectangle.Width) * 0.25)
		frmProject.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.ClientRectangle.Width) - VB6.PixelsToTwipsX(frmProject.Width))
		frmProject.Height = Me.ClientRectangle.Height
		' Resize Project
		frmProject.ResizeForm()
		frmProject.Show()
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub EndGame(ByRef Fail As Short)
		Dim SaveSystemSettings As Object
		Dim Tome_Renamed As Object
		Dim rc As Short
		If Dirty = True Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			rc = MsgBox("Do you want to save the changes you made to " & Tome.Name & "?", MsgBoxStyle.YesNoCancel Or MsgBoxStyle.Exclamation, "RuneSword Creator")
			If rc = MsgBoxResult.Yes Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Tome.FileName = "default.tom" Or Tome.FileName = "" Then
					SaveTomeAs()
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					SaveTome(Tome.LoadPath & "\" & Tome.FileName)
				End If
			ElseIf rc = MsgBoxResult.Cancel Then 
				Fail = True
				Exit Sub
			Else
				Dirty = False
			End If
		End If
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		ShowMsg("Clearing Tome.")
		'UPGRADE_NOTE: Object TreeViewX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		TreeViewX = Nothing
		'UPGRADE_NOTE: Object ObjectListX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		ObjectListX = Nothing
		'UPGRADE_NOTE: Object Tome may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		Tome = Nothing
		'UPGRADE_NOTE: Object Area may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		Area = Nothing
		ShowMsg("Clearing Tome..")
		'UPGRADE_NOTE: Object frmProject.AreaList may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		frmProject.AreaList = Nothing
		ShowMsg("Clearing Tome...")
		'UPGRADE_NOTE: Object frmProject.TomeList may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		frmProject.TomeList = Nothing
		ShowMsg("Clearing Tome....")
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		Fail = False
		SaveSystemSettings()
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub OpenArea(ByRef AreaX As Area)
		Dim Tome_Renamed As Object
		Dim c As Short
		Dim MapX As Map
		Dim FileName As String
		On Error Resume Next
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		' Load Area
		If AreaX.IsLoaded = False And AreaX.FileName <> "Not Saved" Then
			c = FreeFile
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FileName = Tome.LoadPath & "\" & AreaX.FileName
			FileOpen(c, FileName, OpenMode.Binary)
			AreaX.Plot = New Plot
			AreaX.Plot.ReadFromFile(c)
			FileClose(c)
		End If
		AreaX.IsLoaded = True
		Area = AreaX
		' Show Area
		frmProject.lblProjectArea.Text = "Area: " & AreaX.Name
		' Clear old Project (Area) file
		frmProject.tvwProject.Nodes.Clear()
		'UPGRADE_NOTE: Object frmProject.AreaList may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		frmProject.AreaList = Nothing
		ObjectListX = frmProject.AreaList
		TreeViewX = frmProject.tvwProject.GetOcx
		' Show Maps
		For	Each MapX In AreaX.Plot.Maps
			ShowMap(ObjectListX, TreeViewX, MapX)
		Next MapX
		TreeViewX.SelectedItem = TreeViewX.Nodes(1)
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub OpenTome(Optional ByRef strRecent As String = "", Optional ByRef Index As Short = 0)
		Dim fReadValue As Object
		Dim oErr As Object
		Dim LoadSystemSettings As Object
		Dim SaveSystemSettings As Object
		Dim aMostRecent As Object
		Dim ClipPath As Object
		Dim frmWorldSettings As Object
		Dim Tome_Renamed As Object
		'UPGRADE_NOTE: Text was upgraded to Text_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim c, rc As Short
		Dim lResult As Integer
		Dim Text_Renamed, FileName As String
		On Error Resume Next
		strRequiredDataFilesTxtFile = "" ' [Titi 2.6.0]
		' [Titi 2.4.9] autoload a recent tome
		If strRecent <> vbNullString Then
			Tome = New Tome
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.FileName = VB.Right(strRecent, Len(strRecent) - InStrRev(strRecent, "\"))
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.LoadPath = VB.Left(strRecent, Len(strRecent) - Len(Tome.FileName) - 1)
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FullPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.FullPath = Tome.LoadPath
		Else
			' check if working on a world
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Visible. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If frmWorldSettings.Visible Then
				'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.btnQuit_Click. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				frmWorldSettings.btnQuit_Click()
				'UPGRADE_ISSUE: Unload frmWorldSettings was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="875EBAD7-D704-4539-9969-BC7DBDAA62A2"'
				Unload(frmWorldSettings)
			End If
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Dirty. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmWorldSettings.Dirty = False ' [Titi 2.6.0] reset the flag to avoid asking the same question twice
			If Dirty = True Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				rc = MsgBox("Do you want to save the changes you made to " & Tome.Name & "?", MsgBoxStyle.YesNoCancel Or MsgBoxStyle.Exclamation, "RuneSword Creator")
				If rc = MsgBoxResult.Yes Then
					'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If Tome.FileName = "default.tom" Then
						SaveTomeAs()
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						SaveTome(Tome.LoadPath & "\" & Tome.FileName)
					End If
				ElseIf rc = MsgBoxResult.Cancel Then 
					Exit Sub
				Else
					Dirty = False
				End If
			End If
			' Close all open Forms (that are not critical to the application)
			Do Until c > My.Application.OpenForms.Count - 1
				Select Case My.Application.OpenForms.Item(c).Name
					Case "frmMDI", "frmUberWizard", "frmProject", "frmAbout"
					Case Else
						'UPGRADE_ISSUE: Unload Forms() was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="875EBAD7-D704-4539-9969-BC7DBDAA62A2"'
						Unload(My.Application.OpenForms(c))
						c = c - 1
				End Select
				c = c + 1
			Loop 
			dlgFileOpen.FileName = gAppPath & "\Tomes\*.tom"
			dlgFileSave.FileName = gAppPath & "\Tomes\*.tom"
			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
			dlgFile.CancelError = True
			dlgFileOpen.Title = "Open Tome"
			dlgFileSave.Title = "Open Tome"
			'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			dlgFileOpen.Filter = "Tome (*.tom)|*.tom|All Files (*.*)|*.*"
			dlgFileSave.Filter = "Tome (*.tom)|*.tom|All Files (*.*)|*.*"
			dlgFileOpen.FilterIndex = 1
			dlgFileSave.FilterIndex = 1
			'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFile.Flags was upgraded to dlgFileOpen.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			dlgFileOpen.CheckFileExists = True
			dlgFileOpen.CheckPathExists = True
			dlgFileSave.CheckPathExists = True
			'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFile.Flags was upgraded to dlgFileOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			dlgFileOpen.ShowReadOnly = False
			dlgFileOpen.RestoreDirectory = False
			dlgFileSave.RestoreDirectory = False
			dlgFileOpen.ShowDialog()
			dlgFileSave.FileName = dlgFileOpen.FileName
			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
			If Err.Number = DialogResult.Cancel Then
				Exit Sub
			End If
			' Set cursor to hourglass
			'UPGRADE_WARNING: CommonDialog property dlgFile.FileTitle was upgraded to dlgFile.FileName which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			ShowMsg("Loading Tome " & dlgFileOpen.FileName & "....")
			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
			' Depending on file chosen, get other files
			Tome = New Tome
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: CommonDialog property dlgFile.FileTitle was upgraded to dlgFile.FileName which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			Tome.FileName = dlgFileOpen.FileName
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ClipPath(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.LoadPath = ClipPath(dlgFileOpen.FileName)
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FullPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.FullPath = Tome.LoadPath
		End If
		c = FreeFile
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileOpen(c, Tome.LoadPath & "\" & Tome.FileName, OpenMode.Binary)
		' [Titi 2.4.9b] remove from the recent files list if not found!
		If Err.Number = 76 Then ' tome probably renamed, moved or deleted
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			MsgBox("Error! Cannot find " & Tome.FileName,  , "File not found.")
			'UPGRADE_WARNING: Couldn't resolve default property of object aMostRecent(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			aMostRecent(5) = vbNullString
			For c = Index To 4
				'UPGRADE_WARNING: Couldn't resolve default property of object aMostRecent(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				aMostRecent(c) = aMostRecent(c + 1)
			Next 
			Call SaveSystemSettings()
			Call LoadSystemSettings()
		ElseIf Err.Number <> 0 Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object oErr.logError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			oErr.logError("mnuRecent_Click: " & Err.Description & " (" & Err.Number & ")")
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.ReadFromFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Tome.ReadFromFile(c)
		FileClose(c)
		' [Titi 2.4.9a] prevent the use of invalid files
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Tome.Name = vbNullString Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			MsgBox(Tome.FileName & " is not a valid tome file.", MsgBoxStyle.Critical, "Error")
			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
			Exit Sub
		End If
		' [Titi 2.4.9] Careful... sometimes the tome doesn't have its own folder!
		Dim aParse() As String
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aParse = Split(Tome.LoadPath, "\")
		If aParse(UBound(aParse) - 1) = "Tomes" Or aParse(UBound(aParse) - 1) = "World" Then
			' [Titi 2.4.9b] added the case of changes in a saved game
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WorldNow.Name = aParse(UBound(aParse))
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WorldNow.Name = VB.Left(Tome.LoadPath, InStrRev(Tome.LoadPath, "\") - 1)
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WorldNow.Name = VB.Right(WorldNow.Name, Len(WorldNow.Name) - InStrRev(WorldNow.Name, "\"))
		End If
		' [Titi] Now get relevant runes (added for 2.4.8)
		'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		InitializeRunes(WorldNow.Name)
		' [Titi 2.4.9b] added to allow a world specific magic system (not necessarily based on runes)
		'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileName = gAppPath & "\roster\" & WorldNow.Name & "\" & WorldNow.Name & ".ini"
		'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lResult = fReadValue(FileName, "World", "Magic", "S", "Eternium", Text_Renamed)
		'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Magic. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WorldNow.Magic = Text_Renamed
		'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lResult = fReadValue(FileName, "World", "Runes", "S", "0", Text_Renamed)
		'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Runes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WorldNow.Runes = Val(Text_Renamed)
		'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lResult = fReadValue(FileName, "World", "Formula", "S", "", Text_Renamed)
		'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Formula. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WorldNow.Formula = Text_Renamed
		' Show Tome
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ShowTome(Tome)
		ShowMsg("")
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub SaveArea(ByRef AreaX As Area, Optional ByRef strFileName As String = "")
		Dim oErr As Object
		Dim Tome_Renamed As Object
		Dim c As Short
		Dim FileName As String
		On Error GoTo ErrorHandler
		c = FreeFile
		' [Titi 2.4.9b] the SaveToFile method of the Area class only saved the properties of the area, not its maps.
		If strFileName = vbNullString Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			AreaX.FileName = VB.Left(Tome.FileName, InStr(Tome.FileName, ".") - 1) & AreaX.Index & ".rsa"
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FileName = Tome.LoadPath & "\" & AreaX.FileName
		Else
			FileName = strFileName
		End If
		Kill(FileName)
		FileOpen(c, FileName, OpenMode.Binary)
		AreaX.Plot.SaveToFile(c)
		FileClose(c)
		Exit Sub
ErrorHandler: 
		' [Titi 2.4.9] improved error catching!
		If Err.Number = 53 Then ' file non existing, so cannot be deleted by Kill
			Resume Next
		Else
			' log the error
			'UPGRADE_WARNING: Couldn't resolve default property of object oErr.logError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			oErr.logError("SaveArea: " & Err.Description & " (" & Err.Number & ")")
			MsgBox("Area" & AreaX.Index & " not saved!",  , "Error #" & Err.Number)
			Resume Next
		End If
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub RunTome()
		Dim Tome_Renamed As Object
		On Error GoTo ErrorHandler
		Dim rc As Integer
		' Check if saved old Tome
		If Dirty = True Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			rc = MsgBox("Do you want to save the changes you made to " & Tome.Name & "?", MsgBoxStyle.YesNoCancel Or MsgBoxStyle.Exclamation, "RuneSword Creator")
			If rc = MsgBoxResult.Yes Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Tome.FileName = "default.tom" Then
					SaveTomeAs()
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					SaveTome(Tome.LoadPath & "\" & Tome.FileName)
				End If
			ElseIf rc = MsgBoxResult.Cancel Then 
				Exit Sub
			Else
				Dirty = False
			End If
		End If
		' [borfaux] Added 2.4.6 to work in conjunction with new /DataPath setting
		Shell(gAppPath & "\RuneSword.exe /DataPath " & gAppPath, 1)
		Exit Sub
ErrorHandler: 
		' [Titi 2.5.1] Renamed or moved player?
		If Err.Number = 53 Then
			dlgFileOpen.FileName = gAppPath & "\*.exe"
			dlgFileSave.FileName = gAppPath & "\*.exe"
			dlgFileOpen.Title = "Runesword.exe could not be found, please browse for the file or cancel request."
			dlgFileSave.Title = "Runesword.exe could not be found, please browse for the file or cancel request."
			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
			dlgFile.CancelError = True
			'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			dlgFileOpen.Filter = "Programs (*.exe)|*.exe|All Files (*.*)|*.*"
			dlgFileSave.Filter = "Programs (*.exe)|*.exe|All Files (*.*)|*.*"
			dlgFileOpen.FilterIndex = 1
			dlgFileSave.FilterIndex = 1
			'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFile.Flags was upgraded to dlgFileOpen.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			dlgFileOpen.CheckFileExists = True
			dlgFileOpen.CheckPathExists = True
			dlgFileSave.CheckPathExists = True
			'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFile.Flags was upgraded to dlgFileOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			dlgFileOpen.ShowReadOnly = False
			dlgFileOpen.RestoreDirectory = False
			dlgFileSave.RestoreDirectory = False
			dlgFileOpen.ShowDialog()
			dlgFileSave.FileName = dlgFileOpen.FileName
			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
			If Err.Number = DialogResult.Cancel Then
				Exit Sub
			Else
				Shell(dlgFileOpen.FileName & " /DataPath " & gAppPath, 1)
			End If
		End If
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub SaveTome(ByRef FileName As String)
		Dim oErr As Object
		Dim aMostRecent As Object
		Dim Tome_Renamed As Object
		Dim ClipPath As Object
		Dim c, Found As Short
		Dim AreaX As Area
		Dim MapX As Map
		Dim rc As Integer
		Dim MapCnt, EncCnt As Short
		' Proceed with Save
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		On Error GoTo ErrorHandler
		' Save open Area file
		For	Each AreaX In Tome.Areas
			If AreaX.IsLoaded = True Then
				SaveArea(AreaX)
			End If
		Next AreaX
		' Save the Tome
		Kill(FileName)
		c = FreeFile
		FileOpen(c, FileName, OpenMode.Binary)
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FullPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object ClipPath(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Tome.FullPath = ClipPath(FileName)
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.SaveToFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Tome.SaveToFile(c)
		FileClose(c)
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		Dirty = False
		' [Titi 2.5.1] don't forget to reset the children flags too!
		'    For c = 0 To Forms.Count - 1
		'        Forms(c).Dirty = False
		'    Next
		frmMonsProp.Dirty = False
		' [Titi 2.4.9] add to list of recent files
		' check if already in the list
		Found = False
		For c = 0 To 4
			'UPGRADE_WARNING: Couldn't resolve default property of object aMostRecent(c). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If aMostRecent(c) = FileName Then Found = c
		Next 
		If Found > 0 Then
			For c = Found To 4
				'UPGRADE_WARNING: Couldn't resolve default property of object aMostRecent(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				aMostRecent(c) = aMostRecent(c + 1)
			Next 
		End If
		' check if list full
		'UPGRADE_WARNING: Couldn't resolve default property of object aMostRecent(4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If aMostRecent(4) <> vbNullString Then
			' yes, remove the oldest one
			For c = 0 To 3
				'UPGRADE_WARNING: Couldn't resolve default property of object aMostRecent(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				aMostRecent(c) = aMostRecent(c + 1)
			Next 
			'UPGRADE_WARNING: Couldn't resolve default property of object aMostRecent(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			aMostRecent(4) = FileName
		Else
			'no, add at the end of the list
			c = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object aMostRecent(c). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			While aMostRecent(c) <> vbNullString
				c = c + 1
			End While
			'UPGRADE_WARNING: Couldn't resolve default property of object aMostRecent(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			aMostRecent(c) = FileName
		End If
		Exit Sub
ErrorHandler: 
		' [Titi 2.4.9] improved error catching!
		If Err.Number = 53 Then ' file non existing, so cannot be deleted by Kill
			Resume Next
		Else
			' log the error
			'UPGRADE_WARNING: Couldn't resolve default property of object oErr.logError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			oErr.logError("SaveTome: " & Err.Description & " (" & Err.Number & ")")
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			MsgBox("Tome " & Tome.Name & " not saved!",  , "Error #" & Err.Number)
		End If
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub NewTome()
		Dim Tome_Renamed As Object
		Dim c As Short
		Dim FileName As String
		Dim rc As Integer
		' [Titi 2.5.0] moved to mnuFileNewTome
		' check if working on a world
		'If frmWorldSettings.Visible Then
		'    frmWorldSettings.btnQuit_Click
		'    Unload frmWorldSettings
		'End If
		' Check if saved old Tome
		If Dirty = True Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			rc = MsgBox("Do you want to save the changes you made to " & Tome.Name & "?", MsgBoxStyle.YesNoCancel Or MsgBoxStyle.Exclamation, "RuneSword Creator")
			If rc = MsgBoxResult.Yes Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Tome.FileName = "default.tom" Or Tome.FileName = "" Then
					SaveTomeAs()
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					SaveTome(Tome.LoadPath & "\" & Tome.FileName)
				End If
			ElseIf rc = MsgBoxResult.Cancel Then 
				Exit Sub
			Else
				Dirty = False
			End If
		End If
		' Set up default tome and Area
		Tome = New Tome
		'    FileName = Dir(gAppPath & "\data\stock\default.tom")
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileName = Dir(gDataPath & "\stock\default.tom")
		If FileName = "" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.AreaIndex. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.AreaIndex = 1
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.MapIndex. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.MapIndex = 1
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.EntryIndex. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.EntryIndex = 1
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.AddArea. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.AddArea()
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Areas. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.Areas(1).Plot.AddMap()
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Areas. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.Areas(1).Plot.Maps(1).AddEntryPoint()
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Areas. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.Areas(1).Plot.Maps(1).AddEncounter()
		Else
			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
			c = FreeFile
			'        Open gAppPath & "\data\stock\default.tom" For Binary As c
			FileOpen(c, gDataPath & "\stock\default.tom", OpenMode.Binary)
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.ReadFromFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.ReadFromFile(c)
			'        Tome.FullPath = gAppPath & "\data\stock"
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FullPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.FullPath = gDataPath & "\stock"
			'        Tome.LoadPath = gAppPath & "\data\stock"
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.LoadPath = gDataPath & "\stock"
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.FileName = "default.tom"
			FileClose(c)
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ShowTome(Tome)
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		If Me.Dirty <> 250 Then
			Me.Dirty = False
			frmUberWizard.InitGame()
			frmUberWizard.Left = VB6.TwipsToPixelsX(Greatest((VB6.PixelsToTwipsX(Me.Width) - VB6.PixelsToTwipsX(frmProject.Width) - VB6.PixelsToTwipsX(frmUberWizard.Width)) / 2, 0))
			frmUberWizard.Top = VB6.TwipsToPixelsY(Greatest((VB6.PixelsToTwipsY(Me.Height) - VB6.PixelsToTwipsY(frmUberWizard.Height)) / 3, 0))
			frmUberWizard.ShowDialog()
		End If
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub ShowTome(ByRef TomeX As Tome, Optional ByRef blnTomeOnly As Boolean = False)
		Dim Tome_Renamed As Object
		Dim NodeX As ComctlLib.Node
		Dim AreaX As Area
		Dim JournalX As Journal
		Dim CreatureX As Creature
		Dim FactoidX As Factoid
		Dim TriggerX As Trigger
		' Clear old Tome file
		frmProject.tvwTome.Nodes.Clear()
		'UPGRADE_NOTE: Object frmProject.TomeList may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		frmProject.TomeList = Nothing
		ObjectListX = frmProject.TomeList
		TreeViewX = frmProject.tvwTome.GetOcx
		' List Tome in TreeView
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		frmProject.lblProjectTome.Text = "Tome: " & Tome.Name
		' Show Tome
		NodeX = TreeViewX.Nodes.Add( ,  , "Tome", TomeX.Name)
		NodeX.Image = "Book"
		NodeX.ExpandedImage = "Book"
		NodeX.Tag = "Tome"
		NodeX.Selected = True
		ObjectListX.Add(TomeX, NodeX.Tag)
		' Add Party Folder
		NodeX = TreeViewX.Nodes.Add("Tome", ComctlLib.TreeRelationshipConstants.tvwChild, "TomeParty", "Party")
		NodeX.Image = "ClosedFile"
		NodeX.ExpandedImage = "OpenFile"
		NodeX.Tag = "TomeParty"
		'    NodeX.Sorted = True ' [Titi 2.5.1]
		NodeX.Sorted = mnuOptionSort.Checked ' [Titi 2.6.1]
		ObjectListX.Add(TomeX, NodeX.Tag)
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Creatures. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		For	Each CreatureX In Tome.Creatures
			ShowCreature(ObjectListX, TreeViewX, "TomeParty", CreatureX)
		Next CreatureX
		' Add Journal Folder
		NodeX = TreeViewX.Nodes.Add("Tome", ComctlLib.TreeRelationshipConstants.tvwChild, "TomeJournals", "Journal")
		NodeX.Image = "ClosedFile"
		NodeX.ExpandedImage = "OpenFile"
		NodeX.Tag = "TomeJournals"
		'    NodeX.Sorted = True ' [Titi 2.5.1]
		NodeX.Sorted = mnuOptionSort.Checked ' [Titi 2.6.1]
		ObjectListX.Add(TomeX, NodeX.Tag)
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Journals. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		For	Each JournalX In Tome.Journals
			ShowJournal(ObjectListX, TreeViewX, "TomeJournals", JournalX)
		Next JournalX
		' Add Factoid Folder
		NodeX = TreeViewX.Nodes.Add("Tome", ComctlLib.TreeRelationshipConstants.tvwChild, "TomeFactoids", "Factoids")
		NodeX.Image = "ClosedFile"
		NodeX.ExpandedImage = "OpenFile"
		NodeX.Tag = "TomeFactoids"
		'    NodeX.Sorted = True ' [Titi 2.5.1]
		NodeX.Sorted = mnuOptionSort.Checked ' [Titi 2.6.1]
		ObjectListX.Add(TomeX, NodeX.Tag)
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Factoids. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		For	Each FactoidX In Tome.Factoids
			ShowFactoid(ObjectListX, TreeViewX, "TomeFactoids", FactoidX)
		Next FactoidX
		' Add Trigger Folder
		NodeX = TreeViewX.Nodes.Add("Tome", ComctlLib.TreeRelationshipConstants.tvwChild, "TomeTriggers", "Triggers")
		NodeX.Image = "ClosedFile"
		NodeX.ExpandedImage = "OpenFile"
		NodeX.Tag = "TomeTriggers"
		'    NodeX.Sorted = True ' [Titi 2.5.1]
		NodeX.Sorted = mnuOptionSort.Checked ' [Titi 2.6.1]
		ObjectListX.Add(TomeX, NodeX.Tag)
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Triggers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		For	Each TriggerX In Tome.Triggers
			ShowTrigger(ObjectListX, TreeViewX, "TomeTriggers", TriggerX)
		Next TriggerX
		' Add Area Folder
		NodeX = TreeViewX.Nodes.Add("Tome", ComctlLib.TreeRelationshipConstants.tvwChild, "TomeAreas", "Areas")
		NodeX.Image = "ClosedFile"
		NodeX.ExpandedImage = "OpenFile"
		NodeX.Tag = "TomeAreas"
		'    NodeX.Sorted = True ' [Titi 2.5.1]
		NodeX.Sorted = mnuOptionSort.Checked ' [Titi 2.6.1]
		ObjectListX.Add(TomeX, NodeX.Tag)
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Areas. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		For	Each AreaX In Tome.Areas
			ShowArea(ObjectListX, TreeViewX, "TomeAreas", AreaX)
		Next AreaX
		If blnTomeOnly = False Then ' [Titi 2.5.1] Added to make sure the tome package will have ObjectListX set to the Tome treeview
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Areas. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Tome.Areas.Count > 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Areas. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				OpenArea(Tome.Areas(1))
			End If
		End If
	End Sub
	
	Private Sub ShowMap(ByRef ToList As Collection, ByRef ToTree As AxComctlLib.AxTreeView, ByRef MapX As Map)
		Dim NodeX As ComctlLib.Node
		Dim EncounterX As Encounter
		Dim ThemeX As Theme
		Dim CreatureX As Creature
		Dim TileSetX As TileSet
		Dim TileX As Tile
		Dim EntryPointX As EntryPoint
		' Add Map Folder
		NodeX = ToTree.Nodes.Add( ,  , "M" & MapX.Index, MapX.Name)
		NodeX.Image = "ClosedFile"
		NodeX.ExpandedImage = "OpenFile"
		NodeX.Tag = "M" & MapX.Index
		ToList.Add(MapX, NodeX.Tag)
		' Add Map Graphic
		NodeX = ToTree.Nodes.Add("M" & MapX.Index, ComctlLib.TreeRelationshipConstants.tvwChild, "M" & MapX.Index & "Graphic", "Graphic")
		NodeX.Image = "Globe"
		NodeX.Tag = "M" & MapX.Index & "Graphic"
		'    NodeX.Sorted = True ' [Titi 2.5.1]
		NodeX.Sorted = mnuOptionSort.Checked ' [Titi 2.6.1]
		ToList.Add(MapX, NodeX.Tag)
		' Add Combat Wallpaper Folder
		NodeX = ToTree.Nodes.Add("M" & MapX.Index, ComctlLib.TreeRelationshipConstants.tvwChild, "M" & MapX.Index & "TileSets", "Combat Wallpaper")
		NodeX.Image = "ClosedFile"
		NodeX.ExpandedImage = "OpenFile"
		NodeX.Tag = "M" & MapX.Index & "TileSets"
		ToList.Add(MapX, NodeX.Tag)
		For	Each TileSetX In MapX.TileSets
			ShowTileSet(ToList, ToTree, "M" & MapX.Index & "TileSets", TileSetX)
		Next TileSetX
		' Add Wandering monsters Folder
		NodeX = ToTree.Nodes.Add("M" & MapX.Index, ComctlLib.TreeRelationshipConstants.tvwChild, "M" & MapX.Index & "Creatures", "Wandering Monsters")
		NodeX.Image = "ClosedFile"
		NodeX.ExpandedImage = "OpenFile"
		NodeX.Tag = "M" & MapX.Index & "Creatures"
		ToList.Add(MapX, NodeX.Tag)
		For	Each CreatureX In MapX.Creatures
			ShowCreature(ToList, ToTree, "M" & MapX.Index & "Creatures", CreatureX)
		Next CreatureX
		' Add Tiles Folder
		NodeX = ToTree.Nodes.Add("M" & MapX.Index, ComctlLib.TreeRelationshipConstants.tvwChild, "M" & MapX.Index & "Tiles", "Tiles")
		NodeX.Image = "ClosedFile"
		NodeX.ExpandedImage = "OpenFile"
		NodeX.Tag = "M" & MapX.Index & "Tiles"
		'    NodeX.Sorted = True ' [Titi 2.5.1] (commented out to avoid Tile10 between Tile1 and Tile2!)
		ToList.Add(MapX, NodeX.Tag)
		For	Each TileX In MapX.Tiles
			ShowTile(ToList, ToTree, "M" & MapX.Index & "Tiles", TileX)
		Next TileX
		' Add EntryPoints Folder
		NodeX = ToTree.Nodes.Add("M" & MapX.Index, ComctlLib.TreeRelationshipConstants.tvwChild, "M" & MapX.Index & "EntryPoints", "EntryPoints")
		NodeX.Image = "ClosedFile"
		NodeX.ExpandedImage = "OpenFile"
		NodeX.Tag = "M" & MapX.Index & "EntryPoints"
		'    NodeX.Sorted = True ' [Titi 2.5.1]
		NodeX.Sorted = mnuOptionSort.Checked ' [Titi 2.6.1]
		ToList.Add(MapX, NodeX.Tag)
		For	Each EntryPointX In MapX.EntryPoints
			ShowEntryPoint(ToList, ToTree, "M" & MapX.Index & "EntryPoints", EntryPointX)
		Next EntryPointX
		' Add Themes Folder
		NodeX = ToTree.Nodes.Add("M" & MapX.Index, ComctlLib.TreeRelationshipConstants.tvwChild, "M" & MapX.Index & "Themes", "Themes")
		NodeX.Image = "ClosedFile"
		NodeX.ExpandedImage = "OpenFile"
		NodeX.Tag = "M" & MapX.Index & "Themes"
		'    NodeX.Sorted = True ' [Titi 2.5.1]
		NodeX.Sorted = mnuOptionSort.Checked ' [Titi 2.6.1]
		ToList.Add(MapX, NodeX.Tag)
		For	Each ThemeX In MapX.Themes
			ShowTheme(ToList, ToTree, "M" & MapX.Index & "Themes", ThemeX)
		Next ThemeX
		' Add Encounters Folder
		NodeX = ToTree.Nodes.Add("M" & MapX.Index, ComctlLib.TreeRelationshipConstants.tvwChild, "M" & MapX.Index & "Encounters", "Encounters")
		NodeX.Image = "ClosedFile"
		NodeX.ExpandedImage = "OpenFile"
		NodeX.Tag = "M" & MapX.Index & "Encounters"
		'    NodeX.Sorted = True ' [Titi 2.5.1]
		NodeX.Sorted = mnuOptionSort.Checked ' [Titi 2.6.1]
		ToList.Add(MapX, NodeX.Tag)
		For	Each EncounterX In MapX.Encounters
			ShowEncounter(ToList, ToTree, "M" & MapX.Index & "Encounters", EncounterX)
		Next EncounterX
	End Sub
	
	Private Sub ShowTileSet(ByRef ToList As Collection, ByRef ToTree As AxComctlLib.AxTreeView, ByRef ParentKey As String, ByRef TileSetX As TileSet)
		Dim NodeX As ComctlLib.Node
		NodeX = ToTree.Nodes.Add(ParentKey, ComctlLib.TreeRelationshipConstants.tvwChild, ParentKey & "W" & TileSetX.Index, TileSetX.Name)
		NodeX.Image = "Text"
		NodeX.Tag = ParentKey & "W" & TileSetX.Index
		'    NodeX.Sorted = True ' [Titi 2.5.1]
		NodeX.Sorted = mnuOptionSort.Checked ' [Titi 2.6.1]
		ToList.Add(TileSetX, NodeX.Tag)
	End Sub
	
	Private Sub ShowEntryPoint(ByRef ToList As Collection, ByRef ToTree As AxComctlLib.AxTreeView, ByRef ParentKey As String, ByRef EntryPointX As EntryPoint)
		Dim NodeX As ComctlLib.Node
		NodeX = ToTree.Nodes.Add(ParentKey, ComctlLib.TreeRelationshipConstants.tvwChild, ParentKey & "P" & EntryPointX.Index, EntryPointX.Name & " (" & EntryPointX.MapX & "," & EntryPointX.MapY & ")")
		NodeX.Image = "Globe"
		NodeX.Tag = ParentKey & "P" & EntryPointX.Index
		'    NodeX.Sorted = True ' [Titi 2.5.1]
		NodeX.Sorted = mnuOptionSort.Checked ' [Titi 2.6.1]
		ToList.Add(EntryPointX, NodeX.Tag)
	End Sub
	
	Private Sub ShowTile(ByRef ToList As Collection, ByRef ToTree As AxComctlLib.AxTreeView, ByRef ParentKey As String, ByRef TileX As Tile)
		Dim NodeX As ComctlLib.Node
		Dim TriggerX As Trigger
		NodeX = frmProject.tvwProject.Nodes.Add(ParentKey, ComctlLib.TreeRelationshipConstants.tvwChild, ParentKey & "L" & TileX.Index, TileX.Name)
		NodeX.Image = "Globe"
		NodeX.Tag = ParentKey & "L" & TileX.Index
		ToList.Add(TileX, NodeX.Tag)
	End Sub
	
	Public Sub ShowEncounter(ByRef ToList As Collection, ByRef ToTree As AxComctlLib.AxTreeView, ByRef ParentKey As String, ByRef EncounterX As Encounter)
		Dim NodeX As ComctlLib.Node
		Dim TriggerX As Trigger
		Dim CreatureX As Creature
		Dim ItemX As Item
		NodeX = ToTree.Nodes.Add(ParentKey, ComctlLib.TreeRelationshipConstants.tvwChild, ParentKey & "E" & EncounterX.Index, EncounterX.Name)
		NodeX.Image = "Book"
		NodeX.Tag = ParentKey & "E" & EncounterX.Index
		'    NodeX.Sorted = True ' [Titi 2.5.1]
		NodeX.Sorted = mnuOptionSort.Checked ' [Titi 2.6.1]
		ToList.Add(EncounterX, NodeX.Tag)
		' Add Triggers
		For	Each TriggerX In EncounterX.Triggers
			ShowTrigger(ToList, ToTree, ParentKey & "E" & EncounterX.Index, TriggerX)
		Next TriggerX
		' Add Creatures
		For	Each CreatureX In EncounterX.Creatures
			ShowCreature(ToList, ToTree, ParentKey & "E" & EncounterX.Index, CreatureX)
		Next CreatureX
		' Add Items
		For	Each ItemX In EncounterX.Items
			ShowItem(ToList, ToTree, ParentKey & "E" & EncounterX.Index, ItemX)
		Next ItemX
	End Sub
	
	Private Sub ShowTheme(ByRef ToList As Collection, ByRef ToTree As AxComctlLib.AxTreeView, ByRef ParentKey As String, ByRef ThemeX As Theme)
		Dim NodeX As ComctlLib.Node
		Dim EncounterX As Encounter
		Dim TriggerX As Trigger
		Dim CreatureX As Creature
		Dim ItemX As Item
		Dim FactoidX As Factoid
		NodeX = ToTree.Nodes.Add(ParentKey, ComctlLib.TreeRelationshipConstants.tvwChild, ParentKey & "R" & ThemeX.Index, ThemeX.Name)
		NodeX.Image = "Book"
		NodeX.Tag = ParentKey & "R" & ThemeX.Index
		'    NodeX.Sorted = True ' [Titi 2.5.1]
		NodeX.Sorted = mnuOptionSort.Checked ' [Titi 2.6.1]
		ToList.Add(ThemeX, NodeX.Tag)
		' Add Encounters
		For	Each EncounterX In ThemeX.Encounters
			ShowEncounter(ToList, ToTree, ParentKey & "R" & ThemeX.Index, EncounterX)
		Next EncounterX
		' Add Triggers
		For	Each TriggerX In ThemeX.Triggers
			ShowTrigger(ToList, ToTree, ParentKey & "R" & ThemeX.Index, TriggerX)
		Next TriggerX
		' Add Creatures
		For	Each CreatureX In ThemeX.Creatures
			ShowCreature(ToList, ToTree, ParentKey & "R" & ThemeX.Index, CreatureX)
		Next CreatureX
		' Add Items
		For	Each ItemX In ThemeX.Items
			ShowItem(ToList, ToTree, ParentKey & "R" & ThemeX.Index, ItemX)
		Next ItemX
		' Add Factoids
		For	Each FactoidX In ThemeX.Factoids
			ShowFactoid(ToList, ToTree, ParentKey & "R" & ThemeX.Index, FactoidX)
		Next FactoidX
	End Sub
	
	Public Sub ShowItem(ByRef ToList As Collection, ByRef ToTree As AxComctlLib.AxTreeView, ByRef ParentKey As String, ByRef ItemX As Item)
		Dim NodeX As ComctlLib.Node
		Dim ItemZ As Item
		Dim TriggerX As Trigger
		NodeX = ToTree.Nodes.Add(ParentKey, ComctlLib.TreeRelationshipConstants.tvwChild, ParentKey & "I" & ItemX.Index, ItemX.Name)
		NodeX.Image = "Text"
		NodeX.Tag = ParentKey & "I" & ItemX.Index
		'    NodeX.Sorted = True ' [Titi 2.5.1]
		NodeX.Sorted = mnuOptionSort.Checked ' [Titi 2.6.1]
		ToList.Add(ItemX, NodeX.Tag)
		' Show Items
		For	Each ItemZ In ItemX.Items
			ShowItem(ToList, ToTree, ParentKey & "I" & ItemX.Index, ItemZ)
		Next ItemZ
		' Show Triggers
		For	Each TriggerX In ItemX.Triggers
			ShowTrigger(ToList, ToTree, ParentKey & "I" & ItemX.Index, TriggerX)
		Next TriggerX
	End Sub
	
	Public Sub ShowCreature(ByRef ToList As Collection, ByRef ToTree As AxComctlLib.AxTreeView, ByRef ParentKey As String, ByRef CreatureX As Creature)
		Dim NodeX As ComctlLib.Node
		Dim TriggerX As Trigger
		Dim ItemX As Item
		Dim ConversationX As Conversation
		NodeX = ToTree.Nodes.Add(ParentKey, ComctlLib.TreeRelationshipConstants.tvwChild, ParentKey & "X" & CreatureX.Index, CreatureX.Name)
		NodeX.Image = "Text"
		NodeX.Tag = ParentKey & "X" & CreatureX.Index
		'    NodeX.Sorted = True ' [Titi 2.5.1]
		NodeX.Sorted = mnuOptionSort.Checked ' [Titi 2.6.1]
		ToList.Add(CreatureX, NodeX.Tag)
		' Add Creature Triggers
		For	Each TriggerX In CreatureX.Triggers
			ShowTrigger(ToList, ToTree, ParentKey & "X" & CreatureX.Index, TriggerX)
		Next TriggerX
		' Add Creature Items
		For	Each ItemX In CreatureX.Items
			ShowItem(ToList, ToTree, ParentKey & "X" & CreatureX.Index, ItemX)
		Next ItemX
		' Add Conversations
		For	Each ConversationX In CreatureX.Conversations
			ShowConversation(ToList, ToTree, ParentKey & "X" & CreatureX.Index, ConversationX)
		Next ConversationX
	End Sub
	
	Private Sub ShowConversation(ByRef ToList As Collection, ByRef ToTree As AxComctlLib.AxTreeView, ByRef ParentKey As String, ByRef ConversationX As Conversation)
		Dim NodeX As ComctlLib.Node
		Dim TopicX As Topic
		NodeX = ToTree.Nodes.Add(ParentKey, ComctlLib.TreeRelationshipConstants.tvwChild, ParentKey & "C" & ConversationX.Index, ConversationX.Name)
		NodeX.Image = "Doc"
		NodeX.Tag = ParentKey & "C" & ConversationX.Index
		'    NodeX.Sorted = True ' [Titi 2.5.1]
		NodeX.Sorted = mnuOptionSort.Checked ' [Titi 2.6.1]
		ToList.Add(ConversationX, NodeX.Tag)
		' Show Topics
		For	Each TopicX In ConversationX.Topics
			ShowTopic(ToList, ToTree, ParentKey & "C" & ConversationX.Index, TopicX)
		Next TopicX
	End Sub
	
	Private Sub ShowTopic(ByRef ToList As Collection, ByRef ToTree As AxComctlLib.AxTreeView, ByRef ParentKey As String, ByRef TopicX As Topic)
		Dim NodeX As ComctlLib.Node
		Dim TriggerX As Trigger
		Dim FactoidX As Factoid
		NodeX = ToTree.Nodes.Add(ParentKey, ComctlLib.TreeRelationshipConstants.tvwChild, ParentKey & "Q" & TopicX.Index, TopicX.Say)
		NodeX.Image = "Doc"
		NodeX.Tag = ParentKey & "Q" & TopicX.Index
		'    NodeX.Sorted = True ' [Titi 2.5.1]
		NodeX.Sorted = mnuOptionSort.Checked ' [Titi 2.6.1]
		ToList.Add(TopicX, NodeX.Tag)
		' Show Triggers
		For	Each TriggerX In TopicX.Triggers
			ShowTrigger(ToList, ToTree, ParentKey & "Q" & TopicX.Index, TriggerX)
		Next TriggerX
		' Show Factoids
		For	Each FactoidX In TopicX.Factoids
			ShowFactoid(ToList, ToTree, ParentKey & "Q" & TopicX.Index, FactoidX)
		Next FactoidX
	End Sub
	
	Private Sub ShowFactoid(ByRef ToList As Collection, ByRef ToTree As AxComctlLib.AxTreeView, ByRef ParentKey As String, ByRef FactoidX As Factoid)
		Dim NodeX As ComctlLib.Node
		NodeX = ToTree.Nodes.Add(ParentKey, ComctlLib.TreeRelationshipConstants.tvwChild, ParentKey & "F" & FactoidX.Index, FactoidX.Text)
		NodeX.Image = "Doc"
		NodeX.Tag = ParentKey & "F" & FactoidX.Index
		'    NodeX.Sorted = True ' [Titi 2.5.1]
		NodeX.Sorted = mnuOptionSort.Checked ' [Titi 2.6.1]
		ToList.Add(FactoidX, NodeX.Tag)
	End Sub
	
	Private Sub ShowJournal(ByRef ToList As Collection, ByRef ToTree As AxComctlLib.AxTreeView, ByRef ParentKey As String, ByRef JournalX As Journal)
		Dim NodeX As ComctlLib.Node
		NodeX = ToTree.Nodes.Add(ParentKey, ComctlLib.TreeRelationshipConstants.tvwChild, ParentKey & "J" & JournalX.Index, JournalX.Text)
		NodeX.Image = "Doc"
		NodeX.Tag = ParentKey & "J" & JournalX.Index
		'    NodeX.Sorted = True ' [Titi 2.5.1]
		NodeX.Sorted = mnuOptionSort.Checked ' [Titi 2.6.1]
		ToList.Add(JournalX, NodeX.Tag)
	End Sub
	
	Public Sub ShowTrigger(ByRef ToList As Collection, ByRef ToTree As AxComctlLib.AxTreeView, ByRef ParentKey As String, ByRef TriggerX As Trigger)
		Dim NodeX As ComctlLib.Node
		Dim CreatureX As Creature
		Dim ItemX As Item
		Dim TriggerZ As Trigger
		NodeX = ToTree.Nodes.Add(ParentKey, ComctlLib.TreeRelationshipConstants.tvwChild, ParentKey & "T" & TriggerX.Index, TriggerName(TriggerX.TriggerType) & " " & TriggerX.Name)
		NodeX.Image = "Exe"
		NodeX.Tag = ParentKey & "T" & TriggerX.Index
		'    NodeX.Sorted = True ' [Titi 2.5.1]
		NodeX.Sorted = mnuOptionSort.Checked ' [Titi 2.6.1]
		ToList.Add(TriggerX, NodeX.Tag)
		' Show Creatures
		For	Each CreatureX In TriggerX.Creatures
			ShowCreature(ToList, ToTree, ParentKey & "T" & TriggerX.Index, CreatureX)
		Next CreatureX
		' Show Items
		For	Each ItemX In TriggerX.Items
			ShowItem(ToList, ToTree, ParentKey & "T" & TriggerX.Index, ItemX)
		Next ItemX
		' Show Triggers
		For	Each TriggerZ In TriggerX.Triggers
			ShowTrigger(ToList, ToTree, ParentKey & "T" & TriggerX.Index, TriggerZ)
		Next TriggerZ
	End Sub
	
	Public Sub ShowArea(ByRef ToList As Collection, ByRef ToTree As AxComctlLib.AxTreeView, ByRef ParentKey As String, ByRef AreaX As Area)
		Dim NodeX As ComctlLib.Node
		NodeX = ToTree.Nodes.Add(ParentKey, ComctlLib.TreeRelationshipConstants.tvwChild, ParentKey & "A" & AreaX.Index, AreaX.Name)
		NodeX.Image = "Globe"
		NodeX.Tag = ParentKey & "A" & AreaX.Index
		'    NodeX.Sorted = True ' [Titi 2.5.1]
		NodeX.Sorted = mnuOptionSort.Checked ' [Titi 2.6.1]
		ToList.Add(AreaX, NodeX.Tag)
	End Sub
	
	Private Function InitGame() As Boolean
		Dim ERR_CRITICAL As Object
		Dim aMostRecent As Object
		Dim LoadSystemSettings As Object
		Dim Folder As Object
		Dim oGameMusic As Object
		Dim oFileSys As Object
		Dim ERR_DEBUG As Object
		Dim oErr As Object
		Dim fReadValue As Object
		Dim logError, errLevel As Short
		Dim lResult As Integer
		'UPGRADE_NOTE: Text was upgraded to Text_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim nbFile As Short
		Dim Text_Renamed As String
		'On Error GoTo Err_Handler
		' [rb] Added for 2.4.6
		'Call ParseCommandLineArgs
		gAppPath = My.Application.Info.DirectoryPath
		'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lResult = fReadValue(gAppPath & "\Settings.ini", "System", "DataFolder", "S", gAppPath, Text_Renamed)
		gDataPath = Text_Renamed
		'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lResult = fReadValue(gAppPath & "\Settings.ini", "System", "LibraryFolder", "S", gAppPath, Text_Renamed)
		gLibPath = Text_Renamed
		'    Call oErr.Initialize("creatorlog.txt", GlobalDebugMode)
		oErr = New CErrorHandler
		'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lResult = fReadValue(gAppPath & "\Settings.ini", "System", "ErrorLog", "B", "0", logError)
		'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lResult = fReadValue(gAppPath & "\Settings.ini", "System", "ErrorLvl", "B", "3", errLevel)
		'UPGRADE_WARNING: Couldn't resolve default property of object oErr.Initialize. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Call oErr.Initialize(CShort(logError), CShort(errLevel), "CreatorLog.txt")
		'UPGRADE_WARNING: Couldn't resolve default property of object oErr.logError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oErr.logError("InitGame: Started", ERR_DEBUG)
		' Initialize our new IO Class
		oFileSys = New clsInOut
		oGameMusic = New IMCI
		' [Titi 2.4.7]
		WorldNow = New World
		' [Titi 2.4.8] added to use the runes of the current world
		'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lResult = fReadValue(gAppPath & "\Settings.ini", "World", "Current", "S", "Eternia", Text_Renamed)
		'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WorldNow.Name = Text_Renamed
		'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Call InitializeRunes(WorldNow.Name)
		' [Titi 2.4.9] Copied from CreatePCLoadWorlds (to fix RT5 during tome creation by the wizard)
		' Get the World Currency from the *.ini file
		'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lResult = fReadValue(gAppPath & "\Roster\" & WorldNow.Name & "\" & WorldNow.Name & ".ini", "World", "Currency", "S", "Gold piece|gold1.BMP", Text_Renamed)
		'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Money. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WorldNow.Money = Text_Renamed
		'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If oFileSys.CheckExists(gDataPath & "\Data", Folder) Then
			gDataPath = gDataPath & "\Data"
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Not oFileSys.CheckExists(gDataPath, Folder) Then
			Err.Raise(1000, "Creator.InitGame", "No Data Folder found.")
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If oFileSys.CheckExists(gLibPath & "\Library", Folder) Then
			gLibPath = gLibPath & "\Library"
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Not oFileSys.CheckExists(gLibPath, Folder) Then
			Err.Raise(1000, "Creator.InitGame", "No Library Folder found.")
		End If
		' Set GlobalMusicState to ON
		GlobalMusicState = 1
		' Set GlobalWAVState to ON
		GlobalWAVState = 1
		' Build the Syntax for Triggers
		modDM.BuildSyntax()
		' [Titi 2.4.9b] made the AutoComplete feature a lasting value
		'    blnAutoComplete = True
		'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lResult = fReadValue(gAppPath & "\Settings.ini", "Creator", "AutoComplete", "S", "1", nbFile)
		blnAutoComplete = Not CBool(nbFile)
		mnuOptionAutoComplete_Click(mnuOptionAutoComplete, New System.EventArgs())
		' Load LicNumber
		'    OptionsLoad False
		' Set up Default Tome
		Me.Show()
		'    NewTome
		' [borf] autoload a tome
		'UPGRADE_WARNING: CommonDialog property dlgFile.FileTitle was upgraded to dlgFile.FileName which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		ShowMsg("Loading Tome " & dlgFileOpen.FileName & "....")
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		' Depending on file chosen, get other files
		LoadSystemSettings()
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lResult = fReadValue(gAppPath & "\Settings.ini", "Creator", "WizardStartup", "S", "True", Text_Renamed)
		' [Titi 2.4.9] override this setting if nothing to load by default
		'    If UCase$(tmp) = "TRUE" Then NewTome
		If VB.Command() = "" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object aMostRecent(0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If UCase(Text_Renamed) = "TRUE" Or aMostRecent(0) = vbNullString Then
				NewTome()
			Else
				' find most recent tome
				nbFile = 4
				'UPGRADE_WARNING: Couldn't resolve default property of object aMostRecent(nbFile). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				While aMostRecent(nbFile) = vbNullString And nbFile > 0
					nbFile = nbFile - 1
				End While
				'UPGRADE_WARNING: Couldn't resolve default property of object aMostRecent(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				OpenTome(aMostRecent(nbFile))
			End If
		End If
		ShowMsg("")
		InitGame = True
Exit_Sub: 
		Exit Function
Err_Handler: 
		If Err.Number = 1000 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object oErr.logError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			oErr.logError("You may not have the required data files installed.  Check for a Data folder.", ERR_CRITICAL)
		ElseIf Err.Number = 91 Then 
			' not a problem with a block "With" (hehe), but here we probably have two instances of Creator running
			'UPGRADE_WARNING: Couldn't resolve default property of object oErr.Initialize. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Call oErr.Initialize(CShort(logError), CShort(errLevel), "CreatorLog2.txt")
			Resume Next
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object oErr.logError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			oErr.logError("InitGame:  Failed.", ERR_CRITICAL)
		End If
		InitGame = False
		'Stop
		Resume Exit_Sub
	End Function
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub SaveTomeAs()
		Dim Tome_Renamed As Object
		Dim rc As Integer
		Dim AreaX As Area
		On Error Resume Next
		'    ChDir gAppPath & "\tomes"
		' [Titi] 2.4.8
		'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If WorldNow.Name = "" Then WorldNow.Name = "Eternia"
		dlgFileOpen.Title = "Save Tome"
		dlgFileSave.Title = "Save Tome" ' [Titi 2.4.9]
		'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		dlgFileOpen.FileName = gAppPath & "\tomes\" & WorldNow.Name & "\*.tom"
		dlgFileSave.FileName = gAppPath & "\tomes\" & WorldNow.Name & "\*.tom"
		If Tome.FileName <> "" And Tome.FileName <> "default.tom" Then
			dlgFileOpen.FileName = ""
			dlgFileSave.FileName = ""
		End If ' [Titi 2.4.9]
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		dlgFile.CancelError = True
		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		dlgFileOpen.Filter = "Tome (*.tom)|*.tom|All Files (*.*)|*.*"
		dlgFileSave.Filter = "Tome (*.tom)|*.tom|All Files (*.*)|*.*"
		dlgFileOpen.FilterIndex = 1
		dlgFileSave.FilterIndex = 1
		'UPGRADE_WARNING: Untranslated statement in SaveTomeAs. Please check source code.
		dlgFileSave.ShowDialog()
		dlgFileOpen.FileName = dlgFileSave.FileName
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		If Err.Number = DialogResult.Cancel Then
			Exit Sub
		End If
		' Set new file names
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: CommonDialog property dlgFile.FileTitle was upgraded to dlgFile.FileName which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		Tome.FileName = dlgFileOpen.FileName
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: CommonDialog property dlgFile.FileTitle was upgraded to dlgFile.FileName which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		Tome.LoadPath = VB.Left(dlgFileOpen.FileName, Len(dlgFileOpen.FileName) - Len(dlgFileOpen.FileName) - 1)
		' [Titi 2.4.9] make sure all areas are opened
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Areas. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		For	Each AreaX In Tome.Areas
			If AreaX.IsLoaded = False Then
				OpenArea(AreaX)
			End If
		Next AreaX
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		SaveTome(Tome.LoadPath & "\" & Tome.FileName)
	End Sub
	
	Public Sub ShowMsg(ByRef msg As String)
		stbMDI.SimpleText = msg
		'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		stbMDI.CtlRefresh()
	End Sub
	
	Private Sub frmMDI_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim aMostRecent As Object
		Dim File As Object
		Dim oFileSys As Object
		Dim oErr As Object
		If Not InitGame Then End
		' [Titi 2.6.0] Command line feature added
		Dim Found, c, i As Short
		Dim TomeX As Tome
		Dim sTome As String
		Dim TomeList As Collection
		If VB.Command() <> "" Then
			If InStr(VB.Command(), "\") = 0 And UCase(VB.Command()) <> "LASTTOME" Then
				TomeList = New Collection
				'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				SearchFolders("*.tom", gAppPath & "\Tomes\" & WorldNow.Name, TomeList)
				For c = 1 To TomeList.Count()
					TomeX = New Tome
					i = FreeFile
					'UPGRADE_WARNING: Couldn't resolve default property of object TomeList(c).Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					FileOpen(i, TomeList.Item(c).Text, OpenMode.Binary)
					TomeX.ReadFromFileHeader(i)
					'UPGRADE_WARNING: Couldn't resolve default property of object TomeList().Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					TomeX.FileName = VB.Right(TomeList.Item(c).Text, Len(TomeList.Item(c).Text) - InStrRev(TomeList.Item(c).Text, "\"))
					If TomeX.Name = vbNullString Then
						'UPGRADE_WARNING: Couldn't resolve default property of object TomeList().Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object oErr.logError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						oErr.logError(TomeList.Item(c).Text & " is not a valid tome.")
					End If
					FileClose(i)
					If UCase(TomeX.Name) = UCase(VB.Command()) Or UCase(TomeX.Name) = UCase(VB.Command() & ".tom") Or UCase(TomeX.FileName) = UCase(VB.Command()) Or UCase(TomeX.FileName) = UCase(VB.Command() & ".tom") Then
						Found = Found + 1
						'UPGRADE_WARNING: Couldn't resolve default property of object TomeList().Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						sTome = TomeList.Item(c).Text
					End If
				Next 
				If Found = 1 Then
					OpenTome(sTome)
				Else
					MsgBox(Found & " tomes are named " & VB.Command() & ".", MsgBoxStyle.OKOnly)
					If Found = 0 Then
						NewTome()
					Else
						OpenTome()
					End If
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf oFileSys.CheckExists(VB.Command(), File) = True Then 
				OpenTome(VB.Command())
				'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf oFileSys.CheckExists(VB.Command() & ".tom", File) = True Then 
				OpenTome(VB.Command() & ".tom")
			ElseIf UCase(VB.Command()) = "LASTTOME" Then 
				Found = 4
				'UPGRADE_WARNING: Couldn't resolve default property of object aMostRecent(Found). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				While aMostRecent(Found) = vbNullString And Found > 0
					Found = Found - 1
				End While
				'UPGRADE_WARNING: Couldn't resolve default property of object aMostRecent(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				OpenTome(aMostRecent(Found))
			Else
				MsgBox("Unrecognized command: " & VB.Command() & "." & vbCrLf & "Creator will start normally.", MsgBoxStyle.OKOnly, "Unrecognized command")
				NewTome()
			End If
		End If
	End Sub
	
	Private Sub frmMDI_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		Dim Cancel As Boolean = eventArgs.Cancel
		Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
		Dim frmWorldSettings As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Dirty. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If frmWorldSettings.Dirty Then
			Dirty = 250 ' [Titi 2.5.1] flag to tell the creator not to load a new tome when exiting a world upon clicking on the "X" on the main window
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.btnQuit_Click. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmWorldSettings.btnQuit_Click()
			'        Cancel = 1
		Else
			EndGame(Cancel)
		End If
		eventArgs.Cancel = Cancel
	End Sub
	
	'UPGRADE_WARNING: Event frmMDI.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmMDI_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		ResizeForm()
	End Sub
	
	Public Sub mnuCreaExpl_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuCreaExpl.Click
		Dim frmErrorDialog As Object
		Dim frmMonsExplorer As Object
		Dim Folder As Object
		Dim oFileSys As Object
		Dim bFileCk As Boolean
		'    bFileCk = oFileSys.CheckExists(gAppPath & "\Library", Folder, False)
		'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		bFileCk = oFileSys.CheckExists(gLibPath, Folder, False)
		If bFileCk = True Then
			'UPGRADE_WARNING: Couldn't resolve default property of object frmMonsExplorer.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmMonsExplorer.Show()
		Else
			'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
			Load(frmErrorDialog)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmErrorDialog.lblMessage. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmErrorDialog.lblMessage.Caption = "Error : Library directory not found in " & gLibPath
			'UPGRADE_WARNING: Couldn't resolve default property of object frmErrorDialog.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmErrorDialog.Show()
		End If
	End Sub
	
	Public Sub mnuItemExpl_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuItemExpl.Click
		Dim frmErrorDialog As Object
		Dim frmItemExplorer As Object
		Dim Folder As Object
		Dim oFileSys As Object
		Dim bFileCk As Boolean
		'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		bFileCk = oFileSys.CheckExists(gLibPath, Folder, False)
		If bFileCk = True Then
			'UPGRADE_WARNING: Couldn't resolve default property of object frmItemExplorer.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmItemExplorer.Show()
		Else
			'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
			Load(frmErrorDialog)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmErrorDialog.lblMessage. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmErrorDialog.lblMessage.Caption = "Error : Library directory not found in " & gLibPath
			'UPGRADE_WARNING: Couldn't resolve default property of object frmErrorDialog.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmErrorDialog.Show()
		End If
	End Sub
	
	Public Sub mnuEditLoadObj_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditLoadObj.Click
		Dim Index As Short = mnuEditLoadObj.GetIndex(eventSender)
		Select Case mnuEditLoadObj(Index).Text
			Case "Insert Map from Library..."
				EditLoad(TreeViewX.SelectedItem.Tag, bdEditMap)
			Case "Insert Encounter from Library..."
				EditLoad(TreeViewX.SelectedItem.Tag, bdEditEncounter)
			Case "Insert Creature from Library..."
				EditLoad(TreeViewX.SelectedItem.Tag, bdEditCreature)
			Case "Insert Item from Library..."
				EditLoad(TreeViewX.SelectedItem.Tag, bdEditItem)
			Case "Insert Trigger from Library..."
				EditLoad(TreeViewX.SelectedItem.Tag, bdEditTrigger)
			Case "Insert Conversation from Library..."
				EditLoad(TreeViewX.SelectedItem.Tag, bdEditConvo)
			Case "Insert Theme from Library..."
				EditLoad(TreeViewX.SelectedItem.Tag, bdEditTheme)
			Case "Insert Area from Library..."
				EditLoad(TreeViewX.SelectedItem.Tag, bdEditArea)
		End Select
	End Sub
	
	Public Sub mnuEditMovetoArea_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditMovetoArea.Click
		Dim Index As Short = mnuEditMovetoArea.GetIndex(eventSender)
		' [Titi 2.4.9]
		Dim c As Short
		Dim AreaY, AreaX As Area
		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
		If VB6.GetActiveControl().Name = "tvwProject" Or VB6.GetActiveControl().Name = "tvwTome" Then
			If frmProject.blnOtherTree = False Then
				' [Titi 2.5.1] Map already removed from the area if we're coming from a drag & drop action!
				EditCut(TreeViewX.SelectedItem.Tag)
			End If
			For	Each AreaX In Tome.Areas
				If AreaX.Index <> Index And AreaX.IsLoaded Then ' [Titi 2.5.1] If area is not loaded, automatically .Plot.Maps.Count will be 0
					If AreaX.Plot.Maps.Count() < 1 Then
						' remove area
						Me.SetupMenu((frmProject.TomeList), (frmProject.tvwTome), frmProject.tvwTome.SelectedItem.Tag)
						EditDelete("TomeAreasA" & AreaX.Index)
					Else ' flag area
						AreaY = AreaX
					End If
				End If
			Next AreaX
			For	Each AreaX In Tome.Areas
				If AreaX.Index = Index Then
					OpenArea(AreaX)
					' [Titi 2.6.0] if we move the area contained only one map, and if we move the map from that area to the same (yes, silly thing to do!), there won't be any selected item
					If AreaX.Plot.Maps.Count() = 0 Then
						AreaX.Plot.AddMap()
						OpenArea(AreaX)
						c = True
					End If
					EditPaste(TreeViewX.SelectedItem.Tag)
					' [Titi 2.6.0] now, remove the map we temporarily added to prevent RT91
					If c Then AreaX.Plot.RemoveMap("M1")
					' back to the area we were at
					OpenArea(AreaY)
				End If
			Next AreaX
		End If
	End Sub
	
	Public Sub mnuEditNewObj_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditNewObj.Click
		Dim Index As Short = mnuEditNewObj.GetIndex(eventSender)
		Select Case mnuEditNewObj(Index).Text
			Case "New Map"
				EditAdd(TreeViewX.SelectedItem.Tag, bdEditMap, True)
			Case "New Encounter"
				EditAdd(TreeViewX.SelectedItem.Tag, bdEditEncounter, True)
			Case "New Creature"
				EditAdd(TreeViewX.SelectedItem.Tag, bdEditCreature, True)
			Case "New Item"
				EditAdd(TreeViewX.SelectedItem.Tag, bdEditItem, True)
			Case "New Trigger"
				EditAdd(TreeViewX.SelectedItem.Tag, bdEditTrigger, True)
			Case "New Conversation"
				EditAdd(TreeViewX.SelectedItem.Tag, bdEditConvo, True)
			Case "New Topic"
				EditAdd(TreeViewX.SelectedItem.Tag, bdEditTopic, True)
			Case "New Theme"
				EditAdd(TreeViewX.SelectedItem.Tag, bdEditTheme, True)
			Case "New TileSet"
				EditAdd(TreeViewX.SelectedItem.Tag, bdEditTileSet, True)
			Case "New Tile"
				EditAdd(TreeViewX.SelectedItem.Tag, bdEditTile, True)
			Case "New EntryPoint"
				EditAdd(TreeViewX.SelectedItem.Tag, bdEditEntryPoint, True)
			Case "New Factoid"
				EditAdd(TreeViewX.SelectedItem.Tag, bdEditFactoid, True)
			Case "New Description"
				EditAdd(TreeViewX.SelectedItem.Tag, bdEditFactoid, True)
			Case "New Journal Entry"
				EditAdd(TreeViewX.SelectedItem.Tag, bdEditJournal, True)
			Case "New Area"
				EditAdd(TreeViewX.SelectedItem.Tag, bdEditArea, True)
		End Select
	End Sub
	
	Public Sub mnuEditCopy_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditCopy.Click
		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
		If VB6.GetActiveControl().Name = "tvwProject" Or VB6.GetActiveControl().Name = "tvwTome" Then
			EditCopy(TreeViewX.SelectedItem.Tag)
		End If
	End Sub
	
	Public Sub mnuEditCut_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditCut.Click
		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
		If VB6.GetActiveControl().Name = "tvwProject" Or VB6.GetActiveControl().Name = "tvwTome" Then
			EditCut(TreeViewX.SelectedItem.Tag)
		End If
	End Sub
	
	Public Sub mnuEditPaste_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditPaste.Click
		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
		If VB6.GetActiveControl().Name = "tvwProject" Or VB6.GetActiveControl().Name = "tvwTome" Then
			EditPaste(TreeViewX.SelectedItem.Tag)
		End If
	End Sub
	
	Public Sub mnuEditGoto_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditGoto.Click
		' [Borfaux 2.4.8]
		Dim c, TileIndex As Short
		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
		Dim ObjectX As EntryPoint
		If VB6.GetActiveControl().Name = "tvwProject" Or VB6.GetActiveControl().Name = "tvwTome" Then
			' If MapX.Graphic is open, repaint it.
			For c = 0 To My.Application.OpenForms.Count - 1
				If My.Application.OpenForms.Item(c).Tag = TreeViewX.SelectedItem.Parent.Parent.Tag & "Graphic" Then
					'UPGRADE_ISSUE: Control TileNow could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					TileIndex = My.Application.OpenForms.Item(c).TileNow.Index '[Titi 2.4.9] save current tile
					ObjectX = ObjectListX.Item(TreeViewX.SelectedItem.Tag)
					'UPGRADE_ISSUE: Control CenterMap could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					My.Application.OpenForms.Item(c).CenterMap(ObjectX.MapX, ObjectX.MapY)
					'UPGRADE_ISSUE: Control DrawMap could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					My.Application.OpenForms.Item(c).DrawMap()
					' [Titi 2.4.8] highlight the entrypoint location
					'UPGRADE_ISSUE: Control MAJ could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					My.Application.OpenForms.Item(c).MAJ = -5 ' bdTileEncYellow
					'UPGRADE_ISSUE: Control FindTile could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					My.Application.OpenForms.Item(c).FindTile(ObjectX)
					'UPGRADE_ISSUE: Control MAJ could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					My.Application.OpenForms.Item(c).MAJ = 0
					'UPGRADE_ISSUE: Control TileNow could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					My.Application.OpenForms.Item(c).TileNow.Index = TileIndex ' [Titi 2.4.9] now reset the tile
					'UPGRADE_ISSUE: Control picMap could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					My.Application.OpenForms.Item(c).picMap.Refresh()
				End If
			Next c
			If ObjectX Is Nothing Then MsgBox("The map this EntryPoint belongs to is not opened.", MsgBoxStyle.OKOnly, "Map not loaded!")
		End If
	End Sub
	
	Public Sub mnuEditProperties_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditProperties.Click
		EditProperties(TreeViewX.SelectedItem.Tag)
	End Sub
	
	Public Sub mnuEditRemove_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditRemove.Click
		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
		Dim c As Short
		If VB6.GetActiveControl().Name = "tvwProject" Or VB6.GetActiveControl().Name = "tvwTome" Or VB6.GetActiveControl().Name = "picMap" Then
			EditDelete(TreeViewX.SelectedItem.Tag, True)
			' [Titi 2.6.0] right-click to remove an encounter didn't work
			'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
			If VB6.GetActiveControl().Name = "picMap" Then
				' Redraw all open Map windows
				For c = 0 To My.Application.OpenForms.Count - 1
					If VB.Right(My.Application.OpenForms.Item(c).Tag, 7) = "Graphic" Then
						'UPGRADE_ISSUE: Control DrawMap could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
						My.Application.OpenForms.Item(c).DrawMap()
					End If
				Next c
			End If
		Else
			' [Titi - 2.4.6] allows the Del key to act as usual and not only as a shortcut for "Remove"
			mnuEditRemove.Enabled = False
			System.Windows.Forms.SendKeys.SendWait("{DEL}")
			mnuEditRemove.Enabled = True
		End If
	End Sub
	
	Public Sub mnuEditSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditSave.Click
		Select Case mnuEditSave.Text
			Case "Save Map to Library..."
				EditSave(TreeViewX.SelectedItem.Tag, bdEditMap)
			Case "Save Encounter to Library..."
				EditSave(TreeViewX.SelectedItem.Tag, bdEditEncounter)
			Case "Save Creature to Library..."
				EditSave(TreeViewX.SelectedItem.Tag, bdEditCreature)
			Case "Save Item to Library..."
				EditSave(TreeViewX.SelectedItem.Tag, bdEditItem)
			Case "Save Trigger to Library..."
				EditSave(TreeViewX.SelectedItem.Tag, bdEditTrigger)
			Case "Save Conversation to Library..."
				EditSave(TreeViewX.SelectedItem.Tag, bdEditConvo)
			Case "Save Theme to Library..."
				EditSave(TreeViewX.SelectedItem.Tag, bdEditTheme)
			Case "Save Area to Library..."
				EditSave(TreeViewX.SelectedItem.Tag, bdEditArea)
		End Select
	End Sub
	
	Public Sub mnuFileExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileExit.Click
		Dim rc As Short
		EndGame(rc)
		If rc = False Then
			Me.Close()
		End If
	End Sub
	
	Public Sub mnuFileNewTome_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileNewTome.Click
		Dim frmWorldSettings As Object
		' check if working on a world
		'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Visible. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If frmWorldSettings.Visible Then
			Me.Dirty = 250
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.btnQuit_Click. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmWorldSettings.btnQuit_Click()
			'UPGRADE_ISSUE: Unload frmWorldSettings was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="875EBAD7-D704-4539-9969-BC7DBDAA62A2"'
			Unload(frmWorldSettings)
		End If
		Me.Dirty = False
		NewTome()
	End Sub
	
	Public Sub mnuFileOpenTome_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileOpenTome.Click
		OpenTome()
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub mnuFileSaveTome_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileSaveTome.Click
		Dim Tome_Renamed As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Tome.FileName = "default.tom" Or Tome.FileName = "" Then
			' [Titi 2.4.9] RT 52 if a wizard created tome was saved with the save button!
			SaveTomeAs()
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SaveTome(Tome.LoadPath & "\" & Tome.FileName)
		End If
	End Sub
	
	Public Sub mnuFileSaveTomeAs_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileSaveTomeAs.Click
		SaveTomeAs()
	End Sub
	
	Public Sub mnuHelpAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpAbout.Click
		frmAbout.Show()
	End Sub
	
	Public Sub mnuHelpContents_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpContents.Click
		Dim HH_DISPLAY_TOPIC As Object
		Dim HtmlHelp As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object HtmlHelp(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		hwndHelp = HtmlHelp(Handle.ToInt32, My.Application.Info.DirectoryPath & "\RSCHelp.chm", HH_DISPLAY_TOPIC, 0)
	End Sub
	
	Public Sub mnuOptionAutoComplete_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuOptionAutoComplete.Click
		blnAutoComplete = Not blnAutoComplete
		mnuOptionAutoComplete.Text = IIf(blnAutoComplete, "Smart trigger editor ON", "Smart trigger editor OFF")
		mnuOptionAutoComplete.Checked = blnAutoComplete ' Not mnuOptionAutoComplete.Checked
	End Sub
	
	Public Sub mnuOptionGetDataFiles_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuOptionGetDataFiles.Click
		mnuSearchListAllData_Click(mnuSearchListAllData, New System.EventArgs())
		CheckIfExist(True)
	End Sub
	
	Public Sub mnuOptionSort_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuOptionSort.Click
		Dim AreaNodeTag, TomeNodeTag As String
		Dim AreaNodeStatus, TomeNodeStatus As Boolean
		Dim tvwCurrent As AxComctlLib.AxTreeView
		' [Titi 2.6.1] Optional setting to have the treeviews automatically sorted in alphabetical order or not
		mnuOptionSort.Text = "Alphabetical sorting " & IIf(mnuOptionSort.Checked, "OFF", "ON")
		mnuOptionSort.Checked = Not mnuOptionSort.Checked
		' now, let's apply the changes
		tvwCurrent = TreeViewX
		'UPGRADE_WARNING: Couldn't resolve default property of object frmProject.tvwProject.SelectedItem.Tag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		AreaNodeTag = frmProject.tvwProject.SelectedItem.Tag
		AreaNodeStatus = frmProject.tvwProject.SelectedItem.Expanded
		'UPGRADE_WARNING: Couldn't resolve default property of object frmProject.tvwTome.SelectedItem.Tag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TomeNodeTag = frmProject.tvwTome.SelectedItem.Tag
		TomeNodeStatus = frmProject.tvwTome.SelectedItem.Expanded
		ShowTome(Tome, True) ' this refreshes the tome display
		OpenArea(Area) ' this refreshes the area display
		frmProject.tvwProject.SelectedItem = frmProject.tvwProject.Nodes(AreaNodeTag)
		frmProject.tvwProject.SelectedItem.Expanded = AreaNodeStatus
		frmProject.tvwTome.SelectedItem = frmProject.tvwTome.Nodes(TomeNodeTag)
		frmProject.tvwTome.SelectedItem.Expanded = TomeNodeStatus
		TreeViewX = tvwCurrent.GetOcx
	End Sub
	
	Public Sub mnuOptionsShowEncounters_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuOptionsShowEncounters.Click
		Dim c As Short
		mnuOptionsShowEncounters.Checked = (mnuOptionsShowEncounters.Checked = False)
		OptionShowEncounters = mnuOptionsShowEncounters.Checked
		' Redraw all open Map windows
		For c = 0 To My.Application.OpenForms.Count - 1
			If VB.Right(My.Application.OpenForms.Item(c).Tag, 7) = "Graphic" Then
				'UPGRADE_ISSUE: Control DrawMap could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
				My.Application.OpenForms.Item(c).DrawMap()
			End If
		Next c
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub mnuOptionsWorldSettingsLoad_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuOptionsWorldSettingsLoad.Click
		Dim oErr As Object
		Dim File As Object
		Dim oFileSys As Object
		Dim fReadValue As Object
		Dim Tome_Renamed As Object
		Dim frmWorldSettings As Object
		' [Titi] Added for 2.4.7
		'UPGRADE_NOTE: Text was upgraded to Text_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Text_Renamed, FileName, strTomePath As String
		Dim lResult As Integer
		Dim hndWorld, intKingdoms As Short
		Dim strKingdom As String
		On Error GoTo ErrorHandler
		With frmWorldSettings
			' check if tome already open
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Tome.Name = "Untitled" Then
				' but maybe some work was done already...
				'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Dirty. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If .Dirty Then
					' changes made
					hndWorld = MsgBox("Do you want to save the world?", MsgBoxStyle.YesNo, "World settings changed")
					'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.btnSave_Click. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If hndWorld = MsgBoxResult.Yes Then frmWorldSettings.btnSave_Click()
				End If
				EndGame(hndWorld)
				' load saved world
				Me.dlgFileOpen.Title = "Open World"
				Me.dlgFileSave.Title = "Open World"
				Me.dlgFileOpen.FileName = gAppPath & "\Roster\*.ini"
				Me.dlgFileSave.FileName = gAppPath & "\Roster\*.ini"
				'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
				Me.dlgFile.CancelError = True
				'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				Me.dlgFileOpen.Filter = "World settings (*.ini)|*.ini|All Files (*.*)|*.*"
				Me.dlgFileSave.Filter = "World settings (*.ini)|*.ini|All Files (*.*)|*.*"
				Me.dlgFileOpen.FilterIndex = 1
				Me.dlgFileSave.FilterIndex = 1
				'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
				'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
				Me.dlgFileOpen.CheckFileExists = True
				Me.dlgFileOpen.CheckPathExists = True
				Me.dlgFileSave.CheckPathExists = True
				'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
				'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
				Me.dlgFileOpen.ShowReadOnly = False
				Me.dlgFileOpen.RestoreDirectory = False
				Me.dlgFileSave.RestoreDirectory = False
				Me.dlgFileOpen.ShowDialog()
				Me.dlgFileSave.FileName = Me.dlgFileOpen.FileName
				'UPGRADE_NOTE: Object WorldNow may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
				WorldNow = Nothing
				WorldNow = New World
				strTomePath = Me.dlgFileOpen.FileName
				'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf WorldNow.Name <> "" Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Dirty. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If .Dirty Then
					' changes made
					hndWorld = MsgBox("Do you want to save the world?", MsgBoxStyle.YesNo, "World settings changed")
					'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.btnSave_Click. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If hndWorld = MsgBoxResult.Yes Then frmWorldSettings.btnSave_Click()
				End If
				EndGame(hndWorld)
				' load saved world
				Me.dlgFileOpen.Title = "Open World"
				Me.dlgFileSave.Title = "Open World"
				Me.dlgFileOpen.FileName = gAppPath & "\Roster\*.ini"
				Me.dlgFileSave.FileName = gAppPath & "\Roster\*.ini"
				'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
				Me.dlgFile.CancelError = True
				'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				Me.dlgFileOpen.Filter = "World settings (*.ini)|*.ini|All Files (*.*)|*.*"
				Me.dlgFileSave.Filter = "World settings (*.ini)|*.ini|All Files (*.*)|*.*"
				Me.dlgFileOpen.FilterIndex = 1
				Me.dlgFileSave.FilterIndex = 1
				'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
				'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
				Me.dlgFileOpen.CheckFileExists = True
				Me.dlgFileOpen.CheckPathExists = True
				Me.dlgFileSave.CheckPathExists = True
				'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
				'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
				Me.dlgFileOpen.ShowReadOnly = False
				Me.dlgFileOpen.RestoreDirectory = False
				Me.dlgFileSave.RestoreDirectory = False
				Me.dlgFileOpen.ShowDialog()
				Me.dlgFileSave.FileName = Me.dlgFileOpen.FileName
				'UPGRADE_NOTE: Object WorldNow may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
				WorldNow = Nothing
				WorldNow = New World
				strTomePath = Me.dlgFileOpen.FileName
			Else
				hndWorld = MsgBox("This will close your current tome.", MsgBoxStyle.YesNo, "Tome already open...")
				'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strTomePath = Tome.LoadPath
				If hndWorld = MsgBoxResult.No Then
					Exit Sub
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Dirty. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.btnQuit_Click. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If .Dirty Then .btnQuit_Click()
					EndGame(hndWorld)
				End If
			End If
			' work on the current world settings
			'UPGRADE_ISSUE: Unload frmWorldSettings was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="875EBAD7-D704-4539-9969-BC7DBDAA62A2"'
			Unload(frmWorldSettings)
			' get the path
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WorldNow.Name = VB.Left(strTomePath, InStrRev(strTomePath, "\") - 1)
			' the last folder now is the world name
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WorldNow.Name = VB.Right(WorldNow.Name, Len(WorldNow.Name) - InStrRev(WorldNow.Name, "\"))
			' get world general info
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FileName = gAppPath & "\roster\" & WorldNow.Name & "\" & WorldNow.Name & ".ini"
			'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lResult = fReadValue(FileName, "World", "Name", "S", "", Text_Renamed)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtWorldName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.txtWorldName = Text_Renamed
			'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lResult = fReadValue(FileName, "World", "PictureFile", "S", "", Text_Renamed)
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.PictureFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WorldNow.PictureFile = Text_Renamed
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.PictureFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If oFileSys.CheckExists(gAppPath & "\Roster\" & WorldNow.Name & "\" & WorldNow.PictureFile, File) = False Then
				' [Titi 2.4.9] not found - either deleted or renamed - anyway default to blank map!
				'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtWorldMap. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.txtWorldMap = gDataPath & "\Stock\blankmap.bmp"
				'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.PictureFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MsgBox(WorldNow.PictureFile & " not found! Defaulting to blank map...", MsgBoxStyle.Critical, "World map not found!")
			End If
			'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lResult = fReadValue(FileName, "World", "Kingdoms", "S", "", Text_Renamed)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtNumberKingdoms. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.txtNumberKingdoms = Text_Renamed
			'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lResult = fReadValue(FileName, "World", "Intro", "S", "", Text_Renamed)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtIntroMusic. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.txtIntroMusic = Text_Renamed
			'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lResult = fReadValue(FileName, "World", "MusicFolder", "S", "", Text_Renamed)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtMusicFolder. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.txtMusicFolder = Text_Renamed
			' [Titi 2.4.9b] added to allow a world specific magic system (not necessarily based on runes)
			'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lResult = fReadValue(FileName, "World", "Magic", "S", "Eternium", Text_Renamed)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtMagicName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.txtMagicName = Text_Renamed
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Magic. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WorldNow.Magic = Text_Renamed
			'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lResult = fReadValue(FileName, "World", "Runes", "S", "0", Text_Renamed)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.chkRunes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.chkRunes = Val(Text_Renamed)
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Runes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.chkRunes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WorldNow.Runes = .chkRunes
			'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lResult = fReadValue(FileName, "World", "Formula", "S", "4 x Will", Text_Renamed)
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Formula. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WorldNow.Formula = Text_Renamed
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.lblFormulaBasis. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.lblFormulaBasis = Mid(Text_Renamed, 3)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtCoef. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.txtCoef = Val(Text_Renamed)
			Text_Renamed = VB.Right(Text_Renamed, Len(Text_Renamed) - InStrRev(Text_Renamed, " "))
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.cmbMagicBasis. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			For hndWorld = 0 To .cmbMagicBasis.ListCount
				'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.cmbMagicBasis. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If .cmbMagicBasis.List(hndWorld) = Text_Renamed Then .cmbMagicBasis.ListIndex = hndWorld
			Next 
			'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lResult = fReadValue(FileName, "World", "MagicPerLevel", "S", "10", Text_Renamed)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtMagicPerLevel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.txtMagicPerLevel = Text_Renamed
			'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lResult = fReadValue(FileName, "World", "RandomizeMagic", "S", "0", Text_Renamed)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.chkMagicPerLevel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.chkMagicPerLevel.Value = CShort(Val(Text_Renamed))
			' [Titi 2.4.8] added to allow to change the money
			'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lResult = fReadValue(FileName, "World", "Currency", "S", "Gold piece|gold1.bmp", Text_Renamed)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtMoney. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.txtMoney(0) = VB.Left(Text_Renamed, InStr(Text_Renamed, "|") - 1)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtMoney. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.txtMoney(1) = VB.Right(Text_Renamed, Len(Text_Renamed) - InStr(Text_Renamed, "|"))
			' [Titi 2.4.9] added to allow different HP and skillpoints value per world
			'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lResult = fReadValue(FileName, "World", "SkillPtsPerLevel", "S", "10", Text_Renamed)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtSkillPtsPerLevel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.txtSkillPtsPerLevel = Text_Renamed
			'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lResult = fReadValue(FileName, "World", "HPPerLevel", "S", "10", Text_Renamed)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtHPperLevel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.txtHPperLevel = Text_Renamed
			'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lResult = fReadValue(FileName, "World", "RandomizeHP", "S", "0", Text_Renamed)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.chkRandHP. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.chkRandHP.Value = CShort(Val(Text_Renamed))
			' [Titi 2.6.0] special interface selection
			'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lResult = fReadValue(FileName, "World", "InterfaceName", "S", "WoodWeave", Text_Renamed)
			strInterfaceName = Text_Renamed
			' [Titi 2.4.9] added to allow to display a summary of the world in the options page
			'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lResult = fReadValue(FileName, "World", "DescriptionLines", "S", "1", Text_Renamed)
			For intKingdoms = 1 To Val(Text_Renamed)
				'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lResult = fReadValue(FileName, "World", "Description" & Trim(Str(intKingdoms)), "S", "No description available.", Text_Renamed)
				'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Description. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				WorldNow.Description = WorldNow.Description & IIf(intKingdoms > 1, Chr(32), vbNullString) & Text_Renamed
			Next 
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Description. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Text_Renamed = WorldNow.Description
			For intKingdoms = 1 To Len(Text_Renamed)
				If Mid(Text_Renamed, intKingdoms, 1) = "_" Then Text_Renamed = VB.Left(Text_Renamed, intKingdoms - 1) & Chr(13) & Mid(Text_Renamed, intKingdoms + 1)
			Next 
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Description. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WorldNow.Description = Text_Renamed
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtWorldDesc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.txtWorldDesc = "" 'Text
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Description. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			For hndWorld = 1 To Len(WorldNow.Description)
				'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Description. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Mid(WorldNow.Description, hndWorld, 1) = "_" Then
					'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Description. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Text_Renamed = VB.Left(WorldNow.Description, hndWorld - 1) & Chr(13) & Mid(WorldNow.Description, hndWorld + 1)
					System.Windows.Forms.SendKeys.Send(("{enter}")) ' just putting chr$(13) in the string won't work
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Description. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Text_Renamed = Mid(WorldNow.Description, hndWorld, 1)
					If Text_Renamed = "(" Or Text_Renamed = ")" Or Text_Renamed = "+" Or Text_Renamed = "^" Or Text_Renamed = "%" Or Text_Renamed = "[" Or Text_Renamed = "]" Then Text_Renamed = "{" & Text_Renamed & "}"
					System.Windows.Forms.SendKeys.Send((Text_Renamed))
				End If
			Next 
			'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lResult = fReadValue(FileName, "World", "PicDesc", "S", "", Text_Renamed)
			If Text_Renamed = "" Then
				Text_Renamed = gDataPath & "\Stock\blankmap.bmp|" & gDataPath & "\Stock\blankmap.bmp" ' for compatibility with 2.4.7
			ElseIf InStr(Text_Renamed, "|") = 0 Then 
				Text_Renamed = Text_Renamed & "|" & gDataPath & "\Stock\blankmap.bmp"
			End If
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtPicDescName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.txtPicDescName(0) = VB.Left(Text_Renamed, InStr(Text_Renamed, "|") - 1)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtPicDescName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.txtPicDescName(1) = VB.Right(Text_Renamed, Len(Text_Renamed) - InStr(Text_Renamed, "|"))
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.PicDesc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WorldNow.PicDesc = Text_Renamed
			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtNumberKingdoms. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			intKingdoms = Val(.txtNumberKingdoms)
			hndWorld = 0
			' open world settings tome
			hndWorld = FreeFile
			'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lResult = fReadValue(FileName, "World", "Tome", "S", "", Text_Renamed)
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.FileName = Text_Renamed
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.LoadPath = gAppPath & "\Roster\" & WorldNow.Name
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FullPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.FullPath = Tome.LoadPath
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FileOpen(hndWorld, Tome.LoadPath & "\" & Tome.FileName, OpenMode.Binary)
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.ReadFromFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.ReadFromFile(hndWorld)
			FileClose(hndWorld)
			' Show Tome
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ShowTome(Tome)
			ShowMsg("")
			' [Titi 2.4.9b] New abilities (stats) added
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.NewAbilities. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.NewAbilities()
			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
			ReDim Preserve strKingdomNames(intKingdoms)
			ReDim Preserve strKingdomSet(intKingdoms)
			ReDim Preserve strKingdomTemplate(intKingdoms)
			ReDim Preserve strKingdomLocation(intKingdoms)
			ReDim Preserve strKingdomPictures(intKingdoms * 2) ' Titi 2.5.1 double size for male and female pictures
			' create as many tabs as kingdoms
			For hndWorld = 1 To intKingdoms
				'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.AddKingdom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				WorldNow.AddKingdom()
				If hndWorld > 1 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.TabStrip1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					.TabStrip1.Tabs.Add(hndWorld)
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.PopulateWorldSettings. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				frmWorldSettings.PopulateWorldSettings(hndWorld, True, False, intKingdoms)
				'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.TabStrip1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.TabStrip1.Tabs(hndWorld).Caption = strKingdomNames(hndWorld)
			Next 
			' [Titi 2.4.9b] now, add the tab for magic and alternative stats
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.TabStrip1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.TabStrip1.Tabs.Add(hndWorld)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Show()
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.TabStrip1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtWorldName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.TabStrip1.Tabs(hndWorld).Caption = .txtWorldName & " Magic and Stats"
			' [Titi 2.4.9] now, add the tab for comments
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.TabStrip1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.TabStrip1.Tabs.Add(hndWorld + 1)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Show()
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.TabStrip1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtWorldName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.TabStrip1.Tabs(hndWorld + 1).Caption = .txtWorldName & " comments"
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Dirty. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Dirty = False
			' now, add the general view of the world
			'        hndWorld = intKingdoms + 2
			hndWorld = intKingdoms + 3 ' Titi 2.4.9b
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.TabStrip1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.TabStrip1.Tabs.Add(hndWorld)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Show()
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.TabStrip1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtWorldName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.TabStrip1.Tabs(hndWorld).Caption = "Map of " & .txtWorldName
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.TabStrip1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.TabStrip1.Tabs(hndWorld).Selected = True
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Refresh()
		End With
		Exit Sub
ErrorHandler: 
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		If Err.Number = DialogResult.Cancel Then
			Exit Sub
		ElseIf Err.Number = 76 Then 
			' file not found because we're trying to modify a world whereas we were already working on one
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Dirty. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmWorldSettings.Dirty = False
			'UPGRADE_ISSUE: Unload frmWorldSettings was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="875EBAD7-D704-4539-9969-BC7DBDAA62A2"'
			Unload(frmWorldSettings)
			mnuOptionsWorldSettingsLoad_Click(mnuOptionsWorldSettingsLoad, New System.EventArgs())
			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
			Exit Sub
		Else
			' other error
			'UPGRADE_WARNING: Couldn't resolve default property of object oErr.logError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			oErr.logError("Unable to load world settings: error #" & Err.Number)
			'UPGRADE_WARNING: Couldn't resolve default property of object oErr.LogText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			oErr.LogText("Tried to load " & strTomePath)
		End If
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub mnuOptionsWorldSettingsCreate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuOptionsWorldSettingsCreate.Click
		Dim Tome_Renamed As Object
		Dim frmWorldSettings As Object
		' [Titi] Added for 2.4.7
		'UPGRADE_NOTE: Text was upgraded to Text_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim FileName, Text_Renamed As String
		Dim lResult As Integer
		Dim hndWorld As Short
		With frmWorldSettings
			' check if tome already open
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Dirty. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Dirty = IIf(.Dirty = True, True, Dirty)
			If Dirty Then
				hndWorld = MsgBox("This will close your current tome.", MsgBoxStyle.YesNo, "Tome already open...")
				If hndWorld = MsgBoxResult.No Then
					Exit Sub
				Else
					EndGame(hndWorld)
				End If
			End If
			' create new world
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Dirty. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Dirty = False
			'UPGRADE_ISSUE: Unload frmWorldSettings was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="875EBAD7-D704-4539-9969-BC7DBDAA62A2"'
			Unload(frmWorldSettings)
			frmProject.tvwProject.Nodes.Clear()
			'UPGRADE_NOTE: Object frmProject.AreaList may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			frmProject.AreaList = Nothing
			'UPGRADE_NOTE: Object Tome may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			Tome = Nothing
			Tome = New Tome
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.AddArea. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.AddArea()
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Areas. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.Areas(1).Plot.AddMap()
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Areas. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tome.Areas(1).Plot.Maps(1).AddEntryPoint()
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Areas. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			OpenArea(Tome.Areas(1))
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ShowTome(Tome)
			ShowMsg("")
			'UPGRADE_NOTE: Object WorldNow may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			WorldNow = Nothing
			WorldNow = New World
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.mnuAdd_Click. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.mnuAdd_Click() ' create first kingdom
			' [Titi 2.4.9b] add tab for magic and stats
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.TabStrip1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.TabStrip1.Tabs.Add(.TabStrip1.Tabs.Count)
			' [Titi 2.4.9] add tab for comments
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.TabStrip1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.TabStrip1.Tabs.Add(.TabStrip1.Tabs.Count)
			'        .txtWorldMap = gAppPath & "\Data\Stock\blankmap.bmp"
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtWorldMap. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.txtWorldMap = gDataPath & "\Stock\blankmap.bmp"
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtPicDescName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtWorldMap. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.txtPicDescName(0) = .txtWorldMap
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtPicDescName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtWorldMap. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.txtPicDescName(1) = .txtWorldMap
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.PicDesc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtPicDescName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WorldNow.PicDesc = .txtPicDescName(0) & "|" & .txtPicDescName(1)
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Description. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WorldNow.Description = "No description available."
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtWorldMap. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.picKingdom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.picKingdom = System.Drawing.Image.FromFile(.txtWorldMap)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtWorldName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.txtWorldName = "New world"
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.PictureFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WorldNow.PictureFile = "blankmap.bmp"
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.SkillPtsPerLevel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WorldNow.SkillPtsPerLevel = 10
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.HPPerLevel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WorldNow.HPPerLevel = 10
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.RandomizeHP. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WorldNow.RandomizeHP = False
			'[Titi 2.4.9b] customize magic system
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Magic. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WorldNow.Magic = "Eternium"
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Formula. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WorldNow.Formula = "4 x Will"
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.chkRunes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.chkRunes.Value = 1
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.MagicPerLevel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WorldNow.MagicPerLevel = 10
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.RandomizeMagic. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WorldNow.RandomizeMagic = False
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.TabStrip1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			hndWorld = .TabStrip1.Tabs.Count
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtNumberKingdoms. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.txtNumberKingdoms = "1"
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Show()
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.TabStrip1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.txtWorldName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.TabStrip1.Tabs(hndWorld).Caption = .txtWorldName
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.TabStrip1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.TabStrip1.Tabs(hndWorld - 1).Caption = "Comments"
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.TabStrip1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.TabStrip1.Tabs(hndWorld - 2).Caption = "Magic and Statistics"
			Dirty = False
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Dirty. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Dirty = False
			' [Titi 2.6.0] add preferred interface
			strInterfaceName = "WoodWeave"
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.TabStrip1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.TabStrip1.Tabs(hndWorld).Selected = True
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Refresh()
		End With
	End Sub
	
	Public Sub mnuOptionUnpackDataFiles_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuOptionUnpackDataFiles.Click
		Dim InstallPackage As Object
		Dim oErr As Object
		Dim strName, sTome As String
		Dim c, Found As Short
		Dim TomeList As Collection
		Dim i As Short
		Dim TomeX As Tome
		On Error Resume Next
		Me.dlgFileOpen.Title = "Install tome/world"
		Me.dlgFileSave.Title = "Install tome/world"
		Me.dlgFileOpen.FileName = gAppPath & "\*.rsp"
		Me.dlgFileSave.FileName = gAppPath & "\*.rsp"
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		Me.dlgFile.CancelError = True
		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		Me.dlgFileOpen.Filter = "Runesword package (*.rsp)|*.rsp|All Files (*.*)|*.*"
		Me.dlgFileSave.Filter = "Runesword package (*.rsp)|*.rsp|All Files (*.*)|*.*"
		Me.dlgFileOpen.FilterIndex = 1
		Me.dlgFileSave.FilterIndex = 1
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		Me.dlgFileOpen.CheckFileExists = True
		Me.dlgFileOpen.CheckPathExists = True
		Me.dlgFileSave.CheckPathExists = True
		'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		Me.dlgFileOpen.ShowReadOnly = False
		Me.dlgFileOpen.RestoreDirectory = False
		Me.dlgFileSave.RestoreDirectory = False
		Me.dlgFileOpen.ShowDialog()
		Me.dlgFileSave.FileName = Me.dlgFileOpen.FileName
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		If Err.Number = DialogResult.Cancel Then
			Exit Sub
		End If
		strName = Me.dlgFileOpen.FileName
		'UPGRADE_WARNING: Couldn't resolve default property of object InstallPackage(strName). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If InstallPackage(strName) = 0 Then
			MsgBox("Unable to install " & strName & ".", MsgBoxStyle.Critical, "Package error!")
		Else
			If MsgBox(strName & " has been successfully installed." & vbCrLf & "Do you wish to load it now?", MsgBoxStyle.YesNo, "The multiverse is expanding!") = MsgBoxResult.Yes Then
				' strName = gAppPath & "\Tomes\" & Mid$(strName, InStrRev(strName, "\") + 1)
				strName = Mid(strName, InStrRev(strName, "\") + 1)
				strName = VB.Left(strName, Len(strName) - 4)
				strName = Replace(strName, "_", " ")
				' strName now contains the name of the tome
				TomeList = New Collection
				SearchFolders("*.tom", gAppPath & "\Tomes", TomeList)
				For c = 1 To TomeList.Count()
					TomeX = New Tome
					i = FreeFile
					'UPGRADE_WARNING: Couldn't resolve default property of object TomeList(c).Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					FileOpen(i, TomeList.Item(c).Text, OpenMode.Binary)
					TomeX.ReadFromFileHeader(i)
					If TomeX.Name = vbNullString Then
						'UPGRADE_WARNING: Couldn't resolve default property of object TomeList().Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object oErr.logError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						oErr.logError(TomeList.Item(c).Text & " is not a valid tome.")
					End If
					FileClose(i)
					If TomeX.Name = strName Then
						Found = Found + 1
						'UPGRADE_WARNING: Couldn't resolve default property of object TomeList().Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						sTome = TomeList.Item(c).Text
					End If
				Next 
				If Found = 1 Then
					OpenTome(sTome)
				Else
					MsgBox(Found & " tomes are named " & strName & ".", MsgBoxStyle.OKOnly)
				End If
			End If
		End If
	End Sub
	
	Public Sub mnuRecent_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuRecent.Click
		Dim Index As Short = mnuRecent.GetIndex(eventSender)
		'On Error GoTo ErrorHandler ' [Titi 2.4.9] added verification in case of deleted, renamed or moved tomes
		'    Dim c As Integer , lResult As Long
		'    Dim sFile As String, Text As String
		'    c = FreeFile
		'    Set Tome = New Tome
		'    sFile = mnuRecent(Index).Caption
		Call OpenTome(mnuRecent(Index).Text, Index) ' [Titi 2.4.9b] why rewrite something already existing?
		''    Tome.FileName = Right$(sFile, InStrRev(sFile, "\") + 1)
		'    Tome.FileName = Right$(sFile, Len(sFile) - InStrRev(sFile, "\")) ' [Titi 2.4.9] the above is wrong
		'    Tome.LoadPath = ClipPath(sFile)
		'    Tome.FullPath = Tome.LoadPath
		'    Open oFileSys.ShortPath(sFile) For Binary As c
		'    Tome.ReadFromFile c
		'    Close #c
		'    ShowTome Tome
		''    LoadTomeTV Tome
		'    Exit Sub
		'ErrorHandler:
		'    If Err.Number = 75 Then ' tome probably renamed, moved or deleted
		'        MsgBox "Error! Cannot find " & Tome.FileName, , "File not found."
		'        aMostRecent(5) = vbNullString
		'        For c = Index To 4
		'            aMostRecent(c) = aMostRecent(c + 1)
		'        Next
		'        Call SaveSystemSettings
		'        Call LoadSystemSettings
		'    Else
		'        oErr.logError "mnuRecent_Click: " & Err.Description & " (" & Err.Number & ")"
		'    End If
	End Sub
	
	Public Sub mnuSearchClearBuffer_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSearchClearBuffer.Click
		CopyBufferSet = New Collection
		CopyBufferTags = New Collection
		If frmSearch.Visible = True Then
			frmSearch.ReplaceList()
		End If
	End Sub
	
	Public Sub mnuSearchFind_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSearchFind.Click
		frmSearch.ReplaceList()
		frmSearch.Show()
	End Sub
	
	Public Sub mnuSearchFindNext_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSearchFindNext.Click
		frmSearch.FindNext(False)
		frmSearch.Show()
	End Sub
	
	'UPGRADE_NOTE: Text was upgraded to Text_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Function SearchInsideNode(ByRef NodeX As ComctlLib.Node, ByRef ObjectX As Object, ByRef ext As String, Optional ByRef ObjectType As Short = 0, Optional ByRef Text_Renamed As String = "") As Boolean
		Dim frmList As Object
		Dim StmtX As Statement
		Dim EncounterX As Encounter
		Dim intNbFound, intLineNumber As Short
		intNbFound = 0
		intLineNumber = 0
		Select Case ParseTag((NodeX.Tag))
			' .bmp can be found in creatures, items, encounters (wallpapers), triggers (for cutscenes) and maps
			Case bdEditMapEncounters
				If UCase(ext) = "BMP" Or UCase(ext) = "ALL" Then
					' does this encounter use a particular wallpaper?
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Encounters. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For	Each EncounterX In ObjectX.Encounters
						If EncounterX.Wallpaper <> "" Then
							If ObjectType <> bdEditData Then
								'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
								frmList.lstList.AddItem(EncounterX.Wallpaper)
							Else
								SearchInsideNode = (UCase(VB.Left(EncounterX.Wallpaper, Len(EncounterX.Wallpaper) - 4)) Like Text_Renamed)
								If SearchInsideNode Then intNbFound = intNbFound + 1
							End If
						End If
					Next EncounterX
				End If
			Case bdEditMap
				If UCase(ext) = "BMP" Or UCase(ext) = "ALL" Then
					' get the tileset name
					If ObjectType <> bdEditData Then
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.PictureFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						frmList.lstList.AddItem(ObjectX.PictureFile)
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.PictureFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						SearchInsideNode = (UCase(VB.Left(ObjectX.PictureFile, Len(ObjectX.PictureFile) - 4)) Like Text_Renamed)
						If SearchInsideNode Then intNbFound = intNbFound + 1
					End If
				End If
			Case bdEditItem
				If UCase(ext) = "BMP" Or UCase(ext) = "ALL" Then
					' find the item picture
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.PictureFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If ObjectX.PictureFile <> "" Then
						If ObjectType <> bdEditData Then
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.PictureFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							frmList.lstList.AddItem(ObjectX.PictureFile)
						Else
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.PictureFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							SearchInsideNode = (UCase(VB.Left(ObjectX.PictureFile, Len(ObjectX.PictureFile) - 4)) Like Text_Renamed)
							If SearchInsideNode Then intNbFound = intNbFound + 1
						End If
					End If
				End If
			Case bdEditCreature ', bdEditMapCreatures
				If UCase(ext) = "BMP" Or UCase(ext) = "ALL" Then
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.PictureFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If ObjectX.PictureFile <> "" Then
						If ObjectType <> bdEditData Then
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.PictureFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							frmList.lstList.AddItem(ObjectX.PictureFile)
						Else
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.PictureFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							SearchInsideNode = (UCase(VB.Left(ObjectX.PictureFile, Len(ObjectX.PictureFile) - 4)) Like Text_Renamed)
							If SearchInsideNode Then intNbFound = intNbFound + 1
						End If
					End If
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.PortraitFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If ObjectX.PortraitFile <> "" Then
						If ObjectType <> bdEditData Then
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.PortraitFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							frmList.lstList.AddItem(ObjectX.PortraitFile)
						Else
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.PortraitFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							SearchInsideNode = (UCase(VB.Left(ObjectX.PortraitFile, Len(ObjectX.PortraitFile) - 4)) Like Text_Renamed)
							If SearchInsideNode Then intNbFound = intNbFound + 1
						End If
					End If
				End If
				If UCase(ext) = "WAV" Or UCase(ext) = "ALL" Then
					' sounds attached to the creature
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.MoveWAV. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If ObjectX.MoveWAV <> "" Then
						If ObjectType <> bdEditData Then
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.MoveWAV. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							frmList.lstList.AddItem(ObjectX.MoveWAV)
						Else
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.MoveWAV. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							SearchInsideNode = (UCase(VB.Left(ObjectX.MoveWAV, Len(ObjectX.MoveWAV) - 4)) Like Text_Renamed)
							If SearchInsideNode Then intNbFound = intNbFound + 1
						End If
					End If
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AttackWAV. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If ObjectX.AttackWAV <> "" Then
						If ObjectType <> bdEditData Then
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AttackWAV. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							frmList.lstList.AddItem(ObjectX.AttackWAV)
						Else
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AttackWAV. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							SearchInsideNode = (UCase(VB.Left(ObjectX.AttackWAV, Len(ObjectX.AttackWAV) - 4)) Like Text_Renamed)
							If SearchInsideNode Then intNbFound = intNbFound + 1
						End If
					End If
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.HitWAV. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If ObjectX.HitWAV <> "" Then
						If ObjectType <> bdEditData Then
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.HitWAV. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							frmList.lstList.AddItem(ObjectX.HitWAV)
						Else
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.HitWAV. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							SearchInsideNode = (UCase(VB.Left(ObjectX.HitWAV, Len(ObjectX.HitWAV) - 4)) Like Text_Renamed)
							If SearchInsideNode Then intNbFound = intNbFound + 1
						End If
					End If
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.DieWAV. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If ObjectX.DieWAV <> "" Then
						If ObjectType <> bdEditData Then
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.DieWAV. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							frmList.lstList.AddItem(ObjectX.DieWAV)
						Else
							'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.DieWAV. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							SearchInsideNode = (UCase(VB.Left(ObjectX.DieWAV, Len(ObjectX.DieWAV) - 4)) Like Text_Renamed)
							If SearchInsideNode Then intNbFound = intNbFound + 1
						End If
					End If
				End If
			Case bdEditTrigger
				If UCase(ext) = "BMP" Or UCase(ext) = "ALL" Then
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Statements. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For	Each StmtX In ObjectX.Statements
						' [Titi 2.4.8] get the line number where the text we're looking for appears in the trigger
						With StmtX
							intLineNumber = intLineNumber + 1
							If .Statement = 41 Then
								' find the cutscene statements
								If BreakText(TextQuote(.Text), 2) <> "" Then
									If ObjectType <> bdEditData Then
										'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
										frmList.lstList.AddItem(BreakText(TextQuote(.Text), 2))
									Else
										SearchInsideNode = (UCase(VB.Left(BreakText(TextQuote(.Text), 2), Len(BreakText(TextQuote(.Text), 2)) - 4)) Like Text_Renamed)
										If SearchInsideNode Then
											intNbFound = intNbFound + 1
											intSearchLine = intLineNumber
											intPosInSearchLine = 9
										End If
									End If
								End If
							ElseIf .Statement = 46 Then 
								' find the PlaySFX statements
								If TextQuote(.Text) <> "" Then
									If ObjectType <> bdEditData Then
										'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
										frmList.lstList.AddItem(TextQuote(.Text))
									Else
										SearchInsideNode = (UCase(VB.Left(TextQuote(.Text), Len(TextQuote(.Text)) - 4)) Like Text_Renamed)
										If SearchInsideNode Then
											intNbFound = intNbFound + 1
											intSearchLine = intLineNumber
											intPosInSearchLine = 8
										End If
									End If
								End If
							ElseIf .Statement = 22 Then 
								' find the CopyText statements (CopyText could be used like CopyText "Hyena_t1.bmp" Into CreatureNow.PictureFile)
								If UCase(VB.Right(TextQuote(.Text), 3)) = "BMP" Then
									If ObjectType <> bdEditData Then
										'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
										frmList.lstList.AddItem(TextQuote(.Text))
									Else
										SearchInsideNode = (UCase(VB.Left(TextQuote(.Text), Len(TextQuote(.Text)) - 4)) Like Text_Renamed)
										If SearchInsideNode Then
											intNbFound = intNbFound + 1
											intSearchLine = intLineNumber
											intPosInSearchLine = 9
										End If
									End If
								End If
							ElseIf .Statement = 72 Or .Statement = 73 Then 
								' find the CombatAnimation and MapAnimation statements
								If TextQuote(.Text) <> "" Then
									If ObjectType <> bdEditData Then
										'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
										frmList.lstList.AddItem(TextQuote(.Text))
									Else
										SearchInsideNode = (UCase(VB.Left(BreakText(TextQuote(.Text), 1), Len(BreakText(TextQuote(.Text), 1)) - 4)) Like Text_Renamed)
										If SearchInsideNode Then
											intNbFound = intNbFound + 1
											intSearchLine = intLineNumber
											intPosInSearchLine = 13 + 3 * CShort(.Statement = 72)
										End If
									End If
								End If
							End If
						End With
					Next StmtX
				End If
				intLineNumber = 0
				If UCase(ext) = "WAV" Or UCase(ext) = "MID" Or UCase(ext) = "ALL" Then
					' need to find the Play something statements
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Statements. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For	Each StmtX In ObjectX.Statements
						intLineNumber = intLineNumber + 1
						With StmtX
							If .Statement = 33 Or .Statement = 34 Then
								' statement is  a PlaySound or PlayMusic
								If TextQuote(.Text) <> "" Then
									If ObjectType <> bdEditData Then
										'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
										frmList.lstList.AddItem(TextQuote(.Text))
									Else
										SearchInsideNode = (UCase(VB.Left(TextQuote(.Text), Len(TextQuote(.Text)) - 4)) Like Text_Renamed)
										If SearchInsideNode Then
											intNbFound = intNbFound + 1
											intSearchLine = intLineNumber
											intPosInSearchLine = 11
										End If
									End If
								End If
							End If
						End With
					Next StmtX
				End If
				If UCase(ext) = "AVI" Or UCase(ext) = "ALL" Then
					' need to find the PlayVideo statements
					'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.Statements. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For	Each StmtX In ObjectX.Statements
						With StmtX
							If .Statement = 69 Then
								If TextQuote(.Text) <> "" Then
									If ObjectType <> bdEditData Then
										'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
										frmList.lstList.AddItem(TextQuote(.Text))
									Else
										SearchInsideNode = (UCase(VB.Left(TextQuote(.Text), Len(TextQuote(.Text)) - 4)) Like Text_Renamed)
										If SearchInsideNode Then
											intNbFound = intNbFound + 1
											intSearchLine = intLineNumber
											intPosInSearchLine = 11
										End If
									End If
								End If
							End If
						End With
					Next StmtX
				End If
		End Select
		SearchInsideNode = (intNbFound > 0)
	End Function
	
	'Private Sub LookInTome(ext As String) ' [Titi 2.5.1] Optimized the FindFile sub
	'' [Titi] 2.4.6
	'    Dim CreatureX As Creature, TriggerX As Trigger, ItemX As Item
	'    For Each TriggerX In Tome.Triggers
	'        SearchSubTriggers TriggerX, ext
	'    Next TriggerX
	'    If UCase$(ext) = "WAV" Or UCase$(ext) = "ALL" Then
	'        For Each CreatureX In Tome.Creatures
	'            If CreatureX.MoveWAV <> "" Then
	'                frmList.lstList.AddItem CreatureX.MoveWAV
	'                frmList.lstList.Refresh
	'            End If
	'            If CreatureX.AttackWAV <> "" Then
	'                frmList.lstList.AddItem CreatureX.AttackWAV
	'                frmList.lstList.Refresh
	'            End If
	'            If CreatureX.HitWAV <> "" Then
	'                frmList.lstList.AddItem CreatureX.HitWAV
	'                frmList.lstList.Refresh
	'            End If
	'            If CreatureX.DieWAV <> "" Then
	'                frmList.lstList.AddItem CreatureX.DieWAV
	'                frmList.lstList.Refresh
	'            End If
	'            For Each ItemX In CreatureX.Items
	'                For Each TriggerX In ItemX.Triggers
	'                    SearchSubTriggers TriggerX, ext
	'                Next TriggerX
	'            Next ItemX
	'        Next CreatureX
	'    End If
	'    If UCase$(ext) = "BMP" Or UCase$(ext) = "ALL" Then
	'        For Each CreatureX In Tome.Creatures
	'            If CreatureX.PictureFile <> "" Then frmList.lstList.AddItem CreatureX.PictureFile
	'            If CreatureX.PortraitFile <> "" Then frmList.lstList.AddItem CreatureX.PortraitFile
	'            For Each ItemX In CreatureX.Items
	'                For Each TriggerX In ItemX.Triggers
	'                    SearchSubTriggers TriggerX, ext
	'                Next TriggerX
	'                If ItemX.PictureFile <> "" Then frmList.lstList.AddItem ItemX.PictureFile
	'            Next ItemX
	'            For Each TriggerX In CreatureX.Triggers
	'                SearchSubTriggers TriggerX, ext
	'            Next TriggerX
	'        Next CreatureX
	'   End If
	'End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub FindFile(ByRef ext As String)
		Dim Tome_Renamed As Object
		Dim frmList As Object
		' [Titi] Added 2.4.6
		Dim c, i As Short
		Dim NodeX As ComctlLib.Node
		Dim strFormCaption, strProgress As String
		Dim CreatureX As Creature
		Dim TriggerX As Trigger
		Dim TileSetX As TileSet
		Dim EncounterX As Encounter
		Dim ItemX As Item
		Dim MapX As Map
		Dim AreaX As Area
		Dim intArea As Short
		Dim ObjectX As Object
		Dim StmtX As Statement
		If UCase(ext) = "ALL" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmList.Caption = "List of all additional files"
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmList.Caption = "List of additional ." & ext & " files"
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		strFormCaption = frmList.Caption
		' first, search the tome triggers and the provided party members
		' LookInTome [Titi 2.5.1] better results with tvwTome!
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		strProgress = "Processing " & Tome.Name & ": "
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ShowTome(Tome, True) ' this updates ObjectListX
		For i = 1 To TreeViewX.Nodes.Count
			'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmList.Caption = strProgress & i & "/" & TreeViewX.Nodes.Count & " completed..."
			'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmList.Refresh()
			NodeX = TreeViewX.Nodes(i)
			ObjectX = ObjectListX.Item(NodeX.Tag)
			SearchInsideNode(NodeX, ObjectX, ext)
		Next i
		' Now, search the areas
		' save current area
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Areas. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		For	Each AreaX In Tome.Areas
			If AreaX.IsLoaded Then intArea = AreaX.Index
		Next AreaX
		' search through every area
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Areas. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		For	Each AreaX In Tome.Areas
			strProgress = "Processing " & AreaX.Name & ": "
			'        If AreaX.IsLoaded = False Then ' [Titi 2.4.9b] prevented active areas from being included!
			OpenArea(AreaX)
			'        End If
			' Search every node in area
			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
			For i = 1 To TreeViewX.Nodes.Count
				'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				frmList.Caption = strProgress & i & "/" & TreeViewX.Nodes.Count & " completed..."
				'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				frmList.Refresh()
				NodeX = TreeViewX.Nodes(i)
				ObjectX = ObjectListX.Item(NodeX.Tag)
				SearchInsideNode(NodeX, ObjectX, ext)
			Next i
		Next AreaX
		' all nodes searched
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		' return to previous area
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Areas. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		For	Each AreaX In Tome.Areas
			If AreaX.Index = intArea Then OpenArea(AreaX)
		Next AreaX
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		frmList.Caption = strFormCaption
	End Sub
	
	Public Sub mnuSearchListAllData_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSearchListAllData.Click
		Dim frmList As Object
		' [Titi] Added 2.4.6
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		frmList.Show()
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		frmList.lstList.Clear()
		FindFile("all")
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RemoveDuplicate(frmList.lstList)
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CleanList(frmList.lstList)
	End Sub
	
	Public Sub mnuSearchListAvi_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSearchListAvi.Click
		Dim frmList As Object
		' [Titi] Added 2.4.6
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		frmList.Show()
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		frmList.lstList.Clear()
		FindFile("avi")
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RemoveDuplicate(frmList.lstList)
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CleanList(frmList.lstList)
	End Sub
	
	'Private Sub SearchSubTriggers(TriggerY As Trigger, ext As String) '[Titi 2.5.1] Optimized the FindFile sub
	'' [Titi] Added 2.4.6
	'    Dim TriggerX As Trigger, StmtX As Statement
	'    If TriggerY.Triggers.Count > 0 Then
	'        For Each TriggerX In TriggerY.Triggers
	'        ' recursive search
	'            SearchSubTriggers TriggerX, ext
	'        Next TriggerX
	'    Else
	'        For Each StmtX In TriggerY.Statements
	'            With StmtX
	'                If (UCase$(ext) = "BMP" Or UCase$(ext) = "ALL") And .Statement = 41 Then
	'                ' find the cutscene statements
	'                    If BreakText(TextQuote(.Text), 2) <> "" Then frmList.lstList.AddItem BreakText(TextQuote(.Text), 2)
	'                ElseIf (UCase$(ext) = "BMP" Or UCase$(ext) = "ALL") And .Statement = 46 Then
	'                ' find the PlaySFX statements
	'                    If TextQuote(.Text) <> "" Then frmList.lstList.AddItem TextQuote(.Text)
	'                ElseIf (UCase$(ext) = "WAV" Or UCase$(ext) = "ALL") And (.Statement = 33 Or .Statement = 34) Then
	'                ' statement is  a PlaySound or PlayMusic
	'                    If TextQuote(.Text) <> "" Then frmList.lstList.AddItem TextQuote(.Text)
	'                ElseIf (UCase$(ext) = "AVI" Or UCase$(ext) = "ALL") And .Statement = 69 Then ' PlayVideo
	'                    If TextQuote(.Text) <> "" Then frmList.lstList.AddItem TextQuote(.Text)
	'                End If
	'            End With
	'        Next StmtX
	'End Sub
	
	Public Sub mnuSearchListBmp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSearchListBmp.Click
		Dim frmList As Object
		' [Titi] Added 2.4.6
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		frmList.Show()
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		frmList.lstList.Clear()
		FindFile("bmp")
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RemoveDuplicate(frmList.lstList)
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CleanList(frmList.lstList)
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub CheckIfExist(ByRef blnCopy As Boolean, Optional ByRef bPackWorld As Boolean = False)
		Dim oErr As Object
		Dim ExecCmd As Object
		Dim Folder As Object
		Dim oFileSys As Object
		Dim Tome_Renamed As Object
		Dim frmList As Object
		On Error GoTo ErrorHandler
		Dim blnExists, blnCopiedAtLeastOne As Boolean
		Dim confirm As MsgBoxResult
		Dim i, intNbNames, intItemPos, intPercent As Short
		Dim strFound, strFormCaption As String
		Dim strAviFolder, strBmpFolder, strWavFolder, strMidiFolder As String
		Dim shortCmdLine As String
		Dim retval As Integer
		'    If frmList.lstList.ListCount = 0 Then
		'        MsgBox "Sorry, the list is empty!"
		'    Else
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		strFormCaption = frmList.Caption
		'        strBmpFolder = gAppPath & "\data\graphics\"
		'        strWavFolder = gAppPath & "\data\sounds\"
		'        strAviFolder = gAppPath & "\data\video\"
		'        strMidiFolder = gAppPath & "\data\music\"
		strBmpFolder = gDataPath & "\graphics\"
		strWavFolder = gDataPath & "\sounds\"
		strAviFolder = gDataPath & "\video\"
		strMidiFolder = gDataPath & "\music\"
		' [Titi 2.4.9] RT 76 for tomes not previously saved!
		If Tome.LoadPath = "Not Saved" Then
			retval = MsgBox("You need to save the tome first!", MsgBoxStyle.OKCancel, "Tome not saved!")
			If retval = MsgBoxResult.OK Then SaveTomeAs()
			' if tome still not saved, abort
			If Tome.LoadPath = "Not Saved" Then
				MsgBox("Package creation aborted!", MsgBoxStyle.OKOnly, "Tome not saved!")
				Exit Sub
			End If
		End If
		If strRequiredDataFilesTxtFile = "" Then
			' not a saved list
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			strRequiredDataFilesTxtFile = Tome.LoadPath & "\"
		End If
		If blnCopy Then
			'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If oFileSys.CheckExists(strRequiredDataFilesTxtFile & "data\", Folder, True) Then
				'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.Delete. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Call oFileSys.Delete(strRequiredDataFilesTxtFile & "data", Folder, True)
				'                Call oFileSys.Delete(strFound, Folder, True)
			End If
			' create structure
			'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			blnExists = oFileSys.CheckExists(strRequiredDataFilesTxtFile & "data\", Folder, True)
			'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			blnExists = oFileSys.CheckExists(strRequiredDataFilesTxtFile & "data\graphics\", Folder, True)
			'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			blnExists = oFileSys.CheckExists(strRequiredDataFilesTxtFile & "data\graphics\creatures\", Folder, True)
			'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			blnExists = oFileSys.CheckExists(strRequiredDataFilesTxtFile & "data\graphics\cutscenes\", Folder, True)
			'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			blnExists = oFileSys.CheckExists(strRequiredDataFilesTxtFile & "data\graphics\portraits\", Folder, True)
			'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			blnExists = oFileSys.CheckExists(strRequiredDataFilesTxtFile & "data\graphics\items\", Folder, True)
			'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			blnExists = oFileSys.CheckExists(strRequiredDataFilesTxtFile & "data\graphics\tiles\", Folder, True)
			'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			blnExists = oFileSys.CheckExists(strRequiredDataFilesTxtFile & "data\graphics\effects\", Folder, True)
			'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			blnExists = oFileSys.CheckExists(strRequiredDataFilesTxtFile & "data\graphics\wallpapers\", Folder, True)
			'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			blnExists = oFileSys.CheckExists(strRequiredDataFilesTxtFile & "data\graphics\skills\", Folder, True)
			'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			blnExists = oFileSys.CheckExists(strRequiredDataFilesTxtFile & "data\sounds\", Folder, True)
			'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			blnExists = oFileSys.CheckExists(strRequiredDataFilesTxtFile & "data\music\", Folder, True)
			'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			blnExists = oFileSys.CheckExists(strRequiredDataFilesTxtFile & "data\music\adventure\", Folder, True)
			'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			blnExists = oFileSys.CheckExists(strRequiredDataFilesTxtFile & "data\music\combat\", Folder, True)
		End If
		intItemPos = 0
		blnCopiedAtLeastOne = False
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		While intItemPos <= frmList.lstList.ListCount - 1
			blnExists = False
			'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			strFound = UCase(frmList.lstList.List(intItemPos))
			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If UCase(Dir(strRequiredDataFilesTxtFile & strFound)) = strFound Then
				' file exists in the same directory as the tome - no need to copy it there!
				blnExists = True
				' File does not exist. Maybe in the \Data\Graphics subfolders?
				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			ElseIf UCase(Dir(strBmpFolder & "creatures\" & strFound)) = strFound Then 
				If blnCopy Then FileCopy(strBmpFolder & "creatures\" & strFound, strRequiredDataFilesTxtFile & "data\graphics\creatures\" & strFound)
				blnExists = True
				blnCopiedAtLeastOne = True
				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			ElseIf UCase(Dir(strBmpFolder & "portraits\" & strFound)) = strFound Then 
				If blnCopy Then FileCopy(strBmpFolder & "portraits\" & strFound, strRequiredDataFilesTxtFile & "data\graphics\portraits\" & strFound)
				blnExists = True
				blnCopiedAtLeastOne = True
				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			ElseIf UCase(Dir(strBmpFolder & "items\" & strFound)) = strFound Then 
				If blnCopy Then FileCopy(strBmpFolder & "items\" & strFound, strRequiredDataFilesTxtFile & "data\graphics\items\" & strFound)
				blnExists = True
				blnCopiedAtLeastOne = True
				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			ElseIf UCase(Dir(strBmpFolder & "tiles\" & strFound)) = strFound Then 
				If blnCopy Then FileCopy(strBmpFolder & "tiles\" & strFound, strRequiredDataFilesTxtFile & "data\graphics\tiles\" & strFound)
				blnExists = True
				blnCopiedAtLeastOne = True
				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			ElseIf UCase(Dir(strBmpFolder & "effects\" & strFound)) = strFound Then 
				If blnCopy Then FileCopy(strBmpFolder & "effects\" & strFound, strRequiredDataFilesTxtFile & "data\graphics\effects\" & strFound)
				blnExists = True
				blnCopiedAtLeastOne = True
				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			ElseIf UCase(Dir(strBmpFolder & "wallpapers\" & strFound)) = strFound Then 
				If blnCopy Then FileCopy(strBmpFolder & "wallpapers\" & strFound, strRequiredDataFilesTxtFile & "data\graphics\wallpapers\" & strFound)
				blnExists = True
				blnCopiedAtLeastOne = True
				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			ElseIf UCase(Dir(strBmpFolder & "cutscenes\" & strFound)) = strFound Then 
				If blnCopy Then FileCopy(strBmpFolder & "cutscenes\" & strFound, strRequiredDataFilesTxtFile & "data\graphics\cutscenes\" & strFound)
				blnExists = True
				blnCopiedAtLeastOne = True
				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			ElseIf UCase(Dir(strBmpFolder & "skills\" & strFound)) = strFound Then 
				If blnCopy Then FileCopy(strBmpFolder & "skills\" & strFound, strRequiredDataFilesTxtFile & "data\graphics\skills\" & strFound)
				blnExists = True
				blnCopiedAtLeastOne = True
				' or maybe it's a sound?
				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			ElseIf UCase(Dir(strWavFolder & strFound)) = strFound Then 
				If blnCopy Then FileCopy(strWavFolder & strFound, strRequiredDataFilesTxtFile & "data\sounds\" & strFound)
				blnExists = True
				blnCopiedAtLeastOne = True
				' or music?
				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			ElseIf UCase(Dir(strMidiFolder & strFound)) = strFound Then 
				If blnCopy Then FileCopy(strMidiFolder & strFound, strRequiredDataFilesTxtFile & "data\music\" & strFound)
				blnExists = True
				blnCopiedAtLeastOne = True
				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			ElseIf UCase(Dir(strMidiFolder & "Adventure\" & strFound)) = strFound Then 
				If blnCopy Then FileCopy(strMidiFolder & "adventure\" & strFound, strRequiredDataFilesTxtFile & "data\music\adventure\" & strFound)
				blnExists = True
				blnCopiedAtLeastOne = True
				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			ElseIf UCase(Dir(strMidiFolder & "Combat\" & strFound)) = strFound Then 
				If blnCopy Then FileCopy(strMidiFolder & "combat\" & strFound, strRequiredDataFilesTxtFile & "data\music\combat\" & strFound)
				blnExists = True
				blnCopiedAtLeastOne = True
				' or a video?
				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			ElseIf UCase(Dir(strAviFolder & strFound)) = strFound Then 
				If blnCopy Then FileCopy(strAviFolder & strFound, strRequiredDataFilesTxtFile & "data\videos\" & strFound)
				blnExists = True
				blnCopiedAtLeastOne = True
			End If
			' did we finally find something?
			If blnExists = True Then
				' Yep - remove name from list
				'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				frmList.lstList.RemoveItem(intItemPos)
				'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				frmList.lstList.Refresh()
			Else
				' No - keep it and increase index
				intItemPos = intItemPos + 1
			End If
			'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If frmList.lstList.ListCount > 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				intPercent = Int(intItemPos / frmList.lstList.ListCount * 100)
			Else
				intPercent = 100
			End If
			'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmList.Caption = "Searching files: " & intPercent & "%"
			'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmList.Refresh()
		End While
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		frmList.Caption = strFormCaption
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		frmList.Refresh()
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Dim aParse() As String
		If frmList.lstList.ListCount > 0 Then ' some files not found
			'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Hide. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmList.Hide() ' Fixes RT 401 on systems running Vista or 7
			confirm = MsgBox("Some required files are missing. Do you wish to save the list?", MsgBoxStyle.YesNo)
			If confirm = MsgBoxResult.Yes Then
				'UPGRADE_WARNING: Couldn't resolve default property of object frmList.SaveList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				frmList.SaveList()
			End If
			'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmList.Show()
		Else
			If blnCopy Then 'And blnCopiedAtLeastOne Then
				'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Hide. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				frmList.Hide() ' Fixes RT 401 on systems running Vista or 7
				If MsgBox("Do you want to create a package for the " & IIf(bPackWorld, "world?", "tome?"), CDbl(MsgBoxStyle.Question & MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
					' make a package for distributing the tome
					'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					strFound = Replace(Tome.Name, " ", "_")
					'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.ShortPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					shortCmdLine = oFileSys.ShortPath(gAppPath)
					'                    Call ExecCmd(gAppPath & "\NSIS\\makensis /DPRODUCT_VERSION=" & Chr(34) & strFound & Chr(34) & " /DLOCALDIR=" & Chr(34) & Replace$(Tome.LoadPath, "\", "\\") & Chr(34) & " " & Replace$(gAppPath, "\", "\\") & "\\Data\\Stock\\package-tome.nsi")
					'aParse = Split(oFileSys.ShortPath(Tome.LoadPath), "\")
					'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					aParse = Split(Tome.LoadPath, "\")
					' [Titi 2.5.1] Include world package creation
					If bPackWorld Then ' For worlds, the path is different ("Roster" instead of "Tomes")
						'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.ShortPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object ExecCmd(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						retval = ExecCmd(shortCmdLine & "\NSIS\makensis /DTOMEDIR=" & Chr(34) & aParse(UBound(aParse)) & Chr(34) & " /DLOCALDIR=" & Chr(34) & VB.Left(Tome.LoadPath, InStr(Tome.LoadPath, aParse(UBound(aParse) - 1)) - 2) & Chr(34) & " /DPRODUCT_VERSION=" & Chr(34) & strFound & Chr(34) & " " & oFileSys.ShortPath(gDataPath) & "\Stock\package-world.nsi")
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If aParse(UBound(aParse) - 1) <> WorldNow.Name Then
							' [Titi 2.4.9] means the tome is directly in the \tomes folder - correct path accordingly
							'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.ShortPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object ExecCmd(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							retval = ExecCmd(shortCmdLine & "\NSIS\makensis /DTOMEDIR=" & Chr(34) & "\Tomes\" & aParse(UBound(aParse)) & Chr(34) & " /DTOMENAME=" & Chr(34) & VB.Left(Tome.FileName, Len(Tome.FileName) - 4) & Chr(34) & " /DLOCALDIR=" & Chr(34) & VB.Left(Tome.LoadPath, InStr(Tome.LoadPath, aParse(UBound(aParse) - 1)) - 2) & Chr(34) & " /DPRODUCT_VERSION=" & Chr(34) & strFound & Chr(34) & " " & oFileSys.ShortPath(gDataPath) & "\Stock\package-tome.nsi")
						Else
							'                            retval = ExecCmd(shortCmdLine & "\NSIS\makensis /DTOMEDIR=" & Chr(34) & aParse(UBound(aParse) - 1) & "\" & aParse(UBound(aParse)) & Chr(34) & " /DLOCALDIR=" & Chr(34) & Left$(Tome.LoadPath, InStr(Tome.LoadPath, aParse(UBound(aParse) - 2)) - 2) & Chr(34) & " /DPRODUCT_VERSION=" & Chr(34) & strFound & Chr(34) & " " & shortCmdLine & "\Data\Stock\package-tome.nsi")
							'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.ShortPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object ExecCmd(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							retval = ExecCmd(shortCmdLine & "\NSIS\makensis /DTOMEDIR=" & Chr(34) & "\Tomes\" & aParse(UBound(aParse) - 1) & "\" & aParse(UBound(aParse)) & Chr(34) & " /DLOCALDIR=" & Chr(34) & VB.Left(Tome.LoadPath, InStr(Tome.LoadPath, aParse(UBound(aParse) - 2)) - 2) & Chr(34) & " /DPRODUCT_VERSION=" & Chr(34) & strFound & Chr(34) & " " & oFileSys.ShortPath(gDataPath) & "\Stock\package-tome.nsi")
						End If
						'                    If blnCopiedAtLeastOne Then
						'                        retval = ExecCmd(shortCmdLine & "\NSIS\makensis /DPRODUCT_VERSION=" & Chr(34) & strFound & Chr(34) & " /DLOCALDIR=" & Chr(34) & Tome.LoadPath & Chr(34) & " " & shortCmdLine & "\Data\Stock\package-tome_full.nsi")
						'                    Else
						'                        retval = ExecCmd(shortCmdLine & "\NSIS\makensis /DPRODUCT_VERSION=" & Chr(34) & strFound & Chr(34) & " /DLOCALDIR=" & Chr(34) & Tome.LoadPath & Chr(34) & " " & shortCmdLine & "\Data\Stock\package-tome_tome-only.nsi")
						'                    End If
					End If
					If retval <> 0 Then
						' [Titi 2.6.0] Maybe a tome created for the library?
						'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.ShortPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object ExecCmd(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						retval = ExecCmd(shortCmdLine & "\NSIS\makensis /DTOMEDIR=" & Chr(34) & "\Library\Worlds\" & aParse(UBound(aParse) - 1) & "\" & aParse(UBound(aParse)) & Chr(34) & " /DLOCALDIR=" & Chr(34) & VB.Left(Tome.LoadPath, InStr(Tome.LoadPath, aParse(UBound(aParse) - 3)) - 2) & Chr(34) & " /DPRODUCT_VERSION=" & Chr(34) & strFound & Chr(34) & " " & oFileSys.ShortPath(gDataPath) & "\Stock\package-tome.nsi")
						If retval <> 0 Then
							' Maybe trying to create a package from a saved tome?
							'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.ShortPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object ExecCmd(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							retval = ExecCmd(shortCmdLine & "\NSIS\makensis /DTOMEDIR=" & Chr(34) & "\World\" & aParse(UBound(aParse) - 1) & "\" & aParse(UBound(aParse)) & Chr(34) & " /DLOCALDIR=" & Chr(34) & VB.Left(Tome.LoadPath, InStr(Tome.LoadPath, aParse(UBound(aParse) - 2)) - 2) & Chr(34) & " /DPRODUCT_VERSION=" & Chr(34) & strFound & Chr(34) & " " & oFileSys.ShortPath(gDataPath) & "\Stock\package-tome.nsi")
							If retval <> 0 Then
								'UPGRADE_WARNING: Couldn't resolve default property of object oErr.logError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
								oErr.logError("CheckIfExist")
								'UPGRADE_WARNING: Couldn't resolve default property of object oErr.LogText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
								oErr.LogText(IIf(bPackWorld, "World", "Tome") & " package creation error, code = " & retval)
								Call MsgBox(IIf(bPackWorld, "World", "Tome") & " creation error", MsgBoxStyle.Exclamation)
							Else
								'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
								'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
								Call oFileSys.CheckExists(gAppPath & "\Packing store\" & WorldNow.Name & "\", Folder, True) ' create subfolder if necessary
								'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
								'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
								Call oFileSys.CheckExists(gAppPath & "\Packing store\" & WorldNow.Name & "\World\", Folder, True) ' create subfolder if necessary
								'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
								'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
								FileCopy(Tome.LoadPath & "\" & strFound & ".rsp", gAppPath & "\Packing store\" & WorldNow.Name & "\World\" & strFound & ".rsp")
								'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
								Kill(Tome.LoadPath & "\" & strFound & ".rsp")
								'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
								Call MsgBox("Package is saved:" & vbCrLf & gAppPath & "\Packing store\" & WorldNow.Name & "\World\" & strFound & ".rsp", MsgBoxStyle.Information)
								'UPGRADE_WARNING: Couldn't resolve default property of object frmList.btnExit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
								frmList.btnExit = True
							End If
						Else
							' [Titi 2.6.0] now move the package to \Packing store (easier to trace)
							'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							Call oFileSys.CheckExists(gAppPath & "\Packing store\" & WorldNow.Name & "\", Folder, True) ' create subfolder if necessary
							'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							Call oFileSys.CheckExists(gAppPath & "\Packing store\" & WorldNow.Name & "\Library\", Folder, True) ' create subfolder if necessary
							'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							FileCopy(Tome.LoadPath & "\" & strFound & ".rsp", gAppPath & "\Packing store\" & WorldNow.Name & "\Library\" & strFound & ".rsp")
							'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							Kill(Tome.LoadPath & "\" & strFound & ".rsp")
							'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							Call MsgBox("Package is saved:" & vbCrLf & gAppPath & "\Packing store\" & WorldNow.Name & "\Library\" & strFound & ".rsp", MsgBoxStyle.Information)
							'Call MsgBox("Package is saved:" & vbCrLf & Tome.LoadPath & "\" & strFound & ".rsp", vbInformation)
							'UPGRADE_WARNING: Couldn't resolve default property of object frmList.btnExit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							frmList.btnExit = True
						End If
					Else
						' [Titi 2.6.0] Move all packages in the same directory
						'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						Call oFileSys.CheckExists(gAppPath & "\Packing store\" & WorldNow.Name & "\", Folder, True) ' create subfolder if necessary
						'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.CheckExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						Call oFileSys.CheckExists(gAppPath & "\Packing store\" & WorldNow.Name & "\" & Tome.Name & "\", Folder, True) ' create subfolder if necessary
						'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						FileCopy(Tome.LoadPath & "\" & strFound & ".rsp", gAppPath & "\Packing store\" & WorldNow.Name & "\" & Tome.Name & "\" & strFound & ".rsp")
						'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						Kill(Tome.LoadPath & "\" & strFound & ".rsp")
						'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						Call MsgBox("Package is saved:" & vbCrLf & gAppPath & "\Packing store\" & WorldNow.Name & "\" & strFound & ".rsp", MsgBoxStyle.Information)
						'Call MsgBox("Package is saved:" & vbCrLf & Tome.LoadPath & "\" & strFound & ".rsp", vbInformation)
						'                        Call oFileSys.Delete(strRequiredDataFilesTxtFile & "data", Folder, True)
						'UPGRADE_WARNING: Couldn't resolve default property of object frmList.btnExit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						frmList.btnExit = True
					End If
				End If
				'                Call oFileSys.Delete(strRequiredDataFilesTxtFile & "data", Folder, True) '[Titi 2.4.9b] moved here to delete the \Data subfolder even after an error.
			End If
		End If
		'    End If
Exit_Sub: 
		'UPGRADE_WARNING: Couldn't resolve default property of object oFileSys.Delete. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Call oFileSys.Delete(strRequiredDataFilesTxtFile & "data", Folder, True) '[Titi 2.4.9b] moved here to delete the \Data subfolder even after an error or cancellation of the package creation.
		Exit Sub
ErrorHandler: 
		If Err.Number = 53 Then
			' file not found - then let's create one, and the kill *.* will work!
			i = FreeFile
			FileOpen(i, strFound & "\TmpFileToAvoidRT53", OpenMode.Output)
			FileClose(i)
			Resume 
		Else
			' it's something else - log the error
			'UPGRADE_WARNING: Couldn't resolve default property of object oErr.logError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			oErr.logError("CheckIfExist")
			'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Call MsgBox("Error while creating:" & vbCrLf & gAppPath & "\Packing store\" & WorldNow.Name & "\" & strFound & ".rsp" & vbCrLf & "Package NOT saved!", MsgBoxStyle.Information)
			Resume Exit_Sub
		End If
	End Sub
	
	Public Sub btnOpen_Click()
		Dim frmList As Object
		On Error Resume Next
		Dim strFound, strTempFileName As String
		Dim hndList As Short
		dlgFileOpen.FileName = gAppPath & "\Tomes\*.txt"
		dlgFileSave.FileName = gAppPath & "\Tomes\*.txt"
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		dlgFile.CancelError = True
		dlgFileOpen.Title = "Open List"
		dlgFileSave.Title = "Open List"
		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		dlgFileOpen.Filter = "List (*.txt)|*.txt|All Files (*.*)|*.*"
		dlgFileSave.Filter = "List (*.txt)|*.txt|All Files (*.*)|*.*"
		dlgFileOpen.FilterIndex = 1
		dlgFileSave.FilterIndex = 1
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFile.Flags was upgraded to dlgFileOpen.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		dlgFileOpen.CheckFileExists = True
		dlgFileOpen.CheckPathExists = True
		dlgFileSave.CheckPathExists = True
		'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFile.Flags was upgraded to dlgFileOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		dlgFileOpen.ShowReadOnly = False
		dlgFileOpen.RestoreDirectory = False
		dlgFileSave.RestoreDirectory = False
		dlgFileOpen.ShowDialog()
		dlgFileSave.FileName = dlgFileOpen.FileName
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		If Err.Number = DialogResult.Cancel Then Exit Sub
		' Set cursor to hourglass
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		frmList.lstList.Clear()
		hndList = FreeFile
		FileOpen(hndList, dlgFileOpen.FileName, OpenMode.Input)
		strRequiredDataFilesTxtFile = LineInput(hndList)
		' Load the name of the tome the list comes from. However we just need the path.
		strRequiredDataFilesTxtFile = VB.Left(strRequiredDataFilesTxtFile, InStrRev(strRequiredDataFilesTxtFile, "\"))
		While Not EOF(hndList)
			strFound = LineInput(hndList)
			If VB.Left(strFound, 5) <> "-----" And VB.Left(strFound, 9) <> "List of ." Then
				'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				frmList.lstList.AddItem(strFound)
			End If
		End While
		FileClose(hndList)
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		frmList.lstList.Refresh()
	End Sub
	
	Private Sub RemoveDuplicate(ByRef lstList As System.Windows.Forms.ListBox)
		Dim frmList As Object
		' [Titi] Added 2.4.6
		Dim intItemIndex, intPercent As Short
		Dim strProgress, strFormCaption As String
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		strFormCaption = frmList.Caption
		strProgress = "Removing duplicates: "
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		With lstList
			intItemIndex = 1
			' The list is already sorted in alphabetical order, so all duplicates will be adjacent.
			Do While intItemIndex <= .Items.Count - 1
				If UCase(VB6.GetItemString(lstList, intItemIndex)) = UCase(VB6.GetItemString(lstList, intItemIndex - 1)) Then
					.Items.RemoveAt((intItemIndex))
				Else
					intItemIndex = intItemIndex + 1
				End If
				If .Items.Count = 0 Then
					intPercent = 100
				Else
					intPercent = Int(intItemIndex / .Items.Count * 100)
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				frmList.Caption = strProgress & intPercent & "%"
				'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				frmList.Refresh()
			Loop 
		End With
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		frmList.Caption = strFormCaption
	End Sub
	
	Private Sub CleanList(ByRef lstList As System.Windows.Forms.ListBox)
		Dim oErr As Object
		Dim frmList As Object
		' [Titi] Added 2.4.6
		On Error GoTo ErrorHandler
		Dim hndStock, j, i, intNbItemsStock, intNbNames As Short
		Dim strFormCaption, strName, strProgress As String
		Dim intPercent As Short
		Dim blnStockExists As Object
		Dim blnInStock As Boolean
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		strFormCaption = frmList.Caption
		strProgress = "Filtering: "
		hndStock = FreeFile
		'UPGRADE_WARNING: Couldn't resolve default property of object blnStockExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		blnStockExists = True
		' RSStock.txt must be in the stock folder
		'    Open gAppPath & "\Data\Stock\RSStock.txt" For Input As hndStock
		FileOpen(hndStock, gDataPath & "\Stock\RSStock.txt", OpenMode.Input)
		'UPGRADE_WARNING: Couldn't resolve default property of object blnStockExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If blnStockExists = True Then
			Input(hndStock, intNbItemsStock)
			'UPGRADE_WARNING: Lower bound of array tblRS2Stockfiles was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
			Dim tblRS2Stockfiles(intNbItemsStock) As String
			' initialize table of .bmp and .wav in the standard RS2 package
			For i = 1 To intNbItemsStock
				Input(hndStock, tblRS2Stockfiles(i))
			Next 
			FileClose(hndStock)
		Else
			intNbItemsStock = 1
			'UPGRADE_WARNING: Lower bound of array tblRS2Stockfiles was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
			ReDim tblRS2Stockfiles(intNbItemsStock)
		End If
		With lstList
			i = 0
			Do While i < .Items.Count
				blnInStock = False
				' remove standard bmp and wav
				For j = 1 To intNbItemsStock
					If UCase(VB6.GetItemString(lstList, i)) = UCase(tblRS2Stockfiles(j)) Then
						.Items.RemoveAt((i))
						blnInStock = True
					End If
				Next j
				If blnInStock = False Then ' not in the standard package
					i = i + 1 ' so let's keep it, and check the next one
				Else
					blnInStock = False
				End If
				If .Items.Count = 0 Then
					intPercent = 100
				Else
					intPercent = Int(i / .Items.Count * 100)
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				frmList.Caption = strProgress & intPercent & "%"
				'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				frmList.Refresh()
			Loop 
		End With
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		frmList.Caption = strFormCaption
		Exit Sub
ErrorHandler: 
		If Err.Number = 53 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object blnStockExists. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			blnStockExists = False
			'        MsgBox "Cannot find " & gAppPath & "\Data\Stock\RSStock.txt! The list will not be filtered."
			MsgBox("Cannot find " & gDataPath & "\Stock\RSStock.txt! The list will not be filtered.")
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object oErr.logError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			oErr.logError("CleanList: " & Err.Number & " (" & Err.Description & ")")
		End If
		Resume Next
	End Sub
	
	Public Sub mnuSearchListWav_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSearchListWav.Click
		Dim frmList As Object
		' [Titi] Added 2.4.6
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		frmList.Show()
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		frmList.lstList.Clear()
		FindFile("wav")
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RemoveDuplicate(frmList.lstList)
		'UPGRADE_WARNING: Couldn't resolve default property of object frmList.lstList. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CleanList(frmList.lstList)
	End Sub
	
	Public Sub mnuSearchReplace_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSearchReplace.Click
		frmSearch.ReplaceList()
		frmSearch.Show()
	End Sub
	
	Public Sub mnuWindow_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuWindow.Click
		On Error GoTo ErrorHandler
		Dim c As Short
		' clear the previous list
		For c = 1 To 8 ' number of available simultaneously opened forms
			mnuWindowList(c).Enabled = False
			mnuWindowList(c).Visible = False
		Next 
		' form #1 is the creator itself, form #2 is frmProject (the treeview windows)
		mnuList.Enabled = My.Application.OpenForms.Count > 2
		mnuList.Text = IIf(My.Application.OpenForms.Count > 2, "Windows list", "No forms loaded")
		If intIndex >= 8 Then mnuWindowList(0).Text = "Previous..."
		For c = 2 + intIndex To My.Application.OpenForms.Count - 1
			If My.Application.OpenForms.Item(c).Text <> vbNullString Then
				mnuWindowList(c - 2 - intIndex - CShort(intIndex >= 8)).Text = My.Application.OpenForms.Item(c).Text
				mnuWindowList(c - 2 - intIndex - CShort(intIndex >= 8)).Enabled = True
				If c > 2 Then mnuWindowList(c - 2 - intIndex - CShort(intIndex >= 8)).Visible = True
			End If
		Next 
ErrorHandler: 
		If Err.Number = 340 Then mnuWindowList(8).Text = "More..." 'Control Group Item does not exist --> more windows than allowed in the mnuWindowList() array!
		Exit Sub
	End Sub
	
	Public Sub mnuWindowList_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuWindowList.Click
		Dim Index As Short = mnuWindowList.GetIndex(eventSender)
		If mnuWindowList(Index).Text = "More..." Then
			intIndex = intIndex + 8
			mnuWindow_Click(mnuWindow, New System.EventArgs())
		ElseIf mnuWindowList(Index).Text = "Previous..." Then 
			intIndex = intIndex - 8
			mnuWindow_Click(mnuWindow, New System.EventArgs())
		Else
			' reminder: the first two forms are the creator itself and frmProject
			My.Application.OpenForms.Item(Index + 2 + intIndex + CShort(intIndex >= 8)).Activate()
		End If
	End Sub
	
	Public Sub mnuWindowArrangeIcons_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuWindowArrangeIcons.Click
		Me.LayoutMDI(System.Windows.Forms.MDILayout.ArrangeIcons)
	End Sub
	
	Public Sub mnuWindowCascade_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuWindowCascade.Click
		Me.LayoutMDI(System.Windows.Forms.MDILayout.Cascade)
	End Sub
	
	Public Sub mnuWindowHorizontally_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuWindowHorizontally.Click
		Me.LayoutMDI(System.Windows.Forms.MDILayout.TileHorizontal)
	End Sub
	
	Public Sub mnuWindowVertically_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuWindowVertically.Click
		Me.LayoutMDI(System.Windows.Forms.MDILayout.TileVertical)
	End Sub
	
	Private Sub tlbMenu_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As AxComctlLib.IToolbarEvents_ButtonClickEvent) Handles tlbMenu.ButtonClick
		Select Case eventArgs.Button.Key
			Case "New"
				mnuFileNewTome_Click(mnuFileNewTome, New System.EventArgs())
			Case "Open"
				mnuFileOpenTome_Click(mnuFileOpenTome, New System.EventArgs())
			Case "Save"
				mnuFileSaveTome_Click(mnuFileSaveTome, New System.EventArgs())
			Case "Cut"
				mnuEditCut_Click(mnuEditCut, New System.EventArgs())
			Case "Copy"
				mnuEditCopy_Click(mnuEditCopy, New System.EventArgs())
			Case "Paste"
				mnuEditPaste_Click(mnuEditPaste, New System.EventArgs())
			Case "Edit"
				mnuEditProperties_Click(mnuEditProperties, New System.EventArgs())
			Case "Run"
				RunTome()
		End Select
	End Sub
	' HTML Help file launched in response to a button click:
	'Private Sub HH_DISPLAY_Click()
	''hWnd is a Long defined elsewhere to be the window handle
	''that will be the parent to the help window.
	'Dim hwndHelp As Long
	''The return value is the window handle of the created help window.
	'hwndHelp = HtmlHelp(hWnd, App.Path + "\RSHelp.chm", HH_DISPLAY_TOPIC, 0)
	'End Sub ' A specific topic identified by the variable ContextID is launched' in response to this button click:
	'Private Sub HH_HELP_Click()
	'    Dim hwndHelp As Long
	'    'The return value is the window handle of the created help window.
	'    hwndHelp = HtmlHelp(hWnd, App.Path + "\RSHelp.chm", HH_HELP_CONTEXT, ContextID)
	'End Sub
End Class