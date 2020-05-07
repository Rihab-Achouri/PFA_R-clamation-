using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;


namespace DAL
{
    public class Taux_service
    {
        public static int Calcul_taux_service ()
        {
          
            string requete = String.Format("select count (*) from Commande;");
            OleDbDataReader rd = utils.lire(requete);
            int nomb_commande = rd.GetInt32(0);

            string requet = String.Format("select count (*) from Reclamation;");
            OleDbDataReader A = utils.lire(requete);
            int nomb_reclamation = A.GetInt32(0);

            int taux_service = ((nomb_commande-nomb_reclamation)/nomb_commande)*100;

            utils.Disconnect();
            return taux_service;
        }
    }
}
