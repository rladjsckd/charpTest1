using System;

namespace PartiialClassApp
{
    partial class A
    {
        public void Method1()
        {
            Console.WriteLine("메소드 1실행");
        }
    }
    partial class A
    {
        public void Method2()
        {
            Console.WriteLine("메소드 2실행");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            A a = new A();
            a.Method1();
            a.Method2();
        }
    }
}
