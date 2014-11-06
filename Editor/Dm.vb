Option Strict Off
Option Explicit On
Module modDM
	
	Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
	
	Public TriggerStatementState As Short
	
	Public Syntax(bdStatementCount, 7) As String
	Public SyntaxIndex(bdStatementCount, 7) As Byte
	
	Public Const bdTrigAll As Short = 0
	Public Const bdTrigEncounter As Short = 1
	Public Const bdTrigItem As Short = 2
	Public Const bdTrigCreatureSkill As Short = 3
	Public Const bdTrigCreature As Short = 4
	Public Const bdTrigTopic As Short = 5
	Public Const bdTrigTheme As Short = 6
	Public Const bdTrigTome As Short = 7
	Public Const bdTrigTrig As Short = 8
	Public Const bdTrigTile As Short = 9
	
	Public Const bdEditMap As Short = 1
	Public Const bdEditDoor As Short = 2
	Public Const bdEditEncounter As Short = 3
	Public Const bdEditCreature As Short = 4
	Public Const bdEditItem As Short = 5
	Public Const bdEditTrigger As Short = 6
	Public Const bdEditStatement As Short = 7
	Public Const bdEditTile As Short = 8
	Public Const bdEditConvo As Short = 9
	Public Const bdEditTopic As Short = 10
	Public Const bdEditTheme As Short = 11
	Public Const bdEditMapGraphic As Short = 12
	Public Const bdEditMapDoors As Short = 13
	Public Const bdEditMapThemes As Short = 14
	Public Const bdEditMapEncounters As Short = 15
	Public Const bdEditTileSet As Short = 16
	Public Const bdEditSkill As Short = 17
	Public Const bdEditFactoid As Short = 18
	Public Const bdEditMapTileSets As Short = 19
	Public Const bdEditMapTiles As Short = 20
	Public Const bdEditTome As Short = 21
	Public Const bdEditTomeParty As Short = 22
	Public Const bdEditTomeJournals As Short = 23
	Public Const bdEditTomeTriggers As Short = 24
	Public Const bdEditEntryPoint As Short = 25
	Public Const bdEditMapEntryPoints As Short = 26
	Public Const bdEditTomeAreas As Short = 27
	Public Const bdEditArea As Short = 28
	Public Const bdEditJournal As Short = 29
	Public Const bdEditTomeFactoids As Short = 30
	Public Const bdEditData As Short = 31 ' [Titi] 2.4.6
	Public Const bdEditMapCreatures As Short = 32 ' [Titi 2.5.1] wandering monsters
	
	Structure TileList
		Dim TileX As Tile
		Dim X As Short
		Dim Y As Short
	End Structure
	
	Public Sub BuildTriggerList(ByRef cmbTriggerList As System.Windows.Forms.ComboBox, ByRef TrigType As Short)
		Dim c As Short
		For c = 0 To bdNbTriggers ' [Titi 2.4.9] changed from 77 to constant
			Select Case TrigType
				Case bdTrigTome
					Select Case c
						Case bdNone, bdPostTurnCycle, bdPostEnterTome, bdPreExitTome, bdPostApplyDamage, bdPreCombat, bdPostCombat, bdOnListen, bdOnRealTime, bdOnEnterHome
							cmbTriggerList.Items.Add(New VB6.ListBoxItem(TriggerName(c), c))
					End Select
				Case bdTrigTopic
					Select Case c
						Case bdNone, bdPreTopic, bdPostTopic
							cmbTriggerList.Items.Add(New VB6.ListBoxItem(TriggerName(c), c))
					End Select
				Case bdTrigEncounter, bdTrigTheme
					Select Case c
						Case bdNone, bdPostTurnCycle, bdPostEnterEncounter, bdPreSearch, bdPostSearch, bdPreTake, bdPostTake, bdPreUseInEncounter, bdPostUseInEncounter, bdOnIgnore, bdOnListen, bdPostStepEncounter, bdPreExitTome, bdPreCombat, bdPreSearchTraps, bdPostSearchTraps, bdPostCombat, bdPreEnterEncounter, bdPreUnlock, bdPreOpen, bdPreCombatStep, bdPostCombatStep, bdPreCast, bdOnRealTime
							cmbTriggerList.Items.Add(New VB6.ListBoxItem(TriggerName(c), c))
					End Select
				Case bdTrigItem
					Select Case c
						Case bdNone, bdPostTurnCycle, bdPreDropItem, bdPostDropItem, bdPreExamine, bdPostExamine, bdPreSplit, bdPostSplit, bdPreCombine, bdOnCombine, bdPostCombine, bdPreReady, bdPostReady, bdPreUnReady, bdPostUnReady, bdOnUseOnCreature, bdPreUseOnItem, bdOnUseOnItem, bdPostUseOnItem, bdOnUseInEncounter, bdPreRollAttack, bdPostRollAttack, bdPreRollArmorChit, bdPostRollArmorChit, bdPreAttacked, bdPostAttacked, bdPreRollDamage, bdPostRollDamage, bdPreApplyDamage, bdPostApplyDamage, bdPreDeath, bdPostDeath, bdPreCombatMove, bdPostCombatMove, bdPreSearchTraps, bdPostSearchTraps, bdPreTake, bdPostTake, bdPreTurn, bdPostTurn, bdPrePickLock, bdPreUnlock, bdPreSellItem, bdPostSellItem, bdPreBuyItem, bdPostBuyItem, bdPostAttack, bdPreCombatStep, bdPostCombatStep, bdPreCast
							cmbTriggerList.Items.Add(New VB6.ListBoxItem(TriggerName(c), c))
					End Select
				Case bdTrigCreature
					Select Case c
						Case bdNone, bdPostTurnCycle, bdPreUseOnCreature, bdPostUseOnCreature, bdOnAttack, bdOnSkillUse, bdOnCast, bdPostAttacked, bdPreRollAttack, bdPreReady, bdPostReady, bdPreUnReady, bdPostUnReady, bdPreApplyDamage, bdPostApplyDamage, bdPostRollAttack, bdPreRollArmorChit, bdPreAttacked, bdPreTurn, bdPostTurn, bdPreExamine, bdPostExamine, bdPrePickLock, bdPreSellItem, bdPostSellItem, bdPreBuyItem, bdPostBuyItem, bdPreSearchTraps, bdPostSearchTraps, bdPreDeath, bdPostDeath, bdPostNewCharacter, bdPostAttack, bdPreCombatStep, bdPostCombatStep, bdOnSkillTarget, bdOnCastTarget, bdPreCast, bdPreRollDamage, bdPostRollDamage, bdOnStatus, bdOnRealTime, bdOnEnterHome, bdShowNewStat
							cmbTriggerList.Items.Add(New VB6.ListBoxItem(TriggerName(c), c))
					End Select
				Case bdTrigTrig
					cmbTriggerList.Items.Add(New VB6.ListBoxItem(TriggerName(c), c))
			End Select
		Next c
	End Sub
	
	Public Function ParseStatement(ByRef TomeX As Tome, ByRef AreaX As Area, ByRef TrigX As Trigger, ByRef StmtX As Statement, ByVal Text As String) As String
		Dim c, LastPos As Integer
		Dim i, j, w, k, Index As Short
		Dim Found, w2 As Short
		' [Titi 2.4.8] replace the underscore character by a space
		' [Titi 2.6.1] now use ² instead, so that both "_" &nd " " can be used in files names.
		For c = 1 To Len(Text)
			If Mid(Text, c, 1) = "²" Then Mid(Text, c, 1) = " "
		Next 
		' [Titi 2.4.8] Remove extra 0
		c = 1
		Do Until c > Len(Text) - 2
			If Mid(Text, c, 2) = ".0" And Mid(Text, c + 2, 1) <> " " And Mid(Text, c + 2, 1) <> Chr(13) And Mid(Text, c + 2, 1) <> ")" Then ' [Titi 2.4.9b] check if the last character is a closing parenthesis added.
				Text = Left(Text, c) & Mid(Text, c + 2)
			Else
				c = c + 1
			End If
		Loop 
		' Strip out any extra spaces or spaces after an apostrophe (not a comment)
		c = 1
		Do Until c > Len(Text)
			If Mid(Text, c, 2) = "  " Then
				Text = Left(Text, c) & Mid(Text, c + 2)
			Else
				c = c + 1
			End If
		Loop 
		Text = Trim(Text)
		' If Text is now empty, exit without error
		If Len(Text) = 0 Then
			Exit Function
		End If
		' Parse the statement
		c = 1 : w = 0 : LastPos = 1 : ParseStatement = ""
		Do Until c > Len(Text) Or w > 7
			If Mid(Text, c, 1) = "\" Then c = c + 1
			If Mid(Text, c, 1) = " " Or c = Len(Text) Then
				If c = Len(Text) Then c = c + 1
				If w = 0 Then ' Statement Type
					Found = False
					For i = 0 To bdStatementCount
						If UCase(Mid(Text, LastPos, c - LastPos)) = UCase(Syntax(i, 0)) Then
							StmtX.Statement = i
							w = w + 1
							Found = True
							Exit For
						End If
					Next i
					If Found = False Then
						ParseStatement = "Error: Invalid statement type (" & Mid(Text, LastPos, c - LastPos) & ")"
						Exit Function
					End If
				Else ' Additional Syntax
					Index = SyntaxIndex(StmtX.Statement, w)
					Select Case Syntax(StmtX.Statement, w)
						Case "Var" ' Context.Var
							k = InStr(LastPos + 1, Text, ".")
							If k > 0 Then
								' Context
								Found = False
								For i = 0 To 32
									If UCase(Trim(Mid(Text, LastPos, k - LastPos))) = UCase(ContextToText(i)) Then
										StmtX.B(Index) = i
										Found = True
										Exit For
									End If
								Next i
								If Found = False Then
									ParseStatement = "Error: Invalid variable object (" & Mid(Text, LastPos, k - LastPos) & ")"
									Exit Function
								End If
								' Var
								Found = False
								For i = 0 To 255
									If UCase(Trim(Mid(Text, k + 1, c - k - 1))) = UCase(VarToText(StmtX.B(Index), i)) Then
										StmtX.B(Index + 1) = i
										Found = True
										If frmTriggerProp.IsReadOnly(StmtX.B(Index), i) Then
											' [Titi 2.6.0] that's a read-only property: check if it's valid here
											Select Case StmtX.Statement
												Case 12 ' Put
													If Index = 5 Then Found = False
												Case 22, 38, 39, 51, 53 ' CopyText, DialogAccept, DialogDice, DialogAcceptText, Let
													If Index = 0 Then Found = False
											End Select
										End If
										w = w + 1
									End If
								Next i
								If Found = False Then
									ParseStatement = "Error: Invalid variable property (" & Mid(Text, k + 1, c - k - 1) & ")?"
									If frmTriggerProp.IsReadOnly(StmtX.B(Index), i) Then ' [Titi 2.6.0] explain the error
										ParseStatement = "Error: " & ContextToText(StmtX.B(Index)) & "." & Mid(Text, k + 1, c - k - 1) & " is a read-only property."
									End If
									Exit Function
								End If
							Else
								ParseStatement = "Error: Expected a variable object"
								Exit Function
							End If
						Case "Op" ' Operator
							Found = False
							For i = 0 To 13
								If UCase(Trim(Mid(Text, LastPos, c - LastPos))) = UCase(OpToText(i)) Then
									StmtX.B(Index) = i
									Found = True
									w = w + 1
									Exit For
								End If
							Next i
							If Found = False Then
								ParseStatement = "Error: Invalid operator (" & Mid(Text, LastPos, c - LastPos) & ")"
								Exit Function
							End If
						Case "Text1", "Text2", "Text3", "Text4" ' Text
							' Check for starting single quote
							If Mid(Text, LastPos, 1) = Chr(34) Then
								' Check for ending single quote
								k = InStr(LastPos + 1, Text, Chr(34))
								If k > 0 Then
									Select Case Index
										Case 0
											If Len(StmtX.Text) > 0 Then
												StmtX.Text = Mid(Text, LastPos + 1, k - LastPos - 1) & StmtX.Text
											Else
												StmtX.Text = Mid(Text, LastPos + 1, k - LastPos - 1)
											End If
										Case 1
											StmtX.Text = StmtX.Text & "|" & Mid(Text, LastPos + 1, k - LastPos - 1)
									End Select
									w = w + 1
									c = k + 1
								Else
									ParseStatement = "Error: Expected an ending quote"
									Exit Function
								End If
							Else
								ParseStatement = "Error: Expected a starting quote"
								Exit Function
							End If
						Case "List1", "List2", "List3", "List4" ' List Match
							' If quoted list element, then resolve the end position
							If Mid(Text, LastPos, 1) = Chr(34) Then
								c = InStr(LastPos + 1, Text, Chr(34)) + 1
								If c = 0 Then
									ParseStatement = "Error: Expected an ending quote"
									Exit Function
								End If
							End If
							StatementToList(TomeX, AreaX, TrigX, StmtX, ListIndex, List)
							k = CDbl(Right(Syntax(StmtX.Statement, w), 1)) - 1
							Found = False
							For i = 0 To ListIndex(k)
								If UCase(Trim(Mid(Text, LastPos + IIf(StmtX.Statement = 49, 1, 0), c - LastPos - 2 * IIf(StmtX.Statement = 49, 1, 0)))) = UCase(List(k, i)) Then
									StmtX.B(Index) = i
									Found = True
									w = w + 1
									Exit For
								End If
							Next i
							If Found = False Then
								ParseStatement = "Error: Invalid object reference (" & Mid(Text, LastPos, c - LastPos) & ")"
								Exit Function
							End If
						Case "(Var)"
							' Check for starting single paren
							If Mid(Text, LastPos, 1) = "(" Then
								' Check for ending single quote
								k = InStr(LastPos + 1, Text, ")")
								If k > 0 Then
									LastPos = LastPos + 1
									c = LastPos : w2 = 0
									Do While c <= k
										If Mid(Text, c, 1) = "," Or c = k Then
											j = InStr(LastPos + 1, Text, ".")
											If j > 0 Then
												' Context
												Found = False
												For i = 0 To 32
													If UCase(Trim(Mid(Text, LastPos, j - LastPos))) = UCase(ContextToText(i)) Then
														StmtX.B(Index + w2) = i
														Found = True
														Exit For
													End If
												Next i
												If Found = False Then
													ParseStatement = "Error: Invalid variable object (" & Mid(Text, LastPos, j - LastPos) & ")"
													Exit Function
												End If
												' Var
												Found = False
												For i = 0 To 255
													If UCase(Trim(Mid(Text, j + 1, c - j - 1))) = UCase(VarToText(StmtX.B(Index + w2), i)) Then
														StmtX.B(Index + w2 + 1) = i
														w2 = w2 + 3
														LastPos = c + 1
														Found = True
														Exit For
													End If
												Next i
												If Found = False Then
													ParseStatement = "Error: Invalid variable property (" & Mid(Text, j + 1, c - j - 1) & ")?"
													Exit Function
												End If
											Else
												ParseStatement = "Error: Expected a variable object"
												Exit Function
											End If
										End If
										c = c + 1
									Loop 
									w = w + 1
									c = k + 1
								Else
									ParseStatement = "Error: Expected an ending parenthesis"
									Exit Function
								End If
							Else
								ParseStatement = "Error: Expected a starting parenthesis"
								Exit Function
							End If
						Case "(List)"
							' Check for starting single paren
							If Mid(Text, LastPos, 1) = "(" Then
								' Check for ending single quote
								k = InStr(LastPos + 1, Text, ")")
								If k > 0 Then
									LastPos = LastPos + 1
									c = LastPos : w2 = 0
									StatementToList(TomeX, AreaX, TrigX, StmtX, ListIndex, List)
									Do While c <= k And w2 < 6
										If Mid(Text, c, 1) = "," Or c = k Then
											Found = False
											For i = 0 To ListIndex(0)
												If UCase(Trim(Mid(Text, LastPos, c - LastPos))) = UCase(List(0, i)) Then
													StmtX.B(Index + w2) = i
													Found = True
													w2 = w2 + 1
													LastPos = c + 1
													Exit For
												End If
											Next i
											If Found = False Then
												ParseStatement = "Error: Invalid object reference (" & Mid(Text, LastPos, c - LastPos) & ")"
												Exit Function
											End If
										End If
										c = c + 1
									Loop 
									w = w + 1
									c = k + 1
								Else
									ParseStatement = "Error: Expected an ending parenthesis"
									Exit Function
								End If
							Else
								ParseStatement = "Error: Expected a starting parenthesis"
								Exit Function
							End If
						Case "Spec" ' Special Parsing
							Select Case StmtX.Statement
								Case 54 '' Text
									StmtX.Text = Mid(Text, LastPos)
									c = Len(Text)
									w = w + 1
							End Select
						Case Else ' Other expected/allowed tokens
							If UCase(Mid(Text, LastPos, c - LastPos)) = UCase(Syntax(StmtX.Statement, w)) Then
								If w >= SyntaxIndex(StmtX.Statement, 0) Then
									StmtX.B(Index) = 1
								End If
								w = w + 1
							Else
								ParseStatement = "Error: Expected '" & Syntax(StmtX.Statement, w) & "' instead of '" & Mid(Text, LastPos, c - LastPos) & "'"
								Exit Function
							End If
					End Select
				End If
				LastPos = c + 1
			End If
			c = c + 1
		Loop 
		' Check to make sure completed the syntax
		If w > 8 Then
			ParseStatement = "Error: Syntax error"
			Exit Function
		End If
		If SyntaxIndex(StmtX.Statement, 0) > w Then
			ParseStatement = "Error: Unexpected end of statement"
			Exit Function
		End If
	End Function
	
	Public Sub BuildSyntax()
		' Syntax building for parsing trigger statements. The first SyntaxIndex() indicates
		' how many required pieces of the syntax there are for the statement.
		' The other SyntaxIndex() value tell where to put the piece into the Statement object.
		Dim c As Short
		For c = 0 To bdStatementCount
			Select Case c
				Case 0 'None
					Syntax(c, 0) = "" : SyntaxIndex(c, 0) = 0
				Case 1 'Label [Context.Var]
					Syntax(c, 0) = "Label" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "Var" : SyntaxIndex(c, 1) = 0
				Case 2 'If [Context.Var] [Op] [Context.Var]
					Syntax(c, 0) = "If" : SyntaxIndex(c, 0) = 3
					Syntax(c, 1) = "Var" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "Op" : SyntaxIndex(c, 2) = 2
					Syntax(c, 3) = "Var" : SyntaxIndex(c, 3) = 3
				Case 3 'Else
					Syntax(c, 0) = "Else" : SyntaxIndex(c, 0) = 0
				Case 4 'ElseIf [Context.Var] [Op] [Context.Var]
					Syntax(c, 0) = "ElseIf" : SyntaxIndex(c, 0) = 3
					Syntax(c, 1) = "Var" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "Op" : SyntaxIndex(c, 2) = 2
					Syntax(c, 3) = "Var" : SyntaxIndex(c, 3) = 3
				Case 5 'And [Context.Var] [Op] [Context.Var]
					Syntax(c, 0) = "And" : SyntaxIndex(c, 0) = 3
					Syntax(c, 1) = "Var" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "Op" : SyntaxIndex(c, 2) = 2
					Syntax(c, 3) = "Var" : SyntaxIndex(c, 3) = 3
				Case 6 'Or [Context.Var] [Op] [Context.Var]
					Syntax(c, 0) = "Or" : SyntaxIndex(c, 0) = 3
					Syntax(c, 1) = "Var" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "Op" : SyntaxIndex(c, 2) = 2
					Syntax(c, 3) = "Var" : SyntaxIndex(c, 3) = 3
				Case 7 'EndIf
					Syntax(c, 0) = "EndIf" : SyntaxIndex(c, 0) = 0
				Case 8 'While [Context.Var] [Op] [Context.Var]
					Syntax(c, 0) = "While" : SyntaxIndex(c, 0) = 3
					Syntax(c, 1) = "Var" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "Op" : SyntaxIndex(c, 2) = 2
					Syntax(c, 3) = "Var" : SyntaxIndex(c, 3) = 3
				Case 9 'ForEach [List] In [List]
					Syntax(c, 0) = "ForEach" : SyntaxIndex(c, 0) = 3
					Syntax(c, 1) = "List1" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "In"
					Syntax(c, 3) = "List2" : SyntaxIndex(c, 3) = 1
				Case 10 'Next
					Syntax(c, 0) = "Next" : SyntaxIndex(c, 0) = 0
				Case 11 'Branch [Context.Var]
					Syntax(c, 0) = "Branch" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "Var" : SyntaxIndex(c, 1) = 0
				Case 12 'Put [Context.Var] [Op] [Context.Var] Into [Context.Var]
					Syntax(c, 0) = "Put" : SyntaxIndex(c, 0) = 5
					Syntax(c, 1) = "Var" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "Op" : SyntaxIndex(c, 2) = 2
					Syntax(c, 3) = "Var" : SyntaxIndex(c, 3) = 3
					Syntax(c, 4) = "Into"
					Syntax(c, 5) = "Var" : SyntaxIndex(c, 5) = 5
				Case 13 'Set [List] = [List]
					Syntax(c, 0) = "Set" : SyntaxIndex(c, 0) = 3
					Syntax(c, 1) = "List1" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "="
					Syntax(c, 3) = "List2" : SyntaxIndex(c, 3) = 1
				Case 14 'Select [Context.Var]
					Syntax(c, 0) = "Select" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "Var" : SyntaxIndex(c, 1) = 0
				Case 15 'Case [Context.Var]
					Syntax(c, 0) = "Case" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "Var" : SyntaxIndex(c, 1) = 0
				Case 16 'EndSelect
					Syntax(c, 0) = "EndSelect" : SyntaxIndex(c, 0) = 0
				Case 17 'Exit [List]
					Syntax(c, 0) = "Exit" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "List1" : SyntaxIndex(c, 1) = 0
				Case 18 'CopyCreature [List] Into [List]
					Syntax(c, 0) = "CopyCreature" : SyntaxIndex(c, 0) = 3
					Syntax(c, 1) = "List1" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "Into"
					Syntax(c, 3) = "List2" : SyntaxIndex(c, 3) = 1
				Case 19 'CopyItem [List] Into [List]
					Syntax(c, 0) = "CopyItem" : SyntaxIndex(c, 0) = 3
					Syntax(c, 1) = "List1" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "Into"
					Syntax(c, 3) = "List2" : SyntaxIndex(c, 3) = 1
				Case 20 'CopyTrigger [List] Into [List]
					Syntax(c, 0) = "CopyTrigger" : SyntaxIndex(c, 0) = 3
					Syntax(c, 1) = "List1" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "Into"
					Syntax(c, 3) = "List2" : SyntaxIndex(c, 3) = 1
				Case 21 'CopyTile 'Text' Level [List] At ([Context.Var],[Context.Var])
					Syntax(c, 0) = "CopyTile" : SyntaxIndex(c, 0) = 5
					Syntax(c, 1) = "Text1" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "Level"
					Syntax(c, 3) = "List1" : SyntaxIndex(c, 3) = 2
					Syntax(c, 4) = "At"
					Syntax(c, 5) = "(Var)" : SyntaxIndex(c, 5) = 0
				Case 22 'CopyText 'Text' Into [Context.Var]
					Syntax(c, 0) = "CopyText" : SyntaxIndex(c, 0) = 3
					Syntax(c, 1) = "Text1" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "Into"
					Syntax(c, 3) = "Var" : SyntaxIndex(c, 3) = 0
				Case 23 'Runes ([List],[List],[List],[List],[List],[List]) [List]
					Syntax(c, 0) = "Runes" : SyntaxIndex(c, 0) = 2
					Syntax(c, 1) = "(List)" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "List2" : SyntaxIndex(c, 2) = 6
				Case 24 'AddFactoid 'Text'
					Syntax(c, 0) = "AddFactoid" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "Text1" : SyntaxIndex(c, 1) = 0
				Case 25 'AddJournalEntry 'Text'
					Syntax(c, 0) = "AddJournalEntry" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "Text2" : SyntaxIndex(c, 1) = 0
				Case 26 'Destroy [List] In [List]
					Syntax(c, 0) = "Destroy" : SyntaxIndex(c, 0) = 3
					Syntax(c, 1) = "List1" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "In"
					Syntax(c, 3) = "List2" : SyntaxIndex(c, 3) = 1
				Case 27 'CombatApplyDamage [Context.Var] To [List]
					Syntax(c, 0) = "CombatApplyDamage" : SyntaxIndex(c, 0) = 3
					Syntax(c, 1) = "Var" : SyntaxIndex(c, 1) = 3
					Syntax(c, 2) = "To"
					Syntax(c, 3) = "List1" : SyntaxIndex(c, 3) = 0
				Case 28 'CombatRollAttack [List] Bonus [Context.Var]
					Syntax(c, 0) = "CombatRollAttack" : SyntaxIndex(c, 0) = 3
					Syntax(c, 1) = "List1" : SyntaxIndex(c, 1) = 5
					Syntax(c, 2) = "Bonus"
					Syntax(c, 3) = "Var" : SyntaxIndex(c, 3) = 0
				Case 29 'CombatRollDamage [Context.Var] As [List] Check
					Syntax(c, 0) = "CombatRollDamage" : SyntaxIndex(c, 0) = 3
					Syntax(c, 1) = "List1" : SyntaxIndex(c, 1) = 5
					Syntax(c, 2) = "Damaged"
					Syntax(c, 3) = "Var" : SyntaxIndex(c, 3) = 0
					Syntax(c, 4) = "Check" : SyntaxIndex(c, 4) = 2
				Case 30 'DestroyFactoid 'Text'
					Syntax(c, 0) = "DestroyFactoid" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "Text1" : SyntaxIndex(c, 1) = 0
				Case 31 'TargetCreature [List] As [List] Within [Context.Var] Dead
					Syntax(c, 0) = "TargetCreature" : SyntaxIndex(c, 0) = 5
					Syntax(c, 1) = "List1" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "In"
					Syntax(c, 3) = "List2" : SyntaxIndex(c, 3) = 1
					Syntax(c, 4) = "Within"
					Syntax(c, 5) = "Var" : SyntaxIndex(c, 5) = 3
					Syntax(c, 6) = "Dead" : SyntaxIndex(c, 6) = 2
				Case 32 'TargetItem [List]
					Syntax(c, 0) = "TargetItem" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "List1" : SyntaxIndex(c, 1) = 0
				Case 33 'PlaySound 'Text' Pause
					Syntax(c, 0) = "PlaySound" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "Text3" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "Pause" : SyntaxIndex(c, 2) = 0
				Case 34 'PlayMusic 'Text' Pause
					Syntax(c, 0) = "PlayMusic" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "Text3" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "Pause" : SyntaxIndex(c, 2) = 0
				Case 35 'MoveParty To [List] At ([Context.Var],[Context.Var])
					Syntax(c, 0) = "MoveParty" : SyntaxIndex(c, 0) = 4
					Syntax(c, 1) = "To"
					Syntax(c, 2) = "List1" : SyntaxIndex(c, 2) = 5
					Syntax(c, 3) = "At"
					Syntax(c, 4) = "(Var)" : SyntaxIndex(c, 4) = 0
				Case 36 'DialogShow 'Text' [List] Says 'Text'
					Syntax(c, 0) = "DialogShow" : SyntaxIndex(c, 0) = 4
					Syntax(c, 1) = "Text1" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "List1" : SyntaxIndex(c, 2) = 0
					Syntax(c, 3) = "Says"
					Syntax(c, 4) = "Text2" : SyntaxIndex(c, 4) = 1
				Case 37 'DialogReply 'Text'
					Syntax(c, 0) = "DialogReply" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "Text2" : SyntaxIndex(c, 1) = 0
				Case 38 'DialogAccept [Context.Var]
					Syntax(c, 0) = "DialogAccept" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "Var" : SyntaxIndex(c, 1) = 0
				Case 39 'DialogDice 'Text' [List] Says 'Text' Into [Context.Var]
					Syntax(c, 0) = "DialogDice" : SyntaxIndex(c, 0) = 6
					Syntax(c, 1) = "Text1" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "List1" : SyntaxIndex(c, 2) = 2
					Syntax(c, 3) = "Says"
					Syntax(c, 4) = "Text2" : SyntaxIndex(c, 4) = 1
					Syntax(c, 5) = "Into"
					Syntax(c, 6) = "Var" : SyntaxIndex(c, 6) = 0
				Case 40 'DialogHide
					Syntax(c, 0) = "DialogHide" : SyntaxIndex(c, 0) = 0
				Case 41 'CutScene 'Text' Picture 'Text' As [List]
					Syntax(c, 0) = "CutScene" : SyntaxIndex(c, 0) = 5
					Syntax(c, 1) = "Text2" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "Picture"
					Syntax(c, 3) = "Text3" : SyntaxIndex(c, 3) = 1
					Syntax(c, 4) = "As"
					Syntax(c, 5) = "List1" : SyntaxIndex(c, 5) = 0
				Case 42 'QueRunes ([List],[List],[List],[List],[List],[List]) Check
					Syntax(c, 0) = "QueRunes" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "(List)" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "Check" : SyntaxIndex(c, 2) = 6
				Case 43 'CombatMove [List] [List]
					Syntax(c, 0) = "CombatMove" : SyntaxIndex(c, 0) = 2
					Syntax(c, 1) = "List1" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "List2" : SyntaxIndex(c, 2) = 1
				Case 44 'Reserved
				Case 45 'CombatTarget [List]
					Syntax(c, 0) = "CombatTarget" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "List1" : SyntaxIndex(c, 1) = 0
				Case 46 'PlaySFX 'Text' As [List] [List] [List] Frames 'Text'
					Syntax(c, 0) = "PlaySFX" : SyntaxIndex(c, 0) = 7
					Syntax(c, 1) = "Text3" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "As"
					Syntax(c, 3) = "List1" : SyntaxIndex(c, 3) = 0
					Syntax(c, 4) = "List2" : SyntaxIndex(c, 4) = 1
					Syntax(c, 5) = "List3" : SyntaxIndex(c, 5) = 2
					Syntax(c, 6) = "Frames"
					Syntax(c, 7) = "List4" : SyntaxIndex(c, 7) = 3
				Case 47 'Sorcery [Context.Var]
					Syntax(c, 0) = "Sorcery" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "Var" : SyntaxIndex(c, 1) = 0
				Case 48 'DialogBuySell [List] At [Context.Var]
					Syntax(c, 0) = "DialogBuySell" : SyntaxIndex(c, 0) = 3
					Syntax(c, 1) = "List1" : SyntaxIndex(c, 1) = 2
					Syntax(c, 2) = "Rate"
					Syntax(c, 3) = "Var" : SyntaxIndex(c, 3) = 0
				Case 49 'Reserved [Titi 2.5.1] TargetEncounterNamed [List] In [List] Map [List]
					Syntax(c, 0) = "TargetEncounterInArea" : SyntaxIndex(c, 0) = 5
					Syntax(c, 1) = "List1" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "Map"
					Syntax(c, 3) = "List2" : SyntaxIndex(c, 3) = 1
					Syntax(c, 4) = "Named"
					Syntax(c, 5) = "List3" : SyntaxIndex(c, 5) = 2
				Case 50 'ExecTrigger [List]
					Syntax(c, 0) = "ExecTrigger" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "List1" : SyntaxIndex(c, 1) = 0
				Case 51 'DialogAcceptText [Context.Var]
					Syntax(c, 0) = "DialogAcceptText" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "Var" : SyntaxIndex(c, 1) = 0
				Case 52 'CombatStart
					Syntax(c, 0) = "CombatStart" : SyntaxIndex(c, 0) = 1
				Case 53 'Let [Context.Var] = [Context.Var]
					Syntax(c, 0) = "Let" : SyntaxIndex(c, 0) = 3
					Syntax(c, 1) = "Var" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "="
					Syntax(c, 3) = "Var" : SyntaxIndex(c, 3) = 3
				Case 54 '' Text
					Syntax(c, 0) = "'" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "Spec"
				Case 55 'RandomizeEncounter 'Text'
					Syntax(c, 0) = "RandomizeEncounter" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "Text1" : SyntaxIndex(c, 1) = 0
				Case 56 'RandomTheme 'Text'
					Syntax(c, 0) = "RandomTheme" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "Text1" : SyntaxIndex(c, 1) = 0
				Case 57 'AwardExperience [Context.Var] To [List]
					Syntax(c, 0) = "AwardExperience" : SyntaxIndex(c, 0) = 3
					Syntax(c, 1) = "Var" : SyntaxIndex(c, 1) = 5
					Syntax(c, 2) = "To"
					Syntax(c, 3) = "List1" : SyntaxIndex(c, 3) = 0
				Case 58 'MoveItem [List] From [List] To [List] Copy
					Syntax(c, 0) = "MoveItem" : SyntaxIndex(c, 0) = 5
					Syntax(c, 1) = "List1" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "From"
					Syntax(c, 3) = "List2" : SyntaxIndex(c, 3) = 1
					Syntax(c, 4) = "To"
					Syntax(c, 5) = "List3" : SyntaxIndex(c, 5) = 3
					Syntax(c, 6) = "Copy" : SyntaxIndex(c, 6) = 2
				Case 59 'AddQuest 'Text' As 'Text'
					Syntax(c, 0) = "AddQuest" : SyntaxIndex(c, 0) = 3
					Syntax(c, 1) = "Text1" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "As"
					Syntax(c, 3) = "Text2" : SyntaxIndex(c, 3) = 1
				Case 60 'RemoveQuest 'Text'
					Syntax(c, 0) = "RemoveQuest" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "Text1" : SyntaxIndex(c, 1) = 0
				Case 61 'RemoveTopic 'Text'
					' [Titi 2.4.9]
					Syntax(c, 0) = "RemoveTopic" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "Text1" : SyntaxIndex(c, 1) = 0
				Case 62 'CombatAttackWithWeapon
					Syntax(c, 0) = "CombatAttackWithWeapon" : SyntaxIndex(c, 0) = 0
				Case 63 'CombatAttackWithSpecial 'Text' As [Context.Var]
					Syntax(c, 0) = "CombatAttackWithSpecial" : SyntaxIndex(c, 0) = 3
					Syntax(c, 1) = "Text1" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "As"
					Syntax(c, 3) = "Var" : SyntaxIndex(c, 3) = 5
				Case 64 'MovePartyMapName To 'Text' [List] At ([Context.Var],[Context.Var])
					Syntax(c, 0) = "MovePartyMapName" : SyntaxIndex(c, 0) = 5
					Syntax(c, 1) = "To"
					Syntax(c, 2) = "Text1" : SyntaxIndex(c, 2) = 0
					Syntax(c, 3) = "List1" : SyntaxIndex(c, 3) = 2
					Syntax(c, 4) = "At"
					Syntax(c, 5) = "(Var)" : SyntaxIndex(c, 5) = 0
				Case 65 'MoveCreature [List] From [List] To [List] Copy
					Syntax(c, 0) = "MoveCreature" : SyntaxIndex(c, 0) = 5
					Syntax(c, 1) = "List1" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "From"
					Syntax(c, 3) = "List2" : SyntaxIndex(c, 3) = 1
					Syntax(c, 4) = "To"
					Syntax(c, 5) = "List3" : SyntaxIndex(c, 5) = 3
					Syntax(c, 6) = "Copy" : SyntaxIndex(c, 6) = 2
				Case 66 'IfText [Context.Var] [Op] 'Text'
					Syntax(c, 0) = "IfText" : SyntaxIndex(c, 0) = 3
					Syntax(c, 1) = "Var" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "Op" : SyntaxIndex(c, 2) = 2
					Syntax(c, 3) = "Text4" : SyntaxIndex(c, 3) = 0
				Case 67 'TargetEncounter 'Text'
					Syntax(c, 0) = "TargetEncounter" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "Text1" : SyntaxIndex(c, 1) = 0
				Case 68 'TargetTile At ([Context.Var],[Context.Var])
					' [Titi 2.4.6] put 4 in first SyntaxIndex to specify layer, but not useful anyway
					Syntax(c, 0) = "TargetTile" : SyntaxIndex(c, 0) = 2
					Syntax(c, 1) = "At"
					Syntax(c, 2) = "(Var)" : SyntaxIndex(c, 2) = 0
					'                Syntax(c, 3) = "Level"
					'                Syntax(c, 4) = "List1": SyntaxIndex(c, 4) = 2
				Case 69 'PlayVideo 'Text' Pause
					Syntax(c, 0) = "PlayVideo" : SyntaxIndex(c, 0) = 1
					Syntax(c, 1) = "Text3" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "Pause" : SyntaxIndex(c, 2) = 0
				Case 70 'Find [List] Named 'Text' In [List]
					Syntax(c, 0) = "Find" : SyntaxIndex(c, 0) = 5
					Syntax(c, 1) = "List1" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "In"
					Syntax(c, 3) = "List2" : SyntaxIndex(c, 3) = 1
					Syntax(c, 4) = "Named"
					Syntax(c, 5) = "Text4" : SyntaxIndex(c, 5) = 0
				Case 71 'CallTrigger [List] In [List]
					Syntax(c, 0) = "CallTrigger" : SyntaxIndex(c, 0) = 3
					Syntax(c, 1) = "List1" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "In"
					Syntax(c, 3) = "List2" : SyntaxIndex(c, 3) = 1
				Case 72 'CombatAnimation 'Text' For [List] Frames [List]
					Syntax(c, 0) = "CombatAnimation" : SyntaxIndex(c, 0) = 5
					Syntax(c, 1) = "Text3" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "For"
					Syntax(c, 3) = "List1" : SyntaxIndex(c, 3) = 0
					Syntax(c, 4) = "Frames"
					Syntax(c, 5) = "List2" : SyntaxIndex(c, 5) = 1
				Case 73 'MapAnimation 'Text' Frames [List] Level [List] At (Context.Var, Context.Var)
					Syntax(c, 0) = "MapAnimation" : SyntaxIndex(c, 0) = 7
					Syntax(c, 1) = "Text3" : SyntaxIndex(c, 1) = 0
					Syntax(c, 2) = "Frames"
					Syntax(c, 3) = "List1" : SyntaxIndex(c, 3) = 2
					Syntax(c, 4) = "Level"
					Syntax(c, 5) = "List2" : SyntaxIndex(c, 5) = 5
					Syntax(c, 6) = "At"
					Syntax(c, 7) = "(Var)" : SyntaxIndex(c, 7) = 0
				Case 74 'MapRefresh
					Syntax(c, 0) = "MapRefresh" : SyntaxIndex(c, 0) = 0
			End Select
		Next c
	End Sub
End Module