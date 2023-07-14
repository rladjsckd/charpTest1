using System;

namespace Quiz06
{
    internal class Program
    {
        //static void Method(int size)

        //{
        //    int[] arr = new int[5] { 1, 2, 3, 4, 5 };
        //    try 
        //    {
        //        for (int i = 0; i < size; i++)

        //        {
        //            Console.Write(arr[i] + " ");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        Environment.Exit(0);
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("정상종료");
        //}
        static void Method(int size) 
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            try 
            {
                for (int i = 0; i < size; i++) 
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
            Console.WriteLine();
            Console.WriteLine("정상종료");
        }

        static void Main(string[] args)

        {
                //Console.Write("입력 : ");
                //int size = int.Parse(Console.ReadLine());
                //Method(size);
        }
    }
}
