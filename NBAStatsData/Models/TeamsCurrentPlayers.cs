using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData.Models
{
    public class TeamsCurrentPlayers
    {
        public string Name;
        public int GamesPlayed;
        public int TotalMinutesPlayed;

        public TeamsCurrentPlayers(string name, int gamesPlayed, int totalMinutesPlayed)
        {
            Name = name;
            GamesPlayed = gamesPlayed;
            TotalMinutesPlayed = totalMinutesPlayed;
        }
    }
}
