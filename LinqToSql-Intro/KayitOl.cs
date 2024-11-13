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
            //DbTucco db =new DbSinavOgrenciEntities1();
            //PERSONEL ogrenci;
            //db.Ogrenci.Add(new PERSONEL()
            //{

            //    PERSONELADI= txtAd.Text,
            //    PERSONELSOYADI = txtSoyad.Text,
              

            //});

            //db.SaveChanges();
            //MessageBox.Show("Kayıt Oluşturuldu");


          
      
        }
    }
}
