#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Windows.Forms;
using System.Data;
using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;

namespace GettingStarted
{
	public partial class Form1 : Form
	{		       
		public Form1()
		{
			InitializeComponent();
			DataTable table = GetDataTable();
			sfDataGrid.DataSource = table;
			sfDataGrid.AutoExpandGroups = true;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
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
		}		

        public DataTable GetDataTable()
        {
            DataTable collection = new DataTable();
            collection.Columns.Add("ID", typeof(int));
            collection.Columns.Add("Name", typeof(string));
            collection.Columns.Add("Q1", typeof(float));
            collection.Columns.Add("Q2", typeof(float));
            collection.Columns.Add("Q3", typeof(float));

            collection.Rows.Add(1001, "Belgim", 872.81, 978.89, 685.90);
            collection.Rows.Add(1002, "Oliver", 978.76, 458.21, 675.99);
            collection.Rows.Add(1003, "Bernald", 548.31, 234.32, 423.44);
            collection.Rows.Add(1004, "James", 123.31, 6543.12, 978.31);
            collection.Rows.Add(1005, "Beverton", 654.33, 978.31, 654.11);
            collection.Rows.Add(1005, "Berlin", 647.33, 978.31, 423.44);
            collection.Rows.Add(1006, "Fransis", 908.55, 123.31, 675.99);
            collection.Rows.Add(1006, "Fred", 654.34, 423.44, 978.31);
            return collection;
        }
	}
}
