using System;

namespace Enumerators
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3 };

            foreach (int a in array)
            {
                Console.WriteLine(a);
            }

            // En array tillhör redan Enumerator (Enumerable?) interface. Det foreach-loopen egentligen gör är följande:

            var enumerator = array.GetEnumerator();
            
            while (enumerator.MoveNext()) // while there is another item in the array. The enumerator does not ahve a predefined length so it just moves until there is no next item to move to.
                Console.WriteLine(enumerator.Current);
        }
    }
}
