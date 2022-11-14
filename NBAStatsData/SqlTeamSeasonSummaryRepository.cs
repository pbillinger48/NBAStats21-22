using DataAccess;
using NBAStatsData.DataDelegates;
using NBAStatsData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData
{
    public class SqlTeamSeasonSummaryRepository: ITeamSeasonSummaryRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlTeamSeasonSummaryRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }
        public IReadOnlyList<TeamSeasonSummary> RetrieveTeamSeasonSummaries(string teamName)
        {
            return executor.ExecuteReader(new RetrieveTeamSeasonSummariesDataDelegate(teamName));
        }

        public IReadOnlyList<Team> GetAllTeams()
        {
            return executor.ExecuteReader(new GetAllTeamsDataDelegate());
        }
    }
}
