using System;

namespace PropertiesCar
{
    class Program
    {
        static string inputLicenseNumber;
        static string inputColor;
        static bool looping = true;

        static void Main(string[] args)
        {
            Car[] cars = new Car[100];
            int i = 0;
            while (looping)
            {
                AddCar(cars, i);
                i++;
            }

            PrintOut(cars);
        }

        private static void PrintOut(Car[] cars)
        {
            Console.Clear();
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] == null)
                    break;
                else
                    Console.WriteLine($"CAR {i + 1}\nLicense Number: {cars[i].LicenseNumber}\nColor: {cars[i].Color}\n");

            }
        }

        private static void AddCar(Car[] cars, int index)
        {
            ConsoleKey keyPress = GetUserInput();
            if (keyPress == ConsoleKey.A)
            {
                Car car = new Car();
                car.LicenseNumber = inputLicenseNumber;
                car.Color = inputColor;
                cars[index] = car;
            }

        }

        public static ConsoleKey GetUserInput()
        {
            Console.WriteLine("Make your choice: \n");
            Console.WriteLine("[A]dd car");
            Console.WriteLine("[E]xit");
            ConsoleKey keyPress = Console.ReadKey(true).Key;

            if (keyPress == ConsoleKey.A)
            {
                Console.Clear();
                Console.Write("Enter license number of car: ");
                inputLicenseNumber = Console.ReadLine();
                Console.Write("\nEnter color of car (must be \"green\", \"blue\", \"red\" or \"magenta\"): ");
                inputColor = Console.ReadLine().ToLower();
                Console.WriteLine();

            }
            else
                looping = false;
            return keyPress;

        }
    }
}
