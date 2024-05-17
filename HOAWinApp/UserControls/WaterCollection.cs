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
    public partial class WaterCollection : UserControl
    {
        public WaterCollection()
        {
            InitializeComponent();
        }

        private void postPaymentWBut_Click(object sender, EventArgs e)
        {
            var postPayForm = new Winforms.AddWaterPayment();
            postPayForm.Show();
            postPayForm.FormClosed += (s, ev) => reloadData();
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

        private void WaterCollection_Load(object sender, EventArgs e)
        {
            loadColData("SELECT * FROM watercoldata", watercoltable);

            watSearchTB.Text = "Enter Client Information";
            watSearchTB.ForeColor = Color.Gray;
        }

        private void watSearchTB_Enter(object sender, EventArgs e)
        {
            if (watSearchTB.Text == "Enter Client Information")
            {
                watSearchTB.Text = "";
                watSearchTB.ForeColor = Color.Black;
            }
        }

        private void watSearchTB_Leave(object sender, EventArgs e)
        {
            if (watSearchTB.Text == "Enter Client Information")
            {
                watSearchTB.Text = "";
                watSearchTB.ForeColor = Color.Black;
            }
        }

        private void watRelBut_Click(object sender, EventArgs e)
        {
            reloadData();
        }

        private void watSearchBut_Click(object sender, EventArgs e)
        {
            string datSearch = watSearchTB.Text;
            loadColData("SELECT * FROM watercoldata WHERE CONCAT(BLOCK_LOT, NAME, STATUS, DUE_DATE, BILLING_DATE, FROM, TO, CURRENT, PREVIOUS, READING, AMTDUE) LIKE '%" + datSearch + "%';", watercoltable);
        }

        private void excelWBut_Click(object sender, EventArgs e)
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
                            foreach (DataGridViewColumn column in watercoltable.Columns)
                            {
                                dt.Columns.Add(column.HeaderText);
                            }

                            foreach (DataGridViewRow row in watercoltable.Rows)
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

        private void reloadData()
        {
            loadColData("SELECT * FROM watercoldata", watercoltable);
        }

        private void updateBut_Click(object sender, EventArgs e)
        {
            var updateForm = new Winforms.WaterUpdateForm();
            updateForm.Show();
            updateForm.FormClosed += (s, ev) => reloadData();
        }

        private void histWBut_Click(object sender, EventArgs e)
        {
            var histForm = new Winforms.DisplayWaterHistory();
            histForm.Show();
        }
    }
}
