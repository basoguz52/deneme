using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtAd.Text = txtSoyad.Text = txtMeslek.Text = txtYas.Text = "";
            btnsil.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            this.ActiveControl = txtAd;
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {

        }
    }
}
