using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KdvVergiOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double urun = Convert.ToDouble(textBox1.Text);
            double kdv8 = urun * 0.08;
            double kdv18 = urun * 0.18;
            listBox1.Items.Add("Ürünün %8 KDV ile fiyatı: " + (urun + kdv8) + "-Ürünün %18 KDV ile fiyatı: " + (urun + kdv18));
        }
    }
}
