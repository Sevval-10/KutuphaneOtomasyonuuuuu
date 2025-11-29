using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonuuuuu
{
    public partial class AnaSayfafrm : Form
    {
        public AnaSayfafrm()
        {
            InitializeComponent();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            UyeEklefrm uyeekle = new UyeEklefrm();
            uyeekle.ShowDialog();
        }

        private void btnUyeListele_Click(object sender, EventArgs e)
        {
            UyeListelemefrm uyeliste=new UyeListelemefrm();
           uyeliste.ShowDialog();
        }
=======
            UyeEklefrm uyeekle=new UyeEklefrm();
            uyeekle.ShowDialog();
        }
>>>>>>> 8a7dd2eb5b8e9b08b0fab91f47d25e8754ec62fc
    }
}
