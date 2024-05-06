SELECT 
    p.Name AS '�������'
    ,c.Name AS '���������'
FROM Products p
LEFT JOIN ProductCategories pc 
    ON p.Id = pc.ProductId
LEFT JOIN Categories c 
    ON pc.CategoryId = c.Id;