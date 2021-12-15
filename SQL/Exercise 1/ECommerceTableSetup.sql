--create database ECommmerceSampleDB

use ECommmerceSampleDB

create table Customers (
	CustomerId int Primary Key,
	CustomerName varchar(50),
	ShippingAddress varchar(100),
	Balance float,
	CreditLimit float
)

create table Orders (
	OrderId int Primary key,
	CustomerId int foreign key references Customers(CustomerId),
	OrderDate date,
	ShipppingAddress varchar(100)
)

create table Items (
	ItemId int Primary Key,
	ItemName varchar(50),
	ItemDescription varchar(1000),
	Stock int
)

create table Factories (
	FactoryId int Primary Key,
	FactoryName varchar(50),
	ItemId int Foreign Key References Items(ItemId)	
)

select * from Customers
select * from Orders
select * from Items
select * from Factories