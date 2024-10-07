﻿using System;
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
    /// Interaction logic for WrapPanelWindow.xaml
    /// </summary>
    public partial class WrapPanelWindow : Window
    {
        public WrapPanelWindow()
        {
            InitializeComponent();
        }
            private void OrientationChanged(object sender, RoutedEventArgs e)
            {
                if ((sender as RadioButton).Content.ToString() == "Horizontal")
                {
                    MainWrapPanel.Orientation = Orientation.Horizontal;
                }
                else
                {
                    MainWrapPanel.Orientation = Orientation.Vertical;
                }
            }
        }
    }
