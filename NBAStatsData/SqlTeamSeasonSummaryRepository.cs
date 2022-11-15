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
        public IReadOnlyList<TeamSeasonSummary> RetrieveTeamSeasonSummaries(string teamName, int? winsMin, int? winsMax, int? lossesMin, int? lossesMax, decimal? ppgScoredMin, decimal? ppgScoredMax,
            decimal? ppgAgainstMin, decimal? ppgAgainstMax, int? gamesPlayedMin, int? gamesPlayedMax)
        {
            return executor.ExecuteReader(new RetrieveTeamSeasonSummariesDataDelegate(teamName, winsMin, winsMax, lossesMin, lossesMax, ppgScoredMin, ppgScoredMax, ppgAgainstMin, ppgAgainstMax,
                gamesPlayedMin, gamesPlayedMax));
        }

        public IReadOnlyList<Team> GetAllTeams()
        {
            return executor.ExecuteReader(new GetAllTeamsDataDelegate());
        }
    }
}
