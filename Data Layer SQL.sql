CREATE DATABASE DemoDB;

CREATE TABLE DemoDB.[dbo].[tblTitle](
	EmployeeID int IDENTITY(1,1) NOT NULL,
	Title varchar(50) NOT NULL DEFAULT (''),
	CONSTRAINT [PK_tblTitle] PRIMARY KEY CLUSTERED (EmployeeID),
);

CREATE TABLE DemoDB.[dbo].[tblContact](
	ContactID int IDENTITY(1,1) NOT NULL,
	FirstName varchar(50) NOT NULL DEFAULT (''),
	LastName varchar(50) NOT NULL DEFAULT (''),
	EmployeeID int NOT NULL DEFAULT (0),
	ModifiedOn date NOT NULL DEFAULT GETDATE(),
 CONSTRAINT [PK_tblContact] PRIMARY KEY CLUSTERED (ContactID),
 CONSTRAINT [FK_tblContact] FOREIGN KEY (EmployeeID)
	REFERENCES dbo.tblTitle (EmployeeID)
	ON DELETE CASCADE    
	ON UPDATE CASCADE  
);

INSERT INTO DemoDB.dbo.tblTitle (Title)
VALUES ('Developer'), ('Manager'), ('CEO') 

INSERT INTO DemoDB.dbo.tblContact (FirstName, LastName, EmployeeID)
VALUES ('Test', 'Test', 3), ('John', 'Doe', 2), ('Jane', 'Doe', 2)

DELETE FROM DemoDB.dbo.tblTitle
WHERE EmployeeID = 2
