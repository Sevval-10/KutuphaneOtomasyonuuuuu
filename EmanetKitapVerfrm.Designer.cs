namespace KutuphaneOtomasyonuuuuu
{
    partial class EmanetKitapVerfrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpUyeBilgi = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTcAra = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.grpKitapBilgi = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYazari = new System.Windows.Forms.TextBox();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtKitapSayisi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTeslimEt = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblKayitliKitapSayi = new System.Windows.Forms.Label();
            this.lblKitapSayi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpUyeBilgi.SuspendLayout();
            this.grpKitapBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(288, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 548);
            this.dataGridView1.TabIndex = 0;
            // 
            // grpUyeBilgi
            // 
            this.grpUyeBilgi.Controls.Add(this.label1);
            this.grpUyeBilgi.Controls.Add(this.label2);
            this.grpUyeBilgi.Controls.Add(this.label3);
            this.grpUyeBilgi.Controls.Add(this.label4);
            this.grpUyeBilgi.Controls.Add(this.txtTcAra);
            this.grpUyeBilgi.Controls.Add(this.txtAdSoyad);
            this.grpUyeBilgi.Controls.Add(this.txtYas);
            this.grpUyeBilgi.Controls.Add(this.txtTelefon);
            this.grpUyeBilgi.Location = new System.Drawing.Point(12, 33);
            this.grpUyeBilgi.Name = "grpUyeBilgi";
            this.grpUyeBilgi.Size = new System.Drawing.Size(249, 184);
            this.grpUyeBilgi.TabIndex = 1;
            this.grpUyeBilgi.TabStop = false;
            this.grpUyeBilgi.Text = "Üye Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yaş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon";
            // 
            // txtTcAra
            // 
            this.txtTcAra.Location = new System.Drawing.Point(105, 34);
            this.txtTcAra.Name = "txtTcAra";
            this.txtTcAra.Size = new System.Drawing.Size(100, 22);
            this.txtTcAra.TabIndex = 2;
            this.txtTcAra.TextChanged += new System.EventHandler(this.txtTcAra_TextChanged);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(105, 70);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(105, 106);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(100, 22);
            this.txtYas.TabIndex = 4;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(105, 142);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 5;
            // 
            // grpKitapBilgi
            // 
            this.grpKitapBilgi.Controls.Add(this.label11);
            this.grpKitapBilgi.Controls.Add(this.label12);
            this.grpKitapBilgi.Controls.Add(this.dateTimePicker1);
            this.grpKitapBilgi.Controls.Add(this.dateTimePicker2);
            this.grpKitapBilgi.Controls.Add(this.label10);
            this.grpKitapBilgi.Controls.Add(this.label8);
            this.grpKitapBilgi.Controls.Add(this.label9);
            this.grpKitapBilgi.Controls.Add(this.txtBarkodNo);
            this.grpKitapBilgi.Controls.Add(this.txtKitapAdi);
            this.grpKitapBilgi.Controls.Add(this.label5);
            this.grpKitapBilgi.Controls.Add(this.label6);
            this.grpKitapBilgi.Controls.Add(this.label7);
            this.grpKitapBilgi.Controls.Add(this.txtYazari);
            this.grpKitapBilgi.Controls.Add(this.txtYayinevi);
            this.grpKitapBilgi.Controls.Add(this.txtSayfaSayisi);
            this.grpKitapBilgi.Controls.Add(this.txtKitapSayisi);
            this.grpKitapBilgi.Location = new System.Drawing.Point(12, 234);
            this.grpKitapBilgi.Name = "grpKitapBilgi";
            this.grpKitapBilgi.Size = new System.Drawing.Size(249, 380);
            this.grpKitapBilgi.TabIndex = 0;
            this.grpKitapBilgi.TabStop = false;
            this.grpKitapBilgi.Text = "Kitap Bilgileri";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Teslim Tarihi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "İade Tarihi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 284);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(105, 325);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 22);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Kitap Sayısı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Yayın Evi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Sayfa Sayısı";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(105, 38);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(100, 22);
            this.txtBarkodNo.TabIndex = 6;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(105, 79);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(100, 22);
            this.txtKitapAdi.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Barkod No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kitap Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Yazarı";
            // 
            // txtYazari
            // 
            this.txtYazari.Location = new System.Drawing.Point(105, 120);
            this.txtYazari.Name = "txtYazari";
            this.txtYazari.Size = new System.Drawing.Size(100, 22);
            this.txtYazari.TabIndex = 8;
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Location = new System.Drawing.Point(105, 161);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(100, 22);
            this.txtYayinevi.TabIndex = 9;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(105, 202);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(100, 22);
            this.txtSayfaSayisi.TabIndex = 10;
            // 
            // txtKitapSayisi
            // 
            this.txtKitapSayisi.Location = new System.Drawing.Point(105, 243);
            this.txtKitapSayisi.Name = "txtKitapSayisi";
            this.txtKitapSayisi.Size = new System.Drawing.Size(100, 22);
            this.txtKitapSayisi.TabIndex = 11;
            this.txtKitapSayisi.Text = "1";
            this.txtKitapSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(186, 620);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTeslimEt
            // 
            this.btnTeslimEt.Location = new System.Drawing.Point(1192, 591);
            this.btnTeslimEt.Name = "btnTeslimEt";
            this.btnTeslimEt.Size = new System.Drawing.Size(75, 23);
            this.btnTeslimEt.TabIndex = 3;
            this.btnTeslimEt.Text = "Teslim Et";
            this.btnTeslimEt.UseVisualStyleBackColor = true;
            this.btnTeslimEt.Click += new System.EventHandler(this.btnTeslimEt_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(1287, 591);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 23);
            this.btnİptal.TabIndex = 4;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(1368, 33);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(694, 598);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 16);
            this.label13.TabIndex = 6;
            this.label13.Text = "Kayıtlı Kitap Sayısı";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(941, 598);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 16);
            this.label15.TabIndex = 7;
            this.label15.Text = "Kitap Sayısı";
            // 
            // lblKayitliKitapSayi
            // 
            this.lblKayitliKitapSayi.AutoSize = true;
            this.lblKayitliKitapSayi.Location = new System.Drawing.Point(815, 598);
            this.lblKayitliKitapSayi.Name = "lblKayitliKitapSayi";
            this.lblKayitliKitapSayi.Size = new System.Drawing.Size(0, 16);
            this.lblKayitliKitapSayi.TabIndex = 8;
            // 
            // lblKitapSayi
            // 
            this.lblKitapSayi.AutoSize = true;
            this.lblKitapSayi.Location = new System.Drawing.Point(1024, 598);
            this.lblKitapSayi.Name = "lblKitapSayi";
            this.lblKitapSayi.Size = new System.Drawing.Size(0, 16);
            this.lblKitapSayi.TabIndex = 9;
            // 
            // EmanetKitapVerfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1466, 670);
            this.Controls.Add(this.lblKitapSayi);
            this.Controls.Add(this.lblKayitliKitapSayi);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnTeslimEt);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.grpKitapBilgi);
            this.Controls.Add(this.grpUyeBilgi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmanetKitapVerfrm";
            this.Text = "Emanet Kitap Verme Sayfası";
            this.Load += new System.EventHandler(this.EmanetKitapVerfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpUyeBilgi.ResumeLayout(false);
            this.grpUyeBilgi.PerformLayout();
            this.grpKitapBilgi.ResumeLayout(false);
            this.grpKitapBilgi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpUyeBilgi;
        private System.Windows.Forms.GroupBox grpKitapBilgi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTcAra;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtYazari;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.TextBox txtKitapSayisi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTeslimEt;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblKayitliKitapSayi;
        private System.Windows.Forms.Label lblKitapSayi;
    }
}