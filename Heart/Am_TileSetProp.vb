Option Strict Off
Option Explicit On
Friend Class frmTileSetProp
	Inherits System.Windows.Forms.Form
	Dim TreeViewX As AxComctlLib.AxTreeView
	Dim TileSetX As TileSet
	Dim Dirty As Short
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub ShowCombatPic(ByRef PictureFile As String)
		Dim Tome_Renamed As Object
		'UPGRADE_WARNING: Arrays in structure bmPic may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmPic As BITMAPINFO
		Dim hMemPic As Integer
		Dim FileName As String
		Dim rc, lpMem, TransparentRGB As Integer
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor ' Hourglass
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileName = Dir(Tome.LoadPath & "\" & PictureFile)
		If FileName = "" Then
			'        FileName = gAppPath & "\data\graphics\wallpapers\" & PictureFile
			FileName = gDataPath & "\graphics\wallpapers\" & PictureFile
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.LoadPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FileName = Tome.LoadPath & "\" & PictureFile
		End If
		frmMDI.ShowMsg("Loading Picture " & PictureFile & "...")
		' Load TileSet bitmap
		'    ReadBitmapFile PictureFile, bmPic, hMemPic, TransparentRGB ' [Titi 2.5.1] PictureFile doesn't include the path!
		ReadBitmapFile(FileName, bmPic, hMemPic, TransparentRGB)
		' Paint bitmap to picture box using converted palette
		lpMem = GlobalLock(hMemPic)
		'UPGRADE_ISSUE: PictureBox property picCombatWallpaper.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = SetStretchBltMode(picCombatWallpaper.hdc, 3)
		'UPGRADE_ISSUE: PictureBox property picCombatWallpaper.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchDIBits(picCombatWallpaper.hdc, 0, 0, picCombatWallpaper.ClientRectangle.Width, picCombatWallpaper.ClientRectangle.Width, 0, 0, bmPic.bmiHeader.biWidth, bmPic.bmiHeader.biHeight, lpMem, bmPic, DIB_RGB_COLORS, SRCCOPY)
		picCombatWallpaper.Refresh()
		' Release memory
		rc = GlobalUnlock(hMemPic)
		rc = GlobalFree(hMemPic)
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default ' Default
	End Sub
	
	Private Sub SetCombatPic()
		On Error Resume Next
		'    dlgFile.FileName = gAppPath & "\Data\Graphics\Wallpapers\*.bmp"
		dlgFileOpen.FileName = gDataPath & "\Graphics\Wallpapers\*.bmp"
		dlgFileOpen.Title = "Select Background"
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
		' Depending on file chosen, get other files
		'UPGRADE_WARNING: CommonDialog property dlgFile.FileTitle was upgraded to dlgFile.FileName which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		txtCombatPic.Text = dlgFileOpen.FileName
		frmMDI.ShowMsg("Loading CombatWallpaper " & txtCombatPic.Text & "...")
		ShowCombatPic((txtCombatPic.Text))
	End Sub
	
	Public Sub ShowTileSet(ByRef InTree As AxComctlLib.AxTreeView, ByRef InTileSet As TileSet)
		Dim OldDirt As Short
		OldDirt = frmMDI.Dirty
		TreeViewX = InTree
		TileSetX = InTileSet
		Me.Text = "TileSet [" & TileSetX.Name & "]"
		txtName.Text = TileSetX.Name
		txtCombatPic.Text = TileSetX.PictureFile
		ShowCombatPic((txtCombatPic.Text))
		SetDirty(False)
		frmMDI.Dirty = OldDirt
	End Sub
	
	Private Sub SetDirty(ByRef Flag As Short)
		btnApply.Enabled = Flag
		Dirty = Flag
		If Dirty = True Then
			frmMDI.Dirty = True
		End If
	End Sub
	
	Private Sub UpdateTileSet()
		TileSetX.Name = txtName.Text
		TileSetX.PictureFile = txtCombatPic.Text
		' Update ProjectList
		TreeViewX.Nodes(Me.Tag).Text = TileSetX.Name
		SetDirty(False)
	End Sub
	
	Private Sub btnApply_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnApply.Click
		UpdateTileSet()
	End Sub
	
	Private Sub btnBrowse_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnBrowse.Click
		SetCombatPic()
	End Sub
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		Me.Close()
	End Sub
	
	Private Sub btnOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOk.Click
		UpdateTileSet()
		Me.Close()
	End Sub
	
	Private Sub frmTileSetProp_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Dim CtrlKey As Object
		If TypeOf Me.ActiveControl Is System.Windows.Forms.TextBox Then
			CtrlKey(Me.ActiveControl, KeyCode, Shift)
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtCombatPic.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtCombatPic_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCombatPic.TextChanged
		SetDirty(True)
	End Sub
	
	'UPGRADE_WARNING: Event txtName.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtName_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtName.TextChanged
		SetDirty(True)
	End Sub
End Class