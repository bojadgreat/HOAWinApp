using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOAWinApp.Winforms
{
    public partial class WaterUpdateForm : Form
    {
        bool mouseClicked = false;
        public WaterUpdateForm()
        {
            InitializeComponent();
            UserControls.UpdateWater upWater = new UserControls.UpdateWater();
            addUserControl(upWater);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            updateBotPanel.Controls.Clear();
            updateBotPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void updateTopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
        }

        private void updateTopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                int mousex = MousePosition.X - 150;
                int mousey = MousePosition.Y - 10;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void updateTopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }
    }
}
