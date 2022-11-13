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
    public class RetrievePlayersSeasonStatsDataDelegate : DataReaderDelegate<IReadOnlyList<PlayerSeasonStats>>
    {
        public RetrievePlayersSeasonStatsDataDelegate()
         : base("NBA.RetrievePlayersSeasonStats")
        {
        }

        public override IReadOnlyList<PlayerSeasonStats> Translate(SqlCommand command, IDataRowReader reader)
        {
            var PlayersSeasonStatsList = new List<PlayerSeasonStats>();

            while (reader.Read())
            {
                PlayersSeasonStatsList.Add(new PlayerSeasonStats(
                   reader.GetString("PlayerName"),
                   reader.GetString("TeamName"),
                   reader.GetValue<Decimal>("PointsPG"),
                   reader.GetValue<Decimal>("ReboundsPG"),
                   reader.GetValue<Decimal>("AssistsPG"),
                   reader.GetValue<Decimal>("BlocksPG"),
                   reader.GetValue<Decimal>("StealsPG"),
                   reader.GetValue<Decimal>("TurnoversPG"),
                   reader.GetValue<Decimal>("MinutesPG")));
            }

            return PlayersSeasonStatsList;
        }
    }
}
