/* Write your T-SQL query statement below */
select id , 'Root' as Type from tree
where p_id is  null
union
select id , 'Inner' as Type from tree
where p_id is not null and id in (select distinct P_id from tree where  p_id is not null )
union
select id , 'Leaf' as Type from tree
where p_id is not null and id not in (select distinct P_id from tree  where  p_id is not null)
ORDER BY id;