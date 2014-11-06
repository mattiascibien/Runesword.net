Option Strict Off
Option Explicit On
Module modDT
	
	Public Const bdDlgNoReply As Short = 0
	Public Const bdDlgWithReply As Short = 1
	Public Const bdDlgItemList As Short = 2
	Public Const bdDlgWithDice As Short = 3
	Public Const bdDlgReplyText As Short = 4
	Public Const bdDlgItem As Short = 6
	Public Const bdDlgSave As Short = 7
	Public Const bdDlgCreatureList As Short = 8
	Public Const bdDlgDebug As Short = 9
	Public Const bdDlgCredits As Short = 10
	Public Const bdSellStyleInv As Short = 0
	Public Const bdSellStyleEnc As Short = 1
	
	' Grid data type is only used in the combat grid.
	Structure Grid
		Dim Ref As Creature
		Dim Target As Creature
	End Structure
	
	
	Public Sub PlayClickSnd(ByRef ClickType As ClickType)
		Dim ifClickCast As Object
		Dim ifClickPass As Object
		Dim ifClickLow As Object
		Dim ifClickDrop As Object
		Dim ifClick As Object
		Dim PlaySoundFile As Object
		Dim ifClickMenu As Object
		If GlobalMouseClick = 1 And ClickType < ifClickLow Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ifClickLow. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ifClickDrop. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ifClick. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ifClickMenu. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Select Case ClickType
				Case ifClickMenu
					Call PlaySoundFile(gAppPath & "\data\interface\" & GlobalInterfaceName & "\click2.wav", Tome, True)
				Case ifClick
					Call PlaySoundFile(gAppPath & "\data\interface\" & GlobalInterfaceName & "\click1.wav", Tome, True)
				Case ifClickDrop
					Call PlaySoundFile(gAppPath & "\data\interface\" & GlobalInterfaceName & "\click4.wav", Tome, True)
				Case ifClickLow
					Call PlaySoundFile(gAppPath & "\data\interface\" & GlobalInterfaceName & "\click3.wav", Tome, True)
			End Select
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object ifClickCast. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ifClickPass. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Select Case ClickType
				Case ifClickPass
					Call PlaySoundFile(gAppPath & "\data\stock\pass.wav", Tome, True)
				Case ifClickCast
					Call PlaySoundFile(gAppPath & "\data\stock\cast.wav", Tome, True, 5, &H10)
			End Select
		End If
		
	End Sub
	
	Public Function OpName(ByVal Index As Short) As String
		Select Case Index
			Case 0 ' =
				OpName = "EqualTo"
			Case 1 ' +
				OpName = "Plus"
			Case 2 ' -
				OpName = "Minus"
			Case 3 ' *
				OpName = "X"
			Case 4 ' /
				OpName = "DividedBy"
			Case 5 ' >
				OpName = "GreaterThan"
			Case 6 ' <
				OpName = "LessThan"
			Case 7 ' >=
				OpName = "GreaterOrEqual"
			Case 8 ' <=
				OpName = "LessOrEqual"
			Case 9 ' Or
				OpName = "Or"
			Case 10 ' And
				OpName = "And"
			Case 11 ' Xor
				OpName = "XOr"
			Case 12 ' Like
				OpName = "Like"
		End Select
		
	End Function
End Module