Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmList
	Inherits System.Windows.Forms.Form
	Private strListName As String
	Public blnListSaved As Boolean
	
	Private Sub btnCheckIfExist_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCheckIfExist.Click
		frmMDI.CheckIfExist((False))
	End Sub
	
	Private Sub btnExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnExit.Click
		Dim confirm As MsgBoxResult
		If lstList.Items.Count > 0 And blnListSaved = False Then
			confirm = MsgBox("Do you wish to save the current list?", MsgBoxStyle.YesNo)
			If confirm = MsgBoxResult.Yes Then
				btnSave_Click(btnSave, New System.EventArgs())
			End If
		End If
		lstList.Items.Clear()
		Me.Close()
	End Sub
	
	Private Sub SortByExtension(ByRef lstList As System.Windows.Forms.ListBox)
		Dim j, i, intPercent As Short
		Dim strProgress, strTemp, strFormCaption As String
		strFormCaption = Me.Text
		strProgress = "Saving: "
		With lstList
			For i = 0 To .Items.Count - 2
				For j = i + 1 To .Items.Count - 1
					If UCase(VB.Right(VB6.GetItemString(lstList, i), 3)) > UCase(VB.Right(VB6.GetItemString(lstList, j), 3)) Then
						strTemp = VB6.GetItemString(lstList, i)
						VB6.SetItemString(lstList, i, VB6.GetItemString(lstList, j))
						VB6.SetItemString(lstList, j, strTemp)
					End If
				Next j
				intPercent = Int(i * 100 / .Items.Count)
				Me.Text = strProgress & intPercent & "%"
				Me.Refresh()
			Next i
			Me.Text = strFormCaption
		End With
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub SaveList()
		Dim Tome_Renamed As Object
		Dim strDefaultName As String
		Dim hndList, i As Short
		If lstList.Items.Count > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			strDefaultName = Me.Text & " in " & Tome.FileName
			strListName = InputBox("Save list as",  , strDefaultName)
			While frmMDI.CheckName(strListName) > 0
				strListName = InputBox("Make sure the file name does not contain ?/<>*|\:" & Chr(34), "Invalid character found!", strListName)
			End While
			If strListName <> "" Then
				blnListSaved = True
				If VB.Right(strListName, 4) <> ".txt" Then strListName = strListName & ".txt"
				' [Titi 2.6.0] group all packages in the same directory
				' create required subfolders
				hndList = oFileSys.CheckExists(gAppPath & "\Packing Store\" & WorldNow.Name & "\", clsInOut.IOActionType.Folder, True)
				'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				hndList = oFileSys.CheckExists(gAppPath & "\Packing Store\" & WorldNow.Name & "\" & Tome.Name & "\", clsInOut.IOActionType.Folder, True)
				'strListName = Tome.LoadPath & "\" & strListName
				SortByExtension(lstList) ' regroup all .bmp, .wav etc together
				hndList = FreeFile
				FileOpen(hndList, strListName, OpenMode.Output)
				'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				PrintLine(hndList, Tome.LoadPath & "\" & Tome.FileName)
				PrintLine(hndList, "------------")
				PrintLine(hndList, "List of ." & UCase(VB.Right(VB6.GetItemString(lstList, 0), 3)))
				PrintLine(hndList, "------------")
				PrintLine(hndList, VB6.GetItemString(lstList, 0))
				For i = 1 To lstList.Items.Count - 1
					If UCase(VB.Right(VB6.GetItemString(lstList, i), 3)) <> UCase(VB.Right(VB6.GetItemString(lstList, i - 1), 3)) Then
						' new type of files
						PrintLine(hndList, "------------")
						PrintLine(hndList, "List of ." & UCase(VB.Right(VB6.GetItemString(lstList, i), 3)))
						PrintLine(hndList, "------------")
					End If
					PrintLine(hndList, VB6.GetItemString(lstList, i))
				Next 
				FileClose(hndList)
				' [Titi 2.6.0] Move all packages in the same directory; do the same for lists
				'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				FileCopy(strListName, gAppPath & "\Packing store\" & WorldNow.Name & "\" & Tome.Name & "\" & Mid(strListName, InStrRev(strListName, "/") + 1))
				Kill(strListName)
				'UPGRADE_WARNING: Couldn't resolve default property of object Tome.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MsgBox(VB.Right(strListName, Len(strListName) - InStrRev(strListName, "\")) & " successfully saved in " & vbCrLf & gAppPath & "\Packing store\" & WorldNow.Name & "\" & Tome.Name)
			Else
				MsgBox("Action cancelled. The list has NOT been SAVED.",  , "Save failed!")
			End If
		Else
			MsgBox("Sorry, the list is empty")
		End If
	End Sub
	
	Private Sub btnSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnSave.Click
		SaveList()
	End Sub
	
	Private Sub btnCopyFilesToFolder_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCopyFilesToFolder.Click
		frmMDI.CheckIfExist(True)
	End Sub
	
	Private Sub btnOpen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOpen.Click
		Dim confirm As MsgBoxResult
		If lstList.Items.Count > 0 And blnListSaved = False Then
			confirm = MsgBox("Do you wish to save the current list?", MsgBoxStyle.YesNo)
			If confirm = MsgBoxResult.Yes Then
				btnSave_Click(btnSave, New System.EventArgs())
			End If
		Else
			lstList.Items.Clear()
		End If
		frmMDI.btnOpen_Click()
	End Sub
	
	Public Sub mnuDataFilesCheck_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuDataFilesCheck.Click
		frmMDI.CheckIfExist(False)
	End Sub
	
	Public Sub mnuDataFilesCopy_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuDataFilesCopy.Click
		frmMDI.CheckIfExist(True)
	End Sub
	
	Public Sub mnuListOpen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuListOpen.Click
		btnOpen_Click(btnOpen, New System.EventArgs())
	End Sub
	
	Public Sub mnuListSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuListSave.Click
		btnSave_Click(btnSave, New System.EventArgs())
	End Sub
	
	Public Sub mnuQuit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuQuit.Click
		btnExit_Click(btnExit, New System.EventArgs())
	End Sub
End Class