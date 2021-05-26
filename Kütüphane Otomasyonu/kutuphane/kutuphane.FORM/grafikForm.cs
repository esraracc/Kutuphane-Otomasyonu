using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using kutuphane.BLL;
using System.Data.OleDb;

namespace kutuphane.FORM
{
    public partial class grafikForm : Form
    {
        public grafikForm()
        {
            InitializeComponent();
        }

        private void grafikForm_Load(object sender, EventArgs e)
        {
            GrafikBLL bll = new GrafikBLL();
            label1.BackColor = Color.Blue;
            label2.BackColor = Color.Yellow;
            label3.BackColor = Color.Red;
            bll.zedgraph(zedGraph);
            // labellere bilgiler yazılır.
            label1.Text = bll.TumK;
            label2.Text = bll.EmanetVerilen;
            label3.Text = bll.EmanetVerilmeyen;
        }
    }
}
