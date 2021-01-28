using System;
using System.Collections.Generic;

namespace Epidemic
{
    class ProgramEpidemic
    {
        static List<Person> discoDancers = new List<Person>();
        static int dancersAtDisco = 1000;
        static int hoursPassed = 0;
        static int infectiousDancers = 0;
        static int immuneDancers = 0;
        static void Main(string[] args)
        {
            AddPeopleToList();
            InfectCaseZero();
            Console.WriteLine("We do have a pandemic... click yourself through Tegnells hourly updates!");
            Console.ReadLine();
            Console.Clear();
            ListenToTegnell();
            Console.WriteLine();

            while (immuneDancers != discoDancers.Count)
            {
                Console.WriteLine("Press any key to make time fly!");
                Console.ReadLine();
                Console.Clear();
                hoursPassed++;
                SpreadVirus(hoursPassed);
                CalculateImmune(hoursPassed);
                CalculateInfected(hoursPassed);
                ListenToTegnell();
                Console.WriteLine();
            }

            Console.WriteLine($"Wohooo - {dancersAtDisco} dancers infected and immune after just {hoursPassed} hours! Must have been a Swedish disco ;)");
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
        }

        private static void SpreadVirus(int hoursPassed) //måste lägga till minus antalet som blivit immuna den här vändan! 
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
                    discoDancers[i].Immune = true;
                    discoDancers[i].ImmuneWhen = hoursPassed;
                    immuneDancers++;
                    
                }
            }
        }

        private static void CalculateInfected(int hoursPassed)
        {
            for (int i = 0; i < discoDancers.Count; i++)
            {
                if(discoDancers[i].Immune == true && discoDancers[i].ImmuneWhen == hoursPassed)
                {
                    infectiousDancers--;
                }
            }
        }

        private static void ListenToTegnell()
        {
            Console.Write($"Hours passed: {hoursPassed}\n");
            Console.Write($"Infected: {infectiousDancers}\n"); // minus de som blev immuna denna timme
            Console.Write($"Immune: {immuneDancers}\n");

        }
    }
}
