using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionApp02
{
    internal class Program
    {
        static void DoSomething(int arg) 
        {
            if (arg < 10)
                Console.WriteLine(arg);
            else
                throw new Exception("arg가 10보다 큽니다.");

        }
        static void Main(string[] args)
        {
            try
            {
                DoSomething(1);
                DoSomething(11);
                DoSomething(12);
            }catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
