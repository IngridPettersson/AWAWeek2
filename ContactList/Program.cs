using System;
using System.Collections.Generic;
using System.Linq;

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

            PrintOut(contactList);
            RemoveContact();
            PrintOut(contactList);
            contactList = SortContactList(contactList);
            PrintOut(contactList);
            ChangeContactInfo();

        }

        static void ChangeContactInfo()
        {
            Console.WriteLine("You want to change info about one of your contacts! Press any key to continue...");
            Console.ReadKey(true);
            Console.Write("Enter name of contact you want to change: ");
            string name = Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < contactList.Count; i++)
            {
                ConsoleKey input;
                if (contactList[i].FirstName == name)
                {
                    Console.WriteLine($"Contact info for {name}:\nName: {contactList[i].FirstName}\nPhone Number: {contactList[i].PhoneNumber}\nEmail: {contactList[i].Email}\n");
                }
                do
                {
                    Console.WriteLine("Which info would you like to change?\n");
                    Console.WriteLine("[F]irst name");
                    Console.WriteLine("[P]hone number");
                    Console.WriteLine("[E]mail");
                    Console.WriteLine("[B]ack to main menu");

                    input = Console.ReadKey(true).Key;

                    switch (input)
                    {
                        case ConsoleKey.F:
                            Console.Write("Enter new name: ");
                            contactList[i].FirstName = Console.ReadLine();
                            Console.WriteLine($"Name has changed to: {contactList[i].FirstName}\n");
                            break;
                        case ConsoleKey.P:
                            Console.Write("Enter new Phone Number: ");
                            contactList[i].PhoneNumber = Console.ReadLine();
                            Console.WriteLine($"Phone Number has changed to: {contactList[i].PhoneNumber}\n");
                            break;
                        case ConsoleKey.E:
                            Console.Write("Enter new email: ");
                            contactList[i].Email = Console.ReadLine();
                            Console.WriteLine($"Email has changed to: {contactList[i].Email}\n");
                            break;
                        default:
                            break;
                    }

                } while (input != ConsoleKey.B);


             }
        }


        private static List<Person> SortContactList(List<Person> contactList)
        {
            Console.WriteLine("Time to sort your list! Press any key to continue...");
            Console.ReadKey(true);
            List<Person> sortedContactList = contactList.OrderBy(o => o.FirstName).ToList();
            return sortedContactList;
        }

        private static void PrintOut(List<Person> list)
        {
            Console.WriteLine("Press any key to see your contact list!");
            Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("\nCONTACT");
                Console.WriteLine($"Name: {list[i].FirstName}");
                Console.WriteLine(list[i].PhoneNumber);
                Console.WriteLine(list[i].Email);
                Console.WriteLine(list[i].Address1.AddressType);
                Console.WriteLine(list[i].Address1.StreetName);
                Console.WriteLine(list[i].Address1.City);
                Console.WriteLine(list[i].Address1.Country);
                Console.WriteLine(list[i].Address2.AddressType);
                Console.WriteLine(list[i].Address2.StreetName);
                Console.WriteLine(list[i].Address2.City);
                Console.WriteLine(list[i].Address2.Country);
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

            Address address1 = AddAddress();
            Address address2 = AddAddress();
            contact.Address1 = address1;
            contact.Address2 = address2;

            return contact;
        }

        private static Address AddAddress()
        {
            Address address = new Address();

            Console.WriteLine("Add relevant addresses");
            Console.Write("Type of address (home, work, vacation etc.): ");
            address.AddressType = Console.ReadLine();

            Console.Write("Street name: ");
            address.StreetName = Console.ReadLine();

            Console.Write("City: ");
            address.City = Console.ReadLine();

            Console.Write("Country: ");
            address.Country = Console.ReadLine();

            return address;
        }

        static void AddContactToList(Person contact)
        {
            contactList.Add(contact);
        }

    }
}
