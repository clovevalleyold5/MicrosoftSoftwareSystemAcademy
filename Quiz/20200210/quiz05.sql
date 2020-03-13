use TSQLV4;
--1
(select custid, companyname, contactname from Sales.Customers where custid in (select custid from Sales.Orders where orderdate >= '20150101' and orderdate <= '20151231')
union
select custid, companyname, contactname from Sales.Customers where custid in (select custid from Sales.Orders where orderdate >= '20160101' and orderdate <= '20161231'))
except
select custid, companyname, contactname from Sales.Customers where custid in (select custid from Sales.Orders where orderdate >= '20140101' and orderdate <= '20141231');