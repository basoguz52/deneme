using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SınavDurumuHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, proje, ort;
            string durum;

            s1 = Convert.ToDouble(maskedTextBox1.Text);
            s2 = Convert.ToDouble(maskedTextBox2.Text);
            proje = Convert.ToDouble(maskedTextBox3.Text);

            ort = (s1 + s2 + proje) / 3;
            panel1.Visible = true;
            if (ort >= 50)
            {
                durum = "Geçti";
                panel1.BackColor = Color.Green;
            }
            else
            {
                durum = "Kaldı";
                panel1.BackColor = Color.Red;
            }

            textBox1.Text = ort.ToString("0.00");
            label5.Text = durum;
            

        }
    }
}
