CREATE TABLE [dbo].[KeyStyle]
(
	[KeyStyle_Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1)
	, [Style] VARCHAR(4) NOT NULL
)
GO

CREATE INDEX [IX_KeyStyle_Id] ON [dbo].[KeyStyle]([KeyStyle_Id])
GO