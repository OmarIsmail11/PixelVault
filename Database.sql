	
	CREATE DATABASE Pixel_Vault
	USE Pixel_Vault

	CREATE TABLE GameEngine(
	EngineName CHAR(20) ,
	Language VARCHAR(20) NOT NULL ,
	Platform CHAR(20) NOT NULL ,
	PRIMARY KEY(EngineName)
	);

	

	CREATE TABLE Manufacturer (
	ManufacturerName CHAR(30),
	Country CHAR(20) NULL,
	PRIMARY KEY(ManufacturerName)

	);


	CREATE TABLE GameReviewer(
    ReviewerName varchar(30),
    ReviewerURL text NOT NULL,
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
    PublisherName varchar(30),
    Country char(30) NOT NULL,
    ConsoleType varchar(30) NOT NULL,
    StartDate date,
    PRIMARY KEY (PublisherName)
	);



	CREATE TABLE GamingStore
	(
		StoreName varchar(30),
		Rating int not null CHECK (Rating Between 1 AND 5),
		Hotline int not null ,
		PRIMARY KEY (StoreName)
	);

		CREATE TABLE Tournament(
	TName CHAR(20),
	Capacity INT NOT NULL,
	TournamentType	VARCHAR(20) NOT NULL CHECK (TournamentType IN ('Sports' , 'Racing' , 'Fighting', 'Battle Royale' , 'FPS' ) ) ,
	TLocation	CHAR(20) NOT NULL,
	BeginDate	DATE ,
	Organizer	varchar(30),
	PrizeMoney DECIMAL(10,2),
	PRIMARY KEY(TName) ,
	FOREIGN KEY (Organizer) REFERENCES GamingStore(StoreName)
		ON DELETE CASCADE
		ON UPDATE CASCADE
	);

	

	CREATE TABLE Gamer(
	GamerID		INT,
	UserName	VARCHAR(20) NOT NULL,
	Country		CHAR(20)	NOT NULL,
	BirthDate	DATE,

	PRIMARY KEY(GamerID)
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
    foreign key (Publisher) references GamePublisher(PublisherName)
        ON UPDATE CASCADE
        ON DELETE SET NULL,
    foreign key (Reviewer) references GameReviewer(ReviewerName)
        ON UPDATE CASCADE
        ON DELETE SET NULL
	);

	CREATE TABLE Award(
	AwardName CHAR(20) NOT NULL,
	Genre CHAR(20) NOT NULL,
	Reviewer VARCHAR(30) ,
	Won	VARCHAR(50) ,
	YearWon	INT ,
	PRIMARY KEY (AwardName),
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
	FOREIGN KEY (StoreName) REFERENCES GamingStore(StoreName)
		ON DELETE CASCADE
		ON UPDATE CASCADE
	);

	

	CREATE TABLE Plays(
	GameName	VARCHAR(50),
	GamerID		INT,
	CompletionStatus		CHAR(3) CHECK(CompletionStatus IN ('Yes','No')),
	Difficulty	CHAR(6) CHECK(Difficulty IN('Hard' , 'Medium' , 'Easy')) NOT NULL,
	UserRating INT CHECK(UserRating Between 1 AND 5),
	PRIMARY KEY(GameName,GamerID),
	FOREIGN KEY (GameName) REFERENCES Game(GameName)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	FOREIGN KEY (GamerID) REFERENCES Gamer(GamerID)
		ON DELETE CASCADE
		ON UPDATE CASCADE
	);

	

	CREATE TABLE Enroll(
	GamerID INT,
	TName CHAR(20),
	Ranking INT DEFAULT 0,
	PRIMARY KEY(GamerID,TName),
	FOREIGN KEY (GamerID) REFERENCES Gamer(GamerID)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	FOREIGN KEY(TName) REFERENCES Tournament(TName)
		ON DELETE CASCADE
		ON UPDATE CASCADE
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
	('Corona', 'Lua', 'Mobile');


	INSERT INTO Manufacturer VALUES
	('Sony', 'Japan'),
	('Microsoft', 'USA'),
	('Nintendo', 'Japan'),
	('Sega', 'Japan'),
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
	('CD Projekt', 'Poland');


	INSERT INTO GameReviewer VALUES
	('IGN', 'https://www.ign.com', '1996-01-01'),
	('GameSpot', 'https://www.gamespot.com', '1996-05-01'),
	('Metacritic', 'https://www.metacritic.com', '1999-08-01'),
	('PC Gamer', 'https://www.pcgamer.com', '1993-11-01'),
	('Kotaku', 'https://www.kotaku.com', '2004-01-01'),
	('Polygon', 'https://www.polygon.com', '2012-10-01'),
	('Eurogamer', 'https://www.eurogamer.net', '1999-09-01'),
	('Game Informer', 'https://www.gameinformer.com', '1991-08-01'),
	('Destructoid', 'https://www.destructoid.com', '2006-01-01'),
	('VentureBeat', 'https://www.venturebeat.com', '2008-06-01'),
	('RockPaperShotgun', 'https://www.rockpapershotgun.com', '2007-07-01'),
	('The Escapist', 'https://www.escapistmagazine.com', '2005-07-01'),
	('Joystiq', 'https://www.joystiq.com', '2004-01-01'),
	('Giant Bomb', 'https://www.giantbomb.com', '2008-07-01'),
	('Game Rant', 'https://gamerant.com', '2010-03-01');


	INSERT INTO Console VALUES
	('PlayStation', '1994-12-03', 'Sony'),
	('Xbox', '2001-11-15', 'Microsoft'),
	('Switch', '2017-03-03', 'Nintendo'),
	('Genesis', '1988-10-29', 'Sega'),
	('Atari 2600', '1977-09-11', 'Atari'),
	('GameCube', '2001-09-14', 'Nintendo'),
	('Dreamcast', '1999-09-09', 'Sega'),
	('PSP', '2004-12-12', 'Sony'),
	('Xbox 360', '2005-11-22', 'Microsoft'),
	('Wii', '2006-11-19', 'Nintendo'),
	('PlayStation 3', '2006-11-11', 'Sony'),
	('Xbox One', '2013-11-22', 'Microsoft'),
	('PlayStation 5', '2020-11-12', 'Sony'),
	('Xbox Series X', '2020-11-10', 'Microsoft'),
	('Nintendo DS', '2004-11-21', 'Nintendo');


	INSERT INTO GamePublisher VALUES
	('Nintendo', 'Japan', 'Switch', '1983-07-01'),
	('Sony Interactive', 'Japan', 'PlayStation', '1993-11-16'),
	('Microsoft Studios', 'USA', 'Xbox', '2002-03-01'),
	('Electronic Arts', 'USA', 'Cross-Platform', '1982-05-28'),
	('Ubisoft', 'France', 'Cross-Platform', '1986-03-28'),
	('Square Enix', 'Japan', 'PlayStation', '2003-04-01'),
	('Bethesda', 'USA', 'Cross-Platform', '1986-06-28'),
	('Activision', 'USA', 'Cross-Platform', '1979-10-01'),
	('Rockstar Games', 'USA', 'Cross-Platform', '1998-12-01'),
	('Bandai Namco', 'Japan', 'PlayStation', '1955-06-01'),
	('Take-Two', 'USA', 'Cross-Platform', '1993-09-30'),
	('CD Projekt', 'Poland', 'PC', '1994-05-01'),
	('Capcom', 'Japan', 'PlayStation', '1979-05-30'),
	('Konami', 'Japan', 'PlayStation', '1969-03-21'),
	('Sega', 'Japan', 'Genesis', '1940-06-03');


	INSERT INTO GamingStore VALUES
	('Steam', 5, 1800123456),
	('Epic Games Store', 4, 1800123457),
	('GOG', 5, 1800123458),
	('PlayStation Store', 5, 1800123459),
	('Microsoft Store', 4, 1800123460),
	('Nintendo eShop', 4, 1800123461),
	('Origin', 3, 1800123462),
	('Uplay', 3, 1800123463),
	('Itch.io', 5, 1800123464),
	('Green Man Gaming', 4, 1800123465),
	('Humble Bundle', 5, 1800123466),
	('Fanatical', 4, 1800123467),
	('GameStop', 3, 1800123468),
	('Best Buy', 4, 1800123469),
	('Walmart', 3, 1800123470);


	INSERT INTO Gamer VALUES
	(1, 'PlayerOne', 'USA', '1990-01-01'),
	(2, 'NoobMaster', 'Canada', '1995-06-15'),
	(3, 'ProGamer', 'Japan', '2000-09-25'),
	(4, 'GameWizard', 'India', '1985-03-12'),
	(5, 'Speedster', 'UK', '1992-12-05'),
	(6, 'BattleKing', 'Germany', '1998-07-18'),
	(7, 'FPSLord', 'France', '1987-04-30'),
	(8, 'RacerX', 'Italy', '1993-10-20'),
	(9, 'FighterGirl', 'Australia', '1997-02-11'),
	(10, 'StealthNinja', 'China', '2002-05-22'),
	(11, 'TankMaster', 'Russia', '1990-08-09'),
	(12, 'CasualJoe', 'USA', '1980-09-14'),
	(13, 'ArcadePro', 'South Korea', '1999-01-03'),
	(14, 'VRKing', 'Brazil', '1996-11-06'),
	(15, 'PuzzleMaster', 'Sweden', '1993-03-30');

	INSERT INTO Game VALUES
	('FIFA 23', 'Sports', '2022-09-30', 'PlayStation 5', 'Frostbite', 'Electronic Arts', 4, 'Polygon'),
	('Need for Speed Heat', 'Racing', '2019-11-08', 'Xbox Series X', 'Frostbite', 'Electronic Arts', 4, 'GameSpot'),
	('Street Fighter V', 'Fighting', '2016-02-16', 'PlayStation 5', 'Unreal', 'Capcom', 5, 'Kotaku'),
	('Overwatch', 'FPS', '2016-05-24', 'PlayStation 3', 'RAGE', 'Activision', 5, 'IGN'),
	('Call of Duty: Modern Warfare', 'FPS', '2019-10-25', 'Xbox Series X', 'Havok', 'Activision', 4, 'Metacritic'),
	('Fortnite', 'Battle Royale', '2017-07-25', 'Nintendo DS', 'Unreal', 'Capcom', 4, 'Eurogamer'),
	('Apex Legends', 'Battle Royale', '2019-02-04', 'PlayStation 5', 'Source', 'Electronic Arts', 5, 'Polygon'),
	('Gran Turismo 7', 'Racing', '2022-03-04', 'PlayStation 5', 'RenPy', 'Sony Interactive', 5, 'Game Informer'),
	('Rocket League', 'Sports', '2015-07-07', 'PlayStation 3', 'Unreal', 'CD Projekt', 5, 'Joystiq'),
	('Halo Infinite', 'FPS', '2021-12-08', 'Xbox Series X', 'CryEngine', 'Microsoft Studios', 4, 'Destructoid'),
	('PUBG', 'Battle Royale', '2017-12-20', 'Xbox One', 'Unreal', 'Capcom', 3, 'PC Gamer'),
	('Forza Horizon 5', 'Racing', '2021-11-09', 'Xbox Series X', 'Construct', 'Square Enix', 5, 'Polygon'),
	('Tekken 7', 'Fighting', '2015-03-18', 'PlayStation 3', 'Unreal', 'Ubisoft', 4, 'The Escapist'),
	('Valorant', 'FPS', '2020-06-02', 'PlayStation 3', 'Unreal', 'Bethesda', 5, 'VentureBeat'),
	('CS:GO', 'FPS', '2012-08-21', 'Xbox One', 'Godot', 'Take-Two', 5, 'RockPaperShotgun');




	INSERT INTO Tournament VALUES
	('EVO', 500, 'Fighting', 'Las Vegas', '2023-07-07', 'Steam', 250000.00),
	('ESL Pro League', 1000, 'FPS', 'Katowice', '2023-02-01', 'Epic Games Store', 1000000.00),
	('The International', 500, 'Battle Royale', 'Seattle', '2023-10-15', 'Steam', 50000000.00),
	('DreamHack', 800, 'FPS', 'Stockholm', '2023-06-15', 'GOG', 500000.00),
	('PAX', 400, 'Sports', 'Boston', '2023-03-01', 'PlayStation Store', 100000.00),
	('Capcom Cup', 250, 'Fighting', 'Tokyo', '2023-12-05', 'Microsoft Store', 300000.00),
	('Fortnite World Cup', 500, 'Battle Royale', 'New York', '2023-07-01', 'Nintendo eShop', 3000000.00),
	('Overwatch League', 300, 'FPS', 'Los Angeles', '2023-05-15', 'Origin', 500000.00),
	('RLCS', 600, 'Racing', 'San Francisco', '2023-08-20', 'Uplay', 200000.00),
	('FIFAe World Cup', 128, 'Sports', 'London', '2023-07-15', 'Itch.io', 500000.00),
	('CS:GO Major', 1000, 'FPS', 'Berlin', '2023-11-05', 'Green Man Gaming', 2000000.00),
	('Call of Duty League', 400, 'FPS', 'Dallas', '2023-09-20', 'Humble Bundle', 1500000.00),
	('Halo Championship', 300, 'FPS', 'Chicago', '2023-10-10', 'Fanatical', 400000.00),
	('Tekken World Tour', 150, 'Fighting', 'Seoul', '2023-11-25', 'GameStop', 200000.00),
	('Gran Turismo Cup', 128, 'Racing', 'Paris', '2023-12-12', 'Best Buy', 300000.00);