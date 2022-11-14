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
    class GetAllPlayersDataDelegate : DataReaderDelegate<IReadOnlyList<Player>>
    {
        private readonly string name;

        public GetAllPlayersDataDelegate()
           : base("NBA.GetAllPlayers")
        {
            
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<Player> Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            var list = new List<Player>();

            while (reader.Read())
            {
                list.Add(new Player(
                   reader.GetInt32("PlayerID"),
                   reader.GetInt32("CurrentTeamID"),
                   reader.GetString("Name")));
            }

            return list;
        }
    }
}
