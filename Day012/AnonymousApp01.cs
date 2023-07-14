using System;

namespace AnonymousApp01
{
    internal class Program
    {
        delegate int Calculate(int a, int b);
        static void Main(string[] args)
        {
            Calculate Calc;

            Calc = delegate (int a, int b)
            {
                return a + b;
            };

            Console.WriteLine(Calc(3, 4));

        }
    }
}
