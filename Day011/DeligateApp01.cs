using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligateApp01
{
    delegate int MyDelegate(int a, int b);
    class Calculator 
    {
        public int Plus(int a, int b) 
        {
            return a + b;
        }
        public int Minus(int a, int b) 
        {
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();
            MyDelegate Callback;

            Callback = new MyDelegate(Calc.Plus); //Callback이 더하기 기능이 되었다.
            Console.WriteLine(Callback(5, 10));

            Callback = new MyDelegate(Calc.Minus);
            Console.WriteLine(Callback(5, 10));
        }
    }
}
