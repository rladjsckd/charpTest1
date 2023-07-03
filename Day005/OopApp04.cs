using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopApp004
{
    class Cat 
    {
        //defautl 생성자
        public Cat() 
        {
            Name = "";
            Color = "";
        }
        //인자가 있는 생성자
        public Cat(string _Name, string _Color) 
        {
            Name = _Name;
            Color = _Color;
        }
        //맴버변수
        public string Name;
        public string Color;

        public void Meow() 
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat umi = new Cat("유미", "하얀색");
            Console.WriteLine(umi.Name +" "+ umi.Color );

            Cat nero = new Cat("네로", "검은색");
            Console.WriteLine(nero.Name + " " + nero.Color);
        }
    }
}
