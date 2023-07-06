using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good morning";

            //Console.WriteLine(greeting.Substring(0,5));
            //Console.WriteLine(greeting.Substring(5));
            //Console.WriteLine();


            //string[] arr = greeting.Split(
            //    new string[] { " " }, StringSplitOptions.None );

            //foreach (string element in arr) 
            //{
            //    Console.WriteLine(element);
            //}
            //string[] arr = greeting.Split(' ');
            //Console.WriteLine(arr[0] + arr[1]);

            //int[] arr = { 1,2,3,4,5,6,7 };

            //foreach (int number in arr)
            //    Console.WriteLine(number);
            string[] arr = { "안녕", "하세요", "반갑", "습니다" };

            foreach(string s in arr)
                Console.WriteLine(s);
        }
    }
}
