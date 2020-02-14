Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001-2018."
' Copyright Syncfusion Inc. 2001-2018. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Namespace GettingStarted
	Partial Public Class OrderInfo
		Implements INotifyPropertyChanged
		Private _OrderID As Integer

		Private _orderDate As System.DateTime

		Private _CustomerID As String

		Private _unitPrice As Double

		Private _Quantity As Integer

		Private _contactNumber As Integer

		Private _product As String

		Private _shipaddress As String

		''' <summary>
		''' Initializes a new instance of the <see cref="OrderInfo"/> class.
		''' </summary>
		Public Sub New()

		End Sub

		''' <summary>
		''' Gets or sets the order ID.
		''' </summary>
		''' <value>The order ID.</value>
		<Display(Name := "Order ID")> _
		Public Property OrderID() As Integer
			Get
				Return Me._OrderID
			End Get
			Set(ByVal value As Integer)
				Me._OrderID = value
				Me.OnPropertyChanged("OrderID")
			End Set
		End Property

		''' <summary>
		''' Gets or sets the customer ID.
		''' </summary>
		''' <value>The customer ID.</value>
		<Display(Name := "Customer ID")> _
		Public Property CustomerID() As String
			Get
				Return Me._CustomerID
			End Get
			Set(ByVal value As String)
				Me._CustomerID = value
				Me.OnPropertyChanged("CustomerID")
			End Set
		End Property

		''' <summary>
		''' Gets or sets the Product.
		''' </summary>
		''' <value>The Product.</value>
		<Display(Name := "Product Name")> _
		Public Property ProductName() As String
			Get
				Return Me._product
			End Get
			Set(ByVal value As String)
				Me._product = value
				Me.OnPropertyChanged("ProductName")
			End Set
		End Property

		''' <summary>
		''' Gets or Sets the OrderDate
		''' </summary>
		<Display(Name := "Order Date")> _
		Public Property OrderDate() As System.DateTime
			Get
				Return _orderDate
			End Get
			Set(ByVal value As System.DateTime)
				_orderDate = value
			End Set
		End Property

		''' <summary>
		''' Gets or sets quantity
		''' </summary>
		''' <value>the quantity</value>     
		Public Property Quantity() As Integer
			Get
				Return Me._Quantity
			End Get
			Set(ByVal value As Integer)
				_Quantity = value
				OnPropertyChanged("Quantity")
			End Set
		End Property

		''' <summary>
		''' Gets or sets the unit price.
		''' </summary>
		''' <value>The unit price.</value>
		<DataType(DataType.Currency), Display(Name := "Unit Price")> _
		Public Property UnitPrice() As Double
			Get
				Return _unitPrice
			End Get
			Set(ByVal value As Double)
				_unitPrice = value
				OnPropertyChanged("UnitPrice")
			End Set
		End Property

		''' <summary>
		''' Gets or sets quantity
		''' </summary>
		''' <value>the quantity</value>     
		<Display(Name := "Contact Number")> _
		Public Property ContactNumber() As Integer
			Get
				Return Me._contactNumber
			End Get
			Set(ByVal value As Integer)
				_contactNumber = value
				OnPropertyChanged("ContactNumber")
			End Set
		End Property

		''' <summary>
		''' Gets or sets the ShipAddress.
		''' </summary>
		''' <value>The ShipAddress.</value>
		<Display(Name := "Ship Address")> _
		Public Property ShipCountry() As String
			Get
				Return Me._shipaddress
			End Get
			Set(ByVal value As String)
				Me._shipaddress = value
				Me.OnPropertyChanged("ShipCountry")
			End Set
		End Property

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
		Private Sub OnPropertyChanged(ByVal propertyName As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub
	End Class
End Namespace
