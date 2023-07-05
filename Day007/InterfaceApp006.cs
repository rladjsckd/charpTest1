using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp006
{
    interface ILogger 
    {
        void WriteLog(string message);
    }
    interface IFomattableLogger : ILogger 
    {
        void WriteLog(string fomat, params Object[] args);
    }
    class ConsoleLogger2 : IFomattableLogger
    {
        public void WriteLog(string message)
        {
            throw new NotImplementedException();
        }

        public void WriteLog(string fomat, params object[] args)
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
