.echo on
.header on

--Name: Kaiyuan Wang
--File: sql-lab2c.sql
--Date: 20200127

--1
select employeeid, count(orderid) as orderamount from orders group by employeeid order by orderamount desc;

--2
select avg(discount) as avgdiscount, productid, unitprice from order_details where unitprice > 50 group by unitprice order by unitprice desc;

--3
select shipperid, shipcountry, shipname, count(orderid) as ordernumber from orders group by shipcountry having count(orderid) > 10 order by ordernumber;

--4
select orderid, shippeddate, orderdate, julianday(shippeddate) - julianday(orderdate) as lagdays from orders order by lagdays;

--5
select shipperid, shippeddate, orderdate, avg(julianday(shippeddate) - julianday(orderdate)) as avglagdays from orders group by shipperid order by avglagdays;

--6
select productid, productname, unitprice*unitsinstock as totalprice from products group by productname;

--7
select sum(unitprice*unitsinstock) as dollartotal from products;

--8
select orderid, customerid, employeeid, count(orderid) as numberordered from orders group by employeeid, customerid having numberordered > 4 order by orderid;

--9
select julianday('2019-04-09') - julianday('2014-04-10');

--10
select date('now');
select date('now', 'start of month');
select date('now', 'start of month','+1 month');
select date('now', 'start of month','+1 month','-1 day');