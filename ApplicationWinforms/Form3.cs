using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ApplicationWinforms
{
    public partial class Frm_acceuil : Form
    {
        public Frm_acceuil()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_acceuil_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtpass.Focus();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnlogin.PerformClick();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtuser.Text))
            { MessageBox.Show("erreur"); }
            try
            {
                cabinetdentaireDataSet1TableAdapters.SecrétaireTableAdapter login = new cabinetdentaireDataSet1TableAdapters.SecrétaireTableAdapter();
                cabinetdentaireDataSet1.SecrétaireDataTable dt = login.GetDataByLoginMDP(txtuser.Text, txtpass.Text);
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    Form2 f = new Form2();
                    f.ShowDialog();

                }
                else { MessageBox.Show("Mot de passe incorrect"); }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
            }
        }
    
    
    }

