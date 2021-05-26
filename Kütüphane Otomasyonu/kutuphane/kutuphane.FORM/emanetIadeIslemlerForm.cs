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
    public partial class emanetIadeIslemlerForm : Form
    {
        EmanetBLL bll;
        public emanetIadeIslemlerForm()
        { 
            InitializeComponent();
            bll = new EmanetBLL();
        }
        private void emanetIadeIslemlerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.iadeListele();
            
        }
        private void txt_uyeTc_TextChanged(object sender, EventArgs e)
        {
            int uyeTc = Convert.ToInt32(txt_uyeTc.Text);
            dataGridView1.DataSource = bll.uyeAra(uyeTc);
        }

        private void txt_Isbn_TextChanged(object sender, EventArgs e)
        {
            int isbn = Convert.ToInt32(txt_Isbn.Text);
            dataGridView1.DataSource = bll.uyeAra(isbn);
        }

        private void btn_teslimAl_Click(object sender, EventArgs e)
        {
            int secim = dataGridView1.SelectedRows.Count - 1; // Datagridviewde seçilen satır.
            // Datagridviewdeki istenilen satır ve sütundaki veri.
            int uyeTc = int.Parse(dataGridView1.Rows[secim].Cells["uyeTc"].Value.ToString());             
            int isbn = int.Parse(dataGridView1.Rows[secim].Cells["ISBN"].Value.ToString());
            int kitapS = int.Parse(dataGridView1.Rows[secim].Cells["kitapSayisi"].Value.ToString());
            string iadeT = Convert.ToString(DateTime.Now);
            bll.iadeAl(uyeTc, isbn, kitapS, iadeT);
            MessageBox.Show("Kitap(lar) teslim edildi.");
            dataGridView1.DataSource = bll.iadeListele();
            bll.uyeBorc();
        }
    }
}
