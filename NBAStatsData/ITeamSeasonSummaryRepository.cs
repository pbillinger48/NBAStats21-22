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
        IReadOnlyList<TeamSeasonSummary> RetrieveTeamSeasonSummaries();

        /// <summary>
        /// Gets all Teams in the Team table
        /// </summary>
        /// <returns>Gets all teams</returns>
        IReadOnlyList<Team> GetAllTeams();
    }
}
