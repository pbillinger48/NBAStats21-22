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
    public partial class HomePanel : UserControl
    {
        public HomePanel()
        {
            InitializeComponent();
        }

        private void HomePanel_Load(object sender, EventArgs e)
        {
            uxPictureBox.Left = (this.ClientSize.Width - uxPictureBox.Width) / 2;
            uxPictureBox.Top = (this.ClientSize.Height - uxPictureBox.Height) / 2;
        }
    }
}
