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
    public partial class AddUpdatePlayerPanel : UserControl
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=NBAStatsDB;Integrated Security=SSPI;";
        public AddUpdatePlayerPanel()
        {
            InitializeComponent();
        }

        private void AddPlayerPanel_Load(object sender, EventArgs e)
        {
            ITeamRepository repo;

            repo = new SqlTeamRepository(connectionString);

            IReadOnlyList<Team> list2 = repo.GetAllTeams();
            var teamsList = new List<string>();
            foreach (var item in list2)
            {
                teamsList.Add(item.Name);
            }
            var teamsList2 = new List<string>(teamsList);
            uxTeamName.DataSource = null;
            uxTeamName.DataSource = teamsList;
            uxTeamName2.DataSource = null;
            uxTeamName2.DataSource = teamsList2;

            IPlayerRepository repo2;

            repo2 = new SqlPlayerRepository(connectionString);

            IReadOnlyList<Player> list = repo2.GetAllPlayers();
            var playersList = new List<string>();
            foreach (var item in list)
            {
                playersList.Add(item.Name);
            }
            uxPlayerName2.DataSource = null;
            uxPlayerName2.DataSource = playersList;
        }

        private void uxAddPlayer_Click(object sender, EventArgs e)
        {
            string newPlayerName = "";
            if (uxPlayerName.Text != "")
            {
                newPlayerName = uxPlayerName.Text;
                var repo = new SqlDataModificationRepository(connectionString);
                try
                {
                    repo.InsertPlayer(newPlayerName, (string)uxTeamName.SelectedValue);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error while inserting player");
                    return;
                }
                MessageBox.Show("Player successfully inserted.");
                uxPlayerName.Text = "";
                IPlayerRepository repo2;

                repo2 = new SqlPlayerRepository(connectionString);

                IReadOnlyList<Player> list = repo2.GetAllPlayers();
                var playersList = new List<string>();
                foreach (var item in list)
                {
                    playersList.Add(item.Name);
                }
                uxPlayerName2.DataSource = null;
                uxPlayerName2.DataSource = playersList;
            }
            else
            {
                MessageBox.Show("You must enter a Player Name.");
                return;
            }
        }

        private void uxUpdatePlayer_Click(object sender, EventArgs e)
        {
            string PlayerName = "";
            if ((string)uxPlayerName2.Text != "")
            {
                PlayerName = (string)uxPlayerName2.Text;
                var repo = new SqlDataModificationRepository(connectionString);
                try
                {
                    repo.UpdatePlayer(PlayerName, (string)uxTeamName2.SelectedValue);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error while updating player");
                    return;
                }
                MessageBox.Show("Player's team successfully updated.");
            }
            else
            {
                MessageBox.Show("You must select a Player Name.");
                return;
            }
        }
    }
}
