SELECT 
    p.Name AS 'Продукт'
    ,c.Name AS 'Категория'
FROM Products p
LEFT JOIN ProductCategories pc 
    ON p.Id = pc.ProductId
LEFT JOIN Categories c 
    ON pc.CategoryId = c.Id;