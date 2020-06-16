using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Action_reclamation
    {
        public int Num { get; set; }
        public string Etat { get; set; }
        public string Description { get; set; }
        public string Resultat_tri_securisation { get; set; }
        public int Occurrence_probleme { get; set; }
        public string Localisation_defaut { get; set; }
        public DateTime Début_traitement { get; set; }
        public DateTime Date_apparition_défaut { get; set; }
    }

}
