using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace KutuphaneOtomasyonuuuuu
{
    public partial class Grafikfrm : MaterialForm
    {
        public Grafikfrm()
        {
            InitializeComponent();

            // MaterialSkin ayarları
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Purple600,
                Primary.Purple700,
                Primary.Purple200,
                Accent.Purple200,
                TextShade.WHITE
            );
        }

        SqlConnection baglanti = new SqlConnection(
            "Data Source=DESKTOP-6SCKJNF;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void Grafikfrm_Load(object sender, EventArgs e)
        {
            GrafikYukle();
            GrafikGorunumAyarla();
        }

        private void GrafikYukle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select adsoyad, okukitapsayisi from Uye", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                chart1.Series["Okunan Kitap Sayısı"]
                    .Points.AddXY(read["adsoyad"].ToString(), read["okukitapsayisi"]);
            }

            baglanti.Close();
        }

        private void GrafikGorunumAyarla()
        {
            // Arka planlar
            chart1.BackColor = Color.White;
            chart1.ChartAreas[0].BackColor = Color.White;

            // Çubuk rengi
            chart1.Series["Okunan Kitap Sayısı"].Color = Color.Purple;

            // X ekseni düzgün görünmesi için
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chart1.ChartAreas[0].AxisX.IsLabelAutoFit = false;
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 9);

            // Grid çizgileri
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            // Eksen çizgileri
            chart1.ChartAreas[0].AxisX.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisY.LineColor = Color.Gray;

            // Legend
            chart1.Legends[0].BackColor = Color.White;
            chart1.Legends[0].ForeColor = Color.Black;
        }
    }
}
