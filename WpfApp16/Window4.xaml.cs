using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace WpfApp16
{
    /// <summary>
    /// Logique d'interaction pour Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text == "admin" && mdp.Password == "123456") { 
                MainWindow dashboard = new MainWindow();
            dashboard.Show();
            this.Close();

            
            
               
            }
            else
            {
                MessageBox.Show("le mot de passe est incorrect", "authentificcation incorrecte", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
