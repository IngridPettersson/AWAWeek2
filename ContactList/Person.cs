using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ContactList
{
    [Serializable]
    class Person
    {
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Address Address1 { get; set; }
        public Address Address2 { get; set; }
        public Address Address3 { get; set; }


    }
}
