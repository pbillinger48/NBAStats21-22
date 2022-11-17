using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData.DataDelegates
{
    public class InsertCoachDataDelegate : NonQueryDataDelegate<bool>
    {
        public readonly string CoachName;
        public readonly string TeamName;

        public InsertCoachDataDelegate(string coachName, string teamName)
           : base("NBA.InsertCoach")
        {
            this.CoachName = coachName;
            this.TeamName = teamName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("CoachName", CoachName);
            command.Parameters.AddWithValue("TeamName", TeamName);

        }

        public override bool Translate(SqlCommand command)
        {
            return true;
        }
    }
}
