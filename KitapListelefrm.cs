using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KutuphaneOtomasyonuuuuu
{
    public partial class KitapListelefrm : MaterialForm
    {
        public KitapListelefrm()
        {
            InitializeComponent();

            // MaterialSkin tema ve renk ayarı
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
            "Data Source=DESKTOP-6SCKJNF;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"
        );

        DataSet daset = new DataSet();

        private void KitapListelefrm_Load(object sender, EventArgs e)
        {
            try
            {
                KitapListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KitapListele()
        {
            daset.Tables.Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM kitap", baglanti);
            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            DialogResult dialog = MessageBox.Show(
                "Bu kaydı silmek mi istiyorsunuz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
            );

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM kitap WHERE barkodno=@barkodno", baglanti);
                    komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Silme işlemi gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    daset.Tables["kitap"].Clear();
                    KitapListele();
                    Temizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                    baglanti.Close();
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBarkodNo.Text)) return;

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(
                    "UPDATE kitap SET kitapadi=@kitapadi, yazari=@yazari, yayinevi=@yayinevi, sayfasayisi=@sayfasayisi, " +
                    "turu=@turu, stoksayisi=@stoksayisi, rafno=@rafno, aciklama=@aciklama WHERE barkodno=@barkodno", baglanti
                );

                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kitapadi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@yazari", txtYazari.Text);
                komut.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
                komut.Parameters.AddWithValue("@sayfasayisi", txtSayfaSayisi.Text);
                komut.Parameters.AddWithValue("@turu", comboTuru.Text);
                komut.Parameters.AddWithValue("@stoksayisi", txtStokSayisi.Text);
                komut.Parameters.AddWithValue("@rafno", txtRafNo.Text);
                komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Güncelleme işlemi gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                daset.Tables["kitap"].Clear();
                KitapListele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                baglanti.Close();
            }
        }

        private void txtBarkodAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["kitap"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(
                "SELECT * FROM kitap WHERE barkodno LIKE @barkodno", baglanti
            );
            adtr.SelectCommand.Parameters.AddWithValue("@barkodno", "%" + txtBarkodAra.Text + "%");
            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            baglanti.Close();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBarkodNo.Text)) return;

            baglanti.Open();
            SqlCommand komut = new SqlCommand(
                "SELECT * FROM kitap WHERE barkodno=@barkodno", baglanti
            );
            komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
            SqlDataReader read = komut.ExecuteReader();

            if (read.Read())
            {
                txtKitapAdi.Text = read["kitapadi"].ToString();
                txtYazari.Text = read["yazari"].ToString();
                txtYayinevi.Text = read["yayinevi"].ToString();
                txtSayfaSayisi.Text = read["sayfasayisi"].ToString();
                comboTuru.Text = read["turu"].ToString();
                txtStokSayisi.Text = read["stoksayisi"].ToString();
                txtRafNo.Text = read["rafno"].ToString();
                txtAciklama.Text = read["aciklama"].ToString();
            }
            baglanti.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // TextBox veya MaterialTextBox temizleme
        private void Temizle()
        {
            foreach (Control item in Controls)
            {
                if (item is MaterialTextBox || item is TextBox)
                    item.Text = "";
            }
        }
    }
}
