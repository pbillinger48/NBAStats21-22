using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData.Models
{
    public class Coach
    {
        public int CoachID { get; }
        public int TeamID { get; }
        public string Name { get; }

        public Coach(int coachID, int teamID, string name)
        {
            CoachID = coachID;
            TeamID = teamID;
            Name = name;
        }
    }
}
