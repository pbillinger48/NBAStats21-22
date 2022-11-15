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
    public partial class PlayerMonthlyStatsPanel : UserControl
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=NBAStatsDB;Integrated Security=SSPI;";
        public PlayerMonthlyStatsPanel()
        {
            InitializeComponent();
        }

        private void PlayersMonthStatsPanel_Load(object sender, EventArgs e)
        {
            var monthList = new List<string>();
            monthList.Add("January");
            monthList.Add("February");
            monthList.Add("March");
            monthList.Add("April");
            monthList.Add("May");
            monthList.Add("June");
            monthList.Add("July");
            monthList.Add("August");
            monthList.Add("September");
            monthList.Add("October");
            monthList.Add("November");
            monthList.Add("December");

            uxMonth.DataSource = null;
            uxMonth.DataSource = monthList;

            var repo1 = new SqlPlayerSeasonStatsRepository(connectionString);
            IReadOnlyList<Player> list1 = repo1.GetAllPlayers();
            var playersList = new List<string>();
            playersList.Add("");
            foreach (var item in list1)
            {
                playersList.Add(item.Name);
            }
            uxPlayerName.DataSource = null;
            uxPlayerName.DataSource = playersList;
        }

        private void uxPlayerMonthStats_Click(object sender, EventArgs e)
        {

        }
    }
}
