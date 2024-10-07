using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(RowInput.Text, out int row) && int.TryParse(ColumnInput.Text, out int column) && 
                row >= 0 && row < 4 && column >= 0 && column < 4)
            {
                var button = new Button();
                {
                    Content = $"Row {row}, Column {column} "; 
                    Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.LightGreen);
                };
                Grid.SetRow(button, row);
                Grid.SetColumn(button, column);
                MainGrid.Children.Add(button);     
                }
                else
                {
                MessageBox.Show("Vänligen ange gitliga rad- och kolumnvärden mellan 0 och 3.");
            } 
        }
    }
}
