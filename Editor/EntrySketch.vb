Option Strict Off
Option Explicit On
Friend Class EntrySketch
	
	Dim myIndex As Short
	
	Dim myAreaIndex As Short
	Dim myMapIndex As Short
	Dim myEntryIndex As Short
	
	Dim myAreaName As String
	Dim myMapName As String
	Dim myEntryName As String
	
	
	Public Property Index() As Short
		Get
			Index = myIndex
		End Get
		Set(ByVal Value As Short)
			myIndex = Value
		End Set
	End Property
	
	
	Public Property AreaIndex() As Short
		Get
			AreaIndex = myAreaIndex
		End Get
		Set(ByVal Value As Short)
			myAreaIndex = Value
		End Set
	End Property
	
	
	Public Property MapIndex() As Short
		Get
			MapIndex = myMapIndex
		End Get
		Set(ByVal Value As Short)
			myMapIndex = Value
		End Set
	End Property
	
	
	Public Property EntryIndex() As Short
		Get
			EntryIndex = myEntryIndex
		End Get
		Set(ByVal Value As Short)
			myEntryIndex = Value
		End Set
	End Property
	
	
	Public Property AreaName() As String
		Get
			AreaName = myAreaName
		End Get
		Set(ByVal Value As String)
			myAreaName = Value
		End Set
	End Property
	
	
	Public Property MapName() As String
		Get
			MapName = myMapName
		End Get
		Set(ByVal Value As String)
			myMapName = Value
		End Set
	End Property
	
	
	Public Property EntryName() As String
		Get
			EntryName = myEntryName
		End Get
		Set(ByVal Value As String)
			myEntryName = Value
		End Set
	End Property
End Class