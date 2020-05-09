using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationWinforms
{
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }

       
        private void button4_Click_1(object sender, EventArgs e)
        {
            Mes_informations_créer_compte f1 = new Mes_informations_créer_compte();
            f1.button5.Visible = false;
            f1.button3.Visible = false;
            f1.button7.Visible = false;
            f1.groupBox2.Visible = false;
            f1.pictureBox3.Visible = false;
            f1.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Géré_mission f1 = new Géré_mission();
            f1.ShowDialog();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Traitement_reclamation f1 = new Traitement_reclamation();
            f1.ShowDialog();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Passer_Gérer_commande f1 = new Passer_Gérer_commande();
            f1.groupBox3.Visible = false;
            f1.groupBox2.Visible = false;
            f1.groupBox5.Visible = false;
            f1.button12.Visible = false;
            f1.button13.Visible = false;

            f1.ShowDialog();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Suggestion_Taux_satisfaction f1 = new Suggestion_Taux_satisfaction();
            
            f1.pictureBox6.Visible = false;
            f1.pictureBox3.Visible = false;
            f1.pictureBox4.Visible = false;
            f1.pictureBox5.Visible = false;
            f1.label4.Visible = false;
            f1.button5.Visible = false;
            f1.label6.Visible = false;
            f1.label7.Visible = false;
            f1.label8.Visible = false;
            f1.textBox2.Visible = false;
            f1.groupBox1.Visible = false;
            f1.groupBox2.Visible = false;

            f1.ShowDialog();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Reclamation_client f1 = new Reclamation_client();
            f1.ShowDialog();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Authentification f1 = new Authentification();
            f1.ShowDialog();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Géré_personnel_client_produit f1 = new Géré_personnel_client_produit();
            f1.button4.Visible = false;
            f1.button7.Visible = false;
            f1.button3.Visible = false;
            f1.groupBox4.Visible = false;
            f1.pictureBox3.Visible = false;
            f1.button17.Visible = false;
            f1.button8.Visible = false;
            f1.groupBox3.Visible = false;
            f1.groupBox1.Visible = false;

            f1.ShowDialog();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Géré_personnel_client_produit f1 = new Géré_personnel_client_produit();
            f1.groupBox4.Visible = false;
            f1.button9.Visible = false;
            f1.button10.Visible = false;
            f1.button11.Visible = false;
            f1.textBox6.Visible = false;
            f1.label6.Visible = false;
            f1.button1.Visible = false;
            f1.button17.Visible = false;
            f1.groupBox3.Visible = false;
            f1.groupBox2.Visible = false;
            f1.pictureBox3.Visible = false;

            f1.ShowDialog();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Géré_personnel_client_produit f1 = new Géré_personnel_client_produit();
            f1.button1.Visible = false;
            f1.button9.Visible = false;
            f1.button3.Visible = false;
            f1.button4.Visible = false;
            f1.button7.Visible = false;
            f1.button10.Visible = false;
            f1.button11.Visible = false;
            f1.button8.Visible = false;
            f1.textBox1.Visible = false;
            f1.textBox2.Visible = false;
            f1.textBox3.Visible = false;
            f1.textBox4.Visible = false;
            f1.textBox5.Visible = false;
            f1.textBox6.Visible = false;
            f1.label1.Visible = false;
            f1.label2.Visible = false;
            f1.label3.Visible = false;
            f1.label4.Visible = false;
            f1.label5.Visible = false;
            f1.label6.Visible = false;
            f1.groupBox1.Visible = false;
            f1.groupBox2.Visible = false;
            f1.pictureBox2.Visible = false;

            f1.ShowDialog();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Suggestion_Taux_satisfaction f1 = new Suggestion_Taux_satisfaction();
           
            f1.pictureBox2.Visible = false;
            f1.button1.Visible = false;
            f1.button3.Visible = false;
            f1.textBox1.Visible = false;
            f1.label1.Visible = false;
            f1.label2.Visible = false;
            f1.label3.Visible = false;
            f1.label5.Visible = false;
            f1.richTextBox1.Visible = false;

            f1.ShowDialog();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Passer_Gérer_commande f1 = new Passer_Gérer_commande();
            f1.groupBox1.Visible = false;
            f1.groupBox4.Visible = false;
            f1.button2.Visible = false;
            f1.label1.Visible = false;
            f1.textBox1.Visible = false;

            f1.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mes_informations_créer_compte f1 = new Mes_informations_créer_compte();
            f1.button2.Visible = false;
            f1.button11.Visible = false;
            f1.button10.Visible = false;
            f1.label6.Visible = false;
            f1.textBox6.Visible = false;
            f1.groupBox2.Visible = false;
            f1.pictureBox3.Visible = false;
            f1.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Mes_informations_créer_compte f1 = new Mes_informations_créer_compte();
            f1.groupBox1.Visible = false;
            f1.pictureBox2.Visible = false;
            f1.ShowDialog();
            this.Hide();
        }
    }
}
