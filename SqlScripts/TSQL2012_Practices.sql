use TSQL2012
go


select * from Production.Products

select productid, productname from Production.Products

select distinct country from Production.Suppliers
order by country

select count(distinct country) as "Number of country" from Production.Suppliers

select country, city from Production.Suppliers

select contactname, SUBSTRING(address, 1, 8)  from Production.Suppliers
where contactname like '%a%a%'


select contactname,address from Production.Suppliers
where contactname like '%a%a%'



select orderdate from Sales.Orders
where DATEPART(mm, orderdate)=6 and DATEPART(yy, orderdate)=2007

select * from Sales.Orders
where MONTH(orderdate)=6 and YEAR(orderdate)=2007


---Third quarter
select * from Sales.Orders
where datepart(qq, orderdate)=3 and YEAR(orderdate)=2007

select sum(freight) as [Total Freight] from Sales.Orders
where datepart(qq, orderdate)=3 and YEAR(orderdate)=2007


select  dateadd(dd, 2, orderdate) as [Ship Date], orderdate from Sales.Orders
where datepart(qq, orderdate)=3 and YEAR(orderdate)=2007

select  orderdate, DATEDIFF(dd, orderdate, shippeddate) As [No Of Days] from Sales.Orders
where datepart(qq, orderdate)=3 and YEAR(orderdate)=2007

select * from Sales.Orders where orderid=10660




SELECT SYSDATETIME()  
    ,SYSDATETIMEOFFSET()  
    ,SYSUTCDATETIME()  
    ,CURRENT_TIMESTAMP  
    ,GETDATE()  
    ,GETUTCDATE(); 


SELECT CONVERT (date, SYSDATETIME())  
    ,CONVERT (date, SYSDATETIMEOFFSET())  
    ,CONVERT (date, SYSUTCDATETIME())  
    ,CONVERT (date, CURRENT_TIMESTAMP)  
    ,CONVERT (date, GETDATE())  
    ,CONVERT (date, GETUTCDATE());  
