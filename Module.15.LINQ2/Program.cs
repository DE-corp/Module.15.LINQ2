using System;
using System.Collections.Generic;
using System.Linq;

namespace Module._15.LINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", 799900000013, "serg@gmail.com"));
            phoneBook.Add(new Contact("Иннокентий", 799900000013, "innokentii@example.com"));

            var sorted = phoneBook.GroupBy(c => c.Email.Split("@").Last());

            foreach (var c in sorted)
            {
                if (c.Key.Contains("example"))
                {
                    Console.WriteLine("Фейковые адреса: ");

                    foreach (var contact in c)
                        Console.WriteLine(contact.Name + " " + contact.Email);

                }
                else
                {
                    Console.WriteLine("Реальные адреса: ");
                    foreach (var contact in c)
                        Console.WriteLine(contact.Name + " " + contact.Email);
                }
            }
        }
    }

    internal class Contact
    {
        public string Name;
        public long Phone;
        public string Email;

        public Contact(string name, long phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }
    }
}
