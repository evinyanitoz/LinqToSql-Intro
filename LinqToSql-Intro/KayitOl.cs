using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSql_Intro
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void KayitOl_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
            Login giris = new Login();
            giris.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbSinavOgrenciEntities1 db=new DbSinavOgrenciEntities1();
            Ogrenci ogrenci;
            db.Ogrenci.Add(new Ogrenci
            {

                AD = txtAd.Text,
                SOYAD = txtSoyad.Text,
                KULLANICIADI=txtKullaniciAdi.Text,
               SIFRE=txtSifre.Text,


            });

            db.SaveChanges();
            MessageBox.Show("Kayıt Oluşturuldu");


          
      
        }
    }
}
