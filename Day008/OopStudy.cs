using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopStudy
{
    class Point 
    {
        public int x;
        public int y;
        //생성자의 역할은 객체의 초기화
        public Point() 
        {
            x = 1;
            y = 1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point pt1 = new Point();
            Console.WriteLine($"({pt1.x},{pt1.y})");
        }
    }
}
