using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Admin\Desktop\NewJeans01.png";
            pictureBox1.Load(path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Admin\Desktop\NewJeans02.png";
            pictureBox1.Image = Image.FromFile(path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Admin\Desktop\NewJeans03.png";
            pictureBox1.Load(path);
        }
    }
}
