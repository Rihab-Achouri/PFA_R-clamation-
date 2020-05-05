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
    }
}
