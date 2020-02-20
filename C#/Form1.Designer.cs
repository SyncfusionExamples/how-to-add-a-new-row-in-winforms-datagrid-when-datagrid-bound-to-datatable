using System.Data;
using Syncfusion.Data;

#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Windows.Forms;

namespace GettingStarted
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sfDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)this.sfDataGrid).BeginInit();
			this.SuspendLayout();
			// 
			// sfDataGrid
			// 
			this.sfDataGrid.AccessibleName = "Table";
			this.sfDataGrid.AllowDraggingColumns = true;
			this.sfDataGrid.AllowFiltering = true;
			this.sfDataGrid.AllowResizingColumns = true;
			this.sfDataGrid.AllowResizingHiddenColumns = true;
			this.sfDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.sfDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
			this.sfDataGrid.BackColor = System.Drawing.SystemColors.Window;
			this.sfDataGrid.Location = new System.Drawing.Point(10, 5);
			this.sfDataGrid.Name = "sfDataGrid";
			this.sfDataGrid.ShowGroupDropArea = true;
			this.sfDataGrid.Size = new System.Drawing.Size(878, 576);
			this.sfDataGrid.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(894, 80);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 42);
			this.button1.TabIndex = 2;
			this.button1.Text = "Add New Row";
			this.button1.UseVisualStyleBackColor = true;
//			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			// 
			// Form1
			// 
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1006, 593);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.sfDataGrid);
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MinimumSize = new System.Drawing.Size(500, 400);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Getting Started";
			((System.ComponentModel.ISupportInitialize)this.sfDataGrid).EndInit();
			this.ResumeLayout(false);

			//INSTANT C# NOTE: Converted event handlers:
			button1.Click += new System.EventHandler(button1_Click);

		}

		#endregion

		#region API Definition

		private SfDataGrid sfDataGrid;

		#endregion
		private Button button1;
	}
}

