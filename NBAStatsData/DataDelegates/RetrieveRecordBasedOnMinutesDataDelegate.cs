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
    class RetrieveRecordBasedOnMinutesDataDelegate : DataReaderDelegate<RecordBasedOnMinutes>
    {
        private readonly string PlayerName;
        private readonly decimal MinutesThreshold;

        public RetrieveRecordBasedOnMinutesDataDelegate(string playerName, decimal minutesThreshold)
           : base("NBA.RetrieveRecordBasedOnMinutes")
        {
            this.PlayerName = playerName;
            this.MinutesThreshold = minutesThreshold;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("PlayerName", PlayerName);
            command.Parameters.AddWithValue("MinutesThreshold", MinutesThreshold);
        }

        public override RecordBasedOnMinutes Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new RecordBasedOnMinutes(
               reader.GetString("PlayerName"),
               reader.GetString("TeamName"),
               reader.GetInt32("WinsWhenThresholdMet"),
               reader.GetInt32("LossesWhenThresholdMet"),
               reader.GetInt32("WinsWhenThresholdNotMet"),
               reader.GetInt32("LossesWhenThresholdNotMet")
               );
        }
    }
}
