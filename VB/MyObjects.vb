Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo

Namespace ComplexProperty
	Public Class Person
		Inherits XPObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Private _name As String
		Public Property Name() As String
			Get
				Return _name
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Name", _name, value)
			End Set
		End Property

		Private _address As Address
		<Aggregated> _
		Public Property Address() As Address
			Get
				Return _address
			End Get
			Set(ByVal value As Address)
				SetPropertyValue("Address", _address, value)
			End Set
		End Property
	End Class

	Public Class Address
		Inherits XPObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Private _addressLine1 As String
		Public Property AddressLine1() As String
			Get
				Return _addressLine1
			End Get
			Set(ByVal value As String)
				SetPropertyValue("AddressLine1", _addressLine1, value)
			End Set
		End Property

		Private _city As String
		Public Property City() As String
			Get
				Return _city
			End Get
			Set(ByVal value As String)
				SetPropertyValue("City", _city, value)
			End Set
		End Property

		Private _zip As String
		Public Property Zip() As String
			Get
				Return _zip
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Zip", _zip, value)
			End Set
		End Property
	End Class
End Namespace
