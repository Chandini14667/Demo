Create database Test

use Test

create table customer(
customerId int primary key,
customerName varchar(20),
age int,
city varchar(40),
email varchar(40)
)

drop table customer

create table orders(
orderId int primary key,
orderedDate date,
amount int,
customerId int references customer(customerId)
)

alter table orders add orderDescription varchar(50)

alter table orders drop column orderDescription

alter table orders drop constraint [FK__orders__customer__5070F446]

alter table orders add constraint fk1 foreign key(customerId) references customer(customerId)

Use Northwind

Select * from Customers

Select CustomerId, ContactName, City, Country from Customers

Select * from Customers where CustomerID='BERGS'

Select * from Customers where City='London'

Select CustomerId, ContactName, City, Country from Customers where ContactTitle='Owner'

Select * from Products where UnitPrice>35

Select * from Customers where City='London' or City='Madrid'

Select * from Customers where Country='Brazil' and City='Sao Paulo'

Select * from Customers where Region is not null

Select * from Customers where not Region is null

Select * from Customers where not Country='Mexico'

Select ProductID, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitPrice*UnitsInStock as Amount, (UnitPrice*UnitsInStock)*10/100
as Discount from Products

Select * from Products where ProductID not between 11 and 20

Select * from Customers where City='London' or City='Madrid' or City='Paris' or City='Berlin'

Select * from Customers where City in ('London', 'Madrid', 'Paris', 'Berlin')

Select * from Customers where ContactName like 'A%'

Select * from Customers where ContactName like 'A_____________'

Select * from Customers where ContactName like '[^ASJ]%'

Select * from Customers where ContactName like 'A%S'

Select top 10 * from Customers

Select * from Customers Order By ContactName Desc

Select * from Customers

Select * from Customers Order By CustomerID offset 10 rows fetch next 5 rows only

Select distinct ContactTitle from Customers