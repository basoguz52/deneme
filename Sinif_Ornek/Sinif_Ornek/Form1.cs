using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinif_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba araba1 = new Araba();
            araba1.renk = "Mavi";
            araba1.hiz = 160;
            araba1.motor = 1245.56;
            araba1.fiyat = 50000;
            araba1.durum = 's';
            araba1.YIL = -2016;
            araba1.MARKA = "Ford";
            araba1.muayene = 2017;
            araba1.plaka = "52 Oİ 123";
            araba1.sahibi = "Oğuz";


            label1.Text = araba1.renk;
            label2.Text = araba1.hiz.ToString();
            label3.Text = araba1.motor.ToString();
            label4.Text = araba1.fiyat.ToString();
            label5.Text = araba1.durum.ToString();
            label6.Text = araba1.YIL.ToString();
            label7.Text = araba1.MARKA;
            label8.Text = araba1.muayene.ToString();
            label9.Text = araba1.plaka;
            label10.Text = araba1.sahibi;

            pictureBox1.BackColor = Color.CadetBlue;
        }
    }
}
