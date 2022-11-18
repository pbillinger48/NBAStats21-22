using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData.DataDelegates
{
    public class InsertPlayerDataDelegate : NonQueryDataDelegate<bool>
    {
        public readonly string PlayerName;
        public readonly string TeamName;

        public InsertPlayerDataDelegate(string playerName, string teamName)
           : base("NBA.InsertPlayer")
        {
            this.PlayerName = playerName;
            this.TeamName = teamName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("PlayerName", PlayerName);
            command.Parameters.AddWithValue("TeamName", TeamName);

        }

        public override bool Translate(SqlCommand command)
        {
            return true;
        }
    }
}
