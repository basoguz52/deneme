using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void renklendir()
        {
            textBox1.BackColor = Color.Green;
            textBox2.BackColor = Color.Blue;
            textBox3.BackColor = Color.Red;
            textBox4.BackColor = Color.DarkViolet;
        }

        private void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void rol()
        {
            textBox1.Text = "Oğuzhan";
            textBox2.Text = "BAŞ";
            textBox3.Text = "ORDU";
            textBox4.Text = 21.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rol();
        }

        private int toplama(int s1, int s2)
        {
            int toplam;
            return toplam = s1 + s2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = toplama(8, 9).ToString();
        }

        int kup(int sayi)
        {
            return sayi = sayi * sayi * sayi;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Text = kup(Convert.ToInt16(textBox5.Text)).ToString();
        }
    }
}
