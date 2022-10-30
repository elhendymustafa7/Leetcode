/* Write your T-SQL query statement below */
select user_id AS buyer_id,join_date,count(o.buyer_id)as orders_in_2019   from Users u
left join Orders o
on u.user_id =o.buyer_id and year(order_date) =2019
group by user_id , join_date
order by user_id