--Step 1
GO
CREATE DATABASE WarehouseExerciseDB
GO

USE WarehouseExerciseDB

--Step 2
CREATE TABLE Warehouses (
	warehouseId int IDENTITY(1,1) PRIMARY KEY,
	place varchar(100),
	capacity int,
)

CREATE TABLE Boxes (
	refNumber char(5) PRIMARY KEY,
	content varchar(100),
	price float, -- Changed to float from int
	warehouseId int FOREIGN KEY REFERENCES Warehouses(warehouseId),
)
--Step 3
ALTER TABLE Warehouses
ADD city varchar(80)

--Step 4
DROP TABLE Boxes

--Step 5
CREATE TABLE Boxes (
	refNumber char(5) PRIMARY KEY,
	content varchar(100),
	price float, -- Changed to float from int
	warehouseId int FOREIGN KEY REFERENCES Warehouses(warehouseId),
)

--Step 6
INSERT INTO Warehouses (place)
VALUES	('Cincinatti'), 
		('Jacksonville'), 
		('Milwaukee'), 
		('Dallas'), 
		('Los Angeles'),
		('Chicago')

--Step 7
INSERT INTO Boxes (refNumber, content, price, warehouseId)
VALUES	('00001', 'Toys', 20, 1), 
		('00002', 'Games', 20, 2 ), 
		('00003', 'Appliances', 20, 3), 
		('00004', 'Tools', 20, 4), 
		('00005', 'Cooking Equipment', 20, 5),
		('00006', 'Furniture', 20, 6),
		('00007', 'Furniture', 20, 6),
		('00008', 'Furniture', 20, 6),
		('00009', 'Furniture', 20, 6),
		('00010', 'Furniture', 20, 6)

--Step 8 -- Not executing because it will cause errors later.
--GO
--EXEC sp_rename 'Warehouses', 'warehouse';
--GO

--Step 9
SELECT * FROM Warehouses

--Step 10
SELECT refNumber, content, price FROM Boxes

--Step 11
UPDATE Boxes
SET price += 200

--Step 12
SELECT * FROM Boxes

--Step 13
SELECT content FROM Boxes

--Step 14
INSERT INTO Warehouses (place, capacity)
VALUES ('Barcelona', 5)

--Step 15
INSERT INTO Boxes (refNumber, content, price, warehouseId)
VALUES ('BCHS1', 'Paper', 3500, 3)