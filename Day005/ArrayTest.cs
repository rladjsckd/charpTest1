using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 ~ 10까지 들어있는 정수형 배열 arr을 선언해주세요.
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++) 
            {
                arr[i] = i+1; // 배열은 선형적 메모리
                Console.WriteLine(arr[i]);
            }
        }
    }
}
