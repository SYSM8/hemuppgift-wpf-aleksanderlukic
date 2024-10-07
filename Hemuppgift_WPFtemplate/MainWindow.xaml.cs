using System.Windows;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //HEJ
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GridWindow gridWindow = new GridWindow();
            gridWindow.Show();
        }
        private void Button_Click(object sender, RoutedEventArgs e)

            StackPanelWindow stackPanelWindow = new StackPanelWindow();
            StackPanelWindow.Show();



    






    }
}
}