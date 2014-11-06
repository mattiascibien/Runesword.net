Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmEncProp
	Inherits System.Windows.Forms.Form
	Dim TreeViewX As AxComctlLib.AxTreeView
	Dim MapX As Map
	Dim EncounterX As Encounter
	Dim WallPaperFile As String
	Dim Dirty As Short
	Dim View As Short
	Dim GridStyle As Short
	Dim IsMouseDown As Short
	
	Const bdGeneral As Short = 1
	Const bdTriggers As Short = 2
	Const bdCreatures As Short = 3
	Const bdItems As Short = 4
	Const bdReGen As Short = 5
	Const bdWallpaper As Short = 6
	
	Const bdCombatGridWidth As Short = 13
	Const bdCombatGridHeight As Short = 7
	Const bdCombatTop As Short = 28
	Const bdCombatLeft As Short = 2
	
	Private Sub InitGame()
		Dim c As Short
		c = 0
		Do Until SetUpEncClass(c) = ""
			cmbClassification.Items.Add(New VB6.ListBoxItem(SetUpEncClass(c), c))
			c = c + 1
		Loop 
	End Sub
	
	Private Sub EditThing()
		If lstThings.SelectedIndex > -1 Then
			Select Case tabEncProp.SelectedItem.Tag
				Case bdTriggers
					frmMDI.EditProperties(Me.Tag & "T" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdCreatures
					frmMDI.EditProperties(Me.Tag & "X" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdItems
					frmMDI.EditProperties(Me.Tag & "I" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
		End If
	End Sub
	
	Private Sub InsertThing()
		Select Case tabEncProp.SelectedItem.Tag
			Case bdTriggers
				frmMDI.EditAdd(Me.Tag, bdEditTrigger)
			Case bdCreatures
				frmMDI.EditAdd(Me.Tag, bdEditCreature)
			Case bdItems
				frmMDI.EditAdd(Me.Tag, bdEditItem)
		End Select
	End Sub
	
	Private Sub CutThing()
		If lstThings.SelectedIndex > -1 Then
			Select Case tabEncProp.SelectedItem.Tag
				Case bdTriggers
					frmMDI.EditCut(Me.Tag & "T" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdCreatures
					frmMDI.EditCut(Me.Tag & "X" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdItems
					frmMDI.EditCut(Me.Tag & "I" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
		End If
	End Sub
	
	Private Sub CopyThing()
		If lstThings.SelectedIndex > -1 Then
			Select Case tabEncProp.SelectedItem.Tag
				Case bdTriggers
					frmMDI.EditCopy(Me.Tag & "T" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdCreatures
					frmMDI.EditCopy(Me.Tag & "X" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdItems
					frmMDI.EditCopy(Me.Tag & "I" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
			btnPaste.Enabled = True
		End If
	End Sub
	
	Private Sub PasteThing()
		Select Case tabEncProp.SelectedItem.Tag
			Case bdTriggers
				If frmMDI.BufferType = bdEditTrigger Then
					frmMDI.EditPaste(Me.Tag)
				End If
			Case bdCreatures
				If frmMDI.BufferType = bdEditCreature Then
					frmMDI.EditPaste(Me.Tag)
				End If
			Case bdItems
				If frmMDI.BufferType = bdEditItem Then
					frmMDI.EditPaste(Me.Tag)
				End If
		End Select
	End Sub
	
	Public Sub ShowEncounter(ByRef InTree As AxComctlLib.AxTreeView, ByRef InMap As Map, ByRef InEnc As Encounter)
		Dim OldDirt, tmpDirty As Short
		tmpDirty = Dirty ' [Titi 2.4.9a]
		Dim ThemeX As Theme
		OldDirt = frmMDI.Dirty
		TreeViewX = InTree
		MapX = InMap
		EncounterX = InEnc
		Me.Text = "Encounter [" & EncounterX.Name & "]"
		' Populate drop down list of Themes
		cmbParentTheme.Items.Add(New VB6.ListBoxItem("<None>", 0))
		cmbParentTheme.SelectedIndex = 0
		For	Each ThemeX In MapX.Themes
			cmbParentTheme.Items.Add(New VB6.ListBoxItem(ThemeX.Name, ThemeX.Index))
			If EncounterX.ParentTheme = ThemeX.Index Then
				'UPGRADE_ISSUE: ComboBox property cmbParentTheme.NewIndex was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
				cmbParentTheme.SelectedIndex = cmbParentTheme.NewIndex
			End If
		Next ThemeX
		txtName.Text = EncounterX.Name
		txtFirstEntry.Text = EncounterX.FirstEntry
		txtSecondEntry.Text = EncounterX.SecondEntry
		chkIsActive.CheckState = EncounterX.IsActive * CShort(True)
		chkIsDark.CheckState = EncounterX.IsDark * CShort(True)
		chkHint.CheckState = EncounterX.UseHint * CShort(True)
		chkEntered.CheckState = EncounterX.HaveEntered * CShort(True)
		chkCanFight.CheckState = EncounterX.CanFight * CShort(True)
		chkCanTalk.CheckState = EncounterX.CanTalk * CShort(True)
		chkCanFlee.CheckState = EncounterX.CanFlee * CShort(True)
		txtChanceToFlee.Text = VB6.Format(EncounterX.ChanceToFlee)
		cmbClassification.SelectedIndex = EncounterX.Classification
		chkReGen.CheckState = EncounterX.GenerateUponEntry * CShort(True)
		chkReGenFlag(0).CheckState = EncounterX.ReGenCreatures * CShort(True)
		chkReGenFlag(1).CheckState = EncounterX.ReGenItems * CShort(True)
		chkReGenFlag(2).CheckState = EncounterX.ReGenTriggers * CShort(True)
		chkReGenFlag(3).CheckState = EncounterX.ReGenDescription * CShort(True)
		chkReGenFlag(4).CheckState = EncounterX.ReGenLocked * CShort(True)
		' [Titi 2.5.1] added the flag to determine if camping is allowed or not
		chkCanCamp.CheckState = EncounterX.CanCamp * CShort(True)
		' Show Wallpaper File
		WallPaperFile = EncounterX.Wallpaper
		ShowCombatPic(WallPaperFile)
		' Show Encounter Tile
		SetDirty(False)
		frmMDI.Dirty = OldDirt
		Dirty = tmpDirty ' [Titi 2.4.9a] when loading, the form will not set Dirty
		btnApply.Enabled = Dirty
	End Sub
	
	Private Sub SetCombatPic()
		On Error Resume Next
		'    dlgFile.FileName = gAppPath & "\Data\Graphics\Wallpapers\*.bmp"
		dlgFileOpen.FileName = gDataPath & "\Graphics\Wallpapers\*.bmp"
		dlgFileOpen.Title = "Choose Background"
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		dlgFile.CancelError = True
		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		dlgFileOpen.Filter = "Bitmaps (*.bmp)|*.bmp|All Files (*.*)|*.*"
		dlgFileOpen.FilterIndex = 1
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFile.Flags was upgraded to dlgFileOpen.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		dlgFileOpen.CheckFileExists = True
		dlgFileOpen.CheckPathExists = True
		'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFile.Flags was upgraded to dlgFileOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		dlgFileOpen.ShowReadOnly = False
		dlgFileOpen.RestoreDirectory = False
		dlgFileOpen.ShowDialog()
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		If Err.Number = DialogResult.Cancel Then
			Exit Sub
		End If
		' Depending on file chosen, get other files
		'UPGRADE_WARNING: CommonDialog property dlgFile.FileTitle was upgraded to dlgFile.FileName which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		WallPaperFile = dlgFileOpen.FileName
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		frmMDI.ShowMsg("Loading Wallpaper " & WallPaperFile & "...")
		ShowCombatPic(WallPaperFile)
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		SetDirty(True)
	End Sub
	
	Private Sub SetCombatGrid(ByRef Button As Short, ByRef X As Single, ByRef Y As Single)
		Dim Col, c, Row As Short
		If Button = VB6.MouseButtonConstants.LeftButton Then
			c = GridStyle + 1
		Else
			c = 0
		End If
		Row = Least(Greatest(bdCombatHeight - Int((Y - bdCombatTop) / bdCombatGridHeight), 0), bdCombatHeight)
		Col = Least(Greatest(Int((X - bdCombatLeft - (bdCombatGridWidth / 2) * (Row Mod 2)) / bdCombatGridWidth), 0), bdCombatWidth)
		EncounterX.CombatGrid(Col, Row) = c
		ShowCombatPic(WallPaperFile)
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub ShowCombatPic(ByRef PictureFile As String)
		Dim Tome_Renamed As Object
		'UPGRADE_WARNING: Arrays in structure bmPic may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmPic As BITMAPINFO
		Dim hMemPic As Integer
		Dim FileName As String
		Dim rc, lpMem, TransparentRGB As Integer
		Dim X, Y As Short
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileName = Dir(Tome.LoadPath & "\" & PictureFile)
		If FileName = "" Then
			'        FileName = gAppPath & "\data\graphics\wallpapers\" & PictureFile
			FileName = gDataPath & "\graphics\wallpapers\" & PictureFile
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FileName = Tome.LoadPath & "\" & PictureFile
		End If
		frmMDI.ShowMsg("Loading Picture " & PictureFile & "...")
		' Load TileSet bitmap
		ReadBitmapFile(FileName, bmPic, hMemPic, TransparentRGB)
		' Paint bitmap to picture box using converted palette
		lpMem = GlobalLock(hMemPic)
		'UPGRADE_ISSUE: PictureBox property picCombatWallpaper.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = SetStretchBltMode(picCombatWallpaper.hdc, 3)
		'UPGRADE_ISSUE: PictureBox property picCombatWallpaper.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchDIBits(picCombatWallpaper.hdc, 0, 0, picCombatWallpaper.ClientRectangle.Width, picCombatWallpaper.ClientRectangle.Height, 0, 0, bmPic.bmiHeader.biWidth, bmPic.bmiHeader.biHeight, lpMem, bmPic, DIB_RGB_COLORS, SRCCOPY)
		' Release memory
		rc = GlobalUnlock(hMemPic)
		rc = GlobalFree(hMemPic)
		' Show Grid
		' Each square is bdCombatGridWidth X bdCombatGridHeight with a 1 pixel boarder right and bottom
		'    GridWidth = 16: GridAdjust = 4 + 8 * (Row Mod 2)
		' Do final adjustments to CursorAtX and CursorAtY (bound to grid)
		'    CursorAtY = (Int((7 - Row) * 8) + 66) * CommonScale
		'    CursorAtX = (Int(Col * GridWidth + GridAdjust)) * CommonScale
		' Use different color globe dots for each mark: Yellow Party, Red Enemy, Blue open.
		' The dots are globes with grey scale box.
		For X = 0 To bdCombatWidth : For Y = 0 To bdCombatHeight
				If EncounterX.CombatGrid(X, Y) > 0 Then
					'UPGRADE_ISSUE: PictureBox property picGridBlocks.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					'UPGRADE_ISSUE: PictureBox property picCombatWallpaper.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					rc = BitBlt(picCombatWallpaper.hdc, Int(X * bdCombatGridWidth + (bdCombatLeft + (bdCombatGridWidth / 2) * (Y Mod 2))), Int((bdCombatHeight - Y) * bdCombatGridHeight) + bdCombatTop, bdCombatGridWidth - 1, bdCombatGridHeight - 1, picGridBlocks.hdc, 0, 8 * (EncounterX.CombatGrid(X, Y) - 1), SRCCOPY)
				End If
			Next Y : Next X
		picCombatWallpaper.Refresh()
	End Sub
	
	Private Sub SetDirty(ByRef Flag As Short)
		btnApply.Enabled = Flag
		Dirty = Flag
		If Dirty = True Then
			frmMDI.Dirty = True
		End If
	End Sub
	
	Public Sub ListTriggers()
		Dim c As Short
		If tabEncProp.SelectedItem.Tag = bdTriggers Then
			lblAttached.Text = "Triggers Attached to Encounter"
			lstThings.Items.Clear()
			For c = 1 To EncounterX.Triggers.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object EncounterX.Triggers(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object EncounterX.Triggers(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object EncounterX.Triggers().TriggerType. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstThings.Items.Add(New VB6.ListBoxItem(TriggerName(EncounterX.Triggers.Item(c).TriggerType) & " " & EncounterX.Triggers.Item(c).Name, EncounterX.Triggers.Item(c).Index))
			Next c
		End If
	End Sub
	
	Public Sub ListCreatures()
		Dim c As Short
		If tabEncProp.SelectedItem.Tag = bdCreatures Then
			lblAttached.Text = "Creatures Attached to Encounter"
			lstThings.Items.Clear()
			For c = 1 To EncounterX.Creatures.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object EncounterX.Creatures(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object EncounterX.Creatures(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstThings.Items.Add(New VB6.ListBoxItem(EncounterX.Creatures.Item(c).Name, EncounterX.Creatures.Item(c).Index))
			Next c
		End If
	End Sub
	
	Public Sub ListItems()
		Dim c As Short
		If tabEncProp.SelectedItem.Tag = bdItems Then
			lblAttached.Text = "Items Attached to Encounter"
			lstThings.Items.Clear()
			For c = 1 To EncounterX.Items.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object EncounterX.Items(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object EncounterX.Items(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstThings.Items.Add(New VB6.ListBoxItem(EncounterX.Items.Item(c).Name, EncounterX.Items.Item(c).Index))
			Next c
		End If
	End Sub
	
	Private Sub btnApply_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnApply.Click
		UpdateEncounter()
		ShowEncounter(TreeViewX, MapX, EncounterX)
	End Sub
	
	Private Sub btnBrowse_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnBrowse.Click
		SetCombatPic()
	End Sub
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		' [Titi 2.6.3] cancelling a new encounter means we won't keep it
		If VB.Right("   " & Me.Tag, 3) = "NEW" Then frmMDI.EditCut(VB.Left(Me.Tag, Len(Me.Tag) - 3))
		Me.Close()
	End Sub
	
	Private Sub btnCopy_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCopy.Click
		CopyThing()
	End Sub
	
	Private Sub btnCut_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCut.Click
		CutThing()
	End Sub
	
	Private Sub btnEdit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnEdit.Click
		EditThing()
	End Sub
	
	Private Sub btnInsert_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnInsert.Click
		InsertThing()
	End Sub
	
	Private Sub btnOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOk.Click
		' [Titi 2.6.3] cancelling a validated encounter only means we won't keep the changes since the last ones so we update the tag
		If VB.Right("   " & Me.Tag, 3) = "NEW" Then Me.Tag = VB.Left(Me.Tag, Len(Me.Tag) - 3)
		UpdateEncounter()
		Me.Close()
	End Sub
	
	Private Sub UpdateEncounter()
		' [Titi 2.4.9b] Stack overflow if two encounters with the same name
		EncounterX.Name = NameExists((txtName.Text), 0)
		EncounterX.FirstEntry = txtFirstEntry.Text
		EncounterX.SecondEntry = txtSecondEntry.Text
		EncounterX.Wallpaper = WallPaperFile
		EncounterX.UseHint = chkHint.CheckState * CShort(True)
		EncounterX.HaveEntered = chkEntered.CheckState * CShort(True)
		EncounterX.CanFight = chkCanFight.CheckState * CShort(True)
		EncounterX.CanTalk = chkCanTalk.CheckState * CShort(True)
		EncounterX.CanFlee = chkCanFlee.CheckState * CShort(True)
		EncounterX.ChanceToFlee = Val(txtChanceToFlee.Text)
		EncounterX.Classification = VB6.GetItemData(cmbClassification, cmbClassification.SelectedIndex)
		EncounterX.ParentTheme = VB6.GetItemData(cmbParentTheme, cmbParentTheme.SelectedIndex)
		EncounterX.GenerateUponEntry = chkReGen.CheckState * CShort(True)
		EncounterX.ReGenCreatures = chkReGenFlag(0).CheckState * CShort(True)
		EncounterX.ReGenItems = chkReGenFlag(1).CheckState * CShort(True)
		EncounterX.ReGenTriggers = chkReGenFlag(2).CheckState * CShort(True)
		EncounterX.ReGenDescription = chkReGenFlag(3).CheckState * CShort(True)
		EncounterX.ReGenLocked = chkReGenFlag(4).CheckState * CShort(True)
		EncounterX.IsActive = chkIsActive.CheckState * CShort(True)
		' [Titi 2.5.1] flag to tell if camping is possible
		EncounterX.CanCamp = chkCanCamp.CheckState * CShort(True)
		EncounterX.IsDark = chkIsDark.CheckState * CShort(True)
		' Save Name
		TreeViewX.Nodes(Me.Tag).Text = EncounterX.Name
		SetDirty(False)
	End Sub
	
	Private Function NameExists(ByRef sText As String, ByRef iDepth As Short) As String
		Dim c As String
		Dim i As Short
		Dim EncounterZ As Encounter
		For	Each EncounterZ In MapX.Encounters
			If sText = EncounterZ.Name And EncounterX.Index <> EncounterZ.Index Then i = i + 1
		Next EncounterZ
		If i > 0 Then
			If iDepth > 0 Then
				sText = VB.Left(sText, InStrRev(sText, " ") - 1) & Str(iDepth)
			Else
				sText = sText & Str(i)
			End If
			c = NameExists(sText, iDepth + 1)
			NameExists = sText
		Else
			If txtName.Text <> sText Then
				MsgBox("There is already an encounter with that name (" & txtName.Text & ")." & vbCrLf & "This encounter will be renamed " & sText & ".")
			End If
			NameExists = sText
		End If
	End Function
	
	Private Sub btnPaste_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnPaste.Click
		PasteThing()
	End Sub
	
	Private Sub btnReGen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnReGen.Click
		Dim ItemX As Item
		Dim CreatureX As Creature
		Dim TriggerX As Trigger
		UpdateEncounter()
		' Remove Creatures
		If EncounterX.ReGenCreatures = True And EncounterX.Creatures.Count() > 0 Then
			For	Each CreatureX In EncounterX.Creatures
				frmMDI.EditDelete(Me.Tag & "X" & CreatureX.Index, True)
			Next CreatureX
		End If
		' Remove Items
		If EncounterX.ReGenItems = True And EncounterX.Items.Count() > 0 Then
			For	Each ItemX In EncounterX.Items
				frmMDI.EditDelete(Me.Tag & "I" & ItemX.Index, True)
			Next ItemX
		End If
		' Remove Triggers
		If EncounterX.ReGenTriggers = True And EncounterX.Triggers.Count() > 0 Then
			For	Each TriggerX In EncounterX.Triggers
				frmMDI.EditDelete(Me.Tag & "T" & TriggerX.Index, True)
			Next TriggerX
		End If
		modDungeonMaker.MakeEncounter(MapX, EncounterX)
		ShowEncounter(TreeViewX, MapX, EncounterX)
		' Redisplay Creatures
		If EncounterX.ReGenCreatures = True And EncounterX.Creatures.Count() > 0 Then
			For	Each CreatureX In EncounterX.Creatures
				frmMDI.ShowCreature((frmMDI.ObjectListX), TreeViewX, Me.Tag, CreatureX)
			Next CreatureX
		End If
		' Redisplay Items
		If EncounterX.ReGenItems = True And EncounterX.Items.Count() > 0 Then
			For	Each ItemX In EncounterX.Items
				frmMDI.ShowItem((frmMDI.ObjectListX), TreeViewX, Me.Tag, ItemX)
			Next ItemX
		End If
		' Redisplay Triggers
		If EncounterX.ReGenTriggers = True And EncounterX.Triggers.Count() > 0 Then
			For	Each TriggerX In EncounterX.Triggers
				frmMDI.ShowTrigger((frmMDI.ObjectListX), TreeViewX, Me.Tag, TriggerX)
			Next TriggerX
		End If
		UpdateEncounter()
	End Sub
	
	'UPGRADE_WARNING: Event chkCanCamp.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkCanCamp_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkCanCamp.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkCanFight.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkCanFight_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkCanFight.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkCanFlee.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkCanFlee_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkCanFlee.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkCanTalk.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkCanTalk_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkCanTalk.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkEntered.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkEntered_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkEntered.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkHint.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkHint_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkHint.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkIsActive.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkIsActive_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkIsActive.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkIsDark.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkIsDark_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkIsDark.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkReGen.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkReGen_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkReGen.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkReGenFlag.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkReGenFlag_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkReGenFlag.CheckStateChanged
		Dim Index As Short = chkReGenFlag.GetIndex(eventSender)
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbClassification.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbClassification_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbClassification.SelectedIndexChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbParentTheme.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbParentTheme_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbParentTheme.SelectedIndexChanged
		SetDirty(True)
	End Sub
	
	Private Sub btnLibrary_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnLibrary.Click
		If btnLibrary.Visible = True Then
			Select Case Mid(btnLibrary.Text, 8, 4)
				Case "item"
					frmMDI.EditLoad(Me.Tag, bdEditItem)
				Case "crea"
					frmMDI.EditLoad(Me.Tag, bdEditCreature)
				Case "trig"
					frmMDI.EditLoad(Me.Tag, bdEditTrigger)
			End Select
		End If
	End Sub
	
	'UPGRADE_WARNING: Form event frmEncProp.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmEncProp_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		' [Titi 2.6.0] Make sure we're still working with the relevant treeview and objectlist
		If VB.Left(Me.Tag, 4) = "Tome" Then
			frmMDI.TreeViewX = frmProject.tvwTome.GetOcx
			frmMDI.ObjectListX = frmProject.TomeList
		Else
			frmMDI.TreeViewX = frmProject.tvwProject.GetOcx
			frmMDI.ObjectListX = frmProject.AreaList
		End If
	End Sub
	
	Private Sub frmEncProp_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Dim CtrlKey As Object
		If TypeOf Me.ActiveControl Is System.Windows.Forms.TextBox Then
			CtrlKey(Me.ActiveControl, KeyCode, Shift)
		End If
	End Sub
	
	Private Sub frmEncProp_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		InitGame()
	End Sub
	
	Private Sub frmEncProp_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Dim c As Short
		' [Titi 2.4.9a]
		If Dirty Then
			c = MsgBox("Changes will be lost! Save first?", MsgBoxStyle.YesNo, "Changes not saved!")
			If c = MsgBoxResult.Yes Then
				' [Titi 2.6.3] update the tag before closing
				If VB.Right("   " & Me.Tag, 3) = "NEW" Then Me.Tag = VB.Left(Me.Tag, Len(Me.Tag) - 3)
				btnOk_Click(btnOk, New System.EventArgs())
			Else
				' [Titi 2.6.3] closing a new encounter means we won't keep it
				If VB.Right("   " & Me.Tag, 3) = "NEW" Then
					frmMDI.EditCut(VB.Left(Me.Tag, Len(Me.Tag) - 3))
				End If
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event lstThings.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstThings_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstThings.SelectedIndexChanged
		Select Case tabEncProp.SelectedItem.Tag
			Case bdTriggers
				TreeViewX.Nodes(Me.Tag & "T" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
			Case bdCreatures
				TreeViewX.Nodes(Me.Tag & "X" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
			Case bdItems
				TreeViewX.Nodes(Me.Tag & "I" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
		End Select
	End Sub
	
	Private Sub lstThings_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstThings.DoubleClick
		EditThing()
	End Sub
	
	'UPGRADE_WARNING: Event optCombatSettings.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optCombatSettings_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optCombatSettings.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = optCombatSettings.GetIndex(eventSender)
			GridStyle = Index
		End If
	End Sub
	
	Private Sub picCombatWallpaper_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles picCombatWallpaper.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = eventArgs.X
		Dim Y As Single = eventArgs.Y
		If GridStyle < 3 And Y > bdCombatTop Then
			IsMouseDown = True
		End If
	End Sub
	
	Private Sub picCombatWallpaper_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles picCombatWallpaper.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = eventArgs.X
		Dim Y As Single = eventArgs.Y
		If IsMouseDown = True Then
			SetCombatGrid(Button, X, Y)
		End If
	End Sub
	
	Private Sub picCombatWallpaper_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles picCombatWallpaper.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = eventArgs.X
		Dim Y As Single = eventArgs.Y
		If IsMouseDown = True Then
			SetCombatGrid(Button, X, Y)
			IsMouseDown = False
		End If
	End Sub
	
	Private Sub tabEncProp_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabEncProp.ClickEvent
		Select Case tabEncProp.SelectedItem.Tag
			Case bdGeneral
				fraEncounter(0).BringToFront()
				btnLibrary.Visible = False
			Case bdTriggers
				fraEncounter(1).BringToFront()
				btnLibrary.Text = "Insert trigger from library"
				btnLibrary.Visible = True
				ListTriggers()
			Case bdCreatures
				fraEncounter(1).BringToFront()
				btnLibrary.Text = "Insert creature from library"
				btnLibrary.Visible = True
				ListCreatures()
			Case bdItems
				fraEncounter(1).BringToFront()
				btnLibrary.Text = "Insert item from library"
				btnLibrary.Visible = True
				ListItems()
			Case bdReGen
				fraEncounter(2).BringToFront()
			Case bdWallpaper
				fraEncounter(3).BringToFront()
		End Select
	End Sub
	
	'UPGRADE_WARNING: Event txtChanceToFlee.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtChanceToFlee_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtChanceToFlee.TextChanged
		Limit(txtChanceToFlee, 0, bdByte)
		SetDirty(True)
	End Sub
	
	Private Sub txtChanceToFlee_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtChanceToFlee.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(txtChanceToFlee, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtFirstEntry.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtFirstEntry_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFirstEntry.TextChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtName.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtName_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtName.TextChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtSecondEntry.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtSecondEntry_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSecondEntry.TextChanged
		SetDirty(True)
	End Sub
End Class