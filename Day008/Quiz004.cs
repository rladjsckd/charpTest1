using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string a = Console.ReadLine();
            //for (int i = a.Length - 1; i >= 0; i--) 
            //{
            //    Console.Write(a[i]);
            //}

            //string input = Console.ReadLine();
            //char[] array = input.ToCharArray();
            //Array.Reverse(array);
            //string reversed = new string(array);
            //Console.WriteLine(reversed);

            //string input = Console.ReadLine();
            //Stack<char> stack = new Stack<char>(input);
            //string reversed = string.Join(" ", stack);
            //Console.WriteLine(reversed);

            string input = Console.ReadLine();

            string reversed = new string(input.Reverse().ToArray());

            Console.WriteLine(reversed);
        }
    }
}
