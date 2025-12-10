using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KutuphaneOtomasyonuuuuu
{
    public partial class UyeEklefrm : MaterialForm
    {
        public UyeEklefrm()
        {
            InitializeComponent();

            // MaterialSkin tema ayarı
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

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            // Zorunlu alan kontrolü
            if (txtTc.Text.Trim() == "" || txtAdSoyad.Text.Trim() == "")
            {
                MessageBox.Show("TC ve Ad Soyad alanları boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(
                    "INSERT INTO uye(tc,adsoyad,yas,cinsiyet,telefon,adres,email,okukitapsayisi) " +
                    "VALUES(@tc,@adsoyad,@yas,@cinsiyet,@telefon,@adres,@email,@okukitapsayisi)", baglanti);

                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@yas", txtYas.Text);
                komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.SelectedItem?.ToString() ?? "");
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@adres", txtAdres.Text);
                komut.Parameters.AddWithValue("@email", txtEmail.Text);
                komut.Parameters.AddWithValue("@okukitapsayisi", txtOkunanSayi.Text);

                komut.ExecuteNonQuery();

                MessageBox.Show("Üye başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // MaterialTextBox kontrollerini temizle
                foreach (Control item in Controls)
                {
                    if (item is MaterialTextBox)
                    {
                        item.Text = "";
                    }
                }

                txtOkunanSayi.Text = "0"; // Default değer
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void UyeEklefrm_Load(object sender, EventArgs e)
        {
            txtOkunanSayi.Text = "0"; // Form açıldığında default değer
        }
    }
}
