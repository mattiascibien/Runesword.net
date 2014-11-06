Option Strict Off
Option Explicit On
Friend Class frmProject
	Inherits System.Windows.Forms.Form
	
	'UPGRADE_NOTE: MouseClick was upgraded to MouseClick_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Dim MouseClick_Renamed, Drag As Short
	Dim ClickX, ClickY As Short
	' Dim Sizing As Integer
	
	Dim PicFile(31) As String
	Dim PicFileTime(31) As Double
	Dim PicMapFile(7) As String
	Dim PicMapTime(7) As Double
	Dim PicMapScale(7) As Double
	
	Const bdMaxItemPics As Short = 48
	Dim ItemPicFile(bdMaxItemPics) As String
	Dim ItemPicTime(bdMaxItemPics) As Double
	Dim ItemPicWidth(bdMaxItemPics) As Byte
	Dim ItemPicHeight(bdMaxItemPics) As Byte
	
	Public AreaList As New Collection
	Public TomeList As New Collection
	Public ActiveEnc As New Encounter ' [Titi 2.4.9]
	' [Titi 2.5.1] addition of drag & drop
	Dim DragNode As New ComctlLib.Node
	Dim DragTo As New ComctlLib.Node
	Dim oldNode As New ComctlLib.Node
	Dim tvwDest, tvwDragTo, tvwSource As AxComctlLib.AxTreeView
	Public blnOtherTree As Boolean
	Dim ShiftDown, AltDown As Object
	Dim CtrlDown As Short
	Private Declare Function SendMessage Lib "user32"  Alias "SendMessageA"(ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As Integer) As Integer
	Private Const WM_VSCROLL As Integer = &H115
	Private Const SB_LINEUP As Short = 0
	Private Const SB_LINEDOWN As Short = 1
	' [Titi 2.5.1] end drag & drop addition
	Const PicSize As Short = 1
	
	Public Function GetItemPicHeight(ByRef Index As Short) As Byte
		GetItemPicHeight = ItemPicHeight(Index)
	End Function
	
	Public Function GetItemPicWidth(ByRef Index As Short) As Byte
		GetItemPicWidth = ItemPicWidth(Index)
	End Function
	
	Private Sub InitGame()
		' Set up default Item picture size (bdMaxItemPics Pictures)
		picItem.Width = 32 * bdMaxItemPics
		picItem.Height = 64
	End Sub
	
	Public Sub LoadDarkTile(ByRef MapScale As Double)
		' Load and sets Tiles for Map
		'UPGRADE_NOTE: Width was upgraded to Width_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		'UPGRADE_NOTE: Height was upgraded to Height_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Height_Renamed, Width_Renamed As Short
		'UPGRADE_WARNING: Arrays in structure bmTiles may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmTiles As BITMAPINFO
		Dim hMemTiles, TransparentRGB As Integer
		Dim lpMem, rc As Integer
		' Load TileSet bitmap
		'    ReadBitmapFile gAppPath & "\data\stock\darktile.bmp", bmTiles, hMemTiles, TransparentRGB
		ReadBitmapFile(gDataPath & "\stock\darktile.bmp", bmTiles, hMemTiles, TransparentRGB)
		' Make a copy of the current palette for the picture
		frmMDI.ShowMsg("Loading Map....")
		' Paint bitmap to picture box using converted palette
		lpMem = GlobalLock(hMemTiles)
		Width_Renamed = bmTiles.bmiHeader.biWidth
		Height_Renamed = bmTiles.bmiHeader.biHeight
		picBlack.Width = Width_Renamed * MapScale
		picBlack.Height = Height_Renamed * MapScale
		' Set it up for painting
		'UPGRADE_ISSUE: PictureBox property picBlack.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = SetStretchBltMode(picBlack.hdc, 3)
		frmMDI.ShowMsg("Loading Map.....")
		' Writes out normal tiles (black border) to upper left.
		'UPGRADE_ISSUE: PictureBox property picBlack.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchDIBits(picBlack.hdc, 0, 0, Width_Renamed * MapScale, Height_Renamed * MapScale, 0, 0, Width_Renamed, Height_Renamed, lpMem, bmTiles, DIB_RGB_COLORS, SRCCOPY)
		' Release memory
		picBlack.Refresh()
		rc = GlobalUnlock(hMemTiles)
		rc = GlobalFree(hMemTiles)
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub LoadMapPic(ByRef MapX As Map, ByRef MapScale As Double)
		Dim Tome_Renamed As Object
		On Error GoTo ErrorHandler
		' Load and sets Tiles for Map
		Dim k, c, i As Short
		Dim FileName As String
		'UPGRADE_NOTE: Height was upgraded to Height_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		'UPGRADE_NOTE: Width was upgraded to Width_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Width_Renamed, Height_Renamed, PicToLoad As Short
		'UPGRADE_WARNING: Arrays in structure bmTiles may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmTiles As BITMAPINFO
		Dim hMemTiles As Integer
		'UPGRADE_WARNING: Arrays in structure bmBlack may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmBlack As BITMAPINFO
		'UPGRADE_WARNING: Arrays in structure bmMask may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmMask As BITMAPINFO
		'UPGRADE_WARNING: Arrays in structure bmGray may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmGray As BITMAPINFO
		Dim rc, lpMem, TransparentRGB As Integer
		Dim X, Y As Short
		' If PictureFile already loaded, then return that reference
		LoadDarkTile(MapScale)
		For c = 0 To 7
			If PicMapFile(c) = MapX.PictureFile And PicMapScale(c) = MapScale Then
				MapX.Pic = c
				PicMapTime(c) = TimeOfDay.ToOADate()
				Exit Sub
			End If
		Next c
		' Sort to find oldest picture box free
		k = 1 : i = 0
		For c = 0 To 7
			If PicMapTime(c) < k Then
				i = c
				k = PicMapTime(c)
			End If
		Next c
		PicToLoad = i
		MapX.Pic = PicToLoad
		If PicMapTime(PicToLoad) = 0 Then
			If PicToLoad > 0 Then
				picMap.Load(PicToLoad)
			End If
		End If
		PicMapFile(PicToLoad) = MapX.PictureFile
		PicMapTime(PicToLoad) = TimeOfDay.ToOADate()
		PicMapScale(PicToLoad) = MapScale
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor ' Hourglass
		frmMDI.ShowMsg("Loading Map..")
		' Load TileSet bitmap
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FullPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileName = Dir(Tome.FullPath & "\" & MapX.PictureFile)
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FullPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If FileName = "" Or Tome.FullPath = "" Then
			'        FileName = gAppPath & "\data\graphics\tiles\" & MapX.PictureFile
			FileName = gDataPath & "\graphics\tiles\" & MapX.PictureFile
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FullPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FileName = Tome.FullPath & "\" & MapX.PictureFile
		End If
		ReadBitmapFile(FileName, bmTiles, hMemTiles, TransparentRGB)
		' Make a copy of the current palette for the picture
		frmMDI.ShowMsg("Loading Map....")
		' Paint bitmap to picture box using converted palette
		lpMem = GlobalLock(hMemTiles)
		Width_Renamed = bmTiles.bmiHeader.biWidth
		Height_Renamed = bmTiles.bmiHeader.biHeight
		picMap(PicToLoad).Width = Width_Renamed * 2 * MapScale
		picMap(PicToLoad).Height = Height_Renamed * 3 * MapScale
		picOutline.Width = Width_Renamed * 2 * MapScale
		picOutline.Height = Height_Renamed * 2 * MapScale
		' Then change Pure X color to Pure Black (X is upper left RGB)
		'UPGRADE_WARNING: Couldn't resolve default property of object bmBlack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		bmBlack = bmTiles
		ChangeColor(bmBlack, TransparentRGB, 0, 0, 0)
		' Set it up for painting
		'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = SetStretchBltMode(picMap(PicToLoad).hdc, 3)
		'UPGRADE_ISSUE: PictureBox property picOutline.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = SetStretchBltMode(picOutline.hdc, 3)
		frmMDI.ShowMsg("Loading Map.....")
		' Writes out normal tiles (black border) to upper left.
		'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchDIBits(picMap(PicToLoad).hdc, 0, 0, Width_Renamed * MapScale, Height_Renamed * MapScale, 0, 0, Width_Renamed, Height_Renamed, lpMem, bmBlack, DIB_RGB_COLORS, SRCCOPY)
		'UPGRADE_ISSUE: PictureBox property picOutline.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchDIBits(picOutline.hdc, 0, 0, Width_Renamed * MapScale, Height_Renamed * MapScale, 0, 0, Width_Renamed, Height_Renamed, lpMem, bmBlack, DIB_RGB_COLORS, SRCCOPY)
		' Repaint with a transparent color
		frmMDI.ShowMsg("Loading Map......")
		' Writes out flip version to upper right
		'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchBlt(picMap(PicToLoad).hdc, Width_Renamed * MapScale, 0, Width_Renamed * MapScale, Height_Renamed * MapScale, picMap(PicToLoad).hdc, Width_Renamed * MapScale - 1, 0, -Width_Renamed * MapScale, Height_Renamed * MapScale, SRCCOPY)
		'UPGRADE_ISSUE: PictureBox property picOutline.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchBlt(picOutline.hdc, Width_Renamed * MapScale, 0, Width_Renamed * MapScale, Height_Renamed * MapScale, picOutline.hdc, Width_Renamed * MapScale - 1, 0, -Width_Renamed * MapScale, Height_Renamed * MapScale, SRCCOPY)
		' Convert to Mask and copy to picMap (pure Blue is the mask color)
		MakeMask(bmTiles, bmMask, TransparentRGB)
		frmMDI.ShowMsg("Loading Map.......")
		' Writes out mask version to mid-left
		'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchDIBits(picMap(PicToLoad).hdc, 0, Height_Renamed * MapScale, Width_Renamed * MapScale, Height_Renamed * MapScale, 0, 0, Width_Renamed, Height_Renamed, lpMem, bmMask, DIB_RGB_COLORS, SRCCOPY)
		'UPGRADE_ISSUE: PictureBox property picOutline.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchDIBits(picOutline.hdc, 0, Height_Renamed * MapScale, Width_Renamed * MapScale, Height_Renamed * MapScale, 0, 0, Width_Renamed, Height_Renamed, lpMem, bmMask, DIB_RGB_COLORS, SRCCOPY)
		frmMDI.ShowMsg("Loading Map........")
		' Writes out flip mask to mid-right
		'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchBlt(picMap(PicToLoad).hdc, Width_Renamed * MapScale, Height_Renamed * MapScale, Width_Renamed * MapScale, Height_Renamed * MapScale, picMap(PicToLoad).hdc, Width_Renamed * MapScale - 1, Height_Renamed * MapScale, -Width_Renamed * MapScale, Height_Renamed * MapScale, SRCCOPY)
		'UPGRADE_ISSUE: PictureBox property picOutline.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchBlt(picOutline.hdc, Width_Renamed * MapScale, Height_Renamed * MapScale, Width_Renamed * MapScale, Height_Renamed * MapScale, picOutline.hdc, Width_Renamed * MapScale - 1, Height_Renamed * MapScale, -Width_Renamed * MapScale, Height_Renamed * MapScale, SRCCOPY)
		' [Titi 2.4.8] added another set of tiles, for green outline
		' Writes out another version below for outlining
		'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchDIBits(picMap(PicToLoad).hdc, 0, 2 * Height_Renamed * MapScale, Width_Renamed * MapScale, Height_Renamed * MapScale, 0, 0, Width_Renamed, Height_Renamed, lpMem, bmBlack, DIB_RGB_COLORS, SRCCOPY)
		'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchBlt(picMap(PicToLoad).hdc, Width_Renamed * MapScale, 2 * Height_Renamed * MapScale, Width_Renamed * MapScale, Height_Renamed * MapScale, picMap(PicToLoad).hdc, Width_Renamed * MapScale - 1, 2 * Height_Renamed * MapScale, -Width_Renamed * MapScale, Height_Renamed * MapScale, SRCCOPY)
		For Y = Height_Renamed To Height_Renamed * 2 - 1 : For X = 0 To Width_Renamed - 1
				'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				rc = GetPixel(picMap(PicToLoad).hdc, X, Y)
				If rc = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black) Then
					For c = 0 To 3
						Select Case c
							Case 0
								If X < Width_Renamed - 1 Then
									'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
									rc = GetPixel(picMap(PicToLoad).hdc, X + 1, Y)
								End If
							Case 1
								If Y > 0 Then
									'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
									rc = GetPixel(picMap(PicToLoad).hdc, X, Y - 1)
								End If
							Case 2
								If Y < Height_Renamed * 2 - 1 Then
									'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
									rc = GetPixel(picMap(PicToLoad).hdc, X, Y + 1)
								End If
							Case 3
								If X > 0 Then
									'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
									rc = GetPixel(picMap(PicToLoad).hdc, X - 1, Y)
								End If
						End Select
						If rc > System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black) Then
							' Green Outline
							'UPGRADE_ISSUE: PictureBox property picOutline.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
							rc = SetPixel(picOutline.hdc, X, Y - Height_Renamed, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Lime))
							'UPGRADE_ISSUE: PictureBox property picOutline.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
							rc = SetPixel(picOutline.hdc, System.Math.Abs(X - Width_Renamed) + Width_Renamed, Y - Height_Renamed, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Lime))
							'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
							rc = SetPixel(picMap(PicToLoad).hdc, X, Y + Height_Renamed, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Lime))
							'UPGRADE_ISSUE: PictureBox property picMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
							rc = SetPixel(picMap(PicToLoad).hdc, System.Math.Abs(X - Width_Renamed) + Width_Renamed, Y + Height_Renamed, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Lime))
							Exit For
						End If
					Next c
				End If
			Next X : Next Y
		' Release memory
		'    picMap(PicToLoad).Refresh
		frmMDI.ShowMsg("Loading Map..........")
		rc = GlobalUnlock(hMemTiles)
		rc = GlobalFree(hMemTiles)
		frmMDI.ShowMsg("")
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default ' Default
		'UPGRADE_ISSUE: PictureBox property picOutline.AutoRedraw was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picOutline.AutoRedraw = True ' was set to false in case of RT 480
		picMap(PicToLoad).Refresh()
		Exit Sub
		' [Titi 2.6.0] RT 480 when the tileset is too big
