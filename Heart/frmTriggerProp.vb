Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmTriggerProp
	Inherits System.Windows.Forms.Form
	Dim TreeViewX As AxComctlLib.AxTreeView
	Dim TriggerX As Trigger
	Dim StatementX As New Statement
	Dim Dirty As Short
	Dim AutoShow As Short
	Dim bReadOnly As Boolean
	
	Const bdStatements As Short = 1
	Const bdCreatures As Short = 2
	Const bdItems As Short = 3
	Const bdTriggers As Short = 4
	Const nbVar As Short = 543 ' Number of possible objects and properties
	
	'UPGRADE_WARNING: Structure POINTAPI may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function GetCaretPos Lib "user32" (ByRef lpPoint As POINTAPI) As Integer
	Private Structure POINTAPI
		Dim X As Integer
		Dim Y As Integer
	End Structure
	
	Dim strStatements(bdStatementCount) As String
	Dim strContext(32) As String
	Dim strVarProp(nbVar) As String
	Dim strParse(bdStatementCount) As String
	
	Public Sub ShowTrigger(ByRef InTree As AxComctlLib.AxTreeView, ByRef InTrig As Trigger, ByRef TrigType As Short)
		Dim c As Short
		Dim OldDirt, tmpDirty As Short
		OldDirt = frmMDI.Dirty
		tmpDirty = Dirty '[Titi 2.4.9a]
		TreeViewX = InTree
		TriggerX = InTrig
		' [Titi 2.5.1] keep track of the active map (if any)
		If TreeViewX.SelectedItem.Tag <> "Tome" And VB.Left(TreeViewX.SelectedItem.Tag, 1) <> "M" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object TreeViewX.Nodes.Item().Parent.Tag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			MapTag = TreeViewX.Nodes.Item(TreeViewX.SelectedItem.Tag).Parent.Tag
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object TreeViewX.Nodes.Item().Tag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			MapTag = TreeViewX.Nodes.Item(TreeViewX.SelectedItem.Tag).Tag
		End If
		If InStr(MapTag, "M") > 0 Then
			MapTag = "M" & Trim(Str(Val(Mid(MapTag, InStr(MapTag, "M") + 1))))
		Else
			MapTag = "No Map active" ' this way, we will know that 'CopyTile' and 'TargetEncounter' are not applicable!
		End If
		Select Case TrigType
			Case bdTrigTome
				Me.Text = "Tome Trigger [" & TriggerX.Name & "]"
			Case bdTrigTopic
				Me.Text = "Topic Trigger [" & TriggerX.Name & "]"
			Case bdTrigEncounter
				Me.Text = "Encounter Trigger [" & TriggerX.Name & "]"
			Case bdTrigItem
				Me.Text = "Item Trigger [" & TriggerX.Name & "]"
			Case bdTrigCreature
				Me.Text = "Creature Trigger [" & TriggerX.Name & "]"
			Case bdTrigTrig
				Me.Text = "Sub-Trigger [" & TriggerX.Name & "]"
			Case bdTrigTheme
				Me.Text = "Theme Trigger [" & TriggerX.Name & "]"
		End Select
		' Setup TriggerNames
		modDM.BuildTriggerList(cmbTriggerType, TrigType)
		' Show Trigger information
		cmbTriggerType.SelectedIndex = 0
		For c = 0 To cmbTriggerType.Items.Count - 1
			If TriggerX.TriggerType = VB6.GetItemData(cmbTriggerType, c) Then
				cmbTriggerType.SelectedIndex = c
				Exit For
			End If
		Next c
		txtName.Text = TriggerX.Name
		txtComments.Text = TriggerX.Comments
		txtSkillPoints.Text = VB6.Format(TriggerX.SkillPoints)
		If TriggerX.Style(7) = True Then
			txtTurns.Text = VB6.Format(TriggerX.Turns)
			cmbLasting.SelectedIndex = 2
		ElseIf TriggerX.Style(0) = True Then 
			txtTurns.Text = VB6.Format(TriggerX.Turns)
		Else
			Select Case TriggerX.Turns
				Case 0 ' Infinite
					cmbLasting.SelectedIndex = 3
				Case 1 ' One Time
					cmbLasting.SelectedIndex = 0
				Case Else ' Charges
					txtTurns.Text = VB6.Format(TriggerX.Turns)
					cmbLasting.SelectedIndex = 1
			End Select
		End If
		cmbLasting_SelectedIndexChanged(cmbLasting, New System.EventArgs())
		For c = 0 To 6
			chkStyle(c).CheckState = TriggerX.Style(c) * CShort(True)
		Next c
		For c = 8 To 15 ' was 14 [Titi 2.6.0] re-used for "apply on dead characters too"
			chkStyle(c).CheckState = TriggerX.Style(c) * CShort(True)
		Next c
		ListStatements()
		txtStatements.SelectionStart = 0
		FindStatement(True, True)
		SetDirty(False)
		frmMDI.Dirty = OldDirt
		Dirty = tmpDirty ' [Titi 2.4.9a] when loading, the form will not set Dirty
		btnApply.Enabled = Dirty
	End Sub
	
	Private Function UpdateTrigger() As Short
		Dim StartPos, c, EndPos As Short
		Dim ErrorMsg As String
		Dim TriggerZ As New Trigger
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		' Before anything else, attempt a full parse on the Statements
		c = 1 : StartPos = 1 : ErrorMsg = ""
		Do Until c > Len(txtStatements.Text)
			If Mid(txtStatements.Text, c, 2) = Chr(13) & Chr(10) Or c = Len(txtStatements.Text) Then
				If c = Len(txtStatements.Text) Then
					EndPos = c + 1
				Else
					EndPos = c
				End If
				' Parse the Statement
				If EndPos - StartPos > 0 Then
					StatementX = TriggerZ.AddStatement
					ErrorMsg = ParseStatement(Tome, Area, TriggerX, StatementX, Mid(txtStatements.Text, StartPos, EndPos - StartPos))
					If ErrorMsg <> "" Then
						' Display Error Message
						MsgBox(ErrorMsg, MsgBoxStyle.Exclamation)
						txtStatements.SelectionStart = StartPos - 1
						txtStatements.SelectionLength = EndPos - StartPos
						txtStatements.Focus()
						ShowStatement()
						UpdateTrigger = False
						'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
						System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
						Exit Function
					End If
				End If
				c = EndPos + 2
				StartPos = c
			Else
				c = c + 1
			End If
		Loop 
		' Copy parses Statements to TriggerX
		TriggerX.Statements = TriggerZ.Statements
		' Now update Trigger
		TriggerX.TriggerType = VB6.GetItemData(cmbTriggerType, cmbTriggerType.SelectedIndex)
		TriggerX.Name = txtName.Text
		TriggerX.Comments = txtComments.Text
		' [Titi 2.4.8] forces the number of skillpoints to correspond to the nearest level
		If Val(txtTurns.Text) <> CDbl("0") Then
			If Int(Val(txtSkillPoints.Text) / Val(txtTurns.Text)) <> Val(txtSkillPoints.Text) / Val(txtTurns.Text) Then
				' number of skill points allocated not correct
				txtSkillPoints.Text = Str(Int(Val(txtSkillPoints.Text) / Val(txtTurns.Text) + 0.5) * Val(txtTurns.Text))
				MsgBox("Incorrect skillpoints number." & vbLf & "New value: " & txtSkillPoints.Text & ", corresponding to " & IIf(Int(Val(txtSkillPoints.Text) / Val(txtTurns.Text)) = 1, "first", IIf(Int(Val(txtSkillPoints.Text) / Val(txtTurns.Text)) = 2, "second", IIf(Int(Val(txtSkillPoints.Text) / Val(txtTurns.Text)) = 3, "third", Int(Val(txtSkillPoints.Text) / Val(txtTurns.Text)) & "th"))) & " level of skill", MsgBoxStyle.Information, "Skill level correction!")
			End If
		End If
		' [Titi 2.4.9b] Make sure there are skill points to get
		TriggerX.SkillPoints = 0
		If txtSkillPoints.Text <> vbNullString Then TriggerX.SkillPoints = CShort(txtSkillPoints.Text)
		For c = 0 To 6
			TriggerX.Style(c) = chkStyle(c).CheckState * CShort(True)
		Next c
		Select Case cmbLasting.SelectedIndex
			Case 0 ' One Time
				TriggerX.Style(7) = False
				TriggerX.Turns = 1
			Case 1 ' Charges
				TriggerX.Style(7) = False
				TriggerX.Turns = CByte(txtTurns.Text)
			Case 2 ' Turns
				TriggerX.Style(7) = True
				TriggerX.Turns = CByte(txtTurns.Text)
			Case 3 ' Infinite
				TriggerX.Style(7) = False
				TriggerX.Turns = 0
		End Select
		If chkStyle(0).CheckState > 0 Then
			TriggerX.Turns = CByte(txtTurns.Text)
		End If
		For c = 8 To 15 ' was 14 [Titi 2.6.0] added a new option: applies on dead characters too
			TriggerX.Style(c) = chkStyle(c).CheckState * CShort(True)
		Next c
		' Update ProjectList
		TreeViewX.Nodes(Me.Tag).Text = TriggerName(TriggerX.TriggerType) & " " & TriggerX.Name
		SetDirty(False)
		UpdateTrigger = True
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
	End Function
	
	Private Sub InitGame()
		Dim c, i As Short
		' [Titi 2.4.9b] Update statements depending on whether the world uses runes or not
		'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Runes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Syntax(23, 0) = IIf(WorldNow.Runes, "Reagents", "Runes")
		'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Runes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Syntax(42, 0) = IIf(WorldNow.Runes, "CheckReagents", "QueRunes")
		' Load and Setup Statement names
		For c = 1 To bdStatementCount
			If Syntax(c, 0) <> "" Then
				If Syntax(c, 0) = "'" Then
					cmbStatement.Items.Add("TriggerComment")
				Else
					cmbStatement.Items.Add(Syntax(c, 0))
				End If
				'UPGRADE_ISSUE: ComboBox property cmbStatement.NewIndex was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
				VB6.SetItemData(cmbStatement, cmbStatement.NewIndex, c)
			End If
		Next c
		' Set to now update StatementX in Combat Boxes
		AutoShow = False
		' Setup Lasting (One Time, Charges, Turns)
		cmbLasting.Items.Add("One Time")
		cmbLasting.Items.Add("Charges")
		cmbLasting.Items.Add("Turns")
		cmbLasting.Items.Add("Infinite")
		' Populate Op combo boxes in StatementEditor
		For c = 0 To 1
			cmbOp(c).Items.Clear()
			For i = 0 To 13
				cmbOp(c).Items.Add(New VB6.ListBoxItem(OpToText(i), i))
			Next i
		Next c
		' moved to frmMDI [Titi]
		'    Set oGameMusic = New IMCI
	End Sub
	
	Private Sub SetDirty(ByRef Flag As Short)
		btnApply.Enabled = Flag
		Dirty = Flag
		If Dirty = True Then
			frmMDI.Dirty = True
		End If
	End Sub
	
	Private Function GetFileName(ByRef FileType As String, ByRef FileDefault As String) As String
		On Error Resume Next
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		dlgFile.CancelError = True
		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		dlgFileOpen.Filter = FileType & "|All Files (*.*)|*.*"
		dlgFileOpen.FilterIndex = 1
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFile.Flags was upgraded to dlgFileOpen.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		dlgFileOpen.CheckFileExists = True
		dlgFileOpen.CheckPathExists = True
		'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFile.Flags was upgraded to dlgFileOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		dlgFileOpen.ShowReadOnly = False
		dlgFileOpen.RestoreDirectory = False
		dlgFileOpen.FileName = FileDefault
		dlgFileOpen.ShowDialog()
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		If Err.Number = DialogResult.Cancel Then
			Exit Function
		End If
		' Return file name
		'UPGRADE_WARNING: CommonDialog property dlgFile.FileTitle was upgraded to dlgFile.FileName which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		GetFileName = dlgFileOpen.FileName
	End Function
	
	'UPGRADE_NOTE: Update was upgraded to Update_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	'UPGRADE_NOTE: Show was upgraded to Show_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Function FindStatement(ByRef Show_Renamed As Short, ByRef Update_Renamed As Short, Optional ByRef intPosInSearchString As Short = 0) As Short
		Dim ErrStart, ErrLength As Integer
		Dim StartPos, EndPos As Integer
		Dim ErrorMsg As String
		'UPGRADE_NOTE: Text was upgraded to Text_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Text_Renamed As String
		FindStatement = 0
		Dim c, i As Integer
		'    ' Find start of a line
		'    StartPos = 0
		If intPosInSearchString > 0 Then txtStatements.SelectionStart = intPosInSearchString
		'    ' [Titi 2.4.8] moved all the code below to "InsertionAt()"
		'    If txtStatements.SelStart < 2 Then
		'        ' [Titi 2.4.7] if enter pressed to add a new line at the first position, the apostrophe is not yet there
		'        If Len(txtStatements) > 0 Then
		'            If Asc(Mid$(txtStatements, 1, 1)) = 13 Then txtStatements = "'" & txtStatements'
		'        End If
		'        ' Start of the first line
		'        StartPos = 1
		'    ElseIf Mid$(txtStatements.Text, txtStatements.SelStart - 1, 2) = Chr(13) & Chr(10) Then
		'        ' Start of a line other than first
		'        StartPos = txtStatements.SelStart + 1
		'    Else
		'        ' Midpoint of a line
		'        For c = txtStatements.SelStart To 2 Step -1
		'            If Mid$(txtStatements.Text, c - 1, 2) = Chr(13) & Chr(10) Then
		'                StartPos = c + 1
		'                Exit For
		'            End If
		'        Next c
		'        ' Midpoint of the first line
		'        If StartPos = 0 Then
		'            StartPos = 1
		'        End If
		'    End If
		'    ' Find end of the line
		'    EndPos = 0
		'    For c = StartPos To Len(txtStatements.Text) - 1
		'        If Mid$(txtStatements.Text, c, 2) = Chr(13) & Chr(10) Then
		'            EndPos = c - 1
		'            Exit For
		'        End If
		'    Next c
		'    ' End of the last line
		'    If EndPos = 0 Then
		'        EndPos = Len(txtStatements.Text)
		'    End If
		InsertionAt(StartPos, EndPos, ErrLength)
		' Parse the Statement
		ErrorMsg = ""
		If Update_Renamed = True Then
			StatementX = New Statement
			ErrorMsg = ParseStatement(Tome, Area, TriggerX, StatementX, Mid(txtStatements.Text, StartPos, EndPos - StartPos + 1))
		End If
		If ErrorMsg <> "" And Show_Renamed = False Then
			' Display Error Message
			MsgBox(ErrorMsg, MsgBoxStyle.Exclamation)
			FindStatement = -1
		ElseIf ErrorMsg = "" Then 
			' Redisplay parsed Statement
			modBD.StatementToText(Tome, Area, TriggerX, StatementX, Text_Renamed)
			If intPosInSearchString <> 0 Then
				Text_Renamed = Mid(txtStatements.Text, StartPos, EndPos - StartPos + 1)
			End If
			If Mid(txtStatements.Text, StartPos, EndPos - StartPos + 1) <> Text_Renamed Then
				txtStatements.SelectionStart = StartPos - 1
				txtStatements.SelectionLength = EndPos - StartPos + 1
				txtStatements.SelectedText = Text_Renamed
			End If
		End If
		' Might just show the statement
		If Show_Renamed = True And intPosInSearchString <> -1 Then
			' intPosInSearchString borrowed to flag we're coming from AutoComplete (and therefore don't want to show the statement)
			ShowStatement()
		End If
	End Function
	
	Private Sub ShowStatement()
		Dim oErr As Object
		Dim w, k, c, i, j, Index As Short
		Dim tmpReadOnly As Boolean ' [Titi 2.4.9b]
		On Error GoTo ErrorHandler ' [Titi 2.6.0] fixes "bad" trigger coding from previous versions
		tmpReadOnly = bReadOnly ' This is to save the status of bReadOnly in the case this sub is executed from the AutoComplete feature
		bReadOnly = False
		' In this context, w represents the available portion of a line for display.
		' Each cmbEach represents 1/2 a line. Each cmbContext/Var represent a full line.
		' The control's tag represents the byte location (SyntaxIndex) in the Statement.
		AutoShow = True
		For c = 0 To 3
			cmbContext(c).Visible = False : cmbVar(c).Visible = False
		Next c
		For c = 0 To 3
			cmbEach(c).Visible = False
		Next c
		For c = 0 To 1
			cmbOp(c).Visible = False
		Next c
		For c = 0 To 2
			txtText(c).Visible = False
		Next c
		btnBrowse.Visible = False
		btnTest.Visible = False
		chkOption.Visible = False
		' If a blank statement, then shut everything off
		If StatementX.Statement = 0 Then
			cmbStatement.Visible = False
			Exit Sub
		End If
		cmbStatement.Visible = True
		For c = 0 To cmbStatement.Items.Count - 1
			If StatementX.Statement = VB6.GetItemData(cmbStatement, c) Then
				cmbStatement.SelectedIndex = c
				Exit For
			End If
		Next c
		' Show appropriate stuff
		w = 0
		For c = 1 To SyntaxIndex(StatementX.Statement, 0)
			System.Windows.Forms.Application.DoEvents()
			Index = SyntaxIndex(StatementX.Statement, c)
			Select Case Syntax(StatementX.Statement, c)
				Case "Var", "(Var)"
					For j = 0 To System.Math.Abs(CInt(Syntax(StatementX.Statement, c) = "(Var)"))
						i = Int((w + 1) / 2)
						cmbContext(i).Items.Clear()
						' [Titi 2.4.9b] don't show Read-Only properties in destination variables of Put (12), CopyText (22), DialogDice (39) and Let (53)
						' [Titi 2.6.0] Same applies for DialogAccept (38) and DialogAcceptText (51)
						If StatementX.Statement = 12 Then
							If i = 2 Then
								bReadOnly = True
							Else
								bReadOnly = False
							End If
						ElseIf StatementX.Statement = 22 Then 
							If i = 1 Then
								bReadOnly = True
							Else
								bReadOnly = False
							End If
						ElseIf StatementX.Statement = 39 Then 
							If i = 3 Then
								bReadOnly = True
							Else
								bReadOnly = False
							End If
						ElseIf StatementX.Statement = 53 Or StatementX.Statement = 38 Or StatementX.Statement = 51 Then 
							If i = 0 Then
								' we're left of the "=" --> don't display read-only properties
								bReadOnly = True
							Else
								' we're at the right --> no problem
								bReadOnly = False
							End If
						End If
						For k = 0 To bdContextCount
							If bReadOnly = False Or IsReadOnly(k, 255) = False Then
								cmbContext(i).Items.Add(New VB6.ListBoxItem(ContextToText(k), k))
							End If
						Next k
						For k = 0 To cmbContext(i).Items.Count - 1
							If VB6.GetItemData(cmbContext(i), k) = StatementX.B(Index) Then
								cmbContext(i).SelectedIndex = k
								cmbContext(i).Tag = Index
								Exit For
							End If
						Next k
						cmbVar(i).Items.Clear()
						For k = 0 To 255
							If VarToText(StatementX.B(Index), k) = "" Then
								Exit For
							End If
							If VarToText(StatementX.B(Index), k) <> "<Reserved>" Then
								' Format Pos, Neg and Random numbers to they list in order
								Select Case StatementX.B(Index)
									Case 29, 30, 32
										' [Titi 2.4.9b] Only show read-only when allowed
										If bReadOnly = False Then
											cmbVar(i).Items.Add(VB6.Format(VarToText(StatementX.B(Index), k), "000"))
										End If
									Case Else
										' [Titi 2.4.9b] Only show read-only when allowed
										If bReadOnly = False Or IsReadOnly(StatementX.B(Index), k) = False Then
											cmbVar(i).Items.Add(VarToText(StatementX.B(Index), k))
										End If
								End Select
								If bReadOnly = False Or IsReadOnly(StatementX.B(Index), k) = False Then
									'UPGRADE_ISSUE: ComboBox property cmbVar.NewIndex was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
									VB6.SetItemData(cmbVar(i), cmbVar(i).NewIndex, k)
								End If
							End If
						Next k
						For k = 0 To cmbVar(i).Items.Count - 1
							If VB6.GetItemData(cmbVar(i), k) = StatementX.B(Index + 1) Then
								cmbVar(i).SelectedIndex = k
								cmbVar(i).Tag = Index + 1
								Exit For
							End If
						Next k
						' [Titi 2.4.9b]
						If cmbVar(i).SelectedIndex = -1 Then
							cmbVar(i).SelectedIndex = 0
							cmbVar(i).Tag = Index + 1
						End If
						cmbContext(i).Visible = True
						cmbVar(i).Visible = True
						w = w + 2
						Index = Index + 3
					Next j
				Case "Op"
					i = System.Math.Abs(CInt(w > 2))
					For k = 0 To 13
						If VB6.GetItemData(cmbOp(i), k) = StatementX.B(Index) Then
							cmbOp(i).SelectedIndex = k
							cmbOp(i).Tag = Index
							Exit For
						End If
					Next k
					cmbOp(i).Visible = True
				Case "Text1", "Text3"
					txtText(0).Visible = True
					txtText(0).Text = BreakText(StatementX.Text, Index + 1)
					txtText(0).Tag = Index
					w = w + 1
					' [Titi 2.5.1] particular treatment of 'CopyTile' and 'TargetEncounter' (I kept the original syntax for compatibility purposes)
					If StatementX.Statement = 21 Or StatementX.Statement = 67 Then
						StatementToList(Tome, Area, TriggerX, StatementX, ListIndex, List)
						cmbEach(0).Items.Clear()
						If MapTag <> "No Map active" Then
							For i = 0 To ListIndex(1) - 1
								cmbEach(0).Items.Insert(i, List(1, i))
								If List(1, i) = StatementX.Text Then k = i
							Next 
							cmbEach(0).SelectedIndex = k
							cmbEach(0).Visible = True
						End If
					End If
					If Syntax(StatementX.Statement, c) = "Text3" Then
						btnBrowse.Visible = True
						Select Case StatementX.Statement
							Case 33 'PlaySound
								btnTest.Visible = True
							Case 34 'PlayMusic
								btnTest.Visible = True
							Case 41 'CutScene
							Case 46 'PlaySFX
							Case 69 'PlayVideo
						End Select
						w = w + 1
					End If
				Case "Text2", "Spec"
					txtText(1).Visible = True
					txtText(1).Text = BreakText(StatementX.Text, Index + 1)
					txtText(1).Tag = Index
					w = 5
				Case "Text4"
					txtText(2).Visible = True
					txtText(2).Text = BreakText(StatementX.Text, Index + 1)
					txtText(2).Tag = Index
					w = 3
				Case "List1", "List2", "List3", "List4"
					StatementToList(Tome, Area, TriggerX, StatementX, ListIndex, List)
					i = Int(w / 2) : j = CDbl(VB.Right(Syntax(StatementX.Statement, c), 1)) - 1
					If w Mod 2 = 0 Then
						cmbEach(i).Items.Clear() : cmbEach(i).Tag = Index
						For k = 0 To ListIndex(j)
							If List(j, k) <> "" Then
								cmbEach(i).Items.Add(New VB6.ListBoxItem(List(j, k), k))
							End If
						Next k
						For k = 0 To cmbEach(i).Items.Count - 1
							If VB6.GetItemData(cmbEach(i), k) = StatementX.B(Index) Then
								cmbEach(i).SelectedIndex = k
								Exit For
							End If
						Next k
						cmbEach(i).Visible = True
					Else
						cmbVar(i).Items.Clear() : cmbVar(i).Tag = Index
						For k = 0 To ListIndex(j)
							If List(j, k) <> "" Then
								cmbVar(i).Items.Add(New VB6.ListBoxItem(List(j, k), k))
							End If
						Next k
						For k = 0 To cmbVar(i).Items.Count - 1
							If VB6.GetItemData(cmbVar(i), k) = StatementX.B(Index) Then
								cmbVar(i).SelectedIndex = k
								Exit For
							End If
						Next k
						cmbVar(i).Visible = True
					End If
					w = w + 1
				Case "(List)"
					StatementToList(Tome, Area, TriggerX, StatementX, ListIndex, List)
					For k = 0 To 2
						cmbEach(k).Visible = True : cmbEach(k).Items.Clear() : cmbEach(k).Tag = k * 2
						cmbVar(k).Visible = True : cmbVar(k).Items.Clear() : cmbVar(k).Tag = k * 2 + 1
						For j = 0 To intNbRunes '20   [Titi 2.4.9b]
							cmbEach(k).Items.Add(New VB6.ListBoxItem(List(0, j), j))
							cmbVar(k).Items.Add(New VB6.ListBoxItem(List(0, j), j))
						Next j
						For j = 0 To cmbEach(k).Items.Count - 1
							If VB6.GetItemData(cmbEach(k), j) = StatementX.B(k * 2) Then
								cmbEach(k).SelectedIndex = j
							End If
						Next j
						For j = 0 To cmbVar(k).Items.Count - 1
							If VB6.GetItemData(cmbVar(k), j) = StatementX.B(k * 2 + 1) Then
								cmbVar(k).SelectedIndex = j
							End If
						Next j
					Next k
					' [Titi 2.4.9b] If the world doesn't use the runes system, all we need is the first dropdown list!
					'                If WorldNow.Runes Then
					'                    For k = 0 To 2
					'                        If k <> 0 Then cmbEach(k).Visible = False
					'                        cmbVar(k).Visible = False
					'                    Next
					'                End If
					w = 6
			End Select
		Next c
		' Show additional check box if necessary
		If c + 1 < 8 Then
			If Syntax(StatementX.Statement, c) <> "" Then
				Index = SyntaxIndex(StatementX.Statement, c)
				chkOption.Text = Syntax(StatementX.Statement, c)
				chkOption.CheckState = System.Math.Abs(CInt(StatementX.B(Index) > 0))
				chkOption.Tag = Index
				chkOption.Visible = True
			End If
		End If
		AutoShow = False
		If tmpReadOnly Then bReadOnly = tmpReadOnly
		Exit Sub
ErrorHandler: 
		If Err.Number = 380 Then
			If bReadOnly Then
				' trigger coded in a previous version of RS, where we could have "Let Pos.1 = Neg.1"!
				cmbVar(i).Items.Add("Read-only Property!")
				cmbContext(i).Items.Insert(0, "Coding Error:")
				cmbContext(i).SelectedIndex = 0
				Resume 
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object oErr.logError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				oErr.logError("ShowStatement: error with " & Chr(34) & StatementX.Text & Chr(34))
				Resume Next
			End If
		End If
	End Sub
	
	Private Sub UpdateStatement()
		Dim c, Found As Short
		StatementX = New Statement
		StatementX.Statement = VB6.GetItemData(cmbStatement, cmbStatement.SelectedIndex)
		For c = 0 To 3
			If cmbContext(c).Visible = True Then
				StatementX.B(CShort(cmbContext(c).Tag)) = VB6.GetItemData(cmbContext(c), cmbContext(c).SelectedIndex)
			End If
			If cmbVar(c).Visible = True And cmbVar(c).SelectedIndex > -1 Then
				StatementX.B(CShort(cmbVar(c).Tag)) = VB6.GetItemData(cmbVar(c), cmbVar(c).SelectedIndex)
			End If
		Next c
		For c = 0 To 3
			If cmbEach(c).Visible = True And cmbEach(c).SelectedIndex > -1 Then
				If c = 0 And (StatementX.Statement = 21 Or StatementX.Statement = 67) Then
					' CopyTile or TargetEncounter, do nothing - the first list is supposed to be a TextBox
				Else
					StatementX.B(CShort(cmbEach(c).Tag)) = VB6.GetItemData(cmbEach(c), cmbEach(c).SelectedIndex)
				End If
			End If
		Next c
		For c = 0 To 1
			If cmbOp(c).Visible = True Then
				StatementX.B(CShort(cmbOp(c).Tag)) = VB6.GetItemData(cmbOp(c), cmbOp(c).SelectedIndex)
			End If
		Next c
		For c = 0 To 2
			If txtText(c).Visible = True Then
				Select Case txtText(c).Tag
					Case CStr(0)
						If Len(StatementX.Text) > 0 Then
							StatementX.Text = txtText(c).Text & StatementX.Text
						Else
							StatementX.Text = txtText(c).Text
						End If
					Case CStr(1)
						StatementX.Text = StatementX.Text & "|" & txtText(c).Text
				End Select
			End If
		Next c
		If chkOption.Visible = True Then
			StatementX.B(CShort(chkOption.Tag)) = chkOption.CheckState
		End If
		FindStatement(False, False)
		' If at end of text then add a return
		Found = False
		' [Titi 2.4.7] RT5 if update while nothing changed
		If txtStatements.SelectionStart > 0 Then
			For c = txtStatements.SelectionStart To Len(txtStatements.Text)
				If Mid(txtStatements.Text, c, 2) = Chr(13) & Chr(10) Then
					Found = True
					Exit For
				End If
			Next c
			If Found = False Then
				txtStatements.Text = txtStatements.Text & Chr(13) & Chr(10)
				txtStatements.SelectionStart = Len(txtStatements.Text)
			End If
		End If
		'    FindStatement False, True
	End Sub
	
	Private Sub EditThing()
		If lstThings.SelectedIndex > -1 Then
			Select Case tabTrigger.SelectedItem.Tag
				Case bdStatements
				Case bdTriggers
					frmMDI.EditProperties(Me.Tag & "T" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdCreatures
					frmMDI.EditProperties(Me.Tag & "X" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				Case bdItems
					frmMDI.EditProperties(Me.Tag & "I" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
			End Select
		End If
	End Sub
	
	Private Sub CutThing()
		If tabTrigger.SelectedItem.Tag = bdStatements Then
			CopyThing()
			txtStatements.SelectedText = ""
		Else
			If lstThings.SelectedIndex > -1 Then
				Select Case tabTrigger.SelectedItem.Tag
					Case bdStatements
					Case bdTriggers
						frmMDI.EditCut(Me.Tag & "T" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
					Case bdCreatures
						frmMDI.EditCut(Me.Tag & "X" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
					Case bdItems
						frmMDI.EditCut(Me.Tag & "I" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				End Select
			End If
		End If
	End Sub
	
	Private Sub CopyThing()
		If tabTrigger.SelectedItem.Tag = bdStatements Then
			My.Computer.Clipboard.Clear()
			My.Computer.Clipboard.SetText(Mid(txtStatements.Text, txtStatements.SelectionStart + 1, txtStatements.SelectionLength))
		Else
			If lstThings.SelectedIndex > -1 Then
				Select Case tabTrigger.SelectedItem.Tag
					Case bdStatements
					Case bdTriggers
						frmMDI.EditCopy(Me.Tag & "T" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
					Case bdCreatures
						frmMDI.EditCopy(Me.Tag & "X" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
					Case bdItems
						frmMDI.EditCopy(Me.Tag & "I" & VB6.GetItemData(lstThings, lstThings.SelectedIndex))
				End Select
			End If
		End If
	End Sub
	
	Private Sub PasteThing()
		'UPGRADE_NOTE: Text was upgraded to Text_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Text_Renamed As String
		If tabTrigger.SelectedItem.Tag = bdStatements Then
			Text_Renamed = My.Computer.Clipboard.GetText()
			txtStatements.SelectedText = Text_Renamed
		Else
			Select Case tabTrigger.SelectedItem.Tag
				Case bdStatements
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
		End If
	End Sub
	
	Private Sub NewThing()
		Dim c As Short
		Select Case tabTrigger.SelectedItem.Tag
			Case bdStatements
				If Len(txtStatements.Text) > 0 Then
					For c = txtStatements.SelectionStart + 1 To Len(txtStatements.Text)
						If Mid(txtStatements.Text, c, 2) = Chr(13) & Chr(10) Then
							txtStatements.SelectionStart = c - 1
							txtStatements.SelectedText = Chr(13) & Chr(10)
							FindStatement(True, True)
							Exit For
						End If
					Next 
					If c > Len(txtStatements.Text) Then
						txtStatements.Text = txtStatements.Text & Chr(13) & Chr(10)
					End If
				End If
			Case bdTriggers
				frmMDI.EditAdd(Me.Tag, bdEditTrigger)
			Case bdCreatures
				frmMDI.EditAdd(Me.Tag, bdEditCreature)
			Case bdItems
				frmMDI.EditAdd(Me.Tag, bdEditItem)
		End Select
	End Sub
	
	Public Sub ListStatements()
		'UPGRADE_NOTE: Text was upgraded to Text_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim StmtX As Statement
		Dim Text_Renamed As String
		' Show Statement Text
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		btnEdit.Visible = False
		txtStatements.Text = ""
		For	Each StmtX In TriggerX.Statements
			modBD.StatementToText(Tome, Area, TriggerX, StmtX, Text_Renamed)
			txtStatements.Text = txtStatements.Text & Text_Renamed & Chr(13) & Chr(10)
		Next StmtX
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
	End Sub
	
	Public Sub ListCreatures()
		Dim c As Short
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		btnEdit.Visible = True
		lstThings.Items.Clear()
		For c = 1 To TriggerX.Creatures.Count()
			'UPGRADE_WARNING: Couldn't resolve default property of object TriggerX.Creatures(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object TriggerX.Creatures(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lstThings.Items.Add(New VB6.ListBoxItem(TriggerX.Creatures.Item(c).Name, TriggerX.Creatures.Item(c).Index))
		Next c
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
	End Sub
	
	Public Sub ListItems()
		Dim c As Short
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		btnEdit.Visible = True
		lstThings.Items.Clear()
		For c = 1 To TriggerX.Items.Count()
			'UPGRADE_WARNING: Couldn't resolve default property of object TriggerX.Items(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object TriggerX.Items(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lstThings.Items.Add(New VB6.ListBoxItem(TriggerX.Items.Item(c).Name, TriggerX.Items.Item(c).Index))
		Next c
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
	End Sub
	
	Public Sub ListTriggers()
		Dim c As Short
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		btnEdit.Visible = True
		lstThings.Items.Clear()
		For c = 1 To TriggerX.Triggers.Count()
			'UPGRADE_WARNING: Couldn't resolve default property of object TriggerX.Triggers(c).Index. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object TriggerX.Triggers(c).Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object TriggerX.Triggers().TriggerType. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lstThings.Items.Add(New VB6.ListBoxItem(TriggerName(TriggerX.Triggers.Item(c).TriggerType) & " " & TriggerX.Triggers.Item(c).Name, TriggerX.Triggers.Item(c).Index))
		Next c
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub btnApply_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnApply.Click
		UpdateTrigger()
	End Sub
	
	Private Sub btnBrowse_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnBrowse.Click
		If cmbStatement.SelectedIndex > -1 Then
			Select Case VB6.GetItemData(cmbStatement, cmbStatement.SelectedIndex)
				Case 33 'PlaySound
					'                txtText(0).Text = GetFileName("Wave Files (*.wav)|*.wav", gAppPath & "\Data\Sounds\*.wav")
					txtText(0).Text = GetFileName("Wave Files (*.wav)|*.wav", gDataPath & "\Sounds\*.wav")
				Case 34 'PlayMusic
					'                txtText(0).Text = GetFileName("MIDI Files (*.mid)|*.mid|MP3 Files (*.mp3)|*.mp3", gAppPath & "\Data\Music\*.mid")
					txtText(0).Text = GetFileName("MIDI Files (*.mid)|*.mid|MP3 Files (*.mp3)|*.mp3", gDataPath & "\Music\*.mid")
				Case 41 'CutScene
					'                txtText(0).Text = GetFileName("Picture Files (*.bmp)|*.bmp", gAppPath & "\Data\*.bmp")
					txtText(0).Text = GetFileName("Picture Files (*.bmp)|*.bmp", gDataPath & "\*.bmp")
				Case 46, 72, 73 'PlaySFX, CombatAnimation, MapAnimation
					'                txtText(0).Text = GetFileName("SFX Files (*.bmp)|*.bmp", gAppPath & "\Data\Graphics\Effects\*.bmp")
					txtText(0).Text = GetFileName("SFX Files (*.bmp)|*.bmp", gDataPath & "\Graphics\Effects\*.bmp")
				Case 69 'PlayVideo
					'                txtText(0).Text = GetFileName("AVI Files (*.avi)|*.avi|MPEG Files (*.mpg)|*.mpg", gAppPath & "\Data\Video\*.avi")
					txtText(0).Text = GetFileName("AVI Files (*.avi)|*.avi|MPEG Files (*.mpg)|*.mpg", gDataPath & "\Video\*.avi")
			End Select
			SetDirty(True)
		End If
	End Sub
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		' [Titi 2.6.0] cancelling means we don't want to save the changes, so prevent the message from appearing
		Dirty = False
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
	
	Private Sub btnNew_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnNew.Click
		NewThing()
	End Sub
	
	Private Sub btnOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOk.Click
		If UpdateTrigger = True Then
			' [Titi 2.6.3] cancelling an updated trigger only means we won't keep the changes since the last ones so we update the tag
			If VB.Right("   " & Me.Tag, 3) = "NEW" Then Me.Tag = VB.Left(Me.Tag, Len(Me.Tag) - 3)
			Me.Close()
		End If
	End Sub
	
	Private Sub btnPaste_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnPaste.Click
		PasteThing()
	End Sub
	
	Private Sub btnTest_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnTest.Click
		Dim oGameMusic As Object
		Dim PlayMusic As Object
		Dim PlaySoundFile As Object
		If cmbStatement.SelectedIndex > -1 Then
			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
			Select Case VB6.GetItemData(cmbStatement, cmbStatement.SelectedIndex)
				Case 33 'PlaySound
					Call PlaySoundFile(LCase(txtText(0).Text), Tome, True, chkOption.CheckState > 0)
				Case 34 'PlayMusic
					If btnTest.Text = "Test" Then
						Call PlayMusic(txtText(0).Text, frmMDI, Tome.LoadPath)
						btnTest.Text = "Stop"
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object oGameMusic.mciClose. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						Call oGameMusic.mciClose()
						btnTest.Text = "Test"
					End If
				Case 41 'CutScene
				Case 46 'PlaySFX
				Case 69 'PlayVideo
			End Select
			SetDirty(True)
			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		End If
	End Sub
	
	Private Sub btnUpdate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnUpdate.Click
		UpdateStatement()
	End Sub
	
	'UPGRADE_WARNING: Event chkStyle.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkStyle_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkStyle.CheckStateChanged
		Dim Index As Short = chkStyle.GetIndex(eventSender)
		Dim c As Short
		If Index = 0 Then ' If checked Skill
			If chkStyle(0).CheckState = 1 Then
				For c = 1 To 6
					chkStyle(c).Enabled = False
				Next c
				cmbLasting.Visible = False
				lblTurns.Text = "Cost"
				lblTurns.Enabled = True
				lblTurns.Visible = True
				txtTurns.Enabled = True
				txtTurns.Visible = True
				lblSkillPoints.Visible = True
				txtSkillPoints.Visible = True
				lblDuration.Text = ""
			Else
				For c = 1 To 6
					chkStyle(c).Enabled = True
				Next c
				cmbLasting.Visible = True
				lblSkillPoints.Visible = False
				txtSkillPoints.Visible = False
				lblDuration.Text = "Duration"
				cmbLasting_SelectedIndexChanged(cmbLasting, New System.EventArgs())
			End If
		End If
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbContext.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbContext_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbContext.SelectedIndexChanged
		Dim Index As Short = cmbContext.GetIndex(eventSender)
		Dim c, k As Short
		' [Titi 2.4.9b] don't show Read-Only properties in destination variables of Put (12), CopyText (22), DialogDice (39) and Let (53)
		If VB6.GetItemString(cmbStatement, cmbStatement.SelectedIndex) = "Put" Then
			If Index = 2 Then
				bReadOnly = True
			Else
				bReadOnly = False
			End If
		ElseIf VB6.GetItemString(cmbStatement, cmbStatement.SelectedIndex) = "CopyText" Then 
			If Index = 1 Then
				bReadOnly = True
			Else
				bReadOnly = False
			End If
		ElseIf VB6.GetItemString(cmbStatement, cmbStatement.SelectedIndex) = "DialogDice" Then 
			If Index = 3 Then
				bReadOnly = True
			Else
				bReadOnly = False
			End If
		ElseIf VB6.GetItemString(cmbStatement, cmbStatement.SelectedIndex) = "Let" Or VB6.GetItemString(cmbStatement, cmbStatement.SelectedIndex) = "DialogAccept" Or VB6.GetItemString(cmbStatement, cmbStatement.SelectedIndex) = "DialogAcceptText" Then 
			If Index = 0 Then
				bReadOnly = True
			Else
				bReadOnly = False
			End If
		End If
		If cmbContext(Index).SelectedIndex > -1 And AutoShow = False Then
			k = VB6.GetItemData(cmbContext(Index), cmbContext(Index).SelectedIndex)
			cmbVar(Index).Items.Clear()
			For c = 0 To 255
				If VarToText(k, c) = "" Then
					Exit For
				End If
				' [Titi 2.4.9b] added the bReadOnly tests
				If VarToText(k, c) <> "<Reserved>" Then
					' This format Pos, Neg and Random numbers to they list in order
					Select Case k
						Case 29, 30, 32
							If bReadOnly = False Then cmbVar(Index).Items.Add(VB6.Format(VarToText(k, c), "000"))
						Case Else
							If bReadOnly = False Or IsReadOnly(k, c) = False Then
								cmbVar(Index).Items.Add(VarToText(k, c))
							End If
					End Select
					If bReadOnly = False Or IsReadOnly(k, c) = False Then
						'UPGRADE_ISSUE: ComboBox property cmbVar.NewIndex was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
						VB6.SetItemData(cmbVar(Index), cmbVar(Index).NewIndex, c)
						cmbVar(Index).SelectedIndex = 0
					End If
				End If
			Next c
			'        cmbVar(Index).ListIndex = 0
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmbEach.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbEach_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbEach.SelectedIndexChanged
		Dim Index As Short = cmbEach.GetIndex(eventSender)
		Dim c, i As Short
		If cmbEach(Index).SelectedIndex > -1 And Index = 0 And AutoShow = False Then
			Select Case StatementX.Statement
				Case 9, 13, 26, 49, 70 ' ForEach, Set, Destroy, TargetEncounterNamed, Find
					StatementX.B(CShort(cmbEach(Index).Tag)) = VB6.GetItemData(cmbEach(Index), cmbEach(Index).SelectedIndex)
					StatementToList(Tome, Area, TriggerX, StatementX, ListIndex, List)
					cmbVar(0).Items.Clear()
					For c = 0 To ListIndex(1)
						If List(1, c) <> "" Then
							cmbVar(0).Items.Add(New VB6.ListBoxItem(List(1, c), c))
						End If
					Next c
					For c = 0 To cmbVar(0).Items.Count - 1
						If VB6.GetItemData(cmbVar(0), c) = StatementX.B(CShort(cmbVar(0).Tag)) Then
							cmbVar(0).SelectedIndex = c
							Exit For
						End If
					Next c
				Case 21, 67 ' CopyTile, TargetEncounter [Titi 2.5.1]
					If Index = 0 Then
						txtText(0).Text = cmbEach(Index).Text
					End If
			End Select
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmbLasting.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbLasting_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbLasting.SelectedIndexChanged
		Select Case cmbLasting.SelectedIndex
			Case 0 ' One Time
				txtTurns.Visible = False
				txtTurns.Text = "1"
				lblTurns.Visible = False
			Case 1 ' Charges
				txtTurns.Visible = True
				txtTurns.Enabled = True
				lblTurns.Visible = True
				lblTurns.Text = "Charges"
				lblTurns.Enabled = True
			Case 2 ' Turns
				txtTurns.Visible = True
				txtTurns.Enabled = True
				lblTurns.Visible = True
				lblTurns.Text = "Turns"
				lblTurns.Enabled = True
			Case 3 ' Infinite
				txtTurns.Visible = False
				txtTurns.Text = "0"
				lblTurns.Visible = False
		End Select
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbStatement.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbStatement_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbStatement.SelectedIndexChanged
		Dim c As Short
		If cmbStatement.SelectedIndex > -1 And AutoShow = False Then
			bReadOnly = False
			StatementX.Statement = VB6.GetItemData(cmbStatement, cmbStatement.SelectedIndex)
			ShowStatement()
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmbTriggerType.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbTriggerType_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbTriggerType.SelectedIndexChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event cmbVar.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbVar_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbVar.SelectedIndexChanged
		Dim Index As Short = cmbVar.GetIndex(eventSender)
		Dim c As Short
		' [Titi 2.5.1] TargetEncounterNamed
		If StatementX.Statement = 49 Then
			' Update the list of possible encounters based on the selected map
			StatementX.B(CShort(cmbVar(Index).Tag)) = VB6.GetItemData(cmbVar(Index), cmbVar(Index).SelectedIndex)
			StatementToList(Tome, Area, TriggerX, StatementX, ListIndex, List)
			cmbEach(1).Items.Clear()
			For c = 0 To ListIndex(2)
				If List(2, c) <> "" Then
					cmbEach(1).Items.Add(New VB6.ListBoxItem(List(2, c), c))
				End If
			Next c
			For c = 0 To cmbEach(1).Items.Count - 1
				If cmbEach(1).Tag <> "" Then
					If VB6.GetItemData(cmbEach(1), c) = StatementX.B(CShort(cmbEach(1).Tag)) Then
						cmbEach(1).SelectedIndex = c
						Exit For
					End If
				End If
			Next c
		End If
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
	
	'UPGRADE_WARNING: Form event frmTriggerProp.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmTriggerProp_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		' [Titi 2.6.0] Make sure we're still working with the relevant treeview and objectlist
		If VB.Left(Me.Tag, 4) = "Tome" Then
			frmMDI.TreeViewX = frmProject.tvwTome.GetOcx
			frmMDI.ObjectListX = frmProject.TomeList
		Else
			frmMDI.TreeViewX = frmProject.tvwProject.GetOcx
			frmMDI.ObjectListX = frmProject.AreaList
		End If
	End Sub
	
	Private Sub frmTriggerProp_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim i As Short
		Dim c As Integer
		Me.Height = VB6.TwipsToPixelsY(6585) : Me.Width = VB6.TwipsToPixelsX(11145)
		InitGame()
		' Populate statements list
		' It would have been nice to use Syntax(i,0) but statements 23, 32, 45 and 63 require a special attention
		strStatements(0) = "' "
		strStatements(1) = "Label "
		strStatements(2) = "If "
		strStatements(3) = "Else"
		strStatements(4) = "ElseIf "
		strStatements(5) = "And "
		strStatements(6) = "Or "
		strStatements(7) = "EndIf"
		strStatements(8) = "While "
		strStatements(9) = "ForEach "
		strStatements(10) = "Next"
		strStatements(11) = "Branch "
		strStatements(12) = "Put "
		strStatements(13) = "Set "
		strStatements(14) = "Select "
		strStatements(15) = "Case "
		strStatements(16) = "EndSelect"
		strStatements(17) = "Exit "
		strStatements(18) = "CopyCreature "
		strStatements(19) = "CopyItem "
		strStatements(20) = "CopyTrigger "
		strStatements(21) = "CopyTile "
		strStatements(22) = "CopyText "
		'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Runes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		strStatements(23) = IIf(WorldNow.Runes, "Reagents²( ", "Runes²( ") ' "Runes ( "
		strStatements(24) = "AddFactoid "
		strStatements(25) = "AddJournalEntry "
		strStatements(26) = "Destroy "
		strStatements(27) = "CombatApplyDamage "
		strStatements(28) = "CombatRollAttack "
		strStatements(29) = "CombatRollDamage "
		strStatements(30) = "DestroyFactoid "
		strStatements(31) = "TargetCreature "
		strStatements(32) = "TargetItem "
		strStatements(33) = "PlaySound "
		strStatements(34) = "PlayMusic "
		strStatements(35) = "MoveParty " ' "MoveParty To "
		strStatements(36) = "DialogShow "
		strStatements(37) = "DialogReply "
		strStatements(38) = "DialogAccept "
		strStatements(39) = "DialogDice "
		strStatements(40) = "DialogHide"
		strStatements(41) = "CutScene "
		'UPGRADE_WARNING: Couldn't resolve default property of object WorldNow.Runes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		strStatements(42) = IIf(WorldNow.Runes, "CheckReagents²( ", "QueRunes²( ") ' "QueRunes ( "
		strStatements(43) = "CombatMove "
		strStatements(45) = "CombatTarget "
		strStatements(46) = "PlaySFX "
		strStatements(47) = "Sorcery "
		strStatements(48) = "DialogBuySell "
		strStatements(49) = "TargetEncounterInArea "
		strStatements(50) = "ExecTrigger "
		strStatements(51) = "DialogAcceptText "
		strStatements(52) = "CombatStart"
		strStatements(53) = "Let "
		strStatements(55) = "RandomizeEncounter "
		strStatements(56) = "RandomTheme "
		strStatements(57) = "AwardExperience "
		strStatements(58) = "MoveItem "
		strStatements(59) = "AddQuest "
		strStatements(60) = "RemoveQuest "
		strStatements(61) = "RemoveTopic" ' "AnnotateMap " not used
		strStatements(62) = "CombatAttackWithWeapon"
		strStatements(63) = "CombatAttackWithSpecial "
		strStatements(64) = "MovePartyMapName " ' "MovePartyMapName To "
		strStatements(65) = "MoveCreature "
		strStatements(66) = "IfText "
		strStatements(67) = "TargetEncounter "
		strStatements(68) = "TargetTile "
		strStatements(69) = "PlayVideo "
		strStatements(70) = "Find "
		strStatements(71) = "CallTrigger "
		strStatements(72) = "CombatAnimation "
		strStatements(73) = "MapAnimation "
		strStatements(74) = "MapRefresh"
		' statements 44 and 49 do not exist, 54 is for comments...
		For i = 0 To 32
			strContext(i) = ContextToText(i)
		Next 
		c = FreeFile
		'    Open gAppPath & "\data\stock\List of instructions.txt" For Input As #c
		FileOpen(c, gDataPath & "\stock\List of instructions.txt", OpenMode.Input)
		For i = 0 To nbVar - 1
			Input(c, strVarProp(i))
		Next 
		FileClose(c)
		c = FreeFile
		'    Open gAppPath & "\data\stock\RS2 Statements.txt" For Input As #c
		FileOpen(c, gDataPath & "\stock\RS2 Statements.txt", OpenMode.Input)
		For i = 0 To bdStatementCount
			Input(c, strParse(i))
			' [Titi 2.4.9b] Runes and QueRunes are changed to Reagents and CheckReagents if the world doesn't use runes
			If i = 23 Or i = 42 Then
				strParse(i) = strStatements(i) & Mid(strParse(i), 9 - 3 * CShort(i = 42), 5) & IIf(i = 23, "/ Fail/FailSave/Save/", "/ Check")
			End If
		Next 
		FileClose(c)
		' [Titi 2.4.9b] bReadOnly global var to prevent read-only properties from being listed in the statements that allow to change values
		bReadOnly = False
	End Sub
	
	'UPGRADE_WARNING: Event frmTriggerProp.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmTriggerProp_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		Dim oErr As Object
		On Error GoTo ErrorHandler
		Dim ctl As System.Windows.Forms.Control
		Me.Height = VB6.TwipsToPixelsY(6675) ' original height, remains fixed
		If VB6.PixelsToTwipsX(Me.Width) < 11145 Or tabTrigger.SelectedItem.Index <> 1 Then Me.Width = VB6.TwipsToPixelsX(11145) ' reset to default width if sizing down too much or selecting another tab
		For	Each ctl In Me.Controls
			' only resize the statements listbox
			If ctl.Name = "txtStatements" Then
				ctl.Width = VB6.TwipsToPixelsX(4575 + VB6.PixelsToTwipsX(Me.Width) - 11145) ' width varies with form
			ElseIf VB.Left(ctl.Name, 3) = "btn" Then 
				' and the buttons placed at its right
				If VB6.PixelsToTwipsX(ctl.Left) > 9700 And ctl.Name <> "btnApply" Then
					ctl.Left = VB6.TwipsToPixelsX(9780 - VB6.PixelsToTwipsX(Me.Width) - 11145 * CShort(tabTrigger.SelectedItem.Index = 1)) ' only resize the form if the Statements are visible
				End If
			End If
		Next ctl
		tabTrigger.Width = VB6.TwipsToPixelsX(6015 + VB6.PixelsToTwipsX(Me.Width) - 11145) ' expand the tabstrip too, it's nicer
		Exit Sub
ErrorHandler: 
		If Err.Number = 384 Then
			Err.Clear()
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object oErr.logError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			oErr.logError(Me.Name & " encountered error #" & Err.Number)
		End If
	End Sub
	
	Private Sub frmTriggerProp_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Dim oGameMusic As Object
		Dim rc As Short
		'UPGRADE_WARNING: Couldn't resolve default property of object oGameMusic.mciClose. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Call oGameMusic.mciClose(True)
		If Dirty Then
			rc = MsgBox("Do you want to save your changes?", MsgBoxStyle.YesNo, "Trigger modified!")
			If rc = MsgBoxResult.Yes Then
				' [Titi 2.6.3] update the tag before closing
				If VB.Right("   " & Me.Tag, 3) = "NEW" Then Me.Tag = VB.Left(Me.Tag, Len(Me.Tag) - 3)
				btnOk_Click(btnOk, New System.EventArgs())
			Else
				' [Titi 2.6.3] closing a new trigger means we won't keep it
				If VB.Right("   " & Me.Tag, 3) = "NEW" Then
					frmMDI.EditCut(VB.Left(Me.Tag, Len(Me.Tag) - 3))
				End If
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event lstThings.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstThings_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstThings.SelectedIndexChanged
		Select Case tabTrigger.SelectedItem.Tag
			Case bdStatements
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
	
	Private Sub tabTrigger_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabTrigger.ClickEvent
		Select Case tabTrigger.SelectedItem.Tag
			Case bdStatements
				txtStatements.Visible = True
				fraStatementEditor.Visible = True
				btnEdit.Visible = False
				lstThings.Visible = False
				btnLibrary.Visible = False
			Case bdCreatures
				txtStatements.Visible = False
				fraStatementEditor.Visible = False
				btnEdit.Visible = True
				lstThings.Visible = True
				btnLibrary.Text = "Insert creature from library"
				btnLibrary.Visible = True
				ListCreatures()
			Case bdItems
				txtStatements.Visible = False
				fraStatementEditor.Visible = False
				btnEdit.Visible = True
				lstThings.Visible = True
				btnLibrary.Text = "Insert item from library"
				btnLibrary.Visible = True
				ListItems()
			Case bdTriggers
				txtStatements.Visible = False
				fraStatementEditor.Visible = False
				btnEdit.Visible = True
				lstThings.Visible = True
				btnLibrary.Text = "Insert trigger from library"
				btnLibrary.Visible = True
				ListTriggers()
		End Select
		' [Titi 2.5.1]
		frmTriggerProp_Resize(Me, New System.EventArgs())
	End Sub
	
	'UPGRADE_WARNING: Event txtComments.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtComments_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtComments.TextChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtName.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtName_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtName.TextChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtSkillPoints.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtSkillPoints_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSkillPoints.TextChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtStatements.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtStatements_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtStatements.TextChanged
		SetDirty(True)
		'    txtStatements_AutoComplete
	End Sub
	
	Private Sub txtStatements_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtStatements.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		If KeyCode = System.Windows.Forms.Keys.Return Then
			FindStatement(False, True)
		ElseIf (Shift And VB6.ShiftConstants.CtrlMask) > 0 Then 
			Select Case KeyCode
				Case 88, 120 ' X-Cut
					CutThing()
				Case 67, 99 ' C-Copy
					CopyThing()
				Case 86, 118 ' V-Paste
					PasteThing()
					My.Computer.Clipboard.Clear()
			End Select
		End If
	End Sub
	
	Private Sub txtStatements_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtStatements.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Select Case KeyCode
			Case System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.PageUp, System.Windows.Forms.Keys.PageDown
				FindStatement(True, True)
			Case Else
				If frmMDI.blnAutoComplete Then txtStatements_AutoComplete()
		End Select
	End Sub
	
	Private Sub txtStatements_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles txtStatements.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		FindStatement(True, True) ', -1
		lstAutoComplete.Items.Clear()
		lstAutoComplete.Visible = False
	End Sub
	
	'UPGRADE_WARNING: Event txtTurns.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtTurns_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTurns.TextChanged
		SetDirty(True)
	End Sub
	
	Private Sub txtStatements_AutoComplete()
		Dim oErr As Object
		Dim EndPos, StartPos, c As Integer
		Dim j, i, k As Short
		Dim strParseExample, sText As String
		Dim aParse() As String
		Dim bParse() As String
		Dim Found As Boolean
		Dim InsertAt As Integer
		On Error GoTo ErrorHandler
		System.Windows.Forms.Application.DoEvents() ' make sure the SendKeys function is finished
		lstAutoComplete.Visible = False
		lstAutoComplete.Items.Clear()
		' Locate insertion point
		InsertionAt(StartPos, EndPos, InsertAt)
		'    sText = Mid$(txtStatements.Text, Startpos, Endpos - Startpos + 1)
		sText = Mid(txtStatements.Text, StartPos, InsertAt - StartPos + 1)
		If sText = "" Then Exit Sub ' nothing to look for
		' Find corresponding instruction
		For i = 0 To bdStatementCount
			If UCase(sText) = UCase(VB.Left(strStatements(i), InsertAt - StartPos + 1)) Then
				lstAutoComplete.Items.Add(strStatements(i))
				'        If UCase(sText) = UCase(Left$(Syntax(i, 0), EndPos - StartPos + 1)) Then
				'            lstAutoComplete.AddItem Syntax(i, 0)
				strParseExample = strParse(i)
				StatementX.Statement = i
			End If
		Next 
		' but if the user continued typing, no match could been found!
		If lstAutoComplete.Items.Count = 0 Then
			c = InStr(sText, Chr(32))
			If c = 0 Then Exit Sub ' space is the delimiter between keywords - if no space and no match, then statement is wrong
			For i = 0 To bdStatementCount
				If UCase(VB.Left(sText, c)) = UCase(strStatements(i)) Then
					'            If UCase(Left$(sText, c)) = UCase(Syntax(i, 0)) Then
					strParseExample = strParse(i)
					Exit For
				End If
			Next 
		End If
		aParse = Split(strParseExample, Chr(32)) ' how many words in the normal syntax
		bParse = Split(sText, Chr(32)) ' how many written so far
		' [Titi 2.4.9b] added a filter for read-only properties
		If Trim(VB.Right(sText, 5)) = "Into" Then
			' The destination Object.Property for Put, CopyText, DialogDice cannot be Read-Only
			bReadOnly = True
			'    Else
			'        bReadOnly = False
		End If
		If Trim(VB.Left(sText, 4)) = "Let" Then
			' The destination Object.Property Let cannot be Read-Only
			If UBound(bParse) = UBound(aParse) Then
				' we're at the right side of the "=" sign!
				bReadOnly = False
			Else
				' we're still at the left side of the "=" sign...
				bReadOnly = True
			End If
		End If
		If UBound(bParse) < UBound(aParse) - 1 Then
			' update the various dropdown lists, except the last one (if no error in FindStatement, then the text is automatically updated)
			FindStatement(True, True, -1)
		End If
		' fill in the relevant lists of objects and properties
		StatementToList(Tome, Area, TriggerX, StatementX, ListIndex, List)
		' determine where we are in the expected syntax (j is the position of the currently typed word, starts at 0)
		c = StartPos : j = 0
		'    If Endpos > Len(txtStatements.Text) Then Endpos = Len(txtStatements.Text)
		If InsertAt > Len(txtStatements.Text) Then InsertAt = Len(txtStatements.Text)
		For i = StartPos To InsertAt
			If Asc(Mid(txtStatements.Text, i, 1)) = 32 Then
				c = i + 1 ' save position
				j = j + 1 ' increase counter
			End If
		Next 
		If j > UBound(aParse) Then Exit Sub ' no more keyword for this instruction
		If lstAutoComplete.Items.Count > 1 Then
			AutoComplete_ShowList()
		Else 'If lstAutoComplete.ListCount = 0 Then
			' statement not found because user continued typing - display list of matching objects/properties etc...
			k = -1
			For i = 1 To UBound(bParse)
				If VB.Right(aParse(i), 1) = "/" Then k = k + 1 ' check which list of objects fits
			Next 
			If StatementX.Statement = 23 Or StatementX.Statement = 42 Then k = -1 ' special treatement of the runes list
			' k positive means list found, but we don't want to mess with syntax (no "/" at the end in the txt file) nor properties
			If k >= 0 And VB.Right(aParse(j), 1) = "/" And InStr(aParse(j), ".") = 0 Then
				lstAutoComplete.Items.Clear()
				i = 0
				' parsing issue with spaces in a name - replace " " by "_"
				If aParse(j) = Chr(34) & "Text1" & Chr(34) & "/" Then
					AddObjects("Text1", lstAutoComplete)
					lstAutoComplete.Items.Clear()
				End If
				' parsing issue with AwardExperience and CombatApplyDamage
				' the list is not at the same place as for the other statements
				If StatementX.Statement = 57 Or StatementX.Statement = 27 Then
					k = k - 1
				End If
				Do While i <= ListIndex(k)
					If List(k, i) <> "" Then lstAutoComplete.Items.Add(List(k, i))
					i = i + 1
				Loop 
			Else ' no matching list --> use var, properties or extra keywords
				If StatementX.Statement = 23 Or StatementX.Statement = 42 Then
					' processing runes list (varying number of objects!), might be the reason why the list is empty
					If Mid(txtStatements.Text, EndPos, 1) = ")" Then
						j = UBound(aParse) ' found an ending parenthesis, therefore list is finished
					End If
				End If
				lstAutoComplete.Items.Clear()
				FillList(aParse(j), lstAutoComplete)
			End If
			i = -1
			While i < lstAutoComplete.Items.Count - 1
				Found = False
				i = i + 1
				k = IIf(VB.Left(VB6.GetItemString(lstAutoComplete, i), 1) = ",", 2, 1) ' a comma is appended to the rune name
				'            If UCase(Mid$(lstAutoComplete.List(i), k, Endpos - c + 1)) = UCase(Mid$(txtStatements.Text, c, Endpos - c + 1)) Then
				If UCase(Mid(VB6.GetItemString(lstAutoComplete, i), k, InsertAt - c + 1)) = UCase(Mid(txtStatements.Text, c, InsertAt - c + 1)) Then
					Found = True
				End If
				If Not Found Then
					' object not supported by the engine, remove from the list
					lstAutoComplete.Items.RemoveAt(i)
					i = i - 1
				End If
			End While
			If lstAutoComplete.Items.Count = 0 Then
				' no object matches - this means we're now looking at properties
				'            sText = Mid$(txtStatements.Text, Startpos, Endpos - Startpos + 1)
				sText = Mid(txtStatements.Text, StartPos, InsertAt - StartPos + 1)
				' this is in case we modify an existing trigger: InStrRev may not give the correct "."
				' so we need to make sure we're working on the current line
				If InStrRev(sText, ".") > 0 Then
					sText = Mid(sText, InStrRev(sText, " ") + 1, InStrRev(sText, ".") - InStrRev(sText, " ") - 1)
				End If
				AddProperties(sText, lstAutoComplete)
				i = -1
				' this is in case we modify an existing trigger: InStrRev may not give the correct "."
				' so we need to make sure we're working on the current line
				'            sText = Mid$(txtStatements.Text, Startpos, Endpos - Startpos + 1)
				sText = Mid(txtStatements.Text, StartPos, InsertAt - StartPos + 1)
				sText = UCase(Mid(sText, InStrRev(sText, ".") + 1, EndPos - InStrRev(sText, ".") + 1))
				While i < lstAutoComplete.Items.Count - 1
					Found = False
					i = i + 1
					If UCase(VB.Left(VB6.GetItemString(lstAutoComplete, i), Len(sText))) = sText Then
						Found = True
					End If
					If Not Found Or VB6.GetItemString(lstAutoComplete, i) = "<Reserved>" Then ' object not supported by the engine, remove from the list
						lstAutoComplete.Items.RemoveAt(i)
						i = i - 1
					End If
				End While
			End If
			AutoComplete_ShowList()
		End If
		Exit Sub
ErrorHandler: 
		If Err.Number = 5 Then
			' probably a punctuation sign, and the statement cannot be recognized
			Resume Next
		Else
			' log the error
			'UPGRADE_WARNING: Couldn't resolve default property of object oErr.logError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			oErr.logError("txtStatements_AutoComplete" & vbLf & "Error #" & Err.Number & " (" & Err.Description & ")")
		End If
	End Sub
	
	Private Sub FillList(ByRef strParameter As String, ByRef lstAutoComplete As System.Windows.Forms.ListBox)
		Dim i As Short
		Dim strObject As String
		If VB.Right(strParameter, 1) <> "/" Then strParameter = strParameter & "/"
		' the / character is first used to determine if we deal with objects (in which case a specific list, depending on the statement, applies)
		' afterwards, it's used as a separator between possible keywords
		While InStr(strParameter, "/") > 0
			strObject = VB.Left(strParameter, InStr(strParameter, "/") - 1)
			strParameter = VB.Right(strParameter, Len(strParameter) - Len(strObject) - 1)
			If InStr(strObject, ".") > 0 Then
				' case of Object.Property
				AddObjects("Creature", lstAutoComplete)
				If bReadOnly = False Then AddObjects("Dice", lstAutoComplete)
				AddObjects("Encounter", lstAutoComplete)
				AddObjects("Global", lstAutoComplete)
				AddObjects("Item", lstAutoComplete)
				AddObjects("Local", lstAutoComplete)
				AddObjects("Map", lstAutoComplete)
				If bReadOnly = False Then AddObjects("Neg", lstAutoComplete)
				If bReadOnly = False Then AddObjects("Pos", lstAutoComplete)
				If bReadOnly = False Then AddObjects("Random", lstAutoComplete)
				AddObjects("Tile", lstAutoComplete)
				AddObjects("Tome", lstAutoComplete)
				AddObjects("Trigger", lstAutoComplete)
			Else
				AddObjects(strObject, lstAutoComplete)
			End If
		End While
	End Sub
	
	Private Sub AutoComplete_ShowList()
		Dim X, Y As Integer
		' Propose to complete the statement
		Dim Pos As POINTAPI
		If lstAutoComplete.Items.Count > 0 Then
			GetCaretPos(Pos)
			X = (Pos.X + 1) * VB6.TwipsPerPixelX : Y = (Pos.Y + 15) * VB6.TwipsPerPixelY
			If X + VB6.PixelsToTwipsX(lstAutoComplete.Width) > VB6.PixelsToTwipsX(txtStatements.Width) Then X = VB6.PixelsToTwipsX(txtStatements.Width) - VB6.PixelsToTwipsX(lstAutoComplete.Width)
			If Y + VB6.PixelsToTwipsY(lstAutoComplete.Height) > VB6.PixelsToTwipsY(txtStatements.Height) Then Y = VB6.PixelsToTwipsY(txtStatements.Height) - VB6.PixelsToTwipsY(lstAutoComplete.Height)
			lstAutoComplete.SetBounds(VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(txtStatements.Left) + X), VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(txtStatements.Top) + Y), 0, 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y)
			lstAutoComplete.Visible = True
		End If
	End Sub
	
	Private Function InsertionAt(ByRef StartPos As Integer, ByRef EndPos As Integer, ByRef InsertAt As Integer) As Object
		Dim c As Integer
		' Find start of a line
		StartPos = 0
		If txtStatements.SelectionStart < 2 Then
			' Start of the first line
			StartPos = 1
		ElseIf Mid(txtStatements.Text, txtStatements.SelectionStart - 1, 2) = Chr(13) & Chr(10) Then 
			' Start of a line other than first
			StartPos = txtStatements.SelectionStart + 1
		Else
			' Midpoint of a line
			For c = txtStatements.SelectionStart To 2 Step -1
				If Mid(txtStatements.Text, c - 1, 2) = Chr(13) & Chr(10) Then
					StartPos = c + 1
					Exit For
				End If
			Next c
			' Midpoint of the first line
			If StartPos = 0 Then
				StartPos = 1
			End If
		End If
		' Find end of the line
		EndPos = 0
		For c = StartPos To Len(txtStatements.Text) - 1
			If Mid(txtStatements.Text, c, 2) = Chr(13) & Chr(10) Then
				EndPos = c - 1
				Exit For
			End If
		Next c
		' End of the last line
		If EndPos = 0 Then
			EndPos = Len(txtStatements.Text)
		End If
		InsertAt = EndPos
		' however, if we're correcting a statement, what's interesting is the position of the cursor
		If InsertAt > txtStatements.SelectionStart + txtStatements.SelectionLength And txtStatements.SelectionStart > 0 Then InsertAt = txtStatements.SelectionStart + txtStatements.SelectionLength
	End Function
	
	Public Function IsReadOnly(ByRef intObject As Short, ByRef intProperty As Short) As Boolean
		Dim bReadOnly As Boolean
		Select Case intObject
			Case 0 ' Tome
				Select Case intProperty
					Case 0 ' PartyCount
						bReadOnly = True
					Case 4, 5 ' MapX, MapY
						bReadOnly = True
					Case 14 To 17 ' RealSeconds, Minutes, Hours, Days
						bReadOnly = True
					Case Else
						bReadOnly = False
				End Select
			Case 1 ' Map
				Select Case intProperty
					Case 7, 8 ' Height, Left
						bReadOnly = True
					Case 31 To 34 ' Top, Width, IsOutsideMap, Style
						bReadOnly = True
					Case Else
						bReadOnly = False
				End Select
			Case 2 To 6 ' Tile
				Select Case intProperty
					Case 0 To 3 ' CanSeeDown, Left, Right, Up
						bReadOnly = True
					Case 6 To 9 ' IsBlockedDown, Left, Right, Up
						bReadOnly = True
					Case 16 To 20 ' Name, Style, DoorTileName, Movement, TerrainType
						bReadOnly = True
					Case Else
						bReadOnly = False
				End Select
			Case 7 To 11 ' Encounter
				Select Case intProperty
					Case 4 ' Classification
						bReadOnly = True
					Case 18, 19 ' CreatureCount, ItemCount
						bReadOnly = True
					Case Else
						bReadOnly = False
				End Select
			Case 12 To 16 ' Creature
				Select Case intProperty
					Case 0 To 15 ' BodyType1 to 8, Resistance1 to 8
						bReadOnly = True
					Case 19, 20 ' ExperiencePoints, ExperienceLevel
						bReadOnly = True
					Case 32 To 39 ' ResistanceSharp, Blunt, Cold, Fire, Evil, Holy, Magic, Mind
						bReadOnly = True
					Case 40 To 43 ' AgeYear, AgeMoon, AgeCycle, AgeTurn [Titi 2.5.1]
						bReadOnly = True
					Case 76, 77 ' MapX, MapY
						bReadOnly = True
					Case 90 ' ScarletLetter
						bReadOnly = True
					Case 95 ' Attack
						bReadOnly = True
					Case 101, 102, 146 ' RangeToTarget, ActionPointsMax (102 and 146 ???)
						bReadOnly = True
					Case 133 To 136 ' EterniumMax, WeightMax, Weight, Bulk
						bReadOnly = True
					Case 144 ' IsSpellCaster
						bReadOnly = True
					Case 151 To 154 ' PronounHeShe, HimHer, HisHer, MovementCost
						bReadOnly = True
					Case 156 ' Index
						bReadOnly = True
					Case Else
						bReadOnly = False
				End Select
			Case 17 To 21 ' Item
				Select Case intProperty
					Case 3 ' ArmorType
						bReadOnly = True
					Case 22, 23 ' IsWeaponMelee, IsWeaponRanged
						bReadOnly = True
					Case 25 ' IsWeaponThrown
						bReadOnly = True
					Case 50, 51 ' MapX, MapY
						bReadOnly = True
					Case 60 ' IsInHand
						bReadOnly = True
					Case Else
						bReadOnly = False
				End Select
			Case 22 To 26 ' Trigger
				If intProperty = 22 Or intProperty = 24 Then
					' TriggerType, SkillLevel
					bReadOnly = True
				Else
					bReadOnly = False
				End If
			Case 27 ' Local
				bReadOnly = False
			Case 28 ' Global
				Select Case intProperty
					Case 0, 1 ' False, True
						bReadOnly = True
					Case 3, 4 ' DieTypeRoll, DieCountRoll
						bReadOnly = True
					Case 8 ' Offer
						bReadOnly = True
					Case 71 ' HitLocation
						bReadOnly = True
					Case Else
						bReadOnly = False
				End Select
			Case Else ' Pos (29), Neg (30), Dice (31), Random (32)
				bReadOnly = True
		End Select
		IsReadOnly = bReadOnly
	End Function
	
	Private Sub AddProperties(ByRef strObject As String, ByRef lstAutoComplete As System.Windows.Forms.ListBox)
		Dim i As Short
		' don't use "handle"
		On Error Resume Next ' if the length of strObject is less then 6 for example...
		If VB.Right(strObject, 1) >= "A" And VB.Right(strObject, 1) <= "C" Then strObject = VB.Left(strObject, Len(strObject) - 1)
		If VB.Right(strObject, 3) = "Now" Then strObject = VB.Left(strObject, Len(strObject) - 3)
		If VB.Right(strObject, 6) = "Target" Then strObject = VB.Left(strObject, Len(strObject) - 6)
		strObject = UCase(VB.Left(strObject, 1)) & LCase(VB.Right(strObject, Len(strObject) - 1))
		' [Titi 2.4.9b] Added all the tests for ReadOnly
		Select Case strObject
			Case "Tome"
				For i = 0 To 17
					If IsReadOnly(0, i) = False Or bReadOnly = False Then
						lstAutoComplete.Items.Add(VarToText(0, i))
					End If
				Next 
			Case "Map"
				For i = 0 To 34
					If IsReadOnly(1, i) = False Or bReadOnly = False Then
						lstAutoComplete.Items.Add(VarToText(1, i))
					End If
				Next 
			Case "Tile"
				For i = 0 To 20
					If IsReadOnly(2, i) = False Or bReadOnly = False Then
						lstAutoComplete.Items.Add(VarToText(2, i))
					End If
				Next 
			Case "Encounter"
				For i = 0 To 20
					If IsReadOnly(7, i) = False Or bReadOnly = False Then
						lstAutoComplete.Items.Add(VarToText(7, i))
					End If
				Next 
			Case "Creature"
				For i = 0 To 161
					If IsReadOnly(12, i) = False Or bReadOnly = False Then
						lstAutoComplete.Items.Add(VarToText(12, i))
					End If
				Next 
			Case "Item"
				For i = 0 To 65
					If IsReadOnly(17, i) = False Or bReadOnly = False Then
						lstAutoComplete.Items.Add(VarToText(17, i))
					End If
				Next 
			Case "Trigger"
				For i = 0 To 24
					If IsReadOnly(22, i) = False Or bReadOnly = False Then
						lstAutoComplete.Items.Add(VarToText(22, i))
					End If
				Next 
			Case "Local"
				For i = 0 To 13
					lstAutoComplete.Items.Add(VarToText(27, i))
				Next 
			Case "Global"
				For i = 0 To 73
					If IsReadOnly(28, i) = False Or bReadOnly = False Then
						lstAutoComplete.Items.Add(VarToText(28, i))
					End If
				Next 
			Case "Neg", "Pos"
				For i = 0 To 255
					lstAutoComplete.Items.Add(VB.Right("000" & VarToText(29, i), 3))
				Next 
			Case "Dice"
				For i = 0 To 255
					lstAutoComplete.Items.Add(VarToText(31, i))
				Next 
			Case "Random"
				For i = 0 To 255
					lstAutoComplete.Items.Add(VB.Right("000" & VarToText(32, i), 3))
				Next 
		End Select
		'   bReadOnly = False
	End Sub
	
	Private Sub AddObjects(ByRef strObject As String, ByRef lstAutoComplete As System.Windows.Forms.ListBox)
		Dim j, i, c As Short
		Dim sText, sPunctuation As String
		' remove quotes
		If Asc(strObject) = 34 Then strObject = Mid(strObject, 2, Len(strObject) - 2)
		Select Case UCase(VB.Left(strObject, 1)) & LCase(VB.Right(strObject, Len(strObject) - 1))
			Case "R#", "|r#", "|r#)"
				sText = VB.Right(strRunesList, Len(strRunesList) - 5) ' get rid of "List="
				For i = 1 To intNbRunes - 1
					sPunctuation = ""
					If VB.Left(strObject, 1) = "|" Then sPunctuation = ","
					sPunctuation = sPunctuation & VB.Left(sText, InStr(sText, ",") - 1)
					If VB.Right(strObject, 1) = ")" Then sPunctuation = sPunctuation & ") "
					lstAutoComplete.Items.Add(sPunctuation)
					sText = VB.Right(sText, Len(sText) - Len(VB.Left(sText, InStr(sText, ",") - 1)) - 1)
				Next 
				If VB.Left(strObject, 1) = "|" Then sText = "," & sText
				If VB.Right(strObject, 1) = ")" Then sText = sText & ") "
				lstAutoComplete.Items.Add(sText)
			Case "At"
				lstAutoComplete.Items.Add("At²(")
			Case "|"
				lstAutoComplete.Items.Add(",")
			Case "Text1", "Text2", "Text3"
				i = 0 : c = 0
				' [Titi 2.5.1] CopyTile and TargetEncounter will now use pre-defined lists
				If StatementX.Statement = 21 Or StatementX.Statement = 67 Then
					c = 1
				ElseIf StatementX.Statement = 49 Then 
					' [Titi 2.5.1] new statement: TargetEncounterInArea
					If strObject = "Text2" Then
						c = 1
					ElseIf strObject = "Text3" Then 
						c = 2
					End If
				End If
				Do While i <= ListIndex(c)
					If List(c, i) <> "" Then
						' parsing issue: replace the spaces by ² (temporarily)
						For j = 1 To Len(List(c, i))
							If Mid(List(c, i), j, 1) = " " Then Mid(List(c, i), j, 1) = "²"
						Next 
						' [Titi 2.5.1] for TargetEncounterInArea, CopyTile and TargetEncounter, quotes are added even the object is taken out from a list
						If StatementX.Statement = 49 Or c = 1 Then
							lstAutoComplete.Items.Add(Chr(34) & List(c, i) & Chr(34))
						Else
							lstAutoComplete.Items.Add(List(c, i))
						End If
					End If
					i = i + 1
				Loop 
			Case "Text"
				lstAutoComplete.Items.Add("Text")
			Case "Compare", "Operation"
				lstAutoComplete.Items.Add("=")
				lstAutoComplete.Items.Add("+")
				lstAutoComplete.Items.Add("-")
				lstAutoComplete.Items.Add("*")
				lstAutoComplete.Items.Add("/")
				lstAutoComplete.Items.Add(">")
				lstAutoComplete.Items.Add("<")
				lstAutoComplete.Items.Add(">=")
				lstAutoComplete.Items.Add("<=")
				lstAutoComplete.Items.Add("Or")
				lstAutoComplete.Items.Add("And")
				lstAutoComplete.Items.Add("XOr")
				lstAutoComplete.Items.Add("Like")
				lstAutoComplete.Items.Add("<>")
			Case "Local", "Global", "Tome", "Party", "Any"
				lstAutoComplete.Items.Add(strObject)
			Case "Neg", "Pos", "Random", "Dice"
				If bReadOnly = False Then
					lstAutoComplete.Items.Add(strObject)
				End If
			Case "Creature"
				lstAutoComplete.Items.Add("CreatureA")
				lstAutoComplete.Items.Add("CreatureB")
				lstAutoComplete.Items.Add("CreatureC")
				lstAutoComplete.Items.Add("CreatureNow")
				lstAutoComplete.Items.Add("CreatureTarget")
			Case "Item"
				lstAutoComplete.Items.Add("ItemA")
				lstAutoComplete.Items.Add("ItemB")
				lstAutoComplete.Items.Add("ItemC")
				lstAutoComplete.Items.Add("ItemNow")
				lstAutoComplete.Items.Add("ItemTarget")
			Case "Encounter"
				lstAutoComplete.Items.Add("EncounterA")
				lstAutoComplete.Items.Add("EncounterB")
				lstAutoComplete.Items.Add("EncounterC")
				lstAutoComplete.Items.Add("EncounterNow")
				lstAutoComplete.Items.Add("EncounterTarget")
			Case "Tile"
				lstAutoComplete.Items.Add("TileA")
				lstAutoComplete.Items.Add("TileB")
				lstAutoComplete.Items.Add("TileC")
				lstAutoComplete.Items.Add("TileNow")
				lstAutoComplete.Items.Add("TileTarget")
			Case "Trigger"
				lstAutoComplete.Items.Add("TriggerA")
				lstAutoComplete.Items.Add("TriggerB")
				lstAutoComplete.Items.Add("TriggerC")
				lstAutoComplete.Items.Add("TriggerNow")
				lstAutoComplete.Items.Add("TriggerTarget")
			Case Else ' either a statement or a keyword - in both cases add an ending space
				lstAutoComplete.Items.Add(strObject & " ")
		End Select
	End Sub
	
	'UPGRADE_WARNING: Event lstAutoComplete.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstAutoComplete_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstAutoComplete.SelectedIndexChanged
		'    On Error Resume Next
		Dim EndPos, StartPos, InsertAt As Integer
		Dim c As Short
		InsertionAt(StartPos, EndPos, InsertAt)
		txtStatements.Focus()
		' remove characters already typed
		For c = InsertAt To StartPos Step -1
			If Asc(Mid(txtStatements.Text, c, 1)) <> 32 And Mid(txtStatements.Text, c, 1) <> "." Then
				System.Windows.Forms.SendKeys.Send("{BACKSPACE}")
			Else
				Exit For
			End If
		Next 
		' copy selected command
		If lstAutoComplete.Text = "Text" Then
			System.Windows.Forms.SendKeys.Send(Chr(34) & Chr(34) & "{LEFT}")
		Else
			For c = 1 To Len(lstAutoComplete.Text)
				If Mid(lstAutoComplete.Text, c, 1) = "(" Or Mid(lstAutoComplete.Text, c, 1) = ")" Or Mid(lstAutoComplete.Text, c, 1) = "+" Then
					System.Windows.Forms.SendKeys.Send("{" & Mid(lstAutoComplete.Text, c, 1) & "}")
				Else
					System.Windows.Forms.SendKeys.Send(Mid(lstAutoComplete.Text, c, 1))
				End If
			Next 
		End If
		lstAutoComplete.Items.Clear()
		lstAutoComplete.Visible = False
	End Sub
End Class