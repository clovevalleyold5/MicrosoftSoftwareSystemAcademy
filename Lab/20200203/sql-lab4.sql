--Name: Kaiyuan Wang
--File: sql-lab4.sql
--Date: 20200203

use TSQLV4;

--1
select productid, productname, unitprice
	from Production.Products 
	where unitprice =
	(select max(unitprice) 
		from Production.Products);

--2
select productid, productname 
	from Production.Products 
	where productid = 
	(select top (1) productid 
		from Sales.OrderDetails 
		group by productid
		order by sum(qty) desc);

--3
select empid, firstname, lastname, title 
	from HR.Employees 
	where empid =
	(select top (1) empid 
		from Sales.Orders 
		group by empid 
		order by count(orderid) desc);

--4
select od1.orderid, (od1.unitprice * od1.qty) as linetotoal, 
		(select avg(od2.unitprice * od2.qty) as orderavg 
		from Sales.OrderDetails as od2 
	where od2.orderid = od1.orderid) as orderavg
	from Sales.OrderDetails as od1;

--5
select od1.orderid, od1.productid, od1.qty 
	from Sales.OrderDetails as od1 
	where qty =
		(select max(od2.qty) 
			from Sales.OrderDetails as od2 
			where od1.orderid = od2.orderid) 
	order by orderid;

--6