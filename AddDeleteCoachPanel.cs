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
    public partial class AddDeleteCoachPanel : UserControl
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=NBAStatsDB;Integrated Security=SSPI;";
        public AddDeleteCoachPanel()
        {
            InitializeComponent();
        }

        private void GrabCoachesForBox()
        {
            ITeamRepository repo;

            repo = new SqlTeamRepository(connectionString);
            IReadOnlyList<Coach> list = repo.GetAllCoaches();
            var nameList = new List<string>();
            foreach (var coach in list)
            {
                nameList.Add(coach.Name);
            }
            uxCoachName.DataSource = null;
            uxCoachName.DataSource = nameList;
        }

        private void AddDeleteCoachPanel_Load(object sender, EventArgs e)
        {
            GrabCoachesForBox();

            ITeamRepository repo;

            repo = new SqlTeamRepository(connectionString);

            IReadOnlyList<Team> list2 = repo.GetAllTeams();
            var teamsList = new List<string>();
            foreach (var item in list2)
            {
                teamsList.Add(item.Name);
            }
            uxTeamName.DataSource = null;
            uxTeamName.DataSource = teamsList;
        }

        private void uxAddCoach_Click(object sender, EventArgs e)
        {
            string newCoachName = "";
            if (uxNewCoachName.Text != "")
            {
                newCoachName = uxNewCoachName.Text;
                var repo = new SqlDataModificationRepository(connectionString);
                try
                {
                    repo.InsertCoach(newCoachName, (string)uxTeamName.SelectedValue);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error while inserting coach");
                    return;
                }
                MessageBox.Show("Inserting Coach was successful");
                GrabCoachesForBox();
                uxNewCoachName.Text = "";
            }
            else
            {
                MessageBox.Show("You must enter a Coach Name.");
                return;
            }
        }

        private void uxDeleteCoach_Click(object sender, EventArgs e)
        {
            string deleteCoachName = "";
            if ((string)uxCoachName.SelectedValue != "")
            {
                deleteCoachName = (string)uxCoachName.SelectedValue;
                var repo = new SqlDataModificationRepository(connectionString);
                try
                {
                    repo.DeleteCoach(deleteCoachName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error while deleting coach");
                    return;
                }
                
                MessageBox.Show("Coach was successfully deleted");
                GrabCoachesForBox();
            }
            else
            {
                MessageBox.Show("You must enter a Coach Name.");
                return;
            }
        }
    }
}
