using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData.DataDelegates
{
    public class InsertGameAndTeamGamesDataDelegate : NonQueryDataDelegate<bool>
    {
        public readonly DateTime Date;
        public readonly string HomeTeam;
        public readonly string AwayTeam;
        public readonly int HomeScore;
        public readonly int AwayScore;

        public InsertGameAndTeamGamesDataDelegate(DateTime date, string homeTeam, string awayTeam, int homeScore, int awayScore)
           : base("NBA.InsertGameAndTeamGames")
        {
            this.Date = date;
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.HomeScore = homeScore;
            this.AwayScore = awayScore;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GameDate", Date);
            command.Parameters.AddWithValue("HomeTeam", HomeTeam);
            command.Parameters.AddWithValue("AwayTeam", AwayTeam);
            command.Parameters.AddWithValue("HomeScore", HomeScore);
            command.Parameters.AddWithValue("AwayScore", AwayScore);

        }

        public override bool Translate(SqlCommand command)
        {
            return true;
        }
    }
}
