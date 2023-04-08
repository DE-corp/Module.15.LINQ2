using System;
using System.Collections.Generic;
using System.Linq;

namespace Module._15.LINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            var contacts = new List<Contact>()
            {
               new Contact() { Name = "Андрей", Phone = 79994500508 },
               new Contact() { Name = "Сергей", Phone = 799990455 },
               new Contact() { Name = "Иван", Phone = 79999675334 },
               new Contact() { Name = "Игорь", Phone = 8884994 },
               new Contact() { Name = "Анна", Phone = 665565656 },
               new Contact() { Name = "Василий", Phone = 3434 }
            };

            Console.WriteLine(contacts
                .Where(c => c.Phone.ToString().StartsWith('7'))
                .Where(c => c.Phone.ToString().Length == 11)
                .Count());
        }
    }

    public class Contact
    {
        public string Name { get; set; }
        public long Phone { get; set; }
    }
}
