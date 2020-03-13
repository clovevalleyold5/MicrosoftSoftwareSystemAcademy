.echo on
.headers on

--Name: Kaiyuan Wang
--File: Character and Date Functions
--Date: 20200127

--1
select contactname || "
" || companyname || "
" || address || "
" || city || " " || region || " " || postalcode || " " || country || "
" || "
" from customers;

--2
select substr(contactname, instr(contactname, " ") + 1) || ", " || substr (contactname, 1, instr(contactname, " ")) || " " || companyname || " " || phone || "
" from customers;

--3
select orderid, orderdate, shippeddate, julianday(shippeddate) - julianday(orderdate) as delayday from orders;

--4
select date("2020-01-27") - date("1990-01-20"), (julianday("2020-01-27") - julianday("1990-01-20"))%365;