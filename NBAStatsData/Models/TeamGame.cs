using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData.Models
{
    public class TeamGame
    {
        public int GameID { get; }
        public int TeamID { get; }
        public int TeamTypeID { get; }
        public int Score { get; }

        public TeamGame(int gameID, int teamID, int teamTypeID, int score)
        {
            GameID = gameID;
            TeamID = teamID;
            TeamTypeID = teamTypeID;
            Score = score;
        }
    }
}
