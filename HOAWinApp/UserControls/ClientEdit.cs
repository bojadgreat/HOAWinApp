using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace HOAWinApp.UserControls
{
    public partial class ClientEdit : UserControl
    {
        private bool formLoaded = false;
        public ClientEdit()
        {
            InitializeComponent();
            blockNumTB.TextChanged += blockNumTB_TextChanged;
            lotNumTB.TextChanged += lotNumTB_TextChanged;
        }

        private void canBut_Click(object sender, EventArgs e)
        {
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }

        private void ClientEdit_Load(object sender, EventArgs e)
        {
            clientLBox.ClearSelected();
            popListBox();
            searchClientTB.Text = "Enter Client Information";
            searchClientTB.ForeColor = Color.Gray;
            formLoaded = true;
        }

        //function to populate listBox
        private void popListBox() 
        { 
            clientLBox.Items.Clear();
            clientLBox.DataSource = createDT("SELECT CONCAT(fName, ' ', lName) AS fullName, blockNum, lotNum FROM garbcoldata;");
            clientLBox.DisplayMember = "fullName";
            clientLBox.ClearSelected();
        }

        //function for data table of list box
        private DataTable createDT(string strQuer)
        {
            DataTable dt = new DataTable();
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

                
                sqlAdapt.Fill(dt);

                dbConn.close_db();

                return dt;
            }
            else
            {
                MessageBox.Show("Database Error");
                return dt;
            }
        }

        private void searchClientTB_Enter(object sender, EventArgs e)
        {
            if (searchClientTB.Text == "Enter Client Information")
            {
                searchClientTB.Text = "";
                searchClientTB.ForeColor = Color.Black;
            }
        }

        private void searchClientTB_Leave(object sender, EventArgs e)
        {
            if (searchClientTB.Text == "")
            {
                searchClientTB.Text = "Enter Client Information";
                searchClientTB.ForeColor = Color.Gray;
            }
        }

        private void searchBut_Click(object sender, EventArgs e)
        {
            string datSearch = searchClientTB.Text;
            clientLBox.DataSource = createDT("SELECT CONCAT(fName, ' ', lName) AS fullName, blockNum, lotNum FROM garbcoldata WHERE fName LIKE '%" + datSearch + "%' or lName LIKE '%" + datSearch + "%';");
            clientLBox.DisplayMember = "fullName";
            clientLBox.ClearSelected();

            searchClientTB.Text = "Enter Client Information";
            searchClientTB.ForeColor = Color.Gray;
        }

        //selectedindextrigger
        private void clientLBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //to prevent triggering during load
            if (!formLoaded)
            {
                return; // Ignore the event if the form hasn't loaded yet
            }
            else
            {
                if (clientLBox.SelectedItem != null)
                {
                    DataRowView selectedRow = clientLBox.SelectedItem as DataRowView;
                    if (selectedRow != null)
                    {
                        string selectedName = selectedRow["fullName"].ToString();
                        string selectedBlock = selectedRow["blockNum"].ToString();
                        string selectedLot = selectedRow["lotNum"].ToString();
                        string[] name = selectedName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


                        fNameTB.Text = name[0];
                        lNameTB.Text = name[1];
                        blockNumTB.Text = selectedBlock;
                        lotNumTB.Text = selectedLot;
                    }
                }
            } 
        }

        private void subBut_Click(object sender, EventArgs e)
        {
            string fName = fNameTB.Text;
            string lName = lNameTB.Text;
            string blockNum = blockNumTB.Text;
            string lotNum = lotNumTB.Text;
            DialogResult result = MessageBox.Show("Do you want to edit this client?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //to get selected name
                DataRowView selectedRow = clientLBox.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    string transType = "Edit Client";
                    DateTime curDateTime = DateTime.Now;
                    string selectedName = selectedRow["fullName"].ToString();
                    string[] name = selectedName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    query("UPDATE garbcoldata SET fName = '" + fName + "', lName = '" + lName + "', blockNum = '" + blockNum + "', lotNum = '" + lotNum + "'  WHERE fName = '" + name[0] + "' AND lName = '" + name[1] + "';");
                    MessageBox.Show("Client successfully edited!", "EDIT CLIENT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    query("INSERT INTO overalltransachist (dateTimeStamp, transType, fullName) VALUES ('" + curDateTime.ToString("yyyy-MM-dd HH:ss") + "', '" + transType + "', '" + name[1] + "," + name[0] + "')");
                }
            }
        }

        //ensure block num accepts numeric value
        private void blockNumTB_TextChanged(object sender, EventArgs e)
        {
            string input = blockNumTB.Text;

            string numericInput = Regex.Replace(input, "[^0-9]", "");

            blockNumTB.Text = numericInput;

            blockNumTB.SelectionStart = blockNumTB.Text.Length;
        }

        //ensure block num accepts numeric value
        private void lotNumTB_TextChanged(object sender, EventArgs e)
        {
            string input = lotNumTB.Text;

            string numericInput = Regex.Replace(input, "[^0-9]", "");

            lotNumTB.Text = numericInput;

            lotNumTB.SelectionStart = lotNumTB.Text.Length;
        }

        //for mysql queries
        private void query(string query)
        {
            var dbConn = new dbConnect();
            if (dbConn.connect_db())
            {
                string sqlQuery = query;
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
    }
}
