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
    class GetPlayerDataDelegate : DataReaderDelegate<Player>
    {
        private readonly string name;

        public GetPlayerDataDelegate(string name)
           : base("NBA.GetPlayer")
        {
            this.name = name;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
        }

        public override Player Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Player(
               reader.GetInt32("PlayerID"),
               reader.GetInt32("CurrentTeamID"),
               name);
        }
    }
}
