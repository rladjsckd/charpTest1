using System;

namespace OopApp006
{
    class Cat
    {
        private string name;
        private int age;
        private string color;

        public void setName(string _name)
        {
            name = _name;
        }
        public string getName()
        {
            return name;
        }

        public void setAge(int _age)
        {
            age = _age;
        }
        public int getAge()
        {
            return age;
        }

        public void setColor(string _color)
        {
            color = _color;
        }
        public string getColor()
        {
            return color;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat nero = new Cat();
            nero.setAge(10);
            nero.setColor("검은색");
            nero.setName("네로");

            Console.WriteLine($"이름:{nero.getName()} 색깔:{nero.getColor()} 나이:{nero.getAge()} ");
        }
    }
}
