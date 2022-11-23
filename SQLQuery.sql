CREATE TABLE categories
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	CategoryName NVARCHAR(30) NOT NULL,
);
CREATE TABLE products
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	ProductName NVARCHAR(30) NOT NULL,
);
INSERT INTO products 
VALUES
('Chicken drumsticks'),
('Coca-Cola'),
('Bud'),
('Tent'),
('Shovel'),
('Axe'),
('Bread'),
('GeForce RTX 4090'),
('Boilersuit'),
('iPhone 22SMAX')

INSERT INTO categories 
VALUES
('Food'),
('Stuff for home'),
('Stuff for rest'),
('Expensive stuff')

CREATE TABLE productList
(
	ProductId INT FOREIGN KEY REFERENCES products(Id),
	CategoryId INT FOREIGN KEY REFERENCES categories(Id),
	PRIMARY KEY(ProductId, CategoryId)
);
INSERT INTO productList(ProductId, CategoryId) 
VALUES 
(1, 1),
(1, 2),
(1, 3),
(2, 2),
(2, 3),
(3, 2),
(3, 3),
(4, 3),
(5, 2),
(5, 3),
(6, 2),
(6, 3),
(7, 1),
(7, 2),
(7, 3),
(8, 4),
(10, 4)
SELECT ProductName, CategoryName
FROM products
LEFT JOIN productList
	ON products.Id = productList.ProductId
LEFT JOIN categories
	ON productList.CategoryId = categories.id
