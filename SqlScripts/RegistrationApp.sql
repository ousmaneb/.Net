
use RegistrationApp;
go


--create statement
create schema Registration;
go



create table Registration.Student
(
	StudentId int not null identity(1,1),
	FirstName nvarchar(50)not null,
	LastName nvarchar(50) not null,
	);


create table Registration.Course
(
	CourseId int not null identity(1,1),
	CourseName nvarchar(50) not null, 
	CourseDuration int not null
);

create table Registration.ScheduleClass
(
	ScheduleClassId int identity(1,1),
	CourseId int not null,
	StartTime int not null
);

create table Registration.StudentSchedule
(
	StudentScheduleId int identity(1,1),
	StudentId int not null,
	ScheduleClassId int not null
);
go

--alter statement
alter table Registration.Student
	add constraint PK_Student_StudentId primary key clustered (StudentId);
go

alter table Registration.Course
	add constraint PK_Course_CourseId primary key clustered (CourseId);
go

alter table Registration.ScheduleClass
	add constraint PK_ScheduleClass_ScheduleClassId primary key clustered(ScheduleClassId);
go



alter table Registration.ScheduleClass
	add constraint FK_ScheduleClass_CourseId foreign key (CourseId) references Registration.Course(CourseId);
go





alter table Registration.StudentSchedule
	add constraint PK_StudentSchedule_StudentScheduleId primary key clustered(StudentScheduleId);
go

alter table Registration.StudentSchedule
	add constraint FK_StudentSchedule_StudentId foreign key (StudentId) references Registration.Student(StudentId);
go

alter table Registration.StudentSchedule
	add constraint FK_StudentSchedule_ScheduleClassId foreign key (ScheduleClassId) references Registration.ScheduleClass(ScheduleClassId);

go

