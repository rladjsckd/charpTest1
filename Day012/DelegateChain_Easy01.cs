using System;
using System.Web;

namespace DelegateChain_Easy01
{
    internal class Program
    {
        //delegate void ThereisAsFire(string location);

        //public static void Call119(string location) 
        //{
        //    Console.WriteLine($"소방서죠 {location}에 불이 났어요.");
        //}
        //public static void Shotout(string location) 
        //{
        //    Console.WriteLine($"{location}에 불이 났어요 도망치세요");
        //}
        //public static void Escape(string location) 
        //{
        //    Console.WriteLine($"{location}에 불이 났어요 도망치세요");
        //}
        static void Main(string[] args)
        {
            //ThereisAsFire Fire = new ThereisAsFire(Call119);
            //Fire += new ThereisAsFire(Shotout);
            //Fire += new ThereisAsFire(Escape);

            //Fire("우리집");
        }
    }
}
