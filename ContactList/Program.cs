using System;
using System.Collections.Generic;

namespace ContactList
{
    class Program
    {
        List<Person> contactList = new List<Person>(); // Vill man lägga listan i Main eller i klassen Person?
        static void Main(string[] args)
        {
            Console.WriteLine("We're gonna add contacts to your contact list! Press any key to add new contact.");
            Console.ReadKey(true);
            Person addedContact = AddContactInfo();
            AddContactToList(addedContact);
        }

        static Person AddContactInfo()
        {
            Person contact = new Person();

            Console.Write("Enter contacts first name: ");
            contact.FirstName = Console.ReadLine();

            Console.Write("Add contacts phone number: ");
            contact.PhoneNumber = Console.ReadLine();

            Console.Write("Add contacts email address: ");
            contact.Email = Console.ReadLine();

            return contact;
        }

        private static void AddContactToList(Person contact)
        {
            conta
        }
    }
}
