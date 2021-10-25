DECLARE @TotalKeyboardSize INT

SELECT @TotalKeyboardSize = count([KeyboardSize_Id]) from [KeyboardSize];

IF @TotalKeyboardSize = 0
    INSERT INTO [KeyboardSize] ([Size], [NumKeys])
    VALUES
    ('Full-Sized', 104),
    ('Tenkeyless', 87),
    ('60%', 68);

ELSE PRINT N'KeyboardSizes already populated';
GO