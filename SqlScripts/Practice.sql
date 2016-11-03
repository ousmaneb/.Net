use AdventureWorks2014;
go

--simple select statement
select *
from Person.Person;

select count(*) as number
from Person.Person;																  

---real select statement

select FirstName, MiddleName, LastName
from Person.Person;

select FirstName as "First Name", MiddleName as [Middle Name], LastName as "Family Name"
from Person.Person;

select FirstName, MiddleName, LastName
from Person.Person
where MiddleName is null;

select FirstName, MiddleName, LastName
from Person.Person
where MiddleName is not null;

select FirstName, MiddleName, LastName
from Person.Person
where FirstName = 'fred';


select FirstName, MiddleName, LastName
from Person.Person
where FirstName = 'fred'
collate Latin1_General_CS_AS;


--Query all names that starts with letter 's' firstname or lastname
select FirstName, MiddleName, LastName
from Person.Person
where FirstName like 's%' and LastName like's%';

--end with 'e'
select FirstName, MiddleName, LastName
from Person.Person
where FirstName like '%e' or LastName like'%e';

--contains 'se' contiguous
select FirstName, MiddleName, LastName
from Person.Person
where FirstName like '%se%' or LastName like'%se%';


select FirstName, MiddleName, LastName
from Person.Person
where FirstName >= 's' and LastName >='s';

select FirstName, MiddleName, LastName
from Person.Person
where FirstName like '%se[anyi]' or LastName like '%se[anyi]';

select OrderDate
from Sales.SalesOrderHeader
where OrderDate = '2014-06-30'
order by OrderDate asc;

select OrderDate
from Sales.SalesOrderHeader
where OrderDate >= '2014-06-01' and OrderDate <= '2014-06-30'
order by OrderDate asc;

select OrderDate
from Sales.SalesOrderHeader
where OrderDate between '2014-06-01' and '2014-06-30'
order by OrderDate asc;



select OrderDate
from Sales.SalesOrderHeader
where month(Orderdate) = 6 and year(OrderDate)=2014
order by OrderDate asc;

select OrderDate
from Sales.SalesOrderHeader
where datename(weekday, Orderdate) = 'thursday'
order by OrderDate asc;

select OrderDate
from Sales.SalesOrderHeader
where datepart(weekday, Orderdate) = 4
order by OrderDate asc;

select OrderDate, ShipDate, DATEDIFF(day, OrderDate, ShipDate) as Diff
from Sales.SalesOrderHeader
where DATEDIFF(day, OrderDate, ShipDate)<10
order by OrderDate asc;


select OrderDate
from Sales.SalesOrderHeader
where OrderDate = dateadd(day, 1, '2013-11-20')
order by OrderDate asc;


select OrderDate
from Sales.SalesOrderHeader
where OrderDate <> EOMONTH(OrderDate)
order by OrderDate asc;

create table TimeStuff
(
	DateColumn date,
	timecol time,
	time2col time(0),
	datetimecol datetime,
	datetime2col datetime2(7)
);

select FirstName+' '+MiddleName+' '+LastName
from Person.Person;

select FirstName+' '+isnull(MiddleName,'')+' '+LastName
from Person.Person;

select FirstName+' '+isnull(MiddleName+'','')+' '+LastName
from Person.Person;

select FirstName+' '+coalesce(MiddleName+'',null,null,'')+' '+LastName
from Person.Person;

