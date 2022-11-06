using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData.Models
{
    public class Team
    {
        public int TeamID { get; }
        public string Name { get; }
        public string OwnerName { get; }
        public string Location { get; }
        public string StadiumName { get; }

        public Team(int teamID, string name, string ownerName, string location, string stadiumName)
        {
            TeamID = teamID;
            Name = name;
            OwnerName = ownerName;
            Location = location;
            StadiumName = stadiumName;
        }
    }
}
