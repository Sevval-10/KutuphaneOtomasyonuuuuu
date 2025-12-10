namespace KutuphaneOtomasyonuuuuu
{
    partial class UyeListelemefrm
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
            this.btnGuncelle = new MaterialSkin.Controls.MaterialButton();
            this.btnİptal = new MaterialSkin.Controls.MaterialButton();
            this.btnSil = new MaterialSkin.Controls.MaterialButton();
            this.comboCinsiyet = new MaterialSkin.Controls.MaterialComboBox();
            this.txtTc = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAdSoyad = new MaterialSkin.Controls.MaterialTextBox();
            this.txtYas = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTelefon = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAdres = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtOkunanSayi = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAraTc = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(462, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(639, 358);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuncelle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuncelle.Depth = 0;
            this.btnGuncelle.HighEmphasis = true;
            this.btnGuncelle.Icon = null;
            this.btnGuncelle.Location = new System.Drawing.Point(187, 593);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuncelle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuncelle.Size = new System.Drawing.Size(94, 36);
            this.btnGuncelle.TabIndex = 40;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuncelle.UseAccentColor = false;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click_1);
            // 
            // btnİptal
            // 
            this.btnİptal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnİptal.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnİptal.Depth = 0;
            this.btnİptal.HighEmphasis = true;
            this.btnİptal.Icon = null;
            this.btnİptal.Location = new System.Drawing.Point(313, 593);
            this.btnİptal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnİptal.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnİptal.Size = new System.Drawing.Size(64, 36);
            this.btnİptal.TabIndex = 41;
            this.btnİptal.Text = "İptal";
            this.btnİptal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnİptal.UseAccentColor = false;
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSil.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSil.Depth = 0;
            this.btnSil.HighEmphasis = true;
            this.btnSil.Icon = null;
            this.btnSil.Location = new System.Drawing.Point(1066, 126);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSil.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSil.Name = "btnSil";
            this.btnSil.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSil.Size = new System.Drawing.Size(64, 36);
            this.btnSil.TabIndex = 42;
            this.btnSil.Text = "Sil";
            this.btnSil.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSil.UseAccentColor = false;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // comboCinsiyet
            // 
            this.comboCinsiyet.AutoResize = false;
            this.comboCinsiyet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboCinsiyet.Depth = 0;
            this.comboCinsiyet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboCinsiyet.DropDownHeight = 174;
            this.comboCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCinsiyet.DropDownWidth = 121;
            this.comboCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboCinsiyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboCinsiyet.FormattingEnabled = true;
            this.comboCinsiyet.IntegralHeight = false;
            this.comboCinsiyet.ItemHeight = 43;
            this.comboCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboCinsiyet.Location = new System.Drawing.Point(164, 286);
            this.comboCinsiyet.MaxDropDownItems = 4;
            this.comboCinsiyet.MouseState = MaterialSkin.MouseState.OUT;
            this.comboCinsiyet.Name = "comboCinsiyet";
            this.comboCinsiyet.Size = new System.Drawing.Size(250, 49);
            this.comboCinsiyet.StartIndex = 0;
            this.comboCinsiyet.TabIndex = 43;
            // 
            // txtTc
            // 
            this.txtTc.AnimateReadOnly = false;
            this.txtTc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTc.Depth = 0;
            this.txtTc.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTc.LeadingIcon = null;
            this.txtTc.Location = new System.Drawing.Point(164, 112);
            this.txtTc.MaxLength = 50;
            this.txtTc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTc.Multiline = false;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(250, 50);
            this.txtTc.TabIndex = 44;
            this.txtTc.Text = "";
            this.txtTc.TrailingIcon = null;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.AnimateReadOnly = false;
            this.txtAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdSoyad.Depth = 0;
            this.txtAdSoyad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAdSoyad.LeadingIcon = null;
            this.txtAdSoyad.Location = new System.Drawing.Point(164, 170);
            this.txtAdSoyad.MaxLength = 50;
            this.txtAdSoyad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAdSoyad.Multiline = false;
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(250, 50);
            this.txtAdSoyad.TabIndex = 45;
            this.txtAdSoyad.Text = "";
            this.txtAdSoyad.TrailingIcon = null;
            // 
            // txtYas
            // 
            this.txtYas.AnimateReadOnly = false;
            this.txtYas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYas.Depth = 0;
            this.txtYas.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtYas.LeadingIcon = null;
            this.txtYas.Location = new System.Drawing.Point(164, 228);
            this.txtYas.MaxLength = 50;
            this.txtYas.MouseState = MaterialSkin.MouseState.OUT;
            this.txtYas.Multiline = false;
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(250, 50);
            this.txtYas.TabIndex = 46;
            this.txtYas.Text = "";
            this.txtYas.TrailingIcon = null;
            // 
            // txtTelefon
            // 
            this.txtTelefon.AnimateReadOnly = false;
            this.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefon.Depth = 0;
            this.txtTelefon.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefon.LeadingIcon = null;
            this.txtTelefon.Location = new System.Drawing.Point(164, 343);
            this.txtTelefon.MaxLength = 50;
            this.txtTelefon.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefon.Multiline = false;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(250, 50);
            this.txtTelefon.TabIndex = 47;
            this.txtTelefon.Text = "";
            this.txtTelefon.TrailingIcon = null;
            // 
            // txtAdres
            // 
            this.txtAdres.AnimateReadOnly = false;
            this.txtAdres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdres.Depth = 0;
            this.txtAdres.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAdres.LeadingIcon = null;
            this.txtAdres.Location = new System.Drawing.Point(164, 401);
            this.txtAdres.MaxLength = 50;
            this.txtAdres.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAdres.Multiline = false;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(250, 50);
            this.txtAdres.TabIndex = 48;
            this.txtAdres.Text = "";
            this.txtAdres.TrailingIcon = null;
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(164, 459);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 50);
            this.txtEmail.TabIndex = 49;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            // 
            // txtOkunanSayi
            // 
            this.txtOkunanSayi.AnimateReadOnly = false;
            this.txtOkunanSayi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOkunanSayi.Depth = 0;
            this.txtOkunanSayi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOkunanSayi.LeadingIcon = null;
            this.txtOkunanSayi.Location = new System.Drawing.Point(164, 517);
            this.txtOkunanSayi.MaxLength = 50;
            this.txtOkunanSayi.MouseState = MaterialSkin.MouseState.OUT;
            this.txtOkunanSayi.Multiline = false;
            this.txtOkunanSayi.Name = "txtOkunanSayi";
            this.txtOkunanSayi.Size = new System.Drawing.Size(250, 50);
            this.txtOkunanSayi.TabIndex = 50;
            this.txtOkunanSayi.Text = "";
            this.txtOkunanSayi.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(99, 129);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(21, 19);
            this.materialLabel1.TabIndex = 51;
            this.materialLabel1.Text = "TC";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(51, 186);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(69, 19);
            this.materialLabel2.TabIndex = 52;
            this.materialLabel2.Text = "Ad Soyad";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(92, 243);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(28, 19);
            this.materialLabel3.TabIndex = 53;
            this.materialLabel3.Text = "Yaş";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(63, 300);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(57, 19);
            this.materialLabel4.TabIndex = 54;
            this.materialLabel4.Text = "Cinsiyet";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(65, 357);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(55, 19);
            this.materialLabel5.TabIndex = 55;
            this.materialLabel5.Text = "Telefon";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(79, 417);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(41, 19);
            this.materialLabel6.TabIndex = 56;
            this.materialLabel6.Text = "Adres";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(75, 471);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(45, 19);
            this.materialLabel7.TabIndex = 57;
            this.materialLabel7.Text = "E-mail";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(11, 539);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(109, 19);
            this.materialLabel8.TabIndex = 58;
            this.materialLabel8.Text = "Oku. Kitap Sayı";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(580, 133);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(49, 19);
            this.materialLabel9.TabIndex = 59;
            this.materialLabel9.Text = "TC Ara";
            // 
            // txtAraTc
            // 
            this.txtAraTc.AnimateReadOnly = false;
            this.txtAraTc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAraTc.Depth = 0;
            this.txtAraTc.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAraTc.LeadingIcon = null;
            this.txtAraTc.Location = new System.Drawing.Point(654, 119);
            this.txtAraTc.MaxLength = 50;
            this.txtAraTc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAraTc.Multiline = false;
            this.txtAraTc.Name = "txtAraTc";
            this.txtAraTc.Size = new System.Drawing.Size(390, 50);
            this.txtAraTc.TabIndex = 60;
            this.txtAraTc.Text = "";
            this.txtAraTc.TrailingIcon = null;
            this.txtAraTc.TextChanged += new System.EventHandler(this.txtAraTc_TextChanged);
            // 
            // UyeListelemefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1201, 685);
            this.Controls.Add(this.txtAraTc);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtOkunanSayi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.comboCinsiyet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UyeListelemefrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UyeListelemefrm";
            this.Load += new System.EventHandler(this.UyeListelemefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton btnGuncelle;
        private MaterialSkin.Controls.MaterialButton btnİptal;
        private MaterialSkin.Controls.MaterialButton btnSil;
        private MaterialSkin.Controls.MaterialComboBox comboCinsiyet;
        private MaterialSkin.Controls.MaterialTextBox txtTc;
        private MaterialSkin.Controls.MaterialTextBox txtAdSoyad;
        private MaterialSkin.Controls.MaterialTextBox txtYas;
        private MaterialSkin.Controls.MaterialTextBox txtTelefon;
        private MaterialSkin.Controls.MaterialTextBox txtAdres;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtOkunanSayi;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox txtAraTc;
    }
}
