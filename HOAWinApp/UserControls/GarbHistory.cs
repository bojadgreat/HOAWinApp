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
    public partial class GarbHistory : UserControl
    {
        public GarbHistory()
        {
            InitializeComponent();
        }

        private void GarbHistory_Load(object sender, EventArgs e)
        {
            loadColData("SELECT * FROM garbcollhist", dgvGarbHist);

            //setting header text column to desired
            dgvSetHeadTextColumn("Transaction Number", 0, dgvGarbHist);
            dgvSetHeadTextColumn("Edit Timestamps", 1, dgvGarbHist);
            dgvSetHeadTextColumn("Full Name", 2, dgvGarbHist);
            dgvSetHeadTextColumn("Amount Paid", 3, dgvGarbHist);
            dgvSetHeadTextColumn("Date of Transaction", 4, dgvGarbHist);
            dgvSetHeadTextColumn("Payment Remarks", 5, dgvGarbHist);
            dgvSetHeadTextColumn("Collection Remarks", 6, dgvGarbHist);


            //setting column width to desired
            dgvSetWidthColumn(80, 0, dgvGarbHist);
            dgvSetWidthColumn(110, 1, dgvGarbHist);
            dgvSetWidthColumn(110, 2, dgvGarbHist);
            dgvSetWidthColumn(100, 3, dgvGarbHist);
            dgvSetWidthColumn(130, 4, dgvGarbHist);
            dgvSetWidthColumn(130, 5, dgvGarbHist);
            dgvSetWidthColumn(130, 6, dgvGarbHist);

            garbHistTB.Text = "Enter Client Information";
            garbHistTB.ForeColor = Color.Gray;
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

        private void garbSearchTB_Enter(object sender, EventArgs e)
        {
            if (garbHistTB.Text == "Enter Client Information")
            {
                garbHistTB.Text = "";
                garbHistTB.ForeColor = Color.Black;
            }
        }

        private void garbSearchTB_Leave(object sender, EventArgs e)
        {
            if (garbHistTB.Text == "")
            {
                garbHistTB.Text = "Enter Client Information";
                garbHistTB.ForeColor = Color.Gray;
            }
        }

        private void garbHistRelBut_Click(object sender, EventArgs e)
        {
            loadColData("SELECT * FROM garbcollhist", dgvGarbHist);

            //setting header text column to desired
            dgvSetHeadTextColumn("Transaction Number", 0, dgvGarbHist);
            dgvSetHeadTextColumn("Edit Timestamps", 1, dgvGarbHist);
            dgvSetHeadTextColumn("Full Name", 2, dgvGarbHist);
            dgvSetHeadTextColumn("Amount Paid", 3, dgvGarbHist);
            dgvSetHeadTextColumn("Date of Transaction", 4, dgvGarbHist);
            dgvSetHeadTextColumn("Payment Remarks", 5, dgvGarbHist);
            dgvSetHeadTextColumn("Collection Remarks", 6, dgvGarbHist);


            //setting column width to desired
            dgvSetWidthColumn(80, 0, dgvGarbHist);
            dgvSetWidthColumn(110, 1, dgvGarbHist);
            dgvSetWidthColumn(110, 2, dgvGarbHist);
            dgvSetWidthColumn(100, 3, dgvGarbHist);
            dgvSetWidthColumn(130, 4, dgvGarbHist);
            dgvSetWidthColumn(130, 5, dgvGarbHist);
            dgvSetWidthColumn(130, 6, dgvGarbHist);
        }

        private void garbHistSearchBut_Click(object sender, EventArgs e)
        {
            string datSearch = garbHistTB.Text;
            loadColData("SELECT * FROM garbcollhist WHERE CONCAT(transNum, dateTimeStamp, fName, amPaid, transDate, payRem, colRem) LIKE '%" + datSearch + "%';", dgvGarbHist);
        }
    }
}
