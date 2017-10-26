using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projet_Final.Class;

namespace Projet_Final.donnees_IO
{
    class ClientsBD
    {
        public static List<Client> getListClient()
        {
            List<Client> lClient = new List<Client>();
            using (SqlConnection conn = UtilityBD.connectBD())
            {
                string query = "SELECT * FROM Clients";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Client cl = new Client();
                    cl.ClientNo = reader["ClientId"].ToString();
                    cl.ClientNom = reader["ClientNom"].ToString();

                    cl.ClientRue = reader["ClientRue"].ToString();
                    cl.ClientVille = reader["ClientVille"].ToString();
                    cl.ClientCP = reader["ClientCP"].ToString();
                    cl.ClientNTel = reader["ClientTelephone"].ToString();
                    cl.ClientTelecopieur = reader["ClientTelecopieur"].ToString();
                    cl.ClientCeditLim = Convert.ToDecimal(reader["ClientLimiteCredit"]);
                    

                    lClient.Add(cl);
                }
            }
            return lClient;
        }

        public static bool SaveData(Client cli)
        {
            using (SqlConnection con = UtilityBD.connectBD())
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;

                sqlCmd.Parameters.Add("@ClientId", cli.ClientNo);
                sqlCmd.Parameters.Add("@ClientNom", cli.ClientNom);
                sqlCmd.Parameters.Add("@ClientRue", cli.ClientRue);
                sqlCmd.Parameters.Add("@ClientVille", cli.ClientVille);
                sqlCmd.Parameters.Add("@ClientCP", cli.ClientCP);
                sqlCmd.Parameters.Add("@ClientTelephone", cli.ClientNTel);
                sqlCmd.Parameters.Add("@ClientTelecopieur", cli.ClientTelecopieur);
                sqlCmd.Parameters.Add("@ClientLimiteCredit", cli.ClientCeditLim);

                sqlCmd.CommandText = string.Format("INSERT INTO Clients VALUE (@ClientId, @ClientNom, @ClientRue, @ClientVille, @ClientCP, @ClientTelephone, @ClientTelecopieur, @ClientLimiteCredit ) ;");


                return (Convert.ToBoolean(sqlCmd.ExecuteNonQuery()));
            }
        }
        public static bool DeleteData(Client cli)
        {
            using (SqlConnection con = UtilityBD.connectBD())
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;

                sqlCmd.Parameters.Add("@ClientId", cli.ClientNo);
                sqlCmd.Parameters.Add("@ClientNom", cli.ClientNom);
                sqlCmd.Parameters.Add("@ClientRue", cli.ClientRue);
                sqlCmd.Parameters.Add("@ClientVille", cli.ClientVille);
                sqlCmd.Parameters.Add("@ClientCP", cli.ClientCP);
                sqlCmd.Parameters.Add("@ClientTelephone", cli.ClientNTel);
                sqlCmd.Parameters.Add("@ClientTelecopieur", cli.ClientTelecopieur);
                sqlCmd.Parameters.Add("@ClientLimiteCredit", cli.ClientCeditLim);

                sqlCmd.CommandText = string.Format(" DELETE FROM Clients WHERE ClientId = @ClientId ;");


                return (Convert.ToBoolean(sqlCmd.ExecuteNonQuery()));
            }

        }
        public static bool ModifyData(Client cli)
        {
            using (SqlConnection con = UtilityBD.connectBD())
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;

                sqlCmd.Parameters.Add("@ClientId", cli.ClientNo);
                sqlCmd.Parameters.Add("@ClientNom", cli.ClientNom);
                sqlCmd.Parameters.Add("@ClientRue", cli.ClientRue);
                sqlCmd.Parameters.Add("@ClientVille", cli.ClientVille);
                sqlCmd.Parameters.Add("@ClientCP", cli.ClientCP);
                sqlCmd.Parameters.Add("@ClientTelephone", cli.ClientNTel);
                sqlCmd.Parameters.Add("@ClientTelecopieur", cli.ClientTelecopieur);
                sqlCmd.Parameters.Add("@ClientLimiteCredit", cli.ClientCeditLim);

                sqlCmd.CommandText = string.Format("UPDATE Clients SET ClientNom = @ClientNom, ClientRue = @ClientRue, ClientVille = @ClientVille, ClientCP = @ClientCP, ClientTelephone = @ClientTelephone, ClientTelecopieur = @ClientTelecopieur, ClientLimiteCredit = @ClientLimiteCredit WHERE ClientId = @ClientId ;");


                return (Convert.ToBoolean(sqlCmd.ExecuteNonQuery()));
            }

        }
    }
}
