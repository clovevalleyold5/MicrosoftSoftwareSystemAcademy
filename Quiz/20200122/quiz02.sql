.echo on
.headers on

-- Name: Kaiyuan Wang
-- File: quiz02
-- Date: 20200122

--1
select companyname, contactname, country from customers where country like "%Poland%";

--2
select orderid, orderdate, shipcity from orders where shipcity like "berlin";

--3
select productname, unitsinstock from products where productname like "%filo%";

--4
select companyname, phone from shippers;

--5
select firstname, lastname, birthdate from employees order by birthdate limit 1;
select firstname, lastname, birthdate from employees order by birthdate desc limit 1;

--6
select companyname, contactname, contacttitle from suppliers where contacttitle like "%owner%";