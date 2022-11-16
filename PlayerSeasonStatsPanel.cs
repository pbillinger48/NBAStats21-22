using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;
using NBAStatsData.Models;
using NBAStatsData;

namespace _21_22NBAStats
{
    public partial class PlayerSeasonStatsPanel : UserControl
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=NBAStatsDB;Integrated Security=SSPI;";
        public PlayerSeasonStatsPanel()
        {
            InitializeComponent();
        }

        private void uxRunPlayerSeasonStats_Click(object sender, EventArgs e)
        {
            IPlayerRepository repo;

            repo = new SqlPlayerRepository(connectionString);

            decimal? PPGMax = 0;
            decimal? PPGMin = 0;
            decimal? RPGMax = 0;
            decimal? RPGMin = 0;
            decimal? APGMax = 0;
            decimal? APGMin = 0;
            decimal? BPGMax = 0;
            decimal? BPGMin = 0;
            decimal? SPGMax = 0;
            decimal? SPGMin = 0;
            decimal? TPGMax = 0;
            decimal? TPGMin = 0;
            decimal? MPGMax = 0;
            decimal? MPGMin = 0;
            string playerName = "";
            string teamName = "";

            if (uxPPGMax.Value >= uxPPGMin.Value)
            {
                PPGMin = uxPPGMin.Value;
                PPGMax = uxPPGMax.Value;
            }
            else
            {
                MessageBox.Show("PointsPG minimum value must be lower than the maximum value");
                return;
            }
            if (uxRPGMax.Value >= uxRPGMin.Value)
            {
                RPGMin = uxRPGMin.Value;
                RPGMax = uxRPGMax.Value;
            }
            else
            {
                MessageBox.Show("ReboundsPG minimum value must be lower than the maximum value");
                return;
            }
            if (uxAPGMax.Value >= uxAPGMin.Value)
            {
                APGMin = uxAPGMin.Value;
                APGMax = uxAPGMax.Value;
            }
            else
            {
                MessageBox.Show("AssistsPG minimum value must be lower than the maximum value");
                return;
            }
            if (uxBPGMax.Value >= uxBPGMin.Value)
            {
                BPGMin = uxBPGMin.Value;
                BPGMax = uxBPGMax.Value;
            }
            else
            {
                MessageBox.Show("BlocksPG minimum value must be lower than the maximum value");
                return;
            }
            if (uxSPGMax.Value >= uxSPGMin.Value)
            {
                SPGMin = uxSPGMin.Value;
                SPGMax = uxSPGMax.Value;
            }
            else
            {
                MessageBox.Show("StealsPG minimum value must be lower than the maximum value");
                return;
            }
            if (uxTPGMax.Value >= uxTPGMin.Value)
            {
                TPGMin = uxTPGMin.Value;
                TPGMax = uxTPGMax.Value;
            }
            else
            {
                MessageBox.Show("TurnoversPG minimum value must be lower than the maximum value");
                return;
            }
            if (uxMPGMax.Value >= uxMPGMin.Value)
            {
                MPGMin = uxMPGMin.Value;
                MPGMax = uxMPGMax.Value;
            }
            else
            {
                MessageBox.Show("MinutesPG minimum value must be lower than the maximum value");
                return;
            }
            if ((string)uxPlayerName.SelectedValue != "")
            {
                playerName = (string)uxPlayerName.SelectedValue;
            }
            if ((string)uxTeamName.SelectedValue != "")
            {
                teamName = (string)uxTeamName.SelectedValue;
            }

            PPGMin = PPGMin == 0 ? null : PPGMin;
            PPGMax = PPGMax == 0 ? null : PPGMax;
            RPGMax = RPGMax == 0 ? null : RPGMax;
            RPGMin = RPGMin == 0 ? null : RPGMin;
            APGMax = APGMax == 0 ? null : APGMax;
            APGMin = APGMin == 0 ? null : APGMin;
            BPGMax = BPGMax == 0 ? null : BPGMax;
            BPGMin = BPGMin == 0 ? null : BPGMin;
            SPGMax = SPGMax == 0 ? null : SPGMax;
            SPGMin = SPGMin == 0 ? null : SPGMin;
            TPGMax = TPGMax == 0 ? null : TPGMax;
            TPGMin = TPGMin == 0 ? null : TPGMin;
            MPGMax = MPGMax == 0 ? null : MPGMax;
            MPGMin = MPGMin == 0 ? null : MPGMin;
            IReadOnlyList<PlayerSeasonStats> list = repo.RetrievePlayers(playerName, teamName, PPGMin,PPGMax,RPGMax,RPGMin,
                APGMax, APGMin, BPGMax,BPGMin, SPGMax, SPGMin, TPGMax, TPGMin, MPGMax, MPGMin);

            DataTable table = new DataTable();
            table.Columns.Add("PlayerName", typeof(string));
            table.Columns.Add("PointsPG", typeof(decimal));
            table.Columns.Add("ReboundsPG", typeof(decimal));
            table.Columns.Add("AssistsPG", typeof(decimal));
            table.Columns.Add("BlocksPG", typeof(decimal));
            table.Columns.Add("StealsPG", typeof(decimal));
            table.Columns.Add("TurnoversPG", typeof(decimal));
            table.Columns.Add("MinutesPG", typeof(decimal));
            table.Columns.Add("TeamName", typeof(string));

            foreach (var item in list)
            {
                table.Rows.Add(item.Name, item.PointsPerGame, item.ReboundsPerGame, item.AssistsPerGame, item.BlocksPerGame,
                    item.StealsPerGame , item.TurnoversPerGame, item.MinutesPerGame, item.CurrentTeamName);
            }
            uxDataGrid.DataSource = null;
            uxDataGrid.DataSource = table;
        }

