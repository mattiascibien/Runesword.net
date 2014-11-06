Option Strict Off
Option Explicit On

Imports System.Text

Module modRegistry
    '
    ' Written by Dave Scarmozzino  www.TheScarms.com
    ' Completed by Titi
    '
    Structure SECURITY_ATTRIBUTES
        Dim nLength As Integer
        Dim lpSecurityDescriptor As Integer
        Dim bInheritHandle As Boolean
    End Structure

    Public Const MAX_SIZE As Short = 2048
    Public Const MAX_INISIZE As Short = 8192
    ' Constants for Registry top-level keys
    Public Const HKEY_CURRENT_USER As Integer = &H80000001
    Public Const HKEY_LOCAL_MACHINE As Integer = &H80000002
    Public Const HKEY_USERS As Integer = &H80000003
    Public Const HKEY_DYN_DATA As Integer = &H80000006
    Public Const HKEY_CURRENT_CONFIG As Integer = &H80000005
    Public Const HKEY_CLASSES_ROOT As Integer = &H80000000
    ' Return values
    Public Const ERROR_SUCCESS As Short = 0
    Public Const ERROR_FILE_NOT_FOUND As Short = 2
    Public Const ERROR_MORE_DATA As Short = 234
    Public Const ERROR_NO_MORE_ITEMS As Short = 259
    ' RegCreateKeyEx options
    Public Const REG_OPTION_NON_VOLATILE As Short = 0
    ' RegCreateKeyEx Disposition
    Public Const REG_CREATED_NEW_KEY As Integer = &H1
    Public Const REG_OPENED_EXISTING_KEY As Integer = &H2
    ' Registry data types
    Public Const REG_NONE As Short = 0
    Public Const REG_SZ As Short = 1
    Public Const REG_BINARY As Short = 3
    Public Const REG_DWORD As Short = 4
    ' Registry security attributes
    Public Const KEY_QUERY_VALUE As Integer = &H1
    Public Const KEY_SET_VALUE As Integer = &H2
    Public Const KEY_CREATE_SUB_KEY As Integer = &H4
    Public Const KEY_ENUMERATE_SUB_KEYS As Integer = &H8

    'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    Declare Auto Function RegEnumValue Lib "Advapi32" ( _
       ByVal hKey As IntPtr, _
       ByVal dwIndex As Integer, _
       ByVal lpValueName As StringBuilder, _
       ByRef lpcValueName As Integer, _
       ByVal lpReserved As IntPtr, _
       ByVal lpType As IntPtr, _
       ByVal lpData As IntPtr, _
       ByVal lpcbData As IntPtr _
    ) As Integer

    Declare Function RegDeleteValue Lib "advapi32.dll" Alias "RegDeleteValueA" (ByVal hKey As Integer, ByVal lpValueName As String) As Integer
    Declare Function RegDeleteKey Lib "advapi32.dll" Alias "RegDeleteKeyA" (ByVal hKey As Integer, ByVal lpSubKey As String) As Integer
    Declare Function RegOpenKeyEx Lib "advapi32.dll" Alias "RegOpenKeyExA" (ByVal hKey As Integer, ByVal lpSubKey As String, ByVal ulOptions As Integer, ByVal samDesired As Integer, ByRef phkResult As Integer) As Integer
    'UPGRADE_WARNING: Structure SECURITY_ATTRIBUTES may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
    Declare Function RegCreateKeyEx Lib "advapi32.dll" Alias "RegCreateKeyExA" (ByVal hKey As Integer, ByVal lpSubKey As String, ByVal Reserved As Integer, ByVal lpClass As String, ByVal dwOptions As Integer, ByVal samDesired As Integer, ByRef lpSecurityAttributes As SECURITY_ATTRIBUTES, ByRef phkResult As Integer, ByRef lpdwDisposition As Integer) As Integer
    'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    <System.Runtime.InteropServices.DllImport("advapi32.dll", SetLastError:=True)> _
    Friend Function RegQueryValueEx( _
    ByVal hKey As IntPtr, _
    ByVal lpValueName As String, _
    ByVal lpReserved As Integer, _
    ByRef lpType As Integer, _
    ByVal lpData As Byte(), _
    ByRef lpcbData As Integer) As Integer
    End Function
    'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    Declare Function RegSetValueEx Lib "advapi32.dll" Alias "RegSetValueExA" (ByVal hKey As Integer, ByVal lpValueName As String, ByVal Reserved As Integer, ByVal dwType As Integer, ByRef lpData As Byte(), ByVal cbData As Integer) As Integer
    Public Declare Function RegEnumKey Lib "advapi32.dll" Alias "RegEnumKeyA" (ByVal hKey As Integer, ByVal dwIndex As Integer, ByVal lpName As String, ByVal cbName As Integer) As Integer
    Declare Function RegCloseKey Lib "advapi32.dll" (ByVal hKey As Integer) As Integer
    Declare Function GetPrivateProfileSection Lib "kernel32" Alias "GetPrivateProfileSectionA" (ByVal lpAppName As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
    Declare Function GetPrivateProfileInt Lib "kernel32" Alias "GetPrivateProfileIntA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal nDefault As Integer, ByVal lpFileName As String) As Integer

    ' [Titi 2.5.0] added OS detection for compatibility with Win 9x systems
    'UPGRADE_WARNING: Structure OSVERSIONINFO may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
    Private Declare Function GetVersionExA Lib "kernel32" (ByRef lpVersionInformation As OSVERSIONINFO) As Short

    Private Structure OSVERSIONINFO
        Dim dwOSVersionInfoSize As Integer
        Dim dwMajorVersion As Integer
        Dim dwMinorVersion As Integer
        Dim dwBuildNumber As Integer
        Dim dwPlatformId As Integer
        'UPGRADE_WARNING: Fixed-length string size must fit in the buffer. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="3C1E4426-0B80-443E-B943-0627CD55D48B"'
        <VBFixedString(128), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst:=128)> Public szCSDVersion() As Char
        Dim wServicePackMajor As Short ' Version Majeur du Service Pack
        Dim wServicePackMinor As Short ' Version Mineur du Service Pack
    End Structure

    Private Const VER_PLATFORM_WIN32s As Short = 0 ' Win32s / Windows 3.1
    Private Const VER_PLATFORM_WIN32_WINDOWS As Short = 1 ' Windows 95, Windows 98, ou Windows Me
    Private Const VER_PLATFORM_WIN32_NT As Short = 2 ' Windows NT, Windows 2000, Windows XP, ou Windows Server 2003 familiale.
    ' [Titi 2.5.0] end of OS detection

    ' [Titi 2.5.1] added mousewheel support
    Delegate Function EnumChildProcDelegate(ByVal lhWnd As Integer, ByVal lParam As Integer) As Integer
    Declare Function EnumChildWindows Lib "user32" (ByVal hWndParent As Integer, ByVal lpEnumFunc As EnumChildProcDelegate, ByVal lParam As Integer) As Integer
    Declare Function EnumThreadWindows Lib "user32" (ByVal dwThreadId As Integer, ByVal lpfn As Integer, ByVal lParam As Integer) As Integer
    Declare Function GetClassName Lib "user32" Alias "GetClassNameA" (ByVal hWnd As Integer, ByVal lpClassName As String, ByVal nMaxCount As Integer) As Integer
    Declare Function GetWindowText Lib "user32" Alias "GetWindowTextA" (ByVal hWnd As Integer, ByVal lpString As String, ByVal cch As Integer) As Integer
    Public Declare Function GetCurrentThreadId Lib "kernel32" () As Integer
    Public Declare Function CallWindowProc Lib "user32" Alias "CallWindowProcA" (ByVal lpPrevWndFunc As Integer, ByVal hWnd As Integer, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

    Delegate Function WindowProcDelegate(ByVal hWnd As Integer, ByVal uMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Public Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hWnd As Integer, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Public Declare Function WindowFromPointXY Lib "user32" Alias "WindowFromPoint" (ByVal xPoint As Integer, ByVal yPoint As Integer) As Integer
    'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    Private Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParam As Integer, ByRef lpvParam As IntPtr, ByVal fuWinIni As Integer) As Integer
    Public Declare Function PostMessage Lib "user32" Alias "PostMessageA" (ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    'UPGRADE_WARNING: Structure POINTAPI may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
    Public Declare Function WindowFromPoint Lib "user32" (ByRef pt As POINTAPI) As Integer
    'UPGRADE_WARNING: Structure WINDOWINFO may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
    Public Declare Function GetWindowInfo Lib "user32" (ByVal hWnd As Integer, ByRef pwi As WINDOWINFO) As Boolean
    Public Declare Function LoadLibrary Lib "kernel32" Alias "LoadLibraryA" (ByVal lpLibFileName As String) As Integer
    Public Declare Function FreeLibrary Lib "kernel32" Alias "FreeLibraryA" (ByVal hLibrary As Integer) As Boolean

    Public Structure RECT
        'UPGRADE_NOTE: Left was upgraded to Left_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Dim Left_Renamed As Integer
        Dim Top As Integer
        'UPGRADE_NOTE: Right was upgraded to Right_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Dim Right_Renamed As Integer
        Dim Bottom As Integer
    End Structure
    Public Structure WINDOWINFO
        Dim cbSize As Integer
        Dim rcWindow As RECT
        Dim rcClient As RECT
        Dim dwStyle As Integer
        Dim dwExStyle As Integer
        Dim cxWindowBorders As Integer
        Dim cyWindowBorders As Integer
        Dim atomWindowtype As Integer
        Dim wCreatorVersion As Integer
    End Structure
    Public Structure POINTAPI
        Dim X As Integer
        Dim Y As Integer
    End Structure
    Private Structure MOUSEHOOKSTRUCT
        Dim pt As POINTAPI
        Dim hWnd As Integer
        Dim wHitTestCode As Integer
        Dim dwExtraInfo As Integer
    End Structure
    Private Structure MSLLHOOKSTRUCT
        Dim pt As POINTAPI
        Dim mouseData As Integer
        Dim flags As Integer
        Dim time As Integer
        Dim dwExtraInfo As Integer
    End Structure

    Private Const WM_MOUSEWHEEL As Integer = &H20A
    Private Const WM_MBUTTONUP As Integer = &H208
    Private Const WM_MBUTTONDOWN As Integer = &H207
    Private Const WM_MBUTTONDBLCLK As Integer = &H209
    Private Const WM_LBUTTONDOWN As Integer = &H201
    Private Const WM_LBUTTONUP As Integer = &H202
    Private Const WM_RBUTTONUP As Integer = &H205
    Private Const MK_LBUTTON As Integer = &H1
    Private Const MK_MBUTTON As Integer = &H10
    Private Const MK_RBUTTON As Integer = &H2
    Public Const WH_MOUSE As Short = 7
    Private Const WHEEL_DELTA As Short = 120
    Public Const WM_VSCROLL As Integer = &H115
    Private Const WM_USER As Integer = &H400
    Private Const WM_SOMETHING As Decimal = WM_USER + 3139
    Public Const GWL_WNDPROC As Short = -4
    Public Const WH_MOUSE_LL As Short = 14
    Public Const SB_LINEUP As Short = 0
    Public Const SB_LINELEFT As Short = 0
    Public Const SB_LINEDOWN As Short = 1
    Public Const SB_LINERIGHT As Short = 1
    Public Const SB_ENDSCROLL As Short = 8
    Public Const WS_VISIBLE As Integer = &H10000000
    Public Const SBS_VERT As Short = 1
    Public Const SBS_HORZ As Short = 0
    Public Const WM_HSCROLL As Integer = &H114
    Public Const SPI_GETWHEELSCROLLLINES As Short = 104

    Public Enum mButtons
        LBUTTON = &H1
        MBUTTON = &H10
        RBUTTON = &H2
    End Enum

    Public Const ERROR_NONE As Short = 0
    Public Const ERROR_BADDB As Short = 1
    Public Const ERROR_BADKEY As Short = 2
    Public Const ERROR_CANTOPEN As Short = 3
    Public Const ERROR_CANTREAD As Short = 4
    Public Const ERROR_CANTWRITE As Short = 5
    Public Const ERROR_OUTOFMEMORY As Short = 6
    Public Const ERROR_ARENA_TRASHED As Short = 7
    Public Const ERROR_ACCESS_DENIED As Short = 8
    Public Const ERROR_INVALID_PARAMETERS As Short = 87
    Public Const KEY_ALL_ACCESS As Integer = &H3F

    Declare Function RegQueryValueExString Lib "advapi32.dll" Alias "RegQueryValueExA" (ByVal hKey As Integer, ByVal lpValueName As String, ByVal lpReserved As Integer, ByRef lpType As Integer, ByVal lpData As String, ByRef lpcbData As Integer) As Integer
    Declare Function RegQueryValueExLong Lib "advapi32.dll" Alias "RegQueryValueExA" (ByVal hKey As Integer, ByVal lpValueName As String, ByVal lpReserved As Integer, ByRef lpType As Integer, ByRef lpData As Integer, ByRef lpcbData As Integer) As Integer
    Declare Function RegQueryValueExNULL Lib "advapi32.dll" Alias "RegQueryValueExA" (ByVal hKey As Integer, ByVal lpValueName As String, ByVal lpReserved As Integer, ByRef lpType As Integer, ByVal lpData As Integer, ByRef lpcbData As Integer) As Integer
    Declare Function RegSetValueExString Lib "advapi32.dll" Alias "RegSetValueExA" (ByVal hKey As Integer, ByVal lpValueName As String, ByVal Reserved As Integer, ByVal dwType As Integer, ByVal lpValue As String, ByVal cbData As Integer) As Integer
    Declare Function RegSetValueExLong Lib "advapi32.dll" Alias "RegSetValueExA" (ByVal hKey As Integer, ByVal lpValueName As String, ByVal Reserved As Integer, ByVal dwType As Integer, ByRef lpValue As Integer, ByVal cbData As Integer) As Integer

    Public XPos, nKeys, Delta, YPos As Integer
    Dim OriginalWindowProc As Integer
    Public pthWnd, lLineNumbers As Integer
    Dim MainWindowHwnd As Integer ' Main IDE window handle
    Dim bHook As Boolean
    Dim sLib As String
    Dim hLib As Integer


    Public Function WindowProc(ByVal hWnd As Integer, ByVal uMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
        Dim lRet As Integer
        Select Case uMsg
            Case WM_MOUSEWHEEL
                nKeys = wParam And 65535
                Delta = wParam / 65536 / WHEEL_DELTA
                XPos = LowWord(lParam)
                YPos = HighWord(lParam)
                pthWnd = WindowFromPointXY(XPos, YPos)
                ' Get the scroll bar for this window and send the vscroll to it
                'UPGRADE_WARNING: Add a delegate for AddressOf EnumChildProc Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="E9E157F7-EF0C-4016-87B7-7D7FBBC6EE08"'
                lRet = EnumChildWindows(pthWnd, AddressOf EnumChildProc, lParam)
        End Select
        If OriginalWindowProc <> 0 Then
            WindowProc = CallWindowProc(OriginalWindowProc, hWnd, uMsg, wParam, lParam)
        End If
    End Function

    Public Sub UnHookMouseWheel()
        'Ensures that you don't try to unsubclass the window when it is not subclassed.
        If OriginalWindowProc = 0 Then Exit Sub
        'Reset the window's function back to the original address.
        Dim hr As Integer
        hr = SetWindowLong(MainWindowHwnd, GWL_WNDPROC, OriginalWindowProc)
        If hr <> 0 Then
            OriginalWindowProc = 0
            bHook = False
        Else
            oErr.logError("Unable to unhook:  SetWindowLong returns " & vbCrLf & hr & vbCrLf & Err.LastDllError)
        End If
    End Sub

    Public Sub HookMouseWheel()
        On Error GoTo Error_Renamed
        ' [Titi 2.6.0] feature not available for Win 9x
        If Mid(modRegistry.VBWinVer, 9, 1) = "9" Or Mid(modRegistry.VBWinVer, 9, 1) = "M" Then Exit Sub
        ' GetLine Numbers
        SystemParametersInfo(SPI_GETWHEELSCROLLLINES, 0, lLineNumbers, 0)
        ' Adjust just in case, otherwise we'll never get the scroll notification.
        If lLineNumbers = 0 Then
            lLineNumbers = 1
        End If
        'UPGRADE_WARNING: Add a delegate for AddressOf WindowProc Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="E9E157F7-EF0C-4016-87B7-7D7FBBC6EE08"'
        OriginalWindowProc = SetWindowLong(MainWindowHwnd, GWL_WNDPROC, AddressOf WindowProc)
        ' Set a flag indicating that we are hooking
        bHook = True
        ' Find out where we live on the filesystem
        Dim lRetVal As Integer
        Dim sKeyName As String
        Dim sValue As String
        sKeyName = "CLSID\{B84F8C6E-BDDE-4384-9946-82EEE7F81D48}\InprocServer32"
        'UPGRADE_WARNING: Couldn't resolve default property of object QueryValue(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sValue = QueryValue(sKeyName, "")
        ' If we found where we live let's increase our ref count so we can do our own cleanup later
        If Len(sValue) > 0 Then
            sLib = sValue
            hLib = LoadLibrary(sLib)
        End If
        Exit Sub
Error_Renamed:
        oErr.logError("Unable to set hook:  " & vbCrLf & Err.Description & vbCrLf & Err.LastDllError)
    End Sub


    Function EnumChildProc(ByVal lhWnd As Integer, ByVal lParam As Integer) As Integer
        Dim retval As Integer
        Dim WinClassBuf As String
        Dim WinTitleBuf As String
        Dim WinClass, WinTitle As String
        Dim WinRect As RECT
        Dim WinWidth, WinHeight As Integer
        retval = GetClassName(pthWnd, WinClassBuf, 255)
        WinClass = StripNulls(WinClassBuf) ' remove extra Nulls & spaces
        retval = GetWindowText(lhWnd, WinTitleBuf, 255)
        WinTitle = StripNulls(WinTitleBuf)
        ' see the Windows Class and Title for each Child Window enumerated
        'Debug.Print "   hWnd = " & Hex(lhWnd) & " Child Class = "; WinClass; ", Title = "; WinTitle
        ' You can find any type of Window by searching for its WinClass
        Dim lRet As Integer
        Dim i As Integer
        ' Since we can have split windows we need to figure out which scroll bar to move.
        ' We can do this by comparing the Y position of the cursor against the vertical scrollbars
        ' that are children of the current window
        Dim wi As WINDOWINFO
        wi.cbSize = Len(wi)
        '   If GetWindowInfo(lhWnd, wi) And WinClass <> "MDIClient" Then
        If GetWindowInfo(lhWnd, wi) Then
            If IsVerticalScrollBar(lhWnd) = True And wi.rcWindow.Top < YPos And wi.rcWindow.Bottom > YPos Then ' TextBox Window
                If Delta > 0 Then ' Scroll Up
                    Do While i < Delta * lLineNumbers
                        lRet = PostMessage(pthWnd, WM_VSCROLL, SB_LINEUP, lhWnd)
                        i = i + 1
                    Loop
                Else ' Scroll Down
                    Do While i > Delta * lLineNumbers
                        lRet = PostMessage(pthWnd, WM_VSCROLL, SB_LINEDOWN, lhWnd)
                        i = i - 1
                    Loop
                End If
            ElseIf IsHorizontalScrollBar(lhWnd) = True Then
                If Delta > 0 Then ' Scroll Left
                    Do While i < Delta * lLineNumbers
                        lRet = PostMessage(pthWnd, WM_HSCROLL, SB_LINELEFT, lhWnd)
                        i = i + 1
                    Loop
                Else ' Scroll Right
                    Do While i > Delta * lLineNumbers
                        lRet = PostMessage(pthWnd, WM_HSCROLL, SB_LINERIGHT, lhWnd)
                        i = i - 1
                    Loop
                End If
            End If
        End If
        EnumChildProc = bHook ' Continue enumerating the windows based on whether we are hooking or not
        ' It's possible that the addin has already been requested to unload and in such a case we will call free library on ourselves
        ' to reduce our ref count since we incremented it on our own so we can do a clean shutdown
        If Not bHook Then
            If Not FreeLibrary(hLib) Then
                oErr.logError("Unable to FreeLibrary: " & Err.Number & vbCrLf & Err.LastDllError)
            End If
        End If
    End Function

    Function EnumThreadProc(ByVal lhWnd As Integer, ByVal lParam As Integer) As Integer
        Dim retval As Integer
        Dim WinClassBuf As String
        Dim WinTitleBuf As String
        Dim WinClass, WinTitle As String
        On Error GoTo Error_Renamed
        retval = GetClassName(lhWnd, WinClassBuf, 255)
        WinClass = StripNulls(WinClassBuf) ' remove extra Nulls & spaces
        retval = GetWindowText(lhWnd, WinTitleBuf, 255)
        WinTitle = StripNulls(WinTitleBuf)
        ' see the Windows Class and Title for top level Window
        'Debug.Print "Thread Window Class = "; WinClass; ", Title = "; WinTitle
        EnumThreadProc = True
        '   If InStr(1, WinTitle, "Microsoft Visual Basic") <> 0 And WinClass = "wndclass_desked_gsk" And MainWindowHwnd = 0 Then
        If MainWindowHwnd = 0 Then
            MainWindowHwnd = lhWnd
            ' Setup the windows Hook
            HookMouseWheel()
        End If
        Exit Function
Error_Renamed:
        oErr.logError(Err.Description)
    End Function

    Public Function StripNulls(ByRef OriginalStr As String) As String
        ' This removes the extra Nulls so String comparisons will work
        If (InStr(OriginalStr, Chr(0)) > 0) Then
            OriginalStr = Left(OriginalStr, InStr(OriginalStr, Chr(0)) - 1)
        End If
        StripNulls = OriginalStr
    End Function

    Public Function IsVerticalScrollBar(ByRef hWnd As Integer) As Boolean
        ' Check the style of the window specified by hWnd to see if it's a vertical scrollbar
        Dim wi As WINDOWINFO
        wi.cbSize = Len(wi)
        If GetWindowInfo(hWnd, wi) Then
            If (wi.dwStyle And WS_VISIBLE) > 0 And (wi.dwStyle And SBS_VERT) > 0 Then
                IsVerticalScrollBar = True
                Exit Function
            End If
        End If
        IsVerticalScrollBar = False
    End Function

    Public Function IsHorizontalScrollBar(ByRef hWnd As Integer) As Boolean
        ' Check the style of the window specified by hWnd to see if it's a horizontal scrollbar
        Dim wi As WINDOWINFO
        wi.cbSize = Len(wi)
        If GetWindowInfo(hWnd, wi) Then
            If (wi.dwStyle And WS_VISIBLE) > 0 And (wi.dwStyle And SBS_HORZ) > 0 Then
                IsHorizontalScrollBar = True
                Exit Function
            End If
        End If
        IsHorizontalScrollBar = False
    End Function

    Private Function QueryValue(ByRef sKeyName As String, ByRef sValueName As String) As Object
        Dim lRetVal As Integer 'result of the API functions
        Dim hKey As Integer 'handle of opened key
        Dim vValue As Object 'setting of queried value
        lRetVal = RegOpenKeyEx(HKEY_CLASSES_ROOT, sKeyName, 0, KEY_QUERY_VALUE, hKey)
        lRetVal = QueryValueEx(hKey, sValueName, vValue)
        RegCloseKey(hKey)
        'UPGRADE_WARNING: Couldn't resolve default property of object vValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object QueryValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        QueryValue = vValue
    End Function

    Public Function SetValueEx(ByVal hKey As Integer, ByRef sValueName As String, ByRef lType As Integer, ByRef vValue As Object) As Integer
        Dim lValue As Integer
        Dim sValue As String
        Select Case lType
            Case REG_SZ
                'UPGRADE_WARNING: Couldn't resolve default property of object vValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sValue = vValue & Chr(0)
                SetValueEx = RegSetValueExString(hKey, sValueName, 0, lType, sValue, Len(sValue))
            Case REG_DWORD
                'UPGRADE_WARNING: Couldn't resolve default property of object vValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                lValue = vValue
                SetValueEx = RegSetValueExLong(hKey, sValueName, 0, lType, lValue, 4)
        End Select
    End Function

    Function QueryValueEx(ByVal lhKey As Integer, ByVal szValueName As String, ByRef vValue As Object) As Integer
        Dim lType, cch, lrc, lValue As Integer
        Dim sValue As String
        On Error GoTo QueryValueExError
        ' Determine the size and type of data to be read
        lrc = RegQueryValueExNULL(lhKey, szValueName, 0, lType, 0, cch)
        If lrc <> ERROR_NONE Then Error (5)
        Select Case lType
            ' For strings
            Case REG_SZ
                sValue = New String(Chr(0), cch)
                lrc = RegQueryValueExString(lhKey, szValueName, 0, lType, sValue, cch)
                If lrc = ERROR_NONE Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object vValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    vValue = Left(sValue, cch - 1)
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object vValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    vValue = Nothing
                End If
                ' For DWORDS
            Case REG_DWORD
                lrc = RegQueryValueExLong(lhKey, szValueName, 0, lType, lValue, cch)
                'UPGRADE_WARNING: Couldn't resolve default property of object vValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If lrc = ERROR_NONE Then vValue = lValue
            Case Else
                'all other data types not supported
                lrc = -1
        End Select
QueryValueExExit:
        QueryValueEx = lrc
        Exit Function
QueryValueExError:
        Resume QueryValueExExit
    End Function

    Private Function LowWord(ByVal inDWord As Integer) As Short
        LowWord = inDWord And &H7FFF
        If (inDWord And &H8000) Then LowWord = LowWord Or &H8000
    End Function

    Private Function HighWord(ByVal inDWord As Integer) As Short
        HighWord = LowWord(((inDWord And &HFFFF0000) \ &H10000) And &HFFFF)
    End Function
    ' [Titi 2.5.1] end of mousewheel support

    Public Function VBWinVer() As String
        ' Système       Plateforme   Majeur  Mineur   Build
        ' Windows 95        1           4      0
        ' Windows 98        1           4     10      1998
        ' Windows 98SE      1           4     10      2222
        ' Windows Me        1           4     90      3000
        ' NT 3.51           2           3     51
        ' NT                2           4      0      1381
        ' 2000              2           5      0
        ' XP                2           5      1      2600
        ' Server 2003       2           5      2
        Dim OSInfo As OSVERSIONINFO
        Dim retvalue As Short
        OSInfo.dwOSVersionInfoSize = 156
        OSInfo.szCSDVersion = Space(128)
        retvalue = GetVersionExA(OSInfo)
        With OSInfo
            Select Case .dwPlatformId
                Case VER_PLATFORM_WIN32s ' Win32s / Windows 3.1
                    VBWinVer = "Windows 3.1"
                Case VER_PLATFORM_WIN32_WINDOWS ' Windows 95, Windows 98,
                    Select Case .dwMinorVersion ' ou Windows Me
                        Case 0
                            VBWinVer = "Windows 95"
                        Case 10
                            If (OSInfo.dwBuildNumber And &HFFFF) = 2222 Then
                                VBWinVer = "Windows 98SE"
                            Else
                                VBWinVer = "Windows 98"
                            End If
                        Case 90
                            VBWinVer = "Windows Me"
                    End Select
                Case VER_PLATFORM_WIN32_NT ' Windows NT, Windows 2000, Windows XP,
                    Select Case .dwMajorVersion ' ou Windows Server 2003 family.
                        Case 3
                            VBWinVer = "Windows NT 3.51"
                        Case 4
                            VBWinVer = "Windows NT 4.0"
                        Case 5
                            Select Case .dwMinorVersion
                                Case 0
                                    VBWinVer = "Windows 2000"
                                Case 1
                                    VBWinVer = "Windows XP"
                                Case 2
                                    VBWinVer = "Windows Server 2003"
                            End Select
                    End Select
                Case Else
                    VBWinVer = "Failed"
            End Select
            If VBWinVer <> "Failed" And .wServicePackMajor <> 0 Then
                'Ajouter la version du Service Pack Installé
                VBWinVer = VBWinVer & " Service Pack " & Trim(Str(.wServicePackMajor)) & "." & Trim(Str(.wServicePackMinor))
            End If
        End With
    End Function

    Public Function fDeleteKey(ByVal sTopKey As String, ByVal sSubKey As String, ByVal sKeyName As String) As Integer
        ' Written by Dave Scarmozzino  www.TheScarms.com
        '
        ' Use this function to:
        '   -   Delete a registry key.
        ' sTopKey
        '   -   A top level registry key abbreviation {"HKCU","HKLM","HKU","HKDD","HKCC","HKCR"}
        ' sSubKey
        '   -   A registry subkey.
        ' sKeyName
        '   -   The name of the key to delete.
        ' Return Value
        '   -   0 if successful, non-zero otherwise.
        ' Example
        '   lResult = fDeleteKey("HKCU", "Software\YourKey\...\YourApp", "KeyToDelete")
        '   Call fDeleteKey("HKCU", "Software\YourKey\...\YourApp", "KeyToDelete")
        ' NOTE:
        '   The key to be deleted cannot be a top-level key and cannot have any sub-keys.
        '
        Dim lHandle, lTopKey, lResult As Integer
        On Error GoTo fDeleteKeyError
        lResult = 99
        lTopKey = fTopKey(sTopKey)
        If lTopKey = 0 Then GoTo fDeleteKeyError
        lResult = RegOpenKeyEx(lTopKey, sSubKey, 0, KEY_CREATE_SUB_KEY, lHandle)
        If lResult = ERROR_SUCCESS Then
            lResult = RegDeleteKey(lHandle, sKeyName)
        End If
        If lResult = ERROR_SUCCESS Or lResult = ERROR_FILE_NOT_FOUND Then
            fDeleteKey = ERROR_SUCCESS
        Else
            fDeleteKey = lResult
        End If
        Exit Function
fDeleteKeyError:
        fDeleteKey = lResult
    End Function

    Public Function fDeleteValue(ByVal sTopKeyOrFile As String, ByVal sSubKeyOrSection As String, ByVal sValueName As String) As Integer
        ' Written by Dave Scarmozzino  www.TheScarms.com
        '
        ' Use this function to:
        '   -   Delete a registry value.
        '   -   Delete an .ini file value.
        ' sTopKeyOrIniFile
        '   -   A top level registry key abbreviation {"HKCU","HKLM","HKU","HKDD","HKCC","HKCR"} or
        '   -   The full path of an .ini file (ex. "C:\Windows\MyFile.ini")
        ' sSubKeyOrSection
        '   -   A registry subkey or
        '   -   An .ini file section name
        ' sValueName
        '   -   A registry entry or
        '   -   An .ini file entry
        ' Return Value
        '   -   0 if successful, non-zero otherwise.
        ' Example 1   -   Delete a registry value.
        '   lResult = fDeleteValue("HKCU", "Software\YourKey\LastKey\YourApp", "EntryToDelete")
        ' Example 2   -   Delete an .ini file value.
        '   lResult = fDeleteValue("C:\Windows\Myfile.ini", "SectionName", "EntryToDelete")
        '
        Dim lHandle, lTopKey, lResult As Integer
        On Error GoTo fDeleteValueError
        lResult = 99
        lTopKey = fTopKey(sTopKeyOrFile)
        If lTopKey = 0 Then GoTo fDeleteValueError
        If lTopKey = 1 Then
            lResult = WritePrivateProfileString(sSubKeyOrSection, sValueName, "", sTopKeyOrFile)
        Else
            lResult = RegOpenKeyEx(lTopKey, sSubKeyOrSection, 0, KEY_SET_VALUE, lHandle)
            If lResult = ERROR_SUCCESS Then
                lResult = RegDeleteValue(lHandle, sValueName)
            End If

            If lResult = ERROR_SUCCESS Or lResult = ERROR_FILE_NOT_FOUND Then
                fDeleteValue = ERROR_SUCCESS
            Else
                fDeleteValue = lResult
            End If
        End If
        Exit Function
fDeleteValueError:
        fDeleteValue = lResult
    End Function

    Public Function fEnumKey(ByVal sTopKey As String, ByVal sSubKey As String, ByRef sValues As String) As Integer
        ' Written by Dave Scarmozzino  www.TheScarms.com
        '
        ' Use this function to:
        '   -   Enumerate the subkeys of a registry key.
        ' sTopKey
        '   -   A top level registry key abbreviation {"HKCU","HKLM","HKU","HKDD","HKCC","HKCR"}
        ' sSubKey
        '   -   A registry subkey
        ' sValues
        '   -   A returned string of the form:
        '           SubKeyName|SubKeyName|.... SubKeyName||           Where - "|" equals vbNullChar (chr(0)).
        ' Return Value
        '   -   0 if successful, non-zero otherwise.
        ' Example 1
        '   lResult = fEnumKey("HKLM", "Software\Microsoft", sValues)
        Dim bDone As Boolean
        Dim lResult, lTopKey, lHandle, lIndex As Integer
        Dim sKeyName As String
        On Error GoTo fEnumKeyError
        lResult = 99
        lTopKey = fTopKey(sTopKey)
        If lTopKey = 0 Then GoTo fEnumKeyError
        ' Open the registry SubKey.
        lResult = RegOpenKeyEx(lTopKey, sSubKey, 0, KEY_ENUMERATE_SUB_KEYS, lHandle)
        If lResult <> ERROR_SUCCESS Then GoTo fEnumKeyError
        ' Get all subkeys until ERROR_NO_MORE_ITEMS or an error occurs.
        Do While Not bDone
            sKeyName = Space(MAX_SIZE)
            lResult = RegEnumKey(lHandle, lIndex, sKeyName, MAX_SIZE)
            If lResult = ERROR_SUCCESS Then
                sValues = sValues & Trim(sKeyName)
                lIndex = lIndex + 1
            Else
                bDone = True
            End If
        Loop
        sValues = sValues & vbNullChar
        If Len(sValues) = 1 Then sValues = sValues & vbNullChar
        ' Close the key.
        fEnumKey = RegCloseKey(lHandle)
        Exit Function
        ' Error processing.
fEnumKeyError:
        fEnumKey = lResult
    End Function

    Public Function fEnumValue(ByVal sTopKeyOrIniFile As String, ByVal sSubKeyOrSection As String, ByRef sValues As String) As Integer
        ' Written by Dave Scarmozzino  www.TheScarms.com
        '
        ' Use this function to:
        '   -   Enumerate the values of a registry key or
        '   -   Enumerate all entries in a particular section of an .ini file.
        ' sTopKeyOrIniFile
        '   -   A top level registry key abbreviation {"HKCU","HKLM","HKU","HKDD","HKCC","HKCR"} or
        '   -   The full path of an .ini file (ex. "C:\Windows\MyFile.ini")
        ' sSubKeyOrSection
        '   -   A registry subkey or
        '   -   An .ini file section name
        ' sValues
        '   -   A returned string of the form:
        '           EntryName=Value|EntryName=Value|.... EntryName=Value||       Where: - Value can be a string or binary value.
        '                                                                           and - "|" equals vbNullChar (chr(0)).
        ' Return Value
        '   -   0 if successful, non-zero otherwise.
        ' Example 1
        '   lResult = fEnumValue("HKCU", "Software\YourKey\LastKey\YourApp", sValues)
        ' Example 2
        '   lResult = fEnumValue("C:\Windows\Myfile.ini", "SectionName", sValues)
        ' NOTE:
        '   When enumerating registry values, only string, dword and binary values
        '   with a length under 2 bytes (which allows for true/false values) are returned.
        Dim lIndex, lResult, lTopKey, lHandle, lValueLen, lValue As Integer
        Dim lData, lValueType, lDataLen As Integer
        Dim bDone As Boolean
        Dim sValueName, sValue As String
        On Error GoTo fEnumValueError
        lResult = 99
        lTopKey = fTopKey(sTopKeyOrIniFile)
        If lTopKey = 0 Then GoTo fEnumValueError
        If lTopKey = 1 Then
            ' Enumerate an .ini file section.
            sValues = Space(MAX_INISIZE)
            lResult = GetPrivateProfileSection(sSubKeyOrSection, sValues, Len(sValues), sTopKeyOrIniFile)
        Else
            ' Open the registry SubKey.
            lResult = RegOpenKeyEx(lTopKey, sSubKeyOrSection, 0, KEY_QUERY_VALUE, lHandle)
            If lResult <> ERROR_SUCCESS Then GoTo fEnumValueError
            ' Get all values until ERROR_NO_MORE_ITEMS or an error occurs.
            Do While Not bDone
                lDataLen = MAX_SIZE
                lValueLen = lDataLen
                sValueName = Space(lDataLen)
                lResult = RegEnumValue(lHandle, lIndex, New StringBuilder(sValueName), lValueLen, 0, lValueType, lData, lDataLen)
                If lResult = ERROR_SUCCESS Then
                    Select Case lValueType
                        Case REG_SZ
                            sValue = Space(lDataLen)
                            sValueName = Left(sValueName, lValueLen)
                            lResult = RegQueryValueEx(lHandle, sValueName, 0, REG_SZ, CType(sValue, Byte()), lDataLen)
                            If lResult = ERROR_SUCCESS Then
                                sValues = sValues & sValueName & "=" & sValue
                            Else
                                GoTo fEnumValueError
                            End If
                        Case REG_DWORD
                            lResult = RegQueryValueEx(lHandle, sValueName, 0, REG_NONE, CType(lValue, Byte()), lDataLen)
                            If lResult = ERROR_SUCCESS Then
                                sValueName = Left(sValueName, lValueLen)
                                sValues = sValues & sValueName & "=" & lValue & vbNullChar
                            Else
                                GoTo fEnumValueError
                            End If
                        Case REG_BINARY
                            If lDataLen <= 2 Then
                                lResult = RegQueryValueEx(lHandle, sValueName, 0, REG_NONE, lValue, lDataLen)
                                If lResult = ERROR_SUCCESS Then
                                    sValueName = Left(sValueName, lValueLen)
                                    sValues = sValues & sValueName & "=" & lValue & vbNullChar
                                Else
                                    GoTo fEnumValueError
                                End If
                            End If
                        Case Else
                    End Select
                    lIndex = lIndex + 1
                Else
                    bDone = True
                End If
            Loop
            sValues = sValues & vbNullChar
            If Len(sValues) = 1 Then sValues = sValues & vbNullChar
            ' Close the key.
            lResult = RegCloseKey(lHandle)
            fEnumValue = lResult
        End If
        Exit Function
        ' Error processing.
fEnumValueError:
        fEnumValue = lResult
    End Function

    Public Function fReadIniFuzzy(ByVal sIniFile As String, ByRef sSection As String, ByVal sIniEntry As String, ByVal sDefault As String, ByRef sValue As String) As Integer
        ' Written by Dave Scarmozzino  www.TheScarms.com
        '
        ' Use this function to:
        '   -   Read a string value from an .ini file when you do not know the exact
        '       name of the section the value is in.
        ' sIniFile
        '   -   The full path of an .ini file (ex. "C:\Windows\MyFile.ini")
        ' sSection
        '   -   Any complete part of the .ini file section name.
        '       Ex:   [ABC DEF GHI JKL]
        '       sSection Name can be "ABC" or "DEF" or "GHI" or "JKL" but not
        '       a partial value such as "AB" or "HI".
        '
        '       NOTE: if sSection is passed as a variable and not as the actual
        '             string value, sSection will be populated with the
        '             complete section name.
        '
        ' sEntry
        '   -   An .ini file entry
        ' sDefault
        '   -   The default value to return.
        ' sValue
        '   -   The string value read.
        '   -   sDefault if unsuccessful.
        ' Return Value
        '   -   0 if sEntry was found, non-zero otherwise.
        ' Example 1   -   Read a string value from an .ini file.
        '       Ex:   [ABC DEF GHI JKL]
        '             AppName="My App"
        '   sEntry = "AppName"
        '   lResult = fReadIniFuzzy("C:\Windows\Myfile.ini", "DEF", sEntry, sValue)
        '   Upon completion:
        '       lResult  = 0
        '       sSection = "ABC DEF GHI JKL"
        '       sValue   = "My App"
        '
        Dim sEntry, sNextChar, sLine, sSectionName As String
        Dim iLocOfEq, iLen, iFnum As Short
        Dim bFound, bDone, bNewSection As Boolean
        On Error GoTo fReadIniFuzzyError
        fReadIniFuzzy = 99
        bDone = False
        sValue = sDefault
        sEntry = UCase(sIniEntry)
        sSection = UCase(sSection)
        iLen = Len(sSection)
        iFnum = FreeFile()
        FileOpen(iFnum, sIniFile, OpenMode.Input, OpenAccess.Read)
        sLine = LineInput(iFnum)
        Dim iPos As Short
        Do While Not EOF(iFnum) And Not bDone
            sLine = UCase(Trim(sLine))
            bNewSection = False
            ' See if line is a section heading.
            If Left(sLine, 1) = "[" Then
                ' See if section heading contains desired value.
                sSectionName = sLine
                iPos = InStr(1, sLine, sSection)
                If iPos > 0 Then
                    ' Be sure the value is not part of a larger value.
                    sNextChar = Mid(sLine, iPos + iLen, 1)
                    If sNextChar = " " Or sNextChar = "]" Then
                        ' Search this section for the entry.
                        sLine = LineInput(iFnum)
                        bFound = False
                        bNewSection = False
                        Do While Not EOF(iFnum) And Not bFound
                            ' If we hit a new section, stop.
                            sLine = UCase(Trim(sLine))
                            If Left(sLine, 1) = "[" Then
                                bNewSection = True
                                Exit Do
                            End If
                            ' Entry must start in column 1 to avoid comment lines.
                            If InStr(1, sLine, sEntry) = 1 Then
                                ' If entry found and line is not incomplete, get value.
                                iLocOfEq = InStr(1, sLine, "=")
                                If iLocOfEq <> 0 Then
                                    sValue = Mid(sLine, iLocOfEq + 1)
                                    sSection = Mid(sSectionName, 2, InStr(1, sSectionName, "]") - 2)
                                    bFound = True
                                    bDone = True
                                    fReadIniFuzzy = 0
                                End If
                            End If
                            If Not bFound Then
                                sLine = LineInput(iFnum)
                            End If
                        Loop
                        If EOF(iFnum) Then bDone = True
                        sSection = Mid(sSectionName, 2, InStr(1, sSectionName, "]") - 2)
                    End If
                End If
            End If
            If Not bNewSection And Not bDone Then
                sLine = LineInput(iFnum)
            End If
        Loop
        FileClose(iFnum)
        Exit Function
fReadIniFuzzyError:
        fReadIniFuzzy = 99
    End Function

    Public Function fReadValue(ByVal sTopKeyOrFile As String, ByVal sSubKeyOrSection As String, ByVal sValueName As String, ByVal sValueType As String, ByVal vDefault As Object, ByRef vValue As Object, Optional ByRef lLenData As Integer = 255) As Integer
        ' Written by Dave Scarmozzino  www.TheScarms.com
        '
        ' Use this function to read a:
        '   -   String, 16-bit binary (True|False), 32-bit integer registry value or
        '   -   String or integer value from an .ini file.
        ' sTopKeyOrIniFile
        '   -   A top level registry key abbreviation {"HKCU","HKLM","HKU","HKDD","HKCC","HKCR"} or
        '   -   The full path of an .ini file (ex. "C:\Windows\MyFile.ini")
        ' sSubKeyOrSection
        '   -   A registry subkey or
        '   -   An .ini file section name
        ' sValueName
        '   -   A registry entry or
        '   -   An .ini file entry
        ' sValueType
        '   -   "S" to read a string value or
        '   -   "B" to read a 16-bit binary value (applies to registry use only) or
        '   -   "D" to read a 32-bit number value (applies to registry use only).
        ' vDefault
        '   -   The default value to return. It can be a string or boolean.
        ' vValue
        '   -   The value read. It can be a string or boolean.
        '   -   vDefault if unsuccessful (0 when reading an integer from an .ini file)
        ' Return Value
        '   -   0 if successful, non-zero otherwise.
        '
        ' Example 1   -   Read a string value from the registry.
        '   lResult = fReadValue("HKCU", "Software\YourKey\LastKey\YourApp", "AppName", "S", "", sValue)
        ' Example 2   -   Read a boolean (True|False) value from the registry.
        '   lResult = fReadValue("HKCU", "Software\YourKey\LastKey\YourApp", "AutoHide", "B", False, bValue)
        ' Example 3   -   Read an integer value from the registry.
        '   lResult = fReadValue("C:\Windows\Myfile.ini", "SectionName", "NumApps", "D", 12345, lValue)
        ' Example 4   -   Read a string value from an .ini file.
        '   lResult = fReadValue("C:\Windows\Myfile.ini", "SectionName", "AppName", "S", "", sValue)
        '
        ' Example 5   -   Read an integer value from an .ini file.
        '   lResult = fReadValue("C:\Windows\Myfile.ini", "SectionName", "NumApps", "B", "0", iValue)
        '
        Dim lTopKey, lHandle As Integer
        'Dim lLenData    As Long
        Dim lDefault, lResult, lValue As Integer
        Dim sSubKeyPath, sValue, sDefaultStr As String
        Dim bValue As Boolean
        On Error GoTo fReadValueError
        lResult = 99
        'UPGRADE_WARNING: Couldn't resolve default property of object vDefault. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object vValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vValue = vDefault
        lTopKey = fTopKey(sTopKeyOrFile)
        If lTopKey = 0 Then GoTo fReadValueError
        If lTopKey = 1 Then
            ' Read the .ini file value.
            If UCase(sValueType) = "S" Then
                'lLenData = 1024 '255
                'UPGRADE_WARNING: Couldn't resolve default property of object vDefault. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sDefaultStr = vDefault
                sValue = Space(lLenData)
                lResult = GetPrivateProfileString(sSubKeyOrSection, sValueName, sDefaultStr, sValue, lLenData, sTopKeyOrFile)
                'UPGRADE_WARNING: Couldn't resolve default property of object vValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                vValue = Left(sValue, lResult)
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object vDefault. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                lDefault = CShort(vDefault)
                lResult = GetPrivateProfileInt(sSubKeyOrSection, sValueName, lDefault, sTopKeyOrFile)
                If lResult > ERROR_SUCCESS Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object vValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    vValue = lResult
                End If
                'vValue = bValue
            End If
        Else
            ' Open the registry SubKey.
            lResult = RegOpenKeyEx(lTopKey, sSubKeyOrSection, 0, KEY_QUERY_VALUE, lHandle)
            If lResult <> ERROR_SUCCESS Then
                fReadValue = lResult
                Exit Function
            End If
            ' Get the actual value.
            Select Case UCase(sValueType)
                Case "S"
                    ' String value. The first query gets the string length. The second gets the string value.
                    lResult = RegQueryValueEx(lHandle, sValueName, 0, REG_SZ, "", lLenData)
                    If lResult = ERROR_MORE_DATA Then
                        sValue = Space(lLenData)
                        lResult = RegQueryValueEx(lHandle, sValueName, 0, REG_SZ, sValue, lLenData)
                    End If
                    If lResult = ERROR_SUCCESS Then 'Remove null character.
                        'UPGRADE_WARNING: Couldn't resolve default property of object vValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        vValue = Left(sValue, lLenData - 1)
                    Else
                        GoTo fReadValueError
                    End If
                Case "B"
                    lLenData = Len(bValue)
                    lResult = RegQueryValueEx(lHandle, sValueName, 0, REG_BINARY, bValue, lLenData)
                    If lResult = ERROR_SUCCESS Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object vValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        vValue = bValue
                    Else
                        GoTo fReadValueError
                    End If
                Case "D"
                    lLenData = 32
                    lResult = RegQueryValueEx(lHandle, sValueName, 0, REG_DWORD, lValue, lLenData)
                    If lResult = ERROR_SUCCESS Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object vValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        vValue = lValue
                    Else
                        GoTo fReadValueError
                    End If
            End Select
            ' Close the key.
            lResult = RegCloseKey(lHandle)
            fReadValue = lResult
        End If
        Exit Function
        ' Error processing.
fReadValueError:
        fReadValue = lResult
    End Function

    Private Function fTopKey(ByVal sTopKeyOrFile As String) As Integer
        Dim sDir As String
        ' Written by Dave Scarmozzino  www.TheScarms.com
        '
        ' This function returns:
        '   -   the numeric value of a top level registry key or
        '   -   1 if sTopKey is a valid .ini file or
        '   -   0 otherwise.
        On Error GoTo fTopKeyError
        fTopKey = 0
        Select Case UCase(sTopKeyOrFile)
            Case "HKCU"
                fTopKey = HKEY_CURRENT_USER
            Case "HKLM"
                fTopKey = HKEY_LOCAL_MACHINE
            Case "HKU"
                fTopKey = HKEY_USERS
            Case "HKDD"
                fTopKey = HKEY_DYN_DATA
            Case "HKCC"
                fTopKey = HKEY_CURRENT_CONFIG
            Case "HKCR"
                fTopKey = HKEY_CLASSES_ROOT
            Case Else
                On Error Resume Next
                'sDir = Dir$(sTopKeyOrFile)
                'If Err.Number = 0 And sDir <> "" Then fTopKey = 1
                If Err.Number = 0 And oFileSys.CheckExists(sTopKeyOrFile, clsInOut.IOActionType.File) Then fTopKey = 1
        End Select
        Exit Function
fTopKeyError:
    End Function

    Public Function fWriteValue(ByVal sTopKeyOrFile As String, ByVal sSubKeyOrSection As String, ByVal sValueName As String, ByVal sValueType As String, ByVal vValue As Object) As Integer
        ' Written by Dave Scarmozzino  www.TheScarms.com
        '
        ' Use this function to write a:
        '   -   String, 16-bit binary (True|False), 32-bit integer registry value or
        '   -   String value to an .ini file.
        ' sTopKeyOrIniFile
        '   -   A top level registry key abbreviation {"HKCU","HKLM","HKU","HKDD","HKCC","HKCR"} or
        '   -   The full path of an .ini file (ex. "C:\Windows\MyFile.ini")
        ' sSubKeyOrSection
        '   -   A registry subkey or
        '   -   An .ini file section name
        ' sValueName
        '   -   A registry entry or
        '   -   An .ini file entry
        ' sValueType
        '   -   "S" to write a string value or
        '   -   "B" to write a 16-bit binary value (applies to registry use only) or
        '   -   "D" to write a 32-bit number value (applies to registry use only).
        ' vValue
        '   -   The value to write. It can be a string, binary or integer.
        ' Return Value
        '   -   0 if successful, non-zero otherwise.
        '
        ' Example 1   -   Write a string value to the registry.
        '   lResult = fWriteValue("HKCU", "Software\YourKey\LastKey\YourApp", "AppName", "S", "MyApp")
        ' Example 2   -   Write a True|False value to the registry.
        '   lResult = fWriteValue("HKCU", "Software\YourKey\LastKey\YourApp", "AutoHide", "B", True)
        ' Example 3   -   Write an integer value to the registry.
        '   lResult = fWriteValue("HKCU", "Software\YourKey\LastKey\YourApp", "NumOfxxx", "D", 12345)
        ' Example 4   -   Write a string value to an .ini file.
        '   lResult = fWriteValue("C:\Windows\Myfile.ini", "SectionName", "AppName", "S", "MyApp")
        '
        ' NOTE:
        '   This function cannot write a non-string value to an .ini file.
        '
        Dim lsamDesired, lTopKey, hKey, lOptions, lHandle As Integer
        Dim lResult, lDisposition, lLenData, lValue As Integer
        Dim sValue, sClass, sSubKeyPath As String
        Dim bValue As Boolean
        Dim tSecurityAttributes As SECURITY_ATTRIBUTES
        On Error GoTo fWriteValueError
        lResult = 99
        lTopKey = fTopKey(sTopKeyOrFile)
        If lTopKey = 0 Then GoTo fWriteValueError
        If lTopKey = 1 Then
            ' Read the .ini file value.
            If UCase(sValueType) = "S" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object vValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sValue = vValue
                lResult = WritePrivateProfileString(sSubKeyOrSection, sValueName, sValue, sTopKeyOrFile)
            Else
                GoTo fWriteValueError
            End If
        Else
            sClass = ""
            lOptions = REG_OPTION_NON_VOLATILE
            lsamDesired = KEY_CREATE_SUB_KEY Or KEY_SET_VALUE
            ' Create the SubKey or open it if it exists. Return its handle.
            ' lDisposition will be REG_CREATED_NEW_KEY if the key did not exist.
            lResult = RegCreateKeyEx(lTopKey, sSubKeyOrSection, 0, sClass, lOptions, lsamDesired, tSecurityAttributes, lHandle, lDisposition)
            If lResult <> ERROR_SUCCESS Then GoTo fWriteValueError
            ' Set the actual value.
            Select Case UCase(sValueType)
                Case "S"
                    'UPGRADE_WARNING: Couldn't resolve default property of object vValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sValue = vValue
                    '02/05/2002            lLenData = Len(sValue) + 1
                    lLenData = Len(sValue)
                    lResult = RegSetValueEx(lHandle, sValueName, 0, REG_SZ, sValue, lLenData)
                Case "B"
                    'UPGRADE_WARNING: Couldn't resolve default property of object vValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    bValue = vValue
                    lLenData = Len(bValue)
                    lResult = RegSetValueEx(lHandle, sValueName, 0, REG_BINARY, bValue, lLenData)
                Case "D"
                    'UPGRADE_WARNING: Couldn't resolve default property of object vValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    lValue = CShort(vValue)
                    lLenData = 4
                    lResult = RegSetValueEx(lHandle, sValueName, 0, REG_DWORD, lValue, lLenData)
            End Select
            ' Close the key.
            If lResult = ERROR_SUCCESS Then
                lResult = RegCloseKey(lHandle)
                fWriteValue = lResult
                Exit Function
            End If
        End If
        Exit Function
        ' Error processing.
fWriteValueError:
        fWriteValue = lResult
    End Function
End Module