using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.OleDb;


namespace DAL
{
    public class CommandeDAO
    {
        public static string passer_commande(int id, int reference, int qt,  DateTime date_commande, DateTime date_livraison)
        {
            string requet = String.Format("select Prix_unitaire from Produit where Reference={0};", reference);
            OleDbDataReader x = utils.lire(requet);
            Produit c = new Produit();
            if (x.HasRows)
            {
                while (x.Read())
                {
                   
                    c.Prix_unitaire = x.GetInt32(0);

                }

            }
            utils.Disconnect();

            int num;
            int prix = qt * c.Prix_unitaire;
            string req = String.Format("select max (Num_commande) from Commande");
            OleDbDataReader rd = utils.lire(req);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    num = rd.GetInt32(0);
                    
                    string requete = String.Format("insert into Commande (Num_commande, ID_cl, Reference_produit, Qt, Prix, Date_commande, Date_livraison_souhaité,Date_livraison_réel, Etat)" +
                        " values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}');", num + 1, id, reference,qt, prix,  date_commande, date_livraison, date_livraison, "En attente");
                    utils.miseajour(requete);
                }
            }
            else
            {
                num = 0;
                string requete = String.Format("insert into Commande (Num_commande, ID_cl, Reference_produit, Qt, Prix, Date_commande, Date_livraison_souhaité,Date_livraison_réel, Etat)" +
                        " values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}');", num , id, reference, qt, prix, date_commande, date_livraison, date_livraison, "En attente");
                utils.miseajour(requete);
            }
            return ("");

        }

        public static bool Update_commande(int num, int reference_produit, int qt,  DateTime date_1, DateTime date_2)
        {
            string requet = String.Format("select Prix_unitaire from Produit where Reference={0};", reference_produit);
            OleDbDataReader x = utils.lire(requet);
            Produit c = new Produit();
            if (x.HasRows)
            {
                while (x.Read())
                {

                    c.Prix_unitaire = x.GetInt32(0);

                }

            }
            utils.Disconnect();
            int prix = qt * c.Prix_unitaire;

            string requete = String.Format("update Commande set Reference_produit='{0}', Qt='{1}',Prix ='{2}',Date_commande ='{3}'," +
                " Date_livraison_souhaité ='{4}' where Num_commande = '{5}';", reference_produit, qt, prix, date_1, date_2, num);
            return utils.miseajour(requete);
        }

        public static bool Delete_commande(int rf)
        {
            string requete = String.Format("delete from Commande where Num_commande={0};", rf);
            return utils.miseajour(requete);
        }

        public static Commande Get_commande_reference(int rf)
        {
            string requete = String.Format("select * from Commande where Num_commande={0};", rf);
            OleDbDataReader rd = utils.lire(requete);
            Commande c = new Commande();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    c.Num_commande = rd.GetInt32(0);
                    c.ID_cl = rd.GetInt32(1);
                    c.Reference_produit = rd.GetInt32(2);
                    c.Qt = rd.GetInt32(3);
                    c.Prix = rd.GetInt32(4);
                    c.Date_commande = rd.GetDateTime(5);
                    c.Date_livraison_réel = rd.GetDateTime(6);
                    c.Date_livraison_souhaité = rd.GetDateTime(7);
                    c.Etat_commande = rd.GetString(8);
                }

            }
            utils.Disconnect();
            return c;
        }

        public static List<Commande> Get_commande()
        {
            string requete = String.Format("select * from Commande;");
            OleDbDataReader rd = utils.lire(requete);
            List<Commande> L = new List<Commande>();
            Commande c;
            while (rd.Read())
            {
                c = new Commande
                {
                    Num_commande = rd.GetInt32(0),
                    ID_cl = rd.GetInt32(1),
                    Reference_produit = rd.GetInt32(2),
                    Qt = rd.GetInt32(3),
                    Prix = rd.GetInt32(4),
                    Date_commande = rd.GetDateTime(5),
                    Date_livraison_réel = rd.GetDateTime(6),
                    Date_livraison_souhaité = rd.GetDateTime(7),
                    Etat_commande= rd.GetString(8),

                };
                L.Add(c);
            }
            utils.Disconnect();
            return L;
        }
        public static List<Commande> Get_commande_id(int id)
        {
            string requete = String.Format("select * from Commande where ID_cl='{0}';",id);
            OleDbDataReader rd = utils.lire(requete);
            List<Commande> L = new List<Commande>();
            Commande c;
            while (rd.Read())
            {
                c = new Commande
                {
                    Num_commande = rd.GetInt32(0),
                    ID_cl = rd.GetInt32(1),
                    Reference_produit = rd.GetInt32(2),
                    Qt = rd.GetInt32(3),
                    Prix = rd.GetInt32(4),
                    Date_commande = rd.GetDateTime(5),
                    Date_livraison_réel = rd.GetDateTime(6),
                    Date_livraison_souhaité = rd.GetDateTime(7),
                    Etat_commande = rd.GetString(8),

                };
                L.Add(c);
            }
            utils.Disconnect();
            return L;
        }

        public static List<Commande> Get_commande_non_traitée()
        {
            string requete = String.Format("select * from Commande where Etat = 'En attente';");
            OleDbDataReader rd = utils.lire(requete);
            List<Commande> L = new List<Commande>();
            Commande c;
            while (rd.Read())
            {
                c = new Commande
                {
                    Num_commande = rd.GetInt32(0),
                    ID_cl = rd.GetInt32(1),
                    Reference_produit = rd.GetInt32(2),
                    Qt = rd.GetInt32(3),
                    Prix = rd.GetInt32(4),
                    Date_commande = rd.GetDateTime(5),
                    Date_livraison_réel = rd.GetDateTime(6),
                    Date_livraison_souhaité = rd.GetDateTime(7),
                    Etat_commande=rd.GetString(8),

                };
                L.Add(c);
            }
            utils.Disconnect();
            return L;
        }
        public static bool date_livraison(int num, DateTime date_1, string etat)
        {
            string requete = String.Format("update Commande set Date_livraison_réel ='{0}', Etat ='{1}'," +
                " where Num_commande = '{2}';", date_1,etat, num);
            return utils.miseajour(requete);
        }

    }

}
