--create table dbo.Student 
--(
--	Id int primary key identity,
--	Name nvarchar(50) null,
--	Gender nvarchar(10) null,
--	Age int null,
--	University int null,
	
--	constraint FK_Student_University foreign key (University) references University(Id) on delete cascade,
--)

--create table Lecture
--(
--	Id int primary key identity,
--	Name nvarchar(50) NOT NULL,
--)

--create table Student_Lecture
--(
--	Id int primary key identity,
--	StudentId int NOT NULL,
--	LectureId int NOT NULL,

--	constraint FK_StudentLecture_Student foreign key (StudentId) references Student(Id) on delete cascade,
--	constraint FK_StudentLecture_Lecture foreign key (LectureId) references Lecture(Id) on delete cascade,
--)

select * from University
