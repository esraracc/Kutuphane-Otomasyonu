using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane.FORM
{
    public partial class arayuzForm : Form
    {
        public arayuzForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uyeIslemlerForm formGoster = new uyeIslemlerForm();
            formGoster.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kitapIslemlerForm formGoster = new kitapIslemlerForm();
            formGoster.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            emanetKitapVerForm formGoster = new emanetKitapVerForm();
            formGoster.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            emanetIadeIslemlerForm formGoster = new emanetIadeIslemlerForm();
            formGoster.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kitapDurumuForm formGoster = new kitapDurumuForm();
            formGoster.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            grafikForm formGoster = new grafikForm();
            formGoster.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kitaplarForm formGoster = new kitaplarForm();
            formGoster.Show();
        }
    }
}
