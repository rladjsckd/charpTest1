using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadQuiz01
{
    internal class Program
    {
        static void Run() 
        {
            int sum = 0;
            for (int i = 1; i < 101; i++) 
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.WriteLine($"{t.Name} 프로그램 종료");
        }
        static void Abc() 
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            Console.WriteLine("Thread-2 프로그램 종료");
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(Run));
            t.Name = "thread-1"; 
            t.Start();
            t.Join();

            Thread h = new Thread(new ThreadStart(Abc));
            h.Name = "thread-2";
            h.Start();
            h.Join();
            Console.WriteLine("Main 프로그램 종료");
        }
    }
}
