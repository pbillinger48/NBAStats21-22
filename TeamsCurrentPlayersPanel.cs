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
    public partial class TeamsCurrentPlayersPanel : UserControl
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=NBAStatsDB;Integrated Security=SSPI;";
        public TeamsCurrentPlayersPanel()
        {
            InitializeComponent();
        }

        private void uxTeamsCurrentPlayers_Click(object sender, EventArgs e)
        {
            ITeamRepository repo;

            repo = new SqlTeamRepository(connectionString);

            string teamName = "";
            if ((string)uxTeamName.SelectedValue != "")
            {
                teamName = (string)uxTeamName.SelectedValue;
            }
            else
            {
                MessageBox.Show("Team Name is required for this query.");
                return;
            }
            IReadOnlyList<TeamsCurrentPlayers> list = repo.RetrieveTeamsCurrentPlayers(teamName);

            DataTable table = new DataTable();
            table.Columns.Add("Player Name", typeof(string));
            table.Columns.Add("Games Played", typeof(int));
            table.Columns.Add("Total Minutes Played", typeof(int));

            foreach (var item in list)
            {
                table.Rows.Add(item.Name, item.GamesPlayed, item.TotalMinutesPlayed);
            }
            uxDataGrid.DataSource = null;
            uxDataGrid.DataSource = table;
        }

        private void TeamsCurrentPlayersPanel_Load(object sender, EventArgs e)
        {
            var repo = new SqlTeamRepository(connectionString);
            IReadOnlyList<Team> list = repo.GetAllTeams();
            var teamsList = new List<string>();
            teamsList.Add("");
            foreach (var item in list)
            {
                teamsList.Add(item.Name);
            }
            uxTeamName.DataSource = null;
            uxTeamName.DataSource = teamsList;
        }
    }
}
