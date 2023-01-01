CREATE TABLE Products (
	ProductId INT PRIMARY KEY,
	ProductName TEXT
);

INSERT INTO Products
VALUES
	(1, '������'),
	(2, '��������'),
	(3, '�����'),
	(4, '������'),
	(5, '���������'),
	(6, '����');

CREATE TABLE Categories (
	CategoryId INT PRIMARY KEY,
	CategoryName TEXT
);

INSERT INTO Categories
VALUES
	(1, '�����'),
	(2, '������'),
	(3, '�����');

CREATE TABLE ProductCategories (
	Product_Id INT FOREIGN KEY REFERENCES Products(ProductId),
	Category_Id INT FOREIGN KEY REFERENCES Categories(CategoryId),
	PRIMARY KEY (Product_Id, Category_Id)
);

INSERT INTO ProductCategories
VALUES
	(1, 2),
	(2, 3),
	(3, 2),
	(4, 3),
	(5, 1);

SELECT P.ProductName, C.CategoryName
FROM Products P
LEFT JOIN ProductCategories PC
	ON P.ProductId = PC.Product_Id
LEFT JOIN Categories C
	ON PC.Category_Id = C.CategoryId;