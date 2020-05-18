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
        public static Authentifier verif(string login, string passe, string user)
        {
            string requete = string.Format("select Login,Mot_de_passe,User from Authentification where Login ='{0}'and Mot_de_passe='{1}'and User='{2}';", login, passe, user);
            OleDbDataReader rd = utils.lire(requete);
            Authentifier A = new Authentifier();
            A.Login = "";

            while (rd.Read())
            {
                A.Login = rd.GetString(0);
                A.Mot_de_passe = rd.GetString(1);
                A.User = rd.GetString(2);
            }
            utils.Disconnect();
            return A;

        }
    }
    
}
