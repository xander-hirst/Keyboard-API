CREATE TABLE [dbo].[Brand]
(
	[Brand_Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1)
	, [Name] VARCHAR(50) NOT NULL
)
GO

CREATE INDEX [IX_Brand_Id] ON [dbo].[Brand]([Brand_Id])
GO
