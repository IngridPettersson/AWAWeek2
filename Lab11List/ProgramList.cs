using System;
using System.Collections.Generic;

namespace Lab11List

    // Add
    // Remove
    // RemoveAt
    // Contains
    // Count (property)
    // Sort
    // IndexOf
    // LastIndexOf
    // Reverse
    // Insert
    // Find All (måste använda predecates och kommer då in på delegates så inte än) - kontexten LINQ
{
    class ProgramList
    {
        static List<string> names = new List<string> { "Eva", "Adam" };
        static void Main(string[] args)
        {
            PrintNames();
            AddName();
            PrintNames();
            SortNames();
            PrintNames();
            RemoveName();
            PrintNames();
        }

        private static void SortNames()
        {
            names.Sort();
        }

        private static void AddName()
        {
            Console.Write("Enter name you want to add: ");
            string input = Console.ReadLine();
            names.Add(input);
        }

        private static void RemoveName()
        {
            Console.Write("Enter name you want to remove: ");
            string input = Console.ReadLine();
            names.Remove(input);
        }

        private static void PrintNames()
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }


    }
}
