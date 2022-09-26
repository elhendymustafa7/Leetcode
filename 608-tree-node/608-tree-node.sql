SELECT
    id AS 'Id',
    CASE
        WHEN id = (SELECT id FROM tree  WHERE p_id IS NULL)
          THEN 'Root'
        WHEN id IN (SELECT distinct p_id FROM tree )
          THEN 'Inner'
        ELSE 'Leaf'
    END AS Type
FROM
    tree
ORDER BY 'Id'