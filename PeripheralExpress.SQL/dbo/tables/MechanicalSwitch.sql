CREATE TABLE [dbo].[MechanicalSwitch]
(
    [Color] VARCHAR(5) NOT NULL PRIMARY KEY UNIQUE
    , [Actuation_Type] VARCHAR(7) NOT NULL
    , [Actuation_Force_In_G] INT NOT NULL
    , [BottomOut_Force_In_G] INT NOT NULL
)
GO

CREATE INDEX [IX_MechanicalSwitch_Color] ON [dbo].[MechanicalSwitch] ([Color])
GO

CREATE INDEX [IX_MechanicalSwitch_Actuation_Force] ON [dbo].[MechanicalSwitch] ([Actuation_Force_In_G])
GO

CREATE INDEX [IX_MechanicalSwitch_BottomOut_Force] ON [dbo].[MechanicalSwitch] ([BottomOut_Force_In_G])
GO