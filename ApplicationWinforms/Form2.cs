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
    public partial class Form2 : Form
    {
        int i = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Taux_de_satisfaction> Listclients = Taux_satisfactionDAO.Get();
                dataGridView1.DataSource = Listclients;
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
                Taux_de_satisfaction p = Taux_satisfactionDAO.Get_ID(int.Parse(textBox1.Text));
                textBox1.Text = p.ID_cl.ToString();
                textBox2.Text = p.Taux_satisfaction_log;
                textBox3.Text = p.Taux_satisfaction_qualité;

                List<Taux_de_satisfaction> L = new List<Taux_de_satisfaction>();
                L.Add(p);
                dataGridView1.DataSource = L;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            while (i == 0)
            {
                int A = Taux_satisfactionDAO.count_log("Très satisfait");
                this.chart1.Series["Logistique"].Points.AddXY("Très satisfait", A);

                int B = Taux_satisfactionDAO.count_log("Assez satisfait");
                this.chart1.Series["Logistique"].Points.AddXY("Assez satisfait", B);

                int C = Taux_satisfactionDAO.count_log("Peu satisfait");
                this.chart1.Series["Logistique"].Points.AddXY("Peu satisfait", C);

                int D = Taux_satisfactionDAO.count_log("Pas du tout satisfait");
                this.chart1.Series["Logistique"].Points.AddXY("Pas du tout satisfait", D);

                int E = Taux_satisfactionDAO.count_qualité("Très satisfait");
                this.chart2.Series["Qualité"].Points.AddXY("Très satisfait", E);

                int F = Taux_satisfactionDAO.count_qualité("Assez satisfait");
                this.chart2.Series["Qualité"].Points.AddXY("Assez satisfait", F);

                int G = Taux_satisfactionDAO.count_qualité("Peu satisfait");
                this.chart2.Series["Qualité"].Points.AddXY("Peu satisfait", G);

                int H = Taux_satisfactionDAO.count_qualité("Pas du tout satisfait");
                this.chart2.Series["Qualité"].Points.AddXY("Pas du tout satisfait", H);
                i = 1;
            }

        }
    }
}
