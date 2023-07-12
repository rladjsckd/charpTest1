using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            dic["하나"] = '1';
            dic["둘"] = '2';
            dic["셋"] = '3';

            Console.WriteLine(dic["하나"]);
            Console.WriteLine(dic["둘"]);
            Console.WriteLine(dic["셋"]);
        }
    }
}
