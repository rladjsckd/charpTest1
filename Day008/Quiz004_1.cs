using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz004_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string a = Console.ReadLine();
            //for(int i = a.Length-1; i >= 0; i--) 
            //{
            //    Console.Write(a[i]);
            //}

            string a = Console.ReadLine();
            char[] arr = a.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
        }
    }
}
