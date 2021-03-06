﻿using System;

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

            for (int i = 0; i < addedCars; i++)
            {
                Console.WriteLine($"\nCAR {i + 1}\nLicense number: {cars[i].GetLicenseNumber()}\nColor: {cars[i].GetColor()}");
            }
        }

        public static Car AddCar()
        {
            Car car = new Car();

            
            string inputLicNum = car.SetLicenseNumber();
            car.GetLicenseNumber();
            string inputColor = Car.AskForColor();
            car.SetColor(inputColor);
            car.GetColor();
            

            return car;

        }

    }
}
