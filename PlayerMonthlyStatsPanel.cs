using NBAStatsData;
using NBAStatsData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_22NBAStats
{
    public partial class PlayerMonthlyStatsPanel : UserControl
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=NBAStatsDB;Integrated Security=SSPI;";
        public PlayerMonthlyStatsPanel()
        {
            InitializeComponent();
        }

        private void PlayersMonthStatsPanel_Load(object sender, EventArgs e)
        {
            var monthList = new List<string>();
            monthList.Add("January");
            monthList.Add("February");
            monthList.Add("March");
            monthList.Add("April");
            monthList.Add("May");
            monthList.Add("June");
            monthList.Add("July");
            monthList.Add("August");
            monthList.Add("September");
            monthList.Add("October");
            monthList.Add("November");
            monthList.Add("December");

            uxMonth.DataSource = null;
            uxMonth.DataSource = monthList;

            var repo1 = new SqlPlayerSeasonStatsRepository(connectionString);
            IReadOnlyList<Player> list1 = repo1.GetAllPlayers();
            var playersList = new List<string>();
            playersList.Add("");
            foreach (var item in list1)
            {
                playersList.Add(item.Name);
            }
            uxPlayerName.DataSource = null;
            uxPlayerName.DataSource = playersList;
        }

        private void uxPlayerMonthStats_Click(object sender, EventArgs e)
        {
            IPlayerSeasonStatsRepository repo;

            repo = new SqlPlayerSeasonStatsRepository(connectionString);

            int month = 0;
            if ((string)uxMonth.SelectedValue == "January") month = 1;
            if ((string)uxMonth.SelectedValue == "February") month = 2;
            if ((string)uxMonth.SelectedValue == "March") month = 3;
            if ((string)uxMonth.SelectedValue == "April") month = 4;
            if ((string)uxMonth.SelectedValue == "May") month = 5;
            if ((string)uxMonth.SelectedValue == "June") month = 6;
            if ((string)uxMonth.SelectedValue == "July") month = 7;
            if ((string)uxMonth.SelectedValue == "August") month = 8;
            if ((string)uxMonth.SelectedValue == "September") month = 9;
            if ((string)uxMonth.SelectedValue == "October") month = 10;
            if ((string)uxMonth.SelectedValue == "November") month = 11;
            if ((string)uxMonth.SelectedValue == "December") month = 12;

            string name = (string)uxPlayerName.SelectedValue;

            IReadOnlyList<PlayerMonthStats> list = repo.RetrievePlayersMonthStats(month, name);

            DataTable table = new DataTable();
            table.Columns.Add("PPGRank", typeof(int));
            table.Columns.Add("PlayerName", typeof(string));
            table.Columns.Add("PointsPG", typeof(decimal));
            table.Columns.Add("ReboundsPG", typeof(decimal));
            table.Columns.Add("AssistsPG", typeof(decimal));
            table.Columns.Add("BlocksPG", typeof(decimal));
            table.Columns.Add("StealsPG", typeof(decimal));
            table.Columns.Add("TurnoversPG", typeof(decimal));
            table.Columns.Add("MinutesPG", typeof(decimal));
            table.Columns.Add("GamesPlayed", typeof(int));

            foreach (var item in list)
            {
                table.Rows.Add(item.Rank, item.Name,item.PointsPerGame, item.ReboundsPerGame, item.AssistsPerGame, item.BlocksPerGame,
                    item.StealsPerGame, item.TurnoversPerGame, item.MinutesPerGame, item.GamesPlayed);
            }
            uxDataGrid.DataSource = null;
            uxDataGrid.DataSource = table;
        }
    }
}
