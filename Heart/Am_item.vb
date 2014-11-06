Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmItem
	Inherits System.Windows.Forms.Form
	Dim TreeViewX As AxComctlLib.AxTreeView
	Dim ItemX As Item
	Dim Dirty As Short
	Dim TmpPictureFile As String
	Dim PictureDir As String
	
	Const bdGeneral As Short = 1
	Const bdForm As Short = 2
	Const bdItems As Short = 3
	Const bdTriggers As Short = 4
	
	Private Sub CopyThing()
		If lstThings.SelectedIndex > -1 Then
			Select Case tabItemProp.SelectedItem.Tag
				Case bdTriggers
					frmMDI.EditCopy(Me.Tag & "T" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdItems
					frmMDI.EditCopy(Me.Tag & "I" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
		End If
	End Sub
	
	Private Sub PasteThing()
		Select Case tabItemProp.SelectedItem.Tag
			Case bdTriggers
				If frmMDI.BufferType = bdEditTrigger Then
					frmMDI.EditPaste(Me.Tag)
				End If
			Case bdItems
				If frmMDI.BufferType = bdEditItem Then
					frmMDI.EditPaste(Me.Tag)
				End If
		End Select
	End Sub
	
	Private Sub EditThing()
		If lstThings.SelectedIndex > -1 Then
			Select Case tabItemProp.SelectedItem.Tag
				Case bdTriggers
					frmMDI.EditProperties(Me.Tag & "T" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdItems
					frmMDI.EditProperties(Me.Tag & "I" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
		End If
	End Sub
	
	Private Sub CutThing()
		If lstThings.SelectedIndex > -1 Then
			Select Case tabItemProp.SelectedItem.Tag
				Case bdTriggers
					frmMDI.EditCut(Me.Tag & "T" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdItems
					frmMDI.EditCut(Me.Tag & "I" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
		End If
	End Sub
	
	Private Sub btnApply_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnApply.Click
		UpdateItem()
		ShowItem(TreeViewX, ItemX)
	End Sub
	
	Private Sub btnBrowse_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnBrowse.Click
		OpenPictureFile()
		SetDirty(True)
	End Sub
	
	Private Sub btnBrowseLeft_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnBrowseLeft.Click
		NextPictureFile(-1)
		SetDirty(True)
	End Sub
	
	Private Sub btnBrowseRight_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnBrowseRight.Click
		NextPictureFile(1)
		SetDirty(True)
	End Sub
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		' [Titi 2.6.3] cancelling a new item means we won't keep it
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
		' [Titi 2.6.3] cancelling a validated item only means we won't keep the changes since the last ones so we update the tag
		If VB.Right("   " & Me.Tag, 3) = "NEW" Then Me.Tag = VB.Left(Me.Tag, Len(Me.Tag) - 3)
		UpdateItem()
		Me.Close()
	End Sub
	
	Private Sub btnPaste_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnPaste.Click
		PasteThing()
	End Sub
	
	Private Sub btnReGen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnReGen.Click
		Dim ItemZ As Item
		UpdateItem()
		If ItemX.Items.Count() > 0 Then
			For	Each ItemZ In ItemX.Items
				frmMDI.EditDelete(Me.Tag & "I" & ItemZ.Index, True)
			Next ItemZ
		End If
		MakeItem(ItemX)
		ShowItem(TreeViewX, ItemX)
		If ItemX.Items.Count() > 0 Then
			For	Each ItemZ In ItemX.Items
				frmMDI.ShowItem((frmMDI.ObjectListX), TreeViewX, Me.Tag, ItemZ)
			Next ItemZ
		End If
		UpdateItem()
	End Sub
	
	'UPGRADE_WARNING: Event chkAllowOtherSize.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkAllowOtherSize_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkAllowOtherSize.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkCombine.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkCombine_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkCombine.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkDescription.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkDescription_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkDescription.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkExamined.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkExamined_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkExamined.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkIsEquipped.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkIsEquipped_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkIsEquipped.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkKey.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkKey_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkKey.CheckStateChanged
		Dim Index As Short = chkKey.GetIndex(eventSender)
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkSoftCapacity.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkSoftCapacity_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkSoftCapacity.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkTwoHanded.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkTwoHanded_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkTwoHanded.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbAmmo.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbAmmo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbAmmo.SelectedIndexChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbDamage.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbDamage_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbDamage.SelectedIndexChanged
		' [Titi 2.6.0] no value for food if it's not got special properties (ie effect type = None)
		If cmbFamily.SelectedIndex = 3 And cmbFoodType.SelectedIndex = 0 Then
			cmbDamage.SelectedIndex = 0
		Else
			SetDirty(True)
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmbDamageType.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbDamageType_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbDamageType.SelectedIndexChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbFoodType.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbFoodType_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbFoodType.SelectedIndexChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbFamily.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbFamily_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbFamily.SelectedIndexChanged
		ShowItemClass(VB6.GetItemData(cmbFamily, cmbFamily.SelectedIndex))
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbRange.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbRange_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbRange.SelectedIndexChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbResistanceBonus.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbResistanceBonus_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbResistanceBonus.SelectedIndexChanged
		' [Titi 2.6.0] Bonus only possible if a resistance type is defined
		If cmbResistanceType.SelectedIndex = 0 Then
			cmbResistanceBonus.SelectedIndex = 0
		Else
			SetDirty(True)
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmbResistanceType.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbResistanceType_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbResistanceType.SelectedIndexChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbWearType.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbWearType_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbWearType.SelectedIndexChanged
		SetDirty(True)
	End Sub
	
	Private Sub btnLibrary_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnLibrary.Click
		If btnLibrary.Visible = True Then
			frmMDI.EditLoad(Me.Tag, bdEditTrigger)
		End If
	End Sub
	
	'UPGRADE_WARNING: Form event frmItem.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmItem_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		' [Titi 2.6.0] Make sure we're still working with the relevant treeview and objectlist
		If VB.Left(Me.Tag, 4) = "Tome" Then
			frmMDI.TreeViewX = frmProject.tvwTome.GetOcx
			frmMDI.ObjectListX = frmProject.TomeList
		Else
			frmMDI.TreeViewX = frmProject.tvwProject.GetOcx
			frmMDI.ObjectListX = frmProject.AreaList
		End If
	End Sub
	
	Private Sub frmItem_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Dim CtrlKey As Object
		If TypeOf Me.ActiveControl Is System.Windows.Forms.TextBox Then
			CtrlKey(Me.ActiveControl, KeyCode, Shift)
		End If
	End Sub
	
	Private Sub frmItem_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		InitGame()
	End Sub
	
	Private Sub frmItem_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Dim c As Short
		' [Titi 2.4.9a]
		If Dirty Then
			c = MsgBox("Changes will be lost! Save first?", MsgBoxStyle.YesNo, "Changes not saved!")
			If c = MsgBoxResult.Yes Then
				' [Titi 2.6.3] update the tag before closing
				If VB.Right("   " & Me.Tag, 3) = "NEW" Then Me.Tag = VB.Left(Me.Tag, Len(Me.Tag) - 3)
				btnOk_Click(btnOk, New System.EventArgs())
			Else
				' [Titi 2.6.3] closing a new item means we won't keep it
				If VB.Right("   " & Me.Tag, 3) = "NEW" Then
					frmMDI.EditCut(VB.Left(Me.Tag, Len(Me.Tag) - 3))
				End If
			End If
		End If
	End Sub
	
	Private Sub InitGame()
		Dim j, c, i As Short
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor ' Hourglass
		' Damage combo boxes (dice)
		cmbDamage.Items.Add("None")
		For i = 1 To 255
			If i < 26 Then
				cmbDamage.Items.Add(Str((i - 1) Mod 5 + 1) & "d" & Trim(Str(Int(((i - 1) Mod 25) / 5) * 2 + 4)))
			Else
				cmbDamage.Items.Add(Str((i - 1) Mod 5 + 1) & "d" & Trim(Str(Int(((i - 1) Mod 25) / 5) * 2 + 4)) & "+" & Trim(Str(Int((i - 1) / 25))))
			End If
		Next i
		' Set up Item Type list
		c = 0
		Do Until SetUpItemFamily(c) = ""
			cmbFamily.Items.Add(New VB6.ListBoxItem(SetUpItemFamily(c), c))
			c = c + 1
		Loop 
		' Set up Item Class
		cmbDamageType.Items.Clear()
		For c = 1 To 8
			cmbDamageType.Items.Add(SetUpResistanceType(c))
		Next c
		' [Titi 2.4.9b] Added special effects for food
		cmbFoodType.Items.Clear()
		cmbFoodType.Items.Add("None")
		cmbFoodType.Items.Add("Heal") ' gives health
		cmbFoodType.Items.Add("Sickness") ' takes health
		cmbFoodType.Items.Add("Energy") ' adds Eternium (if relevant)
		cmbFoodType.Items.Add("Fatigue") ' takes Eternium (if relevant)
		cmbFoodType.Items.Add("Poison") ' adds a poison trigger
		cmbFoodType.Items.Add("Curse") ' adds a curse trigger
		cmbFoodType.Items.Add("Random") ' any of the above, known only after use
		' Set up ResistanceType
		cmbResistanceType.Items.Clear()
		For c = 0 To 8
			cmbResistanceType.Items.Add(SetUpResistanceType(c))
		Next c
		cmbResistanceBonus.Items.Clear()
		cmbResistanceBonus.Items.Add("<None>")
		cmbResistanceBonus.Items.Add("10%")
		cmbResistanceBonus.Items.Add("20%")
		cmbResistanceBonus.Items.Add("30%")
		cmbResistanceBonus.Items.Add("40%")
		cmbResistanceBonus.Items.Add("50%")
		cmbResistanceBonus.Items.Add("60%")
		cmbResistanceBonus.Items.Add("70%")
		cmbResistanceBonus.Items.Add("80%")
		cmbResistanceBonus.Items.Add("90%")
		cmbResistanceBonus.Items.Add("Immune")
		cmbResistanceBonus.Items.Add("Double Damage")
		cmbResistanceBonus.Items.Add("Triple Damage")
		
		cmbRange.Items.Add("Short")
		cmbRange.Items.Add("Medium")
		cmbRange.Items.Add("Long")
		
		cmbAmmo.Items.Add("Arrow (Short)")
		cmbAmmo.Items.Add("Arrow (Long)")
		cmbAmmo.Items.Add("Sling (Light)")
		cmbAmmo.Items.Add("Sling (Heavy)")
		cmbAmmo.Items.Add("Gun (Small)")
		cmbAmmo.Items.Add("Gun (Large)")
		cmbAmmo.Items.Add("Energy (Low)")
		cmbAmmo.Items.Add("Energy (High)")
		
		cmbWearType.Items.Add("Body")
		cmbWearType.Items.Add("Helm")
		cmbWearType.Items.Add("Glove")
		cmbWearType.Items.Add("Bracelet")
		cmbWearType.Items.Add("Backpack")
		cmbWearType.Items.Add("Shield")
		cmbWearType.Items.Add("Boots")
		cmbWearType.Items.Add("Necklace")
		cmbWearType.Items.Add("Belt")
		cmbWearType.Items.Add("Ring")
		
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default ' Normal
	End Sub
	
	Private Sub SetDirty(ByRef Flag As Short)
		btnApply.Enabled = Flag
		Dirty = Flag
		If Dirty = True Then
			frmMDI.Dirty = True
		End If
	End Sub
	
	Public Sub ShowItem(ByRef InTree As AxComctlLib.AxTreeView, ByRef InItem As Item)
		Dim c, IsKey As Short
		Dim tmpDirty, OldDirt, tmpSize As Short
		tmpDirty = Dirty '[Titi 2.4.9a]
		OldDirt = frmMDI.Dirty
		TreeViewX = InTree
		ItemX = InItem
		Me.Text = "Item [" & ItemX.Name & "]"
		txtName.Text = ItemX.NameText
		chkCombine.CheckState = ItemX.CanCombine * CShort(True)
		chkDescription.CheckState = ItemX.UseDescription * CShort(True)
		txtComments.Text = ItemX.Comments
		For c = 0 To cmbFamily.Items.Count
			If VB6.GetItemData(cmbFamily, c) = ItemX.Family Then
				cmbFamily.SelectedIndex = c
				Exit For
			End If
		Next c
		' Special display for Keys
		For c = 3 To 7
			chkKey(c).CheckState = ItemX.KeyBit(c) * CShort(True)
			chkKey(c).Visible = IsKey
		Next c
		lblRequiredLevel.Visible = Not IsKey
		txtRequiredLevel.Visible = Not IsKey
		ShowItemClass((ItemX.Family))
		txtValue.Text = VB6.Format(ItemX.Value)
		txtCount.Text = VB6.Format(ItemX.Count)
		txtWeight.Text = VB6.Format(ItemX.WeightEmpty)
		txtBulk.Text = VB6.Format(ItemX.Bulk)
		txtCapacity.Text = VB6.Format(ItemX.Capacity)
		chkSoftCapacity.CheckState = ItemX.SoftCapacity * CShort(True)
		chkIsEquipped.CheckState = ItemX.IsReady * CShort(True)
		txtActionPoints.Text = VB6.Format(ItemX.ActionPoints)
		txtAttackBonus.Text = VB6.Format(ItemX.AttackBonus)
		txtDefense.Text = VB6.Format(ItemX.Defense)
		cmbRange.SelectedIndex = ItemX.RangeType
		chkTwoHanded.CheckState = CShort(ItemX.WearType = 11) * CShort(True)
		cmbDamageType.SelectedIndex = Greatest(ItemX.DamageType - 1, 0)
		cmbDamage.SelectedIndex = ItemX.Damage
		' [Titi 2.4.9b] added special effects for food
		cmbFoodType.SelectedIndex = Greatest(ItemX.DamageType - 1, 0)
		txtDamageBonus.Text = VB6.Format(ItemX.DamageBonus)
		cmbAmmo.SelectedIndex = ItemX.ShootType
		txtArmor.Text = VB6.Format(ItemX.Resistance)
		cmbWearType.SelectedIndex = Least((ItemX.WearType), 9)
		cmbResistanceType.SelectedIndex = ItemX.ResistanceType
		cmbResistanceBonus.SelectedIndex = ItemX.ResistanceBonus
		' [Titi 2.4.9b] added size information
		If ItemX.Size = 0 Then
			' for compatibility with previous versions: size "medium" and "all sizes can use"
			ItemX.SizeBit(6) = 1
			ItemX.SizeBit(9) = 1
		End If
		For c = 0 To 4
			OptSize(c).Checked = (ItemX.SizeBit(4 + c) And 2 ^ (4 + c))
		Next 
		chkAllowOtherSize.CheckState = CShort((ItemX.SizeBit(9) And 512) = 512) * CShort(True)
		chkExamined.CheckState = ItemX.Examined * CShort(True)
		' [Titi 2.4.9b] added min level to recognize the item
		txtRequiredLevel.Text = CStr(ItemX.MinLevel - CShort(ItemX.MinLevel = 0))
		' Show correct info based on tab
		Select Case tabItemProp.SelectedItem.Tag
			Case bdGeneral
				fraItemProp(0).BringToFront()
			Case bdForm
				fraItemProp(1).BringToFront()
			Case bdItems, bdTriggers
				fraItemProp(2).BringToFront()
		End Select
		' Show Item Picture
		TmpPictureFile = ItemX.PictureFile
		'    PictureDir = gAppPath & "\data\graphics\items"
		PictureDir = gDataPath & "\graphics\items"
		If ItemX.PictureFile <> "" Then
			ShowItemPicture(TmpPictureFile)
		End If
		ListItems()
		ListTriggers()
		SetDirty(False)
		frmMDI.Dirty = OldDirt
		Dirty = tmpDirty ' [Titi 2.4.9a] when loading, the form will not set Dirty
		btnApply.Enabled = Dirty
	End Sub
	
	Private Sub ShowItemClass(ByRef Index As Short)
		Dim c, IsKey As Short
		' If Key or Lock then show as should
		IsKey = (Index = 1 Or Index = 15)
		lblKey.Visible = IsKey
		' [Titi 2.4.9b] Added min level to use item efficiently
		txtRequiredLevel.Visible = Not IsKey
		lblRequiredLevel.Visible = Not IsKey
		txtRequiredLevel.Text = CStr(System.Math.Abs(CInt(txtRequiredLevel.Visible = True)))
		For c = 3 To 7
			chkKey(c).Visible = IsKey
		Next c
		btnReGen.Visible = False
		fraItem(1).Text = "Damage"
		lblDamageType.Text = "Damage type"
		lblDamage.Text = "Damage"
		lblDamageBonus.Text = "Damage Bonus"
		lblDamageBonus.Width = VB6.TwipsToPixelsX(1245)
		txtDamageBonus.Top = VB6.TwipsToPixelsY(1380)
		Select Case Index
			Case 0, 1, 2, 14, 15, 16, 17, 18 ' <None>
				fraItem(0).Visible = False
				fraItem(1).Visible = False
				fraItem(2).Visible = False
				fraSize.Visible = CShort(False) + CShort(Index = 0)
				' [Titi 2.4.9b] min level to use not relevant
				txtRequiredLevel.Text = CStr(0 - CShort(Index = 0))
				txtRequiredLevel.Visible = CShort(False) + CShort(Index = 0)
				lblRequiredLevel.Visible = CShort(False) + CShort(Index = 0)
			Case 3 ' Food [Titi 2.4.9b] special bonus for food
				fraItem(0).Visible = False
				fraItem(1).Visible = True
				fraItem(1).Text = "Effects after use"
				lblDamageType.Text = "Effect type"
				lblDamage.Text = "Value"
				lblDamageBonus.Text = "Spoiled after (in days)"
				lblDamageBonus.Width = VB6.TwipsToPixelsX(1740)
				txtDamageBonus.Top = VB6.TwipsToPixelsY(1620)
				lblAmmo.Visible = False
				cmbAmmo.Visible = False
				cmbDamageType.Visible = False
				cmbFoodType.Visible = True
				fraItem(2).Visible = False
				fraSize.Visible = False
				' [Titi 2.4.9b] min level to use to determine if the character finds if the food is edible
				txtRequiredLevel.Text = CStr(2) ' level 1 characters will only know it's food, not if it's poisoned!
			Case 4 ' Armor
				fraItem(0).Visible = True
				lblResistance.Visible = True
				txtArmor.Visible = True
				lblAttackBonus.Visible = False
				txtAttackBonus.Visible = False
				lblRange.Visible = False
				cmbRange.Visible = False
				chkTwoHanded.Visible = False
				fraItem(1).Visible = False
				fraItem(2).Visible = True
				fraSize.Visible = True
			Case 5 ' Weapon (Melee)
				fraItem(0).Visible = True
				lblActionPoints.Visible = True
				txtActionPoints.Visible = True
				lblResistance.Visible = False
				txtArmor.Visible = False
				lblAttackBonus.Visible = True
				txtAttackBonus.Visible = True
				lblDefense.Visible = True
				txtDefense.Visible = True
				lblRange.Visible = True
				cmbRange.Visible = True
				chkTwoHanded.Visible = True
				fraItem(1).Visible = True
				lblDamageType.Visible = True
				cmbDamageType.Visible = True
				lblDamage.Visible = True
				cmbDamage.Visible = True
				lblDamageBonus.Visible = True
				txtDamageBonus.Visible = True
				lblAmmo.Visible = False
				cmbAmmo.Visible = False
				fraItem(2).Visible = False
				fraSize.Visible = True
			Case 6 ' Weapon (Ammo)
				fraItem(0).Visible = True
				lblActionPoints.Visible = False
				txtActionPoints.Visible = False
				lblResistance.Visible = False
				txtArmor.Visible = False
				lblAttackBonus.Visible = True
				txtAttackBonus.Visible = True
				lblDefense.Visible = False
				txtDefense.Visible = False
				lblRange.Visible = False
				cmbRange.Visible = False
				chkTwoHanded.Visible = False
				fraItem(1).Visible = True
				lblDamageType.Visible = True
				cmbDamageType.Visible = True
				lblDamage.Visible = True
				cmbDamage.Visible = True
				lblDamageBonus.Visible = True
				txtDamageBonus.Visible = True
				lblAmmo.Visible = True
				cmbAmmo.Visible = True
				fraItem(2).Visible = False
				fraSize.Visible = True
			Case 7 ' Weapon (Ranged)
				fraItem(0).Visible = True
				lblActionPoints.Visible = True
				txtActionPoints.Visible = True
				lblResistance.Visible = False
				txtArmor.Visible = False
				lblAttackBonus.Visible = True
				txtAttackBonus.Visible = True
				lblDefense.Visible = True
				txtDefense.Visible = True
				lblRange.Visible = True
				cmbRange.Visible = True
				chkTwoHanded.Visible = True
				fraItem(1).Visible = True
				lblDamageType.Visible = False
				cmbDamageType.Visible = False
				lblDamage.Visible = False
				cmbDamage.Visible = False
				lblDamageBonus.Visible = True
				txtDamageBonus.Visible = True
				lblAmmo.Visible = True
				cmbAmmo.Visible = True
				fraItem(2).Visible = False
				fraSize.Visible = True
			Case 8 ' Weapon (Thrown)
				fraItem(0).Visible = True
				lblActionPoints.Visible = True
				txtActionPoints.Visible = True
				lblResistance.Visible = False
				txtArmor.Visible = False
				lblAttackBonus.Visible = True
				txtAttackBonus.Visible = True
				lblDefense.Visible = True
				txtDefense.Visible = True
				lblRange.Visible = True
				cmbRange.Visible = True
				chkTwoHanded.Visible = True
				fraItem(1).Visible = True
				lblDamageType.Visible = True
				cmbDamageType.Visible = True
				lblDamage.Visible = True
				cmbDamage.Visible = True
				lblDamageBonus.Visible = True
				txtDamageBonus.Visible = True
				lblAmmo.Visible = False
				cmbAmmo.Visible = False
				fraItem(2).Visible = False
				fraSize.Visible = True
			Case 9, 10 ' Random Weapon, Armor
				fraItem(0).Visible = False
				fraItem(1).Visible = False
				fraItem(2).Visible = False
				fraSize.Visible = False
				btnReGen.Visible = True
				' [Titi 2.4.9b] min level to use item efficiently will be random as well
				txtRequiredLevel.Visible = False
				lblRequiredLevel.Visible = False
			Case 11, 12, 13 ' Random Gems, Treasure, Junk
				fraItem(0).Visible = False
				fraItem(1).Visible = False
				fraItem(2).Visible = False
				fraSize.Visible = False
				btnReGen.Visible = True
				' [Titi 2.4.9b] min level to use not relevant
				txtRequiredLevel.Visible = False
				lblRequiredLevel.Visible = False
		End Select
	End Sub
	
	Public Sub ListTriggers()
		Dim c As Short
		If tabItemProp.SelectedItem.Tag = bdTriggers Then
			lblAttached.Text = "Triggers Attached to Item"
			lstThings.Items.Clear()
			For c = 1 To ItemX.Triggers.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object ItemX.Triggers(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ItemX.Triggers(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ItemX.Triggers().TriggerType. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstThings.Items.Add(New VB6.ListBoxItem(TriggerName(ItemX.Triggers.Item(c).TriggerType) & " " & ItemX.Triggers.Item(c).Name, ItemX.Triggers.Item(c).Index))
			Next c
		End If
	End Sub
	
	Private Sub InsertThing()
		Select Case tabItemProp.SelectedItem.Tag
			Case bdTriggers
				frmMDI.EditAdd(Me.Tag, bdEditTrigger)
			Case bdItems
				frmMDI.EditAdd(Me.Tag, bdEditItem)
		End Select
	End Sub
	
	Private Sub BestBefore(ByRef ItemX As Item)
		' [Titi 2.4.9b] automatically creates a trigger to check if the freshness of the food is over
		Dim TriggerX, TriggerY As Trigger
		Dim StmtX As Statement
		' Delete previous triggers before updating item with new ones
		For	Each TriggerX In ItemX.Triggers
			If TriggerX.Name = "Start countdown" Or VB.Left(TriggerX.Name, 11) = "Best before" Or TriggerX.Name = "Check date" Then
				ItemX.RemoveTrigger("T" & TriggerX.Index)
			End If
		Next TriggerX
		' [Titi 2.4.9b - last minute change] provide food that never spoils
		If ItemX.DamageBonus > 0 Then
			TriggerX = ItemX.AddTrigger
			TriggerX.TriggerType = bdPreTake
			TriggerX.Name = "Start countdown"
			StmtX = TriggerX.AddStatement
			' Find TriggerC In TriggerNow Named "Day"
			StmtX.Statement = 70 : StmtX.B(0) = 8 : StmtX.B(1) = 11 : StmtX.Text = "Day"
			StmtX = TriggerX.AddStatement
			' Let TriggerC.Comments = Tome.TimeDay
			StmtX.Statement = 53 : StmtX.B(0) = 25 : StmtX.B(1) = 3 : StmtX.B(3) = 0 : StmtX.B(4) = 10
			StmtX = TriggerX.AddStatement
			' Find TriggerA In TriggerNow Named "Moon"
			StmtX.Statement = 70 : StmtX.B(0) = 6 : StmtX.B(1) = 11 : StmtX.Text = "Moon"
			StmtX = TriggerX.AddStatement
			' Let TriggerA.Comments = Tome.TimeMoon
			StmtX.Statement = 53 : StmtX.B(0) = 23 : StmtX.B(1) = 3 : StmtX.B(3) = 0 : StmtX.B(4) = 11
			StmtX = TriggerX.AddStatement
			' Put ItemNow.DamageBonus / Pos.30 Into Local.IntegerA
			StmtX.Statement = 12 : StmtX.B(0) = 17 : StmtX.B(1) = 21 : StmtX.B(2) = 4 : StmtX.B(3) = 29 : StmtX.B(4) = 30 : StmtX.B(5) = 27 : StmtX.B(6) = 5
			StmtX = TriggerX.AddStatement
			' Put Local.IntegerA + TriggerA.Comments Into TriggerA.Comments
			StmtX.Statement = 12 : StmtX.B(0) = 27 : StmtX.B(1) = 5 : StmtX.B(2) = 1 : StmtX.B(3) = 23 : StmtX.B(4) = 3 : StmtX.B(5) = 23 : StmtX.B(6) = 3
			StmtX = TriggerX.AddStatement
			' Put Local.IntegerA * Pos.30 Into Local.IntegerC
			StmtX.Statement = 12 : StmtX.B(0) = 27 : StmtX.B(1) = 5 : StmtX.B(2) = 3 : StmtX.B(3) = 29 : StmtX.B(4) = 30 : StmtX.B(5) = 27 : StmtX.B(6) = 7
			StmtX = TriggerX.AddStatement
			' Put ItemNow.DamageBonus - Local.IntegerC Into Local.IntegerA
			StmtX.Statement = 12 : StmtX.B(0) = 17 : StmtX.B(1) = 21 : StmtX.B(2) = 2 : StmtX.B(3) = 27 : StmtX.B(4) = 7 : StmtX.B(5) = 27 : StmtX.B(6) = 5
			StmtX = TriggerX.AddStatement
			' Put Local.IntegerA + TriggerC.Comments Into Local.IntegerB
			StmtX.Statement = 12 : StmtX.B(0) = 27 : StmtX.B(1) = 5 : StmtX.B(2) = 1 : StmtX.B(3) = 25 : StmtX.B(4) = 3 : StmtX.B(5) = 27 : StmtX.B(6) = 6
			StmtX = TriggerX.AddStatement
			' If Local.IntegerB > Pos.30
			StmtX.Statement = 2 : StmtX.B(0) = 27 : StmtX.B(1) = 6 : StmtX.B(2) = 5 : StmtX.B(3) = 29 : StmtX.B(4) = 30
			StmtX = TriggerX.AddStatement
			' Put Local.IntegerB - Pos.30 Into Local.IntegerB
			StmtX.Statement = 12 : StmtX.B(0) = 27 : StmtX.B(1) = 6 : StmtX.B(2) = 2 : StmtX.B(3) = 29 : StmtX.B(4) = 30 : StmtX.B(5) = 27 : StmtX.B(6) = 6
			StmtX = TriggerX.AddStatement
			' Put TriggerA.Comments + Pos.1 Into TriggerA.Comments
			StmtX.Statement = 12 : StmtX.B(0) = 23 : StmtX.B(1) = 3 : StmtX.B(2) = 1 : StmtX.B(3) = 29 : StmtX.B(4) = 1 : StmtX.B(5) = 23 : StmtX.B(6) = 3
			StmtX = TriggerX.AddStatement
			' EndIf
			StmtX.Statement = 7
			StmtX = TriggerX.AddStatement
			' Let TriggerC.Comments = Local.IntegerB
			StmtX.Statement = 53 : StmtX.B(0) = 25 : StmtX.B(1) = 3 : StmtX.B(3) = 27 : StmtX.B(4) = 6
			'    Set StmtX = TriggerX.AddStatement
			TriggerY = TriggerX.AddTrigger
			TriggerY.Name = "Day"
			TriggerY = TriggerX.AddTrigger
			TriggerY.Name = "Moon"
			' So far, we've got a Pre-Take trigger which sets the day and month when the item is no more edible
			' Now, it's time to add the part which will check if the date is still valid
			TriggerX = ItemX.AddTrigger
			TriggerX.TriggerType = bdPreExamine
			TriggerX.Name = "Best before " & ItemX.DamageBonus & IIf(ItemX.DamageBonus > 1, " days", " day")
			TriggerX.Turns = 0
			StmtX = TriggerX.AddStatement
			' Find TriggerA In ItemNow Named "Start countdown"
			StmtX.Statement = 70 : StmtX.B(0) = 6 : StmtX.B(1) = 5 : StmtX.Text = "Start countdown"
			StmtX = TriggerX.AddStatement
			' Find TriggerB In TriggerA Named "Moon"
			StmtX.Statement = 70 : StmtX.B(0) = 7 : StmtX.B(1) = 12 : StmtX.Text = "Moon"
			StmtX = TriggerX.AddStatement
			' Let Local.IntegerB = TriggerB.Comments
			StmtX.Statement = 53 : StmtX.B(0) = 27 : StmtX.B(1) = 6 : StmtX.B(3) = 24 : StmtX.B(4) = 3
			StmtX = TriggerX.AddStatement
			' Find TriggerB In TriggerA Named "Moon"
			StmtX.Statement = 70 : StmtX.B(0) = 7 : StmtX.B(1) = 12 : StmtX.Text = "Day"
			StmtX = TriggerX.AddStatement
			' Let Local.IntegerA = TriggerB.Comments
			StmtX.Statement = 53 : StmtX.B(0) = 27 : StmtX.B(1) = 5 : StmtX.B(3) = 24 : StmtX.B(4) = 3
			StmtX = TriggerX.AddStatement
			' If Local.IntegerA >= Tome.TimeDay
			StmtX.Statement = 2 : StmtX.B(0) = 27 : StmtX.B(1) = 5 : StmtX.B(2) = 8 : StmtX.B(3) = 0 : StmtX.B(4) = 10
			StmtX = TriggerX.AddStatement
			' If Local.IntegerB >= Tome.TimeMoon
			StmtX.Statement = 2 : StmtX.B(0) = 27 : StmtX.B(1) = 6 : StmtX.B(2) = 8 : StmtX.B(3) = 0 : StmtX.B(4) = 11
			StmtX = TriggerX.AddStatement
			' CopyText "Rotten" Into Local.TextA
			StmtX.Statement = 22 : StmtX.B(0) = 27 : StmtX.B(1) = 9 : StmtX.Text = "Rotten"
			StmtX = TriggerX.AddStatement
			' Put Local.TextA + ItemNow.Name Into ItemNow.Name
			StmtX.Statement = 12 : StmtX.B(0) = 27 : StmtX.B(1) = 9 : StmtX.B(2) = 1 : StmtX.B(3) = 17 : StmtX.B(4) = 52 : StmtX.B(5) = 17 : StmtX.B(6) = 52
			StmtX = TriggerX.AddStatement
			' Let ItemNow.IsDamageTypeHoly = Pos.1 [This means the food is now poisonous]
			StmtX.Statement = 53 : StmtX.B(0) = 17 : StmtX.B(1) = 41 : StmtX.B(3) = 29 : StmtX.B(4) = 1
			StmtX = TriggerX.AddStatement
			' EndIf
			StmtX.Statement = 7
			StmtX = TriggerX.AddStatement
			' EndIf
			StmtX.Statement = 7
			' We also want this test to apply upon use, not only when the item is examined.
			TriggerX = ItemX.AddTrigger
			TriggerX.TriggerType = bdOnUseOnCreature
			TriggerX.Name = "Check date"
			TriggerX.Turns = 0
			StmtX = TriggerX.AddStatement
			' Find TriggerA In ItemNow Named "Check date"
			StmtX.Statement = 70 : StmtX.B(0) = 6 : StmtX.B(1) = 5 : StmtX.Text = "Check date"
			StmtX = TriggerX.AddStatement
			' CallTrigger TriggerA In ItemNow
			StmtX.Statement = 71 : StmtX.B(0) = 1 : StmtX.B(1) = 10
		End If
		' [Titi 2.4.9b] The following has for only purpose to update the tree view with the latest triggers
		Dim iNode, i As Short
		' set the current selected node (ie the item we're working on)
		For i = 1 To TreeViewX.Nodes.Count
			If TreeViewX.Nodes(i)._ObjectDefault = TreeViewX.SelectedItem._ObjectDefault Then iNode = i
		Next 
		Dim AreaX As Area
		' set the current area
		For	Each AreaX In Tome.Areas
			If frmProject.lblProjectArea.Text = "Area: " & AreaX.Name Then Exit For
		Next AreaX
		' now reload everything --> new triggers now show
		frmMDI.OpenArea(AreaX)
		TreeViewX.SelectedItem = TreeViewX.Nodes(iNode)
	End Sub
	
	Public Sub ListItems()
		Dim c As Short
		If tabItemProp.SelectedItem.Tag = bdItems Then
			lblAttached.Text = "Items of Item"
			lstThings.Items.Clear()
			For c = 1 To ItemX.Items.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object ItemX.Items(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ItemX.Items(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstThings.Items.Add(New VB6.ListBoxItem(ItemX.Items.Item(c).Name, ItemX.Items.Item(c).Index))
			Next c
		End If
	End Sub
	
	Private Sub UpdateItem()
		Dim c As Short
		ItemX.Name = txtName.Text
		ItemX.CanCombine = chkCombine.CheckState * CShort(True)
		ItemX.UseDescription = chkDescription.CheckState * CShort(True)
		ItemX.Comments = txtComments.Text
		ItemX.Value = Val(txtValue.Text)
		ItemX.Count = Val(txtCount.Text)
		ItemX.Weight = Val(txtWeight.Text)
		ItemX.Bulk = Val(txtBulk.Text)
		ItemX.Capacity = Val(txtCapacity.Text)
		ItemX.SoftCapacity = chkSoftCapacity.CheckState * CShort(True)
		ItemX.IsReady = chkIsEquipped.CheckState * CShort(True)
		For c = 3 To 7
			ItemX.KeyBit(c) = chkKey(c).CheckState * CShort(True)
		Next c
		ItemX.PictureFile = TmpPictureFile
		ItemX.Family = VB6.GetItemData(cmbFamily, cmbFamily.SelectedIndex)
		If ItemX.Family > 4 And ItemX.Family < 9 Then
			' Weapon
			ItemX.ActionPoints = Val(txtActionPoints.Text)
			ItemX.AttackBonus = Val(txtAttackBonus.Text)
			ItemX.Defense = Val(txtDefense.Text)
			ItemX.RangeType = cmbRange.SelectedIndex
			If chkTwoHanded.CheckState > 0 Then
				ItemX.WearType = 11
			Else
				ItemX.WearType = 10
			End If
			ItemX.DamageType = cmbDamageType.SelectedIndex + 1
			ItemX.Damage = cmbDamage.SelectedIndex
			ItemX.DamageBonus = Val(txtDamageBonus.Text)
			ItemX.ShootType = cmbAmmo.SelectedIndex
			ItemX.Resistance = 0
		ElseIf ItemX.Family = 4 Then 
			' Armor
			ItemX.ActionPoints = Val(txtActionPoints.Text)
			ItemX.Resistance = Val(txtArmor.Text)
			ItemX.Defense = Val(txtDefense.Text)
			ItemX.RangeType = 0
			ItemX.Damage = 0
			ItemX.WearType = cmbWearType.SelectedIndex
			ItemX.ResistanceType = cmbResistanceType.SelectedIndex
			ItemX.ResistanceBonus = cmbResistanceBonus.SelectedIndex
		Else
			' Everything Else
			ItemX.RangeType = 0
			ItemX.Damage = 0
			' [Titi 2.4.9b] For the Food family, 'Damage' is used as 'Effects' of using (eating/drinking)
			If ItemX.Family = 3 Then
				ItemX.Damage = cmbDamage.SelectedIndex ' Dice
				ItemX.DamageType = cmbFoodType.SelectedIndex + 1 ' Heal, Sickness, etc...
				ItemX.DamageBonus = Val(txtDamageBonus.Text) ' Days before being spoiled
				BestBefore(ItemX)
				InitGame()
			End If
			ItemX.Resistance = 0
			ItemX.Defense = 0
			ItemX.ActionPoints = 0
			ItemX.WearType = 10
			If ItemX.Family <> 3 Then
				ItemX.ResistanceType = 0
				ItemX.ResistanceBonus = 0
			End If
		End If
		' [Titi 2.4.9b] added size
		For c = 0 To 4
			ItemX.SizeBit(c + 4) = OptSize(c).Checked
		Next 
		ItemX.SizeBit(9) = chkAllowOtherSize.CheckState * CShort(True) ' any size can use the item
		' [Titi 2.4.9b] added examined? status
		ItemX.Examined = chkExamined.CheckState * CShort(True)
		' [Titi 2.4.9b] added min level to recognize the item
		ItemX.MinLevel = Val(txtRequiredLevel.Text)
		TreeViewX.Nodes(Me.Tag).Text = ItemX.Name
		SetDirty(False)
	End Sub
	
	Private Sub OpenPictureFile()
		On Error Resume Next
		'    dlgFile.FileName = gAppPath & "\data\graphics\items\*.bmp"
		dlgFileOpen.FileName = gDataPath & "\graphics\items\*.bmp"
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		dlgFile.CancelError = True
		dlgFileOpen.Title = "Choose picture"
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
		'UPGRADE_WARNING: CommonDialog property dlgFile.FileTitle was upgraded to dlgFile.FileName which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		TmpPictureFile = dlgFileOpen.FileName
		ShowItemPicture(TmpPictureFile)
		SetDirty(True)
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
			ShowItemPicture(TmpPictureFile)
		End If
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub ShowItemPicture(ByVal FileName As String)
		Dim Tome_Renamed As Object
		Dim X, Y As Short
		'UPGRADE_WARNING: Arrays in structure bmItem may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmItem As BITMAPINFO
		Dim hMemItem As Integer
		'UPGRADE_WARNING: Arrays in structure bmBlack may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmBlack As BITMAPINFO
		'UPGRADE_WARNING: Arrays in structure bmMask may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmMask As BITMAPINFO
		Dim rc, lpMem, TransparentRGB As Integer
		Dim PictureFile As String
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor ' Hourglass
		' Load Bitmap
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		PictureFile = Dir(Tome.LoadPath & "\" & FileName)
		If PictureFile = "" Then
			'        PictureFile = gAppPath & "\data\graphics\items\" & FileName
			PictureFile = gDataPath & "\graphics\items\" & FileName
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			PictureFile = Tome.LoadPath & "\" & FileName
		End If
		frmMDI.ShowMsg("Loading Picture " & FileName & "...")
		' Load TileSet bitmap
		ReadBitmapFile(PictureFile, bmItem, hMemItem, TransparentRGB)
		' Make a copy of the current palette for the picture
		'UPGRADE_WARNING: Couldn't resolve default property of object bmBlack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		bmBlack = bmItem
		' Then change Pure Blue to Pure Black
		ChangeColor(bmBlack, TransparentRGB, 0, 0, 0)
		' Paint bitmap to picture box using converted palette
		lpMem = GlobalLock(hMemItem)
		' Convert to Mask and copy to picMask (pure Blue is the mask color)
		MakeMask(bmItem, bmMask, TransparentRGB)
		'UPGRADE_ISSUE: PictureBox method picItem.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picItem.Cls()
		X = (picItem.ClientRectangle.Width - bmItem.bmiHeader.biWidth) / 2
		Y = (picItem.ClientRectangle.Height - bmItem.bmiHeader.biHeight) / 2
		'UPGRADE_ISSUE: PictureBox property picItem.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = SetStretchBltMode(picItem.hdc, 3)
		'UPGRADE_ISSUE: PictureBox property picItem.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchDIBits(picItem.hdc, X, Y, bmItem.bmiHeader.biWidth, bmItem.bmiHeader.biHeight, 0, 0, bmItem.bmiHeader.biWidth, bmItem.bmiHeader.biHeight, lpMem, bmMask, DIB_RGB_COLORS, SRCAND)
		'UPGRADE_ISSUE: PictureBox property picItem.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchDIBits(picItem.hdc, X, Y, bmItem.bmiHeader.biWidth, bmItem.bmiHeader.biHeight, 0, 0, bmItem.bmiHeader.biWidth, bmItem.bmiHeader.biHeight, lpMem, bmBlack, DIB_RGB_COLORS, SRCPAINT)
		picItem.Refresh()
		' Release memory
		rc = GlobalUnlock(hMemItem)
		rc = GlobalFree(hMemItem)
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default ' Default
	End Sub
	
	'UPGRADE_WARNING: Event lstThings.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstThings_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstThings.SelectedIndexChanged
		Select Case tabItemProp.SelectedItem.Tag
			Case bdTriggers
				TreeViewX.Nodes(Me.Tag & "T" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
			Case bdItems
				TreeViewX.Nodes(Me.Tag & "I" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
		End Select
	End Sub
	
	Private Sub lstThings_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstThings.DoubleClick
		EditThing()
	End Sub
	
	'UPGRADE_WARNING: Event optSize.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optSize_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optSize.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = optSize.GetIndex(eventSender)
			SetDirty(True)
		End If
	End Sub
	
	Private Sub tabItemProp_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabItemProp.ClickEvent
		Select Case tabItemProp.SelectedItem.Tag
			Case bdGeneral
				fraItemProp(0).BringToFront()
				btnLibrary.Visible = False
			Case bdForm
				fraItemProp(1).BringToFront()
				btnLibrary.Visible = False
			Case bdItems
				fraItemProp(2).BringToFront()
				btnLibrary.Visible = False
				ListItems()
			Case bdTriggers
				fraItemProp(2).BringToFront()
				btnLibrary.Visible = True
				ListTriggers()
		End Select
	End Sub
	
	'UPGRADE_WARNING: Event txtArmor.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtArmor_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtArmor.TextChanged
		Limit(Me.ActiveControl, 0, bdInt)
		SetDirty(True)
	End Sub
	
	Private Sub txtArmor_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtArmor.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdInt)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtBulk.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtBulk_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtBulk.TextChanged
		Limit(Me.ActiveControl, 0, bdInt)
		SetDirty(True)
	End Sub
	
	Private Sub txtBulk_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtBulk.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdInt)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtCapacity.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtCapacity_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCapacity.TextChanged
		Limit(Me.ActiveControl, 0, bdInt)
		SetDirty(True)
	End Sub
	
	Private Sub txtCapacity_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCapacity.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
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
	
	'UPGRADE_WARNING: Event txtCount.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtCount_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCount.TextChanged
		Limit(Me.ActiveControl, 0, bdInt)
		SetDirty(True)
	End Sub
	
	Private Sub txtCount_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCount.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdInt)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtName.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtName_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtName.TextChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtDefense.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtDefense_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDefense.TextChanged
		Limit(Me.ActiveControl, 0, bdInt)
		SetDirty(True)
	End Sub
	
	Private Sub txtDefense_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDefense.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdInt)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtAttackBonus.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtAttackBonus_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAttackBonus.TextChanged
		Limit(Me.ActiveControl, 0, bdInt)
		SetDirty(True)
	End Sub
	
	Private Sub txtAttackBonus_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtAttackBonus.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdInt)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtDamageBonus.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtDamageBonus_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDamageBonus.TextChanged
		Limit(Me.ActiveControl, 0, bdInt)
		SetDirty(True)
	End Sub
	
	Private Sub txtDamageBonus_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDamageBonus.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdInt)
		' [Titi 2.4.9b] limit the bonus (or days before spoiling of food) to 999
		If Len(Me.ActiveControl) = 3 Then KeyAscii = 0
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtRequiredLevel.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtRequiredLevel_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRequiredLevel.TextChanged
		Limit(Me.ActiveControl, 0, bdInt)
		SetDirty(True)
	End Sub
	
	Private Sub txtRequiredLevel_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtRequiredLevel.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdInt)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtValue.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtValue_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtValue.TextChanged
		Limit(Me.ActiveControl, 0, bdInt)
		SetDirty(True)
	End Sub
	
	Private Sub txtValue_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtValue.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdInt)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtActionPoints.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtActionPoints_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtActionPoints.TextChanged
		Limit(Me.ActiveControl, 0, bdInt)
		SetDirty(True)
	End Sub
	
	Private Sub txtActionPoints_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtActionPoints.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdInt)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtWeight.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtWeight_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWeight.TextChanged
		Limit(Me.ActiveControl, 0, bdInt)
		SetDirty(True)
	End Sub
	
	Private Sub txtWeight_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtWeight.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdInt)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
End Class