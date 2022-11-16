using NBAStatsData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData
{
    public interface ITeamSeasonSummaryRepository
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

        /// <summary>
        /// Gets all the games for a specified team
        /// </summary>
        /// <param name="teamName">Name of the team</param>
        /// <param name="opponentName">Name of the opponent</param>
        /// <param name="gameResult">Win or loss result</param>
        /// <param name="pointsMin">Min points scored by the team</param>
        /// <param name="pointsMax">Max points scored by the team</param>
        /// <param name="oppPointsMin">Min points scored by the opponent</param>
        /// <param name="oppPointsMax">Max points scored by the opponent</param>
        /// <returns></returns>
        IReadOnlyList<TeamGameResults> RetrieveTeamGameResults(string teamName, string opponentName, string gameResult,
            int? pointsMin, int? pointsMax, int? oppPointsMin, int? oppPointsMax);

        /// <summary>
        /// Gets all the coaches and their teams
        /// </summary>
        /// <returns>All of the coaches and their teams</returns>
        IReadOnlyList<Coach> GetAllCoaches();
    }
}
