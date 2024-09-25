using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessExo4Couches;
using CommonExo4Couches;
using System.Data.SqlClient;

namespace MetierExo4Couches
{
    public class GGTCATEGORIE08
    {
        string _categorieId;
        string _catDesignation;

        public string UserLogin
        {
            get { return _categorieId; }
            set { _categorieId = value; }
        }
        public string UserMotPass
        {
            get { return _catDesignation; }
            set { _catDesignation = value; }
        }

        strGGTCATEGORIE08 MyStructure
        {
            get
            {
                strGGTCATEGORIE08 st = new strGGTCATEGORIE08();
                st.categorieId = this._categorieId;
                st.catDesignation = this._catDesignation;
                
                return st;
            }
        }

        public void MapFromDataReader(IDataReader dreader)
        {
            if (!(DBNull.Value.Equals(dreader["categorieId"])))
            {
                _categorieId = (string)dreader["categorieId"];
            }
            if (!(DBNull.Value.Equals(dreader["catDesignation"])))
            {
                _catDesignation = (string)dreader["catDesignation"];
            }
            
        }

        public static DataTable SelectAll(string pUserNom)
        {
            dbGGTCATEGORIE08 undbUser = new dbGGTCATEGORIE08();
            DataTable dt = undbUser.SelectAll(pUserNom);
            return dt;
        }
        public void Insert()
        {
            dbGGTCATEGORIE08 undbuser = new dbGGTCATEGORIE08();
            undbuser.Insert(this.MyStructure);
        }
        public void Update()
        {
            dbGGTCATEGORIE08 undbUser = new dbGGTCATEGORIE08();
            undbUser.Update(this.MyStructure);
        }
        public void Supprimer(string pLogin)
        {
            dbGGTCATEGORIE08 undbUser = new dbGGTCATEGORIE08();
            undbUser.Supprimer(pLogin);
        }

        public GGTCATEGORIE08(string pLogin)
        {
            dbGGTCATEGORIE08 db = new dbGGTCATEGORIE08();
            IDataReader dreader = db.GetObject(pLogin); ;
            if (dreader.Read())
            {
                this.MapFromDataReader(dreader);
            }
            db.CloseConnexion();
        }
        public GGTCATEGORIE08()
        {
        }

    }
}
