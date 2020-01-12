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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp16
{
    /// <summary>
    /// Logique d'interaction pour UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 aa = new Window2();
            aa.Show();
            //this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 aa = new Window1();
            aa.Show();
            //this.Hide();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window3 aa = new Window3();
            aa.Show();
            //this.Hide();
        }
    }
}
