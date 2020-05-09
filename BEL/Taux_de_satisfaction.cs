using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BEL
{
    public class Taux_de_satisfaction
    {
        public int ID_cl { get; set; }
        public string Taux_satisfaction_log{ get; set; }
        public string Taux_satisfaction_qualité { get; set; }
        
    }

    public class Client2
    {
        public int Num2 { get; set; }
        public string Reclamation2 { get; set; }
    }
}