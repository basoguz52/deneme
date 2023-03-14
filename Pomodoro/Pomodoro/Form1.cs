namespace Pomodoro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saniye;
        int dakika;

        private void button1_Click(object sender, EventArgs e)
        {
            saniye = 0;
            dakika = 25;
            label2.Text = dakika.ToString();
            label1.Text = saniye.ToString();
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            label1.Text = saniye.ToString();

            if (saniye == -1)
            {

                dakika--;
                label2.Text = dakika.ToString();
                saniye = 59;
                label1.Text = saniye.ToString();

                if (dakika == -1)
                {
                    label1.Text = "0";
                    label2.Text = "0";
                    timer1.Stop();
                    MessageBox.Show("bittti");
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            saniye = 0;
            dakika = 5;
            timer1.Start();
            label1.Text = saniye.ToString();
            label2.Text = dakika.ToString();

        }
        bool flag = true;
        private void button3_Click(object sender, EventArgs e)
        {
            flag = !flag;
            if (flag)
            {
                timer1.Interval = 1000;
            }
            else
            {
                timer1.Interval = 5;
            }

        }
    }
}