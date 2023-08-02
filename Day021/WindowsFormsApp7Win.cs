using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
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
            Pen blackPen = new Pen(Color.Black, 3);
            Pen redPen = new Pen(Color.Red, 3);
            Pen bluePen = new Pen(Color.Blue, 4);
            Rectangle rectangle = new Rectangle(100, 100, 200, 200);
            g.DrawRectangle(redPen, rectangle);

            Point pt1 = new Point(100, 100);
            Point pt2 = new Point(300, 300);
            g.DrawLine(blackPen, pt1, pt2);

            Point pt3= new Point(300, 100);
            Point pt4 = new Point(100, 300);
            g.DrawLine(blackPen, pt3, pt4);

            SolidBrush solidbrush1 = new SolidBrush(Color.Blue);
            RectangleF recf = new RectangleF(100, 100, 200, 200);
            g.DrawEllipse(bluePen, recf);
            g.FillEllipse(solidbrush1, recf);

            SolidBrush solidbrush2 = new SolidBrush(Color.Red);
            Point point1 = new Point(100, 100);
            Point point2 = new Point(300, 100);
            Point point3 = new Point(200, 60);
            Point[] points = { point1, point2, point3 };
            g.DrawPolygon(redPen, points);
            g.FillPolygon(solidbrush2, points);
        }
    }
}
