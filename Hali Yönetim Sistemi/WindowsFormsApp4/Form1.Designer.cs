namespace WindowsFormsApp4
{
    partial class Form1
    {
      
        private System.ComponentModel.IContainer components = null;

        
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

       
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMusteriler = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMusteriler = new System.Windows.Forms.ListBox();
            this.tabHalilar = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbTeslimEdilenHalilar = new System.Windows.Forms.RadioButton();
            this.rbYikamadakiHalilar = new System.Windows.Forms.RadioButton();
            this.rbTumHalilar = new System.Windows.Forms.RadioButton();
            this.lstHalilar = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMetrekare = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHaliEkle = new System.Windows.Forms.Button();
            this.tabDurum = new System.Windows.Forms.TabPage();
            this.btnDurumGuncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbHalilar = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabMusteriler.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabHalilar.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabDurum.SuspendLayout();
            this.SuspendLayout();
           
            this.tabControl1.Controls.Add(this.tabMusteriler);
            this.tabControl1.Controls.Add(this.tabHalilar);
            this.tabControl1.Controls.Add(this.tabDurum);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 500);
            this.tabControl1.TabIndex = 0;
       
            this.tabMusteriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tabMusteriler.Controls.Add(this.groupBox1);
            this.tabMusteriler.Controls.Add(this.lstMusteriler);
            this.tabMusteriler.Location = new System.Drawing.Point(4, 25);
            this.tabMusteriler.Name = "tabMusteriler";
            this.tabMusteriler.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusteriler.Size = new System.Drawing.Size(792, 471);
            this.tabMusteriler.TabIndex = 0;
            this.tabMusteriler.Text = "Müşteriler";
           
            this.groupBox1.Controls.Add(this.btnMusteriEkle);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(373, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 459);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Müşteri Ekle";
            
            this.btnMusteriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMusteriEkle.FlatAppearance.BorderSize = 0;
            this.btnMusteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriEkle.ForeColor = System.Drawing.Color.White;
            this.btnMusteriEkle.Location = new System.Drawing.Point(124, 291);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(154, 42);
            this.btnMusteriEkle.TabIndex = 8;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            
            this.txtAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.txtAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdres.ForeColor = System.Drawing.Color.White;
            this.txtAdres.Location = new System.Drawing.Point(21, 207);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(371, 67);
            this.txtAdres.TabIndex = 7;
            
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adres:";
            
            this.txtTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefon.ForeColor = System.Drawing.Color.White;
            this.txtTelefon.Location = new System.Drawing.Point(21, 152);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(371, 22);
            this.txtTelefon.TabIndex = 5;
          
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon:";
           
            this.txtSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoyad.ForeColor = System.Drawing.Color.White;
            this.txtSoyad.Location = new System.Drawing.Point(21, 97);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(371, 22);
            this.txtSoyad.TabIndex = 3;
          
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad:";
            
            this.txtAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAd.ForeColor = System.Drawing.Color.White;
            this.txtAd.Location = new System.Drawing.Point(21, 42);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(371, 22);
            this.txtAd.TabIndex = 1;
           
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
          
            this.lstMusteriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.lstMusteriler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstMusteriler.ForeColor = System.Drawing.Color.White;
            this.lstMusteriler.FormattingEnabled = true;
            this.lstMusteriler.ItemHeight = 16;
            this.lstMusteriler.Location = new System.Drawing.Point(8, 6);
            this.lstMusteriler.Name = "lstMusteriler";
            this.lstMusteriler.Size = new System.Drawing.Size(359, 450);
            this.lstMusteriler.TabIndex = 0;
            this.lstMusteriler.SelectedIndexChanged += new System.EventHandler(this.lstMusteriler_SelectedIndexChanged);
       
            this.tabHalilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tabHalilar.Controls.Add(this.groupBox3);
            this.tabHalilar.Controls.Add(this.lstHalilar);
            this.tabHalilar.Controls.Add(this.groupBox2);
            this.tabHalilar.Location = new System.Drawing.Point(4, 25);
            this.tabHalilar.Name = "tabHalilar";
            this.tabHalilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabHalilar.Size = new System.Drawing.Size(792, 471);
            this.tabHalilar.TabIndex = 1;
            this.tabHalilar.Text = "Halılar";
        
            this.groupBox3.Controls.Add(this.rbTeslimEdilenHalilar);
            this.groupBox3.Controls.Add(this.rbYikamadakiHalilar);
            this.groupBox3.Controls.Add(this.rbTumHalilar);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(373, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 123);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Halı Filtreleme";
            this.rbTeslimEdilenHalilar.AutoSize = true;
            this.rbTeslimEdilenHalilar.Location = new System.Drawing.Point(21, 83);
            this.rbTeslimEdilenHalilar.Name = "rbTeslimEdilenHalilar";
            this.rbTeslimEdilenHalilar.Size = new System.Drawing.Size(142, 20);
            this.rbTeslimEdilenHalilar.TabIndex = 2;
            this.rbTeslimEdilenHalilar.Text = "Teslim Edilen Halılar";
            this.rbTeslimEdilenHalilar.UseVisualStyleBackColor = true;
            this.rbTeslimEdilenHalilar.CheckedChanged += new System.EventHandler(this.rbTeslimEdilenHalilar_CheckedChanged);
         
            this.rbYikamadakiHalilar.AutoSize = true;
            this.rbYikamadakiHalilar.Location = new System.Drawing.Point(21, 56);
            this.rbYikamadakiHalilar.Name = "rbYikamadakiHalilar";
            this.rbYikamadakiHalilar.Size = new System.Drawing.Size(137, 20);
            this.rbYikamadakiHalilar.TabIndex = 1;
            this.rbYikamadakiHalilar.Text = "Yıkamadaki Halılar";
            this.rbYikamadakiHalilar.UseVisualStyleBackColor = true;
            this.rbYikamadakiHalilar.CheckedChanged += new System.EventHandler(this.rbYikamadakiHalilar_CheckedChanged);
           
            this.rbTumHalilar.AutoSize = true;
            this.rbTumHalilar.Checked = true;
            this.rbTumHalilar.Location = new System.Drawing.Point(21, 29);
            this.rbTumHalilar.Name = "rbTumHalilar";
            this.rbTumHalilar.Size = new System.Drawing.Size(91, 20);
            this.rbTumHalilar.TabIndex = 0;
            this.rbTumHalilar.TabStop = true;
            this.rbTumHalilar.Text = "Tüm Halılar";
            this.rbTumHalilar.UseVisualStyleBackColor = true;
            this.rbTumHalilar.CheckedChanged += new System.EventHandler(this.rbTumHalilar_CheckedChanged);
          
            this.lstHalilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.lstHalilar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstHalilar.ForeColor = System.Drawing.Color.White;
            this.lstHalilar.FormattingEnabled = true;
            this.lstHalilar.ItemHeight = 16;
            this.lstHalilar.Location = new System.Drawing.Point(8, 6);
            this.lstHalilar.Name = "lstHalilar";
            this.lstHalilar.Size = new System.Drawing.Size(359, 450);
            this.lstHalilar.TabIndex = 1;
          
            this.groupBox2.Controls.Add(this.txtMetrekare);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnHaliEkle);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(373, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 155);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Halı Ekle";
        
            this.txtMetrekare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.txtMetrekare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMetrekare.ForeColor = System.Drawing.Color.White;
            this.txtMetrekare.Location = new System.Drawing.Point(21, 51);
            this.txtMetrekare.Name = "txtMetrekare";
            this.txtMetrekare.Size = new System.Drawing.Size(371, 22);
            this.txtMetrekare.TabIndex = 3;
           
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Metrekare:";
            
            this.btnHaliEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnHaliEkle.FlatAppearance.BorderSize = 0;
            this.btnHaliEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHaliEkle.ForeColor = System.Drawing.Color.White;
            this.btnHaliEkle.Location = new System.Drawing.Point(124, 93);
            this.btnHaliEkle.Name = "btnHaliEkle";
            this.btnHaliEkle.Size = new System.Drawing.Size(154, 42);
            this.btnHaliEkle.TabIndex = 1;
            this.btnHaliEkle.Text = "Halı Ekle";
            this.btnHaliEkle.UseVisualStyleBackColor = false;
            this.btnHaliEkle.Click += new System.EventHandler(this.btnHaliEkle_Click);
            
            this.tabDurum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tabDurum.Controls.Add(this.btnDurumGuncelle);
            this.tabDurum.Controls.Add(this.label6);
            this.tabDurum.Controls.Add(this.cmbHalilar);
            this.tabDurum.Location = new System.Drawing.Point(4, 25);
            this.tabDurum.Name = "tabDurum";
            this.tabDurum.Size = new System.Drawing.Size(792, 471);
            this.tabDurum.TabIndex = 2;
            this.tabDurum.Text = "Durum Güncelleme";
          
            this.btnDurumGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDurumGuncelle.FlatAppearance.BorderSize = 0;
            this.btnDurumGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurumGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnDurumGuncelle.Location = new System.Drawing.Point(320, 181);
            this.btnDurumGuncelle.Name = "btnDurumGuncelle";
            this.btnDurumGuncelle.Size = new System.Drawing.Size(154, 42);
            this.btnDurumGuncelle.TabIndex = 2;
            this.btnDurumGuncelle.Text = "Teslim Edildi";
            this.btnDurumGuncelle.UseVisualStyleBackColor = false;
            this.btnDurumGuncelle.Click += new System.EventHandler(this.btnDurumGuncelle_Click);
           
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(106, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Durumu Güncellenecek Halı:";
             
            this.cmbHalilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.cmbHalilar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHalilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHalilar.ForeColor = System.Drawing.Color.White;
            this.cmbHalilar.FormattingEnabled = true;
            this.cmbHalilar.Location = new System.Drawing.Point(109, 122);
            this.cmbHalilar.Name = "cmbHalilar";
            this.cmbHalilar.Size = new System.Drawing.Size(575, 24);
            this.cmbHalilar.TabIndex = 0;
      
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Halı Yıkama Sistemi";
            this.tabControl1.ResumeLayout(false);
            this.tabMusteriler.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabHalilar.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabDurum.ResumeLayout(false);
            this.tabDurum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMusteriler;
        private System.Windows.Forms.TabPage tabHalilar;
        private System.Windows.Forms.TabPage tabDurum;
        private System.Windows.Forms.ListBox lstMusteriler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHaliEkle;
        private System.Windows.Forms.TextBox txtMetrekare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstHalilar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbTeslimEdilenHalilar;
        private System.Windows.Forms.RadioButton rbYikamadakiHalilar;
        private System.Windows.Forms.RadioButton rbTumHalilar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbHalilar;
        private System.Windows.Forms.Button btnDurumGuncelle;
    }
}

