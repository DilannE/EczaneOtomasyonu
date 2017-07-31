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

namespace eczane_otomasyonu
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eczane.accdb");
        class hasta
        {
            public static void hastakayit(string tcno,string adsoyad,string anneadi,string babaadi,string dogumtarihi,string dogumyeri,string telno,string ilacadi,string ilacadedi,string fiyat)
            {
                baglanti.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter("insert into hasta(tcno,adsoyad,anneadi,babaadi,dogumyeri,dogumtarihi,telno,ilacadi,ilacadedi,fiyat)values('" + tcno + "','" + adsoyad + "'," + anneadi + "','" + babaadi + "'," + dogumyeri + "','" + dogumtarihi + "'," + telno + "','" + ilacadi + "'," + ilacadedi + "','" + fiyat + "' )", baglanti);
                adapter.SelectCommand.ExecuteNonQuery();
                baglanti.Close();
            
            
            
            
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            hasta.hastakayit(txtTc.Text, txtAdsoyad.Text, txtAnnead.Text, txtBabaad.Text,cmbDogumyeri.Text, txtDogumtarihi.Text, cmbDogumyeri.Text, txtTelefonno.Text, cmbİlacsec.Text, txtFiyat.Text);
           
        }
    }
}
