create database RainbowSchool
use RainbowSchool

create table Student
(Id int identity not null,
Name nvarchar(100) not null,
Address nvarchar(100) not null,
Email nvarchar(75) not null,
Class nvarchar(5) not null)

create table Class
(Id int not null,
Name nvarchar(5) not null)

create table Subjects
(Id int not null,
Name nvarchar(50) not null)

insert into student (name, class, address, email) values 
('Tom', '7a', 'Delhi', 'tom@email.com')
insert into student (name, class, address, email) values 
('Thomas', '7b', 'Mumbai', 'thomas@email.com')
insert into student (name, class, address, email) values 
('Manuel', '7c', 'Bangalore', 'manuelm@email.com')
insert into student (name, class, address, email) values 
('Sam', '8a', 'Delhi', 'sam@email.com')
insert into student (name, class, address, email) values 
('Arun', '8b', 'Mumbai', 'arun@email.com')
insert into student (name, class, address, email) values 
('Amit', '9a', 'Kolkata', 'amit@email.com')
insert into student (name, class, address, email) values 
('Deep', '9a', 'Chennai', 'deep@email.com')
insert into student (name, class, address, email) values 
('Sharan', '9a', 'Hyderabad', 'sharan@email.com')
select * from student

insert into Class values(1,'7a')
insert into Class values(2,'7b')
insert into Class values(3,'7c')
insert into Class values(4,'8a')
insert into Class values(5,'9a')
select * from Class

insert into Subjects values(1,'Science')
insert into Subjects values(2,'Maths')
insert into Subjects values(3,'Social')
insert into Subjects values(4,'English')
select * from Subjects




