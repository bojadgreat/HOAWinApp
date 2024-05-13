using DocumentFormat.OpenXml.Bibliography;
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
using System.Windows.Forms;

namespace HOAWinApp.UserControls
{
    public partial class ClientAdd : UserControl
    {
        public ClientAdd()
        {
            InitializeComponent();
            blockNumTB.TextChanged += blockNumTB_TextChanged;
            lotNumTB.TextChanged += lotNumTB_TextChanged;
        }

        private void ClientAdd_Load(object sender, EventArgs e)
        {
            fNameTB.Text = "Enter First Name";
            fNameTB.ForeColor = Color.Gray;

            lNameTB.Text = "Enter Last Name";
            lNameTB.ForeColor = Color.Gray;
        }

        private void canBut_Click(object sender, EventArgs e)
        {
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }

        private void insertClient(string strQuer)
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

        private void subBut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to add this client?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                DateTime curDate = DateTime.Now;
                DateTime newCurDate = DateTime.Now.AddMonths(1);
                DateTime newCompDate = new DateTime(curDate.Year, newCurDate.Month, 01);

                if (!string.IsNullOrWhiteSpace(fNameTB.Text) && !string.IsNullOrWhiteSpace(lNameTB.Text) && !string.IsNullOrWhiteSpace(lotNumTB.Text) && !string.IsNullOrWhiteSpace(blockNumTB.Text))
                {
                    //to add also for water collection
                    insertClient("INSERT INTO garbcoldata (blockNum, lotNum, fName, lName, pDue, cDue, totPaid, dueDate, colRemarks, payRemarks, promRemarks) VALUES (" + Convert.ToInt32(blockNumTB.Text) + ", " + Convert.ToInt32(blockNumTB.Text) + ", '" + fNameTB.Text + "', '" + lNameTB.Text + "', 0, 400, 0, '" + newCompDate.ToString("yyyy-MM-dd") + "','NOT FOR COLLECTION', 'NOT PAID', 'NO');");
                    MessageBox.Show("Client successfully added!","ADD CLIENT",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    //error message for first name tb
                    if (string.IsNullOrWhiteSpace(fNameTB.Text) || fNameTB.Text == "Enter First Name")
                    {
                        clientAddErrorProvider.SetError(fNameTB, "This field cannot be empty");
                    }
                    else
                    {
                        clientAddErrorProvider.SetError(fNameTB, "");
                    }

                    //error message for last name tb
                    if (string.IsNullOrWhiteSpace(lNameTB.Text) || lNameTB.Text == "Enter Last Name")
                    {
                        clientAddErrorProvider.SetError(lNameTB, "This field cannot be empty");
                    }
                    else
                    {
                        clientAddErrorProvider.SetError(lNameTB, "");
                    }

                    //error message for block number tb
                    if (string.IsNullOrWhiteSpace(blockNumTB.Text) || blockNumTB.Text == "Enter Block Number")
                    {
                        clientAddErrorProvider.SetError(blockNumTB, "This field cannot be empty");
                    }
                    else
                    {
                        clientAddErrorProvider.SetError(blockNumTB, "");
                    }

                    //error message for lot number tb
                    if (string.IsNullOrWhiteSpace(lotNumTB.Text) || lotNumTB.Text == "Enter Lot Number")
                    {
                        clientAddErrorProvider.SetError(lotNumTB, "This field cannot be empty");
                    }
                    else
                    {
                        clientAddErrorProvider.SetError(lotNumTB, "");
                    }
                }
            }
            
                
        }

        private void fNameTB_Enter(object sender, EventArgs e)
        {
            if (fNameTB.Text == "Enter First Name")
            {
                fNameTB.Text = "";
                fNameTB.ForeColor = Color.Black;
            }
        }

        private void fNameTB_Leave(object sender, EventArgs e)
        {
            if (fNameTB.Text == "")
            {
                fNameTB.Text = "Enter First Name";
                fNameTB.ForeColor = Color.Gray;
            }
        }

        private void lNameTB_Enter(object sender, EventArgs e)
        {
            lotNumTB.TextChanged += lotNumTB_TextChanged;
            if (lNameTB.Text == "Enter Last Name")
            {
                lNameTB.Text = "";
                lNameTB.ForeColor = Color.Black;
            }
        }

        private void lNameTB_Leave(object sender, EventArgs e)
        {
            if (lNameTB.Text == "")
            {
                lNameTB.Text = "Enter Last Name";
                lNameTB.ForeColor = Color.Gray;
            }
        }

        //function to ensure blockNumTB only accepts numeric values
        private void blockNumTB_TextChanged(object sender, EventArgs e)
        {
            string input = blockNumTB.Text;

            string numericInput = Regex.Replace(input, "[^0-9]", "");

            blockNumTB.Text = numericInput;

            blockNumTB.SelectionStart = blockNumTB.Text.Length;
        }

        //function to ensure lotNumTB only accepts numeric values
        private void lotNumTB_TextChanged(object sender, EventArgs e)
        {
            string input = lotNumTB.Text;

            string numericInput = Regex.Replace(input, "[^0-9]", "");

            lotNumTB.Text = numericInput;

            lotNumTB.SelectionStart = lotNumTB.Text.Length;
        }
    }
}
