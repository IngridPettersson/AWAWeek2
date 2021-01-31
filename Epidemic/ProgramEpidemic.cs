using System;
using System.Collections.Generic;

namespace Epidemic
{
    class ProgramEpidemic
    {
        static List<Person> discoDancersList = new List<Person>();
        static int totalDancers = 50;
        static int hoursPassed = 0;
        static int infectiousDancers = 0;
        static int immuneDancers = 0;
        static int healthyDancers = totalDancers - (infectiousDancers + immuneDancers);
        static void Main(string[] args)
        {
            AddPeopleToList();
            InfectCaseZero();
            Console.WriteLine("We do have a pandemic... click yourself through Tegnells hourly updates!");
            Console.ReadLine();
            Console.Clear();
            ListenToTegnell();
            Console.WriteLine();

            while (immuneDancers != discoDancersList.Count)
            {
                Console.WriteLine("Press any key to make time fly!");
                Console.ReadLine();
                Console.Clear();
                hoursPassed++;
                CalculateImmune(hoursPassed);
                SpreadVirus(hoursPassed);
                //CalculateInfected(hoursPassed);
                ListenToTegnell();
                Console.WriteLine();
            }

            Console.WriteLine($"Wohooo! {totalDancers} dancers infected and immune after just {hoursPassed} hours! Must have been a Swedish disco ;)");
            Console.ReadLine();
        }

        private static void AddPeopleToList()
        {
            for (int i = 0; i < totalDancers; i++)
            {
                Person dancer = new Person();
                discoDancersList.Add(dancer);
            }
        }
        private static void InfectCaseZero()
        {
            discoDancersList[0].Infected = true;
            discoDancersList[0].InfectedWhen = 0;
            infectiousDancers++;
        }

        private static void SpreadVirus(int hoursPassed) //måste lägga till minus antalet som blivit immuna den här vändan! 
        {
            int i;
            for (i = 0; i < discoDancersList.Count; i++)
            {
                if (discoDancersList[i].Infected == true && discoDancersList[i].InfectedWhen < hoursPassed)
                {
                    if (discoDancersList[i].Immune == true && discoDancersList[i].ImmuneWhen == hoursPassed || discoDancersList[i].Immune == false)
                    {
                        for (int j = i + 1; j < discoDancersList.Count; j++)
                        {
                            if (discoDancersList[j].Infected == false)
                            {
                                discoDancersList[j].Infected = true;
                                discoDancersList[j].InfectedWhen = hoursPassed;
                                infectiousDancers++;
                                break;
                            }
                            else
                                continue;
                        }

                    }
                    else
                        continue;

                }
                else
                    break;
            }
        }

        private static void CalculateImmune(int hoursPassed)
        {
            for (int i = 0; i < discoDancersList.Count; i++)
            {
                if (discoDancersList[i].Infected == true && hoursPassed - discoDancersList[i].InfectedWhen == 5)
                {
                    discoDancersList[i].Immune = true;
                    discoDancersList[i].ImmuneWhen = hoursPassed;
                    immuneDancers++;
                    infectiousDancers--;
                }
            }
        }

        //private static void CalculateInfected(int hoursPassed)
        //{
        //    for (int i = 0; i < discoDancers.Count; i++)
        //    {
        //        if (discoDancers[i].Immune == true && discoDancers[i].ImmuneWhen == hoursPassed)
        //        {
        //            infectiousDancers--;
        //        }
        //    }
        //}

        private static void ListenToTegnell()
        {
            Console.Write($"Hours passed: {hoursPassed}\n");
            Console.Write($"Infected: {infectiousDancers}\n"); // minus de som blev immuna denna timme OCH när man nått totalDancers/discoDancersList.Count så ska immuneDancers +
            // infectedDancers == totalDancers.
            Console.Write($"Immune: {immuneDancers}\n");

        }
    }
}
