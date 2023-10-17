using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCvApp001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Cv2.GetVersionString());

            int width = 640;
            int height = 480;

            int rows = 480;
            int cols = 640;

            //2D화면(장면) 만들기
            //Mat color = new Mat(new Size(width, height), MatType.CV_8UC3);
            //Mat gray = new Mat(rows, cols, MatType.CV_8UC1);
            var color = new Mat("lenna.jpg", ImreadModes.Color);
            var gray = new Mat("lenna.jpg", ImreadModes.Grayscale);

            //모니터로 출력
            new Window("color", color);
            new Window("gray", gray);

            Cv2.WaitKey(); //잠시멈춤... Any키를 누르면 동작
        }
    }
}
