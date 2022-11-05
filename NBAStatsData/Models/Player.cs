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
        public string Age { get; }
        public string Position { get; }
        public string Height { get; }
        public string Weight { get; }

        public Player(int playerID, int currentTeamID, string name, string age, string position, string height, string weight)
        {
            PlayerID = playerID;
            CurrentTeamID = currentTeamID;
            Name = name;
            Age = age;
            Position = position;
            Height = height;
            Weight = weight;
        }
    }
}
