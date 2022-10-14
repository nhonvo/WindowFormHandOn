Create database StudentDB
go
use StudentDB
go

create table Classes
(
	id char(3) not null primary key,
	[name] nvarchar(30) not null,

)
create table Student
(
	id char(6) not null primary key,
	[name] nvarchar(40),
	[day] char(10),
	[classId] char(3),
	foreign key (ClassId) references Classes(Id)
)