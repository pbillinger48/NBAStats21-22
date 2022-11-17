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

        DataTable homePlayerTable;
        DataTable awayPlayerTable;


        public AddGamePanel()
        {
            InitializeComponent();
        }

        private void uxInsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                var repo = new SqlInsertDataRepository(connectionString);

                var date = new DateTime((int)uxYearBox.Value, (int)uxMonthBox.Value, (int)uxDayBox.Value);

                string homeTeam = (string)uxHomeTeamComboBox.SelectedValue;

                string awayTeam = (string)uxAwayTeamComboBox.SelectedValue;

                if (homeTeam == awayTeam)
                {
                    MessageBox.Show("Home team and Away team cannot be the same team.");
                    return;
                }

                int homePoints = GetHomePoints();

                int awayPoints = GetAwayPoints();

                if (homePoints == awayPoints)
                {
                    MessageBox.Show("Ties are not allowed.");
                    return;
                }

                repo.InsertGameAndTeamGames(date, homeTeam, awayTeam, homePoints, awayPoints);

                foreach (DataRow row in homePlayerTable.Rows)
                {
                    repo.InsertGameStat(date, homeTeam, awayTeam, (string)row["PlayerName"], homeTeam, (int)row["Points"],
                        (int)row["Rebounds"], (int)row["Assists"], (int)row["Blocks"], (int)row["Steals"],
                        (int)row["Turnovers"], (decimal)row["Minutes"]);
                }

                foreach (DataRow row in awayPlayerTable.Rows)
                {
                    repo.InsertGameStat(date, homeTeam, awayTeam, (string)row["PlayerName"], awayTeam, (int)row["Points"],
                        (int)row["Rebounds"], (int)row["Assists"], (int)row["Blocks"], (int)row["Steals"],
                        (int)row["Turnovers"], (decimal)row["Minutes"]);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error Inserting the game stats");
                return;
            }
            MessageBox.Show("Game successfully added!");
            awayPlayerTable.Clear();
            homePlayerTable.Clear();
            uxAwayTeamPlayerGrid.DataSource = null;
            uxAwayTeamPlayerGrid.DataSource = awayPlayerTable;
            uxHomeTeamPlayerGrid.DataSource = null;
            uxHomeTeamPlayerGrid.DataSource = homePlayerTable;
            UpdateScores();
        }

        private void AddGamePanel_Load(object sender, EventArgs e)
        {
            var repo = new SqlTeamRepository(connectionString);
            IReadOnlyList<Team> list = repo.GetAllTeams();
            var teamsList = new List<string>();
            foreach (var item in list)
            {
                teamsList.Add(item.Name);
            }
            uxHomeTeamComboBox.DataSource = null;
            uxHomeTeamComboBox.DataSource = teamsList;

            var teamsList2 = new List<string>(teamsList);

            uxAwayTeamComboBox.DataSource = null;
            uxAwayTeamComboBox.DataSource = teamsList2;

            homePlayerTable = new DataTable();
            homePlayerTable.Columns.Add("PlayerName", typeof(string));
            homePlayerTable.Columns.Add("Points", typeof(int));
            homePlayerTable.Columns.Add("Rebounds", typeof(int));
            homePlayerTable.Columns.Add("Assists", typeof(int));
            homePlayerTable.Columns.Add("Blocks", typeof(int));
            homePlayerTable.Columns.Add("Steals", typeof(int));
            homePlayerTable.Columns.Add("Turnovers", typeof(int));
            homePlayerTable.Columns.Add("Minutes", typeof(decimal));

            uxHomeTeamPlayerGrid.DataSource = null;
            uxHomeTeamPlayerGrid.DataSource = homePlayerTable;

            awayPlayerTable = new DataTable();
            awayPlayerTable.Columns.Add("PlayerName", typeof(string));
            awayPlayerTable.Columns.Add("Points", typeof(int));
            awayPlayerTable.Columns.Add("Rebounds", typeof(int));
            awayPlayerTable.Columns.Add("Assists", typeof(int));
            awayPlayerTable.Columns.Add("Blocks", typeof(int));
            awayPlayerTable.Columns.Add("Steals", typeof(int));
            awayPlayerTable.Columns.Add("Turnovers", typeof(int));
            awayPlayerTable.Columns.Add("Minutes", typeof(decimal));

            uxAwayTeamPlayerGrid.DataSource = null;
            uxAwayTeamPlayerGrid.DataSource = awayPlayerTable;
        }

        private void uxHomeTeamPlayerGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            UpdateScores();
        }

        private void UpdateScores()
        {
            int homeScore = GetHomePoints();
            
            uxHomeScoreBox.Text = null;
            uxHomeScoreBox.Text = homeScore.ToString();

            int awayScore = GetAwayPoints();
            
            uxAwayScoreBox.Text = null;
            uxAwayScoreBox.Text = awayScore.ToString();
        }

        private int GetHomePoints()
        {
            int score = 0;
            foreach (DataRow row in homePlayerTable.Rows)
            {
                score += (int)row["Points"];
            }
            return score;
        }

        private int GetAwayPoints()
        {
            int score = 0;
            foreach (DataRow row in awayPlayerTable.Rows)
            {
                score += (int)row["Points"];
            }
            return score;
        }

        private void uxAwayTeamPlayerGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            UpdateScores();
        }
    }
}
