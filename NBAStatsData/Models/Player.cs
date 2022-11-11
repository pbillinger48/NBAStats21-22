using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData.Models
{
    public class Player
    {
        public int PlayerID { get; }
        public int CurrentTeamID { get; }
        public string Name { get; }

        public Player(int playerID, int currentTeamID, string name)
        {
            PlayerID = playerID;
            CurrentTeamID = currentTeamID;
            Name = name;
        }
    }
}
