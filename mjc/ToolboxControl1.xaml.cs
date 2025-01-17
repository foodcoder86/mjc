﻿using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace mjc
{
    /// <summary>
    /// Interaction logic for ToolboxControl1.xaml.
    /// </summary>
    
    [ProvideToolboxControl("mjc.ToolboxControl1", true)]
    public partial class ToolboxControl1 : UserControl
    {
        public ToolboxControl1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format(CultureInfo.CurrentUICulture, "We are inside {0}.Button1_Click()", this.ToString()));
        }
    }
}
