using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace HOAWinApp
{
    public partial class Dashboard : UserControl
    {
        bool mouseClicked = false;
        public Dashboard()
        {
            InitializeComponent();
            UserControls.Home homeUC = new UserControls.Home();
            addUserControl(homeUC);
        }



        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainContainer.Controls.Clear();
            mainContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }


        private void clientButt_Click(object sender, EventArgs e)
        {
            UserControls.Clients clientUC = new UserControls.Clients();
            addUserControl(clientUC);
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
        }
        //draggable
        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                int mousex = MousePosition.X - 492;
                int mousey = MousePosition.Y - 35;
            }
        }
        //draggable
        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void updateData(string strQuer)
        {
            var dbConn = new dbConnect();
            if (dbConn.connect_db())
            {
                string sqlQuery = strQuer;
                MySqlCommand mysqlcom = new MySqlCommand(sqlQuery)
                {
                    Connection = dbConn.conn
                };
                MySqlDataAdapter sqlAdapt = new MySqlDataAdapter
                {
                    SelectCommand = mysqlcom
                };

                mysqlcom.ExecuteNonQuery();
                
                dbConn.close_db();
            }
            else
            {
                MessageBox.Show("Database Error");
            }
        }

        //refresh due date every month
        private void newRefreshDueDate() 
        {
            DateTime curDate = DateTime.Now;
            DateTime newCurDate = DateTime.Now.AddMonths(1);
            DateTime newCompDate = new DateTime(curDate.Year, newCurDate.Month, 01);
            updateData("UPDATE garbcoldata SET payRemarks = 'Not Paid', dueDate = '"+ newCompDate.ToString("yyyy-MM-dd") + "', pDue = cDue, cDue = cDue + 400 WHERE MONTH(dueDate) = MONTH(CURRENT_DATE)");
            updateData("UPDATE garbcoldata SET colRemarks = 'Not for collection' WHERE cDue >= 1200;");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            newRefreshDueDate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeButt_Click_Click(object sender, EventArgs e)
        {
            UserControls.Home homeUC = new UserControls.Home();
            addUserControl(homeUC);
        }

        private void gcButt_Click(object sender, EventArgs e)
        {
            UserControls.GarbageCollection gcUC = new UserControls.GarbageCollection();
            addUserControl(gcUC);
        }

        private void wcButt_Click(object sender, EventArgs e)
        {
            UserControls.WaterCollection wcUC = new UserControls.WaterCollection();
            addUserControl(wcUC);
        }

        private void clientButt_Click_1(object sender, EventArgs e)
        {
            UserControls.Clients clientUC = new UserControls.Clients();
            addUserControl(clientUC);
        }


        private void homeButt_Click(object sender, EventArgs e)
        {
            UserControls.Home homeUC = new UserControls.Home();
            addUserControl(homeUC);
        }

        private void topLabel_Click(object sender, EventArgs e)
        {

        }

        private void histPicBoxX1_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }
    }
}
