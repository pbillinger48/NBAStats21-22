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
    public partial class TestHomeForm : Form
    {
        List<Panel> panelList = new List<Panel>();
        public TestHomeForm()
        {
            InitializeComponent();
        }

        private void playerStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxMainPanel.Controls.Clear();
            PlayerPanel panel = new PlayerPanel() { Dock = DockStyle.Fill };
            uxMainPanel.Controls.Add(panel);
            panel.Show();
        }
    }
}
