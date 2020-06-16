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
            Géré_mission f1 = new Géré_mission();
            f1.ShowDialog();
            this.Hide();
            this.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
         
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                List<Action_reclamation> ListAction_reclamation = Action_reclamationDAO.Get_Action_en_cour();
                dataGridView3.DataSource = ListAction_reclamation;
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
                List<Action_reclamation> ListAction_reclamation = Action_reclamationDAO.Get_Action_terminées();
                dataGridView3.DataSource = ListAction_reclamation;
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
                List<Action_reclamation> ListAction_reclamation = Action_reclamationDAO.Get_Action();
                dataGridView3.DataSource = ListAction_reclamation;
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
                Action_reclamationDAO.Insert_action(int.Parse(textBox1.Text), textBox11.Text, richTextBox1.Text, comboBox1.Text,int.Parse(textBox3.Text),textBox4.Text,DateTime.Parse(dateTimePicker2.Text),DateTime.Parse(dateTimePicker1.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Action_reclamation p = Action_reclamationDAO.Get_Action_Num(int.Parse(textBox1.Text));
                textBox1.Text = p.Num.ToString();
                richTextBox1.Text = p.Description;
                

                List<Action_reclamation> L = new List<Action_reclamation>();
                L.Add(p);
                dataGridView3.DataSource = L;
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
                Action_reclamationDAO.Update_Action(int.Parse(textBox1.Text), textBox11.Text, richTextBox1.Text, comboBox1.Text, int.Parse(textBox3.Text), textBox4.Text, DateTime.Parse(dateTimePicker2.Text), DateTime.Parse(dateTimePicker1.Text));
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
                Action_reclamationDAO.Delete_Action(int.Parse(textBox1.Text));
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
