using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.OleDb;


namespace DAL
{
    public class rdvDAO
    {
        public static bool Insert_rdv (string date, int numrdv,int nump)
        {
            string requete = String.Format("insert into RDV (Daterdv, Numrdv,idPersonne)" +
                " values ('{0}','{1}','{2}');",date, numrdv,nump);
            return utils.miseajour(requete);
        }
        public static bool Update_rdv(int numrdv,  string date)
       {
           string requete = String.Format("update RDV set Daterdv='{0}' where Numrdv={1};", date, numrdv);
            return utils.miseajour(requete);
        }
      

        public static bool Delete_rdv(int num)
        {
            string requete = String.Format("delete from RDV where Numrdv={0};",num);
            return utils.miseajour(requete);
        }

        public static void Insert_rdv(int numrdv)
        {
            throw new NotImplementedException();
        }

        public static void Insert_rdv(DateTime daterdv)
        {
            throw new NotImplementedException();
        }

     //public static void Insert_rdv(int nump)
     //{
           // throw new NotImplementedException();
       // } 

        public static Rendezvous Get_rdv(int num)
        {
            string requete = String.Format("select * from RDV where Numrdv={0};", num);
            OleDbDataReader rd = utils.lire(requete);
            Rendezvous c = new Rendezvous();
            while (rd.Read())
            {
                c.Numrdv = rd.GetInt32(0);
                c.Daterdv =rd.GetString(1);
                c.idPersonne= rd.GetInt32(2);
                
            }
            utils.Disconnect();
            return c;
    
       }
        public static List<Rendezvous> Get_rdvs()
        {
            string requete = String.Format("select * from RDV;");
            OleDbDataReader rd = utils.lire(requete);
            List<Rendezvous> L = new List<Rendezvous>();
            Rendezvous c;
            while (rd.Read())
            {
                c = new Rendezvous
                {
                    Daterdv = rd.GetString(0),
                    Numrdv = rd.GetInt32(1),
                    idPersonne = rd.GetInt32(2),
                   

    };
                L.Add(c);
            }
            utils.Disconnect();
            return L;
        }


    }

}
