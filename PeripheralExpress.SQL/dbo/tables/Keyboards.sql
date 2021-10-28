CREATE TABLE [dbo].[Keyboard]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(100,1) 
    , [Name] VARCHAR(50) NOT NULL
    , [Brand_Id] INT NOT NULL
    , CONSTRAINT [FK_Brand_Id] FOREIGN KEY ([Brand_Id]) REFERENCES [Brand]([Id])
    , [Price] SMALLMONEY
    , [Description] VARCHAR(250)
    , [Release_Date] DATE
    , [Has_Backlighting] BIT NOT NULL
    , [KeyLayout_Id] INT NOT NULL
    , CONSTRAINT [FK_KeyLayout_Id] FOREIGN KEY ([KeyLayout_Id]) REFERENCES [KeyLayout]([Id])
    , [KeyboardDesign_Id] INT NOT NULL
    , CONSTRAINT [FK_KeyboardDesign_Id] FOREIGN KEY ([KeyboardDesign_Id]) REFERENCES [KeyboardDesign]([Id])
    , [KeyboardSize_Id] INT NOT NULL
    , CONSTRAINT [FK_KeyboardSize_Id] FOREIGN KEY ([KeyboardSize_Id]) REFERENCES [KeyboardSize]([Id])
    , [SwitchMechanism_Id] INT NOT NULL
    , CONSTRAINT [FK_SwitchMechanism_Id] FOREIGN KEY ([SwitchMechanism_Id]) REFERENCES [SwitchMechanism]([Id])
    , [MechanicalSwitch_Color] VARCHAR(5)
    , CONSTRAINT [FK_MechanicalSwitch_Color] FOREIGN KEY ([MechanicalSwitch_Color]) REFERENCES [MechanicalSwitch]([Color])
    , [ConnectionType_Id] INT NOT NULL
    , CONSTRAINT [FK_ConnectionType_Id] FOREIGN KEY ([ConnectionType_Id]) REFERENCES [ConnectionType]([Id])
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

CREATE INDEX [IX_Keyboard_KeyLayout_Id] ON [dbo].[Keyboard]([KeyLayout_Id])
GO

CREATE INDEX [IX_Keyboard_KeyboardDesign_Id] ON [dbo].[Keyboard]([KeyboardDesign_Id])
GO

CREATE INDEX [IX_Keyboard_KeyboardSize_Id] ON [dbo].[Keyboard]([KeyboardSize_Id])
GO

CREATE INDEX [IX_Keyboard_SwitchMechanism_Id] ON [dbo].[Keyboard]([SwitchMechanism_Id])
GO

CREATE INDEX [IX_Keyboard_MechanicalSwitch_Color] ON [dbo].[Keyboard]([MechanicalSwitch_Color])
GO

CREATE INDEX [IX_Keyboard_ConnectionType_Id] ON [dbo].[Keyboard]([ConnectionType_Id])
GO