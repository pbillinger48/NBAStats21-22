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
    class GetAllTeamsDataDelegate : DataReaderDelegate<IReadOnlyList<Team>>
    {
        public GetAllTeamsDataDelegate()
           : base("NBA.GetAllTeams")
        {
            
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<Team> Translate(SqlCommand command, IDataRowReader reader)
        {
            var list = new List<Team>();

            while (reader.Read())
            {
                list.Add(new Team(
                   reader.GetInt32("TeamID"),
                   reader.GetString("Name"),
                   reader.GetString("OwnerName"),
                   reader.GetString("Location"),
                   reader.GetString("StadiumName")));
            }

            return list;
        }
    }
}
