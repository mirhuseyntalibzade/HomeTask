CREATE TABLE Regions(
  Region_Id int IDENTITY PRIMARY KEY,
  Region_Name varchar(25)
)

INSERT INTO Regions(region_name) VALUES('california')
INSERT INTO Countries(country_name) VALUES('USA')
INSERT INTO Locations(city) VALUES('Los Angeles')
DELETE FROM Locations WHERE location_id=1

SELECT * FROM Regions

ALTER TABLE Countries ADD Country_Capital varchar(25)

DROP TABLE Regions

TRUNCATE TABLE Countries

UPDATE Regions
SET region_name='America'
WHERE region_id = 1

CREATE TABLE Countries(
  Region_Id int,
  Country_Id int IDENTITY PRIMARY KEY,
  Country_Name varchar(40),
)

CREATE TABLE Locations(
  Location_Id int IDENTITY PRIMARY KEY,
  Street_Address varchar(25),
  Postal_Code varchar(12),
  City varchar(30),
  State_Province varchar(12),
  Country_Id int
)

CREATE TABLE Departments(
  Department_Id int IDENTITY PRIMARY KEY,
  Department_Name varchar(30),
  Manager_Id int,
  Location_Id int
)

CREATE TABLE Employees(
  Employee_Id int IDENTITY PRIMARY KEY,
  First_Name varchar(20),
  Last_Name varchar(20),
  Email varchar(25),
  Phone_Number varchar(20),
  Hire_Date date,
  Job_Id varchar(20),
  Salary int,
  Commission_PCT int,
  Manager_Id int,
  Department_Id int
)

CREATE TABLE Jobs(
  Job_Id int IDENTITY PRIMARY KEY,
  Job_Title varchar(35),
  Min_Salary int,
  Max_Salary int
)

CREATE TABLE Job_History(
  Employee_Id int IDENTITY PRIMARY KEY,
  Start_Date date PRIMARY KEY,
  End_Date date,
  Job_Id varchar(20)
  Department_Id int
)

CREATE TABLE Job_Grades(
  Grade_Level varchar(20),
  Lowest_Salary int,
  Highest_Salary int
)