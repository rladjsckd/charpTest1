namespace LinqConsoleApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1 };

            //var result = from n in numbers
            //             where n %2 == 0
            //             orderby n
            //             select n;

            var result = from n in numbers
                         where n % 2 == 0
                         orderby n
                         select n;

            foreach (var n in result)
                Console.WriteLine(n);
        }
    }
}
