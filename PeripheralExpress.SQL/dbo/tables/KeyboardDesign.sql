CREATE TABLE [dbo].[KeyboardDesign]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1)
	, [Layout] VARCHAR(20) NOT NULL
)
GO

CREATE INDEX [IX_KeyboardDesign_Id] ON [dbo].[KeyboardDesign]([Id])
GO
