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
    class RetrieveTeamsCurrentPlayersDataDelegate : DataReaderDelegate<IReadOnlyList<TeamsCurrentPlayers>>
    {
        public readonly string TeamName;
        public RetrieveTeamsCurrentPlayersDataDelegate(string teamName)
           : base("NBA.RetrieveTeamsCurrentPlayers")
        {
            TeamName = teamName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            if (TeamName != "") command.Parameters.AddWithValue("TeamName", TeamName);
        }

        public override IReadOnlyList<TeamsCurrentPlayers> Translate(SqlCommand command, IDataRowReader reader)
        {
            var list = new List<TeamsCurrentPlayers>();

            while (reader.Read())
            {
                list.Add(new TeamsCurrentPlayers(
                   reader.GetString("Name"),
                   reader.GetInt32("GamesPlayed"),
                   reader.GetInt32("TotalMinutesPlayed")));
            }

            return list;
        }
    }
}
