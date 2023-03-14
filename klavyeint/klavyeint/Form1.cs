using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klavyeint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt16(textBox1.Text);
            label2.Text = sayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox1.Text);
            sayi = sayi * sayi;
            label2.Text = sayi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox1.Text);
            sayi = sayi * sayi * sayi;
            label2.Text = sayi.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi = 18 * 18;
            label2.Text = sayi.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi = 19 * 19;
            label2.Text = sayi.ToString();
        }
    }
}
