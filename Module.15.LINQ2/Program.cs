using System;
using System.Collections.Generic;
using System.Linq;

namespace Module._15.LINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            var punctuation = new List<char>() { ' ', ',', '.', ';', ':', '!', '?' };

            Console.Write("Введи строку: ");
            var line = Console.ReadLine();

            if (string.IsNullOrEmpty(line))
            {
                Console.WriteLine("Вы ввели пустой текст");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Текст без знаков препинания: ");

            var noPunctuation = line.Except(punctuation).ToArray();
            Console.WriteLine(noPunctuation);
        }
    }
}
