using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KurbagaOyunu
{
    public partial class Form1 : Form
    {
        string sag = "C:\\Users\\Oguzhan\\Desktop\\Udemy\\resiler\\sari-kurbaga-sag.png";
        string sol = "C:\\Users\\Oguzhan\\Desktop\\Udemy\\resiler\\yesil-kurbaga.png";
        public Form1()
        {
            InitializeComponent();
        }

        int hamlesayac = 0;
        int tursayac = 1;
        public void hamlesayici()
        {
            hamlesayac++;
            label1.Text = "Hamle Sayısı: " + hamlesayac;
        }
        void bitis()
        {
            if (pictureBox1.ImageLocation == sol &&
            pictureBox2.ImageLocation == sol &&
            pictureBox3.ImageLocation == sol &&
            pictureBox5.ImageLocation == sag &&
            pictureBox6.ImageLocation == sag &&
            pictureBox7.ImageLocation == sag)
            {
                MessageBox.Show("Oyun" + hamlesayac + " Hamlede\n" + --tursayac + " Denemede Tamamlandı", "Oyun Bitti", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = sag;
            pictureBox2.ImageLocation = sag;
            pictureBox3.ImageLocation = sag;
            pictureBox4.ImageLocation = null;
            pictureBox5.ImageLocation = sol;
            pictureBox6.ImageLocation = sol;
            pictureBox7.ImageLocation = sol;

            void playSimpleSound()
            {
                System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer(@"C:\Users\Oguzhan\Desktop\Udemy\KurbagaOyunu\\loser.wav");
                simpleSound.Play();
            }

            playSimpleSound();

            label2.Text = "Tur Sayısı: " + tursayac++;

            hamlesayac = 0;
            label1.Text = "Hamle Sayısı " + hamlesayac;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation == sag)
            {
                if (pictureBox2.ImageLocation == null)
                {
                    pictureBox2.ImageLocation = pictureBox1.ImageLocation;
                    pictureBox1.ImageLocation = null;

                }
                else if (pictureBox2.ImageLocation != null && pictureBox3.ImageLocation == null)
                {
                    pictureBox3.ImageLocation = pictureBox1.ImageLocation;

                    pictureBox1.ImageLocation = null;
                }
                
            }
            hamlesayici();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.ImageLocation == sag)
            {
                if (pictureBox3.ImageLocation == null)
                {
                    pictureBox3.ImageLocation = pictureBox2.ImageLocation;
                    pictureBox2.ImageLocation = null;
                }
                else if (pictureBox3.ImageLocation != null && pictureBox4.ImageLocation == null)
                {
                    pictureBox4.ImageLocation = pictureBox2.ImageLocation;
                    pictureBox2.ImageLocation = null;
                }
                
            }
            else if (pictureBox2.ImageLocation == sol && pictureBox1.ImageLocation == null)
            {
                pictureBox1.ImageLocation = pictureBox2.ImageLocation;
                pictureBox2.ImageLocation = null;
            }
            hamlesayici();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.ImageLocation == sag)
            {
                if (pictureBox4.ImageLocation == null)
                {
                    pictureBox4.ImageLocation = pictureBox3.ImageLocation;
                    pictureBox3.ImageLocation = null;
                }
                else if (pictureBox4.ImageLocation != null && pictureBox5.ImageLocation == null)
                {
                    pictureBox5.ImageLocation = pictureBox3.ImageLocation;
                    pictureBox3.ImageLocation = null;
                }
                    
            }
            else if (pictureBox3.ImageLocation == sol)
            {
                if (pictureBox2.ImageLocation == null)
                {
                    pictureBox2.ImageLocation = pictureBox3.ImageLocation;
                    pictureBox3.ImageLocation = null;
                }
                else if (pictureBox2.ImageLocation != null && pictureBox1.ImageLocation == null)
                {
                    pictureBox1.ImageLocation = pictureBox3.ImageLocation;
                    pictureBox3.ImageLocation = null;
                }

            }
            hamlesayici();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.ImageLocation == sag)
            {
                if (pictureBox5.ImageLocation == null)
                {
                    pictureBox5.ImageLocation = pictureBox4.ImageLocation;
                    pictureBox4.ImageLocation = null;
                }
                else if (pictureBox5.ImageLocation != null && pictureBox6.ImageLocation == null)
                {
                    pictureBox6.ImageLocation = pictureBox4.ImageLocation;
                    pictureBox4.ImageLocation = null;
                }
                
            }
            else if (pictureBox4.ImageLocation == sol)
            {
                if(pictureBox3.ImageLocation == null)
                {
                    pictureBox3.ImageLocation = pictureBox4.ImageLocation;
                    pictureBox4.ImageLocation = null;
                }
                else if(pictureBox3.ImageLocation != null && pictureBox2.ImageLocation == null)
                {
                    pictureBox2.ImageLocation = pictureBox4.ImageLocation;
                    pictureBox4.ImageLocation = null;
                }
            }
            bitis();
            hamlesayici();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.ImageLocation == sag)
            {
                if (pictureBox6.ImageLocation == null)
                {
                    pictureBox6.ImageLocation = pictureBox5.ImageLocation;
                    pictureBox5.ImageLocation = null;
                }
                else if (pictureBox6.ImageLocation != null && pictureBox7.ImageLocation == null)
                {
                    pictureBox7.ImageLocation = pictureBox5.ImageLocation;
                    pictureBox5.ImageLocation = null;
                }
                
            }
            else if (pictureBox5.ImageLocation == sol)
            {
                if (pictureBox4.ImageLocation == null)
                {
                    pictureBox4.ImageLocation = pictureBox5.ImageLocation;
                    pictureBox5.ImageLocation = null;
                }
                else if (pictureBox4.ImageLocation != null && pictureBox3.ImageLocation == null)
                {
                    pictureBox3.ImageLocation = pictureBox5.ImageLocation;
                    pictureBox5.ImageLocation = null;
                }
               
            }
            hamlesayici();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            if (pictureBox6.ImageLocation == sag)
            {
                if (pictureBox7.ImageLocation == null)
                {
                    pictureBox7.ImageLocation = pictureBox6.ImageLocation;
                    pictureBox6.ImageLocation = null;
                }
            }
            else if (pictureBox6.ImageLocation == sol)
            {
                if (pictureBox5.ImageLocation == null)
                {
                    pictureBox5.ImageLocation = pictureBox6.ImageLocation;
                    pictureBox6.ImageLocation = null;
                }
                else if (pictureBox5.ImageLocation != null && pictureBox4.ImageLocation == null)
                {
                    pictureBox4.ImageLocation = pictureBox6.ImageLocation;
                    pictureBox6.ImageLocation = null;
                }
            }
            hamlesayici();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox7.ImageLocation == sol)
            {
                if (pictureBox6.ImageLocation == null)
                {
                    pictureBox6.ImageLocation = pictureBox7.ImageLocation;
                    pictureBox7.ImageLocation = null;

                }
                else if (pictureBox6.ImageLocation != null && pictureBox5.ImageLocation == null)
                {
                    pictureBox5.ImageLocation = pictureBox7.ImageLocation;
                    pictureBox7.ImageLocation = null;
                }
            }
            hamlesayici();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = sag;
            pictureBox2.ImageLocation = sag;
            pictureBox3.ImageLocation = sag;
            pictureBox5.ImageLocation = sol;
            pictureBox6.ImageLocation = sol;
            pictureBox7.ImageLocation = sol;
            label1.Text = "Hamle Sayısı " + hamlesayac;
            label2.Text = "Tur Sayısı: " + tursayac++;
        }

    }
}
