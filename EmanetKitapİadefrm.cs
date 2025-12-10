using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KutuphaneOtomasyonuuuuu
{
    public partial class EmanetKitapİadefrm : MaterialForm
    {
        public EmanetKitapİadefrm()
        {
            InitializeComponent();

            // MaterialSkin Ayarları
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

        private void EmanetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM EmanetKitaplar", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            baglanti.Close();
        }

        private void EmanetKitapİadefrm_Load(object sender, EventArgs e)
        {
            EmanetListele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();

            SqlDataAdapter adtr = new SqlDataAdapter(
                "SELECT * FROM EmanetKitaplar WHERE tc LIKE '%" + txtTcAra.Text + "%'",
                baglanti);

            adtr.Fill(daset, "EmanetKitaplar");
            baglanti.Close();

            if (txtTcAra.Text == "")
            {
                daset.Tables["EmanetKitaplar"].Clear();
                EmanetListele();
            }
        }

        private void txtBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();

            SqlDataAdapter adtr = new SqlDataAdapter(
                "SELECT * FROM EmanetKitaplar WHERE barkodno LIKE '%" + txtBarkodNoAra.Text + "%'",
                baglanti);

            adtr.Fill(daset, "EmanetKitaplar");
            baglanti.Close();

            if (txtBarkodNoAra.Text == "")
            {
                daset.Tables["EmanetKitaplar"].Clear();
                EmanetListele();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand(
                "DELETE FROM EmanetKitaplar WHERE tc=@tc AND barkodno=@barkodno",
                baglanti);

            komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut.ExecuteNonQuery();

            SqlCommand komut2 = new SqlCommand(
                "UPDATE Kitap SET stoksayisi = stoksayisi + '" +
                dataGridView1.CurrentRow.Cells["kitapsayisi"].Value.ToString() +
                "' WHERE barkodno=@barkodno",
                baglanti);

            komut2.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut2.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kitap/lar İade Edildi");

            daset.Tables["EmanetKitaplar"].Clear();
            EmanetListele();
        }
    }
}
