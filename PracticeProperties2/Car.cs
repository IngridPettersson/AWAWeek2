using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProperties2
{
    class Car
    {
        private string licenseNumber = "ABC123";
        private string color;

        public string LicenseNumber
        {
            get { return licenseNumber; }
            set 
            {
                
                while (licenseNumber != value)
                {
                    
                    int number;
                    string substringNumbers;
                    value = AskForLicNum();
                    if (value.Length == 6)
                    {
                        substringNumbers = value.Substring(3);
                    }
                    else
                    {
                        Console.WriteLine("Entered license number is either too short or too long. It must be exactly 6 characters long.");
                        continue;
                    }

                    if (int.TryParse(substringNumbers, out number) == true && number >= 0 && number <= 999)
                    {
                        licenseNumber = value;
                        licenseNumber = licenseNumber.ToUpper();
                        string substringLetters = licenseNumber.Substring(0, 3);
                        substringNumbers = licenseNumber.Substring(3);
                        licenseNumber = $"*** {substringLetters} {substringNumbers} ***";
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid license number, please try again.");
                        continue;
                    }
                }
                
            }
        }

        public static string AskForLicNum()
        {
            Console.Write("Enter license number of car, in the format \"ABC123\" or \"abc123\": ");
            string inputLicNum = Console.ReadLine();
            return inputLicNum;
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
