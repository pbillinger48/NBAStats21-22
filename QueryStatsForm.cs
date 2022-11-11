using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using NBAStatsData.Models;
using NBAStatsData;

namespace _21_22NBAStats
{
    public partial class QueryStatsForm : Form
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=NBAStatsDB;Integrated Security=SSPI;";

        public QueryStatsForm()
        {
            InitializeComponent();
        }

        private void uxBackHomeButton_Click(object sender, EventArgs e)
        {
            Form form1 = new Form();
            form1.Show();
            this.Hide();
        }

        private void uxStartQueryButton_Click(object sender, EventArgs e)
        {
            IPlayerRepository repo;
            TransactionScope transaction;

            repo = new SqlPlayerRepository(connectionString);

            transaction = new TransactionScope();

            Player p = repo.GetPlayer(uxQueryTextBox.Text);

            uxQueryResultLabel.Text = p.Name + p.PlayerID + p.CurrentTeamID;
        }
    }
}
