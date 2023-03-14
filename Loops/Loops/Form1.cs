using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 1; i < 5; i++)
            {
                listBox1.Items.Add(i);
                listBox1.Items.Add(5 - i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Break Point kullanırken F11 ile devam edilir. İstediğiniz kontrolleri bu şekilde yapabilirsiniz.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);

            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    listBox3.Items.Add(i);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 2; i <= 10; i += 2)
            {
                toplam += i;
            }
            label3.Text = toplam.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox2.Text);
            long sonuc = 1;

            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
                listBox4.Items.Add(sonuc);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 5)
            {
                listBox5.Items.Add("Merhaba Samsun");
                i++;

            }


            int a = 1;
            int toplam = 0;
            while (a <= 5)
            {
                toplam += a;
                listBox6.Items.Add(a);
                a++;
            }
            listBox6.Items.Add("Toplam:" + toplam);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int i = 18;
            do
            {
                listBox7.Items.Add("Merhaba Ordu");
                listBox7.Items.Add("Do While döngüsünde kod bloğu mutlaka bir kez çalışır.");
                i++;
            }
            while (i <= 10);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        
        int sayac = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sayac++;
            label4.Text = sayac.ToString();
            if (sayac == 2)
            {
                this.BackColor = Color.Red;
            }
            else if (sayac == 4)
            {
                this.BackColor = Color.Green;
                sayac = 0;
            }


        }

    }
}
