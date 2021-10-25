CREATE TABLE [dbo].[Connection_Type]
(
    [Connection_Type_Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1)
    , [Type] VARCHAR(30) NOT NULL
    , [HasUSB] BIT NOT NULL
    , [IsWireless] BIT NOT NULL
)
GO

CREATE INDEX [IX_Connection_Type_Id] ON [dbo].[Connection_Type]([Connection_Type_Id])
GO

CREATE INDEX [IX_Connection_Type_HasUSB] ON [dbo].[Connection_Type]([HasUSB])
GO

CREATE INDEX [IX_Connection_Type_IsWireless] ON [dbo].[Connection_Type]([IsWireless])
GO