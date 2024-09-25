using MetierExo4Couches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGTexo4Couches
{
    public class Divers
    {
        public static Boolean ExisteUtilisateur(string pCode)
        {
            GGTCATEGORIE08 unUser = new GGTCATEGORIE08(pCode);
            if (unUser.UserLogin == null)
            {
                return false;
            }
            else
            {
                if (unUser.UserLogin.ToUpper() == pCode.ToUpper())
                {
                    return true;
                }
                return false;
            }
        }

    }
}
