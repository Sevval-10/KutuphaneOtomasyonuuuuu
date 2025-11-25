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
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=DESKTOP-6SCKJNF;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        private void btnİptal_Click(object sender, EventArgs e)
        {
            this .Close();
        }
       
        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into uye(tc,adsoyad,yas,cinsiyet,telefon,adres,email,okukitapsayisi) values(@tc,@adsoyad,@yas,@cinsiyet,@telefon,@adres,@email,@okukitapsayisi)", baglanti);
            komut.Parameters.AddWithValue("@tc",txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad",txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@yas",txtYas.Text);
            komut.Parameters.AddWithValue("@cinsiyet",comboCinsiyet.Text);
            komut.Parameters.AddWithValue("@telefon",txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres",txtAdres.Text);
            komut.Parameters.AddWithValue("@email",txtEmail.Text);
            komut.Parameters.AddWithValue("@okukitapsayisi",txtOkunanSayi.Text);


        }
    }
}
