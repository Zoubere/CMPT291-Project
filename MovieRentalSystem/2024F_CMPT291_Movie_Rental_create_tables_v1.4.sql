USE [Movie Rental System];

--
-- Clean up DB schema
--

DROP SEQUENCE IF EXISTS Movie_MovieID_Seq;

DROP TABLE IF EXISTS ActorRate;
DROP TABLE IF EXISTS RentalRecord;
DROP TABLE IF EXISTS ActorAppear;
DROP TABLE IF EXISTS Actor;
DROP TABLE IF EXISTS CustomerQueue;
DROP TABLE IF EXISTS Movie;
DROP TABLE IF EXISTS CustomerPhone;
DROP TABLE IF EXISTS Customer;
DROP TABLE IF EXISTS EmployeePhone;
DROP TABLE IF EXISTS Employee;



--
-- Create tables
-- https://www.w3schools.com/sql/sql_create_db.asp
-- https://learn.microsoft.com/en-us/sql/t-sql/data-types/data-types-transact-sql?view=sql-server-ver16
-- https://learn.microsoft.com/en-us/sql/relational-databases/tables/unique-constraints-and-check-constraints?view=sql-server-ver16
--


CREATE TABLE Employee (
EmployeeID INT IDENTITY(1,1),
SSN NCHAR(9) NOT NULL,
LastName VARCHAR(40) NOT NULL,
FirstName VARCHAR(40) NOT NULL,
Address VARCHAR(40),
City VARCHAR(40),
Province NCHAR(2),
PostalCode NCHAR(6),
StartDate DATE NOT NULL,
Username NVARCHAR(50) NOT NULL UNIQUE,
Password NVARCHAR(50) NOT NULL,
PRIMARY KEY( EmployeeID )
);

CREATE TABLE EmployeePhone (
EmployeeID INT NOT NULL,
PhoneNum NCHAR(10) NOT NULL,
PhoneType VARCHAR(10) NOT NULL,
StartTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
EndTime DATETIME,
PRIMARY KEY( EmployeeID, PhoneNum, StartTime ),
FOREIGN KEY ( EmployeeID ) REFERENCES Employee( EmployeeID ),
CONSTRAINT EmpPhonePeriod CHECK (StartTime < EndTime)
);

-- Insert sample employees
INSERT INTO Employee (SSN, LastName, FirstName, Address, City, Province, PostalCode, StartDate, Username, Password)
VALUES 
('123456789', 'Doe', 'John', '123 Main St', 'Edmonton', 'AB', 'T6G1A1', '2020-01-01', 'admin', 'password123'),
('987654321', 'Smith', 'Jane', '456 Elm St', 'Edmonton', 'AB', 'T6G1A2', '2021-03-15', 'jane.smith', 'jane.smith');


CREATE TABLE Customer (
CustomerID INT IDENTITY(1,1),
SSN NCHAR(9) NOT NULL,
LastName VARCHAR(40) NOT NULL,
FirstName VARCHAR(40) NOT NULL,
Address VARCHAR(40),
City VARCHAR(40),
Province NCHAR(2),
PostalCode NCHAR(6),
Email VARCHAR(40) NOT NULL,
AccountNum NCHAR(10) NOT NULL,
CreditCardNum NCHAR(16) NOT NULL,
CreditCardExp NCHAR(4) NOT NULL,
CreditCardCvv NCHAR(3) NOT NULL,
CreationDate DATE NOT NULL DEFAULT CURRENT_TIMESTAMP,
PRIMARY KEY( CustomerID )
);

CREATE TABLE CustomerPhone (
CustomerID INT NOT NULL,
PhoneNum NCHAR(10) NOT NULL,
PhoneType VARCHAR(10) NOT NULL,
StartTime DATETIME NOT NULL DEFAULT(getdate()),
EndTime DATETIME,
PRIMARY KEY( CustomerID, PhoneNum, StartTime ),
FOREIGN KEY ( CustomerID ) REFERENCES Customer( CustomerID ),
CONSTRAINT CustPhonePeriod CHECK (StartTime < EndTime)
);


CREATE TABLE Movie (
MovieID INT NOT NULL,
MovieName VARCHAR(40) NOT NULL,
MovieType VARCHAR(10) NOT NULL
	CHECK( MovieType='Comedy' or MovieType='Drama' or MovieType='Action' or MovieType='Foreign' ),
Fee NUMERIC(6,2) NOT NULL,
NumOfCopy INT NOT NULL,
PRIMARY KEY( MovieID )
);

CREATE SEQUENCE Movie_MovieID_Seq START WITH 1000 INCREMENT BY 1;


CREATE TABLE CustomerQueue (
CustomerID INT NOT NULL,
MovieID INT NOT NULL,
SortNum INT NOT NULL,
PRIMARY KEY ( CustomerID, MovieID ),
UNIQUE ( CustomerID, MovieID, SortNum ),
FOREIGN KEY ( CustomerID ) REFERENCES Customer( CustomerID ),
FOREIGN KEY ( MovieID ) REFERENCES Movie( MovieID )
);



CREATE TABLE Actor (
ActorID INT IDENTITY(1,1),
Name VARCHAR(100) NOT NULL,
Gender NCHAR(1) NOT NULL CHECK( Gender='M' or Gender='F' ),
DateOfBrith Date NOT NULL,
PRIMARY KEY( ActorID )
);

CREATE TABLE ActorAppear (
MovieID INT NOT NULL,
ActorID INT NOT NULL,
PRIMARY KEY ( MovieID, ActorID ),
FOREIGN KEY ( MovieID ) REFERENCES Movie( MovieID ),
FOREIGN KEY ( ActorID ) REFERENCES Actor( ActorID )
);



CREATE TABLE RentalRecord (
RentalRecordID INT IDENTITY(1,1),
EmployeeID INT NOT NULL,
CustomerID INT NOT NULL,
MovieID INT NOT NULL,
CheckoutTime DATETIME NOT NULL DEFAULT(getdate()),
ReturnTime DATETIME,
MovieRate INT,
PRIMARY KEY( RentalRecordID ),
FOREIGN KEY ( EmployeeID ) REFERENCES Employee( EmployeeID ),
FOREIGN KEY ( CustomerID ) REFERENCES Customer( CustomerID ),
FOREIGN KEY ( MovieID ) REFERENCES Movie( MovieID )
);


CREATE TABLE ActorRate (
RentalRecordID INT NOT NULL,
ActorID INT NOT Null,
ActorRate INT,
FOREIGN KEY ( RentalRecordID ) REFERENCES RentalRecord( RentalRecordID ),
FOREIGN KEY ( ActorID ) REFERENCES Actor( ActorID )
);




