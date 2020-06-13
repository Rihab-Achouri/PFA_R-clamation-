using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using BEL;

namespace DAL
{
    public class Taux_satisfactionDAO
    {
        public static bool Insert_Taux_satisfaction(int id, string log, string qualité)
        {
            string requete = String.Format("insert into Taux_satisfaction (ID_cl, Taux_satisfaction_log, Taux_satisfaction_qualité)" +
                " values ('{0}','{1}','{2}');", id, log, qualité);
            return utils.miseajour(requete);
        }
        public static bool Update_Taux_satisfaction(int id, string log, string qualité)
        {
            string requete = String.Format("update Taux_satisfactiont set Taux_satisfaction_log='{0}', Taux_satisfaction_qualité='{1}'," +
                " where ID_cl={2};", log, qualité, id);
            return utils.miseajour(requete);
        }

        public static List<Taux_de_satisfaction> Get()
        {
            string requete = String.Format("select * from Taux_satisfaction ;");
            OleDbDataReader rd = utils.lire(requete);
            List<Taux_de_satisfaction> L = new List<Taux_de_satisfaction>();
            Taux_de_satisfaction c;
            while (rd.Read())
            {
                c = new Taux_de_satisfaction
                {
                    ID_cl = rd.GetInt32(0),
                    Taux_satisfaction_log = rd.GetString(1),
                    Taux_satisfaction_qualité = rd.GetString(2),

                };
                L.Add(c);
            }
            utils.Disconnect();
            return L;
        }

        public static Taux_de_satisfaction Get_ID(int id)
        {
              string requete = String.Format("select * from Taux_satisfaction where ID_cl={0};", id);
              OleDbDataReader rd = utils.lire(requete);
              Taux_de_satisfaction c = new Taux_de_satisfaction();
              if (rd.HasRows)
              {
                    while (rd.Read())
                    {
                        c.ID_cl = rd.GetInt32(0);
                        c.Taux_satisfaction_log = rd.GetString(1);
                        c.Taux_satisfaction_qualité = rd.GetString(2);;
                    }

              }
                utils.Disconnect();
                return c;
        }

        public static int count_log (string taux)
        {
            string requete = String.Format("select count(*) from Taux_satisfaction where Taux_satisfaction_log='{0}';", taux);
            OleDbDataReader rd = utils.lire(requete);
            int c = new int();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    c = rd.GetInt32(0);
                    
                }

            }
            utils.Disconnect();
            return c;
        }
        public static int count_qualité(string taux)
        {
            string requete = String.Format("select count(*) from Taux_satisfaction where Taux_satisfaction_qualité='{0}';", taux);
            OleDbDataReader rd = utils.lire(requete);
            int c = new int();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    c = rd.GetInt32(0);

                }

            }
            utils.Disconnect();
            return c;
        }
    }
}
