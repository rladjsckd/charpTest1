using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatDatetime001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023, 03, 04, 23, 18, 22);

            Console.WriteLine($"12시간 형식 :{dt : yyyy-MM-dd tt hh:mm:ss (ddd)}");
            Console.WriteLine($"24시간 형식 :{dt: yyyy-MM-dd HH:mm:ss (dddd)}");

            CultureInfo ciko = new CultureInfo("ko-KR");
            Console.WriteLine();
            Console.WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciko));
            Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciko));
            Console.WriteLine(dt.ToString(ciko));

            CultureInfo ciEn = new CultureInfo("en-US");
            Console.WriteLine();
            Console.WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
            Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciEn));
            Console.WriteLine(dt.ToString(ciEn));
        }
    }
}
