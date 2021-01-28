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

            PrintOut();
            RemoveContact();
            PrintOut();
            SortContactList();
            PrintOut();
        }

        private static void SortContactList()
        {

        }

        private static void PrintOut()
        {
            Console.WriteLine("Press any key to see your contact list!");
            Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < contactList.Count; i++)
            {
                Console.WriteLine("\nCONTACT");
                Console.WriteLine(contactList[i].FirstName);
                Console.WriteLine(contactList[i].PhoneNumber);
                Console.WriteLine(contactList[i].Email);
                Console.WriteLine();
            }
        }

        private static void RemoveContact()
        {
            Console.WriteLine("Now it's time to remove a contact from your list!\n");
            Console.Write("Enter first name of contact you want to remove: ");
            string name = Console.ReadLine();

            for (int i = 0; i < contactList.Count; i++)
            {
                if (contactList[i].FirstName == name)
                    contactList.RemoveAt(i);
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
