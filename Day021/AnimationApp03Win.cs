using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationApp03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen redPen = new Pen(Color.Red, 3);
            SolidBrush solidbrush2 = new SolidBrush(Color.Red);
            Point point1 = new Point(200, 100);
            Point point2 = new Point(400, 100);
            Point point3 = new Point(300, 60);
            Point[] points = { point1, point2, point3 };
            g.DrawPolygon(redPen, points);
            g.FillPolygon(solidbrush2, points);

            SolidBrush solidbrush1 = new SolidBrush(Color.Red);
            RectangleF recf = new RectangleF(190, 0, 250, 200);
            g.DrawEllipse(redPen, recf);
            g.FillEllipse(solidbrush1, recf);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Maximum = 3000;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;

            Task task = Task.Run(() => {
                for (int i = 1; i <= 3000; i++)
                {
                    Invoke(new Action(() => progressBar1.Value = i));
                    //progressBar1.Value = i; 여기가 문제
                    Thread.Sleep(1);
                }
            });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
