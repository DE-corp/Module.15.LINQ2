using System;
using System.Linq;

namespace Module._15.LINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 5, 3, 2, 6, 412, 43 };
            Console.WriteLine(Average(numbers));

        }

        private static double Average(int[] numbers)
        {
            return numbers.Sum() / (double)numbers.Count();
        }
    }
}
