using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
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

            Pen blackPen = new Pen(Color.Black, 3);   //생성자 확인
            Pen redPen = new Pen(Color.Red, 3);
            Pen bluePen = new Pen (Color.Blue, 4);
            //그리기 함수를 사용
            Rectangle rectangle = new Rectangle(50, 50, 200, 100);
            g.DrawRectangle(blackPen, rectangle);
            //라인그려봅시다
            Point pt1 = new Point(50, 50);
            Point pt2 = new Point(300, 300);
            g.DrawLine(redPen, pt1, pt2);
            //원을 그ㅕ봅시다.
            Rectangle rectf = new Rectangle(30, 30, 170, 170);
            g.DrawEllipse(bluePen, rectf);
        }
    }
}
