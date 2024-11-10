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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
            var ogrenci=db.Ogrenci.ToList();


            foreach (var o in ogrenci)
            {
                if (txtKul.Text == o.KULLANICIADI && txtSifre.Text == o.SIFRE)
                {

                    anasayfa.Show();
                    anasayfa.Text += $"| Hoşgeldin {txtKul.Text}";
                

                }
                else
                {
                    lblSifreHata.Visible = true;
                    lblSifreHata.Text = "HATALI GİRİŞ !";

                }

            }
           


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl kayit=new KayitOl();
            kayit.Show();
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
