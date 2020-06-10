using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using BEL;
using System.Data.OleDb;

namespace DAL
{
    public class SuggestionDAO
    {
        public static Suggestion Get_suggestion_id_cl(int id)
        {
            string requete = String.Format("select * from Suggestion where Id_client ={0};", id);
            OleDbDataReader rd = utils.lire(requete);
            Suggestion s = new Suggestion();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    s.Id_client = rd.GetInt32(0);
                    s.Message = rd.GetString(1);

                }

            }
            utils.Disconnect();
            return s;
        }

        public static List<Suggestion> Get_suggestion()
        {
            string requete = String.Format("select * from Suggestion;");
            OleDbDataReader rd = utils.lire(requete);
            List<Suggestion> L = new List<Suggestion>();
            Suggestion s;
            while (rd.Read())
            {
                s = new Suggestion
                {
                    Id_client = rd.GetInt32(0),
                    Message = rd.GetString(1),
                   

                };
                L.Add(s);
            }
            utils.Disconnect();
            return L;

        }
    }
}