# Задание №2. Продукты и Категории
У нас имеются 3 таблицы (Прим.: в задании не указано, но будем считать,что для связи таблиц Продуктов и Категорий присутствует связающая таблица "Linking"). Тогда получим:

Код задания:
````
SELECT p.name AS Product, c.CatName AS Category FROM Prods AS p
FULL JOIN Linking AS l ON p.Id = l.ProdID
LEFT JOIN Cats AS c ON c.ID = l.CatID
ORDER BY Product;
````
P.S Вместо FULL JOIN можно использовать LEFT JOIN , однако в данной задаче разницы нет, т.к продукты всеравно берутся из таблицы Prods
