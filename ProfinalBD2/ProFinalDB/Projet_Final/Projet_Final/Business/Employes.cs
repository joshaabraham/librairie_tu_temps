using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_Final.donnees_IO;




namespace Projet_Final
{
    class Employes
    {
        private int noIdentifiant;
        public int NoIdentifiant
        {
            get { return noIdentifiant; }
            set { noIdentifiant = value; }
        }

        private string nomUtil;
        public string NomUtil
        {
            get { return nomUtil; }
            set { nomUtil = value; }
        }

        private string prenomUtil;
        public string PrenomAdmin
        {
            get { return prenomUtil; }
            set { prenomUtil = value; }
        }
        private string mPasse;
        public string MPasse
        {
            get { return mPasse; }
            set { mPasse = value; }

        }
        private string categorie;
        public string Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }

        private string supp;
        public string Supp
        {
            get { return supp; }
            set { supp = value; }
        }

        public bool SaveEmploye(Employes emp)
        {
            return (EmployesBD.InsertData(emp));
        }

        public bool DeleteEmploye(Employes emp)
        {
            return (EmployesBD.DeleteData(emp));
        }
        public List<Employes> ListeEmployee()
        {
            return (EmployesBD.getListEmployes());
        }
        public bool modifyData(Employes emp)
        {
            return (EmployesBD.modifyData(emp));
        }

        public Employes rechercheParId(int id)
        {
            return (EmployesBD.rechercheParId(id));
        }

        public List<Employes> rechercheParNom(string nom)
        {
            return (EmployesBD.rechercheParNom(nom));
        }

        public List<Employes> rechercheParPrenom(string prenom)
        {
            return (EmployesBD.rechercheParPreNom(prenom));
        }

        public List<Employes> rechercheParFonction(string fonction)
        {
            return (EmployesBD.rechercheParFonction(fonction));
        }

        public List<Employes> rechercheParNomPrenom(string nom, string prenom)
        {
            return (EmployesBD.rechercheParNomPrenom(nom, prenom));
        }
    }
}
