using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopApp016
{
    abstract class Monster 
    {
        public abstract string Jump();
    }
    class Slime : Monster
    {
        public override string Jump()
        {
            return "점프하다";
        }
    }
    class Blueslime : Slime 
    {
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Blueslime bob = new Blueslime();
            Console.WriteLine(bob.Jump());
        }
    }
}
