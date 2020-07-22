CREATE OR ALTER PROCEDURE [dbo].[OrderByMoneySpend]
AS
BEGIN
	DECLARE @employeeID INT;
	DECLARE @totalPrice INT;
	DECLARE @length INT = (SELECT COUNT(*) FROM Employee)
	
	DECLARE @i INT = 1
	WHILE(@i < @length)
	BEGIN
		SET @totalPrice = [dbo].[employee_total_moneySpend](@i);
		INSERT INTO [dbo].[EmployeeTotalAmount]([employeeID],[totalAmount])
		VALUES (@i, @totalPrice);
		SET @i = @i +1;
	END

	SELECT *
		FROM EmployeeTotalAmount
		ORDER BY totalAmount DESC
END
GO