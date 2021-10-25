DECLARE @TotalKeyStyles INT

SELECT @TotalKeyStyles = count([KeyStyle_Id]) from [KeyStyle];

IF @TotalKeyStyles = 0
    INSERT INTO [KeyStyle] ([Style])
    VALUES
    ('ANSI'),
    ('ISO');

ELSE PRINT N'KeyStyles already populated';
GO