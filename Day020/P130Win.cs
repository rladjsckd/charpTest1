using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P130
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            string b;
            if (textBox1.Text == " ")
            {
                MessageBox.Show("점수를 입력하세요", "경고 1");
                goto Nagayo;
            }
            if (a > 100 || a < 0)
            {
                MessageBox.Show("0~100 사이의 점수를 입력하세요", "경고 2");
                goto Nagayo;
            }
            if (a >= 96)
                b = "A+";
            else if (a >= 91)
                b = "A0";
            else if (a >= 86)
                b = "B+";
            else if (a >= 81)
                b = "B0";
            else if (a >= 76)
                b = "C+";
            else if (a >= 71)
                b = "C0";
            else if (a >= 66)
                b = "D+";
            else if (a >= 61)
                b = "D0";
            else
                b = "F";
            textBox2.Text = b;

        Nagayo: textBox1.Focus();
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.Text.Length;

        }
    }
}
