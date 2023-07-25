using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MemoryStreamQuiz01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream();
            byte[] arrBytes = new byte[] { 1, 2, 3, 4, 5 };
            ms.Write(arrBytes, 0, arrBytes.Length);

            ms.Position = 0; //이부분이 중요
            byte[] buffer = new byte[5];
            ms.Read(buffer, 0, 5);

            foreach (byte b in buffer) 
            {
                Console.WriteLine(b+ " ");
            }
            Console.WriteLine();
;
        }
    }
}
