using System;
using System.IO;
using System.Threading;

namespace FileReaderWriter_Binary

{

    internal class Program

    {
        static void Run(string path, byte[] picture) 
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {

                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(picture);
                bw.Flush(); //이진파일 Flush() 신경
                bw.Close();
            }
        }
        static void Main(string[] args)

        {

            string path = "C:\\Temp\\pic1.png";

            byte[] picture;

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                BinaryReader br = new BinaryReader(fs);
                picture = br.ReadBytes((int)fs.Length);
                br.Close();
            }

            path = "C:\\Temp\\pic2.png";

            Thread t1 = new Thread(() => Run(path, picture));
            t1.Name = "Thread-1";
            t1.Start(); //혹시 main이 죽으면 같이 죽음
            t1.Join(); //main 스레드가 기다려주는 것
        }

    }

}
