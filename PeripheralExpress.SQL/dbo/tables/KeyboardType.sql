CREATE TABLE [dbo].[KeyboardType]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1)
    , [Type] VARCHAR(50) NOT NULL
)
GO

CREATE INDEX [IX_Category_Type] ON [dbo].[KeyboardType] ([Type])
GO