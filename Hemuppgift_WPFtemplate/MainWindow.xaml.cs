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

        private void Button_ClickGridWindow(object sender, RoutedEventArgs e)
        {
            GridWindow gridWindow = new GridWindow();
            gridWindow.Show();
        }
        private void Button_ClickStackPanelWindow(object sender, RoutedEventArgs e)

        { 

            StackPanelWindow stackPanelWindow = new StackPanelWindow();
            stackPanelWindow.Show();

        }

        private void Button_ClickWrapPanelWindow(object sender, RoutedEventArgs e)

        {

            WrapPanelWindow wrapPanelWindow = new WrapPanelWindow();
            wrapPanelWindow.Show();

        }
        private void Button_ClickDockPanelWindow(object sender, RoutedEventArgs e)

        {
            DockPanelWindow dockPanelWindow = new DockPanelWindow();
            dockPanelWindow.Show();

        }








        

    



}

}
