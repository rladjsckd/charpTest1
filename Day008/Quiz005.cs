using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting =Console.ReadLine();

            char ch1 = '1';

            int freq1 = 0;
            foreach (char c1 in greeting) 
            {
                if (c1 == ch1) 
                {
                    freq1++;
                }
            }

            char ch2 = '2';
            int freq2 = 0;
            foreach (char c2 in greeting)
            {
                if (c2 == ch2)
                {
                    freq2++;
                }
            }
            char ch3 = '3';
            int freq3 = 0;
            foreach (char c3 in greeting)
            {
                if (c3 == ch3)
                {
                    freq3++;
                }
            }
            char ch4 = '%';
            int freq4 = 0;
            foreach (char c4 in greeting)
            {
                if (c4 == ch4)
                {
                    freq4++;
                }
            }
            char ch5 = '$';
            int freq5 = 0;
            foreach (char c5 in greeting)
            {
                if (c5 == ch5)
                {
                    freq5++;
                }
            }
            char ch6 = '#';
            int freq6 = 0;
            foreach (char c6 in greeting)
            {
                if (c6 == ch6)
                {
                    freq6++;
                }
            }
            char ch7 = 'A';
            int freq7 = 0;
            foreach (char c7 in greeting)
            {
                if (c7 == ch7)
                {
                    freq7++;
                }
            }
            char ch8 = 'B';
            int freq8 = 0;
            foreach (char c8 in greeting)
            {
                if (c8 == ch8)
                {
                    freq8++;
                }
            }
            char ch9 = 'C';
            int freq9 = 0;
            foreach (char c9 in greeting)
            {
                if (c9 == ch9)
                {
                    freq9++;
                }
            }
            char ch10 = 'D';
            int freq10 = 0;
            foreach (char c10 in greeting)
            {
                if (c10 == ch10)
                {
                    freq10++;
                }
            }
            char ch11 = 'x';
            int freq11 = 0;
            foreach (char c11 in greeting)
            {
                if (c11 == ch11)
                {
                    freq11++;
                }
            }
            char ch12 = 'y';
            int freq12 = 0;
            foreach (char c12 in greeting)
            {
                if (c12 == ch12)
                {
                    freq12++;
                }
            }
            char ch13 = 'z';
            int freq13 = 0;
            foreach (char c13 in greeting)
            {
                if (c13 == ch13)
                {
                    freq13++;
                }
            }
            Console.WriteLine("알파뱃 대문자 :" + (freq7 + freq8 + freq9 + freq10));
            Console.WriteLine("알파뱃 소문자 :" + (freq11 + freq12 + freq13));
            Console.WriteLine("숫자 :" + (freq1 + freq2 + freq3));
            Console.WriteLine("특수문자 :" + (freq4 + freq5 + freq6));
        }
    }
}
