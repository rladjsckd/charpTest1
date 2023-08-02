using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressAPP01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 10000;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;

            Task task = Task.Run(() => {
                for (int i = 1; i <= 10000; i++)
                {
                    Invoke(new Action(() => progressBar1.Value = i));
                    //progressBar1.Value = i; 여기가 문제
                    Thread.Sleep(1);
                }
            });

        }
    }
}
