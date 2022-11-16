using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NBAStatsData;
using NBAStatsData.Models;

namespace _21_22NBAStats
{
    public partial class AddGamePanel : UserControl
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=NBAStatsDB;Integrated Security=SSPI;";


        public AddGamePanel()
        {
            InitializeComponent();
        }

        private void uxInsertButton_Click(object sender, EventArgs e)
        {
            var repo = new SqlInsertDataRepository(connectionString);

            repo.InsertGameAndTeamGames(new DateTime((int)uxYearBox.Value, (int)uxMonthBox.Value, (int)uxDayBox.Value),
                (string)uxHomeTeamComboBox.SelectedValue, (string)uxAwayTeamComboBox.SelectedValue, 0, 1);
        }

        private void AddGamePanel_Load(object sender, EventArgs e)
        {
            var repo = new SqlTeamSeasonSummaryRepository(connectionString);
            IReadOnlyList<Team> list = repo.GetAllTeams();
            var teamsList = new List<string>();
            teamsList.Add("");
            foreach (var item in list)
            {
                teamsList.Add(item.Name);
            }
            uxHomeTeamComboBox.DataSource = null;
            uxHomeTeamComboBox.DataSource = teamsList;

            var teamsList2 = new List<string>(teamsList);

            uxAwayTeamComboBox.DataSource = null;
            uxAwayTeamComboBox.DataSource = teamsList2;
        }
    }
}
