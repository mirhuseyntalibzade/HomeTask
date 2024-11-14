INSERT INTO Job_Grades(grade_level, lowest_salary,highest_salary) 
VALUES('grade-level', 1000, 100000)


CREATE TABLE Regions(
  Region_Id int IDENTITY PRIMARY KEY,
  Region_Name varchar(25)
)
CREATE TABLE Countries(
  Region_Id int,
  FOREIGN KEY (Region_Id) REFERENCES Regions(Region_Id),
  Country_Id int IDENTITY PRIMARY KEY,
  Country_Name varchar(40),
)

CREATE TABLE Locations(
  Location_Id int IDENTITY PRIMARY KEY,
  Street_Address varchar(25),
  Postal_Code varchar(12),
  City varchar(30),
  State_Province varchar(12),
    Country_Id int,
  FOREIGN KEY (Country_Id) REFERENCES Countries(Country_Id)
)

CREATE TABLE Departments(
  Department_Id int IDENTITY PRIMARY KEY,
  Department_Name varchar(30),
  Manager_Id int,
  Location_Id int
  FOREIGN KEY (Location_Id) REFERENCES Locations(Location_Id)
)

CREATE TABLE Jobs(
  Job_Id int IDENTITY PRIMARY KEY,
  Job_Title varchar(35),
  Min_Salary int,
  Max_Salary int
)

CREATE TABLE Employees(
  Employee_Id int IDENTITY PRIMARY KEY,
  First_Name varchar(20),
  Last_Name varchar(20),
  Email varchar(25),
  Phone_Number varchar(20),
  Hire_Date date,
  Job_Id int,
  FOREIGN KEY (Job_Id) REFERENCES Jobs(Job_Id),
  Salary int,
  Commission_PCT int,
  Manager_Id int,
  Department_Id int,
  FOREIGN KEY (Department_Id) REFERENCES Departments(Department_Id)
)

CREATE TABLE Job_History(
  Employee_Id int,
  FOREIGN KEY (Employee_Id) REFERENCES Employees(Employee_Id),
  Start_Date date,
  PRIMARY KEY (Employee_Id, Start_Date),
  End_Date date,
  Job_Id int,
  FOREIGN KEY (Job_Id) REFERENCES Jobs(Job_Id),
  Department_Id int,
  FOREIGN KEY (Department_Id) REFERENCES Departments(Department_Id)
)

CREATE TABLE Job_Grades(
  Grade_Level varchar(20),
  Lowest_Salary int,
  Highest_Salary int
)

