# How to Add a New Row in WinForms DataGrid When DataGrid Bound to DataTable?

This sample illustrates how to add a new row when [WinForms DataGrid](https://www.syncfusion.com/winforms-ui-controls/datagrid) (SfDataGrid) bound to DataTable.

You can add the new row programmatically from a `DataTable` to the `DataGrid` by creating a new row in the [SfDataGrid.View](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.SfDataGrid.html#Syncfusion_WinForms_DataGrid_SfDataGrid_View) and set required value for that row.

``` csharp
DataTable gridDataTable = this.sfDataGrid.DataSource as DataTable;
if (gridDataTable == null || this.sfDataGrid.View == null)
    return;

// Creates a new row.
System.Data.DataRow addNewRow = sfDataGrid.View.AddNew() as System.Data.DataRow;

// Commits the newly created row.
sfDataGrid.View.CommitNew();

// Initialize the values of first row to the newly added row.
addNewRow.SetField(0, gridDataTable.Rows[0][0]);
addNewRow.SetField(1, gridDataTable.Rows[0][1]);
addNewRow.SetField(2, gridDataTable.Rows[0][2]);
addNewRow.SetField(3, gridDataTable.Rows[0][3]);
addNewRow.SetField(4, gridDataTable.Rows[0][4]);
```
