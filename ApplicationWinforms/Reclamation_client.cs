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
    public partial class Reclamation_client : Form
    {
        public Reclamation_client()
        {
            InitializeComponent();
        }

        int i = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string requete = String.Format("update Reclamation set Etat_reclamation='{0}'" +
                " where Num={1};", "Réclamation annulée", int.Parse(textBox2.Text));
            utils.miseajour(requete);
            MessageBox.Show("la réclamation a été annulée");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ReclamationDAO.Insert_reclamation_client(richTextBox1.Text, comboBox2.Text, int.Parse(textBox1.Text), int.Parse(comboBox1.Text), DateTime.Parse(dateTimePicker1.Text));

                string requete = string.Format("select max(Num) from Reclamation;");
                OleDbDataReader rd = utils.lire(requete);
                int A = 0;
                while (rd.Read())
                {
                    A = rd.GetInt32(0);
                }
                utils.Disconnect();

                textBox4.Text = A.ToString();
                MessageBox.Show("Le numéro de votre réclamation est: "+A);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            label4.Visible = true;
            if (textBox4.Text != "")
                try
                {
                    Reclamation p = ReclamationDAO.Get_reclamation_num(int.Parse(textBox4.Text));
                    textBox4.Text = p.Num.ToString();
                    richTextBox1.Text = p.Sujet;
                    comboBox1.Text = p.Ref_prod.ToString();
                    comboBox2.Text = p.Departement;
                    dateTimePicker1.Text = p.Date_ouverture.ToString();
                    textBox3.Text = p.Etat_reclamation;

                    List<Reclamation> L = new List<Reclamation>();
                    L.Add(p);
                    dataGridView1.DataSource = L;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            else if (textBox1.Text != "")
                try
                {
                    List<Reclamation> Listreclamation = ReclamationDAO.Get_reclamation_id_client(int.Parse(textBox1.Text));
                    dataGridView1.DataSource = Listreclamation;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            else MessageBox.Show("Si vous avez oublié le numéro de votre réclamation essayer avec votre identifiant");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                ReclamationDAO.Update_reclamation_client(int.Parse(textBox4.Text), richTextBox1.Text, comboBox2.Text, int.Parse(comboBox1.Text), DateTime.Parse(dateTimePicker1.Text));
                MessageBox.Show("La modfication a été effectuée avec succès");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            while (i == 0)
            {
                richTextBox1.Text = "";
                i = 1;
            }
        }
    }
}
