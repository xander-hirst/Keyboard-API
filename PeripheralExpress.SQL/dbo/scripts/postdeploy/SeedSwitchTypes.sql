DECLARE @TotalSwitchMechanisms INT

SELECT @TotalSwitchMechanisms = count([Id]) from [SwitchMechanism];

IF @TotalSwitchMechanisms = 0
    INSERT INTO [SwitchMechanism] ([Mechanism])
    VALUES
    ('Cherry MX'),
    ('Rubber Dome'),
    ('Buckling Spring');

ELSE PRINT N'SwitchMechanism already populated';
GO