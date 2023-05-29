select * from Products 
select sum(UnitPrice) from Products 
select min(UnitPrice) from Products 
select max(UnitPrice) from Products 
select count(UnitPrice) from Products 

select char(75)
select left('Chandini',5)
select len('Chandini')
select reverse('Chandini')
select * from Products 
select len(ProductName) as LengthPN from Products 
select left(ProductName,3) as LeftPN from Products 
select reverse(ProductName) as ReversePN from Products 

select getdate()
select dateadd(mm,3,'2001-09-02')
select day('2001-09-02')
select month('2001-09-02')
select year('2001-09-02')
select datediff(yyyy,'1991-08-15','2001-09-02')
select*from Orders 
select dateadd(dd,2,ShippedDate) from Orders
select day(ShippedDate) from Orders

select power(24,3)
select round(2.43,0)
select round(2.43,1)
select round(2.53,0)
select round(2.53,1)
select ceiling(2.43)
select ceiling(2.53)
select floor(2.43)
select floor(2.53)

select * from Products 
select SupplierID, SUM(UnitsInStock) as TotalStock from Products group by SupplierID having SupplierID=5

select Customers.CustomerID, ContactName, ContactTitle, OrderId, OrderDate, ShippedDate from Customers inner join Orders on 
Customers.CustomerID=Orders.CustomerID
select Customers.CustomerID, ContactName, ContactTitle, OrderId, OrderDate, ShippedDate from Customers left outer join Orders on 
Customers.CustomerID=Orders.CustomerID
select Customers.CustomerID, ContactName, ContactTitle, OrderId, OrderDate, ShippedDate from Customers right outer join Orders on 
Customers.CustomerID=Orders.CustomerID
select Customers.CustomerID, ContactName, ContactTitle, OrderId, OrderDate, ShippedDate from Customers full outer join Orders on 
Customers.CustomerID=Orders.CustomerID
 
