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
    /// Interaction logic for DockPanelWindow.xaml
    /// </summary>
    public partial class DockPanelWindow : Window
    {
        public DockPanelWindow()
        {
            InitializeComponent();
        }
            private void CenterButton_Click(object sender, RoutedEventArgs e)
            {
             
            Image image = new Image();
            image.Width = 200;
            image.Height = 200;
            BitmapImage imgSource = new BitmapImage(new Uri("C:\\Users\\aleksander\\Documents\\GitHub\\hemuppgift-wpf-aleksanderlukic\\Hemuppgift_WPFtemplate\\TrophyImage.jpg"));
            image.Source = imgSource;

            dockPanel.Children.Remove(CenterButton);
            dockPanel.Children.Add(image);
        }
        }
    }
