using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData.Models
{
    public class TeamSeasonSummary
    {
        public string TeamName { get; }
        public int Wins { get; }
        public int Losses { get; }
            
        public decimal PPGScored { get; }
            
        public decimal PPGGivenUp { get; }
        
        public int GamesPlayed { get; }

        public TeamSeasonSummary(string teamName, int wins, int losses, decimal ppgScored, decimal ppgGivenUp, int gamesPlayd)
        {
            TeamName = teamName;
            Wins = wins;
            Losses = losses;
            PPGScored = ppgScored;
            PPGGivenUp = ppgGivenUp;
            GamesPlayed = gamesPlayd;
        }
    }
}
