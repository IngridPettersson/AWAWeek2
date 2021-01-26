using System;
using System.Collections.Generic;

namespace Epidemic
{
    class ProgramEpidemic
    {
        static List<Person> discoDancers = new List<Person>();
        static int dancersAtDisco = 50;
        static int hoursPassed = 0;
        static int infectiousDancers;
        static int immuneDancers;
        static void Main(string[] args)
        {
            AddPeopleToList();
            Console.WriteLine(discoDancers.Count);
            InfectIndex0();
            // Each infected person infects 1 other person per hour, so expontential increase. After 6 hours all will be infected (64 but we only have 50 dancers) 
            // and 1 will be immune, so 49 infected and 1 immune. After 12 hours all will be immune and noone infected.
            CalculateStatus(hoursPassed);
            GetTegnellsUpdates();
            Console.WriteLine("Press any key to make time fly!");
            Console.ReadLine();
            hoursPassed++;
            CalculateStatus(hoursPassed);
            GetTegnellsUpdates();
            hoursPassed++;
            CalculateStatus(hoursPassed);
            GetTegnellsUpdates();


        }

        private static void AddPeopleToList()
        {
            for (int i = 0; i < dancersAtDisco; i++)
            {
                Person dancer = new Person();
                discoDancers.Add(dancer);
                Console.WriteLine();
            }
        }
        private static void InfectIndex0()
        {
            discoDancers[0].Infected = true;
            infectiousDancers++;
        }

        private static void CalculateStatus(int hoursPassed)
        {
            for (int i = 0; i < discoDancers.Count; i += 2)
            {
                if (discoDancers[i].Infected == true)
                {
                    infectiousDancers++;
                    for (int j = 0; j < discoDancers.Count; j++)
                    {
                        if (discoDancers[j].Infected == false)
                        {
                            discoDancers[j].Infected = true;
                        } 
                    }
                }
                else
                {
                    break;
                }
            }
        }

        private static void GetTegnellsUpdates()
        {
            Console.Write($"Hours passed: ...\n");
            Console.Write($"Infected: ...\n");
            Console.Write($"Immune: ...\n");

        }
    }
}
