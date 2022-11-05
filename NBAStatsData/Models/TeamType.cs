using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData.Models
{
    public class TeamType
    {
        public int TeamTypeID { get; }
        public string Name { get; }

        public TeamType(int teamTypeID, string name)
        {
            TeamTypeID = teamTypeID;
            Name = name;
        }
    }
}
