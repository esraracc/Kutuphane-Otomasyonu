using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kutuphane.BLL;

namespace kutuphane.FORM
{
    public partial class kitaplarForm : Form
    {
        public kitaplarForm()
        {
            InitializeComponent();
        }

        KitapBLL bll = new KitapBLL();
        private void btn_Goster_Click(object sender, EventArgs e)
        {
            bll.kitapBilgiGetir(Convert.ToInt32(txt_ısbn.Text));
            label2.Text = bll.kitapAd;
            label4.Text = bll.sayfaS;
            label6.Text = bll.kategori;
            label8.Text = bll.yazar;
            label10.Text = bll.yayinE;
            label12.Text = bll.yayinT;
            label14.Text = bll.stok.ToString();
            label16.Text = bll.raf;
            label18.Text = bll.ozet;
        }

        private void kitaplarForm_Load(object sender, EventArgs e)
        {

        }
    }
}
