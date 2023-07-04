using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OopApp015
{
    abstract class Shape 
    {
        public abstract void Draw(); 
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            //throw new NotImplementedException();
            Console.WriteLine("삼각형을 그리다");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Triangle();
            Triangle t = new Triangle();
            s.Draw();
            t.Draw();
        }
    }
}
