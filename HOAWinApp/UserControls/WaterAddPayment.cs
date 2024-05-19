using HOAWinApp.Winforms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;
using System.IO;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Text.RegularExpressions;


namespace HOAWinApp.UserControls
{
    public partial class WaterAddPayment : UserControl
    {

        string transType = "";
        public WaterAddPayment()
        {
            InitializeComponent();
            payAmTB.TextChanged += payAmTB_TextChanged;
        }

        private void canBut_Click(object sender, EventArgs e)
        {
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }

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

        /*private string getPromRem(string strQuer)
        {
            string promRem = "";
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
                    promRem = Convert.ToString(result);
                }

                dbConn.close_db();

                return promRem;
            }
            else
            {
                MessageBox.Show("Database Error");

                return promRem;
            }
        }*/

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

        private void garbAddPayment_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection strCol = loadDataAutoComp("SELECT NAME as 'wName' from watercoldata ORDER BY wName ASC;");

            clientNameTB.AutoCompleteCustomSource = strCol;
            clientNameTB.AutoCompleteSource = AutoCompleteSource.CustomSource;
            clientNameTB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            clientNameTB.Text = "";
            clientNameTB.ForeColor = Color.Gray;
            dtpGarbHist.Text = DateTime.Now.ToShortDateString();
        }

        private void garbAddPTB_Enter(object sender, EventArgs e)
        {
            if (clientNameTB.Text == "Last Name, First Name")
            {
                clientNameTB.Text = "";
                clientNameTB.ForeColor = Color.Black;
            }
        }

        private void garbAddPTB_Leave(object sender, EventArgs e)
        {
            if (clientNameTB.Text == "")
            {
                clientNameTB.Text = "Last Name, First Name";
                clientNameTB.ForeColor = Color.Gray;
            }
        }

        private void insertHistData(string strQuer)
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

            DialogResult result = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                transType = "Add Payment for Water Collection";
                DateTime currentDate = DateTime.Now;
                AutoCompleteStringCollection strCol = loadDataAutoComp("SELECT NAME as 'wName' from watercoldata ORDER BY wName ASC;");

