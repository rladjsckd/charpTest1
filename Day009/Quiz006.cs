using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz006
{
    internal class Program
    {
        static void ValueChecking(int n) 
        {
            if (n < 0)
            {
                Console.WriteLine("값이 존재하지 않습니다. 프로그램을 종료합니다.");
                Environment.Exit(0);
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] arr = new int[80];

            for (int i = 0; i < 80; i++)

            {
                arr[i] = random.Next(1,100);
            }
            foreach(int i in arr)
                Console.Write(i+" ");
            int n = Array.IndexOf(arr, 80);
            ValueChecking(n);
            Console.WriteLine("처음 등장한 값의 위치 :"+" " + n);

            Console.WriteLine();

            Array.Sort(arr);
            n = Array.IndexOf(arr, 80);
            ValueChecking(n);
            Console.WriteLine("정렬 후 등장한 값의 위치 :" +" "+ n);
        }
    }
}
