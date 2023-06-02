/*Create Table Employee
(ID integer identity primary key,
SSN nvarchar(15),
DOB date,
Phone nvarchar (15),
FirstName nvarchar (30),
LastName nvarchar (50),
Department nvarchar (20))

insert into Employee (SSN, DOB, Phone, FirstName, LastName, Department) values ('123456789', '1/5/1975', '3135555505', 'Charles', 'Charleston', 'Shipping & Receiving')
insert into Employee (SSN, DOB, Phone, FirstName, LastName, Department) values ('987654321', '5/2/1990', '2489995555', 'Jimmy', 'Scrambles', 'Technology')
insert into Employee (SSN, DOB, Phone, FirstName, LastName, Department) values ('456789123', '8/6/2001', '7895555525', 'Vince', 'Jabowski', 'Technology')
insert into Employee (SSN, DOB, Phone, FirstName, LastName, Department) values ('654854632', '4/6/1988', '3139721400', 'John', 'Johnston', 'Shipping & Receiving')
*/
select * from Employee;