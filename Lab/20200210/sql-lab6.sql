--Name: Kaiyuan Wang
--File: sql-lab6.sql
--Date: 20200210

use TSQLV4;

--1
select custid, empid from Sales.Orders where orderdate >= '20160101' and orderdate < '20160201'
except				 
select custid, empid from Sales.Orders where orderdate >= '20160201' and orderdate < '20160229';

--2
select custid, empid from Sales.Orders where orderdate >= '20160101' and orderdate < '20160201'
intersect				 
select custid, empid from Sales.Orders where orderdate >= '20160201' and orderdate < '20160229';

--3
(select custid, empid from Sales.Orders where orderdate >= '20160101' and orderdate < '20160201'
union				 
select custid, empid from Sales.Orders where orderdate >= '20160201' and orderdate < '20160229')
except
(select custid, empid from Sales.Orders where orderdate >= '20160101' and orderdate < '20160201'
intersect				 
select custid, empid from Sales.Orders where orderdate >= '20160201' and orderdate < '20160229');

--5
(select custid, empid from Sales.Orders where orderdate >= '20160101' and orderdate < '20160201'
intersect				 
select custid, empid from Sales.Orders where orderdate >= '20160201' and orderdate < '20160229')
except
(select custid, empid from Sales.Orders where orderdate >= '20150131' and orderdate <= '20151231')