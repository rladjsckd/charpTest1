using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp04
{
    class MyList<T> where T : struct // T는 값 형식 이어야 합니다.    
    {
    }
    class Car<T> where T : class // T는 참조 형식 이어야 한다.
    { 
    }
    class Dog<T> where T : new() // T는 반드시 매개변수가 없는 생성자가 있어야 합니다.
    {
    } 
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
