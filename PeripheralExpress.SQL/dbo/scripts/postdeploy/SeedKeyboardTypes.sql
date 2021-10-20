DECLARE @TotalKeyboardTypes INT

SELECT @TotalKeyboardTypes = count(Id) from [KeyboardType];

IF @TotalKeyboardTypes = 0
    INSERT INTO [KeyboardType]([Type])
    VALUES
    ('Low Profile')
    , ('Mechanical')
    , ('Backlit')
    , ('Wireless');

ELSE PRINT N'KeyboardTypes already populated';
GO