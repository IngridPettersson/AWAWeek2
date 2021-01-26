using System;
using System.Collections.Generic;

namespace Epidemic
{
    class ProgramEpidemic
    {
        static List<Person> discoDancers = new List<Person>();
        static int dancersAtDisco = 50;
        static int hoursPassed = 0;
        static int infectiousDancers = 0;
        static int immuneDancers;
        static void Main(string[] args)
        {
            AddPeopleToList();
            InfectCaseZero();
            // Each infected person infects 1 other person per hour, so expontential increase. After 6 hours all will be infected (64 but we only have 50 dancers) 
            // and 1 will be immune, so 49 infected and 1 immune. After 12 hours all will be immune and noone infected.
            CalculateInfected(hoursPassed);
            CalculateImmune(hoursPassed);
            ListenToTegnell();
            Console.WriteLine("Press any key to make time fly!");
            Console.ReadLine();
            hoursPassed++;
            CalculateInfected(hoursPassed);
            ListenToTegnell();
            Console.WriteLine("Press any key to make time fly!");
            Console.ReadLine();
            hoursPassed++;
            CalculateInfected(hoursPassed);
            ListenToTegnell();
            Console.WriteLine("Press any key to make time fly!");
            Console.ReadLine();
            hoursPassed++;
            CalculateInfected(hoursPassed);
            ListenToTegnell();
            Console.WriteLine("Press any key to make time fly!");
            Console.ReadLine();
            hoursPassed++;
            CalculateInfected(hoursPassed);
            ListenToTegnell();
            Console.WriteLine("Press any key to make time fly!");
            Console.ReadLine();
            hoursPassed++;
            CalculateInfected(hoursPassed);
            ListenToTegnell();
            Console.WriteLine("Press any key to make time fly!");
            Console.ReadLine();
            hoursPassed++;
            CalculateInfected(hoursPassed);
            ListenToTegnell();
            Console.WriteLine("Press any key to make time fly!");
            Console.ReadLine();
            hoursPassed++;
            CalculateInfected(hoursPassed);
            ListenToTegnell();
            Console.WriteLine("Press any key to make time fly!");
            Console.ReadLine();
            hoursPassed++;
            CalculateInfected(hoursPassed);
            ListenToTegnell();
            Console.WriteLine("Press any key to make time fly!");
            Console.ReadLine();
            hoursPassed++;
            CalculateInfected(hoursPassed);
            ListenToTegnell();
            Console.WriteLine("Press any key to make time fly!");
            Console.ReadLine();
            hoursPassed++;
            CalculateInfected(hoursPassed);
            ListenToTegnell();
            Console.WriteLine("Press any key to make time fly!");
            Console.ReadLine();
            hoursPassed++;
            CalculateInfected(hoursPassed);
            ListenToTegnell();
            Console.WriteLine("Press any key to make time fly!");
            Console.ReadLine();
            hoursPassed++;
            CalculateInfected(hoursPassed);
            ListenToTegnell();
            Console.WriteLine("Press any key to make time fly!");
            Console.ReadLine();
            hoursPassed++;
            CalculateInfected(hoursPassed);
            ListenToTegnell();
            Console.WriteLine("Press any key to make time fly!");
            Console.ReadLine();
        }

        private static void AddPeopleToList()
        {
            for (int i = 0; i < dancersAtDisco; i++)
            {
                Person dancer = new Person();
                discoDancers.Add(dancer);
            }
        }
        private static void InfectCaseZero()
        {
            discoDancers[0].Infected = true;
            discoDancers[0].InfectedWhen = 0;
            infectiousDancers++;
            hoursPassed++;
        }

        private static void CalculateInfected(int hoursPassed)
        {
            int i;
            for (i = 0; i < discoDancers.Count; i ++)
            {
                if (discoDancers[i].Infected == true && discoDancers[i].InfectedWhen < hoursPassed)
                {
                   
                    for (int j = i + 1; j < discoDancers.Count; j++)
                    {
                        if (discoDancers[j].Infected == false)
                        {
                            discoDancers[j].Infected = true;
                            discoDancers[j].InfectedWhen = hoursPassed;
                            infectiousDancers++;
                            break;
                        } 
                    }
                }
                else
                {
                    break;
                }
            }
        }

        private static void CalculateImmune(int hoursPassed)
        {
            for (int i = 0; i < discoDancers.Count; i++)
            {
                if (discoDancers[i].Infected == true && hoursPassed - discoDancers[i].InfectedWhen == 5)
                {

                }
            }
        }

        private static void ListenToTegnell()
        {
            Console.Write($"Hours passed: {hoursPassed}\n");
            Console.Write($"Infected: {infectiousDancers}\n");
            Console.Write($"Immune: ...\n");

        }
    }
}
