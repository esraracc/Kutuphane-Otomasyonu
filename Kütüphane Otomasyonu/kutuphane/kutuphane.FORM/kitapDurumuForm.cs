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
    public partial class kitapDurumuForm : Form
    {
        EmanetBLL bll;
        public kitapDurumuForm()
        {
            InitializeComponent();
            bll = new EmanetBLL();
        }
        private void renklendirme()
        {
            DateTime sonTeslim, iadeT;
            int sayac = 0; // Kitabı geç teslim eden kişiye her geç teslim ettiği gün kadar +1TL borcu tutar.
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                // Tarihler datagridviewden alınarak tarih formatına atanır.
                sonTeslim = DateTime.Parse(dataGridView1.Rows[i].Cells["sonTeslimTarihi"].Value.ToString());
                iadeT = Convert.ToDateTime(dataGridView1.Rows[i].Cells["iadeTarihi"].Value.ToString());
                // İki tarih arasındaki güne göre renk belirleneceği için int(sayı) formatına çevrilerek aşağıda işlem yapılmıştır.
                if (Convert.ToInt32(sonTeslim.Day.ToString()) - Convert.ToInt32(iadeT.Day.ToString()) == 2)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    dataGridView1.ForeColor = Color.White;
                }
                else if(Convert.ToInt32(sonTeslim.Day.ToString()) - Convert.ToInt32(iadeT.Day.ToString()) < 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dataGridView1.ForeColor = Color.White;
                    sayac++;
                }
                else if(Convert.ToInt32(sonTeslim.Day.ToString()) - Convert.ToInt32(iadeT.Day.ToString()) >= 0 && 
                    Convert.ToInt32(sonTeslim.Day.ToString()) - Convert.ToInt32(iadeT.Day.ToString()) <= 7)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dataGridView1.ForeColor = Color.White;
                }
                else
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }            
        }

        private void kitapDurumuForm_Load(object sender, EventArgs e)
        {           
            dataGridView1.DataSource = bll.emanetListele();
            renklendirme();          
        }

        private void txt_uyeTc_TextChanged(object sender, EventArgs e)
        {
            int uyeTc = Convert.ToInt32(txt_uyeTc.Text);
            dataGridView1.DataSource = bll.uyeAra(uyeTc);
        }

        private void txt_Isbn_TextChanged(object sender, EventArgs e)
        {
            int isbn = Convert.ToInt32(txt_Isbn.Text);
            dataGridView1.DataSource = bll.kitapAra(isbn);
        }
    }
}
