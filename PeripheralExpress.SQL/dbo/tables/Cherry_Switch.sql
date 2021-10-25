CREATE TABLE [dbo].[Cherry_Switch]
(
    [Color] VARCHAR(5) NOT NULL PRIMARY KEY UNIQUE
    , [Actuatuation_Type] VARCHAR(7) NOT NULL
    , [Actuation_Force_In_G] INT NOT NULL
    , [BottomOut_Force_In_G] INT NOT NULL
)
GO

CREATE INDEX [IX_Cherry_Switch_Color] ON [dbo].[Cherry_Switch] ([Color])
GO

CREATE INDEX [IX_Cherry_Switch_Actuation_Force] ON [dbo].[Cherry_Switch] ([Actuation_Force_In_G])
GO

CREATE INDEX [IX_Cherry_Switch_BottomOut_Force] ON [dbo].[Cherry_Switch] ([BottomOut_Force_In_G])
GO