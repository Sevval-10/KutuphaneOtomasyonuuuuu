using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KutuphaneOtomasyonuuuuu
{
    public partial class UyeListelemefrm : MaterialForm
    {
        public UyeListelemefrm()
        {
            InitializeComponent();

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.Purple700,
                Primary.Purple900,
                Primary.Purple500,
                Accent.Purple200,
                TextShade.WHITE
            );
        }

        SqlConnection baglanti = new SqlConnection(
            "Data Source=DESKTOP-6SCKJNF;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"
        );

        DataSet daset = new DataSet();

        // FORM LOAD
        private void UyeListelemefrm_Load(object sender, EventArgs e)
        {
            uyelistele();
        }

        // TÜM ÜYELERİ LİSTELE
        private void uyelistele()
        {
            try
            {
                daset.Tables.Clear();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM uye", baglanti);
                adtr.Fill(daset, "uye");
                dataGridView1.DataSource = daset.Tables["uye"];
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        //  🔎 TC'ye göre ARAMA  (txtAraTc)
        private void txtAraTc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                daset.Tables.Clear();
                baglanti.Open();

                SqlDataAdapter adtr = new SqlDataAdapter(
                    "SELECT * FROM uye WHERE tc LIKE @ara",
                    baglanti
                );

                adtr.SelectCommand.Parameters.AddWithValue("@ara", "%" + txtAraTc.Text + "%");

                adtr.Fill(daset, "uye");
                dataGridView1.DataSource = daset.Tables["uye"];
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        // 🔘 DATAGRIDDE ÇİFT TIK → Bilgiler textboxlara gelir
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            txtTc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtYas.Text = dataGridView1.CurrentRow.Cells["yas"].Value.ToString();
            comboCinsiyet.Text = dataGridView1.CurrentRow.Cells["cinsiyet"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            txtOkunanSayi.Text = dataGridView1.CurrentRow.Cells["okukitapsayisi"].Value.ToString();
        }

        // ❌ TC TEXT CHANGED TAMAMEN SİLİNDİ (çakışma nedeni buydu)

        // 🗑 SİLME
        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            if (MessageBox.Show("Silmek istiyor musun?", "UYARI",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM uye WHERE tc=@tc", baglanti);
                komut.Parameters.AddWithValue("@tc",
                    dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
                komut.ExecuteNonQuery();
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }

            MessageBox.Show("Silme Başarılı");
            uyelistele();
            temizle();
        }

        // 📝 GÜNCELLEME
        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(
                    "UPDATE uye SET adsoyad=@ad, yas=@yas, cinsiyet=@c, telefon=@tel, adres=@adr, email=@mail, okukitapsayisi=@s " +
                    "WHERE tc=@tc", baglanti);

                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@ad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@yas", txtYas.Text);
                komut.Parameters.AddWithValue("@c", comboCinsiyet.Text);
                komut.Parameters.AddWithValue("@tel", txtTelefon.Text);
                komut.Parameters.AddWithValue("@adr", txtAdres.Text);
                komut.Parameters.AddWithValue("@mail", txtEmail.Text);
                komut.Parameters.AddWithValue("@s", txtOkunanSayi.Text);

                komut.ExecuteNonQuery();
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }

            MessageBox.Show("Güncellendi");
            uyelistele();
        }

        // ❌ İPTAL
        private void btnİptal_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void temizle()
        {
            txtTc.Text = "";
            txtAdSoyad.Text = "";
            txtYas.Text = "";
            comboCinsiyet.SelectedIndex = 0;
            txtTelefon.Text = "";
            txtAdres.Text = "";
            txtEmail.Text = "";
            txtOkunanSayi.Text = "";
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
        
            // Eğer kutu boşsa alanları temizle
            if (string.IsNullOrWhiteSpace(txtTc.Text))
            {
                txtAdSoyad.Text = "";
                txtYas.Text = "";
                comboCinsiyet.SelectedIndex =0;
                txtTelefon.Text = "";
                txtAdres.Text = "";
                txtEmail.Text = "";
                txtOkunanSayi.Text = "";
                return;
            }

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand komut = new SqlCommand(
                    "SELECT * FROM uye WHERE tc = @tc", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTc.Text.Trim());

                SqlDataReader read = komut.ExecuteReader();

                if (read.Read())
                {
                    txtAdSoyad.Text = read["adsoyad"].ToString();
                    txtYas.Text = read["yas"].ToString();
                    comboCinsiyet.Text = read["cinsiyet"].ToString();
                    txtTelefon.Text = read["telefon"].ToString();
                    txtAdres.Text = read["adres"].ToString();
                    txtEmail.Text = read["email"].ToString();
                    txtOkunanSayi.Text = read["okukitapsayisi"].ToString();
                }
                else
                {
                    // TC bulunamazsa diğer alanları temizle
                    txtAdSoyad.Text = "";
                    txtYas.Text = "";
                    comboCinsiyet.SelectedIndex = -1;
                    txtTelefon.Text = "";
                    txtAdres.Text = "";
                    txtEmail.Text = "";
                    txtOkunanSayi.Text = "";
                }

                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

    }
}

