Option Strict Off
Option Explicit On
Module modCreatorGeneral
	' [rb]
	' Trying to get just one copy of this some where
	Public aMostRecent(5) As String
	
	Private Structure STARTUPINFO
		Dim cb As Integer
		Dim lpReserved As String
		Dim lpDesktop As String
		Dim lpTitle As String
		Dim dwX As Integer
		Dim dwY As Integer
		Dim dwXSize As Integer
		Dim dwYSize As Integer
		Dim dwXCountChars As Integer
		Dim dwYCountChars As Integer
		Dim dwFillAttribute As Integer
		Dim dwFlags As Integer
		Dim wShowWindow As Short
		Dim cbReserved2 As Short
		Dim lpReserved2 As Integer
		Dim hStdInput As Integer
		Dim hStdOutput As Integer
		Dim hStdError As Integer
	End Structure
	
	Private Structure PROCESS_INFORMATION
		Dim hProcess As Integer
		Dim hThread As Integer
		Dim dwProcessID As Integer
		Dim dwThreadId As Integer
	End Structure
	
	Private Declare Function WaitForSingleObject Lib "kernel32" (ByVal hHandle As Integer, ByVal dwMilliseconds As Integer) As Integer
	
	'UPGRADE_WARNING: Structure PROCESS_INFORMATION may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	'UPGRADE_WARNING: Structure STARTUPINFO may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function CreateProcessA Lib "kernel32" (ByVal lpApplicationName As String, ByVal lpCommandLine As String, ByVal lpProcessAttributes As Integer, ByVal lpThreadAttributes As Integer, ByVal bInheritHandles As Integer, ByVal dwCreationFlags As Integer, ByVal lpEnvironment As Integer, ByVal lpCurrentDirectory As String, ByRef lpStartupInfo As STARTUPINFO, ByRef lpProcessInformation As PROCESS_INFORMATION) As Integer
	
	Private Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Integer) As Integer
	
	Private Declare Function GetExitCodeProcess Lib "kernel32" (ByVal hProcess As Integer, ByRef lpExitCode As Integer) As Integer
	
	Private Const NORMAL_PRIORITY_CLASS As Integer = &H20
	Private Const INFINITE As Short = -1
	
	Public Function ExecCmd(ByRef cmdline As String) As Object
		Dim proc As PROCESS_INFORMATION
		Dim start As STARTUPINFO
		Dim ret As Integer
		' Initialize the STARTUPINFO structure:
		start.cb = Len(start)
		' Start the shelled application:
		ret = CreateProcessA(vbNullString, cmdline, 0, 0, 1, NORMAL_PRIORITY_CLASS, 0, vbNullString, start, proc)
		' Wait for the shelled application to finish:
		ret = WaitForSingleObject(proc.hProcess, INFINITE)
		Call GetExitCodeProcess(proc.hProcess, ret)
		Call CloseHandle(proc.hThread)
		Call CloseHandle(proc.hProcess)
		'UPGRADE_WARNING: Couldn't resolve default property of object ExecCmd. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ExecCmd = ret
	End Function
	
	Public Sub LoadSystemSettings()
		Dim lResult As Integer
		Dim tmp As String
		Dim X As Short
		On Error GoTo ErrorHandler
		'lResult = fReadValue(gAppPath & "\Settings.ini", "Creator", "Recent1", "S", "", aMostRecent(0))
		lResult = fReadValue(gAppPath & "\Settings.ini", "Creator", "Recent1", "S", "", aMostRecent(0))
		lResult = fReadValue(gAppPath & "\Settings.ini", "Creator", "Recent2", "S", "", aMostRecent(1))
		lResult = fReadValue(gAppPath & "\Settings.ini", "Creator", "Recent3", "S", "", aMostRecent(2))
		lResult = fReadValue(gAppPath & "\Settings.ini", "Creator", "Recent4", "S", "", aMostRecent(3))
		lResult = fReadValue(gAppPath & "\Settings.ini", "Creator", "Recent5", "S", "", aMostRecent(4))
		' activate menus
		If aMostRecent(0) = vbNullString Then
			frmMDI.mnuRec.Enabled = False
		Else
			frmMDI.mnuRec.Enabled = True
		End If
		For X = 0 To 4
			If aMostRecent(X) <> vbNullString Then
				frmMDI.mnuRecent(X).Visible = True
				frmMDI.mnuRecent(X).Text = aMostRecent(X)
			Else
				frmMDI.mnuRecent(X).Visible = False
			End If
		Next X
		Exit Sub
