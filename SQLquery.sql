SELECT Products.Name AS Имя_продукта, Categories.Name AS Имя_категории
FROM Products
LEFT JOIN Products_Categories ON Products.Id = Products_Categories.ProductId
LEFT JOIN Categories ON Products_Categories.CategoryId = Categories.Id
