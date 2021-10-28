DECLARE @TotalConnectionTypes INT

SELECT @TotalConnectionTypes = count([Id]) from [ConnectionType];

IF @TotalConnectionTypes = 0
    INSERT INTO [ConnectionType] ([Type], [HasUSB], [IsWireless])
    VALUES
    ('Wired', 1, 0),
    ('Wireless Dongle', 1, 1),
    ('Bluetooth', 0, 1);

ELSE PRINT N'ConnectionTypes already populated';
GO