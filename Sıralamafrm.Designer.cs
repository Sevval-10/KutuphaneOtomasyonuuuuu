namespace KutuphaneOtomasyonuuuuu
{
    partial class Sıralamafrm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblEnCokOkuyan = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblEnAzOkuyan = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(115, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(941, 385);
            this.dataGridView1.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(299, 109);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(192, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "En Çok Kitap Okuyan Üye =";
            // 
            // lblEnCokOkuyan
            // 
            this.lblEnCokOkuyan.AutoSize = true;
            this.lblEnCokOkuyan.Depth = 0;
            this.lblEnCokOkuyan.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEnCokOkuyan.Location = new System.Drawing.Point(600, 109);
            this.lblEnCokOkuyan.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEnCokOkuyan.Name = "lblEnCokOkuyan";
            this.lblEnCokOkuyan.Size = new System.Drawing.Size(1, 0);
            this.lblEnCokOkuyan.TabIndex = 6;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(299, 165);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(183, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "En Az Kitap Okuyan Üye =";
            // 
            // lblEnAzOkuyan
            // 
            this.lblEnAzOkuyan.AutoSize = true;
            this.lblEnAzOkuyan.Depth = 0;
            this.lblEnAzOkuyan.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEnAzOkuyan.Location = new System.Drawing.Point(600, 165);
            this.lblEnAzOkuyan.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEnAzOkuyan.Name = "lblEnAzOkuyan";
            this.lblEnAzOkuyan.Size = new System.Drawing.Size(1, 0);
            this.lblEnAzOkuyan.TabIndex = 8;
            // 
            // Sıralamafrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1217, 638);
            this.Controls.Add(this.lblEnAzOkuyan);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.lblEnCokOkuyan);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sıralamafrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sıralama Sayfası";
            this.Load += new System.EventHandler(this.Sıralamafrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblEnCokOkuyan;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblEnAzOkuyan;
    }
}