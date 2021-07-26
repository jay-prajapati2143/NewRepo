-- Creating Database named StackOverflow

CREATE DATABASE StackOverFlow
GO

USE StackOverFlow
GO
-- Create Tables

---- Login Details
--CREATE TABLE UserLoginHistory(
--	ID INT PRIMARY KEY IDENTITY(1,1),
--	Email NVARCHAR(50) UNIQUE NOT NULL,

--	CurrentPassword NVARCHAR(20),
--	PreviousPassword NVARCHAR(20),
--	LastLogin DATETIME
--)
--GO

-- Users Information
CREATE TABLE Users(
	UserID INT PRIMARY KEY IDENTITY(1,1),
	UserName VARCHAR(25) NOT NULL,
	FullName VARCHAR(30) NOT NULL,
	Title VARCHAR(20),
	VisitedDays INT,
	GitHub VARCHAR(100),
	Twitter VARCHAR(100),
	Reputaion INT,
	Location VARCHAR(50),
	LastSeen DATETIME,
	ProfileViews INT,
	AboutUser VARCHAR(200),
	PhoneNumber VARCHAR(10),
	EmailID VARCHAR(50) UNIQUE NOT NULL,
	
)
GO
-- Badges details
CREATE TABLE Badges(
	BadgeID INT PRIMARY KEY IDENTITY(1,1),
	BadgeName VARCHAR(30),
	BadgeCategory VARCHAR(30),
	BadgeDescription VARCHAR(200),
	BadgeType VARCHAR(20)
)
GO


-- Badges Eearned By User
CREATE TABLE BadgesEarnedByUser(
	ID INT PRIMARY KEY  IDENTITY(1,1),
	UserID INT,
	BadgeID INT,
	DateOfEarned DATE,
	CONSTRAINT Fk_UserIDBadge FOREIGN KEY(UserID) REFERENCES Users(UserID),
	CONSTRAINT Fk_BadgeIDBadge FOREIGN KEY(BadgeID) REFERENCES Badges(BadgeID)
)
GO


-- User's Educational Details
CREATE TABLE Education(
	ID INT PRIMARY KEY  IDENTITY(1,1),
	UserID INT,
	Degree VARCHAR(30),
	University VARCHAR(50),
	FromYear INT,
	ToYear INT,
	Summary VARCHAR(200),
	CONSTRAINT Fk_UserIDEducation FOREIGN KEY(UserID) REFERENCES Users(UserID)
)
GO
-- Table for Technologies Used As Student
CREATE TABLE TechnologiesUsedAsStudent(
	ID INT PRIMARY KEY  IDENTITY(1,1),
	UserID INT,
	Technology VARCHAR(20),
	CONSTRAINT Fk_UserIDTech FOREIGN KEY(UserID) REFERENCES Users(UserID)

)
GO


-- Work Profile Information
CREATE TABLE WorkExperience(
	ID INT PRIMARY KEY  IDENTITY(1,1),
	UserID INT,
	JobTitle VARCHAR(30),
	CompanyName VARCHAR(30),
	YearOfJoinning int,
	Responsibilities VARCHAR(200),
	CONSTRAINT Fk_UserIDWork FOREIGN KEY(UserID) REFERENCES Users(UserID)
)
GO
-- Technologies Used By User In Job
CREATE TABLE TechnologiesUsedByUserInJob(
	ID INT PRIMARY KEY IDENTITY(1,1),
	UserID INT,
	Technologies VARCHAR(20),
	CONSTRAINT Fk_UserIDTechInJob FOREIGN KEY(UserID) REFERENCES Users(UserID)
)
GO


-- Table of Questions with UserID
CREATE TABLE Questions(
	QuestionID INT PRIMARY KEY IDENTITY(1,1),
	UserID INT,
	QuestionTitle VARCHAR(500),
	QuestionBody VARCHAR(MAX),
	TotalViews INT,
	Vote INT,
	TimeOfAsk DATETIME,
	CONSTRAINT Fk_UserIDQuestion FOREIGN KEY(UserID) REFERENCES Users(UserID)
)
GO


-- Table for Bookmarks
CREATE TABLE Bookmarks(
ID Int primary key Identity(1,1),
UserID INT FOREIGN KEY REFERENCES Users(UserID),
QuestionID INT FOREIGN KEY REFERENCES Questions(QuestionID),
)
GO

--ALTER table Bookmarks
--Add ID Int primary key Identity(1,1)

-- information of Tag of Questions
CREATE TABLE Tags(
	ID INT PRIMARY KEY  IDENTITY(1,1),
	QuestionID INT FOREIGN KEY REFERENCES Questions,
	TagName NVARCHAR(30)
)
GO

-- Table For Answers of Questions
CREATE TABLE Answers(
	AnswerID INT PRIMARY KEY IDENTITY(1,1),
	QuestionID INT FOREIGN KEY REFERENCES Questions,
	UserID INT,
	AnswerBody VARCHAR(MAX),
	Vote INT,
	CONSTRAINT Fk_UserIDAnswers FOREIGN KEY(UserID) REFERENCES Users(UserID)
)
GO






-- FOR JOB APPLY


-- Job Profile Information
CREATE TABLE JobProfile(
	ID INT PRIMARY KEY  IDENTITY(1,1),
	UserID INT FOREIGN KEY REFERENCES Users(UserID),
	JobType VARCHAR(30),
	Role VARCHAR(30),
	JobSearchStatus VARCHAR(50),
	Industry VARCHAR(30),
	MinAnnualSalary MONEY,
	MinExperience INT,
	MaxExperience INT,
)
GO

-- industries are exclude while apply for job
CREATE TABLE IndustriesToExclude(
	ID INT PRIMARY KEY  IDENTITY(1,1),
	UserID INT FOREIGN KEY REFERENCES Users(UserID),
	IndustryToExclude VARCHAR(30)
)
GO

-- technologies which are not prefer to work with
CREATE TABLE TechPreferNotToWorkWith(
	ID INT PRIMARY KEY  IDENTITY(1,1),
	UserID INT FOREIGN KEY REFERENCES Users(UserID),
	TechPeferNotToWorkWith NVARCHAR(30)
)
GO

-- technologies which are prefer to work with
CREATE TABLE TechWantToWorkWith(
	ID INT PRIMARY KEY  IDENTITY(1,1),
	UserID INT FOREIGN KEY REFERENCES Users(UserID),
	TechYouWantToWorkWith NVARCHAR(30)
)
GO

-- Location where like to work
CREATE TABLE WhereUserLikeToWork(
	ID INT PRIMARY KEY  IDENTITY(1,1),
	UserID int FOREIGN KEY REFERENCES Users(UserID),
	Location VARCHAR(30)
)
GO

-- Companies which are Eccluded to work
CREATE TABLE CompaniesToExclude(
	ID INT PRIMARY KEY  IDENTITY(1,1),
	UserID INT FOREIGN KEY REFERENCES Users(UserID),
	CompanyToExclude VARCHAR(30)
)
GO