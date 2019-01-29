SELECT   p.name AS product_name,
         c.name AS category_name
FROM     (SELECT 1 AS p_id,
                 1 AS c_id          
          UNION ALL
          SELECT 1,
                 3
          UNION ALL
          SELECT 2,
                 1
          UNION ALL
          SELECT 2,
                 3
          UNION ALL
          SELECT 3,
                 2) l --links
         RIGHT JOIN (SELECT 1 AS id,
                            'apple' AS name
                     UNION ALL
                     SELECT 2,
                            'pineapple'
                     UNION ALL
                     SELECT 3,
                            'pen'
                     UNION ALL
                     SELECT 4,
                            'car') p --products
           ON l.p_id = p.id
         LEFT JOIN (SELECT 1 AS id,
                           'fruits' AS name
                    UNION ALL
                    SELECT 2,
                           'stationery'
                    UNION ALL
                    SELECT 3,
                           'food') c --categories
           ON l.c_id = c.id
ORDER BY 1,
         2