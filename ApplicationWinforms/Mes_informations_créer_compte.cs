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
    public partial class Mes_informations_créer_compte : Form
    {
        public Mes_informations_créer_compte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accueil Form = new Accueil();
            Authentification f = new Authentification();
            if (f.comboBox1.Text == "Client")
            {
                Form.button13.Visible = false;
                Form.button17.Visible = false;
                Form.button16.Visible = false;
                Form.button7.Visible = false;
                Form.button10.Visible = false;
                Form.button6.Visible = false;
                Form.button12.Visible = false;
                Form.button1.Visible = false;
                Form.button8.Visible = false;
                Form.button4.Visible = false;
                Form.pictureBox4.Visible = false;
                Form.pictureBox3.Visible = false;
                Form.pictureBox6.Visible = false;
            }
            if (f.comboBox1.Text == "Admin")
            {
                Form.button2.Visible = false;
                Form.button9.Visible = false;
                Form.button14.Visible = false;
                Form.button11.Visible = false;
                Form.button15.Visible = false;
                Form.pictureBox2.Visible = false;
                Form.pictureBox4.Visible = false;
                Form.pictureBox6.Visible = false;
            }
            if (f.comboBox1.Text == "Responsable Qualité")
            {
                Form.button6.Visible = false;
                Form.button1.Visible = false;
                Form.button16.Visible = false;
                Form.button7.Visible = false;
                Form.button13.Visible = false;
                Form.button10.Visible = false;
                Form.button12.Visible = false;
                Form.button2.Visible = false;
                Form.button9.Visible = false;
                Form.button14.Visible = false;
                Form.button11.Visible = false;
                Form.button15.Visible = false;
                Form.pictureBox2.Visible = false;
                Form.pictureBox6.Visible = false;

            }
            if (f.comboBox1.Text == "Responsable Production")
            {
                Form.button2.Visible = false;
                Form.button16.Visible = false;
                Form.button17.Visible = false;
                Form.button9.Visible = false;
                Form.button14.Visible = false;
                Form.button11.Visible = false;
                Form.button15.Visible = false;
                Form.pictureBox2.Visible = false;
                Form.button1.Visible = false;
                Form.button12.Visible = false;
                Form.button13.Visible = false;
                Form.button7.Visible = false;
                Form.button8.Visible = false;
                Form.pictureBox4.Visible = false;
            }
            if (f.comboBox1.Text == "Responsable Traitement")
            {
                Form.button6.Visible = false;
                Form.button17.Visible = false;
                Form.button8.Visible = false;
                Form.button16.Visible = false;
                Form.button7.Visible = false;
                Form.button13.Visible = false;
                Form.button10.Visible = false;
                Form.button12.Visible = false;
                Form.button2.Visible = false;
                Form.button9.Visible = false;
                Form.button14.Visible = false;
                Form.button11.Visible = false;
                Form.button15.Visible = false;
                Form.pictureBox4.Visible = false;
                Form.pictureBox6.Visible = false;
            }
            Form.ShowDialog();
            this.Hide();
        }

       

        

        

       

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                AuthentifierDAO.Insert(textBox8.Text, textBox7.Text, comboBox1.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                Personnel p = PersonnelDAO.Get_personnel_ID(int.Parse(textBox1.Text));
                textBox2.Text = p.Nom;
                textBox3.Text = p.Prenom;
                textBox4.Text = p.Tel.ToString();
                textBox5.Text = p.Adresse_mail;
                textBox6.Text = p.Poste;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                Client c = ClientDAO.Get_client_ID(int.Parse(textBox1.Text));
                textBox2.Text = c.Nom_cl;
                textBox4.Text = c.Tel_cl.ToString();
                textBox5.Text = c.Adresse_mail_cl;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            try
            {
                PersonnelDAO.Update_personnel(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                MessageBox.Show("UPDATE DONE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                ClientDAO.Update_client(int.Parse(textBox1.Text), textBox2.Text, textBox4.Text, textBox5.Text);
                MessageBox.Show("UPDATE DONE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            
        }
    }
}
