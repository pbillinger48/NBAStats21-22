using DataAccess;
using NBAStatsData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBAStatsData.DataDelegates;

namespace NBAStatsData
{
    public class SqlPlayerRepository: IPlayerRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlPlayerRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Player CreatePlayer(string firstName, string lastName)
        {
            throw new NotImplementedException();
            //if (string.IsNullOrWhiteSpace(firstName))
            //    throw new ArgumentException("The parameter cannot be null or empty.", nameof(firstName));

            //if (string.IsNullOrWhiteSpace(lastName))
            //    throw new ArgumentException("The parameter cannot be null or empty.", nameof(lastName));

            //if (string.IsNullOrWhiteSpace(email))
            //    throw new ArgumentException("The parameter cannot be null or empty.", nameof(email));

            //var d = new CreatePlayerDataDelegate(firstName, lastName, email);
            //return executor.ExecuteNonQuery(d);
        }

        public Player FetchPlayer(int PlayerId)
        {
            throw new NotImplementedException();

            //var d = new FetchPlayerDataDelegate(PlayerId);
            //return executor.ExecuteReader(d);
        }

        public Player GetPlayer(string name)
        {

            var d = new GetPlayerDataDelegate(name);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<PlayerSeasonStats> RetrievePlayers(string playerName, string teamName,
            decimal? ppgMin, decimal? ppgMax, decimal? RPGMax, decimal? RPGMin,
                decimal? APGMax, decimal? APGMin, decimal? BPGMax, decimal? BPGMin, decimal? SPGMax, decimal? SPGMin,
                decimal? TPGMax, decimal? TPGMin, decimal? MPGMax, decimal? MPGMin)
        {
            return executor.ExecuteReader(new RetrievePlayersSeasonStatsDataDelegate(playerName, teamName, ppgMin,ppgMax, RPGMax, RPGMin,
                APGMax, APGMin, BPGMax, BPGMin, SPGMax, SPGMin, TPGMax, TPGMin, MPGMax, MPGMin));
        }

        public IReadOnlyList<PlayerMonthStats> RetrievePlayersMonthStats(int month, string playerName)
        {
            return executor.ExecuteReader(new RetrievePlayersMonthStatsDataDelegate(month, playerName));
        }

        public IReadOnlyList<Player> GetAllPlayers()
        {
            return executor.ExecuteReader(new GetAllPlayersDataDelegate());
        }

        public PlayerVsOpponentStats RetrievePlayerVsOpponentStats(string playerName, string opponentName)
        {
            return executor.ExecuteReader(new RetrievePlayerVsOpponentStatsDataDelegate(playerName, opponentName));
        }

        public RecordBasedOnMinutes RetrieveRecordBasedOnMinutes(string playerName, decimal minutesThreshold)
        {
            return executor.ExecuteReader(new RetrieveRecordBasedOnMinutesDataDelegate(playerName, minutesThreshold));
        }

        public IReadOnlyList<PlayerGameStats> RetrievePlayersGameStats(string playerName, int? pointsMin, int? pointsMax, int? minutesMin,
            int? minutesMax, string oppName)
        {
            return executor.ExecuteReader(new RetrievePlayersGameStatsDataDelegate(playerName, pointsMin, pointsMax, minutesMin,
                minutesMax, oppName));
        }
    }
}
