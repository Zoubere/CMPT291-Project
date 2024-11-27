USE [Movie Rental System];

--
-- Remove test data
--

DELETE ActorRate;
DELETE RentalRecord;
DELETE ActorAppear;
DELETE Actor;
DELETE CustomerQueue;
DELETE Movie;
DELETE CustomerPhone;
DELETE Customer;
DELETE EmployeePhone;
DELETE Employee;



--
-- Add test data
--

--INSERT INTO <target_table> SELECT <columns> FROM <source_table>
--INSERT INTO table_name (column1, column2, column3, ...)
	--VALUES (value1, value2, value3, ...),
	--	(value1, value2, value3, ...);
--select getDate();


INSERT INTO Employee (SSN, LastName, FirstName, StartDate)
	VALUES ('111222333', 'Smith', 'John', '2024-10-29');

INSERT INTO EmployeePhone (EmployeeID, PhoneNum, PhoneType)
	VALUES( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		'7807654321', 'Home' );


INSERT INTO Movie (MovieID, MovieName, MovieType, Fee, NumOfCopy)
	VALUES( NEXT VALUE FOR Movie_MovieID_Seq, 'Die Hard', 'Action', 3.5, 5);

--INSERT INTO Movie (MovieID, MovieName, MovieType, Fee, NumOfCopy)
--	VALUES( NEXT VALUE FOR Movie_MovieID_Seq, 'Die Hard 2', 'Error', 4.5, 4);

--SELECT * FROM sys.sequences WHERE name = 'Movie_MovieID_Seq';  

--INSERT INTO Movie (MovieID, MovieName, MovieType, Fee, NumOfCopy)
--	VALUES( NEXT VALUE FOR Movie_MovieID_Seq, 'Die Hard 3', 'Action', 5.5, 3);


--SELECT * FROM Employee;
--SELECT * FROM EmployeePhone;
--SELECT * FROM Customer;
--SELECT * FROM CustomerPhone;
--SELECT * FROM Movie;
--SELECT * FROM CustomerQueue;
--SELECT * FROM Actor;
--SELECT * FROM ActorAppear;
--SELECT * FROM RentalRecord;
--SELECT * FROM ActorRate;




