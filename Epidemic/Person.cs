using System;
using System.Collections.Generic;
using System.Text;

namespace Epidemic
{
    class Person
    {
        public bool Infected { get; set; }
        // Person gets well again after 5 hours
        public int InfectedWhen { get; set; }
        // When the person gets well after 5 hours (s)he can not get infected again
        public bool Immune { get; set; }
        public int ImmuneWhen { get; set; }
    }
}
