using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;

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

        public DataTable selectawardrev()
        {
            string query = "SELECT ReviewerName FROM GameReviewer;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable selectgenre()
        {
            string query = "SELECT DISTINCT Genre FROM Game;";
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

        public int addadmin(string UserName, string Password)
        {
            string query = $"INSERT INTO UserPasswordsAuthorization VALUES ('{UserName}','{Password}', 'Admin');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int addman(string Name, string Country)
        {
            string query = $"INSERT INTO Manufacturer VALUES ('{Name}','{Country}');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int addeng(string Name, string language, string platform)
        {
            string query = $"INSERT INTO GameEngine VALUES ('{Name}','{language}','{platform}');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int addrev(string Name, string URL, string date)
        {
            string query = $"INSERT INTO GameReviewer VALUES ('{Name}','{URL}','{date}');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int addcon(string Name, string date, string man)
        {
            string query = $"INSERT INTO Console VALUES ('{Name}','{date}','{man}');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int addstor(string username,string Name, int rate, int hotline)
        {
            string query = $"INSERT INTO GamingStore VALUES ('{username}','{Name}',{rate},{hotline});";
            return dbMan.ExecuteNonQuery(query);
        }

        public int addpub(string username,string Name, string country, string type, string date)
        {
            string query = $"INSERT INTO GamingStore VALUES ('{username}','{Name}','{country}','{type}','{date}');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int addaward(string Name, string genre, string reviewer)
        {
            string query = $"INSERT INTO Award VALUES ('{Name}','{genre}','{reviewer}',NULL,NULL);";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable Report1()
        {
            string query = "SELECT COUNT(*) AS 'Number of Games',AVG(Rating) AS 'Average Games Rating' FROM Game;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Report2()
        {
            string query = "SELECT COUNT(*) AS 'Number of Gamers' FROM Gamer;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Report3()
        {
            string query = "SELECT COUNT(*) AS 'Number of Stores',AVG(Rating) AS 'Average Rating of Stores' FROM GamingStore;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Report4()
        {
            string query = "SELECT COUNT(*) AS 'Number of Game Publishers' FROM GamePublisher;";
            return dbMan.ExecuteReader(query);
        }


        //**********************************************************************************

        public int CheckIfEmailAlreadyAssociatedWithAnAccount(string email)
        {
            string query = "SELECT COUNT(*) FROM Gamer WHERE Email = '" + email + "';";
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }

        public DataTable RetreieveTournaments()
        {
            string query = "SELECT TName AS Name, Capacity, AvailableSpots, TournamentType AS Type, TLocation AS Location, StartDate, Organizer, PrizeMoney FROM Tournament;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable RetreieveTournamentsEntrolledIn(string UserName)
        {
            string query = "SELECT T.TName AS Name, Capacity, T.AvailableSpots, TournamentType AS Type, Region, T.StartDate, Organizer, PrizeMoney FROM Tournament AS T, Enroll AS E WHERE GamerUserName = '" + UserName + "' AND E.TName = T.TName;";
            return dbMan.ExecuteReader(query);
        }

        public int UnenrollFromTournament(string UserName, string TournamentName)
        {
            string query = "DELETE FROM Enroll WHERE GamerUserName = '" + UserName + "' AND TName = '" + TournamentName + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int IncrementAvailableSlots(string Tname)
        {
            string query = "UPDATE Tournament SET AvailableSpots = AvailableSpots + 1 WHERE TName = '" + Tname + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DecrementAvailableSlots(string Tname)
        {
            string query = "UPDATE Tournament SET AvailableSpots = AvailableSpots - 1 WHERE TName = '" + Tname + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertNewStoreIntoStoreTable(string UserName, string StoreName,int Rating,int Hotline)
        {
            string query = "INSERT INTO GamingStore VALUES ('" + UserName + "','"+StoreName+"','"+Rating+"','"+Hotline+"')";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertNewStoreIntoUserPasswordsAuthorizationTable(string UserName, string Password)
        {
            string query = "INSERT INTO UserPasswordsAuthorization (RegUserName, Password, AuthorizationLevel) VALUES ('" + UserName + "','" + Password + "', 'Game Store');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable RetreiveAllLiveTournaments()
        {
            string query = "SELECT * FROM Tournament";
            return dbMan.ExecuteReader(query);
        }
        public string GetStoreRealName(string username)
        {
            string query = "SELECT StoreRealName FROM GamingStore WHERE StoreUserName='" + username + "'";
            return dbMan.ExecuteScalar(query).ToString();
        }
        public int GetStoreRating(string username)
        {
            string query = "SELECT Rating FROM GamingStore WHERE StoreUserName='" + username + "'";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int GetStoreHotline(string username)
        {
            string query = "SELECT Hotline FROM GamingStore WHERE StoreUserName='" + username + "'";
            return (int)dbMan.ExecuteScalar(query);
        }

      public int InsertNewTournament(string Tname,int Capacity,string gamename,string type,string region,string sdate,string org,float prizemoney)
        {
            string Status = "Open";
            string query = "Insert into Tournament Values('" + Tname + "',"+Capacity+","+Capacity+",'"+gamename+"','"+type+ "', '" + region + "','" + sdate+"','"+org+"',"+prizemoney+",'"+Status+"')";
            return dbMan.ExecuteNonQuery(query);
        }
       public DataTable Tournamentdata(string Susername)
        {
            string query = "Select * from Tournament where Organizer='" + Susername + "' ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable TName(string username)
        {
            string query="Select TName from Tournament where Organizer='"+username+"'";
            return dbMan.ExecuteReader(query);
        }
       public int RegStatus(string TName , string status)
        {
            string query = "UPDATE Tournament Set Registration_Status='" + status + "' where TName='" + TName + "'  ";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable Regions()
        {
            string query = "SELECT Distinct Region FROM Tournament";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Types()
        {
            string query = "Select distinct TournamentType from Tournament";
            return dbMan.ExecuteReader(query);
        }
        public int InsertNewTournamentWithoutDate(string name, int Capacity, string type, string region, string org, float prizemoney)
        {
            string Status = "Open";
            string query = "Insert into Tournament(TName,Capacity,AvailableSpots,TournamentType,Region,Organizer,PrizeMoney,Registration_Status) Values('" + name + "'," + Capacity + "," + Capacity + ",'" + type + "','" + org + "'," + prizemoney + ",'" + Status + "')";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertNewTournamentWithoutMoney(string name, int Capacity,string gamename, string type, string region,string date, string org)
        {
            string Status = "Open";
            string query = "Insert into Tournament(TName,Capacity,AvailableSpots,GameName,TournamentType,Region,StartDate,Organizer,Registration_Status) Values('" + name + "'," + Capacity + "," + Capacity + ",'"+gamename+"','" + type + "','"+region+"','"+date+"','" + org + "','" + Status + "')";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertNewTournamentWithoutMoneyAndDate(string name, int Capacity, string type, string region, string org)
        {
            string Status = "Open";
            string query = "Insert into Tournament(TName,Capacity,AvailableSpots,TournamentType,Region,Organizer,Registration_Status) Values('" + name + "'," + Capacity + "," + Capacity + ",'" + type + "','"+region+"','" + org + "','" + Status + "')";
            return dbMan.ExecuteNonQuery(query);
        }

        public int EnrollInTournament(string UserName, string TournamentName)
        {
            string query = "INSERT INTO ENROLL VALUES ('" + UserName + "', '" + TournamentName + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int CheckIfAlreadyEnrolledInTournament(string UserName, string TournamentName)
        {
            string query = "SELECT COUNT(*) FROM ENROLL WHERE GamerUserName = '" + UserName + "' AND TName = '" + TournamentName + "';";
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }
        public DataTable GameNameInventory(string username)
        {
            string query = "Select distinct GameName From Inventory Where StoreName='" + username + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable RetreiveAllGamesInTournaments()
        {
            string query = "SELECT DISTINCT GameName FROM Tournament;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable FilterTournaments(string Genre, string Region, string Type, string Game, string SortBy)
        {
            string query = "DECLARE @SortColumn AS VARCHAR(20) = '" + SortBy + "' SELECT T.* FROM Tournament T JOIN Game G ON T.GameName = G.GameName WHERE (G.Genre = '" + Genre + "' OR '" + Genre + "' = '') AND (T.Region = '" + Region + "' OR '" + Region + "' = '') AND (T.TournamentType = '" + Type + "' OR '" + Type + "' = '') AND (G.GameName = '" + Game + "' OR '" + Game + "' = '') ORDER BY CASE WHEN @SortColumn = 'Available Spots' THEN T.AvailableSpots END ASC, CASE WHEN @SortColumn = 'Start Date' THEN T.StartDate END ASC;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SearchTournamentGame(string search)
        {
            string query = "SELECT * FROM Tournament WHERE TName LIKE '%" + search + "%' OR GameName LIKE '%" + search + "%';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable RetreiveAllGames()
        {
            string query = "SELECT * FROM Game";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetGameRecommendations(string username)
        {
            string query = "SELECT * FROM Game WHERE Genre IN (SELECT TOP 3 G.Genre FROM Game AS G, Plays AS P WHERE P.GamerUserName = '" + username + "' AND G.GameName = P.GameName GROUP BY G.Genre ORDER BY COUNT(*) DESC) AND GameName NOT IN (SELECT GameName FROM Plays WHERE GamerUserName = '" + username + "');";
            return dbMan.ExecuteReader(query);
        }

        public DataTable FilterGames(string Genre)
        {
            string query = "SELECT * FROM Game WHERE Genre = '" + Genre + "';";
            return dbMan.ExecuteReader(query);
        }

        public int CheckIfGameIsInLibrary(string username, string gamename)
        {
            string query = "SELECT COUNT(*) FROM Plays WHERE GameName = '" + gamename + "' AND GamerUserName = '" + username + "';";
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }

        public int AddGameToLibrary(string username, string gamename)
        {
            string query = "INSERT INTO Plays VALUES ('" + gamename + "','" + username + "', NULL, NULL, NULL);";
            return dbMan.ExecuteNonQuery(query);
        }
        public int AdjustPrice(string Susername,string GameName,float price)
        {
            string query = "UPDATE Inventory Set Price="+price+" Where GameName='"+GameName+"' AND StoreName='"+Susername+"' ";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SearchGame(string search)
        {
            string query = "SELECT * From Game WHERE GameName LIKE '%" + search + "%';";
            return dbMan.ExecuteReader(query);
        }

        public int UpdatePassword(string username, string newpassword)
        {
            string query = "UPDATE UserPasswordsAuthorization SET Password = '" + newpassword + "' WHERE UserName = '" + username + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetInventory(string username)
        {
            string query = "Select I.GameName,Price,Genre from Inventory I,Game G Where StoreName='" + username + "'AND I.GameName=G.GameName";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getPartners(string username)
        {
            string query = "Select * from Partners where SUserName='" + username + "'";
            return dbMan.ExecuteReader(query);
        }
        public int RemovePartner(string Susername,string publisher)
        {
            string query= "DELETE from Partners where SUserName = '"+Susername+"' and PUserName = '"+publisher+"' DELETE I FROM Inventory I JOIN Game G ON I.GameName = G.GameName WHERE I.StoreName = '"+Susername+"' AND G.Publisher = '"+publisher+"'";
            return dbMan.ExecuteNonQuery(query);
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        //Tifa's Functions

        public DataTable Get_All_Published_Games(string PublisherName)
        {
            string query = $"SELECT GameName,Genre,ReleaseDate,ConsoleName,Rating,Reviewer FROM Game WHERE Game.Publisher='{PublisherName}'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Get_Played_Games()
        {
            string query = $"SELECT  Game.GameName,Game.Genre,Game.ConsoleName, Game.EngineName,Game.Publisher, COUNT(Plays.GamerUserName) AS No_of_Players FROM Game JOIN  Plays ON Plays.GameName = Game.GameName GROUP BY Game.GameName, Game.Genre, Game.ConsoleName, Game.EngineName, Game.Publisher ORDER BY  No_of_Players DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Get_Played_Games_By_Userrating()
        {
            string query = $"SELECT \r\n    Game.GameName,\r\n    Game.Genre,\r\n    Game.ConsoleName,\r\n    Game.EngineName,Game.Publisher,\r\n    AVG(Plays.UserRating) AS Average_User_Rating\r\nFROM \r\n    Game\r\nJOIN \r\n    Plays ON Plays.GameName = Game.GameName\r\nGROUP BY \r\n    Game.GameName, Game.Genre, Game.ConsoleName, Game.EngineName, Game.Publisher\r\nORDER BY \r\n    Average_User_Rating DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Get_Played_Games_By_Rating()
        {
            string query = $"SELECT  Game.GameName, Game.Genre, Game.ConsoleName,Game.Publisher ,Game.EngineName,Game.Rating FROM Game JOIN  Plays ON Plays.GameName = Game.GameName GROUP BY  Game.GameName, Game.Genre, Game.ConsoleName, Game.EngineName,Game.Rating ,Game.Publisher Order BY  Game.Rating DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Get_Played_Games_Pub(string PublisherName)
        {
            string query = $"SELECT  Game.GameName,Game.Genre,Game.ConsoleName, Game.EngineName,Game.Publisher, COUNT(Plays.GamerUserName) AS No_of_Players FROM Game JOIN  Plays ON Plays.GameName = Game.GameName where Game.Publisher='{PublisherName}' GROUP BY Game.GameName, Game.Genre, Game.ConsoleName, Game.EngineName, Game.Publisher ORDER BY  No_of_Players DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Get_Played_Games_By_userrating_pub(string PublisherName)
        {
            string query = $"SELECT \r\n    Game.GameName,\r\n    Game.Genre,\r\n    Game.ConsoleName,\r\n    Game.EngineName,Game.Publisher,\r\n    AVG(Plays.UserRating) AS Average_User_Rating\r\nFROM \r\n    Game\r\nJOIN \r\n    Plays ON Plays.GameName = Game.GameName\r\n WHERE Game.Publisher='{PublisherName}'GROUP BY \r\n    Game.GameName, Game.Genre, Game.ConsoleName, Game.EngineName, Game.Publisher\r\nORDER BY \r\n    Average_User_Rating DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Get_Played_Games_By_Rating_Pub(string PublisherName)
        {
            string query = $"SELECT  Game.GameName, Game.Genre, Game.ConsoleName,Game.Publisher ,Game.EngineName,Game.Rating FROM Game JOIN  Plays ON Plays.GameName = Game.GameName WHERE Game.Publisher ='{PublisherName}' GROUP BY  Game.GameName, Game.Genre, Game.ConsoleName, Game.EngineName,Game.Rating ,Game.Publisher Order BY  Game.Rating DESC;";
            return dbMan.ExecuteReader(query);
        }


        public int Add_Game(string GameName, string Genre, string ReleaseDate, string ConsoleName, string EngineName, string Reviewer, string Publisherusername, int rating)
        {
            string query = $"INSERT INTO Game Values ('{GameName}','{Genre}','{ReleaseDate}','{ConsoleName}','{EngineName}','{Publisherusername}',{rating},'{Reviewer}');";
            return dbMan.ExecuteNonQuery (query);
        }


        public DataTable Get_Rewarded_Games()
        {
            string query = $"SELECT Award.AwardName, Game.GameName, Game.Publisher, COUNT(Plays.GamerUserName) AS No_of_Players FROM Award JOIN Game ON Award.Won = Game.GameName LEFT JOIN Plays ON Plays.GameName = Game.GameName GROUP BY Award.AwardName, Game.GameName, Game.Publisher ORDER BY No_of_Players DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Get_Rewarded_Games_pub(string PublisherUsername)
        {
            string query = $"SELECT Award.AwardName, Game.GameName, Game.Publisher, COUNT(Plays.GamerUserName) AS No_of_Players FROM Award JOIN Game ON Award.Won = Game.GameName LEFT JOIN Plays ON Plays.GameName = Game.GameName WHERE Game.Publisher='{PublisherUsername}' GROUP BY Award.AwardName, Game.GameName, Game.Publisher ORDER BY No_of_Players DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Get_Partnered_Stores(string Publisherusername)
        {
            string query = $"SELECT GamingStore.StoreRealName,GamingStore.Rating,GamingStore.Hotline FROM GamingStore,Partners WHERE Partners.PUserName='{Publisherusername}' AND GamingStore.StoreUserName=Partners.SUserName";
            return dbMan.ExecuteReader(query);
        }
        public int Add_Partner(string PUsername,string SUsername)
        {
            string query = $"INSERT INTO Partners Values ('{SUsername}','{PUsername}')";
            return dbMan.ExecuteNonQuery (query);
        }

        public int Delete_Game(string selectedgame)
        {
            string query1 = $"UPDATE Award SET Won=NULL WHERE Won='{selectedgame}' ";
            dbMan .ExecuteNonQuery (query1);
            string query = $"DELETE FROM Game WHERE GameName='{selectedgame}'";
            return dbMan.ExecuteNonQuery (query);
        }

        public int Award_Game(string GameName,string AwardName,int AwardDate)
        {
            string query = $"UPDATE Award SET Won='{GameName}',YearWon={AwardDate} WHERE AwardName='{AwardName}'";
            return dbMan.ExecuteNonQuery (query);
        }

        public DataTable Get_Award_Name()
        {
            string query = $"SELECT AwardName FROM Award WHERE Won is NULL";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Get_Game_Name(string Publisherusername)
        {
            string query = $"SELECT GameName FROM Game WHERE Publisher='{Publisherusername}'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Get_Populer_Genre()
        {
            string query = $"SELECT Game.Genre,Game.Publisher,COUNT(Plays.GamerUserName) AS No_of_Players FROM Plays JOIN Game ON Plays.GameName = Game.GameName GROUP BY Game.Genre,Game.Publisher ORDER BY No_of_Players DESC;";
            return dbMan.ExecuteReader(query);
        }

        public int Delete_Partner(string Publisherusername, string selectedstore)
        {
            string query = $"DELETE FROM Partners WHERE SUserName='{selectedstore}' AND PUserName='{Publisherusername}'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Check_Partner(string Publisherusername, string selectedstore)
        {
            string query = $"SELECT COUNT(*) FROM Partners WHERE SUserName='{selectedstore}' AND PUserName='{Publisherusername}'";
            return (int)dbMan.ExecuteScalar(query);
        }

        public DataTable Get_Populer_Engine()
        {
            string query = $"SELECT Game.EngineName, Game.Publisher, COUNT(Plays.GamerUserName) AS No_of_Players FROM Plays JOIN Game ON Plays.GameName = Game.GameName GROUP BY Game.EngineName, Game.Publisher ORDER BY No_of_Players DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Get_Populer_Platform()
        {
            string query = $"SELECT Game.ConsoleName,Game.Publisher ,COUNT(Plays.GamerUserName) AS No_of_Players FROM Plays JOIN Game ON Plays.GameName = Game.GameName GROUP BY Game.ConsoleName,Game.Publisher ORDER BY No_of_Players DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Get_ConsoleName()
        {
            string query = $"SELECT ConsoleName FROM Console";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Get_EngineName()
        {
            string query = $"SELECT EngineName FROM GameEngine";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Get_ReviewerName()
        {
            string query = $"SELECT ReviewerName FROM GameReviewer";
            return dbMan.ExecuteReader(query);
        }

        //--------------------------------------------------------
        public int CheckIfNewPasswordAlreadyUsed(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM UserPasswordsAuthorization WHERE UserName = '" + username + "' AND Password = '" + password + "';";
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }
        public DataTable GetGenre(string SuserName)
        {
            string query = "Select G.Genre From Game G,Inventory I Where G.GameName=I.GameName AND I.StoreName='" + SuserName + "'";
            return dbMan.ExecuteReader(query);
        }
        public int ApplyPromotion(string Susername, string Genre, int promotion)
        {
            string query = "Update Inventory Set Price=Price-(Price*" + promotion + "/100) From Game G Where Inventory.GameName = G.GameName And Inventory.StoreName = '" + Susername + "' And G.Genre = '" + Genre + "'";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable PartnersNum(string UserName)
        {
            string query = "Select SUserName, Count(*) AS 'Number of Partners' From Partners Group By SUserName ORDER BY Count(*) DESC";
            return dbMan.ExecuteReader(query);
        }
        public DataTable AvgGPrice(string UserName)
        {
            string query = "Select StoreName,AVG(Price) AS 'Average Game Price'  From Inventory Group By StoreName ORDER BY AVG(Price) DESC";
            return dbMan.ExecuteReader(query);
        }
        public DataTable TNum(string UserName)
        {
            string query = "Select Organizer, Count(*) AS 'Tournaments Count' From Tournament Group By Organizer ORDER BY COUNT(*) DESC";
            return dbMan.ExecuteReader (query);
        }
        public DataTable AvgPMoney(string UserName)
        {
            string query = "Select Organizer, Avg(PrizeMoney) AS 'Average Prize Money' From Tournament Group By Organizer ORDER BY AVG(PrizeMoney) DESC";
            return dbMan.ExecuteReader(query);
        }


    }
}
