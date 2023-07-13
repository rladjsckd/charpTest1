using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp02
{
    delegate int Compare(int a, int b);
    internal class Program
    {
        static int AscendCompare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;

        }
        static int DescendCompare(int a, int b) 
        {
            if (a < b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }
        static void BubbleSort(int[] DateSet, Compare Comparer ) 
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for (i = 0; i < DateSet.Length - 1; i++) 
            {
                if (Comparer(DateSet[j], DateSet[j + 1]) > 0) 
                {
                    temp = DateSet[j + 1];
                    DateSet[j + 1] = DateSet[j];
                    DateSet[j] = temp;
                }
            }

        }
        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 2, 10 };
            Console.WriteLine("오름차순");
            BubbleSort(array, new Compare(AscendCompare));
            for(int i = 0; i< array.Length; i++)
                Console.Write(array[i]);

            Console.WriteLine();

            int[] array2 = { 7, 2, 8, 11, 10 };
            Console.WriteLine("내림차순");
            BubbleSort(array2, new Compare(DescendCompare));
            for(int i = 0; i < array.Length; i++)
                Console.Write(array2[i]);

            Console.WriteLine();
        }
    }
}
