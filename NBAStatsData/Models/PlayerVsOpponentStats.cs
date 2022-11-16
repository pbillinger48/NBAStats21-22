using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData.Models
{
    public class PlayerVsOpponentStats
    {
        public string PlayerName;
        public decimal PointsPG;
        public decimal ReboundsPG;
        public decimal AssistsPG;
        public decimal BlocksPG;
        public decimal StealsPG;
        public decimal TurnoversPG;
        public decimal MinutesPG;
        public string TeamName;
        public string OpponentName;

        public PlayerVsOpponentStats(string pN, decimal ppg, decimal rpg, decimal apg, decimal bpg, decimal spg, decimal tpg, decimal mpg,
            string tN, string oN)
        {
            PlayerName = pN;
            PointsPG = ppg;
            ReboundsPG = rpg;
            AssistsPG = apg;
            BlocksPG = bpg;
            StealsPG = spg;
            TurnoversPG = tpg;
            MinutesPG = mpg;
            TeamName = tN;
            OpponentName = oN;
        }

    }
}
