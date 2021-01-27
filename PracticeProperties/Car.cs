using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProperties
{
    class Car
    {
        private string licenseNumber = "ABC123";
        private string color;

        public static string AskForColor()
        {
            Console.Write("Enter color of car: ");
            string inputColor = Console.ReadLine();
            return inputColor;
        }

        public static string AskForLicNum()
        {
            Console.Write("Enter license number of car, in the format \"ABC123\" or \"abc123\": ");
            string inputLicNum = Console.ReadLine();
            return inputLicNum;
        }
        public string SetLicenseNumber()
        {
            string inputLicNum = "";
            int value;

            while (licenseNumber != inputLicNum)
            {
                string substringNumbers;
                inputLicNum = AskForLicNum();
                if (inputLicNum.Length == 6)
                {
                substringNumbers = inputLicNum.Substring(3);
                }
                else
                {
                    Console.WriteLine("Entered license number is either too short or too long. It must be exactly 6 characters long.");
                    continue;
                }

                if (int.TryParse(substringNumbers, out value) == true && value >= 0 && value <= 999)
                {
                    licenseNumber = inputLicNum;
                }
                else
                {
                    Console.WriteLine("Invalid license number, please try again.");
                    continue;
                }

            }
            return licenseNumber;

        }

        public string GetLicenseNumber()
        {
            licenseNumber = licenseNumber.ToUpper();
            string substringLetters = licenseNumber.Substring(0, 3);
            string substringNumbers = licenseNumber.Substring(3);
            string licNumCorrectFormat = $"*** {substringLetters} {substringNumbers} ***";

            return licNumCorrectFormat;
        }

        public void SetColor(string inputColor)
        {
            inputColor = inputColor.ToLower();
            if (inputColor == "red" || inputColor == "green" || inputColor == "blue" || inputColor == "yellow")
            {
                color = inputColor;
            }
            else
            {
                throw new Exception();
            }
        }

        public string GetColor()
        {
            string colorInSwedish;

            if (color == "green")
                colorInSwedish = "grön";
            else if (color == "blue")
                colorInSwedish = "blå";
            else if (color == "yellow")
                colorInSwedish = "gul";
            else if (color == "red")
                colorInSwedish = "röd";
            else
                colorInSwedish = "färg okänd";

            return colorInSwedish;
        }

    }
}
