use TSQL2012
go

create table Patient
(
	ID int,
	Name varchar(20)	
)
go


insert into Patient(ID, Name) values(1, 'ABC'),
									(1, 'ABC'),
									(2, 'XYZ'),
									(2, 'XYZ')
go

insert into Patient(ID, Name) values(3, 'Tom'),
									(3, 'Tom'),
									(4, 'Bob'),
									(2, 'XYZ')
go

								
			
select * from Patient
go			


select ID, count(ID) from Patient
group by ID	



---------------Temporary Table---------------
create table #tempPatient
(
	ID int,
	Name varchar(255)
)
go

insert into #tempPatient
select distinct * from Patient
go

select * from #tempPatient
go								   
------------------------
delete from Patient
go

insert into Patient
select * from #tempPatient
go


------------------
select * from Patient
go

drop table #tempPatient
drop table Patient


---------------table variable---------------
declare @varPatient table
(
	ID int,
	Name varchar(255)
)


insert into @varPatient
select distinct * from Patient


select * from @varPatient
							   
------------------------
delete from Patient

insert into Patient
select distinct * from @varPatient



------------------
select * from Patient


-----------------Rank----------------
Alter table Patient
add SNO int identity(1,1)

select * from Patient


select *, DENSE_RANK() over (order by ID) as rank
from Patient


declare @varPatient table(sno int, ID int, name varchar(255), duprank int)

insert into @varPatient(sno, ID, name, duprank)	  

select sno, id, name, RANK() over (partition by id, name order by sno DESC) as duprank
from Patient


delete p
From Patient p inner join
	@varPatient pt on p.sno = pt.sno and pt.duprank>1




SELECT * FROM patient

ALTER TABLE Patient
ADD SNO INT Identity (1,1)

SELECT * FROM patient

DECLARE @patient table(sno INT,ID INT,NAME varchar(255),duprank INT)

INSERT INTO @patient(SNO,id,NAME,duprank)

SELECT  sno
	  ,id
	  ,name
        ,RANK() OVER ( PARTITION BY id,name ORDER BY sno DESC )as duprank
FROM   Patient



DELETE p
FROM Patient  p INNER JOIN 
     @patient pt on p.sno=pt.sno AND pt.duprank>1

SELECT * FROM patient

DELETE FROM patient

ALter table patient
drop column SNO