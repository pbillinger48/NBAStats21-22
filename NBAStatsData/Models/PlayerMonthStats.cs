using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData.Models
{
    public class PlayerMonthStats
    {
        public string Name { get; }
        public int Rank { get; }
        public Decimal PointsPerGame { get; }
        public Decimal ReboundsPerGame { get; }
        public Decimal AssistsPerGame { get; }
        public Decimal BlocksPerGame { get; }
        public Decimal StealsPerGame { get; }
        public Decimal TurnoversPerGame { get; }
        public Decimal MinutesPerGame { get; }

        public int GamesPlayed { get;  }

        public PlayerMonthStats(string name,int rank, decimal ppg, decimal rpg, decimal apg, decimal bpg,
                        decimal spg, decimal tpg, decimal mpg, int gamesPlayed)
        {
            Name = name;
            Rank = rank;
            PointsPerGame = ppg;
            ReboundsPerGame = rpg;
            AssistsPerGame = apg;
            BlocksPerGame = bpg;
            StealsPerGame = spg;
            TurnoversPerGame = tpg;
            MinutesPerGame = mpg;
            GamesPlayed = gamesPlayed;
        }
    }
}
