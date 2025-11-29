using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KutuphaneOtomasyonuuuuu
{
    public partial class UyeEklefrm : Form
    {
        public UyeEklefrm()
        {
<<<<<<< HEAD
            InitializeComponent();//Data Source=ZEYNEP\\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonuuuuu;Integrated Security=True;TrustServerCertificate=True
        }//Data Source=ZEYNEP\SQLEXPRESS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True
        //Data Source=ZEYNEP\\SQLEXPRESS;InitialCatalog=KutuphaneOtomasyonuuuuu;IntegratedSecurity=True;Encrypt=True;TrustServerCertificate=True
        SqlConnection baglanti = new SqlConnection("Data Source=ZEYNEP\\SQLEXPRESS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
=======
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=DESKTOP-6SCKJNF;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
>>>>>>> 8a7dd2eb5b8e9b08b0fab91f47d25e8754ec62fc
        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into uye(tc,adsoyad,yas,cinsiyet,telefon,adres,email,okukitapsayisi) values(@tc,@adsoyad,@yas,@cinsiyet,@telefon,@adres,@email,@okukitapsayisi)", baglanti);
<<<<<<< HEAD
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@yas", txtYas.Text);
            komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            komut.Parameters.AddWithValue("@okukitapsayisi", txtOkunanSayi.Text);
            //komut.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye Kaydı Yapıldı");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtOkunanSayi)
                    {
                        item.Text = "";
                    }
=======
            komut.Parameters.AddWithValue("@tc",txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad",txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@yas",txtYas.Text);
            komut.Parameters.AddWithValue("@cinsiyet",comboCinsiyet.Text);
            komut.Parameters.AddWithValue("@telefon",txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres",txtAdres.Text);
            komut.Parameters.AddWithValue("@email",txtEmail.Text);
            komut.Parameters.AddWithValue("@okukitapsayisi",txtOkunanSayi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye Kaydı Yapıldı");
            foreach (Control item in Controls) 
            {
                if (item is TextBox)
                {
                    if (item!=txtOkunanSayi)
                    {
                        item.Text = "";
                    }
                   
                }

            }
>>>>>>> 8a7dd2eb5b8e9b08b0fab91f47d25e8754ec62fc

                }

            }
        }
    }
}