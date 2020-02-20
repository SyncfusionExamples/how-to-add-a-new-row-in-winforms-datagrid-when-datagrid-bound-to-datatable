Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001-2018."
' Copyright Syncfusion Inc. 2001-2018. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Data
Imports Syncfusion.WinForms.DataGrid
Imports Syncfusion.WinForms.DataGrid.Enums

Namespace GettingStarted
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			Dim table As DataTable = GetDataTable()
			sfDataGrid.DataSource = table
			sfDataGrid.AutoExpandGroups = True
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			Dim gridDataTable As DataTable = TryCast(Me.sfDataGrid.DataSource, DataTable)
			If gridDataTable Is Nothing OrElse Me.sfDataGrid.View Is Nothing Then
				Return
			End If

			' Creates a new row.
			Dim addNewRow As System.Data.DataRow = TryCast(sfDataGrid.View.AddNew(), System.Data.DataRow)

			' Commits the newly created row.
			sfDataGrid.View.CommitNew()

			' Initialize the values of first row to the newly added row.
			addNewRow.SetField(0, gridDataTable.Rows(0)(0))
			addNewRow.SetField(1, gridDataTable.Rows(0)(1))
			addNewRow.SetField(2, gridDataTable.Rows(0)(2))
			addNewRow.SetField(3, gridDataTable.Rows(0)(3))
			addNewRow.SetField(4, gridDataTable.Rows(0)(4))
		End Sub

		Public Function GetDataTable() As DataTable
			Dim collection As New DataTable()
			collection.Columns.Add("ID", GetType(Integer))
			collection.Columns.Add("Name", GetType(String))
			collection.Columns.Add("Q1", GetType(Single))
			collection.Columns.Add("Q2", GetType(Single))
			collection.Columns.Add("Q3", GetType(Single))

			collection.Rows.Add(1001, "Belgim", 872.81, 978.89, 685.90)
			collection.Rows.Add(1002, "Oliver", 978.76, 458.21, 675.99)
			collection.Rows.Add(1003, "Bernald", 548.31, 234.32, 423.44)
			collection.Rows.Add(1004, "James", 123.31, 6543.12, 978.31)
			collection.Rows.Add(1005, "Beverton", 654.33, 978.31, 654.11)
			collection.Rows.Add(1005, "Berlin", 647.33, 978.31, 423.44)
			collection.Rows.Add(1006, "Fransis", 908.55, 123.31, 675.99)
			collection.Rows.Add(1006, "Fred", 654.34, 423.44, 978.31)
			Return collection
		End Function
	End Class
End Namespace
