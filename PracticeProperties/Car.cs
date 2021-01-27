using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProperties
{
    class Car
    {
        private string licenseNumber = "";
        private string color;

        public void SetLicenseNumber(string licNum)
        {
            string substringNumbers = licNum.Substring(3);
            int value;

            if (int.TryParse(substringNumbers, out value) == true && value >= 0 && value <= 999 && licNum.Length == 6)
            {
                licenseNumber = licNum;
            }
            else
            {
                Console.WriteLine("Invalid licensenumber, please try again.");
                Console.ReadLine();
                Program.AskForLicNum();
            }

        }

        public string GetLicenseNumber()
        {
            licenseNumber = licenseNumber.ToUpper();
            string substringLetters = licenseNumber.Substring(0, 3);
            string substringNumbers = licenseNumber.Substring(3);
            string licNumCorrectFormat = $"*** {substringLetters} {substringNumbers} ***";
            Console.WriteLine(licNumCorrectFormat);
            //char[] inputCharArr = (Console.ReadLine().ToCharArray());

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
