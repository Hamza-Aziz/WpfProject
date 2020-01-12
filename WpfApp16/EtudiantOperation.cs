using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp16
{
    class EtudiantOperation
    {
        DataClasses1DataContext cl = new DataClasses1DataContext();

        //reccuperer les noms de toutes les filiéres

        public List<string> getNomfiliere()
        {
            List<string> ListeFiliere = new List<string>();
            var x = from c in cl.filiere select new { c.nom_filiere };
            foreach (var i in x)
            {
                ListeFiliere.Add(i.nom_filiere);

            }

            return ListeFiliere;

        }

        //List etudiants dans datagridview
        public List<etudiant> getaletudiant()
        {

            List<etudiant> Listeetudiant = new List<etudiant>();
            var x = from c in cl.etudiant select new { c.cne, c.nom, c.prenom, c.dateNaiss, c.tof };
            foreach (var y in x)
            {
                etudiant et = new etudiant();

                et.cne = y.cne;
                et.nom = y.nom;
                et.prenom = y.prenom;
                et.dateNaiss = y.dateNaiss;
                et.tof = y.tof;


                Listeetudiant.Add(et);

            }

            return Listeetudiant;

        }
        //affiher les étudiants pour chaque filière

        public List<etudiant> getchaquefiliere(String v)
        {
            MainWindow ft = new MainWindow();
            List<etudiant> Listeetudiant = new List<etudiant>();
            var x = (from c in cl.etudiant join d in cl.filiere on c.id_filiere equals d.id_filiere where d.nom_filiere == v select new { c.cne, c.nom, c.prenom, c.dateNaiss, c.tof });
            foreach (var y in x)
            {
                etudiant et = new etudiant();

                et.cne = y.cne;
                et.nom = y.nom;
                et.prenom = y.prenom;
                et.dateNaiss = y.dateNaiss;
                et.tof = y.tof;


                Listeetudiant.Add(et);

            }

            return Listeetudiant;
        }





        public List<etudiant> geAlleudiant()
        {

            List<etudiant> Listeetudiant = new List<etudiant>();
            var x = from c in cl.etudiant select new { c.cne, c.nom, c.prenom, c.dateNaiss };
            foreach (var y in x)
            {
                etudiant et = new etudiant();

                et.cne = y.cne;
                et.nom = y.nom;
                et.prenom = y.prenom;
                et.dateNaiss = y.dateNaiss;


                Listeetudiant.Add(et);

            }

            return Listeetudiant;

        }
        //supprimer

        public void Delete(String id)
        {
            List<etudiant> Listeetudiant = new List<etudiant>();

            var x = (from c in cl.etudiant
                     where c.cne == id.ToString()
                     select c).SingleOrDefault();
            cl.etudiant.DeleteOnSubmit(x);
            cl.SubmitChanges();
            Listeetudiant.Remove(x);


        }
        //ajouter

        public void ajouter(etudiant etudiant)
        {
            List<etudiant> Listeetudiant = new List<etudiant>();

            etudiant f = new etudiant();
            f.cne = etudiant.cne;
            f.nom = etudiant.nom;
            f.prenom = etudiant.prenom;
            f.dateNaiss = etudiant.dateNaiss;

            cl.etudiant.InsertOnSubmit(f);
            cl.SubmitChanges();
            //Listeetudiant.Add(f);

        }
        //resp 
        public String getcheffiliere(String v)
        {
            filiere FR = new filiere();
            var x = from c in cl.filiere where c.nom_filiere == v select new { c.resp };
            foreach (var y in x)
            {
                FR.resp = y.resp;

            }
            return FR.resp;

        }
        //modifier 
        public void modifier(etudiant etudiant)
        {
            var x = (from f in cl.etudiant
                     where f.cne == etudiant.cne
                     select f).SingleOrDefault();

            x.nom = etudiant.nom;
            x.prenom = etudiant.prenom;
            x.dateNaiss = etudiant.dateNaiss;
            cl.SubmitChanges();
        }

    }

}
