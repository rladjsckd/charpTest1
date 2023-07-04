using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopApp010
{
    //상속
    class Car //부모 클래스
    {
        public string name;
        private string brand;
        protected int speed;
        public void Run() 
        {
            Console.WriteLine("차가 달리다.");
        }
    }
    class SupperCar : Car  //자식 클래스
    {
        public SupperCar() 
        {
            this.speed = 100;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SupperCar sc = new SupperCar();
            sc.Run();
            sc.name = "자동차";
        }
    }
}
