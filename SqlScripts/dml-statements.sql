use February2016;
go

select * from AddressBook.PersonAddress;
go

--insert statement
insert into AddressBook.Person
values ('Ousmane', 'x','Barry', null);
go

insert into AddressBook.Person(LastName, MiddleName, FirstName)
values ('Barry', 'A', 'Ousmane'), ('belotte', 'x', 'fred');
go


select PhoneNumber, MiddleName, LastName, FirstName
into #MysessionPerson  --temporary table for my current session
from AddressBook.Person;

select PhoneNumber, MiddleName, LastName, FirstName
into ##MysessionPerson  --temporary table for the global session
from AddressBook.Person;

insert into AddressBook.Person(LastName, FirstName, MiddleName, PhoneNumber)
select LastName, FirstName, MiddleName, PhoneNumber
from AddressBook.Person;

/*select FirstName, MiddleName, LastName, PhoneNumber
into AddressBook.Person
from AddressBook.Person;
*/

/*
Take data from a table and put it in a table
*/
bulk insert AddressBook.Person from 'C:\SqlServer\person.csv' with (rowterminator = '\n', fieldterminator = ',');

---update statement
update AddressBook.Person
set LastName='belotte', MiddleName = 'x', PhoneNumber='13579'
where PersonId = 1;

update p
set p.PhoneNumber='1111111111'
from AddressBook.Person as p
where p.PersonId>4 and p.PhoneNumber is null;


--Delete statement
delete from AddressBook.Person
where PersonId = 4;


delete p
from AddressBook.Person as p
where p.PhoneNumber is null;


--select statement

select 'hello sql';

select 1+1;

select *
from AddressBook.Person;

select * 
from #MysessionPerson;

select *
from ##MysessionPerson;

select FirstName, LastName
from AddressBook.Person;

select FirstName SurName, lastName "Family Name", MiddleName as TrueName
from AddressBook.Person;


select FirstName, LastName
from AddressBook.Person
where FirstName = 'fred';


select FirstName as F,MiddleName, LastName
from AddressBook.Person
where FirstName = 'fred';

select FirstName, LastName 
from AddressBook.Person as p
where p.FirstName='fred';


select *
from AddressBook.Person;

select *
from AddressBook.Person
where MiddleName is not null
order by MiddleName, PersonId asc;

select MiddleName
from AddressBook.Person
where MiddleName is not null
group by MiddleName
order by MiddleName;

select MiddleName, count(PersonId) as People, count(FirstName) as F, count(LastName) as N, count(PhoneNumber) as P
from AddressBook.Person
where MiddleName is not null
group by MiddleName
having count(FirstName)> 1
order by MiddleName;


--order of execution
--from
--where
--group by
--having
--select
--order by

