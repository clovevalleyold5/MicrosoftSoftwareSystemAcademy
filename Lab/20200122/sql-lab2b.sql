.echo on
.headers on

--Name: Kaiyuan Wang
--File: sql-lab2b.sql
--Date: 20200122

--1
select customerid, companyname, country from customers where country in ("Canada", "USA", "Mexico");

--2
select orderid, orderdate from orders where orderdate like "1998-04%";

--3
select productname from products where productname like "%sauce%";

--4
select distinct productname from products where productname like "%dr%";

--5
select employeeid, shippeddate, shipcountry from orders where shipcountry like "germany" and shippeddate like "%-12-%";

--6
select productid, unitprice * quantity as totalprice, discount, unitprice * (1 - discount) * quantity as netprice from order_details where productid = 19 and discount > 0;

--7
select titleofcourtesy || " " || firstname || " " || lastname || "
" || title || "
" from employees;

--8
select companyname, substr(contactname, 1, instr(contactname, " ")) as firstname from customers order by companyname;

--9
select substr(contactname, instr(contactname, " ") + 1) as lastname, substr(contactname, 1, instr(contactname, " ")) as firstname from customers order by lastname;