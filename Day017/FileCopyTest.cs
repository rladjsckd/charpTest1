using System;

using System.Collections.Generic;

using System.IO;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace FileCopyTest

{

    internal class Program

    {

        static void Main(string[] args)

        {

            //File 클래스를 이용한 Copy

            string path = "C:\\Users\\Admin\\Desktop";

            FileStream fs = new FileStream(path, FileMode.Create);

            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

            sw.WriteLine("Hello C#");

            sw.Flush();

            sw.Close();

            byte[] buffer = File.ReadAllBytes(path);



            string path2 = "C:\\Users\\Admin\\Desktop";

            File.WriteAllBytes(path2, buffer);



        }

    }

}