        private void PlayerSeasonStatsPanel_Load(object sender, EventArgs e)
        {
            var repo1 = new SqlPlayerRepository(connectionString);
            IReadOnlyList<Player> list1 = repo1.GetAllPlayers();
            var playersList = new List<string>();
            playersList.Add("");
            foreach(var item in list1)
            {
                playersList.Add(item.Name);
            }
            uxPlayerName.DataSource = null;
            uxPlayerName.DataSource = playersList;
            
            var repo2 = new SqlTeamRepository(connectionString);
            IReadOnlyList<Team> list2 = repo2.GetAllTeams();
            var teamsList = new List<string>();
            teamsList.Add("");
            foreach (var item in list2)
            {
                teamsList.Add(item.Name);
            }
            uxTeamName.DataSource = null;
            uxTeamName.DataSource = teamsList;

            IReadOnlyList<PlayerSeasonStats> list = repo1.RetrievePlayers("", "", null, null, null, null,
                null, null, null, null, null, null, null, null, null, null);

            DataTable table = new DataTable();
            table.Columns.Add("PlayerName", typeof(string));
            table.Columns.Add("PointsPG", typeof(decimal));
            table.Columns.Add("ReboundsPG", typeof(decimal));
            table.Columns.Add("AssistsPG", typeof(decimal));
            table.Columns.Add("BlocksPG", typeof(decimal));
            table.Columns.Add("StealsPG", typeof(decimal));
            table.Columns.Add("TurnoversPG", typeof(decimal));
            table.Columns.Add("MinutesPG", typeof(decimal));
            table.Columns.Add("TeamName", typeof(string));

            foreach (var item in list)
            {
                table.Rows.Add(item.Name, item.PointsPerGame, item.ReboundsPerGame, item.AssistsPerGame, item.BlocksPerGame,
                    item.StealsPerGame, item.TurnoversPerGame, item.MinutesPerGame, item.CurrentTeamName);
            }
            uxDataGrid.DataSource = null;
            uxDataGrid.DataSource = table;
        }
    }
}
