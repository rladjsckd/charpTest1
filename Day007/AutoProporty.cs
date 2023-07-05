using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProporty
{
    class Birthdayinfo
    {
        public string Name { get; set; } = "Unknown";
        public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);
        public int Age 
        {
            get 
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Birthdayinfo birth = new Birthdayinfo();
            Console.WriteLine(birth.Name);
            Console.WriteLine(birth.Birthday.ToShortDateString());
            Console.WriteLine(birth.Age);

            birth.Name = "서현";
            birth.Birthday = new DateTime(1991, 6, 28);
            Console.WriteLine(birth.Birthday.ToShortDateString());
            Console.WriteLine(birth.Name);
            Console.WriteLine(birth.Age);
        }
    }
}
