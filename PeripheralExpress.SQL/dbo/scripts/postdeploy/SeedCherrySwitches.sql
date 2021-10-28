DECLARE @TotalMechanicalSwitches INT

SELECT @TotalMechanicalSwitches = count([Color]) from [MechanicalSwitch];

IF @TotalMechanicalSwitches = 0
    INSERT INTO [MechanicalSwitch]
    VALUES
    ('Red', 'Linear', 45, 75),
    ('Black', 'Linear', 60, 85),
    ('Brown', 'Tactile', 55, 60),
    ('Clear', 'Tactile', 65, 95),
    ('Blue', 'Clicky', 60, 60),
    ('Green', 'Clicky', 80, 90);

ELSE PRINT N'MechanicalSwitch already populated';
GO