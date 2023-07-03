using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopApp003
{
    class Cat
    {
        //이름
        public string Name;
        //색깔
        public string Color;
        //나이
        public int Age;

        //생성자
        public Cat() //default 생성자
        {
            //초기값
            this.Name = "나비";
            this.Age = 2;
            this.Color = "노란색";
        }
        //메소드는 "야옹"
        public void Bark() 
        {
            Console.WriteLine("야옹~");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //갹체 생성
            Cat kitty = new Cat();
            //생성 후 초기화
            //kitty.Name = "키티";
            //kitty.Color = "하얀색";
            //kitty.Age = 3;
            //kitty.Bark();
            Console.WriteLine($"키티의 이름 : {kitty.Name}, 키티의 색깔 : {kitty.Color}, 키티의 나이 : {kitty.Age}");
        }
    }
}
