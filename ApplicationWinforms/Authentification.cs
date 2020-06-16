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
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }


        
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Accueil Form = new Accueil();
                if (comboBox1.Text == "Client")
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
                if (comboBox1.Text == "Admin")
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
                if (comboBox1.Text == "Responsable Qualité")
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
                if (comboBox1.Text == "Responsable Production")
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
                if (comboBox1.Text == "Responsable Traitement")
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
                Authentifier A = new Authentifier();

                A= AuthentifierDAO.Verif(textBox1.Text, textBox2.Text, comboBox1.Text);
                if (A.Login != "")
                {
                    Form.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Authentification échouée vérifiez votre mot de passe!");
                }
            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message); }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Authentification_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           

            if ( checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar=false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
