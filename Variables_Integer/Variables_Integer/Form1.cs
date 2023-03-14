using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables_Integer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kenar, alan, cevre;
            kenar = 10;
            alan = kenar * kenar;
            cevre = 4 * kenar;
            label1.Text = "Alan: " + alan + " Çevre: " + cevre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kısa, uzun, alan, cevre;
            kısa = 10;
            uzun = 20;
            alan = kısa * uzun;
            cevre = (kısa + uzun) * 2;
            label2.Text = "Alan: " + alan + " Çevre: " + cevre;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sinav1, sinav2, sinav3, ort;
            sinav1 = 90;
            sinav2 = 100;
            sinav3 = 94;
            ort = (sinav1 + sinav2 + sinav3) / 3;
            label3.Text = "Ortalama: " + ort;

        }
    }
}
