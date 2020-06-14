using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using DAL;
using System.Data.OleDb;

namespace ApplicationWinforms
{
    public partial class Traitement_reclamation : Form
    {
        public Traitement_reclamation()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                List<Reclamation> Listreclamations = ReclamationDAO.Get_reclamation();
                dataGridView1.DataSource = Listreclamations;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                List<Reclamation> Listreclamations = ReclamationDAO.Get_reclamation_non_traitée();
                dataGridView1.DataSource = Listreclamations;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                List<Reclamation> Listreclamations = ReclamationDAO.Get_reclamation_annulée();
                dataGridView1.DataSource = Listreclamations;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Reclamation p = ReclamationDAO.Get_reclamation_num(int.Parse(textBox1.Text));
                textBox1.Text = p.Num.ToString();
                richTextBox1.Text = p.Sujet;
                textBox5.Text = p.Ref_prod.ToString();
                textBox4.Text = p.Departement;
                dateTimePicker2.Text = p.Date_ouverture.ToString();
                dateTimePicker1.Text = p.Date_cloture.ToString();
                comboBox1.Text = p.Etat_reclamation;
                textBox2.Text = p.Id_client.ToString();
                richTextBox2.Text = p.Decision;

                List<Reclamation> L = new List<Reclamation>();
                L.Add(p);
                dataGridView1.DataSource = L;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ReclamationDAO.Update_reclamation_decision(int.Parse(textBox1.Text), richTextBox2.Text, comboBox1.Text, DateTime.Parse(dateTimePicker1.Text));
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ReclamationDAO.Update_reclamation_decision(int.Parse(textBox1.Text), richTextBox2.Text, comboBox1.Text, DateTime.Parse(dateTimePicker1.Text));
                MessageBox.Show("UPDATE DONE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                ReclamationDAO.Delete_reclamation(int.Parse(textBox7.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                ReclamationDAO.Delete_reclamation_annulée();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Accueil f1 = new Accueil();
            f1.ShowDialog();
            this.Hide();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                List<Client2> Listreclamations = ReclamationDAO.Get_reclamation_groupby_client();
                dataGridView1.DataSource = Listreclamations;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
