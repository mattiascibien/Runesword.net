Option Strict Off
Option Explicit On
Friend Class clsInfos
	
	' Version number of Class
	Private myVersion As Short
	'How many monsters that character killed
	Private myKillsCount As Short
	'Largest damage done
	Private myRecordDamage As Short
	'Highest XP gained from a fight
	Private myRecordXP As Integer
	'Number of hits
	Private myHits As Integer
	'Number of misses
	Private myMisses As Integer
	'Number of battles fought
	Private myBattles As Short
	'Number of spells cast
	Private mySpellsCast As Short
	'Number of spells cast that fizzled
	Private mySpellsFailed As Short
	'Number of times died
	Private myDeaths As Short
	' Name of killer
	Private myKillerName As String
	' Date of death
	Private myDateDied As String
	'Number of Tomes Started/Won
	Private myTomes As Short
	'Total playing time for character
	Private myAge As Integer
	
	
	Property KillsCount() As Short
		Get
			KillsCount = myKillsCount
		End Get
		Set(ByVal Value As Short)
			myKillsCount = Value
		End Set
	End Property
	
	
	Property Damage() As Short
		Get
			Damage = myRecordDamage
		End Get
		Set(ByVal Value As Short)
			myRecordDamage = Value
		End Set
	End Property
	
	
	Property RecordXP() As Integer
		Get
			RecordXP = myRecordXP
		End Get
		Set(ByVal Value As Integer)
			myRecordXP = Value
		End Set
	End Property
	
	
	Property Hits() As Short
		Get
			Hits = myHits
		End Get
		Set(ByVal Value As Short)
			myHits = Value
		End Set
	End Property
	
	
	Property Misses() As Short
		Get
			Misses = myMisses
		End Get
		Set(ByVal Value As Short)
			myMisses = Value
		End Set
	End Property
	
	ReadOnly Property Accuracy() As Short
		Get
			If myHits + myMisses <> 0 Then
				Accuracy = Int(100 / (myHits + myMisses) * myHits)
			Else
				Accuracy = -1
			End If
		End Get
	End Property
	
	ReadOnly Property Aptitude() As Short
		Get
			If mySpellsCast <> 0 Then
				Aptitude = Int(100 / mySpellsCast * (mySpellsCast - mySpellsFailed))
			Else
				Aptitude = -1
			End If
		End Get
	End Property
	
	
	Property Battles() As Short
		Get
			Battles = myBattles
		End Get
		Set(ByVal Value As Short)
			myBattles = Value
		End Set
	End Property
	
	
	Property SpellsCast() As Short
		Get
			SpellsCast = mySpellsCast
		End Get
		Set(ByVal Value As Short)
			mySpellsCast = Value
		End Set
	End Property
	
	
	Property SpellsFailed() As Short
		Get
			SpellsFailed = mySpellsFailed
		End Get
		Set(ByVal Value As Short)
			mySpellsFailed = Value
		End Set
	End Property
	
	
	Property Deaths() As Short
		Get
			Deaths = myDeaths
		End Get
		Set(ByVal Value As Short)
			myDeaths = Value
		End Set
	End Property
	
	
	Property Tomes() As Short
		Get
			Tomes = myTomes
		End Get
		Set(ByVal Value As Short)
			myTomes = Value
		End Set
	End Property
	
	
	Property Age() As Integer
		Get
			Age = myAge
		End Get
		Set(ByVal Value As Integer)
			myAge = Value
		End Set
	End Property
	
	
	Property KilledBy() As String
		Get
			KilledBy = myKillerName
		End Get
		Set(ByVal Value As String)
			myKillerName = Value
		End Set
	End Property
	
	
	Property DiedOn() As String
		Get
			DiedOn = myDateDied
		End Get
		Set(ByVal Value As String)
			myDateDied = Value
		End Set
	End Property
	
	Public Sub SaveToFile(ByRef ToFile As Short)
		myVersion = 261 ' [Titi 2.6.0]
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, myVersion)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, myKillsCount)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, myRecordDamage)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, myRecordXP)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, myHits)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, myMisses)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, myBattles)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, mySpellsCast)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, mySpellsFailed)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, myDeaths)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, myTomes)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, myAge)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, Len(myKillerName))
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, myKillerName)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, Len(myDateDied))
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(ToFile, myDateDied)
	End Sub
	
	Public Sub ReadFromFile(ByRef FromFile As Short)
		Dim Cnt, c, s As Short
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, myVersion)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, myKillsCount)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, myRecordDamage)
		If myVersion >= 261 Then ' [Titi 2.6.0] Changed from Integer to Long
			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FileGet(FromFile, myRecordXP)
			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FileGet(FromFile, myHits)
			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FileGet(FromFile, myMisses)
		Else
			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FileGet(FromFile, s)
			myRecordXP = CInt(s)
			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FileGet(FromFile, s)
			myHits = CInt(s)
			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FileGet(FromFile, s)
			myMisses = CInt(s)
		End If
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, myBattles)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, mySpellsCast)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, mySpellsFailed)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, myDeaths)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, myTomes)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(FromFile, myAge)
		If myVersion >= 260 Then
			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FileGet(FromFile, Cnt)
			myKillerName = ""
			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FileGet(FromFile, s)
			For c = 1 To Cnt
				myKillerName = myKillerName & " "
			Next c
			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FileGet(FromFile, myKillerName)
			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FileGet(FromFile, Cnt)
			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FileGet(FromFile, s)
			myDateDied = ""
			For c = 1 To Cnt
				myDateDied = myDateDied & " "
			Next c
			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FileGet(FromFile, myDateDied)
			'    Else
			'        myKillerName = "Titi"
			'        myDateDied = "22nd day of the 7th moon of 2008"
		End If
	End Sub
	
	'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Initialize_Renamed()
		'    myVersion = 251 ' [Titi 2.5.1]
		myVersion = 261 ' [Titi 2.6.0]
	End Sub
	Public Sub New()
		MyBase.New()
		Class_Initialize_Renamed()
	End Sub
End Class