ErrorHandler: 
		' [Titi 2.4.9]
		If Err.Number = 387 Then ' cannot make all items not visible.
			Resume Next
		Else
			oErr.logError("LoadSystemSettings (#" & Err.Number & ")")
		End If
	End Sub
	
	Public Sub SaveSystemSettings()
		Dim lResult As Integer
		Dim X As Short
		Call oFileSys.CheckExists(gAppPath & "\Settings.ini", clsInOut.IOActionType.File, True)
		lResult = fWriteValue(gAppPath & "\Settings.ini", "Creator", "AutoComplete", "S", CShort(frmMDI.blnAutoComplete))
		lResult = fWriteValue(gAppPath & "\Settings.ini", "Creator", "Recent1", "S", aMostRecent(0))
		lResult = fWriteValue(gAppPath & "\Settings.ini", "Creator", "Recent2", "S", aMostRecent(1))
		lResult = fWriteValue(gAppPath & "\Settings.ini", "Creator", "Recent3", "S", aMostRecent(2))
		lResult = fWriteValue(gAppPath & "\Settings.ini", "Creator", "Recent4", "S", aMostRecent(3))
		lResult = fWriteValue(gAppPath & "\Settings.ini", "Creator", "Recent5", "S", aMostRecent(4))
		For X = 0 To 4
			If aMostRecent(X) <> vbNullString Then
				frmMDI.mnuRecent(X).Visible = True
				frmMDI.mnuRecent(X).Text = aMostRecent(X)
			End If
		Next X
	End Sub
	
	Public Sub MouseWheelSupport(ByRef hWnd As Integer, ByRef X As Single, ByRef Y As Single, ByRef vsb As System.Windows.Forms.Control)
		' [Titi 2.5.1]
		EnumThreadProc(hWnd, Y * &H10000 + X)
		Dim i As Short
		Dim lRet As Integer
		If Delta > 0 Then ' Scroll Up
			Do While i < Delta * lLineNumbers
				lRet = PostMessage(pthWnd, WM_VSCROLL, SB_LINEUP, hWnd)
				i = i + 1
				'UPGRADE_WARNING: Couldn't resolve default property of object vsb.Value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object vsb.Max. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				vsb.Value = vsb.Value + IIf(vsb.Value < vsb.Max, 1, 0)
			Loop 
		ElseIf Delta < 0 Then  ' Scroll Down
			Do While i > Delta * lLineNumbers
				lRet = PostMessage(pthWnd, WM_VSCROLL, SB_LINEDOWN, hWnd)
				i = i - 1
				'UPGRADE_WARNING: Couldn't resolve default property of object vsb.Value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object vsb.Min. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				vsb.Value = vsb.Value - IIf(vsb.Value > vsb.Min, 1, 0)
			Loop 
		End If
	End Sub
	
	Public Sub CtrlKey(ByRef txtBox As System.Windows.Forms.TextBox, ByRef KeyCode As Short, ByRef Shift As Short)
		Dim Text As String
		If (Shift And VB6.ShiftConstants.CtrlMask) > 0 Then
			Select Case KeyCode
				Case 88, 120 ' X-Cut
					My.Computer.Clipboard.Clear()
					My.Computer.Clipboard.SetText(Mid(txtBox.Text, txtBox.SelectionStart + 1, txtBox.SelectionLength))
					txtBox.SelectedText = ""
				Case 67, 99 ' C-Copy
					My.Computer.Clipboard.Clear()
					My.Computer.Clipboard.SetText(Mid(txtBox.Text, txtBox.SelectionStart + 1, txtBox.SelectionLength))
				Case 86, 118 ' V-Paste
					Text = My.Computer.Clipboard.GetText()
					txtBox.SelectedText = Text
			End Select
			txtBox.Refresh()
		End If
	End Sub
End Module