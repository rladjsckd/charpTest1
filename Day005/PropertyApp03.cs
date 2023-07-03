using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp003
{
    class Birthdayinfo 
    {
        private string name;
        private DateTime birthday;

        //property

        public string Name 
        {
            get 
            {
                return name;
            }
            set 
            {
                name = value;
            }
        }
        public DateTime Birthday 
        {
            get 
            {
                return birthday;
            }
            set 
            {
                birthday = value;
            }
        }
        public int Age 
        {
            get 
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Birthdayinfo birthday = new Birthdayinfo();
            birthday.Name = "서현";
            birthday.Birthday = new DateTime(1991, 6, 26);

            Console.WriteLine($"Name : {birthday.Name}");
            Console.WriteLine($"Birthday : {birthday.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birthday.Age}");
        }
    }
}
