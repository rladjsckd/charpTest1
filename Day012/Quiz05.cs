using System;

namespace Quiz05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 4];
            string[] input = Console.ReadLine().Split(' ');

            int index = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = int.Parse(input[index]);
                    index++;
                }
            }

            Console.WriteLine("행 우선 출력:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("열 우선 출력:");
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
