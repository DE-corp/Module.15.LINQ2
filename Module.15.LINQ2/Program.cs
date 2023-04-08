using System;
using System.Collections.Generic;
using System.Linq;

namespace Module._15.LINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(20));
        }

        static long Factorial(int number)
        {
            var numbers = new List<int>();
            for (var i = 1; i < number; i++)
            {
                numbers.Add(i);
            }

            long result = numbers.Aggregate((x, y) => x * y);
            return result;
        }
    }
}
