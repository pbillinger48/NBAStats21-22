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
    public partial class PlayerGameStatsPanel : UserControl
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=NBAStatsDB;Integrated Security=SSPI;";
        public PlayerGameStatsPanel()
        {
            InitializeComponent();
        }

        private void PlayerGameStatsPanel_Load(object sender, EventArgs e)
        {
            var repo1 = new SqlPlayerRepository(connectionString);
            IReadOnlyList<Player> list1 = repo1.GetAllPlayers();
            var playersList = new List<string>();
            playersList.Add("");
            foreach (var item in list1)
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
            uxOppName.DataSource = null;
            uxOppName.DataSource = teamsList;
        }

        private void uxRunPlayerGameStats_Click(object sender, EventArgs e)
        {
            IPlayerRepository repo;
            repo = new SqlPlayerRepository(connectionString);
            
            int? PointsMin = 0;
            int? PointsMax = 0;
            int? MinutesMin = 0;
            int? MinutesMax = 0;
            string playerName = "";
            string oppName = "";
            if (uxPointsMax.Value >= uxPointsMin.Value)
            {
                PointsMin = (int?)uxPointsMin.Value;
                PointsMax = (int?)uxPointsMax.Value;
            }
            else
            {
                MessageBox.Show("Points minimum value must be lower than the maximum value");
                return;
            }
            if (uxMinutesMax.Value >= uxMinutesMin.Value)
            {
                MinutesMin = (int?)uxMinutesMin.Value;
                MinutesMax = (int?)uxMinutesMax.Value;
            }
            else
            {
                MessageBox.Show("Minutes minimum value must be lower than the maximum value");
                return;
            }
            if ((string)uxOppName.SelectedValue != "")
            {
                oppName = (string)uxOppName.SelectedValue;
            }
            if ((string)uxPlayerName.SelectedValue != "")
            {
                playerName = (string)uxPlayerName.SelectedValue;
            }
            else
            {
                MessageBox.Show("Player name is required for this query.");
                return;
            }
            PointsMin = PointsMin == 0 ? null : PointsMin;
            PointsMax = PointsMax == 0 ? null : PointsMax;
            MinutesMin = MinutesMin == 0 ? null : MinutesMin;
            MinutesMax = MinutesMax == 0 ? null : MinutesMax;

            IReadOnlyList<PlayerGameStats> list = repo.RetrievePlayersGameStats(playerName, PointsMin, PointsMax, MinutesMin, MinutesMax
                , oppName);

            DataTable table = new DataTable();
            table.Columns.Add("PlayerName", typeof(string));
            table.Columns.Add("TeamName", typeof(string));
            table.Columns.Add("Points", typeof(int));
            table.Columns.Add("Rebounds", typeof(int));
            table.Columns.Add("Assists", typeof(int));
            table.Columns.Add("Blocks", typeof(int));
            table.Columns.Add("Steals", typeof(int));
            table.Columns.Add("Turnovers", typeof(int));
            table.Columns.Add("Minutes", typeof(int));
            table.Columns.Add("OppName", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));

            foreach (var item in list)
            {
                table.Rows.Add(item.PlayerName, item.TeamName, item.Points, item.Rebounds, item.Assists, item.Blocks,
                    item.Steals, item.Turnovers, item.Minutes, item.OppName, item.Date);
            }
            uxDataGrid.DataSource = null;
            uxDataGrid.DataSource = table;

        }
    }
}
