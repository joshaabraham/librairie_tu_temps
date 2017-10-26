using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Projet_Final.donnees_IO
{
    class UtilityBD
    {
        
        public static SqlConnection connectBD()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["HighTechConnection"].ConnectionString;

            con.Open();

            return con;
        }

    }
}
