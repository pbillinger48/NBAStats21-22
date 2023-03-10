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
    public partial class HomeForm : Form
    {
        List<Panel> panelList = new List<Panel>();
        public HomeForm()
        {
            InitializeComponent();
        }

        private void PlayerSeasonStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxMainPanel.Controls.Clear();
            PlayerSeasonStatsPanel panel = new PlayerSeasonStatsPanel() { Dock = DockStyle.Fill };
            uxMainPanel.Controls.Add(panel);
            panel.Show();
            uxPageLabel.Text = "Player Season Stat Averages";
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            uxMainPanel.Controls.Clear();
            HomePanel panel = new HomePanel() { Dock = DockStyle.Fill };
            uxMainPanel.Controls.Add(panel);
            panel.Show();
        }

        private void seasonSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxMainPanel.Controls.Clear();
            TeamSeasonSummaryPanel panel = new TeamSeasonSummaryPanel() { Dock = DockStyle.Fill };
            uxMainPanel.Controls.Add(panel);
            panel.Show();
            uxPageLabel.Text = "Team Season Summary";
        }

        private void testPanelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxMainPanel.Controls.Clear();
            HomePanel panel = new HomePanel() { Dock = DockStyle.Fill };
            uxMainPanel.Controls.Add(panel);
            panel.Show();
            uxPageLabel.Text = "2021-22 NBA Statistics";
        }

        private void monthlyStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxMainPanel.Controls.Clear();
            PlayerMonthlyStatsPanel panel = new PlayerMonthlyStatsPanel() { Dock = DockStyle.Fill };
            uxMainPanel.Controls.Add(panel);
            panel.Show();
            uxPageLabel.Text = "Player Monthly Stat Averages";
        }

        private void otherPlayerQueriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxMainPanel.Controls.Clear();
            OtherPlayerQueriesPanel panel = new OtherPlayerQueriesPanel() { Dock = DockStyle.Fill };
            uxMainPanel.Controls.Add(panel);
            panel.Show();
            uxPageLabel.Text = "Other Player Queries";
        }

        private void gamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxMainPanel.Controls.Clear();
            TeamGameResultsPanel panel = new TeamGameResultsPanel() { Dock = DockStyle.Fill };
            uxMainPanel.Controls.Add(panel);
            panel.Show();
            uxPageLabel.Text = "Team Game Results";
        }

        private void coachesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxMainPanel.Controls.Clear();
            CoachesListPanel panel = new CoachesListPanel() { Dock = DockStyle.Fill };
            uxMainPanel.Controls.Add(panel);
            panel.Show();
            uxPageLabel.Text = "Coaches List";
        }

        private void gameStatLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxMainPanel.Controls.Clear();
            PlayerGameStatsPanel panel = new PlayerGameStatsPanel() { Dock = DockStyle.Fill };
            uxMainPanel.Controls.Add(panel);
            panel.Show();
            uxPageLabel.Text = "Player Game Stat Lines";
        }

        private void addGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxMainPanel.Controls.Clear();
            AddGamePanel panel = new AddGamePanel() { Dock = DockStyle.Fill };
            uxMainPanel.Controls.Add(panel);
            panel.Show();
            uxPageLabel.Text = "Add Game";
        }

        private void currentPlayersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxMainPanel.Controls.Clear();
            TeamsCurrentPlayersPanel panel = new TeamsCurrentPlayersPanel() { Dock = DockStyle.Fill };
            uxMainPanel.Controls.Add(panel);
            panel.Show();
            uxPageLabel.Text = "Team Current Player List";
        }

        private void addDeleteCoachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxMainPanel.Controls.Clear();
            AddDeleteCoachPanel panel = new AddDeleteCoachPanel() { Dock = DockStyle.Fill };
            uxMainPanel.Controls.Add(panel);
            panel.Show();
            uxPageLabel.Text = "Add or Delete Coach";
        }

        private void sourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxMainPanel.Controls.Clear();
            SourcesPanel panel = new SourcesPanel() { Dock = DockStyle.Fill };
            uxMainPanel.Controls.Add(panel);
            panel.Show();
            uxPageLabel.Text = "Project Sources";
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxMainPanel.Controls.Clear();
            AddUpdatePlayerPanel panel = new AddUpdatePlayerPanel() { Dock = DockStyle.Fill };
            uxMainPanel.Controls.Add(panel);
            panel.Show();
            uxPageLabel.Text = "Add or Update Player";
        }
    }
}
