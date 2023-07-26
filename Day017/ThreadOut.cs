
using System.Threading;
using System;

namespace ThreadOut
{
    internal class Program
    {
        static void threadFunc() 
        {
            Console.WriteLine("5초후 종료");
            Thread.Sleep(5000);
            Console.WriteLine("스레드 종료");
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(threadFunc));
            t.IsBackground = true;
            t.Start();
            //Thread.Sleep(7000);
            //t.Join();
            Console.WriteLine("메인스레드 종료");
        }
    }

}
