using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(100);
            stack.Push(200);
            stack.Push(300);

            while (stack.Count > 0)
                Console.Write(stack.Pop()+" ");

        }
    }
}
