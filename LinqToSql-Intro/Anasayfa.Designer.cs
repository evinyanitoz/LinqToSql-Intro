namespace LinqToSql_Intro
{
    partial class Anasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dersİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgiGüncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notGörüntülemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınavİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtBilgiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.donemNotlari = new System.Windows.Forms.ToolStripMenuItem();
            this.notOrtalamasi = new System.Windows.Forms.ToolStripMenuItem();
            this.dersDurum = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dersİşlemleriToolStripMenuItem,
            this.bilgiGüncellemeToolStripMenuItem,
            this.notGörüntülemeToolStripMenuItem,
            this.sınavİşlemleriToolStripMenuItem,
            this.kayıtBilgiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1508, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dersİşlemleriToolStripMenuItem
            // 
            this.dersİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.dersİşlemleriToolStripMenuItem.Image = global::LinqToSql_Intro.Properties.Resources.book;
            this.dersİşlemleriToolStripMenuItem.Name = "dersİşlemleriToolStripMenuItem";
            this.dersİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.dersİşlemleriToolStripMenuItem.Text = "Ders İşlemleri";
            // 
            // bilgiGüncellemeToolStripMenuItem
            // 
            this.bilgiGüncellemeToolStripMenuItem.Image = global::LinqToSql_Intro.Properties.Resources.updated;
            this.bilgiGüncellemeToolStripMenuItem.Name = "bilgiGüncellemeToolStripMenuItem";
            this.bilgiGüncellemeToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.bilgiGüncellemeToolStripMenuItem.Text = "Bilgi Güncelleme";
            // 
            // notGörüntülemeToolStripMenuItem
            // 
            this.notGörüntülemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donemNotlari,
            this.notOrtalamasi,
            this.dersDurum});
            this.notGörüntülemeToolStripMenuItem.Image = global::LinqToSql_Intro.Properties.Resources.sticky_notes;
            this.notGörüntülemeToolStripMenuItem.Name = "notGörüntülemeToolStripMenuItem";
            this.notGörüntülemeToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.notGörüntülemeToolStripMenuItem.Text = "Not Görüntüleme";
            // 
            // sınavİşlemleriToolStripMenuItem
            // 
            this.sınavİşlemleriToolStripMenuItem.Image = global::LinqToSql_Intro.Properties.Resources.teacher;
            this.sınavİşlemleriToolStripMenuItem.Name = "sınavİşlemleriToolStripMenuItem";
            this.sınavİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.sınavİşlemleriToolStripMenuItem.Text = "Sınav İşlemleri";
            // 
            // kayıtBilgiToolStripMenuItem
            // 
            this.kayıtBilgiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıtBilgiToolStripMenuItem.Image = global::LinqToSql_Intro.Properties.Resources.edit;
            this.kayıtBilgiToolStripMenuItem.Name = "kayıtBilgiToolStripMenuItem";
            this.kayıtBilgiToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.kayıtBilgiToolStripMenuItem.Text = "Kayıt Bilgi";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.toolStripMenuItem1.Text = "Ders Ekle";
            // 
            // donemNotlari
            // 
            this.donemNotlari.Name = "donemNotlari";
            this.donemNotlari.Size = new System.Drawing.Size(190, 24);
            this.donemNotlari.Text = "Dönem Notları";
            // 
            // notOrtalamasi
            // 
            this.notOrtalamasi.Name = "notOrtalamasi";
            this.notOrtalamasi.Size = new System.Drawing.Size(190, 24);
            this.notOrtalamasi.Text = "Not Ortalamaları";
            // 
            // dersDurum
            // 
            this.dersDurum.Name = "dersDurum";
            this.dersDurum.Size = new System.Drawing.Size(190, 24);
            this.dersDurum.Text = "Ders Durum";
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 940);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Teal;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa ";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dersİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgiGüncellemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notGörüntülemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınavİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtBilgiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem donemNotlari;
        private System.Windows.Forms.ToolStripMenuItem notOrtalamasi;
        private System.Windows.Forms.ToolStripMenuItem dersDurum;
    }
}