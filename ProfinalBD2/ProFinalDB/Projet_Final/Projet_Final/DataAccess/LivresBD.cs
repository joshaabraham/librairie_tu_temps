using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projet_Final.donnees_IO
{
    class LivresBD
    {
        public static List<Livre> getListLivres()
        {
            List<Livre> lLivre = new List<Livre>();
            using (SqlConnection conn = UtilityBD.connectBD())
            {
                string query = "SELECT * FROM Produits";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Livre liv = new Livre();
                    liv.isBN = reader["ISBN"].ToString();
                    liv.Titre = reader["Titre"].ToString();
                    liv.QuantiteDispo = Convert.ToInt32(reader["LastName"]);
                    liv.PUnitaire = Convert.ToDecimal(reader["PrixU"]);
                    liv.AnneePublication = Convert.ToDateTime(reader["AnneePub"]);
                    liv.CategorieL = reader["Categorie"].ToString();
                    lLivre.Add(liv);
                }
            }



            return lLivre;
        }

    }
}
