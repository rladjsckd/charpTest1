using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace StaeLamdaApp01
{
    internal class Program
    {
        delegate string Concateneate(string[] args);
        static void Main(string[] args)
        {
            Concateneate concat = (arr) =>
            {
                string result = "";
                foreach (string s in _args)
                    result += s;
                return result;

            };
            Console.WriteLine(concat(args));
        }
    }
}
