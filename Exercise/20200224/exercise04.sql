--Name: Kaiyuan Wang
--Date: 20200224
--File: exercise03

USE TSQLV4;
GO
--1
DROP TABLE IF EXISTS dbo.presidents;
CREATE TABLE dbo.presidents
	(
	id						VARCHAR(50) NOT NULL,
	lastname				VARCHAR(50) NOT NULL,
	firstname				VARCHAR(50) NOT NULL,
	middlename				VARCHAR(50),
	orderofpresidency		VARCHAR(50) NOT NULL,
	dateofbirth				VARCHAR(50) NOT NULL,
	dateofdeath				VARCHAR(50) NOT NULL,
	townorcountyofbirth		VARCHAR(50) NOT NULL,
	stateofbirth			VARCHAR(50) NOT NULL,
	homestate				VARCHAR(50) NOT NULL,
	partyaffiliation		VARCHAR(50) NOT NULL,
	datetookoffice			VARCHAR(50) NOT NULL,
	dateleftoffice			VARCHAR(50) NOT NULL,
	assassinationattempt	VARCHAR(50) NOT NULL,
	assassinated			VARCHAR(50) NOT NULL,
	religiousaffiliation	VARCHAR(50) NOT NULL,
	imagepath				VARCHAR(50) NOT NULL,
	);
GO
--2
BULK INSERT dbo.presidents FROM 'C:\Users\Five\MSSA\Exercise\20200224\presidents.csv'
	WITH
	(
	DATAFILETYPE	= 'char',
	FIELDTERMINATOR	= ',',
	ROWTERMINATOR	= '\n'
	);
--3
ALTER TABLE dbo.presidents
DROP COLUMN imagepath;
--4
DELETE FROM dbo.presidents
OUTPUT deleted.*
WHERE id = 'ID';
ALTER TABLE	dbo.presidents
ADD integercolumn INT NOT NULL IDENTITY(1, 1) CONSTRAINT pk PRIMARY KEY;
--5
UPDATE dbo.presidents
SET dateleftoffice = '1/20/2017',
	assassinationattempt = 'false',
	assassinated = 'false'
OUTPUT inserted.dateleftoffice, inserted.assassinationattempt, inserted.assassinated
WHERE id = '44';
--6
INSERT INTO dbo.presidents
	(
	id,
	lastname,
	firstname,
	middlename,
	orderofpresidency,
	dateofbirth,
	dateofdeath,
	townorcountyofbirth,
	stateofbirth,
	homestate,
	partyaffiliation,
	datetookoffice,
	dateleftoffice,
	assassinationattempt,
	assassinated,
	religiousaffiliation
	)
OUTPUT inserted.id, 
	   inserted.lastname,
	   inserted.firstname,
	   inserted.middlename,
	   inserted.orderofpresidency, 
	   inserted.dateofbirth, 
	   inserted.dateofdeath, 
	   inserted.townorcountyofbirth,
	   inserted.stateofbirth,
	   inserted.homestate,
	   inserted.partyaffiliation,
	   inserted.datetookoffice,
	   inserted.dateleftoffice,
	   inserted.assassinationattempt,
	   inserted.assassinated,
	   inserted.religiousaffiliation
VALUES
	(
	'45',
	'Trump',
	'Donald',
	'John',
	'45',
	'6/14/1946',
	'',
	'Queens',
	'New York',
	'New York',
	'Republican',
	'1/20/2017',
	'1/20/2021',
	'false',
	'false',
	'Presbyterian'
	);
--7
SELECT homestate,
	SUM(CASE WHEN partyaffiliation = 'Democratic'									THEN qty END) AS D,
	SUM(CASE WHEN partyaffiliation = 'Democratic-Republican'						THEN qty END) AS DR,
	SUM(CASE WHEN partyaffiliation = 'Democratic-Republican/National Republican'	THEN qty END) AS DRNR,
	SUM(CASE WHEN partyaffiliation = 'Democratic/National Union'					THEN qty END) AS DNU,
	SUM(CASE WHEN partyaffiliation = 'Federalist'									THEN qty END) AS F,
	SUM(CASE WHEN partyaffiliation = 'Independent'									THEN qty END) AS I,
	SUM(CASE WHEN partyaffiliation = 'Republican'									THEN qty END) AS R,
	SUM(CASE WHEN partyaffiliation = 'Republican/National Union'					THEN qty END) AS RNU,
	SUM(CASE WHEN partyaffiliation = 'Whig'											THEN qty END) AS W
FROM
(
	SELECT homestate, partyaffiliation, COUNT(DISTINCT id) AS qty 
	FROM dbo.presidents 
	GROUP BY homestate, partyaffiliation
) AS summary
GROUP BY homestate;
--8
SELECT lastname, firstname, DATEDIFF(DAY, datetookoffice, dateleftoffice) AS daysinoffice FROM dbo.presidents;
--9
SELECT lastname, firstname, DATEDIFF(YEAR, dateofbirth, datetookoffice) AS agetookoffice FROM dbo.presidents;
--10
SELECT partyaffiliation,
	SUM(CASE WHEN partyaffiliation = 'Democratic'									THEN amount END) AS D,
	SUM(CASE WHEN partyaffiliation = 'Democratic-Republican'						THEN amount END) AS DR,
	SUM(CASE WHEN partyaffiliation = 'Democratic-Republican/National Republican'	THEN amount END) AS DRNR,
	SUM(CASE WHEN partyaffiliation = 'Democratic/National Union'					THEN amount END) AS DNU,
	SUM(CASE WHEN partyaffiliation = 'Federalist'									THEN amount END) AS F,
	SUM(CASE WHEN partyaffiliation = 'Independent'									THEN amount END) AS I,
	SUM(CASE WHEN partyaffiliation = 'Republican'									THEN amount END) AS R,
	SUM(CASE WHEN partyaffiliation = 'Republican/National Union'					THEN amount END) AS RNU,
	SUM(CASE WHEN partyaffiliation = 'Whig'											THEN amount END) AS W
FROM
(
	SELECT partyaffiliation, religiousaffiliation, COUNT(DISTINCT id) as amount 
	FROM dbo.presidents 
	GROUP BY partyaffiliation, religiousaffiliation
) AS report
GROUP BY partyaffiliation;
