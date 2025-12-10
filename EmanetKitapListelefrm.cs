using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KutuphaneOtomasyonuuuuu
{
    public partial class EmanetKitapListelefrm : MaterialForm
    {
        public EmanetKitapListelefrm()
        {
            InitializeComponent();

            // MaterialSkin Kurulumu
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
            "Data Source=DESKTOP-6SCKJNF;Initial Catalog=KütüphaneOtomasyonu;" +
            "Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        DataSet daset = new DataSet();

        private void EmanetKitapListelefrm_Load(object sender, EventArgs e)
        {
            EmanetListele();
            materialComboBox1.SelectedIndex = 0;
        }

        private void EmanetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM EmanetKitaplar", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            baglanti.Close();
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();

            if (materialComboBox1.SelectedIndex == 0)
            {
                EmanetListele();
            }
            else if (materialComboBox1.SelectedIndex == 1)
            {
                // Geciken kitaplar
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter(
                    "SELECT * FROM EmanetKitaplar WHERE '" + DateTime.Now.ToShortDateString() + "' > iadetarihi",
                    baglanti);
                adtr.Fill(daset, "EmanetKitaplar");
                dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
                baglanti.Close();
            }
            else if (materialComboBox1.SelectedIndex == 2)
            {
                // Süresi geçmemiş kitaplar
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter(
                    "SELECT * FROM EmanetKitaplar WHERE '" + DateTime.Now.ToShortDateString() + "' <= iadetarihi",
                    baglanti);
                adtr.Fill(daset, "EmanetKitaplar");
                dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
                baglanti.Close();
            }
        }
    }
}
