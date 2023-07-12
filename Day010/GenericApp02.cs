using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp02
{
    class MyList<T> 
    {
        private T[] array;

        public MyList() 
        {
            array = new T[3];
        }
        public T this[int index] 
        {
            get 
            {
                return array[index];
            }
            set 
            {
                if (index >= array.Length) 
                {
                    Array.Resize<T>(ref array, index + 1);
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
