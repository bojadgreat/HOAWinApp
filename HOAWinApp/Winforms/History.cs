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
    public partial class History : Form
    {
        bool mouseClicked = false;
        public History()
        {
            InitializeComponent();
            UserControls.GarbHistory garbHist = new UserControls.GarbHistory();
            addUserControl(garbHist);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            histBotPanel.Controls.Clear();
            histBotPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void garbHistTopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
        }

        private void garbHistTopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                int mousex = MousePosition.X - 250;
                int mousey = MousePosition.Y - 17;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void garbHistTopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void histPicBoxX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
