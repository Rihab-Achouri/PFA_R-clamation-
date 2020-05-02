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
    public class patientDAO
    {
        

      
        
        public static OleDbDataAdapter oledbAdapter;
        public static OleDbConnection cn;
        public static OleDbCommand cmd;
        public static OleDbDataReader rd;



        
        public static bool Insert_patient(int id, string nom, string prenom, int tel)
        {
            string requete = String.Format("insert into Patient(ID, Nom,Prenom,Tel)" +
                " values ('{0}','{1}','{2}','{3}');", id, nom,prenom,tel);
            return utils.miseajour(requete);
        }

        public static bool Update_patient(int id,  string nom, string prenom, int tel)
        {
            string requete = String.Format("update Patient set nom='{0}', prenom='{1}'," +
                " tel='{2}' where ID={3};", nom, prenom, tel, id);
            return utils.miseajour(requete);
        }

        public static bool Delete_patient(int id)
        {
            string requete = String.Format("delete from Patient where ID={0};", id);
            return utils.miseajour(requete);
        }

        public static Patient Get_patient_ID(int id)
        {
            string requete = String.Format("select * from Patient where ID={0};", id);
            OleDbDataReader rd = utils.lire(requete);
            Patient c = new Patient();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    c.ID = rd.GetInt32(0);

                    c.Prenom = rd.GetString(1);
                    c.Nom = rd.GetString(2);
                    c.Tel = rd.GetInt32(3);
                    
                }
                
            }
            utils.Disconnect();
            return c;
        }

    }
}
