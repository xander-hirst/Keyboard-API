DECLARE @TotalSwitchTypes INT

SELECT @TotalSwitchTypes = count([Switch_Type_Id]) from [Switch_Type];

IF @TotalSwitchTypes = 0
    INSERT INTO [Switch_Type] ([Type])
    VALUES
    ('Cherry MX'),
    ('Rubber Dome'),
    ('Buckling Spring');

ELSE PRINT N'SwitchTypes already populated';
GO