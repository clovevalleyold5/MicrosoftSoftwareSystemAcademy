--Name: Kaiyuan Wang
--File: sql-lab5.sql
--Date: 20200204

use TSQLV4;

--1
select SOSS.orderid, SOSS.shipperid, SOSS.shippername, SOSS.orderdate, SOSS.shipcity 
	from (
		select SS.companyname as shippername, SS.shipperid, SO.orderid, SO.orderdate, SO.shipcity
			from Sales.Orders as SO 
			join Sales.Shippers as SS
			on SO.shipperid = SS.shipperid) as SOSS;

--2
select SO.customerid, SO.theyear, SO.numberoforders
	from (
		select O.custid as customerid, year(O.orderdate) as theyear, count(O.orderid) as numberoforders
			from Sales.Orders as O
			group by O.custid, year(O.orderdate)) as SO
	order by customerid, theyear;

--3
select Cur.orderyear, Cur.orderamount as curorders, Prv.orderdamount as prvorders, Cur.orderamount - Prv.orderdamount as growth
	from(
		select year(orderdate) as orderyear, count(orderid) as orderamount
			from Sales.Orders
			group by year(orderdate)) as Cur
		left outer join(
		select year(orderdate) as orderyear, count(orderid) as orderdamount
			from Sales.Orders
			group by year(orderdate)) as Prv
		on Cur.orderyear = Prv.orderyear + 1;

--6
drop view if exists dbo.number6;
go
create view dbo.number6
as

select custid, year(orderdate) as ordersyear, count(orderid) as numberoforders
from Sales.Orders
group by custid, year(orderdate);
go

select * from dbo.number6
order by custid, ordersyear;

--7
drop view if exists dbo.number7;
go
create view dbo.number7
as

select P.productid, P.productname, P.unitprice, C.categoryname
from Production.Products as P
join Production.Categories as C
on P.categoryid = C.categoryid
go

select * from dbo.number7;