ErrorHandler: 
		If Err.Number = 480 Then
			'UPGRADE_ISSUE: PictureBox property picOutline.AutoRedraw was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picOutline.AutoRedraw = False
			Resume 
		Else
			oErr.logError(Err.Description & " in LoadMapPic while working with " & MapX.Name & " (" & MapX.PictureFile & ")")
		End If
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub LoadItemPic(ByRef ItemX As Item)
		Dim Tome_Renamed As Object
		Dim FileName As String
		Dim i, c, PicToLoad As Short
		Dim X, Y As Short
		Dim k As Double
		'UPGRADE_WARNING: Arrays in structure bmBlack may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmBlack As BITMAPINFO
		'UPGRADE_WARNING: Arrays in structure bmMask may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmMask As BITMAPINFO
		Dim rc, lpMem, hMem, TransparentRGB As Integer
		'UPGRADE_NOTE: Height was upgraded to Height_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		'UPGRADE_NOTE: Width was upgraded to Width_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Width_Renamed, Height_Renamed As Short
		' If PictureFile already loaded, then return that reference
		For c = 1 To bdMaxItemPics
			If ItemPicFile(c) = ItemX.PictureFile Then
				ItemX.Pic = c
				ItemPicTime(c) = TimeOfDay.ToOADate()
				Exit Sub
			End If
		Next c
		' Sort to find oldest picture box free
		k = 1 : i = 0
		For c = 1 To bdMaxItemPics
			If ItemPicTime(c) < k Then
				i = c
				k = ItemPicTime(c)
			End If
		Next c
		PicToLoad = i
		ItemPicFile(PicToLoad) = ItemX.PictureFile
		ItemPicTime(PicToLoad) = TimeOfDay.ToOADate()
		' Load Bitmap
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FullPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileName = Dir(Tome.FullPath & "\" & ItemX.PictureFile)
		If FileName = "" Then
			'        FileName = gAppPath & "\Data\Graphics\Items\" & ItemX.PictureFile
			FileName = gDataPath & "\Graphics\Items\" & ItemX.PictureFile
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FullPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FileName = Tome.FullPath & "\" & ItemX.PictureFile
		End If
		ReadBitmapFile(FileName, bmBlack, hMem, TransparentRGB)
		' Convert to Mask (pure Blue is the mask color)
		MakeMask(bmBlack, bmMask, TransparentRGB)
		' Paint bitmap to picture box using converted palette
		lpMem = GlobalLock(hMem)
		Width_Renamed = Int(bmBlack.bmiHeader.biWidth)
		Height_Renamed = Int(bmBlack.bmiHeader.biHeight)
		' Store Height/Width of Item Picture
		Select Case Height_Renamed
			Case 0 To 32 : ItemPicHeight(PicToLoad) = 32
			Case 33 To 64 : ItemPicHeight(PicToLoad) = 64
			Case Else : ItemPicHeight(PicToLoad) = 96
		End Select
		Select Case Width_Renamed
			Case 0 To 32 : ItemPicWidth(PicToLoad) = 32
			Case Else : ItemPicWidth(PicToLoad) = 64
		End Select
		' Center the Item Picture
		X = 32 * PicToLoad - 32 + (ItemPicWidth(PicToLoad) - Width_Renamed) / 2
		Y = (ItemPicHeight(PicToLoad) - Height_Renamed) / 2
		' Paint micro size for map object
		'UPGRADE_ISSUE: PictureBox property picItem.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = SetStretchBltMode(picItem.hdc, 3)
		'UPGRADE_ISSUE: PictureBox property picItem.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchDIBits(picItem.hdc, X, Y, ItemPicWidth(PicToLoad) / 3, ItemPicHeight(PicToLoad) / 3, 0, 0, bmBlack.bmiHeader.biWidth, bmBlack.bmiHeader.biHeight, lpMem, bmBlack, DIB_RGB_COLORS, SRCCOPY)
		'UPGRADE_ISSUE: PictureBox property picItem.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchDIBits(picItem.hdc, X, Y + 32, ItemPicWidth(PicToLoad) / 3, ItemPicHeight(PicToLoad) / 3, 0, 0, bmMask.bmiHeader.biWidth, bmMask.bmiHeader.biHeight, lpMem, bmMask, DIB_RGB_COLORS, SRCCOPY)
		picItem.Refresh()
		' Release memory
		rc = GlobalUnlock(hMem)
		rc = GlobalFree(hMem)
		' Return pointer to PictureBox
		ItemX.Pic = PicToLoad
	End Sub
	
	'UPGRADE_NOTE: Tome was upgraded to Tome_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub LoadCreaturePic(ByRef CreatureX As Creature)
		Dim Tome_Renamed As Object
		Dim c, i As Short
		Dim k As Double
		Dim FileName As String
		Dim PicToLoad As Short
		Dim X, Y As Short
		'UPGRADE_WARNING: Arrays in structure bmBlack may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmBlack As BITMAPINFO
		'UPGRADE_WARNING: Arrays in structure bmMask may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim bmMask As BITMAPINFO
		Dim rc, lpMem, hMem, TransparentRGB As Integer
		'UPGRADE_NOTE: Height was upgraded to Height_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		'UPGRADE_NOTE: Width was upgraded to Width_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Width_Renamed, Height_Renamed As Short
		Dim PartyWidth, PartyHeight As Short
		' If PictureFile is bones, then skip all this
		If CreatureX.PictureFile = "bones.bmp" Or CreatureX.PictureFile = "" Then
			PicToLoad = 0
		Else
			' If PictureFile already loaded, then return that reference
			For c = 0 To 31
				If PicFile(c) = CreatureX.PictureFile Then
					CreatureX.Pic = c
					PicFileTime(c) = TimeOfDay.ToOADate()
					Exit Sub
				End If
			Next c
			' Sort to find oldest picture box free
			k = 1 : i = 0
			For c = 0 To 31
				If PicFileTime(c) < k Then
					i = c
					k = PicFileTime(c)
				End If
			Next c
			PicToLoad = i
			If PicFileTime(PicToLoad) = 0 Then
				If PicToLoad > 0 Then
					picCMap.Load(PicToLoad)
				End If
			End If
		End If
		PicFile(PicToLoad) = CreatureX.PictureFile
		PicFileTime(PicToLoad) = TimeOfDay.ToOADate()
		' Load Bitmap
		'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FullPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileName = Dir(Tome.FullPath & "\" & CreatureX.PictureFile)
		If FileName = "" Then
			'        FileName = gAppPath & "\Data\Graphics\Creatures\" & CreatureX.PictureFile
			FileName = gDataPath & "\Graphics\Creatures\" & CreatureX.PictureFile
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object Tome.FullPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FileName = Tome.FullPath & "\" & CreatureX.PictureFile
		End If
		ReadBitmapFile(FileName, bmBlack, hMem, TransparentRGB)
		' Convert to Mask (pure Blue is the mask color)
		MakeMask(bmBlack, bmMask, TransparentRGB)
		' Paint bitmap to picture box using converted palette
		lpMem = GlobalLock(hMem)
		Width_Renamed = Int(bmBlack.bmiHeader.biWidth * PicSize)
		Height_Renamed = Int(bmBlack.bmiHeader.biHeight * PicSize)
		'UPGRADE_ISSUE: PictureBox property picCMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = SetStretchBltMode(picCMap(PicToLoad).hdc, 3)
		' Paint party size picture box
		PartyWidth = CShort(bmBlack.bmiHeader.biWidth * 0.35)
		PartyHeight = CShort(bmBlack.bmiHeader.biHeight * 0.35)
		picCMap(PicToLoad).Width = PartyWidth
		picCMap(PicToLoad).Height = PartyHeight * 2
		'UPGRADE_ISSUE: PictureBox property picCMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = SetStretchBltMode(picCMap(PicToLoad).hdc, 3)
		'UPGRADE_ISSUE: PictureBox property picCMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchDIBits(picCMap(PicToLoad).hdc, 0, 0, PartyWidth, PartyHeight, 0, 0, bmBlack.bmiHeader.biWidth, bmBlack.bmiHeader.biHeight, lpMem, bmBlack, DIB_RGB_COLORS, SRCCOPY)
		'UPGRADE_ISSUE: PictureBox property picCMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		rc = StretchDIBits(picCMap(PicToLoad).hdc, 0, PartyHeight, PartyWidth, PartyHeight, 0, 0, bmMask.bmiHeader.biWidth, bmMask.bmiHeader.biHeight, lpMem, bmMask, DIB_RGB_COLORS, SRCCOPY)
		' Draw line around party mask picture
		For Y = 0 To PartyHeight - 1 : For X = 0 To PartyWidth - 1
				'UPGRADE_ISSUE: PictureBox property picCMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				rc = GetPixel(picCMap(PicToLoad).hdc, X, Y)
				If rc = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black) Then
					For c = 0 To 3
						Select Case c
							Case 0
								If X < PartyWidth - 1 Then
									'UPGRADE_ISSUE: PictureBox property picCMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
									rc = GetPixel(picCMap(PicToLoad).hdc, X + 1, Y)
								End If
							Case 1
								If Y > 0 Then
									'UPGRADE_ISSUE: PictureBox property picCMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
									rc = GetPixel(picCMap(PicToLoad).hdc, X, Y - 1)
								End If
							Case 2
								If Y < PartyHeight - 1 Then
									'UPGRADE_ISSUE: PictureBox property picCMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
									rc = GetPixel(picCMap(PicToLoad).hdc, X, Y + 1)
								End If
							Case 3
								If X > 0 Then
									'UPGRADE_ISSUE: PictureBox property picCMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
									rc = GetPixel(picCMap(PicToLoad).hdc, X - 1, Y)
								End If
						End Select
						If rc > System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black) Then
							'UPGRADE_ISSUE: PictureBox property picCMap.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
							rc = SetPixel(picCMap(PicToLoad).hdc, X, Y + PartyHeight, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black))
							Exit For
						End If
					Next c
				End If
			Next X : Next Y
		picCMap(PicToLoad).Refresh()
		' Release memory
		rc = GlobalUnlock(hMem)
		rc = GlobalFree(hMem)
		' Return pointer to PictureBox
		CreatureX.Pic = PicToLoad
	End Sub
	
	Public Sub ResizeForm()
		lblProjectTome.Top = 0
		lblProjectTome.Left = 0
		lblProjectTome.Width = Greatest(Me.ClientRectangle.Width, 0)
		tvwTome.Top = lblProjectTome.Height + 3
		tvwTome.Left = 0
		tvwTome.Height = Greatest(Me.ClientRectangle.Height * 0.3 - lblProjectTome.Height, 0)
		tvwTome.Width = lblProjectTome.Width
		lblProjectArea.Top = lblProjectTome.Height + tvwTome.Height + 5
		lblProjectArea.Left = 0
		lblProjectArea.Width = tvwTome.Width
		tvwProject.Width = tvwTome.Width
		tvwProject.Height = Greatest(Me.ClientRectangle.Height - (lblProjectArea.Top + lblProjectArea.Height) - 5, 0)
		tvwProject.Top = lblProjectTome.Height + tvwTome.Height + lblProjectArea.Height + 8
		tvwProject.Left = 0
	End Sub
	
	Private Sub frmProject_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		On Error GoTo ErrorHandler
		'UPGRADE_WARNING: Couldn't resolve default property of object ShiftDown. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ShiftDown = (Shift And VB6.ShiftConstants.ShiftMask) > 0
		'UPGRADE_WARNING: Couldn't resolve default property of object AltDown. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		AltDown = (Shift And VB6.ShiftConstants.AltMask) > 0
		CtrlDown = (Shift And VB6.ShiftConstants.CtrlMask) > 0
		If Drag Then
			If Shift Then
				'UPGRADE_ISSUE: VBControlExtender property tvwSource.DragIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				tvwSource.DragIcon = System.Drawing.Image.FromFile(gDataPath & "\Stock\DRAGCOPY.CUR") 'DragNode.Parent.CreateDragImage
			Else
				'UPGRADE_ISSUE: VBControlExtender property tvwSource.DragIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				tvwSource.DragIcon = System.Drawing.Image.FromFile(gDataPath & "\Stock\DRAGMOVE.CUR") 'DragNode.CreateDragImage
			End If
		End If
		' Undo CTRL-Z
		'   If KeyCode = vbKeyZ And CtrlDown And btnUndo.Enabled = True Then
		'        ApplyUndo
		'   End If
		' Redo CTRL-Y
		'   If KeyCode = vbKeyY And CtrlDown And btnRedo.Enabled = True Then
		'        ApplyRedo
		'   End If
