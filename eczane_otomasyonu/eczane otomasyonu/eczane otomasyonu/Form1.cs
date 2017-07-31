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
    public partial class FormKullanici : Form
    {
        public FormKullanici()
        {
            InitializeComponent();
        }

        public static class kullanici
        {
            public static void kaydet(string kullanici, string sifre)
            {

                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select * From kullanici where kullanici='" + kullanici + "'", baglanti);
                OleDbDataReader okuyucu = komut.ExecuteReader();
                while (okuyucu.Read())
                {
                    if (kullanici == okuyucu["kullanici"].ToString())
                    {
                        if (sifre == okuyucu["sifre"].ToString())
                        {

                            anaform anaform = new anaform();
                            anaform.ShowDialog();

                        }
                        else
                        {
                            MessageBox.Show("BAŞARISIZ!");

                        }
                    }

                }

            }
        }



        public static OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eczane.accdb");
        private void btnGiris_Click(object sender, EventArgs e)
        {

            //    baglanti.Open();
            //    OleDbCommand komut = new OleDbCommand("Select * From kullanici where kullanici='" + txtAd.Text + "'", baglanti);
            //    OleDbDataReader okuyucu = komut.ExecuteReader();
            //    while (okuyucu.Read())
            //    {
            //        if (txtAd.Text.ToString() == okuyucu["kullanici"].ToString())
            //        {
            //            if (txtSifre.Text.ToString() == okuyucu["sifre"].ToString())
            //            {

            //                anaform anaform = new anaform();
            //                anaform.ShowDialog();
            //            }
            //            else
            //            {
            //                MessageBox.Show("BAŞARISIZ!");
            //            }
            //        }
            //    }
            //}

            kullanici.kaydet(txtAd.Text, txtSifre.Text);
        }
        private void FormKullanici_Load(object sender, EventArgs e)
        {

        }

    }
}



