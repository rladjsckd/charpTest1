using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopApp013
{
    class Sport 
    {
        public virtual void Play() 
        {
            Console.WriteLine("운동을 하다");
        }
    }
    class Baseball : Sport
    {
        public override void Play()
        {
            Console.WriteLine("야구를 하다");
        }
    }
    class Soccer : Sport
    {
        public override void Play()
        {
            Console.WriteLine("축구를 하다");
        }
    }
    class Basketball : Sport
    {
        public override void Play()
        {
            Console.WriteLine("농구를 하다");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Sport s1 = new Sport();
            //s1.Play();
            //Sport s2 = new Baseball();
            //s2.Play();
            //Sport s3 = new Soccer();
            //s3.Play();
            //Sport s4 = new Basketball();
            //s4.Play();

            Sport[] sports = new Sport[4];
            sports[0] = new Sport();
            sports[1] = new Baseball();
            sports[2] = new Soccer();
            sports[3] = new Basketball();

            for (int i = 0; i < 4; i++) 
            {
                sports[i].Play();
            }

        }
    }
}
