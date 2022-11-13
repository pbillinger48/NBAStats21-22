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
            IPlayerSeasonStatsRepository repo;
            TransactionScope transaction;

            repo = new SqlPlayerSeasonStatsRepository(connectionString);

            transaction = new TransactionScope();
            decimal PPGMax = 0;
            decimal PPGMin = 0;
            decimal RPGMax = 0;
            decimal RPGMin = 0;
            decimal APGMax = 0;
            decimal APGMin = 0;
            decimal BPGMax = 0;
            decimal BPGMin = 0;
            decimal SPGMax = 0;
            decimal SPGMin = 0;
            decimal TPGMax = 0;
            decimal TPGMin = 0;
            decimal MPGMax = 0;
            decimal MPGMin = 0;
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
            }
            if (uxRPGMax.Value >= uxRPGMin.Value)
            {
                RPGMin = uxRPGMin.Value;
                RPGMax = uxRPGMax.Value;
            }
            else
            {
                MessageBox.Show("ReboundsPG minimum value must be lower than the maximum value");
            }
            if (uxAPGMax.Value >= uxAPGMin.Value)
            {
                APGMin = uxAPGMin.Value;
                APGMax = uxAPGMax.Value;
            }
            else
            {
                MessageBox.Show("AssistsPG minimum value must be lower than the maximum value");
            }
            if (uxBPGMax.Value >= uxBPGMin.Value)
            {
                BPGMin = uxBPGMin.Value;
                BPGMax = uxBPGMax.Value;
            }
            else
            {
                MessageBox.Show("BlocksPG minimum value must be lower than the maximum value");
            }
            if (uxSPGMax.Value >= uxSPGMin.Value)
            {
                SPGMin = uxSPGMin.Value;
                SPGMax = uxSPGMax.Value;
            }
            else
            {
                MessageBox.Show("StealsPG minimum value must be lower than the maximum value");
            }
            if (uxTPGMax.Value >= uxTPGMin.Value)
            {
                TPGMin = uxTPGMin.Value;
                TPGMax = uxTPGMax.Value;
            }
            else
            {
                MessageBox.Show("TurnoversPG minimum value must be lower than the maximum value");
            }
            if (uxMPGMax.Value >= uxMPGMin.Value)
            {
                MPGMin = uxMPGMin.Value;
                MPGMax = uxMPGMax.Value;
            }
            else
            {
                MessageBox.Show("MinutesPG minimum value must be lower than the maximum value");
            }

            IReadOnlyList<PlayerSeasonStats> list = repo.RetrievePlayers();

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
            foreach (var col in uxDataGrid.Columns)
            {
                DataGridViewColumn column = (DataGridViewColumn)col;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            }
            uxDataGrid.DataSource = null;
            uxDataGrid.DataSource = table;
        }
    }
}
