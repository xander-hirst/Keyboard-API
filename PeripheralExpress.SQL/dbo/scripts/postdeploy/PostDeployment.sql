PRINT N'Populating all of the lookup tables.';
:r .\SeedBrands.sql
GO

:r .\SeedCherrySwitches.sql
GO

:r .\SeedConnectionTypes.sql
GO

:r .\SeedKeyboardSize.sql
GO

:r .\SeedKeyLayout.sql
GO

:r .\SeedKeyStyles.sql
GO

:r .\SeedSwitchTypes.sql
GO

PRINT N'Finished populating all of the lookup tables.';