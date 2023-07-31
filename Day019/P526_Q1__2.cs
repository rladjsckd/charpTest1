using System;

namespace P526_Q1__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 22, 33, 44, 55 };

            foreach (int a in array)
            {
                Action<int> action = (x) =>
                {
                    int result = x * x;
                    Console.WriteLine(result);
                };
                action(a);
            }
        }
    }
}
