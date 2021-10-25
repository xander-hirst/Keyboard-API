DECLARE @TotalCherrySwitches INT

SELECT @TotalCherrySwitches = count([Color]) from [Cherry_Switch];

IF @TotalCherrySwitches = 0
    INSERT INTO [Cherry_Switch]
    VALUES
    ('Red', 'Linear', 45, 75),
    ('Black', 'Linear', 60, 85),
    ('Brown', 'Tactile', 55, 60),
    ('Clear', 'Tactile', 65, 95),
    ('Blue', 'Clicky', 60, 60),
    ('Green', 'Clicky', 80, 90);

ELSE PRINT N'Cherry_Switches already populated';
GO