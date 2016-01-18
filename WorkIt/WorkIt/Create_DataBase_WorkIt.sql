/*
CREATE TABLE Employees
(
   ID			INT	primary key,
   Name         varchar(50) not null,
   Address	    varchar(50) not null,
   Mail	        varchar(50) not null,
   Birth_Date   Date,
   Martial_Stautus   varchar(10),
   Education  varchar(30),
   Position   varchar(30),
   Salary      float,
   Phone_num    varchar(30)

);

CREATE TABLE Customers
(
   ID	INT	primary key,
   Name         varchar(50) not null,
   Address	    varchar(50) not null,
   Phone_num    varchar(30),
   Mail	        varchar(50) not null,
   Birth_Date   Date,
   Medical_Issues   varchar(50),
   Interests   varchar(50),
   TP_Id int,
   
);

CREATE TABLE Classes
(
   Name	varchar(20) primary key,
   Days  varchar(20) not null,
   Hours	varchar(20) not null,
   Guide_ID    int,
   Room_num    smallint,
   CONSTRAINT fk_pk FOREIGN KEY (Guide_ID) references Employees(ID)
);

CREATE TABLE Orders	
(
	Order_Id      int  primary key,
    Supplier	  varchar(20) not null,
    Order_Date    Date not null,
	Destination Date,
	Is_Arrived  smallint
);
 
CREATE TABLE Items
(
    Item_Code  int  primary key,
    Item_Name varchar(30),
    Min_Amount int,
    Current_Amount char(10),	
	Propriety_Status char(10)
);

CREATE TABLE Items_In_Orders
(
    Order_Id int,
	Item_Code  int,
	Amount int
	CONSTRAINT fk_order FOREIGN KEY (Order_Id) references Orders(Order_Id),
	CONSTRAINT fk_Items FOREIGN KEY (Item_Code) references Items(Item_Code)
   
);

CREATE TABLE Customres_In_Classes
(
    Class_Name varchar(20),
	Customer_ID int
	CONSTRAINT fk_classes FOREIGN KEY (Class_Name) references Classes(Name),
	CONSTRAINT fk_customers FOREIGN KEY (Customer_ID) references Customers(ID)
   
);

CREATE TABLE Training_Program
(
    TP_Id int,
	Item_ID int,
	Number_of_repetitions int 
);

CREATE TABLE Eventes
(
    Name varchar(20),
	Event_Date date,
	Event_hours varchar(20),
	Description varchar(50),
	Place varchar(20)
);

CREATE TABLE Supppliers
(
    Name varchar(20),
	Mail varchar(50)
);

CREATE TABLE Customres_In_Eventes
(
    Name varchar(20),
	Customer_ID INT
);

--Delete from Personal

INSERT INTO Employees VALUES(1111,'Avi Cohen','Marganit 6,Tel Aviv','avi@gmail.com','1985-02-10','single','Academic','Manager',20000,'052-768-550')
INSERT INTO Employees VALUES(2222,'Noa Levi','Cahal 10,Tel Aviv','noa@gmail.com','1989-09-03','single','Academic','secretary',5700,'052-799-550')
INSERT INTO Employees VALUES(3333,'Sean Savir','lev 45,Tel Aviv','sean@gmail.com','1990-07-03','single','Academic','Guide',8000,'052-7659-550')

*/
--Update Classes Set[Room_num]=6 where Name='Spining'
select * from  Classes
--select C.Name,C.Mail from Customers C inner join Customres_In_Classes CIC on C.ID=CIC.Customer_ID where CIC.Class_Name='Spining'
--drop table  Customers
--drop table  Employees

/*
INSERT INTO Customers VALUES(7676,'Adi Haim','sapir 5,Tel Aviv','052-799-666','adi@gmail.com','1989-10-03',null,'spininig',1)
INSERT INTO Customers VALUES(3251,'Sapir Dan','Cohav 8,Tel Aviv','058-799-566','sapir@gmail.com','1990-10-09',null,'runs',1)
INSERT INTO Customers VALUES(777,'Sheli Hadad','Adarim 83,Tel Aviv','054-799-596','sheli@gmail.com','1989-12-09',null,'spininig',1)


INSERT INTO Classes  VALUES('Spining','Sun,Tue','18:00-19:00',3333,2)
INSERT INTO Classes  VALUES('TRX','Sun,Tue','17:00-19:00',3333,1)

INSERT INTO Orders  VALUES(1,'Dudu','2015-12-18','2016-02-15',0)

*/
--INSERT INTO Orders  VALUES(2,'Dudu','2015-11-30','2016-02-25',0)
--select * from Employees
/*
INSERT INTO Items  VALUES(50,'Bike',10,13,'good')
INSERT INTO Items  VALUES(30,'weight',4,2,'good')
INSERT INTO Items  VALUES(19,'walker',8,10,'good')

INSERT INTO Items_In_Orders VALUES(1,50,2)
INSERT INTO Items_In_Orders VALUES(2,30,5)

INSERT INTO Customres_In_Classes VALUES('Spining',7676)
INSERT INTO Customres_In_Classes VALUES('Spining',777)


INSERT INTO Training_Program VALUES(1,30,10)
INSERT INTO Training_Program VALUES(1,50,1)
INSERT INTO Training_Program VALUES(1,19,1)

INSERT INTO Eventes VALUES('Zomba party','2016-01-27','18:00-20:00','Zomba party','room 3')
INSERT INTO Eventes VALUES('Spining Day','2016-01-30','08:00-20:00','Spining Day','room 3')

INSERT INTO Supppliers VALUES('Dudu','Dudu@gmail.com')
INSERT INTO Supppliers VALUES('Coco','coco@gmail.com')

INSERT INTO Customres_In_Eventes VALUES('Spining Day',777)
INSERT INTO Customres_In_Eventes VALUES('Spining Day',7676)
*/