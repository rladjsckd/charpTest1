using System;

namespace CalculatorApp001
{
    //사칙연산을 하는 계산기를 만들어 봅시다.
    class Calculator
    {
        public int Plus(int x, int y) 
        {
            return x + y;
        }
        public int MInus(int x, int y) 
        {
            return x - y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            int result1 = cal.Plus(1, 2);
            int result2 = cal.MInus(1, 2);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}
