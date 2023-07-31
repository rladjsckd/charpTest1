using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P107Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int n, i;
            //textBox1.Text = "";

            //for (n = 1; n < 10; ++n) 
            //{
            //    for (i = 1; i < 10; ++i)
            //    {
            //        textBox1.Text = textBox1.Text + n + "X" + i + "=";
            //        textBox1.Text = textBox1.Text + (n * i) + "\r\n";
            //    }
            //    textBox1.Text = textBox1.Text + Environment.NewLine;
            //}

            int n, i,j;
            textBox1.Text = "";

            for (j = 1; j < 10; j = j +3) 
            {
                for (n = 1; n < 10; ++n)
                {
                    for (i = 0; i < 3; ++i)
                    {
                        textBox1.Text = textBox1.Text + (j + i) + "X" + n + "=";
                        textBox1.Text = textBox1.Text + ((j + i)*n) + "   ";
                    }
                    textBox1.Text = textBox1.Text + Environment.NewLine;
                }
                textBox1.Text = textBox1.Text + Environment.NewLine;
            }
        }
    }
}
