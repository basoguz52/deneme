using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] kisiler = { "Ali", "Ahmet", "Mehmet", "Aslı", "Hakan", "Ayşe", "Demet" };
            label1.Text = kisiler[6];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 9, 4, 6, 7, 3, 1, 8, 2, 5 };
            label2.Text = sayilar[5].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double[] ondalikliSayilar = { 12.23, 64.87, 99.15, 31.31, 27.64 };
            label3.Text = ondalikliSayilar[3].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            char[] harfler = { 'O', 'Ğ', 'U', 'Z', 'H', 'A', 'N', 'B', 'A', 'Ş' };
            label4.Text = harfler[7].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            char[] harfler = { 'O', 'Ğ', 'U', 'Z', 'H', 'A', 'N', 'B', 'A', 'Ş' };

            for (int i = 0; i < harfler.Length; i++)
            {
                listBox1.Items.Add(harfler[i]);
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 4, 2, 3, 1, 5, 6, 7, 9 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    listBox1.Items.Add(sayilar[i]);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 94, 72, 63, 51, 15, 36, 87, 49 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0 && sayilar[i] > 10)
                {
                    listBox1.Items.Add(sayilar[i]);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string[] kisiler = { "Ahmet", "Ali", "MEhmet", "Mesut", "berna" ,"oğuZHAn"};

            foreach (string kisi in kisiler)
            {
                listBox2.Items.Add(kisi.ToUpper());
                listBox2.Items.Add(kisi.ToLower());
                
                listBox2.Items.Add(kisi);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
    }
}
