using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData.DataDelegates
{
    public class InsertGameStatDataDelegate : NonQueryDataDelegate<bool>
    {
        public readonly DateTime Date;
        public readonly string HomeTeam;
        public readonly string AwayTeam;
        public readonly string PlayerName;
        public readonly string PlayerTeam;
        public readonly int Points;
        public readonly int Rebounds;
        public readonly int Assists;
        public readonly int Blocks;
        public readonly int Steals;
        public readonly int Turnovers;
        public readonly decimal Minutes;

        public InsertGameStatDataDelegate(DateTime date, string homeTeam, string awayTeam, string playerName, string playerTeam,
            int points, int rebounds, int assists, int blocks, int steals, int turnovers, decimal minutes)
           : base("NBA.InsertGameStat")
        {
            this.Date = date;
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.PlayerName = playerName;
            this.PlayerTeam = playerTeam;
            this.Points = points;
            this.Rebounds = rebounds;
            this.Assists = assists;
            this.Blocks = blocks;
            this.Steals = steals;
            this.Turnovers = turnovers;
            this.Minutes = minutes;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GameDate", Date);
            command.Parameters.AddWithValue("HomeTeam", HomeTeam);
            command.Parameters.AddWithValue("AwayTeam", AwayTeam);
            command.Parameters.AddWithValue("PlayerName", PlayerName);
            command.Parameters.AddWithValue("PlayerTeam", PlayerTeam);
            command.Parameters.AddWithValue("Points", Points);
            command.Parameters.AddWithValue("Rebounds", Rebounds);
            command.Parameters.AddWithValue("Assists", Assists);
            command.Parameters.AddWithValue("Blocks", Blocks);
            command.Parameters.AddWithValue("Steals", Steals);
            command.Parameters.AddWithValue("Turnovers", Turnovers);
            command.Parameters.AddWithValue("Minutes", Minutes);

        }

        public override bool Translate(SqlCommand command)
        {
            return true;
        }
    }
}
