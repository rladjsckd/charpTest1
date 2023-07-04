using System;

namespace OopApp007
{
    class Dog
    {
        private string Name;
        private string eat;
        private string play;

        public Dog(string _name)
        {
            Name = _name;
        }
        public string getname()
        {
            return Name;
        }
        public string Eat()
        {
            return "먹습니다";
        }
        public string Play()
        {
            return "뛰어놀다";
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                Dog tom = new Dog("톰");
                Console.WriteLine($"{tom.getname()}이 음식을 {tom.Eat()}");
                Console.WriteLine($"{tom.getname()}이 {tom.Play()}");
            }
        }
    }
}
