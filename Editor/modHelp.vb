Option Strict Off
Option Explicit On
Module modHelp
	Declare Function HtmlHelp Lib "hhctrl.ocx"  Alias "HtmlHelpA"(ByVal hwndCaller As Integer, ByVal pszFile As String, ByVal uCommand As Integer, ByVal dwData As Integer) As Integer
	
	
	Public Const HH_DISPLAY_TOPIC As Integer = &H0
	Public Const HH_SET_WIN_TYPE As Integer = &H4
	Public Const HH_GET_WIN_TYPE As Integer = &H5
	Public Const HH_GET_WIN_HANDLE As Integer = &H6
	Public Const HH_DISPLAY_TEXT_POPUP As Integer = &HE
	' Display string resource ID or ' text in a pop-up window.
	Public Const HH_HELP_CONTEXT As Integer = &HF
	' Display mapped numeric value in ' dwData.
	Public Const HH_TP_HELP_CONTEXTMENU As Integer = &H10
	' Text pop-up help, similar to ' WinHelp's HELP_CONTEXTMENU.
	Public Const HH_TP_HELP_WM_HELP As Integer = &H11
	' text pop-up help, similar to ' WinHelp's HELP_WM_HELP.
End Module