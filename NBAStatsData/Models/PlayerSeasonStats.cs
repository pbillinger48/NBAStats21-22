using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData.Models
{
    public class PlayerSeasonStats
    {
        public string CurrentTeamName { get; }
        public string Name { get; }
        public Decimal PointsPerGame { get;  }
        public Decimal ReboundsPerGame { get;  }
        public Decimal AssistsPerGame { get;  }
        public Decimal BlocksPerGame { get; }
        public Decimal StealsPerGame { get; }
        public Decimal TurnoversPerGame { get; }
        public Decimal MinutesPerGame { get;  }

        public PlayerSeasonStats(string name , string teamName, decimal ppg, decimal rpg, decimal apg, decimal bpg,
                        decimal spg, decimal tpg, decimal mpg)
        {
            Name = name;
            CurrentTeamName = teamName;
            PointsPerGame = ppg;
            ReboundsPerGame = rpg;
            AssistsPerGame = apg;
            BlocksPerGame = bpg;
            StealsPerGame = spg;
            TurnoversPerGame = tpg;
            MinutesPerGame = mpg;
        }
    }
}
