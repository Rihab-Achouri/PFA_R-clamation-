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
    public class ProduitDAO
    {

        public static bool Insert_produit(int RF, string nom, int qt,int prix)
        {
            string requete = String.Format("insert into Produit (Reference,Nom, Qt_stock, Prix_unitaire)" +
                " values ('{0}','{1}','{2}','{3}');", RF, nom, qt, prix);
            return utils.miseajour(requete);
        }

        public static bool Update_produit(int RF,string nom, int qt, int prix)
        {
            string requete = String.Format("update Produit set Nom= '{0}', Qt_stock='{1}', Prix_unitaire='{2}'" +
                " where Reference={3};", nom, qt, prix, RF);
            return utils.miseajour(requete);
        }

        public static bool Delete_produit(int RF)
        {
            string requete = String.Format("delete from Produit where Reference={0};", RF);
            return utils.miseajour(requete);
        }

        public static Produit Get_produit_reference(int RF)
        {
            string requete = String.Format("select * from Produit where Reference={0};", RF);
            OleDbDataReader rd = utils.lire(requete);
            Produit c = new Produit();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    c.Reference = rd.GetInt32(0);
                    c.Nom_produit = rd.GetString(1);
                    c.Qt_stock = rd.GetInt32(2);
                    c.Prix_unitaire = rd.GetInt32(3);

                }

            }
            utils.Disconnect();
            return c;
        }

        public static List<Produit> Get_produit()
        {
            string requete = String.Format("select * from Produit;");
            OleDbDataReader rd = utils.lire(requete);
            List<Produit> L = new List<Produit>();
            Produit c;
            while (rd.Read())
            {
                c = new Produit
                {
                    Reference = rd.GetInt32(0),
                    Nom_produit=rd.GetString(1),
                    Qt_stock = rd.GetInt32(2),
                    Prix_unitaire = rd.GetInt32(3),

                };
                L.Add(c);
            }
            utils.Disconnect();
            return L;

        }
    }
}
