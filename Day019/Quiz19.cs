using System;
using System.Windows.Forms;

namespace Quiz19
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();

            timer.Interval = 1000;
            timer.Tick += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowCurrentTime();
            if (!timer.Enabled)
            {
                timer.Start();
            }
        }

        private void ShowCurrentTime()
        {
            DateTime currentTime = DateTime.Now;
            label1.Text = currentTime.ToString("mm' : 'ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
