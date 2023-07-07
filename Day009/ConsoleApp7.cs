using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 5, 8, 9, 1, 2 };
            list.Sort();

            foreach (int i in list) 
            {
                Console.Write(i+" ");
            }
        }
    }
}
