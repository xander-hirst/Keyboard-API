CREATE TABLE [dbo].[KeyboardSize]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1)
	, [Size] VARCHAR(10) NOT NULL
	, [NumKeys] INT NOT NULL
)
GO

CREATE INDEX [IX_KeyboardSize_Id] ON [dbo].[KeyboardSize]([Id])
GO