ErrorHandler: 
	End Sub
	
	Private Sub frmProject_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		On Error GoTo ErrorHandler
		'UPGRADE_WARNING: Couldn't resolve default property of object ShiftDown. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ShiftDown = (Shift And VB6.ShiftConstants.ShiftMask) > 0
		'UPGRADE_WARNING: Couldn't resolve default property of object AltDown. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		AltDown = (Shift And VB6.ShiftConstants.AltMask) > 0
		CtrlDown = (Shift And VB6.ShiftConstants.CtrlMask) > 0
		If Drag Then
			If Shift Then
				'UPGRADE_ISSUE: VBControlExtender property tvwSource.DragIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				tvwSource.DragIcon = System.Drawing.Image.FromFile(gDataPath & "\Stock\DRAGCOPY.CUR") 'DragNode.Parent.CreateDragImage
			Else
				'UPGRADE_ISSUE: VBControlExtender property tvwSource.DragIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				tvwSource.DragIcon = System.Drawing.Image.FromFile(gDataPath & "\Stock\DRAGMOVE.CUR") 'DragNode.CreateDragImage
			End If
		End If
ErrorHandler: 
	End Sub
	
	Private Sub frmProject_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		InitGame()
	End Sub
	
	'UPGRADE_WARNING: Event frmProject.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmProject_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		ResizeForm()
	End Sub
	
	Private Sub tmrExpandNode_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmrExpandNode.Tick
		On Error GoTo ErrorHandler
		If Drag = True Then
			If Not DragTo Is Nothing Then
				' ok, we're really using Drag & Drop
				If DragTo._ObjectDefault <> oldNode._ObjectDefault Then
					' hovering long enough above a node will expand it
					oldNode = DragTo
				Else
					DragTo.Expanded = True
				End If
			End If
		End If
