using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno, dogru, yanlis = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            labelSoruNo.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                buttonA.Text = "1920";
                buttonB.Text = "1921";
                buttonC.Text = "1922";
                buttonD.Text = "1923";
                label4.Text = "1923";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi şehir Ege bölgemizde bulunmaz?";
                buttonA.Text = "İzmir";
                buttonB.Text = "Balıkesir";
                buttonC.Text = "Aydın";
                buttonD.Text = "Manisa";
                label4.Text = "Balıkesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazara aittir?";
                buttonA.Text = "Sait Faik";
                buttonB.Text = "Cemal Süreyya";
                buttonC.Text = "Atilla İlhan";
                buttonD.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
                buttonSonraki.Text = "Sonuçlar";
            }
            if(soruno == 4)
            {
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
                buttonSonraki.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\nYanlış: " + yanlis);
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonSonraki.Enabled = true;

            label5.Text = buttonC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonSonraki.Enabled = true;

            label5.Text = buttonD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonSonraki.Enabled = true;

            label5.Text = buttonB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonSonraki.Enabled = true;

            label5.Text = buttonA.Text;
            if(label4.Text == label5.Text)
            {
                dogru++;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        
    }
}
