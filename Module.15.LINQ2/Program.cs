using System;
using System.Collections.Generic;
using System.Linq;

namespace Module._15.LINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }
        static string[] GetAllStudents(Classroom[] classes)
        {
            // Запрос LINQ
            var result = from c in classes
                         from s in c.Students
                         select s;

            // Метод расширения
            var result1 = classes.SelectMany(c => c.Students);

            return result.ToArray();
        }
    }

    public class Classroom
    {
        public List<string> Students = new List<string>();
    }
}
