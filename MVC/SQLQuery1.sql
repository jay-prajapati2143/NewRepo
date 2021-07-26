		CREATE TABLE Cricketers

(

       ID int primary key identity (1,1),

       Name varchar(50),

       ODI int,

       Test int

)

 

CREATE TABLE Cricketer_ODI_Statistics

(

       ODI_ID int    primary key   Identity (1,1),

       Cricketer_ID int foreign key references Cricketers (ID),

       Name  varchar(50),

       Half_Century  int,

       Century       int

)

 

CREATE TABLE Cricketer_Test_Statistics

(

       Test_ID       int    primary key   Identity (1,1),

       Cricketer_ID int foreign key references Cricketers (ID),

       Name  varchar(50),

       Half_Century  int,

       Century       int

)

 

CREATE TABLE Cricketer_Details

(

       Details_ID int primary key identity (1,1),     

       Cricketer_ID int foreign key references Cricketers (ID),

       Team varchar(50),

       ODI_Runs int,

       Test_Runs int,

       Wickets int

)

 

Insert into Cricketers (Name, ODI, Test)

values ('Sachin Tendulkar', 463, 198),

('Saurav Ganguly', 311, 113),

('Rahul Dravid', 344, 164),

('Ricky Ponting', 375, 168),

('Wasim Akram', 356, 104),

('Jacques Kallis', 321, 162)

 

Insert into Cricketer_ODI_Statistics (Cricketer_ID, Name, Half_Century, Century)

Values (1,'Sachin Tendulkar', 96, 49 ),

(2,'Saurav Ganguly',72,22),

(3,'Rahul Dravid',83,12),

(4,'Ricky Ponting',82,30),

(5,'Wasim Akram',6,3),

(6,'Jacques Kallis',85,17)

 

Insert into Cricketer_Test_Statistics (Cricketer_ID, Name, Half_Century, Century)

Values (1,'Sachin Tendulkar', 67, 51),

(2,'Saurav Ganguly',35,16),

(3,'Rahul Dravid',63,36),

(4,'Ricky Ponting',62,41),

(5,'Wasim Akram',7,3),

(6,'Jacques Kallis',58,44)

 

Insert into Cricketer_Details (Cricketer_ID, Team, ODI_Runs, Test_Runs, Wickets)

Values (1, 'India', 18426, 15837, 199),

(2, 'India', 11363, 7212, 132),

(3, 'India', 10889, 13288, 5),

(4, 'Australia', 13704, 13378, 8),

(5, 'Pakistan', 3717, 2898, 916),

(6, 'South Africa', 11498, 13128, 558)