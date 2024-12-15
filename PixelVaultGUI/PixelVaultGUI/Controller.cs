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

        public DataTable RetreiveGamerGamesLibrary(string UserName)
        {
            string query = "SELECT GameName AS Name, CompletionStatus AS Completed, Difficulty, UserRating AS Rating FROM Plays WHERE GamerUserName = '" + UserName + "';";
            return dbMan.ExecuteReader(query);

        }

        public int RemoveGameFromLibrary(string GameName)
        {
            string query = "DELETE FROM Plays WHERE GameName = '" + GameName + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateCompletionStatus(string GameName, string status, string GamerUserName)
        {
            string query = "UPDATE Plays SET CompletionStatus = '" + status + "' WHERE GamerUserName = '" + GamerUserName + "' AND GameName = '" + GameName + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateRatingandDifficulty(string GameName, string UserName, string Difficulty, int Rating)
        {
            string query = "UPDATE Plays SET Difficulty = '" + Difficulty + "', UserRating = '" + Rating + "' WHERE GamerUserName = '" + UserName + "' AND GameName = '" + GameName + "'";
            return dbMan.ExecuteNonQuery(query);
        }

        //Tarek's Functions
        public DataTable selectcon()
        {
            string query = "SELECT * FROM Console;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable selecteng()
        {
            string query = "SELECT * FROM GameEngine;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable selectgamer()
        {
            string query = "SELECT * FROM Gamer;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable selectman()
        {
            string query = "SELECT * FROM Manufacturer;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable selectstor()
        {
            string query = "SELECT * FROM GamingStore;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable selectpub()
        {
            string query = "SELECT * FROM GamePublisher;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable selectrev()
        {
            string query = "SELECT * FROM GameReviewer;";
            return dbMan.ExecuteReader(query);
        }

        public int deletecon(string name)
        {
            string query = $"DELETE FROM Console WHERE ConsoleName = '{name}'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deleteeng(string name)
        {
            string query = $"DELETE FROM GameEngine WHERE EngineName = '{name}'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deletestor(string name)
        {
            string query = $"DELETE FROM GamingStore WHERE StoreUserName = '{name}'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deletegamer(string name)
        {
            string query = $"DELETE FROM Gamer WHERE Anumber = '{name}'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deletepub(string name)
        {
            string query = $"DELETE FROM GamePublisher WHERE PublisherUserName = '{name}'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deleteman(string name)
        {
            string query = $"DELETE FROM Manufacturer WHERE ManufacturerName = '{name}'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deleterev(string name)
        {
            string query = $"DELETE FROM GameReviewer WHERE ReviewerName = '{name}'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int CheckIfEmailAlreadyAssociatedWithAnAccount(string email)
        {
            string query = "SELECT COUNT(*) FROM Gamer WHERE Email = '" + email + "';";
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
