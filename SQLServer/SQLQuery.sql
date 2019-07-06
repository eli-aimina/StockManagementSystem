--create database StockManagementSystem;
--use StockManagementSystem;



create table Category
( ID int Identity(1,1) Primary key,
Name varchar(100)

)
 Select * from Category;

 create table Company
 ( ID int Identity(1,1) primary key,
 Name varchar(100)
 );

 create table Item 
 ( ID int Identity(1,1) primary key,
 Name varchar (100),
 ReorderLevel int default 0 ,
 CategoryID int Foreign key References Category(ID),
 CompanyID int foreign key References Company(ID)

 );
 create table StockIn 
 ( ID int Identity(1,1) primary key,
   SiQuantity int ,
   CreatedDate date default getdate(),
   ItemID int foreign key References Item(ID)
)

create table StockOut
 ( ID int Identity(1,1) primary key,
   SoQuantity int ,
   SoType int ,
   CreatedDate date default getdate(),
   ItemID int foreign key References Item(ID)
)

select * from Category order by id desc;
UPDATE Category set Name='Notebook' where ID=2;
DELETE FROM Category WHERE ID=4;

SELECT count(*) from Category where Name='Mobile kk'

Insert into Company (Name) values('Huwei')  
Insert into Company (Name) values('Lenovo')  
Insert into Company (Name) values('Nokia')  
Insert into Company (Name) values('Samsung')  

select * from Company;
select * from Item;
select * from Category;

Create view ItemView AS
select i.ID, i.Name, i.ReorderLevel, c.Name as Category, co.Name as Company  from Item i
join Category c ON c.ID = i.CategoryID
join Company co ON co.ID = i.CompanyID

select * from ItemView;

select * from Item;
select * from StockOut;

alter table StockOut alter column SoType varchar(20); -- Change column type from "int" to "varchar"

insert into StockOut (SoQuantity, SoType, CreatedDate, ItemID) values (10, 'Sold', GETDATE(), 1)
insert into StockOut (SoQuantity, SoType, CreatedDate, ItemID) values (5, 'Damaged', GETDATE(), 2)
insert into StockOut (SoQuantity, SoType, CreatedDate, ItemID) values (8, 'Sold', GETDATE(), 2)

insert into StockOut (SoQuantity, SoType, CreatedDate, ItemID) values (2, 'Lost', '2019-07-05', 2)
insert into StockOut (SoQuantity, SoType, CreatedDate, ItemID) values (6, 'Damaged', '2019-07-04', 2)
insert into StockOut (SoQuantity, SoType, CreatedDate, ItemID) values (4, 'Sold', '2019-07-05', 1)

insert into StockOut (SoQuantity, SoType, CreatedDate, ItemID) values (4, 'Sold', '2019-07-03', 1)
insert into StockOut (SoQuantity, SoType, CreatedDate, ItemID) values (7, 'Sold', '2019-07-04', 2)
insert into StockOut (SoQuantity, SoType, CreatedDate, ItemID) values (12, 'Damaged', '2019-07-03', 1)


alter view StockOutView AS
select i.Name as Item, c.Name as Company, so.SoQuantity, so.SoType, so.CreatedDate 
from StockOut so
join Item i ON i.ID = so.ItemID
join Company c on c.id = i.CompanyID;

select * from StockOutView
select Item, Company, SoQuantity from StockOutView where SoType='Sold' AND CreatedDate BETWEEN  '2019-07-04' AND '2019-07-06'











