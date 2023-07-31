using System;
using System.Windows.Forms;

namespace TimeWin04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Number = 0;
        private DateTime NowTime;
        public void GetNumber()
        {
            Number++;
        }
        public void OutNumber()
        {
            textBox1.AppendText(Number + "\r\n"); //Append = 누적을 시킴
        }
        public void GetTime()
        {
            NowTime = DateTime.Now;
        }
        public void OutTime() 
        {
            textBox2.AppendText(NowTime + "\r\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <=5; i++) 
            {
                GetNumber();
                OutNumber();
                GetTime();
                OutTime();
                System.Threading.Thread.Sleep(1000);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
