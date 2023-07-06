using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz005_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("문자열을 입력하세요.");
            string s = Console.ReadLine();
            char[] arr = s.ToArray();

            int Bigcnt = 0, smallcnt = 0, numcnt = 0, specialcnt = 0;

            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] >= 'A' && arr[i] <= 'Z') Bigcnt++;
                else if (arr[i] >= 'a' && arr[i] <= 'z') smallcnt++;
                else if (arr[i] >= '1' && arr[i] <= '9') numcnt++;
                else specialcnt++;
            }
            Console.WriteLine("대문자 :" + Bigcnt+"개");
            Console.WriteLine("소문자 :" + smallcnt+"개");
            Console.WriteLine("숫자 :" + numcnt + "개");
            Console.WriteLine("특수문자 :" + specialcnt + "개");
        }
    }
}
