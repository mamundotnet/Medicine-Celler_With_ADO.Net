USE [master]
GO
CREATE DATABASE Medicine_cellDB
 
GO
USE Medicine_cellDB
GO

CREATE TABLE companyInfo
(
	companyId int NOT NULL PRIMARY KEY,
	companyName varchar (50) NOT NULL
)
GO

CREATE TABLE medicineForm
(
	formId int PRIMARY KEY NOT NULL,
	formName varchaR(50) NOT NULL
)
GO

CREATE TABLE Position
(
	PositionId int PRIMARY KEY NOT NULL,
	PositionName nvarchar(50) not null
)
GO
Insert into Position Values (1,'Sales Represetive')
Insert into Position Values (2,'Pharmacist')
Insert into Position Values (3,'Medical officer')
Insert into Position Values (4,'Product Manager')
Insert into Position Values (5,'ConsulTant')

CREATE TABLE medicine
(
	medicineId int PRIMARY KEY NOT NULL,
	medicineName varchar(50) NOT NULL,
	companyId int REFERENCES companyInfo(companyId),
	formId int references medicineForm(formId),
	medicineImage varbinary (max) ,
	MRP money NOT NULL
)
GO

CREATE TABLE medicineSupplier
(
	id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	medicineId int references medicine(medicineId),
	supplierName varchar(50) NOT NULL,
	PositionId int references Position(PositionId)	
)
GO

CREATE TABLE purchase
(
	purchaseId int PRIMARY KEY NOT NULL,
	medicineId int,
	quantity int NOT NULL,
	unitPrice money NOT NULL,
	purchaseDate date NOT NULL
)
GO
