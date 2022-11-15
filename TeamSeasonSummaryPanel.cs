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
    public partial class TeamSeasonSummaryPanel : UserControl
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=NBAStatsDB;Integrated Security=SSPI;";

        public TeamSeasonSummaryPanel()
        {
            InitializeComponent();
        }

        private void TeamPanel_Load(object sender, EventArgs e)
        {
            var repo = new SqlTeamSeasonSummaryRepository(connectionString);

            IReadOnlyList<TeamSeasonSummary> list = repo.RetrieveTeamSeasonSummaries("", null, null, null, null, null, null, null, null, null, null);

            DataTable table = new DataTable();
            table.Columns.Add("TeamName", typeof(string));
            table.Columns.Add("Wins", typeof(int));
            table.Columns.Add("Losses", typeof(int));
            table.Columns.Add("PPGScored", typeof(decimal));
            table.Columns.Add("PPGAgainst", typeof(decimal));
            table.Columns.Add("GamesPlayed", typeof(int));

            foreach (var item in list)
            {
                table.Rows.Add(item.TeamName, item.Wins, item.Losses, item.PPGScored, item.PPGGivenUp, item.GamesPlayed);
            }
            uxDataGrid.DataSource = null;
            uxDataGrid.DataSource = table;


            IReadOnlyList<Team> list2 = repo.GetAllTeams();
            var teamsList = new List<string>();
            teamsList.Add("");
            foreach (var item in list2)
            {
                teamsList.Add(item.Name);
            }
            uxTeamName.DataSource = null;
            uxTeamName.DataSource = teamsList;
        }

        private void uxTeamSeasonStats_Click(object sender, EventArgs e)
        {
            var repo = new SqlTeamSeasonSummaryRepository(connectionString);
            int? WinsMin = 0;
            int? WinsMax = 0;
            int? LossesMin = 0;
            int? LossesMax = 0;
            decimal? PPGScMin = 0;
            decimal? PPGScMax = 0;
            decimal? PPGAgMin = 0;
            decimal? PPGAgMax = 0;
            int? GPMin = 0;
            int? GPMax = 0;
            string teamName = "";
            if (uxWinsMax.Value >= uxWinsMin.Value)
            {
                WinsMin = (int?)uxWinsMin.Value;
                WinsMax = (int?)uxWinsMax.Value;
            }
            else
            {
                MessageBox.Show("Wins minimum value must be lower than the maximum value");
                return;
            }
            if (uxLossesMax.Value >= uxLossesMin.Value)
            {
                LossesMin = (int?)uxLossesMin.Value;
                LossesMax = (int?)uxLossesMax.Value;
            }
            else
            {
                MessageBox.Show("Losses minimum value must be lower than the maximum value");
                return;
            }
            if (uxPPGScoredMax.Value >= uxPPGScoredMin.Value)
            {
                PPGScMin = uxPPGScoredMin.Value;
                PPGScMax = uxPPGScoredMax.Value;
            }
            else
            {
                MessageBox.Show("PPGSc minimum value must be lower than the maximum value");
                return;
            }
            if (uxPPGAgainstMax.Value >= uxPPGAgainstMin.Value)
            {
                PPGAgMin = uxPPGAgainstMin.Value;
                PPGAgMax = uxPPGAgainstMax.Value;
            }
            else
            {
                MessageBox.Show("PPGAgainst minimum value must be lower than the maximum value");
                return;
            }
            if (uxGamesPlayedMax.Value >= uxGamesPlayedMin.Value)
            {
                GPMin = (int?)uxGamesPlayedMin.Value;
                GPMax = (int?)uxGamesPlayedMax.Value;
            }
            else
            {
                MessageBox.Show("GamesPlayed minimum value must be lower than the maximum value");
                return;
            }
            if ((string)uxTeamName.SelectedValue != "")
            {
                teamName = (string)uxTeamName.SelectedValue;
            }
            WinsMin = WinsMin == 0 ? null : WinsMin;
            WinsMax = WinsMax == 0 ? null : WinsMax;
            LossesMin = LossesMin == 0 ? null : LossesMin;
            LossesMax = LossesMax == 0 ? null : LossesMax;
            PPGScMin = PPGScMin == 0 ? null : PPGScMin;
            PPGScMax = PPGScMax == 0 ? null : PPGScMax;
            PPGAgMin = PPGAgMin == 0 ? null : PPGAgMin;
            PPGAgMax = PPGAgMax == 0 ? null : PPGAgMax;
            GPMin = GPMin == 0 ? null : GPMin;
            GPMax = GPMax == 0 ? null : GPMax;

            IReadOnlyList<TeamSeasonSummary> list = repo.RetrieveTeamSeasonSummaries(teamName, WinsMin, WinsMax, LossesMin, LossesMax, PPGScMin, PPGScMax, PPGAgMin, PPGAgMax, GPMin, GPMax);

            DataTable table = new DataTable();
            table.Columns.Add("TeamName", typeof(string));
            table.Columns.Add("Wins", typeof(int));
            table.Columns.Add("Losses", typeof(int));
            table.Columns.Add("PPGScored", typeof(decimal));
            table.Columns.Add("PPGAgainst", typeof(decimal));
            table.Columns.Add("GamesPlayed", typeof(int));

            foreach (var item in list)
            {
                table.Rows.Add(item.TeamName, item.Wins, item.Losses, item.PPGScored, item.PPGGivenUp, item.GamesPlayed);
            }
            uxDataGrid.DataSource = null;
            uxDataGrid.DataSource = table;
        }
    }
}
