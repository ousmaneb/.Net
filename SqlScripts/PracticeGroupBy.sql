use TSQL2012
go

select categoryid,
		count(categoryid) As CatgCount
from Production.Products
group by categoryid
go

select region, count(region) as Employee_Count_region
from HR.Employees
group by region


select region, count(*) as Employee_Count_region
from HR.Employees
group by region


select city, region, count(region) as Employee_Count_region
from HR.Employees
group by region, city
go


select city, region, count(*) as Employee_Count_region
from HR.Employees
group by city, region
go

select city, region, count(*) as Employee_Count_region
from HR.Employees
group by region, city
go



select categoryid, unitprice
from Production.Products
group by categoryid, unitprice


select categoryid, unitprice
from Production.Products
group by categoryid, unitprice
having min(unitprice)>=15
order by categoryid

select categoryid, sum(unitprice)
from Production.Products
group by categoryid
having sum(unitprice)>200





select region, city
from HR.Employees
group by city, region

--Dynamic columns--------------------------------------
select shipname, shippeddate, freight,
		CASE when shipcountry='USA' then 'Domestic' else
		'international' end as ShipmentType
from Sales.Orders
Order by ShipmentType



--------------------------------------------------------
select shipcountry, shipcity,  
case when freight >=0 and freight<250 then 'low'
	else
		case when freight>=250 and freight<500 then	'medium'
		else 'high'
		end
	end	as freightRange
from Sales.Orders
order by freight




