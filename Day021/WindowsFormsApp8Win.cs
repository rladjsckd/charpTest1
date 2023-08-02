using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private int R, G, B;
        public Form1()
        {
            InitializeComponent();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            R = trackBar1.Value;
            panel1.Invalidate();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            G = trackBar2.Value;
            panel1.Invalidate();
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            B = trackBar3.Value;
            panel1.Invalidate();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(R, G, B);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
