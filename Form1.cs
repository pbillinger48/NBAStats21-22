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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uxQueryStats_Click(object sender, EventArgs e)
        {
            QueryStatsForm form = new QueryStatsForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
            //QueryStatsForm queryStatsForm = new QueryStatsForm();
            //queryStatsForm.Show();
            //this.Hide();
        }

        private void uxAddGameButton_Click(object sender, EventArgs e)
        {
            TestHomeForm testForm = new TestHomeForm();
            testForm.Show();
            this.Hide();
        }
    }
}
