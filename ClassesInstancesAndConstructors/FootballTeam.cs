using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesInstancesAndConstructors
{
    class FootballTeam
    {
        public string TeamName { get; set; }
        public string CoachName { get; set; }
        public int SquadSize { get; set; }

        public FootballTeam() : this("N/A", "N/A", -1) // Vi anropar här en annan constructor-metod.
        {
        }

        public FootballTeam(string teamName = "N/A", string coachName = "N/A", int squadSize = 10)
        {
            TeamName = teamName;
            CoachName = coachName;
            SquadSize = squadSize;
                
        }

        public FootballTeam(string teamName) : this(teamName, "N/A", -1) // Här kan vi fylla på med värden andra än null för string resp 0 för int, även om man själv skriver teamname
            //och då anropar denna constructor.
        {
            TeamName = teamName;
        }

    }
}
