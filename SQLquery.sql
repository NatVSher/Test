SELECT Products.Name AS ���_��������, Categories.Name AS ���_���������
FROM Products
LEFT JOIN Products_Categories ON Products.Id = Products_Categories.ProductId
LEFT JOIN Categories ON Products_Categories.CategoryId = Categories.Id