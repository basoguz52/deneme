﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyReservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(" Yolcu Adı Soyadı: " + textBox1.Text + 
                " TC: " + maskedTextBox3.Text + 
                " Telefon: " + maskedTextBox2.Text + 
                " Rota: " + comboBox1.Text + 
                " -> " + comboBox2.Text + 
                " Tarih: " + dateTimePicker1.Text + 
                " Saat: " + maskedTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string temp = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text= temp;
        }
    }
}
