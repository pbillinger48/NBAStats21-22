using DataAccess;
using NBAStatsData.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData.DataDelegates
{
    public class RetrieveTeamSeasonSummariesDataDelegate: DataReaderDelegate<IReadOnlyList<TeamSeasonSummary>>
    {
        private readonly string TeamName;
        public RetrieveTeamSeasonSummariesDataDelegate(string teamName)
         : base("NBA.RetrieveTeamSeasonSummaries")
        {
            TeamName = teamName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            if (TeamName != "") command.Parameters.AddWithValue("TeamName", TeamName);
        }

        public override IReadOnlyList<TeamSeasonSummary> Translate(SqlCommand command, IDataRowReader reader)
        {
            var TeamSeasonSummariesList = new List<TeamSeasonSummary>();

            while (reader.Read())
            {
                TeamSeasonSummariesList.Add(new TeamSeasonSummary(
                   reader.GetString("Name"),
                   reader.GetInt32("Wins"),
                   reader.GetInt32("Losses"),
                   reader.GetValue<Decimal>("AveragePointsScored"),
                   reader.GetValue<Decimal>("AveragePointsAgainst"),
                   reader.GetInt32("GamesPlayed")));
            }

            return TeamSeasonSummariesList;
        }
    }
}
