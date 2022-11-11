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
    public partial class PlayerPanel : UserControl
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=NBAStatsDB;Integrated Security=SSPI;";
        public PlayerPanel()
        {
            InitializeComponent();
        }

        private void uxButton1_Click(object sender, EventArgs e)
        {
            IPlayerSeasonStatsRepository repo;
            TransactionScope transaction;

            repo = new SqlPlayerSeasonStatsRepository(connectionString);

            transaction = new TransactionScope();

            IReadOnlyList<PlayerSeasonStats> list = repo.RetrievePlayers();

            DataTable table = new DataTable();
            table.Columns.Add("PlayerName", typeof(string));
            table.Columns.Add("PointsPG", typeof(decimal));
            table.Columns.Add("ReboundsPG", typeof(decimal));
            table.Columns.Add("AssistsPG", typeof(decimal));
            //table.Columns.Add("BlocksPG", typeof(decimal));
            table.Columns.Add("StealsPG", typeof(decimal));
            table.Columns.Add("TurnoversPG", typeof(decimal));
            table.Columns.Add("MinutesPG", typeof(decimal));
            table.Columns.Add("TeamName", typeof(string));

            foreach (var item in list)
            {
                table.Rows.Add(item.Name, item.PointsPerGame, item.ReboundsPerGame, item.AssistsPerGame, item.StealsPerGame
                    , item.TurnoversPerGame, item.MinutesPerGame, item.CurrentTeamName);
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
