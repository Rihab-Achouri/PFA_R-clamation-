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
            try
            {
                Action_reclamationDAO.Insert_Action(int.Parse(textBox12.Text), textBox11.Text, textBox10.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                Action_reclamation A = Action_reclamationDAO.Get_Action_Num(int.Parse(textBox12.Text));
                textBox12.Text = A.Num.ToString();
                textBox11.Text = A.Etat;
                textBox10.Text = A.Description;

                List<Action_reclamation> L = new List<Action_reclamation>();
                L.Add(A);
                dataGridView3.DataSource = L;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                Action_reclamationDAO.Update_Action(int.Parse(textBox12.Text), textBox11.Text, textBox10.Text);
                MessageBox.Show("UPDATE DONE");
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
            try
            {
                Action_reclamationDAO.Delete_Action(int.Parse(textBox10.Text));
                MessageBox.Show("Action Supprimer");

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
    }
}
