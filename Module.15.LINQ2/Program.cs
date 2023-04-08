using System;
using System.Collections.Generic;
using System.Linq;

namespace Module._15.LINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.Write("Введи число: ");
                var isNumber = int.TryParse(Console.ReadLine(), out int number);

                if (!isNumber)
                {
                    Console.WriteLine("Нужно ввести число!");
                    continue;
                }

                numbers.Add(number);

                Console.WriteLine();

                Console.WriteLine($"Количество чисел в списке: " + numbers.Count());
                Console.WriteLine($"Сумма чисел в списке: " + numbers.Sum());
                Console.WriteLine($"Наибольшее число: " + numbers.Max());
                Console.WriteLine($"Наименьшее число: " + numbers.Min());
                Console.WriteLine($"Cреднее значение: " + numbers.Average());

            }
        }
    }
}
