	

	CREATE TABLE GameEngine(
	EngineName CHAR(20) ,
	Language VARCHAR(20) NOT NULL ,
	Platform CHAR(20) NOT NULL ,
	PRIMARY KEY(EngineName)
	);

	GO

	CREATE TABLE Manufacturer (
	ManufacturerName CHAR(30),
	Country CHAR(20) NULL,
	PRIMARY KEY(ManufacturerName)

	);

	GO

	CREATE TABLE Tournament(
	TName CHAR(20),
	Capacity INT NOT NULL,
	PrizeMoney DECIMAL(7,2) ,
	TournamentType	VARCHAR(20) NOT NULL CHECK (TournamentType IN ('Sports' , 'Racing' , 'Fighting', 'Battle Royale' , 'FPS' ) ) ,
	TLocation	CHAR(20) NOT NULL,
	BeginDate	DATE ,
	Organizer	varchar(30),
	PRIMARY KEY(TName) ,
	FOREIGN KEY (Organizer) REFERENCES GamingStore(StoreName)
		ON DELETE CASCADE
		ON UPDATE CASCADE
	);

	GO

	CREATE TABLE GameReviewer(
    ReviewerName varchar(30),
    ReviewerURL text NOT NULL,
    LaunchDate date,
    PRIMARY KEY (ReviewerName),

	);

	GO

	CREATE TABLE Award(
	AwardName CHAR(20) NOT NULL,
	Genre CHAR(20) NOT NULL,
	Reward CHAR(20) ,
	Won	CHAR(20) ,
	YearWon	INT ,
	FOREIGN KEY (Reward) REFERENCES GameReviewer(ReviewerName)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	FOREIGN KEY (Won) REFERENCES Game(GameName)
		ON DELETE CASCADE 
		ON UPDATE CASCADE

	);

	GO

	CREATE TABLE Console(
	ConsoleName	CHAR(20) ,
	ReleaseDate	DATE NOT NULL,
	Develop CHAR(30) ,
	FOREIGN KEY (Develop) REFERENCES Manufacturer (ManufacturerName)
		ON DELETE SET NULL
		ON UPDATE CASCADE
	);

	GO

	CREATE TABLE GamePublisher(
    PublisherName varchar(30),
    Country char(30) NOT NULL,
    ConsoleType varchar(30) NOT NULL,
    StartDate date,
    PRIMARY KEY (PublisherName)
	);

	GO

	CREATE TABLE GamingStore
	(
		StoreName varchar(30),
		Rating int not null CHECK (Rating Between 1 AND 5),
		Hotline int not null ,
		PRIMARY KEY (StoreName)
	);

	GO

	CREATE TABLE Gamer(
	GamerID		INT,
	UserName	VARCHAR(20) NOT NULL,
	Country		CHAR(20)	NOT NULL,
	BirthDate	DATE,

	PRIMARY KEY(GamerID)
	);

	GO

	CREATE TABLE Game(
    GameName varchar(50),
    Genre varchar(30) not null check (Genre IN ('Sports', 'Racing', 'Fighting', 'Battle Royale', 'FPS')),
    ReleaseDate date,
    ConsoleName char(20),
    EngineName char(20),
    Publisher char(20),
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
        ON DELETE SET NULL,
	);

	GO

	CREATE TABLE Inventory(
	GameName	CHAR(20),
	StoreName varchar(30),
	Price	Decimal(3,2) NOT NULL,
	PRIMARY KEY(GameName,StoreName),
	FOREIGN KEY (Gamename) REFERENCES Game(GameName)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	FOREIGN KEY (StoreName) REFERENCES GamingStore(StoreName)
		ON DELETE CASCADE
		ON UPDATE CASCADE
	);

	GO

	CREATE TABLE Plays(
	GameName	CHAR(20),
	GamerID		INT,
	CompletionStatus		CHAR(3) CHECK(CompletionStatus IN ('Yes','No')),
	Difficulty	CHAR(6) CHECK(Difficulty IN('Hard' , 'Medium' , 'Easy')) NOT NULL,
	UserRating INT CHECK(UserRating Between 1 AND 5),
	PRIMARY KEY(GameName,GamerID),
	FOREIGN KEY (Gamename) REFERENCES Game(GameName)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	FOREIGN KEY (GamerID) REFERENCES Gamer(GamerID)
		ON DELETE CASCADE
		ON UPDATE CASCADE
	);

	GO

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