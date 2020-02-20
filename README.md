# How to add a new row in winforms datagrid when datagrid bound to datatable?
You can add the new row programmatically from a DataTable to the SfDataGrid by creating a new row in the `SfDataGrid.View` and set required value for that row.

```
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