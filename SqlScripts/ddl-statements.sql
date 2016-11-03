use February2016;
go


--create statement
create schema AddressBook;
go



create table AddressBook.Person
(
	PersonId int not null identity(1,1),
	FirstName nvarchar(50)not null,
	LastName nvarchar(50) not null,
	PhoneNumber nchar(10) null
	);


create table AddressBook.[Address]
(
	AddressId int not null identity(1,1),
	Street nvarchar(250) not null,
	City nvarchar(50) not null,
	[State] nchar(2) not null,
	ZipCode nchar(5) not null,
);

create table AddressBook.PersonAddress
(
	PersonAddressId int identity(1,1),
	PersonId int not null,
	AddressId int not null
);
go

--alter statement
alter table AddressBook.Person
	add constraint PK_Person_PersonId primary key clustered (PersonId);

alter table AddressBook.[Address]
	add constraint PK_Address_AddressId primary key clustered (AddressId);

alter table AddressBook.PersonAddress
	add constraint PK_PersonAddress_PersonAddressId primary key clustered(PersonAddressId);

alter table AddressBook.PersonAddress
	add constraint FK_PersonAddress_PersonId foreign key (PersonId) references AddressBook.Person(PersonId);

alter table AddressBook.PersonAddress
	add constraint FK_PersonAddress_AddressId foreign key (AddressId) references AddressBook.[Address](AddressId);

alter table AddressBook.Person
	add MiddleName nvarchar(50) null;

alter table AddressBook.[Address]
	alter column [State] nchar(20) not null;
go

---drop statement
drop table AddressBook.PersonAddress;
drop table AddressBook.[Address];
drop table AddressBook.Person;
go

--truncate statement
truncate table AddressBook.PersonAddress;
truncate table AddressBook.[Address];
truncate table AddressBook.Person;