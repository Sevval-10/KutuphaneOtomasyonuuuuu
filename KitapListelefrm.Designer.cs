namespace KutuphaneOtomasyonuuuuu
{
    partial class KitapListelefrm
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
            this.comboTuru = new System.Windows.Forms.ComboBox();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtRafNo = new System.Windows.Forms.TextBox();
            this.txtStokSayisi = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.txtYazari = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBarkodAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboTuru
            // 
            this.comboTuru.FormattingEnabled = true;
            this.comboTuru.Items.AddRange(new object[] {
            "Çocuk Kitapları",
            "Hikaye",
            "Roman"});
            this.comboTuru.Location = new System.Drawing.Point(119, 233);
            this.comboTuru.Name = "comboTuru";
            this.comboTuru.Size = new System.Drawing.Size(251, 24);
            this.comboTuru.TabIndex = 42;
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(260, 403);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 23);
            this.btnİptal.TabIndex = 41;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(160, 403);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 40;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Açıklama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "RafNo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Stok Sayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Turu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Sayfa Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Yayınevi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Yazarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Kitap Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "K.BarkodNo";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(119, 350);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(251, 22);
            this.txtAciklama.TabIndex = 30;
            // 
            // txtRafNo
            // 
            this.txtRafNo.Location = new System.Drawing.Point(119, 312);
            this.txtRafNo.Name = "txtRafNo";
            this.txtRafNo.Size = new System.Drawing.Size(251, 22);
            this.txtRafNo.TabIndex = 29;
            // 
            // txtStokSayisi
            // 
            this.txtStokSayisi.Location = new System.Drawing.Point(119, 274);
            this.txtStokSayisi.Name = "txtStokSayisi";
            this.txtStokSayisi.Size = new System.Drawing.Size(251, 22);
            this.txtStokSayisi.TabIndex = 28;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(119, 198);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(251, 22);
            this.txtSayfaSayisi.TabIndex = 27;
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Location = new System.Drawing.Point(119, 160);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(251, 22);
            this.txtYayinevi.TabIndex = 26;
            // 
            // txtYazari
            // 
            this.txtYazari.Location = new System.Drawing.Point(119, 122);
            this.txtYazari.Name = "txtYazari";
            this.txtYazari.Size = new System.Drawing.Size(251, 22);
            this.txtYazari.TabIndex = 25;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(119, 84);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(251, 22);
            this.txtKitapAdi.TabIndex = 24;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(119, 46);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(251, 22);
            this.txtBarkodNo.TabIndex = 23;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(395, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1069, 326);
            this.dataGridView1.TabIndex = 43;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(1341, 386);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(123, 23);
            this.btnSil.TabIndex = 44;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(671, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 46;
            this.label10.Text = "K.BarkodNo Ara";
            // 
            // txtBarkodAra
            // 
            this.txtBarkodAra.Location = new System.Drawing.Point(781, 18);
            this.txtBarkodAra.Name = "txtBarkodAra";
            this.txtBarkodAra.Size = new System.Drawing.Size(251, 22);
            this.txtBarkodAra.TabIndex = 45;
            this.txtBarkodAra.TextChanged += new System.EventHandler(this.txtBarkodAra_TextChanged);
            // 
            // KitapListelefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1476, 595);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBarkodAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboTuru);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtRafNo);
            this.Controls.Add(this.txtStokSayisi);
            this.Controls.Add(this.txtSayfaSayisi);
            this.Controls.Add(this.txtYayinevi);
            this.Controls.Add(this.txtYazari);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.txtBarkodNo);
            this.Name = "KitapListelefrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Listeleme Sayfası";
            this.Load += new System.EventHandler(this.KitapListelefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTuru;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtRafNo;
        private System.Windows.Forms.TextBox txtStokSayisi;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.TextBox txtYazari;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBarkodAra;
    }
}