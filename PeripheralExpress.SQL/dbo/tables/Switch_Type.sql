CREATE TABLE [dbo].[Switch_Type]
(
	[Switch_Type_Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1)
	, [Type] VARCHAR(20) NOT NULL
)
GO

CREATE INDEX [IX_Switch_Type_Id] ON [dbo].[Switch_Type]([Switch_Type_Id])
GO
