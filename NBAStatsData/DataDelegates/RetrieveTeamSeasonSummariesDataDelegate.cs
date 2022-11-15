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
        private readonly int? WinsMin;
        private readonly int? WinsMax;
        private readonly int? LossesMin;
        private readonly int? LossesMax;
        private readonly decimal? PPGScoredMin;
        private readonly decimal? PPGScoredMax;
        private readonly decimal? PPGAgainstMin;
        private readonly decimal? PPGAgainstMax;
        private readonly int? GamesPlayedMin;
        private readonly int? GamesPlayedMax;
        public RetrieveTeamSeasonSummariesDataDelegate(string teamName, int? winsMin, int? winsMax, int? lossesMin, int? lossesMax, decimal? ppgScoredMin, decimal? ppgScoredMax,
            decimal? ppgAgainstMin, decimal? ppgAgainstMax, int? gamesPlayedMin, int? gamesPlayedMax)
         : base("NBA.RetrieveTeamSeasonSummaries")
        {
            TeamName = teamName;
            WinsMin = winsMin;
            WinsMax = winsMax;
            LossesMin = lossesMin;
            LossesMax = lossesMax;
            PPGScoredMin = ppgScoredMin;
            PPGScoredMax = ppgScoredMax;
            PPGAgainstMin = ppgAgainstMin;
            PPGAgainstMax = ppgAgainstMax;
            GamesPlayedMin = gamesPlayedMin;
            GamesPlayedMax = gamesPlayedMax;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            if (TeamName != "") command.Parameters.AddWithValue("TeamName", TeamName);
            if (WinsMin != null) command.Parameters.AddWithValue("WinsMin", WinsMin);
            if (WinsMax != null) command.Parameters.AddWithValue("WinsMax", WinsMax);
            if (LossesMin != null) command.Parameters.AddWithValue("LossesMin", LossesMin);
            if (LossesMax != null) command.Parameters.AddWithValue("LossesMax", LossesMax);
            if (PPGScoredMin != null) command.Parameters.AddWithValue("PPGScoredMin", PPGScoredMin);
            if (PPGScoredMax != null) command.Parameters.AddWithValue("PPGScoredMax", PPGScoredMax);
            if (PPGAgainstMin != null) command.Parameters.AddWithValue("PPGAgainstMin", PPGAgainstMin);
            if (PPGAgainstMax != null) command.Parameters.AddWithValue("PPGAgainstMax", PPGAgainstMax);
            if (GamesPlayedMin != null) command.Parameters.AddWithValue("GamesPlayedMin", GamesPlayedMin);
            if (GamesPlayedMax != null) command.Parameters.AddWithValue("GamesPlayedMax", GamesPlayedMax);
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
                   reader.GetValue<Decimal>("PPGScored"),
                   reader.GetValue<Decimal>("PPGAgainst"),
                   reader.GetInt32("GamesPlayed")));
            }

            return TeamSeasonSummariesList;
        }
    }
}
