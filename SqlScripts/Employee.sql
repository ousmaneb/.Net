CREATE DATABASE EmployeeDB;
go

use EmployeeDB;
go


--create statement
create schema Employee;
go



create table Employee.Employee
(
	PersonId int not null identity(1,1),
	FirstName nvarchar(50)not null,
	LastName nvarchar(50) not null,
	PhoneNumber nchar(10) null
	);


select * from Employee.Employee;
