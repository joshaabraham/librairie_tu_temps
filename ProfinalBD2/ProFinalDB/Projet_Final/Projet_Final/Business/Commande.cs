using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final.Class
{
    class Commande
    {
        private string noCom;
        public string NoCom
        {
            get { return noCom; }
            set { noCom = value; }

        }
        private string coISBN;
        public string CoisBN
        {
            get { return coISBN; }
            set { coISBN = value; }
        }
        private string coTitre;
        public string CoTitre
        {
            get { return coTitre; }
            set { coTitre = value; }
        }
        private string coclientNo;
        public string coClientNo
        {
            get { return coclientNo; }
            set { coclientNo = value; }
        }
        private DateTime enregistrementDate;
        public DateTime EnregistrementDate
        {
            get { return enregistrementDate; }
            set {  enregistrementDate = value; }
        }

        private DateTime livraisonDate;
        public DateTime LivraisonDate
        {
            get { return livraisonDate; }
            set { livraisonDate = value; }
        }
        private int quantiteCommandee;
        public int QuantiteCommandee
        {
            get { return quantiteCommandee; }
            set { quantiteCommandee = value; }
        }
            private decimal tarifCommande;
            public decimal TarifCommande
            {
                get { return tarifCommande; }
                set { tarifCommande = value; }
            }
           
    }
}
