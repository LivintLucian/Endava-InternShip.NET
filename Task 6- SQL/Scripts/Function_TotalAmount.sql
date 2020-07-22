--Function which return total amount spend by an Empl in a holiday
CREATE OR ALTER FUNCTION employee_total_moneySpend
	(
		@employeeID AS int
	)
RETURNS int 
AS
BEGIN
	RETURN
	(
		SELECT SUM(convert(numeric,Price)) 
			FROM dbo.Expenses
				WHERE EmployeeID = @employeeID
	);
END
GO