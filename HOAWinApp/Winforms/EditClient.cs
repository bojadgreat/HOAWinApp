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
    public partial class EditClient : Form
    {
        bool mouseClicked = false;
        public EditClient()
        {
            InitializeComponent();
            UserControls.ClientEdit clEdit = new UserControls.ClientEdit();
            addEditAdd(clEdit);
        }

        private void editClientTopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                int mousex = MousePosition.X - 150;
                int mousey = MousePosition.Y - 10;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void addEditAdd(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            editClientBotPanel.Controls.Clear();
            editClientBotPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void editClientTopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void editClientTopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
        }
    }
}
