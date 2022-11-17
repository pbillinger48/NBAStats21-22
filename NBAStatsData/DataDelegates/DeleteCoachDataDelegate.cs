using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData.DataDelegates
{
    public class DeleteCoachDataDelegate : NonQueryDataDelegate<bool>
    {
        public readonly string CoachName;

        public DeleteCoachDataDelegate(string coachName)
           : base("NBA.DeleteCoach")
        {
            this.CoachName = coachName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("CoachName", CoachName);

        }

        public override bool Translate(SqlCommand command)
        {
            return true;
        }
    }
}
