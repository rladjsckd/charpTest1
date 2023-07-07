using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueApp001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Quere : 앞이 열려있고 뒤도 뚫려있는 구조 123 ->123
            //Queue<int> que = new Queue<int>();
            //que.Enqueue(1);
            //que.Enqueue(2);
            //que.Enqueue(3);
            //que.Enqueue(4);
            //que.Enqueue(5);

            //while(que.Count > 0)
            //    Console.WriteLine(que.Dequeue());

            Queue<string> que = new Queue<string>();
            que.Enqueue("Hello");
            que.Enqueue("Halo");
            que.Enqueue("Hi");

            while (que.Count > 0)
                Console.WriteLine(que.Dequeue());
        }
    }
}
