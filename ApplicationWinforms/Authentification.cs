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
                Authentifier A = new Authentifier();

                A= AuthentifierDAO.verif(textBox1.Text, int.Parse(textBox2.Text), comboBox1.Text);
                if (A.Login != "")
                {
                    
                    Accueil Form = new Accueil();
                    Form.ShowDialog();

                }
                else
                {
                    MessageBox.Show("votre mot de passe et fause ");
                }
            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message); }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
