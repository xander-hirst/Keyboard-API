DECLARE @TotalConnectionTypes INT

SELECT @TotalConnectionTypes = count([Connection_Type_Id]) from [Connection_Type];

IF @TotalConnectionTypes = 0
    INSERT INTO [Connection_Type] ([Type], [HasUSB], [IsWireless])
    VALUES
    ('Wired', 1, 0),
    ('Wireless Dongle', 1, 1),
    ('Bluetooth', 0, 1);

ELSE PRINT N'Connection_Types already populated';
GO