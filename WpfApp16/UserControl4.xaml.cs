using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Logique d'interaction pour UserControl4.xaml
    /// </summary>
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }
        public class FiliereCount

        {

            public int nbEtudiant { get; set; }

            public string Filiere { get; set; }

        }



        public class UsersViewModel

        {
            static DataClasses1DataContext cl = new DataClasses1DataContext();

            public ObservableCollection<FiliereCount> ListF

            {

                get; set;

            }

            public UsersViewModel()

            {

                this.ListF = new ObservableCollection<FiliereCount>();

                var filCount = from etudiant in cl.etudiant join filiere in cl.filiere
                               on etudiant.id_filiere equals filiere.id_filiere
                               group new { etudiant, filiere } by filiere.nom_filiere
                          into grouping
                               select new
                               {
                                   grouping.Key,
                                   nbEtudiant = grouping.Count()

                               };
                foreach (var gr in filCount)
                {
                    ListF.Add(new FiliereCount { Filiere = gr.Key, nbEtudiant = gr.nbEtudiant });

                }



            }


        }
    }
}

