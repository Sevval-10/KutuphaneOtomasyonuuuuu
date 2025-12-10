using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonuuuuu
{
    public partial class Grafikfrm : Form
    {
        public Grafikfrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ZEYNEP\\SQLEXPRESS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        DataSet daset = new DataSet();
        private void Grafikfrm_Load(object sender, EventArgs e)
        {
            baglanti.Open();    
            SqlCommand komut=new SqlCommand("select adsoyad,okukitapsayisi from uye",baglanti);
            SqlDataReader reader = komut.ExecuteReader();   
            while(reader.Read())
            {
                chart1.Series["Okunan Kitap Sayısı"].Points.AddXY(reader["adsoyad"].ToString(),reader["okukitapsayisi"]);  
            }
            baglanti.Close();
            
        }
    }
}
