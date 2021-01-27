using System;
using AClassLibrary;

namespace PropertiesDemo
{
    class ProgramProperties
    {
        static void Main(string[] args)
        {
            

            bool done = false;
            do
            {
                LivingPerson person = new LivingPerson(0);
                Console.Write($"Justera nuvarande ålder {person.Age}: ");
                int age = int.Parse(Console.ReadLine());
                done = age > -1 && age < 121;
                if (done)
                    person.Age = age;
            } while (!done);
        }
    }
}
