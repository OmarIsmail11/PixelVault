	USE master;
	GO
	ALTER DATABASE PixelVault SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	GO
	DROP DATABASE IF EXISTS PixelVault;
	GO
	CREATE DATABASE PixelVault
	GO
	USE PixelVault;
	GO	

	CREATE TABLE GameEngine(
	EngineName CHAR(20) ,
	Language VARCHAR(20) NOT NULL ,
	Platform CHAR(20) NOT NULL CHECK(Platform in ('Windows','Mobile','Cross-Platform','Playstation')) ,
	PRIMARY KEY(EngineName)
	);

	

	CREATE TABLE Manufacturer (
	ManufacturerName CHAR(30),
	Country CHAR(20) NULL,
	PRIMARY KEY(ManufacturerName)

	);


	CREATE TABLE GameReviewer(
    ReviewerName varchar(30),
    ReviewerURL NVARCHAR(255) UNIQUE NOT NULL,
    LaunchDate date,
    PRIMARY KEY (ReviewerName),

	);


	CREATE TABLE Console(
	ConsoleName	CHAR(20) ,
	ReleaseDate	DATE NOT NULL,
	Develop CHAR(30) ,
	PRIMARY KEY (ConsoleName),
	FOREIGN KEY (Develop) REFERENCES Manufacturer (ManufacturerName)
		ON DELETE SET NULL
		ON UPDATE CASCADE
	);

	

	CREATE TABLE GamePublisher(
    PublisherUserName varchar(30),
	PublisherRealName varchar(30) UNIQUE NOT NULL,
    Country char(30) NOT NULL,
    ConsoleType varchar(30) NOT NULL,
    StartDate date,
    PRIMARY KEY (PublisherUserName)
	);



	CREATE TABLE GamingStore
	(
		StoreUserName varchar(30),
		StoreRealName varchar(30) UNIQUE NOT NULL,
		Rating int not null CHECK (Rating Between 1 AND 5),
		Hotline int not null ,
		PRIMARY KEY (StoreUserName)
	);

	CREATE TABLE Tournament(
	TName CHAR(20),
	Capacity INT NOT NULL,
	AvailableSpots INT NOT NULL,
	TournamentType	VARCHAR(20) NOT NULL CHECK (TournamentType IN ('Sports' , 'Racing' , 'Fighting', 'Battle Royale' , 'FPS' ) ) ,
	Region	CHAR(20) NOT NULL CHECK (Region IN ('North America', 'South America', 'Europe', 'Africa', 'Asia')),
	StartDate	DATE ,
	Organizer	varchar(30),
	PrizeMoney DECIMAL(10,2),
	Registration_Status Char(6) Not Null default 'Open' Check(Registration_Status In('Open','Closed')),
	PRIMARY KEY(TName) ,
	FOREIGN KEY (Organizer) REFERENCES GamingStore(StoreUserName)
		ON DELETE CASCADE
		ON UPDATE CASCADE
	);

	

	CREATE TABLE Gamer(
	UserName	VARCHAR(30),
	FirstName	VARCHAR(20) NOT NULL,
	LastName	VARCHAR(20) NOT NULL,
	Email		NVARCHAR(255) UNIQUE NOT NULL,
	Country		CHAR(20)	NOT NULL,
	BirthDate	DATE,
	PRIMARY KEY(UserName)
	);

	

	CREATE TABLE Game(
    GameName varchar(50),
    Genre varchar(30) not null check (Genre IN ('Sports', 'Racing', 'Fighting', 'Battle Royale', 'FPS')),
    ReleaseDate date,
    ConsoleName char(20),
    EngineName char(20),
    Publisher varchar(30),
    Rating int default 0,
    Reviewer varchar(30),
    primary key (GameName),
    foreign key (ConsoleName) references Console(ConsoleName)
        ON UPDATE CASCADE
        ON DELETE SET NULL,
    foreign key (EngineName) references GameEngine(EngineName)
        ON UPDATE CASCADE
        ON DELETE SET NULL,
    foreign key (Publisher) references GamePublisher(PublisherUserName)
        ON UPDATE CASCADE
        ON DELETE SET NULL,
    foreign key (Reviewer) references GameReviewer(ReviewerName)
        ON UPDATE CASCADE
        ON DELETE SET NULL
	);

	CREATE TABLE Award(
	AwardName CHAR(25) NOT NULL,
	Genre CHAR(20) NOT NULL,
	Reviewer VARCHAR(30) ,
	Won	VARCHAR(50) ,
	YearWon	INT ,
	PRIMARY KEY (AwardName,YearWon),
	FOREIGN KEY (Reviewer) REFERENCES GameReviewer(ReviewerName)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	FOREIGN KEY (Won) REFERENCES Game(GameName)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION

	);

	

	CREATE TABLE Inventory(
	GameName	VARCHAR(50),
	StoreName varchar(30),
	Price	Decimal(3,2) NOT NULL,
	PRIMARY KEY(GameName,StoreName),
	FOREIGN KEY (GameName) REFERENCES Game(GameName)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	FOREIGN KEY (StoreName) REFERENCES GamingStore(StoreUserName)
		ON DELETE CASCADE
		ON UPDATE CASCADE
	);

	

	CREATE TABLE Plays(
	GameName	VARCHAR(50),
	GamerUserName	VARCHAR(30),
	CompletionStatus	CHAR(3) CHECK(CompletionStatus IN ('Yes','No')),
	Difficulty	CHAR(6) CHECK(Difficulty IN('Hard' , 'Medium' , 'Easy')) NULL,
	UserRating INT CHECK(UserRating Between 1 AND 5),
	PRIMARY KEY(GameName,GamerUserName),
	FOREIGN KEY (GameName) REFERENCES Game(GameName)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	FOREIGN KEY (GamerUserName) REFERENCES Gamer(UserName)
		ON DELETE CASCADE
		ON UPDATE CASCADE
	);

	

	CREATE TABLE Enroll(
	GamerUserName VARCHAR(30),
	TName CHAR(20),
	PRIMARY KEY(GamerUserName,TName),
	FOREIGN KEY (GamerUserName) REFERENCES Gamer(UserName)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	FOREIGN KEY(TName) REFERENCES Tournament(TName)
		ON DELETE CASCADE
		ON UPDATE CASCADE
	);

	CREATE TABLE UserPasswordsAuthorization
	(
		UserName VARCHAR(30),
		Password VARCHAR(20) NOT NULL,
		AuthorizationLevel VARCHAR(30) NOT NULL CHECK (AuthorizationLevel in ('Gamer', 'Game Publisher', 'Game Store', 'Admin')),
		PRIMARY KEY (UserName)
	);

	INSERT INTO GameEngine VALUES
	('Unity', 'C#', 'Cross-Platform'),
	('Unreal', 'C++', 'Cross-Platform'),
	('Frostbite', 'C++', 'Windows'),
	('CryEngine', 'C++', 'Cross-Platform'),
	('RAGE', 'C++', 'Windows'),
	('Snowdrop', 'C++', 'Cross-Platform'),
	('Godot', 'C++', 'Cross-Platform'),
	('GameMaker', 'GML', 'Cross-Platform'),
	('Source', 'C++', 'Windows'),
	('Havok', 'C++', 'Windows'),
	('Panda3D', 'Python', 'Cross-Platform'),
	('RenPy', 'Python', 'Cross-Platform'),
	('Amazon Lumberyard', 'C++', 'Windows'),
	('Construct', 'JavaScript', 'Cross-Platform'),
	('Corona', 'Lua', 'Mobile'),
	('Cocos2d', 'C++', 'Cross-platform'),
	('Gamebryo', 'C++', 'Cross-Platform'),
	('Leadwerks', 'C++', 'Windows'),
	('RPG Maker', 'Ruby', 'Cross-Platform');



	INSERT INTO Manufacturer VALUES
	('Sony', 'Japan'),
	('Microsoft', 'USA'),
	('Nintendo', 'Japan'),
	('Sega', 'Japan'),
	('Naughty Dog', 'USA'),
	('Atari', 'USA'),
	('Valve', 'USA'),
	('Electronic Arts', 'USA'),
	('Ubisoft', 'France'),
	('Square Enix', 'Japan'),
	('Capcom', 'Japan'),
	('Konami', 'Japan'),
	('Bandai Namco', 'Japan'),
	('Activision Blizzard', 'USA'),
	('Take-Two Interactive', 'USA'),
	('CD Projekt', 'Poland'),
	('Bethesda', 'USA'),
	('Epic Games', 'USA'),
	('Riot Games', 'USA'),
	('Rockstar Games', 'USA');


	INSERT INTO GameReviewer VALUES
	('Destructoid', 'https://www.destructoid.com', '2006-01-01'),
	('Eurogamer', 'https://www.eurogamer.net', '1999-01-01'),
	('Game Informer', 'https://www.gameinformer.com', '1991-08-01'),
	('Game Rant', 'https://gamerant.com', '2009-01-01'),
	('Giant Bomb', 'https://www.giantbomb.com', '2008-06-01'),
	('IGN', 'https://www.ign.com', '1996-10-05'),
	('Joystiq', 'https://www.joystiq.com', '2004-01-01'),
	('Kotaku', 'https://www.kotaku.com', '2004-07-01'),
	('Metacritic', 'https://www.metacritic.com', '2001-01-01'),
	('Nice Gamer', 'https://www.nicegamer.com', '2014-01-01'),
	('PC Gamer', 'https://www.pcworld.com', '1983-12-01'),
	('Polygon', 'https://www.polygon.com', '2012-10-24'),
	('Rock Paper Shotgun', 'https://www.rockpapershotgun.com', '2007-07-01'),
	('TechRadar', 'https://www.techradar.com', '2008-06-01'),
	('The Escapist', 'https://www.escapistmagazine.com', '2005-10-01'),
	('VentureBeat', 'https://www.venturebeat.com', '2008-06-01'),
	('GameSpot', 'https://www.gamespot.com', '1996-05-01'),
	('PCMag', 'https://www.pcmag.com', '1982-01-01'),
	('GameTrailers', 'https://www.gametrailers.com', '2002-03-01'),
	('Gamers Nexus', 'https://www.gamersnexus.net', '2013-06-01');


	INSERT INTO Console (ConsoleName, ReleaseDate, Develop) VALUES
	('Atari 2600', '1977-09-11', 'Atari'),
	('Dreamcast', '1999-09-09', 'Sega'),
	('GameCube', '2001-09-14', 'Nintendo'),
	('Genesis', '1988-10-29', 'Sega'),
	('Neo Geo', '1990-07-01', 'Konami'),
	('Nintendo 3DS', '2011-02-26', 'Nintendo'),
	('Nintendo DS', '2004-11-21', 'Nintendo'),
	('PlayStation', '1994-12-03', 'Sony'),
	('PlayStation 3', '2006-11-11', 'Sony'),
	('PlayStation 4', '2013-11-15', 'Sony'),
	('PlayStation 5', '2020-11-12', 'Sony'),
	('PSP', '2004-12-12', 'Sony'),
	('Sega Genesis', '1988-08-14', 'Sega'),
	('Steam Deck', '2022-02-25', 'Valve'),
	('Switch', '2017-03-03', 'Nintendo'),
	('Wii', '2006-11-19', 'Nintendo'),
	('Xbox', '2001-11-15', 'Microsoft'),
	('Xbox 360', '2005-11-22', 'Microsoft'),
	('Xbox One', '2013-11-22', 'Microsoft'),
	('Xbox Series X', '2020-11-10', 'Microsoft');



	INSERT INTO GamePublisher VALUES
	('Nintendo', 'Nintendo', 'Japan', 'Switch', '1983-07-01'),
	('Sony_Interactive', 'Sony Interactive', 'Japan', 'PlayStation', '1993-11-16'),
	('Microsoft_Studios', 'Microsoft Studios', 'USA', 'Xbox', '2002-03-01'),
	('Electronic_Arts', 'Electronic Arts', 'USA', 'Cross-Platform', '1982-05-28'),
	('Ubisoft', 'Ubisoft', 'France', 'Cross-Platform', '1986-03-28'),
	('Square_Enix', 'Square Enix', 'Japan', 'PlayStation', '2003-04-01'),
	('Bethesda', 'Bethesda', 'USA', 'Cross-Platform', '1986-06-28'),
	('Activision', 'Activision', 'USA', 'Cross-Platform', '1979-10-01'),
	('Rockstar_Games', 'Rockstar Games', 'USA', 'Cross-Platform', '1998-12-01'),
	('Bandai_Namco', 'Bandai Namco', 'Japan', 'PlayStation', '1955-06-01'),
	('Take-Two', 'Take-Two', 'USA', 'Cross-Platform', '1993-09-30'),
	('CD_Projekt', 'CD Projekt', 'Poland', 'PC', '1994-05-01'),
	('Capcom', 'Capcom', 'Japan', 'PlayStation', '1979-05-30'),
	('Konami', 'Konami', 'Japan', 'PlayStation', '1969-03-21'),
	('Sega', 'Sega', 'Japan', 'Genesis', '1940-06-03'),
	('FromSoftware', 'FromSoftware', 'Japan', 'Cross-Platform', '1986-11-15'),
	('GearBox', 'GearBox', 'USA', 'Cross-Platform', '1999-11-01'),
	('Insomniac_Games', 'Insomniac Games', 'USA', 'PlayStation', '1994-02-28'),
	('Naughty_Dog', 'Naughty Dog', 'USA', 'PlayStation', '1984-05-08'),
	('Valve', 'Valve', 'USA', 'PC', '1996-08-24'),
	('THQ_Nordic', 'THQ Nordic', 'Austria', 'Cross-Platform', '2011-08-01'),
	('FiveHundredFive_Games', 'FiveHundredFive Games', 'Italy', 'Cross-Platform', '2006-06-01');
    


	INSERT INTO GamingStore VALUES
	('Steam', 'Steam', 5, 1800123456),
	('Epic_Games', 'Epic Games', 4, 1800123457),
	('GOG', 'GOG', 5, 1800123458),
	('PlayStation_Store', 'PlayStation Store', 5, 1800123459),
	('Microsoft_Store', 'Microsoft Store', 4, 1800123460),
	('Nintendo_eShop', 'Nintendo eShop', 4, 1800123461),
	('Origin', 'Origin', 3, 1800123462),
	('Uplay', 'Uplay', 3, 1800123463),
	('Itch.io', 'Itch.io', 5, 1800123464),
	('Green_Man_Gaming', 'Green Man Gaming', 4, 1800123465),
	('Humble_Bundle', 'Humble Bundle', 5, 1800123466),
	('Fanatical', 'Fanatical', 4, 1800123467),
	('GameStop', 'GameStop', 3, 1800123468),
	('Best_Buy', 'Best Buy', 4, 1800123469),
	('Walmart', 'Walmart', 3, 1800123470),
	('Battle.net', 'Battle.net', 4, 1800123457),
	('Rockstar_Games_Store', 'Rockstar Games Store', 5, 1800123492),
	('Ubisoft_Store', 'Ubisoft Store', 4, 1800123493),
	('CD_Projekt_Red', 'CD Projekt Red', 5, 1800123494),
	('Discord_Store', 'Discord Store', 3, 1800123496);

	INSERT INTO Gamer (UserName, FirstName, LastName, Email, Country, BirthDate) VALUES
	('OmarReda', 'Omar', 'Reda', 'omar.reda@gmail.com', 'Egypt', '2004-4-9'),
	('NoobMaster69', 'John', 'Doe', 'john.doe@gmail.com', 'USA', '1990-05-15'),
	('AliceTheAce', 'Alice', 'Smith', 'alice.smith@gmail.com', 'Canada', '1985-12-20'),
	('DragonHunter92', 'Bob', 'Brown', 'bob.brown@gmail.com', 'UK', '1992-03-10'),
	('Pixel_Queen97', 'Emma', 'Johnson', 'emma.johnson@gmail.com', 'Australia', '1997-07-25'),
	('FireFuryX', 'Liam', 'Davis', 'liam.davis@gmail.com', 'India', '1995-11-05'),
	('Sophia_Warrior', 'Sophia', 'Wilson', 'sophia.wilson@gmail.com', 'Germany', '1993-04-17'),
	('Oliver007', 'Oliver', 'Moore', 'oliver.moore@gmail.com', 'France', '1989-09-30'),
	('IceDragonXX', 'Isabella', 'Taylor', 'isabella.taylor@gmail.com', 'Japan', '2000-02-18'),
	('BattleKing94', 'James', 'Anderson', 'james.anderson@gmail.com', 'Italy', '1994-08-12'),
	('QuickMia9', 'Mia', 'Martinez', 'mia.martinez@gmail.com', 'Mexico', '1996-01-09'),
	('Dark.Knight', 'Lucas', 'Garcia', 'lucas.garcia@gmail.com', 'Spain', '1998-11-22'),
	('SpeedyElla14', 'Ella', 'Martins', 'ella.martins@gmail.com', 'Brazil', '2001-03-14'),
	('SavageWolf1999', 'Ethan', 'Kim', 'ethan.kim@gmail.com', 'South Korea', '1999-12-05'),
	('BlazeStorm202', 'Ava', 'Lee', 'ava.lee@gmail.com', 'Singapore', '2002-07-19'),
	('Thunder_Hawk', 'Henry', 'White', 'henry.white@gmail.com', 'New Zealand', '1993-10-25'),
	('EpicGamer123', 'Chris', 'Evans', 'chris.evans@gmail.com', 'USA', '1990-06-20'),
	('MagicMia', 'Mia', 'Thomas', 'mia.thomas@gmail.com', 'Canada', '1991-04-12'),
	('StealthyFox', 'Nathan', 'Fox', 'nathan.fox@gmail.com', 'UK', '1988-03-19'),
	('FirePhoenix', 'Sophia', 'Martinez', 'sophia.martinez@gmail.com', 'Australia', '1999-11-25'),
	('HyperHunter', 'James', 'Miller', 'james.miller@gmail.com', 'USA', '1994-02-14');


	INSERT INTO Game VALUES
	('Apex Legends', 'Battle Royale', '2019-02-04', 'PlayStation 5', 'Source', 'Electronic_Arts', 5, 'Polygon'),
	('Battlefield 2042', 'FPS', '2021-11-19', 'PlayStation 5', 'Frostbite', 'Electronic_Arts', 4, 'IGN'),
	('Call of Duty: Modern Warfare', 'FPS', '2019-10-25', 'Xbox Series X', 'Havok', 'Activision', 4, 'Metacritic'),
	('Call of Duty: Vanguard', 'FPS', '2021-11-05', 'Xbox Series X', 'CryEngine', 'Activision', 4, 'GameSpot'),
	('CS:GO', 'FPS', '2012-08-21', 'Xbox One', 'Godot', 'Take-Two', 5, 'Rock Paper Shotgun'),
	('FIFA 22', 'Sports', '2021-10-01', 'PlayStation 4', 'Frostbite', 'Electronic_Arts', 5, 'Kotaku'),
	('FIFA 23', 'Sports', '2022-09-30', 'PlayStation 5', 'Frostbite', 'Electronic_Arts', 4, 'Polygon'),
	('Fortnite', 'Battle Royale', '2017-07-25', 'Nintendo DS', 'Unreal', 'Capcom', 4, 'Eurogamer'),
	('Forza Horizon 4', 'Racing', '2021-11-09', 'Xbox Series X', 'Source', 'Konami', 5, 'Polygon'),
	('Forza Horizon 5', 'Racing', '2021-11-09', 'Xbox Series X', 'Construct', 'Square_Enix', 5, 'Polygon'),
	('Gran Turismo 7', 'Racing', '2022-03-04', 'PlayStation 5', 'RenPy', 'Sony_Interactive', 5, 'Game Informer'),
	('Halo Infinite', 'FPS', '2021-12-08', 'Xbox Series X', 'CryEngine', 'Microsoft_Studios', 4, 'Destructoid'),
	('Need for Speed Heat', 'Racing', '2019-11-08', 'Xbox Series X', 'Frostbite', 'Electronic_Arts', 4, 'GameSpot'),
	('Overwatch', 'FPS', '2016-05-24', 'PlayStation 3', 'RAGE', 'Activision', 5, 'IGN'),
	('PUBG', 'Battle Royale', '2017-12-20', 'Xbox One', 'Unreal', 'Capcom', 3, 'PC Gamer'),
	('Resident Evil Village', 'FPS', '2021-05-07', 'PlayStation 5', 'Unity', 'Capcom', 5, 'Game Informer'),
	('Rocket League', 'Sports', '2015-07-07', 'PlayStation 3', 'Unreal', 'CD_Projekt', 5, 'Joystiq'),
	('Street Fighter V', 'Fighting', '2016-02-16', 'PlayStation 5', 'Unreal', 'Capcom', 5, 'Kotaku'),
	('Tekken 7', 'Fighting', '2015-03-18', 'PlayStation 3', 'Unreal', 'Ubisoft', 4, 'The Escapist'),
	('Valorant', 'FPS', '2020-06-02', 'PlayStation 3', 'Unreal', 'Bethesda', 5, 'VentureBeat');



	INSERT INTO Tournament VALUES
	('EVO', 500, 500, 'Fighting', 'North America', '2023-07-07', 'Steam', 250000.00,'Open'),
	('ESL Pro League', 1000, 1000, 'FPS', 'Asia', '2023-02-01', 'Epic_Games', 1000000.00,'Open'),
	('The International', 500, 500, 'Battle Royale', 'North America', '2023-10-15', 'Steam', 50000000.00,'Open'),
	('DreamHack', 800, 800, 'FPS', 'Europe', '2023-06-15', 'GOG', 500000.00,'Closed'),
	('PAX', 400, 400, 'Sports', 'North America', '2023-03-01', 'PlayStation_Store', 100000.00,'Open'),
	('Capcom Cup', 250, 250, 'Fighting', 'Asia', '2023-12-05', 'Microsoft_Store', 300000.00,'Open'),
	('Fortnite World Cup', 500, 500, 'Battle Royale', 'North America', '2023-07-01', 'Nintendo_eShop', 3000000.00,'Open'),
	('Overwatch League', 300, 300, 'FPS', 'North America', '2023-05-15', 'Origin', 500000.00,'Open'),
	('RLCS', 600, 600, 'Racing', 'North America', '2023-08-20', 'Uplay', 200000.00,'Open'),
	('FIFAe World Cup', 128, 128, 'Sports', 'Europe', '2023-07-15', 'Itch.io', 500000.00,'Open'),
	('CS:GO Major', 1000, 1000, 'FPS', 'Europe', '2023-11-05', 'Green_Man_Gaming', 2000000.00,'Open'),
	('Call of Duty League', 400, 400, 'FPS', 'North America', '2023-09-20', 'Humble_Bundle', 1500000.00,'Open'),
	('Halo Championship', 300, 300, 'FPS', 'North America', '2023-10-10', 'Fanatical', 400000.00,'Open'),
	('Tekken World Tour', 150, 150, 'Fighting', 'Asia', '2023-11-25', 'GameStop', 200000.00,'Open'),
	('Gran Turismo Cup', 128, 128, 'Racing', 'Europe', '2023-12-12', 'Best_Buy', 300000.00,'Open'),
	('Epic Games Cup', 600, 600, 'FPS', 'Africa', '2023-03-15', 'GOG', 750000,'Open'),
	('Fall Brawl', 250, 250, 'Fighting', 'Europe', '2023-09-01', 'GameStop', 200000,'Open'),
	('Spring Clash', 500, 500, 'FPS', 'Africa', '2023-06-01', 'GameStop', 250000,'Open'),
	('Summer Clash', 600, 600, 'FPS', 'South America', '2023-07-15', 'GameStop', 300000,'Open'),
	('Winter War', 400, 400, 'Fighting', 'South America', '2023-09-15', 'Walmart', 300000,'Open');


	INSERT INTO Award VALUES
	('Best Competitive Game', 'Battle Royale', 'Polygon', 'Apex Legends', 2020),
	('Best Action Game', 'FPS', 'IGN', 'Call of Duty: Modern Warfare', 2019),
	('Best eSports Game', 'FPS', 'Metacritic', 'CS:GO', 2021),
	('Best Racing Game', 'Racing', 'Polygon', 'Forza Horizon 4', 2018),
	('Best Family Game', 'Sports', 'Game Informer', 'Rocket League', 2019),
	('Best FPS Game', 'FPS', 'GameSpot', 'Battlefield 2042', 2021),
	('Best Graphics', 'Sports', 'Eurogamer', 'FIFA 23', 2021),
	('Most Innovative Game', 'Racing', 'IGN', 'Gran Turismo 7', 2022),
	('Best Multiplayer Game', 'Battle Royale', 'PC Gamer', 'Fortnite', 2020),
	('Best Fighting Game', 'Fighting', 'Kotaku', 'Street Fighter V', 2018),
	('Best Art Direction', 'Action', 'Kotaku', 'Valorant', 2017),
	('Best Multiplayer', 'FPS', 'GameSpot', 'Overwatch', 2019),
	('Best Narrative', 'RPG', 'Polygon', 'Tekken 7', 2018),
	('Best Soundtrack', 'All', 'PC Gamer', 'Fortnite', 2020),
	('Game of the Year', 'All', 'IGN', 'Halo Infinite', 2021),  
	('Best Indie Game', 'Indie', 'PC Gamer', 'Overwatch', 2021),      
	('Best Art Direction', 'Adventure', 'IGN', 'CS:GO', 2020), 
	('Best Narrative', 'Adventure', 'Polygon', 'Need for Speed Heat', 2021), 
	('Best Soundtrack', 'Action', 'GameSpot', 'Need for Speed Heat', 2010), 
	('Best VR Game', 'VR', 'IGN', 'Rocket League', 2020);        

	INSERT INTO UserPasswordsAuthorization (UserName, Password, AuthorizationLevel) VALUES
	('OmarReda', 'TestTest12_','Gamer'),
	('NoobMaster69', 'Y6m5o2#F9z', 'Gamer'),
	('AliceTheAce', 'N7u!lQm1Pz', 'Gamer'),
	('DragonHunter92', 'H@2Xn8lZ0d', 'Gamer'),
	('Pixel_Queen97', 'Q!7zP4iZm0', 'Gamer'),
	('FireFuryX', 'Sx9l#jF1yP', 'Gamer'),
	('Sophia_Warrior', 'Q8r8ZxF@w', 'Gamer'),
	('Oliver007', 'd0x1I!9sKq', 'Gamer'),
	('IceDragonXX', 'V9rLk@pE2u', 'Gamer'),
	('BattleKing94', 'X5vXg8W!b0', 'Gamer'),
	('QuickMia9', 'J3zX9qQ#M0', 'Gamer'),
	('Dark.Knight', 'B5uL!l7G2R', 'Gamer'),
	('SpeedyElla14', 'Y8c8U!zB3j', 'Gamer'),
	('SavageWolf1999', 'C6h3qX9lD2m', 'Gamer'),
	('BlazeStorm202', 'A2o3R6z!P1s', 'Gamer'),
	('Thunder_Hawk', 'Q5aX8gW9Jz', 'Gamer'),
	('EpicGamer123', 'P7rL#9G2dB', 'Gamer'),
	('MagicMia', 'W9lA0!yV8z', 'Gamer'),
	('StealthyFox', 'M8qL1wS4zB', 'Gamer'),
	('FirePhoenix', 'T7vX2wK3qR', 'Gamer'),
	('HyperHunter', 'C4yU8Zl6pT', 'Gamer'),

	('Steam', 'd#V8gZp1Q3', 'Game Store'),
	('Epic_Games', 'rP7xW0!uQ2', 'Game Store'),
	('GOG', 'H3lT1#uX9', 'Game Store'),
	('PlayStation_Store', 'V5yB8!P2hL', 'Game Store'),
	('Microsoft_Store', 'R6cI9#qB4U', 'Game Store'),
	('Nintendo_eShop', 'F3tS!0Z9pW', 'Game Store'),
	('Origin', 'B4iO7s#3Q1', 'Game Store'),
	('Uplay', 'J7hD3!tN9X', 'Game Store'),
	('Itch.io', 'Y6cX0uP2#R', 'Game Store'),
	('Green_Man_Gaming', 'M5pX1bQ4yR', 'Game Store'),
	('Humble_Bundle', 'Z2wD5lE9pJ', 'Game Store'),
	('Fanatical', 'C8hI2tF0qA', 'Game Store'),
	('GameStop', 'X9jF5!wL2p', 'Game Store'),
	('Best_Buy', 'J4yZ!8wV0g', 'Game Store'),
	('Walmart', 'F7nD2zQ#6K', 'Game Store'),
	('Battle.net', 'Y8qP3gR9zH', 'Game Store'),
	('Rockstar_Games_Store', 'D7cQ!xF3yT', 'Game Store'),
	('Ubisoft_Store', 'P1oQ2gR9zU', 'Game Store'),
	('CD_Projekt_Red', 'S8iT4yJ3Wz', 'Game Store'),
	('Discord_Store', 'V6hF1eJ9qN', 'Game Store'),

	('Nintendo', 'A9s3l!oP2r', 'Game Publisher'),
	('Sony_Interactive', 'X1dV5#yM3p', 'Game Publisher'),
	('Microsoft_Studios', 'B7vZ9kT2aQ', 'Game Publisher'),
	('Electronic_Arts', 'P8wB2rI5nK', 'Game Publisher'),
	('Ubisoft', 'Q6jC4#zM9h', 'Game Publisher'),
	('Square_Enix', 'L2vP1zF7yB', 'Game Publisher'),
	('Bethesda', 'U9dK4rJ2wX', 'Game Publisher'),
	('Activision', 'W3mN0vX5pT', 'Game Publisher'),
	('Rockstar_Games', 'J8tF4kL9wZ', 'Game Publisher'),
	('Bandai_Namco', 'A0pQ3wG1tY', 'Game Publisher'),
	('Take-Two', 'N5xC2zH8lB', 'Game Publisher'),
	('CD_Projekt', 'P9tV4fJ3Wm', 'Game Publisher'),
	('Capcom', 'S7jZ2oA9qB', 'Game Publisher'),
	('Konami', 'D3yQ8rL1uF', 'Game Publisher'),
	('Sega', 'V0iS2bF9jX', 'Game Publisher'),
	('FromSoftware', 'Q5wZ8yP3mJ', 'Game Publisher'),
	('GearBox', 'L4bJ1mO9xY', 'Game Publisher'),
	('Insomniac Games', 'M8pV3rZ2tF', 'Game Publisher'),
	('Naughty_Dog', 'T9nB5wP0uS', 'Game Publisher'),
	('Valve', 'I0dJ2fM6oQ', 'Game Publisher'),
	('THQ_Nordic', 'N6yZ5tP1xA', 'Game Publisher'),
	('FiveHundredFive_Games', 'L7jQ9pV2rB', 'Game Publisher'),
	('Doksh', 'Doksh1234_', 'Admin');

	INSERT INTO Plays VALUES
	('Fortnite', 'OmarReda', NULL, NULL, NULL),
	('Apex Legends', 'OmarReda', NULL, NULL, NULL),
	('FIFA 23', 'OmarReda', NULL, NULL, NULL),
	('FIFA 22', 'OmarReda', NULL, NULL, NULL);

	INSERT INTO Enroll VALUES
	('OmarReda', 'FIFAe World Cup'),
	('OmarReda', 'Tekken World Tour'),
	('OmarReda', 'DreamHack');