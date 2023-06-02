
/*CREATE TABLE Companies
(ID integer primary key,
Name NVarChar(100),
Hiring bit,
Location NVarChar(100))
*/
-- bit = boolean


--insert into Companies (ID, Name, Hiring, Location) values (1, 'Technology', 'True', '1570 Woodward Ave.' )
--insert into Companies (ID, Name, Hiring, Location) values (2, 'Shipping & Receiving', 'False', 'Southfield' )
 
 --delete row
 --delete from Companies where ID = 1

 --delete table
 --drop table Companies
 
 --select * from Companies where Location Like 's%'
 --select * from Companies where Hiring = 1
 
 --select max(ID) from Companies
 --delete from Companies where ID = 2

 --delete from Companies where 1 = 1

 --records with no value
 --select * from Companies where location is null
 -- (or is not null to find opposite)
 
 --select * from Companies
 --inner join Employee on Employee.CompanyID = Company.ID

 --4f?
 --


 --select * from Invoice where InvoiceDate = (
 --select max(Invoicedate) from Invoice)
 --update Invoice Set BillingCity = 'Detroit'
 --where InvoiceDate = (select max(InvoiceDate) from Invoice)

 --select * from Employee where LastName Like 'J%'
 --select * from Invoice where (Total * 100) % 100 = 98
 --select * from Employee where Phone like '313%'
 --select * from Employee where DOB < '1999/09/09' 
 --                                    YYYY/MM/DD
 --update employee set Phone = Null where DOB > '2000/12/31'
 --select * from Employee where Phone = Null
 --join Employee on Employee.DepartmentID = Department.ID


--1)Table creation: Students

	/* CREATE TABLE Students
		(Id integer Identity primary key, 
		FirstName NVarChar(20),
		LastName NVarChar(20),
		Email NVarChar(30),
		Phone NVarChar(30))

--2)Add 5 students

	insert into Students (FirstName, LastName, Email, Phone) values ('Jane', 'Doe', 'jane@example.com', '313-555-0001')
	insert into Students (FirstName, LastName, Email, Phone) values ('James', 'Smith', 'james@example.com', '313-555-0002')
	insert into Students (FirstName, LastName, Email, Phone) values ('Susan', 'Jones', 'susan@example.com', '313-555-0003')
	insert into Students (FirstName, LastName, Email, Phone) values ('Javier', 'Rodriguez', 'javier@example.com', '313-555-0004')
	insert into Students (FirstName, LastName, Email, Phone) values ('DeAndre', 'Taylor', 'deandre@example.com', '313-555-0005')*/

--3)Update student 4

	--Update Students set LastName = 'Chirpus' where Id = 4

--4)Remove student 5

	--Delete from Students where Id = 5

--5)All students named James

	--select * from Students where FirstName = 'James'

--6)First name starting with "J" and Id greater than 3

	--select * from Students where FirstName like 'J%' and Id > 3

--7)Table Creation: Assignments

	/*CREATE TABLE Assignments
		(Id integer Identity primary key, 
		Title NVarChar(40),
		Score TinyInt,
		StudentId Integer)*/

--8)Add assignments

	/*insert into Assignments (Title, Score, StudentId) values ('Geography Quiz', 85, 1)
	insert into Assignments (Title, Score, StudentId) values ('US States Worksheet', 10, 1)
	insert into Assignments (Title, Score, StudentId) values ('Geography Quiz', 92, 4)*/
	
--9)List all assignments

	--select * from Assignments join Students on Assignments.StudentId = Students.Id

--10)First and last names of all students w/ score > 90

	--select FirstName, LastName from Students join Assignments on Assignments.StudentId = Students.Id where Score > 90