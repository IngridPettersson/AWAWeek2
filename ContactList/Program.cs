using System;
using System.Collections.Generic;

namespace ContactList
{
    public class Program
    {
        static List<Person> contactList = new List<Person>(); // Vill man lägga listan i Main eller i klassen Person?
        static ConsoleKey pressedKey = ConsoleKey.Y;
        
        static void Main(string[] args)
        {
            Console.WriteLine("We're gonna add contacts to your contact list! Press any key to add new contact.");
            Console.ReadKey(true);

            while (pressedKey == ConsoleKey.Y)
            {
            AddContact();
            pressedKey = AskUserToContinue();
            } 
        }

        static void AddContact()
        {
            Person addedContact = AddContactInfo();
            AddContactToList(addedContact);
        }

        private static ConsoleKey AskUserToContinue()
        {
            Console.WriteLine("Do you want to add another contact?\n");
            Console.WriteLine("[Y]es");
            Console.WriteLine("[N]o");

            return Console.ReadKey(true).Key;

        }

        static Person AddContactInfo()
        {
            Person contact = new Person();

            Console.Write("\nEnter contacts first name: ");
            contact.FirstName = Console.ReadLine();

            Console.Write("Add contacts phone number: ");
            contact.PhoneNumber = Console.ReadLine();

            Console.Write("Add contacts email address: ");
            contact.Email = Console.ReadLine();

            return contact;
        }

        static void AddContactToList(Person contact)
        {
            contactList.Add(contact);
        }
    }
}
