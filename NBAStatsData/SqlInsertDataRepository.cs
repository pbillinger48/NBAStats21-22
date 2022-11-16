using DataAccess;
using System;
using NBAStatsData.DataDelegates;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData
{
    public class SqlInsertDataRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlInsertDataRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public bool InsertGameAndTeamGames(DateTime date, string homeTeam, string awayTeam, int homeScore, int awayScore)
        {
            return executor.ExecuteNonQuery(new InsertGameAndTeamGamesDataDelegate(date, homeTeam, awayTeam, homeScore, awayScore));
        }
    }
}
