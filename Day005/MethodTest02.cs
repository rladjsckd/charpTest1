using System;

namespace MethodTest002
{
    class MyApp
    {
        public int Max(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public int Min(int i, int k)
        {
            if (i > k)
                return k;
            else
                return i;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            MyApp app = new MyApp();
            Console.WriteLine(app.Max(500, 300));
            Console.WriteLine(app.Min(600, 700));
        }
    }
}
