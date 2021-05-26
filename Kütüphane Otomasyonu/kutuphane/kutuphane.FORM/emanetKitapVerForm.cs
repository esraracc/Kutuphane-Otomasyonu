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
    public partial class emanetKitapVerForm : Form
    {
        EmanetBLL bll;
        public emanetKitapVerForm()
        {
            InitializeComponent();
            bll = new EmanetBLL();
        }

        private void emanetKitapVer_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.sepetListele();
        }

        private void btn_emanetVer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                int tc = Convert.ToInt32(txtTc.Text);
                string uyeAd = textBox2.Text;
                string uyetel = textBox3.Text;
                int isbn = int.Parse(dataGridView1.Rows[i].Cells["ISBN"].Value.ToString());
                string ad = dataGridView1.Rows[i].Cells["kitapAdi"].Value.ToString();
                string yazar = dataGridView1.Rows[i].Cells["yazar"].Value.ToString();
                string sayfaS = dataGridView1.Rows[i].Cells["sayfaSayisi"].Value.ToString();
                int kitapS = int.Parse(dataGridView1.Rows[i].Cells["kitapSayisi"].Value.ToString());
                string dtKayit = dataGridView1.Rows[i].Cells["teslimTarihi"].Value.ToString();
                string dtIadeT = dataGridView1.Rows[i].Cells["iadeTarihi"].Value.ToString();
                string dtSonTeslimT = dataGridView1.Rows[i].Cells["sonTeslimTarihi"].Value.ToString();
                bll.emanetVer(tc, uyeAd, uyetel, isbn, ad, yazar, sayfaS, kitapS, dtKayit, dtSonTeslimT, dtIadeT);
            }
            MessageBox.Show("Kitap(lar) emanet olarak verilmiştir.");
            dataGridView1.DataSource = bll.sepetListele();
            bll.sepetListele().Clear();
            txtTc.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int isbn = Convert.ToInt32(txtIsbn.Text);
            int kitapS = Convert.ToInt32(textBox1.Text);
            string dtkayit = Convert.ToString(DateTime.Now);
            string dtSonTeslim = Convert.ToString(DateTime.Now.AddDays(7));
            string dtIadeT = " ";
            bll.sepetEkle(isbn, textBox5.Text, textBox7.Text, textBox8.Text, kitapS, dtkayit, dtIadeT, dtSonTeslim);
            MessageBox.Show("Kitap(lar) sepete eklendi.");
            dataGridView1.DataSource = bll.sepetListele();
            txtIsbn.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox1.Clear();
        }
        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            string tc = txtTc.Text;
            bll.uyeGetir(tc);
            textBox2.Text = bll.add;
            textBox3.Text = bll.tell;
        }
        private void txtIsbn_TextChanged(object sender, EventArgs e)
        {
            string isbn = txtIsbn.Text;
            bll.kitapGetir(isbn);
            textBox5.Text = bll.kitapad;
            textBox7.Text = bll.yazar;
            textBox8.Text = bll.sayfaS;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int secim = dataGridView1.SelectedRows.Count-1;
            int sil = Convert.ToInt32(dataGridView1.Rows[secim].Cells["ISBN"].Value.ToString());
            bll.sepetSil(sil);
            MessageBox.Show("Kitap sepetten silindi.");
            dataGridView1.DataSource = bll.sepetListele();
        }
    }
}
