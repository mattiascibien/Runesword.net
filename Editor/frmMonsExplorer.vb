Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frmMonsExplorer
	Inherits System.Windows.Forms.Form
	
	Dim TreeViewX As AxComctlLib.AxTreeView
	Dim CreatureX As Creature
	Dim Dirty As Short
	
	Dim PictureStyle As Short
	Dim TmpPictureFile As String
	Dim TmpFaceLeft As Short
	Dim TmpFaceTop As Short
	Dim PictureDir As String
	Dim TmpPortraitFile As String
	Dim PortraitDir As String
	
	Dim TmpWAV(3) As String
	Dim TmpWAVFlag(3) As Short
	
	'UPGRADE_NOTE: Size was upgraded to Size_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Dim Size_Renamed As Double
	'UPGRADE_NOTE: MouseDown was upgraded to MouseDown_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Dim MouseDown_Renamed As Short
	
	Dim strCurrCrea As String
	Dim CreautreX As Creature
	Dim fsoFile As Short
	
	Const bdGeneral As Short = 1
	Const bdType As Short = 2
	Const bdArmor As Short = 3
	Const bdItems As Short = 4
	Const bdConversations As Short = 5
	Const bdTriggers As Short = 6
	Const bdSounds As Short = 7
	Const bdWeakness As Short = 8
	
	' Display size indicator
	Const bdSmallDisplay As Short = 1
	Const bdLargeDisplay As Short = 2
	Dim iDisplaySize As Short
	
	Private Sub InitCreaExpl()
		Dim bExists As Boolean
		'    dlstDirectory.Path = gAppPath & "\Library"
		dlstDirectory.Path = gLibPath
		bExists = oFileSys.CheckExists(dlstDirectory.Path & "\Creatures", clsInOut.IOActionType.Folder, False)
		If bExists = True Then
			dlstDirectory.Path = dlstDirectory.Path & "\Creatures"
		End If
		flsFileList.Path = dlstDirectory.Path
		flsFileList.Refresh()
		' decide how to display
		If (VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) / VB6.TwipsPerPixelX) >= 1280 Then
			iDisplaySize = bdLargeDisplay
		Else
			cmdClose.Visible = False
			iDisplaySize = bdSmallDisplay
		End If
		SizeAndShow()
	End Sub
	
	Private Sub btnInsert_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnInsert.Click
		' [Titi 2.6.0]
		'UPGRADE_NOTE: Tag was upgraded to Tag_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim sError, sAorAn, Tag_Renamed As String
		Dim ObjectX, ObjectEdit As Object
		Dim Index As Short
		If CreatureX Is Nothing Then
			MsgBox("Please select a creature first!", MsgBoxStyle.OKOnly, "Undefined creature")
			Exit Sub
		End If
		If frmMDI.TreeViewX.SelectedItem.Parent Is Nothing Then
			MsgBox("Please select a place to insert the " & CreatureX.Name & " first!", MsgBoxStyle.OKOnly, "Invalid destination")
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object frmMDI.TreeViewX.SelectedItem.Tag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tag_Renamed = frmMDI.TreeViewX.SelectedItem.Tag
			If frmProject.ValidDrop("EncountersE1", frmMDI.TreeViewX.SelectedItem.Parent.Tag) = True Or frmProject.ValidDrop("EncountersE1X1", frmMDI.TreeViewX.SelectedItem.Tag) = True Then
				ObjectX = frmMDI.ObjectListX.Item(Tag_Renamed)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddCreature. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = ObjectX.AddCreature
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Index = ObjectEdit.Index
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Copy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.Copy(CreatureX)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.Index = Index
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				frmMDI.ShowCreature((frmMDI.ObjectListX), (frmMDI.TreeViewX), Tag_Renamed, ObjectEdit)
				' cut & paste below to give several copies of the same creature different names
				frmMDI.EditCut(Tag_Renamed & "X" & Index)
				frmMDI.EditPaste(Tag_Renamed)
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object frmMDI.TreeViewX.SelectedItem.Tag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				sError = frmMDI.TreeViewX.SelectedItem.Tag
				'UPGRADE_WARNING: Couldn't resolve default property of object frmMDI.TreeViewX.SelectedItem.Tag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				sError = frmMDI.TreeViewX.SelectedItem.Tag
				Select Case frmMDI.ParseTag(sError)
					Case bdEditMap, bdEditMapGraphic To bdEditMapEncounters, bdEditMapTileSets, bdEditMapTiles, bdEditMapEntryPoints
						sError = "Map folder " ' better than "Default map "
					Case bdEditEncounter To bdEditTrigger, bdEditTome To bdEditTomeJournals
						sError = frmMDI.TreeViewX.SelectedItem.Text & " "
					Case bdEditTomeTriggers
						sError = "Tome folder " ' can be inserted into a trigger, but not in the tome triggers folder - however in that case SelectedItem.Text could be confusing, so make it clear
					Case bdEditTomeAreas, bdEditTomeFactoids
						sError = frmMDI.TreeViewX.SelectedItem.Text ' get rid of the final s
					Case Else
						sError = frmMDI.TreeViewX.SelectedItem.Parent.Text
				End Select
				sAorAn = AOrAn(sError)
				If Len(Trim(sAorAn)) > 1 Then
					sAorAn = UCase(VB.Left(sAorAn, 1)) & Mid(sAorAn, 2)
				Else
					sAorAn = UCase(sAorAn)
				End If
				MsgBox(sAorAn & VB.Left(sError, Len(sError) - 1) & " is not a valid destination!", MsgBoxStyle.OKOnly, "Invalid destination")
			End If
		End If
	End Sub
	
	Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
		If iDisplaySize = bdSmallDisplay Then
			iDisplaySize = bdLargeDisplay
		Else
			iDisplaySize = bdSmallDisplay
		End If
		SizeAndShow()
	End Sub
	
	Private Sub cmdPlaySound_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPlaySound.Click
		Dim Index As Short = cmdPlaySound.GetIndex(eventSender)
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		If txtSoundFile(Index).Text = "[Default]" Or txtSoundFile(Index).Text = "" Then
			Select Case Index
				Case 0 ' Move
					' Call PlaySoundFile("step1.wav", Tome)
					Call PlaySoundFile("step1.wav")
				Case 1 ' Attack does not have a default sound
				Case 2 ' Hit
					Call PlaySoundFile("hit.wav", Tome)
				Case 3 ' Die
					Call PlaySoundFile("monsdie.wav", Tome)
			End Select
		Else
			Call PlaySoundFile(txtSoundFile(Index).Text, Tome)
		End If
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub dlstDirectory_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dlstDirectory.Change
		flsFileList.Path = dlstDirectory.Path
		flsFileList.Refresh()
	End Sub
	
	Private Sub dlstDirectory_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dlstDirectory.SelectedIndexChanged
		dlstDirectory.Path = dlstDirectory.DirList(dlstDirectory.DirListIndex)
	End Sub
	
	Private Sub drvList_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles drvList.SelectedIndexChanged
		On Error GoTo ErrorHandler
		Dim sDrive As String
		Dim iDrive, i As Short
		sDrive = dlstDirectory.Path
		For i = 0 To drvList.Items.Count
			If UCase(VB.Left(drvList.Items(i), 1)) = UCase(VB.Left(sDrive, 1)) Then
				iDrive = i
			End If
		Next 
		dlstDirectory.Path = drvList.Items(drvList.SelectedIndex)
		Exit Sub
