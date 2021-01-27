using System;

namespace TuplesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var meMyself = GetAgeAndName();
            Console.WriteLine(meMyself.Age);
            Console.WriteLine(meMyself.Name);
        }
        // I stället för tuples så var det klassiska sättet att skapa en ny klass med flera proeprties och skapa en instans av klassen.
        private static (int Age, string Name) GetAgeAndName()
        {
            return (33, "Strumpan");
        }
    }
}
