using System;
using System.Collections.Generic;
using System.Linq;

namespace Module._15.LINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
          

            var employees = new List<Employee>()
           {
               new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
               new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
               new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
               new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
           };
            var employeeArray = employees.ToArray();
            // Выводим значение до добавления элемента
            Console.WriteLine(employeeArray.Count());
            employees.Add(new Employee() { DepartmentId = 1, Name = "Дмитрий", Id = 5 });
            // Выводим значение после добавления элемента
            Console.WriteLine(employeeArray.Count());
            // Они одинаковые, значит выполняется мгновенно

        }
    }

    internal class Employee
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
