DELETE Expenses;

--Populate column MoneySpend FROM the Holiday Table.
UPDATE dbo.Holiday
	SET MoneySpend = ROUND( 100*RAND(convert(varbinary, newid())), 0)
	WHERE MoneySpend is NOT NULL;

--Populate the Expenses Table.
INSERT INTO dbo.Expenses
	SELECT HolidayID, EmployeeID, MoneySpend
	FROM dbo.Holiday;

--Call the function
SELECT [dbo].[employee_total_moneySpend] (1)