ErrorHandler: 
	End Sub
	
	Private Sub tmrScroll_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmrScroll.Tick
		On Error GoTo ErrorHandler
		' check if we need to scroll up or down
		If Drag = True Then ' And blnOtherTree = False Then
			If ClickY > VB6.PixelsToTwipsY(tvwDest.Height) - 50 Then
				SendMessage(tvwDest.hWnd, WM_VSCROLL, SB_LINEDOWN, VariantType.Null) 'Scroll down
			ElseIf System.Math.Abs(ClickY) < 50 Then 
				SendMessage(tvwDest.hWnd, WM_VSCROLL, SB_LINEUP, VariantType.Null) 'Scroll up
			End If
		End If
ErrorHandler: 
	End Sub
	
	Private Sub tvwProject_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tvwProject.ClickEvent
		frmMDI.SetupMenu(AreaList, tvwProject, tvwProject.SelectedItem.Tag)
		' [Titi 2.4.9b] borrowed HoldNode from the Search function to tell it where we're searching
		frmMDI.HoldNode = 0
		If MouseClick_Renamed = VB6.MouseButtonConstants.RightButton Then
			'UPGRADE_ISSUE: MDIForm method frmMDI.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			frmMDI.PopupMenu(frmMDI.mnuEdit)
		End If
	End Sub
	
	Private Sub tvwProject_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tvwProject.DblClick
		Drag = False
		frmMDI.EditProperties(tvwProject.SelectedItem.Tag)
	End Sub
	
	'UPGRADE_ISSUE: VBControlExtender event tvwProject.DragDrop was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub tvwProject_DragDrop(ByRef Source As System.Windows.Forms.Control, ByRef X As Single, ByRef Y As Single)
		' [Titi 2.5.0] added the Drag & Drop functionality
		On Error GoTo ErrorHandler
		If Drag = True Then
			If Not tvwDest.DropHighlight Is Nothing Then
				If tvwDest.DropHighlight._ObjectDefault = DragTo._ObjectDefault Then ' OK, we can drop the selected node here
					If blnOtherTree Then tvwTome_ClickEvent(tvwTome, New System.EventArgs()) ' if we dragged something from the other tome, we need to reset ObjectListX accordingly
					'UPGRADE_WARNING: Couldn't resolve default property of object ShiftDown. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If ShiftDown Then
						frmMDI.EditCopy((DragNode.Tag))
					Else
						frmMDI.EditCut((DragNode.Tag))
					End If
					If blnOtherTree Then tvwProject_ClickEvent(tvwProject, New System.EventArgs()) ' and now set ObjectListX back to what it was
					frmMDI.EditPaste((DragTo.Tag))
					'UPGRADE_NOTE: Object DragTo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
					DragTo = Nothing
					'UPGRADE_NOTE: Object DragNode may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
					DragNode = Nothing
					'UPGRADE_NOTE: Object tvwSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
					tvwSource = Nothing
				End If
			End If
		End If
		Exit Sub
