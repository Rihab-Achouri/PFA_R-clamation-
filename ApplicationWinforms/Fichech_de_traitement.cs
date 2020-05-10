using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BEL;
using System.Data.OleDb;

namespace ApplicationWinforms
{
    public partial class Fiche_de_traitement : Form
    {
        public Fiche_de_traitement()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Acceuil f1 = new Acceuil();
            f1.ShowDialog();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
