use AdventureWorks2014;
go

---inner join
---Give me orders that have details
select soh.OrderDate, soh.ShipDate, soh.TotalDue, soh.SalesOrderID, sod.SalesOrderDetailID
from Sales.SalesOrderHeader as soh
inner join Sales.SalesOrderDetail as sod on soh.SalesOrderID = sod.SalesOrderID;

---Left join
---Give me all orders that have details
select soh.OrderDate, soh.ShipDate, soh.TotalDue, soh.SalesOrderID, sod.SalesOrderDetailID
from Sales.SalesOrderHeader as soh
left join Sales.SalesOrderDetail as sod on soh.SalesOrderID = sod.SalesOrderID;

---Right Join
select soh.OrderDate, soh.ShipDate, soh.TotalDue, soh.SalesOrderID, sod.SalesOrderDetailID
from Sales.SalesOrderDetail as sod
right join Sales.SalesOrderHeader as soh on soh.SalesOrderID = sod.SalesOrderID;

--full joint

select soh.OrderDate, soh.ShipDate, soh.TotalDue, soh.SalesOrderID, sod.SalesOrderDetailID
from Sales.SalesOrderHeader as soh
full join Sales.SalesOrderDetail as sod on soh.SalesOrderID = sod.SalesOrderID;

--Cross join statent
--Multiplying each row from A to B

select soh.OrderDate, soh.ShipDate, soh.TotalDue, soh.SalesOrderID, sod.SalesOrderDetailID
from Sales.SalesOrderHeader as soh
cross join Sales.SalesOrderDetail as sod 
where OrderDate = '2014-06-01';

--Whose firstName = Lastname
--self join statement=inner join on yourself
select *
from Person.Person as p
inner join Person.Person as pp on pp.LastName = p.FirstName;

select distinct p.FirstName, p.LastName
from Person.Person as p
inner join Person.Person as pp on pp.LastName = p.FirstName;

select distinct p.FirstName
from Person.Person as p
inner join Person.Person as pp on pp.LastName = p.FirstName;

select distinct p.BusinessEntityID
from Person.Person as p
inner join Person.Person as pp on pp.LastName = p.FirstName;

select distinct p.FirstName, p.LastName
from Person.Person as p
where p.FirstName = p.LastName;

---inner join
---Give me orders that have details
select sc.PersonID, soh.SalesOrderID
from Sales.Customer as sc
inner join Sales.SalesOrderHeader as soh on sc.CustomerID = soh.CustomerID;


select pp.Name, pp.ListPrice
from Production.Product as pp
full outer join Purchasing.ProductVendor as ppv on pp.ProductID=ppv.ProductID
where pp.ListPrice>50;
