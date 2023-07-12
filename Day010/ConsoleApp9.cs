using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            foreach (int a in list)
                Console.Write(a);
            Console.WriteLine();
            list.Remove(4); // 삭제할 부분 지정
            list.RemoveAt(2); // 삭제할 위치 지정

            foreach (int a in list)
                Console.Write(a);
            Console.WriteLine();

            list.Insert(2, 2);

            foreach (int a in list)
                Console.Write(a);
            Console.WriteLine();

        }
    }
}
