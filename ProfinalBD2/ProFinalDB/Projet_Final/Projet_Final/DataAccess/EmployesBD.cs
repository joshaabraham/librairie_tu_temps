using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projet_Final.Class;
using Projet_Final.donnees_IO;

namespace Projet_Final.donnees_IO
{
    class EmployesBD
    {
        public static List<Employes> getListEmployes()
        {
            List<Employes> lEmployes = new List<Employes>();
            using (SqlConnection conn = UtilityBD.connectBD())
            {
                string query = "SELECT * FROM Employes";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Employes emp = new Employes();
                    emp.NoIdentifiant = Convert.ToInt32(reader["EmployeId"]);
                    emp.MPasse = reader["EmployeMDP"].ToString();
                    emp.NomUtil = reader["EmployeNom"].ToString();
                    emp.PrenomAdmin = reader["EmployePrenom"].ToString();
                    emp.Categorie = reader["EmployeFonction"].ToString();
                    
     
                    lEmployes.Add(emp);
                }
            }

            return lEmployes;
        }

        public static bool InsertData(Employes emp)
        {
            using (SqlConnection con = UtilityBD.connectBD())
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;

                sqlCmd.Parameters.Add("@EmployeeId", emp.NoIdentifiant);
                sqlCmd.Parameters.Add("@EmployeMDP", emp.MPasse);
                sqlCmd.Parameters.Add("@EmployePrenom", emp.PrenomAdmin);
                sqlCmd.Parameters.Add("@EmployeNom", emp.NomUtil);
                sqlCmd.Parameters.Add("@EmployeFonction", emp.Categorie);

                sqlCmd.CommandText = "INSERT INTO Employes VALUES (@EmployeeId,@EmployeMDP,@EmployePrenom,@EmployeNom,@EmployeFonction)";


                return (Convert.ToBoolean(sqlCmd.ExecuteNonQuery()));
            }

        }
        
        public static bool modifyData(Employes emp)
        {
                 using (SqlConnection con =  UtilityBD.connectBD())
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;

                sqlCmd.Parameters.Add("@EmployeId", emp.NoIdentifiant);
                sqlCmd.Parameters.Add("@EmployePrenom", emp.PrenomAdmin);
                sqlCmd.Parameters.Add("@EmployeNom", emp.NomUtil);
                sqlCmd.Parameters.Add("@EmployeFonction", emp.Categorie);
                sqlCmd.Parameters.Add("@EmployeMDP", emp.MPasse);

                sqlCmd.CommandText = string.Format("UPDATE Employes SET EmployePrenom = @EmployePrenom, EmployeNom = @EmployeNom, EmployeFonction = @EmployeFonction, EmployeMDP = @EmployeMDP WHERE EmployeId = @EmployeId ;");                
                 
                
                return (Convert.ToBoolean(sqlCmd.ExecuteNonQuery()));
            }
        }

        public static bool DeleteData(Employes emp)
        {
            using (SqlConnection con = UtilityBD.connectBD())
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;

                sqlCmd.Parameters.Add("@EmployeId", emp.NoIdentifiant);

                sqlCmd.CommandText = string.Format("DELETE FROM Employes WHERE EmployeId = @EmployeId ;");

                return (Convert.ToBoolean(sqlCmd.ExecuteNonQuery()));
            }
              
        }

        public static Employes rechercheParId(int id)
        {
            Employes emp = new Employes();
            using (SqlConnection conn = UtilityBD.connectBD())
            {
                string query = "SELECT * FROM Employes WHERE EmployeId="+id+";";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                { 
                    SqlDataReader reader = cmd.ExecuteReader();
                     while (reader.Read())
                    {
                    
                    emp.NoIdentifiant = Convert.ToInt32(reader["EmployeId"]);
                    emp.MPasse = reader["EmployeMDP"].ToString();
                    emp.NomUtil = reader["EmployeNom"].ToString();
                    emp.PrenomAdmin = reader["EmployePrenom"].ToString();
                    emp.Categorie = reader["EmployeFonction"].ToString();

                    }
                         return emp;
                }
                catch (Exception ex)
                {
                    
                    return null;
                    
                }
               
                
            }
           
        }

        public static List<Employes> rechercheParNom(string nom)
        {
            List<Employes> lEmployes = new List<Employes>();
            using (SqlConnection conn = UtilityBD.connectBD())
            {
                string query = "SELECT * FROM Employes WHERE EmployeNom = '" + nom+"';";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Employes emp = new Employes();
                    emp.NoIdentifiant = Convert.ToInt32(reader["EmployeId"]);
                    emp.MPasse = reader["EmployeMDP"].ToString();
                    emp.NomUtil = reader["EmployeNom"].ToString();
                    emp.PrenomAdmin = reader["EmployePrenom"].ToString();
                    emp.Categorie = reader["EmployeFonction"].ToString();


                    lEmployes.Add(emp);
                }
            }

            return lEmployes;
        }

        public static List<Employes> rechercheParPreNom(string prenom)
        {
            List<Employes> lEmployes = new List<Employes>();
            using (SqlConnection conn = UtilityBD.connectBD())
            {
                string query = "SELECT * FROM Employes WHERE EmployePrenom = '" + prenom + "';";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Employes emp = new Employes();
                    emp.NoIdentifiant = Convert.ToInt32(reader["EmployeId"]);
                    emp.MPasse = reader["EmployeMDP"].ToString();
                    emp.NomUtil = reader["EmployeNom"].ToString();
                    emp.PrenomAdmin = reader["EmployePrenom"].ToString();
                    emp.Categorie = reader["EmployeFonction"].ToString();


                    lEmployes.Add(emp);
                }
            }

            return lEmployes;
        }

        public static List<Employes> rechercheParFonction(string fonction)
        {
            List<Employes> lEmployes = new List<Employes>();
            using (SqlConnection conn = UtilityBD.connectBD())
            {
                string query = "SELECT * FROM Employes WHERE EmployeFonction = '" + fonction + "';";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Employes emp = new Employes();
                    emp.NoIdentifiant = Convert.ToInt32(reader["EmployeId"]);
                    emp.MPasse = reader["EmployeMDP"].ToString();
                    emp.NomUtil = reader["EmployeNom"].ToString();
                    emp.PrenomAdmin = reader["EmployePrenom"].ToString();
                    emp.Categorie = reader["EmployeFonction"].ToString();


                    lEmployes.Add(emp);
                }
            }

            return lEmployes;
        }

        public static List<Employes> rechercheParNomPrenom(string nom, string prenom)
        {
            List<Employes> lEmployes = new List<Employes>();
            using (SqlConnection conn = UtilityBD.connectBD())
            {
                string query = "SELECT * FROM Employes WHERE EmployeNom = '" + nom + "' AND EmployePrenom = '"+prenom+"';";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Employes emp = new Employes();
                    emp.NoIdentifiant = Convert.ToInt32(reader["EmployeId"]);
                    emp.MPasse = reader["EmployeMDP"].ToString();
                    emp.NomUtil = reader["EmployeNom"].ToString();
                    emp.PrenomAdmin = reader["EmployePrenom"].ToString();
                    emp.Categorie = reader["EmployeFonction"].ToString();


                    lEmployes.Add(emp);
                }
            }

            return lEmployes;
        }

        public static Employes UtilTrouve(int empId, string password)
        {
            SqlConnection con = UtilityBD.connectBD();
            SqlCommand sqlCmd = new SqlCommand();

            Employes emp = new Employes();
            emp.NoIdentifiant = empId;
            emp.MPasse = password;

            sqlCmd.Parameters.Add("@EmployeId", emp.NoIdentifiant);
            sqlCmd.Parameters.Add("@EmployeMDP", emp.MPasse);


            sqlCmd.Connection = con;
            sqlCmd.CommandText = "SELECT * FROM Employes WHERE EmployeId = @EmployeId AND EmployeMDP = @EmployeMDP ";
            

            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            
            while (sqlReader.Read())
            {

                emp.NoIdentifiant = Convert.ToInt32(sqlReader["EmployeId"]);
                emp.MPasse = Convert.ToString(sqlReader["EmployeMDP"]);
                emp.PrenomAdmin = Convert.ToString(sqlReader["EmployePrenom"]);
                emp.NomUtil = Convert.ToString(sqlReader["EmployeNom"]);
                emp.Categorie = Convert.ToString(sqlReader["EmployeFonction"]);
                return emp;
            }

            return null;

        }

    }
}
