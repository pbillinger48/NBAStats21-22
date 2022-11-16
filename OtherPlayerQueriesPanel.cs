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

        }

        private void RunPlayerStatsVersus_Click(object sender, EventArgs e)
        {

        }
    }
}
