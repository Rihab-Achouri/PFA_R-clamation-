using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using DAL ;

namespace ApplicationWinforms
{
    public partial class Form4 : Form
    {
        public static OleDbDataAdapter oledbAdapter;
        public static OleDbConnection cn;
        public static OleDbCommand cmd;
        public static OleDbDataReader rd;

        public Form4()
        {
            InitializeComponent();
            fillcombobox();
            
        }

         void fillcombobox()
         {
            utils.Connect();

            string req = String.Format("select * from Patient ;");
            rd = utils.lire(req);

            while (rd.Read())
            {
                int name = rd.GetInt32(0);
                comboBox1.Items.Add(name); 



            }
            utils.Disconnect(); 
        
         }


        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'cabinetdentaireDataSet.RDV'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.rDVTableAdapter.Fill(this.cabinetdentaireDataSet.RDV);

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            try
            {

                string cnstr = utils.Connect1(); 


                cn = new OleDbConnection(cnstr);
                cn.Open();




                string requete = String.Format("select Numrdv,Daterdv from RDV where idpersonne ={0};", comboBox1.Text);

                string req = String.Format("select nom,prenom from patient where id ={0};", comboBox1.Text);

                DataSet ds = new DataSet();

                oledbAdapter = new OleDbDataAdapter(requete, cn);
                oledbAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];


                rd = utils.lire(req);
                while(rd.Read())
                {
                    textBox1.Text = rd.GetString(0);
                    textBox2.Text = rd.GetString(1);
                }
                
                

               // MessageBox.Show("xD");
                
                utils.Disconnect();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Hide();
        }
    }
}
