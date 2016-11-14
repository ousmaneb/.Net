use TSQL2012
go


Create procedure usp_Products_Retrieve_ByID(@id int)
As
BEGIN
----Write your sql query
select * from Production.Products where productid=@id
END
go

Create procedure usp_Products_Retrieve_ByCatg(@id int)
As
BEGIN
----Write your sql query
select * from Production.Products where categoryid=@id
END
go

Create procedure usp_Products_Retrieve_UnitPrice(@id int)
As
BEGIN
----Write your sql query
select * from Production.Products where unitprice=@id
END
go

Create procedure usp_Products_Retrieve
As
BEGIN
----Write your sql query
select * from Production.Products
END



exec usp_Products_Retrieve
exec usp_Products_Retrieve_ByID 2


