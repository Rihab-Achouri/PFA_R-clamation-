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
    public class Action_reclamationDAO
    {
        public static bool Insert_action(int num, string etat, string description,string resultat,int occurence, string localisation,DateTime date_traitemant, DateTime date_apparition)
        {
            string requete = String.Format("insert into Fiche values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');", num, etat, description, resultat,occurence,localisation,date_traitemant,date_apparition);
            return utils.miseajour(requete);
        }

        public static bool Update_Action(int Num, string Etat, string Description, string resulta, int occurence, string locatisation, DateTime date_traitement, DateTime date_apparition)
        {
            string requete = String.Format("update Fiche set Etat='{0}', Description='{1}', Resultat_tri_securisation='{2}', Occurrence_probleme='{3}', Localisation_defaut='{4}', Debut_traitement='{5}', Date_apparition_défaut='{6}'" +
                " where Num={7};", Etat, Description, resulta, occurence, locatisation, date_traitement, date_apparition, Num);
            return utils.miseajour(requete);
        }

        public static bool Delete_Action(int Num)
        {
            string requete = String.Format("delete from Fiche where Num={0};", Num);
            return utils.miseajour(requete);
        }

        public static Action_reclamation Get_Action_Num(int Num)
        {
            string requete = String.Format("select * from Fiche where Num={0};", Num);
            OleDbDataReader rd = utils.lire(requete);
            Action_reclamation c = new Action_reclamation();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    c.Num = rd.GetInt32(0);
                    c.Etat = rd.GetString(1);                   
                    c.Description = rd.GetString(2);
                    c.Resultat_tri_securisation = rd.GetString(3);
                    c.Occurrence_probleme = rd.GetInt32(4);
                    c.Localisation_defaut = rd.GetString(5);
                    c.Début_traitement = rd.GetDateTime(6);
                    c.Date_apparition_défaut = rd.GetDateTime(7);
                }

            }
            utils.Disconnect();
            return c;
        }

        public static List<Action_reclamation> Get_Action_terminées()
        {
            string requete = String.Format("select * from Fiche  where Etat='Non Traitée';");
            OleDbDataReader rd = utils.lire(requete);
            List<Action_reclamation> L = new List<Action_reclamation>();
            Action_reclamation c;
            while (rd.Read())
            {
                c = new Action_reclamation
                {
                    Num = rd.GetInt32(0),
                    Etat = rd.GetString(1),
                    Description = rd.GetString(2),
                    Resultat_tri_securisation = rd.GetString(3),
                    Occurrence_probleme = rd.GetInt32(4),
                    Localisation_defaut = rd.GetString(5),
                    Début_traitement = rd.GetDateTime(6),
                    Date_apparition_défaut = rd.GetDateTime(7),
                };
                L.Add(c);
            }
            utils.Disconnect();
            return L;

        }

        public static List<Action_reclamation> Get_Action_en_cour()
        {
            string requete = String.Format("select * from Fiche  where Etat='en cours';");
            OleDbDataReader rd = utils.lire(requete);
            List<Action_reclamation> L = new List<Action_reclamation>();
            Action_reclamation c;
            while (rd.Read())
            {
                c = new Action_reclamation
                {
                    Num = rd.GetInt32(0),
                    Etat = rd.GetString(1),
                    Description = rd.GetString(2),
                    Resultat_tri_securisation = rd.GetString(3),
                    Occurrence_probleme = rd.GetInt32(4),
                    Localisation_defaut = rd.GetString(5),
                    Début_traitement = rd.GetDateTime(6),
                    Date_apparition_défaut = rd.GetDateTime(7),
                };
                L.Add(c);
            }
            utils.Disconnect();
            return L;

        }

        public static List<Action_reclamation> Get_Action()
        {
            string requete = String.Format("select * from Fiche;");
            OleDbDataReader rd = utils.lire(requete);
            List<Action_reclamation> L = new List<Action_reclamation>();
            Action_reclamation c;
            while (rd.Read())
            {
                c = new Action_reclamation
                {
                    Num = rd.GetInt32(0),
                    Etat = rd.GetString(1),
                    Description = rd.GetString(2),
                    Resultat_tri_securisation = rd.GetString(3),
                    Occurrence_probleme = rd.GetInt32(4),
                    Localisation_defaut = rd.GetString(5),
                    Début_traitement = rd.GetDateTime(6),
                    Date_apparition_défaut = rd.GetDateTime(7),

                };
                L.Add(c);
            }
            utils.Disconnect();
            return L;

        }
    }
}
