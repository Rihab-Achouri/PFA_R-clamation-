using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BEL;
using System.Data.OleDb;

namespace ApplicationWinforms
{
    public partial class Suggestion_Taux_satisfaction : Form
    {
        public Suggestion_Taux_satisfaction()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string requete = String.Format("insert into suggestion (id_client, Message) values ('{0}','{1}');", int.Parse(textBox1.Text), richTextBox1.Text);
            utils.miseajour(requete);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            richTextBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Acceuil f1 = new Acceuil();
            f1.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
