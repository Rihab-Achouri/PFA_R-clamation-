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
    public class ActionDAO
    {
        public static bool Insert_Action(int Num, string Etat, string Description)
        {
            string requete = String.Format("insert into Action (Num, Etat, Description)" +
                " values ('{0}','{1}','{2}');", Num, Etat, Description);
            return utils.miseajour(requete);
        }

        public static bool Update_Action(int Num, string Etat, string Description)
        {
            string requete = String.Format("update Action set Etat='{0}'," +
                " Description='{1}' where Num={2};", Etat, Description, Num);
            return utils.miseajour(requete);
        }

        public static bool Delete_Action(int Num)
        {
            string requete = String.Format("delete from Action where Num={0};", Num);
            return utils.miseajour(requete);
        }

        public static Action Get_Action_Num(int Num)
        {
            string requete = String.Format("select * from Action where Num={0};", Num);
            OleDbDataReader rd = utils.lire(requete);
            Action c = new Action();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    c.Num = rd.GetInt32(0);
                    c.Etat = rd.GetString(1);                   
                    c.Description = rd.GetString(2);
                }

            }
            utils.Disconnect();
            return c;
        }

        public static List<Action> Get_Action_terminées()
        {
            string requete = String.Format("select * from Action  where Etat=='Non Traitée';");
            OleDbDataReader rd = utils.lire(requete);
            List<Action> L = new List<Action>();
            Action c;
            while (rd.Read())
            {
                c = new Action
                {
                    Num = rd.GetInt32(0),
                    Etat = rd.GetString(1),
                    Description = rd.GetString(2),
                };
                L.Add(c);
            }
            utils.Disconnect();
            return L;

        }

        public static List<Action> Get_Action_en_cour()
        {
            string requete = String.Format("select * from Action  where Etat=='en_cour';");
            OleDbDataReader rd = utils.lire(requete);
            List<Action> L = new List<Action>();
            Action c;
            while (rd.Read())
            {
                c = new Action
                {
                    Num = rd.GetInt32(0),
                    Etat = rd.GetString(1),
                    Description = rd.GetString(2),
                };
                L.Add(c);
            }
            utils.Disconnect();
            return L;

        }

        public static List<Action> Get_Action()
        {
            string requete = String.Format("select * from Action;");
            OleDbDataReader rd = utils.lire(requete);
            List<Action> L = new List<Action>();
            Action c;
            while (rd.Read())
            {
                c = new Action
                {
                    Num = rd.GetInt32(0),
                    Etat = rd.GetString(1),
                    Description = rd.GetString(5),

                };
                L.Add(c);
            }
            utils.Disconnect();
            return L;

        }
    }
}
