CREATE VIEW "Products  Less Than Average Price" AS SELECT * FROM Products1 where UnitPrice<(SELECT avg(UnitPrice) from Products1);
SELECT * FROM "Products  Less Than Average Price"
EXEC sp_rename "Products  Less Than Average Price","Low Cost Products"
DROP VIEW "Low Cost Products"