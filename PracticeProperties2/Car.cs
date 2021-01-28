using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProperties2
{
    class Car
    {
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private string licenseNumber;

        public string LicenseNumber
        {
            get { return licensenumber; }
            set
            {
                int number;
                string licNumCorrectFormat = "ABC123";
                
                string substringNumbers = "";

                Console.Write("Enter license number of car, in the format \"ABC123\" or \"abc123\": ");
                string inputLicNum = Console.ReadLine();
                bool validInput = inputLicNum.Length == 6;

                while (licenseNumber != licNumCorrectFormat)
                {
                    if (validInput)
                    {
                        inputLicNum = inputLicNum.ToUpper();
                        string substringLetters = inputLicNum.Substring(0, 3);
                        substringNumbers = inputLicNum.Substring(3);
                        licNumCorrectFormat = $"*** {substringLetters} {substringNumbers} ***";
                    }
                    if (int.TryParse(substringNumbers, out number) == true && number >= 0 && number <= 999)
                    {
                        licenseNumber = licNumCorrectFormat;
                        licensenumber = value;
                    }
                    else
                    {
                        Console.Write("Invalid license number. Try again: ");
                        inputLicNum = Console.ReadLine();
                        continue;
                    }
                }

                
            }
        }



        public static string AskForLicNum()
        {
            int value;
            string licNumCorrectFormat = "ABC123";
            string licenseNumber = "";
            string substringNumbers = "";

            Console.Write("Enter license number of car, in the format \"ABC123\" or \"abc123\": ");
            string inputLicNum = Console.ReadLine();
            bool validInput = inputLicNum.Length == 6;

            while (licenseNumber != licNumCorrectFormat)
            {
                if (validInput)
                {
                    inputLicNum = inputLicNum.ToUpper();
                    string substringLetters = inputLicNum.Substring(0, 3);
                    substringNumbers = inputLicNum.Substring(3);
                    licNumCorrectFormat = $"*** {substringLetters} {substringNumbers} ***";
                }
                if (int.TryParse(substringNumbers, out value) == true && value >= 0 && value <= 999)
                {
                    licenseNumber = licNumCorrectFormat;
                }
                else
                {
                    Console.Write("Invalid license number. Try again: ");
                    inputLicNum = Console.ReadLine();
                    continue;
                }
            }

            return licenseNumber;
        }


        public static string AskForColor()
        {
            Console.Write("Enter color of car: ");
            string inputColor = Console.ReadLine();
            return inputColor;
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
