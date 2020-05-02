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
    public partial class Form5 : Form
    {
        private OleDbConnection a = new OleDbConnection();
        public static OleDbDataAdapter oledbAdapter;
        public static OleDbConnection cn;
        public static OleDbCommand cmd;
        public static OleDbDataReader rd;
        public Form5()
        {
            InitializeComponent();
            string cnstr = utils.Connect1();
            a = new OleDbConnection(cnstr);
        }

        
        public static void Connect()
        {
            
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //AJOUTER RDV
        {
            Rendezvous rdv = new Rendezvous();
            rdv.Numrdv = int.Parse(txtnum.Text);
            rdv.Daterdv =txtdate.Text;
            rdv.idPersonne =int.Parse( txtnom.Text);

            try
            {
                rdvDAO.Insert_rdv(rdv.Daterdv, rdv.Numrdv, rdv.idPersonne);
                MessageBox.Show("RDV ajouté !");

            }
            catch (OleDbException )
            {
                MessageBox.Show("le numero de rdv deja pris ");
            }
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                rdvDAO.Delete_rdv(int.Parse(txtrech.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("RDV supprimé !");
        }

        private void txtsupp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Rendezvous rdv = new Rendezvous();
            rdv.Daterdv = txtdate.Text;
            try
            {
                rdvDAO.Update_rdv(rdv.Numrdv, rdv.Daterdv);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tupdate_Click(object sender, EventArgs e)
        {

            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'cabinetdentaireDataSet2.RDV'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.rDVTableAdapter1.Fill(this.cabinetdentaireDataSet2.RDV);
            // TODO: cette ligne de code charge les données dans la table 'cabinetdentaireDataSet.RDV'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.rDVTableAdapter.Fill(this.cabinetdentaireDataSet.RDV);

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string cnstr = utils.Connect1();
                cn = new OleDbConnection(cnstr);
                cn.Open();
                string requete = String.Format("select * from RDV where Numrdv={0};", txtrech.Text);


                DataSet ds = new DataSet();
                oledbAdapter = new OleDbDataAdapter(requete, cn);
                oledbAdapter.Fill(ds);
                cn.Close();


                dataGridView1.DataSource = ds.Tables[0];

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnaffich_Click(object sender, EventArgs e)
        {
            try
            {
                a.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = a;
                command.CommandText = "SELECT * FROM RDV";

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                a.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            {
               
                try
                {
                    rdvDAO.Update_rdv(int.Parse(txtrech.Text), txtsupp.Text);
                    MessageBox.Show(" rendez-vous modifié ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

