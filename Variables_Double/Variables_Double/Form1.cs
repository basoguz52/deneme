using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables_Double
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi = 4.25;
            label1.Text = sayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sinav1, sinav2, sinav3, ort;
            sinav1 = 60;
            sinav2 = 70;
            sinav3 = 79;
            ort = (sinav1 + sinav2 + sinav3) / 3;
            label2.Text = ort.ToString("0.00");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            label3.Text = sayi.ToString();


        }
    }
}
