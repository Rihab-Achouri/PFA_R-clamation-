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
    public partial class Géré_mission : Form
    {
        public Géré_mission()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                List<Mission> ListMissions = MissionDAO.Get_Mission_Cloturée();
                dataGridView1.DataSource = ListMissions;
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
                List<Mission> ListMissions = MissionDAO.Get_Mission_Non_Traitée();
                dataGridView1.DataSource = ListMissions;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                List<Mission> ListMissions = MissionDAO.Get_Mission();
                dataGridView1.DataSource = ListMissions;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Accueil f1 = new Accueil();
            f1.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Mission m = MissionDAO.Get_Mission_Num(int.Parse(textBox10.Text));
                textBox10.Text = m.Num.ToString();
                comboBox1.Text = m.Etat;
                textBox7.Text = m.Département;
                dateTimePicker2.Text = m.Début_traitement.ToString();
                dateTimePicker1.Text = m.Date_cloture.ToString();
                richTextBox2.Text = m.Description;
                List<Mission> L = new List<Mission>();
                L.Add(m);
                dataGridView1.DataSource = L;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MissionDAO.Delete_Mission(int.Parse(textBox10.Text));
                MessageBox.Show("Mission Supprimer");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Fiche_de_traitement f2 = new Fiche_de_traitement();
            f2.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
