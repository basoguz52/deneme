using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int s1, s2, s3, s4;
            s1 = random.Next(1,5);
            s2 = random.Next(1,5);
            s3 = random.Next(1,5);
            s4 = random.Next(1,5);

            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
            label4.Text = s4.ToString();

            if (textBox1.Text == s1.ToString())
                pictureBox1.Visible = true;
            else
                pictureBox1.Visible = false;
            if (textBox2.Text == s2.ToString())
                pictureBox2.Visible = true;
            else
                pictureBox2.Visible = false;
            if (textBox3.Text == s3.ToString())
                pictureBox3.Visible = true;
            else
                pictureBox3.Visible = false;
            if (textBox4.Text == s4.ToString())
                pictureBox4.Visible = true;
            else
                pictureBox4.Visible = false;

            if (textBox1.Text == s1.ToString() && textBox2.Text == s2.ToString() && textBox3.Text == s3.ToString() && textBox4.Text == s4.ToString())
                MessageBox.Show("Başarılı");

        }
    }
}
