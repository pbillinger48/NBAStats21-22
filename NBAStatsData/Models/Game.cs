using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData.Models
{
    public class Game
    {
        public int GameID { get; }
        public DateTime GameDate { get; }

        public Game(int gameID, DateTime gameDate)
        {
            GameID = gameID;
            GameDate = gameDate;
        }
    }
}
