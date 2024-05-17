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
            AutoCompleteStringCollection strCol = loadDataAutoComp("SELECT NAME as 'wName' from watercoldata ORDER BY wName ASC;");

            clientNameTB.AutoCompleteCustomSource = strCol;
            clientNameTB.AutoCompleteSource = AutoCompleteSource.CustomSource;
            clientNameTB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            curReadingTB.Text = "Enter Current Reading";
            curReadingTB.ForeColor = Color.Gray;
            clientNameTB.Text = "Last Name, First Name";
            clientNameTB.ForeColor = Color.Gray;
        }

                private void UpData(string strQuer)
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
                    strColl.Add(rdr.GetString("wName"));
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

        private double getDoubData(string strQuer)
        {
            double doubData = 0;
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

                object result = mysqlcom.ExecuteScalar();

                if (result != null)
                {
                    doubData = Convert.ToDouble(result);
                }

                dbConn.close_db();

                return doubData;
            }
            else
            {
                MessageBox.Show("Database Error");

                return doubData;
            }
        }

        private void subBut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                AutoCompleteStringCollection strCol = loadDataAutoComp("SELECT NAME as 'wName' from watercoldata ORDER BY wName ASC;");

                string divName = clientNameTB.Text; 
                if (clientNameTB.Text != "")
                {
                    if (strCol.Contains(clientNameTB.Text))
                    {
                        double currentTotalReading = getDoubData("SELECT CURRENT FROM watercoldata WHERE NAME = '" + divName + "';");
                        double updateReading = Convert.ToDouble(curReadingTB.Text);

                        //0-10 current due = 350 amount due
                        //10.1-20 current due = 350 + 40 amount due
                        //20.1-30 current due = 350 + 45 amount due
                        //30.1-40 current due = 350 + 70 amount due
                        //40.1< current due = 350 + 80 amount due
                        double reading = Math.Round(updateReading - currentTotalReading, 2);
                        UpData("UPDATE watercoldata SET PREVIOUS = '" + currentTotalReading + "' WHERE NAME = '" + divName + "';");
                        UpData("UPDATE watercoldata SET CURRENT = '" + updateReading + "' WHERE NAME = '" + divName + "';");
                        UpData("UPDATE watercoldata SET READING = '" + reading + "' WHERE NAME = '" + divName + "';");
                        if (reading >= 0 && reading <= 10)
                        {
                            UpData("UPDATE watercoldata SET AMTDUE = '" + 350 + "' WHERE NAME = '" + divName + "';");
                        }
                        else if (reading >= 10.1 && reading <= 20)
                        {
                            UpData("UPDATE watercoldata SET AMTDUE = '" + 390 + "' WHERE NAME = '" + divName + "';");
                        }
                        else if(reading >= 20.1 && reading <= 30)
                        {
                            UpData("UPDATE watercoldata SET AMTDUE = '" + 395 + "' WHERE NAME = '" + divName + "';");
                        }
                        else if(reading >= 30.1 && reading <= 40)
                        {
                            UpData("UPDATE watercoldata SET AMTDUE = '" + 420 + "' WHERE NAME = '" + divName + "';");
                        }
                        else if(reading >= 40.1)
                        {
                            UpData("UPDATE watercoldata SET AMTDUE = '" + 430 + "' WHERE NAME = '" + divName + "';");
                        }

                    }
                    else
                    {
                        MessageBox.Show("INVALID CLIENT!", "CLIENT NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
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

        private void curReadingTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
