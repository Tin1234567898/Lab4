CREATE DATABASE QuanLySinhVien 
USE QuanLySinhVien 

CREATE TABLE Faculties (
    FacultyID INT PRIMARY KEY,
    FacultyName NVARCHAR(100) NOT NULL
);

CREATE TABLE Students (
    StudentID NVARCHAR(10) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    AverageScore FLOAT NOT NULL,
    FacultyID INT FOREIGN KEY REFERENCES Faculties(FacultyID)
);

INSERT INTO Faculties (FacultyID, FacultyName) 
VALUES (1, N'Công Nghệ Thông Tin'), 
	   (2, N'Ngôn Ngữ Anh'),
	   (3, N'Quản Trị Kinh Doanh');

SELECT * FROM Faculties

INSERT INTO Students (StudentID, FullName, AverageScore, FacultyID) 
VALUES ('1611061916', N'Nguyễn Trần Hoàng Lan', 4.5, 1), 
       ('1711060596', N'Đàm Minh Đức', 2.5, 1),
	   ('1711061004', N'Nguyễn Quốc An', 10, 2);

SELECT * FROM Students

ALTER TABLE Students ADD Gender NVARCHAR(10) NULL;

UPDATE Students SET Gender = 'Female' WHERE StudentID = '1611061916';
UPDATE Students SET Gender = 'Male' WHERE StudentID = '1711060596';
UPDATE Students SET Gender = 'Male' WHERE StudentID = '1611061916';

ALTER TABLE Faculties ADD TotalProfessor INT DEFAULT 0;

Select TotalProfessor
From Faculties