ErrorHandler: 
		If Err.Number = 68 Then
			' drive not available
			dlstDirectory.Path = sDrive
			MsgBox("Drive " & drvList.Items(drvList.SelectedIndex) & " is not accessible." & vbCrLf & "Reverting to " & gLibPath & ".")
			For iDrive = 0 To drvList.Items.Count
				If UCase(VB.Left(drvList.Items(iDrive), 1)) = UCase(VB.Left(gLibPath, 1)) Then
					drvList.SelectedIndex = iDrive
				End If
			Next 
			InitCreaExpl()
		End If
	End Sub
	
	Private Sub flsFileList_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flsFileList.SelectedIndexChanged
		LoadCreature()
	End Sub
	
	Private Sub frmMonsExplorer_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		InitCreaExpl()
	End Sub
	
	Private Sub LoadCreature()
		txtDataPath.Text = flsFileList.Path & "\" & flsFileList.Items(flsFileList.SelectedIndex)
		fsoFile = FreeFile
		FileOpen(fsoFile, txtDataPath.Text, OpenMode.Binary)
		CreatureX = New Creature
		CreatureX.ReadFromFile(fsoFile)
		If iDisplaySize = bdSmallDisplay Then
			DisplayCreaInfoText()
		Else
			DisplayCreaInfo()
		End If
		' [Ephestion 2.4.8] browsing several times through the list caused an error (#67, too many files)
		FileClose(fsoFile)
	End Sub
	
	Private Sub SizeAndShow()
		' set form components for each view style then go to the correct creature display sub
		If iDisplaySize = bdSmallDisplay Then
			' small option :
			Me.Width = VB6.TwipsToPixelsX(8460)
			Me.Height = VB6.TwipsToPixelsY(5955)
			fraFullView.Visible = False
			flsFileList.Height = 120
			fraCompactView.Visible = True
			fraCompactView.Refresh()
			txtInfo.Visible = True
			cmdClose.Text = "Full View"
			btnInsert.Top = 216
			btnInsert.Left = 184
			btnInsert.BringToFront()
			'DisplayCreaInfoText
		Else
			' large option : DisplayCreaInfo
			Me.Width = VB6.TwipsToPixelsX(17370)
			Me.Height = VB6.TwipsToPixelsY(9615)
			fraCompactView.Visible = False
			fraFullView.Visible = True
			flsFileList.Height = 344
			cmdClose.Text = "Compact View"
			fraFullView.Refresh()
			txtInfo.Refresh()
			btnInsert.Top = 56
			btnInsert.Left = 544
			btnInsert.BringToFront()
			'DisplayCreaInfo
		End If
		If flsFileList.SelectedIndex <> -1 Then
			LoadCreature()
		End If
	End Sub
	
	Private Sub DisplayCreaInfoText()
		Dim c As Short
		Dim iNumItems As Short
		Dim sTempWAV As String
		Dim strSize(4) As String
		Dim sInfo As String
		Dim bMoreThan1 As Boolean
		' Clean-up the info display
		txtInfo.Text = "Loading..."
		txtInfo.Refresh()
		' Describe creature's size
		strSize(4) = "Huge" : strSize(3) = "Large" : strSize(2) = "Normal" : strSize(1) = "Small" : strSize(0) = "Tiny"
		' Default size before load any picture
		Size_Renamed = 1
		' Default to normal picture style (not portrait)
		PictureStyle = 0
		Me.Text = "Creature [" & CreatureX.Name & "]"
		sInfo = "Name: " & CreatureX.Name & vbCrLf
		sInfo = sInfo & "Comments : " & CreatureX.Comments & vbCrLf
		sInfo = sInfo & "Race: " & CreatureX.Race & vbCrLf
		txtSize.Text = "Undefined"
		For c = 0 To 4
			If CreatureX.Size(c) < 0 Then txtSize.Text = strSize(c)
		Next 
		sInfo = sInfo & "Size: " & txtSize.Text & vbCrLf
		' Load and paint Picture from myPicture
		'    PictureDir = gAppPath & "\data\graphics\creatures"
		PictureDir = gDataPath & "\graphics\creatures"
		TmpPictureFile = CreatureX.PictureFile
		TmpFaceLeft = CreatureX.FaceLeft
		TmpFaceTop = CreatureX.FaceTop
		TmpPortraitFile = CreatureX.PortraitFile
		Select Case PictureStyle
			Case 0 ' Normal Picture
				If Len(TmpPictureFile) > 0 Then
					'ShowMonsPicture2 TmpPictureFile
					ShowMonsPicture(TmpPictureFile)
				End If
			Case 1 ' Portrait Picture
				If Len(TmpPortraitFile) > 0 Then
					ShowMonsPortrait2(TmpPortraitFile)
				End If
		End Select
		' txtLevel.Text = Val(CreatureX.Level)
		sInfo = sInfo & "  Level: " & CreatureX.Level & vbCrLf
		' txtSkillPoints.Text = Val(CreatureX.SkillPoints)
		sInfo = sInfo & "  SkillPoints: " & CreatureX.SkillPoints & vbCrLf
		' txtExperiencePoints.Text = Val(CreatureX.ExperiencePoints)
		sInfo = sInfo & "  XP value: " & CreatureX.ExperiencePoints & vbCrLf
		' Statistics
		sInfo = sInfo & "--------------------------" & vbCrLf
		sInfo = sInfo & "Statistics :" & vbCrLf
		' HP
		sInfo = sInfo & "  Hit Points: " & CreatureX.HPNow & "/" & CreatureX.HPMax & vbCrLf
		' txtStats(1).Text = Val(CreatureX.Will)
		sInfo = sInfo & "  Intelligence: " & CreatureX.Will & vbCrLf
		' txtStats(2).Text = Val(CreatureX.Strength)
		sInfo = sInfo & "  Strength: " & CreatureX.Strength & vbCrLf
		' txtStats(3).Text = Val(CreatureX.Agility)
		sInfo = sInfo & "  Agility: " & CreatureX.Agility & vbCrLf
		' txtStats(4).Text = Val(CreatureX.MovementCost)
		sInfo = sInfo & "  Movement Cost: " & CreatureX.MovementCost & vbCrLf
		' txtStats(5).Text = Val(CreatureX.ActionPointsMax)
		sInfo = sInfo & "  Max ActionPoints: " & CreatureX.ActionPointsMax & vbCrLf
		' Vices
		sInfo = sInfo & "--------------------------" & vbCrLf
		sInfo = sInfo & "Vices:" & vbCrLf
		' txtVices(0).Text = Val(CreatureX.Lunacy)
		sInfo = sInfo & "  Lunacy: " & CreatureX.Lunacy & vbCrLf
		' txtVices(1).Text = Val(CreatureX.Revelry)
		sInfo = sInfo & "  Revelry: " & CreatureX.Revelry & vbCrLf
		' txtVices(2).Text = Val(CreatureX.Wrath)
		sInfo = sInfo & "  Wrath: " & CreatureX.Wrath & vbCrLf
		' txtVices(3).Text = Val(CreatureX.Pride)
		sInfo = sInfo & "  Pride: " & CreatureX.Pride & vbCrLf
		' txtVices(4).Text = Val(CreatureX.Greed)
		sInfo = sInfo & "  Greed: " & CreatureX.Greed & vbCrLf
		' txtVices(5).Text = Val(CreatureX.Lust)
		sInfo = sInfo & "  Lust: " & CreatureX.Lust & vbCrLf
		sInfo = sInfo & "--------------------------" & vbCrLf
		sInfo = sInfo & "Properties:" & vbCrLf
		' chkIsInanimate.Value = CreatureX.IsInanimate * CInt(True)
		sInfo = sInfo & "  Is inanimate: " & CBool(CreatureX.IsInanimate * CShort(True)) & vbCrLf
		' chkAgressive.Value = CreatureX.Agressive * CInt(True)
		sInfo = sInfo & "  Can't ignore: " & CBool(CreatureX.Agressive * CShort(True)) & vbCrLf
		' chkGuard.Value = CreatureX.Guard * CInt(True)
		sInfo = sInfo & "  Prevent search: " & CBool(CreatureX.IsInanimate * CShort(True)) & vbCrLf
		' chkIsMale.Value = CreatureX.Male * CInt(True)
		sInfo = sInfo & "  Sex: "
		If CBool(CreatureX.Male * CShort(True)) = True Then
			sInfo = sInfo & "male"
		Else
			sInfo = sInfo & "female"
		End If
		sInfo = sInfo & vbCrLf
		' chkFriend.Value = CreatureX.Friendly * CInt(True)
		sInfo = sInfo & "  Friendly: " & CBool(CreatureX.Friendly * CShort(True)) & vbCrLf
		' chkDMControlled.Value = CreatureX.DMControlled * CInt(True)
		' chkRequiredInTome.Value = CreatureX.RequiredInTome * CInt(True)
		sInfo = sInfo & "  Locked in Tome: " & CBool(CreatureX.RequiredInTome * CShort(True)) & vbCrLf
		' chkRequiredInTome.Refresh
		' family
		sInfo = sInfo & "  Family: "
		bMoreThan1 = False
		For c = 0 To 9
			' chkFamily(c).Value = CreatureX.Family(c) * CInt(True)
			Select Case c
				Case 0
					If CBool(CreatureX.Family(c) * CShort(True)) = True Then
						sInfo = sInfo & "Sentient"
						bMoreThan1 = True
					End If
				Case 1
					If CBool(CreatureX.Family(c) * CShort(True)) = True Then
						If bMoreThan1 = True Then
							sInfo = sInfo & "," & vbCrLf & "             "
						Else
							bMoreThan1 = True
						End If
						sInfo = sInfo & " Reptile"
					End If
				Case 2
					If CBool(CreatureX.Family(c) * CShort(True)) = True Then
						If bMoreThan1 = True Then
							sInfo = sInfo & "," & vbCrLf & "             "
						Else
							bMoreThan1 = True
						End If
						sInfo = sInfo & " Insect"
					End If
				Case 3
					If CBool(CreatureX.Family(c) * CShort(True)) = True Then
						If bMoreThan1 = True Then
							sInfo = sInfo & "," & vbCrLf & "             "
						Else
							bMoreThan1 = True
						End If
						sInfo = sInfo & " Blob"
					End If
				Case 4
					If CBool(CreatureX.Family(c) * CShort(True)) = True Then
						If bMoreThan1 = True Then
							sInfo = sInfo & "," & vbCrLf & "             "
						Else
							bMoreThan1 = True
						End If
						sInfo = sInfo & " Undead"
					End If
				Case 5
					If CBool(CreatureX.Family(c) * CShort(True)) = True Then
						If bMoreThan1 = True Then
							sInfo = sInfo & "," & vbCrLf & "             "
						Else
							bMoreThan1 = True
						End If
						sInfo = sInfo & " Bird"
					End If
				Case 6
					If CBool(CreatureX.Family(c) * CShort(True)) = True Then
						If bMoreThan1 = True Then
							sInfo = sInfo & "," & vbCrLf & "             "
						Else
							bMoreThan1 = True
						End If
						sInfo = sInfo & " Plant"
					End If
				Case 7
					If CBool(CreatureX.Family(c) * CShort(True)) = True Then
						If bMoreThan1 = True Then
							sInfo = sInfo & "," & vbCrLf & "             "
						Else
							bMoreThan1 = True
						End If
						sInfo = sInfo & " Animal"
					End If
				Case 8
					If CBool(CreatureX.Family(c) * CShort(True)) = True Then
						If bMoreThan1 = True Then
							sInfo = sInfo & "," & vbCrLf & "             "
						Else
							bMoreThan1 = True
						End If
						sInfo = sInfo & " Magical"
					End If
				Case 9
					If CBool(CreatureX.Family(c) * CShort(True)) = True Then
						If bMoreThan1 = True Then
							sInfo = sInfo & "," & vbCrLf & "             "
						Else
							bMoreThan1 = True
						End If
						sInfo = sInfo & " Aquatic"
					End If
			End Select
		Next c
		sInfo = sInfo & vbCrLf
		' Combat Rank
		sInfo = sInfo & "  Combat Rank: "
		Select Case CreatureX.CombatRank
			Case 0
				sInfo = sInfo & "Random" & vbCrLf
			Case 1
				sInfo = sInfo & "Back/Ranged" & vbCrLf
			Case 2
				sInfo = sInfo & "Middle" & vbCrLf
			Case 3
				sInfo = sInfo & "Front/Melee" & vbCrLf
		End Select
		' Resistances
		sInfo = sInfo & "--------------------------" & vbCrLf
		sInfo = sInfo & "Resistances:" & vbCrLf
		'   CreatureX.BodyType(x)
		'   0 - Wing, 1 - Tail, 2 - Body, 3 - Head, 4 - Arm, 5 - Leg, 6 - Antenna
		'   7 - Tentacle, 8 - Abdomen, 9 - Back, 10 - Neck
		For c = 0 To 7
			sInfo = sInfo & "  " & SetUpArmorType(CreatureX.BodyType(c)) & " : " & CreatureX.Resistance(c) & "%" & vbCrLf
			'        Select Case CreatureX.BodyType(c)
			'            Case 0
			'                ' lblBody(c).Caption = "Wing"
			'                sInfo = sInfo & "  Wing : " & CreatureX.Resistance(c) & "%" & vbCrLf
			'            Case 1
			'                ' lblBody(c).Caption = "Tail"
			'                sInfo = sInfo & "  Tail : " & CreatureX.Resistance(c) & "%" & vbCrLf
			'            Case 2
			'                ' lblBody(c).Caption = "Body"
			'                sInfo = sInfo & "  Body : " & CreatureX.Resistance(c) & "%" & vbCrLf
			'            Case 3
			'                ' lblBody(c).Caption = "Head"
			'                sInfo = sInfo & "  Head : " & CreatureX.Resistance(c) & "%" & vbCrLf
			'            Case 4
			'                ' lblBody(c).Caption = "Arm"
			'                sInfo = sInfo & "  Arm : " & CreatureX.Resistance(c) & "%" & vbCrLf
			'            Case 5
			'                ' lblBody(c).Caption = "Leg"
			'                sInfo = sInfo & "  Leg : " & CreatureX.Resistance(c) & "%" & vbCrLf
			'            Case 6
			'                ' lblBody(c).Caption = "Antenna"
			'                sInfo = sInfo & "  Antenna : " & CreatureX.Resistance(c) & "%" & vbCrLf
			'            Case 7
			'                ' lblBody(c).Caption = "Tentacle"
			'                sInfo = sInfo & "  Tentacle : " & CreatureX.Resistance(c) & "%" & vbCrLf
			'            Case 8
			'                ' lblBody(c).Caption = "Abdomen"
			'                sInfo = sInfo & "  Abdomen : " & CreatureX.Resistance(c) & "%" & vbCrLf
			'            Case 9
			'                ' lblBody(c).Caption = "Back"
			'                sInfo = sInfo & "  Back : " & CreatureX.Resistance(c) & "%" & vbCrLf
			'            Case 10
			'                ' lblBody(c).Caption = "Neck"
			'                sInfo = sInfo & "  Neck : " & CreatureX.Resistance(c) & "%" & vbCrLf
			'        End Select
			' lblResPerc(c).Caption = CreatureX.Resistance(c) & "%"
		Next 
		' Resistance Bonuses
		sInfo = sInfo & "--------------------------" & vbCrLf
		sInfo = sInfo & "Resistances:" & vbCrLf
		For c = 0 To 7
			Select Case c
				Case 0
					sInfo = sInfo & "  Sharp: "
					Select Case CreatureX.ResistanceTypeBonus(c)
						Case 0
							' lblBonusPerc(c).Caption = "<None>"
							sInfo = sInfo & "<None>" & vbCrLf
						Case 1
							' lblBonusPerc(c).Caption = "10%"
							sInfo = sInfo & "10%" & vbCrLf
						Case 2
							' lblBonusPerc(c).Caption = "20%"
							sInfo = sInfo & "20%" & vbCrLf
						Case 3
							' lblBonusPerc(c).Caption = "30%"
							sInfo = sInfo & "30%" & vbCrLf
						Case 4
							' lblBonusPerc(c).Caption = "40%"
							sInfo = sInfo & "40%" & vbCrLf
						Case 5
							' lblBonusPerc(c).Caption = "50%"
							sInfo = sInfo & "50%" & vbCrLf
						Case 6
							' lblBonusPerc(c).Caption = "60%"
							sInfo = sInfo & "60%" & vbCrLf
						Case 7
							' lblBonusPerc(c).Caption = "70%"
							sInfo = sInfo & "70%" & vbCrLf
						Case 8
							' lblBonusPerc(c).Caption = "80%"
							sInfo = sInfo & "80%" & vbCrLf
						Case 9
							' lblBonusPerc(c).Caption = "90%"
							sInfo = sInfo & "90%" & vbCrLf
						Case 10
							' lblBonusPerc(c).Caption = "Immune"
							sInfo = sInfo & "Immune" & vbCrLf
						Case 11
							' lblBonusPerc(c).Caption = "Double Damage"
							sInfo = sInfo & "Double Damage" & vbCrLf
						Case 12
							' lblBonusPerc(c).Caption = "Triple Damage"
							sInfo = sInfo & "Triple Damage" & vbCrLf
					End Select
				Case 1
					sInfo = sInfo & "  Blunt: "
					Select Case CreatureX.ResistanceTypeBonus(c)
						Case 0
							' lblBonusPerc(c).Caption = "<None>"
							sInfo = sInfo & "<None>" & vbCrLf
						Case 1
							' lblBonusPerc(c).Caption = "10%"
							sInfo = sInfo & "10%" & vbCrLf
						Case 2
							' lblBonusPerc(c).Caption = "20%"
							sInfo = sInfo & "20%" & vbCrLf
						Case 3
							' lblBonusPerc(c).Caption = "30%"
							sInfo = sInfo & "30%" & vbCrLf
						Case 4
							' lblBonusPerc(c).Caption = "40%"
							sInfo = sInfo & "40%" & vbCrLf
						Case 5
							' lblBonusPerc(c).Caption = "50%"
							sInfo = sInfo & "50%" & vbCrLf
						Case 6
							' lblBonusPerc(c).Caption = "60%"
							sInfo = sInfo & "60%" & vbCrLf
						Case 7
							' lblBonusPerc(c).Caption = "70%"
							sInfo = sInfo & "70%" & vbCrLf
						Case 8
							' lblBonusPerc(c).Caption = "80%"
							sInfo = sInfo & "80%" & vbCrLf
						Case 9
							' lblBonusPerc(c).Caption = "90%"
							sInfo = sInfo & "90%" & vbCrLf
						Case 10
							' lblBonusPerc(c).Caption = "Immune"
							sInfo = sInfo & "Immune" & vbCrLf
						Case 11
							' lblBonusPerc(c).Caption = "Double Damage"
							sInfo = sInfo & "Double Damage" & vbCrLf
						Case 12
							' lblBonusPerc(c).Caption = "Triple Damage"
							sInfo = sInfo & "Triple Damage" & vbCrLf
					End Select
				Case 2
					sInfo = sInfo & "  Cold: "
					Select Case CreatureX.ResistanceTypeBonus(c)
						Case 0
							' lblBonusPerc(c).Caption = "<None>"
							sInfo = sInfo & "<None>" & vbCrLf
						Case 1
							' lblBonusPerc(c).Caption = "10%"
							sInfo = sInfo & "10%" & vbCrLf
						Case 2
							' lblBonusPerc(c).Caption = "20%"
							sInfo = sInfo & "20%" & vbCrLf
						Case 3
							' lblBonusPerc(c).Caption = "30%"
							sInfo = sInfo & "30%" & vbCrLf
						Case 4
							' lblBonusPerc(c).Caption = "40%"
							sInfo = sInfo & "40%" & vbCrLf
						Case 5
							' lblBonusPerc(c).Caption = "50%"
							sInfo = sInfo & "50%" & vbCrLf
						Case 6
							' lblBonusPerc(c).Caption = "60%"
							sInfo = sInfo & "60%" & vbCrLf
						Case 7
							' lblBonusPerc(c).Caption = "70%"
							sInfo = sInfo & "70%" & vbCrLf
						Case 8
							' lblBonusPerc(c).Caption = "80%"
							sInfo = sInfo & "80%" & vbCrLf
						Case 9
							' lblBonusPerc(c).Caption = "90%"
							sInfo = sInfo & "90%" & vbCrLf
						Case 10
							' lblBonusPerc(c).Caption = "Immune"
							sInfo = sInfo & "Immune" & vbCrLf
						Case 11
							' lblBonusPerc(c).Caption = "Double Damage"
							sInfo = sInfo & "Double Damage" & vbCrLf
						Case 12
							' lblBonusPerc(c).Caption = "Triple Damage"
							sInfo = sInfo & "Triple Damage" & vbCrLf
					End Select
				Case 3
					sInfo = sInfo & "  Fire: "
					Select Case CreatureX.ResistanceTypeBonus(c)
						Case 0
							' lblBonusPerc(c).Caption = "<None>"
							sInfo = sInfo & "<None>" & vbCrLf
						Case 1
							' lblBonusPerc(c).Caption = "10%"
							sInfo = sInfo & "10%" & vbCrLf
						Case 2
							' lblBonusPerc(c).Caption = "20%"
							sInfo = sInfo & "20%" & vbCrLf
						Case 3
							' lblBonusPerc(c).Caption = "30%"
							sInfo = sInfo & "30%" & vbCrLf
						Case 4
							' lblBonusPerc(c).Caption = "40%"
							sInfo = sInfo & "40%" & vbCrLf
						Case 5
							' lblBonusPerc(c).Caption = "50%"
							sInfo = sInfo & "50%" & vbCrLf
						Case 6
							' lblBonusPerc(c).Caption = "60%"
							sInfo = sInfo & "60%" & vbCrLf
						Case 7
							' lblBonusPerc(c).Caption = "70%"
							sInfo = sInfo & "70%" & vbCrLf
						Case 8
							' lblBonusPerc(c).Caption = "80%"
							sInfo = sInfo & "80%" & vbCrLf
						Case 9
							' lblBonusPerc(c).Caption = "90%"
							sInfo = sInfo & "90%" & vbCrLf
						Case 10
							' lblBonusPerc(c).Caption = "Immune"
							sInfo = sInfo & "Immune" & vbCrLf
						Case 11
							' lblBonusPerc(c).Caption = "Double Damage"
							sInfo = sInfo & "Double Damage" & vbCrLf
						Case 12
							' lblBonusPerc(c).Caption = "Triple Damage"
							sInfo = sInfo & "Triple Damage" & vbCrLf
					End Select
				Case 4
					sInfo = sInfo & "  Sharp: "
					Select Case CreatureX.ResistanceTypeBonus(c)
						Case 0
							' lblBonusPerc(c).Caption = "<None>"
							sInfo = sInfo & "<None>" & vbCrLf
						Case 1
							' lblBonusPerc(c).Caption = "10%"
							sInfo = sInfo & "10%" & vbCrLf
						Case 2
							' lblBonusPerc(c).Caption = "20%"
							sInfo = sInfo & "20%" & vbCrLf
						Case 3
							' lblBonusPerc(c).Caption = "30%"
							sInfo = sInfo & "30%" & vbCrLf
						Case 4
							' lblBonusPerc(c).Caption = "40%"
							sInfo = sInfo & "40%" & vbCrLf
						Case 5
							' lblBonusPerc(c).Caption = "50%"
							sInfo = sInfo & "50%" & vbCrLf
						Case 6
							' lblBonusPerc(c).Caption = "60%"
							sInfo = sInfo & "60%" & vbCrLf
						Case 7
							' lblBonusPerc(c).Caption = "70%"
							sInfo = sInfo & "70%" & vbCrLf
						Case 8
							' lblBonusPerc(c).Caption = "80%"
							sInfo = sInfo & "80%" & vbCrLf
						Case 9
							' lblBonusPerc(c).Caption = "90%"
							sInfo = sInfo & "90%" & vbCrLf
						Case 10
							' lblBonusPerc(c).Caption = "Immune"
							sInfo = sInfo & "Immune" & vbCrLf
						Case 11
							' lblBonusPerc(c).Caption = "Double Damage"
							sInfo = sInfo & "Double Damage" & vbCrLf
						Case 12
							' lblBonusPerc(c).Caption = "Triple Damage"
							sInfo = sInfo & "Triple Damage" & vbCrLf
					End Select
				Case 5
					sInfo = sInfo & "  Sharp: "
					Select Case CreatureX.ResistanceTypeBonus(c)
						Case 0
							' lblBonusPerc(c).Caption = "<None>"
							sInfo = sInfo & "<None>" & vbCrLf
						Case 1
							' lblBonusPerc(c).Caption = "10%"
							sInfo = sInfo & "10%" & vbCrLf
						Case 2
							' lblBonusPerc(c).Caption = "20%"
							sInfo = sInfo & "20%" & vbCrLf
						Case 3
							' lblBonusPerc(c).Caption = "30%"
							sInfo = sInfo & "30%" & vbCrLf
						Case 4
							' lblBonusPerc(c).Caption = "40%"
							sInfo = sInfo & "40%" & vbCrLf
						Case 5
							' lblBonusPerc(c).Caption = "50%"
							sInfo = sInfo & "50%" & vbCrLf
						Case 6
							' lblBonusPerc(c).Caption = "60%"
							sInfo = sInfo & "60%" & vbCrLf
						Case 7
							' lblBonusPerc(c).Caption = "70%"
							sInfo = sInfo & "70%" & vbCrLf
						Case 8
							' lblBonusPerc(c).Caption = "80%"
							sInfo = sInfo & "80%" & vbCrLf
						Case 9
							' lblBonusPerc(c).Caption = "90%"
							sInfo = sInfo & "90%" & vbCrLf
						Case 10
							' lblBonusPerc(c).Caption = "Immune"
							sInfo = sInfo & "Immune" & vbCrLf
						Case 11
							' lblBonusPerc(c).Caption = "Double Damage"
							sInfo = sInfo & "Double Damage" & vbCrLf
						Case 12
							' lblBonusPerc(c).Caption = "Triple Damage"
							sInfo = sInfo & "Triple Damage" & vbCrLf
					End Select
				Case 6
					sInfo = sInfo & "  Sharp: "
					Select Case CreatureX.ResistanceTypeBonus(c)
						Case 0
							' lblBonusPerc(c).Caption = "<None>"
							sInfo = sInfo & "<None>" & vbCrLf
						Case 1
							' lblBonusPerc(c).Caption = "10%"
							sInfo = sInfo & "10%" & vbCrLf
						Case 2
							' lblBonusPerc(c).Caption = "20%"
							sInfo = sInfo & "20%" & vbCrLf
						Case 3
							' lblBonusPerc(c).Caption = "30%"
							sInfo = sInfo & "30%" & vbCrLf
						Case 4
							' lblBonusPerc(c).Caption = "40%"
							sInfo = sInfo & "40%" & vbCrLf
						Case 5
							' lblBonusPerc(c).Caption = "50%"
							sInfo = sInfo & "50%" & vbCrLf
						Case 6
							' lblBonusPerc(c).Caption = "60%"
							sInfo = sInfo & "60%" & vbCrLf
						Case 7
							' lblBonusPerc(c).Caption = "70%"
							sInfo = sInfo & "70%" & vbCrLf
						Case 8
							' lblBonusPerc(c).Caption = "80%"
							sInfo = sInfo & "80%" & vbCrLf
						Case 9
							' lblBonusPerc(c).Caption = "90%"
							sInfo = sInfo & "90%" & vbCrLf
						Case 10
							' lblBonusPerc(c).Caption = "Immune"
							sInfo = sInfo & "Immune" & vbCrLf
						Case 11
							' lblBonusPerc(c).Caption = "Double Damage"
							sInfo = sInfo & "Double Damage" & vbCrLf
						Case 12
							' lblBonusPerc(c).Caption = "Triple Damage"
							sInfo = sInfo & "Triple Damage" & vbCrLf
					End Select
				Case 7
					sInfo = sInfo & "  Sharp: "
					Select Case CreatureX.ResistanceTypeBonus(c)
						Case 0
							' lblBonusPerc(c).Caption = "<None>"
							sInfo = sInfo & "<None>" & vbCrLf
						Case 1
							' lblBonusPerc(c).Caption = "10%"
							sInfo = sInfo & "10%" & vbCrLf
						Case 2
							' lblBonusPerc(c).Caption = "20%"
							sInfo = sInfo & "20%" & vbCrLf
						Case 3
							' lblBonusPerc(c).Caption = "30%"
							sInfo = sInfo & "30%" & vbCrLf
						Case 4
							' lblBonusPerc(c).Caption = "40%"
							sInfo = sInfo & "40%" & vbCrLf
						Case 5
							' lblBonusPerc(c).Caption = "50%"
							sInfo = sInfo & "50%" & vbCrLf
						Case 6
							' lblBonusPerc(c).Caption = "60%"
							sInfo = sInfo & "60%" & vbCrLf
						Case 7
							' lblBonusPerc(c).Caption = "70%"
							sInfo = sInfo & "70%" & vbCrLf
						Case 8
							' lblBonusPerc(c).Caption = "80%"
							sInfo = sInfo & "80%" & vbCrLf
						Case 9
							' lblBonusPerc(c).Caption = "90%"
							sInfo = sInfo & "90%" & vbCrLf
						Case 10
							' lblBonusPerc(c).Caption = "Immune"
							sInfo = sInfo & "Immune" & vbCrLf
						Case 11
							' lblBonusPerc(c).Caption = "Double Damage"
							sInfo = sInfo & "Double Damage" & vbCrLf
						Case 12
							' lblBonusPerc(c).Caption = "Triple Damage"
							sInfo = sInfo & "Triple Damage" & vbCrLf
					End Select
			End Select
		Next 
		' Items
		sInfo = sInfo & "-------------------------" & vbCrLf
		sInfo = sInfo & "Items:" & vbCrLf
		' lstItems.Clear
		iNumItems = CreatureX.Items.Count()
		For c = 1 To iNumItems
			' lstItems.AddItem CreatureX.Items(c).Name
			'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Items().Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sInfo = sInfo & "  " & CreatureX.Items.Item(c).Name & vbCrLf
		Next 
		' Triggers
		sInfo = sInfo & "-------------------------" & vbCrLf
		sInfo = sInfo & "Triggers:" & vbCrLf
		'lstTriggers.Clear
		iNumItems = CreatureX.Triggers.Count()
		For c = 1 To iNumItems
			' lstTriggers.AddItem TriggerName(CreatureX.Triggers(c).TriggerType) & " " & CreatureX.Triggers(c).Name
			'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Triggers(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Triggers().TriggerType. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sInfo = sInfo & "  " & TriggerName(CreatureX.Triggers.Item(c).TriggerType) & " " & CreatureX.Triggers.Item(c).Name & vbCrLf
		Next 
		' Conversations - lstConvos
		sInfo = sInfo & "--------------------------" & vbCrLf
		sInfo = sInfo & "Conversations:" & vbCrLf
		' lstConvos.Clear
		iNumItems = CreatureX.Conversations.Count()
		For c = 1 To iNumItems
			'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Conversations(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If CreatureX.CurrentConvo = CreatureX.Conversations.Item(c).Index Then
				' lstConvos.AddItem "<Default> " & CreatureX.Conversations(c).Name
				'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Conversations().Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				sInfo = sInfo & "  <Default> " & CreatureX.Conversations.Item(c).Name & vbCrLf
			Else
				' lstConvos.AddItem CreatureX.Conversations(c).Name
				'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Conversations().Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				sInfo = sInfo & CreatureX.Conversations.Item(c).Name & vbCrLf
			End If
		Next 
		' Sounds
		sInfo = sInfo & "--------------------------" & vbCrLf
		sInfo = sInfo & "Sounds" & vbCrLf
		For c = 0 To 3
			Select Case c
				Case 0
					sTempWAV = CreatureX.MoveWAV
					sInfo = sInfo & "  Move: "
				Case 1
					sTempWAV = CreatureX.AttackWAV
					sInfo = sInfo & "  Attack: "
				Case 2
					sTempWAV = CreatureX.HitWAV
					sInfo = sInfo & "  Hit: "
				Case 3
					sTempWAV = CreatureX.DieWAV
					sInfo = sInfo & "  Die: "
			End Select
			If sTempWAV = "" Then
				sTempWAV = "[Default]"
			End If
			' txtSoundFile(c) = sTempWAV
			sInfo = sInfo & sTempWAV & vbCrLf
		Next 
		' reset comment displays
		txtInfo.Text = sInfo
		txtInfo.Refresh()
	End Sub
	
	Private Sub DisplayCreaInfo()
		Dim c As Short
		Dim iNumItems As Short
		Dim sTempWAV As String
		Dim strSize(4) As String
		' Describe creature's size
		strSize(4) = "Huge" : strSize(3) = "Large" : strSize(2) = "Normal" : strSize(1) = "Small" : strSize(0) = "Tiny"
		' Default size before load any picture
		Size_Renamed = 1
		' Default to normal picture style (not portrait)
		PictureStyle = 0
		Me.Text = "Creature [" & CreatureX.Name & "]"
		txtName.Text = CreatureX.Name
		txtComments.Text = CreatureX.Comments
		txtRace.Text = CreatureX.Race
		txtSize.Text = "Undefined"
		For c = 0 To 4
			If CreatureX.Size(c) < 0 Then txtSize.Text = strSize(c)
		Next 
		' Load and paint Picture from myPicture
		'    PictureDir = gAppPath & "\data\graphics\creatures"
		PictureDir = gDataPath & "\graphics\creatures"
		TmpPictureFile = CreatureX.PictureFile
		TmpFaceLeft = CreatureX.FaceLeft
		TmpFaceTop = CreatureX.FaceTop
		TmpPortraitFile = CreatureX.PortraitFile
		Select Case PictureStyle
			Case 0 ' Normal Picture
				If Len(TmpPictureFile) > 0 Then
					'ShowMonsPicture2 TmpPictureFile
					ShowMonsPicture(TmpPictureFile)
				End If
			Case 1 ' Portrait Picture
				If Len(TmpPortraitFile) > 0 Then
					ShowMonsPortrait2(TmpPortraitFile)
				End If
		End Select
		chkIsInanimate.CheckState = CreatureX.IsInanimate * CShort(True)
		chkAgressive.CheckState = CreatureX.Agressive * CShort(True)
		chkGuard.CheckState = CreatureX.Guard * CShort(True)
		chkIsMale.CheckState = CreatureX.Male * CShort(True)
		chkFriend.CheckState = CreatureX.Friendly * CShort(True)
		chkDMControlled.CheckState = CreatureX.DMControlled * CShort(True)
		chkGuard.CheckState = CreatureX.Guard * CShort(True)
		chkRequiredInTome.CheckState = CreatureX.RequiredInTome * CShort(True)
		chkRequiredInTome.Refresh()
		txtLevel.Text = CStr(Val(CStr(CreatureX.Level)))
		txtSkillPoints.Text = CStr(Val(CStr(CreatureX.SkillPoints)))
		txtExperiencePoints.Text = CStr(Val(CStr(CreatureX.ExperiencePoints)))
		' family
		For c = 0 To 9
			chkFamily(c).CheckState = CreatureX.Family(c) * CShort(True)
		Next c
		' Combat Rank
		' txtCombatRank = CreatureX.CombatRank
		Select Case CreatureX.CombatRank
			Case 0
				txtCombat.Text = "Random"
			Case 1
				txtCombat.Text = "Back/Ranged"
			Case 2
				txtCombat.Text = "Middle"
			Case 3
				txtCombat.Text = "Front/Melee"
		End Select
		' Statistics
		txtStats(0).Text = CStr(Val(CStr(CreatureX.HPMax)))
		txtStats(1).Text = CStr(Val(CStr(CreatureX.Will))) 'don't know what will is, so I'm assuming intelligence
		txtStats(2).Text = CStr(Val(CStr(CreatureX.Strength)))
		txtStats(3).Text = CStr(Val(CStr(CreatureX.Agility)))
		txtStats(4).Text = CStr(Val(CStr(CreatureX.MovementCost)))
		txtStats(5).Text = CStr(Val(CStr(CreatureX.ActionPointsMax)))
		' Vices
		txtVices(0).Text = CStr(Val(CStr(CreatureX.Lunacy)))
		txtVices(1).Text = CStr(Val(CStr(CreatureX.Revelry)))
		txtVices(2).Text = CStr(Val(CStr(CreatureX.Wrath)))
		txtVices(3).Text = CStr(Val(CStr(CreatureX.Pride)))
		txtVices(4).Text = CStr(Val(CStr(CreatureX.Greed)))
		txtVices(5).Text = CStr(Val(CStr(CreatureX.Lust)))
		' Resistances
		'   CreatureX.BodyType(x)
		'   0 - Wing, 1 - Tail, 2 - Body, 3 - Head, 4 - Arm, 5 - Leg, 6 - Antenna
		'   7 - Tentacle, 8 - Abdomen, 9 - Back, 10 - Neck
		For c = 0 To 7
			lblBody(c).Text = SetUpArmorType(CreatureX.BodyType(c))
			'        Select Case CreatureX.BodyType(c)
			'            Case 0
			'                lblBody(c).Caption = "Wing"
			'            Case 1
			'                lblBody(c).Caption = "Tail"
			'            Case 2
			'                lblBody(c).Caption = "Body"
			'            Case 3
			'                lblBody(c).Caption = "Head"
			'            Case 4
			'                lblBody(c).Caption = "Arm"
			'            Case 5
			'                lblBody(c).Caption = "Leg"
			'            Case 6
			'                lblBody(c).Caption = "Antenna"
			'            Case 7
			'                lblBody(c).Caption = "Tentacle"
			'            Case 8
			'                lblBody(c).Caption = "Abdomen"
			'            Case 9
			'                lblBody(c).Caption = "Back"
			'            Case 10
			'                lblBody(c).Caption = "Neck"
			'        End Select
			lblResPerc(c).Text = CreatureX.Resistance(c) & "%"
		Next 
		' Resistance Bonuses
		For c = 0 To 7
			Select Case CreatureX.ResistanceTypeBonus(c)
				Case 0
					lblBonusPerc(c).Text = "<None>"
				Case 1
					lblBonusPerc(c).Text = "10%"
				Case 2
					lblBonusPerc(c).Text = "20%"
				Case 3
					lblBonusPerc(c).Text = "30%"
				Case 4
					lblBonusPerc(c).Text = "40%"
				Case 5
					lblBonusPerc(c).Text = "50%"
				Case 6
					lblBonusPerc(c).Text = "60%"
				Case 7
					lblBonusPerc(c).Text = "70%"
				Case 8
					lblBonusPerc(c).Text = "80%"
				Case 9
					lblBonusPerc(c).Text = "90%"
				Case 10
					lblBonusPerc(c).Text = "Immune"
				Case 11
					lblBonusPerc(c).Text = "Double Damage"
				Case 12
					lblBonusPerc(c).Text = "Triple Damage"
			End Select
		Next 
		' Items
		lstItems.Items.Clear()
		iNumItems = CreatureX.Items.Count()
		For c = 1 To iNumItems
			'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Items().Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lstItems.Items.Add(CreatureX.Items.Item(c).Name)
		Next 
		' Triggers
		lstTriggers.Items.Clear()
		iNumItems = CreatureX.Triggers.Count()
		For c = 1 To iNumItems
			'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Triggers(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Triggers().TriggerType. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lstTriggers.Items.Add(TriggerName(CreatureX.Triggers.Item(c).TriggerType) & " " & CreatureX.Triggers.Item(c).Name)
		Next 
		' Conversations - lstConvos
		lstConvos.Items.Clear()
		iNumItems = CreatureX.Conversations.Count()
		For c = 1 To iNumItems
			'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Conversations(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If CreatureX.CurrentConvo = CreatureX.Conversations.Item(c).Index Then
				'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Conversations().Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstConvos.Items.Add("<Default> " & CreatureX.Conversations.Item(c).Name)
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Conversations().Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstConvos.Items.Add(CreatureX.Conversations.Item(c).Name)
			End If
		Next 
		' Sounds
		For c = 0 To 3
			Select Case c
				Case 0
					sTempWAV = CreatureX.MoveWAV
				Case 1
					sTempWAV = CreatureX.AttackWAV
				Case 2
					sTempWAV = CreatureX.HitWAV
				Case 3
					sTempWAV = CreatureX.DieWAV
			End Select
			If sTempWAV = "" Then
				sTempWAV = "[Default]"
			End If
			txtSoundFile(c).Text = sTempWAV
		Next 
		' reset comment displays
		txtTriggComm.Text = ""
		txtItemComments.Text = ""
	End Sub
	
	Private Sub ShowMonsPortrait2(ByRef FileName As String)
		
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub ShowMonsPortrait(ByRef FileName As String)
		Dim Tome_Renamed As Object
		Dim X, Y As Short
		Dim NewWidth, NewHeight As Short
		'UPGRADE_WARNING: Arrays in structure bmMons may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmMons As BITMAPINFO
		Dim hMemMons As Integer
		'UPGRADE_WARNING: Arrays in structure bmBlack may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmBlack As BITMAPINFO
		'UPGRADE_WARNING: Arrays in structure bmMask may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmMask As BITMAPINFO
		Dim rc, lpMem, TransparentRGB As Integer
		Dim PortraitFile As String
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor ' Hourglass
		' Load Bitmap
		'    PortraitFile = Dir$(Tome.LoadPath & "\" & FileName)
		'    If PortraitFile = "" Then
		'        PortraitFile = gAppPath & "\data\graphics\portraits\" & FileName
		'    Else
		'        PortraitFile = Tome.LoadPath & "\" & FileName
		'    End If
		' [Titi 2.4.8] added the alternative portraits folders
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If Dir(Tome.LoadPath & "\" & FileName) = FileName Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			PortraitFile = Tome.LoadPath & "\" & FileName
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		ElseIf Dir(Tome.LoadPath & "\Creatures\" & FileName) = FileName Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			PortraitFile = Tome.LoadPath & "\Creatures\" & FileName
			'    ElseIf Dir$(gAppPath & "\Data\Graphics\Creatures\" & FileName) = FileName Then
			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		ElseIf Dir(gDataPath & "\Graphics\Creatures\" & FileName) = FileName Then 
			'        PortraitFile = gAppPath & "\Data\Graphics\Creatures\" & FileName
			PortraitFile = gDataPath & "\Graphics\Creatures\" & FileName
			'    ElseIf Dir$(gAppPath & "\Data\Graphics\Portraits\" & FileName) = FileName Then
			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		ElseIf Dir(gDataPath & "\Graphics\Portraits\" & FileName) = FileName Then 
			'        PortraitFile = gAppPath & "\Data\Graphics\Portraits\" & FileName
			PortraitFile = gDataPath & "\Graphics\Portraits\" & FileName
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		ElseIf Dir(Tome.LoadPath & "\Portraits\" & FileName) = FileName Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			PortraitFile = Tome.LoadPath & "\Portraits\" & FileName
			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		ElseIf Dir(gAppPath & "\Roster\" & WorldNow.Name & "\" & FileName) = FileName Then 
			PortraitFile = gAppPath & "\Roster\" & WorldNow.Name & "\" & FileName
			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		ElseIf Dir(gAppPath & "\Roster\" & WorldNow.Name & "\Creatures\" & FileName) = FileName Then 
			PortraitFile = gAppPath & "\Roster\" & WorldNow.Name & "\Creatures\" & FileName
		Else
			'        PortraitFile = gAppPath & "\Data\Graphics\Creatures\NoSuchFile.bmp"
			PortraitFile = gDataPath & "\Graphics\Creatures\NoSuchFile.bmp"
		End If
		PortraitDir = ClipPath(PortraitFile)
		frmMDI.ShowMsg("Loading Portrait " & FileName & "...")
		' Load Creature bitmap
		ReadBitmapFile(PortraitFile, bmMons, hMemMons, TransparentRGB)
		' Make a copy of the current palette for the Portrait
		'UPGRADE_WARNING: Couldn't resolve default property of object bmBlack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		bmBlack = bmMons
		' Then change Pure Blue to Pure Black
		ChangeColor(bmBlack, TransparentRGB, 0, 0, 0)
		' Paint bitmap to Portrait box using converted palette
		lpMem = GlobalLock(hMemMons)
		picMons.Width = bmMons.bmiHeader.biWidth
		picMons.Height = bmMons.bmiHeader.biHeight
		'UPGRADE_ISSUE: PictureBox property picMons.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchDIBits(picMons.hdc, 0, 0, bmMons.bmiHeader.biWidth, bmMons.bmiHeader.biHeight, 0, 0, bmMons.bmiHeader.biWidth, bmMons.bmiHeader.biHeight, lpMem, bmBlack, DIB_RGB_COLORS, SRCCOPY)
		picMons.Refresh()
		' Convert to Mask and copy to picMask (pure Blue is the mask color)
		MakeMask(bmMons, bmMask, TransparentRGB)
		picMask.Width = bmMons.bmiHeader.biWidth
		picMask.Height = bmMons.bmiHeader.biHeight
		'UPGRADE_ISSUE: PictureBox property picMask.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchDIBits(picMask.hdc, 0, 0, bmMons.bmiHeader.biWidth, bmMons.bmiHeader.biHeight, 0, 0, bmMons.bmiHeader.biWidth, bmMons.bmiHeader.biHeight, lpMem, bmMask, DIB_RGB_COLORS, SRCCOPY)
		picMask.Refresh()
		' Release memory
		rc = GlobalUnlock(hMemMons)
		rc = GlobalFree(hMemMons)
		' Resize Creature to fit in space available
		Size_Renamed = 1
		If picMons.Width > 66 Then
			Size_Renamed = 66 / picMons.Width
		End If
		If picMons.Height * Size_Renamed > 76 Then
			Size_Renamed = 76 / picMons.Height
		End If
		' Center Creature in frame
		X = CShort(picCreature.ClientRectangle.Width - (picMons.Width * Size_Renamed)) / 2
		Y = CShort(picCreature.ClientRectangle.Height - (picMons.Height * Size_Renamed)) / 2
		NewHeight = CShort(picMons.Height * Size_Renamed)
		NewWidth = CShort(picMons.Width * Size_Renamed)
		' Paint Creature
		'UPGRADE_ISSUE: PictureBox method picCreature.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picCreature.Cls()
		'UPGRADE_ISSUE: PictureBox property picCreature.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = SetStretchBltMode(picCreature.hdc, 3)
		'UPGRADE_ISSUE: PictureBox property picMask.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: PictureBox property picCreature.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchBlt(picCreature.hdc, X, Y, NewWidth, NewHeight, picMask.hdc, 0, 0, picMask.Width, picMask.Height, SRCAND)
		'UPGRADE_ISSUE: PictureBox property picMons.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: PictureBox property picCreature.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchBlt(picCreature.hdc, X, Y, NewWidth, NewHeight, picMons.hdc, 0, 0, picMons.Width, picMons.Height, SRCPAINT)
		picCreature.Refresh()
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default ' Default
	End Sub
	
	Private Sub ShowMonsPicture2(ByRef FileName As String)
		Dim X, Y As Short
		Dim NewWidth, NewHeight As Short
		'UPGRADE_WARNING: Arrays in structure bmMons may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmMons As BITMAPINFO
		Dim hMemMons As Integer
		'UPGRADE_WARNING: Arrays in structure bmBlack may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmBlack As BITMAPINFO
		'UPGRADE_WARNING: Arrays in structure bmMask may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmMask As BITMAPINFO
		Dim rc, lpMem, TransparentRGB As Integer
		Dim PictureFile As String
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor ' Hourglass
		ReadBitmapFile(PictureFile, bmMons, hMemMons, TransparentRGB)
		' Resize Creature to fit in space available
		Size_Renamed = 1
		If picMons.Width > picCreature.ClientRectangle.Width Then
			Size_Renamed = picCreature.ClientRectangle.Width / picMons.Width
		End If
		If picMons.Height * Size_Renamed > picCreature.ClientRectangle.Height Then
			Size_Renamed = picCreature.ClientRectangle.Height / picMons.Height
		End If
		' Center Creature in frame
		X = CShort(picCreature.ClientRectangle.Width - (picMons.Width * Size_Renamed)) / 2
		Y = CShort(picCreature.ClientRectangle.Height - (picMons.Height * Size_Renamed)) / 2
		NewHeight = CShort(picMons.Height * Size_Renamed)
		NewWidth = CShort(picMons.Width * Size_Renamed)
		' Paint Creature
		'UPGRADE_ISSUE: PictureBox method picCreature.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picCreature.Cls()
		'UPGRADE_ISSUE: PictureBox property picCreature.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = SetStretchBltMode(picCreature.hdc, 3)
		'UPGRADE_ISSUE: PictureBox property picMons.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: PictureBox property picCreature.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchBlt(picCreature.hdc, X, Y, NewWidth, NewHeight, picMons.hdc, 0, 0, picMons.Width, picMons.Height, SRCPAINT)
		' fraMonsPic.Caption = "Picture (" & Format$(picMons.Width) & "x" & Format$(picMons.Height) & ")"
		picCreature.Refresh()
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub ShowMonsPicture(ByRef FileName As String)
		Dim Tome_Renamed As Object
		Dim X, Y As Short
		Dim NewWidth, NewHeight As Short
		'UPGRADE_WARNING: Arrays in structure bmMons may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmMons As BITMAPINFO
		Dim hMemMons As Integer
		'UPGRADE_WARNING: Arrays in structure bmBlack may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmBlack As BITMAPINFO
		'UPGRADE_WARNING: Arrays in structure bmMask may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmMask As BITMAPINFO
		Dim rc, lpMem, TransparentRGB As Integer
		Dim PictureFile As String
		'UPGRADE_WARNING: Lower bound of array oActivePic was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		Dim oActivePic(2) As System.Windows.Forms.PictureBox
		'UPGRADE_ISSUE: picCreatureCompact was upgraded to a Panel, and cannot be coerced to a PictureBox. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="0FF1188E-27C0-4FED-842D-159C65894C9B"'
		oActivePic(1) = picCreatureCompact
		'UPGRADE_ISSUE: picCreature was upgraded to a Panel, and cannot be coerced to a PictureBox. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="0FF1188E-27C0-4FED-842D-159C65894C9B"'
		oActivePic(2) = picCreature
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor ' Hourglass
		' Load Bitmap
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		PictureFile = Dir(Tome.LoadPath & "\" & FileName)
		If PictureFile = "" Then
			'        PictureFile = gAppPath & "\data\graphics\creatures\" & FileName
			PictureFile = gDataPath & "\graphics\creatures\" & FileName
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			PictureFile = Tome.LoadPath & "\" & FileName
		End If
		PictureDir = ClipPath(PictureFile)
		frmMDI.ShowMsg("Loading Picture " & FileName & "...")
		' Load Creature bitmap
		ReadBitmapFile(PictureFile, bmMons, hMemMons, TransparentRGB)
		' Make a copy of the current palette for the picture
		'UPGRADE_WARNING: Couldn't resolve default property of object bmBlack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		bmBlack = bmMons
		' Then change Pure Blue to Pure Black
		ChangeColor(bmBlack, TransparentRGB, 0, 0, 0)
		' Paint bitmap to picture box using converted palette
		lpMem = GlobalLock(hMemMons)
		picMons.Width = bmMons.bmiHeader.biWidth
		picMons.Height = bmMons.bmiHeader.biHeight
		'UPGRADE_ISSUE: PictureBox property picMons.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchDIBits(picMons.hdc, X, Y, bmMons.bmiHeader.biWidth, bmMons.bmiHeader.biHeight, 0, 0, bmMons.bmiHeader.biWidth, bmMons.bmiHeader.biHeight, lpMem, bmBlack, DIB_RGB_COLORS, SRCCOPY)
		picMons.Refresh()
		' Convert to Mask and copy to picMask (pure Blue is the mask color)
		MakeMask(bmMons, bmMask, TransparentRGB)
		picMask.Width = bmMons.bmiHeader.biWidth
		picMask.Height = bmMons.bmiHeader.biHeight
		'UPGRADE_ISSUE: PictureBox property picMask.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchDIBits(picMask.hdc, 0, 0, bmMons.bmiHeader.biWidth, bmMons.bmiHeader.biHeight, 0, 0, bmMons.bmiHeader.biWidth, bmMons.bmiHeader.biHeight, lpMem, bmMask, DIB_RGB_COLORS, SRCCOPY)
		picMask.Refresh()
		' Release memory
		rc = GlobalUnlock(hMemMons)
		rc = GlobalFree(hMemMons)
		' Resize Creature to fit in space available
		Size_Renamed = 1
		If picMons.Width > VB6.PixelsToTwipsX(oActivePic(iDisplaySize).ClientRectangle.Width) Then
			Size_Renamed = VB6.PixelsToTwipsX(oActivePic(iDisplaySize).ClientRectangle.Width) / picMons.Width
		End If
		If picMons.Height * Size_Renamed > VB6.PixelsToTwipsY(oActivePic(iDisplaySize).ClientRectangle.Height) Then
			Size_Renamed = VB6.PixelsToTwipsY(oActivePic(iDisplaySize).ClientRectangle.Height) / picMons.Height
		End If
		' Center Creature in frame
		X = CShort(VB6.PixelsToTwipsX(oActivePic(iDisplaySize).ClientRectangle.Width) - (picMons.Width * Size_Renamed)) / 2
		Y = CShort(VB6.PixelsToTwipsY(oActivePic(iDisplaySize).ClientRectangle.Height) - (picMons.Height * Size_Renamed)) / 2
		NewHeight = CShort(picMons.Height * Size_Renamed)
		NewWidth = CShort(picMons.Width * Size_Renamed)
		' Paint Creature
		'UPGRADE_ISSUE: PictureBox method oActivePic.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		oActivePic(iDisplaySize).Cls()
		'UPGRADE_ISSUE: PictureBox property oActivePic.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = SetStretchBltMode(oActivePic(iDisplaySize).hdc, 3)
		'UPGRADE_ISSUE: PictureBox property picMask.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: PictureBox property oActivePic.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchBlt(oActivePic(iDisplaySize).hdc, X, Y, NewWidth, NewHeight, picMask.hdc, 0, 0, picMask.Width, picMask.Height, SRCAND)
		'UPGRADE_ISSUE: PictureBox property picMons.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: PictureBox property oActivePic.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchBlt(oActivePic(iDisplaySize).hdc, X, Y, NewWidth, NewHeight, picMons.hdc, 0, 0, picMons.Width, picMons.Height, SRCPAINT)
		'picCreature.Refresh
		' Size shpFace Normal: Width=66, Height=76
		' shpFace.Width = 33 * Size: shpFace.Height = 38 * Size
		'shpFace.Left = X + TmpFaceLeft * Size
		' shpFace.Top = Y + TmpFaceTop * Size
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default ' Default
	End Sub
	
	'UPGRADE_WARNING: Event lstTriggers.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstTriggers_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstTriggers.SelectedIndexChanged
		'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Triggers().Comments. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtTriggComm.Text = CreatureX.Triggers.Item(lstTriggers.SelectedIndex + 1).Comments
	End Sub
	
	'UPGRADE_WARNING: Event lstItems.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstItems_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstItems.SelectedIndexChanged
		'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Items().Comments. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtItemComments.Text = CreatureX.Items.Item(lstItems.SelectedIndex + 1).Comments
	End Sub
	
	' -------------------------------------------------------------------
	' code below is to keep the user from editing displayed creature info
	Private Sub chkAgressive_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles chkAgressive.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		If chkAgressive.CheckState Then
			chkAgressive.CheckState = System.Windows.Forms.CheckState.Unchecked
		Else : chkAgressive.CheckState = System.Windows.Forms.CheckState.Checked
		End If
		Beep()
	End Sub
	
	Private Sub chkDMControlled_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles chkDMControlled.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		If chkDMControlled.CheckState Then
			chkDMControlled.CheckState = System.Windows.Forms.CheckState.Unchecked
		Else : chkDMControlled.CheckState = System.Windows.Forms.CheckState.Checked
		End If
		Beep()
	End Sub
	
	Private Sub chkFamily_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles chkFamily.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Dim Index As Short = chkFamily.GetIndex(eventSender)
		If chkFamily(Index).CheckState Then
			chkFamily(Index).CheckState = System.Windows.Forms.CheckState.Unchecked
		Else : chkFamily(Index).CheckState = System.Windows.Forms.CheckState.Checked
		End If
		Beep()
	End Sub
	
	Private Sub chkFriend_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles chkFriend.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		If chkFriend.CheckState Then
			chkFriend.CheckState = System.Windows.Forms.CheckState.Unchecked
		Else : chkFriend.CheckState = System.Windows.Forms.CheckState.Checked
		End If
		Beep()
	End Sub
	
	Private Sub chkGuard_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles chkGuard.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		If chkGuard.CheckState Then
			chkGuard.CheckState = System.Windows.Forms.CheckState.Unchecked
		Else : chkGuard.CheckState = System.Windows.Forms.CheckState.Checked
		End If
		Beep()
	End Sub
	
	Private Sub chkIsInanimate_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles chkIsInanimate.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		If chkIsInanimate.CheckState Then
			chkIsInanimate.CheckState = System.Windows.Forms.CheckState.Unchecked
		Else : chkIsInanimate.CheckState = System.Windows.Forms.CheckState.Checked
		End If
		Beep()
	End Sub
	
	Private Sub chkIsMale_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles chkIsMale.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		If chkIsMale.CheckState Then
			chkIsMale.CheckState = System.Windows.Forms.CheckState.Unchecked
		Else : chkIsMale.CheckState = System.Windows.Forms.CheckState.Checked
		End If
		Beep()
	End Sub
	
	Private Sub chkRequiredInTome_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles chkRequiredInTome.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		If chkRequiredInTome.CheckState Then
			chkRequiredInTome.CheckState = System.Windows.Forms.CheckState.Unchecked
		Else : chkRequiredInTome.CheckState = System.Windows.Forms.CheckState.Checked
		End If
		Beep()
	End Sub
	
	Private Sub txtCombat_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCombat.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Beep()
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtComments_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtComments.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Beep()
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtDataPath_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDataPath.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Beep()
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtExperiencePoints_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtExperiencePoints.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Beep()
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtInfo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtInfo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Beep()
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtItemComments_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtItemComments.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Beep()
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtLevel_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLevel.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Beep()
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Beep()
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtRace_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtRace.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Beep()
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtSize_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSize.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Beep()
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtSkillPoints_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSkillPoints.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Beep()
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtSoundFile_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSoundFile.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = txtSoundFile.GetIndex(eventSender)
		Beep()
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtStats_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtStats.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = txtStats.GetIndex(eventSender)
		Beep()
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtTriggComm_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTriggComm.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Beep()
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtVices_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVices.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = txtVices.GetIndex(eventSender)
		Beep()
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
End Class