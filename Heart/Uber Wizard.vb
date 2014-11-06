Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frmUberWizard
	Inherits System.Windows.Forms.Form
	
	Public UberWiz As UberWizard
	Dim UberIndex As Short
	Dim LibLen As Short
	
	Const UberMax As Short = 9
	
	Private Sub BuildTome()
		Dim k, c, i, j As Short
		Dim TimeFrag, TotalTime As Double
		Dim MapSketchX As MapSketch
		Dim ThemeSketchX As ThemeSketch
		Dim TomeSketchX As TomeSketch
		Dim TomeX As Tome
		Dim AreaX As Area
		Dim PlotX As Plot
		Dim MapX As Map
		Dim EncounterX As Encounter
		Dim EntryPointX As EntryPoint
		Dim ThemeX As Theme
		Dim CreatureX As Creature
		Dim ItemX As Item
		Dim TriggerX As Trigger
		Dim JournalX, FactoidX As Factoid
		Dim CreatureZ As Creature
		Dim ItemZ As Item
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		' Configure new Tome
		Tome = New Tome
		TomeX = Tome
		TomeX.Name = UberWiz.TomeName
		TomeX.Comments = UberWiz.TomeComments
		TomeX.AreaIndex = UberWiz.AreaIndex
		TomeX.MapIndex = UberWiz.MapIndex
		TomeX.EntryIndex = UberWiz.EntryIndex
		' Set up real number in Party based on selected rage
		Select Case UberWiz.TomePartySize
			Case 0
				TomeX.PartySize = 1
			Case 1
				TomeX.PartySize = 3
			Case 2
				TomeX.PartySize = 6
			Case 3
				TomeX.PartySize = 9
		End Select
		'    TomeX.PartySize = 9
		' Set up real average level based on selected average level
		Select Case UberWiz.TomePartyAvgLevel
			Case 0
				TomeX.PartyAvgLevel = 2
			Case 1
				TomeX.PartyAvgLevel = 5
			Case 2
				TomeX.PartyAvgLevel = 9
			Case 3
				TomeX.PartyAvgLevel = 12
		End Select
		UberWiz.MainMap.PartySize = UberWiz.TomePartySize
		UberWiz.MainMap.PartyAvgLevel = UberWiz.TomePartyAvgLevel
		' Copy Tome Creatures, Triggers, Journals and Factoids (if have them)
		If UberWiz.MainMap.TomeIndex > 0 Then
			TomeSketchX = UberWiz.TomeSketchs.Item("T" & UberWiz.MainMap.TomeIndex)
			For	Each CreatureX In TomeSketchX.Creatures
				TomeX.AddCreature.Copy(CreatureX)
			Next CreatureX
			For	Each TriggerX In TomeSketchX.Triggers
				TomeX.AddTrigger.Copy(TriggerX)
			Next TriggerX
			For	Each JournalX In TomeSketchX.Journals
				'UPGRADE_WARNING: Couldn't resolve default property of object JournalX. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				TomeX.AddJournal.Copy(JournalX)
			Next JournalX
			For	Each FactoidX In TomeSketchX.Factoids
				TomeX.AddFactoid.Copy(FactoidX)
			Next FactoidX
		End If
		' Connect Maps
		lblBuildTome.Text = "Redefining Linear Spline Data...."
		TotalTime = 0
		ShowComplete(TotalTime)
		modDungeonMaker.UberWizConnectMap(UberWiz, (UberWiz.MainMap), (UberWiz.TotalSize), 0, 0)
		' Loop and estimate time
		c = 1
		For	Each MapSketchX In UberWiz.MapSketchs
			If MapSketchX.IsUsed = True Then
				c = c + 2
			End If
		Next MapSketchX
		TimeFrag = (100 / c)
		' Copy Major Theme, Quest Themes, Creatures and Items
		lblBuildTome.Text = "Scattering Quests...."
		modDungeonMaker.UberWizScatterQuests(UberWiz)
		lblBuildTome.Refresh()
		TotalTime = TotalTime + TimeFrag
		ShowComplete(TotalTime)
		' Make Maps
		AreaX = TomeX.AddArea
		For	Each MapSketchX In UberWiz.MapSketchs
			If MapSketchX.IsUsed = True Then
				lblBuildTome.Text = "Constructing " & MapSketchX.MapName & "...."
				lblBuildTome.Refresh()
				TotalTime = TotalTime + TimeFrag
				ShowComplete(TotalTime)
				modDungeonMaker.UberWizMakeMap(UberWiz, MapSketchX, AreaX)
			End If
		Next MapSketchX
		' Fill Maps
		For	Each MapX In AreaX.Plot.Maps
			lblBuildTome.Text = "Filling " & MapX.Name & "...."
			lblBuildTome.Refresh()
			TotalTime = TotalTime + TimeFrag
			ShowComplete(TotalTime)
			modDungeonMaker.FillMap(MapX)
		Next MapX
		frmMDI.ShowTome(Tome)
		lblBuildTome.Text = "All done!"
		lblBuildTome.Refresh()
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		frmMDI.Dirty = True
	End Sub
	
	Private Sub ShowComplete(ByRef AsPercent As Double)
		shpTomeComplete.Width = VB6.TwipsToPixelsX(Greatest(Least(3160 * (AsPercent / 100), 3160), 0))
		shpTomeComplete.Refresh()
	End Sub
	
	Private Sub ShowNextMap(ByRef Index As Short)
		'UPGRADE_WARNING: Couldn't resolve default property of object UberWiz.MapSketchs().MapComments. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtNextMap.Text = UberWiz.MapSketchs.Item("M" & Index).MapComments
		If Len(txtNextMap.Text) < 1 Then
			txtNextMap.Text = "No map comments available."
		End If
	End Sub
	
	Private Sub ShowMainMap(ByRef Index As Short)
		Dim MapSketchX As MapSketch
		MapSketchX = UberWiz.MapSketchs.Item("M" & Index)
		txtMapSet.Text = MapSketchX.MapComments
		If MapSketchX.TomeIndex > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object UberWiz.TomeSketchs().PartySize. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lblMaxInParty.Text = "Maximum in Party: " & UberWiz.TomeSketchs.Item("T" & MapSketchX.TomeIndex).PartySize
			'UPGRADE_WARNING: Couldn't resolve default property of object UberWiz.TomeSketchs().PartyAvgLevel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lblAvgLevel.Text = "with Average Level: " & UberWiz.TomeSketchs.Item("T" & MapSketchX.TomeIndex).PartyAvgLevel
		Else
			lblMaxInParty.Text = ""
			lblAvgLevel.Text = ""
		End If
		If Len(txtMapSet.Text) < 1 Then
			txtMapSet.Text = "No map comments available."
		End If
	End Sub
	
	Private Sub ShowTheme(ByRef Index As Short)
		'UPGRADE_WARNING: Couldn't resolve default property of object UberWiz.ThemeSketchs().Comments. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtThemes.Text = UberWiz.ThemeSketchs.Item("R" & Index).Comments
		If Len(txtThemes.Text) < 1 Then
			txtThemes.Text = "No theme comments available."
		End If
	End Sub
	
	Private Sub ShowStoryTheme(ByRef Index As Short)
		'UPGRADE_WARNING: Couldn't resolve default property of object UberWiz.ThemeSketchs().Comments. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtStoryTheme.Text = UberWiz.ThemeSketchs.Item("R" & Index).Comments
		If Len(txtStoryTheme.Text) < 1 Then
			txtStoryTheme.Text = "No theme comments available."
		End If
	End Sub
	
	Private Sub ShowCreature(ByRef Index As Short)
		'UPGRADE_WARNING: Couldn't resolve default property of object UberWiz.Creatures().Comments. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtCreatures.Text = UberWiz.Creatures.Item("X" & Index).Comments
		If Len(txtCreatures.Text) < 1 Then
			txtCreatures.Text = "No Creature comments available."
		End If
	End Sub
	
	Private Sub ShowItem(ByRef Index As Short)
		'UPGRADE_WARNING: Couldn't resolve default property of object UberWiz.Items().Comments. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtItems.Text = UberWiz.Items.Item("I" & Index).Comments
		If Len(txtItems.Text) < 1 Then
			txtItems.Text = "No Item comments available."
		End If
	End Sub
	
	Public Sub InitGame()
		Dim fReadValue As Object
		UberIndex = -1
		Dim tmp As String
		Dim lResult As Integer
		'UPGRADE_WARNING: Couldn't resolve default property of object fReadValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lResult = fReadValue(gAppPath & "\Settings.ini", "Creator", "WizardStartup", "S", "True", tmp)
		If UCase(tmp) = "TRUE" Then
			chkStartup.CheckState = System.Windows.Forms.CheckState.Checked
		End If
		optFirstChoice(2).Checked = True
		MoveThruWizard(1)
		'    LibLen = Len(gAppPath & "\library\") + 1
		LibLen = Len(gLibPath) + 1
		' Party Size
		cmbPartySize.Items.Add(New VB6.ListBoxItem("Solo", 0))
		cmbPartySize.Items.Add(New VB6.ListBoxItem("1-3", 1))
		cmbPartySize.Items.Add(New VB6.ListBoxItem("4-6", 2))
		cmbPartySize.Items.Add(New VB6.ListBoxItem("7-9", 3))
		' Party Avg Level
		cmbPartyAvgLevel.Items.Add(New VB6.ListBoxItem("1-3", 0))
		cmbPartyAvgLevel.Items.Add(New VB6.ListBoxItem("4-6", 1))
		cmbPartyAvgLevel.Items.Add(New VB6.ListBoxItem("7-10", 2))
		cmbPartyAvgLevel.Items.Add(New VB6.ListBoxItem("10+", 3))
		' [Titi 2.6.0] camping options
		Dim c As Short
		cmbInterval.Items.Clear()
		cmbInterval.Items.Add("No interval")
		For c = 10 To 200 Step 10
			cmbInterval.Items.Add(c & " turns")
		Next 
		cmbFrequency.Items.Clear()
		cmbFrequency.Items.Add("No monsters")
		cmbFrequency.Items.Add("1%")
		cmbFrequency.Items.Add("5%")
		cmbFrequency.Items.Add("10%")
		cmbFrequency.Items.Add("20%")
		cmbFrequency.Items.Add("25%")
		cmbFrequency.Items.Add("33%")
		cmbFrequency.Items.Add("50%")
		cmbFrequency.Items.Add("67%")
		cmbFrequency.Items.Add("75%")
		cmbFrequency.Items.Add("100%")
	End Sub
	
	Private Sub InitUberWiz()
		Dim ClipPath As Object
		Dim c, i As Short
		Dim TomeX As Tome
		Dim AreaX As Area
		Dim MapX As Map
		Dim ThemeX As Theme
		Dim EncounterX As Encounter
		Dim CreatureX As Creature
		Dim ItemX As Item
		Dim TomeSketchX As TomeSketch
		Dim MapSketchX As MapSketch
		Dim ThemeSketchX As ThemeSketch
		Dim EntryPointX As EntryPoint
		' Que up all possible Tomes and corresponding Maps
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		fraPause.BringToFront()
		Me.Refresh()
		UberWiz = New UberWizard
		' Load Tomes and Maps
		ShowMessage("Scanning Library Maps....")
		modDungeonMaker.InitUberWizMaps(UberWiz)
		' List Maps
		cmbMapSet.Items.Clear()
		cmbMapSet.Items.Add("<All>")
		For	Each MapSketchX In UberWiz.MapSketchs
			If MapSketchX.IsMainMap = True Then
				' Put in the combo box (if not already there)
				For c = 0 To cmbMapSet.Items.Count
					'UPGRADE_WARNING: Couldn't resolve default property of object ClipPath(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If VB6.GetItemString(cmbMapSet, c) = Mid(ClipPath(MapSketchX.FullPath), LibLen) Then
						Exit For
					End If
				Next c
				If c > cmbMapSet.Items.Count Then
					'UPGRADE_WARNING: Couldn't resolve default property of object ClipPath(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cmbMapSet.Items.Add(Mid(ClipPath(MapSketchX.FullPath), LibLen))
				End If
			End If
		Next MapSketchX
		' Load up Themes
		ShowMessage("Scanning Library Themes....")
		modDungeonMaker.InitUberWizThemes(UberWiz)
		' List Themes
		cmbThemes.Items.Clear()
		cmbThemes.Items.Add("<All>")
		cmbStoryThemes.Items.Clear()
		cmbStoryThemes.Items.Add("<All>")
		For	Each ThemeSketchX In UberWiz.ThemeSketchs
			' Put in the combo box (if not already there)
			If ThemeSketchX.IsMajorTheme = False And ThemeSketchX.IsQuest = False Then
				For i = 0 To cmbThemes.Items.Count
					'UPGRADE_WARNING: Couldn't resolve default property of object ClipPath(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If VB6.GetItemString(cmbThemes, i) = Mid(ClipPath(ThemeSketchX.FullPath), LibLen) Then
						Exit For
					End If
				Next i
				If i > cmbThemes.Items.Count Then
					'UPGRADE_WARNING: Couldn't resolve default property of object ClipPath(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cmbThemes.Items.Add(Mid(ClipPath(ThemeSketchX.FullPath), LibLen))
				End If
			Else
				For i = 0 To cmbStoryThemes.Items.Count
					'UPGRADE_WARNING: Couldn't resolve default property of object ClipPath(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If VB6.GetItemString(cmbStoryThemes, i) = Mid(ClipPath(ThemeSketchX.FullPath), LibLen) Then
						Exit For
					End If
				Next i
				If i > cmbStoryThemes.Items.Count Then
					'UPGRADE_WARNING: Couldn't resolve default property of object ClipPath(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cmbStoryThemes.Items.Add(Mid(ClipPath(ThemeSketchX.FullPath), LibLen))
				End If
			End If
		Next ThemeSketchX
		' Load up Creatures
		ShowMessage("Scanning Library Creatures....")
		modDungeonMaker.InitUberWizCreatures(UberWiz)
		' List Creatures
		cmbCreatures.Items.Clear()
		cmbCreatures.Items.Add("<All>")
		lstWanderingMonsters.Items.Add("<None>")
		For	Each CreatureX In UberWiz.Creatures
			' Plop in the combo box
			For i = 0 To cmbCreatures.Items.Count
				'UPGRADE_WARNING: Couldn't resolve default property of object ClipPath(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If VB6.GetItemString(cmbCreatures, i) = Mid(ClipPath(CreatureX.PictureFile), LibLen) Then
					Exit For
				End If
			Next i
			If i > cmbCreatures.Items.Count Then
				'UPGRADE_WARNING: Couldn't resolve default property of object ClipPath(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				cmbCreatures.Items.Add(Mid(ClipPath(CreatureX.PictureFile), LibLen))
			End If
		Next CreatureX
		' Load up Items
		ShowMessage("Scanning Library Items....")
		modDungeonMaker.InitUberWizItems(UberWiz)
		' List Items
		cmbItems.Items.Clear()
		cmbItems.Items.Add("<All>")
		For	Each ItemX In UberWiz.Items
			' Plop in the combo box
			For i = 0 To cmbItems.Items.Count
				'UPGRADE_WARNING: Couldn't resolve default property of object ClipPath(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If VB6.GetItemString(cmbItems, i) = Mid(ClipPath(ItemX.PictureFile), LibLen) Then
					Exit For
				End If
			Next i
			If i > cmbItems.Items.Count Then
				'UPGRADE_WARNING: Couldn't resolve default property of object ClipPath(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				cmbItems.Items.Add(Mid(ClipPath(ItemX.PictureFile), LibLen))
			End If
		Next ItemX
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub MoveThruWizard(ByRef Direction As Short)
		Dim Tome_Renamed As Object
		Dim c As Short
		Dim TomeSketchX As TomeSketch
		Dim MapSketchX As MapSketch
		Dim EntryPointX As EntryPoint
		Dim ThemeSketchX As ThemeSketch
		Dim CreatureX As Creature
		Dim ItemX As Item
		UberIndex = UberIndex + Direction
		' Check to see if back up over Map Size and Themes
		If UberIndex = 5 And Direction = -1 Then
			UberIndex = 3
		End If
		' UberIndex is now at the frame to display
		Select Case UberIndex
			Case 0 ' Options for UberWizard
				imgWizardPic(0).BringToFront()
			Case 1 ' Choose Starting Tome
				If optFirstChoice(1).Checked = True Then
					'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Tome.FileName = "" ' [Titi 2.4.9]
					CloseForm()
					Exit Sub
				ElseIf optFirstChoice(2).Checked = True Then 
					CloseForm()
					frmMDI.OpenTome()
					Exit Sub
				ElseIf optFirstChoice(3).Checked = True Then 
					' [Titi] added for 2.4.7
					CloseForm()
					frmMDI.mnuOptionsWorldSettingsCreate_Click(Nothing, New System.EventArgs())
					Exit Sub
				ElseIf optFirstChoice(4).Checked = True Then 
					' [Titi] added for 2.4.7
					CloseForm()
					frmMDI.mnuOptionsWorldSettingsLoad_Click(Nothing, New System.EventArgs())
					Exit Sub
				ElseIf Direction = 1 Then 
					InitUberWiz()
					imgWizardPic(1).BringToFront()
					UberWiz.MainMapIndex = 0
					cmbMapSet.SelectedIndex = 0
				End If
			Case 2 ' Edit Name of Tome
				' Unselect all Maps
				For	Each MapSketchX In UberWiz.MapSketchs
					MapSketchX.IsSelected = False
				Next MapSketchX
				SetMainMap()
				' Set the default Name, Comments and Levels
				If UberWiz.MainMap.TomeIndex > 0 Then
					TomeSketchX = UberWiz.TomeSketchs.Item("T" & UberWiz.MainMap.TomeIndex)
					txtTomeName.Text = TomeSketchX.Name
					txtTomeComments.Text = TomeSketchX.Comments
					Select Case TomeSketchX.PartySize
						Case 0 To 1
							cmbPartySize.SelectedIndex = 0
						Case 1 To 3
							cmbPartySize.SelectedIndex = 1
						Case 4 To 6
							cmbPartySize.SelectedIndex = 2
						Case Else
							cmbPartySize.SelectedIndex = 3
					End Select
					Select Case TomeSketchX.PartyAvgLevel
						Case 0 To 3
							cmbPartyAvgLevel.SelectedIndex = 0
						Case 4 To 6
							cmbPartyAvgLevel.SelectedIndex = 1
						Case 7 To 10
							cmbPartyAvgLevel.SelectedIndex = 2
						Case Else
							cmbPartyAvgLevel.SelectedIndex = 3
					End Select
					optTomeSize(1).Checked = True ' Medium
				Else
					txtTomeName.Text = "Tome Wizard Adventure"
					txtTomeComments.Text = ""
					cmbPartySize.SelectedIndex = 1
					cmbPartyAvgLevel.SelectedIndex = 0
				End If
			Case 3 ' Choose Additional Maps
				UberWiz.TomeName = txtTomeName.Text
				UberWiz.TomeComments = txtTomeComments.Text
				UberWiz.TomePartySize = cmbPartySize.SelectedIndex
				UberWiz.TomePartyAvgLevel = cmbPartyAvgLevel.SelectedIndex
				For c = 0 To 3
					If optTomeSize(c).Checked = True Then
						Select Case c
							Case 0 ' Small / 8,000 Sq
								UberWiz.TotalSize = 10000 - Int(Rnd() * 4000)
							Case 1 ' Medium / 20,000 Sq
								UberWiz.TotalSize = 25000 - Int(Rnd() * 10000)
							Case 2 ' Large / 40,000 Sq
								UberWiz.TotalSize = 45000 - Int(Rnd() * 10000)
							Case 3 ' Huge / 60,000+
								UberWiz.TotalSize = 70000 - Int(Rnd() * 20000)
						End Select
						Exit For
					End If
				Next c
			Case 4 ' Choose Size and Encounter Count for the Map (if applicable)
				' Find the next Map to work on
				If NextMapTemplate = True Then
					' If doesn't require a random size then skip this part
					If UberWiz.MakingMap.GenerateUponEntry = False Then
						' [Titi 2.6.0] will stay on same page if going back from a map not generated upon entry!
						If Direction = -1 Then
							MoveThruWizard(-1)
						Else
							MoveThruWizard(1)
						End If
						Exit Sub
					Else
						lblMapSize.Text = "We're working on the " & UberWiz.MakingMap.MapName & " map. You need to decide how big the Map will be, how many Encounters it should have (those are places where you find Monsters and Treasures) and a few Themes for it."
						' [Titi 2.6.0] include the new map options in the tome wizard as well
						chkCanCamp.CheckState = False
						lstWanderingMonsters.Items.Clear()
						lstWanderingMonsters.Items.Add("<Add new creature>")
						For	Each CreatureX In UberWiz.MakingMap.Creatures
							lstWanderingMonsters.Items.Add(CreatureX.Name)
						Next CreatureX
					End If
				Else
					' If no more Maps to size and theme, then skip to Story Themes
					MoveThruWizard(2)
					Exit Sub
				End If
			Case 5 ' Choose Themes for the Map
				If UberWiz.MakingMap.Size = 0 Then
					' Set the Map Size
					For c = 0 To 8
						If optMapSize(c).Checked = True Then
							If c < 4 Then
								Select Case c
									Case 0 ' Small
										UberWiz.MakingMap.Size = 1
										UberWiz.MakingMap.TotalSize = 256 + Int(Rnd() * 1024)
									Case 1 ' Medium
										UberWiz.MakingMap.Size = 2
										UberWiz.MakingMap.TotalSize = 1024 + Int(Rnd() * 4096)
									Case 2 ' Large
										UberWiz.MakingMap.Size = 3
										UberWiz.MakingMap.TotalSize = 4096 + Int(Rnd() * 16384)
									Case Else ' Huge
										UberWiz.MakingMap.Size = 4
										UberWiz.MakingMap.TotalSize = 16384 + CInt(Rnd() * 65536)
								End Select
							Else
								UberWiz.MakingMap.EncounterCount = c - 3
							End If
						End If
					Next c
				End If
				' List Themes to select
				lblThemes.Text = "We're working on the '" & UberWiz.MakingMap.MapName & "' map. You need to pick one or more Themes to fill it out."
				cmbThemes.SelectedIndex = 0
				ListThemes(0)
			Case 6 ' Choose Story Themes for Tome
				imgWizardPic(2).BringToFront()
				If Direction = 1 Then
					modDungeonMaker.UberWizCopyThemes(UberWiz, (UberWiz.MakingMap))
					If NextMapTemplate = True Then
						UberIndex = 4
						MoveThruWizard(0)
						Exit Sub
					End If
				End If
				' List Story Themes to select
				cmbStoryThemes.SelectedIndex = 0
				ListStoryThemes(0)
			Case 7 ' Choose Creatures for Tome
				For	Each CreatureX In UberWiz.Creatures
					CreatureX.IsSelected = False
				Next CreatureX
				cmbCreatures.SelectedIndex = 0
				ListCreatures(0)
			Case 8 ' Choose Items for Tome
				For	Each ItemX In UberWiz.Items
					ItemX.IsSelected = False
				Next ItemX
				cmbItems.SelectedIndex = 0
				ListItems(0)
			Case 9 ' Build the Tome
				imgWizardPic(3).BringToFront()
				fraUberWizard(9).BringToFront()
				Me.Refresh()
				BuildTome()
		End Select
		fraUberWizard(UberIndex).BringToFront()
		btnNext.Enabled = (UberIndex < UberMax)
		btnBack.Enabled = (UberIndex > 0)
		Me.Text = "Tome Wizard: Page " & VB6.Format(UberIndex + 1) & " of " & VB6.Format(UberMax + 1)
		fraUberWizard(UberIndex).BringToFront()
	End Sub
	
	'UPGRADE_WARNING: Event chkCanCamp.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkCanCamp_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkCanCamp.CheckStateChanged
		UberWiz.MakingMap.CanCamp = chkCanCamp.CheckState
	End Sub
	
	'UPGRADE_WARNING: Event chkStartup.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkStartup_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkStartup.CheckStateChanged
		Dim fWriteValue As Object
		Dim lResult As Integer
		Dim tmp As String
		If chkStartup.CheckState = 1 Then
			tmp = "True"
		Else
			tmp = "False"
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object fWriteValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lResult = fWriteValue(gAppPath & "\Settings.ini", "Creator", "WizardStartup", "S", tmp)
	End Sub
	
	'UPGRADE_WARNING: Event cmbCreatures.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbCreatures_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbCreatures.SelectedIndexChanged
		If cmbCreatures.SelectedIndex > -1 Then
			ListCreatures((cmbCreatures.SelectedIndex))
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmbFrequency.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbFrequency_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbFrequency.SelectedIndexChanged
		If cmbFrequency.SelectedIndex > -1 Then
			UberWiz.MakingMap.Hazard = CShort(Val(VB6.GetItemString(cmbFrequency, cmbFrequency.SelectedIndex)))
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmbInterval.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbInterval_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbInterval.SelectedIndexChanged
		If cmbInterval.SelectedIndex > -1 Then
			UberWiz.MakingMap.Interval = CShort(Val(VB6.GetItemString(cmbInterval, cmbInterval.SelectedIndex)))
		End If
	End Sub
	'UPGRADE_WARNING: Event cmbItems.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbItems_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbItems.SelectedIndexChanged
		If cmbItems.SelectedIndex > -1 Then
			ListItems((cmbItems.SelectedIndex))
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmbMapSet.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbMapSet_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbMapSet.SelectedIndexChanged
		If cmbMapSet.SelectedIndex > -1 Then
			ListMainMaps((cmbMapSet.SelectedIndex))
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmbNextMap.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbNextMap_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbNextMap.SelectedIndexChanged
		If cmbNextMap.SelectedIndex > -1 Then
			ListNextMaps((cmbNextMap.SelectedIndex))
		End If
	End Sub
	
	Private Sub CloseForm()
		'UPGRADE_NOTE: Object UberWiz may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		UberWiz = Nothing
		Me.Close()
	End Sub
	
	Private Sub ListMainMaps(ByRef Index As Short)
		Dim ClipPath As Object
		Dim MapSketchX As MapSketch
		lstMapSet.Items.Clear()
		' List out Maps that can be used for Main Maps
		For	Each MapSketchX In UberWiz.MapSketchs
			'UPGRADE_WARNING: Couldn't resolve default property of object ClipPath(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If MapSketchX.IsMainMap = True And (Mid(ClipPath(MapSketchX.FullPath), LibLen) = VB6.GetItemString(cmbMapSet, Index) Or VB6.GetItemString(cmbMapSet, Index) = "<All>") Then
				lstMapSet.Items.Add(New VB6.ListBoxItem(MapSketchX.MapName, MapSketchX.Index))
			End If
		Next MapSketchX
		' If couldn't find any Maps, then can only create one
		If lstMapSet.Items.Count > 0 Then
			lstMapSet.SelectedIndex = 0
		End If
	End Sub
	
	Private Sub ListNextMaps(ByRef Index As Short)
		Dim ClipPath As Object
		Dim MapSketchX As MapSketch
		' List out Maps that can be used for Next Maps
		lstNextMap.Items.Clear()
		For	Each MapSketchX In UberWiz.MapSketchs
			'UPGRADE_WARNING: Couldn't resolve default property of object ClipPath(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If MapSketchX.IsUsed = False And (Mid(ClipPath(MapSketchX.FullPath), LibLen) = VB6.GetItemString(cmbNextMap, Index) Or VB6.GetItemString(cmbNextMap, Index) = "<All>") Then
				lstNextMap.Items.Add(New VB6.ListBoxItem(MapSketchX.MapName, MapSketchX.Index))
				'UPGRADE_ISSUE: ListBox property lstNextMap.NewIndex was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
				lstNextMap.SetItemChecked(lstNextMap.NewIndex, MapSketchX.IsSelected)
			End If
		Next MapSketchX
		' If couldn't find any Maps, then can only create one
		If lstNextMap.Items.Count > 0 Then
			lstNextMap.SelectedIndex = 0
			ShowNextMap(VB6.GetItemData(lstNextMap, 0))
		End If
	End Sub
	
	Private Sub ListStoryThemes(ByRef Index As Short)
		Dim ClipPath As Object
		Dim ThemeSketchX As ThemeSketch
		' List out Themes
		lstStoryThemes.Items.Clear()
		For	Each ThemeSketchX In UberWiz.ThemeSketchs
			'UPGRADE_WARNING: Couldn't resolve default property of object ClipPath(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If ThemeSketchX.IsMajorTheme = True Or ThemeSketchX.IsQuest = True And (Mid(ClipPath(ThemeSketchX.FullPath), LibLen) = VB6.GetItemString(cmbStoryThemes, Index) Or VB6.GetItemString(cmbStoryThemes, Index) = "<All>") Then
				If ThemeSketchX.IsMajorTheme = True Then
					lstStoryThemes.Items.Add(ThemeSketchX.Name & " (Major)")
				Else
					lstStoryThemes.Items.Add(ThemeSketchX.Name)
				End If
				'UPGRADE_ISSUE: ListBox property lstStoryThemes.NewIndex was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
				VB6.SetItemData(lstStoryThemes, lstStoryThemes.NewIndex, ThemeSketchX.Index)
				'UPGRADE_ISSUE: ListBox property lstStoryThemes.NewIndex was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
				lstStoryThemes.SetItemChecked(lstStoryThemes.NewIndex, ThemeSketchX.IsSelected)
			End If
		Next ThemeSketchX
		' If couldn't find any Themes, then can only create one
		If lstStoryThemes.Items.Count > 0 Then
			lstStoryThemes.SelectedIndex = 0
			ShowStoryTheme(VB6.GetItemData(lstStoryThemes, 0))
		End If
	End Sub
	
	Private Sub ListThemes(ByRef Index As Short)
		Dim ClipPath As Object
		Dim ThemeSketchX As ThemeSketch
		' List out Themes
		lstThemes.Items.Clear()
		For	Each ThemeSketchX In UberWiz.ThemeSketchs
			'UPGRADE_WARNING: Couldn't resolve default property of object ClipPath(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If ThemeSketchX.IsMajorTheme = False And ThemeSketchX.IsQuest = False And (Mid(ClipPath(ThemeSketchX.FullPath), LibLen) = VB6.GetItemString(cmbThemes, Index) Or VB6.GetItemString(cmbThemes, Index) = "<All>") Then
				lstThemes.Items.Add(New VB6.ListBoxItem(ThemeSketchX.Name, ThemeSketchX.Index))
				'UPGRADE_ISSUE: ListBox property lstThemes.NewIndex was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
				lstThemes.SetItemChecked(lstThemes.NewIndex, ThemeSketchX.IsSelected)
			End If
		Next ThemeSketchX
		' If couldn't find any Themes, then can only create one
		If lstThemes.Items.Count > 0 Then
			lstThemes.SelectedIndex = 0
			ShowTheme(VB6.GetItemData(lstThemes, 0))
		End If
	End Sub
	
	Private Function NextMapTemplate() As Short
		Dim MapSketchX As MapSketch
		NextMapTemplate = False
		For	Each MapSketchX In UberWiz.MapSketchs
			' If it's a Map Template, Used and doesn't have Size set, then need to set it.
			If MapSketchX.IsSelected = True Then
				If (MapSketchX.GenerateUponEntry = True And MapSketchX.Size = 0) Or MapSketchX.NeedsThemes = True Then
					UberWiz.MakingMapIndex = MapSketchX.Index
					NextMapTemplate = True
					Exit For
				End If
			End If
		Next MapSketchX
	End Function
	
	Private Sub SetMainMap()
		Dim ClipPath As Object
		Dim c, i As Short
		Dim EntryPointX As EntryPoint
		Dim MapSketchX As MapSketch
		' Set up the MainMap
		modDungeonMaker.UberWizMainMap(UberWiz, VB6.GetItemData(lstMapSet, lstMapSet.SelectedIndex))
		' Maps attached to the selected Main Map are Used by association
		'    i = Len(gAppPath & "/library/") + 1
		i = Len(gLibPath) + 1
		cmbNextMap.Items.Clear()
		cmbNextMap.Items.Add("<All>")
		cmbNextMap.SelectedIndex = 0
		For	Each MapSketchX In UberWiz.MapSketchs
			If MapSketchX.IsUsed = False Then
				' Put in the combo box (if not already there)
				For c = 0 To cmbNextMap.Items.Count
					'UPGRADE_WARNING: Couldn't resolve default property of object ClipPath(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If VB6.GetItemString(cmbNextMap, c) = Mid(ClipPath(MapSketchX.FullPath), i) Then
						Exit For
					End If
				Next c
				If c > cmbNextMap.Items.Count Then
					'UPGRADE_WARNING: Couldn't resolve default property of object ClipPath(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cmbNextMap.Items.Add(Mid(ClipPath(MapSketchX.FullPath), i))
				End If
			End If
		Next MapSketchX
	End Sub
	
	Private Sub ListCreatures(ByRef Index As Short)
		Dim ClipPath As Object
		Dim CreatureX As Creature
		' List out Creatures
		lstCreatures.Items.Clear()
		For	Each CreatureX In UberWiz.Creatures
			'UPGRADE_WARNING: Couldn't resolve default property of object ClipPath(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Mid(ClipPath(CreatureX.PictureFile), LibLen) = VB6.GetItemString(cmbCreatures, Index) Or VB6.GetItemString(cmbCreatures, Index) = "<All>" Then
				lstCreatures.Items.Add(New VB6.ListBoxItem(CreatureX.Name, CreatureX.Index))
				'UPGRADE_ISSUE: ListBox property lstCreatures.NewIndex was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
				lstCreatures.SetItemChecked(lstCreatures.NewIndex, CreatureX.IsSelected)
			End If
		Next CreatureX
		' If couldn't find any Creatures, then can only create one
		If lstCreatures.Items.Count > 0 Then
			lstCreatures.SelectedIndex = 0
			ShowCreature(VB6.GetItemData(lstCreatures, 0))
		End If
	End Sub
	
	Private Sub ListItems(ByRef Index As Short)
		Dim ClipPath As Object
		Dim ItemX As Item
		' List out Items
		lstItems.Items.Clear()
		For	Each ItemX In UberWiz.Items
			'UPGRADE_WARNING: Couldn't resolve default property of object ClipPath(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Mid(ClipPath(ItemX.PictureFile), LibLen) = VB6.GetItemString(cmbItems, Index) Or VB6.GetItemString(cmbItems, Index) = "<All>" Then
				lstItems.Items.Add(New VB6.ListBoxItem(ItemX.Name, ItemX.Index))
				'UPGRADE_ISSUE: ListBox property lstItems.NewIndex was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
				lstItems.SetItemChecked(lstItems.NewIndex, ItemX.IsSelected)
			End If
		Next ItemX
		' If couldn't find any Items, then can only create one
		If lstItems.Items.Count > 0 Then
			lstItems.SelectedIndex = 0
			ShowItem(VB6.GetItemData(lstItems, 0))
		End If
	End Sub
	
	Private Sub btnBack_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnBack.Click
		MoveThruWizard(-1)
	End Sub
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		CloseForm()
	End Sub
	
	Private Sub btnFinish_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnFinish.Click
		If UberIndex < 9 Then
			MoveThruWizard(1)
			If optFirstChoice(0).Checked = True Then
				modDungeonMaker.UberWizFinish(UberWiz, UberIndex, True)
				UberIndex = 8
				MoveThruWizard(1)
			End If
		Else
			CloseForm()
		End If
	End Sub
	
	Private Sub btnNext_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnNext.Click
		MoveThruWizard(1)
	End Sub
	
	'UPGRADE_NOTE: Text was upgraded to Text_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub ShowMessage(ByRef Text_Renamed As String)
		lblPause.Text = Text_Renamed
		lblPause.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(fraPause.Width) - 75)
		lblPause.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(fraPause.Width) - VB6.PixelsToTwipsX(lblPause.Width)) / 2)
		lblPause.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(fraPause.Height) - VB6.PixelsToTwipsY(lblPause.Height)) / 2)
		lblPause.Refresh()
	End Sub
	
	'UPGRADE_WARNING: Event cmbStoryThemes.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbStoryThemes_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbStoryThemes.SelectedIndexChanged
		If cmbStoryThemes.SelectedIndex > -1 Then
			ListStoryThemes((cmbStoryThemes.SelectedIndex))
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmbThemes.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbThemes_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbThemes.SelectedIndexChanged
		If cmbThemes.SelectedIndex > -1 Then
			ListThemes((cmbThemes.SelectedIndex))
		End If
	End Sub
	
	'UPGRADE_WARNING: Event lstCreatures.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstCreatures_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstCreatures.SelectedIndexChanged
		If lstCreatures.SelectedIndex > -1 Then
			ShowCreature(VB6.GetItemData(lstCreatures, lstCreatures.SelectedIndex))
			'UPGRADE_WARNING: Couldn't resolve default property of object UberWiz.Creatures(X & lstCreatures.ItemData(lstCreatures.ListIndex)).IsSelected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			UberWiz.Creatures.Item("X" & VB6.GetItemData(lstCreatures, lstCreatures.SelectedIndex)).IsSelected = lstCreatures.GetItemChecked(lstCreatures.SelectedIndex)
		End If
	End Sub
	
	'UPGRADE_WARNING: Event lstItems.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstItems_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstItems.SelectedIndexChanged
		If lstItems.SelectedIndex > -1 Then
			ShowItem(VB6.GetItemData(lstItems, lstItems.SelectedIndex))
			'UPGRADE_WARNING: Couldn't resolve default property of object UberWiz.Items(I & lstItems.ItemData(lstItems.ListIndex)).IsSelected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			UberWiz.Items.Item("I" & VB6.GetItemData(lstItems, lstItems.SelectedIndex)).IsSelected = lstItems.GetItemChecked(lstItems.SelectedIndex)
		End If
	End Sub
	
	'UPGRADE_WARNING: Event lstMapSet.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstMapSet_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstMapSet.SelectedIndexChanged
		If lstMapSet.SelectedIndex > -1 Then
			ShowMainMap(VB6.GetItemData(lstMapSet, lstMapSet.SelectedIndex))
		End If
	End Sub
	
	Private Sub lstNextMap_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lstNextMap.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		If lstNextMap.SelectedIndex > -1 Then
			ShowNextMap(VB6.GetItemData(lstNextMap, lstNextMap.SelectedIndex))
			'UPGRADE_WARNING: Couldn't resolve default property of object UberWiz.MapSketchs(M & lstNextMap.ItemData(lstNextMap.ListIndex)).IsSelected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			UberWiz.MapSketchs.Item("M" & VB6.GetItemData(lstNextMap, lstNextMap.SelectedIndex)).IsSelected = lstNextMap.GetItemChecked(lstNextMap.SelectedIndex)
		End If
	End Sub
	
	'UPGRADE_WARNING: Event lstStoryThemes.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstStoryThemes_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstStoryThemes.SelectedIndexChanged
		If lstStoryThemes.SelectedIndex > -1 Then
			ShowStoryTheme(VB6.GetItemData(lstStoryThemes, lstStoryThemes.SelectedIndex))
			'UPGRADE_WARNING: Couldn't resolve default property of object UberWiz.ThemeSketchs(R & lstStoryThemes.ItemData(lstStoryThemes.ListIndex)).IsSelected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			UberWiz.ThemeSketchs.Item("R" & VB6.GetItemData(lstStoryThemes, lstStoryThemes.SelectedIndex)).IsSelected = lstStoryThemes.GetItemChecked(lstStoryThemes.SelectedIndex)
		End If
	End Sub
	
	'UPGRADE_WARNING: Event lstThemes.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstThemes_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstThemes.SelectedIndexChanged
		If lstThemes.SelectedIndex > -1 Then
			ShowTheme(VB6.GetItemData(lstThemes, lstThemes.SelectedIndex))
			'UPGRADE_WARNING: Couldn't resolve default property of object UberWiz.ThemeSketchs(R & lstThemes.ItemData(lstThemes.ListIndex)).IsSelected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			UberWiz.ThemeSketchs.Item("R" & VB6.GetItemData(lstThemes, lstThemes.SelectedIndex)).IsSelected = lstThemes.GetItemChecked(lstThemes.SelectedIndex)
		End If
	End Sub
	
	Private Sub lstWanderingMonsters_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lstWanderingMonsters.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Dim CreatureX As Creature
		Dim c, Index As Short
		Dim FileName As String
		On Error Resume Next
		If lstWanderingMonsters.SelectedIndex = 0 Then ' add another creature
			frmMDI.dlgFileOpen.FileName = gLibPath & "\Creatures\*.rsc"
			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
			frmMDI.dlgFile.CancelError = True
			frmMDI.dlgFileOpen.Title = "Add wandering monster"
			'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			frmMDI.dlgFileOpen.Filter = "Creature Files (*.rsc)|*.rsc|All Files (*.*)|*.*"
			frmMDI.dlgFileOpen.FilterIndex = 1
			frmMDI.dlgFileOpen.FilterIndex = 1
			'UPGRADE_WARNING: Untranslated statement in lstWanderingMonsters_MouseDown. Please check source code.
			frmMDI.dlgFileOpen.ShowDialog()
			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
			If Err.Number = DialogResult.Cancel Then
				Exit Sub
			End If
			FileName = frmMDI.dlgFileOpen.FileName
			c = FreeFile
			FileOpen(c, FileName, OpenMode.Binary)
			'UPGRADE_WARNING: Couldn't resolve default property of object UberWiz.MapSketchs().AddCreature. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CreatureX = UberWiz.MapSketchs.Item("M" & UberWiz.MakingMapIndex).AddCreature
			Index = CreatureX.Index
			CreatureX.ReadFromFile(c)
			CreatureX.Index = Index
			lstWanderingMonsters.Items.Add(CreatureX.Name)
		ElseIf lstWanderingMonsters.SelectedIndex > -1 Then 
			' get corresponding index
			For	Each CreatureX In UberWiz.MakingMap.Creatures
				If CDbl(CreatureX.Name) = VB6.GetItemData(lstWanderingMonsters, lstWanderingMonsters.SelectedIndex) Then
					Index = CreatureX.Index
					Exit For
				End If
			Next CreatureX
			UberWiz.MakingMap.RemoveCreature("X" & Index)
			lstWanderingMonsters.Items.RemoveAt(lstWanderingMonsters.SelectedIndex)
		End If
	End Sub
End Class