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
    public partial class Géré_personnel_client_produit : Form
    {
        public Géré_personnel_client_produit()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Acceuil f1 = new Acceuil();
            f1.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Personnel> Listpersonnels = PersonnelDAO.Get_personnel();
                dataGridView1.DataSource = Listpersonnels;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                List<Client> Listclients = ClientDAO.Get_client();
                dataGridView1.DataSource = Listclients;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                List<Produit> Listproduits = ProduitDAO.Get_produit();
                dataGridView1.DataSource = Listproduits;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                ProduitDAO.Delete_produit(int.Parse(textBox9.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                PersonnelDAO.Delete_personnel(int.Parse(textBox8.Text));

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
                ClientDAO.Delete_client(int.Parse(textBox7.Text));

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
                PersonnelDAO.Insert_personnel(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, int.Parse(textBox4.Text), textBox5.Text, textBox6.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                ClientDAO.Insert_client(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, int.Parse(textBox4.Text), textBox5.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                ProduitDAO.Insert_produit(int.Parse(textBox12.Text), int.Parse(textBox11.Text), int.Parse(textBox10.Text));
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
                PersonnelDAO.Update_personnel(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, int.Parse(textBox4.Text), textBox5.Text, textBox6.Text);
                MessageBox.Show("UPDATE DONE");
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
                ClientDAO.Update_client(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, int.Parse(textBox4.Text), textBox5.Text);
                MessageBox.Show("UPDATE DONE");
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
                ProduitDAO.Update_produit(int.Parse(textBox12.Text), int.Parse(textBox11.Text), int.Parse(textBox10.Text));
                MessageBox.Show("UPDATE DONE");
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
                Personnel p = PersonnelDAO.Get_personnel_ID(int.Parse(textBox1.Text));
                textBox2.Text = p.Nom;
                textBox3.Text = p.Prenom;
                textBox4.Text = p.Tel.ToString();
                textBox5.Text = p.Adresse_mail;
                textBox6.Text = p.Poste;
                List<Personnel> L = new List<Personnel>();
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
                Client c = ClientDAO.Get_client_ID(int.Parse(textBox1.Text));
                textBox2.Text = c.Nom_cl;
                textBox3.Text = c.Prenom_cl;
                textBox4.Text = c.Tel_cl.ToString();
                textBox5.Text = c.Adresse_mail_cl;
                
                List<Client> L = new List<Client>();
                L.Add(c);
                dataGridView1.DataSource = L;
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
                Produit p = ProduitDAO.Get_produit_reference(int.Parse(textBox12.Text));
                textBox12.Text = p.Reference.ToString();
                textBox11.Text = p.Qt_stock.ToString();
                textBox10.Text = p.Prix_unitaire.ToString();
                
                List<Produit> L = new List<Produit>();
                L.Add(p);
                dataGridView1.DataSource = L;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
