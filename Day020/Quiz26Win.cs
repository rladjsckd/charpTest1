using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz26
{
    public partial class Form1 : Form
    {
        private int count = 0;
        CancellationTokenSource cts;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            var task = Task.Run(async () =>
            {
                while (true)
                {
                    Invoke((Action)(() => label1.Text = (count++).ToString()));
                    await Task.Delay(1000);

                    if (token.IsCancellationRequested) //취소요청이 오면
                    {
                        break;
                    }
                }

            });
        }
        private void button2_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }
    }
}
