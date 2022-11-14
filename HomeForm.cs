﻿using System;
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
            TeamPanel panel = new TeamPanel() { Dock = DockStyle.Fill };
            uxMainPanel.Controls.Add(panel);
            panel.Show();
        }

        private void testPanelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxMainPanel.Controls.Clear();
            HomePanel panel = new HomePanel() { Dock = DockStyle.Fill };
            uxMainPanel.Controls.Add(panel);
            panel.Show();
        }
    }
}