ErrorHandler: 
		' invalid target node
		MsgBox("Invalid target!")
	End Sub
	
	'UPGRADE_ISSUE: VBControlExtender event tvwProject.DragOver was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub tvwProject_DragOver(ByRef Source As System.Windows.Forms.Control, ByRef X As Single, ByRef Y As Single, ByRef State As Short)
		' [Titi 2.5.0] added the Drag & Drop functionality
		If Drag = False Then Exit Sub
		ClickY = Y / VB6.TwipsPerPixelY
		'UPGRADE_ISSUE: Constant vbLeave was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		If State = vbLeave Or blnOtherTree Then ' we are on the other treeview
			DragTo = tvwDragTo.HitTest(X, Y)
			tvwDest = tvwDragTo
			'UPGRADE_ISSUE: Constant vbLeave was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
			If blnOtherTree And State = vbLeave Then ' in case we change our minds and decide to go back to the initial tree
				blnOtherTree = False
			Else
				blnOtherTree = True
			End If
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object Source.HitTest. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DragTo = Source.HitTest(X, Y)
			tvwDest = Source
		End If
		If Not tvwDest.HitTest(X, Y) Is Nothing Then
			' Confirm that we're not trying to do something silly, such as make a node a child of itself
			If Not DragNode._ObjectDefault = DragTo._ObjectDefault Then
				If ValidDrop((DragNode.Tag), (DragTo.Tag)) = True Then ' check we can drop the selected node there
					If blnOtherTree = True Then
						'UPGRADE_WARNING: Couldn't resolve default property of object Source.DropHighlight. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_NOTE: Object Source.DropHighlight may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
						Source.DropHighlight = Nothing
						tvwDragTo.DropHighlight = DragTo
					Else
						tvwDest.DropHighlight = DragTo
						'UPGRADE_NOTE: Object tvwDragTo.DropHighlight may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
						tvwDragTo.DropHighlight = Nothing
					End If
				End If
			End If
		End If
		Exit Sub
	End Sub
	
	Private Sub tvwProject_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxComctlLib.ITreeViewEvents_MouseDownEvent) Handles tvwProject.MouseDownEvent
		MouseClick_Renamed = eventArgs.Button
		Drag = False
		' [Titi 2.5.0] added the Drag & Drop functionality
		If MouseClick_Renamed = VB6.MouseButtonConstants.LeftButton Then
			tvwDragTo = tvwTome
			blnOtherTree = 0
			tvwProject.DropHighlight = tvwProject.HitTest(eventArgs.X, eventArgs.Y)
			If Not tvwProject.DropHighlight Is Nothing Then ' make sure we selected a 'valid' node!
				tvwProject.SelectedItem = tvwProject.HitTest(eventArgs.X, eventArgs.Y)
				DragNode = tvwProject.SelectedItem
				oldNode = DragNode
				Drag = True
			Else
				Drag = False
			End If
			'UPGRADE_NOTE: Object tvwProject.DropHighlight may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			tvwProject.DropHighlight = Nothing
		End If
	End Sub
	
	Private Sub tvwProject_MouseMoveEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxComctlLib.ITreeViewEvents_MouseMoveEvent) Handles tvwProject.MouseMoveEvent
		If eventArgs.Button = VB6.MouseButtonConstants.LeftButton Then
			tvwSource = tvwProject
			'        ShiftDown = Shift ' check if we only move (Shift key not pressed) or copy (Shift key pressed) the selected node.
			DragNode = tvwProject.SelectedItem
			'        If Shift Then
			'            tvwProject.DragIcon = DragNode.Parent.CreateDragImage
			'        Else
			'UPGRADE_ISSUE: VBControlExtender property tvwProject.DragIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			tvwProject.DragIcon = DragNode.CreateDragImage
			'        End If
			'UPGRADE_ISSUE: Constant vbBeginDrag was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
			'UPGRADE_ISSUE: VBControlExtender method tvwProject.Drag was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			tvwProject.Drag(vbBeginDrag)
		End If
	End Sub
	
	Private Sub tvwProject_NodeClick(ByVal eventSender As System.Object, ByVal eventArgs As AxComctlLib.ITreeViewEvents_NodeClickEvent) Handles tvwProject.NodeClick
		Dim Y, c, X, k As Short
		Dim EncounterX As Encounter
		If frmMDI.ParseTag((eventArgs.Node.Tag)) = bdEditEncounter Then
			' [Titi 2.4.9] save active encounter
			frmMDI.SetupMenu(AreaList, tvwProject, tvwProject.SelectedItem.Tag)
			ActiveEnc = frmMDI.ObjectListX.Item(eventArgs.Node.Tag)
			frmMDI.bNotFromEncList = True ' [Titi 2.4.9b] flag to avoid going to the first encounter in the list before going to the active one
			If frmMDI.ParseTag(eventArgs.Node.Parent.Parent.Tag) = bdEditMap Then
				' If MapX.Graphic is open, repaint it.
				For c = 0 To My.Application.OpenForms.Count - 1
					If My.Application.OpenForms.Item(c).Tag = eventArgs.Node.Parent.Parent.Tag & "Graphic" Then
						' If in Encounter Paint mode (3 is that level of painting)
						'UPGRADE_ISSUE: Control PaintLevel could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
						If My.Application.OpenForms.Item(c).PaintLevel = 3 Then
							frmMDI.SetupMenu(AreaList, tvwProject, tvwProject.SelectedItem.Tag)
							EncounterX = frmMDI.ObjectListX.Item(eventArgs.Node.Tag)
							' Set Map's Encounter ComboBox to that Encounter
							'UPGRADE_ISSUE: Control ListEncounters could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
							My.Application.OpenForms.Item(c).ListEncounters()
							'UPGRADE_ISSUE: Control cmbEncounters could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
							For k = 0 To My.Application.OpenForms.Item(c).cmbEncounters.ListCount
								'UPGRADE_ISSUE: Control cmbEncounters could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
								If My.Application.OpenForms.Item(c).cmbEncounters.List(k) = EncounterX.Name Then
									'UPGRADE_ISSUE: Control cmbEncounters could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
									My.Application.OpenForms.Item(c).cmbEncounters.ListIndex = k
								End If
							Next k
							' Find Encounter
							'UPGRADE_ISSUE: Control MapX could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
							For X = 0 To My.Application.OpenForms.Item(c).MapX.Width
								'UPGRADE_ISSUE: Control MapX could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
								For Y = 0 To My.Application.OpenForms.Item(c).MapX.Height
									'UPGRADE_ISSUE: Control MapX could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
									If My.Application.OpenForms.Item(c).MapX.EncPointer(X, Y) = EncounterX.Index Then
										'UPGRADE_ISSUE: Control CenterMap could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
										My.Application.OpenForms.Item(c).CenterMap(X, Y)
										'UPGRADE_ISSUE: Control DrawMap could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
										My.Application.OpenForms.Item(c).DrawMap()
										Exit Sub
									End If
								Next Y : Next X
						End If
					End If
				Next c
			End If
		End If
	End Sub
	
	Private Sub tvwTome_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tvwTome.ClickEvent
		Dim c As Short
		frmMDI.SetupMenu(TomeList, tvwTome, tvwTome.SelectedItem.Tag)
		' [Titi 2.4.9b] borrowed HoldNode from the Search function to tell it where we're searching
		' Also used to check if deleting a member of the party implies deleting the kingdom he belongs to (creation of worlds)
		frmMDI.HoldNode = -1
		With frmWorldSettings
			If .Visible And frmMDI.ParseTag(tvwTome.SelectedItem.Tag) = bdEditCreature Then
				For c = 0 To .TabStrip1.Tabs.Count - 3 ' don't forget, one tab for comments, one for magic and stats, and one for the map
					If strKingdomTemplate(c) = Me.tvwTome.SelectedItem.Text Then
						.TabStrip1.SelectedItem = .TabStrip1.Tabs(c)
					End If
				Next 
			End If
		End With
		If MouseClick_Renamed = VB6.MouseButtonConstants.RightButton Then
			'UPGRADE_ISSUE: MDIForm method frmMDI.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			frmMDI.PopupMenu(frmMDI.mnuEdit)
		End If
	End Sub
	
	Private Sub tvwTome_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tvwTome.DblClick
		Drag = False
		frmMDI.EditProperties(tvwTome.SelectedItem.Tag)
	End Sub
	
	'UPGRADE_ISSUE: VBControlExtender event tvwTome.DragDrop was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub tvwTome_DragDrop(ByRef Source As System.Windows.Forms.Control, ByRef X As Single, ByRef Y As Single)
		' [Titi 2.5.0] added the Drag & Drop functionality
		On Error GoTo ErrorHandler
		If Drag = True Then
			If Not tvwDest.DropHighlight Is Nothing Then
				If tvwDest.DropHighlight._ObjectDefault = DragTo._ObjectDefault And DragNode._ObjectDefault <> DragTo._ObjectDefault Then
					If blnOtherTree Then tvwProject_ClickEvent(tvwProject, New System.EventArgs()) ' if we dragged something from the other tome, we need to reset ObjectListX accordingly
					'UPGRADE_WARNING: Couldn't resolve default property of object ShiftDown. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If ShiftDown Then
						frmMDI.EditCopy((DragNode.Tag))
					Else
						frmMDI.EditCut((DragNode.Tag))
					End If
					If blnOtherTree Then
						tvwTome_ClickEvent(tvwTome, New System.EventArgs()) ' and now set ObjectListX back to what it was
						tvwTome.DropHighlight.Selected = True
					End If
					If DragTo.Tag Like "TomeAreasA*" Then
						' Reminder: maps are NOT areas, they only belong to areas! Therefore, we need to paste them one level lower
						frmMDI.mnuEditMovetoArea_Click(Nothing, New System.EventArgs())
					Else
						frmMDI.EditPaste((DragTo.Tag))
					End If
					'UPGRADE_NOTE: Object DragTo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
					DragTo = Nothing
					'UPGRADE_NOTE: Object DragNode may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
					DragNode = Nothing
					'UPGRADE_NOTE: Object tvwSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
					tvwSource = Nothing
				End If
			Else
				' invalid target node
				MsgBox("Invalid target!")
			End If
		End If
