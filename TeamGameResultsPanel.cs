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
    public partial class TeamGameResultsPanel : UserControl
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=NBAStatsDB;Integrated Security=SSPI;";
        public TeamGameResultsPanel()
        {
            InitializeComponent();
        }

        private void uxRunTeamGameResults_Click(object sender, EventArgs e)
        {
            ITeamSeasonSummaryRepository repo;

            repo = new SqlTeamSeasonSummaryRepository(connectionString);

            int? teamMin = 0;
            int? teamMax = 0;
            int? oppMin = 0;
            int? oppMax = 0;
            string teamName = "";
            string opponentName = "";
            string winLoss = "";
            if (uxTeamMax.Value >= uxTeamMin.Value)
            {
                teamMin = (int?)uxTeamMin.Value;
                teamMax = (int?)uxTeamMax.Value;
            }
            else
            {
                MessageBox.Show("TeamScore minimum value must be lower than the maximum value");
                return;
            }
            if (uxOppMax.Value >= uxOppMin.Value)
            {
                oppMin = (int?)uxOppMin.Value;
                oppMax = (int?)uxOppMax.Value;
            }
            else
            {
                MessageBox.Show("OpponentScore minimum value must be lower than the maximum value");
                return;
            }
            if ((string)uxTeamName.SelectedValue != "")
            {
                teamName = (string)uxTeamName.SelectedValue;
            }
            else
            {
                MessageBox.Show("Team Name is required for this query.");
                return;
            }
            if ((string)uxOpponentName.SelectedValue != "")
            {
                opponentName = (string)uxOpponentName.SelectedValue;
            }
            if ((string)uxWinLoss.SelectedValue != "")
            {
                winLoss = (string)uxWinLoss.SelectedValue;
            }
            teamMin = teamMin == 0 ? null : teamMin;
            teamMax = teamMax == 0 ? null : teamMax;
            oppMin = oppMin == 0 ? null : oppMin;
            oppMax = oppMax == 0 ? null : oppMax;

            IReadOnlyList<TeamGameResults> list = repo.RetrieveTeamGameResults(teamName, opponentName, winLoss, 
                teamMin, teamMax, oppMin, oppMax);
            DataTable table = new DataTable();
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("Team", typeof(string));
            table.Columns.Add("TeamScore", typeof(int));
            table.Columns.Add("OpponentScore", typeof(int));
            table.Columns.Add("Opponent", typeof(string));
            table.Columns.Add("Result", typeof(string));
            table.Columns.Add("Location", typeof(string));

            foreach (var item in list)
            {
                table.Rows.Add(item.Date, item.Team, item.TeamScore, item.OpponentScore, item.Opponent, item.RESULT, item.Location);
            }
            uxDataGrid.DataSource = null;
            uxDataGrid.DataSource = table;
        }

        private void TeamGameResultsPanel_Load(object sender, EventArgs e)
        {
            var repo2 = new SqlTeamSeasonSummaryRepository(connectionString);
            IReadOnlyList<Team> list1 = repo2.GetAllTeams();
            IReadOnlyList<Team> list2 = repo2.GetAllTeams();
            var teamsList = new List<string>();
            teamsList.Add("");
            foreach (var item in list1)
            {
                teamsList.Add(item.Name);
            }
            var teamsList2 = new List<string>(teamsList);
            uxTeamName.DataSource = null;
            uxTeamName.DataSource = teamsList;
            uxOpponentName.DataSource = null;
            uxOpponentName.DataSource = teamsList2;
            var winLossList = new List<string>();
            winLossList.Add("");
            winLossList.Add("Win");
            winLossList.Add("Loss");
            uxWinLoss.DataSource = null;
            uxWinLoss.DataSource = winLossList;
        }
    }
}
