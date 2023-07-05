using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            for (a = 2; a < 100; a++) 
            {
                b = 2;
                while (a > b) 
                {
                    if (a % b == 0)
                    {
                        break;
                    }
                    else 
                    {
                        b++;
                    }
                }
                if (a == b) 
                {
                    Console.Write("{0}", a+" ");
                }
            }
            Console.WriteLine();
        }
    }
}
