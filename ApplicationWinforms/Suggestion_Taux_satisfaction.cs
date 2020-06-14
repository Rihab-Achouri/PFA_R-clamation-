﻿using System;
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
            try
            {
                string requete = String.Format("insert into suggestion (id_client, Message) values ('{0}','{1}');", int.Parse(textBox1.Text), richTextBox1.Text);
                utils.miseajour(requete);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            richTextBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Accueil f1 = new Accueil();
            f1.ShowDialog();
            this.Hide();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string log;
            string qualité;

            if (radioButton1.Checked && radioButton8.Checked )
            {
                log = "Très satisfait";
                qualité = "Très satisfait";
                try
                {
                    Taux_satisfactionDAO.Insert_Taux_satisfaction(int.Parse(textBox2.Text), log, qualité);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (radioButton1.Checked && radioButton7.Checked)
            {
                log = "Très satisfait";
                qualité = "Assez satisfait";
                try
                {
                    Taux_satisfactionDAO.Insert_Taux_satisfaction(int.Parse(textBox2.Text), log, qualité);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (radioButton1.Checked && radioButton6.Checked)
            {
                log = "Très satisfait";
                qualité = "Peu satisfait";
                try
                {
                    Taux_satisfactionDAO.Insert_Taux_satisfaction(int.Parse(textBox2.Text), log, qualité);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (radioButton1.Checked && radioButton5.Checked)
            {
                log = "Très satisfait";
                qualité = "Pas du tout satisfait";
                try
                {
                    Taux_satisfactionDAO.Insert_Taux_satisfaction(int.Parse(textBox2.Text), log, qualité);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (radioButton2.Checked && radioButton8.Checked)
            {
                log = "Assez satisfait";
                qualité = "Très satisfait";
                try
                {
                    Taux_satisfactionDAO.Insert_Taux_satisfaction(int.Parse(textBox2.Text), log, qualité);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (radioButton2.Checked && radioButton7.Checked)
            {
                log = "Assez satisfait";
                qualité = "Assez satisfait";
                try
                {
                    Taux_satisfactionDAO.Insert_Taux_satisfaction(int.Parse(textBox2.Text), log, qualité);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (radioButton2.Checked && radioButton6.Checked)
            {
                log = "Assez satisfait";
                qualité = "Peu satisfait";
                try
                {
                    Taux_satisfactionDAO.Insert_Taux_satisfaction(int.Parse(textBox2.Text), log, qualité);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (radioButton2.Checked && radioButton5.Checked)
            {
                log = "Assez satisfait";
                qualité = "Pas du tout satisfait";
                try
                {
                    Taux_satisfactionDAO.Insert_Taux_satisfaction(int.Parse(textBox2.Text), log, qualité);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (radioButton3.Checked && radioButton8.Checked)
            {
                log = "Pas du tout satisfait";
                qualité = "Très satisfait";
                try
                {
                    Taux_satisfactionDAO.Insert_Taux_satisfaction(int.Parse(textBox2.Text), log, qualité);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (radioButton3.Checked && radioButton7.Checked)
            {
                log = "Peu satisfait";
                qualité = "Assez satisfait";
                try
                {
                    Taux_satisfactionDAO.Insert_Taux_satisfaction(int.Parse(textBox2.Text), log, qualité);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (radioButton3.Checked && radioButton6.Checked)
            {
                log = "Peu satisfait";
                qualité = "Peu satisfait";
                try
                {
                    Taux_satisfactionDAO.Insert_Taux_satisfaction(int.Parse(textBox2.Text), log, qualité);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (radioButton3.Checked && radioButton5.Checked)
            {
                log = "Peu satisfait";
                qualité = "Pas du tout satisfait";
                try
                {
                    Taux_satisfactionDAO.Insert_Taux_satisfaction(int.Parse(textBox2.Text), log, qualité);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (radioButton4.Checked && radioButton7.Checked)
            {
                log = "Pas du tout satisfait";
                qualité = "Assez satisfait";
                try
                {
                    Taux_satisfactionDAO.Insert_Taux_satisfaction(int.Parse(textBox2.Text), log, qualité);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (radioButton4.Checked && radioButton8.Checked)
            {
                log = "Pas du tout satisfait";
                qualité = "Très satisfait";
                try
                {
                    Taux_satisfactionDAO.Insert_Taux_satisfaction(int.Parse(textBox2.Text), log, qualité);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (radioButton4.Checked && radioButton6.Checked)
            {
                log = "Pas du tout satisfait";
                qualité = "Peu satisfait";
                try
                {
                    Taux_satisfactionDAO.Insert_Taux_satisfaction(int.Parse(textBox2.Text), log, qualité);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (radioButton4.Checked && radioButton8.Checked)
            {
                log = "Pas du tout satisfait";
                qualité = "Pas du tout satisfait";
                try
                {
                    Taux_satisfactionDAO.Insert_Taux_satisfaction(int.Parse(textBox2.Text), log, qualité);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                List<Suggestion> Listreclamation = SuggestionDAO.Get_suggestion();
                dataGridView1.DataSource = Listreclamation;
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
                Suggestion s = SuggestionDAO.Get_suggestion_id_cl(int.Parse(textBox3.Text));
                textBox3.Text = s.Id_client.ToString();
                richTextBox2.Text = s.Message;
                
                List<Suggestion> L = new List<Suggestion>();
                L.Add(s);
                dataGridView1.DataSource = L;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Suggestion_Taux_satisfaction_Load(object sender, EventArgs e)
        {

        }
    }
}
