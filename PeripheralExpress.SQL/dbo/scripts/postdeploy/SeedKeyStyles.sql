DECLARE @TotalKeyLayouts INT

SELECT @TotalKeyLayouts = count(Id) from [KeyLayout];

IF @TotalKeyLayouts = 0
    INSERT INTO [KeyLayout] ([Style])
    VALUES
    ('ANSI'),
    ('ISO');

ELSE PRINT N'KeyStyles already populated';
GO