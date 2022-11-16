using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData.Models
{
    public class PlayerGameStats
    {
        public string PlayerName;
        public string TeamName;
        public int Points;
        public int Rebounds;
        public int Assists;
        public int Blocks;
        public int Steals;
        public int Turnovers;
        public int Minutes;
        public string OppName;
        public DateTime Date;

        public PlayerGameStats(string pN, string tN, int p, int r, int a, int b, int s, int t, int m, string opp, DateTime d)
        {
            PlayerName = pN;
            TeamName = tN;
            Points = p;
            Rebounds = r;
            Assists = a;
            Blocks = b;
            Steals = s;
            Turnovers = t;
            Minutes = m;
            OppName = opp;
            Date = d;
        }
    }
}
