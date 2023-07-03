using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProportyApp002
{
    class Cat 
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat nero = new Cat();
            nero.Name = "네로";
            nero.Color = "검은색";
            nero.Age = 100;
        }
    }
}
