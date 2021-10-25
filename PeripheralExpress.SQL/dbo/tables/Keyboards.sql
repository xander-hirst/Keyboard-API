CREATE TABLE [dbo].[Keyboard]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(100,1) 
    , [Name] VARCHAR(50) NOT NULL
    , [Brand_Id] INT NOT NULL
    , CONSTRAINT [FK_Brand_Id] FOREIGN KEY ([Brand_Id]) REFERENCES [Brand]([Brand_Id])
    , [Price] SMALLMONEY
    , [Description] VARCHAR(250)
    , [Release_Date] DATE
    , [Has_Backlighting] BIT NOT NULL
    , [KeyStyle_Id] INT NOT NULL
    , CONSTRAINT [FK_KeyStyle_Id] FOREIGN KEY ([KeyStyle_Id]) REFERENCES [KeyStyle]([KeyStyle_Id])
    , [KeyLayout_Id] INT NOT NULL
    , CONSTRAINT [FK_KeyLayout_Id] FOREIGN KEY ([KeyLayout_Id]) REFERENCES [KeyLayout]([KeyLayout_Id])
    , [KeyboardSize_Id] INT NOT NULL
    , CONSTRAINT [FK_KeyboardSize_Id] FOREIGN KEY ([KeyboardSize_Id]) REFERENCES [KeyboardSize]([KeyboardSize_Id])
    , [Switch_Type_Id] INT NOT NULL
    , CONSTRAINT [FK_Switch_Type_Id] FOREIGN KEY ([Switch_Type_Id]) REFERENCES [Switch_Type]([Switch_Type_Id])
    , [Cherry_Switch_Color] VARCHAR(5)
    , CONSTRAINT [FK_Cherry_Switch_Color] FOREIGN KEY ([Cherry_Switch_Color]) REFERENCES [Cherry_Switch]([Color])
    , [Connection_Type_Id] INT NOT NULL
    , CONSTRAINT [FK_Connection_Type_Id] FOREIGN KEY ([Connection_Type_Id]) REFERENCES [Connection_Type]([Connection_Type_Id])
)
GO

CREATE INDEX [IX_Keyboard_Id] ON [dbo].[Keyboard]([Id])
GO

CREATE INDEX [IX_Keyboard_Brand_Id] ON [dbo].[Keyboard]([Brand_Id])
GO

CREATE INDEX [IX_Keyboard_Price] ON [dbo].[Keyboard]([Price])
GO

CREATE INDEX [IX_Keyboard_Has_Backlighting] ON [dbo].[Keyboard]([Has_Backlighting])
GO

CREATE INDEX [IX_Keyboard_KeyStyle_Id] ON [dbo].[Keyboard]([KeyStyle_Id])
GO

CREATE INDEX [IX_Keyboard_KeyLayout_Id] ON [dbo].[Keyboard]([KeyLayout_Id])
GO

CREATE INDEX [IX_Keyboard_KeyboardSize_Id] ON [dbo].[Keyboard]([KeyboardSize_Id])
GO

CREATE INDEX [IX_Keyboard_Switch_Type_Id] ON [dbo].[Keyboard]([Switch_Type_Id])
GO

CREATE INDEX [IX_Keyboard_Cherry_Switch_Color] ON [dbo].[Keyboard]([Cherry_Switch_Color])
GO

CREATE INDEX [IX_Keyboard_Connection_Type_Id] ON [dbo].[Keyboard]([Connection_Type_Id])
GO