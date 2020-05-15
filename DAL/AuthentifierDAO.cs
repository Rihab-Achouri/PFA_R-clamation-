using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.OleDb;

namespace DAL
{
    public class AuthentifierDAO
    {
        public static Authentifier authentifier (string login, int mot, string user)
        {
            string requete = String.Format("select * from Authentification where Login={0} and Mot_de_passe={1} and User={2};", login, mot,user);
            OleDbDataReader rd = utils.lire(requete);
            Authentifier A = new Authentifier();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    A.Login = rd.GetString(0);
                    A.Mot_de_passe = rd.GetInt32(1);
                    A.User = rd.GetString(2);
                    
                }

            }
            utils.Disconnect();
            return A;
        }
    }
}
