using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp03
{
    class Program
    {

        //static public int CharCounter(char[] arr, char ch)
        //{
        //    int N = 0;
        //    for (int i = 0; i < arr.Length; i++) 
        //    {
        //        if (arr[i] == ch) 
        //        {
        //            N++;
        //        }
        //    }
        //    return N;
        //}
        static void Main(string[] args)
        {
            //Console.WriteLine("문자열 입력 : ");
            //string str = Console.ReadLine();
            //Console.WriteLine("문자 입력: ");
            //char ch = char.Parse(Console.ReadLine());
            //char[] arr = str.ToCharArray();

            //int result = CharCounter(arr, ch);
            //Console.WriteLine("결과 :" +  result);
            Console.WriteLine("문자열을 입력하세요:");
            string str = Console.ReadLine();
            Console.WriteLine("문자를 입력하세요.");
            char ch = char.Parse(Console.ReadLine());
            char[] arr = str.ToCharArray();

            int result = CharCounter(arr, ch);
        }
    }
}
