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
    public partial class QueryStatsForm : Form
    {
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
    }
}
