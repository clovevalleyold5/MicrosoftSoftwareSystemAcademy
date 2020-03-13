select E.Region, E.FirstName + ' ' + E.LastName as EmployeeName, S.CompanyName, P.ProductName 
	from Suppliers as S
	join Products as P
		on P.SupplierID = S.SupplierID
	join [Order Details] as OD
		on OD.ProductID = P.ProductID
	join Orders as O
		on O.OrderID = OD.OrderID
	join Employees as E
		on E.EmployeeID = O.EmployeeID
where S.Country = 'Germany'
group by P.ProductName, E.Region, E.FirstName + ' ' + E.LastName, S.CompanyName
order by E.Region;