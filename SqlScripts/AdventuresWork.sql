use AdventureWorks2014;
go


select Sales.PersonCreditCard.CreditCardID, Sales.PersonCreditCard.ModifiedDate
from Sales.PersonCreditCard

--All customers and their purchases from last year
select Distinct(c.AccountNumber), pp.FirstName, pp.LastName, p.Name, sod.OrderQty, soh.OrderDate
from Sales.Customer as c
inner join Sales.SalesOrderHeader as soh on soh.CustomerID = c.CustomerID
inner join Sales.SalesOrderDetail as sod on sod.SalesOrderID = soh.SalesOrderID
inner join Production.Product as p on p.ProductID = sod.ProductID
inner join Person.Person as pp on pp.BusinessEntityID = c.PersonID
--where year(soh.OrderDate)=2014;
where year(soh.OrderDate) between 2013 and 2014 and sod.OrderQty>1 and p.Name like '%road-650%';


select Distinct(c.AccountNumber), pp.FirstName, pp.LastName, p.Name, sod.OrderQty, soh.OrderDate
from Sales.Customer as c
inner join Sales.SalesOrderHeader as soh on soh.CustomerID = c.CustomerID
inner join Sales.SalesOrderDetail as sod on sod.SalesOrderID = soh.SalesOrderID
inner join Production.Product as p on p.ProductID = sod.ProductID
inner join Person.Person as pp on pp.BusinessEntityID = c.PersonID
--where year(soh.OrderDate)=2014;
where year(soh.OrderDate) between 2013 and 2014 and sod.OrderQty>1 and p.Name like '%road-650%';


--All persons that are customers
select *
from Person.Person
where BusinessEntityID in (select PersonID from Sales.Customer);

select *
from Person.Person
where BusinessEntityID not in (select PersonID from Sales.Customer);


select *
from Person.Person
where exists (select * from Sales.Customer where PersonID=BusinessEntityID);


select *
from Person.Person
where not exists (select * from Sales.Customer where PersonID=BusinessEntityID);