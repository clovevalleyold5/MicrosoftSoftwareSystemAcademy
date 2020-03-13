--1
select E.EmployeeID, E.FirstName, E.LastName, (sum(OD.UnitPrice * OD.Quantity)/ count(OD.OrderID)) as average_sale
from Employees as E
join Orders as O
	on E.EmployeeID = O.EmployeeID
join [Order Details] as OD
	on OD.OrderID = O.OrderID
group by E.EmployeeID, E.FirstName, E.LastName
order by average_sale desc;

--2
select P.CategoryID, C.CategoryName, avg(P.UnitPrice) as average_price
from Categories as C
join Products as P
	on P.CategoryID = C.CategoryID
group by P.CategoryID, C.CategoryName;

--3
select C.ContactName as customer, S.ContactName as supplier, E.FirstName + ' ' + E.LastName as employee, E.City from Suppliers as S
	join Employees as E
	on E.City = S.City
	join Customers as C
	on C.City = S.City
group by C.ContactName, S.ContactName, E.FirstName + ' ' + E.LastName, E.City
order by C.ContactName desc;