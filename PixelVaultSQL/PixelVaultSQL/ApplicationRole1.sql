/*CREATE APPLICATION ROLE [ApplicationRole1]
	WITH PASSWORD = 'xjr{m.zRULisofsqnRTht|crmsFT7_&#$!~<fqqjfeau%iy;'*/


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