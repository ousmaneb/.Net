create database Insurance
go

use Insurance
go

create table [Plan](
	Plan_id int Primary Key identity(1,1),
	Plan_Name varchar(50) not null,
	Plan_Descr varchar(70) not null,
	Plan_DectValue money not null
)
go


create table Member(
	Mem_id int Primary Key identity(1,1),
	FName  varchar(20) not null,
	LName  varchar(20) not null,
	DOB	   Date not null,
	Gender char(1) not null,
	UserName varchar(50) unique not null,
	Plan_id  int Foreign Key References [Plan](Plan_id),
)
go


create table Claim(
	Claim_id int Primary Key identity(1,1),
	Mem_id int Foreign Key References Member(Mem_id),
	Claim_Date Date not null,
	Due_Date Date not null,
	Claim_Amount decimal(4,2) not null
)
go


insert into [Plan](Plan_Name, Plan_Descr, Plan_DectValue) values('Affinity Health', 'Health and Wellness', 200.34),
																('Capital District Phys', 'For everyone', 450.44),
																('Care Connect', 'I gotchu', 200.34),
																('Empire Blue Cross', 'ok I got it', 2678.4),
																('Excellus', 'I do not know you', 200.34),
																('Fidelis Care', 'Best health plan', 450.34),
																('Healthfirst', 'Better health plan', 20.34),
																('Healthnow', 'Good health plan', 2050.34),
																('Metroplus', 'This is my plan', 1200.04),
																('Oscar', 'Wow Oscar', 200.34)
go

select * from [Plan]
go


insert into Member(FName, LName, DOB, Gender, UserName, Plan_id) values	('Ousmane', 'Barry', '2011-01-01', 'M', 'bosmane', 2),
																		('Oumar', 'Diallo', '1999-02-04', 'F', 'osdiallo', 3),
																		('Alpha', 'Sow', '1977-10-01', 'M', 'alphasow', 1),
																		('Mariam', 'Bah', '1993-12-01', 'M', 'mariambah', 4),
																		('Fatou', 'Smith', '1988-03-12', 'F', 'fatousmith', 8),
																		('Mike', 'Guru', '2013-06-18','M', 'mikeguru', 9),
																		('Pepe', 'Smart', '2015-07-29', 'F', 'pepesmart', 10),
																		('Zach', 'Folle', '2000-08-30', 'M', 'zachfolle', 5),
																		('Will', 'Best', '2001-01-11', 'F', 'willbest', 6),
																		('Ferra', 'October', '2002-04-12', 'M', 'ferraoctober', 7)
go



select * from Member
go


insert into Claim(Mem_id, Claim_Date, Due_Date, Claim_Amount) values(2, '2016-08-23', '2017-09-24', 20.00),
																	(1, '2016-08-25', '2017-09-24', 20.00),
																	(7, '2016-09-17', '2017-08-24', 23.00),
																	(6, '2016-01-16', '2017-09-24', 12.00),
																	(10, '2016-03-15', '2017-10-24', 11.00),
																	(4, '2016-05-23', '2017-11-24', 19.00),
																	(3, '2016-12-01', '2017-09-24', 22.00),
																	(9, '2016-11-02', '2017-09-24', 25.00),
																	(5, '2016-02-11', '2017-07-24', 99.00),
																	(8, '2016-01-10', '2017-08-24', 21.00)
go								


select * from Claim	
go	