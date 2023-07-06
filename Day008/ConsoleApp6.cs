using System;
using System.CodeDom.Compiler;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 4, 5, 7, 3, 2, 1, 9, 8 };
            //Array.Sort(arr);
            int temp;

            for (int i = 8 - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (list[j] < list[j + 1])
                    {
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;

                    }
                }
            }

            foreach (int i in list)
            {
                Console.Write(i);
            }
        }
    }
}
