using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp007
{
    interface IRunnable 
    {
        void Run();
    }
    interface IFlyable 
    {
        void Fly();
    }
    class FlyingCar : IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Fly! Fly!");
        }

        public void Run()
        {
            Console.WriteLine("Run! Run!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runnable = car as IRunnable;
            runnable.Run();
            IFlyable flyable = car as IFlyable;
            flyable.Fly();
        }
    }
}
