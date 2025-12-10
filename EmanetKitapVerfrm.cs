using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KutuphaneOtomasyonuuuuu
{
    public partial class EmanetKitapVerfrm : MaterialForm
    {
        SqlConnection baglanti = new SqlConnection(
            "Data Source=DESKTOP-6SCKJNF;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"
        );

        DataSet daset = new DataSet();

        public EmanetKitapVerfrm()
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

        private void EmanetKitapVerfrm_Load(object sender, EventArgs e)
        {
            SepetListele();
            KitapSayisi();
        }

        // SEPETİ LİSTELEME
        private void SepetListele()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM sepet", baglanti);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                baglanti.Close();
            }
        }

        // SEPETTEKİ TOPLAM KİTAP SAYISI
        private void KitapSayisi()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT ISNULL(SUM(kitapsayisi),0) FROM sepet", baglanti);
                lblKitapSayi.Text = komut.ExecuteScalar().ToString();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                baglanti.Close();
            }
        }

        // ÜYE BİLGİLERİ TEXTCHANGED
        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTcAra.Text))
            {
                txtAdSoyad.Text = "";
                txtYas.Text = "";
                txtTelefon.Text = "";
                lblKayitliKitapSayi.Text = "";
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM uye WHERE tc LIKE @tc", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTcAra.Text);
                SqlDataReader read = komut.ExecuteReader();
                if (read.Read())
                {
                    txtAdSoyad.Text = read["adsoyad"].ToString();
                    txtYas.Text = read["yas"].ToString();
                    txtTelefon.Text = read["telefon"].ToString();
                }
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand(
                    "SELECT ISNULL(SUM(kitapsayisi),0) FROM emanetkitaplar WHERE tc=@tc", baglanti
                );
                komut2.Parameters.AddWithValue("@tc", txtTcAra.Text);
                lblKayitliKitapSayi.Text = komut2.ExecuteScalar().ToString();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                baglanti.Close();
            }
        }

        // KİTAP BİLGİLERİ TEXTCHANGED
        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBarkodNo.Text))
            {
                txtKitapAdi.Text = "";
                txtYazari.Text = "";
                txtYayinevi.Text = "";
                txtSayfaSayisi.Text = "";
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM kitap WHERE barkodno LIKE @barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                SqlDataReader read = komut.ExecuteReader();
                if (read.Read())
                {
                    txtKitapAdi.Text = read["kitapadi"].ToString();
                    txtYazari.Text = read["yazari"].ToString();
                    txtYayinevi.Text = read["yayinevi"].ToString();
                    txtSayfaSayisi.Text = read["sayfasayisi"].ToString();
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                baglanti.Close();
            }
        }

        // SEPETE EKLEME
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBarkodNo.Text) || string.IsNullOrEmpty(txtKitapSayisi.Text))
            {
                MessageBox.Show("Lütfen kitap bilgilerini eksiksiz girin!");
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(
                    "INSERT INTO sepet(barkodno,kitapadi,yazari,yayinevi,sayfasayisi,kitapsayisi,teslimtarihi,iadetarihi) " +
                    "VALUES(@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@kitapsayisi,@teslimtarihi,@iadetarihi)", baglanti
                );

                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kitapadi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@yazari", txtYazari.Text);
                komut.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
                komut.Parameters.AddWithValue("@sayfasayisi", txtSayfaSayisi.Text);
                komut.Parameters.AddWithValue("@kitapsayisi", int.Parse(txtKitapSayisi.Text));
                komut.Parameters.AddWithValue("@teslimtarihi", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@iadetarihi", dateTimePicker2.Value);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kitap sepete eklendi!");

                SepetListele();
                KitapSayisi();

                // TextBox’ları temizle
                txtBarkodNo.Text = "";
                txtKitapAdi.Text = "";
                txtYazari.Text = "";
                txtYayinevi.Text = "";
                txtSayfaSayisi.Text = "";
                txtKitapSayisi.Text = "1";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                baglanti.Close();
            }
        }

        // SEPETTEN SİL
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            DialogResult dialog = MessageBox.Show("Kayıt silinsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(
                        "DELETE FROM sepet WHERE barkodno=@barkodno", baglanti
                    );
                    komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Silme işlemi yapıldı");
                    SepetListele();
                    KitapSayisi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                    baglanti.Close();
                }
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (lblKitapSayi.Text == "")
            {
                MessageBox.Show("Önce sepete kitap eklenmelidir!!!", "Uyarı");
                return;
            }

            // Yeni alınacak kitap sayısı
            int yeniKitap = int.Parse(lblKitapSayi.Text);

            // Üyenin önceden aldığı kitap sayısı (boşsa 0 kabul)
            int kayitliKitap = 0;
            if (!string.IsNullOrWhiteSpace(lblKayitliKitapSayi.Text))
                kayitliKitap = int.Parse(lblKayitliKitapSayi.Text);

            // Toplam 3 sınır kontrolü
            if (kayitliKitap + yeniKitap > 3)
            {
                MessageBox.Show("Emanet kitap sayısı 3'ten fazla olamaz!", "Uyarı");
                return;
            }

            // Üye bilgisi boşsa
            if (txtTcAra.Text == "" || txtAdSoyad.Text == "" || txtYas.Text == "" || txtTelefon.Text == "")
            {
                MessageBox.Show("Önce üye ismi seçmeniz gerekir!", "Uyarı");
                return;
            }

            // ----------------------------------------------------
            //   KİTAPLARI EMANET EDEN ANA KISIM
            // ----------------------------------------------------
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                    "insert into emanetkitaplar(tc,adsoyad,yas,telefon,barkodno,kitapadi,yazari,yayinevi,sayfasayisi,kitapsayisi,teslimtarihi,iadetarihi) " +
                    "values(@tc,@adsoyad,@yas,@telefon,@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@kitapsayisi,@teslimtarihi,@iadetarihi)",
                    baglanti);

                komut.Parameters.AddWithValue("@tc", txtTcAra.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@yas", txtYas.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                komut.Parameters.AddWithValue("@kitapadi", dataGridView1.Rows[i].Cells["kitapadi"].Value.ToString());
                komut.Parameters.AddWithValue("@yazari", dataGridView1.Rows[i].Cells["yazari"].Value.ToString());
                komut.Parameters.AddWithValue("@yayinevi", dataGridView1.Rows[i].Cells["yayinevi"].Value.ToString());
                komut.Parameters.AddWithValue("@sayfasayisi", dataGridView1.Rows[i].Cells["sayfasayisi"].Value.ToString());
                komut.Parameters.AddWithValue("@kitapsayisi", int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()));
                komut.Parameters.AddWithValue("@teslimtarihi", dataGridView1.Rows[i].Cells["teslimtarihi"].Value.ToString());
                komut.Parameters.AddWithValue("@iadetarihi", dataGridView1.Rows[i].Cells["iadetarihi"].Value.ToString());

                komut.ExecuteNonQuery();

                // Üyenin kitap sayısını artır
                SqlCommand komut2 = new SqlCommand(
                    "update uye set okukitapsayisi = okukitapsayisi + @adet where tc=@tc",
                    baglanti);
                komut2.Parameters.AddWithValue("@adet", int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()));
                komut2.Parameters.AddWithValue("@tc", txtTcAra.Text);
                komut2.ExecuteNonQuery();

                // Kitap stok düş
                SqlCommand komut3 = new SqlCommand(
                    "update kitap set stoksayisi = stoksayisi - @adet where barkodno=@barkodno",
                    baglanti);
                komut3.Parameters.AddWithValue("@adet", int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()));
                komut3.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                komut3.ExecuteNonQuery();

                baglanti.Close();
            }

            // Sepeti temizle
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("delete from sepet", baglanti);
            komut4.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kitap(lar) emanet edildi");

            // Ekranı yenile
            if (daset.Tables.Contains("sepet"))
                daset.Tables["sepet"].Clear();

            SepetListele();
            txtTcAra.Text = "";
            lblKitapSayi.Text = "";
            KitapSayisi();
            lblKayitliKitapSayi.Text = "";
        }


    }
}


