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
    public partial class AddClient : Form
    {
        bool mouseClicked = false;
        public AddClient()
        {
            InitializeComponent();
            UserControls.ClientAdd clAdd = new UserControls.ClientAdd();
            addClientAdd(clAdd);
        }

        private void addClientAdd(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            addClientBotPanel.Controls.Clear();
            addClientBotPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void addClientTopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
        }

        private void addClientTopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                int mousex = MousePosition.X - 150;
                int mousey = MousePosition.Y - 10;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void addClientTopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }
    }
}
