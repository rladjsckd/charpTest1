using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AbortApp01
{
    internal class Program
    {
        static void DoSomething() 
        {
            try
            {
                for (int i = 0; i < 10000; i++)
                {
                    Console.WriteLine($"DoSomething : {i}");
                    Thread.Sleep(10);  //0.01초
                }
            }
            catch (ThreadAbortException)
            {
                Console.WriteLine("스레드 Abot 발생");
            }
            finally 
            {
                //무조건 실행되는 구문
                Console.WriteLine("finally");
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(DoSomething);
            t1.Start();

            for (int i = 1; i < 1000; i++) 
            {
                if(i == 100)
                    t1.Abort();
                Thread.Sleep(20);
            }
            
            t1.Abort();
            t1.Join();
        }
    }
}
