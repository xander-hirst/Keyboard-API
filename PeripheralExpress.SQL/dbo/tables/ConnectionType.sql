CREATE TABLE [dbo].[ConnectionType]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1)
    , [Type] VARCHAR(30) NOT NULL
    , [HasUSB] BIT NOT NULL
    , [IsWireless] BIT NOT NULL
)
GO

CREATE INDEX [IX_ConnectionType_Id] ON [dbo].[ConnectionType]([Id])
GO

CREATE INDEX [IX_ConnectionType_HasUSB] ON [dbo].[ConnectionType]([HasUSB])
GO

CREATE INDEX [IX_ConnectionType_IsWireless] ON [dbo].[ConnectionType]([IsWireless])
GO