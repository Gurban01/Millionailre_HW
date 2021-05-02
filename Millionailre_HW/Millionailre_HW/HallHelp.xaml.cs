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

namespace Millionailre_HW
{
    /// <summary>
    /// Interaction logic for HallHelp.xaml
    /// </summary>
    public partial class HallHelp : Window
    {
        public HallHelp(int a,int b,int c,int d)
        {
            InitializeComponent();
            text1.Text = a.ToString();
            text2.Text = b.ToString();
            text3.Text = c.ToString();
            text4.Text = d.ToString();
        }
    }
}
