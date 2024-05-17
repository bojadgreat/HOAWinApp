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
    public partial class WaterHistory : UserControl
    {
        public WaterHistory()
        {
            InitializeComponent();
        }

        private void WaterHistory_Load(object sender, EventArgs e)
        {
            loadColData("SELECT * FROM watercollhist", dgvWaterHist);

            //setting header text column to desired
            dgvSetHeadTextColumn("Transaction Number", 0, dgvWaterHist);
            dgvSetHeadTextColumn("Edit Timestamps", 1, dgvWaterHist);
            dgvSetHeadTextColumn("Full Name", 2, dgvWaterHist);
            dgvSetHeadTextColumn("Amount Paid", 3, dgvWaterHist);
            dgvSetHeadTextColumn("Date of Transaction", 4, dgvWaterHist);



            //setting column width to desired
            dgvSetWidthColumn(80, 0, dgvWaterHist);
            dgvSetWidthColumn(110, 1, dgvWaterHist);
            dgvSetWidthColumn(110, 2, dgvWaterHist);
            dgvSetWidthColumn(100, 3, dgvWaterHist);
            dgvSetWidthColumn(130, 4, dgvWaterHist);

            waterHistTB.Text = "Enter Client Information";
            waterHistTB.ForeColor = Color.Gray;
        }

        private void loadColData(string strQuer, DataGridView dgv)
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

        private void waterSearchTB_Enter(object sender, EventArgs e)
        {
            if (waterHistTB.Text == "Enter Client Information")
            {
                waterHistTB.Text = "";
                waterHistTB.ForeColor = Color.Black;
            }
        }

        private void waterSearchTB_Leave(object sender, EventArgs e)
        {
            if (waterHistTB.Text == "")
            {
                waterHistTB.Text = "Enter Client Information";
                waterHistTB.ForeColor = Color.Gray;
            }
        }

        private void waterHistRelBut_Click(object sender, EventArgs e)
        {
            loadColData("SELECT * FROM watercollhist", dgvWaterHist);

            //setting header text column to desired
            dgvSetHeadTextColumn("Transaction Number", 0, dgvWaterHist);
            dgvSetHeadTextColumn("Edit Timestamps", 1, dgvWaterHist);
            dgvSetHeadTextColumn("Full Name", 2, dgvWaterHist);
            dgvSetHeadTextColumn("Amount Paid", 3, dgvWaterHist);
            dgvSetHeadTextColumn("Date of Transaction", 4, dgvWaterHist);


            //setting column width to desired
            dgvSetWidthColumn(80, 0, dgvWaterHist);
            dgvSetWidthColumn(110, 1, dgvWaterHist);
            dgvSetWidthColumn(110, 2, dgvWaterHist);
            dgvSetWidthColumn(100, 3, dgvWaterHist);
            dgvSetWidthColumn(130, 4, dgvWaterHist);
        }

        private void waterHistSearchBut_Click(object sender, EventArgs e)
        {
            string datSearch = waterHistTB.Text;
            loadColData("SELECT * FROM watercollhist WHERE CONCAT(dateTimeStamp, fName, amPaid, transDate) LIKE '%" + datSearch + "%';", dgvWaterHist);
        }
    }
}
