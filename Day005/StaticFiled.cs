using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Filed001
{
    class Global 
    {
        public static int count = 0;
    }
    class ClassA 
    {
        public ClassA() 
        {
            Global.count++;
        }
    }
    class ClassB 
    {
        public ClassB() 
        {
            Global.count++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Global Count : {Global.count}");

            new ClassA();
            new ClassA();
            new ClassA();
            new ClassA();

            Console.WriteLine($"Global Count : {Global.count}");
        }
    }
}
