# How to bind data table to WPF DataGrid (SfDataGrid) 


[WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid) supports to bind the [DataTable](https://docs.microsoft.com/en-us/dotnet/api/system.data.datatable?view=net-5.0) as ItemsSource. You can also bind the datatable from the [dataset](https://docs.microsoft.com/en-us/dotnet/api/system.data.dataset?view=netframework-4.8).

## ViewModel creation

Create a view model class in the WPF project similar to the one in the following code example

```
public class ViewModel
{
    public ViewModel()
    {
        DataTableCollection = GetDataTable();
    }
    public DataTable DataTableCollection { get; set; }
 
    private DataTable GetDataTable()
    {
        DataTable dataTable = new DataTable();
        dataTable.Columns.Add("Order ID", typeof(int));
        dataTable.Columns.Add("Customer Name", typeof(string));
        dataTable.Columns.Add("Customer ID", typeof(string));
        dataTable.Columns.Add("Country", typeof(string));
        dataTable.Rows.Add(1001, "Maria Anders", "ALFKI", "Germany");
        dataTable.Rows.Add(1002, "Ana Trujilo", "ANATR", "Mexico");
        dataTable.Rows.Add(1003, "Antonio Moreno", "ENDGY", "Mexico");
        dataTable.Rows.Add(1004, "Thomas Hardy", "ANTON", "UK");
        dataTable.Rows.Add(1005, "Christina Berglund", "BERGS", "Sweden");
        dataTable.Rows.Add(1006, "Hanna Moos", "BLAUS", "Germany");
        dataTable.Rows.Add(1007, "Frederique Citeaux", "BLONP", "France");
        dataTable.Rows.Add(1008, "Martin Sommer", "BOLID", "Spain");
        dataTable.Rows.Add(1009, "Laurence Lebihan", "BONAP", "France");
        dataTable.Rows.Add(1010, "Kathryn", "BOTTM", "Canada");
        dataTable.Rows.Add(1011, "Tamer", "XDKLF", "UK");
        dataTable.Rows.Add(1012, "Martin", "QEUDJ", "US");
        dataTable.Rows.Add(1013, "Nancy", "ALOPS", "France");
        dataTable.Rows.Add(1014, "Janet", "KSDIO", "Canada");
        dataTable.Rows.Add(1015, "Dodsworth", "AWSDE", "Canada");
        dataTable.Rows.Add(1016, "Buchanan", "CDFKL", "Germany");
        dataTable.Rows.Add(1017, "Therasa", "WSCJD", "Canada");
        dataTable.Rows.Add(1018, "Margaret", "PLSKD", "UK");
        dataTable.Rows.Add(1019, "Anto", "CCDSE", "Sweden");
        dataTable.Rows.Add(1020, "Edward", "EWUJG", "Germany");
        return dataTable;
    }
}
```

## Binding ItemsSource in XAML

In the main page, add the necessary XML namespace to use <b>SfDataGrid</b> control, set the <b>DataContext</b> of the window to the <b>ViewModel</b> class, and bind the <b>ItemsSource</b> of <b>SfDataGrid</b> with the <b>DataTableCollection</b>.

```
<Window x:Class="SfDataGridDemo.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:SfDataGridDemo"
         xmlns:syncfusion="http://schemas.syncfusion.com/wpf"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Window.DataContext>
        <local:ViewModel/>
    </Window.DataContext>
    <Grid>
        <syncfusion:SfDataGrid x:Name="dataGrid"  ItemsSource="{Binding DataTableCollection}" />
    </Grid>
</Window>
```

## CRUD operations

DataGrid automatically refreshes the UI whenever we add, delete or modify the rows of the underlying DataTable collection.

## Data operations

DataGrid supports various data operations to represent the data in it. The following are supported by default:

<li>Sorting (including multicolumn sorting)</li>
<li>Grouping (including multicolumn grouping)</li>
<li>Filtering</li>
<li>Summaries</li>

### Sorting

You can sort columns with the various built-in options such as [multicolumn sorting](https://help.syncfusion.com/wpf/datagrid/sorting?_ga=2.9711221.1545506509.1668677528-766490130.1650530957&_gl=1*fkhq8t*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2ODY5MDMxMS4zMDEuMS4xNjY4NjkyMzg0LjAuMC4w#multi-column-sorting) and [tri-state sorting](https://help.syncfusion.com/wpf/datagrid/sorting?_ga=2.9711221.1545506509.1668677528-766490130.1650530957&_gl=1*fkhq8t*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2ODY5MDMxMS4zMDEuMS4xNjY4NjkyMzg0LjAuMC4w#sorting-order). But [custom sorting](https://help.syncfusion.com/wpf/datagrid/sorting?_ga=2.9711221.1545506509.1668677528-766490130.1650530957&_gl=1*fkhq8t*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2ODY5MDMxMS4zMDEuMS4xNjY4NjkyMzg0LjAuMC4w#custom-sorting) is not supported.


### Groupin

The data can be organized in a hierarchical structure based on matching field values. [Custom grouping](https://help.syncfusion.com/wpf/datagrid/grouping?_ga=2.224142299.1545506509.1668677528-766490130.1650530957&_gl=1*1g5a2dc*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2ODY5MDMxMS4zMDEuMS4xNjY4NjkyMzg0LjAuMC4w#custom-grouping) are also supported.

### Filtering

You can filter columns with the various built-in options such as [Excel like UI filtering](https://help.syncfusion.com/wpf/datagrid/filtering?_ga=2.224142299.1545506509.1668677528-766490130.1650530957&_gl=1*1g5a2dc*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2ODY5MDMxMS4zMDEuMS4xNjY4NjkyMzg0LjAuMC4w#excel-like-ui-filtering), [Advanced UI filtering](https://help.syncfusion.com/wpf/datagrid/filtering?_ga=2.44600932.1545506509.1668677528-766490130.1650530957&_gl=1*1q3ekbe*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2ODY5MDMxMS4zMDEuMS4xNjY4NjkyMzg0LjAuMC4w#advanced-filter-ui) and [programmatic filtering](https://help.syncfusion.com/wpf/datagrid/filtering?_ga=2.44600932.1545506509.1668677528-766490130.1650530957&_gl=1*1q3ekbe*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2ODY5MDMxMS4zMDEuMS4xNjY4NjkyMzg0LjAuMC4w#column-filtering) by using [FilterPredicates](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfGrid.WPF~Syncfusion.UI.Xaml.Grid.GridColumn~FilterPredicates.html?_ga=2.44600932.1545506509.1668677528-766490130.1650530957&_gl=1*1q3ekbe*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2ODY5MDMxMS4zMDEuMS4xNjY4NjkyMzg0LjAuMC4w). But DataGrid’s built-in [View.Filtering](https://help.syncfusion.com/wpf/datagrid/filtering?_ga=2.220799320.1545506509.1668677528-766490130.1650530957&_gl=1*6l5u5q*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2ODY5MDMxMS4zMDEuMS4xNjY4NjkyMzg0LjAuMC4w#%22view-filtering%22) is not supported for the DataTable class. But you can filter the records using DataTable’s [DataView.RowFilter](https://docs.microsoft.com/en-us/dotnet/api/system.data.dataview.rowfilter?view=netframework-4.8) property.

### Summaries

All summary types supported by DataGrid are supported for DataTable, i.e. [group summary](https://help.syncfusion.com/wpf/datagrid/summaries?_ga=2.216057430.1545506509.1668677528-766490130.1650530957&_gl=1*xucyp*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2ODY5MDMxMS4zMDEuMS4xNjY4NjkyMzg0LjAuMC4w#group-summary), [caption summary](https://help.syncfusion.com/wpf/datagrid/summaries?_ga=2.216057430.1545506509.1668677528-766490130.1650530957&_gl=1*xucyp*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2ODY5MDMxMS4zMDEuMS4xNjY4NjkyMzg0LjAuMC4w#caption-summaries), and [table summary](https://help.syncfusion.com/wpf/datagrid/summaries?_ga=2.49933030.1545506509.1668677528-766490130.1650530957&_gl=1*p70ti5*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2ODY5MDMxMS4zMDEuMS4xNjY4NjkyMzg0LjAuMC4w#table-summary).

### Other features

The support for all other features, such as stacked headers, row drag and drop, unbound column, and unbound row, of DataGrid are available.

You can refer to the [user guide](https://help.syncfusion.com/wpf/datagrid/overview?_ga=2.219187929.1545506509.1668677528-766490130.1650530957&_gl=1*hgu4jr*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2ODY5MDMxMS4zMDEuMS4xNjY4NjkyMzg0LjAuMC4w) to learn more about the DataGrid’s feature sets.

Please refer this [link](https://www.syncfusion.com/wpf-ui-controls/datagrid) to know about the essential features of Syncfusion WPF DataGrid.