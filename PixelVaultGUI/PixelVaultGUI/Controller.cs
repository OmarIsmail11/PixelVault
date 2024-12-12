using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }

        // Query Functions
        public DataTable SelectAllUserNamesPasswords()
        {
            string query = "SELECT * FROM UserPasswordsAuthorization;";
            return dbMan.ExecuteReader(query);
        }
        public string CheckCredentials(string UserName, string password)
        {
            string query = "SELECT AuthorizationLevel FROM UserPasswordsAuthorization WHERE UserName = '" + UserName + "' AND Password = '" + password + "';";
            object result = dbMan.ExecuteScalar(query);
            if (result == null) return "";
            else return Convert.ToString(result);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
