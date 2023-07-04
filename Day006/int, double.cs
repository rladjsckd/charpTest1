using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopApp009
{
    class Calculator 
    {
        public int Plus(int a, int b) 
        {
            return a + b;
        }
        public int Plus(int a, int b, int c, int d) 
        {
            return a + b + c + d;
        }
        public double Plus(double a, double b) 
        {
            return a + b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            Console.WriteLine(cal.Plus(1, 2));
            Console.WriteLine(cal.Plus(1, 2, 3, 4));
            Console.WriteLine(cal.Plus(1.3, 2.5));
        }
    }
}
