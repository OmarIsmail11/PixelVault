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