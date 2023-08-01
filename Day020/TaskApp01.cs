using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //main 동작중...
            Action someAction = () => 
            {
                //1. 1~100까지 더하기
                int sum = 0;
                for (int i = 0; i < 101; i++) 
                {
                    sum = sum + i;
                } 
                Console.WriteLine(sum);
            };
            
            Task myTask1 = new Task(someAction); //Action대리자 구현부
            myTask1.Start();
            myTask1.Wait(); //Join()

            Task myTask2 = Task.Run (() =>
            {
                //2. A ~ Z까지 출력
                char start = 'A';
                char end = 'Z';

                for (char letter = start; letter <= end; letter++)
                {
                    Console.Write(letter + " ");
                }
            });

            myTask2.Wait();  //Join()

            Console.WriteLine();
            Console.WriteLine("main 종료");
        }
    }
}
