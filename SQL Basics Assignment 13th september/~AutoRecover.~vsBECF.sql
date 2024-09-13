Use  ShoppingCartDb

CREATE TABLE Products(ProductId INT PRIMARY KEY,
PName varchar(50) NOT NULL,
QuantityInStock INT NOT NULL,
UnitPrice INT NOT NULL,
Category varchar(50) NOT NULL,
CONSTRAINT CHK_Products_QuantityInStock CHECK(QuantityInStock>0),
CONSTRAINT CHK_Products_UnitPrice CHECK(UnitPrice>0)
)

INSERT INTO Products VALUES(1,'outlook',2,3000,'software')
INSERT INTO Products VALUES(2,'hp',1,30000,'electronics')
INSERT INTO Products VALUES(3,'dell',1,35000,'electronics')
INSERT INTO Products VALUES(4,'pen',2,30,'stationery')
INSERT INTO Products VALUES(5,'pencil',2,30,'stationery')

DROP TABLE Products


CREATE TABLE Users(
UserID INT NOT NULL,
UserName varchar(50),
Password varchar(50),
ContactNumber BIGINT,
City varchar(50)
)

DROP TABLE Users
INSERT INTO Users VALUES(1,'tanishq','tanishq@123',1234567890,'Hyderabad')
INSERT INTO Users VALUES(2,'tan','tan@123',2748390483,'Bangalore')
INSERT INTO Users VALUES(3,'tanisq','tanisq@123',1234567240,'Mumbai')
INSERT INTO Users VALUES(4,'tanish','tanish@123',538295380,'Chennai')
INSERT INTO Users VALUES(5,'tanshq','tanshq@123',1116140375,'Delhi')

CREATE TABLE Cart(Id INT UNIQUE NOT NULL,
CartId INT NOT NULL,
ProductId INT,
Quantity INT NOT NULL ,
CONSTRAINT CHK_Cart_Quantity CHECK(Quantity>0),
CONSTRAINT FK_Cart_ProductId FOREIGN KEY(ProductId) REFERENCES Products(ProductId)
ON DELETE CASCADE
ON UPDATE CASCADE)

INSERT INTO Cart VALUES(1,1,1,1116)
INSERT INTO Cart VALUES(2,1,2,4050)
INSERT INTO Cart VALUES(3,2,3,4004)
INSERT INTO Cart VALUES(4,2,4,4005)


DROP TABLE Cart

Select * FROM Products 
SELECT * FROM Products where Category='Electronics'
SELECT * FROM Products where QuantityInStock=0
SELECT * FROM Products where UnitPrice BETWEEN 1000 AND 10000
SELECT * FROM Products where ProductId=4
SELECT * FROM Cart where CartId=2
SELECT * FROM Cart where CartId  IN (SELECT ProductId FROM Products)
SELECT * FROM Users
SELECT * FROM Users where ContactNumber=1234567890
SELECT * FROM Users where UserId=1