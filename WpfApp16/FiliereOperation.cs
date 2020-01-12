using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp16
{
    class FiliereOperation
    {
        DataClasses1DataContext cl;
        ObservableCollection<filiere> liste1;
        public FiliereOperation(DataClasses1DataContext cl, ObservableCollection<filiere> liste1)
        {
            this.cl = cl;
            this.liste1 = liste1;
        }

        public void ajouter(int id, String nomFiliere)
        {
            filiere f = new filiere();
            f.id_filiere = id;
            f.nom_filiere = nomFiliere;
            cl.filiere.InsertOnSubmit(f);
            cl.SubmitChanges();
            liste1.Add(f);

        }
        public void supprimer(int id)
        {
            var x = (from c in cl.filiere
                     where c.id_filiere == id
                     select c).SingleOrDefault();
            cl.filiere.DeleteOnSubmit(x);
            cl.SubmitChanges();
            liste1.Remove(x);



        }
        public void modifier(int id, String nomFiliere)
        {
            var y = (from c in cl.filiere where c.id_filiere == id select c).SingleOrDefault();

            int i = liste1.IndexOf(y);
            liste1.Remove(y);

            y.id_filiere = id;
            y.nom_filiere = nomFiliere;
            cl.SubmitChanges();
            liste1.Insert(i, y);

        }
        public ObservableCollection<filiere> afficher()
        {
            var x = from c in cl.filiere select c;
            foreach (var i in x)
            {
                liste1.Add(i);
            }
            return liste1;
        }

    }

}
