CREATE TABLE [dbo].[Keyboard]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(100,1)
    , [Description] varchar(500) NOT NULL
    , [Name] INT NOT NULL
    , IsRefurbished BIT NOT NULL
    , DateReleased INT NOT NULL
    , Price DECIMAL NOT NULL
    , [Type] INT NOT NULL
    , CONSTRAINT [FK_Keyboard_Type] FOREIGN KEY ([Type]) REFERENCES [KeyboardType]([Id])
)
GO

CREATE INDEX [IX_Keyboard_Name] ON [dbo].[Keyboard] ([Name])
GO

CREATE INDEX [IX_Keyboard_DateReleased] ON [dbo].[Keyboard] ([DateReleased])
GO

CREATE INDEX [IX_Keyboard_Price] ON [dbo].[Keyboard] (Price)
GO

CREATE INDEX [IX_Keyboard_Type] ON [dbo].[Keyboard] ([Type])
GO