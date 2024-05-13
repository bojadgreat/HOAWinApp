using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOAWinApp.UserControls
{
    public partial class UpdateWater : UserControl
    {
        public UpdateWater()
        {
            InitializeComponent();
        }

        private void UpdateWater_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection strCol = loadDataAutoComp("SELECT NAME from watercoldata ORDER BY NAME ASC;");

            clientNameTB.AutoCompleteCustomSource = strCol;
            clientNameTB.AutoCompleteSource = AutoCompleteSource.CustomSource;
            clientNameTB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            curReadingTB.Text = "Enter Current Reading";
            curReadingTB.ForeColor = Color.Gray;
            clientNameTB.Text = "Last Name, First Name";
            clientNameTB.ForeColor = Color.Gray;
        }

        //forAutoComplete
        private AutoCompleteStringCollection loadDataAutoComp(string strQuer)
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

                MySqlDataReader rdr = mysqlcom.ExecuteReader();
                AutoCompleteStringCollection strColl = new AutoCompleteStringCollection();

                while (rdr.Read())
                {
                    strColl.Add(rdr.GetString("NAME"));
                }

                dbConn.close_db();

                return (strColl);
            }
            else
            {
                MessageBox.Show("Database Error");
                return (null);
            }
        }

        private void cancelBut_Click(object sender, EventArgs e)
        {
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }

        private void subBut_Click(object sender, EventArgs e)
        {
            
        }

        private void clientNameTB_Enter(object sender, EventArgs e)
        {
            if (clientNameTB.Text == "Last Name, First Name")
            {
                clientNameTB.Text = "";
                clientNameTB.ForeColor = Color.Black;
            }
        }

        private void clientNameTB_Leave(object sender, EventArgs e)
        {
            if (clientNameTB.Text == "")
            {
                clientNameTB.Text = "Last Name, First Name";
                clientNameTB.ForeColor = Color.Gray;
            }
        }

        private void curReadingTB_Enter(object sender, EventArgs e)
        {
            if (curReadingTB.Text == "Enter Current Reading")
            {
                curReadingTB.Text = "";
                curReadingTB.ForeColor = Color.Black;
            }
        }

        private void curReadingTB_Leave(object sender, EventArgs e)
        {
            if (curReadingTB.Text == "")
            {
                curReadingTB.Text = "Enter Current Reading";
                curReadingTB.ForeColor = Color.Black;
            }
        }
    }
}
