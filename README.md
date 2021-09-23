# How to adjust width of WPF DataGrid (SfDataGrid) when hiding columns using ColumnChooser?

## About the sample

This sample illustrates how to adjust width of WPF DataGrid (SfDataGrid) when hiding columns using ColumnChooser.

In [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid)(SfDataGrid) while hiding the columns using ColumnChooser, empty space will be added to the right side of the DataGrid. You can avoid this by adjusting the width of the DataGrid while hiding columns using ColumnChooser.

```C#

this.dataGrid.Columns.Changed += OnColumns_Changed;

private void OnColumns_Changed(object sender, EventArgs e)
{
    double width = 0;
    foreach(var column in this.dataGrid.Columns)
    {
        width += column.IsHidden ? 0 : column.ActualWidth;
    }

    this.dataGrid.Width = width;
}


```

KB article - [How to adjust width of WPF DataGrid (SfDataGrid) when hiding columns using ColumnChooser?](https://www.syncfusion.com/kb/12512/how-to-adjust-width-of-wpf-datagrid-sfdatagrid-when-hiding-columns-using-columnchooser)

## Requirements to run the demo

Visual Studio 2015 and above versions
