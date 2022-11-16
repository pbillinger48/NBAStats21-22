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
    class GetAllCoachesDataDelegate : DataReaderDelegate<IReadOnlyList<Coach>>
    {

        public GetAllCoachesDataDelegate()
           : base("NBA.GetAllCoaches")
        {
            
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<Coach> Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            var list = new List<Coach>();

            while (reader.Read())
            {
                list.Add(new Coach(
                   reader.GetString("TeamName"),
                   reader.GetString("CoachName")));
            }

            return list;
        }
    }
}
