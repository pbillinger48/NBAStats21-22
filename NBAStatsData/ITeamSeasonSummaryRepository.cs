using NBAStatsData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData
{
    interface ITeamSeasonSummaryRepository
    {
        /// <summary>
        /// Retrieves all teams in the database.
        /// </summary>
        /// <returns>
        /// <see cref="IReadOnlyList{TeamSeasonSummary}"/> containing all Teams.
        /// </returns>
        IReadOnlyList<TeamSeasonSummary> RetrieveTeamSeasonSummaries(string teamName, int? winsMin, int? winsMax, int? lossesMin, int? lossesMax, decimal? ppgScoredMin, decimal? ppgScoredMax,
            decimal? ppgAgainstMin, decimal? ppgAgainstMax, int? gamesPlayedMin, int? gamesPlayedMax);

        /// <summary>
        /// Gets all Teams in the Team table
        /// </summary>
        /// <returns>Gets all teams</returns>
        IReadOnlyList<Team> GetAllTeams();
    }
}