ErrorHandler: 
		Drag = False
		'UPGRADE_ISSUE: VBControlExtender method tvwTome.Drag was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		tvwTome.Drag(MsgBoxResult.Cancel)
		Err.Clear()
	End Sub
	
	'UPGRADE_ISSUE: VBControlExtender event tvwTome.DragOver was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub tvwTome_DragOver(ByRef Source As System.Windows.Forms.Control, ByRef X As Single, ByRef Y As Single, ByRef State As Short)
		' [Titi 2.5.0] added the Drag & Drop functionality
		If Drag = False Then Exit Sub
		ClickY = Y / VB6.TwipsPerPixelY
		'UPGRADE_ISSUE: Constant vbLeave was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		If State = vbLeave Or blnOtherTree = True Then ' we are on the other treeview
			DragTo = tvwDragTo.HitTest(X, Y)
			tvwDest = tvwDragTo
			'UPGRADE_ISSUE: Constant vbLeave was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
			If blnOtherTree And State = vbLeave Then ' in case we change our minds and decide to go back to the initial tree
				blnOtherTree = False
			Else
				blnOtherTree = True
			End If
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object Source.HitTest. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DragTo = Source.HitTest(X, Y)
			tvwDest = Source
		End If
		If Not tvwDest.HitTest(X, Y) Is Nothing Then
			' Confirm that we're not trying to do something silly, such as make a node a child of itself
			If Not DragNode._ObjectDefault = DragTo._ObjectDefault Then
				If ValidDrop((DragNode.Tag), (DragTo.Tag)) = True Then ' check we can drop the selected node there
					If blnOtherTree = True Then
						'UPGRADE_WARNING: Couldn't resolve default property of object Source.DropHighlight. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_NOTE: Object Source.DropHighlight may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
						Source.DropHighlight = Nothing
						tvwDragTo.DropHighlight = DragTo
					Else
						tvwDest.DropHighlight = DragTo
						'UPGRADE_NOTE: Object tvwDragTo.DropHighlight may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
						tvwDragTo.DropHighlight = Nothing
					End If
				End If
			End If
		End If
	End Sub
	
	Private Sub tvwTome_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxComctlLib.ITreeViewEvents_MouseDownEvent) Handles tvwTome.MouseDownEvent
		MouseClick_Renamed = eventArgs.Button
		Drag = False
		' [Titi 2.5.0] added the Drag & Drop functionality
		If MouseClick_Renamed = VB6.MouseButtonConstants.LeftButton Then
			tvwDragTo = tvwProject
			blnOtherTree = 0
			tvwTome.DropHighlight = tvwTome.HitTest(eventArgs.X, eventArgs.Y)
			If Not tvwTome.DropHighlight Is Nothing Then ' make sure we selected a 'valid' node!
				tvwTome.SelectedItem = tvwTome.HitTest(eventArgs.X, eventArgs.Y)
				DragNode = tvwTome.SelectedItem
				oldNode = DragNode
				Drag = True
			Else
				Drag = False
			End If
			'UPGRADE_NOTE: Object tvwTome.DropHighlight may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			tvwTome.DropHighlight = Nothing
		End If
	End Sub
	
	Private Sub tvwTome_MouseMoveEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxComctlLib.ITreeViewEvents_MouseMoveEvent) Handles tvwTome.MouseMoveEvent
		If eventArgs.Button = VB6.MouseButtonConstants.LeftButton Then
			tvwSource = tvwTome
			'        ShiftDown = Shift ' check if we only move (Shift key not pressed) or copy (Shift key pressed) the selected node.
			DragNode = tvwTome.SelectedItem
			'        If Shift Then
			'            tvwTome.DragIcon = DragNode.Parent.CreateDragImage
			'        Else
			'UPGRADE_ISSUE: VBControlExtender property tvwTome.DragIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			tvwTome.DragIcon = DragNode.CreateDragImage
			'        End If
			'UPGRADE_ISSUE: Constant vbBeginDrag was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
			'UPGRADE_ISSUE: VBControlExtender method tvwTome.Drag was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			tvwTome.Drag(vbBeginDrag)
		End If
	End Sub
	
	' [Titi 2.6.0] Made public for use with Monster Explorer
	'Private Function ValidDrop(SourceTag As String, DestTag As String) As Boolean
	Public Function ValidDrop(ByRef SourceTag As String, ByRef DestTag As String) As Boolean
		Dim intTag As Short
		intTag = frmMDI.ParseTag(SourceTag)
		Select Case frmMDI.ParseTag(DestTag)
			Case bdEditMap
				If intTag = bdEditArea Then
					ValidDrop = True
				Else
					ValidDrop = False
				End If
			Case bdEditMapCreatures
				If intTag = bdEditCreature Then
					ValidDrop = True
				Else
					ValidDrop = False
				End If
			Case bdEditEncounter
				Select Case intTag
					Case bdEditCreature, bdEditItem, bdEditTrigger
						ValidDrop = True
					Case Else
						ValidDrop = False
				End Select
			Case bdEditCreature
				Select Case intTag
					Case bdEditItem, bdEditTrigger, bdEditConvo
						ValidDrop = True
					Case Else
						ValidDrop = False
				End Select
			Case bdEditItem
				Select Case intTag
					Case bdEditItem, bdEditTrigger
						ValidDrop = True
					Case Else
						ValidDrop = False
				End Select
			Case bdEditTrigger
				Select Case intTag
					Case bdEditCreature, bdEditItem, bdEditTrigger
						ValidDrop = True
					Case Else
						ValidDrop = False
				End Select
			Case bdEditConvo
				If intTag = bdEditTopic Then
					ValidDrop = True
				Else
					ValidDrop = False
				End If
			Case bdEditTopic
				If intTag = bdEditTrigger Or intTag = bdEditFactoid Then
					ValidDrop = True
				Else
					ValidDrop = False
				End If
			Case bdEditMapThemes
				If intTag = bdEditMapThemes Or intTag = bdEditTheme Then
					ValidDrop = True
				Else
					ValidDrop = False
				End If
			Case bdEditMapEncounters
				If intTag = bdEditEncounter Or intTag = bdEditMapThemes Then
					ValidDrop = True
				Else
					ValidDrop = False
				End If
			Case bdEditTheme
				Select Case intTag
					Case bdEditCreature, bdEditItem, bdEditEncounter
						ValidDrop = True
					Case Else
						ValidDrop = False
				End Select
			Case bdEditTomeParty
				If intTag = bdEditCreature Then
					ValidDrop = True
				Else
					ValidDrop = False
				End If
			Case bdEditTomeTriggers
				If intTag = bdEditTrigger Then
					ValidDrop = True
				Else
					ValidDrop = False
				End If
			Case bdEditEntryPoint
				If intTag = bdEditEntryPoint Then
					ValidDrop = True
				Else
					ValidDrop = False
				End If
			Case bdEditMapEntryPoints
				If intTag = bdEditMapEntryPoints Then
					ValidDrop = True
				Else
					ValidDrop = False
				End If
			Case bdEditTomeAreas
				If intTag = bdEditArea Then
					ValidDrop = True
				Else
					ValidDrop = False
				End If
			Case bdEditArea
				If intTag = bdEditMap Then
					ValidDrop = True
				Else
					ValidDrop = False
				End If
			Case Else
				ValidDrop = False
		End Select
	End Function
End Class