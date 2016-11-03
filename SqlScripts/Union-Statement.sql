use AdventureWorks2014;
go

--Union Statement
select FirstName
from Person.Person
--where LastName='james'
union
select Name
from Production.Product;

