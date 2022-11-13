using DataAccess;
using NBAStatsData.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData.DataDelegates
{
    public class RetrievePlayersSeasonStatsDataDelegate : DataReaderDelegate<IReadOnlyList<PlayerSeasonStats>>
    {
        private readonly decimal? PPGMin;

        private readonly decimal? PPGMax;

        private readonly decimal? RPGMax;
        private readonly decimal? RPGMin;
        private readonly decimal? APGMax;
        private readonly decimal? APGMin;
        private readonly decimal? BPGMax;
        private readonly decimal? BPGMin;
        private readonly decimal? SPGMax;
        private readonly decimal? SPGMin;
        private readonly decimal? TPGMax;
        private readonly decimal? TPGMin;
        private readonly decimal? MPGMax;
        private readonly decimal? MPGMin;
        public RetrievePlayersSeasonStatsDataDelegate(decimal? ppgMin, decimal? ppgMax, decimal? rpgMax, decimal? rpgMin,
                decimal? apgMax, decimal? apgMin, decimal? bpgMax, decimal? bpgMin, decimal? spgMax, decimal? spgMin,
                decimal? tpgMax, decimal? tpgMin, decimal? mpgMax, decimal? mpgMin)
         : base("NBA.RetrievePlayersSeasonStats")
        {
            PPGMin = ppgMin;
            PPGMax = ppgMax;
            RPGMin = rpgMin;
            RPGMax = rpgMax;
            APGMin = apgMin;
            APGMax = apgMax;
            BPGMin = bpgMin;
            BPGMax = bpgMax;
            SPGMin = spgMin;
            SPGMax = spgMax;
            TPGMin = tpgMin;
            TPGMax = tpgMax;
            MPGMin = mpgMin;
            MPGMax = mpgMax;


        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            if(PPGMin != null)command.Parameters.AddWithValue("PPGMin", PPGMin);
            if(PPGMax != null) command.Parameters.AddWithValue("PPGMax", PPGMax);
            if (RPGMin != null) command.Parameters.AddWithValue("RPGMin", RPGMin);
            if (RPGMax != null) command.Parameters.AddWithValue("RPGMax", RPGMax);
            if (APGMin != null) command.Parameters.AddWithValue("APGMin", APGMin);
            if (APGMax != null) command.Parameters.AddWithValue("APGMax", APGMax);
            if (SPGMin != null) command.Parameters.AddWithValue("SPGMin", SPGMin);
            if (SPGMax != null) command.Parameters.AddWithValue("SPGMax", SPGMax);
            if (BPGMin != null) command.Parameters.AddWithValue("BPGMin", BPGMin);
            if (BPGMax != null) command.Parameters.AddWithValue("BPGMax", BPGMax);
            if (TPGMin != null) command.Parameters.AddWithValue("TPGMin", TPGMin);
            if (TPGMax != null) command.Parameters.AddWithValue("TPGMax", TPGMax);
            if (MPGMin != null) command.Parameters.AddWithValue("MPGMin", MPGMin);
            if (MPGMax != null) command.Parameters.AddWithValue("MPGMax", MPGMax);
        }

        public override IReadOnlyList<PlayerSeasonStats> Translate(SqlCommand command, IDataRowReader reader)
        {
            var PlayersSeasonStatsList = new List<PlayerSeasonStats>();

            while (reader.Read())
            {
                PlayersSeasonStatsList.Add(new PlayerSeasonStats(
                   reader.GetString("PlayerName"),
                   reader.GetString("TeamName"),
                   reader.GetValue<Decimal>("PointsPG"),
                   reader.GetValue<Decimal>("ReboundsPG"),
                   reader.GetValue<Decimal>("AssistsPG"),
                   reader.GetValue<Decimal>("BlocksPG"),
                   reader.GetValue<Decimal>("StealsPG"),
                   reader.GetValue<Decimal>("TurnoversPG"),
                   reader.GetValue<Decimal>("MinutesPG")));
            }

            return PlayersSeasonStatsList;
        }
    }
}
