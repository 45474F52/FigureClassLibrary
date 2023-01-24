# Задание 2:
## Запрос на выборку данных:
```SQL
USE MindboxTask

SELECT Products.[Name] AS [Product Name], Categories.[Name] AS [Category Name]
FROM ProductsCategories
	LEFT JOIN Products ON ProductsCategories.[ProductId] = Products.[Id]
	LEFT JOIN Categories ON ProductsCategories.[CategoryId] = Categories.[Id]
```

### Вывод следующий:
| | Product Name | Category Name |
|---:|-----:|-----:|
|1|Продукт_1|Категория_1|
|2|Продукт_1|Категория_2|
|3|Продукт_2|Категория_3|
|4|Продукт_3|Категория_3|
|5|Продукт_4|NULL|

<details>
<summary>Запрос на создание таблиц</summary>

```SQL
CREATE TABLE [Products]
(
	[Id] INT PRIMARY KEY,
	[Name] NVARCHAR(20) NOT NULL
)
GO
CREATE TABLE [Categories]
(
	[Id] INT PRIMARY KEY,
	[Name] NVARCHAR(20) NOT NULL
)
GO
CREATE TABLE [ProductsCategories]
(
	[ProductId] INT FOREIGN KEY REFERENCES [Products] NOT NULL,
	[CategoryId] INT FOREIGN KEY REFERENCES [Categories] NULL
)
GO
INSERT INTO [Products] VALUES
(1, N'Продукт_1'),
(2, N'Продукт_2'),
(3, N'Продукт_3'),
(4, N'Продукт_4')
INSERT INTO [Categories] VALUES
(1, N'Категория_1'),
(2, N'Категория_2'),
(3, N'Категория_3')
INSERT INTO [ProductsCategories] VALUES
(1, 1),
(1, 2),
(2, 3),
(3, 3),
(4, NULL)
```

</details>
