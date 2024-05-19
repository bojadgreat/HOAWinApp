using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using MySql.Data.MySqlClient;

namespace HOAWinApp.UserControls
{
    public partial class Home : UserControl
    {
        private Timer timer;

        public Home()
        {
            InitializeComponent();
            InitializeTimer();
            timeDateLabel.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        private void InitializeTimer()
        {
            // Create a Timer with interval set to 1 minute (60,000 milliseconds)
            timer = new Timer();
            timer.Interval = 1000; // 1 SEC
            timer.Tick += Timer_Tick;

            // Start the timer
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the label's text with the current time and date
            timeDateLabel.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }


    }
}
