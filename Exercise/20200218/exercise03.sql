use TSQLV4;
--1
select ood.customernumber, ood.orderyear, ood.numberofdistinctproduct
	from 
	(
	select custid as customernumber, year(orderdate) as orderyear, count(distinct productid) as numberofdistinctproduct
		from Sales.Orders as o
		join Sales.OrderDetails as od
		on o.orderid = od.orderid 
		group by year(orderdate), custid
	) as ood

--2
with number2 (productid, orderyear, country) as
(
	select productid, year(orderdate) as orderyear, country
	from Sales.OrderDetails as od
	join Sales.Orders as o
	on o.orderid = od.orderid
	join Sales.Customers as c
	on c.custid = o.custid
)
select country, orderyear, count(distinct productid) as numberofdistinctproduct from number2
group by orderyear, country;


--3
drop view if exists dbo.number3;
go
create view dbo.number3
as

select c.country, year(o.orderdate) as orderyear, sum(od.unitprice * od.qty) as totaldollaramountspent
	from Sales.Customers as c
	join Sales.Orders as o
	on c.custid = o.custid
	join Sales.OrderDetails as od
	on od.orderid = o.orderid
	group by c.country, year(o.orderdate);
go

select * from dbo.number3 order by country;