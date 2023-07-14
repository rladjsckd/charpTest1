using System;

namespace Quiz11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            if (n > 12) 
            {
                Console.WriteLine("잘 못 입력");
            }
            Console.WriteLine(arr);
        }
    }
}
