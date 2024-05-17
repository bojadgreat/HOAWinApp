using ClosedXML.Excel;
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
    public partial class GarbageCollection : UserControl
    {
        public GarbageCollection()
        {
            InitializeComponent();
        }

        private void GarbageCollection_Load(object sender, EventArgs e)
        {
            loadColData("SELECT * FROM garbcoldata", garbagecoltable);

            //setting header text column to desired
            dgvSetHeadTextColumn("Client Number", 0, garbagecoltable);
            dgvSetHeadTextColumn("Block Number", 1, garbagecoltable);
            dgvSetHeadTextColumn("Lot Number", 2, garbagecoltable);
            dgvSetHeadTextColumn("First Name", 3, garbagecoltable);
            dgvSetHeadTextColumn("Last Name", 4, garbagecoltable);
            dgvSetHeadTextColumn("Previous Balance", 5, garbagecoltable);
            dgvSetHeadTextColumn("Current Balance", 6, garbagecoltable);
            dgvSetHeadTextColumn("Paid Balance", 7, garbagecoltable);
            dgvSetHeadTextColumn("Due Date", 8, garbagecoltable);
            dgvSetHeadTextColumn("Collection Remarks", 9, garbagecoltable);
            dgvSetHeadTextColumn("Payment Remarks", 10, garbagecoltable);
            dgvSetHeadTextColumn("Promissory Remarks", 11, garbagecoltable);

            //setting column width to desired
            dgvSetWidthColumn(50, 0, garbagecoltable);
            dgvSetWidthColumn(50, 1, garbagecoltable);
            dgvSetWidthColumn(50, 2, garbagecoltable);
            dgvSetWidthColumn(90, 3, garbagecoltable);
            dgvSetWidthColumn(90, 4, garbagecoltable);
            dgvSetWidthColumn(60, 5, garbagecoltable);
            dgvSetWidthColumn(60, 6, garbagecoltable);
            dgvSetWidthColumn(60, 7, garbagecoltable);
            dgvSetWidthColumn(100, 8, garbagecoltable);
            dgvSetWidthColumn(70, 9, garbagecoltable);
            dgvSetWidthColumn(70, 10, garbagecoltable);
            dgvSetWidthColumn(70, 11, garbagecoltable);

            garbSearchTB.Text = "Enter Client Information";
            garbSearchTB.ForeColor = Color.Gray;
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
            if (garbSearchTB.Text == "Enter Client Information")
            {
                garbSearchTB.Text = "";
                garbSearchTB.ForeColor = Color.Black;
            }
        }

        private void garbSearchTB_Leave(object sender, EventArgs e)
        {
            if (garbSearchTB.Text == "")
            {
                garbSearchTB.Text = "Enter Client Information";
                garbSearchTB.ForeColor = Color.Gray;
            }
        }


        private void garbSearchBut_Click(object sender, EventArgs e)
        {
            string datSearch = garbSearchTB.Text;
            loadColData("SELECT * FROM garbcoldata WHERE CONCAT(clientID, blockNum, lotNum, fName, lName, pDue, cDue, totPaid, dueDate, colRemarks, payremarks) LIKE '%"+datSearch+"%';", garbagecoltable);

            //setting header text column to desired
            dgvSetHeadTextColumn("Client Number", 0, garbagecoltable);
            dgvSetHeadTextColumn("Block Number", 1, garbagecoltable);
            dgvSetHeadTextColumn("Lot Number", 2, garbagecoltable);
            dgvSetHeadTextColumn("First Name", 3, garbagecoltable);
            dgvSetHeadTextColumn("Last Name", 4, garbagecoltable);
            dgvSetHeadTextColumn("Previous Balance", 5, garbagecoltable);
            dgvSetHeadTextColumn("Current Balance", 6, garbagecoltable);
            dgvSetHeadTextColumn("Paid Balance", 7, garbagecoltable);
            dgvSetHeadTextColumn("Due Date", 8, garbagecoltable);
            dgvSetHeadTextColumn("Collection Remarks", 9, garbagecoltable);
            dgvSetHeadTextColumn("Payment Remarks", 10, garbagecoltable);
            dgvSetHeadTextColumn("Promissory Remarks", 11, garbagecoltable);

            //setting column width to desired
            dgvSetWidthColumn(50, 0, garbagecoltable);
            dgvSetWidthColumn(50, 1, garbagecoltable);
            dgvSetWidthColumn(50, 2, garbagecoltable);
            dgvSetWidthColumn(90, 3, garbagecoltable);
            dgvSetWidthColumn(90, 4, garbagecoltable);
            dgvSetWidthColumn(60, 5, garbagecoltable);
            dgvSetWidthColumn(60, 6, garbagecoltable);
            dgvSetWidthColumn(60, 7, garbagecoltable);
            dgvSetWidthColumn(100, 8, garbagecoltable);
            dgvSetWidthColumn(70, 9, garbagecoltable);
            dgvSetWidthColumn(70, 10, garbagecoltable);
            dgvSetWidthColumn(70, 11, garbagecoltable);
            dgvSetWidthColumn(70, 10, garbagecoltable);

            garbSearchTB.Text = "Enter Client Information";
            garbSearchTB.ForeColor = Color.Gray;
        }

        private void reloadData()
        {
            loadColData("SELECT * FROM garbcoldata", garbagecoltable);

            //setting header text column to desired
            dgvSetHeadTextColumn("Client Number", 0, garbagecoltable);
            dgvSetHeadTextColumn("Block Number", 1, garbagecoltable);
            dgvSetHeadTextColumn("Lot Number", 2, garbagecoltable);
            dgvSetHeadTextColumn("First Name", 3, garbagecoltable);
            dgvSetHeadTextColumn("Last Name", 4, garbagecoltable);
            dgvSetHeadTextColumn("Previous Balance", 5, garbagecoltable);
            dgvSetHeadTextColumn("Current Balance", 6, garbagecoltable);
            dgvSetHeadTextColumn("Paid Balance", 7, garbagecoltable);
            dgvSetHeadTextColumn("Due Date", 8, garbagecoltable);
            dgvSetHeadTextColumn("Collection Remarks", 9, garbagecoltable);
            dgvSetHeadTextColumn("Payment Remarks", 10, garbagecoltable);
            dgvSetHeadTextColumn("Promissory Remarks", 11, garbagecoltable);

            //setting column width to desired
            dgvSetWidthColumn(50, 0, garbagecoltable);
            dgvSetWidthColumn(50, 1, garbagecoltable);
            dgvSetWidthColumn(50, 2, garbagecoltable);
            dgvSetWidthColumn(90, 3, garbagecoltable);
            dgvSetWidthColumn(90, 4, garbagecoltable);
            dgvSetWidthColumn(60, 5, garbagecoltable);
            dgvSetWidthColumn(60, 6, garbagecoltable);
            dgvSetWidthColumn(60, 7, garbagecoltable);
            dgvSetWidthColumn(100, 8, garbagecoltable);
            dgvSetWidthColumn(70, 9, garbagecoltable);
            dgvSetWidthColumn(70, 10, garbagecoltable);
            dgvSetWidthColumn(70, 11, garbagecoltable);

            garbSearchTB.Text = "Enter Client Information";
            garbSearchTB.ForeColor = Color.Gray;
        }

        private void garbRelBut_Click(object sender, EventArgs e)
        {
            reloadData();
        }

        private void generateExGBut_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            saveFileDialog1.Title = "Export to Excel";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                ExportToExcel(saveFileDialog1.FileName);
            }
        }

        private void ExportToExcel(string filePath)
        {
            DialogResult result = MessageBox.Show("Do you want to export the data to excel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) 
            {
                DateTime dtNow = DateTime.Now;
                string sheetStrFormat = dtNow.ToString("yyyy-MM-dd") + " REPORT";
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        using (DataTable dt = new DataTable())
                        {
                            foreach (DataGridViewColumn column in garbagecoltable.Columns)
                            {
                                dt.Columns.Add(column.HeaderText);
                            }

                            foreach (DataGridViewRow row in garbagecoltable.Rows)
                            {
                                DataRow dr = dt.NewRow();
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    dr[cell.ColumnIndex] = cell.Value;
                                }
                                dt.Rows.Add(dr);
                            }

                            workbook.Worksheets.Add(dt, sheetStrFormat);
                            workbook.SaveAs(filePath);
                        }
                    }

                    MessageBox.Show("Data exported successfully to Excel.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting data to Excel: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void garbSearchTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void generateExGBut_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            saveFileDialog1.Title = "Export to Excel";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                ExportToExcel(saveFileDialog1.FileName);
            }
        }

        private void postPaymentGBut_Click(object sender, EventArgs e)
        {
            var postPayForm = new Winforms.AddPayment();
            postPayForm.Show();
            postPayForm.FormClosed += (s, ev) => reloadData();
        }

        private void histGBut_Click_1(object sender, EventArgs e)
        {
            var histForm = new Winforms.History();
            histForm.Show();
        }
    }
}
