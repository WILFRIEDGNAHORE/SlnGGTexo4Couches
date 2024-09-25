using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CommonExo4Couches
{

    public struct strGGTCATEGORIE08
    {
        public string categorieId;
        public string catDesignation;

    }
    public class mUtilities
    {
        public static SqlConnection maDBConnection()
        {
            //définition de la chaine de connexion
            string conxstr = @"Data Source=(local);Initial Catalog=bdExo4Couches;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            SqlConnection conX = new SqlConnection(conxstr);
            return conX;
        }
    }

}
