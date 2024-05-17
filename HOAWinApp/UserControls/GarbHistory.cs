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
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;

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

            // Set the sort mode of the second column to automatic if it's not already set
            dgvGarbHist.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;

            // Sort the second column (index 1) in descending order
            dgvGarbHist.Sort(dgvGarbHist.Columns[1], System.ComponentModel.ListSortDirection.Descending);

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

        private void garbHistExpBut_Click(object sender, EventArgs e)
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
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            DialogResult result = MessageBox.Show("Do you want to export the data to Excel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DateTime dtNow = DateTime.Now;
                string sheetStrFormat = dtNow.ToString("yyyy-MM-dd") + " REPORT";

                try
                {
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        DataTable dt = new DataTable();
                        // Add columns to the DataTable
                        foreach (DataGridViewColumn column in dgvGarbHist.Columns)
                        {
                            dt.Columns.Add(column.HeaderText);
                        }

                        // Filter and add rows to the DataTable
                        foreach (DataGridViewRow row in dgvGarbHist.Rows)
                        {
                            if (row.IsNewRow) continue; // Skip new row placeholder

                            // Assuming the date is in the second column (index 1) and payment amount in the last column
                            if (DateTime.TryParse(row.Cells[1].Value?.ToString(), out DateTime dateValue))
                            {
                                if (dateValue.Year == dtNow.Year && dateValue.Month == dtNow.Month)
                                {
                                    DataRow dr = dt.NewRow();
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        dr[cell.ColumnIndex] = cell.Value;
                                    }
                                    dt.Rows.Add(dr);
                                }
                            }
                        }

                        // Add the DataTable to the workbook
                        var worksheet = workbook.Worksheets.Add(dt, sheetStrFormat);
                        workbook.SaveAs(filePath);
                    }

                    // Re-open the file with EPPlus to add the chart
                    using (var package = new ExcelPackage(new System.IO.FileInfo(filePath)))
                    {
                        var worksheet = package.Workbook.Worksheets.First();

                        // Aggregate data by date to calculate cumulative payments
                        var dateColumnIndex = 5; // assuming date is the second column (index 1 in DataTable, index 2 in Excel)
                        var paymentColumnIndex = 4; // assuming payment amount is the last column

                        var data = worksheet.Cells[2, dateColumnIndex, worksheet.Dimension.End.Row, dateColumnIndex]
                            .Select(cell => new
                            {
                                Date = DateTime.TryParse(cell.GetValue<string>(), out DateTime date) ? date : (DateTime?)null,
                                Payment = decimal.TryParse(worksheet.Cells[cell.Start.Row, paymentColumnIndex].GetValue<string>(), out decimal payment) ? payment : 0
                            })
                            .Where(x => x.Date.HasValue)
                            .OrderBy(x => x.Date)
                            .ToList();

                        var cumulativeData = data
                            .GroupBy(x => x.Date.Value.ToShortDateString())
                            .Select(g => new
                            {
                                Date = g.Key,
                                TotalPayment = g.Sum(x => x.Payment)
                            })
                            .ToList();

                        // Calculate cumulative total
                        decimal cumulativeSum = 0;
                        var cumulativeSumData = cumulativeData
                            .Select(x =>
                            {
                                cumulativeSum += x.TotalPayment;
                                return new { x.Date, CumulativeTotal = cumulativeSum };
                            })
                            .ToList();

                        // Add cumulative data to a new worksheet for chart
                        var chartWorksheet = package.Workbook.Worksheets.Add("ChartData");
                        chartWorksheet.Cells[1, 1].Value = "Date";
                        chartWorksheet.Cells[1, 2].Value = "Cumulative Total";
                        for (int i = 0; i < cumulativeSumData.Count; i++)
                        {
                            chartWorksheet.Cells[i + 2, 1].Value = cumulativeSumData[i].Date;
                            chartWorksheet.Cells[i + 2, 2].Value = cumulativeSumData[i].CumulativeTotal;
                        }

                        // Create the chart
                        var chart = worksheet.Drawings.AddChart("TotalPaymentsChart", eChartType.Line);
                        var series = chart.Series.Add(chartWorksheet.Cells[2, 2, cumulativeSumData.Count + 1, 2], chartWorksheet.Cells[2, 1, cumulativeSumData.Count + 1, 1]);
                        chart.Title.Text = "Cumulative Payments by Date";
                        chart.SetPosition(1, 0, worksheet.Dimension.End.Column + 1, 0);
                        chart.SetSize(600, 300);

                        package.Save();
                    }

                    MessageBox.Show("Data exported successfully to Excel.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting data to Excel: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvGarbHist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
