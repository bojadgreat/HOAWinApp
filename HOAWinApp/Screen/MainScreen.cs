using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HOAWinApp.UserControls;
using HOAWinApp.Winforms;

namespace HOAWinApp.Screen
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            Dashboard dashboard = new Dashboard();
            dashboard.Dock = DockStyle.Fill; // Optional: to fill the panel
            mainPanel.Controls.Add(dashboard);
        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {

        }

    }
}
