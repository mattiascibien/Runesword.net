Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frmItemExplorer
	Inherits System.Windows.Forms.Form
	
	Dim TreeViewX As AxComctlLib.AxTreeView
	Dim ItemX As Item
	Dim PictureDir, PictureFile As String
	'UPGRADE_NOTE: Size was upgraded to Size_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Dim Size_Renamed As Double
	
	Dim fsoFile As Short
	
	' Display size indicator
	Const bdSmallDisplay As Short = 1
	Const bdLargeDisplay As Short = 2
	Dim iDisplaySize As Short
	
	Private Sub InitItemExplorer()
		Dim bExists As Boolean
		dlstDirectory.Path = gLibPath
		bExists = oFileSys.CheckExists(dlstDirectory.Path & "\Items", clsInOut.IOActionType.Folder, False)
		If bExists = True Then
			dlstDirectory.Path = dlstDirectory.Path & "\Items"
		End If
		flsFileList.Path = dlstDirectory.Path
		flsFileList.Refresh()
		' decide how to display
		If (VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) / VB6.TwipsPerPixelX) >= 1280 Then
			iDisplaySize = bdLargeDisplay
		Else
			'cmdClose.Visible = False
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
		If ItemX Is Nothing Then
			MsgBox("Please select an item first!", MsgBoxStyle.OKOnly, "Undefined item")
			Exit Sub
		End If
		If frmMDI.TreeViewX.SelectedItem.Parent Is Nothing Then
			MsgBox("Please select a place to insert the " & ItemX.Name & " first!", MsgBoxStyle.OKOnly, "Invalid destination")
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object frmMDI.TreeViewX.SelectedItem.Tag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Tag_Renamed = frmMDI.TreeViewX.SelectedItem.Tag
			If frmProject.ValidDrop("EncountersE1", frmMDI.TreeViewX.SelectedItem.Parent.Tag) = True Or frmProject.ValidDrop("EncountersE1I1", frmMDI.TreeViewX.SelectedItem.Tag) = True Then
				ObjectX = frmMDI.ObjectListX.Item(Tag_Renamed)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectX.AddItem. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit = ObjectX.AddItem
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Index = ObjectEdit.Index
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Copy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.Copy(ItemX)
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit.Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ObjectEdit.Index = Index
				'UPGRADE_WARNING: Couldn't resolve default property of object ObjectEdit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				frmMDI.ShowItem((frmMDI.ObjectListX), (frmMDI.TreeViewX), Tag_Renamed, ObjectEdit)
				' cut & paste below to give several copies of the same item different names
				frmMDI.EditCut(Tag_Renamed & "I" & Index)
				frmMDI.EditPaste(Tag_Renamed)
			Else
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
			InitItemExplorer()
		End If
	End Sub
	
	Private Sub flsFileList_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flsFileList.SelectedIndexChanged
		LoadItem()
	End Sub
	
	Private Sub frmItemExplorer_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		InitItemExplorer()
	End Sub
	
	Private Sub LoadItem()
		txtDataPath.Text = flsFileList.Path & "\" & flsFileList.Items(flsFileList.SelectedIndex)
		fsoFile = FreeFile
		FileOpen(fsoFile, txtDataPath.Text, OpenMode.Binary)
		ItemX = New Item
		ItemX.ReadFromFile(fsoFile)
		If iDisplaySize = bdSmallDisplay Then
			DisplayItemInfoText()
		Else
			DisplayItemInfo()
		End If
		FileClose(fsoFile)
	End Sub
	
	Private Sub SizeAndShow()
		' set form components for each view style then go to the correct creature display sub
		If iDisplaySize = bdSmallDisplay Then
			' small option :
			Me.Width = VB6.TwipsToPixelsX(8460)
			Me.Height = VB6.TwipsToPixelsY(5955)
			fraFullView.Visible = False
			flsFileList.Height = VB6.ToPixelsUserHeight(120, 609, 609)
			fraCompactView.Visible = True
			fraCompactView.Refresh()
			txtInfo.Visible = True
			cmdClose.Text = "Full View"
			btnInsert.Top = VB6.ToPixelsUserY(216, 0, 609, 609)
			btnInsert.Left = VB6.ToPixelsUserX(184, 0, 1159, 1159)
			btnInsert.BringToFront()
			'DisplayItemInfoText
		Else
			' large option : DisplayItemInfo
			Me.Width = VB6.TwipsToPixelsX(17370)
			Me.Height = VB6.TwipsToPixelsY(9615)
			fraCompactView.Visible = False
			fraFullView.Visible = True
			flsFileList.Height = VB6.ToPixelsUserHeight(344, 609, 609)
			cmdClose.Text = "Compact View"
			fraFullView.Refresh()
			txtInfo.Refresh()
			btnInsert.Top = VB6.ToPixelsUserY(48, 0, 609, 609)
			btnInsert.Left = VB6.ToPixelsUserX(536, 0, 1159, 1159)
			btnInsert.BringToFront()
			'DisplayCreaInfo
		End If
		If flsFileList.SelectedIndex <> -1 Then
			LoadItem()
		End If
	End Sub
	
	Private Sub DisplayItemInfoText()
		Dim c, iNumItems As Short
		Dim ItemY As Item
		'UPGRADE_NOTE: Text was upgraded to Text_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Text_Renamed, sInfo As String
		Dim strSize(4) As String
		' Clean-up the info display
		txtInfo.Text = "Loading..."
		txtInfo.Refresh()
		Me.Text = "Item [" & ItemX.Name & "]"
		' Describe item's size
		strSize(4) = "Huge" : strSize(3) = "Large" : strSize(2) = "Normal" : strSize(1) = "Small" : strSize(0) = "Tiny"
		sInfo = "Name: " & ItemX.Name & vbCrLf
		sInfo = sInfo & "Comments: " & ItemX.Comments & vbCrLf
		sInfo = sInfo & "Count: " & ItemX.Count & vbCrLf
		sInfo = sInfo & "Bulk: " & ItemX.BulkEmpty & vbCrLf
		sInfo = sInfo & "Weight: " & ItemX.WeightEmpty & vbCrLf
		If ItemX.Capacity > 0 Then
			sInfo = sInfo & IIf(CBool(ItemX.SoftCapacity * CShort(True)), "Soft", "Solid") & " container" & vbCrLf
			sInfo = sInfo & "(total weight:" & ItemX.Weight & ")" & vbCrLf
			sInfo = sInfo & "(total bulk:" & ItemX.Bulk & ")" & vbCrLf & "(contains " & ItemX.Items.Count() & " item" & IIf(ItemX.Items.Count() > 1, "s:", ":") & " "
			For	Each ItemY In ItemX.Items
				sInfo = sInfo & ItemY.Name & ", "
			Next ItemY
			Mid(sInfo, Len(sInfo) - 1) = ")"
			sInfo = sInfo & vbCrLf
		End If
		txtSize.Text = strSize(ItemX.Size - 1) & IIf(ItemX.SizeBit(9) >= 512, " (but can be used by any creature)", " creatures only")
		sInfo = sInfo & "Size: " & txtSize.Text & vbCrLf
		' Load and paint Picture from myPicture
		PictureDir = gDataPath & "\graphics\items"
		PictureFile = ItemX.PictureFile
		ShowItemPicture(PictureFile)
		sInfo = sInfo & "Level: " & ItemX.MinLevel & vbCrLf
		sInfo = sInfo & "Can Combine: " & CBool(ItemX.CanCombine * CShort(True)) & vbCrLf
		sInfo = sInfo & "Value: " & VB6.Format(ItemX.Value) & vbCrLf
		sInfo = sInfo & "Family: " & SetUpItemFamily((ItemX.Family)) & vbCrLf
		sInfo = sInfo & IIf(ItemX.WearType = 11, "two-handed", "") & vbCrLf
		If ItemX.Family > 3 Then
			sInfo = sInfo & "-------------------------" & vbCrLf
			sInfo = sInfo & "Uses " & VB6.Format(ItemX.ActionPoints) & " AP" & vbCrLf
			sInfo = sInfo & "Attack bonus: " & VB6.Format(ItemX.AttackBonus) & vbCrLf
			Select Case ItemX.DamageType
				Case 0
					Text_Renamed = "none"
				Case 1
					Text_Renamed = "sharp"
				Case 2
					Text_Renamed = "blunt"
				Case 3
					Text_Renamed = "cold"
				Case 4
					Text_Renamed = "fire"
				Case 5
					Text_Renamed = "evil"
				Case 6
					Text_Renamed = "holy"
				Case 7
					Text_Renamed = "magic"
				Case 8
					Text_Renamed = "mind"
			End Select
			sInfo = sInfo & "Damage type: " & Text_Renamed & vbCrLf
			If ItemX.Family >= 6 And ItemX.Family <= 8 Then
				strSize(0) = "Short" : strSize(1) = "Medium" : strSize(2) = "Long"
				If ItemX.Family = 6 Then
					sInfo = sInfo & strSize(ItemX.RangeType) & " range" & vbCrLf
				End If
				Select Case ItemX.ShootType
					Case 0
						Text_Renamed = "Arrow (Short)"
					Case 1
						Text_Renamed = "Arrow (Long)"
					Case 2
						Text_Renamed = "Sling (Light)"
					Case 3
						Text_Renamed = "Sling (Heavy)"
					Case 4
						Text_Renamed = "Gun (Small)"
					Case 5
						Text_Renamed = "Gun (Large)"
					Case 6
						Text_Renamed = "Energy (Low)"
					Case 7
						Text_Renamed = "Energy (High)"
				End Select
				sInfo = sInfo & "Ammo type: " & Text_Renamed & vbCrLf
			End If
			If ItemX.Damage > 0 Then
				Text_Renamed = (ItemX.Damage - 1) Mod 5 + 1 & "d" & Int(((ItemX.Damage - 1) Mod 25) / 5) * 2 + 4
				If ItemX.Damage - 1 > 24 Then
					Text_Renamed = Text_Renamed & "+" & Int((ItemX.Damage - 1) / 25)
				End If
			Else
				Text_Renamed = "none"
			End If
			If ItemX.DamageBonus <> 0 Then sInfo = sInfo & IIf(ItemX.DamageBonus > 0, "+", "-") & System.Math.Abs(ItemX.DamageBonus) & " damage bonus" & vbCrLf
			sInfo = sInfo & "Damage:" & Text_Renamed & vbCrLf
		ElseIf ItemX.Family = 3 Then 
			' special effects for food
			Select Case ItemX.DamageType - 1
				Case 0
					Text_Renamed = "None"
				Case 1
					Text_Renamed = "Heal" ' gives health
				Case 2
					Text_Renamed = "Sickness" ' takes health
				Case 3
					Text_Renamed = "Energy" ' adds Eternium (if relevant)
				Case 4
					Text_Renamed = "Fatigue" ' takes Eternium (if relevant)
				Case 5
					Text_Renamed = "Poison" ' adds a poison trigger
				Case 6
					Text_Renamed = "Curse" ' adds a curse trigger
				Case 7
					Text_Renamed = "Random" ' any of the above, known only after use
			End Select
			If ItemX.Damage > 0 Then
				Text_Renamed = Text_Renamed & " (" & (ItemX.Damage - 1) Mod 5 + 1 & "d" & Int(((ItemX.Damage - 1) Mod 25) / 5) * 2 + 4
				If ItemX.Damage - 1 > 24 Then
					Text_Renamed = Text_Renamed & "+" & Int((ItemX.Damage - 1) / 25)
				End If
			End If
			sInfo = sInfo & "Food effect: " & Text_Renamed & ")" & vbCrLf
			sInfo = sInfo & "Spoiled after " & VB6.Format(ItemX.DamageBonus) & " days" & vbCrLf
		End If
		If ItemX.WearType < 10 Then ' Potential Armor
			Select Case ItemX.WearType
				Case 0 ' Body
					Text_Renamed = "on the body"
				Case 1 ' Helm
					Text_Renamed = "on the head"
				Case 2 ' Glove
					Text_Renamed = "on the hand"
				Case 3 ' Bracelet
					Text_Renamed = "on the wrist"
				Case 4 ' BackPack
					Text_Renamed = "on the back"
				Case 5 ' Shield
					Text_Renamed = "on the arm"
				Case 6 ' Boots
					Text_Renamed = "on the feet"
				Case 7 ' Necklace
					Text_Renamed = "around the neck"
				Case 8 ' Belt
					Text_Renamed = "around the waist"
				Case 9 ' Ring
					Text_Renamed = "on a finger"
			End Select
			sInfo = sInfo & "worn " & Text_Renamed & vbCrLf
			sInfo = sInfo & "absorbs up to " & ItemX.Resistance & "% damage" & vbCrLf
			If ItemX.Defense <> 0 Then
				sInfo = sInfo & IIf(ItemX.Defense < 0, "degrades", "improves") & " its wearer's Defense by " & System.Math.Abs(ItemX.Defense) & vbCrLf
			End If
			If ItemX.ResistanceBonus <> 0 Then
				sInfo = sInfo & "provides additional " & ItemX.ResistanceBonus * 10 & "% protection against " & SetUpResistanceType((ItemX.ResistanceType)) & "-based attacks/effects" & vbCrLf
			End If
		End If
		' Triggers
		sInfo = sInfo & "-------------------------" & vbCrLf
		sInfo = sInfo & "Triggers:" & vbCrLf
		iNumItems = ItemX.Triggers.Count()
		For c = 1 To iNumItems
			'UPGRADE_WARNING: Couldn't resolve default property of object ItemX.Triggers(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ItemX.Triggers().TriggerType. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sInfo = sInfo & "  " & TriggerName(ItemX.Triggers.Item(c).TriggerType) & " " & ItemX.Triggers.Item(c).Name & vbCrLf
		Next 
		' reset comment displays
		txtInfo.Text = sInfo
		txtInfo.Refresh()
	End Sub
	
	Private Sub DisplayItemInfo()
		Dim c, iNumItems As Short
		'UPGRADE_NOTE: Text was upgraded to Text_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Text_Renamed, sInfo As String
		Dim strSize(4) As String
		Dim ItemY As Item
		' Clean-up the info display
		lstArmor.Items.Clear()
		lstFood.Items.Clear()
		txtInfo.Text = "Loading..."
		txtInfo.Refresh()
		txtCapacity.Text = "" : txtCapacity.BorderStyle = System.Windows.Forms.FormBorderStyle.None
		lblSoft.Text = ""
		txtContainerWeight.Text = "" : txtContainerWeight.BorderStyle = System.Windows.Forms.FormBorderStyle.None
		txtContainerBulk.Text = "" : txtContainerBulk.BorderStyle = System.Windows.Forms.FormBorderStyle.None
		For c = 0 To 7
			txtStats(c).Text = ""
		Next 
		' Describe item's size
		strSize(4) = "Huge" : strSize(3) = "Large" : strSize(2) = "Normal" : strSize(1) = "Small" : strSize(0) = "Tiny"
		Me.Text = "Item [" & ItemX.Name & "]"
		txtName.Text = ItemX.Name
		txtComments.Text = ItemX.Comments
		txtCount.Text = CStr(ItemX.Count)
		txtBulk.Text = CStr(ItemX.BulkEmpty)
		txtWeight.Text = CStr(ItemX.WeightEmpty)
		txtSize.Text = strSize(ItemX.Size - 1) & IIf(ItemX.SizeBit(9) >= 512, " (but can be used by any creature)", " creatures only")
		' Load and paint Picture from myPicture
		PictureDir = gDataPath & "\graphics\items"
		PictureFile = ItemX.PictureFile
		ShowItemPicture(PictureFile)
		txtLevel.Text = CStr(ItemX.MinLevel)
		chkCanCombine.CheckState = ItemX.CanCombine * CShort(True)
		txtValue.Text = VB6.Format(ItemX.Value)
		For c = 0 To 18
			chkFamily(c).CheckState = System.Windows.Forms.CheckState.Unchecked
		Next 
		chkFamily(ItemX.Family).CheckState = System.Windows.Forms.CheckState.Checked
		chk2hands.CheckState = System.Math.Abs(CInt(ItemX.WearType = 11))
		If ItemX.Family > 3 Then
			txtStats(0).Text = VB6.Format(ItemX.ActionPoints)
			txtStats(1).Text = VB6.Format(ItemX.AttackBonus)
			txtStats(2).Text = VB6.Format(ItemX.Defense)
			Select Case ItemX.DamageType
				Case 0
					Text_Renamed = "none"
				Case 1
					Text_Renamed = "sharp"
				Case 2
					Text_Renamed = "blunt"
				Case 3
					Text_Renamed = "cold"
				Case 4
					Text_Renamed = "fire"
				Case 5
					Text_Renamed = "evil"
				Case 6
					Text_Renamed = "holy"
				Case 7
					Text_Renamed = "magic"
				Case 8
					Text_Renamed = "mind"
			End Select
			txtStats(4).Text = Text_Renamed
			If ItemX.Family >= 6 And ItemX.Family <= 8 Then
				strSize(0) = "Short" : strSize(1) = "Medium" : strSize(2) = "Long"
				If ItemX.Family = 6 Then
					txtStats(5).Text = strSize(ItemX.RangeType)
				End If
				Select Case ItemX.ShootType
					Case 0
						Text_Renamed = "Arrow (Short)"
					Case 1
						Text_Renamed = "Arrow (Long)"
					Case 2
						Text_Renamed = "Sling (Light)"
					Case 3
						Text_Renamed = "Sling (Heavy)"
					Case 4
						Text_Renamed = "Gun (Small)"
					Case 5
						Text_Renamed = "Gun (Large)"
					Case 6
						Text_Renamed = "Energy (Low)"
					Case 7
						Text_Renamed = "Energy (High)"
				End Select
				txtStats(6).Text = Text_Renamed
			End If
			If ItemX.Damage > 0 Then
				Text_Renamed = (ItemX.Damage - 1) Mod 5 + 1 & "d" & Int(((ItemX.Damage - 1) Mod 25) / 5) * 2 + 4
				If ItemX.Damage - 1 > 24 Then
					Text_Renamed = Text_Renamed & "+" & Int((ItemX.Damage - 1) / 25)
				End If
			Else
				Text_Renamed = "none"
			End If
			If ItemX.DamageBonus <> 0 Then txtStats(7).Text = IIf(ItemX.DamageBonus > 0, "+", "-") & System.Math.Abs(ItemX.DamageBonus)
			txtStats(3).Text = Text_Renamed
		ElseIf ItemX.Family = 3 Then 
			' special effects for food
			lstFood.Items.Add("Effect:")
			Select Case ItemX.DamageType - 1
				Case 0
					Text_Renamed = "None"
				Case 1
					Text_Renamed = "Heal" ' gives health
				Case 2
					Text_Renamed = "Sickness" ' takes health
				Case 3
					Text_Renamed = "Energy" ' adds Eternium (if relevant)
				Case 4
					Text_Renamed = "Fatigue" ' takes Eternium (if relevant)
				Case 5
					Text_Renamed = "Poison" ' adds a poison trigger
				Case 6
					Text_Renamed = "Curse" ' adds a curse trigger
				Case 7
					Text_Renamed = "Random" ' any of the above, known only after use
			End Select
			If ItemX.Damage > 0 Then
				Text_Renamed = Text_Renamed & " (" & (ItemX.Damage - 1) Mod 5 + 1 & "d" & Int(((ItemX.Damage - 1) Mod 25) / 5) * 2 + 4
				If ItemX.Damage - 1 > 24 Then
					Text_Renamed = Text_Renamed & "+" & Int((ItemX.Damage - 1) / 25)
				End If
			End If
			lstFood.Items.Add(Text_Renamed & ")")
			lstFood.Items.Add("Spoiled after " & VB6.Format(ItemX.DamageBonus) & " days")
		End If
		If ItemX.WearType < 10 Then ' Potential Armor
			Select Case ItemX.WearType
				Case 0 ' Body
					Text_Renamed = "on the body"
				Case 1 ' Helm
					Text_Renamed = "on the head"
				Case 2 ' Glove
					Text_Renamed = "on the hand"
				Case 3 ' Bracelet
					Text_Renamed = "on the wrist"
				Case 4 ' BackPack
					Text_Renamed = "on the back"
				Case 5 ' Shield
					Text_Renamed = "on the arm"
				Case 6 ' Boots
					Text_Renamed = "on the feet"
				Case 7 ' Necklace
					Text_Renamed = "around the neck"
				Case 8 ' Belt
					Text_Renamed = "around the waist"
				Case 9 ' Ring
					Text_Renamed = "on a finger"
			End Select
			lstArmor.Items.Add("worn " & Text_Renamed)
			lstArmor.Items.Add("absorbs up to " & ItemX.Resistance & "% damage")
			If ItemX.Defense <> 0 Then
				lstArmor.Items.Add(IIf(ItemX.Defense < 0, "degrades", "improves") & " its wearer's Defense by " & System.Math.Abs(ItemX.Defense))
			End If
			If ItemX.ResistanceBonus <> 0 Then
				lstArmor.Items.Add("provides additional " & ItemX.ResistanceBonus * 10 & "% protection against " & SetUpResistanceType((ItemX.ResistanceType)) & "-based attacks/effects")
			End If
		End If
		chkContainer.CheckState = CShort(ItemX.Capacity > 0) * CShort(True)
		If ItemX.Capacity > 0 Then
			txtCapacity.Text = VB6.Format(ItemX.Capacity) : txtCapacity.BorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			lblSoft.Text = IIf(CBool(ItemX.SoftCapacity * CShort(True)), "Soft", "Solid")
			txtContainerWeight.Text = CStr(ItemX.Weight) : txtContainerWeight.BorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			txtContainerBulk.Text = CStr(ItemX.Bulk) : txtContainerBulk.BorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		End If
		' Triggers
		lstTriggers.Items.Clear()
		iNumItems = ItemX.Triggers.Count()
		For c = 1 To iNumItems
			'UPGRADE_WARNING: Couldn't resolve default property of object ItemX.Triggers(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ItemX.Triggers().TriggerType. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lstTriggers.Items.Add(TriggerName(ItemX.Triggers.Item(c).TriggerType) & " " & ItemX.Triggers.Item(c).Name)
		Next 
		lstItems.Items.Clear()
		For	Each ItemY In ItemX.Items
			lstItems.Items.Add(ItemY.Name)
		Next ItemY
		' reset comment displays
		txtTriggComm.Text = ""
		txtItemComments.Text = ""
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub ShowItemPicture(ByRef FileName As String)
		Dim Tome_Renamed As Object
		Dim X, Y As Short
		Dim NewWidth, NewHeight As Short
		'UPGRADE_WARNING: Arrays in structure bmItem may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmItem As BITMAPINFO
		Dim hMemItem As Integer
		'UPGRADE_WARNING: Arrays in structure bmBlack may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmBlack As BITMAPINFO
		'UPGRADE_WARNING: Arrays in structure bmMask may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmMask As BITMAPINFO
		Dim rc, lpMem, TransparentRGB As Integer
		Dim PictureFile As String
		'UPGRADE_WARNING: Lower bound of array oActivePic was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		Dim oActivePic(2) As System.Windows.Forms.PictureBox
		oActivePic(1) = picCreatureCompact
		oActivePic(2) = picCreature
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor ' Hourglass
		' Load Bitmap
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		PictureFile = Dir(Tome.LoadPath & "\" & FileName)
		If PictureFile = "" Then
			'        PictureFile = gAppPath & "\data\graphics\creatures\" & FileName
			PictureFile = gDataPath & "\graphics\items\" & FileName
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			PictureFile = Tome.LoadPath & "\" & FileName
		End If
		PictureDir = ClipPath(PictureFile)
		frmMDI.ShowMsg("Loading Picture " & FileName & "...")
		' Load Creature bitmap
		ReadBitmapFile(PictureFile, bmItem, hMemItem, TransparentRGB)
		' Make a copy of the current palette for the picture
		'UPGRADE_WARNING: Couldn't resolve default property of object bmBlack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		bmBlack = bmItem
		' Then change Pure Blue to Pure Black
		ChangeColor(bmBlack, TransparentRGB, 0, 0, 0)
		' Paint bitmap to picture box using converted palette
		lpMem = GlobalLock(hMemItem)
		picItem.Width = VB6.ToPixelsUserWidth(bmItem.bmiHeader.biWidth, 1159, 1159)
		picItem.Height = VB6.ToPixelsUserHeight(bmItem.bmiHeader.biHeight, 609, 609)
		'UPGRADE_ISSUE: PictureBox property picItem.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchDIBits(picItem.hdc, X, Y, bmItem.bmiHeader.biWidth, bmItem.bmiHeader.biHeight, 0, 0, bmItem.bmiHeader.biWidth, bmItem.bmiHeader.biHeight, lpMem, bmBlack, DIB_RGB_COLORS, SRCCOPY)
		picItem.Refresh()
		' Convert to Mask and copy to picMask (pure Blue is the mask color)
		MakeMask(bmItem, bmMask, TransparentRGB)
		picMask.Width = VB6.ToPixelsUserWidth(bmItem.bmiHeader.biWidth, 1159, 1159)
		picMask.Height = VB6.ToPixelsUserHeight(bmItem.bmiHeader.biHeight, 609, 609)
		'UPGRADE_ISSUE: PictureBox property picMask.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchDIBits(picMask.hdc, 0, 0, bmItem.bmiHeader.biWidth, bmItem.bmiHeader.biHeight, 0, 0, bmItem.bmiHeader.biWidth, bmItem.bmiHeader.biHeight, lpMem, bmMask, DIB_RGB_COLORS, SRCCOPY)
		picMask.Refresh()
		' Release memory
		rc = GlobalUnlock(hMemItem)
		rc = GlobalFree(hMemItem)
		' Resize Creature to fit in space available
		Size_Renamed = 1
		If VB6.FromPixelsUserWidth(picItem.Width, 1159, 1159) > VB6.PixelsToTwipsX(oActivePic(iDisplaySize).ClientRectangle.Width) Then
			Size_Renamed = VB6.PixelsToTwipsX(oActivePic(iDisplaySize).ClientRectangle.Width) / VB6.FromPixelsUserWidth(picItem.Width, 1159, 1159)
		End If
		If VB6.FromPixelsUserHeight(picItem.Height, 609, 609) * Size_Renamed > VB6.PixelsToTwipsY(oActivePic(iDisplaySize).ClientRectangle.Height) Then
			Size_Renamed = VB6.PixelsToTwipsY(oActivePic(iDisplaySize).ClientRectangle.Height) / VB6.FromPixelsUserHeight(picItem.Height, 609, 609)
		End If
		' Center Creature in frame
		X = CShort(VB6.PixelsToTwipsX(oActivePic(iDisplaySize).ClientRectangle.Width) - (VB6.FromPixelsUserWidth(picItem.Width, 1159, 1159) * Size_Renamed)) / 2
		Y = CShort(VB6.PixelsToTwipsY(oActivePic(iDisplaySize).ClientRectangle.Height) - (VB6.FromPixelsUserHeight(picItem.Height, 609, 609) * Size_Renamed)) / 2
		NewHeight = CShort(VB6.FromPixelsUserHeight(picItem.Height, 609, 609) * Size_Renamed)
		NewWidth = CShort(VB6.FromPixelsUserWidth(picItem.Width, 1159, 1159) * Size_Renamed)
		' Paint Creature
		'UPGRADE_ISSUE: PictureBox method oActivePic.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		oActivePic(iDisplaySize).Cls()
		'UPGRADE_ISSUE: PictureBox property oActivePic.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = SetStretchBltMode(oActivePic(iDisplaySize).hdc, 3)
		'UPGRADE_ISSUE: PictureBox property picMask.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: PictureBox property oActivePic.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchBlt(oActivePic(iDisplaySize).hdc, X, Y, NewWidth, NewHeight, picMask.hdc, 0, 0, VB6.FromPixelsUserWidth(picMask.Width, 1159, 1159), VB6.FromPixelsUserHeight(picMask.Height, 609, 609), SRCAND)
		'UPGRADE_ISSUE: PictureBox property picItem.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: PictureBox property oActivePic.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchBlt(oActivePic(iDisplaySize).hdc, X, Y, NewWidth, NewHeight, picItem.hdc, 0, 0, VB6.FromPixelsUserWidth(picItem.Width, 1159, 1159), VB6.FromPixelsUserHeight(picItem.Height, 609, 609), SRCPAINT)
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default ' Default
	End Sub
	
	'UPGRADE_WARNING: Event lstTriggers.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstTriggers_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstTriggers.SelectedIndexChanged
		'UPGRADE_WARNING: Couldn't resolve default property of object ItemX.Triggers().Comments. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtTriggComm.Text = ItemX.Triggers.Item(lstTriggers.SelectedIndex + 1).Comments
	End Sub
	
	'UPGRADE_WARNING: Event lstItems.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstItems_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstItems.SelectedIndexChanged
		'UPGRADE_WARNING: Couldn't resolve default property of object ItemX.Items().Comments. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtItemComments.Text = ItemX.Items.Item(lstItems.SelectedIndex + 1).Comments
	End Sub
	
	' -------------------------------------------------------------------
	' code below is to keep the user from editing displayed item info
	
	Private Sub chkFamily_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles chkFamily.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Dim Index As Short = chkFamily.GetIndex(eventSender)
		chkFamily(Index).CheckState = 1 - chkFamily(Index).CheckState
		Beep()
	End Sub
	
	Private Sub chk2hands_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles chk2hands.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		chk2hands.CheckState = 1 - chk2hands.CheckState
		Beep()
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
	
	Private Sub txtSize_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSize.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
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
End Class