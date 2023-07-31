using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWin03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, val;

            Double result1 =1, result2=1;

            val = int.Parse(textBox1.Text);

            for (i = 1; i < val; i++) 
            {
                if (i % 2 == 0)
                {
                    result1 = result1 + i;
                    textBox2.Text = textBox2.Text + i + "+";
                }
                else 
                {
                    result2 = result2 + i;
                    textBox3.Text = textBox3.Text + i + "+";
                }
            }
            textBox2.Text = textBox2.Text + "=" + result1;
            textBox3.Text = textBox3.Text + "=" + result2;
        }
    }
}
