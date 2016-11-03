CREATE DATABASE ProductDB;
go

use ProductDB;
go


create schema Product;
go



create table Product.Customers
(
	CustomerId int not null identity(1,1),
	FirstName nvarchar(50)not null,
	LastName nvarchar(50) not null,
	CardNumber int not null,
	);


create table Product.Products
(
	ProductId int not null identity(1,1),
	ProductName nvarchar(50) not null,
	ProductPrice int not null, 
);

create table Product.Orders
(
	OrderId int identity(1,1),
	ProductId int not null,
	CustomerId int not null
);
go

--alter statement
alter table Product.Customers
	add constraint PK_Customers_CustomerId primary key clustered (CustomerId);
go

alter table Product.Products
	add constraint PK_Products_ProductId primary key clustered (ProductId);
go

alter table Product.Orders
	add constraint PK_Orders_OrderId primary key clustered(OrderId);
go

alter table Product.Orders
	add constraint FK_Orders_ProductId foreign key (ProductId) references Product.Products(ProductId);
go

alter table Product.Orders
	add constraint FK_Orders_CustomerId foreign key (CustomerId) references Product.Customers(CustomerId);

go

---------SQL Statement Insert Command--

---Insert Customers
insert into Product.Customers(FirstName, LastName, CardNumber)
values ('Ousmane', 'Barry', 1234), ('Diallo', 'Alpha', 5678), ('Sow', 'Karim', 1078);
go

select * from Product.Customers;
go
---Insert Products
insert into Product.Products(ProductName, ProductPrice)
values ('Laptop', 934), ('Speaker', 1678), ('Hard Drive', 78);
go

select * from Product.Products;
go

insert into Product.Orders(ProductId, CustomerId)
values (1, 1), (2, 2), (3,3);
go

select * from Product.Orders;
go


-------
insert into Product.Products(ProductName, ProductPrice)
values ('Iphone', 200);
go
select * from Product.Customers;
go
-------
insert into Product.Customers(FirstName, LastName, CardNumber)
values ('Anthony', 'Gonsalves', 1784);
go

select * from Product.Products;
go
------

insert into Product.Orders(ProductId, CustomerId)
values (4, 4);
go

select * from Product.Orders;
go
-------



select Product.Products.ProductName
from Product.Products, Product.Orders, Product.Customers
where Product.Customers.FirstName ='Anthony' and Product.Customers.LastName='Gonsalves' and 
		Product.Customers.CustomerId = Product.Orders.OrderId and 
		Product.Orders.OrderId = Product.Products.ProductId;
go

--------
select sum(Product.Products.ProductPrice)
from Product.Products
where Product.Products.ProductName = 'Iphone';
go

---------
UPDATE Product.Products
SET ProductPrice = 450
WHERE ProductName = 'Iphone'; 
go

select * from Product.Products;
go

-----
DELETE FROM Product.Customers
WHERE Product.Customers.FirstName ='Anthony' and Product.Customers.LastName='Gonsalves'
	
		