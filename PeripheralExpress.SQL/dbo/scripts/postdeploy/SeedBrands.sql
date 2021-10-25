DECLARE @TotalBrands INT

SELECT @TotalBrands = count(Brand_Id) from [Brand];

IF @TotalBrands = 0
    INSERT INTO [Brand]([Name])
    VALUES
    ('Razer')
    , ('Ducky')
    , ('Cherry')
    , ('Logitech')
    , ('Apple')
    , ('Corsair')
    , ('Rosewill')
    , ('iKBC');

ELSE PRINT N'Brands already populated';
GO