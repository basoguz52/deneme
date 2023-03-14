using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saat, dakika, saniye = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            
            label1.Text = saniye.ToString();

            if (saniye == 60)
            {
                dakika++;
                label2.Text = dakika.ToString();
                saniye = 0;
                label1.Text = saniye.ToString();
                if(dakika == 10)
                {
                    saat++;
                    label3.Text = saat.ToString();
                    dakika = 0;
                }
            }
        }
    }
}
