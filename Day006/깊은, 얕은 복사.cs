using System;

namespace OopApp018
{
    class MyClass
    {
        public int MyField1;
        public int MyField2;

        //깊은복사
        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;

            return newCopy;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass source = new MyClass();
            source.MyField1 = 10;
            source.MyField2 = 20;

            //객체셍성? 일반적으로 new를 통해서
            //MyClass target = source;
            MyClass target = source.DeepCopy();
            target.MyField2 = 30;

            Console.WriteLine(source.MyField1 + " " + source.MyField2);
            Console.WriteLine(target.MyField1 + " " + target.MyField2);
        }
    }
}
