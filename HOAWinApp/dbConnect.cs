using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOAWinApp
{
    internal class dbConnect
    {
        static readonly string server = "127.0.0.1";
        static readonly string user = "root";
        static readonly string password = "@Johnboja123";
        static readonly string database = "users";
        public static string connString = "server='" + server + "'; user= '" + user + "'; database= '" + database + "'; password= '" + password + "'";
        public MySqlConnection conn = new MySqlConnection(connString);

        public bool connect_db()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool close_db()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    }
}
