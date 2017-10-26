using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final.Business
{
    class Facture
    {
        int id;
        double montant;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public double Montant
        {
            get
            {
                return montant;
            }

            set
            {
                montant = value;
            }
        }
    }
}
