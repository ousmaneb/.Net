use Northwind
go

SELECT RANK() OVER (ORDER BY TotCnt DESC) AS TopCustomers, CustomerID, TotCnt
FROM (SELECT CustomerID, COUNT(*) AS TotCnt
FROM Orders Group BY CustomerID) AS Cust
go



SELECT DENSE_RANK() OVER (ORDER BY TotCnt DESC) AS TopCustomers, CustomerID, TotCnt
FROM (SELECT CustomerID, COUNT(*) AS TotCnt
FROM Orders Group BY CustomerID) AS Cust
go


 select dept_id, count(*) as counter
  from emp
  group by dept_id
  order by counter desc
  limit 1
) as maxcount


Select Id, Name from Dept
Where Id = (Select Top(1) DeptId from Emp 
            Group By DeptId
            order by Count(DeptId) desc)


 accepted
	

Just a little more verbose than the other two solutions, but it will get the job done...feel free to tweak to your convenience.

select countbydept.*
from
(
  -- from EMP table, let's count number of records per dept
  -- and then sort it by count (highest to lowest)
  -- and take just the first value. We just care about the highest
  -- count
  select dept_id, count(*) as counter
  from emp
  group by dept_id
  order by counter desc
  limit 1
) as maxcount

inner join

(
  -- let's repeat the exercise, but this time let's join
  -- EMP and DEPT tables to get a full list of dept and 
  -- employe count
  select
    dept.id,
    dept.`name`,
    count(*) as numberofemployees
  from dept
  inner join emp on emp.dept_id = dept.id
  group by dept.id, dept.`name`
) countbydept