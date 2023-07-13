using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz08
{
    delegate int MyDelegate(int a, int b);

    //class Calculator 
    //{
    //    public int Plus(int a, int b) 
    //    {
    //        return a + b;
    //    }
    //    public int Minus(int a, int b) 
    //    {
    //        return a - b;
    //    }
    //}
    internal class Program
    {
        static int Plus(int a, int b) 
        {
            return a + b;
        }
        static int Minus(int a, int b) 
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            //Calculator calculator = new Calculator();
            MyDelegate Callback;
            //Callback = new MyDelegate(calculator.Plus);
            Callback = new MyDelegate(Plus);
            Console.WriteLine(Callback(3, 4));

            //Callback = new MyDelegate(calculator.Minus);
            Callback = new MyDelegate(Minus);
            Console.WriteLine(Callback(7, 5));
        }
    }
}
