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

        public int CheckIfUserNameExists(string UserName)
        {
            string query = "SELECT COUNT(*) FROM UserPasswordsAuthorization WHERE UserName = '" + UserName + "';";
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }

        public int InsertNewGamerIntoGamerTable(string UserName, string FirstName, string LastName, string Email, string Country, string BirthDate)
        {
            string query = "INSERT INTO Gamer (UserName, FirstName, LastName, Email, Country, BirthDate) VALUES " +
                "('" + UserName + "','" + FirstName + "', '" + LastName + "', '" + Email + "', '" + Country + "', '" + BirthDate + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertNewGamerIntoUserPasswordsAuthorizationTable(string UserName, string Password)
        {
            string query = "INSERT INTO UserPasswordsAuthorization (UserName, Password, AuthorizationLevel) VALUES ('" + UserName + "','" + Password + "', 'Gamer');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable RetrieveAllConsoleTypes()
        {
            string query = "SELECT DISTINCT ConsoleType FROM GamePublisher;";
            return dbMan.ExecuteReader(query);
        }

        public int InsertNewGamePublisherIntoGamePublisherTable(string PublisherUserName, string PublisherRealName, string Country, string ConsoleType, string StartDate)
        {
            string query = "INSERT INTO GamePublisher (PublisherUserName, PublisherRealName, Country, ConsoleType, StartDate) VALUES " +
                "('" + PublisherUserName + "','" + PublisherRealName + "','" + Country + "', '" + ConsoleType + "', '" + StartDate + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertNewGamePublisherIntoUserPasswordsAuthorizationTable(string UserName, string Password)
        {
            string query = "INSERT INTO UserPasswordsAuthorization (UserName, Password, AuthorizationLevel) VALUES ('" + UserName + "','" + Password + "', 'Game Publisher');";
            return dbMan.ExecuteNonQuery(query);
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
