using System;

namespace Checkpoint2
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 1 && value <= 125)
                    age = value;
                else
                    throw new Exception("Age must be in the range of 1 to 125.");
            }
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }

    class ProgramCheckpoint2
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[6]
            {
                new Person("Bo", "Andersson", 45),
                new Person("Li", "Johansson", 34),
                new Person("An", "Pettersson", 43),
                new Person("Io", "Johansson", 66),
                new Person("El", "Karlsson", 20),
                new Person("Lo", "Pettersson", 55),
            };

            //Console.WriteLine($"Average age: {AverageAge(people, "Pettersson")}");
            //Console.WriteLine($"Median age: {MedianAge(people, "Pettersson")}");
            Console.WriteLine($"Median age: {MedianAgeFlawless(people, "Pettersson")}");
        }

        static double AverageAge(Person[] people, string lastName)
        {
            double totalAge = 0;
            double lengthOfArray = people.Length;

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].LastName != lastName)
                    totalAge += people[i].Age;
                else if (people[i].LastName == lastName)
                    lengthOfArray--;

            }
            if (lengthOfArray > 0)
                return Math.Round(totalAge / lengthOfArray, 1);
            else
                throw new Exception("Can not divide by zero.");
        }

        static double MedianAge(Person[] people, string lastName)
        {
            Person savedPerson;
            Person[] newPeople;
            double medianAge = 0.0;
            int lengthOfArray = people.Length;

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].LastName == lastName)
                {
                    people[i].Age = 1;
                    lengthOfArray--;
                }
            }

            newPeople = new Person[lengthOfArray];
            int k = 0;
            int p = 0;

            while (k < people.Length)
            {
                if (people[k].Age != 1)
                {
                    savedPerson = new Person(people[k].FirstName, people[k].LastName, people[k].Age);
                    newPeople[p] = savedPerson;
                    p++;
                }
                k++;
            }

            for (int i = 0; i < newPeople.Length - 1; i++)
            {
                int lvi = i;

                for (int j = i + 1; j < newPeople.Length; j++)
                {
                    if (newPeople[j].Age < newPeople[lvi].Age)
                        lvi = j;

                }

                if (lvi != i)
                {
                    int tempInt = newPeople[i].Age;
                    newPeople[i].Age = newPeople[lvi].Age;
                    newPeople[lvi].Age = tempInt;
                }
            }

            if (newPeople.Length % 2 != 0)
                medianAge = newPeople[newPeople.Length / 2 + 1].Age;
            else if (newPeople.Length % 2 == 0)
            {
                int medianHigh = newPeople.Length / 2;
                int medianLow = newPeople.Length / 2 - 1;
                medianAge = (newPeople[medianHigh].Age + newPeople[medianLow].Age) / 2.0;
            }

            return Math.Round(medianAge, 1);
        }

        static double MedianAgeFlawless(Person[] people, string lastName)
        {
            double medianAge = 0.0;
            int[] tempArr = new int[people.Length];
            int counter = 0;

            for (int i = 0; i < people.Length; i++)
            {
                if(people[i].LastName != lastName)
                {
                    tempArr[i] = people[i].Age;
                } else if (people[i].LastName == lastName)
                {
                    tempArr[i] = -1;
                    counter++;
                }
            }

            Array.Sort(tempArr);
            int newLength = people.Length - counter;
            int[] newArr = new int[newLength];

            for (int i = 0; i < newLength; i++)
            {
                newArr[i] = tempArr[counter + i];
            }

            if (newArr.Length % 2 != 0)
                medianAge = newArr[newArr.Length / 2 + 1];
            else if (newArr.Length % 2 == 0)
            {
                int medianHigh = newArr.Length / 2;
                int medianLow = newArr.Length / 2 - 1;
                medianAge = (newArr[medianHigh] + newArr[medianLow]) / 2.0;
            }

            return Math.Round(medianAge, 1);



        }

    }

}

