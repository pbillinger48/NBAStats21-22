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

        private void AddDeleteCoachPanel_Load(object sender, EventArgs e)
        {
            ITeamRepository repo;

            repo = new SqlTeamRepository(connectionString);
            IReadOnlyList<Coach> list = repo.GetAllCoaches();
            var nameList = new List<string>();
            foreach(var coach in list)
            {
                nameList.Add(coach.Name);
            }
            uxCoachName.DataSource = null;
            uxCoachName.DataSource = nameList;

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
            }
            else
            {
                MessageBox.Show("You must enter a Coach Name.");
                return;
            }
        }
    }
}
