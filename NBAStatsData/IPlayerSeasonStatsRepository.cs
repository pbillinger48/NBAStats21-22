using NBAStatsData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData
{
    public interface IPlayerSeasonStatsRepository
    {
        /// <summary>
        /// Retrieves all players in the database.
        /// </summary>
        /// <returns>
        /// <see cref="IReadOnlyList{Player}"/> containing all Players.
        /// </returns>
        IReadOnlyList<PlayerSeasonStats> RetrievePlayers(string playerName, string teamName,
            decimal? ppgMin, decimal? ppgMax, decimal? RPGMax, decimal? RPGMin,
                decimal? APGMax, decimal? APGMin, decimal? BPGMax, decimal? BPGMin, decimal? SPGMax, decimal? SPGMin,
                decimal? TPGMax, decimal? TPGMin, decimal? MPGMax, decimal? MPGMin);

        /// <summary>
        /// Fetches the Player with the given <paramref name="playerId"/> if it exists.
        /// </summary>
        /// <param name="playerId">Identifier of the Player to fetch.</param>
        /// <returns>
        /// An instance of <see cref="Player"/> containing the information of the requested Player.
        /// </returns>
        /// <exception cref="DataAccess.RecordNotFoundException">
        /// Thrown if <paramref name="playerId"/> does not exist.
        /// </exception>
        Player FetchPlayer(int playerId);

        /// <summary>
        /// Gets the Player with the given <paramref name="playerId"/> if it exists.
        /// </summary>
        /// <param name="name">Email of the Player to get.</param>
        /// <returns>
        /// An instance of <see cref="Player"/> containing the information of the requested Player
        /// if one exists with with the provided <paramref name="name"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        Player GetPlayer(string name);

        /// <summary>
        /// Creates a new player in the repository.
        /// </summary>
        /// <param name="firstName">First name of the Player to create.</param>
        /// <param name="lastName">Last name of the Player to create.</param>
        /// <param name="email">Email of the Player to create.</param>
        /// <returns>
        /// The resulting instance of <see cref="Player"/>.
        /// </returns>
        Player CreatePlayer(string firstName, string lastName);

        /// <summary>
        /// Gets all players from the Player table
        /// </summary>
        /// <returns>All players in the database</returns>
        IReadOnlyList<Player> GetAllPlayers();

        /// <summary>
        /// Gets a players stats for a month
        /// </summary>
        /// <returns>PlayerMonthStats object that represents a players stats for a month</returns>
        IReadOnlyList<PlayerMonthStats> RetrievePlayersMonthStats(int month, string playerName);

        /// <summary>
        /// Gets a players statistical averages versus a certain team
        /// </summary>
        /// <param name="playerName">Desired player for the query</param>
        /// <param name="opponentName">Desired opponent for the query</param>
        /// <returns></returns>
        PlayerVsOpponentStats RetrievePlayerVsOpponentStats(string playerName, string opponentName);

        /// <summary>
        /// Gets a teams wins and losses based off a players minutes played
        /// </summary>
        /// <param name="playerName">Desired player for query</param>
        /// <param name="minutesThreshold">Desired minutes of played</param>
        /// <returns></returns>
        RecordBasedOnMinutes RetrieveRecordBasedOnMinutes(string playerName, decimal minutesThreshold);
    }
}
