Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frmWorldSettings
	Inherits System.Windows.Forms.Form
	
	Public FileName As String
	Public blnChangeValue, blnZoomOut As Boolean
	Public Dirty As Short
	'UPGRADE_NOTE: MouseClick was upgraded to MouseClick_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	'UPGRADE_NOTE: MouseDown was upgraded to MouseDown_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Dim MouseDown_Renamed As Boolean
	Dim MouseClick_Renamed, intNbClicks, intPicIndex As Short
	'UPGRADE_NOTE: Size was upgraded to Size_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Dim DeltaX, DeltaY As Integer
	Dim Size_Renamed(7) As Single
	Dim OffsetX(7) As Integer
	Dim OffsetY(7) As Integer
	
	Private Const BIF_RETURNONLYFSDIRS As Short = 1
	Private Const BIF_DONTGOBELOWDOMAIN As Short = 2
	Private Const MAX_PATH As Short = 260
	'UPGRADE_WARNING: Structure BrowseInfo may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function SHBrowseForFolder Lib "shell32" (ByRef lpbi As BrowseInfo) As Integer
	Private Declare Function SHGetPathFromIDList Lib "shell32" (ByVal pidList As Integer, ByVal lpBuffer As String) As Integer
	
	Private Structure BrowseInfo
		Dim hWndOwner As Integer
		Dim pIDLRoot As Integer
		Dim pszDisplayName As Integer
		Dim lpszTitle As Integer
		Dim ulFlags As Integer
		Dim lpfnCallback As Integer
		Dim lParam As Integer
		Dim iImage As Integer
	End Structure
	
	Public Sub btnQuit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnQuit.Click
		Dim rep As String
		If Dirty Then
			' changes made
			rep = CStr(MsgBox("Do you want to save the modifications?", MsgBoxStyle.YesNo, "World settings changed"))
			If rep = CStr(MsgBoxResult.Yes) Then
				' save world
				btnSave_Click(btnSave, New System.EventArgs())
			End If
		End If
		Dirty = False
		Me.Close()
		'    If frmMDI.Dirty <> 250 Then
		frmMDI.NewTome() ' [Titi 2.5.1] start a new tome only if the world settings window is not closed while exiting the creator
	End Sub
	
	Private Sub btnLeftRoster_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnLeftRoster.Click
		'UPGRADE_NOTE: Text was upgraded to Text_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim strPicturesList, strKingdom, Text_Renamed, strPictureName As String
		Dim i, intNbPic As Short
		intNbClicks = intNbClicks - 1
		FileName = gAppPath & "\roster\" & WorldNow.Name & "\" & WorldNow.Name & ".ini"
		With Me
			intNbPic = -1
			strPicturesList = strKingdomPictures(.TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True))
			While VB.Left(strPicturesList, 1) <> "|" ' While Len(strPicturesList) > 6
				' determine how many pictures are available
				intNbPic = intNbPic + 1
				' get only the name
				strPictureName = VB.Left(strPicturesList, InStr(strPicturesList, "|") - 1)
				' advance to next picture
				strPicturesList = VB.Right(strPicturesList, Len(strPicturesList) - Len(strPictureName))
				strPicturesList = VB.Right(strPicturesList, Len(strPicturesList) - InStr(strPicturesList, ","))
			End While
			If intNbPic = -1 Then Exit Sub ' no pictures: world under construction
			Dim strListPicturesNames(intNbPic) As Object
			Dim lTop(intNbPic) As Integer
			Dim lLeft(intNbPic) As Integer
			intNbPic = -1
			strPicturesList = .txtKingdomPictures.Text
			While VB.Left(strPicturesList, 1) <> "|"
				intNbPic = intNbPic + 1
				' get only the name
				strPictureName = VB.Left(strPicturesList, InStr(strPicturesList, "|") - 1)
				' advance to next picture
				strPicturesList = VB.Right(strPicturesList, Len(strPicturesList) - Len(strPictureName))
				lLeft(intNbPic) = Val(BreakText(strPicturesList, 2)) * VB6.TwipsPerPixelX
				lTop(intNbPic) = Val(BreakText(strPicturesList, 3)) * VB6.TwipsPerPixelY
				strPicturesList = VB.Right(strPicturesList, Len(strPicturesList) - InStr(strPicturesList, ","))
				'UPGRADE_WARNING: Couldn't resolve default property of object strListPicturesNames(intNbPic). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strListPicturesNames(intNbPic) = Trim(strPictureName)
			End While
			For i = 0 To 5
				If i + intNbClicks <= intNbPic Then
					' default shape dimensions
					.shpFace(i).Height = VB6.TwipsToPixelsY(480)
					.shpFace(i).Width = VB6.TwipsToPixelsX(375)
					.shpFace(i).Left = VB6.TwipsToPixelsX(lLeft(i + intNbClicks))
					.shpFace(i).Top = VB6.TwipsToPixelsY(lTop(i + intNbClicks))
					'                If Dir$(gAppPath & "\Data\Graphics\Creatures\" & strListPicturesNames(i + intNbClicks)) = "" Then
					'UPGRADE_WARNING: Couldn't resolve default property of object strListPicturesNames(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
					If Dir(gDataPath & "\Graphics\Creatures\" & strListPicturesNames(i + intNbClicks)) = "" Then
						' oops! picture missing
						'                    Set .picMons = LoadPicture(gAppPath & "\Data\Graphics\Creatures\NoSuchFile.bmp")
						.picMons.Image = System.Drawing.Image.FromFile(gDataPath & "\Graphics\Creatures\NoSuchFile.bmp")
						'                    Text = gAppPath & "\Data\Graphics\Creatures\NoSuchFile.bmp"
						Text_Renamed = gDataPath & "\Graphics\Creatures\NoSuchFile.bmp"
					Else
						'                    Set .picMons = LoadPicture(gAppPath & "\Data\Graphics\Creatures\" & strListPicturesNames(i + intNbClicks))
						'UPGRADE_WARNING: Couldn't resolve default property of object strListPicturesNames(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						.picMons.Image = System.Drawing.Image.FromFile(gDataPath & "\Graphics\Creatures\" & strListPicturesNames(i + intNbClicks))
						'                   Text = gAppPath & "\Data\Graphics\Creatures\" & strListPicturesNames(i + intNbClicks)
						'UPGRADE_WARNING: Couldn't resolve default property of object strListPicturesNames(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						Text_Renamed = gDataPath & "\Graphics\Creatures\" & strListPicturesNames(i + intNbClicks)
					End If
					'                Set .picInhabitant(i) = LoadPicture(gAppPath & "\Data\Stock\blankchar.bmp")
					.picInhabitant(i) = System.Drawing.Image.FromFile(gDataPath & "\Stock\blankchar.bmp")
					'UPGRADE_ISSUE: frmWorldSettings.picInhabitant() was upgraded to a Panel, and cannot be coerced to a PictureBox. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="0FF1188E-27C0-4FED-842D-159C65894C9B"'
					ResizePicture(.picMons, .picInhabitant(i), .shpFace(i), i, Text_Renamed)
					'UPGRADE_WARNING: Couldn't resolve default property of object strListPicturesNames(i + intNbClicks). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					.txtPictureName(i).Text = strListPicturesNames(i + intNbClicks)
				End If
			Next 
			If .picInhabitant(5).Name <> "bones.bmp" Then btnRightRoster.Visible = True
		End With
		If intNbClicks = 0 Then btnLeftRoster.Visible = False
	End Sub
	
	Private Sub btnRightRoster_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnRightRoster.Click
		'UPGRADE_NOTE: Text was upgraded to Text_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim strPicturesList, Text_Renamed, strPictureName As String
		Dim i, intNbPic As Short
		If intNbClicks = 3 Then
			MsgBox("For the time being, each kingdom can only have 9 pictures per gender." & vbCrLf & "No more picture will be added.")
			Exit Sub
		End If
		intNbClicks = intNbClicks + 1
		If intNbClicks >= 1 Then btnLeftRoster.Visible = True
		With Me
			intNbPic = -1
			strPicturesList = .txtKingdomPictures.Text
			While VB.Left(strPicturesList, 1) <> "|"
				' determine how many pictures are available
				intNbPic = intNbPic + 1
				' get only the name
				strPictureName = BreakText(strPicturesList, 1)
				' advance to next picture
				strPicturesList = VB.Right(strPicturesList, Len(strPicturesList) - Len(strPictureName))
				strPicturesList = VB.Right(strPicturesList, Len(strPicturesList) - InStr(strPicturesList, ","))
			End While
			If intNbPic = -1 Then Exit Sub ' no pictures: world under construction
			Dim strListPicturesNames(intNbPic) As String
			Dim lTop(intNbPic) As Integer
			Dim lLeft(intNbPic) As Integer
			intNbPic = -1
			strPicturesList = .txtKingdomPictures.Text
			While VB.Left(strPicturesList, 1) <> "|"
				intNbPic = intNbPic + 1
				strPictureName = BreakText(strPicturesList, 1)
				' get only the name
				' advance to next picture
				strPicturesList = VB.Right(strPicturesList, Len(strPicturesList) - Len(strPictureName))
				lLeft(intNbPic) = Val(BreakText(strPicturesList, 2)) * VB6.TwipsPerPixelX
				lTop(intNbPic) = Val(BreakText(strPicturesList, 3)) * VB6.TwipsPerPixelY
				strPicturesList = VB.Right(strPicturesList, Len(strPicturesList) - InStr(strPicturesList, ","))
				strListPicturesNames(intNbPic) = Trim(strPictureName)
			End While
			For i = 0 To 5
				If i + intNbClicks <= intNbPic Then
					'                If Dir$(gAppPath & "\Data\Graphics\Creatures\" & strListPicturesNames(i + intNbClicks)) = "" Then
					'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
					If Dir(gDataPath & "\Graphics\Creatures\" & strListPicturesNames(i + intNbClicks)) = "" Then
						' oops! picture missing
						'                    Set .picMons = LoadPicture(gAppPath & "\Data\Graphics\Creatures\NoSuchFile.bmp")
						.picMons.Image = System.Drawing.Image.FromFile(gDataPath & "\Graphics\Creatures\NoSuchFile.bmp")
						'                    Text = gAppPath & "\Data\Graphics\Creatures\NoSuchFile.bmp"
						Text_Renamed = gDataPath & "\Graphics\Creatures\NoSuchFile.bmp"
					Else
						'                    Set .picMons = LoadPicture(gAppPath & "\Data\Graphics\Creatures\" & strListPicturesNames(i + intNbClicks))
						.picMons.Image = System.Drawing.Image.FromFile(gDataPath & "\Graphics\Creatures\" & strListPicturesNames(i + intNbClicks))
						'                    Text = gAppPath & "\Data\Graphics\Creatures\" & strListPicturesNames(i + intNbClicks)
						Text_Renamed = gDataPath & "\Graphics\Creatures\" & strListPicturesNames(i + intNbClicks)
					End If
					'                Set .picInhabitant(i) = LoadPicture(gAppPath & "\Data\Stock\blankchar.bmp")
					.picInhabitant(i) = System.Drawing.Image.FromFile(gDataPath & "\Stock\blankchar.bmp")
					.txtPictureName(i).Text = strListPicturesNames(i + intNbClicks)
					' default shape dimensions
					.shpFace(i).Height = VB6.TwipsToPixelsY(480)
					.shpFace(i).Width = VB6.TwipsToPixelsX(375)
					' shape position
					.shpFace(i).Top = VB6.TwipsToPixelsY(lTop(i + intNbClicks))
					.shpFace(i).Left = VB6.TwipsToPixelsX(lLeft(i + intNbClicks))
					'UPGRADE_ISSUE: frmWorldSettings.picInhabitant() was upgraded to a Panel, and cannot be coerced to a PictureBox. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="0FF1188E-27C0-4FED-842D-159C65894C9B"'
					ResizePicture(.picMons, .picInhabitant(i), .shpFace(i), i, Text_Renamed)
				Else
					'                Set .picMons = LoadPicture(gAppPath & "\Data\Graphics\Creatures\bones.bmp")
					.picMons.Image = System.Drawing.Image.FromFile(gDataPath & "\Graphics\Creatures\bones.bmp")
					'                Set .picInhabitant(i) = LoadPicture(gAppPath & "\Data\Stock\blankchar.bmp")
					.picInhabitant(i) = System.Drawing.Image.FromFile(gDataPath & "\Stock\blankchar.bmp")
					' default shape dimensions
					.shpFace(i).Height = VB6.TwipsToPixelsY(480)
					.shpFace(i).Width = VB6.TwipsToPixelsX(375)
					'                ResizePicture .picMons, .picInhabitant(i), .shpFace(i), i, gAppPath & "\Data\Graphics\Creatures\bones.bmp"
					'UPGRADE_ISSUE: frmWorldSettings.picInhabitant() was upgraded to a Panel, and cannot be coerced to a PictureBox. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="0FF1188E-27C0-4FED-842D-159C65894C9B"'
					ResizePicture(.picMons, .picInhabitant(i), .shpFace(i), i, gDataPath & "\Graphics\Creatures\bones.bmp")
					.txtPictureName(i).Text = ""
					btnRightRoster.Visible = False
				End If
			Next 
		End With
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub btnSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnSave.Click
		Dim Tome_Renamed As Object
		Dim hndSaveFile, i As Short
		Dim strName, strTmp As String
		With Me
			' [Titi 2.4.9] verify if file name is valid
			strName = WorldNow.Name
			While frmMDI.CheckName(strName) > 0
				strName = InputBox("Make sure the file name does not contain ?/<>*|\:" & Chr(34), "Invalid character found!", strName)
			End While
			If strName = "" Then
				MsgBox("Action cancelled. The world has NOT been SAVED.",  , "Save failed!")
				Exit Sub
			Else
				WorldNow.Name = strName
				.txtWorldName.Text = WorldNow.Name
				FileName = gAppPath & "\Roster\" & WorldNow.Name & "\" & WorldNow.Name & ".ini"
			End If
			strName = VB.Left(WorldNow.PicDesc, InStr(WorldNow.PicDesc, "|") - 1)
			If InStr(strName, "\") > 0 Then strName = VB.Right(strName, InStrRev(strName, "\"))
			strTmp = VB.Right(WorldNow.PicDesc, Len(WorldNow.PicDesc) - InStr(WorldNow.PicDesc, "|"))
			If InStr(strTmp, "\") > 0 Then strTmp = VB.Right(strName, InStrRev(strName, "\"))
			WorldNow.PicDesc = strName & "|" & strTmp
			' Check if world folder already created...
			If Not oFileSys.CheckExists(gAppPath & "\Roster\" & WorldNow.Name, clsInOut.IOActionType.Folder, True) Then FileName = gAppPath & "\Roster\" & WorldNow.Name & "\" & WorldNow.Name & ".ini"
			' copy map to world folder if necessary
			If Not oFileSys.CheckExists(gAppPath & "\Roster\" & WorldNow.Name & "\" & WorldNow.PictureFile, clsInOut.IOActionType.File) Then oFileSys.Copy((Me.txtWorldMap).Text, gAppPath & "\Roster\" & WorldNow.Name & "\" & WorldNow.PictureFile, clsInOut.IOActionType.File)
			' [Titi 2.4.9] copy description pictures to world folder if necessary
			If Not oFileSys.CheckExists(gAppPath & "\Roster\" & WorldNow.Name & "\" & VB.Left(WorldNow.PicDesc, InStr(WorldNow.PicDesc, "|") - 1), clsInOut.IOActionType.File) Then oFileSys.Copy(Me.txtPicDescName(0).Text, gAppPath & "\Roster\" & WorldNow.Name & "\" & VB.Left(WorldNow.PicDesc, InStr(WorldNow.PicDesc, "|") - 1), clsInOut.IOActionType.File)
			If Not oFileSys.CheckExists(gAppPath & "\Roster\" & WorldNow.Name & "\" & VB.Right(WorldNow.PicDesc, Len(WorldNow.PicDesc) - InStr(WorldNow.PicDesc, "|")), clsInOut.IOActionType.File) Then oFileSys.Copy(Me.txtPicDescName(1).Text, gAppPath & "\Roster\" & WorldNow.Name & "\" & VB.Right(WorldNow.PicDesc, Len(WorldNow.PicDesc) - InStr(WorldNow.PicDesc, "|")), clsInOut.IOActionType.File)
			' but get rid of BlankMap.bmp
			If VB.Left(WorldNow.PicDesc, InStr(WorldNow.PicDesc, "|") - 1) = "blankmap.bmp" Or VB.Right(WorldNow.PicDesc, Len(WorldNow.PicDesc) - InStr(WorldNow.PicDesc, "|")) = "blankmap.bmp" Then Kill(gAppPath & "\Roster\" & WorldNow.Name & "\blankmap.bmp")
			WorldNow.PicDesc = IIf(strName <> "blankmap.bmp", strName, vbNullString) & IIf(strTmp <> "blankmap.bmp", IIf(strName <> "blankmap.bmp", "|" & strTmp, strTmp), vbNullString)
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Tome.Name = "Untitled" Or Tome.Name = "Default" Then
				' quitting without having defined anything
				'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Tome.Name = WorldNow.Name
				'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Tome.LoadPath = gAppPath & "\Roster\" & WorldNow.Name
				'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Tome.FileName = Tome.Name & ".tom"
			End If
			hndSaveFile = FreeFile
			FileOpen(hndSaveFile, FileName, OpenMode.Output)
			PrintLine(hndSaveFile, "[World]")
			PrintLine(hndSaveFile, "Name=" & WorldNow.Name)
			PrintLine(hndSaveFile, "Kingdoms=" & WorldNow.Kingdoms.Count())
			PrintLine(hndSaveFile, "PictureFile=" & WorldNow.PictureFile)
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			PrintLine(hndSaveFile, "Tome=" & Tome.FileName)
			PrintLine(hndSaveFile, "Intro=" & .txtIntroMusic.Text)
			PrintLine(hndSaveFile, "MusicFolder=" & .txtMusicFolder.Text)
			PrintLine(hndSaveFile, "Currency=" & .txtMoney(0).Text & "|" & .txtMoney(1).Text)
			' [Titi 2.4.9b] customize the name of the character's property used for magic
			PrintLine(hndSaveFile, "Magic=" & .txtMagicName.Text)
			PrintLine(hndSaveFile, "Runes=" & .chkRunes.CheckState)
			PrintLine(hndSaveFile, "Formula=" & .txtCoef.Text & " " & .lblFormulaBasis.Text)
			PrintLine(hndSaveFile, "MagicPerLevel=" & .txtMagicPerLevel.Text)
			PrintLine(hndSaveFile, "RandomizeMagic=" & .chkMagicPerLevel.CheckState)
			' [Titi 2.4.9] customize HP and SkillPoints earned
			PrintLine(hndSaveFile, "SkillPtsPerLevel=" & .txtSkillPtsPerLevel.Text)
			PrintLine(hndSaveFile, "HPPerLevel=" & .txtHPperLevel.Text)
			PrintLine(hndSaveFile, "RandomizeHP=" & .chkRandHP.CheckState)
			' [Titi 2.6.0] special interface selection
			PrintLine(hndSaveFile, "InterfaceName=" & strInterfaceName)
			' [Titi 2.4.9] comments for the options page
			For i = 1 To Len(WorldNow.Description)
				' {enter} is not supported in ini files
				If Mid(WorldNow.Description, i, 1) = Chr(13) Then WorldNow.Description = VB.Left(WorldNow.Description, i - 1) & "_" & Mid(WorldNow.Description, i + 2)
			Next 
			PrintLine(hndSaveFile, "DescriptionLines=" & Trim(Str(Int((Len(WorldNow.Description) + 99) / 100))))
			' each line is about 100 characters for the display in the player
			strTmp = WorldNow.Description : strName = ""
			For i = 1 To Int((Len(WorldNow.Description) + 99) / 100)
				If i > 1 Then strName = Mid(strTmp, IIf(InStrRev(strTmp, Chr(32)) > InStrRev(strTmp, "."), InStrRev(strTmp, Chr(32)), InStrRev(strTmp, "."))) ' get the last "word" of the previous division
				If Len(strName & strTmp) > 100 Then
					' add the last "word" of the previous line and take the following "line" of 100 characters
					strTmp = strName & Mid(WorldNow.Description, i * 100 - 99, 100)
				Else
					strTmp = strName & Mid(WorldNow.Description, i * 100 - 99) & " "
				End If
				' don't take the part after the last space or dot (might be a word badly clipped)
				strName = VB.Left(strTmp, IIf(InStrRev(strTmp, Chr(32)) > InStrRev(strTmp, "."), InStrRev(strTmp, Chr(32)), InStrRev(strTmp, ".")))
				PrintLine(hndSaveFile, "Description" & Trim(Str(i)) & "=" & strName)
			Next 
			PrintLine(hndSaveFile, "PicDesc=" & WorldNow.PicDesc)
			For i = 1 To WorldNow.Kingdoms.Count()
				'            Print #hndSaveFile, Chr(13)
				PrintLine(hndSaveFile, "[Kingdom" & Trim(Str(i)) & "]")
				PrintLine(hndSaveFile, "Name=" & strKingdomNames(i))
				PrintLine(hndSaveFile, "Location=" & strKingdomLocation(i))
				PrintLine(hndSaveFile, "Template=" & strKingdomTemplate(i))
				PrintLine(hndSaveFile, "PictureFilesMale=" & strKingdomPictures(i))
				PrintLine(hndSaveFile, "PictureFilesFemale=" & strKingdomPictures(i + WorldNow.Kingdoms.Count()))
				PrintLine(hndSaveFile, "NameSet=" & strKingdomSet(i))
			Next 
			FileClose(hndSaveFile)
			' [Titi 2.5.1] save frmMDI.Dirty
			Dirty = frmMDI.Dirty
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmMDI.SaveTome(gAppPath & "\Roster\" & WorldNow.Name & "\" & Tome.FileName)
			frmMDI.Dirty = Dirty ' [Titi 2.5.1] that way, we can check if the wizard has to be run or not
			Dirty = False
		End With
	End Sub
	
	Private Sub btnZoomOut_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnZoomOut.Click
		blnZoomOut = 1 + CShort(blnZoomOut)
		btnZoomOut.Text = IIf(blnZoomOut, "-", "+")
		Me.TabStrip1.SelectedItem.Selected = True
	End Sub
	
	'UPGRADE_WARNING: Event chkMagicPerLevel.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkMagicPerLevel_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkMagicPerLevel.CheckStateChanged
		If blnChangeValue Then
			chkMagicPerLevel.Enabled = 1 - CShort(chkMagicPerLevel.Enabled)
			Dirty = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event chkRandHP.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkRandHP_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkRandHP.CheckStateChanged
		If blnChangeValue Then
			chkRandHP.Enabled = 1 - CShort(chkRandHP.Enabled) ' .Value = 1 - chkRandHP.Value
			Dirty = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event chkRunes.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkRunes_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkRunes.CheckStateChanged
		If blnChangeValue Then
			chkRunes.Enabled = 1 - CShort(chkRunes.Enabled)
			WorldNow.Runes = chkRunes.CheckState
			Dirty = True
		End If
	End Sub
	
	Private Sub NewStat(ByRef sName As String, ByRef bRemove As Boolean, ByRef bShowTome As Boolean)
		Dim TriggerZ, TriggerX, TriggerY, NewTrig As Trigger
		Dim CreatureX As Creature
		Dim bFound As Boolean
		For	Each CreatureX In Tome.Creatures
			bFound = False
			For	Each TriggerX In CreatureX.Triggers
				If TriggerX.Name = "New Abilities" Then
					For	Each TriggerY In TriggerX.Triggers
						For	Each TriggerZ In TriggerY.Triggers
							If TriggerZ.Name = sName Then
								If bRemove Then
									TriggerY.RemoveTrigger("T" & TriggerZ.Index)
								Else
									bFound = True
								End If
							End If
						Next TriggerZ
						If bRemove = False And Not bFound Then
							NewTrig = TriggerY.AddTrigger
							NewTrig.Name = sName
						End If
					Next TriggerY
				End If
			Next TriggerX
		Next CreatureX
		' [Titi 2.4.9b] The following has for only purpose to update the tree view with the latest triggers
		If bShowTome Then frmMDI.ShowTome(Tome)
	End Sub
	
	'UPGRADE_WARNING: Event chkStats.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkStats_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkStats.CheckStateChanged
		Dim Index As Short = chkStats.GetIndex(eventSender)
		Dim sName As String
		Dim i As Short
		Dim Found As Boolean
		If blnChangeValue = False Then Exit Sub
		Dirty = True
		If Index < 10 And chkStats(Index).CheckState = 1 Then
			For i = 3 To 11
				If chkStats(i).CheckState = 0 Then
					chkStats(i).Visible = True
					Exit For
				End If
			Next 
			chkStats(Index).Text = ""
			Do 
				sName = InputBox("What will be the name of this property?", "Creatures statistics")
				Found = False
				For i = 0 To 11
					If chkStats(i).Text = sName Then
						MsgBox("The name " & sName & " already exists. Choose another one.", MsgBoxStyle.OKOnly, "Duplicate names")
						Found = True
					End If
				Next 
			Loop Until Found = False
			If sName <> "" Then
				chkStats(Index).Text = sName
				cmbMagicBasis.Items.Add(chkStats(Index).Text)
				NewStat(chkStats(Index).Text, False, True)
			Else
				chkStats(Index).CheckState = System.Windows.Forms.CheckState.Unchecked
			End If
		ElseIf Index < 9 And chkStats(Index).CheckState = 0 And Index > 2 Then 
			For i = 3 To 11
				If chkStats(i).CheckState = 0 And i <> Index Then
					chkStats(i).Visible = False
				End If
			Next 
			i = 0
			While i < cmbMagicBasis.Items.Count
				If VB6.GetItemString(cmbMagicBasis, i) = chkStats(Index).Text Then
					cmbMagicBasis.Items.RemoveAt(i)
					NewStat(chkStats(Index).Text, True, True)
				Else
					i = i + 1
				End If
			End While
		Else
			MsgBox("You've reached the maximum number of stats allowed!", MsgBoxStyle.OKOnly, "Creatures statistics")
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmbInterface.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbInterface_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbInterface.SelectedIndexChanged
		If blnChangeValue Then
			strInterfaceName = VB6.GetItemString(cmbInterface, cmbInterface.SelectedIndex)
			Dirty = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmbMagicBasis.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbMagicBasis_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbMagicBasis.SelectedIndexChanged
		If blnChangeValue Then
			lblFormulaBasis.Text = VB.Left(lblFormulaBasis.Text, 1) & " " & VB6.GetItemString(cmbMagicBasis, cmbMagicBasis.SelectedIndex)
			WorldNow.Formula = lblFormulaBasis.Text
			Dirty = True
		End If
	End Sub
	
	Private Sub frmWorldSettings_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		If TypeOf Me.ActiveControl Is System.Windows.Forms.TextBox Then
			CtrlKey(Me.ActiveControl, KeyCode, Shift)
		End If
	End Sub
	
	Private Sub frmWorldSettings_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim NewLargeChange As Short
		' ResolutionRefX|Y is the display in which the form was created
		' ResolutionX|Y is the current display
		' RatioX|Y is the resizing factor between these two
		Const ResolutionRefX As Integer = 800
		Const ResolutionRefY As Integer = 600
		Dim RatioY, RatioX, Ratio As Single
		Dim ResolutionX, ResolutionY As Integer
		Dim ctrl As System.Windows.Forms.Control
		Dim ligne As Microsoft.VisualBasic.PowerPacks.LineShape
		' check if resolution fits
		ResolutionX = VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) / VB6.TwipsPerPixelX
		ResolutionY = VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) / VB6.TwipsPerPixelY
		RatioX = ResolutionX / ResolutionRefX
		RatioY = ResolutionY / ResolutionRefY
		Ratio = RatioX
		' use smaller ratio to avoid stretching
		If RatioY < Ratio Then Ratio = RatioY
		If Ratio > 1.25 Then Ratio = 1.25
		RatioX = Ratio
		RatioY = Ratio
		' prevent resizing in width in lower resolution
		If Ratio < 1 Then
			RatioX = 1
			RatioY = 1.1 * RatioY
		End If
		' fit to smaller display
		Me.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Width) * RatioX)
		Me.Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Height) * RatioY)
		For	Each ctrl In Me.Controls
			'UPGRADE_WARNING: TypeOf has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If TypeOf ctrl Is System.Windows.Forms.ComboBox Then
				' the height property is read-only for comboboxes. Test not needed today, but who knows?
				ctrl.SetBounds(VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(ctrl.Left) * RatioX), VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(ctrl.Top) * RatioY), VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(ctrl.Width) * RatioX), 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y Or Windows.Forms.BoundsSpecified.Width)
				'            ctrl.Move ctrl.Left * Ratio, ctrl.Top * Ratio, ctrl.Width * Ratio
				'UPGRADE_WARNING: TypeOf has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			ElseIf TypeOf ctrl Is System.Windows.Forms.ToolStripMenuItem Then 
				' do nothing
				'UPGRADE_WARNING: TypeOf has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			ElseIf TypeOf ctrl Is Microsoft.VisualBasic.PowerPacks.LineShape Then 
				' keep it for later
				ligne = ctrl
			Else
				ctrl.SetBounds(VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(ctrl.Left) * RatioX), VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(ctrl.Top) * RatioY), VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(ctrl.Width) * RatioX), VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(ctrl.Height) * RatioY))
				'            ctrl.Move ctrl.Left * Ratio, ctrl.Top * Ratio, ctrl.Width * Ratio, ctrl.Height * Ratio
			End If
			'UPGRADE_WARNING: TypeOf has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ctrl.FontSize. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If TypeOf ctrl Is System.Windows.Forms.Label Or TypeOf ctrl Is System.Windows.Forms.TextBox Or TypeOf ctrl Is System.Windows.Forms.Button Or TypeOf ctrl Is System.Windows.Forms.ComboBox Then ctrl.Font = VB6.FontChangeSize(ctrl.Font, ctrl.FontSize * Ratio) 'Font
			'UPGRADE_WARNING: TypeOf has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If TypeOf ctrl Is AxComctlLib.AxTabStrip Then ctrl.Font = VB6.FontChangeSize(ctrl.Font, ctrl.Font.SizeInPoints * Ratio)
		Next ctrl
		' now, move the line the middle of the frame
		ligne.X1 = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(fraStats.Width) / 2) : ligne.X2 = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(ligne.X1)) : ligne.Y2 = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(fraStats.Height) - 40)
		' default (blank) picture
		'    Set picKingdom = LoadPicture(gAppPath & "\Data\Stock\blankmap.bmp")
		picKingdom = System.Drawing.Image.FromFile(gDataPath & "\Stock\blankmap.bmp")
		blnZoomOut = False
		' initialize scrollbars
		With HScroll1
			.Minimum = 0
			.Maximum = (VB6.PixelsToTwipsX(picKingdom.Width) + .LargeChange - 1)
			.SmallChange = (.Maximum - .LargeChange + 1) / 20
			NewLargeChange = (.Maximum - .LargeChange + 1) / 4
			.Maximum = .Maximum + NewLargeChange - .LargeChange
			.LargeChange = NewLargeChange
		End With
		With VScroll1
			.Minimum = 0
			.Maximum = (VB6.PixelsToTwipsY(picKingdom.Height) + .LargeChange - 1)
			.SmallChange = (.Maximum - .LargeChange + 1) / 20
			NewLargeChange = (.Maximum - .LargeChange + 1) / 4
			.Maximum = .Maximum + NewLargeChange - .LargeChange
			.LargeChange = NewLargeChange
		End With
		' [Titi 2.4.9b] customize magic system
		cmbMagicBasis.Items.Clear()
		cmbMagicBasis.Items.Add("Strength")
		cmbMagicBasis.Items.Add("Agility")
		cmbMagicBasis.Items.Add("Will")
		cmbMagicBasis.SelectedIndex = 2
		' [Titi 2.6.0] special events options
		Dim c As Short
		Dim sText As String
		cmbInterface.Items.Clear()
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		sText = Dir(gDataPath & "/Interface/*", FileAttribute.Directory)
		If sText = "" Then
			cmbInterface.Items.Add("No Interface List!!!")
		Else
			Do While sText <> ""
				If sText <> "." And sText <> ".." And sText <> "Dice" Then
					cmbInterface.Items.Add(sText)
				End If
				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				sText = Dir()
			Loop 
		End If
		blnChangeValue = False
	End Sub
	
	Private Sub frmWorldSettings_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		Dim Cancel As Boolean = eventArgs.Cancel
		Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
		' [Titi 2.5.1] Check if the user closes the window with the "X" button
		'    If UnloadMode = 0 Then
		' yes, so tell the user to exit "properly"
		'        Cancel = 1
		frmMDI.Dirty = 250
		'    End If
		eventArgs.Cancel = Cancel
	End Sub
	
	Private Sub frmWorldSettings_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		If Dirty Then
			btnQuit_Click(btnQuit, New System.EventArgs())
		Else
			frmMDI.NewTome()
		End If
		Call oGameMusic.mciClose(True)
	End Sub
	
	'UPGRADE_NOTE: HScroll1.Change was changed from an event to a procedure. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
	'UPGRADE_WARNING: HScrollBar event HScroll1.Change has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub HScroll1_Change(ByVal newScrollValue As Integer)
		Dim intTop, intLeft As Short
		Dim strLocation As String
		strLocation = Me.txtKingdomLocation.Text
		intLeft = Val(VB.Left(strLocation, InStr(strLocation, ",") - 1)) '* Screen.TwipsPerPixelX
		strLocation = VB.Right(strLocation, Len(strLocation) - InStr(strLocation, ","))
		intTop = Val(VB.Left(strLocation, InStr(strLocation, ",") - 1)) '* Screen.TwipsPerPixelY
		'UPGRADE_ISSUE: Panel property picKingdom.BackgroundImage will be tiled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ED2DEFAA-C59C-4EDB-AF23-73A16C92C3AC"'
		'UPGRADE_ISSUE: PictureBox method picKingdom.PaintPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picKingdom.PaintPicture(picKingdom.BackgroundImage, -newScrollValue, -VScroll1.Value)
		'UPGRADE_WARNING: Shape method shpBorder.Move has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		shpBorder.SetBounds(intLeft - newScrollValue, intTop - VScroll1.Value, shpBorder.Width, shpBorder.Height)
	End Sub
	
	'UPGRADE_NOTE: HScroll1.Scroll was changed from an event to a procedure. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
	Private Sub HScroll1_Scroll_Renamed(ByVal newScrollValue As Integer)
		HScroll1_Change(0)
	End Sub
	
	Private Sub lblIntroMusic_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lblIntroMusic.Click
		With Me
			If .lblIntroMusic.Text = "Playing" Then
				.lblIntroMusic.Text = "Intro music"
				Call oGameMusic.mciClose()
			Else
				.lblIntroMusic.Text = "Playing"
				Call PlayMusic(.txtIntroMusic.Text, Me, .txtMusicFolder)
			End If
		End With
	End Sub
	
	Private Sub lblFormulaBasis_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lblFormulaBasis.Click
		Dim sOP As String
		Select Case VB.Left(lblFormulaBasis.Text, 1)
			Case "+"
				sOP = "-"
			Case "-"
				sOP = "x"
			Case "x"
				sOP = "/"
			Case "/"
				sOP = "+"
		End Select
		lblFormulaBasis.Text = sOP & VB.Right(lblFormulaBasis.Text, Len(lblFormulaBasis.Text) - 1)
	End Sub
	
	Public Sub mnuPictureAdd_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPictureAdd.Click
		Dim c As Short
		Dim strPicturesList, strPictureName As String
		c = -1
		strPicturesList = txtKingdomPictures.Text
		While VB.Left(strPicturesList, 1) <> "|"
			' determine how many pictures are available
			c = c + 1
			' get only the name
			strPictureName = BreakText(strPicturesList, 1)
			' advance to next picture
			strPicturesList = VB.Right(strPicturesList, Len(strPicturesList) - Len(strPictureName))
			strPicturesList = VB.Right(strPicturesList, Len(strPicturesList) - InStr(strPicturesList, ","))
		End While
		If c = -1 Then
			Exit Sub ' no pictures: world under construction
		Else
			While c > 5
				c = c - 1
				If txtPictureName(5).Text <> "" Then btnRightRoster_Click(btnRightRoster, New System.EventArgs())
			End While
			picInhabitant_DoubleClick(picInhabitant.Item(c + 1), New System.EventArgs())
			If txtPictureName(5).Text <> "" Then
				btnRightRoster_Click(btnRightRoster, New System.EventArgs())
				btnRightRoster.Visible = True
			End If
		End If
	End Sub
	
	Public Sub mnuPictureChange_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPictureChange.Click
		picInhabitant_DoubleClick(picInhabitant.Item(intPicIndex), New System.EventArgs())
	End Sub
	
	Public Sub mnuPictureRemove_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPictureRemove.Click
		Dim intLength, c, intPosInString As Short
		Dim sRightString As String
		If strKingdomPictures(TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True)) <> "|None" Then
			' there really is something to remove
			intLength = Len(txtPictureName(intPicIndex).Text)
			' replace picture name
			intPosInString = InStr(strKingdomPictures(TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True)), txtPictureName(intPicIndex).Text)
			intLength = Len(strKingdomPictures(TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True))) - intPosInString - intLength + 1
			sRightString = VB.Right(strKingdomPictures(TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True)), intLength)
			If InStr(sRightString, ",") Or intPicIndex > 1 Then
				sRightString = IIf(InStr(sRightString, ",") > 0, Mid(sRightString, InStr(sRightString, ",") + 1), "")
				strKingdomPictures(TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True)) = VB.Left(strKingdomPictures(TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True)), intPosInString - 1) & sRightString
			Else
				strKingdomPictures(TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True)) = "|None"
			End If
			' if we removed the last picture, remove the last comma as well
			If VB.Right(strKingdomPictures(TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True)), 1) = "," Then
				strKingdomPictures(TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True)) = VB.Left(strKingdomPictures(TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True)), Len(strKingdomPictures(TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True))) - 1)
			End If
			txtKingdomPictures.Text = strKingdomPictures(TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True))
		End If
		' refresh display
		TabStrip1.SelectedItem.Selected = True
	End Sub
	
	Public Sub mnuQuit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuQuit.Click
		btnQuit_Click(btnQuit, New System.EventArgs())
	End Sub
	
	Public Sub mnuSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSave.Click
		btnSave_Click(btnSave, New System.EventArgs())
	End Sub
	
	Public Sub mnuWorldPackage_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuWorldPackage.Click
		frmMDI.CheckIfExist(True, True)
	End Sub
	
	'UPGRADE_WARNING: Event optGender.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optGender_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optGender.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = optGender.GetIndex(eventSender)
			' [Titi 2.5.1] added the option to select male/female pictures
			TabStrip1.SelectedItem.Selected = True
		End If
	End Sub
	
	Private Sub picInhabitant_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles picInhabitant.Click
		Dim Index As Short = picInhabitant.GetIndex(eventSender)
		If MouseClick_Renamed = VB6.MouseButtonConstants.RightButton Then
			intPicIndex = Index
			'UPGRADE_ISSUE: Form method frmWorldSettings.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			PopupMenu(mnuPicture)
		End If
	End Sub
	
	Private Sub picMoney_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles picMoney.DoubleClick
		With Me
			On Error Resume Next
			'        frmMDI.dlgFile.InitDir = gAppPath & "\Data\Graphics\Items"
			frmMDI.dlgFileOpen.FileName = gDataPath & "\Graphics\Items\*.bmp"
			frmMDI.dlgFileOpen.Title = "Choose Picture"
			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
			frmMDI.dlgFile.CancelError = True
			'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			frmMDI.dlgFileOpen.Filter = "Bitmaps (*.bmp)|*.bmp|All Files (*.*)|*.*"
			frmMDI.dlgFileOpen.FilterIndex = 1
			'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			'UPGRADE_NOTE: Variable frmMDI.dlgFile was renamed frmMDI.dlgFileOpen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="94ADAC4D-C65D-414F-A061-8FDC6B83C5EC"'
			'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.CheckPathExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			frmMDI.dlgFileOpen.CheckFileExists = True
			frmMDI.dlgFileOpen.CheckPathExists = True
			'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			frmMDI.dlgFileOpen.ShowReadOnly = False
			'UPGRADE_NOTE: Variable frmMDI.dlgFile was renamed frmMDI.dlgFileOpen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="94ADAC4D-C65D-414F-A061-8FDC6B83C5EC"'
			'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.RestoreDirectory which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			frmMDI.dlgFileOpen.RestoreDirectory = False
			frmMDI.dlgFileOpen.ShowDialog()
			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
			If Err.Number = DialogResult.Cancel Then
				Exit Sub
			End If
			'UPGRADE_WARNING: CommonDialog property frmMDI.dlgFile.FileTitle was upgraded to frmMDI.dlgFile.FileName which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			.txtMoney(1).Text = frmMDI.dlgFileOpen.FileName
			' display picture and file name
			.picMons.Image = System.Drawing.Image.FromFile(frmMDI.dlgFileOpen.FileName)
			'        Set .picMoney = LoadPicture(gAppPath & "\Data\Stock\blankchar.bmp")
			.picMoney.Image = System.Drawing.Image.FromFile(gDataPath & "\Stock\blankchar.bmp")
			ResizePicture(.picMons, .picMoney, .tmpShape, 7, (frmMDI.dlgFileOpen.FileName))
			' [Titi 2.4.9] refresh map picture (might have been grayed out by the dialog form!)
			If oFileSys.CheckExists(gAppPath & "\Roster\" & WorldNow.Name & "\" & WorldNow.PictureFile, clsInOut.IOActionType.File) Then
				.picMons.Image = System.Drawing.Image.FromFile(gAppPath & "\Roster\" & WorldNow.Name & "\" & WorldNow.PictureFile)
				.picWorldMap.Image = System.Drawing.Image.FromFile(gDataPath & "\Stock\blankmap.bmp")
				ResizePicture(.picMons, .picWorldMap, .tmpShape, 6, gAppPath & "\Roster\" & WorldNow.Name & "\" & WorldNow.PictureFile)
			Else
				.picMons.Image = System.Drawing.Image.FromFile(.txtWorldMap.Text)
				.picWorldMap.Image = System.Drawing.Image.FromFile(gDataPath & "\Stock\blankmap.bmp")
				ResizePicture(.picMons, .picWorldMap, .tmpShape, 6, .txtWorldMap.Text)
			End If
		End With
	End Sub
	
	Private Sub picWorldDesc_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles picWorldDesc.DoubleClick
		Dim Index As Short = picWorldDesc.GetIndex(eventSender)
		With Me
			On Error Resume Next
			frmMDI.dlgFileOpen.FileName = gDataPath & "\Graphics\*.bmp"
			frmMDI.dlgFileOpen.Title = "Choose Picture"
			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
			frmMDI.dlgFile.CancelError = True
			'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			frmMDI.dlgFileOpen.Filter = "Bitmaps (*.bmp)|*.bmp|All Files (*.*)|*.*"
			frmMDI.dlgFileOpen.FilterIndex = 1
			'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			'UPGRADE_NOTE: Variable frmMDI.dlgFile was renamed frmMDI.dlgFileOpen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="94ADAC4D-C65D-414F-A061-8FDC6B83C5EC"'
			'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.CheckPathExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			frmMDI.dlgFileOpen.CheckFileExists = True
			frmMDI.dlgFileOpen.CheckPathExists = True
			'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			frmMDI.dlgFileOpen.ShowReadOnly = False
			'UPGRADE_NOTE: Variable frmMDI.dlgFile was renamed frmMDI.dlgFileOpen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="94ADAC4D-C65D-414F-A061-8FDC6B83C5EC"'
			'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.RestoreDirectory which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			frmMDI.dlgFileOpen.RestoreDirectory = False
			frmMDI.dlgFileOpen.ShowDialog()
			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
			If Err.Number = DialogResult.Cancel Then
				Exit Sub
			End If
			' display picture and file name
			.picMons.Image = System.Drawing.Image.FromFile(frmMDI.dlgFileOpen.FileName)
			.picWorldDesc(Index) = System.Drawing.Image.FromFile(gDataPath & "\Stock\blankmap.bmp")
			ResizePicture(.picMons, .picWorldDesc(Index), .tmpShape, 6, (frmMDI.dlgFileOpen.FileName))
			.txtPicDescName(Index).Text = frmMDI.dlgFileOpen.FileName
			WorldNow.PicDesc = VB.Right(.txtPicDescName(0).Text, Len(.txtPicDescName(0).Text) - InStrRev(.txtPicDescName(0).Text, "\")) & "|" & VB.Right(.txtPicDescName(1).Text, Len(.txtPicDescName(1).Text) - InStrRev(.txtPicDescName(1).Text, "\"))
			Dirty = True
		End With
	End Sub
	
	Private Sub picWorldMap_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles picWorldMap.DoubleClick
		picKingdom_DoubleClick(picKingdom, New System.EventArgs())
	End Sub
	
	Private Sub lblKingdomName_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lblKingdomName.Click
		Dim strNewName As String
		strNewName = InputBox("New name:", "Rename Kingdom?", Me.lblKingdomName.Text)
		If strNewName <> "" Then
			Me.lblKingdomName.Text = strNewName
			strKingdomNames(Me.TabStrip1.SelectedItem.Index) = strNewName
			Me.TabStrip1.SelectedItem.Caption = strNewName
			If blnChangeValue Then Dirty = True
		End If
	End Sub
	
	Public Sub mnuDelete_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuDelete.Click
		'UPGRADE_NOTE: Tag was upgraded to Tag_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim intKingdoms, rc, i, Found As Short
		Dim Tag_Renamed, strPrevious As String
		With Me
			If .TabStrip1.Tabs.Count - 1 > .TabStrip1.SelectedItem.Index Then
				If frmMDI.HoldNode <> -1 Then
					rc = MsgBox("Are you sure? All data will be lost!", MsgBoxStyle.YesNo, "Remove Kingdom")
				Else
					rc = MsgBox("This action will also delete the kingdom of " & .TabStrip1.SelectedItem.Caption & "." & vbCrLf & "Are you sure?", MsgBoxStyle.YesNo, "Remove Kingdom")
				End If
				If rc = MsgBoxResult.Yes Then
					Dirty = True
					frmMDI.Dirty = True
					rc = .TabStrip1.SelectedItem.Index
					strPrevious = strKingdomTemplate(rc)
					' [Titi 2.5.1] what happens if an archetype is the same for several kingdoms?
					For i = 1 To WorldNow.Kingdoms.Count()
						If strKingdomTemplate(i) = strPrevious Then
							Found = Found + 1
						End If
					Next 
					If Found = 1 Then ' [Titi 2.5.1] if used by several kingdoms, keep it!
						For i = 1 To frmProject.tvwTome.Nodes.Count
							If frmProject.tvwTome.Nodes(i).Text = strPrevious Then
								'UPGRADE_WARNING: Couldn't resolve default property of object frmProject.tvwTome.Nodes().Tag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
								Tag_Renamed = frmProject.tvwTome.Nodes(i).Tag
								frmMDI.TreeViewX = frmProject.tvwTome.GetOcx
								frmMDI.ObjectListX = frmProject.TomeList
								If frmMDI.HoldNode <> -1 Then frmMDI.EditDelete(Tag_Renamed)
								Exit For
							End If
						Next 
					End If
					strKingdomTemplate(rc) = .txtKingdomTemplate.Text
					WorldNow.Kingdoms.Remove(rc)
					.TabStrip1.Tabs.Remove(rc)
					intKingdoms = WorldNow.Kingdoms.Count()
					For i = rc To intKingdoms
						strKingdomTemplate(i) = strKingdomTemplate(i + 1)
						strKingdomNames(i) = strKingdomNames(i + 1)
						strKingdomSet(i) = strKingdomSet(i + 1)
						strKingdomLocation(i) = strKingdomLocation(i + 1)
						strKingdomPictures(i) = strKingdomPictures(i + 1)
						' [Titi 2.5.1] addition of female pictures
						strKingdomPictures(i) = strKingdomPictures(i + intKingdoms + 1)
					Next 
					ReDim Preserve strKingdomTemplate(intKingdoms)
					ReDim Preserve strKingdomNames(intKingdoms)
					ReDim Preserve strKingdomSet(intKingdoms)
					ReDim Preserve strKingdomLocation(intKingdoms)
					ReDim Preserve strKingdomPictures(intKingdoms * 2)
				End If
			Else
				MsgBox("This tab cannot be deleted.")
			End If
		End With
		frmMDI.HoldNode = 0 '[Titi 2.4.9b] tells the engine the deletion is over
		TabStrip1.SelectedItem.Selected = True
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub mnuAdd_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAdd.Click
		Dim Tome_Renamed As Object
		Dim intKingdoms, i As Short
		Dim NodeX As ComctlLib.Node
		Dim CreatureX As Creature
		Dim TriggerX, TriggerY As Trigger
		Dim StmtX As Statement
		Dim j As Short
		Dim intSelected As Short
		Dim blnTemp As Boolean
		blnTemp = blnChangeValue : blnChangeValue = False '[Titi 2.6.2] many changes will follow, but we don't want to update all the kingdoms!
		WorldNow.AddKingdom()
		Dirty = True
		frmMDI.Dirty = True
		intKingdoms = WorldNow.Kingdoms.Count()
		ReDim Preserve strKingdomTemplate(intKingdoms)
		ReDim Preserve strKingdomNames(intKingdoms)
		ReDim Preserve strKingdomSet(intKingdoms)
		ReDim Preserve strKingdomLocation(intKingdoms)
		ReDim Preserve strKingdomPictures(intKingdoms * 2)
		With Me
			' [Titi 2.4.9] the world comments occupies the penultimate tab
			' --> we don't want to separate the comments and the worlds generalities
			If TabStrip1.SelectedItem.Index >= TabStrip1.Tabs.Count - 2 And TabStrip1.Tabs.Count > 1 Then
				intSelected = WorldNow.Kingdoms.Count()
			Else
				intSelected = .TabStrip1.SelectedItem.Index
			End If
			'        .TabStrip1.Tabs.Add .TabStrip1.SelectedItem.Index
			.TabStrip1.Tabs.Add(intSelected)
			'        .TabStrip1.Tabs(.TabStrip1.SelectedItem.Index).Caption = "Unknown kingdom"
			.TabStrip1.Tabs(intSelected).Caption = "Unknown kingdom"
			'[Titi 2.6.1] addition of female pictures
			For i = intKingdoms To intSelected + 1 Step -1
				strKingdomPictures(i + intKingdoms) = strKingdomPictures(i + intKingdoms - 2)
			Next 
			For i = 1 To intSelected - 1
				strKingdomPictures(i + intKingdoms) = strKingdomPictures(i + intKingdoms - 1)
			Next 
			'        For i = intKingdoms To TabStrip1.SelectedItem.Index Step -1
			For i = intKingdoms To intSelected + 1 Step -1
				strKingdomTemplate(i) = strKingdomTemplate(i - 1)
				strKingdomNames(i) = strKingdomNames(i - 1)
				strKingdomSet(i) = strKingdomSet(i - 1)
				strKingdomLocation(i) = strKingdomLocation(i - 1)
				strKingdomPictures(i) = strKingdomPictures(i - 1)
			Next 
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.AddCreature. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CreatureX = Tome.AddCreature
			CreatureX.DMControlled = False
			.txtKingdomTemplate.Text = "Creature" & Trim(CStr(CreatureX.Index))
			' tip: i + 1 = .TabStrip1.SelectedItem.Index at the end of the loop!
			strKingdomTemplate(intSelected) = .txtKingdomTemplate.Text
			strKingdomNames(intSelected) = "Unknown"
			strKingdomSet(intSelected) = "0"
			strKingdomLocation(intSelected) = "0,0,100,100"
			strKingdomPictures(intSelected) = "|None" ' Caution: first character must be "|", or btnLeft|RightRoster subs will assume there's at least one picture name
			strKingdomPictures(intSelected + WorldNow.Kingdoms.Count()) = "|None" ' add the list for female characters
			.txtKingdomPictures.Text = "|None"
			' [Titi 2.6.2] bug fix: subscript out of range if the user adds a kingdom without having selecting any first
			.TabStrip1.Tabs(intSelected).Selected = True
			' [Titi 2.4.9b] Add a Post-NewCharacter trigger to create new abilities
			TriggerX = CreatureX.AddTrigger
			TriggerX.TriggerType = bdPostNewCharacter
			TriggerX.Name = "New Abilities"
			TriggerX.Turns = 1
			StmtX = TriggerX.AddStatement
			' Find TriggerA In TriggerNow Named "Check Abilities"
			StmtX.Statement = 70 : StmtX.B(0) = 6 : StmtX.B(1) = 11 : StmtX.Text = "Check Abilities"
			StmtX = TriggerX.AddStatement
			' ForEach TriggerB In TriggerA
			StmtX.Statement = 9 : StmtX.B(0) = 7 : StmtX.B(1) = 12
			StmtX = TriggerX.AddStatement
			' CopyText "Roll the" Into Local.TextA
			StmtX.Statement = 22 : StmtX.B(0) = 27 : StmtX.B(1) = 9 : StmtX.Text = "Roll the"
			StmtX = TriggerX.AddStatement
			' Put Local.TextA + TriggerB.Name Into Local.TextA
			StmtX.Statement = 12 : StmtX.B(0) = 27 : StmtX.B(1) = 9 : StmtX.B(2) = 1 : StmtX.B(3) = 24 : StmtX.B(4) = 20 : StmtX.B(5) = 27 : StmtX.B(6) = 9
			StmtX = TriggerX.AddStatement
			' DialogDice "DM" 1d20 Says "Roll the <ability> for [CreatureNow.Name]" Into Local.IntegerA
			StmtX.Statement = 39 : StmtX.B(0) = 27 : StmtX.B(1) = 5 : StmtX.B(2) = 25 : StmtX.Text = "DM|[Local.TextA] for [CreatureNow.Name]"
			StmtX = TriggerX.AddStatement
			' Let TriggerB.ByteA = Local.IntegerA
			StmtX.Statement = 53 : StmtX.B(0) = 24 : StmtX.B(1) = 0 : StmtX.B(3) = 27 : StmtX.B(4) = 5
			StmtX = TriggerX.AddStatement
			' Next
			StmtX.Statement = 10
			StmtX = TriggerX.AddStatement
			'  CopyTrigger "Check Abilities" Into CreatureNow
			StmtX.Statement = 20 : StmtX.B(0) = 1 : StmtX.B(1) = 0
			' [Titi 2.4.9b] OK, now we've got the trigger to give the values to the new abilities. We now need the trigger to access these values
			TriggerY = TriggerX.AddTrigger
			TriggerY.TriggerType = bdShowNewStat
			TriggerY.Name = "Check Abilities"
			StmtX = TriggerY.AddStatement
			' ForEach TriggerB In TriggerNow
			StmtX.Statement = 9 : StmtX.B(0) = 7 : StmtX.B(1) = 11
			StmtX = TriggerY.AddStatement
			' Let Local.IntegerA = TriggerB.ByteA
			StmtX.Statement = 53 : StmtX.B(0) = 27 : StmtX.B(1) = 5 : StmtX.B(3) = 24 : StmtX.B(4) = 0
			StmtX = TriggerY.AddStatement
			' DialogShow "PC" Normal Says "[Local.IntegerA] [TriggerB.Name]"
			StmtX.Statement = 36 : StmtX.B(0) = 0 : StmtX.Text = "PC|[Local.IntegerA] [TriggerB.Name]"
			StmtX = TriggerY.AddStatement
			' Next
			StmtX.Statement = 10
			' Include previously created abilities
			For j = 3 To 11
				If chkStats(j).CheckState = 1 Then NewStat(chkStats(j).Text, False, False)
			Next 
			frmMDI.TreeViewX = frmProject.tvwTome.GetOcx
			frmMDI.ObjectListX = frmProject.TomeList
			frmMDI.ShowCreature((frmMDI.ObjectListX), (frmMDI.TreeViewX), "TomeParty", CreatureX)
			For i = 0 To 5
				'            Set .picMons = LoadPicture(gAppPath & "\Data\Graphics\Creatures\bones.bmp")
				.picMons.Image = System.Drawing.Image.FromFile(gDataPath & "\Graphics\Creatures\bones.bmp")
				'            Set .picInhabitant(i) = LoadPicture(gAppPath & "\Data\Stock\blankchar.bmp")
				.picInhabitant(i) = System.Drawing.Image.FromFile(gDataPath & "\Stock\blankchar.bmp")
				' default shape dimensions
				.shpFace(i).Height = VB6.TwipsToPixelsY(480) ' twips
				.shpFace(i).Width = VB6.TwipsToPixelsX(375) ' twips
				'            ResizePicture .picMons, .picInhabitant(i), .shpFace(i), i, gAppPath & "\Data\Graphics\Creatures\bones.bmp"
				'UPGRADE_ISSUE: frmWorldSettings.picInhabitant() was upgraded to a Panel, and cannot be coerced to a PictureBox. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="0FF1188E-27C0-4FED-842D-159C65894C9B"'
				ResizePicture(.picMons, .picInhabitant(i), .shpFace(i), i, gDataPath & "\Graphics\Creatures\bones.bmp")
				.txtPictureName(i).Text = ""
			Next 
		End With
		blnChangeValue = blnTemp ' now, for sure, something's been changed!
	End Sub
	
	Private Sub picInhabitant_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles picInhabitant.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Dim Index As Short = picInhabitant.GetIndex(eventSender)
		MouseClick_Renamed = Button
		MouseDown_Renamed = True
		DeltaX = X - VB6.PixelsToTwipsX(Me.shpFace(Index).Left)
		DeltaY = Y - VB6.PixelsToTwipsY(Me.shpFace(Index).Top)
	End Sub
	
	Private Sub picInhabitant_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles picInhabitant.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Dim Index As Short = picInhabitant.GetIndex(eventSender)
		Dim intLength, X1, Y1, intPosInString As Short
		With Me
			If .txtPictureName(Index).Text <> "" Then
				' go back to original values
				X1 = (VB6.PixelsToTwipsX(.shpFace(Index).Left) - OffsetX(Index)) / Size_Renamed(Index)
				Y1 = (VB6.PixelsToTwipsY(.shpFace(Index).Top) - OffsetY(Index)) / Size_Renamed(Index)
				' find where in the pictures list string this creature appears
				intPosInString = InStr(strKingdomPictures(.TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True)), .txtPictureName(Index).Text)
				' get where the following picture is
				intLength = InStr(Len(.txtPictureName(Index).Text) + intPosInString, strKingdomPictures(.TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True)) & ",", ",")
				' change the coordinates of upper left corner of the yellow square
				strKingdomPictures(.TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True)) = VB.Left(strKingdomPictures(.TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True)), intPosInString + Len(.txtPictureName(Index).Text) - 1) & "|" & X1 & "|" & Y1 & VB.Right(strKingdomPictures(.TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True)), Len(strKingdomPictures(.TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True))) - intLength + 1)
				.txtKingdomPictures.Text = strKingdomPictures(.TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True))
			End If
		End With
		MouseDown_Renamed = False
	End Sub
	
	Private Sub picInhabitant_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles picInhabitant.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Dim Index As Short = picInhabitant.GetIndex(eventSender)
		Dim Y1, X1, X2, Y2 As Short
		With Me
			If MouseDown_Renamed = True Then
				Dirty = True
				X1 = VB6.PixelsToTwipsX(.shpFace(Index).Left)
				Y1 = VB6.PixelsToTwipsY(.shpFace(Index).Top)
				Y2 = VB6.PixelsToTwipsY(.shpFace(Index).Height)
				X2 = VB6.PixelsToTwipsX(.shpFace(Index).Width)
				' move area
				If IsBetween(X, X1, X1 + X2) And IsBetween(Y, Y1, Y1 + Y2) Then
					' stay within the picture
					'UPGRADE_WARNING: Shape method shpFace.Move has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
					.shpFace(Index).SetBounds(VB6.TwipsToPixelsX(X - DeltaX), VB6.TwipsToPixelsY(Y - DeltaY), .shpFace(Index).Width, .shpFace(Index).Height)
					X1 = VB6.PixelsToTwipsX(.shpFace(Index).Left)
					If X1 < OffsetX(Index) Then X1 = OffsetX(Index)
					Y1 = VB6.PixelsToTwipsY(.shpFace(Index).Top)
					If Y1 < OffsetY(Index) Then Y1 = OffsetY(Index)
					X2 = VB6.PixelsToTwipsX(.shpFace(Index).Width)
					If X1 + X2 > VB6.PixelsToTwipsX(.picInhabitant(Index).ClientRectangle.Width) - OffsetX(Index) Then X1 = VB6.PixelsToTwipsX(.picInhabitant(Index).ClientRectangle.Width) - X2 - OffsetX(Index)
					Y2 = VB6.PixelsToTwipsY(.shpFace(Index).Height)
					If Y1 + Y2 > picInhabitant(Index).ClientRectangle.Height - OffsetY(Index) Then Y1 = VB6.PixelsToTwipsY(.picInhabitant(Index).ClientRectangle.Height) - Y2 - OffsetY(Index)
				End If
				.shpFace(Index).Left = VB6.TwipsToPixelsX(X1)
				.shpFace(Index).Top = VB6.TwipsToPixelsY(Y1)
			End If
		End With
	End Sub
	
	Private Sub picInhabitant_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles picInhabitant.DoubleClick
		Dim Index As Short = picInhabitant.GetIndex(eventSender)
		Dim intPosInString, intLength As Short
		On Error Resume Next
		intPicIndex = Index
		'    Select Case PictureStyle
		'        Case 0  ' Normal Picture
		'            frmMDI.dlgFile.InitDir = gAppPath & "\Data\Graphics\Creatures"
		frmMDI.dlgFileOpen.FileName = gDataPath & "\Graphics\Creatures\*.bmp"
		'        Case 1  ' Portrait Picture
		'            dlgFile.Filename = gAppPath & "\Data\Graphics\Portraits\*.bmp"
		'    End Select
		frmMDI.dlgFileOpen.Title = "Choose Picture"
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		frmMDI.dlgFile.CancelError = True
		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		frmMDI.dlgFileOpen.Filter = "Bitmaps (*.bmp)|*.bmp|All Files (*.*)|*.*"
		frmMDI.dlgFileOpen.FilterIndex = 1
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_NOTE: Variable frmMDI.dlgFile was renamed frmMDI.dlgFileOpen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="94ADAC4D-C65D-414F-A061-8FDC6B83C5EC"'
		'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.CheckPathExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		frmMDI.dlgFileOpen.CheckFileExists = True
		frmMDI.dlgFileOpen.CheckPathExists = True
		'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		frmMDI.dlgFileOpen.ShowReadOnly = False
		'UPGRADE_NOTE: Variable frmMDI.dlgFile was renamed frmMDI.dlgFileOpen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="94ADAC4D-C65D-414F-A061-8FDC6B83C5EC"'
		'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.RestoreDirectory which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		frmMDI.dlgFileOpen.RestoreDirectory = False
		frmMDI.dlgFileOpen.ShowDialog()
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		If Err.Number = DialogResult.Cancel Then
			Exit Sub
		End If
		With Me
			If strKingdomPictures(.TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True)) <> "|None" Then
				' list of pictures already defined
				intLength = Len(.txtPictureName(Index).Text)
				If intLength = 0 Then
					' new picture --> add at the end
					'UPGRADE_WARNING: CommonDialog property frmMDI.dlgFile.FileTitle was upgraded to frmMDI.dlgFile.FileName which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
					strKingdomPictures(.TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True)) = strKingdomPictures(.TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True)) & "," & frmMDI.dlgFileOpen.FileName & "|0|0"
				Else
					' replace picture name
					intPosInString = InStr(strKingdomPictures(.TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True)), .txtPictureName(Index).Text)
					intLength = Len(strKingdomPictures(.TabStrip1.SelectedItem.Index)) - intPosInString - intLength + 1
					'UPGRADE_WARNING: CommonDialog property frmMDI.dlgFile.FileTitle was upgraded to frmMDI.dlgFile.FileName which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
					strKingdomPictures(.TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True)) = VB.Left(strKingdomPictures(.TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True)), intPosInString - 1) & frmMDI.dlgFileOpen.FileName & VB.Right(strKingdomPictures(.TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True)), intLength)
				End If
			Else
				' first picture of the list
				'UPGRADE_WARNING: CommonDialog property frmMDI.dlgFile.FileTitle was upgraded to frmMDI.dlgFile.FileName which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
				strKingdomPictures(.TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True)) = frmMDI.dlgFileOpen.FileName & "|0|0"
			End If
			' place picture at the first available place on the screen
			If Index > 0 Then
				Do While .txtPictureName(Index - 1).Text = ""
					Index = Index - 1
					If Index = 0 Then Exit Do
				Loop 
			End If
			' display picture and file name
			'        Set .picMons = LoadPicture(gAppPath & "\Data\Graphics\Creatures\" & frmMDI.dlgFile.FileTitle)
			'UPGRADE_WARNING: CommonDialog property frmMDI.dlgFile.FileTitle was upgraded to frmMDI.dlgFile.FileName which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			.picMons.Image = System.Drawing.Image.FromFile(gDataPath & "\Graphics\Creatures\" & frmMDI.dlgFileOpen.FileName)
			'        Set .picInhabitant(Index) = LoadPicture(gAppPath & "\Data\Stock\blankchar.bmp")
			.picInhabitant(Index) = System.Drawing.Image.FromFile(gDataPath & "\Stock\blankchar.bmp")
			' default shape dimensions
			.shpFace(Index).Height = VB6.TwipsToPixelsY(480)
			.shpFace(Index).Width = VB6.TwipsToPixelsX(375)
			'        ResizePicture .picMons, .picInhabitant(Index), .shpFace(Index), Index, gAppPath & "\Data\Graphics\Creatures\" & frmMDI.dlgFile.FileTitle
			'UPGRADE_WARNING: CommonDialog property frmMDI.dlgFile.FileTitle was upgraded to frmMDI.dlgFile.FileName which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			'UPGRADE_ISSUE: frmWorldSettings.picInhabitant() was upgraded to a Panel, and cannot be coerced to a PictureBox. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="0FF1188E-27C0-4FED-842D-159C65894C9B"'
			ResizePicture(.picMons, .picInhabitant(Index), .shpFace(Index), Index, gDataPath & "\Graphics\Creatures\" & frmMDI.dlgFileOpen.FileName)
			'UPGRADE_WARNING: CommonDialog property frmMDI.dlgFile.FileTitle was upgraded to frmMDI.dlgFile.FileName which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			.txtPictureName(Index).Text = frmMDI.dlgFileOpen.FileName
			.txtKingdomPictures.Text = strKingdomPictures(.TabStrip1.SelectedItem.Index - WorldNow.Kingdoms.Count() * CShort(optGender(1).Checked = True))
		End With
		Dirty = True
	End Sub
	
	Private Sub picKingdom_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles picKingdom.DoubleClick
		Dim intPosInString, intLength As Short
		With Me
			On Error Resume Next
			'        frmMDI.dlgFile.InitDir = gAppPath & "\Data\Graphics"
			frmMDI.dlgFileOpen.FileName = gDataPath & "\Graphics\*.bmp"
			frmMDI.dlgFileOpen.Title = "Choose Picture"
			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
			frmMDI.dlgFile.CancelError = True
			'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			frmMDI.dlgFileOpen.Filter = "Bitmaps (*.bmp)|*.bmp|All Files (*.*)|*.*"
			frmMDI.dlgFileOpen.FilterIndex = 1
			'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			'UPGRADE_NOTE: Variable frmMDI.dlgFile was renamed frmMDI.dlgFileOpen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="94ADAC4D-C65D-414F-A061-8FDC6B83C5EC"'
			'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.CheckPathExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			frmMDI.dlgFileOpen.CheckFileExists = True
			frmMDI.dlgFileOpen.CheckPathExists = True
			'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			frmMDI.dlgFileOpen.ShowReadOnly = False
			'UPGRADE_NOTE: Variable frmMDI.dlgFile was renamed frmMDI.dlgFileOpen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="94ADAC4D-C65D-414F-A061-8FDC6B83C5EC"'
			'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.RestoreDirectory which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			frmMDI.dlgFileOpen.RestoreDirectory = False
			frmMDI.dlgFileOpen.ShowDialog()
			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
			If Err.Number = DialogResult.Cancel Then
				Exit Sub
			End If
			' display picture and file name
			.picMons.Image = System.Drawing.Image.FromFile(frmMDI.dlgFileOpen.FileName)
			'        Set .picWorldMap = LoadPicture(gAppPath & "\Data\Stock\blankmap.bmp")
			.picWorldMap.Image = System.Drawing.Image.FromFile(gDataPath & "\Stock\blankmap.bmp")
			ResizePicture(.picMons, .picWorldMap, .tmpShape, 6, (frmMDI.dlgFileOpen.FileName))
			'        Set .picKingdom = LoadPicture(gAppPath & "\Data\Stock\blankmap.bmp")
			.picKingdom = System.Drawing.Image.FromFile(gDataPath & "\Stock\blankmap.bmp")
			' default shape dimensions
			.shpBorder.Height = 1695
			.shpBorder.Width = 2775
			If blnZoomOut Then
				.picKingdom = .picMons
				.HScroll1.Value = 0
				.VScroll1.Value = 0
				' picTmp contains the map at scale 1:1, picKingdom only displays what is visible in its surface
				.HScroll1.Maximum = (.picTmp.ClientRectangle.Width - .picKingdom.ClientRectangle.Width + .VScroll1.Width + .HScroll1.LargeChange - 1)
				.VScroll1.Maximum = (.picTmp.ClientRectangle.Height - .picKingdom.ClientRectangle.Height + .HScroll1.Height + .VScroll1.LargeChange - 1)
				.VScroll1.Visible = (.picTmp.ClientRectangle.Height > .picKingdom.ClientRectangle.Height)
				.HScroll1.Visible = (.picTmp.ClientRectangle.Width > .picKingdom.ClientRectangle.Width)
			Else
				'            ResizePicture .picMons, .picKingdom, .tmpShape, 6, gAppPath & "\Data\Stock\blankmap.bmp"
				'UPGRADE_ISSUE: frmWorldSettings.picKingdom was upgraded to a Panel, and cannot be coerced to a PictureBox. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="0FF1188E-27C0-4FED-842D-159C65894C9B"'
				ResizePicture(.picMons, .picKingdom, .tmpShape, 6, gDataPath & "\Stock\blankmap.bmp")
			End If
			'UPGRADE_WARNING: CommonDialog property frmMDI.dlgFile.FileTitle was upgraded to frmMDI.dlgFile.FileName which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			WorldNow.PictureFile = frmMDI.dlgFileOpen.FileName
			.txtWorldMap.Text = frmMDI.dlgFileOpen.FileName
			Dirty = True
		End With
	End Sub
	
	Private Sub picKingdom_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles picKingdom.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = eventArgs.X
		Dim Y As Single = eventArgs.Y
		If Button = VB6.MouseButtonConstants.RightButton And Not (IsBetween(X, shpBorder.Left, shpBorder.Left + shpBorder.Width) And IsBetween(Y, shpBorder.Top, shpBorder.Top + shpBorder.Height)) Then
			shpBorder.BorderColor = System.Drawing.ColorTranslator.FromOle(IIf(shpBorder.BorderColor.equals(System.Drawing.Color.Yellow), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)))
		End If
		MouseDown_Renamed = True
		DeltaX = X - Me.shpBorder.Left
		DeltaY = Y - Me.shpBorder.Top
	End Sub
	
	Private Sub picKingdom_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles picKingdom.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = eventArgs.X
		Dim Y As Single = eventArgs.Y
		MouseDown_Renamed = False
	End Sub
	
	Private Sub picKingdom_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles picKingdom.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = eventArgs.X
		Dim Y As Single = eventArgs.Y
		Dim Y1, X1, X2, Y2 As Short
		Dim lOffsetX, lOffsetY As Integer
		Dim sinRatio As Single
		With Me
			If MouseDown_Renamed = True Then
				Dirty = True
				X1 = .shpBorder.Left
				Y1 = .shpBorder.Top
				Y2 = .shpBorder.Height
				X2 = .shpBorder.Width
				If blnZoomOut Then
					' in this case, the map is not centered in the PictureBox
					lOffsetX = 0
					lOffsetY = 0
					' and the zoom affects the coordinates by the ratio between picTmp and picKingdom dimensions
					sinRatio = .picTmp.ClientRectangle.Width / .picKingdom.ClientRectangle.Width
					If sinRatio < .picTmp.ClientRectangle.Height / .picKingdom.ClientRectangle.Height Then sinRatio = .picTmp.ClientRectangle.Height / .picKingdom.ClientRectangle.Height
				Else
					lOffsetX = OffsetX(6)
					lOffsetY = OffsetY(6)
				End If
				' move area
				If IsBetween(X, X1, X1 + X2) And IsBetween(Y, Y1, Y1 + Y2) And Button = VB6.MouseButtonConstants.RightButton Then
					'UPGRADE_WARNING: Shape method shpBorder.Move has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
					.shpBorder.SetBounds(X - DeltaX, Y - DeltaY, .shpBorder.Width, .shpBorder.Height)
				ElseIf Button = VB6.MouseButtonConstants.LeftButton Then 
					' resize area
					If X < X1 Then
						.shpBorder.Width = X2 + X
						.shpBorder.Left = X
					Else
						.shpBorder.Width = X - X1
					End If
					If Y < Y1 Then
						.shpBorder.Height = Y2 + Y
						.shpBorder.Top = Y
					Else
						.shpBorder.Height = Y - Y1
					End If
				End If
				X1 = .shpBorder.Left
				' stay on the map
				If X1 < lOffsetX Then X1 = lOffsetX
				Y1 = .shpBorder.Top
				If Y1 < lOffsetY Then Y1 = lOffsetY
				X2 = .shpBorder.Width
				If X1 + X2 > .picKingdom.ClientRectangle.Width - lOffsetX Then X1 = .picKingdom.ClientRectangle.Width - X2 - lOffsetX
				Y2 = .shpBorder.Height
				If Y1 + Y2 > .picKingdom.ClientRectangle.Height - lOffsetY Then Y1 = .picKingdom.ClientRectangle.Height - Y2 - lOffsetY
				.shpBorder.Left = X1
				.shpBorder.Top = Y1
				.shpBorder.Width = X2
				.shpBorder.Height = Y2
				' Size(6) is the coefficient applied on the map to make it fit inside the Picture Box
				'            X1 = (.shpBorder.Left - lOffsetX) / Screen.TwipsPerPixelX / Size(6)
				'            Y1 = (.shpBorder.Top - lOffsetY) / Screen.TwipsPerPixelY / Size(6)
				'            X2 = .shpBorder.Width / Screen.TwipsPerPixelX / Size(6)
				'            Y2 = .shpBorder.Height / Screen.TwipsPerPixelY / Size(6)
				X1 = (.shpBorder.Left - lOffsetX) / Size_Renamed(6)
				Y1 = (.shpBorder.Top - lOffsetY) / Size_Renamed(6)
				X2 = .shpBorder.Width / Size_Renamed(6)
				Y2 = .shpBorder.Height / Size_Renamed(6)
				If blnZoomOut Then
					' therefore, in case of display 1:1, cancel the resizing
					' but take into account the scrolling displacement
					'                X1 = (X1 + HScroll1.Value * sinRatio / Screen.TwipsPerPixelX) * Size(6)
					'                Y1 = (Y1 + VScroll1.Value * sinRatio / Screen.TwipsPerPixelY) * Size(6)
					X1 = (X1 + HScroll1.Value * sinRatio) * Size_Renamed(6)
					Y1 = (Y1 + VScroll1.Value * sinRatio) * Size_Renamed(6)
					X2 = X2 * Size_Renamed(6)
					Y2 = Y2 * Size_Renamed(6)
				End If
				strKingdomLocation(.TabStrip1.SelectedItem.Index) = X1 & "," & Y1 & "," & X2 & "," & Y2
				.txtKingdomLocation.Text = strKingdomLocation(.TabStrip1.SelectedItem.Index)
			End If
		End With
		' [Titi 2.5.1] added mouse wheel support
		EnumThreadProc(Me.Handle.ToInt32, Y * &H10000 + X)
	End Sub
	
	Private Sub TabStrip1_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxComctlLib.ITabStripEvents_MouseDownEvent) Handles TabStrip1.MouseDownEvent
		MouseClick_Renamed = eventArgs.Button
		' [Titi 2.6.0] ' if too many tabs, switch to MultiRow design
		If MouseClick_Renamed = VB6.MouseButtonConstants.RightButton Then
			If (eventArgs.Shift And VB6.ShiftConstants.ShiftMask) Then
				TabStrip1.MultiRow = Not TabStrip1.MultiRow
				MouseClick_Renamed = VB6.MouseButtonConstants.LeftButton
			End If
		End If
	End Sub
	
	Public Sub PopulateWorldSettings(ByRef hndWorld As Short, ByRef fromIniFile As Boolean, ByRef Reverse As Boolean, Optional ByRef intKingdoms As Short = 0)
		'UPGRADE_NOTE: Text was upgraded to Text_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim strKingdom, Text_Renamed As String
		Dim lResult As Integer
		If fromIniFile Then
			FileName = gAppPath & "\roster\" & WorldNow.Name & "\" & WorldNow.Name & ".ini"
			strKingdom = "Kingdom" & Trim(Str(hndWorld)) 'Right$(Str(hndWorld), Len(Str(hndWorld)) - 1)
			lResult = fReadValue(FileName, strKingdom, "Name", "S", "", Text_Renamed)
			strKingdomNames(hndWorld) = Text_Renamed
			lResult = fReadValue(FileName, strKingdom, "Template", "S", "", Text_Renamed)
			strKingdomTemplate(hndWorld) = Text_Renamed
			lResult = fReadValue(FileName, strKingdom, "Nameset", "S", "", Text_Renamed)
			strKingdomSet(hndWorld) = Text_Renamed
			' [Titi 2.5.1] differentiate pictures for male or female characters
			lResult = fReadValue(FileName, strKingdom, "PictureFilesMale", "S", "", Text_Renamed)
			If Text_Renamed <> "" Then ' for compatibility with previous worlds
				strKingdomPictures(hndWorld) = Text_Renamed
				lResult = fReadValue(FileName, strKingdom, "PictureFilesFemale", "S", "", Text_Renamed)
				strKingdomPictures(hndWorld + IIf(intKingdoms <> 0, intKingdoms, WorldNow.Kingdoms.Count())) = Text_Renamed
			Else
				lResult = fReadValue(FileName, strKingdom, "PictureFiles", "S", "", Text_Renamed)
				strKingdomPictures(hndWorld) = Text_Renamed
				strKingdomPictures(hndWorld + IIf(intKingdoms <> 0, intKingdoms, WorldNow.Kingdoms.Count())) = Text_Renamed
			End If
			lResult = fReadValue(FileName, strKingdom, "Location", "S", "", Text_Renamed)
			strKingdomLocation(hndWorld) = Text_Renamed
		Else
			With Me
				If Reverse Then
					.lblKingdomName.Text = strKingdomNames(hndWorld)
					.txtKingdomTemplate.Text = strKingdomTemplate(hndWorld)
					.txtKingdomSet.Text = strKingdomSet(hndWorld)
					.txtKingdomPictures.Text = strKingdomPictures(hndWorld - IIf(intKingdoms <> 0, intKingdoms, WorldNow.Kingdoms.Count()) * CShort(optGender(1).Checked = True))
					.txtKingdomLocation.Text = strKingdomLocation(hndWorld)
					'                .txtWorldMap = WorldNow.PictureFile
				Else
					strKingdomNames(hndWorld) = .lblKingdomName.Text
					strKingdomTemplate(hndWorld) = .txtKingdomTemplate.Text
					strKingdomSet(hndWorld) = .txtKingdomSet.Text
					strKingdomPictures(hndWorld - IIf(intKingdoms <> 0, intKingdoms, WorldNow.Kingdoms.Count()) * CShort(optGender(1).Checked = True)) = .txtKingdomPictures.Text
					strKingdomLocation(hndWorld) = .txtKingdomLocation.Text
					'                WorldNow.PictureFile = .txtWorldMap
				End If
			End With
		End If
	End Sub
	
	Public Sub TabStrip1_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TabStrip1.ClickEvent
		Dim NewLargeChange As Short
		Dim strPictureFile, strKingdom, strPictureName, strLocation, strWorldMap As String
		'UPGRADE_NOTE: Text was upgraded to Text_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim rc As Integer
		Dim hndWorld, intKingdoms As Short
		Dim Text_Renamed, strPicturesList As String
		Dim sinMoveX, sinMoveY As Single
		WorldNow.Name = Me.txtWorldName.Text
		FileName = gAppPath & "\roster\" & WorldNow.Name & "\" & WorldNow.Name & ".ini"
		blnChangeValue = False
		mnuPicture.Enabled = True
		With Me
			If MouseClick_Renamed = VB6.MouseButtonConstants.RightButton Then
				MouseClick_Renamed = VB6.MouseButtonConstants.LeftButton '[Titi 2.4.9b] switching from tvwTome to there with right-clicks pending is no good!
				'UPGRADE_ISSUE: Form method frmWorldSettings.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				.PopupMenu(.mnuAddRemove)
			End If
			.picWorldMap.Image = Nothing
			' [Titi 2.4.9b] no need to "hide" the characters - the frame of the other tabs is large enough to do it!
			'        For hndWorld = 0 To 5
			'            .txtPictureName(hndWorld).Visible = .TabStrip1.SelectedItem.Index < .TabStrip1.Tabs.Count - 1
			'            .picInhabitant(hndWorld).Visible = .TabStrip1.SelectedItem.Index < .TabStrip1.Tabs.Count - 1
			'        Next
			intKingdoms = WorldNow.Kingdoms.Count()
			.txtNumberKingdoms.Text = CStr(intKingdoms)
			If .TabStrip1.SelectedItem.Index < .TabStrip1.Tabs.Count - 2 Then ' the last 3 tabs are not kingdoms
				.fraKingdom(0).BringToFront()
				ReDim Preserve strKingdomTemplate(intKingdoms)
				ReDim Preserve strKingdomNames(intKingdoms)
				ReDim Preserve strKingdomSet(intKingdoms)
				ReDim Preserve strKingdomLocation(intKingdoms)
				ReDim Preserve strKingdomPictures(intKingdoms * 2)
				Dim X1(intKingdoms) As Short
				Dim X2(intKingdoms) As Short
				Dim Y1(intKingdoms) As Short
				Dim Y2(intKingdoms) As Short
				' get kingdoms data
				For hndWorld = 1 To intKingdoms
					PopulateWorldSettings(hndWorld, False, True)
					.txtKingdomSet.Text = strKingdomSet(hndWorld)
					.txtKingdomTemplate.Text = strKingdomTemplate(hndWorld)
					.txtKingdomLocation.Text = strKingdomLocation(hndWorld)
					.txtKingdomPictures.Text = strKingdomPictures(hndWorld - intKingdoms * CShort(optGender(1).Checked = True))
					.lblKingdomName.Text = strKingdomNames(hndWorld)
					strLocation = strKingdomLocation(hndWorld)
					X1(hndWorld) = Val(VB.Left(strLocation, InStr(strLocation, ",") - 1))
					strLocation = VB.Right(strLocation, Len(strLocation) - InStr(strLocation, ","))
					Y1(hndWorld) = Val(VB.Left(strLocation, InStr(strLocation, ",") - 1))
					strLocation = VB.Right(strLocation, Len(strLocation) - InStr(strLocation, ","))
					X2(hndWorld) = Val(VB.Left(strLocation, InStr(strLocation, ",") - 1))
					strLocation = VB.Right(strLocation, Len(strLocation) - InStr(strLocation, ","))
					Y2(hndWorld) = Val(strLocation)
				Next 
				' display current kingdom info
				.txtKingdomSet.Text = strKingdomSet(.TabStrip1.SelectedItem.Index)
				.txtKingdomTemplate.Text = strKingdomTemplate(.TabStrip1.SelectedItem.Index)
				.lblKingdomName.Text = strKingdomNames(.TabStrip1.SelectedItem.Index)
				.txtKingdomPictures.Text = strKingdomPictures(.TabStrip1.SelectedItem.Index - intKingdoms * CShort(optGender(1).Checked = True))
				.txtKingdomLocation.Text = strKingdomLocation(.TabStrip1.SelectedItem.Index)
				' Show the Map
				If oFileSys.CheckExists(gAppPath & "\roster\" & WorldNow.Name & "\" & WorldNow.PictureFile, clsInOut.IOActionType.File) Then
					' if the world ini file has not been created, no map in the roster yet!
					.picMons.Image = System.Drawing.Image.FromFile(gAppPath & "\Roster\" & WorldNow.Name & "\" & WorldNow.PictureFile) ' strWorldMap)
					Text_Renamed = gAppPath & "\Roster\" & WorldNow.Name & "\" & WorldNow.PictureFile
				Else
					.picMons.Image = System.Drawing.Image.FromFile(.txtWorldMap.Text)
					Text_Renamed = .txtWorldMap.Text
				End If
				'            Set .picKingdom = LoadPicture(gAppPath & "\Data\Stock\blankmap.bmp")
				.picKingdom = System.Drawing.Image.FromFile(gDataPath & "\Stock\blankmap.bmp")
				.shpBorder.Height = Y2(.TabStrip1.SelectedItem.Index) '* Screen.TwipsPerPixelY
				.shpBorder.Width = X2(.TabStrip1.SelectedItem.Index) '* Screen.TwipsPerPixelX
				.shpBorder.Left = X1(.TabStrip1.SelectedItem.Index) '* Screen.TwipsPerPixelY
				.shpBorder.Top = Y1(.TabStrip1.SelectedItem.Index) '* Screen.TwipsPerPixelX
				.picTmp = .picMons
				' [Titi 2.4.8] scrolling added
				If blnZoomOut Then
					.HScroll1.Enabled = True
					.VScroll1.Enabled = True
					.picKingdom = .picMons
					' picTmp contains the map at scale 1:1, picKingdom only displays what is visible in its surface
					.HScroll1.Maximum = (.picTmp.ClientRectangle.Width - .picKingdom.ClientRectangle.Width + .VScroll1.Width + .HScroll1.LargeChange - 1)
					.VScroll1.Maximum = (.picTmp.ClientRectangle.Height - .picKingdom.ClientRectangle.Height + .HScroll1.Height + .VScroll1.LargeChange - 1)
					.HScroll1.SmallChange = (.HScroll1.Maximum - .HScroll1.LargeChange + 1) / 20
					NewLargeChange = (.HScroll1.Maximum - .HScroll1.LargeChange + 1) / 4
					.HScroll1.Maximum = .HScroll1.Maximum + NewLargeChange - .HScroll1.LargeChange
					.HScroll1.LargeChange = NewLargeChange
					.VScroll1.SmallChange = (.VScroll1.Maximum - .VScroll1.LargeChange + 1) / 20
					NewLargeChange = (.VScroll1.Maximum - .VScroll1.LargeChange + 1) / 4
					.VScroll1.Maximum = .VScroll1.Maximum + NewLargeChange - .VScroll1.LargeChange
					.VScroll1.LargeChange = NewLargeChange
					.VScroll1.Visible = (.picTmp.ClientRectangle.Height > .picKingdom.ClientRectangle.Height)
					.HScroll1.Visible = (.picTmp.ClientRectangle.Width > .picKingdom.ClientRectangle.Width)
					' center the selected kingdom in the PictureBox
					'                sinMoveX = X1(.TabStrip1.SelectedItem.Index) * Screen.TwipsPerPixelY - (.picKingdom.ScaleWidth - X2(.TabStrip1.SelectedItem.Index) * Screen.TwipsPerPixelX) / 2
					'                sinMoveY = Y1(.TabStrip1.SelectedItem.Index) * Screen.TwipsPerPixelX - (.picKingdom.ScaleHeight - Y2(.TabStrip1.SelectedItem.Index) * Screen.TwipsPerPixelY) / 2
					sinMoveX = X1(.TabStrip1.SelectedItem.Index) - (.picKingdom.ClientRectangle.Width - X2(.TabStrip1.SelectedItem.Index)) / 2
					sinMoveY = Y1(.TabStrip1.SelectedItem.Index) - (.picKingdom.ClientRectangle.Height - Y2(.TabStrip1.SelectedItem.Index)) / 2
					' is centering possible?
					If sinMoveX + .picKingdom.ClientRectangle.Width > .picTmp.ClientRectangle.Width + .VScroll1.Width Then sinMoveX = .picTmp.ClientRectangle.Width - .picKingdom.ClientRectangle.Width + .VScroll1.Width
					If sinMoveY + .picKingdom.ClientRectangle.Height > .picTmp.ClientRectangle.Height + .HScroll1.Height Then sinMoveY = .picTmp.ClientRectangle.Height - .picKingdom.ClientRectangle.Height + .HScroll1.Height
					If sinMoveX < 0 Then sinMoveX = 0
					If sinMoveY < 0 Then sinMoveY = 0
					' go to the selected border
					.HScroll1.Value = sinMoveX
					.VScroll1.Value = sinMoveY
				ElseIf .TabStrip1.SelectedItem.Index < .TabStrip1.Tabs.Count - 2 Then 
					'UPGRADE_ISSUE: frmWorldSettings.picKingdom was upgraded to a Panel, and cannot be coerced to a PictureBox. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="0FF1188E-27C0-4FED-842D-159C65894C9B"'
					ResizePicture(.picMons, .picKingdom, .shpBorder, 6, Text_Renamed)
					.HScroll1.Visible = False
					.VScroll1.Visible = False
				End If
				' Show inhabitants pictures
				For hndWorld = 0 To 5
					'                Set .picMons = LoadPicture(gAppPath & "\Data\Graphics\Creatures\bones.bmp")
					.picMons.Image = System.Drawing.Image.FromFile(gDataPath & "\Graphics\Creatures\bones.bmp")
					'                Set .picInhabitant(hndWorld) = LoadPicture(gAppPath & "\Data\Stock\blankchar.bmp")
					.picInhabitant(hndWorld) = System.Drawing.Image.FromFile(gDataPath & "\Stock\blankchar.bmp")
					.txtPictureName(hndWorld).Text = ""
					' default shape dimensions
					.shpFace(hndWorld).Height = VB6.TwipsToPixelsY(480)
					.shpFace(hndWorld).Width = VB6.TwipsToPixelsX(375)
					'                ResizePicture .picMons, .picInhabitant(hndWorld), .shpFace(hndWorld), hndWorld, gAppPath & "\Data\Graphics\Creatures\bones.bmp"
					'UPGRADE_ISSUE: frmWorldSettings.picInhabitant() was upgraded to a Panel, and cannot be coerced to a PictureBox. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="0FF1188E-27C0-4FED-842D-159C65894C9B"'
					ResizePicture(.picMons, .picInhabitant(hndWorld), .shpFace(hndWorld), hndWorld, gDataPath & "\Graphics\Creatures\bones.bmp")
				Next 
				intNbClicks = -1
				btnLeftRoster.Visible = False
				btnRightRoster.Visible = True
				btnRightRoster.PerformClick()
			ElseIf .TabStrip1.SelectedItem.Index = .TabStrip1.Tabs.Count - 1 Then 
				' [Titi 2.4.9] comments tab
				mnuPicture.Enabled = False
				.fraKingdom(2).BringToFront()
				.txtWorldDesc.Text = WorldNow.Description
				For hndWorld = 0 To 1
					If oFileSys.CheckExists(gAppPath & "\Roster\" & WorldNow.Name & "\" & IIf(hndWorld = 0, VB.Left(WorldNow.PicDesc, InStr(WorldNow.PicDesc, "|") - 1), VB.Right(WorldNow.PicDesc, Len(WorldNow.PicDesc) - InStr(WorldNow.PicDesc, "|"))), clsInOut.IOActionType.File) Then
						.picMons.Image = System.Drawing.Image.FromFile(gAppPath & "\Roster\" & WorldNow.Name & "\" & IIf(hndWorld = 0, VB.Left(WorldNow.PicDesc, InStr(WorldNow.PicDesc, "|") - 1), VB.Right(WorldNow.PicDesc, Len(WorldNow.PicDesc) - InStr(WorldNow.PicDesc, "|"))))
						.picWorldDesc(hndWorld) = System.Drawing.Image.FromFile(gDataPath & "\Stock\blankmap.bmp")
						ResizePicture(.picMons, .picWorldDesc(hndWorld), .tmpShape, 6, gAppPath & "\Roster\" & WorldNow.Name & "\" & .txtPicDescName(hndWorld).Text)
					ElseIf oFileSys.CheckExists(.txtPicDescName(hndWorld).Text, clsInOut.IOActionType.File) Then 
						' the map has been changed, but the settings are not saved
						.picMons.Image = System.Drawing.Image.FromFile(.txtPicDescName(hndWorld).Text)
						.picWorldDesc(hndWorld) = System.Drawing.Image.FromFile(gDataPath & "\Stock\blankmap.bmp")
						ResizePicture(.picMons, .picWorldDesc(hndWorld), .tmpShape, 6, .txtPicDescName(hndWorld).Text)
					Else
						' can't find picture
						.picMons.Image = System.Drawing.Image.FromFile(gDataPath & "\Stock\NoSuchFile.bmp")
						.picWorldDesc(hndWorld) = System.Drawing.Image.FromFile(gDataPath & "\Stock\blankmap.bmp")
						ResizePicture(.picMons, .picWorldDesc(hndWorld), .tmpShape, 6, gDataPath & "\Stock\NoSuchFile.bmp")
					End If
				Next hndWorld
			ElseIf .TabStrip1.SelectedItem.Index = .TabStrip1.Tabs.Count - 2 Then 
				' [Titi 2.4.9b] magic and stats tab
				mnuPicture.Enabled = False
				.fraKingdom(3).BringToFront()
				.txtMagicName.Text = WorldNow.Magic
			Else ' world's general settings
				mnuPicture.Enabled = False
				.fraKingdom(1).BringToFront()
				.lblCount.Text = IIf(WorldNow.Kingdoms.Count() > 1, "Kingdoms", "Kingdom")
				' [Titi 2.6.0] display special events options
				For hndWorld = 0 To .cmbInterface.Items.Count
					If VB6.GetItemString(.cmbInterface, hndWorld) = strInterfaceName Then
						.cmbInterface.SelectedIndex = hndWorld
						Exit For
					End If
				Next 
				' get map picture
				' if the world ini file has not been created, no map in the roster yet!
				If oFileSys.CheckExists(gAppPath & "\Roster\" & WorldNow.Name & "\" & WorldNow.PictureFile, clsInOut.IOActionType.File) Then
					.picMons.Image = System.Drawing.Image.FromFile(gAppPath & "\Roster\" & WorldNow.Name & "\" & WorldNow.PictureFile)
					'                Set .picWorldMap = LoadPicture(gAppPath & "\Data\Stock\blankmap.bmp")
					.picWorldMap.Image = System.Drawing.Image.FromFile(gDataPath & "\Stock\blankmap.bmp")
					ResizePicture(.picMons, .picWorldMap, .tmpShape, 6, gAppPath & "\Roster\" & WorldNow.Name & "\" & WorldNow.PictureFile)
				Else
					' the map has been changed, but the settings are not saved
					.picMons.Image = System.Drawing.Image.FromFile(.txtWorldMap.Text)
					'                Set .picWorldMap = LoadPicture(gAppPath & "\Data\Stock\blankmap.bmp")
					.picWorldMap.Image = System.Drawing.Image.FromFile(gDataPath & "\Stock\blankmap.bmp")
					ResizePicture(.picMons, .picWorldMap, .tmpShape, 6, .txtWorldMap.Text)
				End If
				' get currency picture
				'            If oFileSys.CheckExists(gAppPath & "\Data\Graphics\Items\" & .txtMoney(1), File) Then
				'                Set .picMons = LoadPicture(gAppPath & "\Data\Graphics\Items\" & .txtMoney(1))
				'                Set .picMoney = LoadPicture(gAppPath & "\Data\Stock\blankchar.bmp")
				'                ResizePicture .picMons, .picMoney, .tmpShape, 7, gAppPath & "\Data\Graphics\Items\" & .txtMoney(1)
				If oFileSys.CheckExists(gDataPath & "\Graphics\Items\" & .txtMoney(1).Text, clsInOut.IOActionType.File) Then
					.picMons.Image = System.Drawing.Image.FromFile(gDataPath & "\Graphics\Items\" & .txtMoney(1).Text)
					.picMoney.Image = System.Drawing.Image.FromFile(gDataPath & "\Stock\blankchar.bmp")
					ResizePicture(.picMons, .picMoney, .tmpShape, 7, gDataPath & "\Graphics\Items\" & .txtMoney(1).Text)
				Else
					' picture file for the money not found
					'                Set .picMons = LoadPicture(gAppPath & "\Data\Graphics\Items\NoSuchFile.bmp")
					'                Set .picMoney = LoadPicture(gAppPath & "\Data\Stock\blankchar.bmp")
					'                ResizePicture .picMons, .picMoney, .tmpShape, 7, gAppPath & "\Data\Graphics\Items\NoSuchFile.bmp"
					.picMons.Image = System.Drawing.Image.FromFile(gDataPath & "\Graphics\Items\NoSuchFile.bmp")
					.picMoney.Image = System.Drawing.Image.FromFile(gDataPath & "\Stock\blankchar.bmp")
					ResizePicture(.picMons, .picMoney, .tmpShape, 7, gDataPath & "\Graphics\Items\NoSuchFile.bmp")
				End If
			End If
			.Refresh()
		End With
		blnChangeValue = True
	End Sub
	
	'UPGRADE_WARNING: Event txtCoef.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtCoef_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCoef.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		Dirty = True
	End Sub
	
	Private Sub txtCoef_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCoef.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtHPperLevel.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtHPperLevel_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHPperLevel.TextChanged
		If blnChangeValue Then
			If Me.txtHPperLevel.Text <> vbNullString Then
				If Asc(Me.txtHPperLevel.Text) >= 48 And Asc(Me.txtHPperLevel.Text) <= 57 Then
					WorldNow.HPPerLevel = CShort(Me.txtHPperLevel.Text)
				Else
					Me.txtHPperLevel.Text = CStr(WorldNow.HPPerLevel)
				End If
				Dirty = True
			End If
		End If
	End Sub
	
	Private Sub txtIntroMusic_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIntroMusic.Click
		On Error Resume Next
		If blnChangeValue Then
			frmMDI.dlgFileOpen.FileName = Me.txtMusicFolder.Text
			'        If Not oFileSys.CheckExists(frmMDI.dlgFile.FileName, Folder) Then frmMDI.dlgFile.InitDir = gAppPath & "\Data\Music"
			If Not oFileSys.CheckExists((frmMDI.dlgFileOpen.FileName), clsInOut.IOActionType.Folder) Then
				frmMDI.dlgFileOpen.FileName = gDataPath & "\Music\*.mp3"
			End If
			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
			frmMDI.dlgFile.CancelError = True
			frmMDI.dlgFileOpen.Title = "Select Music"
			'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			frmMDI.dlgFileOpen.Filter = "MP3 files (*.mp3)|*.mp3|MIDI files (*.mid)|*.mid|All files (*.*)|*.*"
			frmMDI.dlgFileOpen.FilterIndex = 1
			'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			'UPGRADE_NOTE: Variable frmMDI.dlgFile was renamed frmMDI.dlgFileOpen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="94ADAC4D-C65D-414F-A061-8FDC6B83C5EC"'
			'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.CheckPathExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			frmMDI.dlgFileOpen.CheckFileExists = True
			frmMDI.dlgFileOpen.CheckPathExists = True
			'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			frmMDI.dlgFileOpen.ShowReadOnly = False
			'UPGRADE_NOTE: Variable frmMDI.dlgFile was renamed frmMDI.dlgFileOpen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="94ADAC4D-C65D-414F-A061-8FDC6B83C5EC"'
			'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.RestoreDirectory which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			frmMDI.dlgFileOpen.RestoreDirectory = False
			frmMDI.dlgFileOpen.ShowDialog()
			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
			If Err.Number = DialogResult.Cancel Then
				Exit Sub
			End If
			'UPGRADE_WARNING: CommonDialog property frmMDI.dlgFile.FileTitle was upgraded to frmMDI.dlgFile.FileName which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			Me.txtIntroMusic.Text = frmMDI.dlgFileOpen.FileName
			Dirty = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtKingdomSet.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtKingdomSet_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtKingdomSet.TextChanged
		If blnChangeValue Then
			strKingdomSet(Me.TabStrip1.SelectedItem.Index) = Me.txtKingdomSet.Text
			Dirty = True
		End If
	End Sub
	
	Public Sub TemplateUpdate(ByRef strPrevious As String)
		Dim CreatureX As Creature
		Dim i As Short
		With Me
			For	Each CreatureX In Tome.Creatures
				If CreatureX.Name = strPrevious Then
					CreatureX.Name = .txtKingdomTemplate.Text
				End If
			Next CreatureX
			For i = 1 To frmProject.tvwTome.Nodes.Count
				If frmProject.tvwTome.Nodes(i).Text = strPrevious Then
					frmProject.tvwTome.Nodes(i).Text = .txtKingdomTemplate.Text 'CreatureX.Name
				End If
			Next 
			strKingdomTemplate(.TabStrip1.SelectedItem.Index) = .txtKingdomTemplate.Text
		End With
		If blnChangeValue Then Dirty = True
	End Sub
	
	'UPGRADE_WARNING: Event txtKingdomTemplate.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtKingdomTemplate_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtKingdomTemplate.TextChanged
		If blnChangeValue Then TemplateUpdate(strKingdomTemplate(Me.TabStrip1.SelectedItem.Index))
	End Sub
	
	'UPGRADE_WARNING: Event txtMagicName.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtMagicName_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMagicName.TextChanged
		'    If blnChangeValue Then
		WorldNow.Magic = Me.txtMagicName.Text
		lblMagicFormula.Text = "according to the formula: " & WorldNow.Magic & " ="
		Dirty = True
		'    End If
	End Sub
	
	'UPGRADE_WARNING: Event txtMagicPerLevel.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtMagicPerLevel_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMagicPerLevel.TextChanged
		If blnChangeValue Then
			WorldNow.MagicPerLevel = CShort(txtMagicPerLevel.Text)
			Dirty = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtMoney.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtMoney_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMoney.TextChanged
		Dim Index As Short = txtMoney.GetIndex(eventSender)
		If blnChangeValue Then
			WorldNow.Money = txtMoney(0).Text & "|" & txtMoney(1).Text
			Dirty = True
		End If
	End Sub
	
	Private Sub txtMusicFolder_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMusicFolder.Click
		Dim lpIDList As Integer
		Dim sBuffer As String
		Dim tBrowseInfo As BrowseInfo
		If blnChangeValue Then
			With tBrowseInfo
				.hWndOwner = Me.Handle.ToInt32
				'        .lpszTitle = lstrcat(szTitle, "")
				.ulFlags = BIF_RETURNONLYFSDIRS + BIF_DONTGOBELOWDOMAIN
			End With
			lpIDList = SHBrowseForFolder(tBrowseInfo)
			If (lpIDList) Then
				sBuffer = Space(MAX_PATH)
				SHGetPathFromIDList(lpIDList, sBuffer)
				sBuffer = VB.Left(sBuffer, InStr(sBuffer, vbNullChar) - 1)
				If VB.Right(sBuffer, 1) = "\" Then sBuffer = VB.Left(sBuffer, Len(sBuffer) - 1)
				Me.txtMusicFolder.Text = sBuffer
				Dirty = True
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtWorldDesc.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtWorldDesc_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWorldDesc.TextChanged
		If blnChangeValue Then
			WorldNow.Description = Me.txtWorldDesc.Text & " "
			Dirty = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtSkillPtsPerLevel.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtSkillPtsPerLevel_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSkillPtsPerLevel.TextChanged
		If blnChangeValue Then
			If Me.txtSkillPtsPerLevel.Text <> vbNullString Then
				If Asc(Me.txtSkillPtsPerLevel.Text) >= 48 And Asc(Me.txtSkillPtsPerLevel.Text) <= 57 Then
					WorldNow.SkillPtsPerLevel = CShort(Me.txtSkillPtsPerLevel.Text)
				Else
					Me.txtSkillPtsPerLevel.Text = CStr(WorldNow.SkillPtsPerLevel)
				End If
				Dirty = True
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtWorldName.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtWorldName_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWorldName.TextChanged
		If blnChangeValue Then
			WorldNow.Name = Me.txtWorldName.Text
			Me.TabStrip1.Tabs(Me.TabStrip1.Tabs.Count)._ObjectDefault = WorldNow.Name
			Dirty = True
		End If
	End Sub
	
	Private Sub ResizePicture(ByRef picOrg As System.Windows.Forms.PictureBox, ByRef picDest As System.Windows.Forms.PictureBox, ByRef shpDest As Microsoft.VisualBasic.PowerPacks.Shape, ByRef Index As Short, ByRef PictureFile As String)
		Dim NewHeight, NewWidth As Single
		Dim X, Y As Short
		'UPGRADE_WARNING: Arrays in structure bmMask may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		'UPGRADE_WARNING: Arrays in structure bmMons may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		'UPGRADE_WARNING: Arrays in structure bmBlack may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmBlack, bmMons, bmMask As BITMAPINFO
		Dim rc, hMemMons, lpMem, TransparentRGB As Integer
		If Index = 6 Then
			' calculate resize coefficient
			Size_Renamed(Index) = 1
			If VB6.PixelsToTwipsY(picOrg.Height) > VB6.PixelsToTwipsY(picDest.ClientRectangle.Height) Then
				Size_Renamed(Index) = VB6.PixelsToTwipsY(picDest.ClientRectangle.Height) / VB6.PixelsToTwipsY(picOrg.Height)
			End If
			If VB6.PixelsToTwipsX(picOrg.Width) * Size_Renamed(Index) > VB6.PixelsToTwipsX(picDest.ClientRectangle.Width) Then
				Size_Renamed(Index) = VB6.PixelsToTwipsX(picDest.ClientRectangle.Width) / VB6.PixelsToTwipsX(picOrg.Width)
			End If
			' Center picture in frame
			X = CShort(VB6.PixelsToTwipsX(picDest.ClientRectangle.Width) - (VB6.PixelsToTwipsX(picOrg.Width) * Size_Renamed(Index))) / 2
			Y = CShort(VB6.PixelsToTwipsY(picDest.ClientRectangle.Height) - (VB6.PixelsToTwipsY(picOrg.Height) * Size_Renamed(Index))) / 2
			' Resize shape (yellow square around the face, or borders)
			If VB.Left(shpDest.Name, 3) = "shp" Then
				shpDest.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(shpDest.Width) * Size_Renamed(Index))
				shpDest.Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(shpDest.Height) * Size_Renamed(Index))
				shpDest.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(shpDest.Top) * Size_Renamed(Index) + Y)
				shpDest.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(shpDest.Left) * Size_Renamed(Index) + X)
			End If
			' Resize picture to fit in space available
			NewHeight = CShort(VB6.PixelsToTwipsY(picOrg.Height) * Size_Renamed(Index))
			NewWidth = CShort(VB6.PixelsToTwipsX(picOrg.Width) * Size_Renamed(Index))
			OffsetX(Index) = X
			OffsetY(Index) = Y
			'UPGRADE_ISSUE: Constant vbSrcCopy was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
			'UPGRADE_ISSUE: PictureBox method picDest.PaintPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picDest.PaintPicture(picOrg.Image, X, Y, NewWidth, NewHeight,  ,  ,  ,  , vbSrcCopy)
		Else
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
			Size_Renamed(Index) = 1
			'    If picMons.Width > picInhabitant(Index).ScaleWidth Then
			'        Size(Index) = picInhabitant(Index).ScaleWidth / picMons.Width
			If picMons.Width > VB6.PixelsToTwipsX(picDest.ClientRectangle.Width) Then
				Size_Renamed(Index) = VB6.PixelsToTwipsX(picDest.ClientRectangle.Width) / picMons.Width
			End If
			'    If picMons.Height * Size(Index) > picInhabitant(Index).ScaleHeight Then
			'        Size(Index) = picInhabitant(Index).ScaleHeight / picMons.Height
			If picMons.Height * Size_Renamed(Index) > VB6.PixelsToTwipsY(picDest.ClientRectangle.Height) Then
				Size_Renamed(Index) = VB6.PixelsToTwipsY(picDest.ClientRectangle.Height) / picMons.Height
			End If
			' Center Creature in frame
			'    X = CInt(picInhabitant(Index).ScaleWidth - (picMons.Width * Size(Index))) / 2
			'    Y = CInt(picInhabitant(Index).ScaleHeight - (picMons.Height * Size(Index))) / 2
			X = CShort(VB6.PixelsToTwipsX(picDest.ClientRectangle.Width) - (picMons.Width * Size_Renamed(Index))) / 2
			Y = CShort(VB6.PixelsToTwipsY(picDest.ClientRectangle.Height) - (picMons.Height * Size_Renamed(Index))) / 2
			NewHeight = CShort(picMons.Height * Size_Renamed(Index))
			NewWidth = CShort(picMons.Width * Size_Renamed(Index))
			' Paint Creature
			'    picInhabitant(Index).Cls
			'UPGRADE_ISSUE: PictureBox method picDest.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picDest.Cls()
			'    rc = SetStretchBltMode(picInhabitant(Index).hdc, 3)
			'    rc = StretchBlt(picInhabitant(Index).hdc, X, Y, NewWidth, NewHeight, picMask.hdc, 0, 0, picMask.Width, picMask.Height, SRCAND)
			'    rc = StretchBlt(picInhabitant(Index).hdc, X, Y, NewWidth, NewHeight, picMons.hdc, 0, 0, picMons.Width, picMons.Height, SRCPAINT)
			'UPGRADE_ISSUE: PictureBox property picDest.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			rc = SetStretchBltMode(picDest.hdc, 3)
			'UPGRADE_ISSUE: PictureBox property picMask.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			'UPGRADE_ISSUE: PictureBox property picDest.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			rc = StretchBlt(picDest.hdc, X, Y, NewWidth, NewHeight, picMask.hdc, 0, 0, picMask.Width, picMask.Height, SRCAND)
			'UPGRADE_ISSUE: PictureBox property picMons.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			'UPGRADE_ISSUE: PictureBox property picDest.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			rc = StretchBlt(picDest.hdc, X, Y, NewWidth, NewHeight, picMons.hdc, 0, 0, picMons.Width, picMons.Height, SRCPAINT)
			OffsetX(Index) = X
			OffsetY(Index) = Y
			If VB.Left(shpDest.Name, 3) = "shp" Then
				shpDest.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(shpDest.Width) * Size_Renamed(Index) / VB6.TwipsPerPixelX)
				shpDest.Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(shpDest.Height) * Size_Renamed(Index) / VB6.TwipsPerPixelY)
				shpDest.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(shpDest.Top) * Size_Renamed(Index) / VB6.TwipsPerPixelY + Y)
				shpDest.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(shpDest.Left) * Size_Renamed(Index) / VB6.TwipsPerPixelX + X)
			End If
		End If
	End Sub
	
	'UPGRADE_NOTE: VScroll1.Change was changed from an event to a procedure. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
	'UPGRADE_WARNING: VScrollBar event VScroll1.Change has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub VScroll1_Change(ByVal newScrollValue As Integer)
		Dim intTop, intLeft As Short
		Dim strLocation As String
		strLocation = Me.txtKingdomLocation.Text
		intLeft = Val(VB.Left(strLocation, InStr(strLocation, ",") - 1)) '* Screen.TwipsPerPixelX
		strLocation = VB.Right(strLocation, Len(strLocation) - InStr(strLocation, ","))
		intTop = Val(VB.Left(strLocation, InStr(strLocation, ",") - 1)) '* Screen.TwipsPerPixelY
		'UPGRADE_ISSUE: Panel property picKingdom.BackgroundImage will be tiled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ED2DEFAA-C59C-4EDB-AF23-73A16C92C3AC"'
		'UPGRADE_ISSUE: PictureBox method picKingdom.PaintPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picKingdom.PaintPicture(picKingdom.BackgroundImage, -HScroll1.Value, -newScrollValue)
		'UPGRADE_WARNING: Shape method shpBorder.Move has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		shpBorder.SetBounds(intLeft - HScroll1.Value, intTop - newScrollValue, shpBorder.Width, shpBorder.Height)
	End Sub
	
	'UPGRADE_NOTE: VScroll1.Scroll was changed from an event to a procedure. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
	Private Sub VScroll1_Scroll_Renamed(ByVal newScrollValue As Integer)
		VScroll1_Change(0)
	End Sub
	
	Public Sub NewAbilities()
		Dim TriggerY, TriggerX, TriggerZ As Trigger
		Dim Index As Short
		Dim CreatureX As Creature
		For	Each CreatureX In Tome.Creatures
			Index = 3
			For	Each TriggerX In CreatureX.Triggers
				If TriggerX.Name = "New Abilities" Then
					For	Each TriggerY In TriggerX.Triggers
						For	Each TriggerZ In TriggerY.Triggers
							cmbMagicBasis.Items.Add(TriggerZ.Name)
							chkStats(Index).Text = TriggerZ.Name
							chkStats(Index).CheckState = System.Windows.Forms.CheckState.Checked
							Index = Index + 1
							chkStats(Index).Visible = True
						Next TriggerZ
					Next TriggerY
				End If
			Next TriggerX
		Next CreatureX
		For Index = 0 To cmbMagicBasis.Items.Count - 1
			If VB6.GetItemString(cmbMagicBasis, Index) = VB.Right(lblFormulaBasis.Text, Len(lblFormulaBasis.Text) - 2) Then
				cmbMagicBasis.SelectedIndex = Index
			End If
		Next 
	End Sub
	Private Sub HScroll1_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles HScroll1.Scroll
		Select Case eventArgs.type
			Case System.Windows.Forms.ScrollEventType.ThumbTrack
				HScroll1_Scroll_Renamed(eventArgs.newValue)
			Case System.Windows.Forms.ScrollEventType.EndScroll
				HScroll1_Change(eventArgs.newValue)
		End Select
	End Sub
	Private Sub VScroll1_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles VScroll1.Scroll
		Select Case eventArgs.type
			Case System.Windows.Forms.ScrollEventType.ThumbTrack
				VScroll1_Scroll_Renamed(eventArgs.newValue)
			Case System.Windows.Forms.ScrollEventType.EndScroll
				VScroll1_Change(eventArgs.newValue)
		End Select
	End Sub
End Class