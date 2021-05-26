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
    public partial class uyeIslemlerForm : Form
    {
        UyeBLL bll;
        public uyeIslemlerForm()
        {
            InitializeComponent();
            bll = new UyeBLL(); // BLL katmanıma ait uye işlemlerinin yapılacağı sınıftan nesne oluşturuldu.
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.uyeListele();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int tcKimlik = Convert.ToInt32(txt_tc.Text);
            string uyeAd = txt_ad.Text;
            string uyeSoyad = txt_soyad.Text;
            string telefon = mtxt_tel.Text;
            string mail = txt_mail.Text;
            string adres = txt_adres.Text;

            bll.uyeEkle(tcKimlik, uyeAd, uyeSoyad, telefon, mail, adres);
            MessageBox.Show("Üye Eklendi.");
            dataGridView1.DataSource = bll.uyeListele();
            txt_tc.Clear();
            txt_ad.Clear();
            txt_soyad.Clear();
            mtxt_tel.Clear();
            txt_mail.Clear();
            txt_adres.Clear();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int tcKimlik = Convert.ToInt32(txt_tc.Text);
            string uyeAd = txt_ad.Text;
            string uyeSoyad = txt_soyad.Text;
            string telefon = mtxt_tel.Text;
            string mail = txt_mail.Text;
            string adres = txt_adres.Text;

            bll.uyeGuncelle(tcKimlik, uyeAd, uyeSoyad, telefon, mail, adres);
            MessageBox.Show("Üye Güncellendi.");
            dataGridView1.DataSource = bll.uyeListele();
            txt_tc.Clear();
            txt_ad.Clear();
            txt_soyad.Clear();
            mtxt_tel.Clear();
            txt_mail.Clear();
            txt_adres.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            txt_tc.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            mtxt_tel.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_mail.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_adres.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show("Satır üzerindeki bilgiye tıklayınız.");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int tcKimlik = Convert.ToInt32(txtSil.Text);
            bll.uyeSil(tcKimlik);
            MessageBox.Show("Üye Silindi.");
            dataGridView1.DataSource = bll.uyeListele();
            txtSil.Clear();
        }

        private void uyeIslemlerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
