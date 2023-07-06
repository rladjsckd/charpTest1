using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class SomeClass 
    {
        public void SomeMethod() 
        {
            int count = 0;
            SomeLocalFunction(1, 2);
            SomeLocalFunction(3, 4);

            void SomeLocalFunction(int a, int b)
            {
                Console.WriteLine($"count : {++count}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeClass sc = new SomeClass();
            sc.SomeMethod();
        }
    }
}
