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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Frm_sec_Click(object sender, EventArgs e)
        {
          
            frm f4 = new frm();
            f4.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            Form5 f5 = new Form5();
            f5.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Hide();

        }
    }
}
