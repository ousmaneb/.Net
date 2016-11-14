use AdventureWorks2012
go


select * from Production.Product
go

 -----Exercise 1
select count(*) As [Number of Product] from Production.Product
go

---Exercise 2
select count(*) As [Number of Product] from Production.Product
where ProductSubcategoryID is not null
go

--Exercise 3
select ProductSubcategoryID, count(*) As [Number of Product] from Production.Product
group by ProductSubcategoryID
go


select * from Production.Product
--Exercise 4
--With WHERE clause
select count(*) As [Number of Product] from Production.Product
where ProductSubcategoryID is null
go


--Without WHERE clause
select count(*) As [Number of Product] from Production.Product
group by  ProductSubcategoryID
having ProductSubcategoryID is null
go


-----Exercise 5
select * from Production.ProductInventory
go

select ProductID, sum(Quantity) as TheSum
from Production.ProductInventory
group by ProductID
go

--------
select ProductID, Shelf, sum(Quantity) as TheSum
from Production.ProductInventory
group by  ProductID, Shelf
having sum(Quantity)<100
order by Shelf
go



---Exercise 6
select ProductID, sum(Quantity) as TheSum
from Production.ProductInventory
where LocationID=40
group by  ProductID
having sum(Quantity)<100
order by ProductID
go


---Exercise 7
select shelf, ProductID, sum(Quantity) as TheSum
from Production.ProductInventory
where LocationID=40
group by  shelf, ProductID
having sum(Quantity)<100
order by ProductID
go


----Exercise 8
--select ProductID, avg(Quantity) as [Average Product]
--from Production.ProductInventory
--where LocationID=10
--group by ProductID
--go

select avg(Quantity) as [Average Product]
from Production.ProductInventory
where LocationID=10
go


----Exercise 9
select ProductID, Shelf, avg(Quantity) as [Average Product]
from Production.ProductInventory
where Shelf <> 'N/A'
group by ProductID, Shelf
order by Shelf
go
