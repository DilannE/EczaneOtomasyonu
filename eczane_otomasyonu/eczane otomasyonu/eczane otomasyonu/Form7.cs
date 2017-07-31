using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eczane_otomasyonu
{
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaform frm7 = new anaform();


            Form4 frm4 = new Form4();
            frm4.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 ilacform = new Form5();
           ilacform.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
