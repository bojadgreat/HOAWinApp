using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOAWinApp.UserControls
{
    //to add history
    public partial class Clients : UserControl
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            loadTable("SELECT blockNum, lotNum, fName, lName, cDue FROM users.garbcoldata;",clientTable);

            dgvSetHeadTextColumn("Block Number", 0, clientTable);
            dgvSetHeadTextColumn("Lot Number", 1, clientTable);
            dgvSetHeadTextColumn("FirstName", 2, clientTable);
            dgvSetHeadTextColumn("Last Name", 3, clientTable);
            dgvSetHeadTextColumn("Current Balance", 4, clientTable);

            dgvSetWidthColumn(200, 0, clientTable);
            dgvSetWidthColumn(200, 1, clientTable);
            dgvSetWidthColumn(250, 2, clientTable);
            dgvSetWidthColumn(250, 3, clientTable);
            dgvSetWidthColumn(250, 4, clientTable);

            clientSearchTB.Text = "Enter Client Information";
            clientSearchTB.ForeColor = Color.Gray;
        }

        private void loadTable(string strQuer, DataGridView dgv)
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
                DataTable dTable = new DataTable();
                sqlAdapt.Fill(dTable);
                BindingSource bds = new BindingSource
                {
                    DataSource = dTable
                };

                dgv.DataSource = bds;

                dbConn.close_db();
            }
            else
            {
                MessageBox.Show("Database Error");
            }
        }
        private void dgvSetHeadTextColumn(string headText, int colInd, DataGridView dgvCol)
        {
            dgvCol.Columns[colInd].HeaderText = headText;
        }

        private void dgvSetWidthColumn(int width, int colInd, DataGridView dgvCol)
        {
            dgvCol.Columns[colInd].Width = width;
        }

        private void clientRelBut_Click(object sender, EventArgs e)
        {
            reloadData();
        }

        private void clientSearchBut_Click(object sender, EventArgs e)
        {
            string datSearch = clientSearchTB.Text;
            loadTable("SELECT blockNum, lotNum, fName, lName, cDue FROM garbcoldata WHERE CONCAT(blockNum, lotNum, fName, lName, cDue) LIKE '%" + datSearch + "%';", clientTable);

            dgvSetHeadTextColumn("Block Number", 0, clientTable);
            dgvSetHeadTextColumn("Lot Number", 1, clientTable);
            dgvSetHeadTextColumn("FirstName", 2, clientTable);
            dgvSetHeadTextColumn("Last Name", 3, clientTable);
            dgvSetHeadTextColumn("Current Balance", 4, clientTable);

            dgvSetWidthColumn(200, 0, clientTable);
            dgvSetWidthColumn(200, 1, clientTable);
            dgvSetWidthColumn(250, 2, clientTable);
            dgvSetWidthColumn(250, 3, clientTable);
            dgvSetWidthColumn(250, 4, clientTable);

            clientSearchTB.Text = "Enter Client Information";
            clientSearchTB.ForeColor = Color.Gray;
        }

        private void clientSearchTB_Enter(object sender, EventArgs e)
        {
            if (clientSearchTB.Text == "Enter Client Information")
            {
                clientSearchTB.Text = "";
                clientSearchTB.ForeColor = Color.Black;
            }
        }

        private void clientSearchTB_Leave(object sender, EventArgs e)
        {
            if (clientSearchTB.Text == "")
            {
                clientSearchTB.Text = "Enter Client Information";
                clientSearchTB.ForeColor = Color.Gray;
            }
        }

        private void addClientBut_Click(object sender, EventArgs e)
        {
            var addClientForm = new Winforms.AddClient();
            addClientForm.Show();
            addClientForm.FormClosed += (s, ev) => reloadData();
        }

        private void reloadData()
        {
            loadTable("SELECT blockNum, lotNum, fName, lName, cDue FROM users.garbcoldata;", clientTable);

            dgvSetHeadTextColumn("Block Number", 0, clientTable);
            dgvSetHeadTextColumn("Lot Number", 1, clientTable);
            dgvSetHeadTextColumn("FirstName", 2, clientTable);
            dgvSetHeadTextColumn("Last Name", 3, clientTable);
            dgvSetHeadTextColumn("Current Balance", 4, clientTable);

            dgvSetWidthColumn(200, 0, clientTable);
            dgvSetWidthColumn(200, 1, clientTable);
            dgvSetWidthColumn(250, 2, clientTable);
            dgvSetWidthColumn(250, 3, clientTable);
            dgvSetWidthColumn(250, 4, clientTable);
        }

        private void editClientBut_Click(object sender, EventArgs e)
        {
            var editClientForm = new Winforms.EditClient();
            editClientForm.Show();
            editClientForm.FormClosed += (s, ev) => reloadData();
        }

        private void deleteClientBut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete the selected client?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                if (clientTable.SelectedCells.Count > 1)
                {
                    // Initialize a string to hold the values of selected cells
                    string selectedCellsValues = "";

                    // Loop through each selected cell
                    foreach (DataGridViewCell cell in clientTable.SelectedCells)
                    {
                        // Append the value of the cell to the string
                        selectedCellsValues += cell.Value.ToString() + ",";
                    }

                    //text to hold each information
                    string[] informations = selectedCellsValues.Split(','); ;
                    DateTime curDateTime = DateTime.Now;
                    string transType = "Delete Client";

                    //to add also for water collection
                    query("DELETE FROM garbcoldata WHERE fName='" + informations[2] + "' and lName='" + informations[3] +"';");
                    query("INSERT INTO overalltransachist (dateTimeStamp, transType, fullName) VALUES ('" + curDateTime.ToString("yyyy-MM-dd HH:ss") + "', '" + transType + "', '" + informations[3] +"," + informations[2] + "')");
                    MessageBox.Show("Client successfully deleted!", "DELETE CLIENT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadData();
                }
                else
                {
                    // If no cell is selected, show a message
                    MessageBox.Show("No row selected. Please Try Again!", "DELETE CLIENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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



        //to add history
    }
}
