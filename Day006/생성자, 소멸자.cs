using System;

namespace OopApp017
{
    class Cat
    {
        public Cat() //디폴트 생성자
        {
            Console.WriteLine("객체의 생성자가 호출되었습니다.");
        }
        ~Cat() // 소멸자 
        {
            Console.WriteLine("객체의 소멸자가 호출되었습니다.");
        }
    }
    class RussianBlue : Cat 
    {
        public RussianBlue() 
        {
            Console.WriteLine("RussianBlue 생성자가 생성되었습니다.");
        }
        ~RussianBlue() 
        {
            Console.WriteLine("RussianBule 소멸자가 호출되었습니다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cat cat = new Cat();
            RussianBlue rb = new RussianBlue();
        }
    }
}
