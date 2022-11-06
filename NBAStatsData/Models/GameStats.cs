using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData.Models
{
    public class GameStats
    {
        public int GameStatsID { get; }
        public int GameID { get; }
        public int TeamID { get; }
        public int PlayerID { get; }
        public int Points { get; }
        public int Rebounds { get; }
        public int Assists { get; }
        public int Blocks { get; }
        public int Steals { get; }
        public int Minutes { get; }

        public GameStats(int gameStatsID, int gameID, int teamID, int playerID, int points, int rebounds, int assists,
            int blocks, int steals, int minutes)
        {
            GameStatsID = gameStatsID;
            GameID = gameID;
            TeamID = teamID;
            PlayerID = playerID;
            Points = points;
            Rebounds = rebounds;
            Assists = assists;
            Blocks = blocks;
            Steals = steals;
            Minutes = minutes;
        }
    }
}
