use Northwind;

--1
select EmployeeID,
count(EmployeeID) as totalsales
from Orders
group by EmployeeID;

--2
select ProductID, avg(Discount) as avgDiscount, ProductID, UnitPrice
from [Order Details]
where UnitPrice > 50.0
group by ProductID, UnitPrice
order by UnitPrice desc;

--3
select ShipCountry, count(OrderID) as ordernumber
from Orders
group by ShipCountry
having count(OrderID) > 10
order by ordernumber;

--4
select OrderID, ShippedDate, OrderDate, datediff(day, OrderDate, ShippedDate) as lagdays
from orders
order by lagdays;

--5
select Shipvia, avg(datediff(day, OrderDate, ShippedDate)) as avglagdays
from Orders 
group by ShipVia;

--6
select ProductName, UnitPrice * UnitsInStock as totalprice 
from Products
order by ProductName;

--7
select sum(UnitPrice * UnitsInStock) as dollartotal
from Products;

--8
select CustomerID, EmployeeID, count(CustomerID) as customernumber
from Orders 
group by EmployeeID, CustomerID
having count(CustomerID) > 4
order by customernumber;

--9
select datediff(day, '2014-04-10', '2019-04-09');

--10
select getdate();
select datefromparts(year(getdate()), month(getdate()), +1);
select datefromparts(year(getdate()), month(getdate()) + 1, +1);
select eomonth(getdate());