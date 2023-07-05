using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp005
{
    interface ILogger 
    {
        void WrtieLog(string message);
    }
    class FileLogger : ILogger
    {
        private StreamWriter writer;

        public FileLogger(string path) 
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }
        public void WrtieLog(string message)
        {
            writer.WriteLine(DateTime.Now.ToShortTimeString()+" " +message);
        }
    }
    class ClimateMonitor 
    {
        private ILogger logger;

        public ClimateMonitor(ILogger logger) 
        {
            this.logger = logger;
        }
        public void start() 
        {
            while (true) 
            {
                Console.Write("온도를 입력해주세요 : ");
                string temperature = Console.ReadLine();

                if (temperature == "")
                    break;
                logger.WrtieLog("현재 온도 : "+ temperature);

            }

        }
    }

    internal class Program
    {
        static void Main(string[] args) 
        {
            ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MyLog.txt"));
            monitor.start();
        }
     
    }
}
