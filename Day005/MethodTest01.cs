using System;
using System.Xml.Schema;

namespace MethodTest001
{
    internal class Program
    {
        //double Avg(int kor, int eng, int math) 
        //{
        //    int total = kor + eng + math;
        //    return (double)total / 3.0;
        //}
        //double Avg(int kor, int eng, int math) 
        //{
        //    int total = kor + eng + math;
        //    return (double)total / 3.0;
        //}
        double Avg( double x, double y, double z)
        {
            return(x + y + z)/3;
        }
        static void Main(string[] args)
        {
            //int kor, eng, math;

            //kor = int.Parse(Console.ReadLine());
            //eng = int.Parse(Console.ReadLine());
            //math = int.Parse(Console.ReadLine());

            //Program p = new Program();
            //double result = p.Avg(kor, eng, math);
            //Console.WriteLine(result);

            //int[] score = new int[3];

            //for(int i = 0; i < 3; i++) 
            //{
            //    score[i] = int.Parse(Console.ReadLine());
            //}
            //Program p = new Program();
            //double result = p.Avg(score[0], score[1], score[2]);
            //Console.WriteLine(result);

            Program p = new Program();

            int[] score = new int[3];

            for (int i = 0; i< 3; i++) 
            {
                score[i] = int.Parse(Console.ReadLine());
            }

            double result = p.Avg(score[0], score[1], score[2]);

            Console.WriteLine(result);
        }
    }
}
