	

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
	PRIMARY KEY(TName)

	);

	GO

	CREATE TABLE GameReviewer(
    ReviewerName varchar(30),
    ReviewerURL text NOT NULL,
    LaunchDate date,
    PRIMARY KEY (Name),

	);

	GO

	CREATE TABLE Award(
	AwardName CHAR(20) NOT NULL,
	Genre CHAR(20) NOT NULL,
	Reward CHAR(20) ,
	FOREIGN KEY (Reward) REFERENCES GameReviewer
		ON DELETE CASCADE
		ON UPDATE CASCADE

	);

	GO

	CREATE TABLE Console(
	ConsoleName	CHAR(20) ,
	ReleaseDate	DATE NOT NULL,
	Develop CHAR(30) ,
	FOREIGN KEY (Develop) REFERENCES Manufacturer
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