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
    public class RetrievePlayersGameStatsDataDelegate: DataReaderDelegate<IReadOnlyList<PlayerGameStats>>
    {
        private readonly string Name;
        private readonly int? PointsMin;
        private readonly int? PointsMax;
        private readonly int? MinutesMin;
        private readonly int? MinutesMax;
        private readonly string OppName;

        public RetrievePlayersGameStatsDataDelegate(string pN, int? pointsMin, int? pointsMax, int? minMin, int? minMax, string oN)
           : base("NBA.RetrievePlayersGameStats")
        {
            Name = pN;
            PointsMin = pointsMin;
            PointsMax = pointsMax;
            MinutesMin = minMin;
            MinutesMax = minMax;
            OppName = oN;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            if(Name != "")command.Parameters.AddWithValue("PlayerName", Name);
            if (PointsMin != null) command.Parameters.AddWithValue("PointsMin", PointsMin);
            if (PointsMax != null) command.Parameters.AddWithValue("PointsMax", PointsMax);
            if (MinutesMin != null) command.Parameters.AddWithValue("MinutesMin", MinutesMin);
            if (MinutesMax != null) command.Parameters.AddWithValue("MinutesMax", MinutesMax);
            if (OppName != "")command.Parameters.AddWithValue("OppName", OppName);
        }

        public override IReadOnlyList<PlayerGameStats> Translate(SqlCommand command, IDataRowReader reader)
        {
            var list = new List<PlayerGameStats>();

            while (reader.Read())
            {
                 list.Add(new PlayerGameStats(
               reader.GetString("PlayerName"),
               reader.GetString("TeamName"),
               reader.GetInt32("Points"),
               reader.GetInt32("Rebounds"),
               reader.GetInt32("Assists"),
               reader.GetInt32("Blocks"),
               reader.GetInt32("Steals"),
               reader.GetInt32("Turnovers"),
               reader.GetInt32("Minutes"),
               reader.GetString("OppName"),
               reader.GetValue<DateTime>("Date")));
            }
            return list;
        }
    }
}
