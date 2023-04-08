using System;
using System.Linq;

namespace Module._15.LINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstWord = "Привет";
            var secondWord = "мир";
            var list = firstWord.Intersect(secondWord);

            foreach (var c in list)
                Console.WriteLine(c);


        }
    }
}
