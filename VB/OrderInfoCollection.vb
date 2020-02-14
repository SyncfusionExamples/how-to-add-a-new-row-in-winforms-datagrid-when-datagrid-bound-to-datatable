Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001-2018."
' Copyright Syncfusion Inc. 2001-2018. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.Collections.Generic

Namespace GettingStarted
	Public Class OrderInfoCollection
		Implements IDisposable
		Public Sub New()
			OrdersListDetails = New OrderInfoRepository().GetListOrdersDetails(10)
		End Sub

		Private _ordersListDetails As List(Of OrderInfo)

		''' <summary>
		''' Gets or sets the orders details.
		''' </summary>
		''' <value>The orders details.</value>
		Public Property OrdersListDetails() As List(Of OrderInfo)
			Get
				Return _ordersListDetails
			End Get
			Set(ByVal value As List(Of OrderInfo))
				_ordersListDetails = value
			End Set
		End Property

		Public Sub Dispose() Implements IDisposable.Dispose
			Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub

		Protected Overridable Sub Dispose(ByVal isdisposable As Boolean)
			If Me.OrdersListDetails IsNot Nothing Then
				Me.OrdersListDetails.Clear()
			End If
		End Sub
	End Class

	Public Class OrderInfoRepository
		Private customerIdCount As Integer = 0

		''' <summary>
		''' Initializes a new instance of the <see cref="OrderInfoRepository"/> class.
		''' </summary>
		Public Sub New()
		End Sub

		''' <summary>
		''' Gets the orders details.
		''' </summary>
		''' <param name="count">The count.</param>
		''' <returns></returns>
		Public Function GetListOrdersDetails(ByVal count As Integer) As List(Of OrderInfo)
			Dim ordersDetails As New List(Of OrderInfo)()
			If ShipCity.Count = 0 Then
				SetShipCity()
			End If
			For i As Integer = 10000 To count + 10000 - 1
				ordersDetails.Add(GetOrder(i))
			Next i

			Return ordersDetails
		End Function

		Private r As New Random(1)

		''' <summary>
		''' Gets the order.
		''' </summary>
		''' <param name="i">The i.</param>
		''' <returns></returns>
		Private Function GetOrder(ByVal i As Integer) As OrderInfo
			Dim shipcountry As String = Me.ShipCountry(r.Next(5))
			Dim shipcitycoll As Object = ShipCity(shipcountry)
			Dim order As New OrderInfo()
			order.OrderID = i
			order.OrderDate = New System.DateTime(r.Next(2011, 2013), r.Next(1, 12), r.Next(1, 28))
			order.ProductName = productName(r.Next(5))
			order.CustomerID = GetCustomerID(i)
			order.UnitPrice = unitPrice(r.Next(35))
			order.Quantity = r.Next(20, 60)
			order.ShipCountry = shipcountry
			order.ContactNumber = 999111235 + i
			Return order
		End Function

		Private Function GetCustomerID(ByVal i As Integer) As String
			If i Mod 4 <> 0 OrElse i = 0 Then
				Return CustomerID(customerIdCount)
			Else
				If i Mod 4 = 0 Then
					customerIdCount += 1
				End If

				If customerIdCount > 9 Then
					customerIdCount = 0
				End If

				Return CustomerID(customerIdCount)
			End If
		End Function

		Private unitPrice() As Double = { 28.5, 336.2, 88.3, 86, 512, 41, 253.3, 33, 87, 45.1, 78.3, 19, 56.7, 23.3, 59, 91, 32.8, 264.5, 63.7, 434.2, 15.9, 21.9, 45, 70.3, 42.5, 67.2, 34.9, 379.9, 0, 59.2, 412.6, 19.8, 42.7, 78, 26.8 }

		Private ShipCountry() As String = { "Argentina", "Austria", "Belgium", "Brazil", "Canada", "Denmark", "Finland", "France", "Germany", "Ireland", "Italy", "Mexico", "Norway", "Poland", "Portugal", "Spain", "Sweden", "Switzerland", "UK", "USA", "Venezuela" }

		''' <summary>
		''' Collection of ProductNames
		''' </summary>
		Private productName() As String = { "Alice Mutton", "NuNuCa Nuß-Nougat-Creme", "Boston Crab Meat", "Raclette Courdavault", "Wimmers gute", "Gorgonzola Telino", "Chartreuse verte", "Fløtemysost", "Carnarvon Tigers", "Thüringer", "Vegie-spread", "Tarte au sucre", "Konbu", "Valkoinen suklaa", "Queso Manchego", "Perth Pasties", "Vegie-spread", "Tofu", "Sir Rodney's", "Manjimup Dried Apples" }

		Private ShipCity As New Dictionary(Of String, String())()

		''' <summary>
		''' Sets the ship city.
		''' </summary>
		Private Sub SetShipCity()
			Dim argentina() As String = { "Buenos Aires" }

			Dim austria() As String = { "Graz", "Salzburg" }

			Dim belgium() As String = { "Bruxelles", "Charleroi" }

			Dim brazil() As String = { "Campinas", "Resende", "Rio de Janeiro", "São Paulo" }

			Dim canada() As String = { "Montréal", "Tsawassen", "Vancouver" }

			Dim denmark() As String = { "Århus", "København" }

			Dim finland() As String = { "Helsinki", "Oulu" }

			Dim france() As String = { "Lille", "Lyon", "Marseille", "Nantes", "Paris", "Reims", "Strasbourg", "Toulouse", "Versailles" }

			Dim germany() As String = { "Aachen", "Berlin", "Brandenburg", "Cunewalde", "Frankfurt a.M.", "Köln", "Leipzig", "Mannheim", "München", "Münster", "Stuttgart" }

			Dim ireland() As String = { "Cork" }

			Dim italy() As String = { "Bergamo", "Reggio Emilia", "Torino" }

			Dim mexico() As String = { "México D.F." }

			Dim norway() As String = { "Stavern" }

			Dim poland() As String = { "Warszawa" }

			Dim portugal() As String = { "Lisboa" }

			Dim spain() As String = { "Barcelona", "Madrid", "Sevilla" }

			Dim sweden() As String = { "Bräcke", "Luleå" }

			Dim switzerland() As String = { "Bern", "Genève" }

			Dim uk() As String = { "Colchester", "Hedge End", "London" }

			Dim usa() As String = { "Albuquerque", "Anchorage", "Boise", "Butte", "Elgin", "Eugene", "Kirkland", "Lander", "Portland", "San Francisco", "Seattle", "Walla Walla" }

			Dim venezuela() As String = { "Barquisimeto", "Caracas", "I. de Margarita", "San Cristóbal" }

			ShipCity.Add("Argentina", argentina)
			ShipCity.Add("Austria", austria)
			ShipCity.Add("Belgium", belgium)
			ShipCity.Add("Brazil", brazil)
			ShipCity.Add("Canada", canada)
			ShipCity.Add("Denmark", denmark)
			ShipCity.Add("Finland", finland)
			ShipCity.Add("France", france)
			ShipCity.Add("Germany", germany)
			ShipCity.Add("Ireland", ireland)
			ShipCity.Add("Italy", italy)
			ShipCity.Add("Mexico", mexico)
			ShipCity.Add("Norway", norway)
			ShipCity.Add("Poland", poland)
			ShipCity.Add("Portugal", portugal)
			ShipCity.Add("Spain", spain)
			ShipCity.Add("Sweden", sweden)
			ShipCity.Add("Switzerland", switzerland)
			ShipCity.Add("UK", uk)
			ShipCity.Add("USA", usa)
			ShipCity.Add("Venezuela", venezuela)
		End Sub

		Private CustomerID() As String = { "ALFKI", "FRANS", "MEREP", "FOLKO", "SIMOB", "WARTH", "VAFFE", "FURIB", "SEVES", "LINOD", "RISCU", "PICCO", "BLONP", "WELLI", "FOLIG", "SHIWL", "ASDFI", "YIWOL", "SIEPZ", "UIKOC", "BNUTQ", "FDKIO", "UJIKW", "QOLPX", "WJXKO", "SXEWD", "ZXSOL", "KKMJU", "QMICP", "SJWII", "WDOPO", "SAIOP", "SSOLE", "CUEMC", "HWIMQ" }
	End Class
End Namespace
