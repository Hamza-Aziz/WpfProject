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
    /// Logique d'interaction pour UserControl3.xaml
    /// </summary>
    public partial class UserControl3 : UserControl
    {
        DataClasses1DataContext cl = new DataClasses1DataContext();
        public UserControl3()
        {
            InitializeComponent();
            EtudiantOperation f = new EtudiantOperation();
            Combobox.ItemsSource = f.getNomfiliere();

            RadGridV.ItemsSource = f.getaletudiant();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ModifierEtudiant dr = new ModifierEtudiant();
            dr.Show();
        }

        private void Combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String combobx = Convert.ToString(Combobox.SelectedItem);

            EtudiantOperation f = new EtudiantOperation();
            label1.Content = combobx;
            Mafiliere.Content = combobx;
            RadGridV.ItemsSource = f.getchaquefiliere(combobx);
            ChefFiliere.Content = f.getcheffiliere(combobx);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ModifierEtudiant dr = new ModifierEtudiant();
            dr.Show();
        }

        private void RadGridV_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {

        }
    }
}
