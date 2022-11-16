using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData.Models
{
    public class TeamGameResults
    {
        public DateTime Date;
        public string Team;
        public int TeamScore;
        public int OpponentScore;
        public string Opponent;
        public string RESULT;
        public string Location;

        public TeamGameResults(DateTime date, string team, int tS, int oS, string opp, string result, string loc)
        {
            Date = date;
            Team = team;
            TeamScore = tS;
            OpponentScore = oS;
            Opponent = opp;
            RESULT = result;
            Location = loc;
        }
    }
}