                string divName = clientNameTB.Text;
                if (clientNameTB.Text != "")
                {
                    if (strCol.Contains(clientNameTB.Text))
                    {
                        try
                        {
                            double payAmount = Convert.ToDouble(payAmTB.Text);

                            //collect previous reading
                            //collect current reading
                            //water payment details
                            //0-10 current due = 350 amount due
                            //10.1-20 current due = 350 + 40 amount due
                            //20.1-30 current due = 350 + 45 amount due
                            //30.1-40 current due = 350 + 70 amount due
                            //40.1< current due = 350 + 80 amount due

                            if(payAmount > 0)
                            {

                                //get divName current total reading
                                double currentTotalReading = getDoubData("SELECT CURRENT FROM watercoldata WHERE NAME = '" + divName + "';");
                                //get divName amount due
                                double AmountDue = getDoubData("SELECT AMTDUE FROM watercoldata WHERE NAME = '" + divName + "';");
                                //get divName Reading
                                double reading = getDoubData("SELECT READING FROM watercoldata WHERE NAME = '" + divName + "';");


                                if (AmountDue >= 0)
                                {
                                    double newAmountDue = AmountDue - payAmount;
                                    //update amount due
                                    UpData("UPDATE watercoldata SET AMTDUE = " + newAmountDue + " WHERE NAME = '" + divName + "';");              
                                    //updated previous based on current
                                    //UpData("UPDATE watercoldata SET PREVIOUS = " + currentTotalReading + " WHERE NAME = '" + divName + "';");
                                    //update current into 0
                                    //UpData("UPDATE watercoldata SET CURRENT = " + (currentTotalReading + reading) + " WHERE NAME = '" + divName + "';");
                                    //update reading into 0
                                    //UpData("UPDATE watercoldata SET READING = " + 0 + " WHERE NAME = '" + divName + "';");
                                    
                                    //if newAmountDue = 0 then set the status to BALANCE PAID
                                    if(newAmountDue == 0)
                                    {
                                        UpData("UPDATE watercoldata SET STATUS = '" + "BALANCE PAID" + "' WHERE NAME = '" + divName + "';");

                                    }
                                    else
                                    {
                                        UpData("UPDATE watercoldata SET STATUS = '" + "PLEASE PAY YOUR BILLS ON TIME" + "' WHERE NAME = '" + divName + "';");
                                    }

                                    //add to history
                                    insertHistData("INSERT INTO watercollhist(dateTimeStamp, fName, amPaid, transDate) VALUES('" + currentDate.ToString("yyyy-MM-dd HH:ss") + "', '" + clientNameTB.Text + "', " + payAmount + ", '" + dtpGarbHist.Text + "');");
                                    /*insertHistData("INSERT INTO overalltransachist(dateTimeStamp, transType, fullName, payAmount, transDate) VALUES('" + currentDate.ToString("yyyy-MM-dd HH:ss") + "', '" + transType + "', '" + clientNameTB.Text + "', " + payAmount + ", '" + dtpGarbHist.Text + ";");*/
                                    Form tmp = this.FindForm();
                                    tmp.Close();
                                    tmp.Dispose();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Invalid Amount. Please Try Again!", "INVALID AMOUNT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }





                            /*if (payAmount > 0)
                            {
                                //string promRem = getPromRem("SELECT promRemarks FROM garbcoldata WHERE fName = '" + divName[1] + "' and lName='" + divName[0] + "';");
                                double AmountDue = getDoubData("SELECT AMTDUE FROM watercoldata WHERE fName = '" + divName + "';");
                                //double totalPaid = getDoubData("SELECT totPaid FROM garbcoldata WHERE fName = '" + divName[1] + "' and lName='" + divName[0] + "';");
                                double newAmountDue = AmountDue - payAmount;
                                //double newTotPaid = totalPaid + payAmount;
                                //UpData("UPDATE garbcoldata SET pDue = " + AmountDue + " WHERE fName = '" + divName[1] + "' AND lName = '" + divName[0] + "';");
                                UpData("UPDATE garbcoldata SET AMTDUE = " + newAmountDue + " WHERE fName = '" + divName + "';");
                                //UpData("UPDATE garbcoldata SET totPaid = " + newTotPaid + " WHERE fName = '" + divName[1] + "' AND lName = '" + divName[0] + "';");
                                //UpData("UPDATE garbcoldata SET payRemarks = 'Paid' WHERE fName = '" + divName[1] + "' AND lName = '" + divName[0] + "';");

                                if (payAmount >= 400) //|| totalPaid >= 400)
                                {
                                    UpData("UPDATE garbcoldata SET dueDate = DATE_ADD(dueDate, INTERVAL 1 MONTH) WHERE fName = '" + divName[1] + "' AND lName = '" + divName[0] + "';");
                                }


                                if (AmountDue < 1200)
                                {
                                    UpData("UPDATE garbcoldata SET colRemarks = 'For Collection' WHERE fName = '" + divName[1] + "' AND lName = '" + divName[0] + "';");
                                    insertHistData("INSERT INTO garbcollhist(dateTimeStamp, fName, amPaid, transDate, payRem, colRem) VALUES('" + currentDate.ToString("yyyy-MM-dd HH:ss") + "', '" + clientNameTB.Text + "', " + payAmount + ", '" + dtpGarbHist.Text + "', '" + remCBox.Text + "', 'For Collection');");
                                    insertHistData("INSERT INTO overalltransachist(dateTimeStamp, transType, fullName, payAmount, transDate, remarksChange, collectionChange) VALUES('" + currentDate.ToString("yyyy-MM-dd HH:ss") + "', '" + transType + "', '" + clientNameTB.Text + "', " + payAmount + ", '" + dtpGarbHist.Text + "', '" + remCBox.Text + "', 'For Collection');");
                                }
                                else
                                {
                                    UpData("UPDATE garbcoldata SET colRemarks = 'Not For Collection' WHERE fName = '" + divName[1] + "' AND lName = '" + divName[0] + "';");
                                    insertHistData("INSERT INTO garbcollhist(dateTimeStamp, fName, amPaid, transDate, payRem, colRem) VALUES('" + currentDate.ToString("yyyy-MM-dd HH:ss") + "', '" + clientNameTB.Text + "', " + payAmount + ", '" + dtpGarbHist.Text + "', '" + remCBox.Text + "', 'Not For Collection');");
                                    insertHistData("INSERT INTO overalltransachist(dateTimeStamp, transType, fullName, payAmount, transDate, remarksChange, collectionChange) VALUES('" + currentDate.ToString("yyyy-MM-dd HH:ss") + "', '" + transType + "', '" + clientNameTB.Text + "', " + payAmount + ", '" + dtpGarbHist.Text + "', '" + remCBox.Text + "', 'Not For Collection');");
                                }

                                MessageBox.Show("PAYMENT SUBMITTED!", "PAYMENT SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                generateReceipt(divName);
                            }
                            else
                            {
                                MessageBox.Show("Invalid Amount. Please Try Again!", "INVALID AMOUNT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }*/
                            clientNameTB.Text = "";
                            payAmTB.Text = "";
                            dtpGarbHist.Text = DateTime.Now.ToShortDateString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("INVALID CLIENT!", "CLIENT NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //error message for client name tb
                    if (string.IsNullOrWhiteSpace(clientNameTB.Text) || clientNameTB.Text == "Last Name, First Name")
                    {
                        addPaymentErrorProvider.SetError(clientNameTB, "This field cannot be empty");
                    }
                    else
                    {
                        addPaymentErrorProvider.SetError(clientNameTB, "");
                    }

                    //error message for pay amount tb
                    if (string.IsNullOrWhiteSpace(payAmTB.Text))
                    {
                        addPaymentErrorProvider.SetError(payAmTB, "This field cannot be empty");
                    }
                    else
                    {
                        addPaymentErrorProvider.SetError(payAmTB, "");
                    }
                }
            }
        }

        private void generateReceipt(string divName)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word Document (*.docx)|*.docx";
            saveFileDialog.Title = "Save Receipt";
            saveFileDialog.ShowDialog();

            if (!string.IsNullOrEmpty(saveFileDialog.FileName))
            {
                // Create a new document
                using (DocX document = DocX.Create(saveFileDialog.FileName))
                {
                    // Add a title
                    document.InsertParagraph("Receipt")
                        .FontSize(20)
                        .Bold()
                        .Alignment = Alignment.center;

                    // Add some information
                    document.InsertParagraph("Date: " + DateTime.Now.ToShortDateString());
                    document.InsertParagraph("Time: " + DateTime.Now.ToShortTimeString());
                    document.InsertParagraph("Customer Name: " + divName + " ");
                    document.InsertParagraph("Item: Product Name");
                    document.InsertParagraph("Price: $10.00");

                    // Save the document
                    document.Save();

                    MessageBox.Show("RECEIPT SUCCESSFULLY CREATED!", "RECEIPT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("INVALID FILENAME!", "INVALID FILENAME", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //function to ensure payAmTB only accepts numeric value
        private void payAmTB_TextChanged(object sender, EventArgs e)
        {
            string input = payAmTB.Text;

            string numericInput = Regex.Replace(input, "[^0-9]", "");

            payAmTB.Text = numericInput;

            payAmTB.SelectionStart = payAmTB.Text.Length;
        }

    }
}
