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
    class RetrievePlayerVsOpponentStatsDataDelegate : DataReaderDelegate<PlayerVsOpponentStats>
    {
        private readonly string PlayerName;
        private readonly string OpponentName;

        public RetrievePlayerVsOpponentStatsDataDelegate(string playerName, string opponentName)
           : base("NBA.RetrievePlayerVsOpponentStats")
        {
            this.PlayerName = playerName;
            this.OpponentName = opponentName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("PlayerName", PlayerName);
            command.Parameters.AddWithValue("OpponentName", OpponentName);
        }

        public override PlayerVsOpponentStats Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new PlayerVsOpponentStats(
               reader.GetString("PlayerName"),
               reader.GetValue<Decimal>("PointsPG"),
               reader.GetValue<Decimal>("ReboundsPG"),
               reader.GetValue<Decimal>("AssistsPG"),
               reader.GetValue<Decimal>("BlocksPG"),
               reader.GetValue<Decimal>("StealsPG"),
               reader.GetValue<Decimal>("TurnoversPG"),
               reader.GetValue<Decimal>("MinutesPG"),
               reader.GetString("TeamName"),
               reader.GetString("OpponentName")
               );
        }
    }
}
