using System;

namespace ClassesInstancesAndConstructors
{
    class ProgramConstructors
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Brand = "Volvo";
            myCar.LicenseNumber = "CWZ635";
            myCar.TypeOfFuel = "Electric";
            myCar.Make = "XC60";
            myCar.YearOfManufacture = 2006;
            myCar.IncreaseCurrentSpeed(2);
        }
    }
}
