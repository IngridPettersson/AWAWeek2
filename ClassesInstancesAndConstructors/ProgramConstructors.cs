using System;

namespace ClassesInstancesAndConstructors
{
    class ProgramConstructors
    {
        static void Main(string[] args)
        {


            // default parameters
            double moms = MomsBelopp(100);
            Console.WriteLine(moms);
            double moms2 = MomsBelopp(100, 0.12);
            Console.WriteLine(moms2);



            //FootballTeam team = new FootballTeam("Academy", "Håkan", 23);

            //FootballTeam[] myTeams = new FootballTeam[3]
            //{
            //    new FootballTeam("Trosa IF") { TeamName = "Arsenal", SquadSize = 10, CoachName = "Carin Cula" },
            //    new FootballTeam("Nykvarn IP") { TeamName = "Arsenal", SquadSize = 10, CoachName = "Carin Cula" },
            //    new FootballTeam("Sjöboda IF") { TeamName = "Arsenal", SquadSize = 10, CoachName = "Carin Cula" },
            //};

            //Car myCar = new Car();
            //myCar.Brand = "Volvo";
            //myCar.LicenseNumber = "CWZ635";
            //myCar.TypeOfFuel = "Electric";
            //myCar.Make = "XC60";
            //myCar.YearOfManufacture = 2006;
            //myCar.IncreaseCurrentSpeed(2);
        }

        static double MomsBelopp(double belopp, double momsSats = 0.25)
        {
            return belopp * momsSats;
        }
    }
}
