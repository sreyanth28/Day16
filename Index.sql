USE NFSDB;

create table NewEmployee(
EmpId INT,
Name varchar(50),
Salary INT,
DeptID INT);

--inserting values
INSERT INTO NewEmployee (EmpId, Name, Salary, DeptID)
VALUES
(101, 'Ravi', 50000, 1),
(102, 'Sneha', 60000, 2),
(103, 'Arjun', 45000, 1),
(104, 'Priya', 70000, 3),
(105, 'Kiran', 55000, 2);

select * from NewEmployee;

SELECT * FROM NewEmployee
WHERE Salary > 60000;

--indexxx
CREATE INDEX idx_salary ON NewEmployee(Salary);

SELECT * FROM NewEmployee
WHERE Salary > 60000;

EXECUTE sp_helpindex 'NewEmployee' ;
--Types of indexing in SQL Server:
   --1. Clustered Index: A clustered index determines the physical order of data in a table. There can be only one clustered index per table, and it is typically created on the primary key column. 
   --It allows for fast retrieval of data based on the indexed column.  
   --2. Non-Clustered Index: A non-clustered index is a separate structure from the data table that contains a copy of the indexed columns and a pointer to the actual data rows.
   --A table can have multiple non-clustered indexes, and they are used to improve query performance by allowing the database engine to quickly locate data based on the indexed columns.

   dROP INDEX idx_salary ON NewEmployee;
   --After usage delete to freee resources

   SET STATISTICS TIME ON;
   SET STATISTICS IO ON;
   SET STATISTICS PROFILE ON;