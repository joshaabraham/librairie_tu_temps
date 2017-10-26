using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projet_Final.Class;

namespace Projet_Final.donnees_IO
{
    class CommandeBD
    {
        public static List<Commande> getListCommande()
        {
            List<Commande> lCommande = new List<Commande>();
            using (SqlConnection conn = UtilityBD.connectBD())
            {
                string query = "SELECT * FROM Commande";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    /*
                    */
                 
                }
            }

            return lCommande;
        }

     
    }
}
