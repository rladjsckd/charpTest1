using System;
using System.Threading;

namespace ThreadApp02
{
    internal class Program
    {
        static void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Thread 프로그램 종료");
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(Run));
            t.Start();
            t.Join();
            Console.WriteLine("Main 프로그램 종료");
        }
    }
}
