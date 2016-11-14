use SqlOct2016
go

create database SqlOct2016

create table Category(
	Catg_ID int Primary Key identity(1,1),
	Catg_Name varchar(50) not null,
	Catg_Descr varchar(75) not null
)
go

create table Product(
	Prd_ID int Primary Key identity(1,1),
	Prd_Name varchar(50) not null,
	Prd_Descr varchar(75),
	UnitPrice decimal(4,2) not null,
	catg_ID int not null
	--catg_ID int Foreign Key References Category(Catg_ID)
)
go

create table Customers(
	Cust_ID int Primary Key identity(1,1),
	Cust_Fname varchar(50) not null,
	Cust_Lname varchar(50) not null,
	Cust_DOB date,
	Cust_Uname varchar(50) not null unique
)
go

create table Orders(
	Order_ID int Primary key identity(1,1),
	Prd_ID int not null,
	Cust_ID int null,
	Order_Date date not null,
	Prd_Qty int default(1) not null,
	TotalPrice Decimal(8,2)
)
go

alter table Product
add Constraint FK_Products_CatgID Foreign Key(Catg_ID) References Category(Catg_ID)
go

alter table Orders
add Constraint FK_Cust_Orders_Prd_ID Foreign Key(Prd_ID) References Product(Prd_ID)
go

alter table Orders
add Constraint FK_Cust_Orders_Cust_ID Foreign Key(Cust_ID) References Customers(Cust_ID)
go


insert into Category(Catg_Name, Catg_Descr) values('Beverages','Good for Summer time');
insert into Category(Catg_Name, Catg_Descr) values('Snacks',''),('Snacks',''),('Home Goods',''),('Kitchen',''),('Sports','')
go
select * from Category

insert into Product(Prd_Name, catg_ID, UnitPrice) values('Pepsi',1,10.2), ('Kitkat',2,2), ('Doritos',1,3.5), ('Iphone 6S',3,69)
select * from Product

insert into Customers values('Ousmane','Guinea');

insert into Orders values('Ousmane','Guinea');