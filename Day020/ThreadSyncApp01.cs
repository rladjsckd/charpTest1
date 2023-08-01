using System;
using System.Threading;

namespace ThreadSyncApp01
{
    class Counter
    {
        public int count = 0;
        private readonly object thisLock = new object();
        public void Increasse()
        {
            //lock (thisLock)
            //{
            //    int temp = count;
            //    Thread.Sleep(1);
            //    count = temp + 1;
            //}
            int temp = count;
            Thread.Sleep(1);
            count = temp + 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Counter counter = new Counter();
            //Thread t1 = new Thread(counter.Increasse);
            //Thread t2 = new Thread(counter.Increasse);
            //Thread t3 = new Thread(counter.Increasse);

            //t1.Start();
            //t2.Start();
            //t3.Start();

            //t1.Join();
            //t2.Join();
            //t3.Join();

            //Console.WriteLine(counter.count);

            Counter counter = new Counter();
            Thread[] t = new Thread[500];

            for (int i = 0; i < 500; i++) 
            {
                t[i] = new Thread(counter.Increasse);
                t[i].Start();
            }
            for (int i = 0; i < 500; i++) 
            {
                t[i].Join();
            }

            Console.WriteLine(counter.count);
        }
    }
}
