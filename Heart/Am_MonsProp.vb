Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frmMonsProp
	Inherits System.Windows.Forms.Form
	Dim TreeViewX As AxComctlLib.AxTreeView
	Public CreatureX As Creature
	Public Dirty As Short '[Titi 2.5.1] made public
	Dim PictureStyle As Short
	Dim TmpPictureFile As String
	Dim TmpFaceLeft As Short
	Dim TmpFaceTop As Short
	Dim PictureDir As String
	Dim TmpPortraitFile As String
	Dim PortraitDir As String
	Dim tmpPictureWhenDead As String ' [Titi 2.6.0] added to have not only bones to show after death
	Dim PicDeadDir As String
	Dim TmpWAV(3) As String
	Dim TmpWAVFlag(3) As Short
	
	'UPGRADE_NOTE: Size was upgraded to Size_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Dim Size_Renamed As Double
	'UPGRADE_NOTE: MouseDown was upgraded to MouseDown_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Dim MouseDown_Renamed As Short
	
	Const bdGeneral As Short = 1
	Const bdType As Short = 2
	Const bdArmor As Short = 3
	Const bdItems As Short = 4
	Const bdConversations As Short = 5
	Const bdTriggers As Short = 6
	Const bdSounds As Short = 7
	Const bdWeakness As Short = 8
	
	Private Sub EditThing()
		If lstThings.SelectedIndex > -1 Then
			Select Case tabMonsProp.SelectedItem.Tag
				Case bdConversations
					frmMDI.EditProperties(Me.Tag & "C" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdTriggers
					frmMDI.EditProperties(Me.Tag & "T" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdItems
					frmMDI.EditProperties(Me.Tag & "I" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
		End If
	End Sub
	
	Private Sub InsertThing()
		Dim TriggerX As Trigger
		Select Case tabMonsProp.SelectedItem.Tag
			Case bdConversations
				frmMDI.EditAdd(Me.Tag, bdEditConvo)
			Case bdTriggers
				frmMDI.EditAdd(Me.Tag, bdEditTrigger)
			Case bdItems
				frmMDI.EditAdd(Me.Tag, bdEditItem)
		End Select
	End Sub
	
	Private Sub CutThing()
		If lstThings.SelectedIndex > -1 Then
			Select Case tabMonsProp.SelectedItem.Tag
				Case bdConversations
					frmMDI.EditCut(Me.Tag & "C" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdTriggers
					frmMDI.EditCut(Me.Tag & "T" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdItems
					frmMDI.EditCut(Me.Tag & "I" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
		End If
	End Sub
	
	Private Sub CopyThing()
		If lstThings.SelectedIndex > -1 Then
			Select Case tabMonsProp.SelectedItem.Tag
				Case bdTriggers
					frmMDI.EditCopy(Me.Tag & "T" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdConversations
					frmMDI.EditCopy(Me.Tag & "C" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdItems
					frmMDI.EditCopy(Me.Tag & "I" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
			btnPaste.Enabled = True
		End If
	End Sub
	
	Private Sub PasteThing()
		Select Case tabMonsProp.SelectedItem.Tag
			Case bdTriggers
				If frmMDI.BufferType = bdEditTrigger Then
					frmMDI.EditPaste(Me.Tag)
				End If
			Case bdConversations
				If frmMDI.BufferType = bdEditConvo Then
					frmMDI.EditPaste(Me.Tag)
				End If
			Case bdItems
				If frmMDI.BufferType = bdEditItem Then
					frmMDI.EditPaste(Me.Tag)
				End If
		End Select
	End Sub
	
	Public Sub InitArmorType()
		Dim c, i As Short
		' Set up Armor Type List
		For c = 0 To 7
			cmbArmor(c).Items.Clear()
			For i = 0 + BodyType * 11 To 10 + BodyType * 11
				cmbArmor(c).Items.Add(New VB6.ListBoxItem(SetUpArmorType(i), i))
			Next i
			cmbArmor(c).SelectedIndex = 0
			For i = 0 To cmbArmor(0).Items.Count - 1
				If CreatureX.BodyType(c) = VB6.GetItemData(cmbArmor(c), i) Then
					cmbArmor(c).SelectedIndex = i
					Exit For
				End If
			Next i
		Next c
	End Sub
	
	Private Sub InitGame()
		Dim c, i As Short
		' Default size before load any picture
		Size_Renamed = 1
		' Default to normal picture style (not portrait)
		PictureStyle = 0
		' Populate WAV name with Default
		cmbWAV.Items.Add("[Default]")
		' [Titi 2.5.1] Set up body types
		For c = 0 To 3
			cmbBodyType.Items.Add(SetUpBodyType(c))
		Next 
		' [Titi 2.5.1] moved to InitArmorType to update the choices depending on the family
		InitArmorType()
		Dirty = 251
		cmbBodyType.SelectedIndex = BodyType
		'    ' Set up Armor Type List
		'    For c = 0 To 7
		'        cmbArmor(c).Clear
		'        For i = 0 To 10
		'            cmbArmor(c).AddItem SetUpArmorType(i)
		'            cmbArmor(c).ItemData(cmbArmor(c).NewIndex) = i
		'        Next i
		'    Next c
		' Set up Weakness Type
		For c = 0 To 7
			cmbResistance(c).Items.Clear()
			cmbResistance(c).Items.Add("<None>")
			cmbResistance(c).Items.Add("10%")
			cmbResistance(c).Items.Add("20%")
			cmbResistance(c).Items.Add("30%")
			cmbResistance(c).Items.Add("40%")
			cmbResistance(c).Items.Add("50%")
			cmbResistance(c).Items.Add("60%")
			cmbResistance(c).Items.Add("70%")
			cmbResistance(c).Items.Add("80%")
			cmbResistance(c).Items.Add("90%")
			cmbResistance(c).Items.Add("Immune")
			cmbResistance(c).Items.Add("Double Damage")
			cmbResistance(c).Items.Add("Triple Damage")
		Next c
		' Set up CombatRank
		cmbCombatRank.Items.Add("Random")
		cmbCombatRank.Items.Add("Back/Ranged")
		cmbCombatRank.Items.Add("Middle")
		cmbCombatRank.Items.Add("Front/Melee")
		' Arrange display depending on Magic settings
		'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Runes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If WorldNow.Runes = False Then
			txtWill.Left = VB6.TwipsToPixelsX(2695) : Label1(7).Left = VB6.TwipsToPixelsX(2650)
			txtAgility.Left = VB6.TwipsToPixelsX(2095) : Label1(6).Left = VB6.TwipsToPixelsX(2050)
			txtStrength.Left = VB6.TwipsToPixelsX(1495) : Label1(5).Left = VB6.TwipsToPixelsX(1450)
		End If
	End Sub
	
	Private Sub btnApply_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnApply.Click
		UpdateMons()
		ShowMons(TreeViewX, CreatureX)
	End Sub
	
	Private Sub btnBrowse_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnBrowse.Click
		OpenPictureFile()
		SetDirty(True)
	End Sub
	
	Private Sub btnBrowseLeft_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnBrowseLeft.Click
		Select Case PictureStyle
			Case 0 ' Normal Picture
				NextPictureFile(-1)
			Case 1 ' Portrait Picture
				NextPortraitFile(-1)
		End Select
		SetDirty(True)
	End Sub
	
	Private Sub btnBrowseRight_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnBrowseRight.Click
		Select Case PictureStyle
			Case 0 ' Normal Picture
				NextPictureFile(1)
			Case 1 ' Portrait Picture
				NextPortraitFile(1)
		End Select
		SetDirty(True)
	End Sub
	
	Private Sub btnBrowseWAV_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnBrowseWAV.Click
		OpenWAVFile()
	End Sub
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		' [Titi 2.6.3] cancelling a new trigger means we won't keep it
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
		' [Titi 2.6.3] cancelling a validated creature only means we won't keep the changes since the last ones so we update the tag
		If VB.Right("   " & Me.Tag, 3) = "NEW" Then Me.Tag = VB.Left(Me.Tag, Len(Me.Tag) - 3)
		UpdateMons()
		Me.Close()
	End Sub
	
	Private Sub btnPaste_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnPaste.Click
		PasteThing()
	End Sub
	
	Private Sub btnPlayWAV_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnPlayWAV.Click
		Dim PlaySoundFile As Object
		'Call PlaySound
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		If cmbWAV.Text = "[Default]" Or cmbWAV.Text = "" Then
			Select Case lstWAV.SelectedIndex
				Case 0 ' Move
					Call PlaySoundFile("step1.wav", Tome)
				Case 1 ' Attack
				Case 2 ' Hit
					Call PlaySoundFile("hit.wav", Tome)
				Case 3 ' Die
					Call PlaySoundFile("monsdie.wav", Tome)
			End Select
		Else
			'modDM.PlaySound cmbWAV.Text, True
			Call PlaySoundFile(cmbWAV.Text, Tome, True)
		End If
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub btnPortrait_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnPortrait.Click
		PictureStyle = System.Math.Abs(PictureStyle - 1)
		Select Case PictureStyle
			Case 0 ' Normal Picture
				ShowMonsPicture(TmpPictureFile)
				btnPortrait.Text = "Portrait"
				shpFace.Visible = True
			Case 1 ' Portrait Picture
				ShowMonsPortrait(TmpPortraitFile)
				btnPortrait.Text = "Miniature"
				shpFace.Visible = False
		End Select
	End Sub
	
	Private Sub btnXP_Value_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnXP_Value.Click
		UpdateMons() ' take possible previous modifications into account
		SetDirty(True)
		txtExperiencePoints.Text = Str(GetXPValue(CreatureX))
		Me.Refresh()
	End Sub
	
	'UPGRADE_WARNING: Event chkAgressive.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkAgressive_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkAgressive.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkDMControlled.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkDMControlled_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkDMControlled.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkFamily.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkFamily_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkFamily.CheckStateChanged
		Dim Index As Short = chkFamily.GetIndex(eventSender)
		If Index = 0 Then
			txtLunacy.Enabled = chkFamily(0).CheckState > 0
			txtRevelry.Enabled = chkFamily(0).CheckState > 0
			txtWrath.Enabled = chkFamily(0).CheckState > 0
			txtPride.Enabled = chkFamily(0).CheckState > 0
			txtGreed.Enabled = chkFamily(0).CheckState > 0
			txtLust.Enabled = chkFamily(0).CheckState > 0
		End If
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkFriend.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkFriend_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkFriend.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkGuard.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkGuard_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkGuard.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkIsInanimate.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkIsInanimate_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkIsInanimate.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkIsMale.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkIsMale_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkIsMale.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkOnAdventure.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkOnAdventure_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkOnAdventure.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkRequiredInTome.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkRequiredInTome_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkRequiredInTome.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbBodyType.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbBodyType_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbBodyType.SelectedIndexChanged
		If Dirty = 251 Then
			Dirty = 0
		Else
			SetDirty(True)
			BodyType = cmbBodyType.SelectedIndex
		End If
		InitArmorType()
	End Sub
	
	Private Sub btnLibrary_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnLibrary.Click
		If btnLibrary.Visible = True Then
			Select Case Mid(btnLibrary.Text, 8, 4)
				Case "item"
					frmMDI.EditLoad(Me.Tag, bdEditItem)
				Case "trig"
					frmMDI.EditLoad(Me.Tag, bdEditTrigger)
				Case "conv"
					frmMDI.EditLoad(Me.Tag, bdEditConvo)
			End Select
		End If
	End Sub
	
	Private Sub btnDead_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnDead.Click
		On Error Resume Next
		frmMDI.dlgFileOpen.InitialDirectory = gAppPath & "\graphics\creatures"
		frmMDI.dlgFileOpen.Title = "Choose appearance of " & CreatureX.Name & " when dead..."
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		frmMDI.dlgFile.CancelError = True
		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		frmMDI.dlgFileOpen.Filter = "Pictures (*.bmp)|*.bmp|All Files (*.*)|*.*"
		frmMDI.dlgFileOpen.FilterIndex = 1
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		frmMDI.dlgFileOpen.CheckFileExists = True
		frmMDI.dlgFileOpen.CheckPathExists = True
		'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		frmMDI.dlgFileOpen.ShowReadOnly = False
		frmMDI.dlgFileOpen.RestoreDirectory = False
		frmMDI.dlgFileOpen.ShowDialog()
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		If Err.Number = DialogResult.Cancel Then
			Exit Sub
		End If
		tmpPictureWhenDead = Mid(frmMDI.dlgFileOpen.FileName, InStrRev(frmMDI.dlgFileOpen.FileName, "\") + 1)
		SetDirty(True)
	End Sub
	
	Private Sub lblHome_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lblHome.DoubleClick
		On Error Resume Next
		'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		frmMDI.dlgFileOpen.InitialDirectory = gAppPath & "\" & WorldNow.Name & "\Tomes"
		'    frmMDI.dlgFile.FileName = gAppPath & "\" & WorldNow.Name & "\Tomes"
		frmMDI.dlgFileOpen.Title = "Choose Home tome for " & CreatureX.Name
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		frmMDI.dlgFile.CancelError = True
		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		frmMDI.dlgFileOpen.Filter = "Tomes (*.tom)|*.tom|All Files (*.*)|*.*"
		frmMDI.dlgFileOpen.FilterIndex = 1
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		frmMDI.dlgFileOpen.CheckFileExists = True
		frmMDI.dlgFileOpen.CheckPathExists = True
		'UPGRADE_WARNING: MSComDlg.CommonDialog property frmMDI.dlgFile.Flags was upgraded to frmMDI.dlgFileOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		frmMDI.dlgFileOpen.ShowReadOnly = False
		frmMDI.dlgFileOpen.RestoreDirectory = False
		frmMDI.dlgFileOpen.ShowDialog()
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		If Err.Number = DialogResult.Cancel Then
			Exit Sub
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtHome.Text = Mid(frmMDI.dlgFileOpen.FileName, InStr(frmMDI.dlgFileOpen.FileName, WorldNow.Name))
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event optSize.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optSize_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optSize.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = optSize.GetIndex(eventSender)
			SetDirty(True)
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmbArmor.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbArmor_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbArmor.SelectedIndexChanged
		Dim Index As Short = cmbArmor.GetIndex(eventSender)
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbCombatRank.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbCombatRank_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbCombatRank.SelectedIndexChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbResistance.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbResistance_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbResistance.SelectedIndexChanged
		Dim Index As Short = cmbResistance.GetIndex(eventSender)
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Form event frmMonsProp.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmMonsProp_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		' [Titi 2.6.0] Make sure we're still working with the relevant treeview and objectlist
		If VB.Left(Me.Tag, 4) = "Tome" Then
			frmMDI.TreeViewX = frmProject.tvwTome.GetOcx
			frmMDI.ObjectListX = frmProject.TomeList
		Else
			frmMDI.TreeViewX = frmProject.tvwProject.GetOcx
			frmMDI.ObjectListX = frmProject.AreaList
		End If
	End Sub
	
	Private Sub frmMonsProp_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Dim CtrlKey As Object
		If TypeOf Me.ActiveControl Is System.Windows.Forms.TextBox Then
			CtrlKey(Me.ActiveControl, KeyCode, Shift)
		End If
	End Sub
	
	Private Sub frmMonsProp_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		' [Titi 2.4.9b] Customize Magic settings
		'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Runes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtEternium.Visible = WorldNow.Runes
		'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Runes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtEterniumMax.Visible = WorldNow.Runes
		'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Runes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Label1(1).Visible = WorldNow.Runes
		'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Runes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Label1(15).Visible = WorldNow.Runes
		InitGame()
	End Sub
	
	Private Sub frmMonsProp_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Dim c As Short
		' [Titi 2.4.9a]
		If Dirty Then
			c = MsgBox("Changes will be lost! Save first?", MsgBoxStyle.YesNo, "Changes not saved!")
			If c = MsgBoxResult.Yes Then
				' [Titi 2.6.3] update the tag before closing
				If VB.Right("   " & Me.Tag, 3) = "NEW" Then Me.Tag = VB.Left(Me.Tag, Len(Me.Tag) - 3)
				btnOk_Click(btnOk, New System.EventArgs())
			Else
				' [Titi 2.6.3] closing a new convo means we won't keep it
				If VB.Right("   " & Me.Tag, 3) = "NEW" Then
					frmMDI.EditCut(VB.Left(Me.Tag, Len(Me.Tag) - 3))
				End If
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event lstThings.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstThings_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstThings.SelectedIndexChanged
		Select Case tabMonsProp.SelectedItem.Tag
			Case bdTriggers
				TreeViewX.Nodes(Me.Tag & "T" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
			Case bdConversations
				TreeViewX.Nodes(Me.Tag & "C" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
			Case bdItems
				TreeViewX.Nodes(Me.Tag & "I" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
		End Select
	End Sub
	
	Private Sub lstThings_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstThings.DoubleClick
		EditThing()
	End Sub
	
	'UPGRADE_WARNING: Event lstWAV.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstWAV_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstWAV.SelectedIndexChanged
		ListSounds()
	End Sub
	
	Private Sub picCreature_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles picCreature.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = eventArgs.X
		Dim Y As Single = eventArgs.Y
		If PictureStyle = 0 Then
			MouseDown_Renamed = True
			TmpFaceLeft = Int((shpFace.Left - CShort(picCreature.ClientRectangle.Width - (picMons.Width * Size_Renamed)) / 2) / Size_Renamed)
			TmpFaceTop = Int((shpFace.Top - CShort(picCreature.ClientRectangle.Height - (picMons.Height * Size_Renamed)) / 2) / Size_Renamed)
			fraMonsPic.Text = "Face (" & TmpFaceLeft & "x" & TmpFaceTop & ")"
		ElseIf Button = VB6.MouseButtonConstants.RightButton Then 
			' [Titi 2.5.1] erase portrait
			TmpPortraitFile = vbNullString
		End If
	End Sub
	
	Private Sub picCreature_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles picCreature.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = eventArgs.X
		Dim Y As Single = eventArgs.Y
		If MouseDown_Renamed = True Then
			SetDirty(True)
			shpFace.Left = X : shpFace.Top = Y
			TmpFaceLeft = Int((shpFace.Left - CShort(picCreature.ClientRectangle.Width - (picMons.Width * Size_Renamed)) / 2) / Size_Renamed)
			TmpFaceTop = Int((shpFace.Top - CShort(picCreature.ClientRectangle.Height - (picMons.Height * Size_Renamed)) / 2) / Size_Renamed)
			fraMonsPic.Text = "Face (" & TmpFaceLeft & "x" & TmpFaceTop & ")"
		End If
	End Sub
	
	Private Sub picCreature_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles picCreature.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = eventArgs.X
		Dim Y As Single = eventArgs.Y
		MouseDown_Renamed = False
		fraMonsPic.Text = "Picture (" & VB6.Format(picMons.Width) & "x" & VB6.Format(picMons.Height) & ")"
	End Sub
	
	Private Sub picDead_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles picDead.DoubleClick
		btnDead_Click(btnDead, New System.EventArgs())
	End Sub
	
	Private Sub tabMonsProp_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabMonsProp.ClickEvent
		Select Case tabMonsProp.SelectedItem.Tag
			Case bdGeneral
				fraMonsProp(0).BringToFront()
			Case bdType
				fraMonsProp(1).BringToFront()
			Case bdArmor
				fraMonsProp(2).BringToFront()
			Case bdItems
				fraMonsProp(3).BringToFront()
				btnLibrary.Text = "Insert item from library"
				ListItems()
			Case bdTriggers
				fraMonsProp(3).BringToFront()
				btnLibrary.Text = "Insert trigger from library"
				ListTriggers()
			Case bdConversations
				fraMonsProp(3).BringToFront()
				btnLibrary.Text = "Insert conversation from library"
				ListConvos()
			Case bdSounds
				fraMonsProp(4).BringToFront()
				ListSounds()
			Case bdWeakness
				fraMonsProp(5).BringToFront()
		End Select
	End Sub
	
	Public Sub ListSounds()
		Static LastChoice As Short
		Dim c, i As Short
		i = lstWAV.SelectedIndex
		' Save previous selections
		If LastChoice > 0 Then
			LastChoice = LastChoice - 1
			If cmbWAV.Text = "[Default]" Then
				TmpWAV(LastChoice) = ""
			Else
				TmpWAV(LastChoice) = cmbWAV.Text
			End If
			TmpWAVFlag(LastChoice) = chkWAV.CheckState
			SetDirty(True)
		End If
		If i > -1 Then
			If TmpWAV(i) = "" Then
				cmbWAV.Text = "[Default]"
			Else
				cmbWAV.Text = TmpWAV(i)
			End If
			chkWAV.CheckState = TmpWAVFlag(i)
			LastChoice = i + 1
		End If
	End Sub
	
	Public Sub ListItems()
		Dim c As Short
		If tabMonsProp.SelectedItem.Tag = bdItems Then
			lblAttached.Text = "Items Attached to Creature"
			lstThings.Items.Clear()
			For c = 1 To CreatureX.Items.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Items(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Items(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstThings.Items.Add(New VB6.ListBoxItem(CreatureX.Items.Item(c).Name, CreatureX.Items.Item(c).Index))
			Next c
		End If
	End Sub
	
	Public Sub ListTriggers()
		Dim c As Short
		If tabMonsProp.SelectedItem.Tag = bdTriggers Then
			lblAttached.Text = "Triggers Attached to Creature"
			lstThings.Items.Clear()
			For c = 1 To CreatureX.Triggers.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Triggers(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Triggers(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Triggers().TriggerType. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstThings.Items.Add(New VB6.ListBoxItem(TriggerName(CreatureX.Triggers.Item(c).TriggerType) & " " & CreatureX.Triggers.Item(c).Name, CreatureX.Triggers.Item(c).Index))
			Next c
		End If
	End Sub
	
	Public Sub ListConvos()
		Dim c As Short
		If tabMonsProp.SelectedItem.Tag = bdConversations Then
			lblAttached.Text = "Conversations Attached to Creature"
			lstThings.Items.Clear()
			For c = 1 To CreatureX.Conversations.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Conversations(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If CreatureX.CurrentConvo = CreatureX.Conversations.Item(c).Index Then
					'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Conversations().Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					lstThings.Items.Add("<Default> " & CreatureX.Conversations.Item(c).Name)
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Conversations().Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					lstThings.Items.Add(CreatureX.Conversations.Item(c).Name)
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object CreatureX.Conversations().Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: ListBox property lstThings.NewIndex was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
				VB6.SetItemData(lstThings, lstThings.NewIndex, CreatureX.Conversations.Item(c).Index)
			Next c
		End If
	End Sub
	
	Private Sub SetDirty(ByRef Flag As Short)
		btnApply.Enabled = Flag
		Dirty = Flag
		If Dirty = True Then
			frmMDI.Dirty = True
		End If
	End Sub
	
	Public Sub ShowMons(ByRef InTree As AxComctlLib.AxTreeView, ByRef InMons As Creature)
		Dim c, i As Short
		Dim OldDirt, tmpDirty As Short
		OldDirt = frmMDI.Dirty
		tmpDirty = Dirty '[Titi 2.4.9a]
		TreeViewX = InTree
		CreatureX = InMons
		Me.Text = "Creature [" & CreatureX.Name & "]"
		txtName.Text = CreatureX.Name
		txtComments.Text = CreatureX.Comments
		txtRace.Text = CreatureX.Race
		txtHome.Text = CreatureX.Home
		' Load and paint Picture from myPicture
		'    PictureDir = gAppPath & "\data\graphics\creatures"
		PictureDir = gDataPath & "\graphics\creatures"
		TmpPictureFile = CreatureX.PictureFile
		TmpFaceLeft = CreatureX.FaceLeft
		TmpFaceTop = CreatureX.FaceTop
		TmpPortraitFile = CreatureX.PortraitFile
		' [Titi 2.6.0] added possibility to have a specific picture when dead
		tmpPictureWhenDead = CreatureX.PictureWhenDead
		If tmpPictureWhenDead = "" Then tmpPictureWhenDead = "bones.bmp"
		ShowMonsPicWhenDead(tmpPictureWhenDead)
		Select Case PictureStyle
			Case 0 ' Normal Picture
				If Len(TmpPictureFile) > 0 Then
					ShowMonsPicture(TmpPictureFile)
				End If
			Case 1 ' Portrait Picture
				If Len(TmpPortraitFile) > 0 Then
					ShowMonsPortrait(TmpPortraitFile)
				End If
		End Select
		chkIsInanimate.CheckState = CreatureX.IsInanimate * CShort(True)
		chkFriend.CheckState = CreatureX.Friendly * CShort(True)
		chkDMControlled.CheckState = CreatureX.DMControlled * CShort(True)
		chkAgressive.CheckState = CreatureX.Agressive * CShort(True)
		chkGuard.CheckState = CreatureX.Guard * CShort(True)
		chkIsMale.CheckState = CreatureX.Male * CShort(True)
		chkOnAdventure.CheckState = CreatureX.OnAdventure * CShort(True)
		chkRequiredInTome.CheckState = CreatureX.RequiredInTome * CShort(True)
		txtStrength.Text = CStr(Val(CStr(CreatureX.Strength)))
		txtAgility.Text = CStr(Val(CStr(CreatureX.Agility)))
		txtWill.Text = CStr(Val(CStr(CreatureX.Will)))
		txtSkillPoints.Text = CStr(Val(CStr(CreatureX.SkillPoints)))
		txtExperiencePoints.Text = CStr(Val(CStr(CreatureX.ExperiencePoints)))
		txtLevel.Text = CStr(Val(CStr(CreatureX.Level)))
		'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Magic. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Label1(1).Text = IIf(WorldNow.Magic = "", "Eternium", WorldNow.Magic)
		txtEternium.Text = CStr(Val(CStr(CreatureX.Eternium)))
		txtEterniumMax.Text = CStr(Val(CStr(CreatureX.EterniumMax)))
		txtMovement.Text = CStr(Val(CStr(CreatureX.MovementCost)))
		txtActionPts.Text = CStr(Val(CStr(CreatureX.ActionPointsMax)))
		' Vices
		txtLunacy.Text = CStr(Val(CStr(CreatureX.Lunacy)))
		txtRevelry.Text = CStr(Val(CStr(CreatureX.Revelry)))
		txtWrath.Text = CStr(Val(CStr(CreatureX.Wrath)))
		txtPride.Text = CStr(Val(CStr(CreatureX.Pride)))
		txtGreed.Text = CStr(Val(CStr(CreatureX.Greed)))
		txtLust.Text = CStr(Val(CStr(CreatureX.Lust)))
		' Family
		For c = 0 To 9
			chkFamily(c).CheckState = CreatureX.Family(c) * CShort(True)
		Next c
		txtLunacy.Enabled = chkFamily(0).CheckState > 0
		txtRevelry.Enabled = chkFamily(0).CheckState > 0
		txtWrath.Enabled = chkFamily(0).CheckState > 0
		txtPride.Enabled = chkFamily(0).CheckState > 0
		txtGreed.Enabled = chkFamily(0).CheckState > 0
		txtLust.Enabled = chkFamily(0).CheckState > 0
		' CombatRank
		cmbCombatRank.SelectedIndex = CreatureX.CombatRank
		' Size
		i = 0
		For c = 0 To 4
			OptSize(c).Checked = CreatureX.Size(c) * CShort(True)
			i = i + OptSize(c).Checked
		Next c
		If i = 0 Then
			OptSize(2).Checked = True
			CreatureX.Size(c) = 1
		End If
		txtHPNow.Text = CStr(Val(CStr(CreatureX.HPNow)))
		txtHPMax.Text = CStr(Val(CStr(CreatureX.HPMax)))
		' Show Body Type and Resistance
		For c = 0 To 7
			txtAR(c).Text = CStr(CreatureX.Resistance(c))
			cmbArmor(c).SelectedIndex = 0
			For i = 0 To cmbArmor(0).Items.Count - 1
				If CreatureX.BodyType(c) = VB6.GetItemData(cmbArmor(c), i) Then
					cmbArmor(c).SelectedIndex = i
					Exit For
				End If
			Next i
		Next c
		' Resistance Type Bonus
		For c = 0 To 7
			cmbResistance(c).SelectedIndex = CreatureX.ResistanceTypeBonus(c)
		Next c
		' Populate tmp Sound information
		For c = 0 To 3
			Select Case c
				Case 0
					TmpWAV(c) = CreatureX.MoveWAV
					TmpWAVFlag(c) = CreatureX.MoveWAVOneTime * CShort(True)
				Case 1
					TmpWAV(c) = CreatureX.AttackWAV
					TmpWAVFlag(c) = CreatureX.AttackWAVOneTime * CShort(True)
				Case 2
					TmpWAV(c) = CreatureX.HitWAV
					TmpWAVFlag(c) = CreatureX.HitWAVOneTime * CShort(True)
				Case 3
					TmpWAV(c) = CreatureX.DieWAV
					TmpWAVFlag(c) = CreatureX.DieWAVOneTime * CShort(True)
			End Select
		Next c
		lstWAV.SelectedIndex = 0
		ListSounds()
		' List other stuff
		ListItems()
		ListTriggers()
		ListConvos()
		SetDirty(False)
		frmMDI.Dirty = OldDirt
		If Not FromParty(CreatureX) Then btnXP_Value.Enabled = True
		Dirty = tmpDirty ' [Titi 2.4.9a] when loading, the form will not set Dirty
		btnApply.Enabled = Dirty
	End Sub
	
	Private Function FromParty(ByRef CreatureY As Creature) As Boolean
		Dim CreatureX As Creature
		Dim blnPlayerCreature As Boolean
		blnPlayerCreature = False
		For	Each CreatureX In Tome.Creatures
			If CreatureX.Index = CreatureY.Index And CreatureX.Name = CreatureY.Name Then blnPlayerCreature = True
		Next CreatureX
		FromParty = blnPlayerCreature
	End Function
	
	Private Sub ShowMonsPicWhenDead(ByRef FileName As String)
		Dim ClipPath As Object
		Dim X, Y As Short
		Dim NewWidth, NewHeight As Short
		'UPGRADE_WARNING: Arrays in structure bmMons may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmMons As BITMAPINFO
		Dim hMemMons As Integer
		'UPGRADE_WARNING: Arrays in structure bmMask may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		'UPGRADE_WARNING: Arrays in structure bmBlack may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmBlack, bmMask As BITMAPINFO
		Dim rc, lpMem, TransparentRGB As Integer
		Dim PortraitFile As String
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor ' Hourglass
		' Load Bitmap
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If Dir(gDataPath & "\Graphics\Creatures\" & FileName) = FileName Then
			PortraitFile = gDataPath & "\Graphics\Creatures\" & FileName
			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		ElseIf Dir(gDataPath & "\Graphics\Items\" & FileName) = FileName Then  '[Titi 2.6.1] after all, a corpse could also be considered an item!
			PortraitFile = gDataPath & "\Graphics\Items\" & FileName
		Else
			PortraitFile = gDataPath & "\Graphics\Creatures\NoSuchFile.bmp"
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object ClipPath(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PicDeadDir = ClipPath(PortraitFile)
		frmMDI.ShowMsg("Loading Portrait " & FileName & "...")
		' Load Creature bitmap
		ReadBitmapFile(PortraitFile, bmMons, hMemMons, TransparentRGB)
		' Make a copy of the current palette for the Portrait
		'UPGRADE_WARNING: Couldn't resolve default property of object bmBlack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		bmBlack = bmMons
		' Then change Pure Blue to Pure Black
		ChangeColor(bmBlack, TransparentRGB, 0, 0, 0)
		' Paint bitmap to Portrait box using converted palette
		' Paint bitmap to picture box using converted palette
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
		If picMons.Width > picDead.ClientRectangle.Width Then
			Size_Renamed = picDead.ClientRectangle.Width / picMons.Width
		End If
		If picMons.Height * Size_Renamed > picDead.ClientRectangle.Height Then
			Size_Renamed = picDead.ClientRectangle.Height / picMons.Height
		End If
		' Center Creature in frame
		X = CShort(picDead.ClientRectangle.Width - (picMons.Width * Size_Renamed)) / 2
		Y = CShort(picDead.ClientRectangle.Height - (picMons.Height * Size_Renamed)) / 2
		NewHeight = CShort(picMons.Height * Size_Renamed)
		NewWidth = CShort(picMons.Width * Size_Renamed)
		' Paint Creature
		'UPGRADE_ISSUE: PictureBox method picDead.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picDead.Cls()
		'UPGRADE_ISSUE: PictureBox property picDead.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = SetStretchBltMode(picDead.hdc, 3)
		'UPGRADE_ISSUE: PictureBox property picMask.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: PictureBox property picDead.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchBlt(picDead.hdc, X, Y, NewWidth, NewHeight, picMask.hdc, 0, 0, picMask.Width, picMask.Height, SRCAND)
		'UPGRADE_ISSUE: PictureBox property picMons.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: PictureBox property picDead.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchBlt(picDead.hdc, X, Y, NewWidth, NewHeight, picMons.hdc, 0, 0, picMons.Width, picMons.Height, SRCPAINT)
		picDead.Refresh()
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default ' Default
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub ShowMonsPortrait(ByRef FileName As String)
		Dim ClipPath As Object
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
		Else
			'        PortraitFile = gAppPath & "\Data\Graphics\Creatures\NoSuchFile.bmp"
			PortraitFile = gDataPath & "\Graphics\Creatures\NoSuchFile.bmp"
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object ClipPath(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
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
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub ShowMonsPicture(ByRef FileName As String)
		Dim ClipPath As Object
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
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor ' Hourglass
		' Load Bitmap
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FullPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		PictureFile = Dir(Tome.FullPath & "\" & FileName)
		If PictureFile = "" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FullPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			PictureFile = Dir(Tome.FullPath & "\creatures\" & FileName)
			If PictureFile = "" Then
				' [Titi 2.4.9b] added the possibility to have pictures only in a given world
				'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				PictureFile = Dir(gAppPath & "\Roster\" & WorldNow.Name & "\" & FileName)
				If PictureFile = "" Then
					'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
					PictureFile = Dir(gAppPath & "\Roster\" & WorldNow.Name & "\Creatures\" & FileName)
					If PictureFile = "" Then
						'        PictureFile = gAppPath & "\data\graphics\creatures\" & FileName
						PictureFile = gDataPath & "\graphics\creatures\" & FileName
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						PictureFile = gAppPath & "\Roster\" & WorldNow.Name & "\Creatures\" & FileName
					End If
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					PictureFile = gAppPath & "\Roster\" & WorldNow.Name & "\" & FileName
				End If
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FullPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				PictureFile = Tome.FullPath & "\creatures\" & FileName
			End If
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FullPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			PictureFile = Tome.FullPath & "\" & FileName
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object ClipPath(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
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
		'UPGRADE_ISSUE: PictureBox property picMask.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: PictureBox property picCreature.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchBlt(picCreature.hdc, X, Y, NewWidth, NewHeight, picMask.hdc, 0, 0, picMask.Width, picMask.Height, SRCAND)
		'UPGRADE_ISSUE: PictureBox property picMons.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: PictureBox property picCreature.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchBlt(picCreature.hdc, X, Y, NewWidth, NewHeight, picMons.hdc, 0, 0, picMons.Width, picMons.Height, SRCPAINT)
		fraMonsPic.Text = "Picture (" & VB6.Format(picMons.Width) & "x" & VB6.Format(picMons.Height) & ")"
		picCreature.Refresh()
		' Size shpFace Normal: Width=66, Height=76
		shpFace.Width = 33 * Size_Renamed : shpFace.Height = 38 * Size_Renamed
		shpFace.Left = X + TmpFaceLeft * Size_Renamed
		shpFace.Top = Y + TmpFaceTop * Size_Renamed
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default ' Default
	End Sub
	
	Private Sub OpenPictureFile()
		On Error Resume Next
		Select Case PictureStyle
			Case 0 ' Normal Picture
				'            dlgFile.FileName = gAppPath & "\Data\Graphics\Creatures\*.bmp"
				dlgFileOpen.FileName = gDataPath & "\Graphics\Creatures\*.bmp"
			Case 1 ' Portrait Picture
				'            dlgFile.FileName = gAppPath & "\Data\Graphics\Portraits\*.bmp"
				dlgFileOpen.FileName = gDataPath & "\Graphics\Portraits\*.bmp"
		End Select
		dlgFileOpen.Title = "Choose Picture"
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
		' Set cursor to hourglass
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		' Depending on file chosen, get other files
		Select Case PictureStyle
			Case 0 ' Normal Picture
				'UPGRADE_WARNING: CommonDialog property dlgFile.FileTitle was upgraded to dlgFile.FileName which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
				TmpPictureFile = dlgFileOpen.FileName
				ShowMonsPicture(TmpPictureFile)
			Case 1 ' Portrait Picture
				'UPGRADE_WARNING: CommonDialog property dlgFile.FileTitle was upgraded to dlgFile.FileName which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
				TmpPortraitFile = dlgFileOpen.FileName
				ShowMonsPortrait(TmpPortraitFile)
		End Select
		SetDirty(True)
	End Sub
	
	Private Sub NextPortraitFile(ByRef Direction As Short)
		' -1 is Left, 1 is Right
		Dim FileName, LastFile As String
		' Count the PortraitFiles
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileName = Dir(PortraitDir & "\*.bmp")
		Do Until FileName = ""
			If Direction = -1 Then ' Left
				If LastFile = "" Then
					LastFile = "1"
				End If
				If FileName < TmpPortraitFile And FileName > LastFile Then
					LastFile = FileName
				End If
			Else ' Right
				If LastFile = "" Then
					LastFile = "~"
				End If
				If FileName > TmpPortraitFile And FileName < LastFile Then
					LastFile = FileName
				End If
			End If
			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FileName = Dir()
		Loop 
		If LastFile <> "1" And LastFile <> "~" Then
			TmpPortraitFile = LastFile
			ShowMonsPortrait(TmpPortraitFile)
		ElseIf LastFile = "1" Then 
			TmpPortraitFile = ""
			ShowMonsPortrait(TmpPortraitFile)
		End If
	End Sub
	
	Private Sub NextPictureFile(ByRef Direction As Short)
		' -1 is Left, 1 is Right
		Dim FileName, LastFile As String
		' Count the PictureFiles
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileName = Dir(PictureDir & "\*.bmp")
		Do Until FileName = ""
			If Direction = -1 Then ' Left
				If LastFile = "" Then
					LastFile = "1"
				End If
				If FileName < TmpPictureFile And FileName > LastFile Then
					LastFile = FileName
				End If
			Else ' Right
				If LastFile = "" Then
					LastFile = "~"
				End If
				If FileName > TmpPictureFile And FileName < LastFile Then
					LastFile = FileName
				End If
			End If
			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FileName = Dir()
		Loop 
		If LastFile <> "1" And LastFile <> "~" Then
			TmpPictureFile = LastFile
			ShowMonsPicture(TmpPictureFile)
		End If
	End Sub
	
	Private Sub OpenWAVFile()
		On Error Resume Next
		'    ChDir gAppPath & "\data\sounds"
		dlgFileOpen.FileName = gDataPath & "\sounds\*.wav"
		dlgFileOpen.Title = "Select Sound"
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		dlgFile.CancelError = True
		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		dlgFileOpen.Filter = "Sounds (*.wav)|*.wav|All Files (*.*)|*.*"
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
		cmbWAV.Text = dlgFileOpen.FileName
		SetDirty(True)
	End Sub
	
	Private Sub UpdateMons()
		Dim frmWorldSettings As Object
		'[Titi] added all the 'if txtVar.text <>"" ' lines
		Dim c, i As Short
		CreatureX.Name = txtName.Text
		CreatureX.Comments = txtComments.Text
		CreatureX.Race = txtRace.Text
		CreatureX.Home = txtHome.Text
		' Load and paint Picture from myPicture
		CreatureX.PictureFile = TmpPictureFile
		CreatureX.PortraitFile = TmpPortraitFile
		' [Titi 2.6.0] possibility to have a specific picture when dead
		CreatureX.PictureWhenDead = tmpPictureWhenDead
		CreatureX.FaceLeft = (shpFace.Left - CShort(picCreature.ClientRectangle.Width - (picMons.Width * Size_Renamed)) / 2) / Size_Renamed
		CreatureX.FaceTop = (shpFace.Top - CShort(picCreature.ClientRectangle.Height - (picMons.Height * Size_Renamed)) / 2) / Size_Renamed
		CreatureX.IsInanimate = chkIsInanimate.CheckState * CShort(True)
		CreatureX.Friendly = chkFriend.CheckState * CShort(True)
		CreatureX.DMControlled = chkDMControlled.CheckState * CShort(True)
		CreatureX.Guard = chkGuard.CheckState * CShort(True)
		CreatureX.Agressive = chkAgressive.CheckState * CShort(True)
		CreatureX.Male = chkIsMale.CheckState * CShort(True)
		CreatureX.OnAdventure = chkOnAdventure.CheckState * CShort(True)
		CreatureX.RequiredInTome = chkRequiredInTome.CheckState * CShort(True)
		CreatureX.Strength = 0
		If txtStrength.Text <> "" Then CreatureX.Strength = CShort(txtStrength.Text)
		CreatureX.Agility = 0
		If txtAgility.Text <> "" Then CreatureX.Agility = CShort(txtAgility.Text)
		CreatureX.Will = 0
		If txtWill.Text <> "" Then CreatureX.Will = CShort(txtWill.Text)
		CreatureX.ExperiencePoints = 0
		If txtExperiencePoints.Text <> "" Then CreatureX.ExperiencePoints = CInt(txtExperiencePoints.Text)
		CreatureX.SkillPoints = 0
		If txtSkillPoints.Text <> "" Then CreatureX.SkillPoints = CShort(txtSkillPoints.Text)
		CreatureX.Level = 0
		If txtLevel.Text <> "" Then CreatureX.Level = CShort(txtLevel.Text)
		CreatureX.Eternium = 0
		If txtEternium.Text <> "" Then CreatureX.Eternium = CShort(txtEternium.Text)
		' Vices
		CreatureX.Lunacy = 0
		If txtLunacy.Text <> "" Then CreatureX.Lunacy = CShort(txtLunacy.Text)
		CreatureX.Revelry = 0
		If txtRevelry.Text <> "" Then CreatureX.Revelry = CShort(txtRevelry.Text)
		CreatureX.Wrath = 0
		If txtWrath.Text <> "" Then CreatureX.Wrath = CShort(txtWrath.Text)
		CreatureX.Pride = 0
		If txtPride.Text <> "" Then CreatureX.Pride = CShort(txtPride.Text)
		CreatureX.Greed = 0
		If txtGreed.Text <> "" Then CreatureX.Greed = CShort(txtGreed.Text)
		CreatureX.Lust = 0
		If txtLust.Text <> "" Then CreatureX.Lust = CShort(txtLust.Text)
		' Family
		For c = 0 To 9
			CreatureX.Family(c) = chkFamily(c).CheckState * CShort(True)
		Next c
		' Size
		For c = 0 To 4
			CreatureX.Size(c) = CShort(OptSize(c).Checked) * CShort(True)
		Next c
		CreatureX.HPMax = 0
		If txtHPMax.Text <> "" Then CreatureX.HPMax = CShort(txtHPMax.Text)
		CreatureX.HPNow = 0
		If txtHPNow.Text <> "" Then CreatureX.HPNow = CShort(txtHPNow.Text)
		' Populate tmp armor information
		For c = 0 To 7
			CreatureX.Resistance(c) = Val(txtAR(c).Text)
			CreatureX.BodyType(c) = VB6.GetItemData(cmbArmor(c), cmbArmor(c).SelectedIndex)
		Next c
		' Populate Resistance Bonus
		For c = 0 To 7
			CreatureX.ResistanceTypeBonus(c) = cmbResistance(c).SelectedIndex
		Next c
		' Populate tmp sound information
		For c = 0 To 3
			Select Case c
				Case 0
					CreatureX.MoveWAV = TmpWAV(c)
					CreatureX.MoveWAVOneTime = TmpWAVFlag(c) * CShort(True)
				Case 1
					CreatureX.AttackWAV = TmpWAV(c)
					CreatureX.AttackWAVOneTime = TmpWAVFlag(c) * CShort(True)
				Case 2
					CreatureX.HitWAV = TmpWAV(c)
					CreatureX.HitWAVOneTime = TmpWAVFlag(c) * CShort(True)
				Case 3
					CreatureX.DieWAV = TmpWAV(c)
					CreatureX.DieWAVOneTime = TmpWAVFlag(c) * CShort(True)
			End Select
		Next c
		' Update ProjectList
		TreeViewX.Nodes(Me.Tag).Text = CreatureX.Name
		SetDirty(False)
		' [Titi 2.4.9b] If name has been changed, update the kingdom if necessary
		'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.Visible. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If frmWorldSettings.Visible = True Then
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.TabStrip1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			strKingdomTemplate(frmWorldSettings.TabStrip1.SelectedItem.Index) = CreatureX.Name
			'UPGRADE_WARNING: Couldn't resolve default property of object frmWorldSettings.TabStrip1_Click. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmWorldSettings.TabStrip1_Click() ' [Titi 2.4.9b] will refresh the display
		End If
	End Sub
	
	Private Sub txtAgility_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtAgility.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtAgility.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtAgility_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAgility.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtAR.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtAR_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAR.TextChanged
		Dim Index As Short = txtAR.GetIndex(eventSender)
		Limit(Me.ActiveControl, 0, bdInt)
		SetDirty(True)
	End Sub
	
	Private Sub txtAR_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtAR.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = txtAR.GetIndex(eventSender)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdInt)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtComments.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtComments_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtComments.TextChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtEternium.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtEternium_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtEternium.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		If Val(txtEternium.Text) > CreatureX.EterniumMax Then
			txtEternium.Text = CStr(CreatureX.EterniumMax)
		End If
		SetDirty(True)
	End Sub
	
	Private Sub txtEternium_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtEternium.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtExperiencePoints_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtExperiencePoints.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdLong)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtGreed.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtGreed_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtGreed.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	Private Sub txtGreed_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtGreed.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdInt)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtHome.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtHome_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHome.TextChanged
		SetDirty(True)
	End Sub
	
	Private Sub txtHPMax_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHPMax.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdInt)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtHPNow_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHPNow.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdInt)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtLevel.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtLevel_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLevel.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtHPMax.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtHPMax_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHPMax.TextChanged
		Limit(Me.ActiveControl, 0, bdInt)
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtHPNow.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtHPNow_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHPNow.TextChanged
		Limit(Me.ActiveControl, 0, bdInt)
		SetDirty(True)
	End Sub
	
	Private Sub txtLevel_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLevel.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtLunacy.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtLunacy_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLunacy.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	Private Sub txtLunacy_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLunacy.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtLust.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtLust_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLust.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	Private Sub txtLust_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLust.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtName.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtName_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtName.TextChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtPride.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtPride_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPride.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	Private Sub txtPride_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtPride.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtRace.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtRace_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRace.TextChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtRevelry.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtRevelry_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRevelry.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	Private Sub txtRevelry_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtRevelry.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtSkillPoints_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSkillPoints.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdInt)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtExperiencePoints.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtExperiencePoints_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtExperiencePoints.TextChanged
		Limit(Me.ActiveControl, 0, bdLong)
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtSkillPoints.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtSkillPoints_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSkillPoints.TextChanged
		Limit(Me.ActiveControl, 0, bdInt)
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtStrength.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtStrength_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtStrength.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	Private Sub txtStrength_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtStrength.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtWill.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtWill_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWill.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	Private Sub txtWill_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtWill.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtWrath.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtWrath_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWrath.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	Private Sub txtWrath_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtWrath.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
End Class