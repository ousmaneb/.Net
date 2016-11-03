use February2016;
go

--New Statement
--a view is not a table, it's a query

create view AddressBook.FullName(FullName)
as
(
	select FirstName+' '+coalesce(MiddleName+' ','')+LastName
	from AddressBook.Person
);
go

--When SCHEMABINDING is specified, the base table or tables cannot be modified in a way that would affect the view definition.
----schemaBinding is like locking the table, schema become child of the table

create view AddressBook.FullNameSafe(FullName) with schemabinding
as
(
	select FirstName+' '+coalesce(MiddleName+' ','')+LastName
	from AddressBook.Person
);
go




select *
from AddressBook.FullName;
go

----function statement
---Scalar value function return one thing
create function AddressBook.GetPersonCount()
returns int
begin
	declare @number int;
	select @number = count(*)
	from AddressBook.Person
	return @number
end;
go


select AddressBook.GetPersonCount();
go
----------------------
create function AddressBook.GetPersonByState(@state nchar(2))
returns table
as return
(
	select p.FirstName+' '+coalesce(p.MiddleName+' ','')+p.LastName as FullName, a.*
	from AddressBook.Person as p 
	inner join AddressBook.PersonAddress as pa on pa.AddressId = p.PersonId
	inner join AddressBook.[Address] as a on a.AddressId = pa.AddressId
	where a.[State] = @state
);
go

select *
from AddressBook.GetPersonByState('ny');
go
---Stored precedure statement
create procedure AddressBook.InsertPersonAddress
	(@first nvarchar(50), @last nvarchar(50), @street nvarchar(250), @city nvarchar(50), @state nchar(2), @zip nchar(5))
as
begin
	insert into AddressBook.Person(FirstName, LastName)
	output inserted.*
	values (@first, @last);

	insert into AddressBook.[Address](Street, City, [State], ZipCode)
	values (@street, @city, @state, @zip);

	declare @pid int;
	declare @aid int;

	select @pid = max(PersonId)
	from AddressBook.Person;

	select @aid = max(AddressId)
	from AddressBook.[Address];

	insert into AddressBook.PersonAddress(PersonId, AddressId)
	values (@pid, @aid);
end;
go

exec AddressBook.InsertPersonAddress 'france', 'brazil', 'cit', 'st', 'ny', '10000';

select *
from AddressBook.GetPersonByState('ny');
go

--sequence statement
create procedure AddressBook.InsertPersonAddressSafe
	(@first nvarchar(50), @last nvarchar(50), @street nvarchar(250), @city nvarchar(50), @state nchar(2), @zip nchar(5))
as
begin
	set xact_ abort on;
	begin transaction
		begin try
			insert into AddressBook.Person(FirstName, LastName)
			output inserted.*
			values (@first, @last);

			insert into AddressBook.[Address](Street, City, [State], ZipCode)
			values (@street, @city, @state, @zip);

			declare @pid int;
			declare @aid int;

			select @pid = max(PersonId)
			from AddressBook.Person;

			select @aid = max(AddressId)
			from AddressBook.[Address];

			insert into AddressBook.PersonAddress(PersonId, AddressId)
			values (@pid, @aid);
		commit transaction
	end try
	
	begin catch
		print error_message
		print error_severity
		print error_number
		print error_state

		if @@error = 1
		begin
			print 'Too many errors'
		end

---It's best to use throw instead raiserror
		raiserror(N'message',16,1);
		throw 50000, 'message', 16;
		throw;
		throw @id, @ms, 200;

		rollback transaction
	end catch	
end;
go