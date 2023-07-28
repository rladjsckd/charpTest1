using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseClickApp01
{
    class MainApp : Form
    {
        static void Mouse_Click(object sender, MouseEventArgs e) 
        {
            if (e.Button == MouseButtons.Left)
            {
                Console.WriteLine($"X : +{e.X}");
                Console.WriteLine($"Y : +{e.Y}");
                Console.WriteLine("마우스 왼쪽 버튼을 클릭하셨습니다.");
            }
            else if (e.Button == MouseButtons.Right)
            {
                Console.WriteLine($"X : +{e.X}");
                Console.WriteLine($"Y : +{e.Y}");
                Console.WriteLine("마우스 오른쪽 버튼을 클릭하셨습니다.");
            }
            else if (e.Button == MouseButtons.Middle) 
            {
                Console.WriteLine($"X : +{e.X}");
                Console.WriteLine($"Y : +{e.Y}");
                Console.WriteLine("마우스 중간 버튼을 클릭하셨습니다.");
            }
        }
        static void Main(string[] args)
        {
            MainApp form = new MainApp();
            form.MouseClick += Mouse_Click;
            Application.Run(form);
        }
    }
}
