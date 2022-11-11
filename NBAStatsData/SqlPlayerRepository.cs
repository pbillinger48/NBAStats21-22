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

        public IReadOnlyList<Player> RetrievePlayers()
        {
            throw new NotImplementedException();

            //return executor.ExecuteReader(new RetrievePlayersDataDelegate());
        }
    }
}
