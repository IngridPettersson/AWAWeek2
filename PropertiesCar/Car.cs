using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesCar
{
    class Car
    {
        private string licenseNumber;

        public string LicenseNumber
        {
            get
            {
                string letters = licenseNumber.Substring(0, 3).ToUpper();
                string numbers = licenseNumber.Substring(3);
                return $"*** {letters} {numbers} ***";
            }
            set
            {
                int number;
                bool isNumber = int.TryParse(value.Substring(3), out number);
                if (value.Length == 6 && isNumber && number < 999 && number >= 0)
                    licenseNumber = value;
                else
                    throw new Exception();
            }
        }

        private string color;

        public string Color
        {
            get
            {
                switch (color)
                {
                    case "green":
                        color = "grön";
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "blue":
                        color = "blå";
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case "red":
                        color = "röd";
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "magenta":
                        color = "magenta";
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;
                }
                return color;
            }
            set
            {
                switch (value)
                {
                    case "green":
                        color = value;
                        break;
                    case "blue":
                        color = value;
                        break;
                    case "red":
                        color = value;
                        break;
                    case "magenta":
                        color = value;
                        break;
                    default:
                        throw new Exception();
                }
                
            }
        }


    }
}
