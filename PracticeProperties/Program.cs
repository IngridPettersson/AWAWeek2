using System;

namespace PracticeProperties
{
    class Program
    {
        static int addedCars = 0;

        static void Main(string[] args)
        {
            Car[] cars = new Car[100];
            bool keepAsking = addedCars <= cars.Length ? true : false;


            while (keepAsking)
            {
                Console.WriteLine("Press Enter if you want to add a car. If not, press any other key.");
                if (ConsoleKey.Enter == Console.ReadKey(true).Key)
                {
                    Car car = AddCar();
                    cars[addedCars] = car;
                    addedCars++;
                }

                else
                    break;
            }
        }

        public static Car AddCar()
        {
            Car car = new Car();

            string inputLicNum = AskForLicNum();
            car.SetLicenseNumber(inputLicNum);
            car.GetLicenseNumber();
            string inputColor = AskForColor();
            car.SetColor(inputColor);
            car.GetColor();
            

            return car;

        }

        public static string AskForColor()
        {
            Console.Write("Enter color of car: ");
            string inputColor = Console.ReadLine();
            return inputColor;
        }

        public static string AskForLicNum()
        {
            Console.Write("Enter license number of car: ");
            string inputLicNum = Console.ReadLine();
            return inputLicNum;
        }
    }
}
