using System;
using MyClassLibrary;

namespace MyClassLibrary
{
    public class LivingPerson
    {
        // Klassmedlemmarna måste vara public för att synas utanför klassen.
        //private int age;

        //public void SetAge(int anAge) // Here we can validate the age before we set it
        //{
        //    if (anAge >= 0 && anAge <= 120)
        //        age = anAge;
        //    else
        //        age = 0;
        //}

        //public int GetAge()
        //{
        //    return age;
        //}

        // Samma som ovan men med properties

        private int age;

        // En xml-kommentar
        /// <summary>
        /// Sets and gets the age of a living person. Valid ages 0 - 120. 
        /// </summary>

        public int Age
        {
            set // set-delen kan betraktas som en metodkropp
            {
                if (value >= 0 && value <= 120)
                    age = value; // värdet som vi tilldelar vår property (via person.Age = 33 tex) var som helst ifrån landar i value.
                else
                    throw new Exception("Invalid age. Must be between 0 and 120.");
            }
            get { return age; }
        }

        //Man får fram mallen för xml-kommentar genom att skriva 3 /// precis ovanför det man vill dokumentera.

        /// <summary>
        /// Does it's thing.
        /// </summary>
        /// <param name="aValue">A very nice parameter.</param>

        public void SomeMethod(int aValue)
        {
            Console.WriteLine(aValue);
        }

       

    }
}
