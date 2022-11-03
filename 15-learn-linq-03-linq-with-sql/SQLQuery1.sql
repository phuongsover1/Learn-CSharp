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

--select * from Student

--exec sp_rename 'Student.University', 'UniversityId', 'COLUMN'

--alter table Student
--drop constraint FK_Student_University

--alter table Student 
--add constraint FK_Student_University foreign key (UniversityId) references University(Id) on delete cascade

--select * from University
--select * from Lecture

--select * from Lecture
--select * from Student

--select * from Student
--select * from Lecture
--select * from Student_Lecture
--select * from Student

--delete from Student_Lecture where Id = 3 or Id = 4

--insert Student_Lecture(StudentId, LectureId)
--values
--(6,1)

--insert Student
--values('Phuong', 'male', 22, 7),
--('Hoa', 'female', 23, 7)
update Student set UniversityId = 8 where Name = 'Phuong' or Name = 'Hoa'
select * from Student




