using System;

namespace PracticeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            string inputLicNum = AskForLicNum();
            car1.SetLicenseNumber(inputLicNum);
            car1.GetLicenseNumber();
            Console.Write("Enter color of car: ");
            string inputColor = Console.ReadLine();
            car1.SetColor(inputColor);
        }

        public static string AskForLicNum()
        {
            Console.Write("Enter license number of car: ");
            string inputLicNum = Console.ReadLine();
            return inputLicNum;
        }
    }
}
