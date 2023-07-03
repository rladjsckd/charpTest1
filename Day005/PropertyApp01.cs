using System;

namespace PropertyApp001
{
    class Cat
    {
        public string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int age;
        public int Age
        {
            get;
            set;
        }
        public string color;

        public string Color { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat nero = new Cat();
            nero.Name = "네로";
            nero.Age = 10;
            nero.Color = "검은색";

            Console.WriteLine($"고양이 이름은 {nero.Name} 고양이 나이는 {nero.Age} 고양이 색깔은 {nero.Color}");
        }
    }
}
