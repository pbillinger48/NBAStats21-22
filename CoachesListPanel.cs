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
    public partial class CoachesListPanel : UserControl
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=NBAStatsDB;Integrated Security=SSPI;";
        public CoachesListPanel()
        {
            InitializeComponent();
        }

        private void uxGetAllCoaches_Click(object sender, EventArgs e)
        {
            ITeamSeasonSummaryRepository repo;

            repo = new SqlTeamSeasonSummaryRepository(connectionString);
            IReadOnlyList<Coach> list = repo.GetAllCoaches();
            DataTable table = new DataTable();
            table.Columns.Add("Coach Name", typeof(string));
            table.Columns.Add("Team Name", typeof(string));

            foreach (var item in list)
            {
                table.Rows.Add(item.Name, item.TeamName);
            }
            uxDataGrid.DataSource = null;
            uxDataGrid.DataSource = table;
        }

        private void CoachesListPanel_Load(object sender, EventArgs e)
        {
            ITeamSeasonSummaryRepository repo;

            repo = new SqlTeamSeasonSummaryRepository(connectionString);
            IReadOnlyList<Coach> list = repo.GetAllCoaches();
            DataTable table = new DataTable();
            table.Columns.Add("Coach Name", typeof(string));
            table.Columns.Add("Team Name", typeof(string));

            foreach (var item in list)
            {
                table.Rows.Add(item.Name, item.TeamName);
            }
            uxDataGrid.DataSource = null;
            uxDataGrid.DataSource = table;
        }
    }
}
