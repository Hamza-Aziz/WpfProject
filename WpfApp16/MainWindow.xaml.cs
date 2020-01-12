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
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserControl3 usaa = new UserControl3();
            grid1.Children.Clear();
            grid1.Children.Add(usaa);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UserControl2 usaaa = new UserControl2();
            grid1.Children.Clear();
            grid1.Children.Add(usaaa);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            UserControl4 usa = new UserControl4();
           
            grid1.Children.Clear();
            grid1.Children.Add(usa);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            UserControl1 uusaa = new UserControl1();
            grid1.Children.Clear();
            grid1.Children.Add(uusaa);
        }
    }
}
