CREATE DATABASE HospitalDB;
Use HospitalDB;

CREATE TABLE Department(
	DepartmentID INT PRIMARY KEY Identity(1,1),
	DepartmentName VARCHAR(40));


CREATE TABLE Staff(
	ID INT PRIMARY KEY Identity(1,1),
	"Name" VARCHAR(40) NOT NULL,
	Position VARCHAR(20) NOT NULL,
	Department INT NOT NULL FOREIGN KEY REFERENCES Department(DepartmentID));




CREATE TABLE Patients(
	ID INT PRIMARY KEY Identity(1,1),
	"Name" VARCHAR(40) NOT NULL,
	Age int NOT NULL,
	City VARCHAR(20),
	Department INT NOT NULL FOREIGN KEY REFERENCES Department(DepartmentID),
	);


CREATE TABLE Treatment(
	ID INT PRIMARY KEY IDENTITY(1,1),
	PatientID INT NOT NULL FOREIGN KEY REFERENCES Patients(ID),
	StaffID INT NOT NULL FOREIGN KEY REFERENCES Staff(ID),
	TreatmentName VARCHAR(50));



CREATE TABLE DrugAllotment(
	ID INT PRIMARY KEY IDENTITY(1,1),
	PatientID INT FOREIGN KEY REFERENCES Patients(ID),
	DrugName VARCHAR(20),
	Morning Binary,
	Afternoon Binary,
	Evenning Binary,
	Night Binary);


CREATE VIEW VPatientsTreatment
AS 
SELECT P.ID AS PatientID,
		P.Name AS PatientName,
		P.Age AS PatientAge,
		P.City AS PatientCity,
		S.ID AS StaffID,
		S.Name AS StaffName,
		D.DepartmentName AS Department,
		T.TreatmentName AS Treatment
FROM Patients AS P
INNER JOIN Treatment AS T
ON P.ID = T.PatientID
INNER JOIN Staff AS S
ON T.StaffID = S.ID
INNER JOIN Department AS D
ON S.Department = D.DepartmentID;


CREATE VIEW VStaffDepartment
AS 
SELECT S.ID AS StaffID, 
	   S.Name AS "Name", 
	   S.Position AS Position,
	   D.DepartmentName AS Department
FROM Staff AS S
INNER JOIN Department AS D
ON S.Department = D.DepartmentID;



--Create Table AppUser(
--AppUserId Int Identity(1,1) PRIMARY KEY,
--FirstName VARCHAR(30) Not null,
--LastName VARCHAR(30) Not null,
--UserName VARCHAR(30) Not null,
--Email VARCHAR(50) Not null,
--"Password" VARCHAR(20) Not null,
--UserRole VARCHAR(15) Not null,
--CreatedDate DateTime Default(GetDate()) Not Null)
--GO

--Insert Into UserInfo(FirstName, LastName, UserName, Email, Password) 
--Values ('Inventory', 'Admin', 'InventoryAdmin', 'InventoryAdmin@abc.com', '$admin@2017')


Alter table UserInfo
ADD  UserRole Varchar(15)