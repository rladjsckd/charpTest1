using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 ~ 10까지 정수가 담겨있는 배열 arr
            //int[] arr = new int[10];
            //for(int i = 0, cnt = 2 ; i < 5; i++, cnt +=2)
            //{
            //arr[i] = cnt;
            //Console.WriteLine(arr[i]);
            //}

            //int[] arr = new int[10];
            //for (int i = 0; i < 10; i++) 
            //{
            //arr[i] = i+1;
            //if (arr[i] % 2 == 0) 
            //{
            //Console.WriteLine(arr[i]);
            //}
            //}

            int[] arr = new int[10];
            for(int i = 0; i < arr.Length; i++) 
            {
                arr[i] = i + 1;
                if (arr[i] % 2 == 1) 
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
