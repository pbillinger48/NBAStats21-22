using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData.Models
{
    public class Coach
    {
        public string TeamName { get; }
        public string Name { get; }

        public Coach(string teamName, string name)
        {
            TeamName = teamName;
            Name = name;
        }
    }
}
