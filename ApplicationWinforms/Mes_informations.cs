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
    public partial class Mes_informations : Form
    {
        public Mes_informations()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Acceuil f1 = new Acceuil();
            f1.ShowDialog();
            this.Hide();
        }
    }
}
