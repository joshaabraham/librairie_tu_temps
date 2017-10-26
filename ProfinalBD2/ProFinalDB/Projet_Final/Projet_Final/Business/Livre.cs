using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final
{
    class Livre
    {
        //Chaque livre : 
        //  - ISBN
        //  - titre
        //  - prix unitaire
        //  - année publiée
        //  - quantité disponible
        //  - catégorie

        private string ISBN;
        public string isBN
        {
            get { return ISBN; }
            set { ISBN = value; }
        }

        private string titre;
        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }

        private decimal pUnitaire;
        public decimal PUnitaire
        {
            get { return pUnitaire; }
            set { pUnitaire = value; }
        }

        private DateTime anneePublication;
        public DateTime AnneePublication
        {
            get { return anneePublication; }
            set { anneePublication = value; }

        }

        private int quantiteDispo;
        public int QuantiteDispo 
        {
            get { return quantiteDispo; }
            set { quantiteDispo = value; }
        }

        private string categorieL;
        public string CategorieL
        {
            get { return categorieL; }
            set { categorieL = value; }
        }
        private string editeur;
        public string Editeur
        {
            get { return editeur; }
            set { editeur = value; }
        }
        private string auteurNom;
            public string AuteurNom
            {
                get {return auteurNom;}
                set{auteurNom = value;}
            }

            private string auteurPrenom;
            public string AuteurPrenom
            {
                get { return auteurPrenom; }
                set { auteurPrenom = value; }
            }
            private string auteurGNom;
            public string AuteurGnom
            {
                get { return auteurGNom; }
                set { auteurGNom = value; }
            }

    }
}
