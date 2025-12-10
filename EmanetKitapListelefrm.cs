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
    public partial class EmanetKitapListelefrm : Form
    {
        public EmanetKitapListelefrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ZEYNEP\\SQLEXPRESS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        DataSet daset = new DataSet();
        private void EmanetKitapListelefrm_Load(object sender, EventArgs e)
        {
            EmanetListele();
            comboBox1.SelectedIndex = 0;
        }

        private void EmanetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            if(comboBox1.SelectedIndex == 0)
            {
                EmanetListele();    
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where '"+DateTime.Now.ToString()+"'>iadetarihi", baglanti);
                adtr.Fill(daset, "EmanetKitaplar");
                dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
                baglanti.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where '" + DateTime.Now.ToString() + "'<=iadetarihi", baglanti);
                adtr.Fill(daset, "EmanetKitaplar");
                dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
                baglanti.Close();
            }
        }
    }
}
