using LinqToSql_Intro.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSql_Intro
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            DbTuccoEntities db = new DbTuccoEntities();

            foreach (var item in db.YEMEKLER)
            {
                yemekcard c = new yemekcard();
                c.label1.Text = item.YEMEKAD;
                c.label2.Text = item.YEMEKFIYAT + " TL";
                c.pictureBox1.Image = Image.FromFile(item.FOTOGRAF);


                flowLayoutPanel1.Controls.Add(c);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnYemek_Click(object sender, EventArgs e)
        {
            DbTuccoEntities db = new DbTuccoEntities();

            foreach (var item in db.YEMEKLER)
            {
                yemekcard c = new yemekcard();
                c.label1.Text = item.YEMEKAD;
                c.label2.Text = item.YEMEKFIYAT + " TL";
                c.pictureBox1.Image=Image.FromFile(item.FOTOGRAF);


                flowLayoutPanel1.Controls.Add(c);   
            }
        }
    }
}
