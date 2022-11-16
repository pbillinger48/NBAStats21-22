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
    public class SqlTeamRepository: ITeamRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlTeamRepository(string connectionString)
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

        public IReadOnlyList<TeamGameResults> RetrieveTeamGameResults(string teamName, string opponentName, string gameResult,
            int? pointsMin, int? pointsMax, int? oppPointsMin, int? oppPointsMax)
        {
            return executor.ExecuteReader(new RetrieveTeamGameResultsDataDelegate(teamName, opponentName, gameResult, pointsMin, pointsMax,
                oppPointsMin, oppPointsMax));
        }

        public IReadOnlyList<Coach> GetAllCoaches()
        {
            return executor.ExecuteReader(new GetAllCoachesDataDelegate());
        }

        public IReadOnlyList<TeamsCurrentPlayers> RetrieveTeamsCurrentPlayers(string teamName)
        {
            return executor.ExecuteReader(new RetrieveTeamsCurrentPlayersDataDelegate(teamName));
        }
    }
}
