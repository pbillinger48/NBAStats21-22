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
    public partial class OtherPlayerQueriesPanel : UserControl
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=NBAStatsDB;Integrated Security=SSPI;";
        public OtherPlayerQueriesPanel()
        {
            InitializeComponent();
        }

        private void OtherPlayerQueriesPanel_Load(object sender, EventArgs e)
        {
            var repo1 = new SqlPlayerSeasonStatsRepository(connectionString);
            IReadOnlyList<Player> list1 = repo1.GetAllPlayers();
            var playersList = new List<string>();
            playersList.Add("");
            foreach (var item in list1)
            {
                playersList.Add(item.Name);
            }
            uxPlayerName1.DataSource = null;
            uxPlayerName1.DataSource = playersList;

            uxPlayerName2.DataSource = null;
            uxPlayerName2.DataSource = playersList;

            var repo2 = new SqlTeamSeasonSummaryRepository(connectionString);
            IReadOnlyList<Team> list2 = repo2.GetAllTeams();
            var teamsList = new List<string>();
            teamsList.Add("");
            foreach (var item in list2)
            {
                teamsList.Add(item.Name);
            }
            uxTeamName.DataSource = null;
            uxTeamName.DataSource = teamsList;
        }

        private void uxRunRecordBasedOnMinutes_Click(object sender, EventArgs e)
        {
            IPlayerSeasonStatsRepository repo;

            repo = new SqlPlayerSeasonStatsRepository(connectionString);

            string playerName = "";
            decimal minutesThreshold = 0;

            if ((string)uxPlayerName1.SelectedValue != "")
            {
                playerName = (string)uxPlayerName1.SelectedValue;
            }
            else
            {
                MessageBox.Show("You must select a player name to run this query.");
                return;
            }
            minutesThreshold = uxMinutesThreshold.Value;
            RecordBasedOnMinutes result = repo.RetrieveRecordBasedOnMinutes(playerName, minutesThreshold);
            if (result != null)
            {
                DataTable table = new DataTable();
                table.Columns.Add("PlayerName", typeof(string));
                table.Columns.Add("TeamName", typeof(string));
                table.Columns.Add("WinsWhenThresholdMet", typeof(int));
                table.Columns.Add("LossesWhenThresholdMet", typeof(int));
                table.Columns.Add("WinsWhenThresholdNotMet", typeof(int));
                table.Columns.Add("LossesWhenThresholdNotMet", typeof(int));

                table.Rows.Add(result.PlayerName, result.TeamName, result.WinsWhenThresholdMet, result.LossesWhenThresholdMet,
                    result.WinsWhenThresholdNotMet, result.LossesWhenThresholdNotMet);
                uxDataGrid1.DataSource = null;
                uxDataGrid1.DataSource = table;
            }
            else
            {
                MessageBox.Show("No results returned.");
                return;
            }
        }

        private void RunPlayerStatsVersus_Click(object sender, EventArgs e)
        {
            IPlayerSeasonStatsRepository repo;

            repo = new SqlPlayerSeasonStatsRepository(connectionString);

            string playerName = "";
            string opponentName = "";

            if((string)uxPlayerName2.SelectedValue != "")
            {
                playerName = (string)uxPlayerName2.SelectedValue;
            }
            else
            {
                MessageBox.Show("You must select a player name to run this query.");
                return;
            }
            if ((string)uxTeamName.SelectedValue != "")
            {
                opponentName = (string)uxTeamName.SelectedValue;
            }
            else
            {
                MessageBox.Show("You must select an opponent name to run this query.");
                return;
            }
            PlayerVsOpponentStats result = repo.RetrievePlayerVsOpponentStats(playerName, opponentName);
            if (result != null)
            {
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
                table.Columns.Add("OpponentName", typeof(string));

                table.Rows.Add(result.PlayerName, result.PointsPG, result.ReboundsPG, result.AssistsPG, result.BlocksPG,
                        result.StealsPG, result.TurnoversPG, result.MinutesPG, result.TeamName, result.OpponentName);
                uxDataGrid2.DataSource = null;
                uxDataGrid2.DataSource = table;
            }
            else
            {
                MessageBox.Show("No results returned.");
                return;
            }
        }
    }
}
