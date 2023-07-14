using System;
using System.ComponentModel;

namespace Quiz10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++) 
            {
                for (int k = n; k > i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
