CREATE DATABASE QuanLySinhVien;
GO

USE QuanLySinhVien;
GO
Create table  Faculty 
(
	 FacultyID  Integer NOT NULL,
	 FacultyNme  Nvarchar(200) NULL,
Primary Key ( FacultyID )
) 
go

Create table  Student 
(
	 StudentID  Nvarchar(20) NOT NULL,
	 FullName  Nvarchar(200) NULL,
	 AverageScore  Float NULL,
	 FacultyID  Integer NOT NULL,
Primary Key ( StudentID )
) 
go


Alter table  Student  add  foreign key( FacultyID ) references  Faculty  ( FacultyID )  on update no action on delete no action 
go


INSERT INTO Faculty (FacultyID, FacultyNme)
VALUES 
(1, N'Công nghệ thông tin'),
(2, N'Kinh tế'),
(3, N'Kỹ thuật điện tử');


INSERT INTO Student (StudentID, FullName, AverageScore, FacultyID)
VALUES
(1611061916, N'Nguyễn Trần Hoàng Lan', 4.5, 1),
(1711060596, N'Đàm Minh Đức', 2.5, 1),
(1711061004, N'Nguyễn Quốc An', 10, 2);



ALTER TABLE  Faculty 
ADD  TotalProfessor  INTEGER NULL;