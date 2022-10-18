select customer_number from orders
group by customer_number
order by count(customer_number) DESC, 1  OFFSET 0 ROWS fetch next 1 rows only