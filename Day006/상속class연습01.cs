using System;

namespace OopApp011
{
    class Car
    {
        public virtual void Run()
        {
            Console.WriteLine("차가 달리다.");
        }
    }
    class SupperCar : Car
    {
        public override void Run()
        {
            Console.WriteLine("슈퍼카가 달리다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Run();
            SupperCar supperCar = new SupperCar();
            supperCar.Run();
        }
    }
}
