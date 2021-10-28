CREATE TABLE [dbo].[KeyLayout]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1)
	, [Style] VARCHAR(4) NOT NULL
)
GO

CREATE INDEX [IX_KeyLayout_Id] ON [dbo].[KeyLayout]([Id])
GO