/* Write your T-SQL query statement below */
SELECT employee_id,
CASE 
	when  employee_id % 2 != 0 and name not like 'm%' then salary *100 /100
	else salary * 0
end as bonus 
from Employees order by employee_id