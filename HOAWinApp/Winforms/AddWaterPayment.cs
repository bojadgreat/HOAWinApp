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
    public partial class AddWaterPayment : Form
    {
        bool mouseClicked = false;
        public AddWaterPayment()
        {
            InitializeComponent();
            UserControls.WaterAddPayment waterAdd = new UserControls.WaterAddPayment();
            addUserControl(waterAdd);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            addWaterPaymentBotPanel.Controls.Clear();
            addWaterPaymentBotPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void addWaterPaymentTopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
        }

        private void addWaterPaymentTopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                int mousex = MousePosition.X - 150;
                int mousey = MousePosition.Y - 10;
                this.SetDesktopLocation(mousex, mousey);
            }

        }

        private void addWaterPaymentTopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void addWaterPaymentBotPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
