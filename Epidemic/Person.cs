using System;
using System.Collections.Generic;
using System.Text;

namespace Epidemic
{
    class Person
    {
        public string Name { get; set; }
        public bool Infected { get; set; }
        public int InfectedWhen { get; set; }
        public bool Immune { get; set; }
        public Person(string name)
        {
            Name = name;
        }
    }
}
