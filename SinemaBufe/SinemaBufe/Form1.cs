using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBufe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasatutar = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet, toplam;
            misir = Convert.ToInt16(txtmisir.Text);
            su = Convert.ToInt16(txtsu.Text);
            cay = Convert.ToInt16(txtcay.Text);
            bilet = Convert.ToInt16(txtbilet.Text);

            toplam = misir * 4 + su * 1 + cay * 2 + bilet * 8;
            lbltoplam.Text = toplam + " TL";

            kasatutar += toplam;
            lblkasa.Text = kasatutar + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbilet.Text = "";
            txtcay.Text = "";
            txtmisir.Text = "";
            txtsu.Text = "";
            txtmisir.Focus();
        }
    }
}
