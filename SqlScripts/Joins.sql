use TSQL2012
go


select p.productname, c.categoryname 
from Production.Products p
inner join 
Production.Categories c on
p.categoryid = c.categoryid
where p.discontinued = 1
order by c.categoryname
go

select p.productname, c.categoryname 
from Production.Products p
inner join 
Production.Categories c on
p.categoryid = c.categoryid and p.discontinued = 1
order by c.categoryname
go


select p.productname, c.categoryname 
from Production.Products p
inner join 
Production.Categories c on
p.categoryid = c.categoryid and p.discontinued = 1
inner join
Sales.OrderDetails oc on oc.productid = p.productid
order by c.categoryname
go

