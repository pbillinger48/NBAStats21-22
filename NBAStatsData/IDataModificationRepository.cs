using NBAStatsData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData
{
    public interface IDataModificationRepository
    {
        /// <summary>
        /// Inserts into Game and TeamGame Tables
        /// </summary>
        /// <param name="date">Game date</param>
        /// <param name="homeTeam">Home team</param>
        /// <param name="awayTeam">Away team</param>
        /// <param name="homeScore">Home Score</param>
        /// <param name="awayScore">Away Score</param>
        /// <returns></returns>
        bool InsertGameAndTeamGames(DateTime date, string homeTeam, string awayTeam, int homeScore, int awayScore);

        /// <summary>
        /// Inserts into the GameStats table
        /// </summary>
        /// <param name="date">Game date</param>
        /// <param name="homeTeam">Home Team</param>
        /// <param name="awayTeam">Away Team</param>
        /// <param name="playerName">Player Name</param>
        /// <param name="playerTeam">Player's Team</param>
        /// <param name="points">Points</param>
        /// <param name="rebounds">Rebounds</param>
        /// <param name="assists">Assists</param>
        /// <param name="blocks">Blocks</param>
        /// <param name="steals">Steals</param>
        /// <param name="turnovers">Turnovers</param>
        /// <param name="minutes">Minutes</param>
        /// <returns></returns>
        bool InsertGameStat(DateTime date, string homeTeam, string awayTeam, string playerName, string playerTeam,
            int points, int rebounds, int assists, int blocks, int steals, int turnovers, decimal minutes);

        /// <summary>
        /// Inserts into the Coach table
        /// </summary>
        /// <param name="coachName">Coach Name</param>
        /// <param name="teamName">Team Name</param>
        /// <returns></returns>
        bool InsertCoach(string coachName, string teamName);

        /// <summary>
        /// Deletes a coach from the Coach table
        /// </summary>
        /// <param name="coachName">Coach name</param>
        /// <returns></returns>
        bool DeleteCoach(string coachName);

        /// <summary>
        /// Inserts into the Player table
        /// </summary>
        /// <param name="playerName">Player name</param>
        /// <param name="teamName">Team name</param>
        /// <returns></returns>
        bool InsertPlayer(string playerName, string teamName);
    }
}
