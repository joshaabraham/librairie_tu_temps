using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projet_Final.donnees_IO
{
    class AuteursBD
    {
        public static List<Auteur> getListAuteur()
        {
            List<Auteur> lAuteur = new List<Auteur>();
            using (SqlConnection conn = UtilityBD.connectBD())
            {
                string query = "SELECT * FROM Auteurs";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Auteur aut = new Auteur();
                    aut.AuteurID = Convert.ToInt32(reader["AuteurId"]);
                    aut.AuteurIPrenom = reader["AuteurPrenom"].ToString();
                    aut.AuteurNom = reader["AuteurNom"].ToString();
                    aut.AuteurCourriel = reader["AuteurCourriel"].ToString();
                  
                    lAuteur.Add(aut);
                }
            }



            return lAuteur;
        }

    }
}
