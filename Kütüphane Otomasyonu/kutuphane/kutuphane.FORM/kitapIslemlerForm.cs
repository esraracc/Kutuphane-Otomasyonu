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
    public partial class kitapIslemlerForm : Form
    {
        KitapBLL bll;
        public kitapIslemlerForm()
        {
            InitializeComponent();
            bll = new KitapBLL();
        }         

        private void kitapIslemlerForm_Load(object sender, EventArgs e)
        {
            //Kategori combobox veri ekleme
            cmb_k.Items.Add("Aksiyon - Macera");
            cmb_k.Items.Add("Aşk");
            cmb_k.Items.Add("Bilimkurgu");
            cmb_k.Items.Add("Fantastik");
            cmb_k.Items.Add("Klasikler");
            cmb_k.Items.Add("Korku-Gerilim");
            cmb_k.Items.Add("Polisiye");
            cmb_k.Items.Add("Roman");
            cmb_k.Items.Add("Mühendislik");
            cmb_k.Items.Add("Matematik");
            //Yayınevi combobox veri ekleme
            cmb_ye.Items.Add("Bilgi Yayınevi");
            cmb_ye.Items.Add("Everest Yayınları");
            cmb_ye.Items.Add("Halk Kitabevi");
            cmb_ye.Items.Add("Muştu Yayınları");
            cmb_ye.Items.Add("Literatür Yayıncılık");
            cmb_ye.Items.Add("Kaynak Yayınları");
            cmb_ye.Items.Add("Siyah Beyaz Yayınları");
            cmb_ye.Items.Add("Dost Kitabevi");
            cmb_ye.Items.Add("Çınar Yayınları");
            cmb_ye.Items.Add("Akademisyen Kitabevi");
            //Yazar combobox veri ekleme
            cmb_y.Items.Add("Sabahattin Ali");
            cmb_y.Items.Add("Yaşar Kemal");
            cmb_y.Items.Add("Zülfü Livaneli");
            cmb_y.Items.Add("Ahmet Batman");
            cmb_y.Items.Add("İskender Pala");
            cmb_y.Items.Add("Ahmet Ümit");
            cmb_y.Items.Add("Mustafa Kutlu");
            cmb_y.Items.Add("Orhan Pamuk");
            cmb_y.Items.Add("Peyami Safa");
            cmb_y.Items.Add("Elif Şafak");
        }
        private void btn_listele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.kitapListele();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int txtISBN = Convert.ToInt32(txt_ısbn.Text);
            string txtAd = txt_ad.Text;
            string mtxtYayinT = Convert.ToString(mtxt_YayinT.Text);
            int txtSayfaS = Convert.ToInt32(txt_sayfaS.Text);
            string cmbYayinEvi = cmb_ye.Text;
            string cmbYazar = cmb_y.Text;
            string cmbKategori = cmb_k.Text;
            int stokS = Convert.ToInt32(txt_stokS.Text);
            string rafNo = txt_rafNo.Text;
            string ozet = rtxt_ozet.Text;

            bll.kitapEkle(txtISBN, txtAd, mtxtYayinT, txtSayfaS, cmbYayinEvi, cmbYazar, cmbKategori, stokS, rafNo, ozet);
            MessageBox.Show("Kitap Eklendi.");
            dataGridView1.DataSource = bll.kitapListele();
            txt_ısbn.Clear();
            txt_ad.Clear();
            mtxt_YayinT.Clear();
            txt_sayfaS.Clear();
            txt_rafNo.Clear();
            txt_stokS.Clear();
            rtxt_ozet.Clear();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int txtISBN = Convert.ToInt32(txt_ısbn.Text);
            string txtAd = txt_ad.Text;
            string mtxtYayinT = Convert.ToString(mtxt_YayinT.Text);
            int txtSayfaS = Convert.ToInt32(txt_sayfaS.Text);
            string cmbYayinEvi = cmb_ye.Text;
            string cmbYazar = cmb_y.Text;
            string cmbKategori = cmb_k.Text;
            int stokS = Convert.ToInt32(txt_stokS.Text);
            string rafNo = txt_rafNo.Text;
            string ozet = rtxt_ozet.Text;

            bll.kitapGuncelle(txtISBN, txtAd, mtxtYayinT, txtSayfaS, cmbYayinEvi, cmbYazar, cmbKategori, stokS, rafNo, ozet);
            MessageBox.Show("Kitap Güncellendi.");
            dataGridView1.DataSource = bll.kitapListele();
            txt_ısbn.Clear();
            txt_ad.Clear();
            mtxt_YayinT.Clear();
            txt_sayfaS.Clear();
            txt_rafNo.Clear();
            txt_stokS.Clear();
            rtxt_ozet.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_ısbn.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_ad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                mtxt_YayinT.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_sayfaS.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmb_ye.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmb_y.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmb_k.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_stokS.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                txt_rafNo.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                rtxt_ozet.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show("Satır üzerindeki bilgiye tıklayınız.");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int txtISBN = Convert.ToInt32(txt_ısbn.Text);
            bll.kitapSil(txtISBN);
            MessageBox.Show("Kitap Silindi.");
            dataGridView1.DataSource = bll.kitapListele();
            txtSil.Clear();
        }

    }
}
