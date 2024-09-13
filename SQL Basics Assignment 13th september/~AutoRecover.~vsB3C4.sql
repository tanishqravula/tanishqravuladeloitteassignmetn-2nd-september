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
SELECT c.CartId,p.PName,c.Quantity,p.UnitPrice from cart c INNER JOIN products p on c.ProductId=p.ProductId;
SELECT c.CartId,p.PName,c.Quantity,p.UnitPrice from cart c RIGHT OUTER JOIN products p on c.ProductId=p.ProductId;
SELECT c.CartId,p.PName,c.Quantity,p.UnitPrice from cart c LEFT OUTER JOIN products p on c.ProductId=p.ProductId;
SELECT c.CartId,p.PName,c.Quantity,p.UnitPrice from cart c  FULL OUTER JOIN products p on c.ProductId=p.ProductId;

CREATE TABLE Student(
studentid INT UNIQUE NOT NULL,
studentname varchar(50) NOT NULL,
coursename varchar(50),
cityname varchar(50)
)

INSERT INTO Student VALUES(1,'tanishq','Angular','Hyderabad')
INSERT INTO Student VALUES(2,'tanshq','React','Hyderabad')
INSERT INTO Student VALUES(3,'anishq','.NET','Bangalore')
INSERT INTO Student VALUES(4,'tanisq','.NET','Bangalore')
INSERT INTO Student VALUES(5,'taishq','Angular','Chennai')
INSERT INTO Student VALUES(6,'tanhq','React','Mumbai')
INSERT INTO Student VALUES(7,'tanishq','React','Pune')
INSERT INTO Student VALUES(8,'tansshq','Angular','Bangalore')
INSERT INTO Student VALUES(9,'tanish','.NET','Hyderabad')
INSERT INTO Student VALUES(10,'tanisq','React','Hyderabad')
SELECT  count(*) from Student where coursename='Angular';
SELECT count(*) from Student where cityname='Hyderabad';
Select cityname as City,count(*) as No_of_Students from Student group by cityname;
Select coursename as Course,count(*) as No_of_Students from Student group by coursename;
Select cityname as City,coursename as Course,count(*) as No_of_Students from Student group by cityname,coursename;
Select * FROM Products WHERE ProductId IN (Select ProductId FROM Cart);
SELECT * FROM Cart Where ProductId IN (Select ProductId FROM Products WHERE UnitPrice>5000);