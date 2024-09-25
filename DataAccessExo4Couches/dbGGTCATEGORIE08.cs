using System;
using System.Data;
using System.Data.SqlClient;

using CommonExo4Couches;
namespace DataAccessExo4Couches
{
    public class dbGGTCATEGORIE08
    {
        SqlConnection SqlConX = null;
        //Méthode de fermeture de la connexion à la BD
        public void CloseConnexion()
        {
            if ((SqlConX != null) && SqlConX.State == ConnectionState.Open)
            {
                SqlConX.Close();
            }
        }

        public DataTable SelectAll(string pUserNom)
        {
            SqlConX = mUtilities.maDBConnection();
            SqlConX.Open();
            SqlCommand cmd = new SqlCommand("SPX_GGTCATEGORIE08_SelectAll", SqlConX);
            cmd.CommandType = CommandType.StoredProcedure;
            //Ajout des paramètres
            SqlParameter prm;
            prm = new SqlParameter("@catDesignation", SqlDbType.VarChar, 10);
            prm.Value = pUserNom;
            cmd.Parameters.Add(prm);
            

            //récupération des données
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //Remplissage du datatable
            da.Fill(dt);
            //Fermer la connexion
            CloseConnexion();
            return dt;
        }

        public string Insert(strGGTCATEGORIE08 pUser)
        {
            try
            {
                SqlConX = mUtilities.maDBConnection();
                SqlConX.Open();
                SqlCommand cmd = new SqlCommand("SPX_GGTCATEGORIE08_insert", SqlConX);
                cmd.CommandType = CommandType.StoredProcedure;
                //Ajout des paramètres
                SqlParameter prm;
                prm = new SqlParameter("@categorieId", SqlDbType.VarChar, 10);
                prm.Value = pUser.categorieId;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@catDesignation", SqlDbType.VarChar, 10);
                prm.Value = pUser.catDesignation;
                cmd.Parameters.Add(prm);
                
                string res = (string)cmd.ExecuteScalar();
                CloseConnexion();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Update(strGGTCATEGORIE08 pUser)
        {
            try
            {
                SqlConX = mUtilities.maDBConnection();
                SqlConX.Open();
                SqlCommand cmd = new SqlCommand("SPX_GGTCATEGORIE08_Update", SqlConX);
                cmd.CommandType = CommandType.StoredProcedure;
                //Ajout des paramètres
                SqlParameter prm;
                prm = new SqlParameter("@categorieId", SqlDbType.VarChar, 10);
                prm.Value = pUser.categorieId;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@catDesignation", SqlDbType.VarChar, 10);
                prm.Value = pUser.catDesignation;
                cmd.Parameters.Add(prm);
                
                string res = (string)cmd.ExecuteScalar();
                CloseConnexion();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IDataReader GetObject(string pLogin)
        {
            IDataReader dr = null;
            //Définition de la chaine de connexion
            SqlConX = mUtilities.maDBConnection();
            SqlConX.Open();
            //Commande
            SqlCommand cmd = new SqlCommand("SPX_GGTCATEGORIE08_Get", SqlConX);
            cmd.CommandType = CommandType.StoredProcedure;
            //Paramètres
            SqlParameter prm;
            prm = new SqlParameter("@categorieId", SqlDbType.VarChar, 10);
            prm.Value = pLogin;
            cmd.Parameters.Add(prm);
            dr = cmd.ExecuteReader();
            return dr;
        }

        public string Supprimer(string pLogin)
        {
            try
            {
                //Définition de la chaine de connexion
                SqlConX = mUtilities.maDBConnection();
                SqlConX.Open();
                SqlCommand cmd = new SqlCommand("SPX_GGTCATEGORIE08_Delete", SqlConX);
                cmd.CommandType = CommandType.StoredProcedure;
                //Ajout des paramètres
                SqlParameter prm;
                prm = new SqlParameter("@categorieId", SqlDbType.VarChar, 20);
                prm.Value = pLogin;
                cmd.Parameters.Add(prm);
                string res = (string)cmd.ExecuteScalar();
                SqlConX.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
