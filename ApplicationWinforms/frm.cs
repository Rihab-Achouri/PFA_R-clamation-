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
    

    public partial class frm : Form
    {
        public static OleDbDataAdapter oledbAdapter;
        public static OleDbConnection cn;
        public static OleDbCommand cmd;
        public static OleDbDataReader rd;


        
        





        public frm()
        {
            InitializeComponent();
            
        }


        private static bool existance(string a) //fonction qui permet de vérifier l'existence d'un patient dont le code est saisi dans la zone textcode
        {
            bool p = false;
            utils.Connect();

            string req = "select * from Patient where id ='" + a + "'";
            //cmd = new OleDbCommand(req, cn);
            rd = utils.lire(req);


            if (rd.HasRows)
                p = true;


            cn.Close();
            return p;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                patientDAO.Delete_patient(int.Parse(txt_ID.Text));
                MessageBox.Show("patient supprimé *_* ");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                string cnstr = utils.Connect1();
                cn = new OleDbConnection(cnstr);
                cn.Open();
                string requete = String.Format("select * from Patient;");


                DataSet ds = new DataSet();
                oledbAdapter = new OleDbDataAdapter(requete, cn);
                oledbAdapter.Fill(ds);
                cn.Close();
                grid_patients.DataSource = ds.Tables[0];
                
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
                string cnstr = utils.Connect1();
                cn = new OleDbConnection(cnstr);
                cn.Open();
                string requete = String.Format("select * from Patient where ID={0};", txt_ID.Text);


                DataSet ds = new DataSet();
                oledbAdapter = new OleDbDataAdapter(requete, cn);
                oledbAdapter.Fill(ds);
                cn.Close();
                

                grid_patients.DataSource = ds.Tables[0];

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                
                    patientDAO.Insert_patient(int.Parse(tbID.Text), tbnom.Text, tbprenom.Text, int.Parse(tbnum.Text));
                    MessageBox.Show("patient ajouté *_* ");

                
            }
            
            catch (OleDbException )
            {
                MessageBox.Show(" Patient deja existant  ");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                patientDAO.Update_patient(int.Parse(tbID.Text), tbnom.Text, tbprenom.Text, int.Parse(tbnum.Text));
                MessageBox.Show("patient modifié ");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         

        }

        private void grid_clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnretour_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
