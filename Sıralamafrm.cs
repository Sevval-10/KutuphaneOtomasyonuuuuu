using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KutuphaneOtomasyonuuuuu
{
    public partial class Sıralamafrm : MaterialForm
    {
        public Sıralamafrm()
        {
            InitializeComponent();

            // MaterialSkin Tema Ayarları
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.DeepPurple600,
                Primary.DeepPurple700,
                Primary.DeepPurple200,
                Accent.Purple200,
                TextShade.WHITE
            );
        }

        SqlConnection baglanti = new SqlConnection(
            "Data Source=DESKTOP-6SCKJNF;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        DataSet daset = new DataSet();

        private void Sıralamafrm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(
                "SELECT * FROM Uye ORDER BY okukitapsayisi DESC",
                baglanti);

            adtr.Fill(daset, "Uye");
            baglanti.Close();

            dataGridView1.DataSource = daset.Tables["Uye"];

            // En çok okuyan
            lblEnCokOkuyan.Text =
                daset.Tables["Uye"].Rows[0]["adsoyad"].ToString() + " = " +
                daset.Tables["Uye"].Rows[0]["okukitapsayisi"].ToString();

            // En az okuyan
            int sonIndex = dataGridView1.Rows.Count - 2;

            lblEnAzOkuyan.Text =
                daset.Tables["Uye"].Rows[sonIndex]["adsoyad"].ToString() + " = " +
                daset.Tables["Uye"].Rows[sonIndex]["okukitapsayisi"].ToString();
        }
    }
}
