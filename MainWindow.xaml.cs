using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.TreeGrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SfDataGrid_MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.dataGrid.Columns.Changed += OnColumns_Changed;
            
        }

        private void OnColumns_Changed(object sender, EventArgs e)
        {
            double width = 0;
            foreach(var column in this.dataGrid.Columns)
            {
                width += column.IsHidden ? 0 : column.ActualWidth;
            }

            this.dataGrid.Width = width;
        }

        ColumnChooser chooserWindow;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            chooserWindow = new ColumnChooser(this.dataGrid) { Width = 300, Height = 500 };
            this.dataGrid.GridColumnDragDropController = new GridColumnChooserController(this.dataGrid, chooserWindow);
            chooserWindow.Show();
            chooserWindow.Owner = this;
        }
    }
}
