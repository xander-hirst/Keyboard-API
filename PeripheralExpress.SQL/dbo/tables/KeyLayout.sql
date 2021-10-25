CREATE TABLE [dbo].[KeyLayout]
(
	[KeyLayout_Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1)
	, [Layout] VARCHAR(20) NOT NULL
)
GO

CREATE INDEX [IX_KeyLayout_Id] ON [dbo].[KeyLayout]([KeyLayout_Id])
GO
