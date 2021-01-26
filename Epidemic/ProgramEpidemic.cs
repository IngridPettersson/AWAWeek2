using System;
using System.Collections.Generic;

namespace Epidemic
{
    class ProgramEpidemic
    {
        static List<Person> discoDancers = new List<Person>();
        static void Main(string[] args)
        {
            AddPeopleToList();
        }

        private static void AddPeopleToList()
        {
            for (int i = 0; i < 51; i++)
            {
                string dancer = GetDancerName(i);
                
                discoDancers.Add(new Person(dancer));
            }
        }

        private static string GetDancerName(int i)
        {
            string dancerName = $"dancer{i}";
            return dancerName;
        }
    }
}
