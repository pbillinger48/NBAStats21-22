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
    public class RetrieveTeamGameResultsDataDelegate : DataReaderDelegate<IReadOnlyList<TeamGameResults>>
    {
        private readonly string TeamName;
        private readonly string OpponentName;
        private readonly string Result;
        private readonly int? PointsMin;
        private readonly int? PointsMax;
        private readonly int? OppPointsMin;
        private readonly int? OppPointsMax;
        public RetrieveTeamGameResultsDataDelegate(string teamName, string opponentName, string gameResult,
            int? pointsMin, int? pointsMax, int? oppPointsMin, int? oppPointsMax)
         : base("NBA.RetrieveTeamGameResults")
        {
            TeamName = teamName;
            OpponentName = opponentName;
            Result = gameResult;
            PointsMin = pointsMin;
            PointsMax = pointsMax;
            OppPointsMin = oppPointsMin;
            OppPointsMax = oppPointsMax;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            if (TeamName != "") command.Parameters.AddWithValue("TeamName", TeamName);
            if (OpponentName != "") command.Parameters.AddWithValue("OpponentName", OpponentName);
            if (Result != "") command.Parameters.AddWithValue("GameResult", Result);
            if (PointsMin != null) command.Parameters.AddWithValue("PointsMin", PointsMin);
            if (PointsMax != null) command.Parameters.AddWithValue("PointsMax", PointsMax);
            if (OppPointsMin != null) command.Parameters.AddWithValue("OppPointsMin", OppPointsMin);
            if (OppPointsMax != null) command.Parameters.AddWithValue("OppPointsMax", OppPointsMax);
        }

        public override IReadOnlyList<TeamGameResults> Translate(SqlCommand command, IDataRowReader reader)
        {
            var list = new List<TeamGameResults>();

            while (reader.Read())
            {
                list.Add(new TeamGameResults(
                   reader.GetValue<DateTime>("Date"),
                   reader.GetString("Team"),
                   reader.GetInt32("TeamScore"),
                   reader.GetInt32("OpponentScore"),
                   reader.GetString("Opponent"),
                   reader.GetString("RESULT"),
                   reader.GetString("Location")));
            }

            return list;
        }
    }
}
