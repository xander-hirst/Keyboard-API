DECLARE @TotalKeyLayouts INT

SELECT @TotalKeyLayouts = count([KeyLayout_Id]) from [KeyLayout];

IF @TotalKeyLayouts = 0
    INSERT INTO [KeyLayout] ([Layout])
    VALUES
    ('QWERTY'),
    ('Dvorak'),
    ('Colemak'), 
    ('QWERTY Ergonomic');

ELSE PRINT N'KeyLayouts already populated';
GO