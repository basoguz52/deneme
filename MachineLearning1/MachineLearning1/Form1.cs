using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearning1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] evbuyukluk = { 1, 2, 3, 4 };
        double[] evfiyat = { 1, 2, 3, 4 };






        private void button1_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            double teta0 = Convert.ToDouble(textBox1.Text);
            double teta1 = Convert.ToDouble(textBox2.Text);
            int m = Convert.ToInt16(textBox3.Text);


            for (int i = 0; i < 3; i++)
            {
                double h = teta0 + teta1 * evbuyukluk[i];
                double y = evfiyat[i];
                double hFarky = (h - y);
                double kare = hFarky * hFarky;
                toplam += kare;

                listBox1.Items.Add(h);
                listBox2.Items.Add(y);
                listBox3.Items.Add(hFarky);
                listBox4.Items.Add(kare);
            }

            double sonuc = toplam / (2 * m);
            listBox5.Items.Add("t0: " + teta0 + " t1: " + teta1 + " J(t0, t1): " + sonuc );

            label4.Text = sonuc.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();

        }
    }
}
