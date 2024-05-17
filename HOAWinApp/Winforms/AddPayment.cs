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
    public partial class AddPayment : Form
    {
        bool mouseClicked = false;
        public AddPayment()
        {
            InitializeComponent();
            UserControls.GarbAddPayment garbAdd = new UserControls.GarbAddPayment();
            addUserControl(garbAdd);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            addPaymentBotPanel.Controls.Clear();
            addPaymentBotPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void addPaymentTopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
        }

        private void addPaymentTopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked) 
            {
                int mousex = MousePosition.X-150;
                int mousey = MousePosition.Y-10;
                this.SetDesktopLocation(mousex, mousey);
            }
            
        }

        private void addPaymentTopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void addPaymentBotPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
