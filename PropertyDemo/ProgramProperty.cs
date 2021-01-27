using System;
using MyClassLibrary;

namespace PropertyDemo
{
    class ProgramProperty
    {
        static void Main(string[] args)
        {
            LivingPerson person = new LivingPerson();
            //person.SetAge(33);
            //Console.WriteLine(person.GetAge());

            //person.Age = 330; // Set
            //int whatAge = person.Age; // Get

            person.Age = 18;

            person.SomeMethod(10);

        }
    }
}
