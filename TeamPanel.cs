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
    public partial class TeamPanel : UserControl
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=NBAStatsDB;Integrated Security=SSPI;";

        public TeamPanel()
        {
            InitializeComponent();
        }

        private void TeamPanel_Load(object sender, EventArgs e)
        {
            var repo = new SqlTeamSeasonSummaryRepository(connectionString);

            IReadOnlyList<TeamSeasonSummary> list = repo.RetrieveTeamSeasonSummaries();

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
            foreach (var col in uxDataGrid.Columns)
            {
                DataGridViewColumn column = (DataGridViewColumn)col;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
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

            IReadOnlyList<TeamSeasonSummary> list = repo.RetrieveTeamSeasonSummaries();

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
