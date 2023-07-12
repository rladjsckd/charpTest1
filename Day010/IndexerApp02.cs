using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerApp02
{
    class ArrayWrapper
    {
        private int[] array;

        public ArrayWrapper()
        {
            array = new int[5];
        }
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
        public void PrintElements()
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayWrapper list = new ArrayWrapper();
            for (int i = 0; i < 5; i++)
            {
                list[i] = i * 10;
            }
            list.PrintElements();
        }
    }
}
