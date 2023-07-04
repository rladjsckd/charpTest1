using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopApp008
{
    class Calculator 
    {
        public int executeTotalScore(int x, int y, int z) 
        {
            return x + y + z;
        }
        public int excuteAvg(int x, int y, int z) 
        {
            return (x + y + z)/3;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();

            Console.Write("국어 :");
            int x = int.Parse(Console.ReadLine());
            Console.Write("수학 :");
            int y = int.Parse(Console.ReadLine());
            Console.Write("영어 :");
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine($"총점: {cal.executeTotalScore(x, y, z)}");
            Console.WriteLine($"평균: {cal.excuteAvg(x, y, z)}");
    
        }
    }
}
