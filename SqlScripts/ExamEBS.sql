use TSQL2012
go

select * from HR.Employees
go

--16 select employeeID, lastname of all employees from the HREmployeestable
select empid, lastname from HR.Employees
go

--17 select employeeID, lastname of all employees from the HREmployeestable and sort by the employeeid in the ascending order
select empid, lastname from HR.Employees
order by empid
go

--18 select country, hire date for hire date greater than or equal to 20030101
select country, hiredate
from HR.Employees
where hiredate>='2003-01-01'
go

--19 select shipperID, companyname and phone of all shippers from the Sales.shipper table
select shipperid, companyname, phone 
from Sales.Shippers
go

--20 select shipperID, companyname and phone of all shippers from the sales.shippers table alias the table S and reference the columns in your select statement
select s.shipperid As [Shipper ID] , s.companyname AS [Company Name], s.phone As [Phone Number]
from Sales.Shippers As s
go

--21 select employeeID, firstname, lastname, country, region and the city of all the employees who live in the 'WA' region
select empid, firstname, lastname, country, region, city
from HR.Employees
where region = 'WA'
go

--22 select the employeeid, firstname, country, region and the city of all the employees who do not live in the 'WA' region or region is null
select empid, firstname, country, region, city from HR.Employees
where (region <> 'WA') OR (region is NULL)
go

--23 select orderid, orderdate, customerid and employeeid for all the orders between '20080211' and '20080213' from the sales.orders table
select orderid, orderdate, custid, empid
from Sales.Orders
where orderdate between '2008-02-11' and '2008-02-13'
go

--24 select the employeeid, firstname, lastname, and the city of all the employees who live in a city with 'a' in the spelling
select empid, firstname, lastname, city
from HR.Employees
where city like '%a%'
go

--25 Get the number of employees from the employee table
select count(empid) As [Number of Employees] from HR.Employees
go

--26 Get the employee region and the number of employees who live in that region
select region, count(*)
from HR.Employees
Group by region
go

select * from HR.Employees

select region, count(empid)
from HR.Employees
Group by region
go

select * from HR.Employees
go

--27 Get the orderid and the total amount of freight associated with that order
select orderid, sum(freight) As [Total Freight]
from Sales.Orders
Group by orderid
go


---Top 10
select top 10  orderid, freight, Dense_Rank() over (order by freight DESC) As RankByFreight
from Sales.Orders
go


select top 1 freight from
(select distinct top 10  orderid, freight from Sales.Orders order by freight desc)
Result
order by freight
go


select * from Sales.Orders order by freight desc
go