using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormStyle01
{
    //만들고 싶은 윈도우 <---- Form클래스 상속
    class MyClass : Form 
    {

    }
    //Program은 Main함수만 동작하도록
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            Application.Run(mc);
        }
    }
}
