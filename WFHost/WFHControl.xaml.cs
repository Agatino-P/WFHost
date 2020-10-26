using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WFHost
{
    /// <summary>
    /// Interaction logic for WFHControl.xaml
    /// </summary>
    public partial class WFHControl : UserControl
    {
        public WFHControl()
        {
            InitializeComponent();

            System.Windows.Forms.Button button = new System.Windows.Forms.Button();
            button.Text = "wfbutton";
            WFHost.Child = button;

        }
    }
}
