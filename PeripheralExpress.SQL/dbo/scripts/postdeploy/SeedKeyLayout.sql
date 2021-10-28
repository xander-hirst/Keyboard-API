DECLARE @TotalKeyboardDesigns INT

SELECT @TotalKeyboardDesigns = count([Id]) from [KeyboardDesign];

IF @TotalKeyboardDesigns = 0
    INSERT INTO [KeyboardDesign] ([Layout])
    VALUES
    ('QWERTY'),
    ('Dvorak'),
    ('Colemak'), 
    ('QWERTY Ergonomic');

ELSE PRINT N'KeyboardDesigns already populated';
GO