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
    public class RetrievePlayersMonthStatsDataDelegate: DataReaderDelegate<IReadOnlyList<PlayerMonthStats>>
    {
        private readonly string name;
        private readonly int month;

        public RetrievePlayersMonthStatsDataDelegate(int month, string name)
           : base("NBA.RetrievePlayersMonthStats")
        {
            this.name = name;
            this.month = month;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            if(name != "")command.Parameters.AddWithValue("Name", name);
            if(month != 0)command.Parameters.AddWithValue("MONTH", month);
        }

        public override IReadOnlyList<PlayerMonthStats> Translate(SqlCommand command, IDataRowReader reader)
        {
            var PlayersMonthStatsList = new List<PlayerMonthStats>();

            while (reader.Read())
            {
                 PlayersMonthStatsList.Add(new PlayerMonthStats(
               reader.GetString("PlayerName"),
               reader.GetInt32("Rank"),
               reader.GetValue<Decimal>("PointsPG"),
               reader.GetValue<Decimal>("ReboundsPG"),
               reader.GetValue<Decimal>("AssistsPG"),
               reader.GetValue<Decimal>("BlocksPG"),
               reader.GetValue<Decimal>("StealsPG"),
               reader.GetValue<Decimal>("TurnoversPG"),
               reader.GetValue<Decimal>("MinutesPG"),
               reader.GetInt32("GamesPlayed")));
            }
            return PlayersMonthStatsList;
        }
    }
}
