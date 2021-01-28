using System;

namespace PropertiesCar
{
    class Program
    {
        static string inputLicenseNumber = "";
        static bool looping = true;

        static void Main(string[] args)
        {
            Car[] cars = new Car[100];
            while (looping)
            {
                int i = 0;
                AddCar(cars);
                i++;
            }

            PrintOut(cars);
        }

        private static void PrintOut(Car[] cars)
        {
            for
        }

        private static void AddCar(Car[] cars)
        {
            Car car = new Car();
            GetUserInput();
            car.LicenseNumber = inputLicenseNumber;


        }

        public static void GetUserInput()
        {
            Console.WriteLine("Make your choice: \n");
            Console.WriteLine("[A]dd car");
            Console.WriteLine("[E]xit");
            ConsoleKey keyPress = Console.ReadKey(true).Key;

            if (keyPress == ConsoleKey.A)
            {
                Console.Write("\nEnter license number of car: ");
                inputLicenseNumber = Console.ReadLine();
                Console.WriteLine();
            }
            else
                looping = false;

        }
    }
}
