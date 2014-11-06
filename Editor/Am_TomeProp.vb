Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmTome
	Inherits System.Windows.Forms.Form
	Dim TreeViewX As AxComctlLib.AxTreeView
	Dim TomeX As Tome
	Dim Dirty As Short
	Const bdGeneral As Short = 1
	Const bdParty As Short = 2
	Const bdJournal As Short = 3
	Const bdFactoid As Short = 4
	Const bdTrigger As Short = 5
	Const bdArea As Short = 6
	
	Private Sub CopyThing()
		If lstThings.SelectedIndex > -1 Then
			Select Case tabTomeProp.SelectedItem.Tag
				Case bdTrigger
					frmMDI.EditCopy(Me.Tag & "TriggersT" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdParty
					frmMDI.EditCopy(Me.Tag & "PartyX" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdJournal
					frmMDI.EditCopy(Me.Tag & "JournalsJ" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdFactoid
					frmMDI.EditCopy(Me.Tag & "FactoidsF" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdArea
					frmMDI.EditCopy(Me.Tag & "AreasA" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
			btnPaste.Enabled = True
		End If
	End Sub
	
	Private Sub CutThing()
		If lstThings.SelectedIndex > -1 Then
			SetDirty(True)
			Select Case tabTomeProp.SelectedItem.Tag
				Case bdTrigger
					'                frmMDI.EditCut Me.Tag & "T" & lstThings.ItemData(lstThings.ListIndex)
					frmMDI.EditCut(Me.Tag & "TriggersT" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdParty
					'                frmMDI.EditCut Me.Tag & "X" & lstThings.ItemData(lstThings.ListIndex)
					frmMDI.EditCut(Me.Tag & "PartyX" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdJournal
					'                frmMDI.EditCut Me.Tag & "J" & lstThings.ItemData(lstThings.ListIndex)
					frmMDI.EditCut(Me.Tag & "JournalsJ" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdFactoid
					'                frmMDI.EditCut Me.Tag & "F" & lstThings.ItemData(lstThings.ListIndex)
					frmMDI.EditCut(Me.Tag & "FactoidsF" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdArea
					' [Titi 2.4.9] set the treeview
					frmMDI.SetupMenu((frmProject.TomeList), (frmProject.tvwTome), frmProject.tvwTome.SelectedItem.Tag)
					frmMDI.EditCut(Me.Tag & "AreasA" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
			btnPaste.Enabled = True ' [Titi 2.4.9]
			tabTomeProp_ClickEvent(tabTomeProp, New System.EventArgs())
		End If
	End Sub
	
	Private Sub DeleteThing()
		' [Titi 2.4.9] same modifications as in CutThing()
		If lstThings.SelectedIndex > -1 Then
			SetDirty(True)
			Select Case tabTomeProp.SelectedItem.Tag
				Case bdTrigger
					frmMDI.EditDelete(Me.Tag & "TriggersT" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdParty
					frmMDI.EditDelete(Me.Tag & "PartyX" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdJournal
					frmMDI.EditDelete(Me.Tag & "JournalsJ" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdFactoid
					frmMDI.EditDelete(Me.Tag & "FactoidsF" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdArea
					frmMDI.SetupMenu((frmProject.TomeList), (frmProject.tvwTome), frmProject.tvwTome.SelectedItem.Tag)
					frmMDI.EditDelete(Me.Tag & "AreasA" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
			tabTomeProp_ClickEvent(tabTomeProp, New System.EventArgs())
		End If
	End Sub
	
	Private Sub UpdateTome()
		TomeX.Name = txtName.Text
		TomeX.OnAdventure = chkOnAdventure.CheckState * CShort(True)
		TomeX.IsPersistent = chkIsPersistent.CheckState * CShort(True)
		TomeX.Comments = txtComments.Text
		If cmbAreas.SelectedIndex > -1 Then
			TomeX.AreaIndex = VB6.GetItemData(cmbAreas, cmbAreas.SelectedIndex)
		End If
		If cmbMaps.SelectedIndex > -1 Then
			TomeX.MapIndex = VB6.GetItemData(cmbMaps, cmbMaps.SelectedIndex)
		End If
		If cmbEntryPoints.SelectedIndex > -1 Then
			TomeX.EntryIndex = VB6.GetItemData(cmbEntryPoints, cmbEntryPoints.SelectedIndex)
		End If
		TomeX.MapX = Val(txtAtX.Text)
		TomeX.MapY = Val(txtAtY.Text)
		TomeX.PartySize = Val(txtPartySize.Text)
		TomeX.PartyAvgLevel = Val(txtPartyAvgLevel.Text)
		TomeX.Turn = Val(txtTurn.Text)
		TomeX.Cycle = Val(txtCycle.Text)
		TomeX.Moon = Val(txtMoon.Text)
		TomeX.Year_Renamed = Val(txtYear.Text)
		' Show Name in TreeView
		frmProject.lblProjectTome.Text = "Tome: " & TomeX.Name
		TreeViewX.Nodes(Me.Tag).Text = TomeX.Name
		SetDirty(False)
	End Sub
	
	Public Sub ShowTome(ByRef InTree As AxComctlLib.AxTreeView, ByRef InTome As Tome)
		Dim OldDirt, tmpDirty As Short
		tmpDirty = Dirty ' [Titi 2.4.9a]
		OldDirt = frmMDI.Dirty
		TreeViewX = InTree
		TomeX = InTome
		txtName.Text = TomeX.Name
		chkOnAdventure.CheckState = TomeX.OnAdventure * CShort(True)
		chkIsPersistent.CheckState = TomeX.IsPersistent * CShort(True)
		txtComments.Text = TomeX.Comments
		txtAtX.Text = CStr(TomeX.MapX)
		txtAtY.Text = CStr(TomeX.MapY)
		txtPartySize.Text = CStr(TomeX.PartySize)
		txtPartyAvgLevel.Text = CStr(TomeX.PartyAvgLevel)
		txtTurn.Text = CStr(TomeX.Turn)
		txtCycle.Text = CStr(TomeX.Cycle)
		txtMoon.Text = CStr(TomeX.Moon)
		txtYear.Text = CStr(TomeX.Year_Renamed)
		ListAreas()
		frmMDI.SetupMenu((frmProject.TomeList), (frmProject.tvwTome), frmProject.tvwTome.SelectedItem.Tag)
		frmMDI.Dirty = OldDirt
		Dirty = tmpDirty ' [Titi 2.4.9a] when loading, the form will not set Dirty
		btnApply.Enabled = Dirty
	End Sub
	
	Private Sub SetDirty(ByRef Flag As Short)
		btnApply.Enabled = Flag
		Dirty = Flag
		If Dirty = True Then
			frmMDI.Dirty = True
		End If
	End Sub
	
	Private Sub btnApply_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnApply.Click
		UpdateTome()
	End Sub
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		Me.Close()
	End Sub
	
	Private Sub btnCopy_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCopy.Click
		' [Titi 2.4.9] added
		CopyThing()
	End Sub
	
	Private Sub btnCut_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCut.Click
		' [Titi 2.4.9] added
		CutThing()
	End Sub
	
	Private Sub btnDelete_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnDelete.Click
		' [Titi 2.4.9] added
		DeleteThing()
	End Sub
	
	Private Sub btnEdit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnEdit.Click
		EditThing()
	End Sub
	
	Private Sub btnInsert_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnInsert.Click
		InsertThing()
	End Sub
	
	Private Sub btnOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOk.Click
		UpdateTome()
		Me.Close()
	End Sub
	
	Public Sub ListJournals()
		Dim c As Short
		If tabTomeProp.SelectedItem.Tag = bdJournal Then
			lblAttached.Text = "Journals for Tome"
			lstThings.Items.Clear()
			For c = 1 To TomeX.Journals.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Journals(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Journals(c).Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstThings.Items.Add(New VB6.ListBoxItem(TomeX.Journals.Item(c).Text, TomeX.Journals.Item(c).Index))
			Next c
			' [Titi 2.4.9]
			If c > 1 Then
				btnEdit.Enabled = True
				btnCut.Enabled = True
				btnDelete.Enabled = True
				btnCopy.Enabled = True
				lstThings.SetSelected(c - 2, True)
			End If
		End If
	End Sub
	
	Public Sub ListFactoids()
		Dim c As Short
		If tabTomeProp.SelectedItem.Tag = bdFactoid Then
			lblAttached.Text = "Factoids for Tome"
			lstThings.Items.Clear()
			For c = 1 To TomeX.Factoids.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Factoids(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Factoids(c).Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstThings.Items.Add(New VB6.ListBoxItem(TomeX.Factoids.Item(c).Text, TomeX.Factoids.Item(c).Index))
			Next c
			' [Titi 2.4.9]
			If c > 1 Then
				btnEdit.Enabled = True
				btnCut.Enabled = True
				btnDelete.Enabled = True
				btnCopy.Enabled = True
				lstThings.SetSelected(c - 2, True)
			End If
		End If
	End Sub
	
	Public Sub ListCreatures()
		Dim c As Short
		If tabTomeProp.SelectedItem.Tag = bdParty Then
			lblAttached.Text = "Party Members for Tome"
			lstThings.Items.Clear()
			For c = 1 To TomeX.Creatures.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Creatures(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Creatures(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstThings.Items.Add(New VB6.ListBoxItem(TomeX.Creatures.Item(c).Name, TomeX.Creatures.Item(c).Index))
			Next c
			' [Titi 2.4.9]
			If c > 1 Then
				btnEdit.Enabled = True
				btnCut.Enabled = True
				btnDelete.Enabled = True
				btnCopy.Enabled = True
				lstThings.SetSelected(c - 2, True)
			End If
		End If
	End Sub
	
	Public Sub ListTriggers()
		Dim c As Short
		If tabTomeProp.SelectedItem.Tag = bdTrigger Then
			lblAttached.Text = "Party Triggers for Tome"
			lstThings.Items.Clear()
			For c = 1 To TomeX.Triggers.Count()
				'            lstThings.AddItem TriggerName(TomeX.Triggers(c).TriggerType)
				' [Titi 2.4.9] show also trigger name
				'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Triggers(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Triggers(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Triggers().TriggerType. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstThings.Items.Add(New VB6.ListBoxItem(TriggerName(TomeX.Triggers.Item(c).TriggerType) & " " & Chr(34) & TomeX.Triggers.Item(c).Name & Chr(34), TomeX.Triggers.Item(c).Index))
			Next c
			' [Titi 2.4.9]
			If c > 1 Then
				btnEdit.Enabled = True
				btnCut.Enabled = True
				btnDelete.Enabled = True
				btnCopy.Enabled = True
				lstThings.SetSelected(c - 2, True)
			End If
		End If
	End Sub
	
	Public Sub ListAreas()
		Dim c As Short
		cmbAreas.Items.Clear()
		For c = 1 To TomeX.Areas.Count()
			'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Areas(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Areas(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cmbAreas.Items.Add(New VB6.ListBoxItem(TomeX.Areas.Item(c).Name, TomeX.Areas.Item(c).Index))
			'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Areas(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If TomeX.AreaIndex = TomeX.Areas.Item(c).Index Then
				cmbAreas.SelectedIndex = c - 1
			End If
		Next c
		cmbAreas_SelectedIndexChanged(cmbAreas, New System.EventArgs())
		If tabTomeProp.SelectedItem.Tag = bdArea Then
			lblAttached.Text = "Areas for Tome:"
			lstThings.Items.Clear()
			For c = 1 To TomeX.Areas.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Areas().Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lstThings.Items.Add(TomeX.Areas.Item(c).Name)
				'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Areas().Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: ListBox property lstThings.NewIndex was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
				VB6.SetItemData(lstThings, lstThings.NewIndex, TomeX.Areas.Item(c).Index)
			Next c
			' [Titi 2.4.9]
			If c > 1 Then
				btnEdit.Enabled = True
				btnCut.Enabled = True
				btnDelete.Enabled = True
				btnCopy.Enabled = True
				lstThings.SetSelected(c - 2, True)
			End If
		End If
	End Sub
	
	Private Sub InsertThing()
		SetDirty(True)
		Select Case tabTomeProp.SelectedItem.Tag
			Case bdTrigger
				frmMDI.EditAdd(Me.Tag & "Triggers", bdEditTrigger)
			Case bdParty
				frmMDI.EditAdd(Me.Tag & "Party", bdEditCreature)
			Case bdJournal
				frmMDI.EditAdd(Me.Tag & "Journals", bdEditJournal)
			Case bdFactoid
				frmMDI.EditAdd(Me.Tag & "Factoids", bdEditFactoid)
			Case bdArea
				frmMDI.EditAdd(Me.Tag & "Areas", bdEditArea)
		End Select
		tabTomeProp_ClickEvent(tabTomeProp, New System.EventArgs())
	End Sub
	
	Private Sub EditThing()
		Dim c As Short
		If lstThings.SelectedIndex > -1 Then
			Select Case tabTomeProp.SelectedItem.Tag
				Case bdTrigger
					frmMDI.EditProperties(Me.Tag & "TriggersT" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdParty
					frmMDI.EditProperties(Me.Tag & "PartyX" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdJournal
					'                frmMDI.EditProperties Me.Tag & "JournalF" & lstThings.ItemData(lstThings.ListIndex) <-- [Titi 2.4.9] F is the key for factoids, not journal entries
					frmMDI.EditProperties(Me.Tag & "JournalJ" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
					' [Titi 2.4.9] added factoids and areas cases
				Case bdFactoid
					frmMDI.EditProperties(Me.Tag & "FactoidsF" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdArea
					cmbAreas.Items.Clear()
					For c = 1 To TomeX.Areas.Count()
						'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Areas(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Areas(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						cmbAreas.Items.Add(New VB6.ListBoxItem(TomeX.Areas.Item(c).Name, TomeX.Areas.Item(c).Index))
						'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Areas(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If VB6.GetItemData(lstThings, lstThings.SelectedIndex) = TomeX.Areas.Item(c).Index Then
							cmbAreas.SelectedIndex = c - 1
						End If
					Next c
					cmbAreas_SelectedIndexChanged(cmbAreas, New System.EventArgs())
					frmMDI.EditProperties(Me.Tag & "AreasA" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
		End If
	End Sub
	
	Private Sub PasteThing()
		frmMDI.TreeViewX = frmProject.tvwTome.GetOcx
		Select Case tabTomeProp.SelectedItem.Tag
			Case bdTrigger
				If frmMDI.BufferType = bdEditTrigger Then
					frmMDI.EditPaste(Me.Tag & "Triggers")
				End If
			Case bdParty
				If frmMDI.BufferType = bdEditCreature Then
					frmMDI.EditPaste(Me.Tag & "Party")
				End If
			Case bdJournal
				If frmMDI.BufferType = bdEditJournal Then
					frmMDI.EditPaste(Me.Tag & "Journals")
				End If
				' [Titi 2.4.9] added factoids and areas cases
			Case bdFactoid
				If frmMDI.BufferType = bdEditFactoid Then
					frmMDI.EditPaste(Me.Tag & "Factoids")
				End If
			Case bdArea
				If frmMDI.BufferType = bdEditArea Then
					frmMDI.EditPaste(Me.Tag & "Areas")
				End If
		End Select
		btnPaste.Enabled = False
		tabTomeProp_ClickEvent(tabTomeProp, New System.EventArgs())
	End Sub
	
	Private Sub btnPaste_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnPaste.Click
		' [Titi 2.4.9] added
		PasteThing()
	End Sub
	
	Private Sub chkCamp_Click()
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkIsPersistent.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkIsPersistent_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkIsPersistent.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event chkOnAdventure.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkOnAdventure_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkOnAdventure.CheckStateChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbAreas.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbAreas_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbAreas.SelectedIndexChanged
		Dim c As Short
		Dim AreaX As Area
		If cmbAreas.SelectedIndex > -1 Then
			AreaX = TomeX.Areas.Item("A" & VB6.GetItemData(cmbAreas, cmbAreas.SelectedIndex))
			frmMDI.OpenArea(AreaX)
			cmbMaps.Items.Clear()
			For c = 1 To AreaX.Plot.Maps.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object AreaX.Plot.Maps(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object AreaX.Plot.Maps(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				cmbMaps.Items.Add(New VB6.ListBoxItem(AreaX.Plot.Maps.Item(c).Name, AreaX.Plot.Maps.Item(c).Index))
				'UPGRADE_WARNING: Couldn't resolve default property of object AreaX.Plot.Maps(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If TomeX.MapIndex = AreaX.Plot.Maps.Item(c).Index Then
					cmbMaps.SelectedIndex = c - 1
				End If
			Next c
			cmbMaps_SelectedIndexChanged(cmbMaps, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmbMaps.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbMaps_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbMaps.SelectedIndexChanged
		Dim c As Short
		Dim MapX As Map
		If cmbMaps.SelectedIndex > -1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object TomeX.Areas().Plot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			MapX = TomeX.Areas.Item("A" & VB6.GetItemData(cmbAreas, cmbAreas.SelectedIndex)).Plot.Maps("M" & VB6.GetItemData(cmbMaps, cmbMaps.SelectedIndex))
			cmbEntryPoints.Items.Clear()
			For c = 1 To MapX.EntryPoints.Count()
				'UPGRADE_WARNING: Couldn't resolve default property of object MapX.EntryPoints(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object MapX.EntryPoints(c).MapY. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object MapX.EntryPoints(c).MapX. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object MapX.EntryPoints(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				cmbEntryPoints.Items.Add(New VB6.ListBoxItem(MapX.EntryPoints.Item(c).Name & " (" & MapX.EntryPoints.Item(c).MapX & "," & MapX.EntryPoints.Item(c).MapY & ")", MapX.EntryPoints.Item(c).Index))
				'UPGRADE_WARNING: Couldn't resolve default property of object MapX.EntryPoints(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If TomeX.EntryIndex = MapX.EntryPoints.Item(c).Index Then
					cmbEntryPoints.SelectedIndex = c - 1
				End If
			Next c
		End If
	End Sub
	
	Private Sub btnLibrary_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnLibrary.Click
		If btnLibrary.Visible = True Then
			frmMDI.ObjectListX = frmProject.TomeList
			frmMDI.TreeViewX = frmProject.tvwTome.GetOcx
			Select Case Mid(btnLibrary.Text, 8, 4)
				Case "area"
					frmMDI.EditLoad(Me.Tag & "Areas", bdEditArea)
				Case "crea"
					frmMDI.EditLoad(Me.Tag & "Party", bdEditCreature)
				Case "trig"
					frmMDI.EditLoad(Me.Tag & "Triggers", bdEditTrigger)
			End Select
		End If
	End Sub
	
	'UPGRADE_WARNING: Form event frmTome.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmTome_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		' [Titi 2.6.0] Make sure we're still working with the relevant treeview and objectlist
		If VB.Left(Me.Tag, 4) = "Tome" Then
			frmMDI.TreeViewX = frmProject.tvwTome.GetOcx
			frmMDI.ObjectListX = frmProject.TomeList
		Else
			frmMDI.TreeViewX = frmProject.tvwProject.GetOcx
			frmMDI.ObjectListX = frmProject.AreaList
		End If
	End Sub
	
	Private Sub frmTome_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Dim c As Short
		' [Titi 2.4.9a]
		If Dirty Then
			c = MsgBox("Changes will be lost! Save first?", MsgBoxStyle.YesNo, "Changes not saved!")
			If c = MsgBoxResult.Yes Then btnOk_Click(btnOk, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event lstThings.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstThings_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstThings.SelectedIndexChanged
		Select Case tabTomeProp.SelectedItem.Tag
			Case bdTrigger
				TreeViewX.Nodes(Me.Tag & "TriggersT" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
			Case bdParty
				TreeViewX.Nodes(Me.Tag & "PartyX" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
			Case bdJournal
				TreeViewX.Nodes(Me.Tag & "JournalsJ" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
			Case bdFactoid
				TreeViewX.Nodes(Me.Tag & "FactoidsF" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
			Case bdArea
				TreeViewX.Nodes(Me.Tag & "AreasA" & VB6.GetItemData(lstThings, lstThings.SelectedIndex)).Selected = True
		End Select
	End Sub
	
	Private Sub lstThings_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstThings.DoubleClick
		EditThing()
	End Sub
	
	Private Sub tabTomeProp_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabTomeProp.ClickEvent
		' [Titi 2.4.9] added the button enable/disable part
		btnEdit.Enabled = False
		btnCut.Enabled = False
		btnDelete.Enabled = False
		btnCopy.Enabled = False
		Select Case tabTomeProp.SelectedItem.Tag
			Case bdGeneral
				fraTome(0).BringToFront()
			Case bdParty
				fraTome(1).BringToFront()
				btnLibrary.Text = "Insert creature from library"
				btnLibrary.Visible = True
				ListCreatures()
			Case bdJournal
				fraTome(1).BringToFront()
				btnLibrary.Visible = False
				ListJournals()
			Case bdFactoid
				fraTome(1).BringToFront()
				btnLibrary.Visible = False
				ListFactoids()
			Case bdTrigger
				fraTome(1).BringToFront()
				btnLibrary.Text = "Insert trigger from library"
				btnLibrary.Visible = True
				ListTriggers()
			Case bdArea
				fraTome(1).BringToFront()
				btnLibrary.Text = "Insert area from library"
				btnLibrary.Visible = True
				ListAreas()
		End Select
	End Sub
	
	'UPGRADE_WARNING: Event txtAtX.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtAtX_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAtX.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	Private Sub txtAtX_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtAtX.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		SetDirty(True)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtAtY.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtAtY_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAtY.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	Private Sub txtAtY_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtAtY.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtComments.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtComments_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtComments.TextChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtCycle.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtCycle_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCycle.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	Private Sub txtCycle_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCycle.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtPartyAvgLevel.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtPartyAvgLevel_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPartyAvgLevel.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	Private Sub txtPartyAvgLevel_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtPartyAvgLevel.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtPartySize.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtPartySize_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPartySize.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	Private Sub txtPartySize_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtPartySize.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtMoon.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtMoon_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMoon.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	Private Sub txtMoon_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMoon.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtName.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtName_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtName.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtTurn.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtTurn_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTurn.TextChanged
		Limit(Me.ActiveControl, 0, bdByte)
		SetDirty(True)
	End Sub
	
	Private Sub txtTurn_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTurn.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdByte)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtYear.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtYear_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtYear.TextChanged
		Limit(Me.ActiveControl, 0, bdInt)
		SetDirty(True)
	End Sub
	
	Private Sub txtYear_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtYear.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Limit(Me.ActiveControl, KeyAscii, bdInt)
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
End Class