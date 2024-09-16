alter PROCEDURE ASSIGNMENT2
AS
BEGIN
SELECT * FROM Products1;
END;

EXEC ASSIGNMENT2

ALTER  PROCEDURE  ASSIGNMENT_2
AS
BEGIN

DECLARE cursor_pro CURSOR
FOR SELECT ProductName, SUM(UnitPrice*Quantity) As TotalAmount FROM  Products1 GROUP BY ProductName;
DECLARE @ProductName VARCHAR(MAX),  @TotalAmount   DECIMAL(10,2),  @GrandTotal   DECIMAL(10,2),@Amount DECIMAL(10,2) ;
SELECT @GrandTotal=0.00;
OPEN cursor_pro;
FETCH NEXT FROM cursor_pro INTO @ProductName, @TotalAmount;

WHILE @@FETCH_STATUS = 0
    BEGIN
        PRINT @ProductName + ' - ' +  CAST(@TotalAmount AS varchar);
		SELECT @GrandTotal=@GrandTotal+@TotalAmount;
        FETCH NEXT FROM cursor_pro INTO @ProductName, @TotalAmount;
    END;
 PRINT 'GrandTotal' + ' - ' +  CAST(@GrandTotal AS varchar);
	CLOSE cursor_pro;
deallocate cursor_pro;
END;

EXEC ASSIGNMENT_2;