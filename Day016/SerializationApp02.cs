using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SerializationApp02
{
    class Student 
    {
        public int STID { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "student.json";
            using (Stream ws = new FileStream(path, FileMode.Create)) 
            {
                Student st = new Student();
                st.STID = 12345;
                st.Name = "이순신";
                st.Major = "스마트팩토리";

                string jsonString = JsonSerializer.Serialize<Student>(st);
                byte[] jsonBytes = System.Text.Encoding.UTF8.GetBytes(jsonString);
                ws.Write(jsonBytes, 0, jsonBytes.Length);
            }

            using (Stream rs = new FileStream(path, FileMode.Open)) 
            {
                byte[] jsonBytes = new byte[rs.Length];
                rs.Read(jsonBytes, 0, jsonBytes.Length);
                string jsonString = System.Text.Encoding.UTF8.GetString(jsonBytes);

                Student st2 = JsonSerializer.Deserialize<Student>(jsonString);

                Console.WriteLine($"학번 :"+st2.STID);
                Console.WriteLine($"이름 :"+st2.Name);
                Console.WriteLine($"전공 :"+st2.Major);
            }

        }
    }
}
