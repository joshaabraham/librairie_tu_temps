using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final
{
    class Auteur
    {

        //INFORMATION AUTEUR : 
        //  - auteur ID (pour l'identification dans les cas les auteurs portent le même nom)
        //  - prénom
        //  - nom
        //  - courriel

        private int auteurID;
        public int AuteurID
        {
            get { return auteurID; }
            set { auteurID = value; }
            
        }
        private string auteurPrenom;
        public string AuteurIPrenom
        {
            
            get { return auteurPrenom; }
            set { auteurPrenom = value; }
        }
        private string auteurNom;
        public string AuteurNom
        {
            get { return auteurNom; }
            set { auteurNom = value; }
        }
        private string auteurCourriel;
        public string AuteurCourriel
        {
            get { return auteurCourriel; }
            set { auteurCourriel = value; }
        }

    }
}
